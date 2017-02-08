<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemSetup
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.pgTax = New DevExpress.XtraTab.XtraTabPage()
        Me.rbTax_Val = New System.Windows.Forms.RadioButton()
        Me.rbTax_Per = New System.Windows.Forms.RadioButton()
        Me.cmdDel_Tax = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTaxVal = New DevExpress.XtraEditors.TextEdit()
        Me.cmdAdd_Tax = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEdit_Tax = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTaxPer = New DevExpress.XtraEditors.TextEdit()
        Me.txtDesc_Tax = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTaxCode = New DevExpress.XtraEditors.TextEdit()
        Me.lbl3 = New DevExpress.XtraEditors.LabelControl()
        Me.gridTax = New DevExpress.XtraGrid.GridControl()
        Me.vwTax = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pgUOM = New DevExpress.XtraTab.XtraTabPage()
        Me.pgDepartment = New DevExpress.XtraTab.XtraTabPage()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.pgTax.SuspendLayout()
        CType(Me.txtTaxVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTaxPer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc_Tax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTaxCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridTax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vwTax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.pgTax
        Me.XtraTabControl1.Size = New System.Drawing.Size(566, 220)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.pgTax, Me.pgUOM, Me.pgDepartment})
        '
        'pgTax
        '
        Me.pgTax.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgTax.Appearance.Header.Options.UseFont = True
        Me.pgTax.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgTax.Appearance.HeaderActive.Options.UseFont = True
        Me.pgTax.Controls.Add(Me.rbTax_Val)
        Me.pgTax.Controls.Add(Me.rbTax_Per)
        Me.pgTax.Controls.Add(Me.cmdDel_Tax)
        Me.pgTax.Controls.Add(Me.txtTaxVal)
        Me.pgTax.Controls.Add(Me.cmdAdd_Tax)
        Me.pgTax.Controls.Add(Me.cmdEdit_Tax)
        Me.pgTax.Controls.Add(Me.txtTaxPer)
        Me.pgTax.Controls.Add(Me.txtDesc_Tax)
        Me.pgTax.Controls.Add(Me.LabelControl1)
        Me.pgTax.Controls.Add(Me.txtTaxCode)
        Me.pgTax.Controls.Add(Me.lbl3)
        Me.pgTax.Controls.Add(Me.gridTax)
        Me.pgTax.Name = "pgTax"
        Me.pgTax.Size = New System.Drawing.Size(564, 193)
        Me.pgTax.Text = "       Tax        "
        '
        'rbTax_Val
        '
        Me.rbTax_Val.Location = New System.Drawing.Point(334, 88)
        Me.rbTax_Val.Name = "rbTax_Val"
        Me.rbTax_Val.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbTax_Val.Size = New System.Drawing.Size(93, 17)
        Me.rbTax_Val.TabIndex = 24
        Me.rbTax_Val.TabStop = True
        Me.rbTax_Val.Text = "         Is Value"
        Me.rbTax_Val.UseVisualStyleBackColor = True
        '
        'rbTax_Per
        '
        Me.rbTax_Per.Location = New System.Drawing.Point(321, 66)
        Me.rbTax_Per.Name = "rbTax_Per"
        Me.rbTax_Per.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbTax_Per.Size = New System.Drawing.Size(106, 17)
        Me.rbTax_Per.TabIndex = 23
        Me.rbTax_Per.TabStop = True
        Me.rbTax_Per.Text = "Is Percentage"
        Me.rbTax_Per.UseVisualStyleBackColor = True
        '
        'cmdDel_Tax
        '
        Me.cmdDel_Tax.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDel_Tax.Appearance.Options.UseFont = True
        Me.cmdDel_Tax.Location = New System.Drawing.Point(489, 147)
        Me.cmdDel_Tax.Name = "cmdDel_Tax"
        Me.cmdDel_Tax.Size = New System.Drawing.Size(67, 23)
        Me.cmdDel_Tax.TabIndex = 22
        Me.cmdDel_Tax.Text = "In Active"
        '
        'txtTaxVal
        '
        Me.txtTaxVal.EnterMoveNextControl = True
        Me.txtTaxVal.Location = New System.Drawing.Point(473, 87)
        Me.txtTaxVal.Name = "txtTaxVal"
        Me.txtTaxVal.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxVal.Properties.Appearance.Options.UseFont = True
        Me.txtTaxVal.Size = New System.Drawing.Size(88, 20)
        Me.txtTaxVal.TabIndex = 21
        '
        'cmdAdd_Tax
        '
        Me.cmdAdd_Tax.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd_Tax.Appearance.Options.UseFont = True
        Me.cmdAdd_Tax.Location = New System.Drawing.Point(325, 147)
        Me.cmdAdd_Tax.Name = "cmdAdd_Tax"
        Me.cmdAdd_Tax.Size = New System.Drawing.Size(67, 23)
        Me.cmdAdd_Tax.TabIndex = 8
        Me.cmdAdd_Tax.Text = "Add"
        '
        'cmdEdit_Tax
        '
        Me.cmdEdit_Tax.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit_Tax.Appearance.Options.UseFont = True
        Me.cmdEdit_Tax.Location = New System.Drawing.Point(407, 147)
        Me.cmdEdit_Tax.Name = "cmdEdit_Tax"
        Me.cmdEdit_Tax.Size = New System.Drawing.Size(67, 23)
        Me.cmdEdit_Tax.TabIndex = 7
        Me.cmdEdit_Tax.Text = "Edit"
        '
        'txtTaxPer
        '
        Me.txtTaxPer.EnterMoveNextControl = True
        Me.txtTaxPer.Location = New System.Drawing.Point(473, 63)
        Me.txtTaxPer.Name = "txtTaxPer"
        Me.txtTaxPer.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxPer.Properties.Appearance.Options.UseFont = True
        Me.txtTaxPer.Size = New System.Drawing.Size(88, 20)
        Me.txtTaxPer.TabIndex = 5
        '
        'txtDesc_Tax
        '
        Me.txtDesc_Tax.EnterMoveNextControl = True
        Me.txtDesc_Tax.Location = New System.Drawing.Point(402, 37)
        Me.txtDesc_Tax.Name = "txtDesc_Tax"
        Me.txtDesc_Tax.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc_Tax.Properties.Appearance.Options.UseFont = True
        Me.txtDesc_Tax.Size = New System.Drawing.Size(159, 20)
        Me.txtDesc_Tax.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(334, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Description"
        '
        'txtTaxCode
        '
        Me.txtTaxCode.EnterMoveNextControl = True
        Me.txtTaxCode.Location = New System.Drawing.Point(402, 11)
        Me.txtTaxCode.Name = "txtTaxCode"
        Me.txtTaxCode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxCode.Properties.Appearance.Options.UseFont = True
        Me.txtTaxCode.Size = New System.Drawing.Size(90, 20)
        Me.txtTaxCode.TabIndex = 1
        '
        'lbl3
        '
        Me.lbl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(334, 14)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(46, 13)
        Me.lbl3.TabIndex = 2
        Me.lbl3.Text = "Tax Code"
        '
        'gridTax
        '
        Me.gridTax.Location = New System.Drawing.Point(3, 14)
        Me.gridTax.MainView = Me.vwTax
        Me.gridTax.Name = "gridTax"
        Me.gridTax.Size = New System.Drawing.Size(313, 176)
        Me.gridTax.TabIndex = 0
        Me.gridTax.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vwTax})
        '
        'vwTax
        '
        Me.vwTax.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.vwTax.GridControl = Me.gridTax
        Me.vwTax.Name = "vwTax"
        Me.vwTax.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Tax"
        Me.GridColumn1.FieldName = "Taxcode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 80
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Description"
        Me.GridColumn2.FieldName = "Description"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 204
        '
        'pgUOM
        '
        Me.pgUOM.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgUOM.Appearance.Header.Options.UseFont = True
        Me.pgUOM.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgUOM.Appearance.HeaderActive.Options.UseFont = True
        Me.pgUOM.Name = "pgUOM"
        Me.pgUOM.Size = New System.Drawing.Size(564, 193)
        Me.pgUOM.Text = "Unit of Measure"
        '
        'pgDepartment
        '
        Me.pgDepartment.Appearance.Header.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgDepartment.Appearance.Header.Options.UseFont = True
        Me.pgDepartment.Appearance.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pgDepartment.Appearance.HeaderActive.Options.UseFont = True
        Me.pgDepartment.Name = "pgDepartment"
        Me.pgDepartment.Size = New System.Drawing.Size(0, 0)
        Me.pgDepartment.Text = "Department"
        '
        'frmSystemSetup
        '
        Me.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 244)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmSystemSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Setup"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.pgTax.ResumeLayout(False)
        Me.pgTax.PerformLayout()
        CType(Me.txtTaxVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTaxPer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc_Tax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTaxCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridTax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vwTax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents pgTax As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pgUOM As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gridTax As DevExpress.XtraGrid.GridControl
    Friend WithEvents vwTax As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDesc_Tax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTaxCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTaxPer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAdd_Tax As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEdit_Tax As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTaxVal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdDel_Tax As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rbTax_Val As System.Windows.Forms.RadioButton
    Friend WithEvents rbTax_Per As System.Windows.Forms.RadioButton
    Friend WithEvents pgDepartment As DevExpress.XtraTab.XtraTabPage
End Class
