<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordProtect
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.oldps = New System.Windows.Forms.TextBox()
        Me.newps = New System.Windows.Forms.TextBox()
        Me.Divider1 = New RT101V001.Divider()
        Me.newps2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Old password :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New password :"
        '
        'oldps
        '
        Me.oldps.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oldps.Location = New System.Drawing.Point(196, 27)
        Me.oldps.Name = "oldps"
        Me.oldps.Size = New System.Drawing.Size(230, 26)
        Me.oldps.TabIndex = 2
        Me.oldps.UseSystemPasswordChar = True
        '
        'newps
        '
        Me.newps.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.newps.Location = New System.Drawing.Point(196, 175)
        Me.newps.Name = "newps"
        Me.newps.Size = New System.Drawing.Size(230, 26)
        Me.newps.TabIndex = 3
        Me.newps.UseSystemPasswordChar = True
        '
        'Divider1
        '
        Me.Divider1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Divider1.Location = New System.Drawing.Point(16, 104)
        Me.Divider1.Name = "Divider1"
        Me.Divider1.Size = New System.Drawing.Size(410, 23)
        Me.Divider1.TabIndex = 4
        Me.Divider1.Text = "Divider1"
        '
        'newps2
        '
        Me.newps2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.newps2.Location = New System.Drawing.Point(196, 207)
        Me.newps2.Name = "newps2"
        Me.newps2.Size = New System.Drawing.Size(230, 26)
        Me.newps2.TabIndex = 6
        Me.newps2.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirm New Password :"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(196, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 30)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(316, 295)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 30)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(196, 239)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(132, 23)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Show Passwords"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(196, 59)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(126, 23)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "Show Password"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(12, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(325, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "If you loose you password you'll never access again."
        '
        'PasswordProtect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 337)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.newps2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Divider1)
        Me.Controls.Add(Me.newps)
        Me.Controls.Add(Me.oldps)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PasswordProtect"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Password Protection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents oldps As TextBox
    Friend WithEvents newps As TextBox
    Friend WithEvents Divider1 As Divider
    Friend WithEvents newps2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label5 As Label
End Class
