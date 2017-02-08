<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemSelection))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblitemtot = New DevExpress.XtraEditors.LabelControl()
        Me.optbyname = New System.Windows.Forms.RadioButton()
        Me.optbycode = New System.Windows.Forms.RadioButton()
        Me.lbl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtsearch = New DevExpress.XtraEditors.TextEdit()
        Me.lbl1 = New DevExpress.XtraEditors.LabelControl()
        Me.gridItemSelection = New DevExpress.XtraGrid.GridControl()
        Me.gvItemSelection = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStocks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotShots = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colROL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colROQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsSplit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBDes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtsearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridItemSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvItemSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblitemtot)
        Me.PanelControl1.Controls.Add(Me.optbyname)
        Me.PanelControl1.Controls.Add(Me.optbycode)
        Me.PanelControl1.Controls.Add(Me.lbl2)
        Me.PanelControl1.Controls.Add(Me.txtsearch)
        Me.PanelControl1.Controls.Add(Me.lbl1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 31)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(635, 38)
        Me.PanelControl1.TabIndex = 10
        '
        'lblitemtot
        '
        Me.lblitemtot.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemtot.Location = New System.Drawing.Point(592, 15)
        Me.lblitemtot.Name = "lblitemtot"
        Me.lblitemtot.Size = New System.Drawing.Size(0, 13)
        Me.lblitemtot.TabIndex = 15
        '
        'optbyname
        '
        Me.optbyname.AutoSize = True
        Me.optbyname.Checked = True
        Me.optbyname.Location = New System.Drawing.Point(143, 13)
        Me.optbyname.Name = "optbyname"
        Me.optbyname.Size = New System.Drawing.Size(69, 17)
        Me.optbyname.TabIndex = 14
        Me.optbyname.TabStop = True
        Me.optbyname.Text = "By Name"
        Me.optbyname.UseVisualStyleBackColor = True
        '
        'optbycode
        '
        Me.optbycode.AutoSize = True
        Me.optbycode.Location = New System.Drawing.Point(65, 13)
        Me.optbycode.Name = "optbycode"
        Me.optbycode.Size = New System.Drawing.Size(74, 17)
        Me.optbycode.TabIndex = 13
        Me.optbycode.Text = "ItemCode"
        Me.optbycode.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(508, 15)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(78, 13)
        Me.lbl2.TabIndex = 12
        Me.lbl2.Text = "Found Records"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(218, 12)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Properties.Appearance.Options.UseFont = True
        Me.txtsearch.Size = New System.Drawing.Size(280, 20)
        Me.txtsearch.TabIndex = 11
        '
        'lbl1
        '
        Me.lbl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(6, 15)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(49, 13)
        Me.lbl1.TabIndex = 10
        Me.lbl1.Text = "Search By"
        '
        'gridItemSelection
        '
        Me.gridItemSelection.Location = New System.Drawing.Point(12, 84)
        Me.gridItemSelection.MainView = Me.gvItemSelection
        Me.gridItemSelection.Name = "gridItemSelection"
        Me.gridItemSelection.Size = New System.Drawing.Size(794, 364)
        Me.gridItemSelection.TabIndex = 1
        Me.gridItemSelection.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvItemSelection})
        '
        'gvItemSelection
        '
        Me.gvItemSelection.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.gvItemSelection.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvItemSelection.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvItemSelection.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvItemSelection.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvItemSelection.Appearance.Row.Options.UseFont = True
        Me.gvItemSelection.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemCode, Me.colDescription, Me.colStocks, Me.colTotShots, Me.colROL, Me.colROQ, Me.colIsSplit, Me.colBDes})
        Me.gvItemSelection.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvItemSelection.GridControl = Me.gridItemSelection
        Me.gvItemSelection.Name = "gvItemSelection"
        Me.gvItemSelection.OptionsBehavior.Editable = False
        Me.gvItemSelection.OptionsFind.AllowFindPanel = False
        Me.gvItemSelection.OptionsView.ShowGroupPanel = False
        '
        'colItemCode
        '
        Me.colItemCode.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colItemCode.AppearanceCell.Options.UseFont = True
        Me.colItemCode.AppearanceCell.Options.UseTextOptions = True
        Me.colItemCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemCode.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colItemCode.AppearanceHeader.Options.UseFont = True
        Me.colItemCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colItemCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colItemCode.Caption = "Item Code"
        Me.colItemCode.FieldName = "Itemcode"
        Me.colItemCode.Name = "colItemCode"
        Me.colItemCode.Visible = True
        Me.colItemCode.VisibleIndex = 0
        Me.colItemCode.Width = 115
        '
        'colDescription
        '
        Me.colDescription.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDescription.AppearanceCell.Options.UseFont = True
        Me.colDescription.AppearanceCell.Options.UseTextOptions = True
        Me.colDescription.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDescription.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDescription.AppearanceHeader.Options.UseFont = True
        Me.colDescription.AppearanceHeader.Options.UseTextOptions = True
        Me.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDescription.Caption = "Description"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        Me.colDescription.Width = 231
        '
        'colStocks
        '
        Me.colStocks.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colStocks.AppearanceCell.Options.UseFont = True
        Me.colStocks.AppearanceCell.Options.UseTextOptions = True
        Me.colStocks.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStocks.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colStocks.AppearanceHeader.Options.UseFont = True
        Me.colStocks.AppearanceHeader.Options.UseTextOptions = True
        Me.colStocks.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStocks.Caption = "Stocks"
        Me.colStocks.FieldName = "Stocks"
        Me.colStocks.Name = "colStocks"
        Me.colStocks.Visible = True
        Me.colStocks.VisibleIndex = 2
        Me.colStocks.Width = 92
        '
        'colTotShots
        '
        Me.colTotShots.Caption = "Ava. Shots"
        Me.colTotShots.FieldName = "TotShots"
        Me.colTotShots.Name = "colTotShots"
        Me.colTotShots.Visible = True
        Me.colTotShots.VisibleIndex = 3
        '
        'colROL
        '
        Me.colROL.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colROL.AppearanceCell.Options.UseFont = True
        Me.colROL.AppearanceCell.Options.UseTextOptions = True
        Me.colROL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colROL.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colROL.AppearanceHeader.Options.UseFont = True
        Me.colROL.AppearanceHeader.Options.UseTextOptions = True
        Me.colROL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colROL.Caption = "ROL"
        Me.colROL.FieldName = "ROL"
        Me.colROL.Name = "colROL"
        Me.colROL.Visible = True
        Me.colROL.VisibleIndex = 4
        Me.colROL.Width = 92
        '
        'colROQ
        '
        Me.colROQ.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colROQ.AppearanceCell.Options.UseFont = True
        Me.colROQ.AppearanceCell.Options.UseTextOptions = True
        Me.colROQ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colROQ.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colROQ.AppearanceHeader.Options.UseFont = True
        Me.colROQ.AppearanceHeader.Options.UseTextOptions = True
        Me.colROQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colROQ.Caption = "ROQ"
        Me.colROQ.FieldName = "ROQ"
        Me.colROQ.Name = "colROQ"
        Me.colROQ.Visible = True
        Me.colROQ.VisibleIndex = 5
        Me.colROQ.Width = 100
        '
        'colIsSplit
        '
        Me.colIsSplit.Caption = "IsSplit"
        Me.colIsSplit.FieldName = "IsSplit"
        Me.colIsSplit.Name = "colIsSplit"
        '
        'colBDes
        '
        Me.colBDes.Caption = "BillingDesc"
        Me.colBDes.FieldName = "BillingDesc"
        Me.colBDes.Name = "colBDes"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(823, 420)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(84, 31)
        Me.PictureEdit1.TabIndex = 5
        '
        'frmItemSelection
        '
        Me.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(919, 460)
        Me.Controls.Add(Me.gridItemSelection)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmItemSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Selection"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtsearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridItemSelection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvItemSelection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridItemSelection As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvItemSelection As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStocks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colROL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colROQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblitemtot As DevExpress.XtraEditors.LabelControl
    Friend WithEvents optbyname As System.Windows.Forms.RadioButton
    Friend WithEvents optbycode As System.Windows.Forms.RadioButton
    Friend WithEvents lbl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtsearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents colTotShots As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsSplit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBDes As DevExpress.XtraGrid.Columns.GridColumn
End Class
