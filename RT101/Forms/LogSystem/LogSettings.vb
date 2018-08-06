Imports System.IO

Public Class LogSettings
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        preview.Text = Application.StartupPath & "\" & TextBox1.Text & "\" & TextBox2.Text & ".txt"
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        preview.Text = Application.StartupPath & "\" & TextBox1.Text & "\" & TextBox2.Text & ".txt"
    End Sub

    Private Sub LogSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim values() As String = File.ReadAllText(Application.StartupPath & "\Settings\" & "\LogsSettings.ini").Split("|"c)
        If values(0) <> "" Then
            TextBox1.Text = values(0)
        End If
        If values(1) <> "" Then
            TextBox2.Text = values(1)
        End If
        If values(2) = "True" Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If File.Exists(Application.StartupPath & "\Settings\" & "\LogsSettings.ini") Then
                File.Delete(Application.StartupPath & "\Settings\" & "\LogsSettings.ini")
            End If
            Dim globString As String
            Using sw As StreamWriter = File.AppendText(Application.StartupPath & "\Settings\" & "\LogsSettings.ini")
                If TextBox1.Text <> "" Then
                    globString += TextBox1.Text & "|"
                End If
                If TextBox2.Text <> "" Then
                    globString += TextBox2.Text & "|"
                End If
                If CheckBox1.Checked = True Then
                    globString += "True|"
                Else
                    globString += "False|"
                End If
                sw.WriteLine(globString)
                Me.Close()
            End Using

        Catch : End Try

    End Sub

    Private Sub LogSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If File.Exists(Application.StartupPath & "\Settings\" & "\LogsSettings.ini") Then
                File.Delete(Application.StartupPath & "\Settings\" & "\LogsSettings.ini")
            End If
            Dim globString As String
            Using sw As StreamWriter = File.AppendText(Application.StartupPath & "\Settings\" & "\LogsSettings.ini")
                If TextBox1.Text <> "" Then
                    globString += TextBox1.Text & "|"
                End If
                If TextBox2.Text <> "" Then
                    globString += TextBox2.Text & "|"
                End If
                If CheckBox1.Checked = True Then
                    globString += "True|"
                Else
                    globString += "False|"
                End If
                sw.WriteLine(globString)
                Me.Close()
            End Using

        Catch : End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.Enabled = False
        ElseIf CheckBox1.Checked = False Then
            TextBox2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class