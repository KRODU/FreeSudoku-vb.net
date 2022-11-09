Public Class SMaker
    Dim WithEvents TheNumbering As MakePatten
    Dim PuzzleSize As Integer = 9
    Dim SizeMe As Size
    Dim MyComplete As Boolean
    Dim i As Integer = 0
    Private Sub SMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TheNumbering = New MakePatten(PuzzleSize, {True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True, True,
                                          True, True, True, True, True, True, True, True, True, True, True, True, True, False, False}, OutSquare(PuzzleSize, 0))
        TheNumbering.MakeControls(Me)
        SizeT_Tick(sender, e)
        SizeMe = Me.Size
        SizeT.Enabled = True
    End Sub

    Private Sub SizeT_Tick(sender As Object, e As EventArgs) Handles SizeT.Tick
        If Not SizeMe = Me.Size Then
            SizeMe = Me.Size
            TheNumbering.ReSize(New Size(35, 35), New Size(Me.Size.Width - 13, Me.Size.Height - 40))
            Me.Refresh()
            ReButtonLocation()
        End If
    End Sub

    Private Sub ReButtonLocation()
        B1.Location = New Size(TheNumbering.MyControls(PuzzleSize - 1, 0).Location.X,
                       TheNumbering.MyControls(PuzzleSize - 1, 0).Location.Y + TheNumbering.MyControls(0, 0).Height + 10)
        B2.Location = New Size(TheNumbering.MyControls(PuzzleSize - 1, PuzzleSize - 1).Location.X +
                               TheNumbering.MyControls(0, 0).Height - B2.Size.Width, TheNumbering.MyControls(PuzzleSize - 1,
                                                                                                             PuzzleSize - 1).Location.Y + TheNumbering.MyControls(0, 0).Height + 10)
    End Sub

    Private Sub SMaker_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        TheNumbering.BoardDrawing_ForMakePatten(e)
    End Sub

    Private Sub AutoRandom_Tick(sender As System.Object, e As System.EventArgs) Handles AutoRandom.Tick
        TheNumbering.ValueRandomSelect()
    End Sub

    Private Sub Complete() Handles TheNumbering.PuzzleComplete_Event
        AutoRandom.Enabled = False
        MyComplete = True
        B2.Enabled = True
        B2.Text = "→ 다음으로"
        B2.Size = New Size(85, 25)
        ReButtonLocation()
    End Sub

    Private Sub B2_Click(sender As System.Object, e As System.EventArgs) Handles B2.Click
        If MyComplete = False Then
            TheNumbering.NonEnable = True
            AutoRandom.Enabled = True
            B2.Enabled = False
        End If
    End Sub

End Class
