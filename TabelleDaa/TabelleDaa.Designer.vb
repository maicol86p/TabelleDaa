<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabelleDaa
    Inherits FunzioniIntegra.BaseForm

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Overloads Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TabelleDaa))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DBGridDaaAcciseDef = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Tab1 = New System.Windows.Forms.TabControl()
        Me.TabContenuto = New System.Windows.Forms.TabPage()
        Me.TableContenuto = New System.Windows.Forms.TableLayoutPanel()
        Me.DBGridDaaAccise = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnCancelAll = New System.Windows.Forms.Button()
        Me.BtnApplyAll = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnFirst = New System.Windows.Forms.ToolStripButton()
        Me.BtnPrev = New System.Windows.Forms.ToolStripButton()
        Me.BtnAdd = New System.Windows.Forms.ToolStripButton()
        Me.BtnDel = New System.Windows.Forms.ToolStripButton()
        Me.BtnNext = New System.Windows.Forms.ToolStripButton()
        Me.BtnLast = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbDeposito = New C1.Win.C1List.C1Combo()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DBGridDaaAcciseDef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab1.SuspendLayout()
        Me.TabContenuto.SuspendLayout()
        Me.TableContenuto.SuspendLayout()
        CType(Me.DBGridDaaAccise, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.CmbDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Size = New System.Drawing.Size(804, 21)
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Width = 398
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Text = "NUM"
        '
        'StatusBarPanel6
        '
        Me.StatusBarPanel6.Text = "12/11/2015 09.01.59"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 52)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DBGridDaaAcciseDef)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Tab1)
        Me.SplitContainer1.Size = New System.Drawing.Size(804, 381)
        Me.SplitContainer1.SplitterDistance = 146
        Me.SplitContainer1.TabIndex = 6
        '
        'DBGridDaaAcciseDef
        '
        Me.DBGridDaaAcciseDef.AllowAddNew = True
        Me.DBGridDaaAcciseDef.AllowColMove = False
        Me.DBGridDaaAcciseDef.AllowColSelect = False
        Me.DBGridDaaAcciseDef.AllowDelete = True
        Me.DBGridDaaAcciseDef.AllowFilter = False
        Me.DBGridDaaAcciseDef.AllowSort = False
        Me.DBGridDaaAcciseDef.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBGridDaaAcciseDef.ExtendRightColumn = True
        Me.DBGridDaaAcciseDef.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGridDaaAcciseDef.Images.Add(CType(resources.GetObject("DBGridDaaAcciseDef.Images"), System.Drawing.Image))
        Me.DBGridDaaAcciseDef.Location = New System.Drawing.Point(0, 0)
        Me.DBGridDaaAcciseDef.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.DBGridDaaAcciseDef.Name = "DBGridDaaAcciseDef"
        Me.DBGridDaaAcciseDef.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGridDaaAcciseDef.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGridDaaAcciseDef.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGridDaaAcciseDef.PrintInfo.PageSettings = CType(resources.GetObject("DBGridDaaAcciseDef.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGridDaaAcciseDef.Size = New System.Drawing.Size(804, 146)
        Me.DBGridDaaAcciseDef.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.DBGridDaaAcciseDef.TabIndex = 7
        Me.DBGridDaaAcciseDef.Text = "C1TrueDBGrid2"
        Me.DBGridDaaAcciseDef.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.DBGridDaaAcciseDef.PropBag = resources.GetString("DBGridDaaAcciseDef.PropBag")
        '
        'Tab1
        '
        Me.Tab1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.Tab1.Controls.Add(Me.TabContenuto)
        Me.Tab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab1.Location = New System.Drawing.Point(0, 0)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.SelectedIndex = 0
        Me.Tab1.Size = New System.Drawing.Size(804, 231)
        Me.Tab1.TabIndex = 8
        '
        'TabContenuto
        '
        Me.TabContenuto.Controls.Add(Me.TableContenuto)
        Me.TabContenuto.Location = New System.Drawing.Point(4, 25)
        Me.TabContenuto.Name = "TabContenuto"
        Me.TabContenuto.Padding = New System.Windows.Forms.Padding(3)
        Me.TabContenuto.Size = New System.Drawing.Size(796, 202)
        Me.TabContenuto.TabIndex = 0
        Me.TabContenuto.Text = "Contenuto"
        Me.TabContenuto.UseVisualStyleBackColor = True
        '
        'TableContenuto
        '
        Me.TableContenuto.ColumnCount = 1
        Me.TableContenuto.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableContenuto.Controls.Add(Me.DBGridDaaAccise, 0, 1)
        Me.TableContenuto.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableContenuto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableContenuto.Location = New System.Drawing.Point(3, 3)
        Me.TableContenuto.Name = "TableContenuto"
        Me.TableContenuto.RowCount = 2
        Me.TableContenuto.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableContenuto.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableContenuto.Size = New System.Drawing.Size(790, 196)
        Me.TableContenuto.TabIndex = 10
        '
        'DBGridDaaAccise
        '
        Me.DBGridDaaAccise.AllowAddNew = True
        Me.DBGridDaaAccise.AllowColSelect = False
        Me.DBGridDaaAccise.AllowDelete = True
        Me.DBGridDaaAccise.AllowFilter = False
        Me.DBGridDaaAccise.AllowSort = False
        Me.DBGridDaaAccise.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBGridDaaAccise.GroupByCaption = "Drag a column header here to group by that column"
        Me.DBGridDaaAccise.Images.Add(CType(resources.GetObject("DBGridDaaAccise.Images"), System.Drawing.Image))
        Me.DBGridDaaAccise.Location = New System.Drawing.Point(3, 38)
        Me.DBGridDaaAccise.Name = "DBGridDaaAccise"
        Me.DBGridDaaAccise.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.DBGridDaaAccise.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.DBGridDaaAccise.PreviewInfo.ZoomFactor = 75.0R
        Me.DBGridDaaAccise.PrintInfo.PageSettings = CType(resources.GetObject("DBGridDaaAccise.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.DBGridDaaAccise.Size = New System.Drawing.Size(784, 196)
        Me.DBGridDaaAccise.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.DBGridDaaAccise.TabIndex = 7
        Me.DBGridDaaAccise.Text = "C1TrueDBGrid1"
        Me.DBGridDaaAccise.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.DBGridDaaAccise.PropBag = resources.GetString("DBGridDaaAccise.PropBag")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCancelAll, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnApplyAll, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 29)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'BtnCancelAll
        '
        Me.BtnCancelAll.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCancelAll.Location = New System.Drawing.Point(103, 3)
        Me.BtnCancelAll.Name = "BtnCancelAll"
        Me.BtnCancelAll.Size = New System.Drawing.Size(94, 23)
        Me.BtnCancelAll.TabIndex = 2
        Me.BtnCancelAll.Text = "Deseleziona tutte"
        Me.BtnCancelAll.UseVisualStyleBackColor = True
        '
        'BtnApplyAll
        '
        Me.BtnApplyAll.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnApplyAll.Location = New System.Drawing.Point(3, 3)
        Me.BtnApplyAll.Name = "BtnApplyAll"
        Me.BtnApplyAll.Size = New System.Drawing.Size(94, 23)
        Me.BtnApplyAll.TabIndex = 1
        Me.BtnApplyAll.Text = "Seleziona tutte"
        Me.BtnApplyAll.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnFirst, Me.BtnPrev, Me.BtnAdd, Me.BtnDel, Me.BtnNext, Me.BtnLast, Me.toolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(804, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnFirst
        '
        Me.BtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFirst.Image = CType(resources.GetObject("BtnFirst.Image"), System.Drawing.Image)
        Me.BtnFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(23, 22)
        Me.BtnFirst.Text = "Prima"
        '
        'BtnPrev
        '
        Me.BtnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(23, 22)
        Me.BtnPrev.Text = "Precedente"
        '
        'BtnAdd
        '
        Me.BtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(23, 22)
        '
        'BtnDel
        '
        Me.BtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnDel.Image = CType(resources.GetObject("BtnDel.Image"), System.Drawing.Image)
        Me.BtnDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(23, 22)
        Me.BtnDel.Text = "Elimina"
        '
        'BtnNext
        '
        Me.BtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(23, 22)
        Me.BtnNext.Text = "Successiva"
        '
        'BtnLast
        '
        Me.BtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnLast.Image = CType(resources.GetObject("BtnLast.Image"), System.Drawing.Image)
        Me.BtnLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(23, 22)
        Me.BtnLast.Text = "Ultima"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CmbDeposito)
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 23)
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Deposito"
        '
        'CmbDeposito
        '
        Me.CmbDeposito.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.CmbDeposito.AllowColMove = False
        Me.CmbDeposito.AllowSort = False
        Me.CmbDeposito.AutoSelect = True
        Me.CmbDeposito.Caption = ""
        Me.CmbDeposito.CaptionHeight = 17
        Me.CmbDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.CmbDeposito.ColumnCaptionHeight = 17
        Me.CmbDeposito.ColumnFooterHeight = 17
        Me.CmbDeposito.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.CmbDeposito.ContentHeight = 15
        Me.CmbDeposito.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.CmbDeposito.EditorBackColor = System.Drawing.SystemColors.Window
        Me.CmbDeposito.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDeposito.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.CmbDeposito.EditorHeight = 15
        Me.CmbDeposito.Images.Add(CType(resources.GetObject("CmbDeposito.Images"), System.Drawing.Image))
        Me.CmbDeposito.ItemHeight = 15
        Me.CmbDeposito.LimitToList = True
        Me.CmbDeposito.Location = New System.Drawing.Point(64, 0)
        Me.CmbDeposito.MatchEntryTimeout = CType(2000, Long)
        Me.CmbDeposito.MaxDropDownItems = CType(5, Short)
        Me.CmbDeposito.MaxLength = 32767
        Me.CmbDeposito.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.CmbDeposito.Name = "CmbDeposito"
        Me.CmbDeposito.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.CmbDeposito.Size = New System.Drawing.Size(243, 21)
        Me.CmbDeposito.TabIndex = 0
        Me.CmbDeposito.PropBag = resources.GetString("CmbDeposito.PropBag")
        '
        'TabelleDaa
        '
        Me.ClientSize = New System.Drawing.Size(804, 455)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "TabelleDaa"
        Me.Text = "Tabelle DAA"
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.ToolStrip1, 0)
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DBGridDaaAcciseDef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab1.ResumeLayout(False)
        Me.TabContenuto.ResumeLayout(False)
        Me.TableContenuto.ResumeLayout(False)
        CType(Me.DBGridDaaAccise, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CmbDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DBGridDaaAcciseDef As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1Combo1 As C1.Win.C1List.C1Combo
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnPrev As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbDeposito As C1.Win.C1List.C1Combo
    Friend WithEvents Tab1 As System.Windows.Forms.TabControl
    Friend WithEvents TabContenuto As System.Windows.Forms.TabPage
    Friend WithEvents DBGridDaaAccise As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TableContenuto As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnApplyAll As System.Windows.Forms.Button
    Friend WithEvents BtnCancelAll As System.Windows.Forms.Button

End Class
