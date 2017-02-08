<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchReq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchReq))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton()
        Me.tabMain = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gridPOReq = New DevExpress.XtraGrid.GridControl()
        Me.gvPOReq = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemReqCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLevel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
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
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repItemList = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
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
        Me.grpIR = New System.Windows.Forms.GroupBox()
        Me.cmdItemReq = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdAuthorized = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmdCertified = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.gridPOReq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPOReq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.txtUIDMaster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItemDets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItemDets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPriority.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRequestBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtReqDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtReqDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReqID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpIR.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdDelete)
        Me.GroupBox2.Controls.Add(Me.cmdEdit)
        Me.GroupBox2.Controls.Add(Me.cmdNew)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance.Font = CType(resources.GetObject("cmdDelete.Appearance.Font"), System.Drawing.Font)
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        resources.ApplyResources(Me.cmdDelete, "cmdDelete")
        Me.cmdDelete.Name = "cmdDelete"
        '
        'cmdEdit
        '
        Me.cmdEdit.Appearance.Font = CType(resources.GetObject("cmdEdit.Appearance.Font"), System.Drawing.Font)
        Me.cmdEdit.Appearance.Options.UseFont = True
        Me.cmdEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        resources.ApplyResources(Me.cmdEdit, "cmdEdit")
        Me.cmdEdit.Name = "cmdEdit"
        '
        'cmdNew
        '
        Me.cmdNew.Appearance.Font = CType(resources.GetObject("cmdNew.Appearance.Font"), System.Drawing.Font)
        Me.cmdNew.Appearance.Options.UseFont = True
        Me.cmdNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        resources.ApplyResources(Me.cmdNew, "cmdNew")
        Me.cmdNew.Name = "cmdNew"
        '
        'tabMain
        '
        Me.tabMain.AppearancePage.Header.Font = CType(resources.GetObject("tabMain.AppearancePage.Header.Font"), System.Drawing.Font)
        Me.tabMain.AppearancePage.Header.Options.UseFont = True
        Me.tabMain.AppearancePage.HeaderActive.Font = CType(resources.GetObject("tabMain.AppearancePage.HeaderActive.Font"), System.Drawing.Font)
        Me.tabMain.AppearancePage.HeaderActive.Options.UseFont = True
        resources.ApplyResources(Me.tabMain, "tabMain")
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedTabPage = Me.XtraTabPage1
        Me.tabMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = CType(resources.GetObject("XtraTabPage1.Appearance.Header.Font"), System.Drawing.Font)
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Appearance.HeaderActive.Font = CType(resources.GetObject("XtraTabPage1.Appearance.HeaderActive.Font"), System.Drawing.Font)
        Me.XtraTabPage1.Appearance.HeaderActive.Options.UseFont = True
        Me.XtraTabPage1.Controls.Add(Me.GroupBox4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        resources.ApplyResources(Me.XtraTabPage1, "XtraTabPage1")
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.gridPOReq)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'gridPOReq
        '
        resources.ApplyResources(Me.gridPOReq, "gridPOReq")
        Me.gridPOReq.MainView = Me.gvPOReq
        Me.gridPOReq.Name = "gridPOReq"
        Me.gridPOReq.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPOReq})
        '
        'gvPOReq
        '
        Me.gvPOReq.Appearance.FocusedCell.BackColor = CType(resources.GetObject("gvPOReq.Appearance.FocusedCell.BackColor"), System.Drawing.Color)
        Me.gvPOReq.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvPOReq.Appearance.HeaderPanel.Font = CType(resources.GetObject("gvPOReq.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.gvPOReq.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvPOReq.Appearance.Row.Font = CType(resources.GetObject("gvPOReq.Appearance.Row.Font"), System.Drawing.Font)
        Me.gvPOReq.Appearance.Row.Options.UseFont = True
        Me.gvPOReq.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemReqCode, Me.colDate, Me.colLevel, Me.colBalance, Me.GridColumn7, Me.GridColumn8})
        Me.gvPOReq.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvPOReq.GridControl = Me.gridPOReq
        Me.gvPOReq.Name = "gvPOReq"
        Me.gvPOReq.OptionsBehavior.Editable = False
        Me.gvPOReq.OptionsView.ShowGroupPanel = False
        '
        'colItemReqCode
        '
        Me.colItemReqCode.AppearanceCell.Font = CType(resources.GetObject("colItemReqCode.AppearanceCell.Font"), System.Drawing.Font)
        Me.colItemReqCode.AppearanceCell.Options.UseFont = True
        Me.colItemReqCode.AppearanceCell.Options.UseTextOptions = True
        Me.colItemReqCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemReqCode.AppearanceHeader.Font = CType(resources.GetObject("colItemReqCode.AppearanceHeader.Font"), System.Drawing.Font)
        Me.colItemReqCode.AppearanceHeader.Options.UseFont = True
        Me.colItemReqCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemReqCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colItemReqCode, "colItemReqCode")
        Me.colItemReqCode.FieldName = "POReqCode"
        Me.colItemReqCode.Name = "colItemReqCode"
        '
        'colDate
        '
        Me.colDate.AppearanceCell.Font = CType(resources.GetObject("colDate.AppearanceCell.Font"), System.Drawing.Font)
        Me.colDate.AppearanceCell.Options.UseFont = True
        Me.colDate.AppearanceCell.Options.UseTextOptions = True
        Me.colDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDate.AppearanceHeader.Font = CType(resources.GetObject("colDate.AppearanceHeader.Font"), System.Drawing.Font)
        Me.colDate.AppearanceHeader.Options.UseFont = True
        Me.colDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colDate, "colDate")
        Me.colDate.FieldName = "ReqDate"
        Me.colDate.Name = "colDate"
        '
        'colLevel
        '
        Me.colLevel.AppearanceCell.Font = CType(resources.GetObject("colLevel.AppearanceCell.Font"), System.Drawing.Font)
        Me.colLevel.AppearanceCell.Options.UseFont = True
        Me.colLevel.AppearanceCell.Options.UseTextOptions = True
        Me.colLevel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLevel.AppearanceHeader.Font = CType(resources.GetObject("colLevel.AppearanceHeader.Font"), System.Drawing.Font)
        Me.colLevel.AppearanceHeader.Options.UseFont = True
        Me.colLevel.AppearanceHeader.Options.UseTextOptions = True
        Me.colLevel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colLevel, "colLevel")
        Me.colLevel.FieldName = "PriorityLevel"
        Me.colLevel.Name = "colLevel"
        '
        'colBalance
        '
        Me.colBalance.AppearanceCell.Font = CType(resources.GetObject("colBalance.AppearanceCell.Font"), System.Drawing.Font)
        Me.colBalance.AppearanceCell.Options.UseFont = True
        Me.colBalance.AppearanceCell.Options.UseTextOptions = True
        Me.colBalance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBalance.AppearanceHeader.Font = CType(resources.GetObject("colBalance.AppearanceHeader.Font"), System.Drawing.Font)
        Me.colBalance.AppearanceHeader.Options.UseFont = True
        Me.colBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.colBalance, "colBalance")
        Me.colBalance.FieldName = "ReqBy"
        Me.colBalance.Name = "colBalance"
        '
        'GridColumn7
        '
        resources.ApplyResources(Me.GridColumn7, "GridColumn7")
        Me.GridColumn7.FieldName = "IsAuthorized"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        resources.ApplyResources(Me.GridColumn8, "GridColumn8")
        Me.GridColumn8.FieldName = "IsCertified"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.Header.Font = CType(resources.GetObject("XtraTabPage2.Appearance.Header.Font"), System.Drawing.Font)
        Me.XtraTabPage2.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage2.Appearance.HeaderActive.Font = CType(resources.GetObject("XtraTabPage2.Appearance.HeaderActive.Font"), System.Drawing.Font)
        Me.XtraTabPage2.Appearance.HeaderActive.Options.UseFont = True
        Me.XtraTabPage2.Controls.Add(Me.GroupBox5)
        resources.ApplyResources(Me.XtraTabPage2, "XtraTabPage2")
        Me.XtraTabPage2.Name = "XtraTabPage2"
        '
        'GroupBox5
        '
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
        Me.GroupBox5.Controls.Add(Me.dtReqDate)
        Me.GroupBox5.Controls.Add(Me.txtReference)
        Me.GroupBox5.Controls.Add(Me.LabelControl10)
        Me.GroupBox5.Controls.Add(Me.LabelControl3)
        Me.GroupBox5.Controls.Add(Me.LabelControl1)
        Me.GroupBox5.Controls.Add(Me.txtReqID)
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'txtUIDMaster
        '
        resources.ApplyResources(Me.txtUIDMaster, "txtUIDMaster")
        Me.txtUIDMaster.Name = "txtUIDMaster"
        Me.txtUIDMaster.Properties.Appearance.Font = CType(resources.GetObject("txtUIDMaster.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtUIDMaster.Properties.Appearance.Options.UseFont = True
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = CType(resources.GetObject("LabelControl8.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl8.Appearance.ForeColor = CType(resources.GetObject("LabelControl8.Appearance.ForeColor"), System.Drawing.Color)
        resources.ApplyResources(Me.LabelControl8, "LabelControl8")
        Me.LabelControl8.Name = "LabelControl8"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = CType(resources.GetObject("LabelControl5.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        '
        'cmbSupplier
        '
        resources.ApplyResources(Me.cmbSupplier, "cmbSupplier")
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbSupplier.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbSupplier.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("cmbSupplier.Properties.Columns"), resources.GetString("cmbSupplier.Properties.Columns1")), New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("cmbSupplier.Properties.Columns2"), resources.GetString("cmbSupplier.Properties.Columns3"))})
        Me.cmbSupplier.Properties.NullText = resources.GetString("cmbSupplier.Properties.NullText")
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = CType(resources.GetObject("LabelControl7.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl7.Appearance.ForeColor = CType(resources.GetObject("LabelControl7.Appearance.ForeColor"), System.Drawing.Color)
        resources.ApplyResources(Me.LabelControl7, "LabelControl7")
        Me.LabelControl7.Name = "LabelControl7"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = CType(resources.GetObject("LabelControl6.Appearance.Font"), System.Drawing.Font)
        Me.LabelControl6.Appearance.ForeColor = CType(resources.GetObject("LabelControl6.Appearance.ForeColor"), System.Drawing.Color)
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Name = "LabelControl6"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = CType(resources.GetObject("lbl28.Appearance.Font"), System.Drawing.Font)
        Me.lbl28.Appearance.ForeColor = CType(resources.GetObject("lbl28.Appearance.ForeColor"), System.Drawing.Color)
        resources.ApplyResources(Me.lbl28, "lbl28")
        Me.lbl28.Name = "lbl28"
        '
        'gridItemDets
        '
        resources.ApplyResources(Me.gridItemDets, "gridItemDets")
        Me.gridItemDets.MainView = Me.gvItemDets
        Me.gridItemDets.Name = "gridItemDets"
        Me.gridItemDets.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repItemList})
        Me.gridItemDets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItemDets})
        '
        'gvItemDets
        '
        Me.gvItemDets.Appearance.HeaderPanel.Font = CType(resources.GetObject("gvItemDets.Appearance.HeaderPanel.Font"), System.Drawing.Font)
        Me.gvItemDets.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvItemDets.Appearance.Row.Font = CType(resources.GetObject("gvItemDets.Appearance.Row.Font"), System.Drawing.Font)
        Me.gvItemDets.Appearance.Row.Options.UseFont = True
        Me.gvItemDets.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.gvItemDets.GridControl = Me.gridItemDets
        Me.gvItemDets.Name = "gvItemDets"
        Me.gvItemDets.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Font = CType(resources.GetObject("GridColumn1.AppearanceCell.Font"), System.Drawing.Font)
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Font = CType(resources.GetObject("GridColumn1.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn1, "GridColumn1")
        Me.GridColumn1.FieldName = "Itemcode"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = CType(resources.GetObject("GridColumn2.AppearanceCell.Font"), System.Drawing.Font)
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Font = CType(resources.GetObject("GridColumn2.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn2, "GridColumn2")
        Me.GridColumn2.FieldName = "Itemname"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Font = CType(resources.GetObject("GridColumn3.AppearanceCell.Font"), System.Drawing.Font)
        Me.GridColumn3.AppearanceCell.Options.UseFont = True
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.AppearanceHeader.Font = CType(resources.GetObject("GridColumn3.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn3, "GridColumn3")
        Me.GridColumn3.FieldName = "CurrQty"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Font = CType(resources.GetObject("GridColumn4.AppearanceCell.Font"), System.Drawing.Font)
        Me.GridColumn4.AppearanceCell.Options.UseFont = True
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.AppearanceHeader.Font = CType(resources.GetObject("GridColumn4.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        resources.ApplyResources(Me.GridColumn4, "GridColumn4")
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "OrdQty"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Font = CType(resources.GetObject("GridColumn5.AppearanceCell.Font"), System.Drawing.Font)
        Me.GridColumn5.AppearanceCell.Options.UseFont = True
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Font = CType(resources.GetObject("GridColumn5.AppearanceHeader.Font"), System.Drawing.Font)
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        resources.ApplyResources(Me.GridColumn5, "GridColumn5")
        Me.GridColumn5.FieldName = "Itemprice"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        '
        'GridColumn6
        '
        resources.ApplyResources(Me.GridColumn6, "GridColumn6")
        Me.GridColumn6.FieldName = "UIDDetail"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'repItemList
        '
        resources.ApplyResources(Me.repItemList, "repItemList")
        Me.repItemList.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("repItemList.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.repItemList.Name = "repItemList"
        '
        'cmbPriority
        '
        resources.ApplyResources(Me.cmbPriority, "cmbPriority")
        Me.cmbPriority.Name = "cmbPriority"
        Me.cmbPriority.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbPriority.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbPriority.Properties.Items.AddRange(New Object() {resources.GetString("cmbPriority.Properties.Items"), resources.GetString("cmbPriority.Properties.Items1"), resources.GetString("cmbPriority.Properties.Items2")})
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = CType(resources.GetObject("LabelControl4.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        '
        'txtRequestBy
        '
        resources.ApplyResources(Me.txtRequestBy, "txtRequestBy")
        Me.txtRequestBy.Name = "txtRequestBy"
        Me.txtRequestBy.Properties.Appearance.Font = CType(resources.GetObject("txtRequestBy.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtRequestBy.Properties.Appearance.Options.UseFont = True
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = CType(resources.GetObject("LabelControl2.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'dtReqDate
        '
        resources.ApplyResources(Me.dtReqDate, "dtReqDate")
        Me.dtReqDate.Name = "dtReqDate"
        Me.dtReqDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("dtReqDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.dtReqDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'txtReference
        '
        resources.ApplyResources(Me.txtReference, "txtReference")
        Me.txtReference.Name = "txtReference"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = CType(resources.GetObject("LabelControl10.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl10, "LabelControl10")
        Me.LabelControl10.Name = "LabelControl10"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = CType(resources.GetObject("LabelControl3.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = CType(resources.GetObject("LabelControl1.Appearance.Font"), System.Drawing.Font)
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        '
        'txtReqID
        '
        resources.ApplyResources(Me.txtReqID, "txtReqID")
        Me.txtReqID.Name = "txtReqID"
        Me.txtReqID.Properties.Appearance.Font = CType(resources.GetObject("txtReqID.Properties.Appearance.Font"), System.Drawing.Font)
        Me.txtReqID.Properties.Appearance.Options.UseFont = True
        '
        'grpIR
        '
        Me.grpIR.Controls.Add(Me.cmdItemReq)
        resources.ApplyResources(Me.grpIR, "grpIR")
        Me.grpIR.Name = "grpIR"
        Me.grpIR.TabStop = False
        '
        'cmdItemReq
        '
        Me.cmdItemReq.Appearance.Font = CType(resources.GetObject("cmdItemReq.Appearance.Font"), System.Drawing.Font)
        Me.cmdItemReq.Appearance.Options.UseFont = True
        Me.cmdItemReq.Appearance.Options.UseTextOptions = True
        Me.cmdItemReq.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdItemReq.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        resources.ApplyResources(Me.cmdItemReq, "cmdItemReq")
        Me.cmdItemReq.Name = "cmdItemReq"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdAuthorized)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'cmdAuthorized
        '
        Me.cmdAuthorized.Appearance.Font = CType(resources.GetObject("cmdAuthorized.Appearance.Font"), System.Drawing.Font)
        Me.cmdAuthorized.Appearance.Options.UseFont = True
        Me.cmdAuthorized.Appearance.Options.UseTextOptions = True
        Me.cmdAuthorized.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdAuthorized.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        resources.ApplyResources(Me.cmdAuthorized, "cmdAuthorized")
        Me.cmdAuthorized.Name = "cmdAuthorized"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmdCertified)
        resources.ApplyResources(Me.GroupBox6, "GroupBox6")
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.TabStop = False
        '
        'cmdCertified
        '
        Me.cmdCertified.Appearance.Font = CType(resources.GetObject("cmdCertified.Appearance.Font"), System.Drawing.Font)
        Me.cmdCertified.Appearance.Options.UseFont = True
        Me.cmdCertified.Appearance.Options.UseTextOptions = True
        Me.cmdCertified.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdCertified.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        resources.ApplyResources(Me.cmdCertified, "cmdCertified")
        Me.cmdCertified.Name = "cmdCertified"
        '
        'PictureEdit1
        '
        resources.ApplyResources(Me.PictureEdit1, "PictureEdit1")
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = CType(resources.GetObject("PictureEdit1.Properties.Appearance.BackColor"), System.Drawing.Color)
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdPrint)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'cmdPrint
        '
        Me.cmdPrint.Appearance.Font = CType(resources.GetObject("cmdPrint.Appearance.Font"), System.Drawing.Font)
        Me.cmdPrint.Appearance.Options.UseFont = True
        Me.cmdPrint.Appearance.Options.UseTextOptions = True
        Me.cmdPrint.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.cmdPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        resources.ApplyResources(Me.cmdPrint, "cmdPrint")
        Me.cmdPrint.Name = "cmdPrint"
        '
        'frmPurchReq
        '
        Me.Appearance.Font = CType(resources.GetObject("frmPurchReq.Appearance.Font"), System.Drawing.Font)
        Me.Appearance.Options.UseFont = True
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpIR)
        Me.Controls.Add(Me.GroupBox2)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmPurchReq"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.gridPOReq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPOReq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.txtUIDMaster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItemDets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItemDets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPriority.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRequestBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtReqDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtReqDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReqID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpIR.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
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
    Friend WithEvents gridPOReq As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPOReq As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemReqCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLevel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridItemDets As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvItemDets As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repItemList As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbPriority As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRequestBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtReqDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtReference As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReqID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbSupplier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents grpIR As System.Windows.Forms.GroupBox
    Friend WithEvents cmdItemReq As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtUIDMaster As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAuthorized As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCertified As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
End Class
