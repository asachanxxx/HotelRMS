<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisscountBilling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisscountBilling))
        Me.tabDiscou = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GcDisscounts = New DevExpress.XtraGrid.GridControl()
        Me.GcDisscountview = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.cmbDistype = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbldistype = New DevExpress.XtraEditors.LabelControl()
        Me.DisplanName = New DevExpress.XtraEditors.TextEdit()
        Me.DisplanAmt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.btEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btAdd = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.tabDiscou, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDiscou.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GcDisscounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcDisscountview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.cmbDistype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplanName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplanAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabDiscou
        '
        Me.tabDiscou.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabDiscou.AppearancePage.Header.Options.UseFont = True
        Me.tabDiscou.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabDiscou.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabDiscou.Location = New System.Drawing.Point(6, 6)
        Me.tabDiscou.Name = "tabDiscou"
        Me.tabDiscou.SelectedTabPage = Me.XtraTabPage1
        Me.tabDiscou.Size = New System.Drawing.Size(589, 237)
        Me.tabDiscou.TabIndex = 5
        Me.tabDiscou.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GcDisscounts)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(587, 212)
        Me.XtraTabPage1.Text = "Discount List"
        '
        'GcDisscounts
        '
        Me.GcDisscounts.Location = New System.Drawing.Point(3, 8)
        Me.GcDisscounts.MainView = Me.GcDisscountview
        Me.GcDisscounts.Name = "GcDisscounts"
        Me.GcDisscounts.Size = New System.Drawing.Size(581, 196)
        Me.GcDisscounts.TabIndex = 0
        Me.GcDisscounts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GcDisscountview})
        '
        'GcDisscountview
        '
        Me.GcDisscountview.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GcDisscountview.Appearance.HeaderPanel.Options.UseFont = True
        Me.GcDisscountview.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GcDisscountview.Appearance.Row.Options.UseFont = True
        Me.GcDisscountview.GridControl = Me.GcDisscounts
        Me.GcDisscountview.Name = "GcDisscountview"
        Me.GcDisscountview.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.cmbDistype)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.lbldistype)
        Me.XtraTabPage2.Controls.Add(Me.DisplanName)
        Me.XtraTabPage2.Controls.Add(Me.DisplanAmt)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(587, 212)
        Me.XtraTabPage2.Text = "  New Discount     "
        '
        'cmbDistype
        '
        Me.cmbDistype.Location = New System.Drawing.Point(102, 26)
        Me.cmbDistype.Name = "cmbDistype"
        Me.cmbDistype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDistype.Properties.Items.AddRange(New Object() {"per", "value"})
        Me.cmbDistype.Size = New System.Drawing.Size(73, 20)
        Me.cmbDistype.TabIndex = 30
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(5, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl1.TabIndex = 29
        Me.LabelControl1.Text = "Discount Type"
        '
        'lbldistype
        '
        Me.lbldistype.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldistype.Location = New System.Drawing.Point(5, 101)
        Me.lbldistype.Name = "lbldistype"
        Me.lbldistype.Size = New System.Drawing.Size(58, 13)
        Me.lbldistype.TabIndex = 22
        Me.lbldistype.Text = "Discount %"
        '
        'DisplanName
        '
        Me.DisplanName.Location = New System.Drawing.Point(102, 58)
        Me.DisplanName.Name = "DisplanName"
        Me.DisplanName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplanName.Properties.Appearance.Options.UseFont = True
        Me.DisplanName.Size = New System.Drawing.Size(310, 20)
        Me.DisplanName.TabIndex = 0
        '
        'DisplanAmt
        '
        Me.DisplanAmt.Location = New System.Drawing.Point(102, 94)
        Me.DisplanAmt.Name = "DisplanAmt"
        Me.DisplanAmt.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplanAmt.Properties.Appearance.Options.UseFont = True
        Me.DisplanAmt.Size = New System.Drawing.Size(142, 20)
        Me.DisplanAmt.TabIndex = 2
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(5, 65)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Discount Name"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(602, 203)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 23
        '
        'btEdit
        '
        Me.btEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEdit.Appearance.Options.UseFont = True
        Me.btEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btEdit.Location = New System.Drawing.Point(607, 59)
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
        Me.btAdd.Location = New System.Drawing.Point(608, 30)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(92, 23)
        Me.btAdd.TabIndex = 20
        Me.btAdd.Text = "Add"
        '
        'frmDisscountBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(706, 249)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.tabDiscou)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmDisscountBilling"
        Me.Text = "Disscount Billing"
        CType(Me.tabDiscou, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDiscou.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GcDisscounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcDisscountview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.cmbDistype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplanName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplanAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabDiscou As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GcDisscounts As DevExpress.XtraGrid.GridControl
    Friend WithEvents GcDisscountview As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmbDistype As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbldistype As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DisplanAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DisplanName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAdd As DevExpress.XtraEditors.SimpleButton
End Class
