Class SoveForm
    Inherits Numbering
    Sub New(ByVal PuzzleSize As Byte, ByVal AbleLine() As Boolean, ByVal PSquare(,) As CPosition)
        MyBase.New(PuzzleSize, AbleLine, PSquare)
    End Sub

    Public Sub MakeVisualD(ByVal MyForm As Form)
        ReDim MyControls(MySize - 1, MySize - 1)
        For t As Integer = 0 To MySize - 1
            For i As Integer = 0 To MySize - 1
                MyControls(t, i) = OnControl.NewTB("E" & t + 1 & ":" & i + 1)
                MyForm.Controls.Add(MyControls(t, i))
            Next
        Next
    End Sub
End Class