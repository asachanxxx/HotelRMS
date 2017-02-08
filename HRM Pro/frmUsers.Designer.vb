<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.tabUsersDetails = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcUser = New DevExpress.XtraGrid.GridControl()
        Me.gvUser = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtCreatedBy = New DevExpress.XtraEditors.TextEdit()
        Me.txtFullName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.dtDate = New DevExpress.XtraEditors.DateEdit()
        Me.chkStatus = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUpw = New DevExpress.XtraEditors.TextEdit()
        Me.txtUName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDriverName = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tabUsersDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUsersDetails.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtCreatedBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFullName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUpw.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Appearance.Options.UseFont = True
        Me.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnDelete.Location = New System.Drawing.Point(440, 94)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "In Active"
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Location = New System.Drawing.Point(440, 65)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(90, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(440, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        '
        'tabUsersDetails
        '
        Me.tabUsersDetails.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabUsersDetails.AppearancePage.Header.Options.UseFont = True
        Me.tabUsersDetails.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabUsersDetails.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabUsersDetails.Location = New System.Drawing.Point(4, 12)
        Me.tabUsersDetails.Name = "tabUsersDetails"
        Me.tabUsersDetails.SelectedTabPage = Me.XtraTabPage1
        Me.tabUsersDetails.Size = New System.Drawing.Size(430, 282)
        Me.tabUsersDetails.TabIndex = 2
        Me.tabUsersDetails.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcUser)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(428, 257)
        Me.XtraTabPage1.Text = "User  Details"
        '
        'gcUser
        '
        Me.gcUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gcUser.Location = New System.Drawing.Point(3, 3)
        Me.gcUser.MainView = Me.gvUser
        Me.gcUser.Name = "gcUser"
        Me.gcUser.Size = New System.Drawing.Size(418, 248)
        Me.gcUser.TabIndex = 1
        Me.gcUser.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUser})
        '
        'gvUser
        '
        Me.gvUser.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.gvUser.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvUser.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvUser.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvUser.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvUser.Appearance.Row.Options.UseFont = True
        Me.gvUser.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvUser.GridControl = Me.gcUser
        Me.gvUser.Name = "gvUser"
        Me.gvUser.OptionsBehavior.Editable = False
        Me.gvUser.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.txtCreatedBy)
        Me.XtraTabPage2.Controls.Add(Me.txtFullName)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage2.Controls.Add(Me.dtDate)
        Me.XtraTabPage2.Controls.Add(Me.chkStatus)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.lbl28)
        Me.XtraTabPage2.Controls.Add(Me.txtUpw)
        Me.XtraTabPage2.Controls.Add(Me.txtUName)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.txtDriverName)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(428, 257)
        Me.XtraTabPage2.Text = "Add New User    "
        '
        'txtCreatedBy
        '
        Me.txtCreatedBy.Enabled = False
        Me.txtCreatedBy.Location = New System.Drawing.Point(83, 117)
        Me.txtCreatedBy.Name = "txtCreatedBy"
        Me.txtCreatedBy.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreatedBy.Properties.Appearance.Options.UseFont = True
        Me.txtCreatedBy.Properties.ReadOnly = True
        Me.txtCreatedBy.Size = New System.Drawing.Size(304, 20)
        Me.txtCreatedBy.TabIndex = 3
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(83, 83)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Properties.Appearance.Options.UseFont = True
        Me.txtFullName.Size = New System.Drawing.Size(304, 20)
        Me.txtFullName.TabIndex = 2
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(9, 199)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl6.TabIndex = 88
        Me.LabelControl6.Text = "Status"
        '
        'dtDate
        '
        Me.dtDate.EditValue = Nothing
        Me.dtDate.Location = New System.Drawing.Point(83, 152)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDate.Size = New System.Drawing.Size(155, 20)
        Me.dtDate.TabIndex = 4
        '
        'chkStatus
        '
        Me.chkStatus.Location = New System.Drawing.Point(81, 197)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Properties.Caption = ""
        Me.chkStatus.Properties.ReadOnly = True
        Me.chkStatus.Size = New System.Drawing.Size(75, 19)
        Me.chkStatus.TabIndex = 86
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(9, 159)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl5.TabIndex = 84
        Me.LabelControl5.Text = "Date"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(9, 124)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl4.TabIndex = 82
        Me.LabelControl4.Text = "Create By"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(9, 86)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 80
        Me.LabelControl3.Text = "Full Name"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl2.Location = New System.Drawing.Point(327, 14)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl2.TabIndex = 79
        Me.LabelControl2.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(327, 48)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 78
        Me.lbl28.Text = "*"
        '
        'txtUpw
        '
        Me.txtUpw.Location = New System.Drawing.Point(83, 48)
        Me.txtUpw.Name = "txtUpw"
        Me.txtUpw.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpw.Properties.Appearance.Options.UseFont = True
        Me.txtUpw.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUpw.Properties.UseSystemPasswordChar = True
        Me.txtUpw.Size = New System.Drawing.Size(238, 20)
        Me.txtUpw.TabIndex = 1
        '
        'txtUName
        '
        Me.txtUName.Location = New System.Drawing.Point(83, 14)
        Me.txtUName.Name = "txtUName"
        Me.txtUName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUName.Properties.Appearance.Options.UseFont = True
        Me.txtUName.Size = New System.Drawing.Size(238, 20)
        Me.txtUName.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(9, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "User Name"
        '
        'txtDriverName
        '
        Me.txtDriverName.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDriverName.Location = New System.Drawing.Point(9, 51)
        Me.txtDriverName.Name = "txtDriverName"
        Me.txtDriverName.Size = New System.Drawing.Size(49, 13)
        Me.txtDriverName.TabIndex = 19
        Me.txtDriverName.Text = "Password"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(440, 256)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 15
        '
        'frmUsers
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(542, 301)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.tabUsersDetails)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Users"
        CType(Me.tabUsersDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUsersDetails.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtCreatedBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFullName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUpw.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabUsersDetails As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcUser As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvUser As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtUpw As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDriverName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkStatus As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dtDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFullName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCreatedBy As DevExpress.XtraEditors.TextEdit
End Class
