<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SMaker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SMaker))
        Me.SizeT = New System.Windows.Forms.Timer(Me.components)
        Me.AutoRandom = New System.Windows.Forms.Timer(Me.components)
        Me.B2 = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SizeT
        '
        Me.SizeT.Interval = 500
        '
        'AutoRandom
        '
        Me.AutoRandom.Interval = 50
        '
        'B2
        '
        Me.B2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.B2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.B2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B2.ForeColor = System.Drawing.Color.Black
        Me.B2.Location = New System.Drawing.Point(12, 12)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(111, 25)
        Me.B2.TabIndex = 19
        Me.B2.Text = "→ 퍼즐 자동 완성"
        Me.B2.UseVisualStyleBackColor = False
        '
        'B1
        '
        Me.B1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.B1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.B1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B1.ForeColor = System.Drawing.Color.Black
        Me.B1.Location = New System.Drawing.Point(129, 12)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(85, 25)
        Me.B1.TabIndex = 20
        Me.B1.Text = "← 이전으로"
        Me.B1.UseVisualStyleBackColor = False
        '
        'SMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(692, 666)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.B2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(700, 700)
        Me.Name = "SMaker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "문제 만들기"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SizeT As System.Windows.Forms.Timer
    Friend WithEvents AutoRandom As System.Windows.Forms.Timer
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents B1 As System.Windows.Forms.Button

End Class
