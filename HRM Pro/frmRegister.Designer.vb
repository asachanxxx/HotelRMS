<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.txtkey = New DevExpress.XtraEditors.TextEdit()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.txtKeyUni = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtMain = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtkey.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKeyUni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(360, 148)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 15
        '
        'txtkey
        '
        Me.txtkey.Location = New System.Drawing.Point(31, 44)
        Me.txtkey.Name = "txtkey"
        Me.txtkey.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkey.Properties.Appearance.Options.UseFont = True
        Me.txtkey.Size = New System.Drawing.Size(298, 20)
        Me.txtkey.TabIndex = 16
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(109, 81)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 23)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Encrypt"
        '
        'txtKeyUni
        '
        Me.txtKeyUni.Location = New System.Drawing.Point(31, 125)
        Me.txtKeyUni.Name = "txtKeyUni"
        Me.txtKeyUni.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyUni.Properties.Appearance.Options.UseFont = True
        Me.txtKeyUni.Size = New System.Drawing.Size(298, 20)
        Me.txtKeyUni.TabIndex = 18
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton1.Location = New System.Drawing.Point(237, 81)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButton1.TabIndex = 19
        Me.SimpleButton1.Text = "Decrypt"
        '
        'txtMain
        '
        Me.txtMain.Location = New System.Drawing.Point(31, 12)
        Me.txtMain.Name = "txtMain"
        Me.txtMain.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMain.Properties.Appearance.Options.UseFont = True
        Me.txtMain.Size = New System.Drawing.Size(298, 20)
        Me.txtMain.TabIndex = 20
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(472, 202)
        Me.Controls.Add(Me.txtMain)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.txtKeyUni)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtkey)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmRegister"
        Me.Text = "Key Register"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtkey.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKeyUni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtkey As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtKeyUni As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMain As DevExpress.XtraEditors.TextEdit
End Class
