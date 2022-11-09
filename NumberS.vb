Class Numbering
    Public MyControls(,) As Control
    Public PattenNumber As String
    Public NumberArray(,) As OneCell
    Friend MySize As Byte
    Friend AbleHorizontalB() As Boolean
    Friend AbleVerticalB() As Boolean
    Friend AbleDiagonalB(1) As Boolean
    Private AbleLSquare(,) As CPosition
    Private Cut_InValueDate, Cut_Line, Cut_Horizontal, Cut_Vertical As Integer

#Region "퍼즐 초기화"
    Sub New(ByVal PuzzleSize As Byte, ByVal AbleLine() As Boolean, ByVal PSquare(,) As CPosition)
        MySize = PuzzleSize
        ReDim AbleHorizontalB(PuzzleSize - 1)
        ReDim AbleVerticalB(PuzzleSize - 1)
        For i As Integer = 0 To PuzzleSize - 1
            AbleHorizontalB(i) = AbleLine(i)
        Next
        For i As Integer = 0 To PuzzleSize - 1
            AbleVerticalB(i) = AbleLine(i + MySize)
        Next
        AbleDiagonalB(0) = AbleLine(AbleLine.Length - 2)
        AbleDiagonalB(1) = AbleLine(AbleLine.Length - 1)
        ReDim NumberArray(PuzzleSize - 1, PuzzleSize - 1)
        For i As Byte = 0 To PuzzleSize - 1
            For t As Byte = 0 To PuzzleSize - 1
                NumberArray(i, t) = New OneCell(PuzzleSize)
                If AbleHorizontalB(t) = True Then
                    NumberArray(i, t).AbleX = t + 1
                End If
                If AbleVerticalB(i) = True Then
                    NumberArray(i, t).AbleY = i + 1
                End If
                If i = t And AbleDiagonalB(0) = True Then
                    NumberArray(i, t).AbleOneDiagonal = True
                End If
                If i + t = MySize - 1 And AbleDiagonalB(1) = True Then
                    NumberArray(i, t).AbleTwoDiagonal = True
                End If
            Next
        Next
        For i As Integer = 0 To PSquare.GetLength(0) - 1
            For k As Integer = 0 To PuzzleSize - 1
                NumberArray(PSquare(i, k).Y - 1, PSquare(i, k).X - 1).InSquare = i + 1
            Next
        Next
        ReDim AbleLSquare(MySize * 3 + 1, MySize - 1)
        Dim Count As Integer = 0
        For i As Integer = 0 To PuzzleSize - 1
            If AbleHorizontalB(i) = True Then
                For k As Integer = 0 To PuzzleSize - 1
                    AbleLSquare(Count, k) = New CPosition(k + 1, i + 1)
                Next
                Count += 1
            End If
        Next
        Cut_Horizontal = Count - 1
        For i As Integer = 0 To PuzzleSize - 1
            If AbleVerticalB(i) = True Then
                For k As Integer = 0 To PuzzleSize - 1
                    AbleLSquare(Count, k) = New CPosition(i + 1, k + 1)
                Next
                Count += 1
            End If
        Next
        Cut_Vertical = Count - 1
        If AbleDiagonalB(0) = True Then
            For i As Integer = 0 To PuzzleSize - 1
                AbleLSquare(Count, i) = New CPosition(i + 1, i + 1)
            Next
            Count += 1
        End If
        If AbleDiagonalB(1) = True Then
            For i As Integer = 0 To PuzzleSize - 1
                AbleLSquare(Count, i) = New CPosition(MySize - i, i + 1)
            Next
            Count += 1
        End If
        Cut_Line = Count - 1
        For i As Integer = 0 To PSquare.GetLength(0) - 1
            For k As Integer = 0 To MySize - 1
                AbleLSquare(Count, k) = PSquare(i, k)
            Next
            Count += 1
        Next
        Cut_InValueDate = Count - 1
    End Sub
#End Region

