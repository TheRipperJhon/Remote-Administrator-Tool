Imports System.IO
Public Class Icon_Changer
    Dim ico As New OpenFileDialog
    Dim exe As New OpenFileDialog
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        exe.Filter = "Exe|*.exe"
        exe.Title = "Exe File"
        exe.ShowDialog()
        TextBox1.Text = exe.FileName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ico.Filter = "Ico|*.ico"
        ico.Title = "Ico"
        ico.ShowDialog()
        TextBox2.Text = ico.FileName
        Try
            PictureBox1.Image = Image.FromFile(ico.FileName)
        Catch es As Exception
            MessageBox.Show("Error: " & es.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please select a valid exe file!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("Please select a valid icon file!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            IconInjector.InjectIcon(exe.FileName, ico.FileName)
            MessageBox.Show("Icon successfully injected!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

    End Sub
End Class