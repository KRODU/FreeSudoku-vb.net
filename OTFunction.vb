Module GeneralFunction

#Region "Square 데이터 저장소"

    Public Function OutSquare(ByVal PuzzleSize As Byte, ByVal JigsawNumber As Byte) As CPosition(,)
        Dim Out(PuzzleSize - 1, PuzzleSize - 1) As CPosition
        Dim Count(PuzzleSize - 1)
        Dim NDa As Integer
        Dim Nine As String = SquareStore(PuzzleSize, JigsawNumber)
        For i As Integer = 0 To PuzzleSize - 1
            For k As Integer = 0 To PuzzleSize - 1
                NDa = Nine.Remove(Nine.IndexOf("."))
                Out(NDa - 1, Count(NDa - 1)) = New CPosition(i + 1, k + 1)
                Count(NDa - 1) += 1
                Nine = Nine.Remove(0, Nine.IndexOf(".") + 1)
            Next
        Next
        Return Out
    End Function

    Private Function SquareStore(ByVal PuzzleSize As Byte, ByVal jigsawNumber As Byte) As String
        Select Case PuzzleSize
            Case 4 And jigsawNumber = 0
                Return "1.1.2.2.1.1.2.2.3.3.4.4.3.3.4.4."
            Case 6 And jigsawNumber = 0
                Return "1.1.1.2.2.2.1.1.1.2.2.2.3.3.3.4.4.4.3.3.3.4.4.4.5.5.5.6.6.6.5.5.5.6.6.6."
            Case 9 And jigsawNumber = 0
                Return "1.1.1.2.2.2.3.3.3.1.1.1.2.2.2.3.3.3.1.1.1.2.2.2.3.3.3.4.4.4.5.5.5.6.6.6.4.4.4.5.5.5.6.6.6.4.4.4.5.5.5.6.6.6.7.7.7.8.8.8.9.9.9.7.7.7.8.8.8.9.9.9.7.7.7.8.8.8.9.9.9."
            Case 12 And jigsawNumber = 0
                Return "1.1.1.1.2.2.2.2.3.3.3.3.1.1.1.1.2.2.2.2.3.3.3.3.1.1.1.1.2.2.2.2.3.3.3.3.4.4.4.4.5.5.5.5.6.6.6.6.4.4.4.4.5.5.5.5.6.6.6.6.4.4.4.4.5.5.5.5.6.6.6.6.7.7.7.7.8.8.8.8.9.9.9.9.7.7.7.7.8.8.8.8.9.9.9.9.7.7.7.7.8.8.8.8.9.9.9.9.10.10.10.10.11.11.11.11.12.12.12.12.10.10.10.10.11.11.11.11.12.12.12.12.10.10.10.10.11.11.11.11.12.12.12.12."
            Case 16 And jigsawNumber = 0
                Return "1.1.1.1.2.2.2.2.3.3.3.3.4.4.4.4.1.1.1.1.2.2.2.2.3.3.3.3.4.4.4.4.1.1.1.1.2.2.2.2.3.3.3.3.4.4.4.4.1.1.1.1.2.2.2.2.3.3.3.3.4.4.4.4.5.5.5.5.6.6.6.6.7.7.7.7.8.8.8.8.5.5.5.5.6.6.6.6.7.7.7.7.8.8.8.8.5.5.5.5.6.6.6.6.7.7.7.7.8.8.8.8.5.5.5.5.6.6.6.6.7.7.7.7.8.8.8.8.9.9.9.9.10.10.10.10.11.11.11.11.12.12.12.12.9.9.9.9.10.10.10.10.11.11.11.11.12.12.12.12.9.9.9.9.10.10.10.10.11.11.11.11.12.12.12.12.9.9.9.9.10.10.10.10.11.11.11.11.12.12.12.12.13.13.13.13.14.14.14.14.15.15.15.15.16.16.16.16.13.13.13.13.14.14.14.14.15.15.15.15.16.16.16.16.13.13.13.13.14.14.14.14.15.15.15.15.16.16.16.16.13.13.13.13.14.14.14.14.15.15.15.15.16.16.16.16."
            Case 9 And jigsawNumber = 1
                Return "1.1.2.2.2.3.3.3.3.1.1.2.1.2.3.3.3.6.1.1.1.1.2.3.3.6.6.4.4.2.2.2.5.5.6.6.4.4.5.5.5.5.5.6.6.4.4.5.5.8.8.8.6.6.4.4.7.7.8.9.9.9.9.4.7.7.7.8.9.8.9.9.7.7.7.7.8.8.8.9.9."
            Case 9 And jigsawNumber = 2
                Return "1.1.1.1.1.2.2.3.3.1.1.4.1.1.2.2.3.3.4.4.4.4.2.2.2.2.3.4.4.4.6.6.6.2.3.3.5.5.4.6.6.6.8.3.3.5.5.7.6.6.6.8.8.8.5.7.7.7.7.8.8.8.8.5.5.7.7.9.9.8.9.9.5.5.7.7.9.9.9.9.9."
            Case 9 And jigsawNumber = 3
                Return "1.1.1.2.2.2.3.3.3.1.1.4.2.2.2.2.3.3.1.4.4.4.5.2.2.3.3.1.1.4.5.5.5.6.3.3.1.4.4.4.5.6.6.6.9.7.7.4.5.5.5.6.9.9.7.7.8.8.5.6.6.6.9.7.7.8.8.8.8.6.9.9.7.7.7.8.8.8.9.9.9."
            Case 9 And jigsawNumber = 4
                Return "1.2.2.2.2.3.3.3.3.1.2.2.1.2.3.6.6.6.1.2.2.1.5.3.6.6.6.1.1.1.1.5.3.3.3.6.4.4.5.5.5.5.5.6.6.4.7.7.7.5.9.9.9.9.4.4.4.7.5.9.8.8.9.4.4.4.7.8.9.8.8.9.7.7.7.7.8.8.8.8.9."
            Case 9 And jigsawNumber = 5
                Return "1.1.2.2.2.2.3.3.3.1.1.1.2.2.3.3.3.6.1.1.2.2.3.3.3.6.6.4.1.1.2.5.5.6.6.6.4.4.5.5.5.5.5.6.6.4.4.4.5.5.8.9.9.6.4.4.7.7.7.8.8.9.9.4.7.7.7.8.8.9.9.9.7.7.7.8.8.8.8.9.9."
            Case 9 And jigsawNumber = 6
                Return "1.1.1.1.1.2.2.2.3.4.1.1.1.2.2.2.3.3.4.4.1.2.2.2.3.3.3.4.4.4.5.5.5.6.3.3.7.4.4.5.5.5.6.6.3.7.7.4.5.5.5.6.6.6.7.7.7.8.8.8.9.6.6.7.7.8.8.8.9.9.9.6.7.8.8.8.9.9.9.9.9."
            Case 9 And jigsawNumber = 7
                Return "1.1.1.2.2.2.2.2.2.1.1.1.1.2.5.5.2.2.3.3.1.1.5.5.5.6.6.3.3.4.4.4.5.5.5.6.3.3.7.4.4.4.5.6.6.3.7.7.7.4.4.4.6.6.3.3.7.7.7.9.9.6.6.8.8.7.7.8.9.9.9.9.8.8.8.8.8.8.9.9.9."
        End Select
        Return Nothing
    End Function