#Region "그림 그리기"

    Public Sub BoardDrawing_ForMakePatten(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim BigPen As New Pen(Brushes.Black, 5)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Dim ControlSize As Integer = MyControls(0, 0).Size.Height
        For i As Integer = 0 To MySize - 1
            For k As Integer = 0 To MySize - 2
                If NumberArray(i, k).InSquare <> NumberArray(i, k + 1).InSquare Then
                    e.Graphics.DrawLine(BigPen, New Point(MyControls(i, k + 1).Location.X - 3, MyControls(i, k + 1).Location.Y - 4),
                    New Point(MyControls(i, k + 1).Location.X - 3, MyControls(i, k + 1).Location.Y + ControlSize + 4))
                End If
            Next
        Next
        For k As Integer = 0 To MySize - 1
            For i As Integer = 0 To MySize - 2
                If NumberArray(i, k).InSquare <> NumberArray(i + 1, k).InSquare Then
                    e.Graphics.DrawLine(BigPen, New Point(MyControls(i + 1, k).Location.X - 4, MyControls(i + 1, k).Location.Y - 2),
    New Point(MyControls(i + 1, k).Location.X + 4 + ControlSize, MyControls(i + 1, k).Location.Y - 2))
                End If
            Next
        Next
        e.Graphics.DrawLine(BigPen, New Point(MyControls(0, 0).Location.X - 4, MyControls(0, 0).Location.Y - 2),
                            New Point(MyControls(0, MySize - 1).Location.X + 4 + ControlSize, MyControls(0, MySize - 1).Location.Y - 2))
        e.Graphics.DrawLine(BigPen, New Point(MyControls(0, 0).Location.X - 3, MyControls(0, 0).Location.Y - 4),
                    New Point(MyControls(MySize - 1, 0).Location.X - 3, MyControls(MySize - 1, 0).Location.Y + ControlSize))
        e.Graphics.DrawLine(BigPen, New Point(MyControls(0, MySize - 1).Location.X + ControlSize + 2, MyControls(0, MySize - 1).Location.Y),
                    New Point(MyControls(MySize - 1, MySize - 1).Location.X + ControlSize + 2, MyControls(MySize - 1, MySize - 1).Location.Y + ControlSize))
        e.Graphics.DrawLine(BigPen, New Point(MyControls(MySize - 1, 0).Location.X - 5, MyControls(MySize - 1, 0).Location.Y + ControlSize + 2),
            New Point(MyControls(MySize - 1, MySize - 1).Location.X + 4 + ControlSize, MyControls(MySize - 1, MySize - 1).Location.Y + ControlSize + 2))
    End Sub

    Public Sub BoardDrawing_DrawSmallPen(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim BigPen As New Pen(Brushes.Black, 5)
        Dim SmallPen As New Pen(Brushes.LightGray, 3)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        Dim ControlSize As Integer = MyControls(0, 0).Size.Height
        For i As Integer = 0 To MySize - 1
            For k As Integer = 0 To MySize - 2
                If NumberArray(i, k).InSquare = NumberArray(i, k + 1).InSquare Then
                    e.Graphics.DrawLine(SmallPen, New Point(MyControls(i, k + 1).Location.X - 3, MyControls(i, k + 1).Location.Y - 2),
New Point(MyControls(i, k + 1).Location.X - 3, MyControls(i, k + 1).Location.Y + ControlSize + 2))
                Else
                    e.Graphics.DrawLine(BigPen, New Point(MyControls(i, k + 1).Location.X - 3, MyControls(i, k + 1).Location.Y - 2),
New Point(MyControls(i, k + 1).Location.X - 3, MyControls(i, k + 1).Location.Y + ControlSize + 2))
                End If
            Next
        Next
        For k As Integer = 0 To MySize - 1
            For i As Integer = 0 To MySize - 2
                If NumberArray(i, k).InSquare = NumberArray(i + 1, k).InSquare Then
                    e.Graphics.DrawLine(SmallPen, New Point(MyControls(i + 1, k).Location.X - 1, MyControls(i + 1, k).Location.Y - 2),
New Point(MyControls(i + 1, k).Location.X + ControlSize + 1, MyControls(i + 1, k).Location.Y - 2))
                Else
                    e.Graphics.DrawLine(BigPen, New Point(MyControls(i + 1, k).Location.X - 1, MyControls(i + 1, k).Location.Y - 2),
New Point(MyControls(i + 1, k).Location.X + ControlSize + 1, MyControls(i + 1, k).Location.Y - 2))
                End If
            Next
        Next
        e.Graphics.DrawLine(BigPen, New Point(MyControls(0, 0).Location.X - 4, MyControls(0, 0).Location.Y - 2),
                            New Point(MyControls(0, MySize - 1).Location.X + 4 + ControlSize, MyControls(0, MySize - 1).Location.Y - 2))
        e.Graphics.DrawLine(BigPen, New Point(MyControls(0, 0).Location.X - 3, MyControls(0, 0).Location.Y - 4),
                    New Point(MyControls(MySize - 1, 0).Location.X - 3, MyControls(MySize - 1, 0).Location.Y + ControlSize))
        e.Graphics.DrawLine(BigPen, New Point(MyControls(0, MySize - 1).Location.X + ControlSize + 2, MyControls(0, MySize - 1).Location.Y),
                    New Point(MyControls(MySize - 1, MySize - 1).Location.X + ControlSize + 2, MyControls(MySize - 1, MySize - 1).Location.Y + ControlSize))
        e.Graphics.DrawLine(BigPen, New Point(MyControls(MySize - 1, 0).Location.X - 5, MyControls(MySize - 1, 0).Location.Y + ControlSize + 2),
            New Point(MyControls(MySize - 1, MySize - 1).Location.X + 4 + ControlSize, MyControls(MySize - 1, MySize - 1).Location.Y + ControlSize + 2))
    End Sub

    Public Function RealSize(ByVal Size As Size, Location As Size, ByVal PuzzleSize As Byte) As Integer
        Dim OnSize As Integer = Size.Height - Location.Height - 50
        OnSize -= 3 * (PuzzleSize - 1)
        Dim OtherSize As Integer = Size.Width - Location.Width - 25
        OtherSize -= 3 * (PuzzleSize - 1)
        If OnSize < OtherSize Then
            Return OnSize
        Else
            Return OtherSize
        End If
    End Function

    Public Function FontSize(ByVal Size As Integer) As Integer
        Return Size / 2 + 6
    End Function

    Enum ColorStore
        SelectArea
        NonSelect
        CanSelect
        NoEnable
        OnlyValue
    End Enum

    Public Function ColorReturn(ByVal Val As ColorStore) As System.Drawing.Color
        Select Case Val
            Case ColorStore.SelectArea
                Return System.Drawing.Color.FromArgb(100, 155, 100)
            Case ColorStore.NonSelect
                Return System.Drawing.Color.FromArgb(192, 255, 192)
            Case ColorStore.CanSelect
                Return System.Drawing.Color.FromArgb(255, 255, 255)
            Case ColorStore.NoEnable
                Return System.Drawing.Color.FromArgb(150, 150, 150)
            Case ColorStore.OnlyValue
                Return Color.YellowGreen
        End Select
    End Function
#End Region

    Private Function AllFinder_AbleLineToInSquare(ByVal AbleLineN As Integer) As Integer
        Return AbleLineN - Cut_Line
    End Function

    Private Function AllFinder_InSquareToAbleLine(ByVal SquareS As Integer) As Integer
        Return SquareS + Cut_Line
    End Function

#Region "Naked Single Arrange / Naked Finder / Hidden Finder"

    Public Function NakedSingleArrange()
        Dim Out() As PassNum
        For i As Integer = 0 To MySize - 1
            For k As Integer = 0 To MySize - 1
                If NumberArray(i, k).Memo_Auto.CountTrueV = 1 Then
                    Out = NakedSingleArrange_PassNum(New CPosition(i + 1, k + 1))
                    If Not Out Is Nothing Then Return Out
                End If
            Next
        Next
        Return Nothing
    End Function

    Private Function NakedSingleArrange_PassNum(ByVal CP As CPosition) As PassNum()
        Dim Out(0) As PassNum
        Dim FMemo As Byte = NumberArray(CP.Y - 1, CP.X - 1).Memo_Auto.CanSelect(0)
        Dim Count As Integer
        For i As Integer = 0 To MySize - 1
            For k As Integer = 0 To MySize - 1
                If NumberArray(i, k).Memo_Auto(FMemo) = True And DirectConnect(CP, New CPosition(i + 1, k + 1)) = True Then
                    If i <> CP.Y - 1 Or k <> CP.X - 1 Then
                        ReDim Preserve Out(Out.Length)
                        Out(Count) = New PassNum(i + 1, k + 1, FMemo)
                        Count += 1
                    End If
                End If
            Next
        Next
        If Count <> 0 Then
            ReDim Preserve Out(Out.Length - 2)
            Return Out
        Else
            Return Nothing
        End If
    End Function

    Public Function NakedFinder(ByVal SelectN As Byte) As PassNum()
        Dim TNB As TheNext
        Dim SearchL() As CPosition
        Dim FindMemoColl As NumMemo
        Dim MemoFinding() As PassNum
        For m As Integer = 0 To Cut_InValueDate
            SearchL = NakedFinder_SCellList(m, SelectN)
            If Not SearchL Is Nothing Then
                TNB = New TheNext(0, SearchL.Length - 1, SelectN)
                For i As Integer = 1 To TNB.PossibleCount
                    FindMemoColl = NakedFinder_IsNaked(TNB, SearchL)
                    If FindMemoColl.CountTrueV = SelectN Then
                        MemoFinding = NakedFinder_MemoFinder(m, SearchL, TNB, FindMemoColl)
                        If Not MemoFinding Is Nothing Then Return MemoFinding
                    End If
                    TNB.TNext()
                Next
            End If
        Next
        Return Nothing
    End Function

    Private Function NakedFinder_SCellList(ByVal LineNumber As Integer, ByVal SelectN As Byte) As CPosition()
        Dim FOut(0) As CPosition
        Dim Count As Integer = 0
        Dim CTV As Integer
        For i As Integer = 0 To MySize - 1
            CTV = NumberArray(AbleLSquare(LineNumber, i).Y - 1, AbleLSquare(LineNumber, i).X - 1).Memo_Auto.CountTrueV
            If CTV <= SelectN And CTV > 1 Then
                ReDim Preserve FOut(FOut.Length)
                FOut(Count) = New CPosition(AbleLSquare(LineNumber, i).Y, AbleLSquare(LineNumber, i).X)
                Count += 1
            End If
        Next
        If Count < SelectN Then
            Return Nothing
        Else
            ReDim Preserve FOut(FOut.Length - 2)
            Return FOut
        End If
    End Function

    Private Function NakedFinder_IsNaked(ByVal TNB As TheNext, ByVal SearchL() As CPosition) As NumMemo
        Dim MemoL As New NumMemo(MySize)
        MemoL.AllFalse()
        For i As Integer = 0 To TNB.SelectN - 1
            For k As Integer = 1 To MySize
                MemoL(k) = NumberArray(SearchL(TNB(i)).Y - 1, SearchL(TNB(i)).X - 1).Memo_Auto(k) Or MemoL(k)
            Next
        Next
        Return MemoL
    End Function

    Private Function NakedFinder_MemoFinder(ByVal AbleLine As Integer, ByVal SearchL() As CPosition, ByVal Exclude As TheNext, ByVal SearchWhat As NumMemo) As PassNum()
        Dim PassNumB() As PassNum = Nothing
        Dim CountingEx As Integer = 0
        Dim ItsEx As Boolean
        Dim ExV() As Byte = NakedFinder_ExcludeB(AbleLine, SearchL, Exclude)
        For i As Integer = 0 To MySize - 1
            If CountingEx < ExV.Length Then
                If i = ExV(CountingEx) Then
                    CountingEx += 1
                    ItsEx = True
                End If
            End If
            If ItsEx = False Then
                PassNumB = Array_StructureArrayAdding(PassNumB, NakedFinder_MemoFinder_IsItH(AbleLSquare(AbleLine, i), SearchWhat))
            Else
                ItsEx = False
            End If
        Next
        Return PassNumB
    End Function

    Private Function NakedFinder_ExcludeB(ByVal AbleLine As Integer, ByVal SearchL() As CPosition, ByVal Ex As TheNext) As Byte()
        Dim Out(Ex.SelectN - 1) As Byte
        Dim ExCount As Integer = 0
        For i As Integer = 0 To MySize - 1
            If AbleLSquare(AbleLine, i).Y = SearchL(Ex(ExCount)).Y And AbleLSquare(AbleLine, i).X = SearchL(Ex(ExCount)).X Then
                Out(ExCount) = i
                ExCount += 1
            End If
        Next
        Return Out
    End Function

    Private Function NakedFinder_MemoFinder_IsItH(ByVal IsIt As CPosition, ByVal SearchWhat As NumMemo) As PassNum()
        Dim Out(0) As PassNum
        Dim Count As Integer
        For i As Integer = 1 To MySize
            If NumberArray(IsIt.Y - 1, IsIt.X - 1).Memo_Auto(i) = True And SearchWhat(i) = True Then
                ReDim Preserve Out(Out.Length)
                Out(Count) = New PassNum(IsIt.Y, IsIt.X, i)
                Count += 1
            End If
        Next
        If Count <> 0 Then
            ReDim Preserve Out(Out.Length - 2)
            Return Out
        Else
            Return Nothing
        End If
    End Function

    Public Function HiddenFinder(ByVal SelectN As Byte) As PassNum()
        Return NakedFinder(MySize - SelectN)
    End Function

#End Region

#Region "Block and Column / Row Interactions"

    Public Function BCRInteraction() As PassNum()
        Dim InAbleV() As Byte
        Dim OutPosition() As CPosition
        Dim PassNumD() As PassNum
        Dim LineP As BCRInteraction_LineM
        For m As Integer = Cut_Line + 1 To Cut_InValueDate
            InAbleV = BCRInteraction_InSquareH(m).CanSelect
            For k As Integer = 0 To InAbleV.Length - 1
                OutPosition = BCRInteraction_OutPosition(m, InAbleV(k))
                LineP = BCRInteraction_IsItBLR(OutPosition)
                If LineP <> BCRInteraction_LineM.TFalse Then
                    PassNumD = BCRInteraction_MemoFinding(OutPosition(0), InAbleV(k), m, LineP)
                    If Not PassNumD Is Nothing Then Return PassNumD
                End If
            Next
        Next
        Return Nothing
    End Function

    Private Function BCRInteraction_InSquareH(ByVal LineNumber As Integer) As NumMemo
        Dim Out As NumMemo = New NumMemo(MySize)
        Out.AllFalse()
        For i As Integer = 0 To MySize - 1
            For k As Integer = 1 To MySize
                Out(k) = NumberArray(AbleLSquare(LineNumber, i).Y - 1, AbleLSquare(LineNumber, i).X - 1).Memo_Auto(k) Or Out(k)
            Next
        Next
        Return Out
    End Function

    Private Function BCRInteraction_OutPosition(ByVal LineNumber As Integer, ByVal WValue As Byte) As CPosition()
        Dim Out(0) As CPosition
        Dim Count As Integer
        For i As Integer = 0 To MySize - 1
            If NumberArray(AbleLSquare(LineNumber, i).Y - 1, AbleLSquare(LineNumber, i).X - 1).Memo_Auto(WValue) = True Then
                ReDim Preserve Out(Out.Length)
                Out(Count) = New CPosition(AbleLSquare(LineNumber, i).Y, AbleLSquare(LineNumber, i).X)
                Count += 1
            End If
        Next
        If Count > 1 Then
            ReDim Preserve Out(Out.Length - 2)
            Return Out
        Else
            Return Nothing
        End If
    End Function

    Private Enum BCRInteraction_LineM
        TFalse
        Horizontal
        Vertical
        DiagonalOne
        DiagonalTwo
    End Enum

    Private Function BCRInteraction_IsItBLR(ByVal OVPosition As CPosition()) As BCRInteraction_LineM
        If OVPosition Is Nothing Then
            Return BCRInteraction_LineM.TFalse
        End If
        Dim CompareB As Boolean = False
        'X 축 비교
        Dim Compare As Integer = NumberArray(OVPosition(0).Y - 1, OVPosition(0).X - 1).AbleX
        If Compare <> 0 Then
            For i As Integer = 1 To OVPosition.Length - 1
                If NumberArray(OVPosition(i).Y - 1, OVPosition(i).X - 1).AbleX <> Compare Then
                    CompareB = True
                    Exit For
                End If
            Next
        Else
            CompareB = True
        End If
        If CompareB = False Then Return BCRInteraction_LineM.Vertical
        'Y 축 비교
        CompareB = False
        Compare = NumberArray(OVPosition(0).Y - 1, OVPosition(0).X - 1).AbleY
        If Compare <> 0 Then
            For i As Integer = 1 To OVPosition.Length - 1
                If NumberArray(OVPosition(i).Y - 1, OVPosition(i).X - 1).AbleY <> Compare Then
                    CompareB = True
                    Exit For
                End If
            Next
        Else
            CompareB = True
        End If
        If CompareB = False Then Return BCRInteraction_LineM.Horizontal
        '대각선 축 비교 (1)
        CompareB = False
        If NumberArray(OVPosition(0).Y - 1, OVPosition(0).X - 1).AbleOneDiagonal = True Then
            For i As Integer = 1 To OVPosition.Length - 1
                If NumberArray(OVPosition(i).Y - 1, OVPosition(i).X - 1).AbleOneDiagonal = False Then
                    CompareB = True
                    Exit For
                End If
            Next
        Else
            CompareB = True
        End If
        If CompareB = False Then Return BCRInteraction_LineM.DiagonalOne
        '대각선 축 비교 (2)
        CompareB = False
        If NumberArray(OVPosition(0).Y - 1, OVPosition(0).X - 1).AbleTwoDiagonal = True Then
            For i As Integer = 1 To OVPosition.Length - 1
                If NumberArray(OVPosition(i).Y - 1, OVPosition(i).X - 1).AbleTwoDiagonal = False Then
                    CompareB = True
                    Exit For
                End If
            Next
        Else
            CompareB = True
        End If
        If CompareB = False Then Return BCRInteraction_LineM.DiagonalTwo
        Return BCRInteraction_LineM.TFalse
    End Function

    Private Function BCRInteraction_MemoFinding(ByVal OnOneP As CPosition, ByVal FineT As Byte, ByVal LineNumber As Integer,
                                                  ByVal HVD As BCRInteraction_LineM) As PassNum()
        Dim Out(0) As PassNum
        Dim Count As Integer = 0
        Dim ALTS As Integer = AllFinder_AbleLineToInSquare(LineNumber)
        ' 수평 방향
        If HVD = BCRInteraction_LineM.Horizontal Then
            For i As Integer = 0 To MySize - 1
                If NumberArray(OnOneP.Y - 1, i).Memo_Auto(FineT) = True And
                    NumberArray(OnOneP.Y - 1, i).InSquare <> ALTS Then
                    ReDim Preserve Out(Out.Length)
                    Out(Count) = New PassNum(OnOneP.Y, i + 1, FineT)
                    Count += 1
                End If
            Next
        End If
        '수직 방향
        If HVD = BCRInteraction_LineM.Vertical Then
            For i As Integer = 0 To MySize - 1
                If NumberArray(i, OnOneP.X - 1).Memo_Auto(FineT) = True And
                    NumberArray(i, OnOneP.X - 1).InSquare <> ALTS Then
                    ReDim Preserve Out(Out.Length)
                    Out(Count) = New PassNum(i + 1, OnOneP.X, FineT)
                    Count += 1
                End If
            Next
        End If
        '대각선 방향 (1)
        If HVD = BCRInteraction_LineM.DiagonalOne Then
            For i As Integer = 0 To MySize - 1
                If NumberArray(i, i).Memo_Auto(FineT) = True And
                    NumberArray(i, i).InSquare <> ALTS Then
                    ReDim Preserve Out(Out.Length)
                    Out(Count) = New PassNum(i + 1, i + 1, FineT)
                    Count += 1
                End If
            Next
        End If
        '대각선 방향 (2)
        If HVD = BCRInteraction_LineM.DiagonalTwo Then
            For i As Integer = 0 To MySize - 1
                If NumberArray(MySize - i - 1, i).Memo_Auto(FineT) = True And
                    NumberArray(MySize - i - 1, i).InSquare <> ALTS Then
                    ReDim Preserve Out(Out.Length)
                    Out(Count) = New PassNum(MySize - i, i + 1, FineT)
                    Count += 1
                End If
            Next
        End If
        If Count = 0 Then Return Nothing
        ReDim Preserve Out(Out.Length - 2)
        Return Out
    End Function

#End Region

#Region "Box Line Reduction"

    Public Function BoxLineReduction() As PassNum()
        Dim BoxSquare As Byte?
        Dim Out() As PassNum
        For m As Integer = 0 To Cut_Line
            For h As Integer = 1 To MySize
                BoxSquare = BoxLineReduction_FirstM(m, h)
                If BoxSquare.HasValue = True Then
                    If BoxLineReduction_IsItAble(m, BoxSquare, h) = True Then
                        Out = BoxLineReduction_MemoFinder(m, BoxSquare, h)
                        If Not Out Is Nothing Then Return Out
                    End If
                End If
            Next
        Next
        Return Nothing
    End Function

    Private Function BoxLineReduction_FirstM(ByVal LineN As Integer, ByVal MemoV As Byte) As Nullable(Of Byte)
        For i As Integer = 0 To MySize - 1
            If NumberArray(AbleLSquare(LineN, i).Y - 1, AbleLSquare(LineN, i).X - 1).Memo_Auto(MemoV) = True Then
                Return NumberArray(AbleLSquare(LineN, i).Y - 1, AbleLSquare(LineN, i).X - 1).InSquare
            End If
        Next
        Return Nothing
    End Function

    Private Function BoxLineReduction_IsItAble(ByVal LineN As Integer, ByVal FirstS As Byte, MemoV As Byte) As Boolean
        For i As Integer = 0 To MySize - 1
            If NumberArray(AbleLSquare(LineN, i).Y - 1, AbleLSquare(LineN, i).X - 1).Memo_Auto(MemoV) = True And
                NumberArray(AbleLSquare(LineN, i).Y - 1, AbleLSquare(LineN, i).X - 1).InSquare <> FirstS Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function BoxLineReduction_MemoFinder(ByVal LineN As Integer, ByVal BoxS As Byte, ByVal MemoV As Byte) As PassNum()
        Dim Out(0) As PassNum
        Dim Count As Integer
        BoxS = AllFinder_InSquareToAbleLine(BoxS)
        For i As Integer = 0 To MySize - 1
            If NumberArray(AbleLSquare(BoxS, i).Y - 1, AbleLSquare(BoxS, i).X - 1).Memo_Auto(MemoV) = True Then
                If BoxLineReduction_MemoFinder_IsItH(LineN, i, BoxS) = False Then
                    ReDim Preserve Out(Out.Length)
                    Out(Count) = New PassNum(AbleLSquare(BoxS, i).Y, AbleLSquare(BoxS, i).X, MemoV)
                    Count += 1
                End If
            End If
        Next
        If Count = 0 Then Return Nothing
        ReDim Preserve Out(Out.Length - 2)
        Return Out
    End Function

    Private Function BoxLineReduction_MemoFinder_IsItH(ByVal LineN As Integer, ByVal i As Integer, ByVal BoxS As Byte) As Boolean
        For mn As Integer = 0 To MySize - 1
            If AbleLSquare(LineN, mn).X = AbleLSquare(BoxS, i).X And AbleLSquare(LineN, mn).Y = AbleLSquare(BoxS, i).Y Then
                Return True
            End If
        Next
        Return False
    End Function

#End Region

#Region "Box Interaction"

    Public Function BoxInteraction(ByVal InteractionLine As Byte) As PassNum()

    End Function

    Private Function BoxInteraction_VerticalLine(ByVal IL As Byte) As Byte()
        Dim Out() As Byte = Nothing
        For i As Integer = Cut_Horizontal + 1 To Cut_Vertical
            Out = Array_StructureArrayAdding(Out, BoxInteraction_VerticalLine_IsIt(i, IL))
        Next
        Return Out
    End Function

    Private Function BoxInteraction_VerticalLine_IsIt(ByVal TheLineNumer As Integer, ByVal IL As Byte) As Byte()
        Dim VerticalL(IL - 1) As Byte
    End Function
#End Region

    Public Function ErrorCheck() As Boolean
        Dim MemoC As New NumMemo(MySize)
        MemoC.AllFalse()
        For m As Integer = 0 To Cut_InValueDate
            For i As Integer = 0 To MySize - 1
                For k As Integer = 1 To MySize
                    MemoC(k) = NumberArray(AbleLSquare(m, i).Y - 1, AbleLSquare(m, i).X - 1).Memo_Auto(k) Or MemoC(k)
                Next
            Next
            If MemoC.CountTrueV <> MySize Then Return True
            MemoC.AllFalse()
        Next
        For i As Integer = 0 To MySize - 1
            For k As Integer = 0 To MySize - 1
                If NumberArray(i, k).Memo_Auto.CountTrueV = 0 Then Return True
            Next
        Next
        Return False
    End Function

    Public Function UltraFinder() As PassNum()
        Dim OT As PassNum()
        OT = NakedSingleArrange()
        If Not OT Is Nothing Then
            Return OT
        End If
        For i As Integer = 2 To MySize \ 2
            OT = NakedFinder(i)
            If Not OT Is Nothing Then
                Return OT
            End If
        Next
        For i As Integer = 1 To MySize \ 2
            OT = HiddenFinder(i)
            If Not OT Is Nothing Then
                Return OT
            End If
        Next
        OT = BCRInteraction()
        If Not OT Is Nothing Then
            Return OT
        End If
        OT = BoxLineReduction()
        If Not OT Is Nothing Then
            Return OT
        End If
        Return Nothing
    End Function

    Private Function MemoCalcurate(ByVal Po As CPosition) As NumMemo
        Dim Memol(MySize - 1) As Boolean
        For i As Integer = 0 To Memol.Length - 1
            Memol(i) = True
        Next
        Dim D() As CPosition = EffectingArea(Po)
        For i As Integer = 0 To D.Length - 1
            Memol(NumberArray(D(i).Y, D(i).X).TheValue - 1) = False
        Next
        Dim OutMemo As New NumMemo(MySize)

    End Function

    Public Function EffectingArea(ByVal Ina As CPosition) As CPosition()
        '하나의 Cell 과 직접적으로 연결되어 있는 모든 Cell 의 배열을 반환.
        Dim TheCount = 0
        Dim AP(0) As CPosition
        For i As Integer = 0 To MySize - 1
            For k As Integer = 0 To MySize - 1
                If DirectConnect(New CPosition(i + 1, k + 1), Ina) = True Then
                    ReDim Preserve AP(AP.Length)
                    AP(TheCount) = New CPosition(i + 1, k + 1)
                    TheCount += 1
                End If
            Next
        Next
        ReDim Preserve AP(AP.Length - 2)
        Return AP
    End Function

    Private Function DirectConnect(ByVal In1 As CPosition, ByVal In2 As CPosition) As Boolean
        '2개의 Cell 이 서로 직접적으로 연결되어 있는지 여부를 확인.
        If NumberArray(In1.Y - 1, In1.X - 1).AbleX = NumberArray(In2.Y - 1, In2.X - 1).AbleX And Not NumberArray(In1.Y - 1, In1.X - 1).AbleX = 0 Then
        ElseIf NumberArray(In1.Y - 1, In1.X - 1).AbleY = NumberArray(In2.Y - 1, In2.X - 1).AbleY And Not NumberArray(In1.Y - 1, In1.X - 1).AbleY = 0 Then
        ElseIf NumberArray(In1.Y - 1, In1.X - 1).InSquare = NumberArray(In2.Y - 1, In2.X - 1).InSquare And Not NumberArray(In1.Y - 1, In1.X - 1).InSquare = 0 Then
        ElseIf NumberArray(In1.Y - 1, In1.X - 1).AbleOneDiagonal = NumberArray(In2.Y - 1, In2.X - 1).AbleOneDiagonal And NumberArray(In1.Y - 1, In1.X - 1).AbleOneDiagonal = True Then
        ElseIf NumberArray(In1.Y - 1, In1.X - 1).AbleTwoDiagonal = NumberArray(In2.Y - 1, In2.X - 1).AbleTwoDiagonal And NumberArray(In1.Y - 1, In1.X - 1).AbleTwoDiagonal = True Then
        Else
            Return False
        End If
        Return True
    End Function

    Public Function CountMemo_PositionList(ByVal Count As Byte) As CPosition()
        '후보 숫자의 갯수가 Count 인 Cell 의 목록을 반환함.
        Dim A(0) As CPosition
        Dim ArrCount As Integer = 0
        For i As Integer = 0 To MySize - 1
            For k As Integer = 0 To MySize - 1
                If NumberArray(i, k).Memo_Auto.CountTrueV = Count Then
                    ReDim Preserve A(A.Length)
                    A(ArrCount) = New CPosition(i + 1, k + 1)
                    ArrCount += 1
                End If
            Next
        Next
        ReDim Preserve A(A.Length - 2)
        Return A
    End Function

End Class