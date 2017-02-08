<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcountryage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcountryage))
        Me.CachedReceiptDirect1 = New HRM_Pro.CachedReceiptDirect()
        Me.calFrom = New DevExpress.XtraEditors.DateEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.CachedReceiptDirect2 = New HRM_Pro.CachedReceiptDirect()
        Me.chkcountry = New System.Windows.Forms.CheckBox()
        Me.chkage = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.calFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.calFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'calFrom
        '
        Me.calFrom.CausesValidation = False
        Me.calFrom.EditValue = Nothing
        Me.calFrom.Location = New System.Drawing.Point(12, 41)
        Me.calFrom.Name = "calFrom"
        Me.calFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.calFrom.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.calFrom.Size = New System.Drawing.Size(129, 20)
        Me.calFrom.TabIndex = 36
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(202, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 37
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(11, 18)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl3.TabIndex = 42
        Me.LabelControl3.Text = "Select Report Date"
        '
        'btnPrint
        '
        Me.btnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnPrint.Location = New System.Drawing.Point(225, 110)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 43
        Me.btnPrint.Text = "Print"
        '
        'chkcountry
        '
        Me.chkcountry.AutoSize = True
        Me.chkcountry.Checked = True
        Me.chkcountry.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkcountry.Location = New System.Drawing.Point(97, 20)
        Me.chkcountry.Name = "chkcountry"
        Me.chkcountry.Size = New System.Drawing.Size(77, 17)
        Me.chkcountry.TabIndex = 44
        Me.chkcountry.Text = "By Country"
        Me.chkcountry.UseVisualStyleBackColor = True
        '
        'chkage
        '
        Me.chkage.AutoSize = True
        Me.chkage.Location = New System.Drawing.Point(97, 43)
        Me.chkage.Name = "chkage"
        Me.chkage.Size = New System.Drawing.Size(60, 17)
        Me.chkage.TabIndex = 45
        Me.chkage.Text = "By Age"
        Me.chkage.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.HRM_Pro.My.Resources.Resources.bg23
        Me.GroupBox1.Controls.Add(Me.chkage)
        Me.GroupBox1.Controls.Add(Me.chkcountry)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 66)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter By"
        '
        'frmcountryage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg23
        Me.ClientSize = New System.Drawing.Size(324, 146)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.calFrom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmcountryage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Country & Age Report"
        CType(Me.calFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.calFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CachedReceiptDirect1 As HRM_Pro.CachedReceiptDirect
    Friend WithEvents calFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CachedReceiptDirect2 As HRM_Pro.CachedReceiptDirect
    Friend WithEvents chkcountry As System.Windows.Forms.CheckBox
    Friend WithEvents chkage As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