#End Region

#Region "각종 구조체 정의"

    Structure CPosition
        Public X As Byte
        Public Y As Byte
        Sub New(ByVal Yl As Byte, ByVal Xl As Byte)
            X = Xl
            Y = Yl
        End Sub
    End Structure

    Structure PassNum
        Public X As Byte
        Public Y As Byte
        Public Values As Byte
        Sub New(ByVal Yl As Byte, ByVal Xl As Byte, ByVal Value As Byte)
            X = Xl
            Y = Yl
            Values = Value
        End Sub
    End Structure

    Enum WhatDo
        Solve
        Make
        Tools
    End Enum

    Structure PuzzInfo
        Public WhatDo As WhatDo
        Public PuzzleSize As Byte

    End Structure

    Structure TheNext
        Private PossibleN() As Byte
        Private SelectingN As Byte
        Private MaxN As Byte
        Private MinN As Byte
        Private PCount As Double

        Sub New(ByVal Minimum As Byte, Maximum As Byte, ByVal SelectN As Byte)
            ReDim PossibleN(SelectN - 1)
            SelectingN = SelectN
            MaxN = Maximum
            MinN = Minimum
            For i As Integer = 0 To PossibleN.Length - 1
                PossibleN(i) = Minimum
                Minimum += 1
            Next
            PCount = MaxN - MinN + 1
            Dim RT As Integer = MaxN - MinN + 1
            For i As Integer = RT - 1 To RT - SelectN + 1 Step -1
                PCount *= i
            Next
            For i As Integer = 2 To SelectingN
                PCount /= i
            Next
        End Sub

        Public ReadOnly Property PossibleCount As Integer
            Get
                Return PCount
            End Get
        End Property

        Public ReadOnly Property SelectN As Integer
            Get
                Return SelectingN
            End Get
        End Property

        Default Public ReadOnly Property PByte(ByVal Index As Integer) As Integer
            Get
                If Index >= PossibleN.Length Then
                    Return Nothing
                End If
                Return PossibleN(Index)
            End Get
        End Property

        Public Sub TNext()
            For i As Integer = PossibleN.Length - 1 To 0 Step -1
                If PossibleN(i) <> MaxN - (SelectingN - i) + 1 Then
                    PossibleN(i) += 1
                    DownCount(i)
                    Exit For
                End If
            Next
        End Sub

        Private Sub DownCount(ByVal i As Integer)
            If i <> PossibleN.Length - 1 Then
                For k As Integer = i + 1 To PossibleN.Length - 1
                    PossibleN(k) = PossibleN(k - 1) + 1
                Next
            End If
        End Sub

    End Structure

    Structure OneCell
        Public Memo_Auto As NumMemo
        Public Memo_User As NumMemo
        Public InSquare As Byte
        Private Value As Byte
        Public Solution As Byte
        Public Clue As Boolean
        Public AbleX, AbleY As Byte
        Public AbleOneDiagonal, AbleTwoDiagonal As Boolean

        Sub New(ByVal PuzzleSize As Byte)
            Memo_Auto = New NumMemo(PuzzleSize)
            Memo_User = New NumMemo(PuzzleSize)
        End Sub

        Public Property TheValue As Byte
            Get
                Return Value
            End Get
            Set(valSet As Byte)
                Value = valSet
                Memo_Auto.AllFalse()
                Memo_Auto(valSet) = True
            End Set
        End Property

    End Structure

    Structure NumMemo
        Private Memo() As Boolean
        Private CanSelectCount As Integer

        Sub New(ByVal PuzzleSize As Byte)
            SetSize(PuzzleSize)
        End Sub

        Public Sub AllFalse()
            For i As Integer = 0 To Memo.Length - 1
                Memo(i) = False
            Next
            CanSelectCount = 0
        End Sub

        Private Sub SetSize(ByVal Num As Byte)
            ReDim Memo(Num - 1)
            For i As Byte = 0 To Num - 1
                Memo(i) = True
            Next
            CanSelectCount = Num
        End Sub

        Default Public Property BMemo(ByVal Num As Byte) As Boolean
            Get
                Return Memo(Num - 1)
            End Get
            Set(value As Boolean)
                If Memo(Num - 1) = False And value = True Then
                    CanSelectCount += 1
                End If
                If Memo(Num - 1) = True And value = False Then
                    CanSelectCount -= 1
                End If
                Memo(Num - 1) = value
            End Set

        End Property

        Public ReadOnly Property CanSelect As Byte()
            Get
                Dim ForOut(CanSelectCount - 1) As Byte
                Dim Count As Byte = 0
                For i As Byte = 0 To Memo.Length - 1
                    If Memo(i) = True Then
                        ForOut(Count) = i + 1
                        Count += 1
                    End If
                Next
                Return ForOut
            End Get

        End Property

        Public ReadOnly Property CountTrueV As Byte
            Get
                Return CanSelectCount
            End Get
        End Property

    End Structure

