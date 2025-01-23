﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        MenuStrip = New MenuStrip()
        FileMenu = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        PrintToolStripMenuItem = New ToolStripMenuItem()
        PrintPreviewToolStripMenuItem = New ToolStripMenuItem()
        PrintSetupToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditMenu = New ToolStripMenuItem()
        UndoToolStripMenuItem = New ToolStripMenuItem()
        RedoToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator6 = New ToolStripSeparator()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator7 = New ToolStripSeparator()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        ViewMenu = New ToolStripMenuItem()
        ToolBarToolStripMenuItem = New ToolStripMenuItem()
        StatusBarToolStripMenuItem = New ToolStripMenuItem()
        ToolsMenu = New ToolStripMenuItem()
        OptionsToolStripMenuItem = New ToolStripMenuItem()
        WindowsMenu = New ToolStripMenuItem()
        NewWindowToolStripMenuItem = New ToolStripMenuItem()
        CascadeToolStripMenuItem = New ToolStripMenuItem()
        TileVerticalToolStripMenuItem = New ToolStripMenuItem()
        TileHorizontalToolStripMenuItem = New ToolStripMenuItem()
        CloseAllToolStripMenuItem = New ToolStripMenuItem()
        ArrangeIconsToolStripMenuItem = New ToolStripMenuItem()
        HelpMenu = New ToolStripMenuItem()
        ContentsToolStripMenuItem = New ToolStripMenuItem()
        IndexToolStripMenuItem = New ToolStripMenuItem()
        SearchToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator8 = New ToolStripSeparator()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        ToolStrip = New ToolStrip()
        NewToolStripButton = New ToolStripButton()
        OpenToolStripButton = New ToolStripButton()
        SaveToolStripButton = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        PrintToolStripButton = New ToolStripButton()
        PrintPreviewToolStripButton = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        HelpToolStripButton = New ToolStripButton()
        StatusStrip = New StatusStrip()
        ToolStripProgressBar1 = New ToolStripProgressBar()
        ToolTip = New ToolTip(components)
        MenuStrip.SuspendLayout()
        ToolStrip.SuspendLayout()
        StatusStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.ImageScalingSize = New Size(24, 24)
        MenuStrip.Items.AddRange(New ToolStripItem() {FileMenu, EditMenu, ViewMenu, ToolsMenu, WindowsMenu, HelpMenu})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.MdiWindowListItem = WindowsMenu
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Padding = New Padding(10, 4, 0, 4)
        MenuStrip.Size = New Size(789, 37)
        MenuStrip.TabIndex = 5
        MenuStrip.Text = "MenuStrip"
        ' 
        ' FileMenu
        ' 
        FileMenu.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, OpenToolStripMenuItem, ToolStripSeparator3, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ToolStripSeparator4, PrintToolStripMenuItem, PrintPreviewToolStripMenuItem, PrintSetupToolStripMenuItem, ToolStripSeparator5, ExitToolStripMenuItem})
        FileMenu.ImageTransparentColor = SystemColors.ActiveBorder
        FileMenu.Name = "FileMenu"
        FileMenu.Size = New Size(54, 29)
        FileMenu.Text = "&File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), Image)
        NewToolStripMenuItem.ImageTransparentColor = Color.Black
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.N
        NewToolStripMenuItem.Size = New Size(223, 34)
        NewToolStripMenuItem.Text = "&New"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), Image)
        OpenToolStripMenuItem.ImageTransparentColor = Color.Black
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        OpenToolStripMenuItem.Size = New Size(223, 34)
        OpenToolStripMenuItem.Text = "&Open"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(220, 6)
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), Image)
        SaveToolStripMenuItem.ImageTransparentColor = Color.Black
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SaveToolStripMenuItem.Size = New Size(223, 34)
        SaveToolStripMenuItem.Text = "&Save"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.Size = New Size(223, 34)
        SaveAsToolStripMenuItem.Text = "Save &As"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(220, 6)
        ' 
        ' PrintToolStripMenuItem
        ' 
        PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), Image)
        PrintToolStripMenuItem.ImageTransparentColor = Color.Black
        PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        PrintToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.P
        PrintToolStripMenuItem.Size = New Size(223, 34)
        PrintToolStripMenuItem.Text = "&Print"
        ' 
        ' PrintPreviewToolStripMenuItem
        ' 
        PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), Image)
        PrintPreviewToolStripMenuItem.ImageTransparentColor = Color.Black
        PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        PrintPreviewToolStripMenuItem.Size = New Size(223, 34)
        PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        ' 
        ' PrintSetupToolStripMenuItem
        ' 
        PrintSetupToolStripMenuItem.Name = "PrintSetupToolStripMenuItem"
        PrintSetupToolStripMenuItem.Size = New Size(223, 34)
        PrintSetupToolStripMenuItem.Text = "Print Setup"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(220, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(223, 34)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' EditMenu
        ' 
        EditMenu.DropDownItems.AddRange(New ToolStripItem() {UndoToolStripMenuItem, RedoToolStripMenuItem, ToolStripSeparator6, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, ToolStripSeparator7, SelectAllToolStripMenuItem})
        EditMenu.Name = "EditMenu"
        EditMenu.Size = New Size(58, 29)
        EditMenu.Text = "&Edit"
        ' 
        ' UndoToolStripMenuItem
        ' 
        UndoToolStripMenuItem.Image = CType(resources.GetObject("UndoToolStripMenuItem.Image"), Image)
        UndoToolStripMenuItem.ImageTransparentColor = Color.Black
        UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        UndoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Z
        UndoToolStripMenuItem.Size = New Size(248, 34)
        UndoToolStripMenuItem.Text = "&Undo"
        ' 
        ' RedoToolStripMenuItem
        ' 
        RedoToolStripMenuItem.Image = CType(resources.GetObject("RedoToolStripMenuItem.Image"), Image)
        RedoToolStripMenuItem.ImageTransparentColor = Color.Black
        RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        RedoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Y
        RedoToolStripMenuItem.Size = New Size(248, 34)
        RedoToolStripMenuItem.Text = "&Redo"
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(245, 6)
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), Image)
        CutToolStripMenuItem.ImageTransparentColor = Color.Black
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.X
        CutToolStripMenuItem.Size = New Size(248, 34)
        CutToolStripMenuItem.Text = "Cu&t"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), Image)
        CopyToolStripMenuItem.ImageTransparentColor = Color.Black
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
        CopyToolStripMenuItem.Size = New Size(248, 34)
        CopyToolStripMenuItem.Text = "&Copy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), Image)
        PasteToolStripMenuItem.ImageTransparentColor = Color.Black
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.V
        PasteToolStripMenuItem.Size = New Size(248, 34)
        PasteToolStripMenuItem.Text = "&Paste"
        ' 
        ' ToolStripSeparator7
        ' 
        ToolStripSeparator7.Name = "ToolStripSeparator7"
        ToolStripSeparator7.Size = New Size(245, 6)
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.A
        SelectAllToolStripMenuItem.Size = New Size(248, 34)
        SelectAllToolStripMenuItem.Text = "Select &All"
        ' 
        ' ViewMenu
        ' 
        ViewMenu.DropDownItems.AddRange(New ToolStripItem() {ToolBarToolStripMenuItem, StatusBarToolStripMenuItem})
        ViewMenu.Name = "ViewMenu"
        ViewMenu.Size = New Size(65, 29)
        ViewMenu.Text = "&View"
        ' 
        ' ToolBarToolStripMenuItem
        ' 
        ToolBarToolStripMenuItem.Checked = True
        ToolBarToolStripMenuItem.CheckOnClick = True
        ToolBarToolStripMenuItem.CheckState = CheckState.Checked
        ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        ToolBarToolStripMenuItem.Size = New Size(192, 34)
        ToolBarToolStripMenuItem.Text = "&Toolbar"
        ' 
        ' StatusBarToolStripMenuItem
        ' 
        StatusBarToolStripMenuItem.Checked = True
        StatusBarToolStripMenuItem.CheckOnClick = True
        StatusBarToolStripMenuItem.CheckState = CheckState.Checked
        StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        StatusBarToolStripMenuItem.Size = New Size(192, 34)
        StatusBarToolStripMenuItem.Text = "&Status Bar"
        ' 
        ' ToolsMenu
        ' 
        ToolsMenu.DropDownItems.AddRange(New ToolStripItem() {OptionsToolStripMenuItem})
        ToolsMenu.Name = "ToolsMenu"
        ToolsMenu.Size = New Size(69, 29)
        ToolsMenu.Text = "&Tools"
        ' 
        ' OptionsToolStripMenuItem
        ' 
        OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        OptionsToolStripMenuItem.Size = New Size(178, 34)
        OptionsToolStripMenuItem.Text = "&Options"
        ' 
        ' WindowsMenu
        ' 
        WindowsMenu.DropDownItems.AddRange(New ToolStripItem() {NewWindowToolStripMenuItem, CascadeToolStripMenuItem, TileVerticalToolStripMenuItem, TileHorizontalToolStripMenuItem, CloseAllToolStripMenuItem, ArrangeIconsToolStripMenuItem})
        WindowsMenu.Name = "WindowsMenu"
        WindowsMenu.Size = New Size(102, 29)
        WindowsMenu.Text = "&Windows"
        ' 
        ' NewWindowToolStripMenuItem
        ' 
        NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        NewWindowToolStripMenuItem.Size = New Size(227, 34)
        NewWindowToolStripMenuItem.Text = "&New Window"
        ' 
        ' CascadeToolStripMenuItem
        ' 
        CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        CascadeToolStripMenuItem.Size = New Size(227, 34)
        CascadeToolStripMenuItem.Text = "&Cascade"
        ' 
        ' TileVerticalToolStripMenuItem
        ' 
        TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        TileVerticalToolStripMenuItem.Size = New Size(227, 34)
        TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        ' 
        ' TileHorizontalToolStripMenuItem
        ' 
        TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        TileHorizontalToolStripMenuItem.Size = New Size(227, 34)
        TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        ' 
        ' CloseAllToolStripMenuItem
        ' 
        CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        CloseAllToolStripMenuItem.Size = New Size(227, 34)
        CloseAllToolStripMenuItem.Text = "C&lose All"
        ' 
        ' ArrangeIconsToolStripMenuItem
        ' 
        ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        ArrangeIconsToolStripMenuItem.Size = New Size(227, 34)
        ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons"
        ' 
        ' HelpMenu
        ' 
        HelpMenu.DropDownItems.AddRange(New ToolStripItem() {ContentsToolStripMenuItem, IndexToolStripMenuItem, SearchToolStripMenuItem, ToolStripSeparator8, AboutToolStripMenuItem})
        HelpMenu.Name = "HelpMenu"
        HelpMenu.Size = New Size(65, 29)
        HelpMenu.Text = "&Help"
        ' 
        ' ContentsToolStripMenuItem
        ' 
        ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        ContentsToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F1
        ContentsToolStripMenuItem.Size = New Size(255, 34)
        ContentsToolStripMenuItem.Text = "&Contents"
        ' 
        ' IndexToolStripMenuItem
        ' 
        IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), Image)
        IndexToolStripMenuItem.ImageTransparentColor = Color.Black
        IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        IndexToolStripMenuItem.Size = New Size(255, 34)
        IndexToolStripMenuItem.Text = "&Index"
        ' 
        ' SearchToolStripMenuItem
        ' 
        SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), Image)
        SearchToolStripMenuItem.ImageTransparentColor = Color.Black
        SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        SearchToolStripMenuItem.Size = New Size(255, 34)
        SearchToolStripMenuItem.Text = "&Search"
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(252, 6)
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(255, 34)
        AboutToolStripMenuItem.Text = "&About ..."
        ' 
        ' ToolStrip
        ' 
        ToolStrip.ImageScalingSize = New Size(24, 24)
        ToolStrip.Items.AddRange(New ToolStripItem() {NewToolStripButton, OpenToolStripButton, SaveToolStripButton, ToolStripSeparator1, PrintToolStripButton, PrintPreviewToolStripButton, ToolStripSeparator2, HelpToolStripButton})
        ToolStrip.Location = New Point(0, 37)
        ToolStrip.Name = "ToolStrip"
        ToolStrip.Padding = New Padding(0, 0, 3, 0)
        ToolStrip.Size = New Size(789, 33)
        ToolStrip.TabIndex = 6
        ToolStrip.Text = "ToolStrip"
        ' 
        ' NewToolStripButton
        ' 
        NewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), Image)
        NewToolStripButton.ImageTransparentColor = Color.Black
        NewToolStripButton.Name = "NewToolStripButton"
        NewToolStripButton.Size = New Size(34, 28)
        NewToolStripButton.Text = "New"
        ' 
        ' OpenToolStripButton
        ' 
        OpenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), Image)
        OpenToolStripButton.ImageTransparentColor = Color.Black
        OpenToolStripButton.Name = "OpenToolStripButton"
        OpenToolStripButton.Size = New Size(34, 28)
        OpenToolStripButton.Text = "Open"
        ' 
        ' SaveToolStripButton
        ' 
        SaveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), Image)
        SaveToolStripButton.ImageTransparentColor = Color.Black
        SaveToolStripButton.Name = "SaveToolStripButton"
        SaveToolStripButton.Size = New Size(34, 28)
        SaveToolStripButton.Text = "Save"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 33)
        ' 
        ' PrintToolStripButton
        ' 
        PrintToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), Image)
        PrintToolStripButton.ImageTransparentColor = Color.Black
        PrintToolStripButton.Name = "PrintToolStripButton"
        PrintToolStripButton.Size = New Size(34, 28)
        PrintToolStripButton.Text = "Print"
        ' 
        ' PrintPreviewToolStripButton
        ' 
        PrintPreviewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PrintPreviewToolStripButton.Image = CType(resources.GetObject("PrintPreviewToolStripButton.Image"), Image)
        PrintPreviewToolStripButton.ImageTransparentColor = Color.Black
        PrintPreviewToolStripButton.Name = "PrintPreviewToolStripButton"
        PrintPreviewToolStripButton.Size = New Size(34, 28)
        PrintPreviewToolStripButton.Text = "Print Preview"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 33)
        ' 
        ' HelpToolStripButton
        ' 
        HelpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), Image)
        HelpToolStripButton.ImageTransparentColor = Color.Black
        HelpToolStripButton.Name = "HelpToolStripButton"
        HelpToolStripButton.Size = New Size(34, 28)
        HelpToolStripButton.Text = "Help"
        ' 
        ' StatusStrip
        ' 
        StatusStrip.ImageScalingSize = New Size(24, 24)
        StatusStrip.Items.AddRange(New ToolStripItem() {ToolStripProgressBar1})
        StatusStrip.Location = New Point(0, 660)
        StatusStrip.Name = "StatusStrip"
        StatusStrip.Padding = New Padding(2, 0, 23, 0)
        StatusStrip.Size = New Size(789, 28)
        StatusStrip.TabIndex = 7
        StatusStrip.Text = "StatusStrip"
        ' 
        ' ToolStripProgressBar1
        ' 
        ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        ToolStripProgressBar1.Size = New Size(100, 20)
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(789, 688)
        Controls.Add(ToolStrip)
        Controls.Add(MenuStrip)
        Controls.Add(StatusStrip)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip
        Margin = New Padding(5, 6, 5, 6)
        MaximizeBox = False
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        ToolStrip.ResumeLayout(False)
        ToolStrip.PerformLayout()
        StatusStrip.ResumeLayout(False)
        StatusStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreviewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar

End Class
