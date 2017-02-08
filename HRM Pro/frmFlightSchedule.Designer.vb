<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlightSchedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFlightSchedule))
        Me.cmbCountry = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.tmScheduleTime = New DevExpress.XtraEditors.TimeEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbDay = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFlightNo = New DevExpress.XtraEditors.TextEdit()
        Me.cmbType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnInactive = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.tabFlightSchedule = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.btGridview = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbGridDay = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.gcFlightSchedule = New DevExpress.XtraGrid.GridControl()
        Me.gvFlightSchedule = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmbGridType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.cmbCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tmScheduleTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFlightNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabFlightSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFlightSchedule.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.cmbGridDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcFlightSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvFlightSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGridType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCountry
        '
        Me.cmbCountry.Location = New System.Drawing.Point(117, 74)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmbCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCountry.Properties.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua & Deps", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Rep", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Congo {Democratic Rep}", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland {Republic}", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea North", "Korea South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar, {Burma}", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russian Federation", "Rwanda", "St Kitts & Nevis", "St Lucia", "Saint Vincent & the Grenadines", "Samoa", "San Marino", "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe", "Other"})
        Me.cmbCountry.Size = New System.Drawing.Size(166, 22)
        Me.cmbCountry.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(11, 79)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl2.TabIndex = 39
        Me.LabelControl2.Text = "Country"
        '
        'tmScheduleTime
        '
        Me.tmScheduleTime.EditValue = New Date(2012, 8, 29, 0, 0, 0, 0)
        Me.tmScheduleTime.Location = New System.Drawing.Point(117, 103)
        Me.tmScheduleTime.Name = "tmScheduleTime"
        Me.tmScheduleTime.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.tmScheduleTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.tmScheduleTime.Properties.DisplayFormat.FormatString = "hh:mm:ss tt"
        Me.tmScheduleTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tmScheduleTime.Size = New System.Drawing.Size(106, 22)
        Me.tmScheduleTime.TabIndex = 3
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(12, 104)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl8.TabIndex = 37
        Me.LabelControl8.Text = "Schedule Time"
        '
        'cmbDay
        '
        Me.cmbDay.Location = New System.Drawing.Point(117, 16)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmbDay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDay.Properties.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.cmbDay.Size = New System.Drawing.Size(165, 22)
        Me.cmbDay.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(15, 20)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl3.TabIndex = 35
        Me.LabelControl3.Text = "Day"
        '
        'txtFlightNo
        '
        Me.txtFlightNo.Location = New System.Drawing.Point(118, 45)
        Me.txtFlightNo.Name = "txtFlightNo"
        Me.txtFlightNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlightNo.Properties.Appearance.Options.UseFont = True
        Me.txtFlightNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtFlightNo.Size = New System.Drawing.Size(96, 22)
        Me.txtFlightNo.TabIndex = 1
        '
        'cmbType
        '
        Me.cmbType.Location = New System.Drawing.Point(117, 132)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmbType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbType.Properties.Items.AddRange(New Object() {"Arrival", "Departure"})
        Me.cmbType.Size = New System.Drawing.Size(126, 22)
        Me.cmbType.TabIndex = 4
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(13, 134)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Type"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(14, 48)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Flight No"
        '
        'btnInactive
        '
        Me.btnInactive.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInactive.Appearance.Options.UseFont = True
        Me.btnInactive.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnInactive.Location = New System.Drawing.Point(412, 90)
        Me.btnInactive.Name = "btnInactive"
        Me.btnInactive.Size = New System.Drawing.Size(83, 23)
        Me.btnInactive.TabIndex = 2
        Me.btnInactive.Text = "Inactive"
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Location = New System.Drawing.Point(411, 61)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(84, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(411, 33)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        '
        'tabFlightSchedule
        '
        Me.tabFlightSchedule.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabFlightSchedule.AppearancePage.Header.Options.UseFont = True
        Me.tabFlightSchedule.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabFlightSchedule.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabFlightSchedule.Location = New System.Drawing.Point(5, 8)
        Me.tabFlightSchedule.Name = "tabFlightSchedule"
        Me.tabFlightSchedule.SelectedTabPage = Me.XtraTabPage1
        Me.tabFlightSchedule.Size = New System.Drawing.Size(392, 198)
        Me.tabFlightSchedule.TabIndex = 1
        Me.tabFlightSchedule.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.btGridview)
        Me.XtraTabPage1.Controls.Add(Me.cmbGridDay)
        Me.XtraTabPage1.Controls.Add(Me.gcFlightSchedule)
        Me.XtraTabPage1.Controls.Add(Me.cmbGridType)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(390, 173)
        Me.XtraTabPage1.Text = "Flight Details"
        '
        'btGridview
        '
        Me.btGridview.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGridview.Appearance.Options.UseFont = True
        Me.btGridview.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btGridview.Location = New System.Drawing.Point(302, 18)
        Me.btGridview.Name = "btGridview"
        Me.btGridview.Size = New System.Drawing.Size(77, 23)
        Me.btGridview.TabIndex = 41
        Me.btGridview.Text = "View"
        '
        'cmbGridDay
        '
        Me.cmbGridDay.Location = New System.Drawing.Point(34, 18)
        Me.cmbGridDay.Name = "cmbGridDay"
        Me.cmbGridDay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmbGridDay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbGridDay.Properties.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.cmbGridDay.Size = New System.Drawing.Size(103, 22)
        Me.cmbGridDay.TabIndex = 38
        '
        'gcFlightSchedule
        '
        Me.gcFlightSchedule.Location = New System.Drawing.Point(3, 57)
        Me.gcFlightSchedule.MainView = Me.gvFlightSchedule
        Me.gcFlightSchedule.Name = "gcFlightSchedule"
        Me.gcFlightSchedule.Size = New System.Drawing.Size(384, 113)
        Me.gcFlightSchedule.TabIndex = 0
        Me.gcFlightSchedule.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvFlightSchedule, Me.GridView1})
        '
        'gvFlightSchedule
        '
        Me.gvFlightSchedule.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvFlightSchedule.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvFlightSchedule.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvFlightSchedule.Appearance.Row.Options.UseFont = True
        Me.gvFlightSchedule.GridControl = Me.gcFlightSchedule
        Me.gvFlightSchedule.Name = "gvFlightSchedule"
        Me.gvFlightSchedule.OptionsView.ShowGroupPanel = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gcFlightSchedule
        Me.GridView1.Name = "GridView1"
        '
        'cmbGridType
        '
        Me.cmbGridType.Location = New System.Drawing.Point(180, 18)
        Me.cmbGridType.Name = "cmbGridType"
        Me.cmbGridType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmbGridType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbGridType.Properties.Items.AddRange(New Object() {"Arrival", "Departure"})
        Me.cmbGridType.Size = New System.Drawing.Size(109, 22)
        Me.cmbGridType.TabIndex = 40
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(9, 22)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl4.TabIndex = 37
        Me.LabelControl4.Text = "Day"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(152, 22)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl5.TabIndex = 39
        Me.LabelControl5.Text = "Type"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage2.Controls.Add(Me.lbl28)
        Me.XtraTabPage2.Controls.Add(Me.cmbCountry)
        Me.XtraTabPage2.Controls.Add(Me.cmbType)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.txtFlightNo)
        Me.XtraTabPage2.Controls.Add(Me.tmScheduleTime)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.cmbDay)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(390, 173)
        Me.XtraTabPage2.Text = " Add New Flight Schedule   "
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl11.Location = New System.Drawing.Point(249, 134)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl11.TabIndex = 82
        Me.LabelControl11.Text = "*"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Location = New System.Drawing.Point(229, 105)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl9.TabIndex = 81
        Me.LabelControl9.Text = "*"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl7.Location = New System.Drawing.Point(288, 76)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl7.TabIndex = 80
        Me.LabelControl7.Text = "*"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl6.Location = New System.Drawing.Point(220, 49)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl6.TabIndex = 79
        Me.LabelControl6.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(288, 18)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 78
        Me.lbl28.Text = "*"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(400, 174)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 15
        '
        'frmFlightSchedule
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(503, 209)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.tabFlightSchedule)
        Me.Controls.Add(Me.btnInactive)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmFlightSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flight Schedule Master"
        CType(Me.cmbCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tmScheduleTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFlightNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabFlightSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFlightSchedule.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.cmbGridDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcFlightSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvFlightSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGridType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtFlightNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDay As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tmScheduleTime As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents cmbCountry As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnInactive As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabFlightSchedule As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btGridview As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbGridDay As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents gcFlightSchedule As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvFlightSchedule As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmbGridType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
End Class
