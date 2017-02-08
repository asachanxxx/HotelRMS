<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerformaPeriode
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.CachedReceiptDirect1 = New HRM_Pro.CachedReceiptDirect()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.gcBoat = New DevExpress.XtraGrid.GridControl()
        Me.gvBoat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.gcBoat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBoat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAdd.Location = New System.Drawing.Point(28, 22)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Get Null Rates"
        '
        'gcBoat
        '
        Me.gcBoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        GridLevelNode1.RelationName = "Level1"
        Me.gcBoat.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcBoat.Location = New System.Drawing.Point(28, 51)
        Me.gcBoat.MainView = Me.gvBoat
        Me.gcBoat.Name = "gcBoat"
        Me.gcBoat.Size = New System.Drawing.Size(539, 166)
        Me.gcBoat.TabIndex = 2
        Me.gcBoat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBoat})
        '
        'gvBoat
        '
        Me.gvBoat.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvBoat.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvBoat.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvBoat.Appearance.Row.Options.UseFont = True
        Me.gvBoat.GridControl = Me.gcBoat
        Me.gvBoat.Name = "gvBoat"
        Me.gvBoat.OptionsView.ShowGroupPanel = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton1.Location = New System.Drawing.Point(28, 243)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(92, 23)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Update"
        '
        'GridControl1
        '
        Me.GridControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GridControl1.Location = New System.Drawing.Point(28, 283)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(539, 166)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'PerformaPeriode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 461)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.gcBoat)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "PerformaPeriode"
        Me.Text = "PerformaPeriode"
        CType(Me.gcBoat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBoat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CachedReceiptDirect1 As HRM_Pro.CachedReceiptDirect
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcBoat As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBoat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
