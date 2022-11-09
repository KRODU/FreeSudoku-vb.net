Public Class Step1

    Private Sub B1_Click(sender As System.Object, e As System.EventArgs) Handles B1.Click
        Step2.Show()
        Me.Dispose()
    End Sub

    Private Sub B3_Click(sender As System.Object, e As System.EventArgs) Handles B3.Click
        Step2.Show()
        Me.Dispose()
    End Sub

    Private Sub Step1_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub AboutB_Click(sender As System.Object, e As System.EventArgs) Handles AboutB.Click
        MsgBox("프로그램 버전: 1.0.0" & vbCrLf & "프로그램 문의: nscks@naver.com", MsgBoxStyle.Information)
    End Sub
End Class