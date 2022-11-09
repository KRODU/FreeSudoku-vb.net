Public Class Step3

    Private Sub Step3_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub B1_Click(sender As System.Object, e As System.EventArgs) Handles B1.Click
        Step2.Show()
        Me.Dispose()
    End Sub

    Private Sub RB3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB3.CheckedChanged
        CB1.Enabled = False
    End Sub

    Private Sub RB_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RB1.CheckedChanged, RB2.CheckedChanged
        CB1.Enabled = True
    End Sub
End Class