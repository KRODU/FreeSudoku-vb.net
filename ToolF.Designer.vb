<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolF
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToolF))
        Me.SizeT = New System.Windows.Forms.Timer(Me.components)
        Me.FindCButton = New System.Windows.Forms.Button()
        Me.Arrangy_B = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SizeT
        '
        Me.SizeT.Interval = 500
        '
        'FindCButton
        '
        Me.FindCButton.Location = New System.Drawing.Point(628, 117)
        Me.FindCButton.Name = "FindCButton"
        Me.FindCButton.Size = New System.Drawing.Size(62, 32)
        Me.FindCButton.TabIndex = 0
        Me.FindCButton.Text = "Find (&F)"
        Me.FindCButton.UseVisualStyleBackColor = True
        '
        'Arrangy_B
        '
        Me.Arrangy_B.Enabled = False
        Me.Arrangy_B.Location = New System.Drawing.Point(628, 155)
        Me.Arrangy_B.Name = "Arrangy_B"
        Me.Arrangy_B.Size = New System.Drawing.Size(62, 32)
        Me.Arrangy_B.TabIndex = 1
        Me.Arrangy_B.Text = "Arrangy (&A)"
        Me.Arrangy_B.UseVisualStyleBackColor = True
        '
        'ToolF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(692, 666)
        Me.Controls.Add(Me.Arrangy_B)
        Me.Controls.Add(Me.FindCButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(700, 700)
        Me.Name = "ToolF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "도구"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SizeT As System.Windows.Forms.Timer
    Friend WithEvents FindCButton As System.Windows.Forms.Button
    Friend WithEvents Arrangy_B As System.Windows.Forms.Button
End Class
