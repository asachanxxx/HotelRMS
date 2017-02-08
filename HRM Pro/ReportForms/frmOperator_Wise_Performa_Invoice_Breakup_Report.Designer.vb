<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperator_Wise_Performa_Invoice_Breakup_Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOperator_Wise_Performa_Invoice_Breakup_Report))
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dtDate2 = New DevExpress.XtraEditors.DateEdit()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.dtDate = New DevExpress.XtraEditors.DateEdit()
        Me.cmbOperatorID = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOperatorID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(0, 15)
        Me.LabelControl3.TabIndex = 27
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(273, 5)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 26
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(10, 83)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl1.TabIndex = 25
        Me.LabelControl1.Text = "To"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(10, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl2.TabIndex = 24
        Me.LabelControl2.Text = "From"
        '
        'dtDate2
        '
        Me.dtDate2.EditValue = Nothing
        Me.dtDate2.Location = New System.Drawing.Point(78, 81)
        Me.dtDate2.Name = "dtDate2"
        Me.dtDate2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDate2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDate2.Size = New System.Drawing.Size(131, 20)
        Me.dtDate2.TabIndex = 23
        '
        'btnPrint
        '
        Me.btnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrint.Location = New System.Drawing.Point(229, 78)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 22
        Me.btnPrint.Text = "Print"
        '
        'dtDate
        '
        Me.dtDate.EditValue = Nothing
        Me.dtDate.Location = New System.Drawing.Point(78, 52)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDate.Size = New System.Drawing.Size(131, 20)
        Me.dtDate.TabIndex = 21
        '
        'cmbOperatorID
        '
        Me.cmbOperatorID.Location = New System.Drawing.Point(79, 24)
        Me.cmbOperatorID.Name = "cmbOperatorID"
        Me.cmbOperatorID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOperatorID.Size = New System.Drawing.Size(67, 20)
        Me.cmbOperatorID.TabIndex = 28
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(9, 27)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl4.TabIndex = 29
        Me.LabelControl4.Text = "Operator ID"
        '
        'frmOperator_Wise_Performa_Invoice_Breakup_Report
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(379, 126)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.cmbOperatorID)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.dtDate2)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.dtDate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmOperator_Wise_Performa_Invoice_Breakup_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operator Wise Performa Invoice Breakup Report"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOperatorID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtDate2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbOperatorID As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
