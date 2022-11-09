<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Step3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Step3))
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.L1 = New System.Windows.Forms.Label()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.RB3 = New System.Windows.Forms.RadioButton()
        Me.CB1 = New System.Windows.Forms.CheckBox()
        Me.B1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.GB1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.BackColor = System.Drawing.Color.White
        Me.RB1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RB1.ForeColor = System.Drawing.Color.Black
        Me.RB1.Location = New System.Drawing.Point(6, 20)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(47, 16)
        Me.RB1.TabIndex = 0
        Me.RB1.TabStop = True
        Me.RB1.Text = "일반"
        Me.RB1.UseVisualStyleBackColor = False
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Location = New System.Drawing.Point(12, 9)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(161, 12)
        Me.L1.TabIndex = 1
        Me.L1.Text = "퍼즐의 유형을 선택해주세요."
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.BackColor = System.Drawing.Color.White
        Me.RB2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RB2.ForeColor = System.Drawing.Color.Black
        Me.RB2.Location = New System.Drawing.Point(59, 20)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(75, 16)
        Me.RB2.TabIndex = 2
        Me.RB2.TabStop = True
        Me.RB2.Text = "직소 퍼즐"
        Me.RB2.UseVisualStyleBackColor = False
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.RB3)
        Me.GB1.Controls.Add(Me.RB1)
        Me.GB1.Controls.Add(Me.RB2)
        Me.GB1.ForeColor = System.Drawing.Color.Black
        Me.GB1.Location = New System.Drawing.Point(12, 36)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(234, 51)
        Me.GB1.TabIndex = 3
        Me.GB1.TabStop = False
        Me.GB1.Text = "퍼즐의 유형"
        '
        'RB3
        '
        Me.RB3.AutoSize = True
        Me.RB3.BackColor = System.Drawing.Color.White
        Me.RB3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RB3.ForeColor = System.Drawing.Color.Black
        Me.RB3.Location = New System.Drawing.Point(140, 20)
        Me.RB3.Name = "RB3"
        Me.RB3.Size = New System.Drawing.Size(87, 16)
        Me.RB3.TabIndex = 4
        Me.RB3.TabStop = True
        Me.RB3.Text = "사용자 정의"
        Me.RB3.UseVisualStyleBackColor = False
        '
        'CB1
        '
        Me.CB1.AutoSize = True
        Me.CB1.BackColor = System.Drawing.Color.White
        Me.CB1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB1.Location = New System.Drawing.Point(12, 93)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(140, 16)
        Me.CB1.TabIndex = 4
        Me.CB1.Text = "X 스도쿠 규칙을 적용"
        Me.CB1.UseVisualStyleBackColor = False
        '
        'B1
        '
        Me.B1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.B1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.B1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B1.ForeColor = System.Drawing.Color.Black
        Me.B1.Location = New System.Drawing.Point(12, 126)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(85, 25)
        Me.B1.TabIndex = 18
        Me.B1.Text = "← 이전으로"
        Me.B1.UseVisualStyleBackColor = False
        '
        'B2
        '
        Me.B2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.B2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.B2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B2.ForeColor = System.Drawing.Color.Black
        Me.B2.Location = New System.Drawing.Point(167, 126)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(85, 25)
        Me.B2.TabIndex = 19
        Me.B2.Text = "→ 다음으로"
        Me.B2.UseVisualStyleBackColor = False
        '
        'Step3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(264, 163)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.CB1)
        Me.Controls.Add(Me.GB1)
        Me.Controls.Add(Me.L1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Step3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "퍼즐의 유형 선택"
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents RB3 As System.Windows.Forms.RadioButton
    Friend WithEvents CB1 As System.Windows.Forms.CheckBox
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
End Class
