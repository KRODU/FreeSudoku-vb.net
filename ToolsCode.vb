Class STool
    Inherits Numbering
    Dim Ult As PassNum()
    Sub New(ByVal PuzzleSize As Byte, ByVal AbleLine() As Boolean, ByVal PSquare(,) As CPosition)
        MyBase.New(PuzzleSize, AbleLine, PSquare)
    End Sub

    Public Sub MakeControls(ByVal MyForm As Form)
        ReDim MyControls(MySize - 1, MySize - 1)
        For t As Integer = 0 To MySize - 1
            For i As Integer = 0 To MySize - 1
                MyControls(t, i) = OnControl.NewRTB("E" & t + 1 & ":" & i + 1)
                MyForm.Controls.Add(MyControls(t, i))
            Next
        Next
    End Sub

    Public Sub Resize(ByVal Location As Size, ByVal Size As Size)
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
                MyControls(t, i).Font = New System.Drawing.Font("Arial", FontSize(Divers) / 3)
                X += Divers + 4
            Next
            Y += Divers + 4
            X = Location.Width
        Next
    End Sub

    Public Property RTControl(ByVal i As Integer, ByVal k As Integer) As RichTextBox
        Get
            Return MyControls(i, k)
        End Get
        Set(value As RichTextBox)
            MyControls(i, k) = value
        End Set
    End Property

    Private Sub RedRol(ByVal Xl As Byte, ByVal Yl As Byte, ByVal RDB As Byte)
        With RTControl(Yl - 1, Xl - 1)
            .Select(.Text.IndexOf(RDB), 1)
            .SelectionColor = Color.Red
            .SelectionFont = New System.Drawing.Font(.Font.FontFamily, .Font.Size, FontStyle.Bold)
        End With
    End Sub

    Public Function AutoFinder() As Boolean
        For i As Integer = 0 To MySize - 1
            For k As Integer = 0 To MySize - 1
                NumberArray(i, k).Memo_Auto.AllFalse()
                For l As Integer = 0 To MyControls(i, k).Text.Length - 1
                    NumberArray(i, k).Memo_Auto(Val(MyControls(i, k).Text(l))) = True
                Next
            Next
        Next
        If ErrorCheck() = True Then
            MsgBox("입력한 퍼즐에 오류가 있습니다.", MsgBoxStyle.Exclamation)
            Return False
        End If
        Ult = UltraFinder()
        If Ult Is Nothing Then
            Return False
        End If
        For i As Integer = 0 To Ult.Length - 1
            RedRol(Ult(i).X, Ult(i).Y, Ult(i).Values)
        Next
        Return True
    End Function

    Public Sub FindingArrangy()
        For i As Integer = 0 To Ult.Length - 1
            With RTControl(Ult(i).Y - 1, Ult(i).X - 1)
                .Text = .Text.Remove(.Text.IndexOf(Ult(i).Values), 1)
                .SelectAll()
                .SelectionFont = New System.Drawing.Font(.Font.FontFamily, .Font.Size)
                .SelectionColor = Color.Black
            End With
        Next
    End Sub

End Class