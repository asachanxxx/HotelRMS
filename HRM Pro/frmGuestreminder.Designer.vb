<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuestreminder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuestreminder))
        Me.btPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TimeBillST = New DevExpress.XtraEditors.TimeEdit()
        Me.dtBillSettlement = New DevExpress.XtraEditors.DateEdit()
        Me.TimeHDep = New DevExpress.XtraEditors.TimeEdit()
        Me.TimeFinalBill = New DevExpress.XtraEditors.TimeEdit()
        Me.TimeMealS = New DevExpress.XtraEditors.TimeEdit()
        Me.TimeLCollection = New DevExpress.XtraEditors.TimeEdit()
        Me.TimeWakeup = New DevExpress.XtraEditors.TimeEdit()
        Me.TimeBillSF = New DevExpress.XtraEditors.TimeEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.tabBoatSchedDetails = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.CbWake = New System.Windows.Forms.CheckBox()
        Me.CheckEng = New DevExpress.XtraEditors.CheckEdit()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.btnViewDep = New DevExpress.XtraEditors.SimpleButton()
        Me.gcDep = New DevExpress.XtraGrid.GridControl()
        Me.gvDep = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRoom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReservationNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepFlight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldepsourse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepGuest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Depcolcheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.dtDateDep = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.CbMR = New System.Windows.Forms.CheckBox()
        CType(Me.TimeBillST.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBillSettlement.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBillSettlement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeHDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeFinalBill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeMealS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeLCollection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeWakeup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeBillSF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabBoatSchedDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBoatSchedDetails.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.CheckEng.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateDep.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btPrint
        '
        Me.btPrint.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPrint.Appearance.Options.UseFont = True
        Me.btPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btPrint.Location = New System.Drawing.Point(307, 380)
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(92, 23)
        Me.btPrint.TabIndex = 4
        Me.btPrint.Text = "Print"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(463, 243)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(10, 12)
        Me.LabelControl2.TabIndex = 81
        Me.LabelControl2.Text = "To"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(293, 243)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(20, 12)
        Me.LabelControl1.TabIndex = 80
        Me.LabelControl1.Text = "From"
        '
        'TimeBillST
        '
        Me.TimeBillST.EditValue = New Date(2012, 10, 24, 0, 0, 0, 0)
        Me.TimeBillST.Location = New System.Drawing.Point(351, 235)
        Me.TimeBillST.Name = "TimeBillST"
        Me.TimeBillST.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeBillST.Size = New System.Drawing.Size(106, 20)
        Me.TimeBillST.TabIndex = 79
        '
        'dtBillSettlement
        '
        Me.dtBillSettlement.EditValue = Nothing
        Me.dtBillSettlement.Location = New System.Drawing.Point(181, 203)
        Me.dtBillSettlement.Name = "dtBillSettlement"
        Me.dtBillSettlement.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBillSettlement.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtBillSettlement.Size = New System.Drawing.Size(106, 20)
        Me.dtBillSettlement.TabIndex = 78
        '
        'TimeHDep
        '
        Me.TimeHDep.EditValue = New Date(2012, 10, 24, 0, 0, 0, 0)
        Me.TimeHDep.Location = New System.Drawing.Point(181, 383)
        Me.TimeHDep.Name = "TimeHDep"
        Me.TimeHDep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeHDep.Size = New System.Drawing.Size(106, 20)
        Me.TimeHDep.TabIndex = 77
        '
        'TimeFinalBill
        '
        Me.TimeFinalBill.EditValue = New Date(2012, 10, 24, 0, 0, 0, 0)
        Me.TimeFinalBill.Location = New System.Drawing.Point(181, 353)
        Me.TimeFinalBill.Name = "TimeFinalBill"
        Me.TimeFinalBill.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeFinalBill.Size = New System.Drawing.Size(106, 20)
        Me.TimeFinalBill.TabIndex = 76
        '
        'TimeMealS
        '
        Me.TimeMealS.EditValue = New Date(2012, 10, 24, 0, 0, 0, 0)
        Me.TimeMealS.Location = New System.Drawing.Point(181, 323)
        Me.TimeMealS.Name = "TimeMealS"
        Me.TimeMealS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeMealS.Size = New System.Drawing.Size(106, 20)
        Me.TimeMealS.TabIndex = 75
        '
        'TimeLCollection
        '
        Me.TimeLCollection.EditValue = New Date(2012, 10, 24, 0, 0, 0, 0)
        Me.TimeLCollection.Location = New System.Drawing.Point(181, 297)
        Me.TimeLCollection.Name = "TimeLCollection"
        Me.TimeLCollection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeLCollection.Size = New System.Drawing.Size(106, 20)
        Me.TimeLCollection.TabIndex = 74
        '
        'TimeWakeup
        '
        Me.TimeWakeup.EditValue = New Date(2012, 10, 24, 0, 0, 0, 0)
        Me.TimeWakeup.Location = New System.Drawing.Point(181, 271)
        Me.TimeWakeup.Name = "TimeWakeup"
        Me.TimeWakeup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeWakeup.Size = New System.Drawing.Size(106, 20)
        Me.TimeWakeup.TabIndex = 73
        '
        'TimeBillSF
        '
        Me.TimeBillSF.EditValue = New Date(2012, 10, 24, 0, 0, 0, 0)
        Me.TimeBillSF.Location = New System.Drawing.Point(181, 235)
        Me.TimeBillSF.Name = "TimeBillSF"
        Me.TimeBillSF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeBillSF.Size = New System.Drawing.Size(106, 20)
        Me.TimeBillSF.TabIndex = 72
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(22, 386)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl9.TabIndex = 40
        Me.LabelControl9.Text = "Hotel Departure Time "
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(22, 356)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(149, 13)
        Me.LabelControl8.TabIndex = 38
        Me.LabelControl8.Text = "Final Bill Settlement Amount "
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(22, 330)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl7.TabIndex = 36
        Me.LabelControl7.Text = "Meal Served "
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(22, 300)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(129, 13)
        Me.LabelControl6.TabIndex = 34
        Me.LabelControl6.Text = "Luggage Collection Time "
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(22, 274)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl5.TabIndex = 32
        Me.LabelControl5.Text = "Wake Up Call Time "
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(22, 238)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl4.TabIndex = 30
        Me.LabelControl4.Text = "Bill Settlement Time "
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(22, 203)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl3.TabIndex = 28
        Me.LabelControl3.Text = "Bill Settlement Date "
        '
        'tabBoatSchedDetails
        '
        Me.tabBoatSchedDetails.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBoatSchedDetails.AppearancePage.Header.Options.UseFont = True
        Me.tabBoatSchedDetails.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBoatSchedDetails.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabBoatSchedDetails.Location = New System.Drawing.Point(12, 12)
        Me.tabBoatSchedDetails.Name = "tabBoatSchedDetails"
        Me.tabBoatSchedDetails.SelectedTabPage = Me.XtraTabPage3
        Me.tabBoatSchedDetails.Size = New System.Drawing.Size(1043, 443)
        Me.tabBoatSchedDetails.TabIndex = 24
        Me.tabBoatSchedDetails.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.CbMR)
        Me.XtraTabPage3.Controls.Add(Me.CbWake)
        Me.XtraTabPage3.Controls.Add(Me.CheckEng)
        Me.XtraTabPage3.Controls.Add(Me.PictureEdit2)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage3.Controls.Add(Me.btnViewDep)
        Me.XtraTabPage3.Controls.Add(Me.TimeBillST)
        Me.XtraTabPage3.Controls.Add(Me.gcDep)
        Me.XtraTabPage3.Controls.Add(Me.dtBillSettlement)
        Me.XtraTabPage3.Controls.Add(Me.dtDateDep)
        Me.XtraTabPage3.Controls.Add(Me.TimeHDep)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl42)
        Me.XtraTabPage3.Controls.Add(Me.TimeFinalBill)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage3.Controls.Add(Me.TimeMealS)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage3.Controls.Add(Me.TimeLCollection)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage3.Controls.Add(Me.TimeWakeup)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage3.Controls.Add(Me.TimeBillSF)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage3.Controls.Add(Me.btPrint)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1041, 418)
        Me.XtraTabPage3.Text = "Letters"
        '
        'CbWake
        '
        Me.CbWake.AutoSize = True
        Me.CbWake.Location = New System.Drawing.Point(293, 273)
        Me.CbWake.Name = "CbWake"
        Me.CbWake.Size = New System.Drawing.Size(66, 17)
        Me.CbWake.TabIndex = 83
        Me.CbWake.Text = "Request"
        Me.CbWake.UseVisualStyleBackColor = True
        '
        'CheckEng
        '
        Me.CheckEng.Location = New System.Drawing.Point(422, 383)
        Me.CheckEng.Name = "CheckEng"
        Me.CheckEng.Properties.Caption = "Print Default"
        Me.CheckEng.Size = New System.Drawing.Size(117, 19)
        Me.CheckEng.TabIndex = 82
        '
        'PictureEdit2
        '
        Me.PictureEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit2.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit2.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit2.Location = New System.Drawing.Point(939, 377)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Size = New System.Drawing.Size(96, 37)
        Me.PictureEdit2.TabIndex = 25
        '
        'btnViewDep
        '
        Me.btnViewDep.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDep.Appearance.Options.UseFont = True
        Me.btnViewDep.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnViewDep.Location = New System.Drawing.Point(203, 13)
        Me.btnViewDep.Name = "btnViewDep"
        Me.btnViewDep.Size = New System.Drawing.Size(115, 23)
        Me.btnViewDep.TabIndex = 69
        Me.btnViewDep.Text = "View Departures"
        '
        'gcDep
        '
        Me.gcDep.Location = New System.Drawing.Point(22, 53)
        Me.gcDep.MainView = Me.gvDep
        Me.gcDep.Name = "gcDep"
        Me.gcDep.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.gcDep.Size = New System.Drawing.Size(1005, 128)
        Me.gcDep.TabIndex = 32
        Me.gcDep.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDep})
        '
        'gvDep
        '
        Me.gvDep.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvDep.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvDep.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvDep.Appearance.Row.Options.UseFont = True
        Me.gvDep.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRoom, Me.colReservationNo, Me.colDepdate, Me.colDepTime, Me.colDepFlight, Me.coldepsourse, Me.colDepGuest, Me.colcountry, Me.Depcolcheck})
        Me.gvDep.GridControl = Me.gcDep
        Me.gvDep.Name = "gvDep"
        Me.gvDep.OptionsView.ShowGroupPanel = False
        '
        'colRoom
        '
        Me.colRoom.Caption = "Roomno"
        Me.colRoom.FieldName = "Roomno"
        Me.colRoom.Name = "colRoom"
        Me.colRoom.Visible = True
        Me.colRoom.VisibleIndex = 0
        Me.colRoom.Width = 80
        '
        'colReservationNo
        '
        Me.colReservationNo.Caption = "ReservationNo"
        Me.colReservationNo.FieldName = "Reservation No"
        Me.colReservationNo.Name = "colReservationNo"
        Me.colReservationNo.Visible = True
        Me.colReservationNo.VisibleIndex = 1
        Me.colReservationNo.Width = 92
        '
        'colDepdate
        '
        Me.colDepdate.Caption = "Date"
        Me.colDepdate.FieldName = "DepDate"
        Me.colDepdate.Name = "colDepdate"
        Me.colDepdate.Visible = True
        Me.colDepdate.VisibleIndex = 2
        Me.colDepdate.Width = 80
        '
        'colDepTime
        '
        Me.colDepTime.Caption = "Flight Time"
        Me.colDepTime.FieldName = "DepTime"
        Me.colDepTime.Name = "colDepTime"
        Me.colDepTime.Visible = True
        Me.colDepTime.VisibleIndex = 3
        Me.colDepTime.Width = 90
        '
        'colDepFlight
        '
        Me.colDepFlight.Caption = "Flight No"
        Me.colDepFlight.FieldName = "DFlight"
        Me.colDepFlight.Name = "colDepFlight"
        Me.colDepFlight.Visible = True
        Me.colDepFlight.VisibleIndex = 4
        Me.colDepFlight.Width = 90
        '
        'coldepsourse
        '
        Me.coldepsourse.Caption = "Departure From"
        Me.coldepsourse.FieldName = "DepTo"
        Me.coldepsourse.Name = "coldepsourse"
        Me.coldepsourse.Visible = True
        Me.coldepsourse.VisibleIndex = 5
        Me.coldepsourse.Width = 90
        '
        'colDepGuest
        '
        Me.colDepGuest.Caption = "Guest"
        Me.colDepGuest.FieldName = "FullName"
        Me.colDepGuest.Name = "colDepGuest"
        Me.colDepGuest.Visible = True
        Me.colDepGuest.VisibleIndex = 6
        Me.colDepGuest.Width = 250
        '
        'colcountry
        '
        Me.colcountry.Caption = "Country"
        Me.colcountry.FieldName = "Country"
        Me.colcountry.Name = "colcountry"
        Me.colcountry.Visible = True
        Me.colcountry.VisibleIndex = 7
        Me.colcountry.Width = 92
        '
        'Depcolcheck
        '
        Me.Depcolcheck.Caption = "Select"
        Me.Depcolcheck.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.Depcolcheck.FieldName = "select"
        Me.Depcolcheck.Name = "Depcolcheck"
        Me.Depcolcheck.Visible = True
        Me.Depcolcheck.VisibleIndex = 8
        Me.Depcolcheck.Width = 112
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'dtDateDep
        '
        Me.dtDateDep.EditValue = Nothing
        Me.dtDateDep.Location = New System.Drawing.Point(68, 15)
        Me.dtDateDep.Name = "dtDateDep"
        Me.dtDateDep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDateDep.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDateDep.Size = New System.Drawing.Size(129, 20)
        Me.dtDateDep.TabIndex = 31
        '
        'LabelControl42
        '
        Me.LabelControl42.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl42.Location = New System.Drawing.Point(22, 18)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl42.TabIndex = 1
        Me.LabelControl42.Text = "Date"
        '
        'CbMR
        '
        Me.CbMR.AutoSize = True
        Me.CbMR.Location = New System.Drawing.Point(293, 325)
        Me.CbMR.Name = "CbMR"
        Me.CbMR.Size = New System.Drawing.Size(66, 17)
        Me.CbMR.TabIndex = 84
        Me.CbMR.Text = "Request"
        Me.CbMR.UseVisualStyleBackColor = True
        '
        'frmGuestreminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(1063, 459)
        Me.Controls.Add(Me.tabBoatSchedDetails)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmGuestreminder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest Reminder"
        CType(Me.TimeBillST.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBillSettlement.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBillSettlement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeHDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeFinalBill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeMealS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeLCollection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeWakeup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeBillSF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabBoatSchedDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBoatSchedDetails.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.CheckEng.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateDep.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabBoatSchedDetails As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnViewDep As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcDep As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDep As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colReservationNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepFlight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepGuest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Depcolcheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents dtDateDep As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents TimeLCollection As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents TimeWakeup As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents TimeBillSF As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TimeBillST As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents dtBillSettlement As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TimeHDep As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents TimeFinalBill As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents TimeMealS As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents colRoom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldepsourse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckEng As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CbWake As System.Windows.Forms.CheckBox
    Friend WithEvents CbMR As System.Windows.Forms.CheckBox
End Class
