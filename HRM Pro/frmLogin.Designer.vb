<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUsername = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPass = New DevExpress.XtraEditors.TextEdit()
        Me.btLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.btExit = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.dtDate = New DevExpress.XtraEditors.DateEdit()
        Me.lblerror = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(645, 256)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(158, 20)
        Me.txtUsername.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl1.Location = New System.Drawing.Point(560, 259)
        Me.LabelControl1.LookAndFeel.SkinName = "Metropolis"
        Me.LabelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 15)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "User Name "
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl2.Location = New System.Drawing.Point(560, 297)
        Me.LabelControl2.LookAndFeel.SkinName = "Metropolis"
        Me.LabelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 15)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Password"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(645, 292)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(158, 20)
        Me.txtPass.TabIndex = 1
        '
        'btLogin
        '
        Me.btLogin.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLogin.Appearance.Options.UseFont = True
        Me.btLogin.Location = New System.Drawing.Point(726, 361)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(75, 23)
        Me.btLogin.TabIndex = 2
        Me.btLogin.Text = "Login "
        '
        'btExit
        '
        Me.btExit.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExit.Appearance.Options.UseFont = True
        Me.btExit.Location = New System.Drawing.Point(645, 361)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(75, 23)
        Me.btExit.TabIndex = 3
        Me.btExit.Text = "Exit"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(809, 258)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 78
        Me.lbl28.Text = "*"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Location = New System.Drawing.Point(809, 293)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl3.TabIndex = 79
        Me.LabelControl3.Text = "*"
        '
        'dtDate
        '
        Me.dtDate.EditValue = New Date(2012, 10, 4, 10, 43, 57, 500)
        Me.dtDate.Enabled = False
        Me.dtDate.Location = New System.Drawing.Point(773, 12)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDate.Size = New System.Drawing.Size(133, 20)
        Me.dtDate.TabIndex = 101
        Me.dtDate.Visible = False
        '
        'lblerror
        '
        Me.lblerror.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblerror.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblerror.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.lblerror.Location = New System.Drawing.Point(526, 465)
        Me.lblerror.LookAndFeel.SkinName = "Metropolis"
        Me.lblerror.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(0, 15)
        Me.lblerror.TabIndex = 102
        '
        'frmLogin
        '
        Me.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.LoginBG3
        Me.ClientSize = New System.Drawing.Size(977, 595)
        Me.Controls.Add(Me.lblerror)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.lbl28)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.btLogin)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblerror As DevExpress.XtraEditors.LabelControl
End Class
