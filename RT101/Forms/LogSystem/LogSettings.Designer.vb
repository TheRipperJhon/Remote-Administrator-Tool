<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogSettings
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Divider1 = New RT101V001.Divider()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.preview = New System.Windows.Forms.TextBox()
        Me.Divider2 = New RT101V001.Divider()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Log Folder :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(100, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(143, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(285, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Log Filename :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(388, 62)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(96, 26)
        Me.TextBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "File Settings"
        '
        'Divider1
        '
        Me.Divider1.Location = New System.Drawing.Point(100, 20)
        Me.Divider1.Name = "Divider1"
        Me.Divider1.Size = New System.Drawing.Size(383, 23)
        Me.Divider1.TabIndex = 5
        Me.Divider1.Text = "Divider1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Log Folder Preview:"
        '
        'preview
        '
        Me.preview.BackColor = System.Drawing.Color.White
        Me.preview.Location = New System.Drawing.Point(147, 103)
        Me.preview.Name = "preview"
        Me.preview.ReadOnly = True
        Me.preview.Size = New System.Drawing.Size(336, 26)
        Me.preview.TabIndex = 7
        '
        'Divider2
        '
        Me.Divider2.Location = New System.Drawing.Point(127, 179)
        Me.Divider2.Name = "Divider2"
        Me.Divider2.Size = New System.Drawing.Size(356, 23)
        Me.Divider2.TabIndex = 9
        Me.Divider2.Text = "Divider2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "General Settings"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(17, 207)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(272, 23)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Generate a new log file for each session"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(368, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 28)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(247, 277)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 28)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 6.8!, System.Drawing.FontStyle.Italic)
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(9, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Every change will be effective on next start."
        '
        'LogSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 317)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Divider2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.preview)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Divider1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LogSettings"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Logs Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Divider1 As Divider
    Friend WithEvents Label4 As Label
    Friend WithEvents preview As TextBox
    Friend WithEvents Divider2 As Divider
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
End Class
