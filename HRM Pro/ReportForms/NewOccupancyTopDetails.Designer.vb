﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewOccupancyTopDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewOccupancyTopDetails))
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.dtResDate2 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.dtResDate = New DevExpress.XtraEditors.DateEdit()
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbTopcode = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtResDate2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtResDate2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtResDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtResDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTopcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(217, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(98, 42)
        Me.PictureEdit1.TabIndex = 53
        '
        'dtResDate2
        '
        Me.dtResDate2.EditValue = Nothing
        Me.dtResDate2.Location = New System.Drawing.Point(66, 85)
        Me.dtResDate2.Name = "dtResDate2"
        Me.dtResDate2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtResDate2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtResDate2.Size = New System.Drawing.Size(110, 20)
        Me.dtResDate2.TabIndex = 52
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(17, 88)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl2.TabIndex = 51
        Me.LabelControl2.Text = "To"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(16, 59)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl3.TabIndex = 50
        Me.LabelControl3.Text = "From"
        '
        'dtResDate
        '
        Me.dtResDate.EditValue = Nothing
        Me.dtResDate.Location = New System.Drawing.Point(65, 56)
        Me.dtResDate.Name = "dtResDate"
        Me.dtResDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtResDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtResDate.Size = New System.Drawing.Size(110, 20)
        Me.dtResDate.TabIndex = 49
        '
        'btnPrint
        '
        Me.btnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnPrint.Location = New System.Drawing.Point(202, 114)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 48
        Me.btnPrint.Text = "Print"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(17, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl1.TabIndex = 47
        Me.LabelControl1.Text = "Reservation Date"
        '
        'cbTopcode
        '
        Me.cbTopcode.Location = New System.Drawing.Point(65, 117)
        Me.cbTopcode.Name = "cbTopcode"
        Me.cbTopcode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTopcode.Size = New System.Drawing.Size(110, 20)
        Me.cbTopcode.TabIndex = 55
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(17, 120)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl4.TabIndex = 54
        Me.LabelControl4.Text = "TOP"
        '
        'NewOccupancyTopDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(352, 160)
        Me.Controls.Add(Me.cbTopcode)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.dtResDate2)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.dtResDate)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.LabelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "NewOccupancyTopDetails"
        Me.Text = "Occupancy Top Wise Details"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtResDate2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtResDate2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtResDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtResDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTopcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents dtResDate2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtResDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbTopcode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
