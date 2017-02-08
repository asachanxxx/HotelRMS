<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAllinclusive
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAllinclusive))
        Me.tabRoomrates = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcRoomRates = New DevExpress.XtraGrid.GridControl()
        Me.gviewRoomrate = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colguesttype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInclusiveId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtrate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbCustype = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbGuesttype = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.tabRoomrates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRoomrates.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcRoomRates, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gviewRoomrate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtrate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCustype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGuesttype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabRoomrates
        '
        Me.tabRoomrates.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabRoomrates.AppearancePage.Header.Options.UseFont = True
        Me.tabRoomrates.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabRoomrates.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabRoomrates.Location = New System.Drawing.Point(12, 12)
        Me.tabRoomrates.Name = "tabRoomrates"
        Me.tabRoomrates.SelectedTabPage = Me.XtraTabPage1
        Me.tabRoomrates.Size = New System.Drawing.Size(588, 244)
        Me.tabRoomrates.TabIndex = 2
        Me.tabRoomrates.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcRoomRates)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(586, 219)
        Me.XtraTabPage1.Text = "All Inclusive Rate Details"
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
        Me.gviewRoomrate.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colguesttype, Me.colCategory, Me.colRate, Me.colInclusiveId})
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
        'colCategory
        '
        Me.colCategory.Caption = "Category"
        Me.colCategory.FieldName = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 1
        '
        'colRate
        '
        Me.colRate.Caption = "Rates"
        Me.colRate.FieldName = "Rates"
        Me.colRate.Name = "colRate"
        Me.colRate.Visible = True
        Me.colRate.VisibleIndex = 2
        '
        'colInclusiveId
        '
        Me.colInclusiveId.Caption = "InclusiveId"
        Me.colInclusiveId.FieldName = "InclusiveId"
        Me.colInclusiveId.Name = "colInclusiveId"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.txtrate)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Controls.Add(Me.cmbCustype)
        Me.XtraTabPage2.Controls.Add(Me.cmbGuesttype)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(586, 219)
        Me.XtraTabPage2.Text = "Add New All Inclusive  Rates      "
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl12.Location = New System.Drawing.Point(207, 91)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl12.TabIndex = 93
        Me.LabelControl12.Text = "*"
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
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(20, 29)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 34
        Me.LabelControl2.Text = "Guest Type"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(20, 60)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Type"
        '
        'txtrate
        '
        Me.txtrate.Location = New System.Drawing.Point(106, 87)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Properties.Appearance.Options.UseFont = True
        Me.txtrate.Size = New System.Drawing.Size(100, 20)
        Me.txtrate.TabIndex = 6
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(22, 93)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl8.TabIndex = 22
        Me.LabelControl8.Text = "Rates"
        '
        'cmbCustype
        '
        Me.cmbCustype.Location = New System.Drawing.Point(106, 55)
        Me.cmbCustype.Name = "cmbCustype"
        Me.cmbCustype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCustype.Properties.Items.AddRange(New Object() {"Adults", "Children", "Infants"})
        Me.cmbCustype.Size = New System.Drawing.Size(95, 20)
        Me.cmbCustype.TabIndex = 1
        '
        'cmbGuesttype
        '
        Me.cmbGuesttype.Location = New System.Drawing.Point(106, 26)
        Me.cmbGuesttype.Name = "cmbGuesttype"
        Me.cmbGuesttype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbGuesttype.Properties.Items.AddRange(New Object() {"FIT", "COMPLEMENTARY", "TOP NON CONTRACTS"})
        Me.cmbGuesttype.Size = New System.Drawing.Size(147, 20)
        Me.cmbGuesttype.TabIndex = 0
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(603, 218)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 17
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Location = New System.Drawing.Point(605, 65)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(92, 23)
        Me.btnEdit.TabIndex = 19
        Me.btnEdit.Text = "Edit"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(606, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 23)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Add"
        '
        'frmAllinclusive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(703, 263)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.tabRoomrates)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmAllinclusive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All Inclusive"
        CType(Me.tabRoomrates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRoomrates.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcRoomRates, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gviewRoomrate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtrate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCustype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGuesttype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabRoomrates As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcRoomRates As DevExpress.XtraGrid.GridControl
    Friend WithEvents gviewRoomrate As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colguesttype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtrate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbCustype As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbGuesttype As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colInclusiveId As DevExpress.XtraGrid.Columns.GridColumn
End Class
