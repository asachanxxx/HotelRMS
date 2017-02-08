<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmentities
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAmentities))
        Me.tabAmentities = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GcAmenities = New DevExpress.XtraGrid.GridControl()
        Me.GcAmenitiesview = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtAmeDetails = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAmename = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.btDel = New DevExpress.XtraEditors.SimpleButton()
        Me.btEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tabAmentities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAmentities.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GcAmenities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcAmenitiesview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtAmeDetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabAmentities
        '
        Me.tabAmentities.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAmentities.AppearancePage.Header.Options.UseFont = True
        Me.tabAmentities.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAmentities.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabAmentities.Location = New System.Drawing.Point(12, 12)
        Me.tabAmentities.Name = "tabAmentities"
        Me.tabAmentities.SelectedTabPage = Me.XtraTabPage1
        Me.tabAmentities.Size = New System.Drawing.Size(537, 266)
        Me.tabAmentities.TabIndex = 5
        Me.tabAmentities.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GcAmenities)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(535, 241)
        Me.XtraTabPage1.Text = "Amenities List"
        '
        'GcAmenities
        '
        Me.GcAmenities.Location = New System.Drawing.Point(8, 8)
        Me.GcAmenities.MainView = Me.GcAmenitiesview
        Me.GcAmenities.Name = "GcAmenities"
        Me.GcAmenities.Size = New System.Drawing.Size(524, 230)
        Me.GcAmenities.TabIndex = 0
        Me.GcAmenities.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GcAmenitiesview})
        '
        'GcAmenitiesview
        '
        Me.GcAmenitiesview.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GcAmenitiesview.Appearance.HeaderPanel.Options.UseFont = True
        Me.GcAmenitiesview.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GcAmenitiesview.Appearance.Row.Options.UseFont = True
        Me.GcAmenitiesview.GridControl = Me.GcAmenities
        Me.GcAmenitiesview.Name = "GcAmenitiesview"
        Me.GcAmenitiesview.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.txtAmeDetails)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Controls.Add(Me.txtAmename)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(535, 241)
        Me.XtraTabPage2.Text = "  New Amenities"
        '
        'txtAmeDetails
        '
        Me.txtAmeDetails.Location = New System.Drawing.Point(111, 56)
        Me.txtAmeDetails.Name = "txtAmeDetails"
        Me.txtAmeDetails.Size = New System.Drawing.Size(254, 64)
        Me.txtAmeDetails.TabIndex = 20
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(14, 29)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Amenities Name"
        '
        'txtAmename
        '
        Me.txtAmename.Location = New System.Drawing.Point(111, 27)
        Me.txtAmename.Name = "txtAmename"
        Me.txtAmename.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmename.Properties.Appearance.Options.UseFont = True
        Me.txtAmename.Size = New System.Drawing.Size(414, 20)
        Me.txtAmename.TabIndex = 18
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(15, 81)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Details"
        '
        'btDel
        '
        Me.btDel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDel.Appearance.Options.UseFont = True
        Me.btDel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btDel.Location = New System.Drawing.Point(554, 94)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(92, 23)
        Me.btDel.TabIndex = 14
        Me.btDel.Text = "Inactivate"
        '
        'btEdit
        '
        Me.btEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEdit.Appearance.Options.UseFont = True
        Me.btEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btEdit.Location = New System.Drawing.Point(554, 65)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(92, 23)
        Me.btEdit.TabIndex = 13
        Me.btEdit.Text = "Edit"
        '
        'btAdd
        '
        Me.btAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.Appearance.Options.UseFont = True
        Me.btAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btAdd.Location = New System.Drawing.Point(555, 36)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(92, 23)
        Me.btAdd.TabIndex = 12
        Me.btAdd.Text = "Add"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(551, 235)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 15
        '
        'frmAmentities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg23
        Me.ClientSize = New System.Drawing.Size(650, 280)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btDel)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.tabAmentities)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmAmentities"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Amentities"
        CType(Me.tabAmentities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAmentities.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GcAmenities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcAmenitiesview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtAmeDetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabAmentities As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GcAmenities As DevExpress.XtraGrid.GridControl
    Friend WithEvents GcAmenitiesview As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtAmeDetails As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAmename As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
