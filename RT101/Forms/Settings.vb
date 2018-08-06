Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Settings
    Dim CheckedFromUSer As Boolean = False
    Public runauto As Boolean = False
    Sub PressB(sender As Object, e As EventArgs)

        startstop_Click(sender, e)
    End Sub

    Public Function GetExternalIp() As String
        Try
            Dim ExternalIP As String
            ExternalIP = (New WebClient()).DownloadString("http://checkip.dyndns.org/")
            ExternalIP = (New Regex("\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")) _
                     .Matches(ExternalIP)(0).ToString()
            Return ExternalIP
        Catch
            Return Nothing
        End Try
    End Function

    Private Sub startstop_Click(sender As Object, e As EventArgs) Handles startstop.Click
        If startstop.Text = "Start Listening" Then
            If runauto = True Then
                Dim values() As String = File.ReadAllText(Application.StartupPath & "\Settings" & "\Settings.ini").Split("|"c)
                NumericUpDown1.Value = values(0)
                runauto = False
            End If


            Form1.S.Start(NumericUpDown1.Value)
            Form1.PasswordSocket = passwd.Text
            startstop.Text = "Stop Listening"
            passwd.Enabled = False
            NumericUpDown1.Enabled = False
            Form1.portlabel.Text = NumericUpDown1.Value.ToString
            Form1.iplabel.Text = GetExternalIp().ToString


        ElseIf startstop.Text = "Stop Listening" Then


            For Each x As ListViewItem In Form1.L1.Items
                Form1.S.Disconnect(x.ToolTipText)
            Next
            Form1.S.stops()
            startstop.Text = "Start Listening"
            NumericUpDown1.Enabled = True
            passwd.Enabled = True
            Form1.portlabel.Text = "-"
            Form1.iplabel.Text = "-"
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            passwd.UseSystemPasswordChar = False
        Else
            passwd.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.portlabel.Text <> "-" Then
            startstop.Text = "Stop Listening"
            passwd.Enabled = False
            NumericUpDown1.Enabled = False
        End If
        Dim values() As String = File.ReadAllText(Application.StartupPath & "\Settings" & "\Settings.ini").Split("|"c)
        If values(0) <> "" Then
            NumericUpDown1.Value = Convert.ToInt32(values(0))
        End If
        If values(1) <> "" Then
            passwd.Text = values(1)
        End If
        If values(2) = "True" Then
            CheckBox3.Checked = True
        Else
            CheckBox3.Checked = False
        End If
        If values(3) = "True" Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
        If values(4) = "True" Then
            CheckBox2.Checked = True
        Else
            CheckBox2.Checked = False
        End If
        If values(5) = "True" Then
            CheckBox4.Checked = True
        Else
            CheckBox4.Checked = False
        End If
        If values(6) = "True" Then
            CheckBox5.Checked = True
        Else
            CheckBox5.Checked = False
        End If
        If values(7) = "True" Then
            CheckBox6.Checked = True
        Else
            CheckBox6.Checked = False
        End If
        CheckedFromUSer = True

    End Sub

    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If File.Exists(Application.StartupPath & "\Settings" & "\Settings.ini") Then
                File.Delete(Application.StartupPath & "\Settings" & "\Settings.ini")
            End If
            Dim globString As String
            Using sw As StreamWriter = File.AppendText(Application.StartupPath & "\Settings" & "\Settings.ini")

                ' Saving Checkboxes States

                globString += NumericUpDown1.Value.ToString & "|"
                globString += passwd.Text & "|"
                If CheckBox3.Checked = True Then
                    globString += "True|"
                Else
                    globString += "False|"
                End If
                If CheckBox1.Checked = True Then
                    globString += "True|"
                Else
                    globString += "False|"
                End If
                If CheckBox2.Checked = True Then
                    globString += "True|"
                Else
                    globString += "False|"
                End If
                If CheckBox4.Checked = True Then
                    globString += "True|"
                Else
                    globString += "False|"
                End If

                If CheckBox5.Checked = True Then
                    globString += "True|"
                Else
                    globString += "False|"
                End If
                If CheckBox6.Checked = True Then
                    Form1.notifydisconnect = True
                    globString += "True|"
                Else
                    Form1.notifydisconnect = False
                    globString += "False|"
                End If

                sw.WriteLine(globString)
            End Using

        Catch : End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If File.Exists(Application.StartupPath & "\Settings" & "\Settings.ini") Then
                File.Delete(Application.StartupPath & "\Settings" & "\Settings.ini")
            End If
            Dim globString As String
            Using sw As StreamWriter = File.AppendText(Application.StartupPath & "\Settings\" & "\Settings.ini")

                ' Saving Checkboxes States

                globString += NumericUpDown1.Value.ToString & "|"
                globString += passwd.Text & "|"
                If CheckBox3.Checked = True Then
                    globString += "True|"
                Else
                    globString += "False|"
                End If
                If CheckBox1.Checked = True Then
                    globString += "True|"
                Else
                    globString += "False|"
                End If
                If CheckBox2.Checked = True Then
                    globString += "True|"
                Else
                    globString += "False|"
                End If
                If CheckBox4.Checked = True Then
                    globString += "True|"
                Else
                    globString += "False|"
                End If
                If CheckBox5.Checked = True Then
                    globString += "True|"
                Else
                    globString += "False|"
                End If
                If CheckBox6.Checked = True Then
                    Form1.notifydisconnect = True
                    globString += "True|"
                Else
                    Form1.notifydisconnect = False
                    globString += "False|"
                End If

                sw.WriteLine(globString)
                Me.Close()
            End Using

        Catch : End Try
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Form1.ClearTheme(Form1.L1)
            Form1.L1.GridLines = True
        ElseIf CheckBox4.Checked = False Then

            Form1.ApplyTheme(Form1.L1)
            Form1.L1.GridLines = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckedFromUSer = True Then
            If CheckBox5.Checked = True Then
                PasswordProtect.ShowDialog()
            ElseIf CheckBox5.Checked = False Then
                My.Settings.PasswordPr = ""
                My.Settings.Save()
            End If

        End If
    End Sub

End Class