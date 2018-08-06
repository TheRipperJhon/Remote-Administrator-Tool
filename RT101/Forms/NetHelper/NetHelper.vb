Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Runtime.InteropServices

Public Class NetHelper

    <DllImport("dnsapi.dll", EntryPoint:="DnsFlushResolverCache")>
    Private Shared Function DnsFlushResolverCache() As UInt32
    End Function

    Public Shared Sub FlushMyCache()
        Dim result As UInt32 = DnsFlushResolverCache()
    End Sub

    Private Sub NetHelper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim basicinfo As String = ""
        Dim strHostName As String
        Dim strIPAddress As String
        Dim IpAddressString As [String] = IPAddress.Loopback.ToString()
        strHostName = System.Net.Dns.GetHostName()
        Dim myNetworkAdapters() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        Dim myAdapterProps As IPInterfaceProperties = Nothing
        Dim myGateways As GatewayIPAddressInformationCollection = Nothing




        basicinfo += "Hostname:" & Environment.NewLine & Environment.MachineName & Environment.NewLine & Environment.NewLine
        basicinfo += "WAN Address:" & Environment.NewLine & Settings.GetExternalIp().ToString & Environment.NewLine & Environment.NewLine
        basicinfo += "LAN Address:" & Environment.NewLine & System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString() & Environment.NewLine & Environment.NewLine
        basicinfo += "Loopback Address:" & Environment.NewLine & IpAddressString & Environment.NewLine & Environment.NewLine
        For Each adapter As NetworkInterface In myNetworkAdapters
            myAdapterProps = adapter.GetIPProperties
            myGateways = myAdapterProps.GatewayAddresses
            For Each Gateway As GatewayIPAddressInformation In myGateways
                If Gateway.Address.ToString = "::" Then
                Else
                    basicinfo += "Gateway Address:" & Environment.NewLine & Gateway.Address.ToString & Environment.NewLine & Environment.NewLine
                End If

            Next
        Next
        TextBox1.Text = basicinfo

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        PortCheck.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        PortCheck.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            FlushMyCache()
            MessageBox.Show("DNS cache successfully flushed!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HostnameResolver.ShowDialog()
    End Sub
End Class