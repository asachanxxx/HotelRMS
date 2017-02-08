<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBoat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBoat))
        Me.colBoatID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colDriverID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colMinPassengers = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colMaxPassengers = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.tabBoat = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcBoat = New DevExpress.XtraGrid.GridControl()
        Me.gvBoat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDName = New DevExpress.XtraEditors.TextEdit()
        Me.txtBoatNo = New DevExpress.XtraEditors.TextEdit()
        Me.txtMinpas = New DevExpress.XtraEditors.TextEdit()
        Me.txtFLimite = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaxpas = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDriverName = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnInactive = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.tabBoat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBoat.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcBoat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBoat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtDName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoatNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinpas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFLimite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaxpas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colBoatID
        '
        Me.colBoatID.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colBoatID.AppearanceCell.Options.UseFont = True
        Me.colBoatID.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colBoatID.AppearanceHeader.Options.UseFont = True
        Me.colBoatID.AppearanceHeader.Options.UseTextOptions = True
        Me.colBoatID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBoatID.Caption = "Boat"
        Me.colBoatID.LayoutViewField = Nothing
        Me.colBoatID.Name = "colBoatID"
        Me.colBoatID.Width = 72
        '
        'colDriverID
        '
        Me.colDriverID.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colDriverID.AppearanceCell.Options.UseFont = True
        Me.colDriverID.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colDriverID.AppearanceHeader.Options.UseFont = True
        Me.colDriverID.AppearanceHeader.Options.UseTextOptions = True
        Me.colDriverID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDriverID.Caption = "Driver ID"
        Me.colDriverID.LayoutViewField = Nothing
        Me.colDriverID.Name = "colDriverID"
        Me.colDriverID.Width = 94
        '
        'colMinPassengers
        '
        Me.colMinPassengers.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colMinPassengers.AppearanceCell.Options.UseFont = True
        Me.colMinPassengers.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colMinPassengers.AppearanceHeader.Options.UseFont = True
        Me.colMinPassengers.AppearanceHeader.Options.UseTextOptions = True
        Me.colMinPassengers.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMinPassengers.Caption = "Min Passengers"
        Me.colMinPassengers.LayoutViewField = Nothing
        Me.colMinPassengers.Name = "colMinPassengers"
        Me.colMinPassengers.Width = 124
        '
        'colMaxPassengers
        '
        Me.colMaxPassengers.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colMaxPassengers.AppearanceCell.Options.UseFont = True
        Me.colMaxPassengers.AppearanceCell.Options.UseTextOptions = True
        Me.colMaxPassengers.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colMaxPassengers.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.colMaxPassengers.AppearanceHeader.Options.UseFont = True
        Me.colMaxPassengers.AppearanceHeader.Options.UseTextOptions = True
        Me.colMaxPassengers.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMaxPassengers.Caption = "Max Passengers"
        Me.colMaxPassengers.DisplayFormat.FormatString = "n2"
        Me.colMaxPassengers.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMaxPassengers.LayoutViewField = Nothing
        Me.colMaxPassengers.Name = "colMaxPassengers"
        Me.colMaxPassengers.Width = 185
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
        Me.tabBoat.Location = New System.Drawing.Point(4, 4)
        Me.tabBoat.Name = "tabBoat"
        Me.tabBoat.SelectedTabPage = Me.XtraTabPage1
        Me.tabBoat.Size = New System.Drawing.Size(360, 197)
        Me.tabBoat.TabIndex = 10
        Me.tabBoat.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcBoat)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(358, 172)
        Me.XtraTabPage1.Text = "Boat Details"
        '
        'gcBoat
        '
        Me.gcBoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gcBoat.Location = New System.Drawing.Point(3, 3)
        Me.gcBoat.MainView = Me.gvBoat
        Me.gcBoat.Name = "gcBoat"
        Me.gcBoat.Size = New System.Drawing.Size(338, 166)
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
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.lbl28)
        Me.XtraTabPage2.Controls.Add(Me.txtDName)
        Me.XtraTabPage2.Controls.Add(Me.txtBoatNo)
        Me.XtraTabPage2.Controls.Add(Me.txtMinpas)
        Me.XtraTabPage2.Controls.Add(Me.txtFLimite)
        Me.XtraTabPage2.Controls.Add(Me.txtMaxpas)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Controls.Add(Me.txtDriverName)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(358, 172)
        Me.XtraTabPage2.Text = "Add New Boat    "
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Location = New System.Drawing.Point(262, 112)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl3.TabIndex = 79
        Me.LabelControl3.Text = "*"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl2.Location = New System.Drawing.Point(262, 87)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl2.TabIndex = 78
        Me.LabelControl2.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(262, 20)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 77
        Me.lbl28.Text = "*"
        '
        'txtDName
        '
        Me.txtDName.Location = New System.Drawing.Point(114, 51)
        Me.txtDName.Name = "txtDName"
        Me.txtDName.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDName.Properties.Appearance.Options.UseFont = True
        Me.txtDName.Size = New System.Drawing.Size(142, 20)
        Me.txtDName.TabIndex = 1
        '
        'txtBoatNo
        '
        Me.txtBoatNo.Location = New System.Drawing.Point(114, 19)
        Me.txtBoatNo.Name = "txtBoatNo"
        Me.txtBoatNo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoatNo.Properties.Appearance.Options.UseFont = True
        Me.txtBoatNo.Size = New System.Drawing.Size(142, 20)
        Me.txtBoatNo.TabIndex = 0
        '
        'txtMinpas
        '
        Me.txtMinpas.Location = New System.Drawing.Point(114, 83)
        Me.txtMinpas.Name = "txtMinpas"
        Me.txtMinpas.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinpas.Properties.Appearance.Options.UseFont = True
        Me.txtMinpas.Size = New System.Drawing.Size(142, 20)
        Me.txtMinpas.TabIndex = 2
        '
        'txtFLimite
        '
        Me.txtFLimite.Location = New System.Drawing.Point(114, 144)
        Me.txtFLimite.Name = "txtFLimite"
        Me.txtFLimite.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFLimite.Properties.Appearance.Options.UseFont = True
        Me.txtFLimite.Size = New System.Drawing.Size(194, 20)
        Me.txtFLimite.TabIndex = 4
        '
        'txtMaxpas
        '
        Me.txtMaxpas.Location = New System.Drawing.Point(114, 113)
        Me.txtMaxpas.Name = "txtMaxpas"
        Me.txtMaxpas.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxpas.Properties.Appearance.Options.UseFont = True
        Me.txtMaxpas.Size = New System.Drawing.Size(142, 20)
        Me.txtMaxpas.TabIndex = 3
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(16, 86)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl8.TabIndex = 34
        Me.LabelControl8.Text = "Min Passengers"
        '
        'txtDriverName
        '
        Me.txtDriverName.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDriverName.Location = New System.Drawing.Point(16, 54)
        Me.txtDriverName.Name = "txtDriverName"
        Me.txtDriverName.Size = New System.Drawing.Size(75, 13)
        Me.txtDriverName.TabIndex = 33
        Me.txtDriverName.Text = "Captain  Name"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(14, 116)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl6.TabIndex = 32
        Me.LabelControl6.Text = "Max Passengers"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(16, 147)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl5.TabIndex = 31
        Me.LabelControl5.Text = "Fuel Limite"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(16, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl1.TabIndex = 30
        Me.LabelControl1.Text = "Boat No"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(367, 165)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 14
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(370, 36)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        '
        'btnInactive
        '
        Me.btnInactive.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInactive.Appearance.Options.UseFont = True
        Me.btnInactive.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnInactive.Location = New System.Drawing.Point(370, 94)
        Me.btnInactive.Name = "btnInactive"
        Me.btnInactive.Size = New System.Drawing.Size(92, 23)
        Me.btnInactive.TabIndex = 2
        Me.btnInactive.Text = "Inactive"
        '
        'btnEdit
        '
        Me.btnEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Appearance.Options.UseFont = True
        Me.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEdit.Location = New System.Drawing.Point(370, 65)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(92, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        '
        'frmBoat
        '
        Me.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseBorderColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(468, 202)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnInactive)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.tabBoat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmBoat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boat Master"
        CType(Me.tabBoat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBoat.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcBoat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBoat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtDName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoatNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinpas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFLimite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaxpas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents colBoatID As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colDriverID As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colMinPassengers As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colMaxPassengers As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents tabBoat As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcBoat As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBoat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnInactive As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBoatNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMinpas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFLimite As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaxpas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDriverName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
End Class
