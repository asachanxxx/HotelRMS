<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckOuts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckOuts))
        Me.tabBoatSchedDetails = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.btnViewDep = New DevExpress.XtraEditors.SimpleButton()
        Me.gcDep = New DevExpress.XtraGrid.GridControl()
        Me.gvDep = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRoom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReservationNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGuestRegNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepFlight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldepsourse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepGuest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Depcolcheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.dtDateDep = New DevExpress.XtraEditors.DateEdit()
        Me.TimeHDep = New DevExpress.XtraEditors.TimeEdit()
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.btPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.tabBoatSchedDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBoatSchedDetails.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateDep.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeHDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabBoatSchedDetails
        '
        Me.tabBoatSchedDetails.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBoatSchedDetails.AppearancePage.Header.Options.UseFont = True
        Me.tabBoatSchedDetails.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBoatSchedDetails.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabBoatSchedDetails.Location = New System.Drawing.Point(12, 12)
        Me.tabBoatSchedDetails.Name = "tabBoatSchedDetails"
        Me.tabBoatSchedDetails.SelectedTabPage = Me.XtraTabPage3
        Me.tabBoatSchedDetails.Size = New System.Drawing.Size(1027, 308)
        Me.tabBoatSchedDetails.TabIndex = 25
        Me.tabBoatSchedDetails.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.PictureEdit2)
        Me.XtraTabPage3.Controls.Add(Me.btnViewDep)
        Me.XtraTabPage3.Controls.Add(Me.gcDep)
        Me.XtraTabPage3.Controls.Add(Me.dtDateDep)
        Me.XtraTabPage3.Controls.Add(Me.TimeHDep)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl42)
        Me.XtraTabPage3.Controls.Add(Me.btPrint)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1025, 283)
        Me.XtraTabPage3.Text = "Departures"
        '
        'PictureEdit2
        '
        Me.PictureEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit2.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit2.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit2.Location = New System.Drawing.Point(918, 230)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Size = New System.Drawing.Size(96, 37)
        Me.PictureEdit2.TabIndex = 25
        '
        'btnViewDep
        '
        Me.btnViewDep.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDep.Appearance.Options.UseFont = True
        Me.btnViewDep.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnViewDep.Location = New System.Drawing.Point(203, 13)
        Me.btnViewDep.Name = "btnViewDep"
        Me.btnViewDep.Size = New System.Drawing.Size(115, 23)
        Me.btnViewDep.TabIndex = 69
        Me.btnViewDep.Text = "View Departures"
        '
        'gcDep
        '
        Me.gcDep.Location = New System.Drawing.Point(9, 59)
        Me.gcDep.MainView = Me.gvDep
        Me.gcDep.Name = "gcDep"
        Me.gcDep.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2})
        Me.gcDep.Size = New System.Drawing.Size(1005, 140)
        Me.gcDep.TabIndex = 32
        Me.gcDep.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDep})
        '
        'gvDep
        '
        Me.gvDep.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvDep.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvDep.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvDep.Appearance.Row.Options.UseFont = True
        Me.gvDep.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRoom, Me.colReservationNo, Me.colGuestRegNo, Me.colDepdate, Me.colDepTime, Me.colDepFlight, Me.coldepsourse, Me.colDepGuest, Me.colcountry, Me.Depcolcheck})
        Me.gvDep.GridControl = Me.gcDep
        Me.gvDep.Name = "gvDep"
        Me.gvDep.OptionsView.ShowGroupPanel = False
        '
        'colRoom
        '
        Me.colRoom.Caption = "Roomno"
        Me.colRoom.FieldName = "Roomno"
        Me.colRoom.Name = "colRoom"
        Me.colRoom.Visible = True
        Me.colRoom.VisibleIndex = 0
        '
        'colReservationNo
        '
        Me.colReservationNo.Caption = "ReservationNo"
        Me.colReservationNo.FieldName = "ReservationNo"
        Me.colReservationNo.Name = "colReservationNo"
        Me.colReservationNo.Visible = True
        Me.colReservationNo.VisibleIndex = 1
        Me.colReservationNo.Width = 78
        '
        'colGuestRegNo
        '
        Me.colGuestRegNo.Caption = "RegNo"
        Me.colGuestRegNo.FieldName = "GuestRegNo"
        Me.colGuestRegNo.Name = "colGuestRegNo"
        Me.colGuestRegNo.Visible = True
        Me.colGuestRegNo.VisibleIndex = 2
        '
        'colDepdate
        '
        Me.colDepdate.Caption = "Date"
        Me.colDepdate.FieldName = "DepDate"
        Me.colDepdate.Name = "colDepdate"
        Me.colDepdate.Visible = True
        Me.colDepdate.VisibleIndex = 3
        Me.colDepdate.Width = 67
        '
        'colDepTime
        '
        Me.colDepTime.Caption = "Hotel Departure Time"
        Me.colDepTime.FieldName = "DTime"
        Me.colDepTime.Name = "colDepTime"
        Me.colDepTime.Visible = True
        Me.colDepTime.VisibleIndex = 4
        '
        'colDepFlight
        '
        Me.colDepFlight.Caption = "Flight No"
        Me.colDepFlight.FieldName = "DFlight"
        Me.colDepFlight.Name = "colDepFlight"
        Me.colDepFlight.Visible = True
        Me.colDepFlight.VisibleIndex = 5
        '
        'coldepsourse
        '
        Me.coldepsourse.Caption = "Departure From"
        Me.coldepsourse.FieldName = "DepTo"
        Me.coldepsourse.Name = "coldepsourse"
        Me.coldepsourse.Visible = True
        Me.coldepsourse.VisibleIndex = 6
        '
        'colDepGuest
        '
        Me.colDepGuest.Caption = "Guest"
        Me.colDepGuest.FieldName = "FullName"
        Me.colDepGuest.Name = "colDepGuest"
        Me.colDepGuest.Visible = True
        Me.colDepGuest.VisibleIndex = 7
        Me.colDepGuest.Width = 210
        '
        'colcountry
        '
        Me.colcountry.Caption = "Country"
        Me.colcountry.FieldName = "Country"
        Me.colcountry.Name = "colcountry"
        Me.colcountry.Visible = True
        Me.colcountry.VisibleIndex = 8
        Me.colcountry.Width = 76
        '
        'Depcolcheck
        '
        Me.Depcolcheck.Caption = "Select"
        Me.Depcolcheck.ColumnEdit = Me.RepositoryItemCheckEdit2
        Me.Depcolcheck.FieldName = "select"
        Me.Depcolcheck.Name = "Depcolcheck"
        Me.Depcolcheck.Visible = True
        Me.Depcolcheck.VisibleIndex = 9
        Me.Depcolcheck.Width = 94
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'dtDateDep
        '
        Me.dtDateDep.EditValue = Nothing
        Me.dtDateDep.Location = New System.Drawing.Point(68, 15)
        Me.dtDateDep.Name = "dtDateDep"
        Me.dtDateDep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDateDep.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDateDep.Size = New System.Drawing.Size(129, 20)
        Me.dtDateDep.TabIndex = 31
        '
        'TimeHDep
        '
        Me.TimeHDep.EditValue = New Date(2012, 10, 24, 0, 0, 0, 0)
        Me.TimeHDep.Location = New System.Drawing.Point(168, 233)
        Me.TimeHDep.Name = "TimeHDep"
        Me.TimeHDep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeHDep.Size = New System.Drawing.Size(106, 20)
        Me.TimeHDep.TabIndex = 77
        '
        'LabelControl42
        '
        Me.LabelControl42.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl42.Location = New System.Drawing.Point(22, 18)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl42.TabIndex = 1
        Me.LabelControl42.Text = "Date"
        '
        'btPrint
        '
        Me.btPrint.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPrint.Appearance.Options.UseFont = True
        Me.btPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btPrint.Location = New System.Drawing.Point(294, 230)
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(142, 23)
        Me.btPrint.TabIndex = 4
        Me.btPrint.Text = "Set Departure Time"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(9, 236)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl9.TabIndex = 40
        Me.LabelControl9.Text = "Hotel Departure Time "
        '
        'frmCheckOuts
        '
        Me.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(1043, 325)
        Me.Controls.Add(Me.tabBoatSchedDetails)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmCheckOuts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Check Outs"
        CType(Me.tabBoatSchedDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBoatSchedDetails.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateDep.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeHDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabBoatSchedDetails As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnViewDep As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcDep As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDep As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRoom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReservationNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepFlight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldepsourse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepGuest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Depcolcheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents dtDateDep As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TimeHDep As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colGuestRegNo As DevExpress.XtraGrid.Columns.GridColumn
End Class
