<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserGroups
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserGroups))
        Me.tabUserGroup = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcUserGroup = New DevExpress.XtraGrid.GridControl()
        Me.gvUserGroup = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.chkStatus = New DevExpress.XtraEditors.CheckEdit()
        Me.dtCreateDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCreateBy = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.MemoDes = New DevExpress.XtraEditors.MemoEdit()
        Me.txtUserGroupname = New DevExpress.XtraEditors.TextEdit()
        Me.txtDriverName = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tabUserGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUserGroup.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcUserGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUserGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCreateDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCreateDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreateBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoDes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserGroupname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabUserGroup
        '
        Me.tabUserGroup.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabUserGroup.AppearancePage.Header.Options.UseFont = True
        Me.tabUserGroup.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabUserGroup.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabUserGroup.Location = New System.Drawing.Point(6, 3)
        Me.tabUserGroup.Name = "tabUserGroup"
        Me.tabUserGroup.SelectedTabPage = Me.XtraTabPage1
        Me.tabUserGroup.Size = New System.Drawing.Size(459, 210)
        Me.tabUserGroup.TabIndex = 2
        Me.tabUserGroup.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcUserGroup)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(457, 185)
        Me.XtraTabPage1.Text = "User Group Details"
        '
        'gcUserGroup
        '
        Me.gcUserGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gcUserGroup.Location = New System.Drawing.Point(3, 3)
        Me.gcUserGroup.MainView = Me.gvUserGroup
        Me.gcUserGroup.Name = "gcUserGroup"
        Me.gcUserGroup.Size = New System.Drawing.Size(440, 176)
        Me.gcUserGroup.TabIndex = 1
        Me.gcUserGroup.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUserGroup})
        '
        'gvUserGroup
        '
        Me.gvUserGroup.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.gvUserGroup.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvUserGroup.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvUserGroup.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvUserGroup.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvUserGroup.Appearance.Row.Options.UseFont = True
        Me.gvUserGroup.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvUserGroup.GridControl = Me.gcUserGroup
        Me.gvUserGroup.Name = "gvUserGroup"
        Me.gvUserGroup.OptionsBehavior.Editable = False
        Me.gvUserGroup.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.chkStatus)
        Me.XtraTabPage2.Controls.Add(Me.dtCreateDate)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage2.Controls.Add(Me.txtCreateBy)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.lbl28)
        Me.XtraTabPage2.Controls.Add(Me.MemoDes)
        Me.XtraTabPage2.Controls.Add(Me.txtUserGroupname)
        Me.XtraTabPage2.Controls.Add(Me.txtDriverName)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(457, 185)
        Me.XtraTabPage2.Text = "Add New User Group    "
        '
        'chkStatus
        '
        Me.chkStatus.Location = New System.Drawing.Point(105, 140)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Properties.Caption = ""
        Me.chkStatus.Size = New System.Drawing.Size(75, 19)
        Me.chkStatus.TabIndex = 85
        '
        'dtCreateDate
        '
        Me.dtCreateDate.EditValue = Nothing
        Me.dtCreateDate.Location = New System.Drawing.Point(105, 107)
        Me.dtCreateDate.Name = "dtCreateDate"
        Me.dtCreateDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCreateDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtCreateDate.Size = New System.Drawing.Size(142, 20)
        Me.dtCreateDate.TabIndex = 84
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(7, 140)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl5.TabIndex = 83
        Me.LabelControl5.Text = "Status"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(7, 107)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl4.TabIndex = 82
        Me.LabelControl4.Text = "Created Date"
        '
        'txtCreateBy
        '
        Me.txtCreateBy.Location = New System.Drawing.Point(104, 72)
        Me.txtCreateBy.Name = "txtCreateBy"
        Me.txtCreateBy.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateBy.Properties.Appearance.Options.UseFont = True
        Me.txtCreateBy.Properties.ReadOnly = True
        Me.txtCreateBy.Size = New System.Drawing.Size(216, 20)
        Me.txtCreateBy.TabIndex = 81
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(7, 75)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl3.TabIndex = 80
        Me.LabelControl3.Text = "Create By"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl2.Location = New System.Drawing.Point(442, 36)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl2.TabIndex = 79
        Me.LabelControl2.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(253, 11)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 78
        Me.lbl28.Text = "*"
        '
        'MemoDes
        '
        Me.MemoDes.Location = New System.Drawing.Point(104, 43)
        Me.MemoDes.Name = "MemoDes"
        Me.MemoDes.Size = New System.Drawing.Size(332, 18)
        Me.MemoDes.TabIndex = 29
        '
        'txtUserGroupname
        '
        Me.txtUserGroupname.Location = New System.Drawing.Point(105, 10)
        Me.txtUserGroupname.Name = "txtUserGroupname"
        Me.txtUserGroupname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserGroupname.Properties.Appearance.Options.UseFont = True
        Me.txtUserGroupname.Size = New System.Drawing.Size(142, 20)
        Me.txtUserGroupname.TabIndex = 28
        '
        'txtDriverName
        '
        Me.txtDriverName.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDriverName.Location = New System.Drawing.Point(7, 43)
        Me.txtDriverName.Name = "txtDriverName"
        Me.txtDriverName.Size = New System.Drawing.Size(59, 13)
        Me.txtDriverName.TabIndex = 19
        Me.txtDriverName.Text = "Description"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(7, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Group Name"
        '
        'btnDelete
        '
        Me.btnDelete.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Appearance.Options.UseFont = True
        Me.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnDelete.Location = New System.Drawing.Point(476, 81)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "In Active"
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Location = New System.Drawing.Point(476, 54)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Update"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(476, 27)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(468, 176)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 15
        '
        'frmUserGroups
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(572, 218)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.tabUserGroup)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmUserGroups"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Groups"
        CType(Me.tabUserGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUserGroup.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcUserGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUserGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.chkStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCreateDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCreateDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreateBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoDes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserGroupname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabUserGroup As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcUserGroup As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvUserGroup As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtUserGroupname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDriverName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MemoDes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCreateBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkStatus As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dtCreateDate As DevExpress.XtraEditors.DateEdit
End Class
