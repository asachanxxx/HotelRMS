<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoomMaster))
        Me.tabRooms = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcRoomMaster = New DevExpress.XtraGrid.GridControl()
        Me.gvRoomMaster = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.cmbStatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbCategory = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRoomno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.btInactiv = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.tabRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRooms.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcRoomMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRoomMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoomno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabRooms
        '
        Me.tabRooms.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabRooms.AppearancePage.Header.Options.UseFont = True
        Me.tabRooms.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabRooms.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabRooms.Location = New System.Drawing.Point(3, 12)
        Me.tabRooms.Name = "tabRooms"
        Me.tabRooms.SelectedTabPage = Me.XtraTabPage1
        Me.tabRooms.Size = New System.Drawing.Size(601, 245)
        Me.tabRooms.TabIndex = 2
        Me.tabRooms.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcRoomMaster)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(599, 220)
        Me.XtraTabPage1.Text = "Room details"
        '
        'gcRoomMaster
        '
        Me.gcRoomMaster.Location = New System.Drawing.Point(8, 8)
        Me.gcRoomMaster.MainView = Me.gvRoomMaster
        Me.gcRoomMaster.Name = "gcRoomMaster"
        Me.gcRoomMaster.Size = New System.Drawing.Size(588, 204)
        Me.gcRoomMaster.TabIndex = 0
        Me.gcRoomMaster.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRoomMaster})
        '
        'gvRoomMaster
        '
        Me.gvRoomMaster.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvRoomMaster.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvRoomMaster.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvRoomMaster.Appearance.Row.Options.UseFont = True
        Me.gvRoomMaster.GridControl = Me.gcRoomMaster
        Me.gvRoomMaster.Name = "gvRoomMaster"
        Me.gvRoomMaster.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.cmbStatus)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.cmbCategory)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.txtRoomno)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(599, 159)
        Me.XtraTabPage2.Text = " Add New Room  "
        '
        'cmbStatus
        '
        Me.cmbStatus.Location = New System.Drawing.Point(121, 85)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStatus.Properties.Items.AddRange(New Object() {"vacant", "out of service", "occupied", "dirty"})
        Me.cmbStatus.Size = New System.Drawing.Size(133, 20)
        Me.cmbStatus.TabIndex = 33
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(17, 88)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl2.TabIndex = 32
        Me.LabelControl2.Text = "Status"
        '
        'cmbCategory
        '
        Me.cmbCategory.Location = New System.Drawing.Point(121, 54)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCategory.Properties.Items.AddRange(New Object() {"Standard", "Superior", "Deluxe"})
        Me.cmbCategory.Size = New System.Drawing.Size(133, 20)
        Me.cmbCategory.TabIndex = 31
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(17, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Room No"
        '
        'txtRoomno
        '
        Me.txtRoomno.EditValue = ""
        Me.txtRoomno.Location = New System.Drawing.Point(121, 26)
        Me.txtRoomno.Name = "txtRoomno"
        Me.txtRoomno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomno.Properties.Appearance.Options.UseFont = True
        Me.txtRoomno.Size = New System.Drawing.Size(87, 20)
        Me.txtRoomno.TabIndex = 0
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(17, 55)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Category"
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Location = New System.Drawing.Point(615, 65)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(92, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(615, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(606, 214)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 16
        '
        'btInactiv
        '
        Me.btInactiv.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInactiv.Appearance.Options.UseFont = True
        Me.btInactiv.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btInactiv.Location = New System.Drawing.Point(615, 94)
        Me.btInactiv.Name = "btInactiv"
        Me.btInactiv.Size = New System.Drawing.Size(92, 23)
        Me.btInactiv.TabIndex = 17
        Me.btInactiv.Text = "Inactive"
        '
        'frmRoomMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(718, 262)
        Me.Controls.Add(Me.btInactiv)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.tabRooms)
        Me.Controls.Add(Me.btnAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmRoomMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Master"
        CType(Me.tabRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRooms.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcRoomMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRoomMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoomno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabRooms As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcRoomMaster As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvRoomMaster As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmbCategory As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRoomno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cmbStatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btInactiv As DevExpress.XtraEditors.SimpleButton
End Class
