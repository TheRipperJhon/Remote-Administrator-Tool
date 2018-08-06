Imports System.Net
Public Class HostnameResolver

    Public Function GetHostNameFromIP(ByRef IP As String) As String
        Try
            Dim host As IPHostEntry = Dns.GetHostEntry(IP.Trim())
            Dim ipaddr As IPAddress() = host.AddressList
            ' Loop through the IP Address array and add the IP address to Listbox
            For Each addr As IPAddress In ipaddr

                TextBox2.Text += addr.ToString() & Environment.NewLine

            Next addr
            ' Catch unknown host names
        Catch ex As System.Net.Sockets.SocketException
            MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter a valid IP address!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            GetHostNameFromIP(TextBox1.Text)
        End If

    End Sub
End Class