<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoicing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoicing))
        Me.tabDiscou = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GcDisscounts = New DevExpress.XtraGrid.GridControl()
        Me.GcDisscountview = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btDel = New DevExpress.XtraEditors.SimpleButton()
        Me.btEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btAdd = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.tabDiscou, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDiscou.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GcDisscounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcDisscountview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabDiscou
        '
        Me.tabDiscou.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabDiscou.AppearancePage.Header.Options.UseFont = True
        Me.tabDiscou.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabDiscou.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabDiscou.Location = New System.Drawing.Point(12, 12)
        Me.tabDiscou.Name = "tabDiscou"
        Me.tabDiscou.SelectedTabPage = Me.XtraTabPage1
        Me.tabDiscou.Size = New System.Drawing.Size(732, 416)
        Me.tabDiscou.TabIndex = 5
        Me.tabDiscou.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupBox4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(730, 391)
        Me.XtraTabPage1.Text = "Reservations"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GcDisscounts)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(719, 380)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'GcDisscounts
        '
        Me.GcDisscounts.Location = New System.Drawing.Point(6, 12)
        Me.GcDisscounts.MainView = Me.GcDisscountview
        Me.GcDisscounts.Name = "GcDisscounts"
        Me.GcDisscounts.Size = New System.Drawing.Size(564, 295)
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
        Me.XtraTabPage2.Controls.Add(Me.GroupBox5)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(730, 391)
        Me.XtraTabPage2.Text = "Invoices"
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(721, 374)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'btDel
        '
        Me.btDel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDel.Appearance.Options.UseFont = True
        Me.btDel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btDel.Location = New System.Drawing.Point(759, 94)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(92, 23)
        Me.btDel.TabIndex = 10
        Me.btDel.Text = "Delete"
        '
        'btEdit
        '
        Me.btEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEdit.Appearance.Options.UseFont = True
        Me.btEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btEdit.Location = New System.Drawing.Point(759, 65)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(92, 23)
        Me.btEdit.TabIndex = 9
        Me.btEdit.Text = "Edit"
        '
        'btAdd
        '
        Me.btAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.Appearance.Options.UseFont = True
        Me.btAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btAdd.Location = New System.Drawing.Point(760, 36)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(92, 23)
        Me.btAdd.TabIndex = 8
        Me.btAdd.Text = "Add"
        '
        'frmInvoicing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 434)
        Me.Controls.Add(Me.btDel)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.tabDiscou)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmInvoicing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoicing"
        CType(Me.tabDiscou, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDiscou.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GcDisscounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcDisscountview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabDiscou As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GcDisscounts As DevExpress.XtraGrid.GridControl
    Friend WithEvents GcDisscountview As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAdd As DevExpress.XtraEditors.SimpleButton
End Class
