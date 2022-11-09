<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Step2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Step2))
        Me.R9 = New System.Windows.Forms.RadioButton()
        Me.R4 = New System.Windows.Forms.RadioButton()
        Me.R12 = New System.Windows.Forms.RadioButton()
        Me.L1 = New System.Windows.Forms.Label()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.R16 = New System.Windows.Forms.RadioButton()
        Me.R6 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.R15 = New System.Windows.Forms.RadioButton()
        Me.R14 = New System.Windows.Forms.RadioButton()
        Me.R13 = New System.Windows.Forms.RadioButton()
        Me.R11 = New System.Windows.Forms.RadioButton()
        Me.R10 = New System.Windows.Forms.RadioButton()
        Me.R8 = New System.Windows.Forms.RadioButton()
        Me.R7 = New System.Windows.Forms.RadioButton()
        Me.R5 = New System.Windows.Forms.RadioButton()
        Me.B1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.GB1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'R9
        '
        Me.R9.AutoSize = True
        Me.R9.BackColor = System.Drawing.Color.White
        Me.R9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.R9.Location = New System.Drawing.Point(144, 20)
        Me.R9.Name = "R9"
        Me.R9.Size = New System.Drawing.Size(63, 16)
        Me.R9.TabIndex = 5
        Me.R9.TabStop = True
        Me.R9.Text = "9 (3X3)"
        Me.R9.UseVisualStyleBackColor = False
        '
        'R4
        '
        Me.R4.AutoSize = True
        Me.R4.BackColor = System.Drawing.Color.White
        Me.R4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.R4.Location = New System.Drawing.Point(6, 20)
        Me.R4.Name = "R4"
        Me.R4.Size = New System.Drawing.Size(63, 16)
        Me.R4.TabIndex = 3
        Me.R4.TabStop = True
        Me.R4.Text = "4 (2X2)"
        Me.R4.UseVisualStyleBackColor = False
        '
        'R12
        '
        Me.R12.AutoSize = True
        Me.R12.BackColor = System.Drawing.Color.White
        Me.R12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.R12.Location = New System.Drawing.Point(213, 20)
        Me.R12.Name = "R12"
        Me.R12.Size = New System.Drawing.Size(69, 16)
        Me.R12.TabIndex = 6
        Me.R12.TabStop = True
        Me.R12.Text = "12 (4X3)"
        Me.R12.UseVisualStyleBackColor = False
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Location = New System.Drawing.Point(12, 9)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(161, 12)
        Me.L1.TabIndex = 1
        Me.L1.Text = "퍼즐의 크기를 선택해주세요."
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.R16)
        Me.GB1.Controls.Add(Me.R6)
        Me.GB1.Controls.Add(Me.R4)
        Me.GB1.Controls.Add(Me.R9)
        Me.GB1.Controls.Add(Me.R12)
        Me.GB1.ForeColor = System.Drawing.Color.Black
        Me.GB1.Location = New System.Drawing.Point(12, 39)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(369, 52)
        Me.GB1.TabIndex = 2
        Me.GB1.TabStop = False
        Me.GB1.Text = "일반 크기"
        '
        'R16
        '
        Me.R16.AutoSize = True
        Me.R16.BackColor = System.Drawing.Color.White
        Me.R16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.R16.Location = New System.Drawing.Point(288, 20)
        Me.R16.Name = "R16"
        Me.R16.Size = New System.Drawing.Size(69, 16)
        Me.R16.TabIndex = 7
        Me.R16.TabStop = True
        Me.R16.Text = "16 (4X4)"
        Me.R16.UseVisualStyleBackColor = False
        '
        'R6
        '
        Me.R6.AutoSize = True
        Me.R6.BackColor = System.Drawing.Color.White
        Me.R6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.R6.Location = New System.Drawing.Point(75, 20)
        Me.R6.Name = "R6"
        Me.R6.Size = New System.Drawing.Size(63, 16)
        Me.R6.TabIndex = 4
        Me.R6.TabStop = True
        Me.R6.Text = "6 (3X2)"
        Me.R6.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.R15)
        Me.GroupBox1.Controls.Add(Me.R14)
        Me.GroupBox1.Controls.Add(Me.R13)
        Me.GroupBox1.Controls.Add(Me.R11)
        Me.GroupBox1.Controls.Add(Me.R10)
        Me.GroupBox1.Controls.Add(Me.R8)
        Me.GroupBox1.Controls.Add(Me.R7)
        Me.GroupBox1.Controls.Add(Me.R5)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 48)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "사용자 정의 크기"
        '
        'R15
        '
        Me.R15.AutoSize = True
        Me.R15.BackColor = System.Drawing.Color.White
        Me.R15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.R15.Location = New System.Drawing.Point(275, 20)
        Me.R15.Name = "R15"
        Me.R15.Size = New System.Drawing.Size(35, 16)
        Me.R15.TabIndex = 16
        Me.R15.TabStop = True
        Me.R15.Text = "15"
        Me.R15.UseVisualStyleBackColor = False
        '
        'R14
        '
        Me.R14.AutoSize = True
        Me.R14.BackColor = System.Drawing.Color.White
        Me.R14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.R14.Location = New System.Drawing.Point(234, 20)
        Me.R14.Name = "R14"
        Me.R14.Size = New System.Drawing.Size(35, 16)
        Me.R14.TabIndex = 15
        Me.R14.TabStop = True
        Me.R14.Text = "14"
        Me.R14.UseVisualStyleBackColor = False
        '
        'R13
        '
        Me.R13.AutoSize = True
        Me.R13.BackColor = System.Drawing.Color.White
        Me.R13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.R13.Location = New System.Drawing.Point(193, 20)
        Me.R13.Name = "R13"
        Me.R13.Size = New System.Drawing.Size(35, 16)
        Me.R13.TabIndex = 14
        Me.R13.TabStop = True
        Me.R13.Text = "13"
        Me.R13.UseVisualStyleBackColor = False
        '
        'R11
        '
        Me.R11.AutoSize = True
        Me.R11.BackColor = System.Drawing.Color.White
        Me.R11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.R11.Location = New System.Drawing.Point(152, 20)
        Me.R11.Name = "R11"
        Me.R11.Size = New System.Drawing.Size(35, 16)
        Me.R11.TabIndex = 13
        Me.R11.TabStop = True
        Me.R11.Text = "11"
        Me.R11.UseVisualStyleBackColor = False
        '
        'R10
        '
        Me.R10.AutoSize = True
        Me.R10.BackColor = System.Drawing.Color.White
        Me.R10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.R10.Location = New System.Drawing.Point(111, 20)
        Me.R10.Name = "R10"
        Me.R10.Size = New System.Drawing.Size(35, 16)
        Me.R10.TabIndex = 12
        Me.R10.TabStop = True
        Me.R10.Text = "10"
        Me.R10.UseVisualStyleBackColor = False
        '
        'R8
        '
        Me.R8.AutoSize = True
        Me.R8.BackColor = System.Drawing.Color.White
        Me.R8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.R8.Location = New System.Drawing.Point(76, 20)
        Me.R8.Name = "R8"
        Me.R8.Size = New System.Drawing.Size(29, 16)
        Me.R8.TabIndex = 11
        Me.R8.TabStop = True
        Me.R8.Text = "8"
        Me.R8.UseVisualStyleBackColor = False
        '
        'R7
        '
        Me.R7.AutoSize = True
        Me.R7.BackColor = System.Drawing.Color.White
        Me.R7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.R7.Location = New System.Drawing.Point(41, 20)
        Me.R7.Name = "R7"
        Me.R7.Size = New System.Drawing.Size(29, 16)
        Me.R7.TabIndex = 10
        Me.R7.TabStop = True
        Me.R7.Text = "7"
        Me.R7.UseVisualStyleBackColor = False
        '
        'R5
        '
        Me.R5.AutoSize = True
        Me.R5.BackColor = System.Drawing.Color.White
        Me.R5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.R5.Location = New System.Drawing.Point(6, 20)
        Me.R5.Name = "R5"
        Me.R5.Size = New System.Drawing.Size(29, 16)
        Me.R5.TabIndex = 9
        Me.R5.TabStop = True
        Me.R5.Text = "5"
        Me.R5.UseVisualStyleBackColor = False
        '
        'B1
        '
        Me.B1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.B1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.B1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B1.ForeColor = System.Drawing.Color.Black
        Me.B1.Location = New System.Drawing.Point(12, 151)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(85, 25)
        Me.B1.TabIndex = 17
        Me.B1.Text = "← 이전으로"
        Me.B1.UseVisualStyleBackColor = False
        '
        'B2
        '
        Me.B2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.B2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.B2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B2.ForeColor = System.Drawing.Color.Black
        Me.B2.Location = New System.Drawing.Point(296, 151)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(85, 25)
        Me.B2.TabIndex = 18
        Me.B2.Text = "→ 다음으로"
        Me.B2.UseVisualStyleBackColor = False
        '
        'Step2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(393, 186)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GB1)
        Me.Controls.Add(Me.L1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Step2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "퍼즐 크기 설정"
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents R9 As System.Windows.Forms.RadioButton
    Friend WithEvents R4 As System.Windows.Forms.RadioButton
    Friend WithEvents R12 As System.Windows.Forms.RadioButton
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents R16 As System.Windows.Forms.RadioButton
    Friend WithEvents R6 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents R15 As System.Windows.Forms.RadioButton
    Friend WithEvents R14 As System.Windows.Forms.RadioButton
    Friend WithEvents R13 As System.Windows.Forms.RadioButton
    Friend WithEvents R11 As System.Windows.Forms.RadioButton
    Friend WithEvents R10 As System.Windows.Forms.RadioButton
    Friend WithEvents R8 As System.Windows.Forms.RadioButton
    Friend WithEvents R7 As System.Windows.Forms.RadioButton
    Friend WithEvents R5 As System.Windows.Forms.RadioButton
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
End Class
