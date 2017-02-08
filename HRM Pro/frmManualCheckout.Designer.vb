<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManualCheckout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManualCheckout))
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.tabBoat = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcBoat = New DevExpress.XtraGrid.GridControl()
        Me.gvBoat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnManualCheout = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabBoat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBoat.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcBoat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBoat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(636, 263)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 16
        '
        'tabBoat
        '
        Me.tabBoat.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.tabBoat.Appearance.Options.UseBackColor = True
        Me.tabBoat.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBoat.AppearancePage.Header.Options.UseFont = True
        Me.tabBoat.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBoat.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabBoat.BackgroundImage = Global.HRM_Pro.My.Resources.Resources.b2g
        Me.tabBoat.Location = New System.Drawing.Point(12, 12)
        Me.tabBoat.Name = "tabBoat"
        Me.tabBoat.SelectedTabPage = Me.XtraTabPage1
        Me.tabBoat.Size = New System.Drawing.Size(587, 293)
        Me.tabBoat.TabIndex = 17
        Me.tabBoat.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcBoat)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(585, 268)
        Me.XtraTabPage1.Text = "Occupied Rooms"
        '
        'gcBoat
        '
        Me.gcBoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gcBoat.Location = New System.Drawing.Point(3, 3)
        Me.gcBoat.MainView = Me.gvBoat
        Me.gcBoat.Name = "gcBoat"
        Me.gcBoat.Size = New System.Drawing.Size(579, 257)
        Me.gcBoat.TabIndex = 1
        Me.gcBoat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBoat})
        '
        'gvBoat
        '
        Me.gvBoat.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvBoat.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvBoat.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvBoat.Appearance.Row.Options.UseFont = True
        Me.gvBoat.GridControl = Me.gcBoat
        Me.gvBoat.Name = "gvBoat"
        Me.gvBoat.OptionsView.ShowGroupPanel = False
        '
        'btnManualCheout
        '
        Me.btnManualCheout.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManualCheout.Appearance.Options.UseFont = True
        Me.btnManualCheout.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnManualCheout.Location = New System.Drawing.Point(605, 36)
        Me.btnManualCheout.Name = "btnManualCheout"
        Me.btnManualCheout.Size = New System.Drawing.Size(131, 63)
        Me.btnManualCheout.TabIndex = 18
        Me.btnManualCheout.Text = "Manual Check Out"
        '
        'frmManualCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(746, 312)
        Me.Controls.Add(Me.btnManualCheout)
        Me.Controls.Add(Me.tabBoat)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmManualCheckout"
        Me.Text = "Manual Checkout  - No Bills"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabBoat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBoat.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcBoat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBoat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents tabBoat As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcBoat As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBoat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnManualCheout As DevExpress.XtraEditors.SimpleButton
End Class
