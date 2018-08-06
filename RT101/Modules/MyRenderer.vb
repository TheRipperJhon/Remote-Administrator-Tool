Public Class MyRenderer
    Inherits ToolStripProfessionalRenderer
    Dim GrayBrush As New SolidBrush(Color.FromArgb(95, 95, 95))
    Dim BlueBrush As New SolidBrush(Color.FromArgb(50, 150, 255))

    Dim GrayPen As New Pen(Color.FromArgb(95, 95, 95))



    Protected Overrides Sub OnRenderToolStripBorder(e As System.Windows.Forms.ToolStripRenderEventArgs)
        MyBase.OnRenderToolStripBorder(e)
        e.Graphics.FillRectangle(GrayBrush, e.ConnectedArea)
        e.Graphics.DrawRectangle(GrayPen, New Rectangle(0, 1, e.AffectedBounds.Width - 2, e.AffectedBounds.Height - 3))
    End Sub

    Protected Overrides Sub OnRenderMenuItemBackground(ByVal e As System.Windows.Forms.ToolStripItemRenderEventArgs)
        If e.Item.Selected Then
            e.Graphics.FillRectangle(BlueBrush, New Rectangle(Point.Empty, e.Item.Size))
        Else
            e.Graphics.FillRectangle(GrayBrush, New Rectangle(Point.Empty, e.Item.Size))
        End If
    End Sub

End Class