Namespace OnControl

    Module ControlStore
        Public Function NewLBe() As Control
            Dim LinkA As New Label
            LinkA.Font = New System.Drawing.Font("Arial", 20)
            LinkA.Size = New Size(30, 30)
            LinkA.BackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255)
            Return LinkA
        End Function

        Public Function NewCB(ByVal Name As String) As Control
            Dim LinkA As New Button
            LinkA.Cursor = Cursors.Hand
            LinkA.Name = Name
            LinkA.FlatStyle = FlatStyle.Flat
            LinkA.Enabled = False
            Return LinkA
        End Function

        Public Function RemoteButton(ByVal Name As String, ByVal Number As String)
            Dim LinkA As New Button
            LinkA.Cursor = Cursors.Hand
            LinkA.Name = Name
            LinkA.Visible = False
            LinkA.Text = Number
            LinkA.Font = New System.Drawing.Font("Arial", 18)
            LinkA.TabStop = False
            LinkA.TabIndex = 0
            Return LinkA
        End Function

        Public Function NewTB(ByVal Name As String) As Control
            Dim LinkA As New TextBox
            LinkA.TextAlign = HorizontalAlignment.Center
            LinkA.Cursor = Cursors.Arrow
            LinkA.Multiline = True
            LinkA.Name = Name
            Return LinkA
        End Function

        Public Function NewRTB(ByVal Name As String) As Control
            Dim LinkA As New RichTextBox
            LinkA.Cursor = Cursors.Arrow
            LinkA.Multiline = True
            LinkA.Name = Name
            LinkA.ScrollBars = RichTextBoxScrollBars.None
            LinkA.BorderStyle = BorderStyle.None
            Return (LinkA)
        End Function

    End Module
End Namespace