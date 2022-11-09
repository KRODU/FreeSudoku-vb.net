<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Step1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Step1))
        Me.B1 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.AboutB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'B1
        '
        Me.B1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.B1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.B1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B1.ForeColor = System.Drawing.Color.Black
        Me.B1.Location = New System.Drawing.Point(12, 12)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(85, 25)
        Me.B1.TabIndex = 0
        Me.B1.Text = "문제 풀기"
        Me.B1.UseVisualStyleBackColor = False
        '
        'B3
        '
        Me.B3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.B3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.B3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B3.ForeColor = System.Drawing.Color.Black
        Me.B3.Location = New System.Drawing.Point(103, 12)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(85, 25)
        Me.B3.TabIndex = 2
        Me.B3.Text = "문제 만들기"
        Me.B3.UseVisualStyleBackColor = False
        '
        'AboutB
        '
        Me.AboutB.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AboutB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AboutB.ForeColor = System.Drawing.Color.Black
        Me.AboutB.Location = New System.Drawing.Point(194, 12)
        Me.AboutB.Name = "AboutB"
        Me.AboutB.Size = New System.Drawing.Size(85, 25)
        Me.AboutB.TabIndex = 3
        Me.AboutB.Text = "About"
        Me.AboutB.UseVisualStyleBackColor = False
        '
        'Step1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(290, 47)
        Me.Controls.Add(Me.AboutB)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Step1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "프리스도쿠"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents B3 As System.Windows.Forms.Button
    Friend WithEvents AboutB As System.Windows.Forms.Button
End Class
