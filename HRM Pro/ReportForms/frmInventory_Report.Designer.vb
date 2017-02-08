<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory_Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory_Report))
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dtDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.dtDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.cmbItem = New DevExpress.XtraEditors.LookUpEdit()
        Me.gbItem = New System.Windows.Forms.GroupBox()
        Me.cmbDepartment_Item = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.gbDate = New System.Windows.Forms.GroupBox()
        Me.gbDepartment_General = New System.Windows.Forms.GroupBox()
        Me.cmbDepartment_General = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItem.SuspendLayout()
        CType(Me.cmbDepartment_Item.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDate.SuspendLayout()
        Me.gbDepartment_General.SuspendLayout()
        CType(Me.cmbDepartment_General.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(496, 264)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 48
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
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 23)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl2.TabIndex = 46
        Me.LabelControl2.Text = "From"
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
        'btnPrint
        '
        Me.btnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnPrint.Location = New System.Drawing.Point(496, 38)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 44
        Me.btnPrint.Text = "Print"
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
        'cmbItem
        '
        Me.cmbItem.Location = New System.Drawing.Point(52, 62)
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItem.Properties.Appearance.Options.UseFont = True
        Me.cmbItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbItem.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Itemcode", "Item Code"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description")})
        Me.cmbItem.Properties.NullText = ""
        Me.cmbItem.Size = New System.Drawing.Size(304, 20)
        Me.cmbItem.TabIndex = 49
        '
        'gbItem
        '
        Me.gbItem.BackColor = System.Drawing.Color.Transparent
        Me.gbItem.Controls.Add(Me.cmbDepartment_Item)
        Me.gbItem.Controls.Add(Me.LabelControl4)
        Me.gbItem.Controls.Add(Me.TextEdit2)
        Me.gbItem.Controls.Add(Me.TextEdit1)
        Me.gbItem.Controls.Add(Me.LabelControl3)
        Me.gbItem.Controls.Add(Me.cmbItem)
        Me.gbItem.Location = New System.Drawing.Point(12, 151)
        Me.gbItem.Name = "gbItem"
        Me.gbItem.Size = New System.Drawing.Size(582, 118)
        Me.gbItem.TabIndex = 50
        Me.gbItem.TabStop = False
        Me.gbItem.Visible = False
        '
        'cmbDepartment_Item
        '
        Me.cmbDepartment_Item.Location = New System.Drawing.Point(52, 27)
        Me.cmbDepartment_Item.Name = "cmbDepartment_Item"
        Me.cmbDepartment_Item.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepartment_Item.Properties.Appearance.Options.UseFont = True
        Me.cmbDepartment_Item.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDepartment_Item.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentID", "Department ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Department", "Department")})
        Me.cmbDepartment_Item.Properties.NullText = ""
        Me.cmbDepartment_Item.Size = New System.Drawing.Size(304, 20)
        Me.cmbDepartment_Item.TabIndex = 55
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(12, 30)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl4.TabIndex = 53
        Me.LabelControl4.Text = "Outlet"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(52, 88)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Size = New System.Drawing.Size(167, 20)
        Me.TextEdit2.TabIndex = 52
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(227, 88)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Size = New System.Drawing.Size(349, 20)
        Me.TextEdit1.TabIndex = 51
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(11, 65)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl3.TabIndex = 50
        Me.LabelControl3.Text = "Item"
        '
        'gbDate
        '
        Me.gbDate.BackColor = System.Drawing.Color.Transparent
        Me.gbDate.Controls.Add(Me.dtDateTo)
        Me.gbDate.Controls.Add(Me.dtDateFrom)
        Me.gbDate.Controls.Add(Me.LabelControl2)
        Me.gbDate.Controls.Add(Me.LabelControl1)
        Me.gbDate.Location = New System.Drawing.Point(12, 38)
        Me.gbDate.Name = "gbDate"
        Me.gbDate.Size = New System.Drawing.Size(402, 54)
        Me.gbDate.TabIndex = 51
        Me.gbDate.TabStop = False
        Me.gbDate.Visible = False
        '
        'gbDepartment_General
        '
        Me.gbDepartment_General.BackColor = System.Drawing.Color.Transparent
        Me.gbDepartment_General.Controls.Add(Me.cmbDepartment_General)
        Me.gbDepartment_General.Controls.Add(Me.LabelControl5)
        Me.gbDepartment_General.Location = New System.Drawing.Point(12, 98)
        Me.gbDepartment_General.Name = "gbDepartment_General"
        Me.gbDepartment_General.Size = New System.Drawing.Size(402, 54)
        Me.gbDepartment_General.TabIndex = 52
        Me.gbDepartment_General.TabStop = False
        Me.gbDepartment_General.Visible = False
        '
        'cmbDepartment_General
        '
        Me.cmbDepartment_General.Location = New System.Drawing.Point(52, 17)
        Me.cmbDepartment_General.Name = "cmbDepartment_General"
        Me.cmbDepartment_General.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDepartment_General.Properties.Appearance.Options.UseFont = True
        Me.cmbDepartment_General.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDepartment_General.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentID", "Department ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Department", "Department")})
        Me.cmbDepartment_General.Properties.NullText = ""
        Me.cmbDepartment_General.Size = New System.Drawing.Size(321, 20)
        Me.cmbDepartment_General.TabIndex = 57
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(11, 24)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl5.TabIndex = 56
        Me.LabelControl5.Text = "Outlet"
        '
        'frmInventory_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(606, 305)
        Me.Controls.Add(Me.gbDepartment_General)
        Me.Controls.Add(Me.gbDate)
        Me.Controls.Add(Me.gbItem)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btnPrint)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmInventory_Report"
        Me.Text = "Report Formula Selection"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItem.ResumeLayout(False)
        Me.gbItem.PerformLayout()
        CType(Me.cmbDepartment_Item.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDate.ResumeLayout(False)
        Me.gbDate.PerformLayout()
        Me.gbDepartment_General.ResumeLayout(False)
        Me.gbDepartment_General.PerformLayout()
        CType(Me.cmbDepartment_General.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbItem As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gbItem As System.Windows.Forms.GroupBox
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gbDate As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDepartment_Item As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gbDepartment_General As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDepartment_General As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
