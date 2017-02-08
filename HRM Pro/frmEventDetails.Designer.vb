<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEventDetails))
        Me.tabEventDetails = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcEvent = New DevExpress.XtraGrid.GridControl()
        Me.gvEventDetails = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.MemoEventDes = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.dtEventDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtMaxNo = New DevExpress.XtraEditors.TextEdit()
        Me.txtMinNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEventName = New DevExpress.XtraEditors.TextEdit()
        Me.txtEventNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.btnInactive = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tabEventDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEventDetails.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcEvent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEventDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEventDes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEventDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEventDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaxNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEventName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEventNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabEventDetails
        '
        Me.tabEventDetails.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabEventDetails.AppearancePage.Header.Options.UseFont = True
        Me.tabEventDetails.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabEventDetails.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabEventDetails.Location = New System.Drawing.Point(3, 4)
        Me.tabEventDetails.Name = "tabEventDetails"
        Me.tabEventDetails.SelectedTabPage = Me.XtraTabPage1
        Me.tabEventDetails.Size = New System.Drawing.Size(444, 285)
        Me.tabEventDetails.TabIndex = 0
        Me.tabEventDetails.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcEvent)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(442, 260)
        Me.XtraTabPage1.Text = "Event Details"
        '
        'gcEvent
        '
        Me.gcEvent.Location = New System.Drawing.Point(4, 3)
        Me.gcEvent.MainView = Me.gvEventDetails
        Me.gcEvent.Name = "gcEvent"
        Me.gcEvent.Size = New System.Drawing.Size(435, 254)
        Me.gcEvent.TabIndex = 0
        Me.gcEvent.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEventDetails})
        '
        'gvEventDetails
        '
        Me.gvEventDetails.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvEventDetails.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvEventDetails.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvEventDetails.Appearance.Row.Options.UseFont = True
        Me.gvEventDetails.GridControl = Me.gcEvent
        Me.gvEventDetails.Name = "gvEventDetails"
        Me.gvEventDetails.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.lbl28)
        Me.XtraTabPage2.Controls.Add(Me.cmbStatus)
        Me.XtraTabPage2.Controls.Add(Me.MemoEventDes)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage2.Controls.Add(Me.dtEventDate)
        Me.XtraTabPage2.Controls.Add(Me.txtMaxNo)
        Me.XtraTabPage2.Controls.Add(Me.txtMinNo)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.txtRate)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage2.Controls.Add(Me.txtEventName)
        Me.XtraTabPage2.Controls.Add(Me.txtEventNo)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(442, 260)
        Me.XtraTabPage2.Text = " Add New Event   "
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl12.Location = New System.Drawing.Point(259, 211)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl12.TabIndex = 82
        Me.LabelControl12.Text = "*"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl11.Location = New System.Drawing.Point(259, 186)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl11.TabIndex = 81
        Me.LabelControl11.Text = "*"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl7.Location = New System.Drawing.Point(259, 238)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl7.TabIndex = 80
        Me.LabelControl7.Text = "*"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Location = New System.Drawing.Point(259, 134)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl3.TabIndex = 79
        Me.LabelControl3.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(259, 11)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 78
        Me.lbl28.Text = "*"
        '
        'cmbStatus
        '
        Me.cmbStatus.Location = New System.Drawing.Point(110, 236)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStatus.Properties.Items.AddRange(New Object() {"Open Event", "Close Event"})
        Me.cmbStatus.Size = New System.Drawing.Size(143, 20)
        Me.cmbStatus.TabIndex = 7
        '
        'MemoEventDes
        '
        Me.MemoEventDes.Location = New System.Drawing.Point(111, 60)
        Me.MemoEventDes.Name = "MemoEventDes"
        Me.MemoEventDes.Size = New System.Drawing.Size(324, 64)
        Me.MemoEventDes.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(7, 213)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Min No"
        '
        'dtEventDate
        '
        Me.dtEventDate.EditValue = Nothing
        Me.dtEventDate.Location = New System.Drawing.Point(111, 130)
        Me.dtEventDate.Name = "dtEventDate"
        Me.dtEventDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEventDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtEventDate.Size = New System.Drawing.Size(142, 20)
        Me.dtEventDate.TabIndex = 3
        '
        'txtMaxNo
        '
        Me.txtMaxNo.Location = New System.Drawing.Point(111, 182)
        Me.txtMaxNo.Name = "txtMaxNo"
        Me.txtMaxNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxNo.Properties.Appearance.Options.UseFont = True
        Me.txtMaxNo.Size = New System.Drawing.Size(142, 20)
        Me.txtMaxNo.TabIndex = 5
        '
        'txtMinNo
        '
        Me.txtMinNo.Location = New System.Drawing.Point(111, 208)
        Me.txtMinNo.Name = "txtMinNo"
        Me.txtMinNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinNo.Properties.Appearance.Options.UseFont = True
        Me.txtMinNo.Size = New System.Drawing.Size(142, 20)
        Me.txtMinNo.TabIndex = 6
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(7, 133)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl8.TabIndex = 22
        Me.LabelControl8.Text = "Event Date"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(7, 185)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "Max No"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(7, 239)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Status"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(111, 156)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Properties.Appearance.Options.UseFont = True
        Me.txtRate.Size = New System.Drawing.Size(142, 20)
        Me.txtRate.TabIndex = 4
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(7, 37)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Event Name"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(7, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Event No"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(7, 159)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "Rate"
        '
        'txtEventName
        '
        Me.txtEventName.Location = New System.Drawing.Point(111, 34)
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventName.Properties.Appearance.Options.UseFont = True
        Me.txtEventName.Size = New System.Drawing.Size(324, 20)
        Me.txtEventName.TabIndex = 1
        '
        'txtEventNo
        '
        Me.txtEventNo.Location = New System.Drawing.Point(111, 8)
        Me.txtEventNo.Name = "txtEventNo"
        Me.txtEventNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventNo.Properties.Appearance.Options.UseFont = True
        Me.txtEventNo.Size = New System.Drawing.Size(142, 20)
        Me.txtEventNo.TabIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(7, 80)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Event Description"
        '
        'btnInactive
        '
        Me.btnInactive.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInactive.Appearance.Options.UseFont = True
        Me.btnInactive.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnInactive.Location = New System.Drawing.Point(456, 87)
        Me.btnInactive.Name = "btnInactive"
        Me.btnInactive.Size = New System.Drawing.Size(100, 23)
        Me.btnInactive.TabIndex = 2
        Me.btnInactive.Text = "Inactive"
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Location = New System.Drawing.Point(456, 58)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(456, 29)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(454, 253)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 16
        '
        'frmEventDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(563, 291)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.tabEventDetails)
        Me.Controls.Add(Me.btnInactive)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmEventDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Event Details Master"
        CType(Me.tabEventDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEventDetails.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcEvent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEventDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEventDes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEventDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEventDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaxNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEventName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEventNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabEventDetails As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcEvent As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvEventDetails As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MemoEventDes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEventName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaxNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEventNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtEventDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnInactive As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
End Class
