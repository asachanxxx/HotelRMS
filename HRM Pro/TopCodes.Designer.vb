<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopCodes
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
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.gcProforma = New DevExpress.XtraGrid.GridControl()
        Me.gvProforma = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcProforma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProforma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(21, 29)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl12.TabIndex = 3
        Me.LabelControl12.Text = "Type"
        '
        'cmbType
        '
        Me.cmbType.Location = New System.Drawing.Point(86, 26)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbType.Properties.Items.AddRange(New Object() {"PRO", "TAX"})
        Me.cmbType.Size = New System.Drawing.Size(100, 20)
        Me.cmbType.TabIndex = 4
        '
        'gcProforma
        '
        Me.gcProforma.Location = New System.Drawing.Point(12, 52)
        Me.gcProforma.MainView = Me.gvProforma
        Me.gcProforma.Name = "gcProforma"
        Me.gcProforma.Size = New System.Drawing.Size(818, 189)
        Me.gcProforma.TabIndex = 5
        Me.gcProforma.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProforma})
        '
        'gvProforma
        '
        Me.gvProforma.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvProforma.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvProforma.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvProforma.Appearance.Row.Options.UseFont = True
        Me.gvProforma.GridControl = Me.gcProforma
        Me.gvProforma.Name = "gvProforma"
        Me.gvProforma.OptionsView.ShowGroupPanel = False
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton4.Appearance.Options.UseFont = True
        Me.SimpleButton4.Location = New System.Drawing.Point(210, 23)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButton4.TabIndex = 6
        Me.SimpleButton4.Text = "Search"
        '
        'TopCodes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 488)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.gcProforma)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.LabelControl12)
        Me.Name = "TopCodes"
        Me.Text = "TopCodes"
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcProforma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProforma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents gcProforma As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvProforma As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
End Class
