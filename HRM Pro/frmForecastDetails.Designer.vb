<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForecastDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForecastDetails))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.btPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.btnView = New DevExpress.XtraEditors.SimpleButton()
        Me.DtTo = New DevExpress.XtraEditors.DateEdit()
        Me.DtFrm = New DevExpress.XtraEditors.DateEdit()
        Me.gcForecast = New DevExpress.XtraGrid.GridControl()
        Me.gvforecast = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcRes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcGuest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcResType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTopcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcArrDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDepDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAdultQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcChildrenQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcInfantsQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcMealPlan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.DtTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtFrm.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtFrm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcForecast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvforecast, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.XtraTabControl1.Location = New System.Drawing.Point(4, 4)
        Me.XtraTabControl1.LookAndFeel.SkinName = "Metropolis"
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(873, 442)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.btPrint)
        Me.XtraTabPage2.Controls.Add(Me.btnView)
        Me.XtraTabPage2.Controls.Add(Me.DtTo)
        Me.XtraTabPage2.Controls.Add(Me.DtFrm)
        Me.XtraTabPage2.Controls.Add(Me.gcForecast)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(871, 417)
        Me.XtraTabPage2.Text = " Forecast Details"
        '
        'btPrint
        '
        Me.btPrint.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPrint.Appearance.Options.UseFont = True
        Me.btPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btPrint.Location = New System.Drawing.Point(490, 17)
        Me.btPrint.LookAndFeel.SkinName = "Metropolis"
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(81, 23)
        Me.btPrint.TabIndex = 30
        Me.btPrint.Text = "Print"
        '
        'btnView
        '
        Me.btnView.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Appearance.Options.UseFont = True
        Me.btnView.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnView.Location = New System.Drawing.Point(403, 17)
        Me.btnView.LookAndFeel.SkinName = "Metropolis"
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(81, 23)
        Me.btnView.TabIndex = 29
        Me.btnView.Text = "View"
        '
        'DtTo
        '
        Me.DtTo.EditValue = Nothing
        Me.DtTo.Location = New System.Drawing.Point(231, 20)
        Me.DtTo.Name = "DtTo"
        Me.DtTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DtTo.Size = New System.Drawing.Size(142, 20)
        Me.DtTo.TabIndex = 28
        '
        'DtFrm
        '
        Me.DtFrm.EditValue = Nothing
        Me.DtFrm.Location = New System.Drawing.Point(37, 20)
        Me.DtFrm.Name = "DtFrm"
        Me.DtFrm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtFrm.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DtFrm.Size = New System.Drawing.Size(138, 20)
        Me.DtFrm.TabIndex = 27
        '
        'gcForecast
        '
        Me.gcForecast.Location = New System.Drawing.Point(3, 58)
        Me.gcForecast.LookAndFeel.SkinName = "Metropolis"
        Me.gcForecast.MainView = Me.gvforecast
        Me.gcForecast.Name = "gcForecast"
        Me.gcForecast.Size = New System.Drawing.Size(865, 356)
        Me.gcForecast.TabIndex = 25
        Me.gcForecast.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvforecast})
        '
        'gvforecast
        '
        Me.gvforecast.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcRes, Me.gcGuest, Me.gcResType, Me.gcTopcode, Me.gcArrDate, Me.gcDepDate, Me.gcAdultQty, Me.gcChildrenQty, Me.gcInfantsQty, Me.gcMealPlan})
        Me.gvforecast.GridControl = Me.gcForecast
        Me.gvforecast.Name = "gvforecast"
        '
        'gcRes
        '
        Me.gcRes.Caption = "Reservation No"
        Me.gcRes.FieldName = "ResNo"
        Me.gcRes.Name = "gcRes"
        Me.gcRes.Visible = True
        Me.gcRes.VisibleIndex = 0
        Me.gcRes.Width = 100
        '
        'gcGuest
        '
        Me.gcGuest.Caption = "Guest"
        Me.gcGuest.FieldName = "Guest"
        Me.gcGuest.Name = "gcGuest"
        Me.gcGuest.Visible = True
        Me.gcGuest.VisibleIndex = 1
        Me.gcGuest.Width = 150
        '
        'gcResType
        '
        Me.gcResType.Caption = "ResType"
        Me.gcResType.FieldName = "ResType"
        Me.gcResType.Name = "gcResType"
        Me.gcResType.Visible = True
        Me.gcResType.VisibleIndex = 2
        '
        'gcTopcode
        '
        Me.gcTopcode.Caption = "Topcode"
        Me.gcTopcode.FieldName = "Topcode"
        Me.gcTopcode.Name = "gcTopcode"
        Me.gcTopcode.Visible = True
        Me.gcTopcode.VisibleIndex = 3
        Me.gcTopcode.Width = 25
        '
        'gcArrDate
        '
        Me.gcArrDate.Caption = "Arrival"
        Me.gcArrDate.FieldName = "ArrDate"
        Me.gcArrDate.Name = "gcArrDate"
        Me.gcArrDate.Visible = True
        Me.gcArrDate.VisibleIndex = 4
        Me.gcArrDate.Width = 47
        '
        'gcDepDate
        '
        Me.gcDepDate.Caption = "DepDate"
        Me.gcDepDate.FieldName = "DepDate"
        Me.gcDepDate.Name = "gcDepDate"
        Me.gcDepDate.Visible = True
        Me.gcDepDate.VisibleIndex = 5
        Me.gcDepDate.Width = 45
        '
        'gcAdultQty
        '
        Me.gcAdultQty.Caption = "Adults"
        Me.gcAdultQty.FieldName = "AdultQty"
        Me.gcAdultQty.Name = "gcAdultQty"
        Me.gcAdultQty.Visible = True
        Me.gcAdultQty.VisibleIndex = 6
        Me.gcAdultQty.Width = 33
        '
        'gcChildrenQty
        '
        Me.gcChildrenQty.Caption = "Children"
        Me.gcChildrenQty.FieldName = "ChildrenQty"
        Me.gcChildrenQty.Name = "gcChildrenQty"
        Me.gcChildrenQty.Visible = True
        Me.gcChildrenQty.VisibleIndex = 7
        Me.gcChildrenQty.Width = 33
        '
        'gcInfantsQty
        '
        Me.gcInfantsQty.Caption = "Infants"
        Me.gcInfantsQty.FieldName = "InfantsQty"
        Me.gcInfantsQty.Name = "gcInfantsQty"
        Me.gcInfantsQty.Visible = True
        Me.gcInfantsQty.VisibleIndex = 8
        Me.gcInfantsQty.Width = 33
        '
        'gcMealPlan
        '
        Me.gcMealPlan.Caption = "MP"
        Me.gcMealPlan.FieldName = "MealPlan"
        Me.gcMealPlan.Name = "gcMealPlan"
        Me.gcMealPlan.Visible = True
        Me.gcMealPlan.VisibleIndex = 9
        Me.gcMealPlan.Width = 45
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(213, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "To"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(5, 23)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "From"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(883, 409)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 18
        '
        'frmForecastDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(981, 449)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmForecastDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forecast Details"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.DtTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtFrm.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtFrm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcForecast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvforecast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcForecast As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvforecast As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DtTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DtFrm As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcRes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcGuest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcResType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTopcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcArrDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDepDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAdultQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcChildrenQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcInfantsQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMealPlan As DevExpress.XtraGrid.Columns.GridColumn
End Class
