<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferRate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferRate))
        Me.tabTransrate = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcTransfer = New DevExpress.XtraGrid.GridControl()
        Me.gviewTransrate = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRestype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCusId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGuesttype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShift = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbShift = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.Cmbguestype = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbResType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtrate = New DevExpress.XtraEditors.TextEdit()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tabTransrate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTransrate.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gviewTransrate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.CmbShift.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cmbguestype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbResType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabTransrate
        '
        Me.tabTransrate.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabTransrate.AppearancePage.Header.Options.UseFont = True
        Me.tabTransrate.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabTransrate.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabTransrate.Location = New System.Drawing.Point(6, 11)
        Me.tabTransrate.Name = "tabTransrate"
        Me.tabTransrate.SelectedTabPage = Me.XtraTabPage1
        Me.tabTransrate.Size = New System.Drawing.Size(589, 277)
        Me.tabTransrate.TabIndex = 2
        Me.tabTransrate.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcTransfer)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(587, 252)
        Me.XtraTabPage1.Text = "Transfer Rates"
        '
        'gcTransfer
        '
        Me.gcTransfer.Location = New System.Drawing.Point(8, 8)
        Me.gcTransfer.MainView = Me.gviewTransrate
        Me.gcTransfer.Name = "gcTransfer"
        Me.gcTransfer.Size = New System.Drawing.Size(576, 241)
        Me.gcTransfer.TabIndex = 0
        Me.gcTransfer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gviewTransrate})
        '
        'gviewTransrate
        '
        Me.gviewTransrate.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gviewTransrate.Appearance.HeaderPanel.Options.UseFont = True
        Me.gviewTransrate.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gviewTransrate.Appearance.Row.Options.UseFont = True
        Me.gviewTransrate.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRestype, Me.colCusId, Me.colGuesttype, Me.colShift, Me.colRate})
        Me.gviewTransrate.GridControl = Me.gcTransfer
        Me.gviewTransrate.Name = "gviewTransrate"
        Me.gviewTransrate.OptionsView.ShowGroupPanel = False
        '
        'colRestype
        '
        Me.colRestype.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colRestype.AppearanceCell.Options.UseFont = True
        Me.colRestype.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colRestype.AppearanceHeader.Options.UseFont = True
        Me.colRestype.AppearanceHeader.Options.UseTextOptions = True
        Me.colRestype.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRestype.Caption = "Type"
        Me.colRestype.FieldName = "Custype"
        Me.colRestype.Name = "colRestype"
        Me.colRestype.Visible = True
        Me.colRestype.VisibleIndex = 0
        '
        'colCusId
        '
        Me.colCusId.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCusId.AppearanceCell.Options.UseFont = True
        Me.colCusId.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCusId.AppearanceHeader.Options.UseFont = True
        Me.colCusId.AppearanceHeader.Options.UseTextOptions = True
        Me.colCusId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCusId.Caption = "Guest"
        Me.colCusId.FieldName = "CusId"
        Me.colCusId.Name = "colCusId"
        Me.colCusId.Visible = True
        Me.colCusId.VisibleIndex = 1
        '
        'colGuesttype
        '
        Me.colGuesttype.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGuesttype.AppearanceCell.Options.UseFont = True
        Me.colGuesttype.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGuesttype.AppearanceHeader.Options.UseFont = True
        Me.colGuesttype.AppearanceHeader.Options.UseTextOptions = True
        Me.colGuesttype.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGuesttype.Caption = "Guest Type"
        Me.colGuesttype.FieldName = "Guesttype"
        Me.colGuesttype.Name = "colGuesttype"
        Me.colGuesttype.Visible = True
        Me.colGuesttype.VisibleIndex = 2
        '
        'colShift
        '
        Me.colShift.Caption = "Shift"
        Me.colShift.FieldName = "Shift"
        Me.colShift.Name = "colShift"
        Me.colShift.Visible = True
        Me.colShift.VisibleIndex = 3
        '
        'colRate
        '
        Me.colRate.Caption = "Rate"
        Me.colRate.FieldName = "Rate"
        Me.colRate.Name = "colRate"
        Me.colRate.Visible = True
        Me.colRate.VisibleIndex = 4
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupBox5)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(587, 252)
        Me.XtraTabPage2.Text = "Add New Rate      "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LabelControl3)
        Me.GroupBox5.Controls.Add(Me.CmbShift)
        Me.GroupBox5.Controls.Add(Me.LabelControl17)
        Me.GroupBox5.Controls.Add(Me.Cmbguestype)
        Me.GroupBox5.Controls.Add(Me.LabelControl1)
        Me.GroupBox5.Controls.Add(Me.cmbResType)
        Me.GroupBox5.Controls.Add(Me.LabelControl2)
        Me.GroupBox5.Controls.Add(Me.LabelControl8)
        Me.GroupBox5.Controls.Add(Me.txtrate)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(574, 237)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Location = New System.Drawing.Point(199, 111)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl3.TabIndex = 93
        Me.LabelControl3.Text = "*"
        '
        'CmbShift
        '
        Me.CmbShift.Location = New System.Drawing.Point(98, 77)
        Me.CmbShift.Name = "CmbShift"
        Me.CmbShift.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CmbShift.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbShift.Properties.Items.AddRange(New Object() {"DAY", "NIGHT"})
        Me.CmbShift.Size = New System.Drawing.Size(95, 22)
        Me.CmbShift.TabIndex = 92
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Location = New System.Drawing.Point(9, 81)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl17.TabIndex = 91
        Me.LabelControl17.Text = "Shift"
        '
        'Cmbguestype
        '
        Me.Cmbguestype.Location = New System.Drawing.Point(98, 48)
        Me.Cmbguestype.Name = "Cmbguestype"
        Me.Cmbguestype.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.Cmbguestype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Cmbguestype.Properties.Items.AddRange(New Object() {"Adults", "Children", "Infants", " "})
        Me.Cmbguestype.Size = New System.Drawing.Size(95, 22)
        Me.Cmbguestype.TabIndex = 90
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(8, 52)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl1.TabIndex = 89
        Me.LabelControl1.Text = "Guest Type"
        '
        'cmbResType
        '
        Me.cmbResType.Location = New System.Drawing.Point(98, 20)
        Me.cmbResType.Name = "cmbResType"
        Me.cmbResType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmbResType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbResType.Properties.Items.AddRange(New Object() {"FIT", "COM", "TOP"})
        Me.cmbResType.Size = New System.Drawing.Size(95, 22)
        Me.cmbResType.TabIndex = 35
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(6, 21)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl2.TabIndex = 34
        Me.LabelControl2.Text = "Reservation Type"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(8, 111)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl8.TabIndex = 22
        Me.LabelControl8.Text = "Rates"
        '
        'txtrate
        '
        Me.txtrate.Location = New System.Drawing.Point(97, 107)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Properties.Appearance.Options.UseFont = True
        Me.txtrate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtrate.Size = New System.Drawing.Size(96, 22)
        Me.txtrate.TabIndex = 21
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Location = New System.Drawing.Point(604, 64)
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
        Me.btnAdd.Location = New System.Drawing.Point(605, 35)
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
        Me.PictureEdit1.Location = New System.Drawing.Point(605, 248)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 20
        '
        'frmTransferRate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg23
        Me.ClientSize = New System.Drawing.Size(709, 291)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tabTransrate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmTransferRate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer Rates"
        CType(Me.tabTransrate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTransrate.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gviewTransrate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.CmbShift.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cmbguestype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbResType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabTransrate As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcTransfer As DevExpress.XtraGrid.GridControl
    Friend WithEvents gviewTransrate As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRestype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCusId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGuesttype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShift As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbResType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtrate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Cmbguestype As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbShift As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
