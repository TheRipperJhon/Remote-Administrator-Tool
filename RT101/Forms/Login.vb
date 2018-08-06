Imports System.IO


Public Class Login
    Dim flagclose As Boolean = False

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            key.UseSystemPasswordChar = False
        ElseIf CheckBox1.Checked = False Then
            key.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If key.Text = AES_Decrypt(My.Settings.PasswordPr, PasswordProtect.K) Then
            flagclose = True
            Me.Close()
        Else
            MessageBox.Show("Authentication failed!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If flagclose = False Then
            Application.Exit()
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class