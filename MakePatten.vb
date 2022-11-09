Class MakePatten
    Inherits Numbering
    Private RemoteControler() As Button
    Private NowClickingPosition As CPosition
    Private LabelHorizontal() As Label
    Private LabelVertical() As Label
    Private LabelDiagonalB(3) As Label
    Public NonEnable As Boolean
    Public QuestionMark As Boolean
    Private RandomBol As New Random
    Private RestCell As Integer
    Private RollbackFocus_Romote As Boolean
    Private RollbackFocus_Cell As CPosition
    Private SameArea As CPosition()
    Private TheSandBox As Numbering
    Event PuzzleComplete_Event()

    Sub New(ByVal PuzzleSize As Byte, ByVal AbleLine() As Boolean, ByVal PSquare(,) As CPosition)
        MyBase.New(PuzzleSize, AbleLine, PSquare)
        TheSandBox = New Numbering(PuzzleSize, AbleLine, PSquare)
        RestCell = PuzzleSize ^ 2
    End Sub

#Region "키입력 이벤트 처리"

    Private Sub Key_CellPressNumber_ByEvent(sender As Button, e As KeyPressEventArgs)
        Key_PressNumber_CellOrRomote(OutPositionFromE(sender.Name), e)
    End Sub

    Private Sub Key_RemotePressNumber_ByEvent(sender As Button, e As KeyPressEventArgs)
        Key_PressNumber_CellOrRomote(NowClickingPosition, e)
    End Sub

    Private Sub Key_PressNumber_CellOrRomote(ByVal TPosition As CPosition, ByVal e As KeyPressEventArgs)
        If Not "123456789ABCDEFG".IndexOf(Char.ToUpper(e.KeyChar)) = -1 And
            "123456789ABCDEFG".IndexOf(Char.ToUpper(e.KeyChar)) < MySize Then
            Dim PressOn As Byte
            If Not "ABCDEFG".IndexOf(Char.ToUpper(e.KeyChar)) = -1 Then
                PressOn = OutInAlphabet(Char.ToUpper(e.KeyChar))
            Else
                PressOn = Val(e.KeyChar)
            End If
            If NumberArray(TPosition.Y - 1, TPosition.X - 1).Memo_Auto(PressOn) = True Then
                ValueSelectProcess(PressOn, TPosition)
            End If
        End If
    End Sub

    Private Sub Key_PressArrow_Remote_ByEvent(sender As Button, e As PreviewKeyDownEventArgs)
        Select Case e.KeyData
            Case Keys.Up
                CellButtonClick_ByEvent(, , Key_ArrowPositionOut(0, 1, NowClickingPosition))
                RollbackFocus_Romote = True
            Case Keys.Down
                CellButtonClick_ByEvent(, , Key_ArrowPositionOut(0, -1, NowClickingPosition))
                RollbackFocus_Romote = True
            Case Keys.Left
                CellButtonClick_ByEvent(, , Key_ArrowPositionOut(-1, 0, NowClickingPosition))
                RollbackFocus_Romote = True
            Case Keys.Right
                CellButtonClick_ByEvent(, , Key_ArrowPositionOut(1, 0, NowClickingPosition))
                RollbackFocus_Romote = True
        End Select
    End Sub

    Private Function Key_ArrowPositionOut(ByVal Right As Integer, ByVal Up As Integer, ByVal OnPosition As CPosition) As CPosition
        Dim NowPosition As CPosition = OnPosition
        If Not Right = 0 Then
            For i As Integer = 0 To MySize - 1
                NowPosition = New CPosition(NowPosition.Y, NowPosition.X + Right)
                If NowPosition.X = MySize + 1 And Right = 1 Then
                    NowPosition = New CPosition(NowPosition.Y, 1)
                End If
                If NowPosition.X = 0 And Right = -1 Then
                    NowPosition = New CPosition(NowPosition.Y, MySize)
                End If
                If MyControls(NowPosition.Y - 1, NowPosition.X - 1).Enabled = True Then
                    Exit For
                End If
            Next
        End If
        If Not Up = 0 Then
            For i As Integer = 0 To MySize - 1
                NowPosition = New CPosition(NowPosition.Y - Up, NowPosition.X)
                If NowPosition.Y = MySize + 1 And Up = -1 Then
                    NowPosition = New CPosition(1, NowPosition.X)
                End If
                If NowPosition.Y = 0 And Up = 1 Then
                    NowPosition = New CPosition(MySize, NowPosition.X)
                End If
                If MyControls(NowPosition.Y - 1, NowPosition.X - 1).Enabled = True Then
                    Exit For
                End If
            Next
        End If
        Return NowPosition
    End Function

    Private Sub Key_RollBackFocus_Remote_ByEvent()
        If RollbackFocus_Romote = True Then
            For i As Integer = 1 To MySize
                If NumberArray(NowClickingPosition.Y - 1, NowClickingPosition.X - 1).Memo_Auto(i) = True Then
                    RemoteControler(i - 1).Focus()
                    Exit For
                End If
            Next
            RollbackFocus_Romote = False
        End If
    End Sub

    Private Sub Key_RollBackFocus_Cell_ByEvent()
        If Not RollbackFocus_Cell.X = 0 Then
            MyControls(RollbackFocus_Cell.Y - 1, RollbackFocus_Cell.X - 1).Focus()
            RollbackFocus_Cell = Nothing
        End If
    End Sub

    Private Sub Key_PressArrow_Cell_ByEvent(sender As Button, e As PreviewKeyDownEventArgs)
        Select Case e.KeyData
            Case Keys.Up
                RollbackFocus_Cell = Key_ArrowPositionOut(0, 1, OutPositionFromE(sender.Name))
            Case Keys.Down
                RollbackFocus_Cell = Key_ArrowPositionOut(0, -1, OutPositionFromE(sender.Name))
            Case Keys.Left
                RollbackFocus_Cell = Key_ArrowPositionOut(-1, 0, OutPositionFromE(sender.Name))
            Case Keys.Right
                RollbackFocus_Cell = Key_ArrowPositionOut(1, 0, OutPositionFromE(sender.Name))
        End Select
    End Sub

