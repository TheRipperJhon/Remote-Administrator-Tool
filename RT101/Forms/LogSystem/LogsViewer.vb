Imports System.IO

Public Class LogsViewer
    Private Sub LogsViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Logs Viewer [ " & My.Settings.LogFolder & "\" & My.Settings.LogFile & ".txt" & " ]"
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\" & My.Settings.LogFolder & "\" & My.Settings.LogFile & ".txt")
        TextBox1.Text = fileReader.ToString

        TextBox1.SelectionStart = TextBox1.Text.Length

    End Sub
End Class