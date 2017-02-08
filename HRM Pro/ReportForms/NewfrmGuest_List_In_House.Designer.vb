<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewfrmGuest_List_In_House
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewfrmGuest_List_In_House))
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.dtResDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.CachedReceipt1 = New HRM_Pro.CachedReceipt()
        Me.dtfrom = New DevExpress.XtraEditors.DateEdit()
        Me.dtto = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnviewhis = New DevExpress.XtraEditors.SimpleButton()
        Me.chkarr = New DevExpress.XtraEditors.CheckEdit()
        Me.chktop = New DevExpress.XtraEditors.CheckEdit()
        Me.chkmp = New DevExpress.XtraEditors.CheckEdit()
        Me.chkroom = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtResDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtResDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtfrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtfrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtto.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkarr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chktop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkmp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkroom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(292, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 43
        '
        'dtResDate
        '
        Me.dtResDate.EditValue = Nothing
        Me.dtResDate.Location = New System.Drawing.Point(33, 81)
        Me.dtResDate.Name = "dtResDate"
        Me.dtResDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtResDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtResDate.Size = New System.Drawing.Size(110, 20)
        Me.dtResDate.TabIndex = 39
        Me.dtResDate.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(116, 13)
        Me.LabelControl1.TabIndex = 38
        Me.LabelControl1.Text = "Guest In House Date"
        Me.LabelControl1.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnPrint.Location = New System.Drawing.Point(18, 66)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(163, 23)
        Me.btnPrint.TabIndex = 37
        Me.btnPrint.Text = "View Current Guest In-House"
        '
        'dtfrom
        '
        Me.dtfrom.EditValue = Nothing
        Me.dtfrom.Location = New System.Drawing.Point(254, 20)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtfrom.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtfrom.Size = New System.Drawing.Size(110, 20)
        Me.dtfrom.TabIndex = 44
        '
        'dtto
        '
        Me.dtto.EditValue = Nothing
        Me.dtto.Location = New System.Drawing.Point(254, 46)
        Me.dtto.Name = "dtto"
        Me.dtto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtto.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtto.Size = New System.Drawing.Size(110, 20)
        Me.dtto.TabIndex = 45
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(201, 20)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl4.TabIndex = 46
        Me.LabelControl4.Text = "From"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(201, 49)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl2.TabIndex = 47
        Me.LabelControl2.Text = "To"
        '
        'btnviewhis
        '
        Me.btnviewhis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnviewhis.Location = New System.Drawing.Point(233, 85)
        Me.btnviewhis.Name = "btnviewhis"
        Me.btnviewhis.Size = New System.Drawing.Size(131, 23)
        Me.btnviewhis.TabIndex = 48
        Me.btnviewhis.Text = "View History"
        '
        'chkarr
        '
        Me.chkarr.Location = New System.Drawing.Point(14, 39)
        Me.chkarr.Name = "chkarr"
        Me.chkarr.Properties.Caption = "By Arrival Date"
        Me.chkarr.Size = New System.Drawing.Size(112, 19)
        Me.chkarr.TabIndex = 49
        '
        'chktop
        '
        Me.chktop.Location = New System.Drawing.Point(14, 89)
        Me.chktop.Name = "chktop"
        Me.chktop.Properties.Caption = "By TOP"
        Me.chktop.Size = New System.Drawing.Size(112, 19)
        Me.chktop.TabIndex = 50
        '
        'chkmp
        '
        Me.chkmp.Location = New System.Drawing.Point(14, 64)
        Me.chkmp.Name = "chkmp"
        Me.chkmp.Properties.Caption = "By Meal Plan"
        Me.chkmp.Size = New System.Drawing.Size(112, 19)
        Me.chkmp.TabIndex = 51
        '
        'chkroom
        '
        Me.chkroom.Location = New System.Drawing.Point(14, 14)
        Me.chkroom.Name = "chkroom"
        Me.chkroom.Properties.Caption = "By Room No"
        Me.chkroom.Size = New System.Drawing.Size(112, 19)
        Me.chkroom.TabIndex = 52
        '
        'PanelControl1
        '
        Me.PanelControl1.ContentImage = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.PanelControl1.Controls.Add(Me.chkroom)
        Me.PanelControl1.Controls.Add(Me.chkmp)
        Me.PanelControl1.Controls.Add(Me.chktop)
        Me.PanelControl1.Controls.Add(Me.chkarr)
        Me.PanelControl1.Controls.Add(Me.btnviewhis)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.dtto)
        Me.PanelControl1.Controls.Add(Me.dtfrom)
        Me.PanelControl1.Location = New System.Drawing.Point(18, 119)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(372, 127)
        Me.PanelControl1.TabIndex = 53
        '
        'NewfrmGuest_List_In_House
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg23
        Me.ClientSize = New System.Drawing.Size(396, 258)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.dtResDate)
        Me.Controls.Add(Me.LabelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "NewfrmGuest_List_In_House"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest List In House"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtResDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtResDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtfrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtfrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtto.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkarr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chktop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkmp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkroom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents dtResDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CachedReceipt1 As HRM_Pro.CachedReceipt
    Friend WithEvents dtfrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtto As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnviewhis As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkarr As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chktop As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkmp As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkroom As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
