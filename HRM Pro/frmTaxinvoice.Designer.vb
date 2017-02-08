<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaxinvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTaxinvoice))
        Me.tabTaxinvocie = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcTaxinv = New DevExpress.XtraGrid.GridControl()
        Me.gvtaxinvs = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtTaxinvnoMas = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.gbOthers = New System.Windows.Forms.GroupBox()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotBedtimetax = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBedtimetax = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtBednights = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFinaltot = New DevExpress.XtraEditors.TextEdit()
        Me.txtReferencesTop = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReferences = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRemarks = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.gbTax = New System.Windows.Forms.GroupBox()
        Me.btTaxdel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbTax = New DevExpress.XtraEditors.LookUpEdit()
        Me.btTaxApply = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.gcTaxDetail = New DevExpress.XtraGrid.GridControl()
        Me.gvProTax = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gbRates = New System.Windows.Forms.GroupBox()
        Me.txtTransferrate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTransferrateDep = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTransferrateArr = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisscounts = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRate = New DevExpress.XtraEditors.TextEdit()
        Me.gbRoomdetails = New System.Windows.Forms.GroupBox()
        Me.gcPax = New DevExpress.XtraGrid.GridControl()
        Me.gvroomdetails = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcRoom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRooTyp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcRoomcount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gbRes = New System.Windows.Forms.GroupBox()
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
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.DtToday = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btResDetails = New DevExpress.XtraEditors.SimpleButton()
        Me.btSearchothers = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTaxinvno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbProInvNo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbTopcode = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.btSearchtop = New DevExpress.XtraEditors.SimpleButton()
        Me.btRev = New DevExpress.XtraEditors.SimpleButton()
        Me.btDel = New DevExpress.XtraEditors.SimpleButton()
        Me.btEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.btAddTax = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tabTaxinvocie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTaxinvocie.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcTaxinv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvtaxinvs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtTaxinvnoMas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOthers.SuspendLayout()
        CType(Me.txtTotBedtimetax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBedtimetax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBednights.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinaltot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferencesTop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReferences.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTax.SuspendLayout()
        CType(Me.cmbTax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcTaxDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProTax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRates.SuspendLayout()
        CType(Me.txtTransferrate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransferrateDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransferrateArr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisscounts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRoomdetails.SuspendLayout()
        CType(Me.gcPax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvroomdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRes.SuspendLayout()
        CType(Me.gcResdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdviewresdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtToday.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtToday.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTaxinvno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProInvNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTopcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabTaxinvocie
        '
        Me.tabTaxinvocie.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabTaxinvocie.AppearancePage.Header.Options.UseFont = True
        Me.tabTaxinvocie.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabTaxinvocie.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabTaxinvocie.Location = New System.Drawing.Point(12, 12)
        Me.tabTaxinvocie.Name = "tabTaxinvocie"
        Me.tabTaxinvocie.SelectedTabPage = Me.XtraTabPage1
        Me.tabTaxinvocie.Size = New System.Drawing.Size(839, 603)
        Me.tabTaxinvocie.TabIndex = 0
        Me.tabTaxinvocie.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcTaxinv)
        Me.XtraTabPage1.Controls.Add(Me.SimpleButton4)
        Me.XtraTabPage1.Controls.Add(Me.ComboBoxEdit1)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(837, 578)
        Me.XtraTabPage1.Text = "Tax  Invoice List"
        '
        'gcTaxinv
        '
        Me.gcTaxinv.Location = New System.Drawing.Point(9, 41)
        Me.gcTaxinv.MainView = Me.gvtaxinvs
        Me.gcTaxinv.Name = "gcTaxinv"
        Me.gcTaxinv.Size = New System.Drawing.Size(821, 529)
        Me.gcTaxinv.TabIndex = 8
        Me.gcTaxinv.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvtaxinvs})
        '
        'gvtaxinvs
        '
        Me.gvtaxinvs.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvtaxinvs.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvtaxinvs.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvtaxinvs.Appearance.Row.Options.UseFont = True
        Me.gvtaxinvs.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn1, Me.GridColumn2, Me.GridColumn6, Me.GridColumn3, Me.GridColumn4})
        Me.gvtaxinvs.GridControl = Me.gcTaxinv
        Me.gvtaxinvs.Name = "gvtaxinvs"
        Me.gvtaxinvs.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tax Mas Inv No"
        Me.GridColumn5.FieldName = "TaxInvNoMas"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 150
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceCell.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Tax Inv No"
        Me.GridColumn1.FieldName = "TaxInvNo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 175
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceCell.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Pro Inv No"
        Me.GridColumn2.FieldName = "ProInvNoMas"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 116
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "ResNo"
        Me.GridColumn6.FieldName = "ResNO"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceCell.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Inv Date"
        Me.GridColumn3.FieldName = "TaxInvDate"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 173
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Final Total"
        Me.GridColumn4.FieldName = "FinalTot"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        Me.GridColumn4.Width = 178
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Location = New System.Drawing.Point(230, 11)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButton4.TabIndex = 4
        Me.SimpleButton4.Text = "Search"
        Me.SimpleButton4.Visible = False
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(98, 14)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(100, 20)
        Me.ComboBoxEdit1.TabIndex = 3
        Me.ComboBoxEdit1.Visible = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(9, 17)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl12.TabIndex = 2
        Me.LabelControl12.Text = "Tour Operator"
        Me.LabelControl12.Visible = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.txtTaxinvnoMas)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl27)
        Me.XtraTabPage2.Controls.Add(Me.gbOthers)
        Me.XtraTabPage2.Controls.Add(Me.gbTax)
        Me.XtraTabPage2.Controls.Add(Me.gbRates)
        Me.XtraTabPage2.Controls.Add(Me.gbRoomdetails)
        Me.XtraTabPage2.Controls.Add(Me.gbRes)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl17)
        Me.XtraTabPage2.Controls.Add(Me.DtToday)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage2.Controls.Add(Me.btResDetails)
        Me.XtraTabPage2.Controls.Add(Me.btSearchothers)
        Me.XtraTabPage2.Controls.Add(Me.txtTaxinvno)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.cmbProInvNo)
        Me.XtraTabPage2.Controls.Add(Me.cbTopcode)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl13)
        Me.XtraTabPage2.Controls.Add(Me.btSearchtop)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(837, 578)
        Me.XtraTabPage2.Text = "New Tax Invoice"
        '
        'txtTaxinvnoMas
        '
        Me.txtTaxinvnoMas.EditValue = ""
        Me.txtTaxinvnoMas.Location = New System.Drawing.Point(688, 51)
        Me.txtTaxinvnoMas.Name = "txtTaxinvnoMas"
        Me.txtTaxinvnoMas.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxinvnoMas.Properties.Appearance.Options.UseFont = True
        Me.txtTaxinvnoMas.Properties.ReadOnly = True
        Me.txtTaxinvnoMas.Size = New System.Drawing.Size(135, 20)
        Me.txtTaxinvnoMas.TabIndex = 97
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl27.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelControl27.Location = New System.Drawing.Point(599, 54)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl27.TabIndex = 96
        Me.LabelControl27.Text = "Tax Inv Mas No"
        '
        'gbOthers
        '
        Me.gbOthers.Controls.Add(Me.LabelControl24)
        Me.gbOthers.Controls.Add(Me.LabelControl25)
        Me.gbOthers.Controls.Add(Me.txtTotBedtimetax)
        Me.gbOthers.Controls.Add(Me.LabelControl8)
        Me.gbOthers.Controls.Add(Me.LabelControl23)
        Me.gbOthers.Controls.Add(Me.txtBedtimetax)
        Me.gbOthers.Controls.Add(Me.LabelControl16)
        Me.gbOthers.Controls.Add(Me.LabelControl15)
        Me.gbOthers.Controls.Add(Me.LabelControl11)
        Me.gbOthers.Controls.Add(Me.txtBednights)
        Me.gbOthers.Controls.Add(Me.LabelControl3)
        Me.gbOthers.Controls.Add(Me.txtFinaltot)
        Me.gbOthers.Controls.Add(Me.txtReferencesTop)
        Me.gbOthers.Controls.Add(Me.LabelControl18)
        Me.gbOthers.Controls.Add(Me.txtReferences)
        Me.gbOthers.Controls.Add(Me.LabelControl10)
        Me.gbOthers.Controls.Add(Me.txtRemarks)
        Me.gbOthers.Controls.Add(Me.LabelControl4)
        Me.gbOthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbOthers.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOthers.Location = New System.Drawing.Point(12, 378)
        Me.gbOthers.Name = "gbOthers"
        Me.gbOthers.Size = New System.Drawing.Size(817, 194)
        Me.gbOthers.TabIndex = 95
        Me.gbOthers.TabStop = False
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl24.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl24.Location = New System.Drawing.Point(711, 59)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl24.TabIndex = 122
        Me.LabelControl24.Text = "*"
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl25.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelControl25.Location = New System.Drawing.Point(517, 61)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl25.TabIndex = 121
        Me.LabelControl25.Text = "Tot Green Tax ( $ )"
        '
        'txtTotBedtimetax
        '
        Me.txtTotBedtimetax.EditValue = ""
        Me.txtTotBedtimetax.Location = New System.Drawing.Point(611, 60)
        Me.txtTotBedtimetax.Name = "txtTotBedtimetax"
        Me.txtTotBedtimetax.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotBedtimetax.Properties.Appearance.Options.UseFont = True
        Me.txtTotBedtimetax.Properties.ReadOnly = True
        Me.txtTotBedtimetax.Size = New System.Drawing.Size(94, 20)
        Me.txtTotBedtimetax.TabIndex = 120
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl8.Location = New System.Drawing.Point(471, 63)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl8.TabIndex = 119
        Me.LabelControl8.Text = "*"
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl23.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelControl23.Location = New System.Drawing.Point(319, 61)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl23.TabIndex = 118
        Me.LabelControl23.Text = "Green  Tax ( $ )"
        '
        'txtBedtimetax
        '
        Me.txtBedtimetax.EditValue = "6"
        Me.txtBedtimetax.Location = New System.Drawing.Point(412, 59)
        Me.txtBedtimetax.Name = "txtBedtimetax"
        Me.txtBedtimetax.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBedtimetax.Properties.Appearance.Options.UseFont = True
        Me.txtBedtimetax.Size = New System.Drawing.Size(51, 20)
        Me.txtBedtimetax.TabIndex = 117
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl16.Location = New System.Drawing.Point(261, 59)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl16.TabIndex = 116
        Me.LabelControl16.Text = "*"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl15.Location = New System.Drawing.Point(262, 21)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl15.TabIndex = 115
        Me.LabelControl15.Text = "*"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelControl11.Location = New System.Drawing.Point(9, 59)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl11.TabIndex = 114
        Me.LabelControl11.Text = "No Of Bed Nights"
        '
        'txtBednights
        '
        Me.txtBednights.Location = New System.Drawing.Point(118, 56)
        Me.txtBednights.Name = "txtBednights"
        Me.txtBednights.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBednights.Properties.Appearance.Options.UseFont = True
        Me.txtBednights.Size = New System.Drawing.Size(139, 20)
        Me.txtBednights.TabIndex = 113
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelControl3.Location = New System.Drawing.Point(9, 21)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl3.TabIndex = 112
        Me.LabelControl3.Text = "Final Total ( $ )"
        '
        'txtFinaltot
        '
        Me.txtFinaltot.Location = New System.Drawing.Point(118, 18)
        Me.txtFinaltot.Name = "txtFinaltot"
        Me.txtFinaltot.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinaltot.Properties.Appearance.Options.UseFont = True
        Me.txtFinaltot.Size = New System.Drawing.Size(139, 20)
        Me.txtFinaltot.TabIndex = 111
        '
        'txtReferencesTop
        '
        Me.txtReferencesTop.Location = New System.Drawing.Point(120, 157)
        Me.txtReferencesTop.Name = "txtReferencesTop"
        Me.txtReferencesTop.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencesTop.Properties.Appearance.Options.UseFont = True
        Me.txtReferencesTop.Size = New System.Drawing.Size(587, 20)
        Me.txtReferencesTop.TabIndex = 104
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelControl18.Location = New System.Drawing.Point(11, 163)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(106, 13)
        Me.LabelControl18.TabIndex = 103
        Me.LabelControl18.Text = "Operator References"
        '
        'txtReferences
        '
        Me.txtReferences.Location = New System.Drawing.Point(120, 127)
        Me.txtReferences.Name = "txtReferences"
        Me.txtReferences.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferences.Properties.Appearance.Options.UseFont = True
        Me.txtReferences.Size = New System.Drawing.Size(587, 20)
        Me.txtReferences.TabIndex = 98
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelControl10.Location = New System.Drawing.Point(11, 130)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl10.TabIndex = 97
        Me.LabelControl10.Text = "References"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(120, 93)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Properties.Appearance.Options.UseFont = True
        Me.txtRemarks.Size = New System.Drawing.Size(587, 20)
        Me.txtRemarks.TabIndex = 73
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelControl4.Location = New System.Drawing.Point(11, 100)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl4.TabIndex = 72
        Me.LabelControl4.Text = "Remarks"
        '
        'gbTax
        '
        Me.gbTax.Controls.Add(Me.btTaxdel)
        Me.gbTax.Controls.Add(Me.cmbTax)
        Me.gbTax.Controls.Add(Me.btTaxApply)
        Me.gbTax.Controls.Add(Me.LabelControl9)
        Me.gbTax.Controls.Add(Me.gcTaxDetail)
        Me.gbTax.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbTax.Location = New System.Drawing.Point(572, 230)
        Me.gbTax.Name = "gbTax"
        Me.gbTax.Size = New System.Drawing.Size(255, 148)
        Me.gbTax.TabIndex = 94
        Me.gbTax.TabStop = False
        Me.gbTax.Text = "Tax"
        '
        'btTaxdel
        '
        Me.btTaxdel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTaxdel.Appearance.Options.UseFont = True
        Me.btTaxdel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btTaxdel.Location = New System.Drawing.Point(200, 20)
        Me.btTaxdel.Name = "btTaxdel"
        Me.btTaxdel.Size = New System.Drawing.Size(44, 23)
        Me.btTaxdel.TabIndex = 100
        Me.btTaxdel.Text = "Del"
        '
        'cmbTax
        '
        Me.cmbTax.Location = New System.Drawing.Point(39, 23)
        Me.cmbTax.Name = "cmbTax"
        Me.cmbTax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTax.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TaxID", 5, "Tax Id"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TaxName", 12, "Tax"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Taxpercentage", 5, "%")})
        Me.cmbTax.Properties.NullText = ""
        Me.cmbTax.Size = New System.Drawing.Size(105, 20)
        Me.cmbTax.TabIndex = 99
        '
        'btTaxApply
        '
        Me.btTaxApply.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTaxApply.Appearance.Options.UseFont = True
        Me.btTaxApply.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btTaxApply.Location = New System.Drawing.Point(150, 20)
        Me.btTaxApply.Name = "btTaxApply"
        Me.btTaxApply.Size = New System.Drawing.Size(44, 23)
        Me.btTaxApply.TabIndex = 94
        Me.btTaxApply.Text = "Apply"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(6, 24)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl9.TabIndex = 35
        Me.LabelControl9.Text = "Taxes"
        '
        'gcTaxDetail
        '
        Me.gcTaxDetail.Location = New System.Drawing.Point(11, 49)
        Me.gcTaxDetail.LookAndFeel.SkinName = "Metropolis"
        Me.gcTaxDetail.MainView = Me.gvProTax
        Me.gcTaxDetail.Name = "gcTaxDetail"
        Me.gcTaxDetail.Size = New System.Drawing.Size(233, 82)
        Me.gcTaxDetail.TabIndex = 1
        Me.gcTaxDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProTax})
        '
        'gvProTax
        '
        Me.gvProTax.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvProTax.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvProTax.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvProTax.Appearance.Row.Options.UseFont = True
        Me.gvProTax.GridControl = Me.gcTaxDetail
        Me.gvProTax.Name = "gvProTax"
        Me.gvProTax.OptionsView.ShowGroupPanel = False
        '
        'gbRates
        '
        Me.gbRates.Controls.Add(Me.txtTransferrate)
        Me.gbRates.Controls.Add(Me.LabelControl22)
        Me.gbRates.Controls.Add(Me.LabelControl21)
        Me.gbRates.Controls.Add(Me.LabelControl19)
        Me.gbRates.Controls.Add(Me.txtTransferrateDep)
        Me.gbRates.Controls.Add(Me.LabelControl20)
        Me.gbRates.Controls.Add(Me.LabelControl14)
        Me.gbRates.Controls.Add(Me.lbl28)
        Me.gbRates.Controls.Add(Me.txtTransferrateArr)
        Me.gbRates.Controls.Add(Me.txtDisscounts)
        Me.gbRates.Controls.Add(Me.LabelControl7)
        Me.gbRates.Controls.Add(Me.LabelControl6)
        Me.gbRates.Controls.Add(Me.txtRate)
        Me.gbRates.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRates.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbRates.Location = New System.Drawing.Point(272, 230)
        Me.gbRates.Name = "gbRates"
        Me.gbRates.Size = New System.Drawing.Size(294, 148)
        Me.gbRates.TabIndex = 93
        Me.gbRates.TabStop = False
        Me.gbRates.Text = "Rate  Details"
        '
        'txtTransferrate
        '
        Me.txtTransferrate.Location = New System.Drawing.Point(199, 111)
        Me.txtTransferrate.Name = "txtTransferrate"
        Me.txtTransferrate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferrate.Properties.Appearance.Options.UseFont = True
        Me.txtTransferrate.Size = New System.Drawing.Size(73, 20)
        Me.txtTransferrate.TabIndex = 119
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Location = New System.Drawing.Point(7, 71)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl22.TabIndex = 118
        Me.LabelControl22.Text = "Transfer Rate ( $ )"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Location = New System.Drawing.Point(9, 94)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl21.TabIndex = 117
        Me.LabelControl21.Text = "Arrival"
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl19.Location = New System.Drawing.Point(184, 115)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl19.TabIndex = 116
        Me.LabelControl19.Text = "*"
        '
        'txtTransferrateDep
        '
        Me.txtTransferrateDep.Location = New System.Drawing.Point(109, 111)
        Me.txtTransferrateDep.Name = "txtTransferrateDep"
        Me.txtTransferrateDep.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferrateDep.Properties.Appearance.Options.UseFont = True
        Me.txtTransferrateDep.Size = New System.Drawing.Size(73, 20)
        Me.txtTransferrateDep.TabIndex = 115
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl20.Location = New System.Drawing.Point(109, 95)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl20.TabIndex = 114
        Me.LabelControl20.Text = "Departure"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl14.Location = New System.Drawing.Point(87, 116)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl14.TabIndex = 113
        Me.LabelControl14.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(237, 18)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 112
        Me.lbl28.Text = "*"
        '
        'txtTransferrateArr
        '
        Me.txtTransferrateArr.Location = New System.Drawing.Point(8, 111)
        Me.txtTransferrateArr.Name = "txtTransferrateArr"
        Me.txtTransferrateArr.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferrateArr.Properties.Appearance.Options.UseFont = True
        Me.txtTransferrateArr.Size = New System.Drawing.Size(77, 20)
        Me.txtTransferrateArr.TabIndex = 111
        '
        'txtDisscounts
        '
        Me.txtDisscounts.Location = New System.Drawing.Point(115, 42)
        Me.txtDisscounts.Name = "txtDisscounts"
        Me.txtDisscounts.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisscounts.Properties.Appearance.Options.UseFont = True
        Me.txtDisscounts.Size = New System.Drawing.Size(116, 20)
        Me.txtDisscounts.TabIndex = 110
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(8, 45)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl7.TabIndex = 109
        Me.LabelControl7.Text = "Discounts ( $ )"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(9, 20)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl6.TabIndex = 108
        Me.LabelControl6.Text = "Rate ( $ )"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(115, 17)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Properties.Appearance.Options.UseFont = True
        Me.txtRate.Size = New System.Drawing.Size(116, 20)
        Me.txtRate.TabIndex = 107
        '
        'gbRoomdetails
        '
        Me.gbRoomdetails.Controls.Add(Me.gcPax)
        Me.gbRoomdetails.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRoomdetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbRoomdetails.Location = New System.Drawing.Point(10, 230)
        Me.gbRoomdetails.Name = "gbRoomdetails"
        Me.gbRoomdetails.Size = New System.Drawing.Size(256, 148)
        Me.gbRoomdetails.TabIndex = 92
        Me.gbRoomdetails.TabStop = False
        Me.gbRoomdetails.Text = "Room  Details"
        '
        'gcPax
        '
        Me.gcPax.Location = New System.Drawing.Point(11, 21)
        Me.gcPax.LookAndFeel.SkinName = "Metropolis"
        Me.gcPax.MainView = Me.gvroomdetails
        Me.gcPax.Name = "gcPax"
        Me.gcPax.Size = New System.Drawing.Size(239, 121)
        Me.gcPax.TabIndex = 0
        Me.gcPax.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvroomdetails})
        '
        'gvroomdetails
        '
        Me.gvroomdetails.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvroomdetails.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvroomdetails.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvroomdetails.Appearance.Row.Options.UseFont = True
        Me.gvroomdetails.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcRoom, Me.gcRooTyp, Me.gcRoomcount})
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
        'gbRes
        '
        Me.gbRes.Controls.Add(Me.gcResdetails)
        Me.gbRes.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbRes.Location = New System.Drawing.Point(6, 110)
        Me.gbRes.Name = "gbRes"
        Me.gbRes.Size = New System.Drawing.Size(817, 114)
        Me.gbRes.TabIndex = 91
        Me.gbRes.TabStop = False
        Me.gbRes.Text = "Reservation  Details"
        '
        'gcResdetails
        '
        Me.gcResdetails.Location = New System.Drawing.Point(6, 19)
        Me.gcResdetails.LookAndFeel.SkinName = "Metropolis"
        Me.gcResdetails.MainView = Me.gdviewresdetails
        Me.gcResdetails.Name = "gcResdetails"
        Me.gcResdetails.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.gcResdetails.Size = New System.Drawing.Size(805, 87)
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
        Me.colResDate.Width = 70
        '
        'colResType
        '
        Me.colResType.Caption = "Type"
        Me.colResType.FieldName = "ResType"
        Me.colResType.Name = "colResType"
        Me.colResType.Visible = True
        Me.colResType.VisibleIndex = 9
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
        Me.colGuest.Width = 98
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
        Me.colArrDate.Width = 100
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
        Me.colDepdate.Width = 100
        '
        'colAdultQty
        '
        Me.colAdultQty.Caption = "Adult"
        Me.colAdultQty.FieldName = "AdultQty"
        Me.colAdultQty.Name = "colAdultQty"
        Me.colAdultQty.Visible = True
        Me.colAdultQty.VisibleIndex = 4
        Me.colAdultQty.Width = 50
        '
        'colChildrenQty
        '
        Me.colChildrenQty.Caption = "Children"
        Me.colChildrenQty.FieldName = "ChildrenQty"
        Me.colChildrenQty.Name = "colChildrenQty"
        Me.colChildrenQty.Visible = True
        Me.colChildrenQty.VisibleIndex = 5
        Me.colChildrenQty.Width = 53
        '
        'colInfantsQty
        '
        Me.colInfantsQty.Caption = "Infants"
        Me.colInfantsQty.FieldName = "InfantsQty"
        Me.colInfantsQty.Name = "colInfantsQty"
        Me.colInfantsQty.Visible = True
        Me.colInfantsQty.VisibleIndex = 6
        Me.colInfantsQty.Width = 53
        '
        'colMealPlan
        '
        Me.colMealPlan.Caption = "Meal Plan"
        Me.colMealPlan.FieldName = "MealPlan"
        Me.colMealPlan.Name = "colMealPlan"
        Me.colMealPlan.Visible = True
        Me.colMealPlan.VisibleIndex = 7
        Me.colMealPlan.Width = 66
        '
        'colBillingInst
        '
        Me.colBillingInst.Caption = "Billing Instruction"
        Me.colBillingInst.FieldName = "BillingInst"
        Me.colBillingInst.Name = "colBillingInst"
        Me.colBillingInst.Visible = True
        Me.colBillingInst.VisibleIndex = 8
        Me.colBillingInst.Width = 186
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl17.Location = New System.Drawing.Point(230, 58)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl17.TabIndex = 90
        Me.LabelControl17.Text = "*"
        '
        'DtToday
        '
        Me.DtToday.EditValue = Nothing
        Me.DtToday.Enabled = False
        Me.DtToday.Location = New System.Drawing.Point(688, 12)
        Me.DtToday.Name = "DtToday"
        Me.DtToday.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtToday.Properties.Appearance.Options.UseFont = True
        Me.DtToday.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtToday.Properties.ReadOnly = True
        Me.DtToday.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DtToday.Size = New System.Drawing.Size(135, 20)
        Me.DtToday.TabIndex = 89
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelControl5.Location = New System.Drawing.Point(599, 19)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl5.TabIndex = 88
        Me.LabelControl5.Text = "Date"
        '
        'btResDetails
        '
        Me.btResDetails.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btResDetails.Appearance.Options.UseFont = True
        Me.btResDetails.Location = New System.Drawing.Point(240, 54)
        Me.btResDetails.Name = "btResDetails"
        Me.btResDetails.Size = New System.Drawing.Size(100, 23)
        Me.btResDetails.TabIndex = 87
        Me.btResDetails.Text = "View Details"
        '
        'btSearchothers
        '
        Me.btSearchothers.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSearchothers.Appearance.Options.UseFont = True
        Me.btSearchothers.Location = New System.Drawing.Point(346, 13)
        Me.btSearchothers.Name = "btSearchothers"
        Me.btSearchothers.Size = New System.Drawing.Size(105, 23)
        Me.btSearchothers.TabIndex = 86
        Me.btSearchothers.Text = "Other Pro Inv"
        '
        'txtTaxinvno
        '
        Me.txtTaxinvno.EditValue = "INV-"
        Me.txtTaxinvno.Location = New System.Drawing.Point(688, 84)
        Me.txtTaxinvno.Name = "txtTaxinvno"
        Me.txtTaxinvno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxinvno.Properties.Appearance.Options.UseFont = True
        Me.txtTaxinvno.Properties.ReadOnly = True
        Me.txtTaxinvno.Size = New System.Drawing.Size(135, 20)
        Me.txtTaxinvno.TabIndex = 85
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelControl2.Location = New System.Drawing.Point(599, 87)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl2.TabIndex = 84
        Me.LabelControl2.Text = "Tax Inv TOP Ref"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelControl1.Location = New System.Drawing.Point(9, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 79
        Me.LabelControl1.Text = "Tour Operator"
        '
        'cmbProInvNo
        '
        Me.cmbProInvNo.Location = New System.Drawing.Point(94, 55)
        Me.cmbProInvNo.Name = "cmbProInvNo"
        Me.cmbProInvNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProInvNo.Size = New System.Drawing.Size(135, 20)
        Me.cmbProInvNo.TabIndex = 83
        '
        'cbTopcode
        '
        Me.cbTopcode.Location = New System.Drawing.Point(94, 16)
        Me.cbTopcode.Name = "cbTopcode"
        Me.cbTopcode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTopcode.Size = New System.Drawing.Size(135, 20)
        Me.cbTopcode.TabIndex = 80
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelControl13.Location = New System.Drawing.Point(9, 58)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl13.TabIndex = 82
        Me.LabelControl13.Text = "Pro Inv No"
        '
        'btSearchtop
        '
        Me.btSearchtop.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSearchtop.Appearance.Options.UseFont = True
        Me.btSearchtop.Location = New System.Drawing.Point(240, 13)
        Me.btSearchtop.Name = "btSearchtop"
        Me.btSearchtop.Size = New System.Drawing.Size(100, 23)
        Me.btSearchtop.TabIndex = 81
        Me.btSearchtop.Text = "TOP Pro Inv"
        '
        'btRev
        '
        Me.btRev.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRev.Appearance.Options.UseFont = True
        Me.btRev.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btRev.Location = New System.Drawing.Point(870, 152)
        Me.btRev.Name = "btRev"
        Me.btRev.Size = New System.Drawing.Size(103, 23)
        Me.btRev.TabIndex = 28
        Me.btRev.Text = "Reverse"
        Me.btRev.Visible = False
        '
        'btDel
        '
        Me.btDel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDel.Appearance.Options.UseFont = True
        Me.btDel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btDel.Location = New System.Drawing.Point(870, 94)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(103, 23)
        Me.btDel.TabIndex = 27
        Me.btDel.Text = "Inactivate"
        '
        'btEdit
        '
        Me.btEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEdit.Appearance.Options.UseFont = True
        Me.btEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btEdit.Location = New System.Drawing.Point(869, 65)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(104, 23)
        Me.btEdit.TabIndex = 25
        Me.btEdit.Text = "Edit"
        Me.btEdit.Visible = False
        '
        'btPrint
        '
        Me.btPrint.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPrint.Appearance.Options.UseFont = True
        Me.btPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btPrint.Location = New System.Drawing.Point(869, 123)
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(104, 23)
        Me.btPrint.TabIndex = 26
        Me.btPrint.Text = "Print"
        '
        'btAddTax
        '
        Me.btAddTax.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddTax.Appearance.Options.UseFont = True
        Me.btAddTax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btAddTax.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btAddTax.Location = New System.Drawing.Point(870, 36)
        Me.btAddTax.Name = "btAddTax"
        Me.btAddTax.Size = New System.Drawing.Size(103, 23)
        Me.btAddTax.TabIndex = 24
        Me.btAddTax.Text = "Create"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(857, 573)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(118, 42)
        Me.PictureEdit1.TabIndex = 29
        '
        'frmTaxinvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(979, 618)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btRev)
        Me.Controls.Add(Me.btDel)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btPrint)
        Me.Controls.Add(Me.btAddTax)
        Me.Controls.Add(Me.tabTaxinvocie)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmTaxinvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tax Invoice"
        CType(Me.tabTaxinvocie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTaxinvocie.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.gcTaxinv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvtaxinvs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtTaxinvnoMas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOthers.ResumeLayout(False)
        Me.gbOthers.PerformLayout()
        CType(Me.txtTotBedtimetax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBedtimetax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBednights.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinaltot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferencesTop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReferences.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTax.ResumeLayout(False)
        Me.gbTax.PerformLayout()
        CType(Me.cmbTax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcTaxDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProTax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRates.ResumeLayout(False)
        Me.gbRates.PerformLayout()
        CType(Me.txtTransferrate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransferrateDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransferrateArr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisscounts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRoomdetails.ResumeLayout(False)
        CType(Me.gcPax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvroomdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRes.ResumeLayout(False)
        CType(Me.gcResdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdviewresdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtToday.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtToday.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTaxinvno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProInvNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTopcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabTaxinvocie As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btRev As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAddTax As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents gcTaxinv As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvtaxinvs As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DtToday As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btResDetails As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btSearchothers As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTaxinvno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbProInvNo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbTopcode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btSearchtop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbRes As System.Windows.Forms.GroupBox
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
    Friend WithEvents gbTax As System.Windows.Forms.GroupBox
    Friend WithEvents btTaxdel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbTax As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btTaxApply As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcTaxDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvProTax As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gbRates As System.Windows.Forms.GroupBox
    Friend WithEvents gbRoomdetails As System.Windows.Forms.GroupBox
    Friend WithEvents gcPax As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvroomdetails As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcRoom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRooTyp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcRoomcount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gbOthers As System.Windows.Forms.GroupBox
    Friend WithEvents txtReferencesTop As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReferences As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRemarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTransferrate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTransferrateDep As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTransferrateArr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisscounts As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotBedtimetax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBedtimetax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBednights As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFinaltot As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTaxinvnoMas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
End Class
