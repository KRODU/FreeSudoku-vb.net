Public Class Step2
    Private Sub Step2_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub Step2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        R9.Checked = True
    End Sub

    Private Sub B1_Click(sender As System.Object, e As System.EventArgs) Handles B1.Click
        Step1.Show()
        Me.Dispose()
    End Sub

    Private Sub B2_Click(sender As System.Object, e As System.EventArgs) Handles B2.Click
        Step3.Show()
        Me.Dispose()
    End Sub

    Private Sub General_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles _
        R4.CheckedChanged, R9.CheckedChanged, R6.CheckedChanged, R16.CheckedChanged, R12.CheckedChanged
        Dim L As RadioButton = sender
        If L.Checked = True Then
            R5.Checked = False
            R8.Checked = False
            R7.Checked = False
            R15.Checked = False
            R14.Checked = False
            R13.Checked = False
            R11.Checked = False
            R10.Checked = False
        End If
    End Sub

    Private Sub UserCustom_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles _
        R5.CheckedChanged, R8.CheckedChanged, R7.CheckedChanged, R15.CheckedChanged, R14.CheckedChanged, _
        R13.CheckedChanged, R11.CheckedChanged, R10.CheckedChanged
        Dim L As RadioButton = sender
        If L.Checked = True Then
            R4.Checked = False
            R9.Checked = False
            R6.Checked = False
            R16.Checked = False
            R12.Checked = False
        End If
    End Sub
End Class