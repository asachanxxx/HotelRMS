<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmonthlysalesrpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmonthlysalesrpt))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dtResDate2 = New DevExpress.XtraEditors.DateEdit()
        Me.dtResDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbbno = New System.Windows.Forms.ComboBox()
        Me.cmbresno = New System.Windows.Forms.ComboBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnexl = New System.Windows.Forms.Button()
        Me.txttest = New System.Windows.Forms.Button()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.dtResDate2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtResDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtResDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtResDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(55, 89)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(14, 13)
        Me.LabelControl2.TabIndex = 59
        Me.LabelControl2.Text = "To"
        '
        'dtResDate2
        '
        Me.dtResDate2.EditValue = Nothing
        Me.dtResDate2.Location = New System.Drawing.Point(89, 82)
        Me.dtResDate2.Name = "dtResDate2"
        Me.dtResDate2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtResDate2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtResDate2.Size = New System.Drawing.Size(110, 20)
        Me.dtResDate2.TabIndex = 58
        '
        'dtResDate
        '
        Me.dtResDate.EditValue = Nothing
        Me.dtResDate.Location = New System.Drawing.Point(89, 56)
        Me.dtResDate.Name = "dtResDate"
        Me.dtResDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtResDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtResDate.Size = New System.Drawing.Size(110, 20)
        Me.dtResDate.TabIndex = 57
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(40, 59)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl1.TabIndex = 56
        Me.LabelControl1.Text = "From"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(31, 117)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl3.TabIndex = 61
        Me.LabelControl3.Text = "Res No"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(19, 148)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl4.TabIndex = 63
        Me.LabelControl4.Text = "Room No"
        '
        'cmbbno
        '
        Me.cmbbno.FormattingEnabled = True
        Me.cmbbno.Location = New System.Drawing.Point(89, 114)
        Me.cmbbno.Name = "cmbbno"
        Me.cmbbno.Size = New System.Drawing.Size(214, 21)
        Me.cmbbno.TabIndex = 64
        '
        'cmbresno
        '
        Me.cmbresno.FormattingEnabled = True
        Me.cmbresno.Location = New System.Drawing.Point(89, 148)
        Me.cmbresno.Name = "cmbresno"
        Me.cmbresno.Size = New System.Drawing.Size(214, 21)
        Me.cmbresno.TabIndex = 65
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Location = New System.Drawing.Point(325, 183)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(91, 27)
        Me.btnPrint.TabIndex = 66
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        Me.btnPrint.Visible = False
        '
        'btnexl
        '
        Me.btnexl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexl.Location = New System.Drawing.Point(325, 144)
        Me.btnexl.Name = "btnexl"
        Me.btnexl.Size = New System.Drawing.Size(91, 27)
        Me.btnexl.TabIndex = 67
        Me.btnexl.Text = "To Excel"
        Me.btnexl.UseVisualStyleBackColor = True
        '
        'txttest
        '
        Me.txttest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txttest.Location = New System.Drawing.Point(212, 183)
        Me.txttest.Name = "txttest"
        Me.txttest.Size = New System.Drawing.Size(91, 27)
        Me.txttest.TabIndex = 68
        Me.txttest.Text = "Print"
        Me.txttest.UseVisualStyleBackColor = True
        Me.txttest.Visible = False
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(325, 34)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 69
        '
        'frmmonthlysalesrpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(444, 222)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.txttest)
        Me.Controls.Add(Me.btnexl)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.cmbresno)
        Me.Controls.Add(Me.cmbbno)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.dtResDate2)
        Me.Controls.Add(Me.dtResDate)
        Me.Controls.Add(Me.LabelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmmonthlysalesrpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monthly Sales Report"
        CType(Me.dtResDate2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtResDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtResDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtResDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtResDate2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtResDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbbno As System.Windows.Forms.ComboBox
    Friend WithEvents cmbresno As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnexl As System.Windows.Forms.Button
    Friend WithEvents txttest As System.Windows.Forms.Button
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
