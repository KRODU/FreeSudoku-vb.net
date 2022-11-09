Public Class ToolF
    Dim MySize As Size
    Dim ToolNum As STool
    Dim PuzzleSize As Byte = 9
    Dim SizeMe As Size
    Dim AFinderB As Boolean

    Private Sub ToolF_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ToolNum = New STool(PuzzleSize, {True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True,
                                          True, True, True, True, True, True, True, True, True, True, True, True, True, True, True}, OutSquare(PuzzleSize, 0))
        ToolNum.MakeControls(Me)
        SizeT_Tick(sender, e)
        SizeMe = Me.Size
        SizeT.Enabled = True
        For i As Integer = 0 To ToolNum.MySize - 1
            For k As Integer = 0 To ToolNum.MySize - 1
                ToolNum.MyControls(i, k).Text = "123456789"
            Next
        Next
    End Sub

    Private Sub SizeT_Tick(sender As System.Object, e As System.EventArgs) Handles SizeT.Tick
        If Not SizeMe = Me.Size Then
            SizeMe = Me.Size
            ToolNum.Resize(New Size(35, 35), New Size(Me.Size.Width - 13, Me.Size.Height - 40))
            Me.Refresh()
        End If
    End Sub

    Private Sub ToolF_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        ToolNum.BoardDrawing_DrawSmallPen(e)
    End Sub

    Private Sub FindCButton_Click(sender As System.Object, e As System.EventArgs) Handles FindCButton.Click
        AFinderB = ToolNum.AutoFinder()
        If AFinderB = False Then
            Arrangy_B.Enabled = False
        Else
            Arrangy_B.Enabled = True
        End If
    End Sub

    Private Sub Arrangy_B_Click(sender As System.Object, e As System.EventArgs) Handles Arrangy_B.Click
        ToolNum.FindingArrangy()
        Arrangy_B.Enabled = False
    End Sub
End Class