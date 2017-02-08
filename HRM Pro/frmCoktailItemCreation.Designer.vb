<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoktailItemCreation
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCoktailItemCreation))
        Me.GroupBox9 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton()
        Me.tabMain = New DevExpress.XtraTab.XtraTabControl()
        Me.tbpItem = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl25 = New DevExpress.XtraEditors.PanelControl()
        Me.grdItemMain = New DevExpress.XtraGrid.GridControl()
        Me.gvItemMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblitemtot = New DevExpress.XtraEditors.LabelControl()
        Me.optbyname = New System.Windows.Forms.RadioButton()
        Me.optbycode = New System.Windows.Forms.RadioButton()
        Me.lbl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtsearch = New DevExpress.XtraEditors.TextEdit()
        Me.lbl1 = New DevExpress.XtraEditors.LabelControl()
        Me.tbpDescription = New DevExpress.XtraTab.XtraTabPage()
        Me.gridTemplate = New DevExpress.XtraGrid.GridControl()
        Me.gvTemplate = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repcmbUOM = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Frame7 = New DevExpress.XtraEditors.PanelControl()
        Me.txtItemcode = New DevExpress.XtraEditors.TextEdit()
        Me.cmbUOM = New DevExpress.XtraEditors.LookUpEdit()
        Me.lbl31 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl29 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.dtCreateDate = New DevExpress.XtraEditors.DateEdit()
        Me.lbl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl3 = New DevExpress.XtraEditors.LabelControl()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.GroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.tbpItem.SuspendLayout()
        CType(Me.PanelControl25, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl25.SuspendLayout()
        CType(Me.grdItemMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItemMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtsearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpDescription.SuspendLayout()
        CType(Me.gridTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repcmbUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Frame7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame7.SuspendLayout()
        CType(Me.txtItemcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCreateDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCreateDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox9
        '
        Me.GroupBox9.Appearance.BackColor = System.Drawing.Color.White
        Me.GroupBox9.Appearance.Options.UseBackColor = True
        Me.GroupBox9.Controls.Add(Me.cmdDelete)
        Me.GroupBox9.Controls.Add(Me.cmdCancel)
        Me.GroupBox9.Controls.Add(Me.cmdEdit)
        Me.GroupBox9.Controls.Add(Me.cmdNew)
        Me.GroupBox9.Location = New System.Drawing.Point(757, 33)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(96, 94)
        Me.GroupBox9.TabIndex = 6
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdDelete.Location = New System.Drawing.Point(9, 61)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 20)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Appearance.Options.UseFont = True
        Me.cmdCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdCancel.Location = New System.Drawing.Point(9, 61)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 20)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "Close"
        '
        'cmdEdit
        '
        Me.cmdEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Appearance.Options.UseFont = True
        Me.cmdEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdEdit.Location = New System.Drawing.Point(9, 35)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 20)
        Me.cmdEdit.TabIndex = 1
        Me.cmdEdit.Text = "Edit"
        '
        'cmdNew
        '
        Me.cmdNew.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Appearance.Options.UseFont = True
        Me.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdNew.Location = New System.Drawing.Point(9, 11)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(75, 20)
        Me.cmdNew.TabIndex = 0
        Me.cmdNew.Text = "New"
        '
        'tabMain
        '
        Me.tabMain.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.Location = New System.Drawing.Point(12, 12)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedTabPage = Me.tbpItem
        Me.tabMain.Size = New System.Drawing.Size(739, 509)
        Me.tabMain.TabIndex = 5
        Me.tabMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tbpItem, Me.tbpDescription})
        '
        'tbpItem
        '
        Me.tbpItem.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpItem.Appearance.Header.Options.UseFont = True
        Me.tbpItem.Controls.Add(Me.PanelControl25)
        Me.tbpItem.Controls.Add(Me.PanelControl1)
        Me.tbpItem.Name = "tbpItem"
        Me.tbpItem.Size = New System.Drawing.Size(737, 484)
        Me.tbpItem.Text = "     Item List    "
        '
        'PanelControl25
        '
        Me.PanelControl25.Controls.Add(Me.grdItemMain)
        Me.PanelControl25.Location = New System.Drawing.Point(9, 13)
        Me.PanelControl25.Name = "PanelControl25"
        Me.PanelControl25.Size = New System.Drawing.Size(714, 460)
        Me.PanelControl25.TabIndex = 8
        '
        'grdItemMain
        '
        Me.grdItemMain.Location = New System.Drawing.Point(8, 9)
        Me.grdItemMain.MainView = Me.gvItemMain
        Me.grdItemMain.Name = "grdItemMain"
        Me.grdItemMain.Size = New System.Drawing.Size(697, 446)
        Me.grdItemMain.TabIndex = 0
        Me.grdItemMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItemMain})
        '
        'gvItemMain
        '
        Me.gvItemMain.Appearance.FocusedCell.BackColor = System.Drawing.Color.Silver
        Me.gvItemMain.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvItemMain.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver
        Me.gvItemMain.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvItemMain.Appearance.SelectedRow.BackColor = System.Drawing.Color.Silver
        Me.gvItemMain.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gvItemMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn7})
        Me.gvItemMain.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvItemMain.GridControl = Me.grdItemMain
        Me.gvItemMain.Name = "gvItemMain"
        Me.gvItemMain.OptionsBehavior.Editable = False
        Me.gvItemMain.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.Caption = "ItemCode"
        Me.GridColumn1.FieldName = "ItemCode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 150
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.Caption = "Description"
        Me.GridColumn2.FieldName = "Description"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 375
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceCell.Options.UseFont = True
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Stock"
        Me.GridColumn3.FieldName = "UOM"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 154
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceCell.Options.UseFont = True
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Last Cost"
        Me.GridColumn4.FieldName = "Lastcost"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 47
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn5.AppearanceCell.Options.UseFont = True
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Sell Price"
        Me.GridColumn5.FieldName = "SellPrice"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 54
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn7.AppearanceCell.Options.UseFont = True
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "ROL"
        Me.GridColumn7.FieldName = "ROL"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Width = 32
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblitemtot)
        Me.PanelControl1.Controls.Add(Me.optbyname)
        Me.PanelControl1.Controls.Add(Me.optbycode)
        Me.PanelControl1.Controls.Add(Me.lbl2)
        Me.PanelControl1.Controls.Add(Me.txtsearch)
        Me.PanelControl1.Controls.Add(Me.lbl1)
        Me.PanelControl1.Location = New System.Drawing.Point(9, 13)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(635, 38)
        Me.PanelControl1.TabIndex = 9
        Me.PanelControl1.Visible = False
        '
        'lblitemtot
        '
        Me.lblitemtot.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemtot.Location = New System.Drawing.Point(592, 15)
        Me.lblitemtot.Name = "lblitemtot"
        Me.lblitemtot.Size = New System.Drawing.Size(0, 13)
        Me.lblitemtot.TabIndex = 15
        '
        'optbyname
        '
        Me.optbyname.AutoSize = True
        Me.optbyname.Location = New System.Drawing.Point(143, 13)
        Me.optbyname.Name = "optbyname"
        Me.optbyname.Size = New System.Drawing.Size(69, 17)
        Me.optbyname.TabIndex = 14
        Me.optbyname.Text = "By Name"
        Me.optbyname.UseVisualStyleBackColor = True
        '
        'optbycode
        '
        Me.optbycode.AutoSize = True
        Me.optbycode.Checked = True
        Me.optbycode.Location = New System.Drawing.Point(65, 13)
        Me.optbycode.Name = "optbycode"
        Me.optbycode.Size = New System.Drawing.Size(74, 17)
        Me.optbycode.TabIndex = 13
        Me.optbycode.TabStop = True
        Me.optbycode.Text = "ItemCode"
        Me.optbycode.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(508, 15)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(78, 13)
        Me.lbl2.TabIndex = 12
        Me.lbl2.Text = "Found Records"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(218, 12)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Properties.Appearance.Options.UseFont = True
        Me.txtsearch.Size = New System.Drawing.Size(280, 20)
        Me.txtsearch.TabIndex = 11
        '
        'lbl1
        '
        Me.lbl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(6, 15)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(49, 13)
        Me.lbl1.TabIndex = 10
        Me.lbl1.Text = "Search By"
        '
        'tbpDescription
        '
        Me.tbpDescription.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpDescription.Appearance.Header.Options.UseFont = True
        Me.tbpDescription.Controls.Add(Me.gridTemplate)
        Me.tbpDescription.Controls.Add(Me.Frame7)
        Me.tbpDescription.Controls.Add(Me.ShapeContainer2)
        Me.tbpDescription.Name = "tbpDescription"
        Me.tbpDescription.Size = New System.Drawing.Size(737, 484)
        Me.tbpDescription.Text = "     Details     "
        '
        'gridTemplate
        '
        Me.gridTemplate.Location = New System.Drawing.Point(10, 133)
        Me.gridTemplate.MainView = Me.gvTemplate
        Me.gridTemplate.Name = "gridTemplate"
        Me.gridTemplate.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repcmbUOM})
        Me.gridTemplate.Size = New System.Drawing.Size(713, 335)
        Me.gridTemplate.TabIndex = 44
        Me.gridTemplate.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTemplate})
        '
        'gvTemplate
        '
        Me.gvTemplate.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvTemplate.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvTemplate.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvTemplate.Appearance.Row.Options.UseFont = True
        Me.gvTemplate.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9, Me.GridColumn15, Me.GridColumn14, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19})
        Me.gvTemplate.GridControl = Me.gridTemplate
        Me.gvTemplate.Name = "gvTemplate"
        Me.gvTemplate.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvTemplate.OptionsView.ShowGroupPanel = False
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn8.AppearanceCell.Options.UseFont = True
        Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn8.AppearanceHeader.Options.UseFont = True
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "Item Code"
        Me.GridColumn8.FieldName = "SubItemCode"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        Me.GridColumn8.Width = 125
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn9.AppearanceCell.Options.UseFont = True
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn9.AppearanceHeader.Options.UseFont = True
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Item Name"
        Me.GridColumn9.FieldName = "SubItemName"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        Me.GridColumn9.Width = 300
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn15.AppearanceCell.Options.UseFont = True
        Me.GridColumn15.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn15.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn15.AppearanceHeader.Options.UseFont = True
        Me.GridColumn15.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.Caption = "UOM"
        Me.GridColumn15.FieldName = "UOM"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 2
        Me.GridColumn15.Width = 175
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn14.AppearanceCell.Options.UseFont = True
        Me.GridColumn14.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn14.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn14.AppearanceHeader.Options.UseFont = True
        Me.GridColumn14.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.Caption = "Required Qty"
        Me.GridColumn14.FieldName = "RequiredQty"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 3
        Me.GridColumn14.Width = 102
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "UID"
        Me.GridColumn16.FieldName = "UIDDetail"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn17.AppearanceCell.Options.UseFont = True
        Me.GridColumn17.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn17.AppearanceHeader.Options.UseFont = True
        Me.GridColumn17.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.Caption = "TaxCode"
        Me.GridColumn17.FieldName = "TaxCode"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.Width = 67
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn18.AppearanceCell.Options.UseFont = True
        Me.GridColumn18.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn18.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn18.AppearanceHeader.Options.UseFont = True
        Me.GridColumn18.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.Caption = "TaxValue"
        Me.GridColumn18.FieldName = "TaxValue"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.Width = 83
        '
        'GridColumn19
        '
        Me.GridColumn19.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn19.AppearanceCell.Options.UseFont = True
        Me.GridColumn19.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn19.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn19.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn19.AppearanceHeader.Options.UseFont = True
        Me.GridColumn19.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn19.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn19.Caption = "SubTotal"
        Me.GridColumn19.FieldName = "SubTotal"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.AllowEdit = False
        Me.GridColumn19.Width = 153
        '
        'repcmbUOM
        '
        Me.repcmbUOM.AutoHeight = False
        Me.repcmbUOM.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repcmbUOM.Name = "repcmbUOM"
        '
        'Frame7
        '
        Me.Frame7.Controls.Add(Me.txtItemcode)
        Me.Frame7.Controls.Add(Me.cmbUOM)
        Me.Frame7.Controls.Add(Me.lbl31)
        Me.Frame7.Controls.Add(Me.lbl29)
        Me.Frame7.Controls.Add(Me.lbl28)
        Me.Frame7.Controls.Add(Me.lbl8)
        Me.Frame7.Controls.Add(Me.txtDescription)
        Me.Frame7.Controls.Add(Me.dtCreateDate)
        Me.Frame7.Controls.Add(Me.lbl5)
        Me.Frame7.Controls.Add(Me.lbl4)
        Me.Frame7.Controls.Add(Me.lbl3)
        Me.Frame7.Location = New System.Drawing.Point(10, 12)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Size = New System.Drawing.Size(713, 99)
        Me.Frame7.TabIndex = 3
        '
        'txtItemcode
        '
        Me.txtItemcode.EnterMoveNextControl = True
        Me.txtItemcode.Location = New System.Drawing.Point(82, 13)
        Me.txtItemcode.Name = "txtItemcode"
        Me.txtItemcode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemcode.Properties.Appearance.Options.UseFont = True
        Me.txtItemcode.Size = New System.Drawing.Size(211, 20)
        Me.txtItemcode.TabIndex = 19
        '
        'cmbUOM
        '
        Me.cmbUOM.EnterMoveNextControl = True
        Me.cmbUOM.Location = New System.Drawing.Point(347, 63)
        Me.cmbUOM.Name = "cmbUOM"
        Me.cmbUOM.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUOM.Properties.Appearance.Options.UseFont = True
        Me.cmbUOM.Properties.Appearance.Options.UseTextOptions = True
        Me.cmbUOM.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cmbUOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbUOM.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UOMCode", 150, "UOM Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", 350, "Description")})
        Me.cmbUOM.Properties.NullText = ""
        Me.cmbUOM.Size = New System.Drawing.Size(170, 20)
        Me.cmbUOM.TabIndex = 18
        '
        'lbl31
        '
        Me.lbl31.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl31.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl31.Location = New System.Drawing.Point(518, 65)
        Me.lbl31.Name = "lbl31"
        Me.lbl31.Size = New System.Drawing.Size(8, 16)
        Me.lbl31.TabIndex = 16
        Me.lbl31.Text = "*"
        '
        'lbl29
        '
        Me.lbl29.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl29.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl29.Location = New System.Drawing.Point(520, 36)
        Me.lbl29.Name = "lbl29"
        Me.lbl29.Size = New System.Drawing.Size(8, 16)
        Me.lbl29.TabIndex = 14
        Me.lbl29.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(299, 13)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 13
        Me.lbl28.Text = "*"
        '
        'lbl8
        '
        Me.lbl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.Location = New System.Drawing.Point(252, 67)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(83, 13)
        Me.lbl8.TabIndex = 9
        Me.lbl8.Text = "Unit of Measure"
        '
        'txtDescription
        '
        Me.txtDescription.EnterMoveNextControl = True
        Me.txtDescription.Location = New System.Drawing.Point(82, 38)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Size = New System.Drawing.Size(435, 20)
        Me.txtDescription.TabIndex = 1
        '
        'dtCreateDate
        '
        Me.dtCreateDate.EditValue = Nothing
        Me.dtCreateDate.Location = New System.Drawing.Point(82, 64)
        Me.dtCreateDate.Name = "dtCreateDate"
        Me.dtCreateDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtCreateDate.Properties.Appearance.Options.UseFont = True
        Me.dtCreateDate.Properties.Appearance.Options.UseTextOptions = True
        Me.dtCreateDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dtCreateDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCreateDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtCreateDate.Size = New System.Drawing.Size(134, 20)
        Me.dtCreateDate.TabIndex = 3
        '
        'lbl5
        '
        Me.lbl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(14, 68)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(60, 13)
        Me.lbl5.TabIndex = 2
        Me.lbl5.Text = "Create Date"
        '
        'lbl4
        '
        Me.lbl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(14, 41)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(59, 13)
        Me.lbl4.TabIndex = 1
        Me.lbl4.Text = "Description"
        '
        'lbl3
        '
        Me.lbl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(14, 16)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(52, 13)
        Me.lbl3.TabIndex = 0
        Me.lbl3.Text = "Item Code"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(737, 484)
        Me.ShapeContainer2.TabIndex = 45
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 25
        Me.LineShape2.X2 = 637
        Me.LineShape2.Y1 = 122
        Me.LineShape2.Y2 = 122
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(760, 474)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 15
        '
        'frmCoktailItemCreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(872, 524)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.tabMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmCoktailItemCreation"
        Me.Text = "Coktail Item Creation"
        CType(Me.GroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.tbpItem.ResumeLayout(False)
        CType(Me.PanelControl25, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl25.ResumeLayout(False)
        CType(Me.grdItemMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItemMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtsearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpDescription.ResumeLayout(False)
        CType(Me.gridTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repcmbUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Frame7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame7.ResumeLayout(False)
        Me.Frame7.PerformLayout()
        CType(Me.txtItemcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCreateDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCreateDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabMain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tbpItem As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl25 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grdItemMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvItemMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblitemtot As DevExpress.XtraEditors.LabelControl
    Friend WithEvents optbyname As System.Windows.Forms.RadioButton
    Friend WithEvents optbycode As System.Windows.Forms.RadioButton
    Friend WithEvents lbl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtsearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tbpDescription As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gridTemplate As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTemplate As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repcmbUOM As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Frame7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtItemcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbUOM As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lbl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtCreateDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lbl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
