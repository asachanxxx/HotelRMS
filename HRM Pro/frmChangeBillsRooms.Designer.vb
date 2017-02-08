<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeBillsRooms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangeBillsRooms))
        Me.tabMain = New DevExpress.XtraTab.XtraTabControl()
        Me.Bill = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDep = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtbillamt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtbillno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btBillchange = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtguest2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbroomno2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEditGuest = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControUnPaidBill = New DevExpress.XtraGrid.GridControl()
        Me.BillGview = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbroomno = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.Bill.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbillamt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbillno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtguest2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbroomno2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditGuest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControUnPaidBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillGview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbroomno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.AppearancePage.Header.Options.UseFont = True
        Me.tabMain.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabMain.Location = New System.Drawing.Point(3, 12)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedTabPage = Me.Bill
        Me.tabMain.Size = New System.Drawing.Size(660, 505)
        Me.tabMain.TabIndex = 1
        Me.tabMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.Bill})
        '
        'Bill
        '
        Me.Bill.Controls.Add(Me.GroupBox2)
        Me.Bill.Name = "Bill"
        Me.Bill.Size = New System.Drawing.Size(658, 480)
        Me.Bill.Text = "Master Billing"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelControl10)
        Me.GroupBox2.Controls.Add(Me.LabelControl9)
        Me.GroupBox2.Controls.Add(Me.LabelControl7)
        Me.GroupBox2.Controls.Add(Me.lbl28)
        Me.GroupBox2.Controls.Add(Me.txtDep)
        Me.GroupBox2.Controls.Add(Me.LabelControl6)
        Me.GroupBox2.Controls.Add(Me.txtbillamt)
        Me.GroupBox2.Controls.Add(Me.LabelControl5)
        Me.GroupBox2.Controls.Add(Me.txtbillno)
        Me.GroupBox2.Controls.Add(Me.LabelControl4)
        Me.GroupBox2.Controls.Add(Me.btBillchange)
        Me.GroupBox2.Controls.Add(Me.LabelControl3)
        Me.GroupBox2.Controls.Add(Me.txtguest2)
        Me.GroupBox2.Controls.Add(Me.LabelControl1)
        Me.GroupBox2.Controls.Add(Me.cmbroomno2)
        Me.GroupBox2.Controls.Add(Me.LabelControl2)
        Me.GroupBox2.Controls.Add(Me.LabelControl14)
        Me.GroupBox2.Controls.Add(Me.TextEditGuest)
        Me.GroupBox2.Controls.Add(Me.LabelControl13)
        Me.GroupBox2.Controls.Add(Me.GridControUnPaidBill)
        Me.GroupBox2.Controls.Add(Me.cmbroomno)
        Me.GroupBox2.Controls.Add(Me.LabelControl8)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(643, 464)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl10.Location = New System.Drawing.Point(513, 318)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl10.TabIndex = 141
        Me.LabelControl10.Text = "*"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl9.Location = New System.Drawing.Point(302, 358)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl9.TabIndex = 140
        Me.LabelControl9.Text = "*"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl7.Location = New System.Drawing.Point(302, 313)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl7.TabIndex = 139
        Me.LabelControl7.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(302, 270)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 138
        Me.lbl28.Text = "*"
        '
        'txtDep
        '
        Me.txtDep.Enabled = False
        Me.txtDep.Location = New System.Drawing.Point(96, 355)
        Me.txtDep.Name = "txtDep"
        Me.txtDep.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDep.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtDep.Properties.Appearance.Options.UseFont = True
        Me.txtDep.Properties.Appearance.Options.UseForeColor = True
        Me.txtDep.Size = New System.Drawing.Size(200, 28)
        Me.txtDep.TabIndex = 137
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(16, 358)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(48, 21)
        Me.LabelControl6.TabIndex = 136
        Me.LabelControl6.Text = "Outlet"
        '
        'txtbillamt
        '
        Me.txtbillamt.Enabled = False
        Me.txtbillamt.Location = New System.Drawing.Point(96, 310)
        Me.txtbillamt.Name = "txtbillamt"
        Me.txtbillamt.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbillamt.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtbillamt.Properties.Appearance.Options.UseFont = True
        Me.txtbillamt.Properties.Appearance.Options.UseForeColor = True
        Me.txtbillamt.Size = New System.Drawing.Size(200, 28)
        Me.txtbillamt.TabIndex = 135
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(16, 313)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(62, 21)
        Me.LabelControl5.TabIndex = 134
        Me.LabelControl5.Text = "Amount"
        '
        'txtbillno
        '
        Me.txtbillno.Enabled = False
        Me.txtbillno.Location = New System.Drawing.Point(96, 267)
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbillno.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtbillno.Properties.Appearance.Options.UseFont = True
        Me.txtbillno.Properties.Appearance.Options.UseForeColor = True
        Me.txtbillno.Size = New System.Drawing.Size(200, 28)
        Me.txtbillno.TabIndex = 133
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(22, 270)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 21)
        Me.LabelControl4.TabIndex = 132
        Me.LabelControl4.Text = "Bill No"
        '
        'btBillchange
        '
        Me.btBillchange.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBillchange.Appearance.Options.UseFont = True
        Me.btBillchange.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btBillchange.Location = New System.Drawing.Point(411, 396)
        Me.btBillchange.Name = "btBillchange"
        Me.btBillchange.Size = New System.Drawing.Size(133, 44)
        Me.btBillchange.TabIndex = 131
        Me.btBillchange.Text = "Bill Change"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl3.Location = New System.Drawing.Point(337, 270)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(81, 21)
        Me.LabelControl3.TabIndex = 130
        Me.LabelControl3.Text = "Change To"
        '
        'txtguest2
        '
        Me.txtguest2.Enabled = False
        Me.txtguest2.Location = New System.Drawing.Point(411, 359)
        Me.txtguest2.Name = "txtguest2"
        Me.txtguest2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtguest2.Properties.Appearance.Options.UseFont = True
        Me.txtguest2.Size = New System.Drawing.Size(226, 20)
        Me.txtguest2.TabIndex = 129
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl1.Location = New System.Drawing.Point(337, 358)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 21)
        Me.LabelControl1.TabIndex = 128
        Me.LabelControl1.Text = "Guest"
        '
        'cmbroomno2
        '
        Me.cmbroomno2.AllowDrop = True
        Me.cmbroomno2.Location = New System.Drawing.Point(411, 314)
        Me.cmbroomno2.Name = "cmbroomno2"
        Me.cmbroomno2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbroomno2.Properties.Appearance.Options.UseFont = True
        Me.cmbroomno2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbroomno2.Size = New System.Drawing.Size(96, 26)
        Me.cmbroomno2.TabIndex = 127
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl2.Location = New System.Drawing.Point(337, 313)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 21)
        Me.LabelControl2.TabIndex = 126
        Me.LabelControl2.Text = "RoomNo"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Location = New System.Drawing.Point(25, 65)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl14.TabIndex = 113
        Me.LabelControl14.Text = "Bills"
        '
        'TextEditGuest
        '
        Me.TextEditGuest.Enabled = False
        Me.TextEditGuest.Location = New System.Drawing.Point(259, 30)
        Me.TextEditGuest.Name = "TextEditGuest"
        Me.TextEditGuest.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEditGuest.Properties.Appearance.Options.UseFont = True
        Me.TextEditGuest.Size = New System.Drawing.Size(354, 20)
        Me.TextEditGuest.TabIndex = 112
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(209, 32)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl13.TabIndex = 111
        Me.LabelControl13.Text = "Guest"
        '
        'GridControUnPaidBill
        '
        Me.GridControUnPaidBill.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridControUnPaidBill.Location = New System.Drawing.Point(22, 80)
        Me.GridControUnPaidBill.MainView = Me.BillGview
        Me.GridControUnPaidBill.Name = "GridControUnPaidBill"
        Me.GridControUnPaidBill.Size = New System.Drawing.Size(601, 170)
        Me.GridControUnPaidBill.TabIndex = 109
        Me.GridControUnPaidBill.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BillGview})
        '
        'BillGview
        '
        Me.BillGview.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillGview.Appearance.HeaderPanel.Options.UseFont = True
        Me.BillGview.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillGview.Appearance.Row.Options.UseFont = True
        Me.BillGview.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn10, Me.GridColumn2, Me.GridColumn3, Me.GridColumn5, Me.GridColumn12, Me.GridColumn4})
        Me.BillGview.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.BillGview.GridControl = Me.GridControUnPaidBill
        Me.BillGview.Name = "BillGview"
        Me.BillGview.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.BillGview.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Bill No"
        Me.GridColumn6.FieldName = "Bill No"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Amount"
        Me.GridColumn7.FieldName = "Amount"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "UID"
        Me.GridColumn10.FieldName = "UID"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Department"
        Me.GridColumn2.FieldName = "Department"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "BillGeneratedDate"
        Me.GridColumn3.FieldName = "BillGeneratedDate"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "KOTBOTNo"
        Me.GridColumn5.FieldName = "KOTBOTNo"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "OutletMasBill"
        Me.GridColumn12.FieldName = "OutMasNo"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 5
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Paid"
        Me.GridColumn4.FieldName = "Paid"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'cmbroomno
        '
        Me.cmbroomno.AllowDrop = True
        Me.cmbroomno.Location = New System.Drawing.Point(77, 30)
        Me.cmbroomno.Name = "cmbroomno"
        Me.cmbroomno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbroomno.Size = New System.Drawing.Size(96, 20)
        Me.cmbroomno.TabIndex = 99
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(24, 32)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl8.TabIndex = 98
        Me.LabelControl8.Text = "RoomNo"
        '
        'frmChangeBillsRooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(665, 521)
        Me.Controls.Add(Me.tabMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmChangeBillsRooms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Bills - Rooms"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.Bill.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbillamt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbillno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtguest2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbroomno2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditGuest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControUnPaidBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillGview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbroomno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents Bill As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtguest2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbroomno2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEditGuest As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControUnPaidBill As DevExpress.XtraGrid.GridControl
    Friend WithEvents BillGview As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbroomno As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDep As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtbillamt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtbillno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btBillchange As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
End Class
