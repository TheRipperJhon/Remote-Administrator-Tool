Public Class PasswordProtect
    Public K As String = "yhByz84zV8f$zaztg5YvVSzB#u^9Djwv4#qCx#6J@DYry#cwXgjAwmg6&J%QNJR&"
    Private m_iMessage As Integer
    Private Shared WM_QUERYENDSESSION As Integer = &H11 'this is a logoff, shutdown, or reboot
    Private Shared WM_FORMCONTROLMENU As Integer = 16 'form closed via form control menu
    Dim closingwithsave As Boolean = False
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        m_iMessage = m.Msg

        ' If this is WM_QUERYENDSESSION, the closing event should be fired in the base WndProc
        MyBase.WndProc(m)

    End Sub 'WndProc

    Private Sub PasswordProtect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.PasswordPr <> "" Then
            oldps.Enabled = True
            CheckBox2.Enabled = True
        Else
            oldps.Enabled = False
            CheckBox2.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            oldps.UseSystemPasswordChar = False
        ElseIf CheckBox2.Checked = False Then
            oldps.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            newps.UseSystemPasswordChar = False
            newps2.UseSystemPasswordChar = False
        ElseIf CheckBox1.Checked = False Then
            newps.UseSystemPasswordChar = True
            newps2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If oldps.Enabled = False Then
            'Check for password match
            If newps.Text = newps2.Text Then
                'Match
                If newps2.Text.Length < 6 Then
                    MessageBox.Show("Insert 6 chars or more!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                My.Settings.PasswordPr = AES_Encrypt(newps2.Text, K)
                My.Settings.Save()
                MessageBox.Show("Password saved!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Settings.CheckBox5.Checked = True
                closingwithsave = True
                Me.Close()

            Else
                MessageBox.Show("Passwords don't match!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Else
            'Old Password check
            If oldps.Text = "" Then
                MessageBox.Show("Insert old password!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                'Don't match old ps
                If oldps.Text <> AES_Decrypt(My.Settings.PasswordPr, K) Then
                    MessageBox.Show("Old password is wrong!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    If newps.Text = newps2.Text Then
                        'Match
                        If newps2.Text.Length < 6 Then
                            MessageBox.Show("Insert 6 chars or more!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                        My.Settings.PasswordPr = AES_Encrypt(newps2.Text, K)
                        My.Settings.Save()
                        MessageBox.Show("Password saved!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Settings.CheckBox5.Checked = True
                        closingwithsave = True
                        Me.Close()

                    Else
                        MessageBox.Show("Passwords don't match!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Settings.CheckBox5.Checked = False
        Me.Close()
    End Sub

    Private Sub PasswordProtect_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If m_iMessage = WM_FORMCONTROLMENU Then
            If closingwithsave = True Then
            Else
                Settings.CheckBox5.Checked = False
                closingwithsave = False
            End If

        End If
    End Sub
End Class