<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextFileImport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTextFileImport))
        Me.txtPathItemMaster = New DevExpress.XtraEditors.TextEdit()
        Me.cmdBrowse = New DevExpress.XtraEditors.SimpleButton()
        Me.fbAccounts = New System.Windows.Forms.OpenFileDialog()
        Me.cmdImport_Item = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtPathItemMaster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPathItemMaster
        '
        Me.txtPathItemMaster.Location = New System.Drawing.Point(12, 47)
        Me.txtPathItemMaster.Name = "txtPathItemMaster"
        Me.txtPathItemMaster.Size = New System.Drawing.Size(404, 20)
        Me.txtPathItemMaster.TabIndex = 0
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(422, 42)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(88, 25)
        Me.cmdBrowse.TabIndex = 1
        Me.cmdBrowse.Text = "Browse"
        '
        'fbAccounts
        '
        Me.fbAccounts.FileName = "OpenFileDialog1"
        '
        'cmdImport_Item
        '
        Me.cmdImport_Item.Location = New System.Drawing.Point(516, 42)
        Me.cmdImport_Item.Name = "cmdImport_Item"
        Me.cmdImport_Item.Size = New System.Drawing.Size(88, 25)
        Me.cmdImport_Item.TabIndex = 2
        Me.cmdImport_Item.Text = "Import"
        '
        'frmTextFileImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 261)
        Me.Controls.Add(Me.cmdImport_Item)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtPathItemMaster)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTextFileImport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTextFileImport"
        CType(Me.txtPathItemMaster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPathItemMaster As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents fbAccounts As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdImport_Item As DevExpress.XtraEditors.SimpleButton
End Class
