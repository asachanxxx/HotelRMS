<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomnochange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoomnochange))
        Me.tabRooms = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcRoomMaster = New DevExpress.XtraGrid.GridControl()
        Me.gvRoomMaster = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbRoom = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRoomno = New DevExpress.XtraEditors.TextEdit()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbChangeType = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.tabRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRooms.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcRoomMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRoomMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.cmbRoom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoomno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbChangeType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabRooms
        '
        Me.tabRooms.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabRooms.AppearancePage.Header.Options.UseFont = True
        Me.tabRooms.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabRooms.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabRooms.Location = New System.Drawing.Point(5, 12)
        Me.tabRooms.Name = "tabRooms"
        Me.tabRooms.SelectedTabPage = Me.XtraTabPage1
        Me.tabRooms.Size = New System.Drawing.Size(514, 184)
        Me.tabRooms.TabIndex = 3
        Me.tabRooms.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcRoomMaster)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(512, 159)
        Me.XtraTabPage1.Text = "Room details"
        '
        'gcRoomMaster
        '
        Me.gcRoomMaster.Location = New System.Drawing.Point(8, 18)
        Me.gcRoomMaster.MainView = Me.gvRoomMaster
        Me.gcRoomMaster.Name = "gcRoomMaster"
        Me.gcRoomMaster.Size = New System.Drawing.Size(588, 137)
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
        Me.XtraTabPage2.Controls.Add(Me.cmbChangeType)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.cmbRoom)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.txtRoomno)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(512, 159)
        Me.XtraTabPage2.Text = " Change Room  "
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(17, 67)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl3.TabIndex = 34
        Me.LabelControl3.Text = "New Room No"
        '
        'cmbRoom
        '
        Me.cmbRoom.Location = New System.Drawing.Point(131, 64)
        Me.cmbRoom.Name = "cmbRoom"
        Me.cmbRoom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRoom.Size = New System.Drawing.Size(87, 20)
        Me.cmbRoom.TabIndex = 31
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
        Me.txtRoomno.Location = New System.Drawing.Point(131, 26)
        Me.txtRoomno.Name = "txtRoomno"
        Me.txtRoomno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomno.Properties.Appearance.Options.UseFont = True
        Me.txtRoomno.Size = New System.Drawing.Size(87, 20)
        Me.txtRoomno.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(525, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(99, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Change Room"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(525, 161)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 17
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(17, 114)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl2.TabIndex = 35
        Me.LabelControl2.Text = "Room Change Type"
        '
        'cmbChangeType
        '
        Me.cmbChangeType.Location = New System.Drawing.Point(131, 111)
        Me.cmbChangeType.Name = "cmbChangeType"
        Me.cmbChangeType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbChangeType.Properties.Items.AddRange(New Object() {"Upgrade", "Downgrade", "Not Changed", "Other"})
        Me.cmbChangeType.Size = New System.Drawing.Size(87, 20)
        Me.cmbChangeType.TabIndex = 36
        '
        'frmRoomnochange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(630, 198)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.tabRooms)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmRoomnochange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room No Change"
        CType(Me.tabRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRooms.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcRoomMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRoomMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.cmbRoom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoomno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbChangeType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabRooms As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcRoomMaster As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvRoomMaster As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbRoom As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRoomno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cmbChangeType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