#End Region

    Public Function OutInAlphabet(ByVal InDate As String) As String
        Select Case InDate
            Case "A"
                Return "10"
            Case "B"
                Return "11"
            Case "C"
                Return "12"
            Case "D"
                Return "13"
            Case "E"
                Return "14"
            Case "F"
                Return "15"
            Case "G"
                Return "16"
            Case "10"
                Return "A"
            Case "11"
                Return "B"
            Case "12"
                Return "C"
            Case "13"
                Return "D"
            Case "14"
                Return "E"
            Case "15"
                Return "F"
            Case "16"
                Return "G"
            Case Else
                Return InDate
        End Select
    End Function

    Public Function Array_OverlapDelete(ByVal Onin() As CPosition) As CPosition()
        Dim Pr(0) As CPosition
        Dim Redo As Boolean
        Dim Count As Integer = 0
        For k As Integer = 0 To Onin.Length - 1
            For i As Integer = 0 To Pr.Length - 2
                If Pr(i).X = Onin(k).X And Pr(i).Y = Onin(k).Y Then
                    Redo = True
                End If
            Next
            If Redo = False Then
                ReDim Preserve Pr(Pr.Length)
                Pr(Count) = New CPosition(Onin(k).Y, Onin(k).X)
                Count += 1
            End If
            Redo = False
        Next
        ReDim Preserve Pr(Pr.Length - 2)
        Return Pr
    End Function

    Public Function Array_StructureArrayAdding(Of T As Structure)(ByVal In1() As T, ByVal In2() As T) As T()
        If In1 Is Nothing And Not In2 Is Nothing Then
            Return In2
        End If
        If In2 Is Nothing And Not In1 Is Nothing Then
            Return In1
        End If
        If In1 Is Nothing And In2 Is Nothing Then
            Return Nothing
        End If
        Dim Out() As T = In1
        Dim Count As Integer
        ReDim Preserve Out(In1.Length + In2.Length - 1)
        For i As Integer = In1.Length To In1.Length + In2.Length - 1
            Out(i) = In2(Count)
            Count += 1
        Next
        Return Out
    End Function

    Public Function OutPositionFromE(ByVal Name As String) As CPosition
        Dim X As String = Name.Remove(0, 1)
        Dim Y As String = X
        X = X.Remove(X.IndexOf(":"))
        Y = Y.Remove(0, Y.IndexOf(":") + 1)
        Return New CPosition(Y, X)
    End Function

End Module