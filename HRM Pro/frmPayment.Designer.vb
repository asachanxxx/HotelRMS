<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Dim TextAnnotation1 As DevExpress.XtraCharts.TextAnnotation = New DevExpress.XtraCharts.TextAnnotation()
        Dim SeriesPointAnchorPoint1 As DevExpress.XtraCharts.SeriesPointAnchorPoint = New DevExpress.XtraCharts.SeriesPointAnchorPoint()
        Dim RelativePosition1 As DevExpress.XtraCharts.RelativePosition = New DevExpress.XtraCharts.RelativePosition()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim SeriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Jan", New Object() {CType(10.0R, Object)}, 0)
        Dim SeriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Feb")
        Dim SeriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Mar")
        Dim SeriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Apr")
        Dim SeriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("May", New Object() {CType(50.0R, Object)})
        Dim SeriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Jun")
        Dim SeriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Jul")
        Dim SeriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Aug")
        Dim SeriesPoint9 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Sep")
        Dim SeriesPoint10 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Oct")
        Dim SeriesPoint11 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Nov")
        Dim SeriesPoint12 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Dec")
        Dim SideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayment))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colReceiptno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colrecdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNarration = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colbillno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBillstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colguestname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coladd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltouroperator = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit3 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit4 = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(TextAnnotation1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SeriesPointAnchorPoint1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.XtraTabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(727, 486)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(10, 15)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(708, 471)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupBox9)
        Me.XtraTabPage1.Controls.Add(Me.TextEdit3)
        Me.XtraTabPage1.Controls.Add(Me.SimpleButton4)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage1.Controls.Add(Me.GroupBox4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(706, 446)
        Me.XtraTabPage1.Text = "Payment History"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.GridControl3)
        Me.GroupBox9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox9.Location = New System.Drawing.Point(12, 232)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(679, 185)
        Me.GroupBox9.TabIndex = 71
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Payment Details"
        '
        'GridControl3
        '
        Me.GridControl3.Location = New System.Drawing.Point(6, 27)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(656, 138)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView3.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.Row.Options.UseFont = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReceiptno, Me.colrecdate, Me.colsmount, Me.colNarration})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colReceiptno
        '
        Me.colReceiptno.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colReceiptno.AppearanceCell.Options.UseFont = True
        Me.colReceiptno.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colReceiptno.AppearanceHeader.Options.UseFont = True
        Me.colReceiptno.AppearanceHeader.Options.UseTextOptions = True
        Me.colReceiptno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colReceiptno.Caption = "Receipt No"
        Me.colReceiptno.Name = "colReceiptno"
        Me.colReceiptno.Visible = True
        Me.colReceiptno.VisibleIndex = 0
        Me.colReceiptno.Width = 150
        '
        'colrecdate
        '
        Me.colrecdate.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colrecdate.AppearanceCell.Options.UseFont = True
        Me.colrecdate.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colrecdate.AppearanceHeader.Options.UseFont = True
        Me.colrecdate.AppearanceHeader.Options.UseTextOptions = True
        Me.colrecdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colrecdate.Caption = "Date"
        Me.colrecdate.Name = "colrecdate"
        Me.colrecdate.Visible = True
        Me.colrecdate.VisibleIndex = 1
        Me.colrecdate.Width = 100
        '
        'colsmount
        '
        Me.colsmount.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colsmount.AppearanceCell.Options.UseFont = True
        Me.colsmount.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colsmount.AppearanceHeader.Options.UseFont = True
        Me.colsmount.AppearanceHeader.Options.UseTextOptions = True
        Me.colsmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colsmount.Caption = "Amount"
        Me.colsmount.Name = "colsmount"
        Me.colsmount.Visible = True
        Me.colsmount.VisibleIndex = 2
        Me.colsmount.Width = 148
        '
        'colNarration
        '
        Me.colNarration.Caption = "Narration"
        Me.colNarration.Name = "colNarration"
        Me.colNarration.Visible = True
        Me.colNarration.VisibleIndex = 3
        Me.colNarration.Width = 148
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(72, 40)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit3.Properties.Appearance.Options.UseFont = True
        Me.TextEdit3.Size = New System.Drawing.Size(110, 20)
        Me.TextEdit3.TabIndex = 70
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Location = New System.Drawing.Point(197, 37)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButton4.TabIndex = 4
        Me.SimpleButton4.Text = "Search"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(8, 43)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl12.TabIndex = 2
        Me.LabelControl12.Text = "Room No"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GridControl1)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox4.Location = New System.Drawing.Point(9, 72)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(682, 152)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Master Bill Details"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(6, 27)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(656, 112)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colbillno, Me.colDate, Me.colAmt, Me.colBillstatus})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colbillno
        '
        Me.colbillno.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colbillno.AppearanceCell.Options.UseFont = True
        Me.colbillno.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colbillno.AppearanceHeader.Options.UseFont = True
        Me.colbillno.AppearanceHeader.Options.UseTextOptions = True
        Me.colbillno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colbillno.Caption = "Master Bill No"
        Me.colbillno.Name = "colbillno"
        Me.colbillno.Visible = True
        Me.colbillno.VisibleIndex = 0
        Me.colbillno.Width = 150
        '
        'colDate
        '
        Me.colDate.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDate.AppearanceCell.Options.UseFont = True
        Me.colDate.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDate.AppearanceHeader.Options.UseFont = True
        Me.colDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDate.Caption = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.Visible = True
        Me.colDate.VisibleIndex = 1
        Me.colDate.Width = 100
        '
        'colAmt
        '
        Me.colAmt.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAmt.AppearanceCell.Options.UseFont = True
        Me.colAmt.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAmt.AppearanceHeader.Options.UseFont = True
        Me.colAmt.AppearanceHeader.Options.UseTextOptions = True
        Me.colAmt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAmt.Caption = "Amount"
        Me.colAmt.Name = "colAmt"
        Me.colAmt.Visible = True
        Me.colAmt.VisibleIndex = 2
        Me.colAmt.Width = 148
        '
        'colBillstatus
        '
        Me.colBillstatus.Caption = "Status"
        Me.colBillstatus.Name = "colBillstatus"
        Me.colBillstatus.Visible = True
        Me.colBillstatus.VisibleIndex = 3
        Me.colBillstatus.Width = 148
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupBox5)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(706, 446)
        Me.XtraTabPage2.Text = "New Payment"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox10)
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Controls.Add(Me.CheckEdit1)
        Me.GroupBox5.Controls.Add(Me.CheckEdit2)
        Me.GroupBox5.Controls.Add(Me.TextEdit7)
        Me.GroupBox5.Controls.Add(Me.LabelControl7)
        Me.GroupBox5.Controls.Add(Me.TextEdit4)
        Me.GroupBox5.Controls.Add(Me.GroupBox8)
        Me.GroupBox5.Controls.Add(Me.LabelControl2)
        Me.GroupBox5.Controls.Add(Me.LabelControl1)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(693, 436)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.GridControl4)
        Me.GroupBox10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox10.Location = New System.Drawing.Point(368, 98)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(316, 178)
        Me.GroupBox10.TabIndex = 80
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Guest Details"
        '
        'GridControl4
        '
        Me.GridControl4.Location = New System.Drawing.Point(6, 27)
        Me.GridControl4.MainView = Me.GridView4
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(301, 141)
        Me.GridControl4.TabIndex = 0
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView4.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView4.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView4.Appearance.Row.Options.UseFont = True
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colguestname, Me.coladd, Me.coltouroperator})
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colguestname
        '
        Me.colguestname.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colguestname.AppearanceCell.Options.UseFont = True
        Me.colguestname.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colguestname.AppearanceHeader.Options.UseFont = True
        Me.colguestname.AppearanceHeader.Options.UseTextOptions = True
        Me.colguestname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colguestname.Caption = "Guest Name"
        Me.colguestname.Name = "colguestname"
        Me.colguestname.Visible = True
        Me.colguestname.VisibleIndex = 0
        Me.colguestname.Width = 150
        '
        'coladd
        '
        Me.coladd.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coladd.AppearanceCell.Options.UseFont = True
        Me.coladd.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coladd.AppearanceHeader.Options.UseFont = True
        Me.coladd.AppearanceHeader.Options.UseTextOptions = True
        Me.coladd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coladd.Caption = "Address"
        Me.coladd.Name = "coladd"
        Me.coladd.Visible = True
        Me.coladd.VisibleIndex = 1
        Me.coladd.Width = 100
        '
        'coltouroperator
        '
        Me.coltouroperator.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coltouroperator.AppearanceCell.Options.UseFont = True
        Me.coltouroperator.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coltouroperator.AppearanceHeader.Options.UseFont = True
        Me.coltouroperator.AppearanceHeader.Options.UseTextOptions = True
        Me.coltouroperator.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltouroperator.Caption = "Tour Operator"
        Me.coltouroperator.Name = "coltouroperator"
        Me.coltouroperator.Visible = True
        Me.coltouroperator.VisibleIndex = 2
        Me.coltouroperator.Width = 148
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GridControl2)
        Me.GroupBox7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox7.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(328, 178)
        Me.GroupBox7.TabIndex = 79
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Master Bill Details"
        '
        'GridControl2
        '
        Me.GridControl2.Location = New System.Drawing.Point(6, 27)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(301, 141)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Master Bill No"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 150
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Date"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 100
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceCell.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Amount"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 148
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Status"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 148
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(145, 48)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Full Payment"
        Me.CheckEdit1.Size = New System.Drawing.Size(82, 19)
        Me.CheckEdit1.TabIndex = 77
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(243, 48)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "Advanced Payment"
        Me.CheckEdit2.Size = New System.Drawing.Size(123, 19)
        Me.CheckEdit2.TabIndex = 78
        '
        'TextEdit7
        '
        Me.TextEdit7.Location = New System.Drawing.Point(486, 14)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit7.Properties.Appearance.Options.UseFont = True
        Me.TextEdit7.Size = New System.Drawing.Size(198, 20)
        Me.TextEdit7.TabIndex = 76
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(368, 17)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl7.TabIndex = 75
        Me.LabelControl7.Text = "Receipt No"
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(147, 14)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit4.Properties.Appearance.Options.UseFont = True
        Me.TextEdit4.Size = New System.Drawing.Size(198, 20)
        Me.TextEdit4.TabIndex = 71
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.LabelControl6)
        Me.GroupBox8.Controls.Add(Me.CheckEdit3)
        Me.GroupBox8.Controls.Add(Me.CheckEdit4)
        Me.GroupBox8.Controls.Add(Me.LabelControl5)
        Me.GroupBox8.Controls.Add(Me.TextEdit5)
        Me.GroupBox8.Controls.Add(Me.TextEdit2)
        Me.GroupBox8.Controls.Add(Me.LabelControl4)
        Me.GroupBox8.Controls.Add(Me.LabelControl3)
        Me.GroupBox8.Controls.Add(Me.TextEdit1)
        Me.GroupBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(12, 282)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(672, 144)
        Me.GroupBox8.TabIndex = 70
        Me.GroupBox8.TabStop = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(6, 76)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl6.TabIndex = 81
        Me.LabelControl6.Text = "Credit Card No"
        '
        'CheckEdit3
        '
        Me.CheckEdit3.Location = New System.Drawing.Point(134, 42)
        Me.CheckEdit3.Name = "CheckEdit3"
        Me.CheckEdit3.Properties.Caption = "Cash"
        Me.CheckEdit3.Size = New System.Drawing.Size(82, 19)
        Me.CheckEdit3.TabIndex = 79
        '
        'CheckEdit4
        '
        Me.CheckEdit4.Location = New System.Drawing.Point(231, 42)
        Me.CheckEdit4.Name = "CheckEdit4"
        Me.CheckEdit4.Properties.Caption = "Credit Card"
        Me.CheckEdit4.Size = New System.Drawing.Size(123, 19)
        Me.CheckEdit4.TabIndex = 80
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(6, 44)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl5.TabIndex = 77
        Me.LabelControl5.Text = "Pay Method"
        '
        'TextEdit5
        '
        Me.TextEdit5.Location = New System.Drawing.Point(136, 16)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit5.Properties.Appearance.Options.UseFont = True
        Me.TextEdit5.Size = New System.Drawing.Size(198, 20)
        Me.TextEdit5.TabIndex = 76
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(135, 103)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Size = New System.Drawing.Size(498, 20)
        Me.TextEdit2.TabIndex = 73
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(6, 106)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl4.TabIndex = 72
        Me.LabelControl4.Text = "Remarks"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(6, 17)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl3.TabIndex = 71
        Me.LabelControl3.Text = "Pay Amount "
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(135, 73)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Size = New System.Drawing.Size(198, 20)
        Me.TextEdit1.TabIndex = 70
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(6, 50)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl2.TabIndex = 36
        Me.LabelControl2.Text = "Payment Mode"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(6, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl1.TabIndex = 30
        Me.LabelControl1.Text = "Room No"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GroupBox6)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(706, 446)
        Me.XtraTabPage3.Text = "Statistics"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ChartControl1)
        Me.GroupBox6.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(710, 434)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        '
        'ChartControl1
        '
        SeriesPointAnchorPoint1.SeriesID = 0
        SeriesPointAnchorPoint1.SeriesPointID = 0
        TextAnnotation1.AnchorPoint = SeriesPointAnchorPoint1
        TextAnnotation1.Name = "Text Annotation 1"
        TextAnnotation1.ShapePosition = RelativePosition1
        TextAnnotation1.Text = "Text here"
        Me.ChartControl1.AnnotationRepository.AddRange(New DevExpress.XtraCharts.Annotation() {TextAnnotation1})
        XyDiagram1.AxisX.Range.Auto = False
        XyDiagram1.AxisX.Range.MaxValueSerializable = "Dec"
        XyDiagram1.AxisX.Range.MinValueInternal = -0.5R
        XyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Location = New System.Drawing.Point(7, 22)
        Me.ChartControl1.Name = "ChartControl1"
        SideBySideBarSeriesLabel1.LineVisible = True
        Series1.Label = SideBySideBarSeriesLabel1
        Series1.Name = "Series 1"
        Series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint1, SeriesPoint2, SeriesPoint3, SeriesPoint4, SeriesPoint5, SeriesPoint6, SeriesPoint7, SeriesPoint8, SeriesPoint9, SeriesPoint10, SeriesPoint11, SeriesPoint12})
        Series1.SeriesID = 0
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        SideBySideBarSeriesLabel2.LineVisible = True
        Me.ChartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel2
        Me.ChartControl1.Size = New System.Drawing.Size(697, 406)
        Me.ChartControl1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.SimpleButton7)
        Me.GroupBox2.Controls.Add(Me.SimpleButton6)
        Me.GroupBox2.Controls.Add(Me.SimpleButton3)
        Me.GroupBox2.Controls.Add(Me.SimpleButton2)
        Me.GroupBox2.Controls.Add(Me.SimpleButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(735, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(103, 307)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton7.Appearance.Options.UseFont = True
        Me.SimpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton7.Location = New System.Drawing.Point(5, 132)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButton7.TabIndex = 4
        Me.SimpleButton7.Text = "Cancel"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton6.Location = New System.Drawing.Point(5, 103)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButton6.TabIndex = 3
        Me.SimpleButton6.Text = "Print"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton3.Location = New System.Drawing.Point(5, 74)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "View"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton2.Location = New System.Drawing.Point(5, 45)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "Edit"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton1.Location = New System.Drawing.Point(6, 16)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Pay"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.BackgroundImage = Global.HRM_Pro.My.Resources.Resources._2
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox3.Location = New System.Drawing.Point(736, 314)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(102, 177)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.rmsinterface
        Me.ClientSize = New System.Drawing.Size(846, 496)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(SeriesPointAnchorPoint1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(TextAnnotation1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colbillno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colReceiptno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrecdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNarration As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colguestname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltouroperator As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit4 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
End Class
