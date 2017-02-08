<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuestRegisterView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuestRegisterView))
        Me.tabMain = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtSearchByPP = New DevExpress.XtraEditors.TextEdit()
        Me.rbPP = New System.Windows.Forms.RadioButton()
        Me.rbByName = New System.Windows.Forms.RadioButton()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.gridGuestList = New DevExpress.XtraGrid.GridControl()
        Me.gvGuestList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemReqCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtSearchByPP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridGuestList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvGuestList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.AppearancePage.Header.Options.UseFont = True
        Me.tabMain.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabMain.Location = New System.Drawing.Point(12, 12)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedTabPage = Me.XtraTabPage1
        Me.tabMain.Size = New System.Drawing.Size(1065, 434)
        Me.tabMain.TabIndex = 1
        Me.tabMain.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraTabPage1.Appearance.HeaderActive.Options.UseFont = True
        Me.XtraTabPage1.Controls.Add(Me.GroupBox4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(1063, 407)
        Me.XtraTabPage1.Text = "Guest List"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSearchByPP)
        Me.GroupBox4.Controls.Add(Me.rbPP)
        Me.GroupBox4.Controls.Add(Me.rbByName)
        Me.GroupBox4.Controls.Add(Me.LabelControl36)
        Me.GroupBox4.Controls.Add(Me.gridGuestList)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1048, 393)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'txtSearchByPP
        '
        Me.txtSearchByPP.Location = New System.Drawing.Point(320, 17)
        Me.txtSearchByPP.Name = "txtSearchByPP"
        Me.txtSearchByPP.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchByPP.Properties.Appearance.Options.UseFont = True
        Me.txtSearchByPP.Size = New System.Drawing.Size(283, 20)
        Me.txtSearchByPP.TabIndex = 165
        '
        'rbPP
        '
        Me.rbPP.AutoSize = True
        Me.rbPP.Checked = True
        Me.rbPP.Location = New System.Drawing.Point(109, 18)
        Me.rbPP.Name = "rbPP"
        Me.rbPP.Size = New System.Drawing.Size(76, 17)
        Me.rbPP.TabIndex = 164
        Me.rbPP.TabStop = True
        Me.rbPP.Text = "Passport #"
        Me.rbPP.UseVisualStyleBackColor = True
        '
        'rbByName
        '
        Me.rbByName.AutoSize = True
        Me.rbByName.Location = New System.Drawing.Point(219, 18)
        Me.rbByName.Name = "rbByName"
        Me.rbByName.Size = New System.Drawing.Size(84, 17)
        Me.rbByName.TabIndex = 163
        Me.rbByName.Text = "Guest Name"
        Me.rbByName.UseVisualStyleBackColor = True
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl36.Location = New System.Drawing.Point(6, 22)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl36.TabIndex = 158
        Me.LabelControl36.Text = "Guest Search"
        '
        'gridGuestList
        '
        Me.gridGuestList.Location = New System.Drawing.Point(6, 50)
        Me.gridGuestList.MainView = Me.gvGuestList
        Me.gridGuestList.Name = "gridGuestList"
        Me.gridGuestList.Size = New System.Drawing.Size(1042, 337)
        Me.gridGuestList.TabIndex = 2
        Me.gridGuestList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvGuestList})
        '
        'gvGuestList
        '
        Me.gvGuestList.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.gvGuestList.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvGuestList.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvGuestList.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvGuestList.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvGuestList.Appearance.Row.Options.UseFont = True
        Me.gvGuestList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemReqCode, Me.colDate, Me.colBalance, Me.GridColumn7, Me.GridColumn13, Me.GridColumn1, Me.GridColumn2})
        Me.gvGuestList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvGuestList.GridControl = Me.gridGuestList
        Me.gvGuestList.Name = "gvGuestList"
        Me.gvGuestList.OptionsBehavior.Editable = False
        Me.gvGuestList.OptionsView.ShowGroupPanel = False
        '
        'colItemReqCode
        '
        Me.colItemReqCode.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colItemReqCode.AppearanceCell.Options.UseFont = True
        Me.colItemReqCode.AppearanceCell.Options.UseTextOptions = True
        Me.colItemReqCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemReqCode.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colItemReqCode.AppearanceHeader.Options.UseFont = True
        Me.colItemReqCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemReqCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemReqCode.Caption = "Passport No"
        Me.colItemReqCode.FieldName = "PassportNo"
        Me.colItemReqCode.Name = "colItemReqCode"
        Me.colItemReqCode.Visible = True
        Me.colItemReqCode.VisibleIndex = 0
        Me.colItemReqCode.Width = 110
        '
        'colDate
        '
        Me.colDate.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDate.AppearanceCell.Options.UseFont = True
        Me.colDate.AppearanceCell.Options.UseTextOptions = True
        Me.colDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDate.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDate.AppearanceHeader.Options.UseFont = True
        Me.colDate.AppearanceHeader.Options.UseTextOptions = True
        Me.colDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDate.Caption = "Full Name"
        Me.colDate.FieldName = "FullName"
        Me.colDate.Name = "colDate"
        Me.colDate.Visible = True
        Me.colDate.VisibleIndex = 1
        Me.colDate.Width = 275
        '
        'colBalance
        '
        Me.colBalance.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colBalance.AppearanceCell.Options.UseFont = True
        Me.colBalance.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colBalance.AppearanceHeader.Options.UseFont = True
        Me.colBalance.AppearanceHeader.Options.UseTextOptions = True
        Me.colBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBalance.Caption = "Date of Birth"
        Me.colBalance.FieldName = "DOB"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.Visible = True
        Me.colBalance.VisibleIndex = 2
        Me.colBalance.Width = 100
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn7.AppearanceCell.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Country"
        Me.GridColumn7.FieldName = "Country"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 180
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn13.AppearanceCell.Options.UseFont = True
        Me.GridColumn13.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn13.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn13.AppearanceHeader.Options.UseFont = True
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.Caption = "Profession"
        Me.GridColumn13.FieldName = "Profession"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 4
        Me.GridColumn13.Width = 179
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GuestRegNo"
        Me.GridColumn1.FieldName = "GuestRegNo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "No Of Visit Eriyadu"
        Me.GridColumn2.FieldName = "NoOfVisitEriyadu"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 6
        '
        'frmGuestRegisterView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(1079, 447)
        Me.Controls.Add(Me.tabMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmGuestRegisterView"
        Me.Text = "Guest Register View"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txtSearchByPP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridGuestList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvGuestList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearchByPP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rbPP As System.Windows.Forms.RadioButton
    Friend WithEvents rbByName As System.Windows.Forms.RadioButton
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridGuestList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvGuestList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemReqCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
