<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserGroupAssignProcess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserGroupAssignProcess))
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.tabUserGroupAssignProcess = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcUserGroupAssignProcess = New DevExpress.XtraGrid.GridControl()
        Me.gvUserGroupAssignProcess = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnAssign = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbProcess = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.gcUserGroupAssignProcessTemp = New DevExpress.XtraGrid.GridControl()
        Me.gvUserGroupAssignProcessTemp = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtGroupName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbGID = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbFunctionName = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tabUserGroupAssignProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUserGroupAssignProcess.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcUserGroupAssignProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUserGroupAssignProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.cmbProcess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcUserGroupAssignProcessTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUserGroupAssignProcessTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGroupName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFunctionName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Appearance.Options.UseFont = True
        Me.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnDelete.Location = New System.Drawing.Point(408, 58)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(81, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(408, 29)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(81, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        '
        'tabUserGroupAssignProcess
        '
        Me.tabUserGroupAssignProcess.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabUserGroupAssignProcess.AppearancePage.Header.Options.UseFont = True
        Me.tabUserGroupAssignProcess.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabUserGroupAssignProcess.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabUserGroupAssignProcess.Location = New System.Drawing.Point(4, 6)
        Me.tabUserGroupAssignProcess.Name = "tabUserGroupAssignProcess"
        Me.tabUserGroupAssignProcess.SelectedTabPage = Me.XtraTabPage1
        Me.tabUserGroupAssignProcess.Size = New System.Drawing.Size(398, 311)
        Me.tabUserGroupAssignProcess.TabIndex = 2
        Me.tabUserGroupAssignProcess.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcUserGroupAssignProcess)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(396, 286)
        Me.XtraTabPage1.Text = "User Group Assign Process Details"
        '
        'gcUserGroupAssignProcess
        '
        Me.gcUserGroupAssignProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gcUserGroupAssignProcess.Location = New System.Drawing.Point(8, 8)
        Me.gcUserGroupAssignProcess.MainView = Me.gvUserGroupAssignProcess
        Me.gcUserGroupAssignProcess.Name = "gcUserGroupAssignProcess"
        Me.gcUserGroupAssignProcess.Size = New System.Drawing.Size(381, 272)
        Me.gcUserGroupAssignProcess.TabIndex = 1
        Me.gcUserGroupAssignProcess.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUserGroupAssignProcess})
        '
        'gvUserGroupAssignProcess
        '
        Me.gvUserGroupAssignProcess.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvUserGroupAssignProcess.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvUserGroupAssignProcess.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvUserGroupAssignProcess.Appearance.Row.Options.UseFont = True
        Me.gvUserGroupAssignProcess.GridControl = Me.gcUserGroupAssignProcess
        Me.gvUserGroupAssignProcess.Name = "gvUserGroupAssignProcess"
        Me.gvUserGroupAssignProcess.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.btnAssign)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.lbl28)
        Me.XtraTabPage2.Controls.Add(Me.cmbProcess)
        Me.XtraTabPage2.Controls.Add(Me.gcUserGroupAssignProcessTemp)
        Me.XtraTabPage2.Controls.Add(Me.txtGroupName)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.cmbGID)
        Me.XtraTabPage2.Controls.Add(Me.cmbFunctionName)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(392, 283)
        Me.XtraTabPage2.Text = " User Group Assign  Process    "
        '
        'btnAssign
        '
        Me.btnAssign.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssign.Appearance.Options.UseFont = True
        Me.btnAssign.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAssign.Location = New System.Drawing.Point(271, 99)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(89, 23)
        Me.btnAssign.TabIndex = 81
        Me.btnAssign.Text = "Assign"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl6.Location = New System.Drawing.Point(257, 102)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl6.TabIndex = 80
        Me.LabelControl6.Text = "*"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl5.Location = New System.Drawing.Point(256, 74)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl5.TabIndex = 79
        Me.LabelControl5.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(256, 10)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 78
        Me.lbl28.Text = "*"
        '
        'cmbProcess
        '
        Me.cmbProcess.Location = New System.Drawing.Point(105, 102)
        Me.cmbProcess.Name = "cmbProcess"
        Me.cmbProcess.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProcess.Size = New System.Drawing.Size(146, 20)
        Me.cmbProcess.TabIndex = 38
        '
        'gcUserGroupAssignProcessTemp
        '
        Me.gcUserGroupAssignProcessTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gcUserGroupAssignProcessTemp.Location = New System.Drawing.Point(3, 128)
        Me.gcUserGroupAssignProcessTemp.MainView = Me.gvUserGroupAssignProcessTemp
        Me.gcUserGroupAssignProcessTemp.Name = "gcUserGroupAssignProcessTemp"
        Me.gcUserGroupAssignProcessTemp.Size = New System.Drawing.Size(386, 151)
        Me.gcUserGroupAssignProcessTemp.TabIndex = 37
        Me.gcUserGroupAssignProcessTemp.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUserGroupAssignProcessTemp})
        '
        'gvUserGroupAssignProcessTemp
        '
        Me.gvUserGroupAssignProcessTemp.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvUserGroupAssignProcessTemp.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvUserGroupAssignProcessTemp.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvUserGroupAssignProcessTemp.Appearance.Row.Options.UseFont = True
        Me.gvUserGroupAssignProcessTemp.GridControl = Me.gcUserGroupAssignProcessTemp
        Me.gvUserGroupAssignProcessTemp.Name = "gvUserGroupAssignProcessTemp"
        Me.gvUserGroupAssignProcessTemp.OptionsView.ShowGroupPanel = False
        '
        'txtGroupName
        '
        Me.txtGroupName.Location = New System.Drawing.Point(104, 41)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupName.Properties.Appearance.Options.UseFont = True
        Me.txtGroupName.Size = New System.Drawing.Size(264, 20)
        Me.txtGroupName.TabIndex = 36
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(7, 44)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl4.TabIndex = 35
        Me.LabelControl4.Text = "Group Name"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(8, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Group ID"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(6, 105)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl3.TabIndex = 33
        Me.LabelControl3.Text = "Process"
        '
        'cmbGID
        '
        Me.cmbGID.Location = New System.Drawing.Point(105, 9)
        Me.cmbGID.Name = "cmbGID"
        Me.cmbGID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbGID.Size = New System.Drawing.Size(145, 20)
        Me.cmbGID.TabIndex = 30
        '
        'cmbFunctionName
        '
        Me.cmbFunctionName.Location = New System.Drawing.Point(104, 71)
        Me.cmbFunctionName.Name = "cmbFunctionName"
        Me.cmbFunctionName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbFunctionName.Size = New System.Drawing.Size(146, 20)
        Me.cmbFunctionName.TabIndex = 32
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(6, 74)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl2.TabIndex = 31
        Me.LabelControl2.Text = "Function Name"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(408, 285)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(92, 32)
        Me.PictureEdit1.TabIndex = 15
        '
        'frmUserGroupAssignProcess
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(501, 322)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.tabUserGroupAssignProcess)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MinimizeBox = False
        Me.Name = "frmUserGroupAssignProcess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserGroupAssign to Process"
        CType(Me.tabUserGroupAssignProcess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUserGroupAssignProcess.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcUserGroupAssignProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUserGroupAssignProcess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.cmbProcess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcUserGroupAssignProcessTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUserGroupAssignProcessTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGroupName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFunctionName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabUserGroupAssignProcess As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcUserGroupAssignProcess As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvUserGroupAssignProcess As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbFunctionName As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbGID As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGroupName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbProcess As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents gcUserGroupAssignProcessTemp As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvUserGroupAssignProcessTemp As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAssign As DevExpress.XtraEditors.SimpleButton
End Class
