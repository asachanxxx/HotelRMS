<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemAdjustment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemAdjustment))
        Me.tabMain = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.lblitemtot = New DevExpress.XtraEditors.LabelControl()
        Me.optbyname = New System.Windows.Forms.RadioButton()
        Me.optbycode = New System.Windows.Forms.RadioButton()
        Me.lblFoundrecords = New DevExpress.XtraEditors.LabelControl()
        Me.txtsearch = New DevExpress.XtraEditors.TextEdit()
        Me.lbl1 = New DevExpress.XtraEditors.LabelControl()
        Me.gcMain = New DevExpress.XtraGrid.GridControl()
        Me.gvMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcAdjust = New DevExpress.XtraGrid.GridControl()
        Me.gvAdjust = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gbCost = New System.Windows.Forms.GroupBox()
        Me.txtNewAvgCost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkIsNonInv = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.chkIsSplit = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCategory = New DevExpress.XtraEditors.TextEdit()
        Me.lbl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAvgCost = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtItemCode = New DevExpress.XtraEditors.TextEdit()
        Me.lbl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl3 = New DevExpress.XtraEditors.LabelControl()
        Me.dtAdjDate = New DevExpress.XtraEditors.DateEdit()
        Me.gbStock = New System.Windows.Forms.GroupBox()
        Me.txtTotShots = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProcessQty = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbLocation = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbValue = New System.Windows.Forms.RadioButton()
        Me.rbDeduct = New System.Windows.Forms.RadioButton()
        Me.rbAdd = New System.Windows.Forms.RadioButton()
        Me.txtAdjNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtsearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.gcAdjust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAdjust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCost.SuspendLayout()
        CType(Me.txtNewAvgCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.chkIsNonInv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsSplit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAvgCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtAdjDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtAdjDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbStock.SuspendLayout()
        CType(Me.txtTotShots.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcessQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtAdjNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.Appearance.Options.UseFont = True
        Me.tabMain.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.AppearancePage.Header.Options.UseFont = True
        Me.tabMain.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabMain.Location = New System.Drawing.Point(12, 12)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedTabPage = Me.XtraTabPage1
        Me.tabMain.Size = New System.Drawing.Size(862, 576)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.PanelControl1)
        Me.XtraTabPage1.Controls.Add(Me.gcMain)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(860, 549)
        Me.XtraTabPage1.Text = "     Item List        "
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.lblitemtot)
        Me.PanelControl1.Controls.Add(Me.optbyname)
        Me.PanelControl1.Controls.Add(Me.optbycode)
        Me.PanelControl1.Controls.Add(Me.lblFoundrecords)
        Me.PanelControl1.Controls.Add(Me.txtsearch)
        Me.PanelControl1.Controls.Add(Me.lbl1)
        Me.PanelControl1.Location = New System.Drawing.Point(3, 23)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(654, 38)
        Me.PanelControl1.TabIndex = 10
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(552, 15)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl10.TabIndex = 16
        Me.LabelControl10.Text = "# Found Records"
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
        'lblFoundrecords
        '
        Me.lblFoundrecords.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoundrecords.Location = New System.Drawing.Point(529, 15)
        Me.lblFoundrecords.Name = "lblFoundrecords"
        Me.lblFoundrecords.Size = New System.Drawing.Size(0, 13)
        Me.lblFoundrecords.TabIndex = 12
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
        'gcMain
        '
        Me.gcMain.Location = New System.Drawing.Point(3, 67)
        Me.gcMain.MainView = Me.gvMain
        Me.gcMain.Name = "gcMain"
        Me.gcMain.Size = New System.Drawing.Size(854, 479)
        Me.gcMain.TabIndex = 1
        Me.gcMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMain})
        '
        'gvMain
        '
        Me.gvMain.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.gvMain.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.gvMain.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvMain.GridControl = Me.gcMain
        Me.gvMain.Name = "gvMain"
        Me.gvMain.OptionsBehavior.Editable = False
        Me.gvMain.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Item Code"
        Me.GridColumn1.FieldName = "Itemcode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 125
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Item Name"
        Me.GridColumn2.FieldName = "Description"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 280
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
        Me.GridColumn3.Caption = "Category"
        Me.GridColumn3.FieldName = "Category"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 175
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceCell.Options.UseFont = True
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Cost Price"
        Me.GridColumn4.FieldName = "Avgcost"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 71
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn5.AppearanceCell.Options.UseFont = True
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Stock"
        Me.GridColumn5.FieldName = "Stocks"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 79
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Location"
        Me.GridColumn6.FieldName = "Location"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.gcAdjust)
        Me.XtraTabPage2.Controls.Add(Me.gbCost)
        Me.XtraTabPage2.Controls.Add(Me.GroupBox5)
        Me.XtraTabPage2.Controls.Add(Me.dtAdjDate)
        Me.XtraTabPage2.Controls.Add(Me.gbStock)
        Me.XtraTabPage2.Controls.Add(Me.GroupBox3)
        Me.XtraTabPage2.Controls.Add(Me.txtAdjNo)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.ShapeContainer1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(860, 549)
        Me.XtraTabPage2.Text = "Item Adjustment "
        '
        'gcAdjust
        '
        Me.gcAdjust.Location = New System.Drawing.Point(5, 202)
        Me.gcAdjust.MainView = Me.gvAdjust
        Me.gcAdjust.Name = "gcAdjust"
        Me.gcAdjust.Size = New System.Drawing.Size(852, 344)
        Me.gcAdjust.TabIndex = 22
        Me.gcAdjust.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAdjust})
        '
        'gvAdjust
        '
        Me.gvAdjust.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.gvAdjust.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvAdjust.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn13, Me.GridColumn12})
        Me.gvAdjust.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvAdjust.GridControl = Me.gcAdjust
        Me.gvAdjust.Name = "gvAdjust"
        Me.gvAdjust.OptionsBehavior.Editable = False
        Me.gvAdjust.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn7.AppearanceCell.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Item Code"
        Me.GridColumn7.FieldName = "Itemcode"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 125
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn8.AppearanceCell.Options.UseFont = True
        Me.GridColumn8.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn8.AppearanceHeader.Options.UseFont = True
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "Item Name"
        Me.GridColumn8.FieldName = "Itemname"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 280
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn9.AppearanceCell.Options.UseFont = True
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn9.AppearanceHeader.Options.UseFont = True
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Category"
        Me.GridColumn9.FieldName = "Category"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        Me.GridColumn9.Width = 175
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn10.AppearanceCell.Options.UseFont = True
        Me.GridColumn10.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn10.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn10.AppearanceHeader.Options.UseFont = True
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Cost Price"
        Me.GridColumn10.FieldName = "Avgcost"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        Me.GridColumn10.Width = 71
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn11.AppearanceCell.Options.UseFont = True
        Me.GridColumn11.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn11.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn11.AppearanceHeader.Options.UseFont = True
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "Stock"
        Me.GridColumn11.FieldName = "Stock"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 5
        Me.GridColumn11.Width = 79
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn13.AppearanceCell.Options.UseFont = True
        Me.GridColumn13.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.Caption = "Shots"
        Me.GridColumn13.FieldName = "TotShots"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 4
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Location"
        Me.GridColumn12.FieldName = "Location"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'gbCost
        '
        Me.gbCost.Controls.Add(Me.txtNewAvgCost)
        Me.gbCost.Controls.Add(Me.LabelControl5)
        Me.gbCost.Location = New System.Drawing.Point(494, 132)
        Me.gbCost.Name = "gbCost"
        Me.gbCost.Size = New System.Drawing.Size(219, 45)
        Me.gbCost.TabIndex = 21
        Me.gbCost.TabStop = False
        Me.gbCost.Text = "Adjust Cost"
        '
        'txtNewAvgCost
        '
        Me.txtNewAvgCost.EditValue = "0"
        Me.txtNewAvgCost.EnterMoveNextControl = True
        Me.txtNewAvgCost.Location = New System.Drawing.Point(73, 16)
        Me.txtNewAvgCost.Name = "txtNewAvgCost"
        Me.txtNewAvgCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewAvgCost.Properties.Appearance.Options.UseFont = True
        Me.txtNewAvgCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNewAvgCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNewAvgCost.Properties.Mask.EditMask = "n2"
        Me.txtNewAvgCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNewAvgCost.Size = New System.Drawing.Size(137, 20)
        Me.txtNewAvgCost.TabIndex = 13
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(15, 19)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl5.TabIndex = 14
        Me.LabelControl5.Text = "New Cost "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkIsNonInv)
        Me.GroupBox5.Controls.Add(Me.LabelControl9)
        Me.GroupBox5.Controls.Add(Me.chkIsSplit)
        Me.GroupBox5.Controls.Add(Me.LabelControl8)
        Me.GroupBox5.Controls.Add(Me.txtCategory)
        Me.GroupBox5.Controls.Add(Me.lbl7)
        Me.GroupBox5.Controls.Add(Me.txtAvgCost)
        Me.GroupBox5.Controls.Add(Me.txtDescription)
        Me.GroupBox5.Controls.Add(Me.LabelControl3)
        Me.GroupBox5.Controls.Add(Me.txtItemCode)
        Me.GroupBox5.Controls.Add(Me.lbl4)
        Me.GroupBox5.Controls.Add(Me.lbl3)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(461, 118)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        '
        'chkIsNonInv
        '
        Me.chkIsNonInv.Enabled = False
        Me.chkIsNonInv.Location = New System.Drawing.Point(432, 94)
        Me.chkIsNonInv.Name = "chkIsNonInv"
        Me.chkIsNonInv.Properties.Caption = ""
        Me.chkIsNonInv.Size = New System.Drawing.Size(21, 19)
        Me.chkIsNonInv.TabIndex = 25
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(342, 97)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl9.TabIndex = 24
        Me.LabelControl9.Text = "Is Non Inventory"
        '
        'chkIsSplit
        '
        Me.chkIsSplit.Enabled = False
        Me.chkIsSplit.Location = New System.Drawing.Point(304, 96)
        Me.chkIsSplit.Name = "chkIsSplit"
        Me.chkIsSplit.Properties.Caption = ""
        Me.chkIsSplit.Size = New System.Drawing.Size(21, 19)
        Me.chkIsSplit.TabIndex = 23
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(264, 98)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl8.TabIndex = 22
        Me.LabelControl8.Text = "Is Split"
        '
        'txtCategory
        '
        Me.txtCategory.EnterMoveNextControl = True
        Me.txtCategory.Location = New System.Drawing.Point(84, 65)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Properties.Appearance.Options.UseFont = True
        Me.txtCategory.Size = New System.Drawing.Size(262, 20)
        Me.txtCategory.TabIndex = 21
        '
        'lbl7
        '
        Me.lbl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.Location = New System.Drawing.Point(16, 65)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(46, 13)
        Me.lbl7.TabIndex = 20
        Me.lbl7.Text = "Category"
        '
        'txtAvgCost
        '
        Me.txtAvgCost.EditValue = "0"
        Me.txtAvgCost.EnterMoveNextControl = True
        Me.txtAvgCost.Location = New System.Drawing.Point(84, 91)
        Me.txtAvgCost.Name = "txtAvgCost"
        Me.txtAvgCost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvgCost.Properties.Appearance.Options.UseFont = True
        Me.txtAvgCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAvgCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAvgCost.Size = New System.Drawing.Size(137, 20)
        Me.txtAvgCost.TabIndex = 11
        '
        'txtDescription
        '
        Me.txtDescription.EnterMoveNextControl = True
        Me.txtDescription.Location = New System.Drawing.Point(84, 39)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Size = New System.Drawing.Size(369, 20)
        Me.txtDescription.TabIndex = 18
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(16, 91)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 12
        Me.LabelControl3.Text = "Cost Price"
        '
        'txtItemCode
        '
        Me.txtItemCode.EnterMoveNextControl = True
        Me.txtItemCode.Location = New System.Drawing.Point(84, 13)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.Properties.Appearance.Options.UseFont = True
        Me.txtItemCode.Properties.Appearance.Options.UseTextOptions = True
        Me.txtItemCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtItemCode.Size = New System.Drawing.Size(143, 20)
        Me.txtItemCode.TabIndex = 15
        '
        'lbl4
        '
        Me.lbl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(16, 39)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(59, 13)
        Me.lbl4.TabIndex = 17
        Me.lbl4.Text = "Description"
        '
        'lbl3
        '
        Me.lbl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(16, 14)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(52, 13)
        Me.lbl3.TabIndex = 16
        Me.lbl3.Text = "Item Code"
        '
        'dtAdjDate
        '
        Me.dtAdjDate.EditValue = Nothing
        Me.dtAdjDate.Location = New System.Drawing.Point(636, 34)
        Me.dtAdjDate.Name = "dtAdjDate"
        Me.dtAdjDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtAdjDate.Properties.Appearance.Options.UseFont = True
        Me.dtAdjDate.Properties.Appearance.Options.UseTextOptions = True
        Me.dtAdjDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dtAdjDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtAdjDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtAdjDate.Size = New System.Drawing.Size(143, 20)
        Me.dtAdjDate.TabIndex = 19
        '
        'gbStock
        '
        Me.gbStock.Controls.Add(Me.txtTotShots)
        Me.gbStock.Controls.Add(Me.LabelControl7)
        Me.gbStock.Controls.Add(Me.txtProcessQty)
        Me.gbStock.Controls.Add(Me.LabelControl4)
        Me.gbStock.Controls.Add(Me.cmbLocation)
        Me.gbStock.Controls.Add(Me.LabelControl6)
        Me.gbStock.Location = New System.Drawing.Point(494, 60)
        Me.gbStock.Name = "gbStock"
        Me.gbStock.Size = New System.Drawing.Size(291, 72)
        Me.gbStock.TabIndex = 18
        Me.gbStock.TabStop = False
        Me.gbStock.Text = "Add Or Deduct Qty"
        '
        'txtTotShots
        '
        Me.txtTotShots.EditValue = "0"
        Me.txtTotShots.EnterMoveNextControl = True
        Me.txtTotShots.Location = New System.Drawing.Point(216, 46)
        Me.txtTotShots.Name = "txtTotShots"
        Me.txtTotShots.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotShots.Properties.Appearance.Options.UseFont = True
        Me.txtTotShots.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotShots.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotShots.Properties.Mask.EditMask = "n0"
        Me.txtTotShots.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotShots.Size = New System.Drawing.Size(69, 20)
        Me.txtTotShots.TabIndex = 25
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(181, 49)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl7.TabIndex = 26
        Me.LabelControl7.Text = "Shots"
        '
        'txtProcessQty
        '
        Me.txtProcessQty.EditValue = "0"
        Me.txtProcessQty.EnterMoveNextControl = True
        Me.txtProcessQty.Location = New System.Drawing.Point(82, 46)
        Me.txtProcessQty.Name = "txtProcessQty"
        Me.txtProcessQty.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcessQty.Properties.Appearance.Options.UseFont = True
        Me.txtProcessQty.Properties.Appearance.Options.UseTextOptions = True
        Me.txtProcessQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtProcessQty.Properties.Mask.EditMask = "\d+(\.\d{1,4})?"
        Me.txtProcessQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtProcessQty.Properties.Mask.ShowPlaceHolders = False
        Me.txtProcessQty.Size = New System.Drawing.Size(82, 20)
        Me.txtProcessQty.TabIndex = 23
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(15, 49)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl4.TabIndex = 24
        Me.LabelControl4.Text = "Process Qty"
        '
        'cmbLocation
        '
        Me.cmbLocation.EnterMoveNextControl = True
        Me.cmbLocation.Location = New System.Drawing.Point(82, 20)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLocation.Properties.Appearance.Options.UseFont = True
        Me.cmbLocation.Properties.Appearance.Options.UseTextOptions = True
        Me.cmbLocation.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cmbLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLocation.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentID", 150, "Department ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Department", 350, "Department")})
        Me.cmbLocation.Properties.NullText = ""
        Me.cmbLocation.Size = New System.Drawing.Size(204, 20)
        Me.cmbLocation.TabIndex = 21
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(17, 23)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl6.TabIndex = 22
        Me.LabelControl6.Text = "Outlet"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbValue)
        Me.GroupBox3.Controls.Add(Me.rbDeduct)
        Me.GroupBox3.Controls.Add(Me.rbAdd)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(273, 48)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'rbValue
        '
        Me.rbValue.AutoSize = True
        Me.rbValue.Location = New System.Drawing.Point(168, 21)
        Me.rbValue.Name = "rbValue"
        Me.rbValue.Size = New System.Drawing.Size(84, 17)
        Me.rbValue.TabIndex = 2
        Me.rbValue.TabStop = True
        Me.rbValue.Text = "Adjust Value"
        Me.rbValue.UseVisualStyleBackColor = True
        '
        'rbDeduct
        '
        Me.rbDeduct.AutoSize = True
        Me.rbDeduct.Location = New System.Drawing.Point(79, 21)
        Me.rbDeduct.Name = "rbDeduct"
        Me.rbDeduct.Size = New System.Drawing.Size(79, 17)
        Me.rbDeduct.TabIndex = 1
        Me.rbDeduct.TabStop = True
        Me.rbDeduct.Text = "Deduct Qty"
        Me.rbDeduct.UseVisualStyleBackColor = True
        '
        'rbAdd
        '
        Me.rbAdd.AutoSize = True
        Me.rbAdd.Location = New System.Drawing.Point(6, 21)
        Me.rbAdd.Name = "rbAdd"
        Me.rbAdd.Size = New System.Drawing.Size(63, 17)
        Me.rbAdd.TabIndex = 0
        Me.rbAdd.TabStop = True
        Me.rbAdd.Text = "Add Qty"
        Me.rbAdd.UseVisualStyleBackColor = True
        '
        'txtAdjNo
        '
        Me.txtAdjNo.EnterMoveNextControl = True
        Me.txtAdjNo.Location = New System.Drawing.Point(636, 8)
        Me.txtAdjNo.Name = "txtAdjNo"
        Me.txtAdjNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdjNo.Properties.Appearance.Options.UseFont = True
        Me.txtAdjNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAdjNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtAdjNo.Size = New System.Drawing.Size(143, 20)
        Me.txtAdjNo.TabIndex = 15
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(544, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Adjustment Date"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(561, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl1.TabIndex = 16
        Me.LabelControl1.Text = "Adjustment #"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(860, 549)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 16
        Me.LineShape2.X2 = 454
        Me.LineShape2.Y1 = 60
        Me.LineShape2.Y2 = 60
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 12
        Me.LineShape1.X2 = 450
        Me.LineShape1.Y1 = 190
        Me.LineShape1.Y2 = 190
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdClose)
        Me.GroupBox2.Controls.Add(Me.cmdUpdate)
        Me.GroupBox2.Location = New System.Drawing.Point(886, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(98, 75)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'cmdClose
        '
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdClose.Location = New System.Drawing.Point(6, 43)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(86, 20)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "Close"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdUpdate.Location = New System.Drawing.Point(6, 17)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(86, 20)
        Me.cmdUpdate.TabIndex = 2
        Me.cmdUpdate.Text = "Update"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cmdPrint)
        Me.GroupBox7.Location = New System.Drawing.Point(880, 249)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(98, 48)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Visible = False
        '
        'cmdPrint
        '
        Me.cmdPrint.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Appearance.Options.UseFont = True
        Me.cmdPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdPrint.Location = New System.Drawing.Point(6, 17)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(86, 20)
        Me.cmdPrint.TabIndex = 2
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.Visible = False
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(880, 553)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(104, 31)
        Me.PictureEdit1.TabIndex = 5
        '
        'frmItemAdjustment
        '
        Me.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(996, 591)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmItemAdjustment"
        Me.Text = "Item Adjustment"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtsearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.gcAdjust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAdjust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCost.ResumeLayout(False)
        Me.gbCost.PerformLayout()
        CType(Me.txtNewAvgCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.chkIsNonInv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsSplit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAvgCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtAdjDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtAdjDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbStock.ResumeLayout(False)
        Me.gbStock.PerformLayout()
        CType(Me.txtTotShots.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcessQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txtAdjNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAdjNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents gbStock As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dtAdjDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtAvgCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rbValue As System.Windows.Forms.RadioButton
    Friend WithEvents rbDeduct As System.Windows.Forms.RadioButton
    Friend WithEvents rbAdd As System.Windows.Forms.RadioButton
    Friend WithEvents gbCost As System.Windows.Forms.GroupBox
    Friend WithEvents txtNewAvgCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtItemCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbLocation As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProcessQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAdjust As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAdjust As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCategory As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtTotShots As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkIsSplit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkIsNonInv As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblitemtot As DevExpress.XtraEditors.LabelControl
    Friend WithEvents optbyname As System.Windows.Forms.RadioButton
    Friend WithEvents optbycode As System.Windows.Forms.RadioButton
    Friend WithEvents lblFoundrecords As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtsearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
End Class
