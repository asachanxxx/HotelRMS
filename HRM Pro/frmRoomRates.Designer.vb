<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomRates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoomRates))
        Me.tabRoomrates = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcRoomRates = New DevExpress.XtraGrid.GridControl()
        Me.gviewRoomrate = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colguesttype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvalidfrm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValidto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRoom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRoomtype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPackagetype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRoomId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.dtsubedate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dtsubsdate = New DevExpress.XtraEditors.DateEdit()
        Me.txtrate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbRoom = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbMealplan = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbGuesttype = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbRoomtyp = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnInactive = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tabRoomrates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRoomrates.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcRoomRates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gviewRoomrate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.dtsubedate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsubedate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsubsdate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsubsdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRoom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMealplan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGuesttype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRoomtyp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabRoomrates
        '
        Me.tabRoomrates.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabRoomrates.AppearancePage.Header.Options.UseFont = True
        Me.tabRoomrates.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabRoomrates.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabRoomrates.Location = New System.Drawing.Point(12, 6)
        Me.tabRoomrates.Name = "tabRoomrates"
        Me.tabRoomrates.SelectedTabPage = Me.XtraTabPage1
        Me.tabRoomrates.Size = New System.Drawing.Size(589, 244)
        Me.tabRoomrates.TabIndex = 1
        Me.tabRoomrates.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcRoomRates)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(587, 219)
        Me.XtraTabPage1.Text = "Room Rate Details"
        '
        'gcRoomRates
        '
        Me.gcRoomRates.Location = New System.Drawing.Point(8, 8)
        Me.gcRoomRates.MainView = Me.gviewRoomrate
        Me.gcRoomRates.Name = "gcRoomRates"
        Me.gcRoomRates.Size = New System.Drawing.Size(571, 208)
        Me.gcRoomRates.TabIndex = 0
        Me.gcRoomRates.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gviewRoomrate})
        '
        'gviewRoomrate
        '
        Me.gviewRoomrate.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gviewRoomrate.Appearance.HeaderPanel.Options.UseFont = True
        Me.gviewRoomrate.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gviewRoomrate.Appearance.Row.Options.UseFont = True
        Me.gviewRoomrate.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colguesttype, Me.colvalidfrm, Me.colValidto, Me.colRoom, Me.colRoomtype, Me.colPackagetype, Me.colRate, Me.colRoomId})
        Me.gviewRoomrate.GridControl = Me.gcRoomRates
        Me.gviewRoomrate.Name = "gviewRoomrate"
        Me.gviewRoomrate.OptionsView.ShowGroupPanel = False
        '
        'colguesttype
        '
        Me.colguesttype.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colguesttype.AppearanceCell.Options.UseFont = True
        Me.colguesttype.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colguesttype.AppearanceHeader.Options.UseFont = True
        Me.colguesttype.AppearanceHeader.Options.UseTextOptions = True
        Me.colguesttype.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colguesttype.Caption = "Guest Type"
        Me.colguesttype.FieldName = "Custype"
        Me.colguesttype.Name = "colguesttype"
        Me.colguesttype.Visible = True
        Me.colguesttype.VisibleIndex = 0
        '
        'colvalidfrm
        '
        Me.colvalidfrm.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colvalidfrm.AppearanceCell.Options.UseFont = True
        Me.colvalidfrm.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colvalidfrm.AppearanceHeader.Options.UseFont = True
        Me.colvalidfrm.AppearanceHeader.Options.UseTextOptions = True
        Me.colvalidfrm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colvalidfrm.Caption = "Rate Valid From"
        Me.colvalidfrm.FieldName = "ValidSDate"
        Me.colvalidfrm.Name = "colvalidfrm"
        Me.colvalidfrm.Visible = True
        Me.colvalidfrm.VisibleIndex = 1
        '
        'colValidto
        '
        Me.colValidto.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colValidto.AppearanceCell.Options.UseFont = True
        Me.colValidto.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colValidto.AppearanceHeader.Options.UseFont = True
        Me.colValidto.AppearanceHeader.Options.UseTextOptions = True
        Me.colValidto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colValidto.Caption = "Rate Valid To"
        Me.colValidto.FieldName = "ValidEDate"
        Me.colValidto.Name = "colValidto"
        Me.colValidto.Visible = True
        Me.colValidto.VisibleIndex = 2
        '
        'colRoom
        '
        Me.colRoom.Caption = "Room"
        Me.colRoom.FieldName = "Roomtype"
        Me.colRoom.Name = "colRoom"
        Me.colRoom.Visible = True
        Me.colRoom.VisibleIndex = 3
        '
        'colRoomtype
        '
        Me.colRoomtype.Caption = "Room Type"
        Me.colRoomtype.FieldName = "Countype"
        Me.colRoomtype.Name = "colRoomtype"
        Me.colRoomtype.Visible = True
        Me.colRoomtype.VisibleIndex = 4
        '
        'colPackagetype
        '
        Me.colPackagetype.Caption = "Package"
        Me.colPackagetype.FieldName = "Packagetype"
        Me.colPackagetype.Name = "colPackagetype"
        Me.colPackagetype.Visible = True
        Me.colPackagetype.VisibleIndex = 5
        '
        'colRate
        '
        Me.colRate.Caption = "Rate"
        Me.colRate.FieldName = "Rate"
        Me.colRate.Name = "colRate"
        Me.colRate.Visible = True
        Me.colRate.VisibleIndex = 6
        '
        'colRoomId
        '
        Me.colRoomId.Caption = "RatesId"
        Me.colRoomId.FieldName = "RatesId"
        Me.colRoomId.Name = "colRoomId"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage2.Controls.Add(Me.dtsubedate)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.dtsubsdate)
        Me.XtraTabPage2.Controls.Add(Me.txtrate)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl19)
        Me.XtraTabPage2.Controls.Add(Me.cmbRoom)
        Me.XtraTabPage2.Controls.Add(Me.cmbMealplan)
        Me.XtraTabPage2.Controls.Add(Me.cmbGuesttype)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.cmbRoomtyp)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(587, 219)
        Me.XtraTabPage2.Text = "Add New Room Rates      "
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl12.Location = New System.Drawing.Point(207, 185)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl12.TabIndex = 93
        Me.LabelControl12.Text = "*"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl11.Location = New System.Drawing.Point(155, 118)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl11.TabIndex = 92
        Me.LabelControl11.Text = "*"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl10.Location = New System.Drawing.Point(205, 88)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl10.TabIndex = 91
        Me.LabelControl10.Text = "*"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Location = New System.Drawing.Point(205, 58)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl9.TabIndex = 90
        Me.LabelControl9.Text = "*"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl7.Location = New System.Drawing.Point(254, 29)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl7.TabIndex = 89
        Me.LabelControl7.Text = "*"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(348, 156)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(10, 12)
        Me.LabelControl6.TabIndex = 88
        Me.LabelControl6.Text = "To"
        '
        'dtsubedate
        '
        Me.dtsubedate.EditValue = Nothing
        Me.dtsubedate.Location = New System.Drawing.Point(244, 148)
        Me.dtsubedate.Name = "dtsubedate"
        Me.dtsubedate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.dtsubedate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtsubedate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtsubedate.Size = New System.Drawing.Size(100, 22)
        Me.dtsubedate.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(20, 29)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 34
        Me.LabelControl2.Text = "Guest Type"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(205, 156)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(20, 12)
        Me.LabelControl5.TabIndex = 86
        Me.LabelControl5.Text = "From"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(22, 60)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Room "
        '
        'dtsubsdate
        '
        Me.dtsubsdate.EditValue = Nothing
        Me.dtsubsdate.Location = New System.Drawing.Point(101, 147)
        Me.dtsubsdate.Name = "dtsubsdate"
        Me.dtsubsdate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.dtsubsdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtsubsdate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtsubsdate.Size = New System.Drawing.Size(100, 22)
        Me.dtsubsdate.TabIndex = 4
        '
        'txtrate
        '
        Me.txtrate.Location = New System.Drawing.Point(101, 184)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Properties.Appearance.Options.UseFont = True
        Me.txtrate.Size = New System.Drawing.Size(100, 20)
        Me.txtrate.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(22, 153)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl4.TabIndex = 84
        Me.LabelControl4.Text = "Valid Period"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(22, 190)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl8.TabIndex = 22
        Me.LabelControl8.Text = "Rates"
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Location = New System.Drawing.Point(22, 121)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl19.TabIndex = 83
        Me.LabelControl19.Text = "Meal Plan"
        '
        'cmbRoom
        '
        Me.cmbRoom.Location = New System.Drawing.Point(101, 55)
        Me.cmbRoom.Name = "cmbRoom"
        Me.cmbRoom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRoom.Properties.Items.AddRange(New Object() {"Standard", "Superior", "Deluxe"})
        Me.cmbRoom.Size = New System.Drawing.Size(95, 20)
        Me.cmbRoom.TabIndex = 1
        '
        'cmbMealplan
        '
        Me.cmbMealplan.Location = New System.Drawing.Point(101, 116)
        Me.cmbMealplan.Name = "cmbMealplan"
        Me.cmbMealplan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMealplan.Size = New System.Drawing.Size(48, 20)
        Me.cmbMealplan.TabIndex = 3
        '
        'cmbGuesttype
        '
        Me.cmbGuesttype.Location = New System.Drawing.Point(101, 26)
        Me.cmbGuesttype.Name = "cmbGuesttype"
        Me.cmbGuesttype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbGuesttype.Properties.Items.AddRange(New Object() {"FIT", "COMPLEMENTARY", "TOP NON CONTRACTS"})
        Me.cmbGuesttype.Size = New System.Drawing.Size(147, 20)
        Me.cmbGuesttype.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(22, 90)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl3.TabIndex = 37
        Me.LabelControl3.Text = "Room Type"
        '
        'cmbRoomtyp
        '
        Me.cmbRoomtyp.Location = New System.Drawing.Point(101, 87)
        Me.cmbRoomtyp.Name = "cmbRoomtyp"
        Me.cmbRoomtyp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRoomtyp.Properties.Items.AddRange(New Object() {"Single", "Double", "Triple", "Child"})
        Me.cmbRoomtyp.Size = New System.Drawing.Size(95, 20)
        Me.cmbRoomtyp.TabIndex = 2
        '
        'btnInactive
        '
        Me.btnInactive.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInactive.Appearance.Options.UseFont = True
        Me.btnInactive.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnInactive.Location = New System.Drawing.Point(610, 87)
        Me.btnInactive.Name = "btnInactive"
        Me.btnInactive.Size = New System.Drawing.Size(92, 23)
        Me.btnInactive.TabIndex = 2
        Me.btnInactive.Text = "Del"
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Location = New System.Drawing.Point(610, 59)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(92, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(611, 30)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(607, 216)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 16
        '
        'frmRoomRates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(715, 254)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btnInactive)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.tabRoomrates)
        Me.Controls.Add(Me.btnAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmRoomRates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Rates Master"
        CType(Me.tabRoomrates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRoomrates.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcRoomRates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gviewRoomrate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.dtsubedate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtsubedate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtsubsdate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtsubsdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRoom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMealplan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGuesttype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRoomtyp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabRoomrates As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcRoomRates As DevExpress.XtraGrid.GridControl
    Friend WithEvents gviewRoomrate As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colguesttype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvalidfrm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtrate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnInactive As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbGuesttype As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbRoom As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbRoomtyp As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbMealplan As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtsubsdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtsubedate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colRoom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRoomtype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPackagetype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents colRoomId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
