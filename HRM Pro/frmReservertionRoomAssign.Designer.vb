<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservertionRoomAssign
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservertionRoomAssign))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbReservation = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbVacant = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbNDVacant = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdVacAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNDAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.grdReservation = New DevExpress.XtraGrid.GridControl()
        Me.gvMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbRoomtype = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbBedtype = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblRoomQty = New DevExpress.XtraEditors.LabelControl()
        Me.lblPax = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.dtDate = New DevExpress.XtraEditors.DateEdit()
        Me.btView = New DevExpress.XtraEditors.SimpleButton()
        Me.btReset = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cmbReservation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVacant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNDVacant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdReservation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRoomtype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBedtype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(601, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl2.TabIndex = 158
        Me.LabelControl2.Text = "Reservation #"
        '
        'cmbReservation
        '
        Me.cmbReservation.Location = New System.Drawing.Point(686, 52)
        Me.cmbReservation.Name = "cmbReservation"
        Me.cmbReservation.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReservation.Properties.Appearance.Options.UseFont = True
        Me.cmbReservation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbReservation.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ResNo", 125, "Reservertion #"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Guest", 250, "Full Name"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Operator", 125, "Operator")})
        Me.cmbReservation.Properties.NullText = ""
        Me.cmbReservation.Size = New System.Drawing.Size(190, 22)
        Me.cmbReservation.TabIndex = 157
        '
        'cmbVacant
        '
        Me.cmbVacant.Location = New System.Drawing.Point(714, 199)
        Me.cmbVacant.Name = "cmbVacant"
        Me.cmbVacant.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVacant.Properties.Appearance.Options.UseFont = True
        Me.cmbVacant.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbVacant.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbVacant.Size = New System.Drawing.Size(96, 22)
        Me.cmbVacant.TabIndex = 159
        '
        'cmbNDVacant
        '
        Me.cmbNDVacant.Location = New System.Drawing.Point(714, 225)
        Me.cmbNDVacant.Name = "cmbNDVacant"
        Me.cmbNDVacant.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNDVacant.Properties.Appearance.Options.UseFont = True
        Me.cmbNDVacant.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbNDVacant.Size = New System.Drawing.Size(96, 22)
        Me.cmbNDVacant.TabIndex = 161
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(619, 202)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 15)
        Me.LabelControl1.TabIndex = 162
        Me.LabelControl1.Text = "Vacant Room"
        '
        'cmdVacAdd
        '
        Me.cmdVacAdd.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVacAdd.Appearance.Options.UseFont = True
        Me.cmdVacAdd.Location = New System.Drawing.Point(816, 196)
        Me.cmdVacAdd.Name = "cmdVacAdd"
        Me.cmdVacAdd.Size = New System.Drawing.Size(48, 23)
        Me.cmdVacAdd.TabIndex = 164
        Me.cmdVacAdd.Text = "Add"
        '
        'cmdNDAdd
        '
        Me.cmdNDAdd.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNDAdd.Appearance.Options.UseFont = True
        Me.cmdNDAdd.Location = New System.Drawing.Point(816, 226)
        Me.cmdNDAdd.Name = "cmdNDAdd"
        Me.cmdNDAdd.Size = New System.Drawing.Size(48, 23)
        Me.cmdNDAdd.TabIndex = 165
        Me.cmdNDAdd.Text = "Add"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Appearance.Options.UseFont = True
        Me.cmdUpdate.Location = New System.Drawing.Point(323, 230)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(99, 23)
        Me.cmdUpdate.TabIndex = 169
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(619, 228)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(89, 15)
        Me.LabelControl3.TabIndex = 170
        Me.LabelControl3.Text = "Next Day Vacant"
        '
        'grdReservation
        '
        Me.grdReservation.Location = New System.Drawing.Point(6, 24)
        Me.grdReservation.MainView = Me.gvMain
        Me.grdReservation.Name = "grdReservation"
        Me.grdReservation.Size = New System.Drawing.Size(569, 200)
        Me.grdReservation.TabIndex = 171
        Me.grdReservation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMain})
        '
        'gvMain
        '
        Me.gvMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn4, Me.GridColumn5, Me.GridColumn2, Me.GridColumn3, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.gvMain.GridControl = Me.grdReservation
        Me.gvMain.Name = "gvMain"
        Me.gvMain.OptionsBehavior.Editable = False
        Me.gvMain.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Reservertion #"
        Me.GridColumn1.FieldName = "ResNo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 95
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Room"
        Me.GridColumn4.FieldName = "Room"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 80
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "BedType"
        Me.GridColumn5.FieldName = "BedType"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 80
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Reservation Date"
        Me.GridColumn2.FieldName = "ResDate"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 80
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Room No"
        Me.GridColumn3.FieldName = "RoomNo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 80
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "RoomCount"
        Me.GridColumn6.FieldName = "RoomCount"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "RoomPax"
        Me.GridColumn7.FieldName = "RoomPax"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Id"
        Me.GridColumn8.FieldName = "Id"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(475, 228)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 172
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(601, 88)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(59, 15)
        Me.LabelControl5.TabIndex = 174
        Me.LabelControl5.Text = "Room Type"
        '
        'cmbRoomtype
        '
        Me.cmbRoomtype.Location = New System.Drawing.Point(686, 85)
        Me.cmbRoomtype.Name = "cmbRoomtype"
        Me.cmbRoomtype.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRoomtype.Properties.Appearance.Options.UseFont = True
        Me.cmbRoomtype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRoomtype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbRoomtype.Size = New System.Drawing.Size(96, 22)
        Me.cmbRoomtype.TabIndex = 175
        '
        'cmbBedtype
        '
        Me.cmbBedtype.Location = New System.Drawing.Point(788, 85)
        Me.cmbBedtype.Name = "cmbBedtype"
        Me.cmbBedtype.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBedtype.Properties.Appearance.Options.UseFont = True
        Me.cmbBedtype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbBedtype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbBedtype.Size = New System.Drawing.Size(88, 22)
        Me.cmbBedtype.TabIndex = 176
        '
        'lblRoomQty
        '
        Me.lblRoomQty.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomQty.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.lblRoomQty.Location = New System.Drawing.Point(790, 123)
        Me.lblRoomQty.Name = "lblRoomQty"
        Me.lblRoomQty.Size = New System.Drawing.Size(20, 15)
        Me.lblRoomQty.TabIndex = 177
        Me.lblRoomQty.Text = "Qty"
        '
        'lblPax
        '
        Me.lblPax.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPax.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.lblPax.Location = New System.Drawing.Point(790, 158)
        Me.lblPax.Name = "lblPax"
        Me.lblPax.Size = New System.Drawing.Size(19, 15)
        Me.lblPax.TabIndex = 178
        Me.lblPax.Text = "Pax"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(723, 123)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(55, 15)
        Me.LabelControl4.TabIndex = 179
        Me.LabelControl4.Text = "Room Qty"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(706, 158)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(72, 15)
        Me.LabelControl6.TabIndex = 180
        Me.LabelControl6.Text = "Pax PerRoom"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(601, 22)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(25, 15)
        Me.LabelControl7.TabIndex = 181
        Me.LabelControl7.Text = "Date"
        '
        'dtDate
        '
        Me.dtDate.EditValue = Nothing
        Me.dtDate.Location = New System.Drawing.Point(686, 20)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDate.Size = New System.Drawing.Size(132, 20)
        Me.dtDate.TabIndex = 182
        '
        'btView
        '
        Me.btView.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btView.Appearance.Options.UseFont = True
        Me.btView.Location = New System.Drawing.Point(824, 17)
        Me.btView.Name = "btView"
        Me.btView.Size = New System.Drawing.Size(52, 23)
        Me.btView.TabIndex = 183
        Me.btView.Text = "Get"
        '
        'btReset
        '
        Me.btReset.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReset.Appearance.Options.UseFont = True
        Me.btReset.Location = New System.Drawing.Point(6, 230)
        Me.btReset.Name = "btReset"
        Me.btReset.Size = New System.Drawing.Size(73, 23)
        Me.btReset.TabIndex = 184
        Me.btReset.Text = "ReSet"
        '
        'frmReservertionRoomAssign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(886, 275)
        Me.Controls.Add(Me.btReset)
        Me.Controls.Add(Me.btView)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.lblPax)
        Me.Controls.Add(Me.lblRoomQty)
        Me.Controls.Add(Me.cmbBedtype)
        Me.Controls.Add(Me.cmbRoomtype)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.grdReservation)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdNDAdd)
        Me.Controls.Add(Me.cmdVacAdd)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmbNDVacant)
        Me.Controls.Add(Me.cmbVacant)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmbReservation)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmReservertionRoomAssign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Room Assignment"
        CType(Me.cmbReservation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVacant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNDVacant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdReservation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRoomtype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBedtype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbReservation As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbVacant As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbNDVacant As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdVacAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNDAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grdReservation As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbRoomtype As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbBedtype As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblRoomQty As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblPax As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btReset As DevExpress.XtraEditors.SimpleButton
End Class
