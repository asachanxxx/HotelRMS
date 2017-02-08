<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmoutbillreprint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmoutbillreprint))
        Me.cmbobilno = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.dtResDate2 = New DevExpress.XtraEditors.DateEdit()
        Me.dtResDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnfilter = New System.Windows.Forms.Button()
        Me.cmbbno = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.cmbobilno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtResDate2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtResDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtResDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtResDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbobilno
        '
        Me.cmbobilno.Location = New System.Drawing.Point(89, 74)
        Me.cmbobilno.Name = "cmbobilno"
        Me.cmbobilno.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmbobilno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbobilno.Size = New System.Drawing.Size(214, 22)
        Me.cmbobilno.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(22, 49)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl2.TabIndex = 28
        Me.LabelControl2.Text = "To"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(22, 19)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl3.TabIndex = 27
        Me.LabelControl3.Text = "From"
        '
        'dtResDate2
        '
        Me.dtResDate2.EditValue = Nothing
        Me.dtResDate2.Location = New System.Drawing.Point(89, 42)
        Me.dtResDate2.Name = "dtResDate2"
        Me.dtResDate2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtResDate2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtResDate2.Size = New System.Drawing.Size(110, 20)
        Me.dtResDate2.TabIndex = 26
        '
        'dtResDate
        '
        Me.dtResDate.EditValue = Nothing
        Me.dtResDate.Location = New System.Drawing.Point(89, 12)
        Me.dtResDate.Name = "dtResDate"
        Me.dtResDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtResDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtResDate.Size = New System.Drawing.Size(110, 20)
        Me.dtResDate.TabIndex = 25
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(22, 83)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl1.TabIndex = 30
        Me.LabelControl1.Text = "Room No"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(21, 14)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl4.TabIndex = 31
        Me.LabelControl4.Text = "Bill No"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(325, 10)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(91, 27)
        Me.btnPrint.TabIndex = 32
        Me.btnPrint.Text = "Re-Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnfilter
        '
        Me.btnfilter.Location = New System.Drawing.Point(326, 71)
        Me.btnfilter.Name = "btnfilter"
        Me.btnfilter.Size = New System.Drawing.Size(91, 27)
        Me.btnfilter.TabIndex = 33
        Me.btnfilter.Text = "Filter Records"
        Me.btnfilter.UseVisualStyleBackColor = True
        '
        'cmbbno
        '
        Me.cmbbno.FormattingEnabled = True
        Me.cmbbno.Location = New System.Drawing.Point(88, 14)
        Me.cmbbno.Name = "cmbbno"
        Me.cmbbno.Size = New System.Drawing.Size(214, 21)
        Me.cmbbno.TabIndex = 34
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureEdit1)
        Me.Panel1.Controls.Add(Me.btnfilter)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.LabelControl2)
        Me.Panel1.Controls.Add(Me.LabelControl3)
        Me.Panel1.Controls.Add(Me.dtResDate2)
        Me.Panel1.Controls.Add(Me.dtResDate)
        Me.Panel1.Controls.Add(Me.cmbobilno)
        Me.Panel1.Location = New System.Drawing.Point(18, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 116)
        Me.Panel1.TabIndex = 35
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cmbbno)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.LabelControl4)
        Me.Panel2.Location = New System.Drawing.Point(19, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(438, 49)
        Me.Panel2.TabIndex = 36
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(335, 3)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 44
        '
        'frmoutbillreprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(467, 202)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmoutbillreprint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Outlet Bill Re-Print"
        CType(Me.cmbobilno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtResDate2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtResDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtResDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtResDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbobilno As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtResDate2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtResDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnfilter As System.Windows.Forms.Button
    Friend WithEvents cmbbno As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
