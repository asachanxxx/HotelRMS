<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeMP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangeMP))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtExMP = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.btUpdateMP = New DevExpress.XtraEditors.SimpleButton()
        Me.gbRes = New System.Windows.Forms.GroupBox()
        Me.gcResdetails = New DevExpress.XtraGrid.GridControl()
        Me.gdviewresdetails = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colResDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGuest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArrDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdultQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChildrenQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInfantsQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBillingInst = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.cmbMealplan = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReservationno = New DevExpress.XtraEditors.TextEdit()
        Me.btUnblock = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.colTop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMealPlan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepdate = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtExMP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRes.SuspendLayout()
        CType(Me.gcResdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdviewresdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMealplan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReservationno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.XtraTabControl1.LookAndFeel.SkinName = "Metropolis"
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(834, 351)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.txtExMP)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.PictureEdit1)
        Me.XtraTabPage2.Controls.Add(Me.btUpdateMP)
        Me.XtraTabPage2.Controls.Add(Me.gbRes)
        Me.XtraTabPage2.Controls.Add(Me.cmbMealplan)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.txtReservationno)
        Me.XtraTabPage2.Controls.Add(Me.btUnblock)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(832, 326)
        Me.XtraTabPage2.Text = "Meal Plan"
        '
        'txtExMP
        '
        Me.txtExMP.EditValue = ""
        Me.txtExMP.Enabled = False
        Me.txtExMP.EnterMoveNextControl = True
        Me.txtExMP.Location = New System.Drawing.Point(119, 257)
        Me.txtExMP.Name = "txtExMP"
        Me.txtExMP.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExMP.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtExMP.Properties.Appearance.Options.UseFont = True
        Me.txtExMP.Properties.Appearance.Options.UseForeColor = True
        Me.txtExMP.Size = New System.Drawing.Size(136, 20)
        Me.txtExMP.TabIndex = 175
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl2.Location = New System.Drawing.Point(9, 260)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl2.TabIndex = 174
        Me.LabelControl2.Text = "Existing Meal Plan"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(722, 281)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 173
        '
        'btUpdateMP
        '
        Me.btUpdateMP.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUpdateMP.Appearance.Options.UseFont = True
        Me.btUpdateMP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btUpdateMP.Location = New System.Drawing.Point(261, 293)
        Me.btUpdateMP.Name = "btUpdateMP"
        Me.btUpdateMP.Size = New System.Drawing.Size(100, 23)
        Me.btUpdateMP.TabIndex = 117
        Me.btUpdateMP.Text = "Update MP"
        '
        'gbRes
        '
        Me.gbRes.Controls.Add(Me.gcResdetails)
        Me.gbRes.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbRes.Location = New System.Drawing.Point(10, 93)
        Me.gbRes.Name = "gbRes"
        Me.gbRes.Size = New System.Drawing.Size(818, 131)
        Me.gbRes.TabIndex = 116
        Me.gbRes.TabStop = False
        Me.gbRes.Text = "Reservation  Details"
        '
        'gcResdetails
        '
        Me.gcResdetails.Location = New System.Drawing.Point(7, 28)
        Me.gcResdetails.LookAndFeel.SkinName = "Metropolis"
        Me.gcResdetails.MainView = Me.gdviewresdetails
        Me.gcResdetails.Name = "gcResdetails"
        Me.gcResdetails.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.gcResdetails.Size = New System.Drawing.Size(805, 87)
        Me.gcResdetails.TabIndex = 1
        Me.gcResdetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gdviewresdetails})
        '
        'gdviewresdetails
        '
        Me.gdviewresdetails.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gdviewresdetails.Appearance.HeaderPanel.Options.UseFont = True
        Me.gdviewresdetails.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gdviewresdetails.Appearance.Row.Options.UseFont = True
        Me.gdviewresdetails.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colResDate, Me.colResType, Me.colGuest, Me.colArrDate, Me.GridColumn1, Me.colAdultQty, Me.colChildrenQty, Me.colInfantsQty, Me.GridColumn2, Me.colBillingInst, Me.GridColumn3})
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
        Me.colResDate.Width = 58
        '
        'colResType
        '
        Me.colResType.Caption = "Type"
        Me.colResType.FieldName = "ResType"
        Me.colResType.Name = "colResType"
        Me.colResType.Visible = True
        Me.colResType.VisibleIndex = 9
        Me.colResType.Width = 65
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
        Me.colGuest.Width = 82
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
        Me.colArrDate.Width = 83
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Departure"
        Me.GridColumn1.FieldName = "DepDate"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        Me.GridColumn1.Width = 83
        '
        'colAdultQty
        '
        Me.colAdultQty.Caption = "Adult"
        Me.colAdultQty.FieldName = "AdultQty"
        Me.colAdultQty.Name = "colAdultQty"
        Me.colAdultQty.Visible = True
        Me.colAdultQty.VisibleIndex = 4
        Me.colAdultQty.Width = 41
        '
        'colChildrenQty
        '
        Me.colChildrenQty.Caption = "Children"
        Me.colChildrenQty.FieldName = "ChildrenQty"
        Me.colChildrenQty.Name = "colChildrenQty"
        Me.colChildrenQty.Visible = True
        Me.colChildrenQty.VisibleIndex = 5
        Me.colChildrenQty.Width = 44
        '
        'colInfantsQty
        '
        Me.colInfantsQty.Caption = "Infants"
        Me.colInfantsQty.FieldName = "InfantsQty"
        Me.colInfantsQty.Name = "colInfantsQty"
        Me.colInfantsQty.Visible = True
        Me.colInfantsQty.VisibleIndex = 6
        Me.colInfantsQty.Width = 44
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Meal Plan"
        Me.GridColumn2.FieldName = "MealPlan"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 7
        Me.GridColumn2.Width = 55
        '
        'colBillingInst
        '
        Me.colBillingInst.Caption = "Billing Instruction"
        Me.colBillingInst.FieldName = "BillingInst"
        Me.colBillingInst.Name = "colBillingInst"
        Me.colBillingInst.Visible = True
        Me.colBillingInst.VisibleIndex = 8
        Me.colBillingInst.Width = 155
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "TOP"
        Me.GridColumn3.FieldName = "Topcode"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 10
        Me.GridColumn3.Width = 65
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'cmbMealplan
        '
        Me.cmbMealplan.Location = New System.Drawing.Point(119, 296)
        Me.cmbMealplan.Name = "cmbMealplan"
        Me.cmbMealplan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMealplan.Size = New System.Drawing.Size(136, 20)
        Me.cmbMealplan.TabIndex = 115
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.ForestGreen
        Me.LabelControl3.Location = New System.Drawing.Point(9, 299)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl3.TabIndex = 114
        Me.LabelControl3.Text = "New Meal Plan"
        '
        'txtReservationno
        '
        Me.txtReservationno.EditValue = "RES"
        Me.txtReservationno.EnterMoveNextControl = True
        Me.txtReservationno.Location = New System.Drawing.Point(108, 41)
        Me.txtReservationno.Name = "txtReservationno"
        Me.txtReservationno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReservationno.Properties.Appearance.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtReservationno.Properties.Appearance.Options.UseFont = True
        Me.txtReservationno.Properties.Appearance.Options.UseForeColor = True
        Me.txtReservationno.Size = New System.Drawing.Size(136, 20)
        Me.txtReservationno.TabIndex = 111
        '
        'btUnblock
        '
        Me.btUnblock.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUnblock.Appearance.Options.UseFont = True
        Me.btUnblock.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btUnblock.Location = New System.Drawing.Point(250, 38)
        Me.btUnblock.Name = "btUnblock"
        Me.btUnblock.Size = New System.Drawing.Size(100, 23)
        Me.btUnblock.TabIndex = 110
        Me.btUnblock.Text = "View Details"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelControl1.Location = New System.Drawing.Point(9, 44)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl1.TabIndex = 73
        Me.LabelControl1.Text = "Reservation No"
        '
        'colTop
        '
        Me.colTop.Caption = "TOP"
        Me.colTop.FieldName = "Topcode"
        Me.colTop.Name = "colTop"
        Me.colTop.Width = 65
        '
        'colMealPlan
        '
        Me.colMealPlan.Caption = "Meal Plan"
        Me.colMealPlan.FieldName = "MealPlan"
        Me.colMealPlan.Name = "colMealPlan"
        Me.colMealPlan.Width = 55
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
        Me.colDepdate.Width = 83
        '
        'frmChangeMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(851, 369)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmChangeMP"
        Me.Text = "Change Meal Plan"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtExMP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRes.ResumeLayout(False)
        CType(Me.gcResdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdviewresdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMealplan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReservationno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btUnblock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReservationno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbMealplan As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btUpdateMP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbRes As System.Windows.Forms.GroupBox
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents colTop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMealPlan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcResdetails As DevExpress.XtraGrid.GridControl
    Friend WithEvents gdviewresdetails As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colResDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGuest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArrDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdultQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChildrenQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInfantsQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillingInst As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtExMP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
