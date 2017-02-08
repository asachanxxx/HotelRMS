<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemCategory))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gcMain = New DevExpress.XtraGrid.GridControl()
        Me.gvMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gcMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gcMain)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 266)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'gcMain
        '
        Me.gcMain.Location = New System.Drawing.Point(6, 21)
        Me.gcMain.MainView = Me.gvMain
        Me.gcMain.Name = "gcMain"
        Me.gcMain.Size = New System.Drawing.Size(532, 239)
        Me.gcMain.TabIndex = 0
        Me.gcMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMain})
        '
        'gvMain
        '
        Me.gvMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCategoryID, Me.colCategory})
        Me.gvMain.GridControl = Me.gcMain
        Me.gvMain.Name = "gvMain"
        Me.gvMain.OptionsBehavior.Editable = False
        Me.gvMain.OptionsView.ShowGroupPanel = False
        '
        'colCategoryID
        '
        Me.colCategoryID.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.colCategoryID.AppearanceCell.Options.UseFont = True
        Me.colCategoryID.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCategoryID.AppearanceHeader.Options.UseFont = True
        Me.colCategoryID.AppearanceHeader.Options.UseTextOptions = True
        Me.colCategoryID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCategoryID.Caption = "Category ID"
        Me.colCategoryID.Name = "colCategoryID"
        Me.colCategoryID.OptionsColumn.AllowEdit = False
        Me.colCategoryID.Visible = True
        Me.colCategoryID.VisibleIndex = 0
        Me.colCategoryID.Width = 150
        '
        'colCategory
        '
        Me.colCategory.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCategory.AppearanceCell.Options.UseFont = True
        Me.colCategory.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCategory.AppearanceHeader.Options.UseFont = True
        Me.colCategory.AppearanceHeader.Options.UseTextOptions = True
        Me.colCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCategory.Caption = "Category"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 1
        Me.colCategory.Width = 364
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.SimpleButton3)
        Me.GroupBox2.Controls.Add(Me.SimpleButton2)
        Me.GroupBox2.Controls.Add(Me.SimpleButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(562, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(103, 272)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton3.Location = New System.Drawing.Point(6, 80)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(91, 23)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "Delete"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton2.Location = New System.Drawing.Point(6, 51)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(91, 23)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "Edit"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.SimpleButton1.Location = New System.Drawing.Point(6, 21)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(91, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Add"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextEdit4)
        Me.GroupBox3.Controls.Add(Me.LabelControl4)
        Me.GroupBox3.Controls.Add(Me.TextEdit3)
        Me.GroupBox3.Controls.Add(Me.LabelControl3)
        Me.GroupBox3.Controls.Add(Me.TextEdit2)
        Me.GroupBox3.Controls.Add(Me.LabelControl2)
        Me.GroupBox3.Controls.Add(Me.TextEdit1)
        Me.GroupBox3.Controls.Add(Me.LabelControl1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 284)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(544, 166)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(90, 108)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit4.Properties.Appearance.Options.UseFont = True
        Me.TextEdit4.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit4.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(6, 111)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Last Item Code"
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(90, 77)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit3.Properties.Appearance.Options.UseFont = True
        Me.TextEdit3.Size = New System.Drawing.Size(436, 20)
        Me.TextEdit3.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(6, 80)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Description"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(90, 48)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Size = New System.Drawing.Size(319, 20)
        Me.TextEdit2.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(6, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Category Name"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(90, 19)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit1.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(6, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Category ID"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImage = Global.HRM_Pro.My.Resources.Resources._2
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox4.Location = New System.Drawing.Point(562, 284)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(103, 164)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'frmItemCategory
        '
        Me.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.rmsinterface
        Me.ClientSize = New System.Drawing.Size(673, 461)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmItemCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Category"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gcMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gcMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
