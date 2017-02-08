<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtopcon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtopcon))
        Me.CachedReceiptDirect1 = New HRM_Pro.CachedReceiptDirect()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.CachedReceiptDirect2 = New HRM_Pro.CachedReceiptDirect()
        Me.CachedReceiptDirect3 = New HRM_Pro.CachedReceiptDirect()
        Me.CachedReceiptDirect4 = New HRM_Pro.CachedReceiptDirect()
        Me.cmbtoplist = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.CachedReceiptDirect5 = New HRM_Pro.CachedReceiptDirect()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CachedReceiptDirect6 = New HRM_Pro.CachedReceiptDirect()
        Me.CachedReceiptDirect7 = New HRM_Pro.CachedReceiptDirect()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.cmbtoplist.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(289, 98)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(91, 27)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cmbtoplist
        '
        Me.cmbtoplist.Location = New System.Drawing.Point(63, 60)
        Me.cmbtoplist.Name = "cmbtoplist"
        Me.cmbtoplist.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbtoplist.Size = New System.Drawing.Size(317, 20)
        Me.cmbtoplist.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Tour Operator Name"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(289, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 38
        '
        'frmtopcon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(394, 135)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbtoplist)
        Me.Controls.Add(Me.btnPrint)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmtopcon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tour Operator Contract List"
        CType(Me.cmbtoplist.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CachedReceiptDirect1 As HRM_Pro.CachedReceiptDirect
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents CachedReceiptDirect2 As HRM_Pro.CachedReceiptDirect
    Friend WithEvents CachedReceiptDirect3 As HRM_Pro.CachedReceiptDirect
    Friend WithEvents cbotop As System.Windows.Forms.ComboBox
    Friend WithEvents CachedReceiptDirect4 As HRM_Pro.CachedReceiptDirect
    Friend WithEvents cmbtoplist As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CachedReceiptDirect5 As HRM_Pro.CachedReceiptDirect
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CachedReceiptDirect6 As HRM_Pro.CachedReceiptDirect
    Friend WithEvents CachedReceiptDirect7 As HRM_Pro.CachedReceiptDirect
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
