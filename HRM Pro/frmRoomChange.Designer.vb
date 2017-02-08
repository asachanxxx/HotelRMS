<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoomChange))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.btUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.gcResdetails = New DevExpress.XtraGrid.GridControl()
        Me.gdviewresdetails = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colResDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGuest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArrDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdultQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChildrenQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInfantsQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMealPlan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBillingInst = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.gcPax = New DevExpress.XtraGrid.GridControl()
        Me.gvroomdetails = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcRoom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRooTyp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRoomcount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcBednights = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btDelRoom = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBednights = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbRoomtyp = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtRoomcount = New DevExpress.XtraEditors.TextEdit()
        Me.cmbRoom = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.btResDetails = New DevExpress.XtraEditors.SimpleButton()
        Me.btSearchothers = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbResnos = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbTopcode = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.btSearchtop = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.gcResdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdviewresdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvroomdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBednights.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRoomtyp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoomcount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRoom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbResnos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTopcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XtraTabControl1.BackgroundImage = Global.HRM_Pro.My.Resources.Resources.rmsinterface
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 28)
        Me.XtraTabControl1.LookAndFeel.SkinName = "Metropolis"
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(693, 343)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.lbl28)
        Me.XtraTabPage2.Controls.Add(Me.btUpdate)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.gcResdetails)
        Me.XtraTabPage2.Controls.Add(Me.gcPax)
        Me.XtraTabPage2.Controls.Add(Me.btDelRoom)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl16)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl18)
        Me.XtraTabPage2.Controls.Add(Me.txtBednights)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.cmbRoomtyp)
        Me.XtraTabPage2.Controls.Add(Me.txtRoomcount)
        Me.XtraTabPage2.Controls.Add(Me.cmbRoom)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl17)
        Me.XtraTabPage2.Controls.Add(Me.btResDetails)
        Me.XtraTabPage2.Controls.Add(Me.btSearchothers)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.cmbResnos)
        Me.XtraTabPage2.Controls.Add(Me.cbTopcode)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl13)
        Me.XtraTabPage2.Controls.Add(Me.btSearchtop)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(691, 318)
        Me.XtraTabPage2.Text = "Change Room Type"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Location = New System.Drawing.Point(437, 257)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl3.TabIndex = 102
        Me.LabelControl3.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(437, 234)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 101
        Me.lbl28.Text = "*"
        '
        'btUpdate
        '
        Me.btUpdate.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUpdate.Appearance.Options.UseFont = True
        Me.btUpdate.Location = New System.Drawing.Point(530, 222)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(141, 37)
        Me.btUpdate.TabIndex = 100
        Me.btUpdate.Text = "Update Room"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Brown
        Me.LabelControl2.Location = New System.Drawing.Point(9, 289)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(235, 13)
        Me.LabelControl2.TabIndex = 99
        Me.LabelControl2.Text = "Select a row in the grid and Update/Del  room"
        '
        'gcResdetails
        '
        Me.gcResdetails.Location = New System.Drawing.Point(9, 76)
        Me.gcResdetails.LookAndFeel.SkinName = "Metropolis"
        Me.gcResdetails.MainView = Me.gdviewresdetails
        Me.gcResdetails.Name = "gcResdetails"
        Me.gcResdetails.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.gcResdetails.Size = New System.Drawing.Size(656, 87)
        Me.gcResdetails.TabIndex = 0
        Me.gcResdetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdviewresdetails})
        '
        'gdviewresdetails
        '
        Me.gdviewresdetails.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gdviewresdetails.Appearance.HeaderPanel.Options.UseFont = True
        Me.gdviewresdetails.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gdviewresdetails.Appearance.Row.Options.UseFont = True
        Me.gdviewresdetails.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colResDate, Me.colResType, Me.colGuest, Me.colArrDate, Me.colDepdate, Me.colAdultQty, Me.colChildrenQty, Me.colInfantsQty, Me.colMealPlan, Me.colBillingInst})
        Me.gdviewresdetails.GridControl = Me.gcResdetails
        Me.gdviewresdetails.Name = "gdviewresdetails"
        Me.gdviewresdetails.OptionsView.ShowGroupPanel = False
        '
        'colResDate
        '
        Me.colResDate.Caption = "Date"
        Me.colResDate.FieldName = "ResDate"
        Me.colResDate.Name = "colResDate"
        Me.colResDate.Visible = True
        Me.colResDate.VisibleIndex = 0
        Me.colResDate.Width = 51
        '
        'colResType
        '
        Me.colResType.Caption = "Type"
        Me.colResType.FieldName = "ResType"
        Me.colResType.Name = "colResType"
        Me.colResType.Visible = True
        Me.colResType.VisibleIndex = 9
        Me.colResType.Width = 131
        '
        'colGuest
        '
        Me.colGuest.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGuest.AppearanceCell.Options.UseFont = True
        Me.colGuest.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGuest.AppearanceHeader.Options.UseFont = True
        Me.colGuest.AppearanceHeader.Options.UseTextOptions = True
        Me.colGuest.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGuest.Caption = "Guest"
        Me.colGuest.FieldName = "Guest"
        Me.colGuest.Name = "colGuest"
        Me.colGuest.Visible = True
        Me.colGuest.VisibleIndex = 1
        Me.colGuest.Width = 72
        '
        'colArrDate
        '
        Me.colArrDate.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colArrDate.AppearanceCell.Options.UseFont = True
        Me.colArrDate.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colArrDate.AppearanceHeader.Options.UseFont = True
        Me.colArrDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colArrDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colArrDate.Caption = "Arrival "
        Me.colArrDate.FieldName = "ArrDate"
        Me.colArrDate.Name = "colArrDate"
        Me.colArrDate.Visible = True
        Me.colArrDate.VisibleIndex = 2
        Me.colArrDate.Width = 73
        '
        'colDepdate
        '
        Me.colDepdate.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDepdate.AppearanceCell.Options.UseFont = True
        Me.colDepdate.AppearanceCell.Options.UseTextOptions = True
        Me.colDepdate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDepdate.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDepdate.AppearanceHeader.Options.UseFont = True
        Me.colDepdate.AppearanceHeader.Options.UseTextOptions = True
        Me.colDepdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDepdate.Caption = "Departure"
        Me.colDepdate.FieldName = "DepDate"
        Me.colDepdate.Name = "colDepdate"
        Me.colDepdate.Visible = True
        Me.colDepdate.VisibleIndex = 3
        Me.colDepdate.Width = 73
        '
        'colAdultQty
        '
        Me.colAdultQty.Caption = "Adult"
        Me.colAdultQty.FieldName = "AdultQty"
        Me.colAdultQty.Name = "colAdultQty"
        Me.colAdultQty.Visible = True
        Me.colAdultQty.VisibleIndex = 4
        Me.colAdultQty.Width = 36
        '
        'colChildrenQty
        '
        Me.colChildrenQty.Caption = "Children"
        Me.colChildrenQty.FieldName = "ChildrenQty"
        Me.colChildrenQty.Name = "colChildrenQty"
        Me.colChildrenQty.Visible = True
        Me.colChildrenQty.VisibleIndex = 5
        Me.colChildrenQty.Width = 39
        '
        'colInfantsQty
        '
        Me.colInfantsQty.Caption = "Infants"
        Me.colInfantsQty.FieldName = "InfantsQty"
        Me.colInfantsQty.Name = "colInfantsQty"
        Me.colInfantsQty.Visible = True
        Me.colInfantsQty.VisibleIndex = 6
        Me.colInfantsQty.Width = 39
        '
        'colMealPlan
        '
        Me.colMealPlan.Caption = "Meal Plan"
        Me.colMealPlan.FieldName = "MealPlan"
        Me.colMealPlan.Name = "colMealPlan"
        Me.colMealPlan.Visible = True
        Me.colMealPlan.VisibleIndex = 7
        Me.colMealPlan.Width = 48
        '
        'colBillingInst
        '
        Me.colBillingInst.Caption = "Bed Nights"
        Me.colBillingInst.FieldName = "BedNights"
        Me.colBillingInst.Name = "colBillingInst"
        Me.colBillingInst.Visible = True
        Me.colBillingInst.VisibleIndex = 8
        Me.colBillingInst.Width = 65
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'gcPax
        '
        Me.gcPax.Location = New System.Drawing.Point(9, 181)
        Me.gcPax.LookAndFeel.SkinName = "Metropolis"
        Me.gcPax.MainView = Me.gvroomdetails
        Me.gcPax.Name = "gcPax"
        Me.gcPax.Size = New System.Drawing.Size(269, 102)
        Me.gcPax.TabIndex = 0
        Me.gcPax.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvroomdetails})
        '
        'gvroomdetails
        '
        Me.gvroomdetails.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvroomdetails.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvroomdetails.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvroomdetails.Appearance.Row.Options.UseFont = True
        Me.gvroomdetails.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcRoom, Me.gcRooTyp, Me.gcRoomcount, Me.gcBednights})
        Me.gvroomdetails.GridControl = Me.gcPax
        Me.gvroomdetails.Name = "gvroomdetails"
        Me.gvroomdetails.OptionsView.ShowGroupPanel = False
        '
        'gcRoom
        '
        Me.gcRoom.Caption = "Room"
        Me.gcRoom.FieldName = "Room"
        Me.gcRoom.Name = "gcRoom"
        Me.gcRoom.Visible = True
        Me.gcRoom.VisibleIndex = 0
        Me.gcRoom.Width = 63
        '
        'gcRooTyp
        '
        Me.gcRooTyp.Caption = "Type"
        Me.gcRooTyp.FieldName = "Roomtype"
        Me.gcRooTyp.Name = "gcRooTyp"
        Me.gcRooTyp.Visible = True
        Me.gcRooTyp.VisibleIndex = 1
        Me.gcRooTyp.Width = 63
        '
        'gcRoomcount
        '
        Me.gcRoomcount.Caption = "Count"
        Me.gcRoomcount.FieldName = "RoomCount"
        Me.gcRoomcount.Name = "gcRoomcount"
        Me.gcRoomcount.Visible = True
        Me.gcRoomcount.VisibleIndex = 2
        Me.gcRoomcount.Width = 50
        '
        'gcBednights
        '
        Me.gcBednights.Caption = "Bed Nights"
        Me.gcBednights.FieldName = "BedNights"
        Me.gcBednights.Name = "gcBednights"
        Me.gcBednights.Visible = True
        Me.gcBednights.VisibleIndex = 3
        '
        'btDelRoom
        '
        Me.btDelRoom.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDelRoom.Appearance.Options.UseFont = True
        Me.btDelRoom.Location = New System.Drawing.Point(530, 265)
        Me.btDelRoom.Name = "btDelRoom"
        Me.btDelRoom.Size = New System.Drawing.Size(141, 37)
        Me.btDelRoom.TabIndex = 98
        Me.btDelRoom.Text = "Delete Room"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Location = New System.Drawing.Point(311, 207)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl16.TabIndex = 97
        Me.LabelControl16.Text = "Room Type"
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Location = New System.Drawing.Point(310, 181)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl18.TabIndex = 96
        Me.LabelControl18.Text = "Room "
        '
        'txtBednights
        '
        Me.txtBednights.EditValue = ""
        Me.txtBednights.Location = New System.Drawing.Point(395, 256)
        Me.txtBednights.Name = "txtBednights"
        Me.txtBednights.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBednights.Properties.Appearance.Options.UseFont = True
        Me.txtBednights.Size = New System.Drawing.Size(36, 20)
        Me.txtBednights.TabIndex = 95
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(311, 259)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl5.TabIndex = 94
        Me.LabelControl5.Text = "Bed Nights"
        '
        'cmbRoomtyp
        '
        Me.cmbRoomtyp.Location = New System.Drawing.Point(395, 204)
        Me.cmbRoomtyp.Name = "cmbRoomtyp"
        Me.cmbRoomtyp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRoomtyp.Properties.Items.AddRange(New Object() {"Single", "Double", "Triple", "Child"})
        Me.cmbRoomtyp.Size = New System.Drawing.Size(95, 20)
        Me.cmbRoomtyp.TabIndex = 91
        '
        'txtRoomcount
        '
        Me.txtRoomcount.Location = New System.Drawing.Point(395, 230)
        Me.txtRoomcount.Name = "txtRoomcount"
        Me.txtRoomcount.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomcount.Properties.Appearance.Options.UseFont = True
        Me.txtRoomcount.Size = New System.Drawing.Size(36, 20)
        Me.txtRoomcount.TabIndex = 92
        '
        'cmbRoom
        '
        Me.cmbRoom.Location = New System.Drawing.Point(395, 178)
        Me.cmbRoom.Name = "cmbRoom"
        Me.cmbRoom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRoom.Properties.Items.AddRange(New Object() {"Standard", "Superior", "Deluxe"})
        Me.cmbRoom.Size = New System.Drawing.Size(95, 20)
        Me.cmbRoom.TabIndex = 90
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Location = New System.Drawing.Point(310, 233)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl17.TabIndex = 93
        Me.LabelControl17.Text = "Room Qty"
        '
        'btResDetails
        '
        Me.btResDetails.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btResDetails.Appearance.Options.UseFont = True
        Me.btResDetails.Location = New System.Drawing.Point(240, 38)
        Me.btResDetails.Name = "btResDetails"
        Me.btResDetails.Size = New System.Drawing.Size(100, 23)
        Me.btResDetails.TabIndex = 79
        Me.btResDetails.Text = "View Details"
        '
        'btSearchothers
        '
        Me.btSearchothers.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSearchothers.Appearance.Options.UseFont = True
        Me.btSearchothers.Location = New System.Drawing.Point(346, 9)
        Me.btSearchothers.Name = "btSearchothers"
        Me.btSearchothers.Size = New System.Drawing.Size(105, 23)
        Me.btSearchothers.TabIndex = 78
        Me.btSearchothers.Text = "Other Res"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelControl1.Location = New System.Drawing.Point(9, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 73
        Me.LabelControl1.Text = "Tour Operator"
        '
        'cmbResnos
        '
        Me.cmbResnos.Location = New System.Drawing.Point(94, 39)
        Me.cmbResnos.Name = "cmbResnos"
        Me.cmbResnos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbResnos.Size = New System.Drawing.Size(135, 20)
        Me.cmbResnos.TabIndex = 77
        '
        'cbTopcode
        '
        Me.cbTopcode.Location = New System.Drawing.Point(94, 12)
        Me.cbTopcode.Name = "cbTopcode"
        Me.cbTopcode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTopcode.Size = New System.Drawing.Size(135, 20)
        Me.cbTopcode.TabIndex = 74
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelControl13.Location = New System.Drawing.Point(9, 42)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl13.TabIndex = 76
        Me.LabelControl13.Text = "Reservation No"
        '
        'btSearchtop
        '
        Me.btSearchtop.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSearchtop.Appearance.Options.UseFont = True
        Me.btSearchtop.Location = New System.Drawing.Point(240, 9)
        Me.btSearchtop.Name = "btSearchtop"
        Me.btSearchtop.Size = New System.Drawing.Size(100, 23)
        Me.btSearchtop.TabIndex = 75
        Me.btSearchtop.Text = "TOP Res"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(710, 331)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 17
        '
        'frmRoomChange
        '
        Me.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(811, 374)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmRoomChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Allocation Edit"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.gcResdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdviewresdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvroomdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBednights.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRoomtyp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoomcount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRoom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbResnos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTopcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btResDetails As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btSearchothers As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbResnos As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbTopcode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btSearchtop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcResdetails As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdviewresdetails As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colResDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGuest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArrDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdultQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChildrenQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInfantsQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMealPlan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillingInst As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gcPax As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvroomdetails As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcRoom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRooTyp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRoomcount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtBednights As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbRoomtyp As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtRoomcount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbRoom As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btDelRoom As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcBednights As DevExpress.XtraGrid.Columns.GridColumn
End Class
