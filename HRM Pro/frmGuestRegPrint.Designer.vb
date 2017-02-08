<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuestRegPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuestRegPrint))
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.dtDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.grdReservation = New DevExpress.XtraGrid.GridControl()
        Me.gvMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btView = New DevExpress.XtraEditors.SimpleButton()
        Me.btPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbReservation = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdReservation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReservation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(628, 268)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 173
        '
        'dtDate
        '
        Me.dtDate.EditValue = Nothing
        Me.dtDate.Location = New System.Drawing.Point(110, 32)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDate.Size = New System.Drawing.Size(132, 20)
        Me.dtDate.TabIndex = 184
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(22, 35)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(66, 15)
        Me.LabelControl7.TabIndex = 183
        Me.LabelControl7.Text = "Arrival Date"
        '
        'grdReservation
        '
        Me.grdReservation.Location = New System.Drawing.Point(12, 110)
        Me.grdReservation.MainView = Me.gvMain
        Me.grdReservation.Name = "grdReservation"
        Me.grdReservation.Size = New System.Drawing.Size(607, 200)
        Me.grdReservation.TabIndex = 185
        Me.grdReservation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMain})
        '
        'gvMain
        '
        Me.gvMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn4, Me.GridColumn5, Me.GridColumn2, Me.GridColumn3, Me.GridColumn6, Me.GridColumn7})
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
        Me.GridColumn2.FieldName = "Arrdate"
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
        'btView
        '
        Me.btView.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btView.Appearance.Options.UseFont = True
        Me.btView.Location = New System.Drawing.Point(266, 29)
        Me.btView.Name = "btView"
        Me.btView.Size = New System.Drawing.Size(64, 23)
        Me.btView.TabIndex = 186
        Me.btView.Text = "Get"
        '
        'btPrint
        '
        Me.btPrint.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPrint.Appearance.Options.UseFont = True
        Me.btPrint.Location = New System.Drawing.Point(625, 110)
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(103, 36)
        Me.btPrint.TabIndex = 187
        Me.btPrint.Text = "Print"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(22, 70)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl2.TabIndex = 189
        Me.LabelControl2.Text = "Reservation #"
        '
        'cmbReservation
        '
        Me.cmbReservation.Location = New System.Drawing.Point(110, 66)
        Me.cmbReservation.Name = "cmbReservation"
        Me.cmbReservation.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReservation.Properties.Appearance.Options.UseFont = True
        Me.cmbReservation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbReservation.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ResNo", 125, "Reservertion #"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Guest", 250, "Full Name"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Operator", 125, "Operator")})
        Me.cmbReservation.Properties.NullText = ""
        Me.cmbReservation.Size = New System.Drawing.Size(190, 22)
        Me.cmbReservation.TabIndex = 188
        '
        'frmGuestRegPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(738, 322)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmbReservation)
        Me.Controls.Add(Me.btPrint)
        Me.Controls.Add(Me.btView)
        Me.Controls.Add(Me.grdReservation)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmGuestRegPrint"
        Me.Text = "Guest Registration Card Print"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdReservation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReservation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents dtDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grdReservation As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbReservation As DevExpress.XtraEditors.LookUpEdit
End Class
