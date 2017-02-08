<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArrivalDepartureExpexted
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArrivalDepartureExpexted))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcGuestArr = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.dtDateArr = New DevExpress.XtraEditors.DateEdit()
        Me.btnViewarr = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.btPrintDep = New DevExpress.XtraEditors.SimpleButton()
        Me.gcGuestDep = New DevExpress.XtraGrid.GridControl()
        Me.gvGuestArr = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcRoomNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcResNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcGuestRegNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcFullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDepDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDepTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDepTrans = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDFlight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtDateDep = New DevExpress.XtraEditors.DateEdit()
        Me.btnViewDep = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.gcArrDep = New DevExpress.XtraGrid.GridControl()
        Me.gvArrDep = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRmNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArrivalDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepartureDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.gcGuestArr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateArr.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateArr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.gcGuestDep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvGuestArr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateDep.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcArrDep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvArrDep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 2)
        Me.XtraTabControl1.LookAndFeel.SkinName = "Metropolis"
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(856, 450)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.gcGuestArr)
        Me.XtraTabPage2.Controls.Add(Me.SimpleButton1)
        Me.XtraTabPage2.Controls.Add(Me.dtDateArr)
        Me.XtraTabPage2.Controls.Add(Me.btnViewarr)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(854, 425)
        Me.XtraTabPage2.Text = "Expected Arrivals"
        '
        'gcGuestArr
        '
        Me.gcGuestArr.Location = New System.Drawing.Point(4, 40)
        Me.gcGuestArr.MainView = Me.GridView2
        Me.gcGuestArr.Name = "gcGuestArr"
        Me.gcGuestArr.Size = New System.Drawing.Size(848, 381)
        Me.gcGuestArr.TabIndex = 31
        Me.gcGuestArr.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.GridView2.GridControl = Me.gcGuestArr
        Me.GridView2.Name = "GridView2"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ResNo"
        Me.GridColumn1.FieldName = "ResNo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 81
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Guest"
        Me.GridColumn2.FieldName = "Guest"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 120
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "TotPax"
        Me.GridColumn3.FieldName = "TotPax"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 65
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "MP"
        Me.GridColumn4.FieldName = "MealPlan"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 77
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Topcode"
        Me.GridColumn5.FieldName = "Topcode"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 77
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "ArrFlight"
        Me.GridColumn6.FieldName = "ArrFlight"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 77
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "FlightTime"
        Me.GridColumn7.FieldName = "ArrTime"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 77
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "ArrTrans"
        Me.GridColumn8.FieldName = "ArrTrans"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        Me.GridColumn8.Width = 77
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "DepDate"
        Me.GridColumn9.FieldName = "DepDate"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        Me.GridColumn9.Width = 77
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Remarks"
        Me.GridColumn10.FieldName = "Remarks"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        Me.GridColumn10.Width = 91
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton1.Location = New System.Drawing.Point(251, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(71, 23)
        Me.SimpleButton1.TabIndex = 30
        Me.SimpleButton1.Text = "Print"
        '
        'dtDateArr
        '
        Me.dtDateArr.EditValue = Nothing
        Me.dtDateArr.Location = New System.Drawing.Point(60, 13)
        Me.dtDateArr.Name = "dtDateArr"
        Me.dtDateArr.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDateArr.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDateArr.Size = New System.Drawing.Size(101, 20)
        Me.dtDateArr.TabIndex = 29
        '
        'btnViewarr
        '
        Me.btnViewarr.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewarr.Appearance.Options.UseFont = True
        Me.btnViewarr.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnViewarr.Location = New System.Drawing.Point(173, 12)
        Me.btnViewarr.Name = "btnViewarr"
        Me.btnViewarr.Size = New System.Drawing.Size(72, 23)
        Me.btnViewarr.TabIndex = 28
        Me.btnViewarr.Text = "View"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(15, 14)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Date :"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.btPrintDep)
        Me.XtraTabPage3.Controls.Add(Me.gcGuestDep)
        Me.XtraTabPage3.Controls.Add(Me.dtDateDep)
        Me.XtraTabPage3.Controls.Add(Me.btnViewDep)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(854, 425)
        Me.XtraTabPage3.Text = "Expected Departures"
        '
        'btPrintDep
        '
        Me.btPrintDep.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPrintDep.Appearance.Options.UseFont = True
        Me.btPrintDep.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btPrintDep.Location = New System.Drawing.Point(295, 10)
        Me.btPrintDep.Name = "btPrintDep"
        Me.btPrintDep.Size = New System.Drawing.Size(71, 23)
        Me.btPrintDep.TabIndex = 31
        Me.btPrintDep.Text = "Print"
        '
        'gcGuestDep
        '
        Me.gcGuestDep.Location = New System.Drawing.Point(3, 48)
        Me.gcGuestDep.MainView = Me.gvGuestArr
        Me.gcGuestDep.Name = "gcGuestDep"
        Me.gcGuestDep.Size = New System.Drawing.Size(848, 381)
        Me.gcGuestDep.TabIndex = 28
        Me.gcGuestDep.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvGuestArr})
        '
        'gvGuestArr
        '
        Me.gvGuestArr.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcRoomNo, Me.gcResNo, Me.gcGuestRegNo, Me.gcFullName, Me.gcDepDate1, Me.gcDepTime, Me.gcDepTrans, Me.gcDFlight})
        Me.gvGuestArr.GridControl = Me.gcGuestDep
        Me.gvGuestArr.Name = "gvGuestArr"
        '
        'gcRoomNo
        '
        Me.gcRoomNo.Caption = "RoomNo"
        Me.gcRoomNo.FieldName = "RoomNo"
        Me.gcRoomNo.Name = "gcRoomNo"
        Me.gcRoomNo.Visible = True
        Me.gcRoomNo.VisibleIndex = 0
        '
        'gcResNo
        '
        Me.gcResNo.Caption = "ResNo"
        Me.gcResNo.FieldName = "ReservationNo"
        Me.gcResNo.Name = "gcResNo"
        Me.gcResNo.Visible = True
        Me.gcResNo.VisibleIndex = 1
        '
        'gcGuestRegNo
        '
        Me.gcGuestRegNo.Caption = "GuestRegNo"
        Me.gcGuestRegNo.FieldName = "GuestRegNo"
        Me.gcGuestRegNo.Name = "gcGuestRegNo"
        Me.gcGuestRegNo.Visible = True
        Me.gcGuestRegNo.VisibleIndex = 2
        '
        'gcFullName
        '
        Me.gcFullName.Caption = "Guest"
        Me.gcFullName.FieldName = "FullName"
        Me.gcFullName.Name = "gcFullName"
        Me.gcFullName.Visible = True
        Me.gcFullName.VisibleIndex = 3
        Me.gcFullName.Width = 120
        '
        'gcDepDate1
        '
        Me.gcDepDate1.Caption = "DepDate"
        Me.gcDepDate1.FieldName = "DepDate"
        Me.gcDepDate1.Name = "gcDepDate1"
        Me.gcDepDate1.Visible = True
        Me.gcDepDate1.VisibleIndex = 4
        Me.gcDepDate1.Width = 80
        '
        'gcDepTime
        '
        Me.gcDepTime.Caption = "DepTime"
        Me.gcDepTime.FieldName = "DTime"
        Me.gcDepTime.Name = "gcDepTime"
        Me.gcDepTime.Visible = True
        Me.gcDepTime.VisibleIndex = 6
        Me.gcDepTime.Width = 82
        '
        'gcDepTrans
        '
        Me.gcDepTrans.Caption = "DepTrans"
        Me.gcDepTrans.FieldName = "DepTo"
        Me.gcDepTrans.Name = "gcDepTrans"
        Me.gcDepTrans.Visible = True
        Me.gcDepTrans.VisibleIndex = 5
        Me.gcDepTrans.Width = 80
        '
        'gcDFlight
        '
        Me.gcDFlight.Caption = "Flight"
        Me.gcDFlight.FieldName = "DFlight"
        Me.gcDFlight.Name = "gcDFlight"
        Me.gcDFlight.Visible = True
        Me.gcDFlight.VisibleIndex = 7
        '
        'dtDateDep
        '
        Me.dtDateDep.EditValue = Nothing
        Me.dtDateDep.Location = New System.Drawing.Point(78, 13)
        Me.dtDateDep.Name = "dtDateDep"
        Me.dtDateDep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDateDep.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDateDep.Size = New System.Drawing.Size(124, 20)
        Me.dtDateDep.TabIndex = 27
        '
        'btnViewDep
        '
        Me.btnViewDep.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDep.Appearance.Options.UseFont = True
        Me.btnViewDep.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnViewDep.Location = New System.Drawing.Point(216, 10)
        Me.btnViewDep.Name = "btnViewDep"
        Me.btnViewDep.Size = New System.Drawing.Size(63, 23)
        Me.btnViewDep.TabIndex = 15
        Me.btnViewDep.Text = "View"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(16, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl2.TabIndex = 19
        Me.LabelControl2.Text = "Date :"
        '
        'gcArrDep
        '
        Me.gcArrDep.Location = New System.Drawing.Point(14, 32)
        Me.gcArrDep.LookAndFeel.SkinName = "Metropolis"
        Me.gcArrDep.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcArrDep.MainView = Me.gvArrDep
        Me.gcArrDep.Name = "gcArrDep"
        Me.gcArrDep.Size = New System.Drawing.Size(493, 292)
        Me.gcArrDep.TabIndex = 0
        Me.gcArrDep.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvArrDep, Me.GridView1})
        '
        'gvArrDep
        '
        Me.gvArrDep.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvArrDep.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvArrDep.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvArrDep.Appearance.Row.Options.UseFont = True
        Me.gvArrDep.GridControl = Me.gcArrDep
        Me.gvArrDep.Name = "gvArrDep"
        Me.gvArrDep.OptionsView.ShowGroupPanel = False
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gcArrDep
        Me.GridView1.Name = "GridView1"
        '
        'colGID
        '
        Me.colGID.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGID.AppearanceCell.Options.UseFont = True
        Me.colGID.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGID.AppearanceHeader.Options.UseFont = True
        Me.colGID.AppearanceHeader.Options.UseTextOptions = True
        Me.colGID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGID.Caption = "Guest ID"
        Me.colGID.Name = "colGID"
        Me.colGID.Visible = True
        Me.colGID.VisibleIndex = 0
        Me.colGID.Width = 93
        '
        'colGName
        '
        Me.colGName.Caption = "Guest Name"
        Me.colGName.Name = "colGName"
        Me.colGName.Visible = True
        Me.colGName.VisibleIndex = 1
        '
        'colRmNo
        '
        Me.colRmNo.Caption = "Room No"
        Me.colRmNo.Name = "colRmNo"
        Me.colRmNo.Visible = True
        Me.colRmNo.VisibleIndex = 2
        Me.colRmNo.Width = 82
        '
        'colArrivalDate
        '
        Me.colArrivalDate.Caption = "Arrival Date"
        Me.colArrivalDate.Name = "colArrivalDate"
        Me.colArrivalDate.Visible = True
        Me.colArrivalDate.VisibleIndex = 3
        Me.colArrivalDate.Width = 82
        '
        'colDepartureDate
        '
        Me.colDepartureDate.Caption = "Departure Date"
        Me.colDepartureDate.Name = "colDepartureDate"
        Me.colDepartureDate.Visible = True
        Me.colDepartureDate.VisibleIndex = 4
        Me.colDepartureDate.Width = 132
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(862, 420)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 18
        '
        'frmArrivalDepartureExpexted
        '
        Me.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(962, 456)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmArrivalDepartureExpexted"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arrival/Departure Expected"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.gcGuestArr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateArr.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateArr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.gcGuestDep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvGuestArr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateDep.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcArrDep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvArrDep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtDateDep As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnViewDep As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcArrDep As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvArrDep As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRmNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArrivalDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepartureDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtDateArr As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnViewarr As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcGuestArr As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcGuestDep As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvGuestArr As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcRoomNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcResNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcGuestRegNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcFullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDepDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDepTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDepTrans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDFlight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btPrintDep As DevExpress.XtraEditors.SimpleButton
End Class
