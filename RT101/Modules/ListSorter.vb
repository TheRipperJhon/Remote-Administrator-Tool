'Visual Basic 
' Implements the manual sorting of items by column.
Class ListViewItemComparer
    Implements IComparer
    Private col As Integer

    Public Sub New()
        col = 0
    End Sub

    Public Sub New(column As Integer)
        col = column
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer _
                            Implements System.Collections.IComparer.Compare
        Dim returnVal As Integer = -1
        returnVal = [String].Compare(CType(x,
                        ListViewItem).SubItems(col).Text,
                        CType(y, ListViewItem).SubItems(col).Text)
        Return returnVal
    End Function
End Class
