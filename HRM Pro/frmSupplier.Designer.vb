<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
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
        Dim TextAnnotation1 As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
        Dim SeriesPointAnchorPoint1 As DevExpress.XtraCharts.SeriesPointAnchorPoint = New DevExpress.XtraCharts.SeriesPointAnchorPoint()
        Dim RelativePosition1 As DevExpress.XtraCharts.RelativePosition = New DevExpress.XtraCharts.RelativePosition()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SeriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Jan", New Object() {CType(10.0R, Object)}, 0)
        Dim SeriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Feb")
        Dim SeriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Mar")
        Dim SeriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Apr")
        Dim SeriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("May", New Object() {CType(50.0R, Object)})
        Dim SeriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Jun")
        Dim SeriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Jul")
        Dim SeriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Aug")
        Dim SeriesPoint9 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Sep")
        Dim SeriesPoint10 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Oct")
        Dim SeriesPoint11 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Nov")
        Dim SeriesPoint12 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Dec")
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupplier))
        Me.tabSupplier = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gridSupplier = New DevExpress.XtraGrid.GridControl()
        Me.vwMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSuppID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtCreate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCountry = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.chkStatus = New DevExpress.XtraEditors.CheckEdit()
        Me.lbl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBalance = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPhone1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtReference = New DevExpress.XtraEditors.MemoEdit()
        Me.txtFax = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.txtAddress = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSupplierName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPhone2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCompany = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtWeb = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBank = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAccountno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSuppliercode = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tabSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSupplier.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vwMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dtCreate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCreate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBalance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhone1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSupplierName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhone2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWeb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccountno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuppliercode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(TextAnnotation1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SeriesPointAnchorPoint1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabSupplier
        '
        Me.tabSupplier.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabSupplier.AppearancePage.Header.Options.UseFont = True
        Me.tabSupplier.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabSupplier.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabSupplier.Location = New System.Drawing.Point(12, 12)
        Me.tabSupplier.Name = "tabSupplier"
        Me.tabSupplier.SelectedTabPage = Me.XtraTabPage1
        Me.tabSupplier.Size = New System.Drawing.Size(589, 368)
        Me.tabSupplier.TabIndex = 0
        Me.tabSupplier.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gridSupplier)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(587, 343)
        Me.XtraTabPage1.Text = "Supplier List"
        '
        'gridSupplier
        '
        Me.gridSupplier.Location = New System.Drawing.Point(8, 8)
        Me.gridSupplier.MainView = Me.vwMain
        Me.gridSupplier.Name = "gridSupplier"
        Me.gridSupplier.Size = New System.Drawing.Size(564, 327)
        Me.gridSupplier.TabIndex = 0
        Me.gridSupplier.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vwMain})
        '
        'vwMain
        '
        Me.vwMain.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.vwMain.Appearance.FocusedCell.Options.UseBackColor = True
        Me.vwMain.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vwMain.Appearance.HeaderPanel.Options.UseFont = True
        Me.vwMain.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vwMain.Appearance.Row.Options.UseFont = True
        Me.vwMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSuppID, Me.colSupplier, Me.colTelNo, Me.colBalance})
        Me.vwMain.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.vwMain.GridControl = Me.gridSupplier
        Me.vwMain.Name = "vwMain"
        Me.vwMain.OptionsBehavior.Editable = False
        Me.vwMain.OptionsCustomization.AllowGroup = False
        Me.vwMain.OptionsView.ShowGroupPanel = False
        '
        'colSuppID
        '
        Me.colSuppID.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colSuppID.AppearanceCell.Options.UseFont = True
        Me.colSuppID.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colSuppID.AppearanceHeader.Options.UseFont = True
        Me.colSuppID.AppearanceHeader.Options.UseTextOptions = True
        Me.colSuppID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSuppID.Caption = "Supplier ID"
        Me.colSuppID.FieldName = "Suppliercode"
        Me.colSuppID.Name = "colSuppID"
        Me.colSuppID.Visible = True
        Me.colSuppID.VisibleIndex = 0
        Me.colSuppID.Width = 104
        '
        'colSupplier
        '
        Me.colSupplier.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colSupplier.AppearanceCell.Options.UseFont = True
        Me.colSupplier.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colSupplier.AppearanceHeader.Options.UseFont = True
        Me.colSupplier.AppearanceHeader.Options.UseTextOptions = True
        Me.colSupplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSupplier.Caption = "Supplier"
        Me.colSupplier.FieldName = "Suppliername"
        Me.colSupplier.Name = "colSupplier"
        Me.colSupplier.Visible = True
        Me.colSupplier.VisibleIndex = 1
        Me.colSupplier.Width = 250
        '
        'colTelNo
        '
        Me.colTelNo.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colTelNo.AppearanceCell.Options.UseFont = True
        Me.colTelNo.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colTelNo.AppearanceHeader.Options.UseFont = True
        Me.colTelNo.AppearanceHeader.Options.UseTextOptions = True
        Me.colTelNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTelNo.Caption = "Telephone #"
        Me.colTelNo.FieldName = "Phone1"
        Me.colTelNo.Name = "colTelNo"
        Me.colTelNo.Visible = True
        Me.colTelNo.VisibleIndex = 2
        Me.colTelNo.Width = 80
        '
        'colBalance
        '
        Me.colBalance.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colBalance.AppearanceCell.Options.UseFont = True
        Me.colBalance.AppearanceCell.Options.UseTextOptions = True
        Me.colBalance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colBalance.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colBalance.AppearanceHeader.Options.UseFont = True
        Me.colBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBalance.Caption = "Balance"
        Me.colBalance.DisplayFormat.FormatString = "n2"
        Me.colBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBalance.FieldName = "Balance"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.Visible = True
        Me.colBalance.VisibleIndex = 3
        Me.colBalance.Width = 101
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupBox5)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(587, 343)
        Me.XtraTabPage2.Text = "     Details        "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dtCreate)
        Me.GroupBox5.Controls.Add(Me.LabelControl16)
        Me.GroupBox5.Controls.Add(Me.LabelControl15)
        Me.GroupBox5.Controls.Add(Me.lbl28)
        Me.GroupBox5.Controls.Add(Me.LabelControl7)
        Me.GroupBox5.Controls.Add(Me.LabelControl14)
        Me.GroupBox5.Controls.Add(Me.txtCountry)
        Me.GroupBox5.Controls.Add(Me.LabelControl13)
        Me.GroupBox5.Controls.Add(Me.PanelControl4)
        Me.GroupBox5.Controls.Add(Me.LabelControl12)
        Me.GroupBox5.Controls.Add(Me.txtBalance)
        Me.GroupBox5.Controls.Add(Me.LabelControl11)
        Me.GroupBox5.Controls.Add(Me.txtPhone1)
        Me.GroupBox5.Controls.Add(Me.txtReference)
        Me.GroupBox5.Controls.Add(Me.txtFax)
        Me.GroupBox5.Controls.Add(Me.LabelControl8)
        Me.GroupBox5.Controls.Add(Me.txtEmail)
        Me.GroupBox5.Controls.Add(Me.txtAddress)
        Me.GroupBox5.Controls.Add(Me.LabelControl10)
        Me.GroupBox5.Controls.Add(Me.txtSupplierName)
        Me.GroupBox5.Controls.Add(Me.LabelControl9)
        Me.GroupBox5.Controls.Add(Me.txtPhone2)
        Me.GroupBox5.Controls.Add(Me.LabelControl6)
        Me.GroupBox5.Controls.Add(Me.txtCompany)
        Me.GroupBox5.Controls.Add(Me.LabelControl5)
        Me.GroupBox5.Controls.Add(Me.txtWeb)
        Me.GroupBox5.Controls.Add(Me.LabelControl4)
        Me.GroupBox5.Controls.Add(Me.txtBank)
        Me.GroupBox5.Controls.Add(Me.LabelControl3)
        Me.GroupBox5.Controls.Add(Me.LabelControl2)
        Me.GroupBox5.Controls.Add(Me.txtAccountno)
        Me.GroupBox5.Controls.Add(Me.LabelControl1)
        Me.GroupBox5.Controls.Add(Me.txtSuppliercode)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(576, 337)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'dtCreate
        '
        Me.dtCreate.EditValue = Nothing
        Me.dtCreate.Location = New System.Drawing.Point(430, 255)
        Me.dtCreate.Name = "dtCreate"
        Me.dtCreate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtCreate.Properties.Appearance.Options.UseFont = True
        Me.dtCreate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCreate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtCreate.Size = New System.Drawing.Size(140, 20)
        Me.dtCreate.TabIndex = 37
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Location = New System.Drawing.Point(364, 257)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl16.TabIndex = 36
        Me.LabelControl16.Text = "Create Date"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl15.Location = New System.Drawing.Point(489, 44)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl15.TabIndex = 35
        Me.LabelControl15.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(217, 18)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 34
        Me.lbl28.Text = "*"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(320, 150)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl7.TabIndex = 33
        Me.LabelControl7.Text = "Web"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Location = New System.Drawing.Point(6, 176)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl14.TabIndex = 32
        Me.LabelControl14.Text = "Country"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(69, 173)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.Properties.Appearance.Options.UseFont = True
        Me.txtCountry.Size = New System.Drawing.Size(271, 20)
        Me.txtCountry.TabIndex = 7
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(392, 301)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl13.TabIndex = 30
        Me.LabelControl13.Text = "Status"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.chkStatus)
        Me.PanelControl4.Controls.Add(Me.lbl9)
        Me.PanelControl4.Location = New System.Drawing.Point(431, 288)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(78, 37)
        Me.PanelControl4.TabIndex = 29
        '
        'chkStatus
        '
        Me.chkStatus.EditValue = True
        Me.chkStatus.Location = New System.Drawing.Point(50, 11)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Properties.Caption = ""
        Me.chkStatus.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.chkStatus.Size = New System.Drawing.Size(21, 19)
        Me.chkStatus.TabIndex = 2
        '
        'lbl9
        '
        Me.lbl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.Location = New System.Drawing.Point(14, 13)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(30, 13)
        Me.lbl9.TabIndex = 0
        Me.lbl9.Text = "Active"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(384, 231)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl12.TabIndex = 28
        Me.LabelControl12.Text = "Balance"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(431, 228)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.Properties.Appearance.Options.UseFont = True
        Me.txtBalance.Size = New System.Drawing.Size(139, 20)
        Me.txtBalance.TabIndex = 27
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(350, 72)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl11.TabIndex = 26
        Me.LabelControl11.Text = "Telephone"
        '
        'txtPhone1
        '
        Me.txtPhone1.Location = New System.Drawing.Point(410, 69)
        Me.txtPhone1.Name = "txtPhone1"
        Me.txtPhone1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone1.Properties.Appearance.Options.UseFont = True
        Me.txtPhone1.Size = New System.Drawing.Size(160, 20)
        Me.txtPhone1.TabIndex = 2
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(69, 280)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(271, 45)
        Me.txtReference.TabIndex = 11
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(410, 121)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Properties.Appearance.Options.UseFont = True
        Me.txtFax.Size = New System.Drawing.Size(160, 20)
        Me.txtFax.TabIndex = 4
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(7, 150)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl8.TabIndex = 22
        Me.LabelControl8.Text = "E-Mail"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(69, 147)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEmail.Size = New System.Drawing.Size(226, 20)
        Me.txtEmail.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(69, 70)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(271, 71)
        Me.txtAddress.TabIndex = 1
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(6, 47)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Supplier"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(69, 44)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierName.Properties.Appearance.Options.UseFont = True
        Me.txtSupplierName.Size = New System.Drawing.Size(414, 20)
        Me.txtSupplierName.TabIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(6, 66)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Address"
        '
        'txtPhone2
        '
        Me.txtPhone2.Location = New System.Drawing.Point(410, 95)
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone2.Properties.Appearance.Options.UseFont = True
        Me.txtPhone2.Size = New System.Drawing.Size(160, 20)
        Me.txtPhone2.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(4, 205)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "Company"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(69, 202)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.Properties.Appearance.Options.UseFont = True
        Me.txtCompany.Size = New System.Drawing.Size(412, 20)
        Me.txtCompany.TabIndex = 8
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(387, 128)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "Fax"
        '
        'txtWeb
        '
        Me.txtWeb.Location = New System.Drawing.Point(350, 147)
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeb.Properties.Appearance.Options.UseFont = True
        Me.txtWeb.Size = New System.Drawing.Size(220, 20)
        Me.txtWeb.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(6, 231)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Bank"
        '
        'txtBank
        '
        Me.txtBank.Location = New System.Drawing.Point(69, 228)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBank.Properties.Appearance.Options.UseFont = True
        Me.txtBank.Size = New System.Drawing.Size(226, 20)
        Me.txtBank.TabIndex = 9
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(7, 283)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Notes"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(6, 257)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Account #"
        '
        'txtAccountno
        '
        Me.txtAccountno.Location = New System.Drawing.Point(69, 254)
        Me.txtAccountno.Name = "txtAccountno"
        Me.txtAccountno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountno.Properties.Appearance.Options.UseFont = True
        Me.txtAccountno.Size = New System.Drawing.Size(226, 20)
        Me.txtAccountno.TabIndex = 10
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(6, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Supplier ID"
        '
        'txtSuppliercode
        '
        Me.txtSuppliercode.Location = New System.Drawing.Point(69, 18)
        Me.txtSuppliercode.Name = "txtSuppliercode"
        Me.txtSuppliercode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppliercode.Properties.Appearance.Options.UseFont = True
        Me.txtSuppliercode.Size = New System.Drawing.Size(142, 20)
        Me.txtSuppliercode.TabIndex = 0
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GroupBox6)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(587, 343)
        Me.XtraTabPage3.Text = "Purchase History"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ChartControl1)
        Me.GroupBox6.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(576, 323)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        '
        'ChartControl1
        '
        SeriesPointAnchorPoint1.SeriesID = 0
        SeriesPointAnchorPoint1.SeriesPointID = 0
        TextAnnotation1.AnchorPoint = SeriesPointAnchorPoint1
        TextAnnotation1.Name = "Text Annotation 1"
        TextAnnotation1.ShapePosition = RelativePosition1
        TextAnnotation1.Text = "Text here"
        Me.ChartControl1.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() {TextAnnotation1})
        XyDiagram1.AxisX.Range.Auto = False
        XyDiagram1.AxisX.Range.MaxValueSerializable = "Dec"
        XyDiagram1.AxisX.Range.MinValueInternal = -0.5R
        XyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Location = New System.Drawing.Point(7, 22)
        Me.ChartControl1.Name = "ChartControl1"
        SideBySideBarSeriesLabel1.LineVisible = True
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.Name = "Series 1"
        Series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint1, SeriesPoint2, SeriesPoint3, SeriesPoint4, SeriesPoint5, SeriesPoint6, SeriesPoint7, SeriesPoint8, SeriesPoint9, SeriesPoint10, SeriesPoint11, SeriesPoint12})
        Series1.SeriesID = 0
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        SideBySideBarSeriesLabel2.LineVisible = True
        Me.ChartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel2
        Me.ChartControl1.Size = New System.Drawing.Size(564, 293)
        Me.ChartControl1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdDelete)
        Me.GroupBox2.Controls.Add(Me.cmdEdit)
        Me.GroupBox2.Controls.Add(Me.cmdAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(607, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(103, 108)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
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
        Me.cmdDelete.Text = "In Active"
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
        'cmdAdd
        '
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdAdd.Location = New System.Drawing.Point(6, 16)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(92, 23)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "Add"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(619, 348)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(84, 31)
        Me.PictureEdit1.TabIndex = 5
        '
        'frmSupplier
        '
        Me.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(717, 387)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.tabSupplier)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier Screen"
        CType(Me.tabSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSupplier.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gridSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vwMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dtCreate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCreate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBalance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhone1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSupplierName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhone2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWeb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccountno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuppliercode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(SeriesPointAnchorPoint1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(TextAnnotation1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tabSupplier As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents gridSupplier As DevExpress.XtraGrid.GridControl
    Friend WithEvents vwMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSuppID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSuppliercode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAddress As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSupplierName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPhone2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCompany As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtWeb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBank As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAccountno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtReference As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPhone1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBalance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents chkStatus As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lbl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCountry As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtCreate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
