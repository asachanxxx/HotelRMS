<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAssignGroup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserAssignGroup))
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAssign = New DevExpress.XtraEditors.SimpleButton()
        Me.tabUserAssignGroup = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcUserAssignGroup = New DevExpress.XtraGrid.GridControl()
        Me.gvUserAssignGroup = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.cmbUser = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbGroup = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUserGroupname = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tabUserAssignGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUserAssignGroup.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcUserAssignGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUserAssignGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.cmbUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserGroupname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Appearance.Options.UseFont = True
        Me.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnDelete.Location = New System.Drawing.Point(515, 62)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        '
        'btnAssign
        '
        Me.btnAssign.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssign.Appearance.Options.UseFont = True
        Me.btnAssign.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAssign.Location = New System.Drawing.Point(516, 32)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(85, 23)
        Me.btnAssign.TabIndex = 0
        Me.btnAssign.Text = "Assign"
        '
        'tabUserAssignGroup
        '
        Me.tabUserAssignGroup.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabUserAssignGroup.AppearancePage.Header.Options.UseFont = True
        Me.tabUserAssignGroup.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabUserAssignGroup.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabUserAssignGroup.Location = New System.Drawing.Point(4, 6)
        Me.tabUserAssignGroup.Name = "tabUserAssignGroup"
        Me.tabUserAssignGroup.SelectedTabPage = Me.XtraTabPage1
        Me.tabUserAssignGroup.Size = New System.Drawing.Size(501, 229)
        Me.tabUserAssignGroup.TabIndex = 2
        Me.tabUserAssignGroup.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcUserAssignGroup)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(499, 204)
        Me.XtraTabPage1.Text = "User Assign Group Details"
        '
        'gcUserAssignGroup
        '
        Me.gcUserAssignGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gcUserAssignGroup.Location = New System.Drawing.Point(3, 5)
        Me.gcUserAssignGroup.MainView = Me.gvUserAssignGroup
        Me.gcUserAssignGroup.Name = "gcUserAssignGroup"
        Me.gcUserAssignGroup.Size = New System.Drawing.Size(484, 188)
        Me.gcUserAssignGroup.TabIndex = 1
        Me.gcUserAssignGroup.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUserAssignGroup})
        '
        'gvUserAssignGroup
        '
        Me.gvUserAssignGroup.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.gvUserAssignGroup.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvUserAssignGroup.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvUserAssignGroup.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvUserAssignGroup.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvUserAssignGroup.Appearance.Row.Options.UseFont = True
        Me.gvUserAssignGroup.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvUserAssignGroup.GridControl = Me.gcUserAssignGroup
        Me.gvUserAssignGroup.Name = "gvUserAssignGroup"
        Me.gvUserAssignGroup.OptionsBehavior.Editable = False
        Me.gvUserAssignGroup.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.cmbUser)
        Me.XtraTabPage2.Controls.Add(Me.cmbGroup)
        Me.XtraTabPage2.Controls.Add(Me.txtUserName)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.lbl28)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage2.Controls.Add(Me.txtUserGroupname)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(499, 204)
        Me.XtraTabPage2.Text = " User Assign Group    "
        '
        'cmbUser
        '
        Me.cmbUser.Location = New System.Drawing.Point(103, 10)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbUser.Properties.NullText = ""
        Me.cmbUser.Size = New System.Drawing.Size(164, 20)
        Me.cmbUser.TabIndex = 84
        '
        'cmbGroup
        '
        Me.cmbGroup.Location = New System.Drawing.Point(103, 67)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbGroup.Properties.NullText = ""
        Me.cmbGroup.Size = New System.Drawing.Size(164, 20)
        Me.cmbGroup.TabIndex = 83
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(103, 38)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Properties.Appearance.Options.UseFont = True
        Me.txtUserName.Size = New System.Drawing.Size(296, 20)
        Me.txtUserName.TabIndex = 82
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(6, 13)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl5.TabIndex = 80
        Me.LabelControl5.Text = "User Name"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl2.Location = New System.Drawing.Point(273, 68)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl2.TabIndex = 79
        Me.LabelControl2.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(273, 10)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 78
        Me.lbl28.Text = "*"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(6, 41)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl4.TabIndex = 35
        Me.LabelControl4.Text = "Full Name"
        '
        'txtUserGroupname
        '
        Me.txtUserGroupname.Location = New System.Drawing.Point(103, 98)
        Me.txtUserGroupname.Name = "txtUserGroupname"
        Me.txtUserGroupname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserGroupname.Properties.Appearance.Options.UseFont = True
        Me.txtUserGroupname.Size = New System.Drawing.Size(296, 20)
        Me.txtUserGroupname.TabIndex = 34
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(4, 71)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Group ID"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(3, 98)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 33
        Me.LabelControl3.Text = "Group Name"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(510, 197)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 15
        '
        'frmUserAssignGroup
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(613, 240)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.tabUserAssignGroup)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAssign)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmUserAssignGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Assign Group"
        CType(Me.tabUserAssignGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUserAssignGroup.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcUserAssignGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUserAssignGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.cmbUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserGroupname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAssign As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabUserAssignGroup As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcUserAssignGroup As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvUserAssignGroup As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUserGroupname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbGroup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbUser As DevExpress.XtraEditors.LookUpEdit
End Class
