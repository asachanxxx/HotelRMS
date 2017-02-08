<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservation))
        Me.tabReservation = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.btViewTopRef = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTopReference = New DevExpress.XtraEditors.TextEdit()
        Me.gcReservation = New DevExpress.XtraGrid.GridControl()
        Me.GviewReservation = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcResno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcResdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcGuest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcResType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTopcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcArrDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDepDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btPendingApp = New DevExpress.XtraEditors.SimpleButton()
        Me.btViewAll = New DevExpress.XtraEditors.SimpleButton()
        Me.btView = New DevExpress.XtraEditors.SimpleButton()
        Me.DtViewdate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtNationality = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbCountry = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtGuesname = New DevExpress.XtraEditors.TextEdit()
        Me.DtToday = New DevExpress.XtraEditors.DateEdit()
        Me.DtResdate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReservationno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.gbOthers = New System.Windows.Forms.GroupBox()
        Me.txtRefno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBillinginst = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txtguestdislike = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtguestlike = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.gbpayment = New System.Windows.Forms.GroupBox()
        Me.txtPaymentStatus = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl()
        Me.DtExpiry = New DevExpress.XtraEditors.DateEdit()
        Me.cmbpaymode = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCCno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.gbPax = New System.Windows.Forms.GroupBox()
        Me.gbpax2 = New System.Windows.Forms.GroupBox()
        Me.btgetTopallDis = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbOffers = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtBednights = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbAmmenties = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbDisscounts = New DevExpress.XtraEditors.LookUpEdit()
        Me.btGetrate = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.gbPax1 = New System.Windows.Forms.GroupBox()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.totPaxrooms = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.btDelRoomcount = New DevExpress.XtraEditors.SimpleButton()
        Me.gcRoomcount = New DevExpress.XtraGrid.GridControl()
        Me.gcViewRoomCount = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btAddRoomcount = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbRoomtyp = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtRoomcount = New DevExpress.XtraEditors.TextEdit()
        Me.cmbRoom = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtcounttot = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbMealplan = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txtadultcount = New DevExpress.XtraEditors.TextEdit()
        Me.txtinfantcount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtchildcount = New DevExpress.XtraEditors.TextEdit()
        Me.gbArridep = New System.Windows.Forms.GroupBox()
        Me.cmbDepTransTime = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbArrTransTime = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDepyear = New DevExpress.XtraEditors.TextEdit()
        Me.txtDepDay = New DevExpress.XtraEditors.TextEdit()
        Me.txtDepMonth = New DevExpress.XtraEditors.TextEdit()
        Me.btGetFlightArr = New DevExpress.XtraEditors.SimpleButton()
        Me.txtArryear = New DevExpress.XtraEditors.TextEdit()
        Me.btGetFlights = New DevExpress.XtraEditors.SimpleButton()
        Me.txtArrDay = New DevExpress.XtraEditors.TextEdit()
        Me.txtDepTime = New DevExpress.XtraEditors.TextEdit()
        Me.txtArrMonth = New DevExpress.XtraEditors.TextEdit()
        Me.txtArrTime = New DevExpress.XtraEditors.TextEdit()
        Me.cmbDepType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbArrType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbDepTrans = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbArrTrans = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbDepFlight = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbArriFlight = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblDepFlight = New DevExpress.XtraEditors.LabelControl()
        Me.lblArrivalFlight = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOtherArr = New DevExpress.XtraEditors.TextEdit()
        Me.txtOtherDep = New DevExpress.XtraEditors.TextEdit()
        Me.gbBookingtype = New System.Windows.Forms.GroupBox()
        Me.cbTopcode = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.CbFit = New DevExpress.XtraEditors.CheckEdit()
        Me.CbTop = New DevExpress.XtraEditors.CheckEdit()
        Me.CbCompl = New DevExpress.XtraEditors.CheckEdit()
        Me.DtDep = New DevExpress.XtraEditors.DateEdit()
        Me.DtArrival = New DevExpress.XtraEditors.DateEdit()
        Me.btApprove = New DevExpress.XtraEditors.SimpleButton()
        Me.btDel = New DevExpress.XtraEditors.SimpleButton()
        Me.btEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.CachedReceiptDirect1 = New HRM_Pro.CachedReceiptDirect()
        Me.btprintres = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl62 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        CType(Me.tabReservation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabReservation.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtTopReference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcReservation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GviewReservation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtViewdate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtViewdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtNationality.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGuesname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtToday.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtToday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtResdate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtResdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReservationno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOthers.SuspendLayout()
        CType(Me.txtRefno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBillinginst.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtguestdislike.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtguestlike.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbpayment.SuspendLayout()
        CType(Me.txtPaymentStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtExpiry.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtExpiry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbpaymode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCCno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPax.SuspendLayout()
        Me.gbpax2.SuspendLayout()
        CType(Me.cmbOffers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBednights.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAmmenties.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDisscounts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPax1.SuspendLayout()
        CType(Me.totPaxrooms.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcRoomcount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcViewRoomCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRoomtyp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoomcount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRoom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcounttot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMealplan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtadultcount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtinfantcount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtchildcount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbArridep.SuspendLayout()
        CType(Me.cmbDepTransTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbArrTransTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepyear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArryear.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArrDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArrMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArrTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDepType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbArrType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDepTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbArrTrans.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDepFlight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbArriFlight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtherArr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtherDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBookingtype.SuspendLayout()
        CType(Me.cbTopcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbFit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbCompl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtDep.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtArrival.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtArrival.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabReservation
        '
        Me.tabReservation.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabReservation.AppearancePage.Header.Options.UseFont = True
        Me.tabReservation.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabReservation.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabReservation.Location = New System.Drawing.Point(12, 13)
        Me.tabReservation.Name = "tabReservation"
        Me.tabReservation.SelectedTabPage = Me.XtraTabPage1
        Me.tabReservation.Size = New System.Drawing.Size(833, 633)
        Me.tabReservation.TabIndex = 0
        Me.tabReservation.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.btViewTopRef)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl42)
        Me.XtraTabPage1.Controls.Add(Me.txtTopReference)
        Me.XtraTabPage1.Controls.Add(Me.gcReservation)
        Me.XtraTabPage1.Controls.Add(Me.btPendingApp)
        Me.XtraTabPage1.Controls.Add(Me.btViewAll)
        Me.XtraTabPage1.Controls.Add(Me.btView)
        Me.XtraTabPage1.Controls.Add(Me.DtViewdate)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(831, 608)
        Me.XtraTabPage1.Text = "Reservation Quick View"
        '
        'btViewTopRef
        '
        Me.btViewTopRef.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btViewTopRef.Appearance.Options.UseFont = True
        Me.btViewTopRef.Location = New System.Drawing.Point(750, 21)
        Me.btViewTopRef.Name = "btViewTopRef"
        Me.btViewTopRef.Size = New System.Drawing.Size(72, 23)
        Me.btViewTopRef.TabIndex = 10
        Me.btViewTopRef.Text = "View"
        '
        'LabelControl42
        '
        Me.LabelControl42.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl42.Location = New System.Drawing.Point(507, 25)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl42.TabIndex = 9
        Me.LabelControl42.Text = "TOP Reference No"
        '
        'txtTopReference
        '
        Me.txtTopReference.Location = New System.Drawing.Point(605, 22)
        Me.txtTopReference.Name = "txtTopReference"
        Me.txtTopReference.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopReference.Properties.Appearance.Options.UseFont = True
        Me.txtTopReference.Size = New System.Drawing.Size(140, 20)
        Me.txtTopReference.TabIndex = 8
        '
        'gcReservation
        '
        Me.gcReservation.Location = New System.Drawing.Point(18, 63)
        Me.gcReservation.MainView = Me.GviewReservation
        Me.gcReservation.Name = "gcReservation"
        Me.gcReservation.Size = New System.Drawing.Size(804, 537)
        Me.gcReservation.TabIndex = 0
        Me.gcReservation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GviewReservation})
        '
        'GviewReservation
        '
        Me.GviewReservation.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GviewReservation.Appearance.HeaderPanel.Options.UseFont = True
        Me.GviewReservation.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GviewReservation.Appearance.Row.Options.UseFont = True
        Me.GviewReservation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcResno, Me.gcResdate, Me.gcGuest, Me.gcResType, Me.gcTopcode, Me.gcArrDate, Me.gcDepDate})
        Me.GviewReservation.GridControl = Me.gcReservation
        Me.GviewReservation.Name = "GviewReservation"
        Me.GviewReservation.OptionsView.ShowGroupPanel = False
        '
        'gcResno
        '
        Me.gcResno.Caption = "No"
        Me.gcResno.FieldName = "ResNo"
        Me.gcResno.Name = "gcResno"
        Me.gcResno.Visible = True
        Me.gcResno.VisibleIndex = 0
        Me.gcResno.Width = 100
        '
        'gcResdate
        '
        Me.gcResdate.Caption = "Date"
        Me.gcResdate.FieldName = "ResDate"
        Me.gcResdate.MinWidth = 10
        Me.gcResdate.Name = "gcResdate"
        Me.gcResdate.Visible = True
        Me.gcResdate.VisibleIndex = 1
        Me.gcResdate.Width = 65
        '
        'gcGuest
        '
        Me.gcGuest.Caption = "Guest"
        Me.gcGuest.FieldName = "Guest"
        Me.gcGuest.Name = "gcGuest"
        Me.gcGuest.Visible = True
        Me.gcGuest.VisibleIndex = 2
        Me.gcGuest.Width = 276
        '
        'gcResType
        '
        Me.gcResType.Caption = "Type"
        Me.gcResType.FieldName = "ResType"
        Me.gcResType.Name = "gcResType"
        Me.gcResType.Visible = True
        Me.gcResType.VisibleIndex = 3
        Me.gcResType.Width = 56
        '
        'gcTopcode
        '
        Me.gcTopcode.Caption = "Operator"
        Me.gcTopcode.FieldName = "Topcode"
        Me.gcTopcode.Name = "gcTopcode"
        Me.gcTopcode.Visible = True
        Me.gcTopcode.VisibleIndex = 4
        Me.gcTopcode.Width = 56
        '
        'gcArrDate
        '
        Me.gcArrDate.Caption = "Arrival"
        Me.gcArrDate.FieldName = "ArrDate"
        Me.gcArrDate.Name = "gcArrDate"
        Me.gcArrDate.Visible = True
        Me.gcArrDate.VisibleIndex = 5
        Me.gcArrDate.Width = 106
        '
        'gcDepDate
        '
        Me.gcDepDate.Caption = "Departure"
        Me.gcDepDate.FieldName = "DepDate"
        Me.gcDepDate.Name = "gcDepDate"
        Me.gcDepDate.Visible = True
        Me.gcDepDate.VisibleIndex = 6
        Me.gcDepDate.Width = 116
        '
        'btPendingApp
        '
        Me.btPendingApp.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPendingApp.Appearance.Options.UseFont = True
        Me.btPendingApp.Location = New System.Drawing.Point(332, 19)
        Me.btPendingApp.Name = "btPendingApp"
        Me.btPendingApp.Size = New System.Drawing.Size(121, 23)
        Me.btPendingApp.TabIndex = 6
        Me.btPendingApp.Text = "Pending Approval"
        '
        'btViewAll
        '
        Me.btViewAll.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btViewAll.Appearance.Options.UseFont = True
        Me.btViewAll.Location = New System.Drawing.Point(249, 19)
        Me.btViewAll.Name = "btViewAll"
        Me.btViewAll.Size = New System.Drawing.Size(78, 23)
        Me.btViewAll.TabIndex = 5
        Me.btViewAll.Text = "View All"
        '
        'btView
        '
        Me.btView.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btView.Appearance.Options.UseFont = True
        Me.btView.Location = New System.Drawing.Point(156, 19)
        Me.btView.Name = "btView"
        Me.btView.Size = New System.Drawing.Size(88, 23)
        Me.btView.TabIndex = 4
        Me.btView.Text = "View By Date"
        '
        'DtViewdate
        '
        Me.DtViewdate.EditValue = Nothing
        Me.DtViewdate.Location = New System.Drawing.Point(49, 21)
        Me.DtViewdate.Name = "DtViewdate"
        Me.DtViewdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtViewdate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DtViewdate.Size = New System.Drawing.Size(100, 20)
        Me.DtViewdate.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(18, 21)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl4.TabIndex = 2
        Me.LabelControl4.Text = "Date"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.txtEmail)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl62)
        Me.XtraTabPage2.Controls.Add(Me.txtNationality)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl61)
        Me.XtraTabPage2.Controls.Add(Me.cmbCountry)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl60)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage2.Controls.Add(Me.lbl28)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Controls.Add(Me.txtGuesname)
        Me.XtraTabPage2.Controls.Add(Me.DtToday)
        Me.XtraTabPage2.Controls.Add(Me.DtResdate)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl31)
        Me.XtraTabPage2.Controls.Add(Me.txtReservationno)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl30)
        Me.XtraTabPage2.Controls.Add(Me.gbOthers)
        Me.XtraTabPage2.Controls.Add(Me.gbpayment)
        Me.XtraTabPage2.Controls.Add(Me.gbPax)
        Me.XtraTabPage2.Controls.Add(Me.gbArridep)
        Me.XtraTabPage2.Controls.Add(Me.gbBookingtype)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(831, 608)
        Me.XtraTabPage2.Text = "  New Reservation"
        '
        'txtNationality
        '
        Me.txtNationality.Location = New System.Drawing.Point(127, 79)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNationality.Properties.Appearance.ForeColor = System.Drawing.Color.DarkMagenta
        Me.txtNationality.Properties.Appearance.Options.UseFont = True
        Me.txtNationality.Properties.Appearance.Options.UseForeColor = True
        Me.txtNationality.Size = New System.Drawing.Size(192, 20)
        Me.txtNationality.TabIndex = 79
        '
        'LabelControl61
        '
        Me.LabelControl61.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl61.Location = New System.Drawing.Point(11, 83)
        Me.LabelControl61.Name = "LabelControl61"
        Me.LabelControl61.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl61.TabIndex = 78
        Me.LabelControl61.Text = "Nationality"
        '
        'cmbCountry
        '
        Me.cmbCountry.Location = New System.Drawing.Point(127, 55)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCountry.Properties.Appearance.ForeColor = System.Drawing.Color.DarkMagenta
        Me.cmbCountry.Properties.Appearance.Options.UseFont = True
        Me.cmbCountry.Properties.Appearance.Options.UseForeColor = True
        Me.cmbCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCountry.Properties.Items.AddRange(New Object() {"", "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas, The", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei ", "Bulgaria", "Burkina Faso", "Burma", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros ", "Congo, Democratic Republic of the", "Congo, Republic of the ", "Costa Rica", "Cote d'Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (see Timor-Leste)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia, The", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Holy See", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Namibia", "Nauru", "Nepal", "Netherlands", "Netherlands Antilles", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Korea", "Norway", "Oman", "Pakistan", "Palau", "Palestinian Territories", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Korea", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United States of America", "United Kingdom", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"})
        Me.cmbCountry.Size = New System.Drawing.Size(190, 20)
        Me.cmbCountry.TabIndex = 77
        '
        'LabelControl60
        '
        Me.LabelControl60.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl60.Location = New System.Drawing.Point(11, 58)
        Me.LabelControl60.Name = "LabelControl60"
        Me.LabelControl60.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl60.TabIndex = 76
        Me.LabelControl60.Text = "Country Of Residence"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl8.Location = New System.Drawing.Point(819, 32)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl8.TabIndex = 75
        Me.LabelControl8.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(302, 10)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 74
        Me.lbl28.Text = "*"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(10, 34)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl10.TabIndex = 73
        Me.LabelControl10.Text = "Guest Names"
        '
        'txtGuesname
        '
        Me.txtGuesname.Location = New System.Drawing.Point(127, 31)
        Me.txtGuesname.Name = "txtGuesname"
        Me.txtGuesname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuesname.Properties.Appearance.Options.UseFont = True
        Me.txtGuesname.Size = New System.Drawing.Size(690, 20)
        Me.txtGuesname.TabIndex = 2
        '
        'DtToday
        '
        Me.DtToday.EditValue = Nothing
        Me.DtToday.Enabled = False
        Me.DtToday.Location = New System.Drawing.Point(630, 7)
        Me.DtToday.Name = "DtToday"
        Me.DtToday.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtToday.Properties.Appearance.Options.UseFont = True
        Me.DtToday.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtToday.Properties.ReadOnly = True
        Me.DtToday.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DtToday.Size = New System.Drawing.Size(189, 20)
        Me.DtToday.TabIndex = 71
        '
        'DtResdate
        '
        Me.DtResdate.EditValue = Nothing
        Me.DtResdate.Location = New System.Drawing.Point(435, 7)
        Me.DtResdate.Name = "DtResdate"
        Me.DtResdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtResdate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DtResdate.Size = New System.Drawing.Size(117, 20)
        Me.DtResdate.TabIndex = 0
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl31.Location = New System.Drawing.Point(342, 10)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl31.TabIndex = 69
        Me.LabelControl31.Text = "Reservation Date"
        '
        'txtReservationno
        '
        Me.txtReservationno.Enabled = False
        Me.txtReservationno.EnterMoveNextControl = True
        Me.txtReservationno.Location = New System.Drawing.Point(127, 7)
        Me.txtReservationno.Name = "txtReservationno"
        Me.txtReservationno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReservationno.Properties.Appearance.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtReservationno.Properties.Appearance.Options.UseFont = True
        Me.txtReservationno.Properties.Appearance.Options.UseForeColor = True
        Me.txtReservationno.Size = New System.Drawing.Size(169, 20)
        Me.txtReservationno.TabIndex = 1
        '
        'LabelControl30
        '
        Me.LabelControl30.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl30.Location = New System.Drawing.Point(10, 10)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl30.TabIndex = 2
        Me.LabelControl30.Text = "Reservation No"
        '
        'gbOthers
        '
        Me.gbOthers.Controls.Add(Me.txtRefno)
        Me.gbOthers.Controls.Add(Me.LabelControl38)
        Me.gbOthers.Controls.Add(Me.txtRemarks)
        Me.gbOthers.Controls.Add(Me.LabelControl7)
        Me.gbOthers.Controls.Add(Me.txtBillinginst)
        Me.gbOthers.Controls.Add(Me.LabelControl25)
        Me.gbOthers.Controls.Add(Me.txtguestdislike)
        Me.gbOthers.Controls.Add(Me.LabelControl23)
        Me.gbOthers.Controls.Add(Me.txtguestlike)
        Me.gbOthers.Controls.Add(Me.LabelControl27)
        Me.gbOthers.Enabled = False
        Me.gbOthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbOthers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOthers.Location = New System.Drawing.Point(352, 481)
        Me.gbOthers.Name = "gbOthers"
        Me.gbOthers.Size = New System.Drawing.Size(469, 124)
        Me.gbOthers.TabIndex = 66
        Me.gbOthers.TabStop = False
        Me.gbOthers.Text = "Other Details"
        '
        'txtRefno
        '
        Me.txtRefno.Location = New System.Drawing.Point(105, 94)
        Me.txtRefno.Name = "txtRefno"
        Me.txtRefno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefno.Properties.Appearance.Options.UseFont = True
        Me.txtRefno.Size = New System.Drawing.Size(358, 20)
        Me.txtRefno.TabIndex = 62
        '
        'LabelControl38
        '
        Me.LabelControl38.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl38.Location = New System.Drawing.Point(11, 99)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl38.TabIndex = 61
        Me.LabelControl38.Text = "Ref No"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(106, 69)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Size = New System.Drawing.Size(358, 20)
        Me.txtRemarks.TabIndex = 3
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(11, 74)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl7.TabIndex = 60
        Me.LabelControl7.Text = "Remarks"
        '
        'txtBillinginst
        '
        Me.txtBillinginst.Location = New System.Drawing.Point(106, 43)
        Me.txtBillinginst.Name = "txtBillinginst"
        Me.txtBillinginst.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillinginst.Properties.Appearance.Options.UseFont = True
        Me.txtBillinginst.Size = New System.Drawing.Size(358, 20)
        Me.txtBillinginst.TabIndex = 2
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl25.Location = New System.Drawing.Point(11, 47)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl25.TabIndex = 58
        Me.LabelControl25.Text = "Billing Instruction"
        '
        'txtguestdislike
        '
        Me.txtguestdislike.Location = New System.Drawing.Point(325, 17)
        Me.txtguestdislike.Name = "txtguestdislike"
        Me.txtguestdislike.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtguestdislike.Properties.Appearance.Options.UseFont = True
        Me.txtguestdislike.Size = New System.Drawing.Size(140, 20)
        Me.txtguestdislike.TabIndex = 1
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl23.Location = New System.Drawing.Point(280, 20)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl23.TabIndex = 56
        Me.LabelControl23.Text = "Dislikes"
        '
        'txtguestlike
        '
        Me.txtguestlike.Location = New System.Drawing.Point(107, 17)
        Me.txtguestlike.Name = "txtguestlike"
        Me.txtguestlike.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtguestlike.Properties.Appearance.Options.UseFont = True
        Me.txtguestlike.Size = New System.Drawing.Size(140, 20)
        Me.txtguestlike.TabIndex = 0
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl27.Location = New System.Drawing.Point(10, 20)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl27.TabIndex = 2
        Me.LabelControl27.Text = "Guest Likes"
        '
        'gbpayment
        '
        Me.gbpayment.Controls.Add(Me.txtPaymentStatus)
        Me.gbpayment.Controls.Add(Me.LabelControl59)
        Me.gbpayment.Controls.Add(Me.DtExpiry)
        Me.gbpayment.Controls.Add(Me.cmbpaymode)
        Me.gbpayment.Controls.Add(Me.LabelControl24)
        Me.gbpayment.Controls.Add(Me.txtCCno)
        Me.gbpayment.Controls.Add(Me.LabelControl26)
        Me.gbpayment.Controls.Add(Me.LabelControl28)
        Me.gbpayment.Enabled = False
        Me.gbpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbpayment.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbpayment.Location = New System.Drawing.Point(7, 480)
        Me.gbpayment.Name = "gbpayment"
        Me.gbpayment.Size = New System.Drawing.Size(339, 121)
        Me.gbpayment.TabIndex = 65
        Me.gbpayment.TabStop = False
        Me.gbpayment.Text = "Payment Details"
        '
        'txtPaymentStatus
        '
        Me.txtPaymentStatus.Location = New System.Drawing.Point(114, 95)
        Me.txtPaymentStatus.Name = "txtPaymentStatus"
        Me.txtPaymentStatus.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentStatus.Properties.Appearance.Options.UseFont = True
        Me.txtPaymentStatus.Properties.ReadOnly = True
        Me.txtPaymentStatus.Size = New System.Drawing.Size(219, 20)
        Me.txtPaymentStatus.TabIndex = 58
        '
        'LabelControl59
        '
        Me.LabelControl59.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl59.Location = New System.Drawing.Point(6, 98)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl59.TabIndex = 57
        Me.LabelControl59.Text = "Payment Status"
        '
        'DtExpiry
        '
        Me.DtExpiry.EditValue = Nothing
        Me.DtExpiry.Location = New System.Drawing.Point(114, 44)
        Me.DtExpiry.Name = "DtExpiry"
        Me.DtExpiry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtExpiry.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DtExpiry.Size = New System.Drawing.Size(139, 20)
        Me.DtExpiry.TabIndex = 1
        '
        'cmbpaymode
        '
        Me.cmbpaymode.Location = New System.Drawing.Point(114, 18)
        Me.cmbpaymode.Name = "cmbpaymode"
        Me.cmbpaymode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbpaymode.Properties.Items.AddRange(New Object() {"Cash", "Cheque", "Creditcard"})
        Me.cmbpaymode.Size = New System.Drawing.Size(139, 20)
        Me.cmbpaymode.TabIndex = 0
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl24.Location = New System.Drawing.Point(9, 46)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl24.TabIndex = 56
        Me.LabelControl24.Text = "Expiry Date"
        '
        'txtCCno
        '
        Me.txtCCno.Location = New System.Drawing.Point(114, 71)
        Me.txtCCno.Name = "txtCCno"
        Me.txtCCno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCCno.Properties.Appearance.Options.UseFont = True
        Me.txtCCno.Size = New System.Drawing.Size(139, 20)
        Me.txtCCno.TabIndex = 2
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl26.Location = New System.Drawing.Point(6, 74)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl26.TabIndex = 52
        Me.LabelControl26.Text = "Credit Card No"
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl28.Location = New System.Drawing.Point(9, 21)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl28.TabIndex = 2
        Me.LabelControl28.Text = "Mode Of Payments"
        '
        'gbPax
        '
        Me.gbPax.Controls.Add(Me.gbpax2)
        Me.gbPax.Controls.Add(Me.gbPax1)
        Me.gbPax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbPax.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPax.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gbPax.Location = New System.Drawing.Point(3, 251)
        Me.gbPax.Name = "gbPax"
        Me.gbPax.Size = New System.Drawing.Size(818, 224)
        Me.gbPax.TabIndex = 64
        Me.gbPax.TabStop = False
        Me.gbPax.Text = "Pax Details"
        '
        'gbpax2
        '
        Me.gbpax2.Controls.Add(Me.btgetTopallDis)
        Me.gbpax2.Controls.Add(Me.cmbOffers)
        Me.gbpax2.Controls.Add(Me.txtBednights)
        Me.gbpax2.Controls.Add(Me.LabelControl35)
        Me.gbpax2.Controls.Add(Me.LabelControl5)
        Me.gbpax2.Controls.Add(Me.LabelControl32)
        Me.gbpax2.Controls.Add(Me.LabelControl12)
        Me.gbpax2.Controls.Add(Me.cmbAmmenties)
        Me.gbpax2.Controls.Add(Me.cmbDisscounts)
        Me.gbpax2.Controls.Add(Me.btGetrate)
        Me.gbpax2.Controls.Add(Me.txtTotal)
        Me.gbpax2.Controls.Add(Me.LabelControl1)
        Me.gbpax2.Controls.Add(Me.LabelControl22)
        Me.gbpax2.Controls.Add(Me.txtRate)
        Me.gbpax2.Controls.Add(Me.LabelControl21)
        Me.gbpax2.Controls.Add(Me.LabelControl20)
        Me.gbpax2.Location = New System.Drawing.Point(417, 8)
        Me.gbpax2.Name = "gbpax2"
        Me.gbpax2.Size = New System.Drawing.Size(395, 210)
        Me.gbpax2.TabIndex = 79
        Me.gbpax2.TabStop = False
        '
        'btgetTopallDis
        '
        Me.btgetTopallDis.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btgetTopallDis.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btgetTopallDis.Appearance.Options.UseFont = True
        Me.btgetTopallDis.Appearance.Options.UseForeColor = True
        Me.btgetTopallDis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btgetTopallDis.Location = New System.Drawing.Point(203, 72)
        Me.btgetTopallDis.Name = "btgetTopallDis"
        Me.btgetTopallDis.Size = New System.Drawing.Size(81, 23)
        Me.btgetTopallDis.TabIndex = 100
        Me.btgetTopallDis.Text = "ALL TOP DIS"
        '
        'cmbOffers
        '
        Me.cmbOffers.Location = New System.Drawing.Point(291, 110)
        Me.cmbOffers.Name = "cmbOffers"
        Me.cmbOffers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOffers.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OfferID", 5, "Offer ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OfferName", 12, "Offer Name")})
        Me.cmbOffers.Properties.NullText = ""
        Me.cmbOffers.Size = New System.Drawing.Size(99, 20)
        Me.cmbOffers.TabIndex = 99
        Me.cmbOffers.Visible = False
        '
        'txtBednights
        '
        Me.txtBednights.EditValue = ""
        Me.txtBednights.Location = New System.Drawing.Point(95, 14)
        Me.txtBednights.Name = "txtBednights"
        Me.txtBednights.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBednights.Properties.Appearance.Options.UseFont = True
        Me.txtBednights.Size = New System.Drawing.Size(98, 20)
        Me.txtBednights.TabIndex = 89
        '
        'LabelControl35
        '
        Me.LabelControl35.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl35.Location = New System.Drawing.Point(320, 136)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl35.TabIndex = 98
        Me.LabelControl35.Text = "Offers & Comp"
        Me.LabelControl35.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(16, 17)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl5.TabIndex = 88
        Me.LabelControl5.Text = "Bed Nights"
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl32.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl32.Location = New System.Drawing.Point(236, 149)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl32.TabIndex = 97
        Me.LabelControl32.Text = "*"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl12.Location = New System.Drawing.Point(236, 47)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl12.TabIndex = 96
        Me.LabelControl12.Text = "*"
        '
        'cmbAmmenties
        '
        Me.cmbAmmenties.Location = New System.Drawing.Point(95, 110)
        Me.cmbAmmenties.Name = "cmbAmmenties"
        Me.cmbAmmenties.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAmmenties.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AmentitiesID", 7, "Amentities ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AmentitiesName", "Amentities")})
        Me.cmbAmmenties.Properties.NullText = ""
        Me.cmbAmmenties.Size = New System.Drawing.Size(185, 20)
        Me.cmbAmmenties.TabIndex = 94
        '
        'cmbDisscounts
        '
        Me.cmbDisscounts.Location = New System.Drawing.Point(95, 74)
        Me.cmbDisscounts.Name = "cmbDisscounts"
        Me.cmbDisscounts.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDisscounts.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisID", 5, "Discount Id"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisPlan", 12, "Discount Plan"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisAmt", 5, "%")})
        Me.cmbDisscounts.Properties.NullText = ""
        Me.cmbDisscounts.Size = New System.Drawing.Size(98, 20)
        Me.cmbDisscounts.TabIndex = 93
        '
        'btGetrate
        '
        Me.btGetrate.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGetrate.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btGetrate.Appearance.Options.UseFont = True
        Me.btGetrate.Appearance.Options.UseForeColor = True
        Me.btGetrate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btGetrate.Location = New System.Drawing.Point(249, 42)
        Me.btGetrate.Name = "btGetrate"
        Me.btGetrate.Size = New System.Drawing.Size(81, 23)
        Me.btGetrate.TabIndex = 92
        Me.btGetrate.Text = "Get Rate"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(95, 145)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(139, 20)
        Me.txtTotal.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(16, 149)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl1.TabIndex = 91
        Me.LabelControl1.Text = "Total"
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Location = New System.Drawing.Point(15, 113)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl22.TabIndex = 88
        Me.LabelControl22.Text = "Ammentities"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(96, 43)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Properties.Appearance.Options.UseFont = True
        Me.txtRate.Size = New System.Drawing.Size(139, 20)
        Me.txtRate.TabIndex = 4
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Location = New System.Drawing.Point(16, 48)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl21.TabIndex = 86
        Me.LabelControl21.Text = "Rate"
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl20.Location = New System.Drawing.Point(16, 77)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl20.TabIndex = 84
        Me.LabelControl20.Text = "Discount Plan"
        '
        'gbPax1
        '
        Me.gbPax1.Controls.Add(Me.LabelControl41)
        Me.gbPax1.Controls.Add(Me.LabelControl29)
        Me.gbPax1.Controls.Add(Me.totPaxrooms)
        Me.gbPax1.Controls.Add(Me.LabelControl6)
        Me.gbPax1.Controls.Add(Me.LabelControl9)
        Me.gbPax1.Controls.Add(Me.btDelRoomcount)
        Me.gbPax1.Controls.Add(Me.gcRoomcount)
        Me.gbPax1.Controls.Add(Me.btAddRoomcount)
        Me.gbPax1.Controls.Add(Me.cmbRoomtyp)
        Me.gbPax1.Controls.Add(Me.txtRoomcount)
        Me.gbPax1.Controls.Add(Me.cmbRoom)
        Me.gbPax1.Controls.Add(Me.LabelControl16)
        Me.gbPax1.Controls.Add(Me.LabelControl17)
        Me.gbPax1.Controls.Add(Me.txtcounttot)
        Me.gbPax1.Controls.Add(Me.LabelControl18)
        Me.gbPax1.Controls.Add(Me.LabelControl14)
        Me.gbPax1.Controls.Add(Me.cmbMealplan)
        Me.gbPax1.Controls.Add(Me.LabelControl19)
        Me.gbPax1.Controls.Add(Me.txtadultcount)
        Me.gbPax1.Controls.Add(Me.txtinfantcount)
        Me.gbPax1.Controls.Add(Me.LabelControl13)
        Me.gbPax1.Controls.Add(Me.LabelControl15)
        Me.gbPax1.Controls.Add(Me.txtchildcount)
        Me.gbPax1.Location = New System.Drawing.Point(4, 8)
        Me.gbPax1.Name = "gbPax1"
        Me.gbPax1.Size = New System.Drawing.Size(407, 210)
        Me.gbPax1.TabIndex = 78
        Me.gbPax1.TabStop = False
        '
        'LabelControl41
        '
        Me.LabelControl41.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl41.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl41.Location = New System.Drawing.Point(304, 95)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl41.TabIndex = 100
        Me.LabelControl41.Text = "*"
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl29.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl29.Location = New System.Drawing.Point(393, 59)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl29.TabIndex = 99
        Me.LabelControl29.Text = "*"
        '
        'totPaxrooms
        '
        Me.totPaxrooms.Location = New System.Drawing.Point(345, 58)
        Me.totPaxrooms.Name = "totPaxrooms"
        Me.totPaxrooms.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totPaxrooms.Properties.Appearance.Options.UseFont = True
        Me.totPaxrooms.Size = New System.Drawing.Size(43, 22)
        Me.totPaxrooms.TabIndex = 98
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(213, 62)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(130, 13)
        Me.LabelControl6.TabIndex = 97
        Me.LabelControl6.Text = "TotPax Count For Rooms"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Location = New System.Drawing.Point(394, 17)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl9.TabIndex = 96
        Me.LabelControl9.Text = "*"
        '
        'btDelRoomcount
        '
        Me.btDelRoomcount.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDelRoomcount.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btDelRoomcount.Appearance.Options.UseFont = True
        Me.btDelRoomcount.Appearance.Options.UseForeColor = True
        Me.btDelRoomcount.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btDelRoomcount.Location = New System.Drawing.Point(358, 90)
        Me.btDelRoomcount.Name = "btDelRoomcount"
        Me.btDelRoomcount.Size = New System.Drawing.Size(34, 23)
        Me.btDelRoomcount.TabIndex = 87
        Me.btDelRoomcount.Text = "^"
        '
        'gcRoomcount
        '
        Me.gcRoomcount.AllowDrop = True
        Me.gcRoomcount.Location = New System.Drawing.Point(6, 119)
        Me.gcRoomcount.MainView = Me.gcViewRoomCount
        Me.gcRoomcount.Name = "gcRoomcount"
        Me.gcRoomcount.Size = New System.Drawing.Size(386, 85)
        Me.gcRoomcount.TabIndex = 86
        Me.gcRoomcount.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gcViewRoomCount})
        '
        'gcViewRoomCount
        '
        Me.gcViewRoomCount.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcViewRoomCount.Appearance.HeaderPanel.Options.UseFont = True
        Me.gcViewRoomCount.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcViewRoomCount.Appearance.Row.Options.UseFont = True
        Me.gcViewRoomCount.GridControl = Me.gcRoomcount
        Me.gcViewRoomCount.Name = "gcViewRoomCount"
        Me.gcViewRoomCount.OptionsView.ShowGroupPanel = False
        '
        'btAddRoomcount
        '
        Me.btAddRoomcount.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddRoomcount.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btAddRoomcount.Appearance.Options.UseFont = True
        Me.btAddRoomcount.Appearance.Options.UseForeColor = True
        Me.btAddRoomcount.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btAddRoomcount.Location = New System.Drawing.Point(322, 89)
        Me.btAddRoomcount.Name = "btAddRoomcount"
        Me.btAddRoomcount.Size = New System.Drawing.Size(31, 23)
        Me.btAddRoomcount.TabIndex = 3
        Me.btAddRoomcount.Text = " V"
        '
        'cmbRoomtyp
        '
        Me.cmbRoomtyp.Location = New System.Drawing.Point(69, 91)
        Me.cmbRoomtyp.Name = "cmbRoomtyp"
        Me.cmbRoomtyp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRoomtyp.Properties.Items.AddRange(New Object() {"Single", "Double", "Triple"})
        Me.cmbRoomtyp.Size = New System.Drawing.Size(83, 20)
        Me.cmbRoomtyp.TabIndex = 1
        '
        'txtRoomcount
        '
        Me.txtRoomcount.Location = New System.Drawing.Point(224, 91)
        Me.txtRoomcount.Name = "txtRoomcount"
        Me.txtRoomcount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomcount.Properties.Appearance.Options.UseFont = True
        Me.txtRoomcount.Size = New System.Drawing.Size(74, 20)
        Me.txtRoomcount.TabIndex = 2
        '
        'cmbRoom
        '
        Me.cmbRoom.Location = New System.Drawing.Point(69, 65)
        Me.cmbRoom.Name = "cmbRoom"
        Me.cmbRoom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRoom.Properties.Items.AddRange(New Object() {"Standard", "Superior", "Deluxe"})
        Me.cmbRoom.Size = New System.Drawing.Size(83, 20)
        Me.cmbRoom.TabIndex = 0
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Location = New System.Drawing.Point(9, 93)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl16.TabIndex = 80
        Me.LabelControl16.Text = "Room Type"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Location = New System.Drawing.Point(170, 94)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl17.TabIndex = 79
        Me.LabelControl17.Text = "Room Qty"
        '
        'txtcounttot
        '
        Me.txtcounttot.Location = New System.Drawing.Point(345, 13)
        Me.txtcounttot.Name = "txtcounttot"
        Me.txtcounttot.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcounttot.Properties.Appearance.Options.UseFont = True
        Me.txtcounttot.Properties.ReadOnly = True
        Me.txtcounttot.Size = New System.Drawing.Size(43, 22)
        Me.txtcounttot.TabIndex = 2
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Location = New System.Drawing.Point(9, 67)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl18.TabIndex = 78
        Me.LabelControl18.Text = "Room "
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Location = New System.Drawing.Point(6, 17)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl14.TabIndex = 76
        Me.LabelControl14.Text = "Adults"
        '
        'cmbMealplan
        '
        Me.cmbMealplan.Location = New System.Drawing.Point(69, 40)
        Me.cmbMealplan.Name = "cmbMealplan"
        Me.cmbMealplan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMealplan.Size = New System.Drawing.Size(48, 20)
        Me.cmbMealplan.TabIndex = 3
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Location = New System.Drawing.Point(6, 42)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl19.TabIndex = 82
        Me.LabelControl19.Text = "Meal Plan"
        '
        'txtadultcount
        '
        Me.txtadultcount.EditValue = ""
        Me.txtadultcount.Location = New System.Drawing.Point(69, 14)
        Me.txtadultcount.Name = "txtadultcount"
        Me.txtadultcount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadultcount.Properties.Appearance.Options.UseFont = True
        Me.txtadultcount.Size = New System.Drawing.Size(36, 20)
        Me.txtadultcount.TabIndex = 77
        '
        'txtinfantcount
        '
        Me.txtinfantcount.EditValue = ""
        Me.txtinfantcount.Location = New System.Drawing.Point(269, 13)
        Me.txtinfantcount.Name = "txtinfantcount"
        Me.txtinfantcount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinfantcount.Properties.Appearance.Options.UseFont = True
        Me.txtinfantcount.Size = New System.Drawing.Size(43, 20)
        Me.txtinfantcount.TabIndex = 81
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(120, 17)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl13.TabIndex = 0
        Me.LabelControl13.Text = "Children"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Location = New System.Drawing.Point(227, 17)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl15.TabIndex = 1
        Me.LabelControl15.Text = "Infants"
        '
        'txtchildcount
        '
        Me.txtchildcount.EditValue = ""
        Me.txtchildcount.Location = New System.Drawing.Point(170, 14)
        Me.txtchildcount.Name = "txtchildcount"
        Me.txtchildcount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchildcount.Properties.Appearance.Options.UseFont = True
        Me.txtchildcount.Size = New System.Drawing.Size(41, 20)
        Me.txtchildcount.TabIndex = 79
        '
        'gbArridep
        '
        Me.gbArridep.Controls.Add(Me.cmbDepTransTime)
        Me.gbArridep.Controls.Add(Me.cmbArrTransTime)
        Me.gbArridep.Controls.Add(Me.LabelControl51)
        Me.gbArridep.Controls.Add(Me.LabelControl52)
        Me.gbArridep.Controls.Add(Me.LabelControl53)
        Me.gbArridep.Controls.Add(Me.LabelControl54)
        Me.gbArridep.Controls.Add(Me.LabelControl55)
        Me.gbArridep.Controls.Add(Me.LabelControl56)
        Me.gbArridep.Controls.Add(Me.LabelControl57)
        Me.gbArridep.Controls.Add(Me.LabelControl58)
        Me.gbArridep.Controls.Add(Me.LabelControl50)
        Me.gbArridep.Controls.Add(Me.LabelControl49)
        Me.gbArridep.Controls.Add(Me.LabelControl48)
        Me.gbArridep.Controls.Add(Me.LabelControl47)
        Me.gbArridep.Controls.Add(Me.LabelControl46)
        Me.gbArridep.Controls.Add(Me.LabelControl45)
        Me.gbArridep.Controls.Add(Me.LabelControl44)
        Me.gbArridep.Controls.Add(Me.LabelControl43)
        Me.gbArridep.Controls.Add(Me.txtDepyear)
        Me.gbArridep.Controls.Add(Me.txtDepDay)
        Me.gbArridep.Controls.Add(Me.txtDepMonth)
        Me.gbArridep.Controls.Add(Me.btGetFlightArr)
        Me.gbArridep.Controls.Add(Me.txtArryear)
        Me.gbArridep.Controls.Add(Me.btGetFlights)
        Me.gbArridep.Controls.Add(Me.txtArrDay)
        Me.gbArridep.Controls.Add(Me.txtDepTime)
        Me.gbArridep.Controls.Add(Me.txtArrMonth)
        Me.gbArridep.Controls.Add(Me.txtArrTime)
        Me.gbArridep.Controls.Add(Me.cmbDepType)
        Me.gbArridep.Controls.Add(Me.LabelControl40)
        Me.gbArridep.Controls.Add(Me.cmbArrType)
        Me.gbArridep.Controls.Add(Me.LabelControl39)
        Me.gbArridep.Controls.Add(Me.cmbDepTrans)
        Me.gbArridep.Controls.Add(Me.LabelControl37)
        Me.gbArridep.Controls.Add(Me.cmbArrTrans)
        Me.gbArridep.Controls.Add(Me.LabelControl36)
        Me.gbArridep.Controls.Add(Me.LabelControl34)
        Me.gbArridep.Controls.Add(Me.LabelControl33)
        Me.gbArridep.Controls.Add(Me.cmbDepFlight)
        Me.gbArridep.Controls.Add(Me.cmbArriFlight)
        Me.gbArridep.Controls.Add(Me.lblDepFlight)
        Me.gbArridep.Controls.Add(Me.lblArrivalFlight)
        Me.gbArridep.Controls.Add(Me.LabelControl3)
        Me.gbArridep.Controls.Add(Me.LabelControl2)
        Me.gbArridep.Controls.Add(Me.txtOtherArr)
        Me.gbArridep.Controls.Add(Me.txtOtherDep)
        Me.gbArridep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbArridep.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbArridep.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gbArridep.Location = New System.Drawing.Point(327, 65)
        Me.gbArridep.Name = "gbArridep"
        Me.gbArridep.Size = New System.Drawing.Size(492, 182)
        Me.gbArridep.TabIndex = 63
        Me.gbArridep.TabStop = False
        Me.gbArridep.Text = "Arrival/Departure"
        '
        'cmbDepTransTime
        '
        Me.cmbDepTransTime.Location = New System.Drawing.Point(403, 157)
        Me.cmbDepTransTime.Name = "cmbDepTransTime"
        Me.cmbDepTransTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDepTransTime.Properties.Items.AddRange(New Object() {"DAY", "NIGHT"})
        Me.cmbDepTransTime.Size = New System.Drawing.Size(82, 20)
        Me.cmbDepTransTime.TabIndex = 118
        '
        'cmbArrTransTime
        '
        Me.cmbArrTransTime.Location = New System.Drawing.Point(147, 157)
        Me.cmbArrTransTime.Name = "cmbArrTransTime"
        Me.cmbArrTransTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbArrTransTime.Properties.Items.AddRange(New Object() {"DAY", "NIGHT"})
        Me.cmbArrTransTime.Size = New System.Drawing.Size(78, 20)
        Me.cmbArrTransTime.TabIndex = 117
        '
        'LabelControl51
        '
        Me.LabelControl51.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl51.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl51.Location = New System.Drawing.Point(414, 58)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(7, 12)
        Me.LabelControl51.TabIndex = 116
        Me.LabelControl51.Text = "Y"
        '
        'LabelControl52
        '
        Me.LabelControl52.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl52.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl52.Location = New System.Drawing.Point(404, 58)
        Me.LabelControl52.Name = "LabelControl52"
        Me.LabelControl52.Size = New System.Drawing.Size(7, 12)
        Me.LabelControl52.TabIndex = 115
        Me.LabelControl52.Text = "Y"
        '
        'LabelControl53
        '
        Me.LabelControl53.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl53.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl53.Location = New System.Drawing.Point(396, 58)
        Me.LabelControl53.Name = "LabelControl53"
        Me.LabelControl53.Size = New System.Drawing.Size(7, 12)
        Me.LabelControl53.TabIndex = 114
        Me.LabelControl53.Text = "Y"
        '
        'LabelControl54
        '
        Me.LabelControl54.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl54.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl54.Location = New System.Drawing.Point(388, 58)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(7, 12)
        Me.LabelControl54.TabIndex = 113
        Me.LabelControl54.Text = "Y"
        '
        'LabelControl55
        '
        Me.LabelControl55.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl55.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl55.Location = New System.Drawing.Point(319, 57)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(7, 12)
        Me.LabelControl55.TabIndex = 112
        Me.LabelControl55.Text = "D"
        '
        'LabelControl56
        '
        Me.LabelControl56.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl56.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl56.Location = New System.Drawing.Point(312, 57)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(7, 12)
        Me.LabelControl56.TabIndex = 111
        Me.LabelControl56.Text = "D"
        '
        'LabelControl57
        '
        Me.LabelControl57.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl57.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl57.Location = New System.Drawing.Point(358, 57)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(8, 12)
        Me.LabelControl57.TabIndex = 110
        Me.LabelControl57.Text = "M"
        '
        'LabelControl58
        '
        Me.LabelControl58.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl58.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl58.Location = New System.Drawing.Point(350, 57)
        Me.LabelControl58.Name = "LabelControl58"
        Me.LabelControl58.Size = New System.Drawing.Size(8, 12)
        Me.LabelControl58.TabIndex = 109
        Me.LabelControl58.Text = "M"
        '
        'LabelControl50
        '
        Me.LabelControl50.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl50.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl50.Location = New System.Drawing.Point(160, 59)
        Me.LabelControl50.Name = "LabelControl50"
        Me.LabelControl50.Size = New System.Drawing.Size(7, 12)
        Me.LabelControl50.TabIndex = 108
        Me.LabelControl50.Text = "Y"
        '
        'LabelControl49
        '
        Me.LabelControl49.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl49.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl49.Location = New System.Drawing.Point(150, 59)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(7, 12)
        Me.LabelControl49.TabIndex = 107
        Me.LabelControl49.Text = "Y"
        '
        'LabelControl48
        '
        Me.LabelControl48.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl48.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl48.Location = New System.Drawing.Point(142, 59)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(7, 12)
        Me.LabelControl48.TabIndex = 106
        Me.LabelControl48.Text = "Y"
        '
        'LabelControl47
        '
        Me.LabelControl47.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl47.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl47.Location = New System.Drawing.Point(134, 59)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(7, 12)
        Me.LabelControl47.TabIndex = 105
        Me.LabelControl47.Text = "Y"
        '
        'LabelControl46
        '
        Me.LabelControl46.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl46.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl46.Location = New System.Drawing.Point(66, 57)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(7, 12)
        Me.LabelControl46.TabIndex = 104
        Me.LabelControl46.Text = "D"
        '
        'LabelControl45
        '
        Me.LabelControl45.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl45.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl45.Location = New System.Drawing.Point(59, 57)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(7, 12)
        Me.LabelControl45.TabIndex = 103
        Me.LabelControl45.Text = "D"
        '
        'LabelControl44
        '
        Me.LabelControl44.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl44.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl44.Location = New System.Drawing.Point(103, 58)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(8, 12)
        Me.LabelControl44.TabIndex = 102
        Me.LabelControl44.Text = "M"
        '
        'LabelControl43
        '
        Me.LabelControl43.Appearance.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl43.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl43.Location = New System.Drawing.Point(95, 58)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(8, 12)
        Me.LabelControl43.TabIndex = 101
        Me.LabelControl43.Text = "M"
        '
        'txtDepyear
        '
        Me.txtDepyear.Location = New System.Drawing.Point(381, 71)
        Me.txtDepyear.Name = "txtDepyear"
        Me.txtDepyear.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepyear.Properties.Appearance.Options.UseFont = True
        Me.txtDepyear.Properties.MaxLength = 4
        Me.txtDepyear.Size = New System.Drawing.Size(58, 20)
        Me.txtDepyear.TabIndex = 100
        '
        'txtDepDay
        '
        Me.txtDepDay.Location = New System.Drawing.Point(304, 71)
        Me.txtDepDay.Name = "txtDepDay"
        Me.txtDepDay.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepDay.Properties.Appearance.Options.UseFont = True
        Me.txtDepDay.Properties.MaxLength = 2
        Me.txtDepDay.Size = New System.Drawing.Size(34, 20)
        Me.txtDepDay.TabIndex = 99
        '
        'txtDepMonth
        '
        Me.txtDepMonth.Location = New System.Drawing.Point(344, 71)
        Me.txtDepMonth.Name = "txtDepMonth"
        Me.txtDepMonth.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepMonth.Properties.Appearance.Options.UseFont = True
        Me.txtDepMonth.Properties.MaxLength = 2
        Me.txtDepMonth.Size = New System.Drawing.Size(34, 20)
        Me.txtDepMonth.TabIndex = 98
        '
        'btGetFlightArr
        '
        Me.btGetFlightArr.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGetFlightArr.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btGetFlightArr.Appearance.Options.UseFont = True
        Me.btGetFlightArr.Appearance.Options.UseForeColor = True
        Me.btGetFlightArr.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btGetFlightArr.Location = New System.Drawing.Point(190, 71)
        Me.btGetFlightArr.Name = "btGetFlightArr"
        Me.btGetFlightArr.Size = New System.Drawing.Size(42, 23)
        Me.btGetFlightArr.TabIndex = 94
        Me.btGetFlightArr.Text = "Flights"
        '
        'txtArryear
        '
        Me.txtArryear.Location = New System.Drawing.Point(126, 72)
        Me.txtArryear.Name = "txtArryear"
        Me.txtArryear.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArryear.Properties.Appearance.Options.UseFont = True
        Me.txtArryear.Properties.MaxLength = 4
        Me.txtArryear.Size = New System.Drawing.Size(58, 20)
        Me.txtArryear.TabIndex = 97
        '
        'btGetFlights
        '
        Me.btGetFlights.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGetFlights.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btGetFlights.Appearance.Options.UseFont = True
        Me.btGetFlights.Appearance.Options.UseForeColor = True
        Me.btGetFlights.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btGetFlights.Location = New System.Drawing.Point(444, 70)
        Me.btGetFlights.Name = "btGetFlights"
        Me.btGetFlights.Size = New System.Drawing.Size(42, 23)
        Me.btGetFlights.TabIndex = 0
        Me.btGetFlights.Text = "Flights"
        '
        'txtArrDay
        '
        Me.txtArrDay.Location = New System.Drawing.Point(49, 72)
        Me.txtArrDay.Name = "txtArrDay"
        Me.txtArrDay.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArrDay.Properties.Appearance.Options.UseFont = True
        Me.txtArrDay.Properties.MaxLength = 2
        Me.txtArrDay.Size = New System.Drawing.Size(34, 20)
        Me.txtArrDay.TabIndex = 96
        '
        'txtDepTime
        '
        Me.txtDepTime.Location = New System.Drawing.Point(302, 125)
        Me.txtDepTime.Name = "txtDepTime"
        Me.txtDepTime.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepTime.Properties.Appearance.Options.UseFont = True
        Me.txtDepTime.Size = New System.Drawing.Size(95, 20)
        Me.txtDepTime.TabIndex = 79
        '
        'txtArrMonth
        '
        Me.txtArrMonth.Location = New System.Drawing.Point(87, 72)
        Me.txtArrMonth.Name = "txtArrMonth"
        Me.txtArrMonth.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArrMonth.Properties.Appearance.Options.UseFont = True
        Me.txtArrMonth.Properties.MaxLength = 2
        Me.txtArrMonth.Size = New System.Drawing.Size(34, 20)
        Me.txtArrMonth.TabIndex = 95
        '
        'txtArrTime
        '
        Me.txtArrTime.Location = New System.Drawing.Point(46, 126)
        Me.txtArrTime.Name = "txtArrTime"
        Me.txtArrTime.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArrTime.Properties.Appearance.Options.UseFont = True
        Me.txtArrTime.Size = New System.Drawing.Size(95, 20)
        Me.txtArrTime.TabIndex = 57
        '
        'cmbDepType
        '
        Me.cmbDepType.Location = New System.Drawing.Point(300, 28)
        Me.cmbDepType.Name = "cmbDepType"
        Me.cmbDepType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDepType.Properties.Items.AddRange(New Object() {"Flight", "Other"})
        Me.cmbDepType.Size = New System.Drawing.Size(63, 20)
        Me.cmbDepType.TabIndex = 76
        '
        'LabelControl40
        '
        Me.LabelControl40.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl40.Location = New System.Drawing.Point(265, 31)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl40.TabIndex = 75
        Me.LabelControl40.Text = "Type"
        '
        'cmbArrType
        '
        Me.cmbArrType.Location = New System.Drawing.Point(46, 32)
        Me.cmbArrType.Name = "cmbArrType"
        Me.cmbArrType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbArrType.Properties.Items.AddRange(New Object() {"Flight", "Other"})
        Me.cmbArrType.Size = New System.Drawing.Size(65, 20)
        Me.cmbArrType.TabIndex = 74
        '
        'LabelControl39
        '
        Me.LabelControl39.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl39.Location = New System.Drawing.Point(8, 33)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl39.TabIndex = 73
        Me.LabelControl39.Text = "Type"
        '
        'cmbDepTrans
        '
        Me.cmbDepTrans.Location = New System.Drawing.Point(303, 157)
        Me.cmbDepTrans.Name = "cmbDepTrans"
        Me.cmbDepTrans.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDepTrans.Properties.Items.AddRange(New Object() {"SPE", "OTHER"})
        Me.cmbDepTrans.Size = New System.Drawing.Size(95, 20)
        Me.cmbDepTrans.TabIndex = 72
        '
        'LabelControl37
        '
        Me.LabelControl37.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl37.Location = New System.Drawing.Point(266, 160)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl37.TabIndex = 71
        Me.LabelControl37.Text = "Trans"
        '
        'cmbArrTrans
        '
        Me.cmbArrTrans.Location = New System.Drawing.Point(46, 157)
        Me.cmbArrTrans.Name = "cmbArrTrans"
        Me.cmbArrTrans.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbArrTrans.Properties.Items.AddRange(New Object() {"SPE", "OTHER"})
        Me.cmbArrTrans.Size = New System.Drawing.Size(95, 20)
        Me.cmbArrTrans.TabIndex = 70
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl36.Location = New System.Drawing.Point(8, 161)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl36.TabIndex = 69
        Me.LabelControl36.Text = "Trans"
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl34.Location = New System.Drawing.Point(266, 128)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl34.TabIndex = 56
        Me.LabelControl34.Text = "Time"
        '
        'LabelControl33
        '
        Me.LabelControl33.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl33.Location = New System.Drawing.Point(8, 128)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl33.TabIndex = 55
        Me.LabelControl33.Text = "Time"
        '
        'cmbDepFlight
        '
        Me.cmbDepFlight.Location = New System.Drawing.Point(303, 97)
        Me.cmbDepFlight.Name = "cmbDepFlight"
        Me.cmbDepFlight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDepFlight.Size = New System.Drawing.Size(92, 20)
        Me.cmbDepFlight.TabIndex = 3
        '
        'cmbArriFlight
        '
        Me.cmbArriFlight.Location = New System.Drawing.Point(47, 100)
        Me.cmbArriFlight.Name = "cmbArriFlight"
        Me.cmbArriFlight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbArriFlight.Size = New System.Drawing.Size(94, 20)
        Me.cmbArriFlight.TabIndex = 1
        '
        'lblDepFlight
        '
        Me.lblDepFlight.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepFlight.Location = New System.Drawing.Point(266, 103)
        Me.lblDepFlight.Name = "lblDepFlight"
        Me.lblDepFlight.Size = New System.Drawing.Size(30, 13)
        Me.lblDepFlight.TabIndex = 54
        Me.lblDepFlight.Text = "Flight"
        '
        'lblArrivalFlight
        '
        Me.lblArrivalFlight.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrivalFlight.Location = New System.Drawing.Point(8, 103)
        Me.lblArrivalFlight.Name = "lblArrivalFlight"
        Me.lblArrivalFlight.Size = New System.Drawing.Size(30, 13)
        Me.lblArrivalFlight.TabIndex = 52
        Me.lblArrivalFlight.Text = "Flight"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(266, 75)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl3.TabIndex = 50
        Me.LabelControl3.Text = "Date"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(9, 75)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Date"
        '
        'txtOtherArr
        '
        Me.txtOtherArr.Location = New System.Drawing.Point(47, 101)
        Me.txtOtherArr.Name = "txtOtherArr"
        Me.txtOtherArr.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherArr.Properties.Appearance.Options.UseFont = True
        Me.txtOtherArr.Size = New System.Drawing.Size(109, 20)
        Me.txtOtherArr.TabIndex = 77
        Me.txtOtherArr.Visible = False
        '
        'txtOtherDep
        '
        Me.txtOtherDep.Location = New System.Drawing.Point(304, 98)
        Me.txtOtherDep.Name = "txtOtherDep"
        Me.txtOtherDep.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherDep.Properties.Appearance.Options.UseFont = True
        Me.txtOtherDep.Size = New System.Drawing.Size(101, 20)
        Me.txtOtherDep.TabIndex = 78
        Me.txtOtherDep.Visible = False
        '
        'gbBookingtype
        '
        Me.gbBookingtype.Controls.Add(Me.cbTopcode)
        Me.gbBookingtype.Controls.Add(Me.LabelControl11)
        Me.gbBookingtype.Controls.Add(Me.CbFit)
        Me.gbBookingtype.Controls.Add(Me.CbTop)
        Me.gbBookingtype.Controls.Add(Me.CbCompl)
        Me.gbBookingtype.Enabled = False
        Me.gbBookingtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbBookingtype.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBookingtype.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gbBookingtype.Location = New System.Drawing.Point(3, 122)
        Me.gbBookingtype.Name = "gbBookingtype"
        Me.gbBookingtype.Size = New System.Drawing.Size(320, 123)
        Me.gbBookingtype.TabIndex = 2
        Me.gbBookingtype.TabStop = False
        Me.gbBookingtype.Text = "Booking Type"
        '
        'cbTopcode
        '
        Me.cbTopcode.Enabled = False
        Me.cbTopcode.Location = New System.Drawing.Point(120, 91)
        Me.cbTopcode.Name = "cbTopcode"
        Me.cbTopcode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTopcode.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TopCode", 5, "TopCode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TopName", 15, "TopName")})
        Me.cbTopcode.Properties.NullText = ""
        Me.cbTopcode.Size = New System.Drawing.Size(194, 20)
        Me.cbTopcode.TabIndex = 1
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(7, 21)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl11.TabIndex = 57
        Me.LabelControl11.Text = "Reservation Type"
        '
        'CbFit
        '
        Me.CbFit.Location = New System.Drawing.Point(9, 41)
        Me.CbFit.Name = "CbFit"
        Me.CbFit.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbFit.Properties.Appearance.Options.UseFont = True
        Me.CbFit.Properties.Caption = "FIT"
        Me.CbFit.Size = New System.Drawing.Size(68, 19)
        Me.CbFit.TabIndex = 58
        '
        'CbTop
        '
        Me.CbTop.Location = New System.Drawing.Point(11, 90)
        Me.CbTop.Name = "CbTop"
        Me.CbTop.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTop.Properties.Appearance.Options.UseFont = True
        Me.CbTop.Properties.Caption = "Tour Operator"
        Me.CbTop.Size = New System.Drawing.Size(105, 19)
        Me.CbTop.TabIndex = 0
        '
        'CbCompl
        '
        Me.CbCompl.Location = New System.Drawing.Point(9, 65)
        Me.CbCompl.Name = "CbCompl"
        Me.CbCompl.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCompl.Properties.Appearance.Options.UseFont = True
        Me.CbCompl.Properties.Caption = "Complimentary"
        Me.CbCompl.Size = New System.Drawing.Size(112, 19)
        Me.CbCompl.TabIndex = 0
        '
        'DtDep
        '
        Me.DtDep.EditValue = Nothing
        Me.DtDep.Enabled = False
        Me.DtDep.Location = New System.Drawing.Point(854, 264)
        Me.DtDep.Name = "DtDep"
        Me.DtDep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtDep.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DtDep.Size = New System.Drawing.Size(102, 20)
        Me.DtDep.TabIndex = 2
        Me.DtDep.Visible = False
        '
        'DtArrival
        '
        Me.DtArrival.EditValue = Nothing
        Me.DtArrival.Location = New System.Drawing.Point(854, 238)
        Me.DtArrival.Name = "DtArrival"
        Me.DtArrival.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtArrival.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DtArrival.Size = New System.Drawing.Size(97, 20)
        Me.DtArrival.TabIndex = 0
        Me.DtArrival.Visible = False
        '
        'btApprove
        '
        Me.btApprove.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btApprove.Appearance.Options.UseFont = True
        Me.btApprove.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btApprove.Location = New System.Drawing.Point(853, 121)
        Me.btApprove.Name = "btApprove"
        Me.btApprove.Size = New System.Drawing.Size(103, 23)
        Me.btApprove.TabIndex = 3
        Me.btApprove.Text = "Approve"
        '
        'btDel
        '
        Me.btDel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDel.Appearance.Options.UseFont = True
        Me.btDel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btDel.Location = New System.Drawing.Point(853, 92)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(103, 23)
        Me.btDel.TabIndex = 2
        Me.btDel.Text = "Inactivate"
        '
        'btEdit
        '
        Me.btEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEdit.Appearance.Options.UseFont = True
        Me.btEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btEdit.Location = New System.Drawing.Point(854, 63)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(102, 23)
        Me.btEdit.TabIndex = 1
        Me.btEdit.Text = "Edit"
        '
        'btAdd
        '
        Me.btAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.Appearance.Options.UseFont = True
        Me.btAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btAdd.Location = New System.Drawing.Point(854, 34)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(102, 23)
        Me.btAdd.TabIndex = 0
        Me.btAdd.Text = "&Add"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(851, 610)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 15
        '
        'btprintres
        '
        Me.btprintres.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btprintres.Appearance.Options.UseFont = True
        Me.btprintres.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btprintres.Location = New System.Drawing.Point(853, 150)
        Me.btprintres.Name = "btprintres"
        Me.btprintres.Size = New System.Drawing.Size(103, 30)
        Me.btprintres.TabIndex = 16
        Me.btprintres.Text = "Res.Confirmation"
        '
        'LabelControl62
        '
        Me.LabelControl62.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl62.Location = New System.Drawing.Point(11, 104)
        Me.LabelControl62.Name = "LabelControl62"
        Me.LabelControl62.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl62.TabIndex = 80
        Me.LabelControl62.Text = "E-mail"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(127, 101)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Properties.Appearance.ForeColor = System.Drawing.Color.DarkMagenta
        Me.txtEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEmail.Properties.Appearance.Options.UseForeColor = True
        Me.txtEmail.Size = New System.Drawing.Size(192, 20)
        Me.txtEmail.TabIndex = 80
        '
        'frmReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(963, 651)
        Me.Controls.Add(Me.btprintres)
        Me.Controls.Add(Me.tabReservation)
        Me.Controls.Add(Me.btApprove)
        Me.Controls.Add(Me.btDel)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.DtArrival)
        Me.Controls.Add(Me.DtDep)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmReservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation"
        CType(Me.tabReservation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReservation.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtTopReference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcReservation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GviewReservation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtViewdate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtViewdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtNationality.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGuesname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtToday.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtToday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtResdate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtResdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReservationno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOthers.ResumeLayout(False)
        Me.gbOthers.PerformLayout()
        CType(Me.txtRefno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBillinginst.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtguestdislike.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtguestlike.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbpayment.ResumeLayout(False)
        Me.gbpayment.PerformLayout()
        CType(Me.txtPaymentStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtExpiry.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtExpiry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbpaymode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCCno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPax.ResumeLayout(False)
        Me.gbpax2.ResumeLayout(False)
        Me.gbpax2.PerformLayout()
        CType(Me.cmbOffers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBednights.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAmmenties.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDisscounts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPax1.ResumeLayout(False)
        Me.gbPax1.PerformLayout()
        CType(Me.totPaxrooms.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcRoomcount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcViewRoomCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRoomtyp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoomcount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRoom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcounttot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMealplan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtadultcount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtinfantcount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtchildcount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbArridep.ResumeLayout(False)
        Me.gbArridep.PerformLayout()
        CType(Me.cmbDepTransTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbArrTransTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepyear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArryear.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArrDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArrMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArrTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDepType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbArrType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDepTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbArrTrans.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDepFlight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbArriFlight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtherArr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtherDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBookingtype.ResumeLayout(False)
        Me.gbBookingtype.PerformLayout()
        CType(Me.cbTopcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbFit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbCompl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtDep.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtArrival.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtArrival.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabReservation As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents DtViewdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcReservation As DevExpress.XtraGrid.GridControl
    Friend WithEvents GviewReservation As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbArridep As System.Windows.Forms.GroupBox
    Friend WithEvents lblDepFlight As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblArrivalFlight As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DtDep As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DtArrival As DevExpress.XtraEditors.DateEdit
    Friend WithEvents gbBookingtype As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CbFit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CbTop As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CbCompl As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents gbPax As System.Windows.Forms.GroupBox
    Friend WithEvents gbOthers As System.Windows.Forms.GroupBox
    Friend WithEvents txtBillinginst As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtguestdislike As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtguestlike As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gbpayment As System.Windows.Forms.GroupBox
    Friend WithEvents DtExpiry As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbpaymode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCCno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtReservationno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DtToday As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DtResdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDepFlight As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbArriFlight As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGuesname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gbpax2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcounttot As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbMealplan As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtinfantcount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtchildcount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtadultcount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gbPax1 As System.Windows.Forms.GroupBox
    Friend WithEvents btAddRoomcount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbRoomtyp As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtRoomcount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbRoom As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btGetrate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbDisscounts As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbAmmenties As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcResno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcResdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcGuest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcResType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTopcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcArrDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDepDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btViewAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbOffers As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRefno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDepTrans As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbArrTrans As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcRoomcount As DevExpress.XtraGrid.GridControl
    Friend WithEvents gcViewRoomCount As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmbDepType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbArrType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOtherArr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOtherDep As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDepTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtArrTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btPendingApp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btApprove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btDelRoomcount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtBednights As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents totPaxrooms As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btGetFlights As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btGetFlightArr As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btViewTopRef As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTopReference As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbTopcode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btgetTopallDis As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtArryear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtArrDay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtArrMonth As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDepyear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDepDay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDepMonth As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPaymentStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbArrTransTime As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbDepTransTime As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CachedReceiptDirect1 As HRM_Pro.CachedReceiptDirect
    Friend WithEvents btprintres As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbCountry As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtNationality As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl62 As DevExpress.XtraEditors.LabelControl
End Class
