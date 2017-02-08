<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchaseOrder))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton()
        Me.tabMain = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.gridPOMain = New DevExpress.XtraGrid.GridControl()
        Me.gvPOMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemReqCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLevel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.dtFrom = New DevExpress.XtraEditors.DateEdit()
        Me.dtTo = New DevExpress.XtraEditors.DateEdit()
        Me.optClosed = New System.Windows.Forms.RadioButton()
        Me.optOpen = New System.Windows.Forms.RadioButton()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtReqDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPOTot = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTaxValue = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSubtot = New DevExpress.XtraEditors.TextEdit()
        Me.txtPRDate = New DevExpress.XtraEditors.TextEdit()
        Me.txtPRPriority = New DevExpress.XtraEditors.TextEdit()
        Me.txtPRRef = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbPOReq = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtUIDMaster = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbSupplier = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.gridItemDets = New DevExpress.XtraGrid.GridControl()
        Me.gvItemDets = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repItemList = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.cmbPriority = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRequestBy = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReference = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReqID = New DevExpress.XtraEditors.TextEdit()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cmdAuthorized = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.gridPOMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPOMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dtReqDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtReqDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPOTot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTaxValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubtot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPRDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPRPriority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPRRef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPOReq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUIDMaster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItemDets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItemDets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPriority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequestBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReqID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdClose)
        Me.GroupBox2.Controls.Add(Me.cmdDelete)
        Me.GroupBox2.Controls.Add(Me.cmdEdit)
        Me.GroupBox2.Controls.Add(Me.cmdNew)
        Me.GroupBox2.Location = New System.Drawing.Point(1097, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(103, 142)
        Me.GroupBox2.TabIndex = 6
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
        Me.cmdDelete.Text = "PO Cancel"
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
        Me.cmdEdit.Text = "Edit"
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
        Me.cmdNew.Text = "New"
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
        Me.tabMain.Size = New System.Drawing.Size(1067, 589)
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
        Me.XtraTabPage1.Size = New System.Drawing.Size(1065, 562)
        Me.XtraTabPage1.Text = "    PO  List     "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdSearch)
        Me.GroupBox4.Controls.Add(Me.gridPOMain)
        Me.GroupBox4.Controls.Add(Me.LabelControl15)
        Me.GroupBox4.Controls.Add(Me.LabelControl14)
        Me.GroupBox4.Controls.Add(Me.dtFrom)
        Me.GroupBox4.Controls.Add(Me.dtTo)
        Me.GroupBox4.Controls.Add(Me.optClosed)
        Me.GroupBox4.Controls.Add(Me.optOpen)
        Me.GroupBox4.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1054, 546)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'cmdSearch
        '
        Me.cmdSearch.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Appearance.Options.UseFont = True
        Me.cmdSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdSearch.Location = New System.Drawing.Point(740, 17)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(107, 19)
        Me.cmdSearch.TabIndex = 9
        Me.cmdSearch.Text = "Process"
        '
        'gridPOMain
        '
        Me.gridPOMain.Location = New System.Drawing.Point(5, 52)
        Me.gridPOMain.MainView = Me.gvPOMain
        Me.gridPOMain.Name = "gridPOMain"
        Me.gridPOMain.Size = New System.Drawing.Size(1043, 488)
        Me.gridPOMain.TabIndex = 1
        Me.gridPOMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPOMain})
        '
        'gvPOMain
        '
        Me.gvPOMain.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.gvPOMain.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvPOMain.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPOMain.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvPOMain.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPOMain.Appearance.Row.Options.UseFont = True
        Me.gvPOMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemReqCode, Me.colDate, Me.colLevel, Me.colBalance, Me.GridColumn15, Me.GridColumn7, Me.GridColumn13})
        Me.gvPOMain.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvPOMain.GridControl = Me.gridPOMain
        Me.gvPOMain.Name = "gvPOMain"
        Me.gvPOMain.OptionsBehavior.Editable = False
        Me.gvPOMain.OptionsView.ShowGroupPanel = False
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
        Me.colItemReqCode.Caption = "PO Code"
        Me.colItemReqCode.FieldName = "POCode"
        Me.colItemReqCode.Name = "colItemReqCode"
        Me.colItemReqCode.Visible = True
        Me.colItemReqCode.VisibleIndex = 0
        Me.colItemReqCode.Width = 124
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
        Me.colDate.FieldName = "PODate"
        Me.colDate.Name = "colDate"
        Me.colDate.Visible = True
        Me.colDate.VisibleIndex = 1
        Me.colDate.Width = 124
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
        Me.colLevel.Width = 99
        '
        'colBalance
        '
        Me.colBalance.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colBalance.AppearanceCell.Options.UseFont = True
        Me.colBalance.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colBalance.AppearanceHeader.Options.UseFont = True
        Me.colBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBalance.Caption = "Created By"
        Me.colBalance.FieldName = "CreatedBy"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.Visible = True
        Me.colBalance.VisibleIndex = 3
        Me.colBalance.Width = 223
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Is Authorized"
        Me.GridColumn15.FieldName = "IsAuthorized"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 4
        Me.GridColumn15.Width = 80
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn7.AppearanceCell.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Authorized By"
        Me.GridColumn7.FieldName = "Authorized"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 219
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn13.AppearanceCell.Options.UseFont = True
        Me.GridColumn13.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn13.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn13.AppearanceHeader.Options.UseFont = True
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.Caption = "POTotal"
        Me.GridColumn13.FieldName = "POTotal"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 6
        Me.GridColumn13.Width = 145
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Location = New System.Drawing.Point(548, 19)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl15.TabIndex = 8
        Me.LabelControl15.Text = "To"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Location = New System.Drawing.Point(343, 19)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl14.TabIndex = 7
        Me.LabelControl14.Text = "From"
        '
        'dtFrom
        '
        Me.dtFrom.EditValue = Nothing
        Me.dtFrom.Location = New System.Drawing.Point(383, 16)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrom.Properties.Appearance.Options.UseFont = True
        Me.dtFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFrom.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtFrom.Size = New System.Drawing.Size(151, 20)
        Me.dtFrom.TabIndex = 6
        '
        'dtTo
        '
        Me.dtTo.EditValue = Nothing
        Me.dtTo.Location = New System.Drawing.Point(572, 16)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Properties.Appearance.Options.UseFont = True
        Me.dtTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtTo.Size = New System.Drawing.Size(151, 20)
        Me.dtTo.TabIndex = 5
        '
        'optClosed
        '
        Me.optClosed.AutoSize = True
        Me.optClosed.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optClosed.Location = New System.Drawing.Point(105, 17)
        Me.optClosed.Name = "optClosed"
        Me.optClosed.Size = New System.Drawing.Size(98, 17)
        Me.optClosed.TabIndex = 4
        Me.optClosed.Text = "Closed Orders"
        Me.optClosed.UseVisualStyleBackColor = True
        '
        'optOpen
        '
        Me.optOpen.AutoSize = True
        Me.optOpen.Checked = True
        Me.optOpen.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optOpen.Location = New System.Drawing.Point(7, 17)
        Me.optOpen.Name = "optOpen"
        Me.optOpen.Size = New System.Drawing.Size(92, 17)
        Me.optOpen.TabIndex = 3
        Me.optOpen.TabStop = True
        Me.optOpen.Text = "Open Orders"
        Me.optOpen.UseVisualStyleBackColor = True
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1048, 527)
        Me.ShapeContainer2.TabIndex = 2
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.Control
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 1
        Me.LineShape3.X2 = 725
        Me.LineShape3.Y1 = 26
        Me.LineShape3.Y2 = 26
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
        Me.XtraTabPage2.Size = New System.Drawing.Size(1065, 562)
        Me.XtraTabPage2.Text = "     Details        "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dtReqDate)
        Me.GroupBox5.Controls.Add(Me.LabelControl18)
        Me.GroupBox5.Controls.Add(Me.txtPOTot)
        Me.GroupBox5.Controls.Add(Me.LabelControl17)
        Me.GroupBox5.Controls.Add(Me.txtTaxValue)
        Me.GroupBox5.Controls.Add(Me.LabelControl16)
        Me.GroupBox5.Controls.Add(Me.txtSubtot)
        Me.GroupBox5.Controls.Add(Me.txtPRDate)
        Me.GroupBox5.Controls.Add(Me.txtPRPriority)
        Me.GroupBox5.Controls.Add(Me.txtPRRef)
        Me.GroupBox5.Controls.Add(Me.LabelControl13)
        Me.GroupBox5.Controls.Add(Me.LabelControl12)
        Me.GroupBox5.Controls.Add(Me.LabelControl11)
        Me.GroupBox5.Controls.Add(Me.LabelControl9)
        Me.GroupBox5.Controls.Add(Me.cmbPOReq)
        Me.GroupBox5.Controls.Add(Me.txtUIDMaster)
        Me.GroupBox5.Controls.Add(Me.LabelControl8)
        Me.GroupBox5.Controls.Add(Me.LabelControl5)
        Me.GroupBox5.Controls.Add(Me.cmbSupplier)
        Me.GroupBox5.Controls.Add(Me.LabelControl7)
        Me.GroupBox5.Controls.Add(Me.LabelControl6)
        Me.GroupBox5.Controls.Add(Me.lbl28)
        Me.GroupBox5.Controls.Add(Me.gridItemDets)
        Me.GroupBox5.Controls.Add(Me.cmbPriority)
        Me.GroupBox5.Controls.Add(Me.LabelControl4)
        Me.GroupBox5.Controls.Add(Me.txtRequestBy)
        Me.GroupBox5.Controls.Add(Me.LabelControl2)
        Me.GroupBox5.Controls.Add(Me.txtReference)
        Me.GroupBox5.Controls.Add(Me.LabelControl10)
        Me.GroupBox5.Controls.Add(Me.LabelControl3)
        Me.GroupBox5.Controls.Add(Me.LabelControl1)
        Me.GroupBox5.Controls.Add(Me.txtReqID)
        Me.GroupBox5.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1056, 529)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'dtReqDate
        '
        Me.dtReqDate.EditValue = Nothing
        Me.dtReqDate.Location = New System.Drawing.Point(568, 13)
        Me.dtReqDate.Name = "dtReqDate"
        Me.dtReqDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtReqDate.Properties.Appearance.Options.UseFont = True
        Me.dtReqDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtReqDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtReqDate.Size = New System.Drawing.Size(142, 20)
        Me.dtReqDate.TabIndex = 60
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Location = New System.Drawing.Point(808, 505)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl18.TabIndex = 59
        Me.LabelControl18.Text = "PO Total"
        '
        'txtPOTot
        '
        Me.txtPOTot.Location = New System.Drawing.Point(869, 502)
        Me.txtPOTot.Name = "txtPOTot"
        Me.txtPOTot.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOTot.Properties.Appearance.Options.UseFont = True
        Me.txtPOTot.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPOTot.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPOTot.Size = New System.Drawing.Size(108, 20)
        Me.txtPOTot.TabIndex = 58
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Location = New System.Drawing.Point(808, 479)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl17.TabIndex = 57
        Me.LabelControl17.Text = "Tax Value"
        '
        'txtTaxValue
        '
        Me.txtTaxValue.Location = New System.Drawing.Point(869, 476)
        Me.txtTaxValue.Name = "txtTaxValue"
        Me.txtTaxValue.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxValue.Properties.Appearance.Options.UseFont = True
        Me.txtTaxValue.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTaxValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTaxValue.Size = New System.Drawing.Size(108, 20)
        Me.txtTaxValue.TabIndex = 56
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Location = New System.Drawing.Point(808, 453)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl16.TabIndex = 55
        Me.LabelControl16.Text = "Sub Total"
        '
        'txtSubtot
        '
        Me.txtSubtot.Location = New System.Drawing.Point(869, 450)
        Me.txtSubtot.Name = "txtSubtot"
        Me.txtSubtot.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtot.Properties.Appearance.Options.UseFont = True
        Me.txtSubtot.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSubtot.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSubtot.Size = New System.Drawing.Size(108, 20)
        Me.txtSubtot.TabIndex = 54
        '
        'txtPRDate
        '
        Me.txtPRDate.Location = New System.Drawing.Point(568, 118)
        Me.txtPRDate.Name = "txtPRDate"
        Me.txtPRDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRDate.Properties.Appearance.Options.UseFont = True
        Me.txtPRDate.Size = New System.Drawing.Size(142, 20)
        Me.txtPRDate.TabIndex = 53
        '
        'txtPRPriority
        '
        Me.txtPRPriority.Location = New System.Drawing.Point(568, 144)
        Me.txtPRPriority.Name = "txtPRPriority"
        Me.txtPRPriority.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRPriority.Properties.Appearance.Options.UseFont = True
        Me.txtPRPriority.Size = New System.Drawing.Size(142, 20)
        Me.txtPRPriority.TabIndex = 52
        '
        'txtPRRef
        '
        Me.txtPRRef.Location = New System.Drawing.Point(130, 143)
        Me.txtPRRef.Name = "txtPRRef"
        Me.txtPRRef.Size = New System.Drawing.Size(350, 30)
        Me.txtPRRef.TabIndex = 51
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(526, 145)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl13.TabIndex = 49
        Me.LabelControl13.Text = "Priority"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(6, 145)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl12.TabIndex = 48
        Me.LabelControl12.Text = "Reference"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(6, 121)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl11.TabIndex = 47
        Me.LabelControl11.Text = "Purchase Requisition #"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(427, 121)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(135, 13)
        Me.LabelControl9.TabIndex = 45
        Me.LabelControl9.Text = "Purchase Requisition Date"
        '
        'cmbPOReq
        '
        Me.cmbPOReq.Location = New System.Drawing.Point(130, 118)
        Me.cmbPOReq.Name = "cmbPOReq"
        Me.cmbPOReq.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPOReq.Properties.Appearance.Options.UseFont = True
        Me.cmbPOReq.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPOReq.Properties.NullText = ""
        Me.cmbPOReq.Size = New System.Drawing.Size(218, 20)
        Me.cmbPOReq.TabIndex = 44
        '
        'txtUIDMaster
        '
        Me.txtUIDMaster.Location = New System.Drawing.Point(330, 81)
        Me.txtUIDMaster.Name = "txtUIDMaster"
        Me.txtUIDMaster.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUIDMaster.Properties.Appearance.Options.UseFont = True
        Me.txtUIDMaster.Size = New System.Drawing.Size(55, 20)
        Me.txtUIDMaster.TabIndex = 42
        Me.txtUIDMaster.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl8.Location = New System.Drawing.Point(323, 42)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl8.TabIndex = 41
        Me.LabelControl8.Text = "*"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(6, 47)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl5.TabIndex = 40
        Me.LabelControl5.Text = "Supplier"
        '
        'cmbSupplier
        '
        Me.cmbSupplier.Location = New System.Drawing.Point(99, 44)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSupplier.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Suppliercode", "Supplier Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Suppliername", "Supplier")})
        Me.cmbSupplier.Properties.NullText = ""
        Me.cmbSupplier.Size = New System.Drawing.Size(218, 20)
        Me.cmbSupplier.TabIndex = 39
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl7.Location = New System.Drawing.Point(1042, 166)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl7.TabIndex = 38
        Me.LabelControl7.Text = "*"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl6.Location = New System.Drawing.Point(716, 17)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl6.TabIndex = 37
        Me.LabelControl6.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(247, 17)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 36
        Me.lbl28.Text = "*"
        '
        'gridItemDets
        '
        Me.gridItemDets.Location = New System.Drawing.Point(6, 188)
        Me.gridItemDets.MainView = Me.gvItemDets
        Me.gridItemDets.Name = "gridItemDets"
        Me.gridItemDets.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repItemList, Me.RepositoryItemCheckEdit1})
        Me.gridItemDets.Size = New System.Drawing.Size(1044, 256)
        Me.gridItemDets.TabIndex = 35
        Me.gridItemDets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItemDets})
        '
        'gvItemDets
        '
        Me.gvItemDets.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvItemDets.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvItemDets.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvItemDets.Appearance.Row.Options.UseFont = True
        Me.gvItemDets.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn8, Me.GridColumn9, Me.GridColumn6, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn14})
        Me.gvItemDets.GridControl = Me.gridItemDets
        Me.gvItemDets.Name = "gvItemDets"
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
        Me.GridColumn1.FieldName = "Itemcode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 108
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
        Me.GridColumn2.Width = 260
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
        Me.GridColumn3.Caption = "Consumption"
        Me.GridColumn3.FieldName = "Consumption"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 82
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
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 65
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn5.AppearanceCell.Options.UseFont = True
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.Caption = "Item Rate"
        Me.GridColumn5.FieldName = "Itemprice"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 64
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn8.AppearanceCell.Options.UseFont = True
        Me.GridColumn8.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn8.AppearanceHeader.Options.UseFont = True
        Me.GridColumn8.Caption = "Processed Qty"
        Me.GridColumn8.FieldName = "ProcessQty"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 5
        Me.GridColumn8.Width = 88
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "IsProcessed"
        Me.GridColumn9.FieldName = "IsProcessed"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "UID"
        Me.GridColumn6.FieldName = "UIDDetail"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn10.AppearanceCell.Options.UseFont = True
        Me.GridColumn10.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn10.AppearanceHeader.Options.UseFont = True
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "TaxCode"
        Me.GridColumn10.FieldName = "TaxCode"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 6
        Me.GridColumn10.Width = 63
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn11.AppearanceCell.Options.UseFont = True
        Me.GridColumn11.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn11.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn11.AppearanceHeader.Options.UseFont = True
        Me.GridColumn11.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "TaxValue"
        Me.GridColumn11.FieldName = "TaxValue"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 7
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn12.AppearanceCell.Options.UseFont = True
        Me.GridColumn12.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn12.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn12.AppearanceHeader.Options.UseFont = True
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.Caption = "SubTotal"
        Me.GridColumn12.FieldName = "SubTotal"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 8
        Me.GridColumn12.Width = 130
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn14.AppearanceCell.Options.UseFont = True
        Me.GridColumn14.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn14.AppearanceHeader.Options.UseFont = True
        Me.GridColumn14.Caption = "Is Select"
        Me.GridColumn14.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn14.FieldName = "IsSelect"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 9
        Me.GridColumn14.Width = 80
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'repItemList
        '
        Me.repItemList.AutoHeight = False
        Me.repItemList.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repItemList.Name = "repItemList"
        '
        'cmbPriority
        '
        Me.cmbPriority.Location = New System.Drawing.Point(568, 44)
        Me.cmbPriority.Name = "cmbPriority"
        Me.cmbPriority.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPriority.Properties.Items.AddRange(New Object() {"Low", "Medium", "High"})
        Me.cmbPriority.Size = New System.Drawing.Size(142, 20)
        Me.cmbPriority.TabIndex = 31
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(448, 72)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl4.TabIndex = 30
        Me.LabelControl4.Text = "Created By"
        '
        'txtRequestBy
        '
        Me.txtRequestBy.Location = New System.Drawing.Point(509, 70)
        Me.txtRequestBy.Name = "txtRequestBy"
        Me.txtRequestBy.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestBy.Properties.Appearance.Options.UseFont = True
        Me.txtRequestBy.Properties.ReadOnly = True
        Me.txtRequestBy.Size = New System.Drawing.Size(201, 20)
        Me.txtRequestBy.TabIndex = 29
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(526, 45)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl2.TabIndex = 28
        Me.LabelControl2.Text = "Priority"
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(99, 70)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(218, 31)
        Me.txtReference.TabIndex = 24
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(538, 20)
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
        Me.LabelControl1.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Purchase Order #"
        '
        'txtReqID
        '
        Me.txtReqID.Location = New System.Drawing.Point(99, 18)
        Me.txtReqID.Name = "txtReqID"
        Me.txtReqID.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReqID.Properties.Appearance.Options.UseFont = True
        Me.txtReqID.Size = New System.Drawing.Size(142, 20)
        Me.txtReqID.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 18)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1050, 508)
        Me.ShapeContainer1.TabIndex = 43
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 25
        Me.LineShape2.X2 = 1035
        Me.LineShape2.Y1 = 163
        Me.LineShape2.Y2 = 163
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 27
        Me.LineShape1.X2 = 733
        Me.LineShape1.Y1 = 89
        Me.LineShape1.Y2 = 91
        '
        'cmdAuthorized
        '
        Me.cmdAuthorized.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAuthorized.Appearance.Options.UseFont = True
        Me.cmdAuthorized.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdAuthorized.Location = New System.Drawing.Point(5, 15)
        Me.cmdAuthorized.Name = "cmdAuthorized"
        Me.cmdAuthorized.Size = New System.Drawing.Size(99, 36)
        Me.cmdAuthorized.TabIndex = 7
        Me.cmdAuthorized.Text = "PO Authorization"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdAuthorized)
        Me.GroupBox3.Location = New System.Drawing.Point(1097, 190)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(110, 62)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(1110, 570)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(84, 31)
        Me.PictureEdit1.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdPrint)
        Me.GroupBox1.Location = New System.Drawing.Point(1102, 373)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(103, 56)
        Me.GroupBox1.TabIndex = 11
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
        'frmPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(1212, 613)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmPurchaseOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.gridPOMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPOMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dtReqDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtReqDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPOTot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTaxValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubtot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPRDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPRPriority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPRRef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPOReq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUIDMaster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItemDets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItemDets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPriority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequestBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReqID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabMain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents gridPOMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPOMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemReqCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLevel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUIDMaster As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbSupplier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridItemDets As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvItemDets As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repItemList As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cmbPriority As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRequestBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReference As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReqID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbPOReq As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPRRef As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents optClosed As System.Windows.Forms.RadioButton
    Friend WithEvents optOpen As System.Windows.Forms.RadioButton
    Friend WithEvents dtFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPRPriority As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPRDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPOTot As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTaxValue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSubtot As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents dtReqDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAuthorized As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
End Class
