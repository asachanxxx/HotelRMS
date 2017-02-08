<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpaservices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSpaservices))
        Me.tabSpaService = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GcSpa = New DevExpress.XtraGrid.GridControl()
        Me.GcSpaview = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtServiceAmt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtServiceDetail = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtService = New DevExpress.XtraEditors.TextEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.btDel = New DevExpress.XtraEditors.SimpleButton()
        Me.btEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btAdd = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.tabSpaService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSpaService.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GcSpa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcSpaview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtServiceAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServiceDetail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtService.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabSpaService
        '
        Me.tabSpaService.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabSpaService.AppearancePage.Header.Options.UseFont = True
        Me.tabSpaService.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabSpaService.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabSpaService.Location = New System.Drawing.Point(3, 12)
        Me.tabSpaService.Name = "tabSpaService"
        Me.tabSpaService.SelectedTabPage = Me.XtraTabPage1
        Me.tabSpaService.Size = New System.Drawing.Size(589, 238)
        Me.tabSpaService.TabIndex = 5
        Me.tabSpaService.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GcSpa)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(587, 213)
        Me.XtraTabPage1.Text = "Spa Services"
        '
        'GcSpa
        '
        Me.GcSpa.Location = New System.Drawing.Point(8, 8)
        Me.GcSpa.MainView = Me.GcSpaview
        Me.GcSpa.Name = "GcSpa"
        Me.GcSpa.Size = New System.Drawing.Size(576, 202)
        Me.GcSpa.TabIndex = 0
        Me.GcSpa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GcSpaview})
        '
        'GcSpaview
        '
        Me.GcSpaview.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GcSpaview.Appearance.HeaderPanel.Options.UseFont = True
        Me.GcSpaview.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GcSpaview.Appearance.Row.Options.UseFont = True
        Me.GcSpaview.GridControl = Me.GcSpa
        Me.GcSpaview.Name = "GcSpaview"
        Me.GcSpaview.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Controls.Add(Me.txtServiceAmt)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Controls.Add(Me.txtServiceDetail)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage2.Controls.Add(Me.txtService)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(587, 213)
        Me.XtraTabPage2.Text = "  New Service  "
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(16, 136)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl8.TabIndex = 22
        Me.LabelControl8.Text = "Amount [$]"
        '
        'txtServiceAmt
        '
        Me.txtServiceAmt.Location = New System.Drawing.Point(113, 133)
        Me.txtServiceAmt.Name = "txtServiceAmt"
        Me.txtServiceAmt.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceAmt.Properties.Appearance.Options.UseFont = True
        Me.txtServiceAmt.Size = New System.Drawing.Size(142, 20)
        Me.txtServiceAmt.TabIndex = 21
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(16, 29)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Service Name"
        '
        'txtServiceDetail
        '
        Me.txtServiceDetail.Location = New System.Drawing.Point(113, 56)
        Me.txtServiceDetail.Name = "txtServiceDetail"
        Me.txtServiceDetail.Size = New System.Drawing.Size(254, 64)
        Me.txtServiceDetail.TabIndex = 20
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(16, 81)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Details"
        '
        'txtService
        '
        Me.txtService.Location = New System.Drawing.Point(113, 27)
        Me.txtService.Name = "txtService"
        Me.txtService.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtService.Properties.Appearance.Options.UseFont = True
        Me.txtService.Size = New System.Drawing.Size(414, 20)
        Me.txtService.TabIndex = 18
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(598, 211)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 23
        '
        'btDel
        '
        Me.btDel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDel.Appearance.Options.UseFont = True
        Me.btDel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btDel.Location = New System.Drawing.Point(602, 94)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(92, 23)
        Me.btDel.TabIndex = 22
        Me.btDel.Text = "Delete"
        '
        'btEdit
        '
        Me.btEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEdit.Appearance.Options.UseFont = True
        Me.btEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btEdit.Location = New System.Drawing.Point(602, 65)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(92, 23)
        Me.btEdit.TabIndex = 21
        Me.btEdit.Text = "Edit"
        '
        'btAdd
        '
        Me.btAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.Appearance.Options.UseFont = True
        Me.btAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btAdd.Location = New System.Drawing.Point(603, 36)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(92, 23)
        Me.btAdd.TabIndex = 20
        Me.btAdd.Text = "Add"
        '
        'frmSpaservices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(703, 253)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btDel)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.tabSpaService)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmSpaservices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spa Services"
        CType(Me.tabSpaService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSpaService.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GcSpa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcSpaview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtServiceAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServiceDetail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtService.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabSpaService As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GcSpa As DevExpress.XtraGrid.GridControl
    Friend WithEvents GcSpaview As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtServiceAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtServiceDetail As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtService As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAdd As DevExpress.XtraEditors.SimpleButton
End Class
