<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistryEditor
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HKEY_CLASSES_ROOT")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HKEY_CURRENT_USER")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HKEY_LOCAL_MACHINE")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HKEY_USERS")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistryEditor))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.RGk = New System.Windows.Forms.TreeView()
        Me.crgk = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.RGLIST = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.crg = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pr = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.EditKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.crgk.SuspendLayout()
        Me.crg.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 383)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(904, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'RGk
        '
        Me.RGk.ContextMenuStrip = Me.crgk
        Me.RGk.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RGk.Dock = System.Windows.Forms.DockStyle.Left
        Me.RGk.ImageIndex = 0
        Me.RGk.ImageList = Me.img
        Me.RGk.Location = New System.Drawing.Point(0, 0)
        Me.RGk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RGk.Name = "RGk"
        TreeNode1.Name = "HKEY_CLASSES_ROOT"
        TreeNode1.Text = "HKEY_CLASSES_ROOT"
        TreeNode2.Name = "HKEY_CURRENT_USER"
        TreeNode2.Text = "HKEY_CURRENT_USER"
        TreeNode3.Name = "HKEY_LOCAL_MACHINE"
        TreeNode3.Text = "HKEY_LOCAL_MACHINE"
        TreeNode4.Name = "HKEY_USERS"
        TreeNode4.Text = "HKEY_USERS"
        Me.RGk.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Me.RGk.SelectedImageIndex = 0
        Me.RGk.Size = New System.Drawing.Size(311, 383)
        Me.RGk.TabIndex = 2
        '
        'crgk
        '
        Me.crgk.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.crgk.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem1, Me.EditKeyToolStripMenuItem, Me.CreateKeyToolStripMenuItem, Me.DeleteKeyToolStripMenuItem})
        Me.crgk.Name = "crgk"
        Me.crgk.Size = New System.Drawing.Size(155, 108)
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.Image = CType(resources.GetObject("RefreshToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(154, 26)
        Me.RefreshToolStripMenuItem1.Text = "Refresh"
        '
        'CreateKeyToolStripMenuItem
        '
        Me.CreateKeyToolStripMenuItem.Image = CType(resources.GetObject("CreateKeyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CreateKeyToolStripMenuItem.Name = "CreateKeyToolStripMenuItem"
        Me.CreateKeyToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.CreateKeyToolStripMenuItem.Text = "Create Key"
        '
        'DeleteKeyToolStripMenuItem
        '
        Me.DeleteKeyToolStripMenuItem.Image = CType(resources.GetObject("DeleteKeyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteKeyToolStripMenuItem.Name = "DeleteKeyToolStripMenuItem"
        Me.DeleteKeyToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.DeleteKeyToolStripMenuItem.Text = "Delete Key"
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "folder-0.png")
        Me.img.Images.SetKeyName(1, "key.png")
        Me.img.Images.SetKeyName(2, "value.png")
        '
        'RGLIST
        '
        Me.RGLIST.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.RGLIST.ContextMenuStrip = Me.crgk
        Me.RGLIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RGLIST.Location = New System.Drawing.Point(311, 0)
        Me.RGLIST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RGLIST.Name = "RGLIST"
        Me.RGLIST.Size = New System.Drawing.Size(593, 383)
        Me.RGLIST.SmallImageList = Me.img
        Me.RGLIST.TabIndex = 3
        Me.RGLIST.UseCompatibleStateImageBehavior = False
        Me.RGLIST.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Value"
        Me.ColumnHeader3.Width = 100
        '
        'crg
        '
        Me.crg.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.crg.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.EditToolStripMenuItem, Me.NewValueToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.crg.Name = "crg"
        Me.crg.Size = New System.Drawing.Size(154, 108)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = CType(resources.GetObject("EditToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'NewValueToolStripMenuItem
        '
        Me.NewValueToolStripMenuItem.Image = CType(resources.GetObject("NewValueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewValueToolStripMenuItem.Name = "NewValueToolStripMenuItem"
        Me.NewValueToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.NewValueToolStripMenuItem.Text = "New Value"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'pr
        '
        Me.pr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pr.Location = New System.Drawing.Point(3, 385)
        Me.pr.Name = "pr"
        Me.pr.Size = New System.Drawing.Size(124, 19)
        Me.pr.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Status : Ready"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(311, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 383)
        Me.Splitter1.TabIndex = 8
        Me.Splitter1.TabStop = False
        '
        'EditKeyToolStripMenuItem
        '
        Me.EditKeyToolStripMenuItem.Image = CType(resources.GetObject("EditKeyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditKeyToolStripMenuItem.Name = "EditKeyToolStripMenuItem"
        Me.EditKeyToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.EditKeyToolStripMenuItem.Text = "Edit Key"
        '
        'RegistryEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 405)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pr)
        Me.Controls.Add(Me.RGLIST)
        Me.Controls.Add(Me.RGk)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "RegistryEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registry Editor ["
        Me.crgk.ResumeLayout(False)
        Me.crg.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents RGk As TreeView
    Friend WithEvents RGLIST As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents img As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pr As ProgressBar
    Friend WithEvents crg As ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewValueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents crgk As ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CreateKeyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteKeyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents EditKeyToolStripMenuItem As ToolStripMenuItem
End Class
