<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOfferComplimentary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOfferComplimentary))
        Me.tabOffers = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcOffer = New DevExpress.XtraGrid.GridControl()
        Me.gvOffer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btDelup = New DevExpress.XtraEditors.SimpleButton()
        Me.btAssign = New DevExpress.XtraEditors.SimpleButton()
        Me.gcTop = New DevExpress.XtraGrid.GridControl()
        Me.gcViewTop = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtTopname = New DevExpress.XtraEditors.TextEdit()
        Me.cbTopcode = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.CbTopInd = New DevExpress.XtraEditors.CheckEdit()
        Me.CbTopGroupC = New DevExpress.XtraEditors.CheckEdit()
        Me.CbTopGroupB = New DevExpress.XtraEditors.CheckEdit()
        Me.CbTopGroupA = New DevExpress.XtraEditors.CheckEdit()
        Me.CbTopGroup = New DevExpress.XtraEditors.CheckEdit()
        Me.CbTopAll = New DevExpress.XtraEditors.CheckEdit()
        Me.CbTop = New DevExpress.XtraEditors.CheckEdit()
        Me.CbComp = New DevExpress.XtraEditors.CheckEdit()
        Me.CbFIT = New DevExpress.XtraEditors.CheckEdit()
        Me.CbAll = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOfferdetail = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOffername = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.btDel = New DevExpress.XtraEditors.SimpleButton()
        Me.btEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tabOffers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOffers.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcOffer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvOffer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.gcTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcViewTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTopname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTopcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTopInd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTopGroupC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTopGroupB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTopGroupA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTopGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTopAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbTop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbComp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbFIT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOfferdetail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOffername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabOffers
        '
        Me.tabOffers.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabOffers.AppearancePage.Header.Options.UseFont = True
        Me.tabOffers.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabOffers.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabOffers.Location = New System.Drawing.Point(3, 12)
        Me.tabOffers.Name = "tabOffers"
        Me.tabOffers.SelectedTabPage = Me.XtraTabPage1
        Me.tabOffers.Size = New System.Drawing.Size(589, 402)
        Me.tabOffers.TabIndex = 0
        Me.tabOffers.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.gcOffer)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(587, 377)
        Me.XtraTabPage1.Text = "Offer Details"
        '
        'gcOffer
        '
        Me.gcOffer.Location = New System.Drawing.Point(8, 8)
        Me.gcOffer.MainView = Me.gvOffer
        Me.gcOffer.Name = "gcOffer"
        Me.gcOffer.Size = New System.Drawing.Size(576, 363)
        Me.gcOffer.TabIndex = 0
        Me.gcOffer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvOffer})
        '
        'gvOffer
        '
        Me.gvOffer.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvOffer.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvOffer.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvOffer.Appearance.Row.Options.UseFont = True
        Me.gvOffer.GridControl = Me.gcOffer
        Me.gvOffer.Name = "gvOffer"
        Me.gvOffer.OptionsView.ShowGroupPanel = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupBox5)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(587, 377)
        Me.XtraTabPage2.Text = "  New Offer     "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btDelup)
        Me.GroupBox5.Controls.Add(Me.btAssign)
        Me.GroupBox5.Controls.Add(Me.gcTop)
        Me.GroupBox5.Controls.Add(Me.txtTopname)
        Me.GroupBox5.Controls.Add(Me.cbTopcode)
        Me.GroupBox5.Controls.Add(Me.CbTopInd)
        Me.GroupBox5.Controls.Add(Me.CbTopGroupC)
        Me.GroupBox5.Controls.Add(Me.CbTopGroupB)
        Me.GroupBox5.Controls.Add(Me.CbTopGroupA)
        Me.GroupBox5.Controls.Add(Me.CbTopGroup)
        Me.GroupBox5.Controls.Add(Me.CbTopAll)
        Me.GroupBox5.Controls.Add(Me.CbTop)
        Me.GroupBox5.Controls.Add(Me.CbComp)
        Me.GroupBox5.Controls.Add(Me.CbFIT)
        Me.GroupBox5.Controls.Add(Me.CbAll)
        Me.GroupBox5.Controls.Add(Me.LabelControl2)
        Me.GroupBox5.Controls.Add(Me.txtOfferdetail)
        Me.GroupBox5.Controls.Add(Me.LabelControl10)
        Me.GroupBox5.Controls.Add(Me.txtOffername)
        Me.GroupBox5.Controls.Add(Me.LabelControl9)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(576, 368)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'btDelup
        '
        Me.btDelup.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDelup.Appearance.Options.UseFont = True
        Me.btDelup.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btDelup.Location = New System.Drawing.Point(539, 254)
        Me.btDelup.Name = "btDelup"
        Me.btDelup.Size = New System.Drawing.Size(29, 21)
        Me.btDelup.TabIndex = 106
        Me.btDelup.Text = "^"
        Me.btDelup.Visible = False
        '
        'btAssign
        '
        Me.btAssign.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAssign.Appearance.Options.UseFont = True
        Me.btAssign.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btAssign.Location = New System.Drawing.Point(504, 254)
        Me.btAssign.Name = "btAssign"
        Me.btAssign.Size = New System.Drawing.Size(29, 21)
        Me.btAssign.TabIndex = 105
        Me.btAssign.Text = "V"
        '
        'gcTop
        '
        Me.gcTop.AllowDrop = True
        Me.gcTop.Location = New System.Drawing.Point(209, 280)
        Me.gcTop.MainView = Me.gcViewTop
        Me.gcTop.Name = "gcTop"
        Me.gcTop.Size = New System.Drawing.Size(291, 84)
        Me.gcTop.TabIndex = 104
        Me.gcTop.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gcViewTop})
        '
        'gcViewTop
        '
        Me.gcViewTop.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcViewTop.Appearance.HeaderPanel.Options.UseFont = True
        Me.gcViewTop.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcViewTop.Appearance.Row.Options.UseFont = True
        Me.gcViewTop.GridControl = Me.gcTop
        Me.gcViewTop.Name = "gcViewTop"
        Me.gcViewTop.OptionsView.ShowGroupPanel = False
        '
        'txtTopname
        '
        Me.txtTopname.Enabled = False
        Me.txtTopname.Location = New System.Drawing.Point(296, 255)
        Me.txtTopname.Name = "txtTopname"
        Me.txtTopname.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopname.Properties.Appearance.Options.UseFont = True
        Me.txtTopname.Properties.ReadOnly = True
        Me.txtTopname.Size = New System.Drawing.Size(204, 20)
        Me.txtTopname.TabIndex = 103
        '
        'cbTopcode
        '
        Me.cbTopcode.EditValue = ""
        Me.cbTopcode.Enabled = False
        Me.cbTopcode.Location = New System.Drawing.Point(209, 255)
        Me.cbTopcode.Name = "cbTopcode"
        Me.cbTopcode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTopcode.Size = New System.Drawing.Size(78, 20)
        Me.cbTopcode.TabIndex = 102
        '
        'CbTopInd
        '
        Me.CbTopInd.Enabled = False
        Me.CbTopInd.Location = New System.Drawing.Point(143, 255)
        Me.CbTopInd.Name = "CbTopInd"
        Me.CbTopInd.Properties.Caption = "Selective"
        Me.CbTopInd.Size = New System.Drawing.Size(84, 19)
        Me.CbTopInd.TabIndex = 101
        '
        'CbTopGroupC
        '
        Me.CbTopGroupC.Enabled = False
        Me.CbTopGroupC.Location = New System.Drawing.Point(348, 223)
        Me.CbTopGroupC.Name = "CbTopGroupC"
        Me.CbTopGroupC.Properties.Caption = "Other"
        Me.CbTopGroupC.Size = New System.Drawing.Size(65, 19)
        Me.CbTopGroupC.TabIndex = 99
        '
        'CbTopGroupB
        '
        Me.CbTopGroupB.Enabled = False
        Me.CbTopGroupB.Location = New System.Drawing.Point(279, 223)
        Me.CbTopGroupB.Name = "CbTopGroupB"
        Me.CbTopGroupB.Properties.Caption = "Prepaid"
        Me.CbTopGroupB.Size = New System.Drawing.Size(62, 19)
        Me.CbTopGroupB.TabIndex = 98
        '
        'CbTopGroupA
        '
        Me.CbTopGroupA.Enabled = False
        Me.CbTopGroupA.Location = New System.Drawing.Point(224, 223)
        Me.CbTopGroupA.Name = "CbTopGroupA"
        Me.CbTopGroupA.Properties.Caption = "Credit"
        Me.CbTopGroupA.Size = New System.Drawing.Size(59, 19)
        Me.CbTopGroupA.TabIndex = 97
        '
        'CbTopGroup
        '
        Me.CbTopGroup.Enabled = False
        Me.CbTopGroup.Location = New System.Drawing.Point(143, 223)
        Me.CbTopGroup.Name = "CbTopGroup"
        Me.CbTopGroup.Properties.Caption = "Group"
        Me.CbTopGroup.Size = New System.Drawing.Size(75, 19)
        Me.CbTopGroup.TabIndex = 96
        '
        'CbTopAll
        '
        Me.CbTopAll.Enabled = False
        Me.CbTopAll.Location = New System.Drawing.Point(143, 198)
        Me.CbTopAll.Name = "CbTopAll"
        Me.CbTopAll.Properties.Caption = "All"
        Me.CbTopAll.Size = New System.Drawing.Size(49, 19)
        Me.CbTopAll.TabIndex = 95
        '
        'CbTop
        '
        Me.CbTop.Location = New System.Drawing.Point(101, 173)
        Me.CbTop.Name = "CbTop"
        Me.CbTop.Properties.Caption = "Tour Operator"
        Me.CbTop.Size = New System.Drawing.Size(106, 19)
        Me.CbTop.TabIndex = 94
        '
        'CbComp
        '
        Me.CbComp.Location = New System.Drawing.Point(198, 148)
        Me.CbComp.Name = "CbComp"
        Me.CbComp.Properties.Caption = "Complimentary"
        Me.CbComp.Size = New System.Drawing.Size(106, 19)
        Me.CbComp.TabIndex = 93
        '
        'CbFIT
        '
        Me.CbFIT.Location = New System.Drawing.Point(143, 148)
        Me.CbFIT.Name = "CbFIT"
        Me.CbFIT.Properties.Caption = "FIT"
        Me.CbFIT.Size = New System.Drawing.Size(49, 19)
        Me.CbFIT.TabIndex = 92
        '
        'CbAll
        '
        Me.CbAll.Location = New System.Drawing.Point(101, 147)
        Me.CbAll.Name = "CbAll"
        Me.CbAll.Properties.Caption = "All"
        Me.CbAll.Size = New System.Drawing.Size(75, 19)
        Me.CbAll.TabIndex = 91
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(6, 150)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl2.TabIndex = 100
        Me.LabelControl2.Text = "Applicable For"
        '
        'txtOfferdetail
        '
        Me.txtOfferdetail.Location = New System.Drawing.Point(103, 70)
        Me.txtOfferdetail.Name = "txtOfferdetail"
        Me.txtOfferdetail.Size = New System.Drawing.Size(254, 64)
        Me.txtOfferdetail.TabIndex = 1
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(6, 31)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Offer Name"
        '
        'txtOffername
        '
        Me.txtOffername.Location = New System.Drawing.Point(103, 29)
        Me.txtOffername.Name = "txtOffername"
        Me.txtOffername.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffername.Properties.Appearance.Options.UseFont = True
        Me.txtOffername.Size = New System.Drawing.Size(376, 20)
        Me.txtOffername.TabIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(3, 95)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Details"
        '
        'btDel
        '
        Me.btDel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDel.Appearance.Options.UseFont = True
        Me.btDel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btDel.Location = New System.Drawing.Point(606, 94)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(92, 23)
        Me.btDel.TabIndex = 2
        Me.btDel.Text = "Delete"
        '
        'btEdit
        '
        Me.btEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEdit.Appearance.Options.UseFont = True
        Me.btEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btEdit.Location = New System.Drawing.Point(606, 65)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(92, 23)
        Me.btEdit.TabIndex = 1
        Me.btEdit.Text = "Edit"
        '
        'btAdd
        '
        Me.btAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.Appearance.Options.UseFont = True
        Me.btAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btAdd.Location = New System.Drawing.Point(607, 36)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(92, 23)
        Me.btAdd.TabIndex = 0
        Me.btAdd.Text = "Add"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(597, 377)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 20
        '
        'frmOfferComplimentary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(706, 417)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btDel)
        Me.Controls.Add(Me.tabOffers)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmOfferComplimentary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Offer And Complimentary"
        CType(Me.tabOffers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOffers.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcOffer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvOffer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.gcTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcViewTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTopname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTopcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTopInd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTopGroupC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTopGroupB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTopGroupA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTopGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTopAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbTop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbComp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbFIT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOfferdetail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOffername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabOffers As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcOffer As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvOffer As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOfferdetail As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOffername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btDelup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAssign As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcTop As DevExpress.XtraGrid.GridControl
    Friend WithEvents gcViewTop As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtTopname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbTopcode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CbTopInd As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CbTopGroupC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CbTopGroupB As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CbTopGroupA As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CbTopGroup As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CbTopAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CbTop As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CbComp As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CbFIT As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CbAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
