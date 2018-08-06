Imports System.IO

Module LogClass

    Public Function Writelog(ByVal action As String)
        Dim logfile As String = ""
        Dim valueslogs() As String = File.ReadAllText(Application.StartupPath & "\Settings\" & "\LogsSettings.ini").Split("|"c)
        If valueslogs(2) = "True" Then
            logfile = Application.StartupPath & "\" & My.Settings.LogFolder & "\" & DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss_SESSION") & ".txt"
        Else
            logfile = Application.StartupPath & "\" & My.Settings.LogFolder & "\" & My.Settings.LogFile & ".txt"

        End If

        If Not File.Exists(logfile) Then
            ' Create a file to write to.
            Using sw As StreamWriter = File.CreateText(logfile)
                sw.WriteLine(DateTime.Now.ToString("[dd/MM/yyyy HH:mm:ss] ") & action)
            End Using
        Else
            Using sw As StreamWriter = File.AppendText(logfile)
                sw.WriteLine(DateTime.Now.ToString("[dd/MM/yyyy HH:mm:ss] ") & action)
            End Using
        End If
    End Function

End Module
