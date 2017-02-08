<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployee))
        Me.tabBoat = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcBoat = New DevExpress.XtraGrid.GridControl()
        Me.gvBoat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.empid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbCategory = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbdep = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmpName = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmpNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDriverName = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tabBoat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBoat.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcBoat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBoat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.empid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbdep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabBoat
        '
        Me.tabBoat.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.tabBoat.Appearance.Options.UseBackColor = True
        Me.tabBoat.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBoat.AppearancePage.Header.Options.UseFont = True
        Me.tabBoat.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBoat.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabBoat.BackgroundImage = Global.HRM_Pro.My.Resources.Resources.b2g
        Me.tabBoat.Location = New System.Drawing.Point(12, 12)
        Me.tabBoat.Name = "tabBoat"
        Me.tabBoat.SelectedTabPage = Me.XtraTabPage1
        Me.tabBoat.Size = New System.Drawing.Size(486, 293)
        Me.tabBoat.TabIndex = 11
        Me.tabBoat.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcBoat)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(484, 268)
        Me.XtraTabPage1.Text = "Employee"
        '
        'gcBoat
        '
        Me.gcBoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gcBoat.Location = New System.Drawing.Point(3, 3)
        Me.gcBoat.MainView = Me.gvBoat
        Me.gcBoat.Name = "gcBoat"
        Me.gcBoat.Size = New System.Drawing.Size(473, 257)
        Me.gcBoat.TabIndex = 1
        Me.gcBoat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBoat})
        '
        'gvBoat
        '
        Me.gvBoat.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvBoat.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvBoat.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvBoat.Appearance.Row.Options.UseFont = True
        Me.gvBoat.GridControl = Me.gcBoat
        Me.gvBoat.Name = "gvBoat"
        Me.gvBoat.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.empid)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage2.Controls.Add(Me.cmbCategory)
        Me.XtraTabPage2.Controls.Add(Me.cmbdep)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.lbl28)
        Me.XtraTabPage2.Controls.Add(Me.txtEmpName)
        Me.XtraTabPage2.Controls.Add(Me.txtEmpNo)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Controls.Add(Me.txtDriverName)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(484, 268)
        Me.XtraTabPage2.Text = "Add New Employee"
        '
        'empid
        '
        Me.empid.Location = New System.Drawing.Point(114, 187)
        Me.empid.Name = "empid"
        Me.empid.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empid.Properties.Appearance.Options.UseFont = True
        Me.empid.Size = New System.Drawing.Size(53, 20)
        Me.empid.TabIndex = 83
        Me.empid.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl4.Location = New System.Drawing.Point(339, 143)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl4.TabIndex = 82
        Me.LabelControl4.Text = "*"
        '
        'cmbCategory
        '
        Me.cmbCategory.Location = New System.Drawing.Point(114, 137)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmbCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCategory.Properties.Items.AddRange(New Object() {"EMP", "COM"})
        Me.cmbCategory.Properties.LookAndFeel.UseWindowsXPTheme = True
        Me.cmbCategory.Size = New System.Drawing.Size(219, 22)
        Me.cmbCategory.TabIndex = 81
        '
        'cmbdep
        '
        Me.cmbdep.Location = New System.Drawing.Point(114, 98)
        Me.cmbdep.Name = "cmbdep"
        Me.cmbdep.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmbdep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbdep.Properties.Items.AddRange(New Object() {"A/C", "ACCOUNTS", "DC", "DIVING CENTER", "DIVING SCHOOL", "ENGINEERING DEPARTMENT", "FOOD & BEVERAGE", "FOOD & BEVERAGES/ MAIN KITCHEN", "FRONT OFFICE", "GENERAL MAINTANACE & LABOUR SECTION", "HO", "HOUSEKEEPING", "HR", "LAUNCH SECTION", "Misraap", "spa", "WAITER", "Water sports"})
        Me.cmbdep.Properties.LookAndFeel.UseWindowsXPTheme = True
        Me.cmbdep.Size = New System.Drawing.Size(219, 22)
        Me.cmbdep.TabIndex = 80
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Location = New System.Drawing.Point(339, 102)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl3.TabIndex = 79
        Me.LabelControl3.Text = "*"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl2.Location = New System.Drawing.Point(466, 54)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl2.TabIndex = 78
        Me.LabelControl2.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(262, 20)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 77
        Me.lbl28.Text = "*"
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(114, 60)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpName.Properties.Appearance.Options.UseFont = True
        Me.txtEmpName.Size = New System.Drawing.Size(346, 20)
        Me.txtEmpName.TabIndex = 1
        '
        'txtEmpNo
        '
        Me.txtEmpNo.Location = New System.Drawing.Point(114, 19)
        Me.txtEmpNo.Name = "txtEmpNo"
        Me.txtEmpNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpNo.Properties.Appearance.Options.UseFont = True
        Me.txtEmpNo.Size = New System.Drawing.Size(142, 20)
        Me.txtEmpNo.TabIndex = 0
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(16, 102)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl8.TabIndex = 34
        Me.LabelControl8.Text = "Department"
        '
        'txtDriverName
        '
        Me.txtDriverName.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDriverName.Location = New System.Drawing.Point(16, 63)
        Me.txtDriverName.Name = "txtDriverName"
        Me.txtDriverName.Size = New System.Drawing.Size(57, 13)
        Me.txtDriverName.TabIndex = 33
        Me.txtDriverName.Text = "EMP  Name"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(14, 141)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 32
        Me.LabelControl6.Text = "Category"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(16, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 30
        Me.LabelControl1.Text = "EMP No"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(514, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 23)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Location = New System.Drawing.Point(514, 65)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(92, 23)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "Resign"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(506, 262)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 15
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(616, 314)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.tabBoat)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee "
        CType(Me.tabBoat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBoat.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcBoat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBoat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.empid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbdep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabBoat As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcBoat As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBoat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmpName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmpNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDriverName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbCategory As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbdep As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents empid As DevExpress.XtraEditors.TextEdit
End Class
