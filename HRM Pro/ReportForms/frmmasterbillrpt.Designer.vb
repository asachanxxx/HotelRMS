<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmasterbillrpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmasterbillrpt))
        Me.btnfilter = New System.Windows.Forms.Button()
        Me.cmbbno = New System.Windows.Forms.ComboBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.cmbmbilno = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.calfrom = New DevExpress.XtraEditors.DateEdit()
        Me.calto = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.calfrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.calfrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.calto.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.calto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnfilter
        '
        Me.btnfilter.Location = New System.Drawing.Point(381, 130)
        Me.btnfilter.Name = "btnfilter"
        Me.btnfilter.Size = New System.Drawing.Size(91, 21)
        Me.btnfilter.TabIndex = 39
        Me.btnfilter.Text = "Filter Records"
        Me.btnfilter.UseVisualStyleBackColor = True
        '
        'cmbbno
        '
        Me.cmbbno.FormattingEnabled = True
        Me.cmbbno.Location = New System.Drawing.Point(161, 91)
        Me.cmbbno.Name = "cmbbno"
        Me.cmbbno.Size = New System.Drawing.Size(214, 21)
        Me.cmbbno.TabIndex = 40
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(381, 164)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(91, 21)
        Me.btnPrint.TabIndex = 38
        Me.btnPrint.Text = "Re-Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        Me.btnPrint.Visible = False
        '
        'cmbmbilno
        '
        Me.cmbmbilno.FormattingEnabled = True
        Me.cmbmbilno.Location = New System.Drawing.Point(161, 130)
        Me.cmbmbilno.Name = "cmbmbilno"
        Me.cmbmbilno.Size = New System.Drawing.Size(214, 21)
        Me.cmbmbilno.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Room No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Master Bill No"
        '
        'calfrom
        '
        Me.calfrom.CausesValidation = False
        Me.calfrom.EditValue = Nothing
        Me.calfrom.Location = New System.Drawing.Point(161, 29)
        Me.calfrom.Name = "calfrom"
        Me.calfrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.calfrom.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.calfrom.Size = New System.Drawing.Size(129, 20)
        Me.calfrom.TabIndex = 44
        '
        'calto
        '
        Me.calto.CausesValidation = False
        Me.calto.EditValue = Nothing
        Me.calto.Location = New System.Drawing.Point(161, 60)
        Me.calto.Name = "calto"
        Me.calto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.calto.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.calto.Size = New System.Drawing.Size(129, 20)
        Me.calto.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "From Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "To Date"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(374, 32)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 48
        '
        'frmmasterbillrpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(480, 197)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.calto)
        Me.Controls.Add(Me.calfrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbmbilno)
        Me.Controls.Add(Me.btnfilter)
        Me.Controls.Add(Me.cmbbno)
        Me.Controls.Add(Me.btnPrint)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmmasterbillrpt"
        Me.Text = "Master Bill Reprint"
        CType(Me.calfrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.calfrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.calto.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.calto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnfilter As System.Windows.Forms.Button
    Friend WithEvents dtResDate2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtResDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbobilno As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbbno As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbmbilno As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents calfrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents calto As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
