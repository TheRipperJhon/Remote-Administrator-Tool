Imports System.Net.Sockets

Public Class PortCheck

    ''' <summary>
    ''' Checks to see if a TCP port is open on a specified device
    ''' </summary>
    ''' <param name="Host">The name or IP address of the device to check for the open port on</param>
    ''' <param name="PortNumber">The TCP port to test</param>
    Private Function IsPortOpen(ByVal Host As String, ByVal PortNumber As Integer) As Boolean
        Dim Client As TcpClient = Nothing
        Try
            Client = New TcpClient(Host, PortNumber)
            Return True
        Catch ex As SocketException
            Return False
        Finally
            If Not Client Is Nothing Then
                Client.Close()
            End If
        End Try
    End Function

    Private Sub PortCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Settings.GetExternalIp().ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Call the function
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter a valid IP address!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim PortOpen As Boolean = IsPortOpen(TextBox1.Text, NumericUpDown1.Value.ToString)
        Label3.Visible = True
        If PortOpen = True Then
            Label3.Text = "Success"
            Label3.ForeColor = Color.Green
            TextBox2.Text = "Service at " & TextBox1.Text & " is running, port " & NumericUpDown1.Value.ToString & " is open."
        Else
            Label3.Text = "Error"
            Label3.ForeColor = Color.Red
            TextBox2.Text = "Service at " & TextBox1.Text & " is not running or port " & NumericUpDown1.Value.ToString & " is closed."
        End If

    End Sub
End Class