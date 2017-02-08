<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaunchsectionfoodrates
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLaunchsectionfoodrates))
        Me.tabLaunchSectionFoodRates = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcLSectionFoodRates = New DevExpress.XtraGrid.GridControl()
        Me.gvSectionFoodRates = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.tmETime = New DevExpress.XtraEditors.TimeEdit()
        Me.CmbMealType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.tmSTime = New DevExpress.XtraEditors.TimeEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMealNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRate = New DevExpress.XtraEditors.TextEdit()
        Me.btnInactive = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tabLaunchSectionFoodRates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLaunchSectionFoodRates.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcLSectionFoodRates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvSectionFoodRates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.tmETime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbMealType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tmSTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMealNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabLaunchSectionFoodRates
        '
        Me.tabLaunchSectionFoodRates.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabLaunchSectionFoodRates.AppearancePage.Header.Options.UseFont = True
        Me.tabLaunchSectionFoodRates.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabLaunchSectionFoodRates.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabLaunchSectionFoodRates.Location = New System.Drawing.Point(7, 4)
        Me.tabLaunchSectionFoodRates.Name = "tabLaunchSectionFoodRates"
        Me.tabLaunchSectionFoodRates.SelectedTabPage = Me.XtraTabPage1
        Me.tabLaunchSectionFoodRates.Size = New System.Drawing.Size(494, 182)
        Me.tabLaunchSectionFoodRates.TabIndex = 0
        Me.tabLaunchSectionFoodRates.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcLSectionFoodRates)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(492, 157)
        Me.XtraTabPage1.Text = "Launch Section Food Rates"
        '
        'gcLSectionFoodRates
        '
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.RelationName = "Level2"
        Me.gcLSectionFoodRates.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.gcLSectionFoodRates.Location = New System.Drawing.Point(3, 3)
        Me.gcLSectionFoodRates.MainView = Me.gvSectionFoodRates
        Me.gcLSectionFoodRates.Name = "gcLSectionFoodRates"
        Me.gcLSectionFoodRates.Size = New System.Drawing.Size(485, 148)
        Me.gcLSectionFoodRates.TabIndex = 0
        Me.gcLSectionFoodRates.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvSectionFoodRates})
        '
        'gvSectionFoodRates
        '
        Me.gvSectionFoodRates.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvSectionFoodRates.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvSectionFoodRates.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvSectionFoodRates.Appearance.Row.Options.UseFont = True
        Me.gvSectionFoodRates.GridControl = Me.gcLSectionFoodRates
        Me.gvSectionFoodRates.Name = "gvSectionFoodRates"
        Me.gvSectionFoodRates.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage2.Controls.Add(Me.lbl28)
        Me.XtraTabPage2.Controls.Add(Me.tmETime)
        Me.XtraTabPage2.Controls.Add(Me.CmbMealType)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Controls.Add(Me.tmSTime)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.txtMealNo)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.txtRate)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(492, 157)
        Me.XtraTabPage2.Text = "  New Food Rates  "
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl5.Location = New System.Drawing.Point(338, 109)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl5.TabIndex = 80
        Me.LabelControl5.Text = "*"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl4.Location = New System.Drawing.Point(338, 41)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl4.TabIndex = 79
        Me.LabelControl4.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(337, 15)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 78
        Me.lbl28.Text = "*"
        '
        'tmETime
        '
        Me.tmETime.EditValue = New Date(2012, 8, 27, 0, 0, 0, 0)
        Me.tmETime.Location = New System.Drawing.Point(337, 80)
        Me.tmETime.Name = "tmETime"
        Me.tmETime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.tmETime.Size = New System.Drawing.Size(141, 20)
        Me.tmETime.TabIndex = 44
        '
        'CmbMealType
        '
        Me.CmbMealType.Location = New System.Drawing.Point(102, 37)
        Me.CmbMealType.Name = "CmbMealType"
        Me.CmbMealType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbMealType.Properties.Items.AddRange(New Object() {"FullBoard", "HalfBoad"})
        Me.CmbMealType.Size = New System.Drawing.Size(230, 20)
        Me.CmbMealType.TabIndex = 39
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(5, 63)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Meal Time"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(275, 83)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 43
        Me.LabelControl3.Text = "End Time"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(8, 107)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "Rate"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(6, 40)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Meal Type"
        '
        'tmSTime
        '
        Me.tmSTime.EditValue = New Date(2012, 8, 27, 0, 0, 0, 0)
        Me.tmSTime.Location = New System.Drawing.Point(102, 80)
        Me.tmSTime.Name = "tmSTime"
        Me.tmSTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.tmSTime.Size = New System.Drawing.Size(142, 20)
        Me.tmSTime.TabIndex = 42
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(7, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Meal No"
        '
        'txtMealNo
        '
        Me.txtMealNo.Location = New System.Drawing.Point(102, 11)
        Me.txtMealNo.Name = "txtMealNo"
        Me.txtMealNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMealNo.Properties.Appearance.Options.UseFont = True
        Me.txtMealNo.Size = New System.Drawing.Size(230, 20)
        Me.txtMealNo.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(30, 83)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl2.TabIndex = 41
        Me.LabelControl2.Text = "Start Time"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(102, 106)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Properties.Appearance.Options.UseFont = True
        Me.txtRate.Size = New System.Drawing.Size(230, 20)
        Me.txtRate.TabIndex = 40
        '
        'btnInactive
        '
        Me.btnInactive.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInactive.Appearance.Options.UseFont = True
        Me.btnInactive.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnInactive.Location = New System.Drawing.Point(522, 82)
        Me.btnInactive.Name = "btnInactive"
        Me.btnInactive.Size = New System.Drawing.Size(60, 23)
        Me.btnInactive.TabIndex = 2
        Me.btnInactive.Text = "Inactive"
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Location = New System.Drawing.Point(522, 55)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(60, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(522, 28)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(61, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(506, 156)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 33)
        Me.PictureEdit1.TabIndex = 16
        '
        'frmLaunchsectionfoodrates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(606, 189)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btnInactive)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tabLaunchSectionFoodRates)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmLaunchsectionfoodrates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Launch Section Food Rates"
        CType(Me.tabLaunchSectionFoodRates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLaunchSectionFoodRates.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcLSectionFoodRates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvSectionFoodRates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.tmETime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbMealType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tmSTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMealNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabLaunchSectionFoodRates As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcLSectionFoodRates As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvSectionFoodRates As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tmETime As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tmSTime As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CmbMealType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMealNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnInactive As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
End Class
