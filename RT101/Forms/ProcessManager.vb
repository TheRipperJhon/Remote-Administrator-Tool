Imports System.ComponentModel

Public Class ProcessManager
    Public yy As String = "|SPX|"
    Public sock As Integer
    Public WithEvents bw As BackgroundWorker = New BackgroundWorker
    Dim state As Integer
    Dim time As Integer
    Private Sub ProcessManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.ApplyTheme(PListView)
        ToolStripStatusLabel1.Text = "Status: Receiving feeds ..."
        If state = 1 Then
            ToolStripStatusLabel1.Text = "Status: Auto Update Every " & time / 1000 & " Sec."
            Timer1.Interval = time
            Timer1.Start()
        Else
            ToolStripStatusLabel1.Text = "Status: Ready"
            Timer1.Stop()
        End If
        Form1.S.Send(sock, "GetProcesses")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PListView.Items.Clear()
        If Not bw.IsBusy = True Then
            bw.RunWorkerAsync()
        End If
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bw.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Threading.Thread.Sleep(100)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bw.RunWorkerCompleted
        Form1.S.Send(sock, "GetProcesses")
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ToolStripStatusLabel1.Text = "Status: Refreshing ..."
        PListView.Items.Clear()
        Threading.Thread.Sleep(100)
        If Not bw.IsBusy = True Then
            bw.RunWorkerAsync()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToolStripStatusLabel1.Text = "Status: Killing process ..."
        Dim allprocess As String = ""
        For Each item As ListViewItem In PListView.SelectedItems
            allprocess += (item.Text.Replace(".exe", "") & "ProcessSplit")
        Next
        Form1.S.Send(sock, "KillProcess" & Form1.Yy & allprocess)

        PListView.Items.Clear()
        If Not bw.IsBusy = True Then
            bw.RunWorkerAsync()
        End If
    End Sub

    Private Sub SuspenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuspenToolStripMenuItem.Click
        ToolStripStatusLabel1.Text = "Status: Process suspended"
        Dim allprocess As String = ""
        For Each item As ListViewItem In PListView.SelectedItems
            allprocess += (item.Text.Replace(".exe", "") & "ProcessSplit")
        Next
        Form1.S.Send(sock, "SProcess" & Form1.Yy & allprocess)
    End Sub

    Private Sub PListView_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles PListView.ColumnClick
        Me.PListView.ListViewItemSorter = New ListViewItemComparer(e.Column)
        ' Call the sort method to manually sort.
        PListView.Sort()
    End Sub

    Private Sub EndProcessToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim allprocess As String = ""
        For Each item As ListViewItem In PListView.SelectedItems
            allprocess += (item.Text & "ProcessSplit")
        Next
        Form1.S.Send(sock, "KillProcess" & Form1.Yy & allprocess)
        PListView.Items.Clear()
        If Not bw.IsBusy = True Then
            bw.RunWorkerAsync()
        End If
    End Sub
End Class