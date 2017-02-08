<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEventBoard))
        Me.tabEventBoard = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcEventBoard = New DevExpress.XtraGrid.GridControl()
        Me.gvEventBoard = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnView = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbGuestID = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbRmNo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.gcEvents = New DevExpress.XtraGrid.GridControl()
        Me.gvEvents = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtEventRate = New DevExpress.XtraEditors.TextEdit()
        Me.txtEventName = New DevExpress.XtraEditors.TextEdit()
        Me.txtEventNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnInactive = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.tabEventBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEventBoard.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcEventBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEventBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.cmbGuestID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRmNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEventRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEventName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEventNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabEventBoard
        '
        Me.tabEventBoard.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabEventBoard.AppearancePage.Header.Options.UseFont = True
        Me.tabEventBoard.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabEventBoard.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabEventBoard.Location = New System.Drawing.Point(7, 4)
        Me.tabEventBoard.Name = "tabEventBoard"
        Me.tabEventBoard.SelectedTabPage = Me.XtraTabPage1
        Me.tabEventBoard.Size = New System.Drawing.Size(547, 305)
        Me.tabEventBoard.TabIndex = 0
        Me.tabEventBoard.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcEventBoard)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(545, 280)
        Me.XtraTabPage1.Text = "Event Board Details"
        '
        'gcEventBoard
        '
        Me.gcEventBoard.Location = New System.Drawing.Point(4, 8)
        Me.gcEventBoard.LookAndFeel.SkinName = "Metropolis"
        Me.gcEventBoard.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcEventBoard.MainView = Me.gvEventBoard
        Me.gcEventBoard.Name = "gcEventBoard"
        Me.gcEventBoard.Size = New System.Drawing.Size(538, 269)
        Me.gcEventBoard.TabIndex = 0
        Me.gcEventBoard.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEventBoard})
        '
        'gvEventBoard
        '
        Me.gvEventBoard.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvEventBoard.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvEventBoard.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvEventBoard.Appearance.Row.Options.UseFont = True
        Me.gvEventBoard.GridControl = Me.gcEventBoard
        Me.gvEventBoard.Name = "gvEventBoard"
        Me.gvEventBoard.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage2.Controls.Add(Me.lbl28)
        Me.XtraTabPage2.Controls.Add(Me.btnView)
        Me.XtraTabPage2.Controls.Add(Me.cmbGuestID)
        Me.XtraTabPage2.Controls.Add(Me.gcEvents)
        Me.XtraTabPage2.Controls.Add(Me.cmbRmNo)
        Me.XtraTabPage2.Controls.Add(Me.txtEventNo)
        Me.XtraTabPage2.Controls.Add(Me.txtEventRate)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.txtEventName)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(545, 280)
        Me.XtraTabPage2.Text = " Add New Event"
        '
        'btnView
        '
        Me.btnView.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Appearance.Options.UseFont = True
        Me.btnView.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnView.Location = New System.Drawing.Point(290, 114)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(92, 23)
        Me.btnView.TabIndex = 28
        Me.btnView.Text = "View"
        '
        'cmbGuestID
        '
        Me.cmbGuestID.Location = New System.Drawing.Point(119, 35)
        Me.cmbGuestID.Name = "cmbGuestID"
        Me.cmbGuestID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbGuestID.Size = New System.Drawing.Size(155, 20)
        Me.cmbGuestID.TabIndex = 27
        '
        'cmbRmNo
        '
        Me.cmbRmNo.Location = New System.Drawing.Point(119, 7)
        Me.cmbRmNo.Name = "cmbRmNo"
        Me.cmbRmNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRmNo.Size = New System.Drawing.Size(101, 20)
        Me.cmbRmNo.TabIndex = 26
        '
        'gcEvents
        '
        Me.gcEvents.Location = New System.Drawing.Point(4, 143)
        Me.gcEvents.MainView = Me.gvEvents
        Me.gcEvents.Name = "gcEvents"
        Me.gcEvents.Size = New System.Drawing.Size(538, 134)
        Me.gcEvents.TabIndex = 25
        Me.gcEvents.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEvents})
        '
        'gvEvents
        '
        Me.gvEvents.GridControl = Me.gcEvents
        Me.gvEvents.Name = "gvEvents"
        '
        'txtEventRate
        '
        Me.txtEventRate.Location = New System.Drawing.Point(119, 117)
        Me.txtEventRate.Name = "txtEventRate"
        Me.txtEventRate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventRate.Properties.Appearance.Options.UseFont = True
        Me.txtEventRate.Size = New System.Drawing.Size(161, 20)
        Me.txtEventRate.TabIndex = 24
        '
        'txtEventName
        '
        Me.txtEventName.Location = New System.Drawing.Point(119, 87)
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventName.Properties.Appearance.Options.UseFont = True
        Me.txtEventName.Size = New System.Drawing.Size(310, 20)
        Me.txtEventName.TabIndex = 23
        '
        'txtEventNo
        '
        Me.txtEventNo.Location = New System.Drawing.Point(119, 60)
        Me.txtEventNo.Name = "txtEventNo"
        Me.txtEventNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventNo.Properties.Appearance.Options.UseFont = True
        Me.txtEventNo.Size = New System.Drawing.Size(210, 20)
        Me.txtEventNo.TabIndex = 22
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(15, 120)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl3.TabIndex = 21
        Me.LabelControl3.Text = "Event Rate"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(15, 90)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl2.TabIndex = 20
        Me.LabelControl2.Text = "Event Name"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(15, 39)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Guest ID"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(15, 64)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Event No"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(15, 14)
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
        Me.btnInactive.Location = New System.Drawing.Point(572, 81)
        Me.btnInactive.Name = "btnInactive"
        Me.btnInactive.Size = New System.Drawing.Size(70, 23)
        Me.btnInactive.TabIndex = 12
        Me.btnInactive.Text = "Inactive"
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Location = New System.Drawing.Point(572, 53)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(70, 23)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edit"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(573, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(69, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(556, 269)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 18
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(226, 8)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 76
        Me.lbl28.Text = "*"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl4.Location = New System.Drawing.Point(280, 38)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl4.TabIndex = 77
        Me.LabelControl4.Text = "*"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl5.Location = New System.Drawing.Point(335, 62)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl5.TabIndex = 78
        Me.LabelControl5.Text = "*"
        '
        'frmEventBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(651, 312)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.tabEventBoard)
        Me.Controls.Add(Me.btnInactive)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmEventBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Event Board"
        CType(Me.tabEventBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEventBoard.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcEventBoard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEventBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.cmbGuestID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRmNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcEvents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEvents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEventRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEventName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEventNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabEventBoard As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcEventBoard As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvEventBoard As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEventRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEventName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEventNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcEvents As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvEvents As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnInactive As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbGuestID As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbRmNo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
End Class
