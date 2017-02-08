<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPasswordChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPasswordChange))
        Me.tabUsersDetails = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtNewpassRe = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNewpass = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txCurrpass = New DevExpress.XtraEditors.TextEdit()
        Me.txtUName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDriverName = New DevExpress.XtraEditors.LabelControl()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tabUsersDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUsersDetails.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtNewpassRe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNewpass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txCurrpass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabUsersDetails
        '
        Me.tabUsersDetails.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabUsersDetails.AppearancePage.Header.Options.UseFont = True
        Me.tabUsersDetails.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabUsersDetails.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabUsersDetails.Location = New System.Drawing.Point(7, 7)
        Me.tabUsersDetails.Name = "tabUsersDetails"
        Me.tabUsersDetails.SelectedTabPage = Me.XtraTabPage1
        Me.tabUsersDetails.Size = New System.Drawing.Size(391, 201)
        Me.tabUsersDetails.TabIndex = 3
        Me.tabUsersDetails.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.txtNewpassRe)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Controls.Add(Me.txtNewpass)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.txCurrpass)
        Me.XtraTabPage1.Controls.Add(Me.txtUName)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Controls.Add(Me.txtDriverName)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(389, 176)
        Me.XtraTabPage1.Text = "User  Details"
        '
        'txtNewpassRe
        '
        Me.txtNewpassRe.Enabled = False
        Me.txtNewpassRe.Location = New System.Drawing.Point(117, 135)
        Me.txtNewpassRe.Name = "txtNewpassRe"
        Me.txtNewpassRe.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewpassRe.Properties.Appearance.Options.UseFont = True
        Me.txtNewpassRe.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewpassRe.Properties.UseSystemPasswordChar = True
        Me.txtNewpassRe.Size = New System.Drawing.Size(238, 20)
        Me.txtNewpassRe.TabIndex = 26
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(20, 138)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl3.TabIndex = 27
        Me.LabelControl3.Text = "Re Type Password"
        '
        'txtNewpass
        '
        Me.txtNewpass.Enabled = False
        Me.txtNewpass.Location = New System.Drawing.Point(117, 97)
        Me.txtNewpass.Name = "txtNewpass"
        Me.txtNewpass.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewpass.Properties.Appearance.Options.UseFont = True
        Me.txtNewpass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewpass.Properties.UseSystemPasswordChar = True
        Me.txtNewpass.Size = New System.Drawing.Size(238, 20)
        Me.txtNewpass.TabIndex = 24
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(20, 100)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl2.TabIndex = 25
        Me.LabelControl2.Text = "New Password"
        '
        'txCurrpass
        '
        Me.txCurrpass.Location = New System.Drawing.Point(117, 60)
        Me.txCurrpass.Name = "txCurrpass"
        Me.txCurrpass.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCurrpass.Properties.Appearance.Options.UseFont = True
        Me.txCurrpass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txCurrpass.Properties.UseSystemPasswordChar = True
        Me.txCurrpass.Size = New System.Drawing.Size(238, 20)
        Me.txCurrpass.TabIndex = 22
        '
        'txtUName
        '
        Me.txtUName.Location = New System.Drawing.Point(117, 26)
        Me.txtUName.Name = "txtUName"
        Me.txtUName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUName.Properties.Appearance.Options.UseFont = True
        Me.txtUName.Properties.ReadOnly = True
        Me.txtUName.Size = New System.Drawing.Size(238, 20)
        Me.txtUName.TabIndex = 20
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(20, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl1.TabIndex = 21
        Me.LabelControl1.Text = "User Name"
        '
        'txtDriverName
        '
        Me.txtDriverName.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDriverName.Location = New System.Drawing.Point(20, 63)
        Me.txtDriverName.Name = "txtDriverName"
        Me.txtDriverName.Size = New System.Drawing.Size(91, 13)
        Me.txtDriverName.TabIndex = 23
        Me.txtDriverName.Text = "Current Password"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(406, 31)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Update"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(403, 169)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 16
        '
        'frmPasswordChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(502, 212)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tabUsersDetails)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmPasswordChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Change"
        CType(Me.tabUsersDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUsersDetails.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtNewpassRe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNewpass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txCurrpass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabUsersDetails As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtNewpassRe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNewpass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txCurrpass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDriverName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
