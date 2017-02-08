<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGINReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGINReport))
        Me.gbItem = New System.Windows.Forms.GroupBox()
        Me.cmbDepartment_Item = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.gbDate = New System.Windows.Forms.GroupBox()
        Me.dtDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.dtDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.gridGIN = New DevExpress.XtraGrid.GridControl()
        Me.gvItemReq = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemReqCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLevel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbAll = New System.Windows.Forms.RadioButton()
        Me.rbSingleItem = New System.Windows.Forms.RadioButton()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.gbItem.SuspendLayout()
        CType(Me.cmbDepartment_Item.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDate.SuspendLayout()
        CType(Me.dtDateTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridGIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItemReq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbItem
        '
        Me.gbItem.BackColor = System.Drawing.Color.Transparent
        Me.gbItem.Controls.Add(Me.cmbDepartment_Item)
        Me.gbItem.Controls.Add(Me.LabelControl4)
        Me.gbItem.Location = New System.Drawing.Point(-5, 12)
        Me.gbItem.Name = "gbItem"
        Me.gbItem.Size = New System.Drawing.Size(302, 51)
        Me.gbItem.TabIndex = 51
        Me.gbItem.TabStop = False
        '
        'cmbDepartment_Item
        '
        Me.cmbDepartment_Item.Location = New System.Drawing.Point(52, 20)
        Me.cmbDepartment_Item.Name = "cmbDepartment_Item"
        Me.cmbDepartment_Item.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepartment_Item.Properties.Appearance.Options.UseFont = True
        Me.cmbDepartment_Item.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDepartment_Item.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentID", "Department ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Department", "Department")})
        Me.cmbDepartment_Item.Properties.NullText = ""
        Me.cmbDepartment_Item.Size = New System.Drawing.Size(216, 20)
        Me.cmbDepartment_Item.TabIndex = 55
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(13, 23)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl4.TabIndex = 53
        Me.LabelControl4.Text = "Outlet"
        '
        'gbDate
        '
        Me.gbDate.BackColor = System.Drawing.Color.Transparent
        Me.gbDate.Controls.Add(Me.dtDateTo)
        Me.gbDate.Controls.Add(Me.dtDateFrom)
        Me.gbDate.Controls.Add(Me.LabelControl2)
        Me.gbDate.Controls.Add(Me.LabelControl1)
        Me.gbDate.Location = New System.Drawing.Point(286, 12)
        Me.gbDate.Name = "gbDate"
        Me.gbDate.Size = New System.Drawing.Size(419, 54)
        Me.gbDate.TabIndex = 52
        Me.gbDate.TabStop = False
        '
        'dtDateTo
        '
        Me.dtDateTo.EditValue = Nothing
        Me.dtDateTo.Location = New System.Drawing.Point(238, 20)
        Me.dtDateTo.Name = "dtDateTo"
        Me.dtDateTo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateTo.Properties.Appearance.Options.UseFont = True
        Me.dtDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDateTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDateTo.Size = New System.Drawing.Size(124, 20)
        Me.dtDateTo.TabIndex = 45
        '
        'dtDateFrom
        '
        Me.dtDateFrom.EditValue = Nothing
        Me.dtDateFrom.Location = New System.Drawing.Point(52, 20)
        Me.dtDateFrom.Name = "dtDateFrom"
        Me.dtDateFrom.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateFrom.Properties.Appearance.Options.UseFont = True
        Me.dtDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDateFrom.Size = New System.Drawing.Size(124, 20)
        Me.dtDateFrom.TabIndex = 43
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 23)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl2.TabIndex = 46
        Me.LabelControl2.Text = "From"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(198, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl1.TabIndex = 47
        Me.LabelControl1.Text = "To"
        '
        'gridGIN
        '
        Me.gridGIN.Location = New System.Drawing.Point(12, 111)
        Me.gridGIN.MainView = Me.gvItemReq
        Me.gridGIN.Name = "gridGIN"
        Me.gridGIN.Size = New System.Drawing.Size(781, 387)
        Me.gridGIN.TabIndex = 53
        Me.gridGIN.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItemReq})
        '
        'gvItemReq
        '
        Me.gvItemReq.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.gvItemReq.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvItemReq.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvItemReq.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvItemReq.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvItemReq.Appearance.Row.Options.UseFont = True
        Me.gvItemReq.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemReqCode, Me.colDate, Me.colLevel, Me.colBalance, Me.GridColumn7})
        Me.gvItemReq.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvItemReq.GridControl = Me.gridGIN
        Me.gvItemReq.Name = "gvItemReq"
        Me.gvItemReq.OptionsBehavior.Editable = False
        Me.gvItemReq.OptionsView.ShowGroupPanel = False
        '
        'colItemReqCode
        '
        Me.colItemReqCode.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colItemReqCode.AppearanceCell.Options.UseFont = True
        Me.colItemReqCode.AppearanceCell.Options.UseTextOptions = True
        Me.colItemReqCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemReqCode.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colItemReqCode.AppearanceHeader.Options.UseFont = True
        Me.colItemReqCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemReqCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemReqCode.Caption = "GIN Code"
        Me.colItemReqCode.FieldName = "GINCode"
        Me.colItemReqCode.Name = "colItemReqCode"
        Me.colItemReqCode.Visible = True
        Me.colItemReqCode.VisibleIndex = 0
        Me.colItemReqCode.Width = 120
        '
        'colDate
        '
        Me.colDate.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDate.AppearanceCell.Options.UseFont = True
        Me.colDate.AppearanceCell.Options.UseTextOptions = True
        Me.colDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDate.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDate.AppearanceHeader.Options.UseFont = True
        Me.colDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDate.Caption = "Date"
        Me.colDate.FieldName = "GINDate"
        Me.colDate.Name = "colDate"
        Me.colDate.Visible = True
        Me.colDate.VisibleIndex = 1
        Me.colDate.Width = 100
        '
        'colLevel
        '
        Me.colLevel.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colLevel.AppearanceCell.Options.UseFont = True
        Me.colLevel.AppearanceCell.Options.UseTextOptions = True
        Me.colLevel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLevel.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colLevel.AppearanceHeader.Options.UseFont = True
        Me.colLevel.AppearanceHeader.Options.UseTextOptions = True
        Me.colLevel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colLevel.Caption = "Created By"
        Me.colLevel.FieldName = "CreatedBy"
        Me.colLevel.Name = "colLevel"
        Me.colLevel.Visible = True
        Me.colLevel.VisibleIndex = 2
        Me.colLevel.Width = 275
        '
        'colBalance
        '
        Me.colBalance.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colBalance.AppearanceCell.Options.UseFont = True
        Me.colBalance.AppearanceCell.Options.UseTextOptions = True
        Me.colBalance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBalance.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colBalance.AppearanceHeader.Options.UseFont = True
        Me.colBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBalance.Caption = "Transfer To"
        Me.colBalance.FieldName = "ToDept"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.Visible = True
        Me.colBalance.VisibleIndex = 3
        Me.colBalance.Width = 167
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn7.AppearanceCell.Options.UseFont = True
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Department"
        Me.GridColumn7.FieldName = "Department"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Width = 106
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbAll)
        Me.GroupBox1.Controls.Add(Me.rbSingleItem)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 36)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Checked = True
        Me.rbAll.Location = New System.Drawing.Point(162, 13)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(38, 17)
        Me.rbAll.TabIndex = 1
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "All"
        Me.rbAll.UseVisualStyleBackColor = True
        '
        'rbSingleItem
        '
        Me.rbSingleItem.AutoSize = True
        Me.rbSingleItem.Location = New System.Drawing.Point(13, 13)
        Me.rbSingleItem.Name = "rbSingleItem"
        Me.rbSingleItem.Size = New System.Drawing.Size(98, 17)
        Me.rbSingleItem.TabIndex = 0
        Me.rbSingleItem.Text = "Individual GIN"
        Me.rbSingleItem.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnPrint.Location = New System.Drawing.Point(724, 25)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(109, 23)
        Me.btnPrint.TabIndex = 54
        Me.btnPrint.Text = "Print"
        '
        'frmGINReport
        '
        Me.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(839, 505)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gridGIN)
        Me.Controls.Add(Me.gbDate)
        Me.Controls.Add(Me.gbItem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmGINReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Good Issued Reports"
        Me.gbItem.ResumeLayout(False)
        Me.gbItem.PerformLayout()
        CType(Me.cmbDepartment_Item.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDate.ResumeLayout(False)
        Me.gbDate.PerformLayout()
        CType(Me.dtDateTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridGIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItemReq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbItem As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDepartment_Item As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gbDate As System.Windows.Forms.GroupBox
    Friend WithEvents dtDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridGIN As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvItemReq As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemReqCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLevel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rbAll As System.Windows.Forms.RadioButton
    Friend WithEvents rbSingleItem As System.Windows.Forms.RadioButton
End Class
