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
        Me.gridCategory = New DevExpress.XtraGrid.GridControl()
        Me.vwMain = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txtLastItemCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescription = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCategory = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCategoryID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.gridCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vwMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtLastItemCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategoryID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridCategory
        '
        Me.gridCategory.Location = New System.Drawing.Point(18, 21)
        Me.gridCategory.MainView = Me.vwMain
        Me.gridCategory.Name = "gridCategory"
        Me.gridCategory.Size = New System.Drawing.Size(532, 252)
        Me.gridCategory.TabIndex = 0
        Me.gridCategory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vwMain})
        '
        'vwMain
        '
        Me.vwMain.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.vwMain.Appearance.FocusedCell.Options.UseBackColor = True
        Me.vwMain.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCategoryID, Me.colCategory})
        Me.vwMain.GridControl = Me.gridCategory
        Me.vwMain.Name = "vwMain"
        Me.vwMain.OptionsBehavior.Editable = False
        Me.vwMain.OptionsView.ShowGroupPanel = False
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
        Me.colCategoryID.FieldName = "CategoryID"
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
        Me.colCategory.FieldName = "Categoryname"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 1
        Me.colCategory.Width = 364
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdDelete)
        Me.GroupBox2.Controls.Add(Me.cmdEdit)
        Me.GroupBox2.Controls.Add(Me.cmdAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(559, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(118, 124)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdDelete.Location = New System.Drawing.Point(16, 80)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(91, 23)
        Me.cmdDelete.TabIndex = 2
        Me.cmdDelete.Text = "In Active"
        '
        'cmdEdit
        '
        Me.cmdEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Appearance.Options.UseFont = True
        Me.cmdEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdEdit.Location = New System.Drawing.Point(16, 51)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(91, 23)
        Me.cmdEdit.TabIndex = 1
        Me.cmdEdit.Text = "Edit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Appearance.Options.UseFont = True
        Me.cmdAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmdAdd.Location = New System.Drawing.Point(16, 22)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(91, 23)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "Add"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl5.Location = New System.Drawing.Point(424, 330)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl5.TabIndex = 36
        Me.LabelControl5.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(208, 297)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 35
        Me.lbl28.Text = "*"
        '
        'txtLastItemCode
        '
        Me.txtLastItemCode.EnterMoveNextControl = True
        Me.txtLastItemCode.Location = New System.Drawing.Point(102, 386)
        Me.txtLastItemCode.Name = "txtLastItemCode"
        Me.txtLastItemCode.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastItemCode.Properties.Appearance.Options.UseFont = True
        Me.txtLastItemCode.Size = New System.Drawing.Size(100, 20)
        Me.txtLastItemCode.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(18, 389)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Last Item Code"
        '
        'txtDescription
        '
        Me.txtDescription.EnterMoveNextControl = True
        Me.txtDescription.Location = New System.Drawing.Point(102, 355)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Size = New System.Drawing.Size(436, 20)
        Me.txtDescription.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(18, 358)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Description"
        '
        'txtCategory
        '
        Me.txtCategory.EnterMoveNextControl = True
        Me.txtCategory.Location = New System.Drawing.Point(102, 326)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Properties.Appearance.Options.UseFont = True
        Me.txtCategory.Properties.Mask.EditMask = "\p{Lu}+"
        Me.txtCategory.Properties.Mask.IgnoreMaskBlank = False
        Me.txtCategory.Properties.Mask.ShowPlaceHolders = False
        Me.txtCategory.Size = New System.Drawing.Size(319, 20)
        Me.txtCategory.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(18, 329)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Category Name"
        '
        'txtCategoryID
        '
        Me.txtCategoryID.EnterMoveNextControl = True
        Me.txtCategoryID.Location = New System.Drawing.Point(102, 297)
        Me.txtCategoryID.Name = "txtCategoryID"
        Me.txtCategoryID.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoryID.Properties.Appearance.Options.UseFont = True
        Me.txtCategoryID.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCategoryID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCategoryID.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None
        Me.txtCategoryID.Properties.Mask.EditMask = "[(A-Z)(0-9)]+"
        Me.txtCategoryID.Properties.Mask.IgnoreMaskBlank = False
        Me.txtCategoryID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtCategoryID.Properties.Mask.ShowPlaceHolders = False
        Me.txtCategoryID.Size = New System.Drawing.Size(100, 20)
        Me.txtCategoryID.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(18, 300)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Category ID"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(581, 423)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(84, 31)
        Me.PictureEdit1.TabIndex = 6
        '
        'frmItemCategory
        '
        Me.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(682, 461)
        Me.Controls.Add(Me.gridCategory)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.lbl28)
        Me.Controls.Add(Me.txtLastItemCode)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtCategoryID)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.LabelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmItemCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Category"
        CType(Me.gridCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vwMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.txtLastItemCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategoryID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gridCategory As DevExpress.XtraGrid.GridControl
    Friend WithEvents vwMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtLastItemCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCategory As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCategoryID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
