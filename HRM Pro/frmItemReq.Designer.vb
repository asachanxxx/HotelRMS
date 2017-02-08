<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemReq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemReq))
        Me.tabMain = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gridItemReq = New DevExpress.XtraGrid.GridControl()
        Me.gvItemReq = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemReqCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLevel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.gridItemDets = New DevExpress.XtraGrid.GridControl()
        Me.gvItemDets = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repItemList = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbDepartment = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbPriority = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRequestBy = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dtReqDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtReference = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReqID = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.gridItemReq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItemReq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.gridItemDets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItemDets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPriority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequestBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtReqDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtReqDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReqID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.AppearancePage.Header.Options.UseFont = True
        Me.tabMain.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabMain.Location = New System.Drawing.Point(12, 12)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedTabPage = Me.XtraTabPage1
        Me.tabMain.Size = New System.Drawing.Size(831, 513)
        Me.tabMain.TabIndex = 0
        Me.tabMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage1.Appearance.HeaderActive.Options.UseFont = True
        Me.XtraTabPage1.Controls.Add(Me.GroupBox4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(829, 486)
        Me.XtraTabPage1.Text = "Item Request List"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.gridItemReq)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(818, 470)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'gridItemReq
        '
        Me.gridItemReq.Location = New System.Drawing.Point(6, 10)
        Me.gridItemReq.MainView = Me.gvItemReq
        Me.gridItemReq.Name = "gridItemReq"
        Me.gridItemReq.Size = New System.Drawing.Size(806, 454)
        Me.gridItemReq.TabIndex = 1
        Me.gridItemReq.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItemReq})
        '
        'gvItemReq
        '
        Me.gvItemReq.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.gvItemReq.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvItemReq.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvItemReq.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvItemReq.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvItemReq.Appearance.Row.Options.UseFont = True
        Me.gvItemReq.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemReqCode, Me.colDate, Me.colLevel, Me.colBalance, Me.GridColumn5})
        Me.gvItemReq.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvItemReq.GridControl = Me.gridItemReq
        Me.gvItemReq.Name = "gvItemReq"
        Me.gvItemReq.OptionsBehavior.Editable = False
        Me.gvItemReq.OptionsView.ShowGroupPanel = False
        '
        'colItemReqCode
        '
        Me.colItemReqCode.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colItemReqCode.AppearanceCell.Options.UseFont = True
        Me.colItemReqCode.AppearanceCell.Options.UseTextOptions = True
        Me.colItemReqCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemReqCode.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colItemReqCode.AppearanceHeader.Options.UseFont = True
        Me.colItemReqCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemReqCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemReqCode.Caption = "Requisition Code"
        Me.colItemReqCode.FieldName = "ItemReqCode"
        Me.colItemReqCode.Name = "colItemReqCode"
        Me.colItemReqCode.Visible = True
        Me.colItemReqCode.VisibleIndex = 0
        Me.colItemReqCode.Width = 125
        '
        'colDate
        '
        Me.colDate.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDate.AppearanceCell.Options.UseFont = True
        Me.colDate.AppearanceCell.Options.UseTextOptions = True
        Me.colDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDate.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDate.AppearanceHeader.Options.UseFont = True
        Me.colDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDate.Caption = "Date"
        Me.colDate.FieldName = "ReqDate"
        Me.colDate.Name = "colDate"
        Me.colDate.Visible = True
        Me.colDate.VisibleIndex = 1
        Me.colDate.Width = 73
        '
        'colLevel
        '
        Me.colLevel.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colLevel.AppearanceCell.Options.UseFont = True
        Me.colLevel.AppearanceCell.Options.UseTextOptions = True
        Me.colLevel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLevel.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colLevel.AppearanceHeader.Options.UseFont = True
        Me.colLevel.AppearanceHeader.Options.UseTextOptions = True
        Me.colLevel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLevel.Caption = "Priority"
        Me.colLevel.FieldName = "PriorityLevel"
        Me.colLevel.Name = "colLevel"
        Me.colLevel.Visible = True
        Me.colLevel.VisibleIndex = 2
        Me.colLevel.Width = 69
        '
        'colBalance
        '
        Me.colBalance.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colBalance.AppearanceCell.Options.UseFont = True
        Me.colBalance.AppearanceCell.Options.UseTextOptions = True
        Me.colBalance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBalance.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colBalance.AppearanceHeader.Options.UseFont = True
        Me.colBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBalance.Caption = "Request By"
        Me.colBalance.FieldName = "ReqBy"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.Visible = True
        Me.colBalance.VisibleIndex = 3
        Me.colBalance.Width = 178
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn5.AppearanceCell.Options.UseFont = True
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Department"
        Me.GridColumn5.FieldName = "Department"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 106
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage2.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage2.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage2.Appearance.HeaderActive.Options.UseFont = True
        Me.XtraTabPage2.Controls.Add(Me.GroupBox5)
        Me.XtraTabPage2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(829, 486)
        Me.XtraTabPage2.Text = "     Details        "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LabelControl7)
        Me.GroupBox5.Controls.Add(Me.LabelControl6)
        Me.GroupBox5.Controls.Add(Me.lbl28)
        Me.GroupBox5.Controls.Add(Me.gridItemDets)
        Me.GroupBox5.Controls.Add(Me.cmbDepartment)
        Me.GroupBox5.Controls.Add(Me.LabelControl5)
        Me.GroupBox5.Controls.Add(Me.cmbPriority)
        Me.GroupBox5.Controls.Add(Me.LabelControl4)
        Me.GroupBox5.Controls.Add(Me.txtRequestBy)
        Me.GroupBox5.Controls.Add(Me.LabelControl2)
        Me.GroupBox5.Controls.Add(Me.dtReqDate)
        Me.GroupBox5.Controls.Add(Me.txtReference)
        Me.GroupBox5.Controls.Add(Me.LabelControl10)
        Me.GroupBox5.Controls.Add(Me.LabelControl3)
        Me.GroupBox5.Controls.Add(Me.LabelControl1)
        Me.GroupBox5.Controls.Add(Me.txtReqID)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(820, 453)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl7.Location = New System.Drawing.Point(805, 107)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl7.TabIndex = 38
        Me.LabelControl7.Text = "*"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl6.Location = New System.Drawing.Point(754, 26)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl6.TabIndex = 37
        Me.LabelControl6.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(229, 17)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 36
        Me.lbl28.Text = "*"
        '
        'gridItemDets
        '
        Me.gridItemDets.Location = New System.Drawing.Point(0, 107)
        Me.gridItemDets.MainView = Me.gvItemDets
        Me.gridItemDets.Name = "gridItemDets"
        Me.gridItemDets.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repItemList})
        Me.gridItemDets.Size = New System.Drawing.Size(799, 340)
        Me.gridItemDets.TabIndex = 6
        Me.gridItemDets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItemDets})
        '
        'gvItemDets
        '
        Me.gvItemDets.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvItemDets.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvItemDets.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvItemDets.Appearance.Row.Options.UseFont = True
        Me.gvItemDets.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn6})
        Me.gvItemDets.GridControl = Me.gridItemDets
        Me.gvItemDets.Name = "gvItemDets"
        Me.gvItemDets.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvItemDets.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Item Code"
        Me.GridColumn1.ColumnEdit = Me.repItemList
        Me.GridColumn1.FieldName = "Itemcode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 104
        '
        'repItemList
        '
        Me.repItemList.AutoHeight = False
        Me.repItemList.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repItemList.Name = "repItemList"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Item Name"
        Me.GridColumn2.FieldName = "Itemname"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 250
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceCell.Options.UseFont = True
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Current Qty"
        Me.GridColumn3.FieldName = "CurrQty"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 90
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceCell.Options.UseFont = True
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Order Qty"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "OrdQty"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 91
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "UID"
        Me.GridColumn6.FieldName = "UID"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Location = New System.Drawing.Point(598, 81)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDepartment.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentID", "Department ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Department", "Department Name")})
        Me.cmbDepartment.Properties.NullText = ""
        Me.cmbDepartment.Size = New System.Drawing.Size(201, 20)
        Me.cmbDepartment.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(535, 84)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl5.TabIndex = 33
        Me.LabelControl5.Text = "Department"
        '
        'cmbPriority
        '
        Me.cmbPriority.Location = New System.Drawing.Point(81, 44)
        Me.cmbPriority.Name = "cmbPriority"
        Me.cmbPriority.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPriority.Properties.Items.AddRange(New Object() {"Low", "Medium", "High"})
        Me.cmbPriority.Size = New System.Drawing.Size(142, 20)
        Me.cmbPriority.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(535, 58)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl4.TabIndex = 30
        Me.LabelControl4.Text = "Request By"
        '
        'txtRequestBy
        '
        Me.txtRequestBy.Location = New System.Drawing.Point(598, 55)
        Me.txtRequestBy.Name = "txtRequestBy"
        Me.txtRequestBy.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestBy.Properties.Appearance.Options.UseFont = True
        Me.txtRequestBy.Properties.ReadOnly = True
        Me.txtRequestBy.Size = New System.Drawing.Size(201, 20)
        Me.txtRequestBy.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(6, 47)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl2.TabIndex = 28
        Me.LabelControl2.Text = "Priority"
        '
        'dtReqDate
        '
        Me.dtReqDate.EditValue = Nothing
        Me.dtReqDate.Location = New System.Drawing.Point(598, 29)
        Me.dtReqDate.Name = "dtReqDate"
        Me.dtReqDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtReqDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtReqDate.Size = New System.Drawing.Size(150, 20)
        Me.dtReqDate.TabIndex = 2
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(81, 70)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(234, 31)
        Me.txtReference.TabIndex = 4
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(568, 28)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Date"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(6, 72)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Reference"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(6, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Requisition #"
        '
        'txtReqID
        '
        Me.txtReqID.Location = New System.Drawing.Point(81, 18)
        Me.txtReqID.Name = "txtReqID"
        Me.txtReqID.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReqID.Properties.Appearance.Options.UseFont = True
        Me.txtReqID.Size = New System.Drawing.Size(142, 20)
        Me.txtReqID.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdClose)
        Me.GroupBox2.Controls.Add(Me.cmdDelete)
        Me.GroupBox2.Controls.Add(Me.cmdEdit)
        Me.GroupBox2.Controls.Add(Me.cmdNew)
        Me.GroupBox2.Location = New System.Drawing.Point(853, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(103, 131)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'cmdClose
        '
        Me.cmdClose.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Appearance.Options.UseFont = True
        Me.cmdClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdClose.Location = New System.Drawing.Point(5, 103)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(92, 23)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "Close"
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdDelete.Location = New System.Drawing.Point(5, 74)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(92, 23)
        Me.cmdDelete.TabIndex = 2
        Me.cmdDelete.Text = "&In Active"
        '
        'cmdEdit
        '
        Me.cmdEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Appearance.Options.UseFont = True
        Me.cmdEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdEdit.Location = New System.Drawing.Point(5, 45)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(92, 23)
        Me.cmdEdit.TabIndex = 1
        Me.cmdEdit.Text = "&Edit"
        '
        'cmdNew
        '
        Me.cmdNew.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Appearance.Options.UseFont = True
        Me.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdNew.Location = New System.Drawing.Point(6, 16)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(92, 23)
        Me.cmdNew.TabIndex = 0
        Me.cmdNew.Text = "&New"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(853, 493)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(103, 31)
        Me.PictureEdit1.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdPrint)
        Me.GroupBox1.Location = New System.Drawing.Point(855, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(103, 56)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'cmdPrint
        '
        Me.cmdPrint.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmdPrint.Appearance.Options.UseFont = True
        Me.cmdPrint.Appearance.Options.UseTextOptions = True
        Me.cmdPrint.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdPrint.Location = New System.Drawing.Point(6, 16)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(92, 31)
        Me.cmdPrint.TabIndex = 0
        Me.cmdPrint.Text = "Print Report"
        '
        'frmItemReq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(963, 531)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmItemReq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Requisition"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.gridItemReq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItemReq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.gridItemDets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItemDets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPriority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequestBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtReqDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtReqDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReqID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtReference As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReqID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtReqDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRequestBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbPriority As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDepartment As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gridItemReq As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvItemReq As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemReqCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLevel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridItemDets As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvItemDets As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repItemList As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
End Class
