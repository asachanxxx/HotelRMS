<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuestregister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuestregister))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabGuestDetails = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gcGuestDetails = New DevExpress.XtraGrid.GridControl()
        Me.gvGuestDetails = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOccupation = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.dtBday = New DevExpress.XtraEditors.DateEdit()
        Me.txtHNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPassportNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtGName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAddress = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNationality = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCRes = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtGID = New DevExpress.XtraEditors.TextEdit()
        Me.btnInactive = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tabGuestDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGuestDetails.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.gcGuestDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvGuestDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.txtOccupation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBday.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassportNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNationality.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCRes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tabGuestDetails)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(612, 375)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'tabGuestDetails
        '
        Me.tabGuestDetails.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabGuestDetails.AppearancePage.Header.Options.UseFont = True
        Me.tabGuestDetails.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabGuestDetails.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabGuestDetails.Location = New System.Drawing.Point(6, 10)
        Me.tabGuestDetails.Name = "tabGuestDetails"
        Me.tabGuestDetails.SelectedTabPage = Me.XtraTabPage1
        Me.tabGuestDetails.Size = New System.Drawing.Size(589, 354)
        Me.tabGuestDetails.TabIndex = 0
        Me.tabGuestDetails.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupBox4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(587, 329)
        Me.XtraTabPage1.Text = "Guest List"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.gcGuestDetails)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(576, 313)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'gcGuestDetails
        '
        Me.gcGuestDetails.Location = New System.Drawing.Point(6, 12)
        Me.gcGuestDetails.MainView = Me.gvGuestDetails
        Me.gcGuestDetails.Name = "gcGuestDetails"
        Me.gcGuestDetails.Size = New System.Drawing.Size(564, 295)
        Me.gcGuestDetails.TabIndex = 0
        Me.gcGuestDetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvGuestDetails})
        '
        'gvGuestDetails
        '
        Me.gvGuestDetails.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvGuestDetails.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvGuestDetails.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvGuestDetails.Appearance.Row.Options.UseFont = True
        Me.gvGuestDetails.GridControl = Me.gcGuestDetails
        Me.gvGuestDetails.Name = "gvGuestDetails"
        Me.gvGuestDetails.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupBox5)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(587, 329)
        Me.XtraTabPage2.Text = "Add New Guest   "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LabelControl3)
        Me.GroupBox5.Controls.Add(Me.txtOccupation)
        Me.GroupBox5.Controls.Add(Me.LabelControl11)
        Me.GroupBox5.Controls.Add(Me.LabelControl9)
        Me.GroupBox5.Controls.Add(Me.dtBday)
        Me.GroupBox5.Controls.Add(Me.txtHNo)
        Me.GroupBox5.Controls.Add(Me.LabelControl8)
        Me.GroupBox5.Controls.Add(Me.txtPassportNo)
        Me.GroupBox5.Controls.Add(Me.LabelControl10)
        Me.GroupBox5.Controls.Add(Me.txtGName)
        Me.GroupBox5.Controls.Add(Me.LabelControl7)
        Me.GroupBox5.Controls.Add(Me.txtMNo)
        Me.GroupBox5.Controls.Add(Me.LabelControl6)
        Me.GroupBox5.Controls.Add(Me.txtAddress)
        Me.GroupBox5.Controls.Add(Me.LabelControl5)
        Me.GroupBox5.Controls.Add(Me.txtNationality)
        Me.GroupBox5.Controls.Add(Me.LabelControl4)
        Me.GroupBox5.Controls.Add(Me.txtCRes)
        Me.GroupBox5.Controls.Add(Me.LabelControl2)
        Me.GroupBox5.Controls.Add(Me.LabelControl1)
        Me.GroupBox5.Controls.Add(Me.txtGID)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(576, 323)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(6, 268)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl3.TabIndex = 29
        Me.LabelControl3.Text = "Occupation"
        '
        'txtOccupation
        '
        Me.txtOccupation.Location = New System.Drawing.Point(124, 265)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccupation.Properties.Appearance.Options.UseFont = True
        Me.txtOccupation.Size = New System.Drawing.Size(226, 20)
        Me.txtOccupation.TabIndex = 28
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(367, 225)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl11.TabIndex = 27
        Me.LabelControl11.Text = "Home"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(124, 225)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl9.TabIndex = 26
        Me.LabelControl9.Text = "Mobile"
        '
        'dtBday
        '
        Me.dtBday.EditValue = Nothing
        Me.dtBday.Location = New System.Drawing.Point(124, 191)
        Me.dtBday.Name = "dtBday"
        Me.dtBday.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBday.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtBday.Size = New System.Drawing.Size(142, 20)
        Me.dtBday.TabIndex = 25
        '
        'txtHNo
        '
        Me.txtHNo.Location = New System.Drawing.Point(403, 222)
        Me.txtHNo.Name = "txtHNo"
        Me.txtHNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHNo.Properties.Appearance.Options.UseFont = True
        Me.txtHNo.Size = New System.Drawing.Size(136, 20)
        Me.txtHNo.TabIndex = 23
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(6, 77)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl8.TabIndex = 22
        Me.LabelControl8.Text = "Passport No"
        '
        'txtPassportNo
        '
        Me.txtPassportNo.Location = New System.Drawing.Point(124, 74)
        Me.txtPassportNo.Name = "txtPassportNo"
        Me.txtPassportNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassportNo.Properties.Appearance.Options.UseFont = True
        Me.txtPassportNo.Size = New System.Drawing.Size(226, 20)
        Me.txtPassportNo.TabIndex = 21
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(6, 47)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Name"
        '
        'txtGName
        '
        Me.txtGName.Location = New System.Drawing.Point(124, 44)
        Me.txtGName.Name = "txtGName"
        Me.txtGName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGName.Properties.Appearance.Options.UseFont = True
        Me.txtGName.Size = New System.Drawing.Size(414, 20)
        Me.txtGName.TabIndex = 18
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(6, 225)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl7.TabIndex = 13
        Me.LabelControl7.Text = "Telephone"
        '
        'txtMNo
        '
        Me.txtMNo.Location = New System.Drawing.Point(187, 222)
        Me.txtMNo.Name = "txtMNo"
        Me.txtMNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMNo.Properties.Appearance.Options.UseFont = True
        Me.txtMNo.Size = New System.Drawing.Size(163, 20)
        Me.txtMNo.TabIndex = 12
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(6, 108)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(125, 105)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Properties.Appearance.Options.UseFont = True
        Me.txtAddress.Size = New System.Drawing.Size(414, 20)
        Me.txtAddress.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(6, 139)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "Nationality"
        '
        'txtNationality
        '
        Me.txtNationality.Location = New System.Drawing.Point(124, 136)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNationality.Properties.Appearance.Options.UseFont = True
        Me.txtNationality.Size = New System.Drawing.Size(226, 20)
        Me.txtNationality.TabIndex = 8
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(6, 165)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Country Of Residence"
        '
        'txtCRes
        '
        Me.txtCRes.Location = New System.Drawing.Point(124, 162)
        Me.txtCRes.Name = "txtCRes"
        Me.txtCRes.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCRes.Properties.Appearance.Options.UseFont = True
        Me.txtCRes.Size = New System.Drawing.Size(226, 20)
        Me.txtCRes.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(6, 191)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Date Of Birth"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(6, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Guest ID"
        '
        'txtGID
        '
        Me.txtGID.Location = New System.Drawing.Point(124, 18)
        Me.txtGID.Name = "txtGID"
        Me.txtGID.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGID.Properties.Appearance.Options.UseFont = True
        Me.txtGID.Size = New System.Drawing.Size(142, 20)
        Me.txtGID.TabIndex = 0
        '
        'btnInactive
        '
        Me.btnInactive.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInactive.Appearance.Options.UseFont = True
        Me.btnInactive.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnInactive.Location = New System.Drawing.Point(624, 74)
        Me.btnInactive.Name = "btnInactive"
        Me.btnInactive.Size = New System.Drawing.Size(92, 23)
        Me.btnInactive.TabIndex = 2
        Me.btnInactive.Text = "Inactive"
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Location = New System.Drawing.Point(624, 45)
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
        Me.btnAdd.Location = New System.Drawing.Point(625, 16)
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
        Me.PictureEdit1.Location = New System.Drawing.Point(618, 339)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 19
        '
        'frmGuestregister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(729, 384)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btnInactive)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmGuestregister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Register"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.tabGuestDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGuestDetails.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.gcGuestDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvGuestDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.txtOccupation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBday.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassportNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNationality.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCRes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tabGuestDetails As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents gcGuestDetails As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvGuestDetails As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPassportNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNationality As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCRes As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOccupation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtBday As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnInactive As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