#End Region

#Region "컨트롤 생성, 재배열"

    Public Sub MakeControls(ByVal MyForm As Form)
        ReDim MyControls(MySize - 1, MySize - 1)
        ReDim RemoteControler(MySize - 1)
        ReDim LabelHorizontal(MySize - 1)
        ReDim LabelVertical(MySize - 1)
        For i As Integer = 0 To MySize - 1
            RemoteControler(i) = OnControl.RemoteButton("C" & i + 1, i + 1)
            MyForm.Controls.Add(RemoteControler(i))
            AddHandler RemoteControler(i).Click, AddressOf RemoteControlerClick_ByEvent
            AddHandler RemoteControler(i).KeyPress, AddressOf Key_RemotePressNumber_ByEvent
            AddHandler RemoteControler(i).PreviewKeyDown, AddressOf Key_PressArrow_Remote_ByEvent
            AddHandler RemoteControler(i).LostFocus, AddressOf Key_RollBackFocus_Remote_ByEvent
        Next
        For t As Integer = 0 To MySize - 1
            For i As Integer = 0 To MySize - 1
                MyControls(t, i) = OnControl.ControlStore.NewCB("E" & i + 1 & ":" & t + 1)
                MyForm.Controls.Add(MyControls(t, i))
                AddHandler MyControls(t, i).Click, AddressOf CellButtonClick_ByEvent
                AddHandler MyControls(t, i).LostFocus, AddressOf Key_RollBackFocus_Cell_ByEvent
                AddHandler MyControls(t, i).PreviewKeyDown, AddressOf Key_PressArrow_Cell_ByEvent
                AddHandler MyControls(t, i).KeyPress, AddressOf Key_CellPressNumber_ByEvent
            Next
        Next
        Dim VL As Boolean
        For i As Integer = 0 To MySize - 1
            LabelHorizontal(i) = OnControl.NewLBe()
            MyForm.Controls.Add(LabelHorizontal(i))
            If AbleHorizontalB(i) = True Then
                LabelHorizontal(i).Text = "X"
            Else
                LabelHorizontal(i).Text = "O"
                VL = True
            End If
        Next
        If VL = False Then
            For i As Integer = 0 To MySize - 1
                LabelHorizontal(i).Visible = False
            Next
        End If
        VL = False
        For i As Integer = 0 To MySize - 1
            LabelVertical(i) = OnControl.NewLBe()
            MyForm.Controls.Add(LabelVertical(i))
            If AbleVerticalB(i) = True Then
                LabelVertical(i).Text = "X"
            Else
                LabelVertical(i).Text = "O"
                VL = True
            End If
        Next
        If VL = False Then
            For i As Integer = 0 To MySize - 1
                LabelVertical(i).Visible = False
            Next
        End If
        VL = False
        For i As Integer = 0 To 3
            LabelDiagonalB(i) = OnControl.NewLBe
            MyForm.Controls.Add(LabelDiagonalB(i))
        Next
        If AbleDiagonalB(0) = True Then
            LabelDiagonalB(0).Text = "X"
            LabelDiagonalB(1).Text = "X"
            VL = True
        Else
            LabelDiagonalB(0).Text = "O"
            LabelDiagonalB(1).Text = "O"
        End If
        If AbleDiagonalB(1) = True Then
            LabelDiagonalB(2).Text = "X"
            LabelDiagonalB(3).Text = "X"
            VL = True
        Else
            LabelDiagonalB(2).Text = "O"
            LabelDiagonalB(3).Text = "O"
        End If
        If VL = False Then
            For i As Integer = 0 To 3
                LabelDiagonalB(i).Visible = False
            Next
        End If
        FindCommender()
    End Sub

    Public Sub ReSize(ByVal Location As Size, ByVal Size As Size)
        If MyControls Is Nothing Then
            Exit Sub
        End If
        Dim Divers As Integer = RealSize(Size, Location, MySize) / MySize
        Dim X As Integer = Location.Width
        Dim Y As Integer = Location.Height
        For t As Integer = 0 To MySize - 1
            For i As Integer = 0 To MySize - 1
                MyControls(t, i).Location = New Size(X, Y)
                MyControls(t, i).Size = New Size(Divers, Divers)
                MyControls(t, i).Font = New System.Drawing.Font("Arial", FontSize(Divers))
                X += Divers + 4
            Next
            Y += Divers + 4
            X = Location.Width
        Next
        If Not RemoteControler Is Nothing Then
            Dim OneSize As Integer = Divers
            If MySize <= 9 Then
                OneSize = OneSize / 3
            Else
                OneSize = OneSize / 4
            End If
            If OneSize < 30 Then
                OneSize = 30
            End If
            For i As Integer = 0 To MySize - 1
                RemoteControler(i).Size = New Size(OneSize, OneSize)
            Next
            If Not NowClickingPosition.X = 0 Then
                RemoteControlerArrange(True)
            End If
        End If
        For i As Integer = 0 To MySize - 1
            LabelHorizontal(i).Location = New Size(MyControls(0, i).Location.X + ((Divers / 2) - 15), MyControls(0, i).Location.Y - 31)
        Next
        For i As Integer = 0 To MySize - 1
            LabelVertical(i).Location = New Size(MyControls(i, 0).Location.X - 31, MyControls(i, 0).Location.Y + ((Divers / 2) - 15))
        Next
        LabelDiagonalB(0).Location = New Size(MyControls(0, 0).Location.X - 29, MyControls(0, 0).Location.Y - 29)
        LabelDiagonalB(1).Location = New Size(MyControls(MySize - 1, MySize - 1).Location.X + Divers - 4, MyControls(MySize - 1, MySize - 1).Location.Y + Divers - 2)
        LabelDiagonalB(2).Location = New Size(MyControls(MySize - 1, 0).Location.X - 28, MyControls(MySize - 1, 0).Location.Y + Divers - 2)
        LabelDiagonalB(3).Location = New Size(MyControls(0, MySize - 1).Location.X - 3 + Divers, MyControls(0, MySize - 1).Location.Y - 28)
        LabelDiagonalB(0).BringToFront()
    End Sub

    Private Sub RemoteControlerArrange(ByVal InNowReSize As Boolean)
        Dim X As Integer = MyControls(NowClickingPosition.Y - 1, NowClickingPosition.X - 1).Location.X
        Dim DX As Integer
        Dim Y As Integer = MyControls(NowClickingPosition.Y - 1, NowClickingPosition.X - 1).Location.Y
        If MySize <= 9 Then
            X = X + (X + MyControls(0, 0).Width)
            X = X / 2
            X -= RemoteControler(0).Size.Width
            X -= RemoteControler(0).Size.Width / 2
            Y = Y + (Y + MyControls(0, 0).Height)
            Y = Y / 2
            Y += 2 * RemoteControler(0).Size.Height
            Y -= RemoteControler(0).Size.Height
            Y -= RemoteControler(0).Size.Height / 2
            DX = X
            For i As Integer = 0 To MySize - 1
                RemoteControler(i).Location = New Size(X, Y)
                If InNowReSize = False Then
                    RemoteControler(i).Visible = True
                    RemoteControler(i).BringToFront()
                    RemoteControler(i).Enabled = NumberArray(NowClickingPosition.Y - 1, NowClickingPosition.X - 1).Memo_Auto(i + 1)
                End If
                X += RemoteControler(0).Width
                If i = 2 Or i = 5 Or i = 8 Then
                    X = DX
                    Y -= RemoteControler(0).Size.Height
                End If
            Next
        End If
    End Sub
