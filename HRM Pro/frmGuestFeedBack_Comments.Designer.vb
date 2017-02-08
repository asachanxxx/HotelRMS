<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuestFeedBack_Comments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuestFeedBack_Comments))
        Me.tabGuestFeddBackComments = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcGuestFeedback_Comments = New DevExpress.XtraGrid.GridControl()
        Me.gvGuestFeedback_Comments = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbRoomNo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.MemoGuestComments = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnInactive = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.tabGuestFeddBackComments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabGuestFeddBackComments.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcGuestFeedback_Comments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvGuestFeedback_Comments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.cmbRoomNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoGuestComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabGuestFeddBackComments
        '
        Me.tabGuestFeddBackComments.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabGuestFeddBackComments.AppearancePage.Header.Options.UseFont = True
        Me.tabGuestFeddBackComments.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabGuestFeddBackComments.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabGuestFeddBackComments.Location = New System.Drawing.Point(8, 5)
        Me.tabGuestFeddBackComments.Name = "tabGuestFeddBackComments"
        Me.tabGuestFeddBackComments.SelectedTabPage = Me.XtraTabPage1
        Me.tabGuestFeddBackComments.Size = New System.Drawing.Size(434, 251)
        Me.tabGuestFeddBackComments.TabIndex = 0
        Me.tabGuestFeddBackComments.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcGuestFeedback_Comments)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(432, 226)
        Me.XtraTabPage1.Text = "Guest Feed Back/Comments "
        '
        'gcGuestFeedback_Comments
        '
        Me.gcGuestFeedback_Comments.Location = New System.Drawing.Point(3, 3)
        Me.gcGuestFeedback_Comments.MainView = Me.gvGuestFeedback_Comments
        Me.gcGuestFeedback_Comments.Name = "gcGuestFeedback_Comments"
        Me.gcGuestFeedback_Comments.Size = New System.Drawing.Size(426, 220)
        Me.gcGuestFeedback_Comments.TabIndex = 0
        Me.gcGuestFeedback_Comments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvGuestFeedback_Comments})
        '
        'gvGuestFeedback_Comments
        '
        Me.gvGuestFeedback_Comments.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvGuestFeedback_Comments.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvGuestFeedback_Comments.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvGuestFeedback_Comments.Appearance.Row.Options.UseFont = True
        Me.gvGuestFeedback_Comments.GridControl = Me.gcGuestFeedback_Comments
        Me.gvGuestFeedback_Comments.Name = "gvGuestFeedback_Comments"
        Me.gvGuestFeedback_Comments.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.lbl28)
        Me.XtraTabPage2.Controls.Add(Me.cmbRoomNo)
        Me.XtraTabPage2.Controls.Add(Me.MemoGuestComments)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(432, 226)
        Me.XtraTabPage2.Text = " Add New Feed Back/Comments "
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Location = New System.Drawing.Point(411, 101)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl3.TabIndex = 79
        Me.LabelControl3.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(217, 7)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 77
        Me.lbl28.Text = "*"
        '
        'cmbRoomNo
        '
        Me.cmbRoomNo.Location = New System.Drawing.Point(111, 9)
        Me.cmbRoomNo.Name = "cmbRoomNo"
        Me.cmbRoomNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRoomNo.Size = New System.Drawing.Size(100, 20)
        Me.cmbRoomNo.TabIndex = 21
        '
        'MemoGuestComments
        '
        Me.MemoGuestComments.Location = New System.Drawing.Point(111, 53)
        Me.MemoGuestComments.Name = "MemoGuestComments"
        Me.MemoGuestComments.Size = New System.Drawing.Size(294, 126)
        Me.MemoGuestComments.TabIndex = 20
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(7, 101)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Guest Comments"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(7, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = " Room No"
        '
        'btnInactive
        '
        Me.btnInactive.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInactive.Appearance.Options.UseFont = True
        Me.btnInactive.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnInactive.Location = New System.Drawing.Point(455, 84)
        Me.btnInactive.Name = "btnInactive"
        Me.btnInactive.Size = New System.Drawing.Size(76, 23)
        Me.btnInactive.TabIndex = 10
        Me.btnInactive.Text = "Inactive"
        Me.btnInactive.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(455, 29)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(76, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(445, 214)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 18
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Location = New System.Drawing.Point(455, 56)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 19
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.Visible = False
        '
        'frmGuestFeedBack_Comments
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(543, 258)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.tabGuestFeddBackComments)
        Me.Controls.Add(Me.btnInactive)
        Me.Controls.Add(Me.btnAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmGuestFeedBack_Comments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Feed Back & Comments"
        CType(Me.tabGuestFeddBackComments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabGuestFeddBackComments.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcGuestFeedback_Comments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvGuestFeedback_Comments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.cmbRoomNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoGuestComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabGuestFeddBackComments As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcGuestFeedback_Comments As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvGuestFeedback_Comments As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents MemoGuestComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnInactive As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cmbRoomNo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
End Class