#End Region

    Private Sub CellButtonClick_ByEvent(Optional sender As Button = Nothing, Optional e As EventArgs = Nothing, Optional ByVal OninPosition As CPosition = Nothing)
        If NonEnable = True Then
            Exit Sub
        End If
        If Not NowClickingPosition.X = 0 Then
            If MyControls(NowClickingPosition.Y - 1, NowClickingPosition.X - 1).Text = "" Then
                MyControls(NowClickingPosition.Y - 1, NowClickingPosition.X - 1).Enabled = True
            End If
        End If
        If Not sender Is Nothing Then
            NowClickingPosition = OutPositionFromE(sender.Name)
        Else
            NowClickingPosition = OninPosition
        End If
        MyControls(NowClickingPosition.Y - 1, NowClickingPosition.X - 1).Enabled = False
        MyControls(NowClickingPosition.Y - 1, NowClickingPosition.X - 1).BackColor = Color.White
        If NonEnable = True Then
            Exit Sub
        End If
        If NumberArray(NowClickingPosition.Y - 1, NowClickingPosition.X - 1).Memo_Auto.CountTrueV = 1 Then
            ValueSelectProcess(NumberArray(NowClickingPosition.Y - 1, NowClickingPosition.X - 1).Memo_Auto.CanSelect(0), NowClickingPosition)
        Else
            RemoteControlerArrange(False)
            Dim Toe() As CPosition
            Toe = EffectingArea(New CPosition(NowClickingPosition.Y, NowClickingPosition.X))
            For i As Integer = 0 To MySize - 1
                For k As Integer = 0 To MySize - 1
                    If MyControls(i, k).Enabled = True Then
                        MyControls(i, k).BackColor = ColorReturn(ColorStore.NonSelect)
                    End If
                Next
            Next
            For i As Integer = 0 To Toe.Length - 1
                If MyControls(Toe(i).Y - 1, Toe(i).X - 1).Enabled = True Then
                    MyControls(Toe(i).Y - 1, Toe(i).X - 1).BackColor = ColorReturn(ColorStore.SelectArea)
                End If
            Next
        End If
        For i As Integer = 1 To MySize
            If NumberArray(NowClickingPosition.Y - 1, NowClickingPosition.X - 1).Memo_Auto(i) = True Then
                RemoteControler(i - 1).Focus()
                Exit For
            End If
        Next
    End Sub

    Private Sub RemoteControlerClick_ByEvent(sender As Button, e As EventArgs)
        ValueSelectProcess(sender.Name.Remove(0, 1), NowClickingPosition)
    End Sub

    Private Sub ValueSelectProcess(ByVal Val As Byte, ByVal Locational As CPosition, Optional ByVal DonotCallCommender As Boolean = False)
        If DonotCallCommender = False Then
            TheSandBox.NumberArray(Locational.Y - 1, Locational.X - 1).TheValue = Val
            Dim AfterL As PassNum()
            Dim OnOv As Boolean = True
            Do While OnOv = True
                OnOv = False
                AfterL = TheSandBox.UltraFinder()
                If Not AfterL Is Nothing Then
                    OnOv = True
                    For i As Integer = 0 To AfterL.Length - 1
                        TheSandBox.NumberArray(AfterL(i).Y - 1, AfterL(i).X - 1).Memo_Auto(AfterL(i).Values) = False
                    Next
                End If
            Loop
        End If
        If TheSandBox.ErrorCheck = False Then
            NumberArray = TheSandBox.NumberArray.Clone
            NumberArray(Locational.Y - 1, Locational.X - 1).TheValue = Val
            RestCell -= 1
            If QuestionMark = False Then
                MyControls(Locational.Y - 1, Locational.X - 1).Text = OutInAlphabet(Val)
            Else
                MyControls(Locational.Y - 1, Locational.X - 1).Text = "?"
            End If
            MyControls(Locational.Y - 1, Locational.X - 1).BackColor = Color.White
        Else
            TheSandBox.NumberArray = NumberArray.Clone
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
            NumberArray(Locational.Y - 1, Locational.X - 1).Memo_Auto(Val) = False
        End If
        For i As Integer = 0 To RemoteControler.Length - 1
            RemoteControler(i).Visible = False
        Next
        If DonotCallCommender = False Then
            FindCommender()
        End If
    End Sub

    Private Sub FindCommender()
        Dim LeastSmall As Byte = MySize
        Dim Coun As Byte
        For i As Integer = 0 To MySize - 1
            For k As Integer = 0 To MySize - 1
                If MyControls(i, k).Text = "" Then MyControls(i, k).BackColor = ColorReturn(ColorStore.NoEnable)
                MyControls(i, k).Enabled = False
                Coun = NumberArray(i, k).Memo_Auto.CountTrueV
                If LeastSmall > Coun And Coun > 1 Then
                    LeastSmall = Coun
                End If
                If Coun = 0 Then
                    MyControls(i, k).BackColor = Color.Red
                    MyControls(i, k).Text = "E"
                    RestCell -= 1
                End If
            Next
        Next
        For i As Integer = 0 To MySize - 1
            For k As Integer = 0 To MySize - 1
                If NumberArray(i, k).Memo_Auto.CountTrueV = 1 And MyControls(i, k).Text = "" Then
                    ValueSelectProcess(NumberArray(i, k).Memo_Auto.CanSelect(0), New CPosition(i + 1, k + 1), True)
                End If
            Next
        Next
        SameArea = CountMemo_PositionList(LeastSmall)
        For i As Integer = 0 To SameArea.Length - 1
            MyControls(SameArea(i).Y - 1, SameArea(i).X - 1).Enabled = True
            MyControls(SameArea(i).Y - 1, SameArea(i).X - 1).BackColor = ColorReturn(ColorStore.CanSelect)
        Next
        FocusCal()
        If RestCell <= 0 Then
            RaiseEvent PuzzleComplete_Event()
        End If
    End Sub

    Private Sub FocusCal()
        For i As Integer = 0 To MySize - 1
            For k As Integer = 0 To MySize - 1
                If MyControls(i, k).Enabled = True Then
                    MyControls(i, k).Focus()
                    Exit Sub
                End If
            Next
        Next
    End Sub

    Public Sub ValueRandomSelect()
        Dim Counts As Integer = 0
        Dim RandomSelect_Cell As Integer = RandomBol.Next(SameArea.Length)
        Dim RandomSelect_OneNumber As OneCell = NumberArray(SameArea(RandomSelect_Cell).Y - 1, SameArea(RandomSelect_Cell).X - 1)
        Dim RandomSelect_Value As Integer = RandomBol.Next(1, RandomSelect_OneNumber.Memo_Auto.CountTrueV + 1)
        Dim Count As Integer
        Dim Val As Byte
        For i As Integer = 1 To MySize
            If RandomSelect_OneNumber.Memo_Auto(i) = True Then Count += 1
            If Count = RandomSelect_Value Then
                Val = i
                Exit For
            End If
        Next
        ValueSelectProcess(Val, New CPosition(SameArea(RandomSelect_Cell).Y, SameArea(RandomSelect_Cell).X))
    End Sub


End Class