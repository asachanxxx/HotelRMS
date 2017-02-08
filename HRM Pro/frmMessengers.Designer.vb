<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessengers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMessengers))
        Me.tabmsg = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.btUnread = New DevExpress.XtraEditors.SimpleButton()
        Me.btReadE = New DevExpress.XtraEditors.SimpleButton()
        Me.btReadNEx = New DevExpress.XtraEditors.SimpleButton()
        Me.gcMessenger = New DevExpress.XtraGrid.GridControl()
        Me.gvMessenger = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMsgID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMsgRecipient = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMsg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl28 = New DevExpress.XtraEditors.LabelControl()
        Me.dtDateDep = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbUsers = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtMsg = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMsgFrm = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.btRead = New DevExpress.XtraEditors.SimpleButton()
        Me.btAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.tabmsg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabmsg.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.gcMessenger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMessenger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.dtDateDep.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDateDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUsers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMsg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMsgFrm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabmsg
        '
        Me.tabmsg.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabmsg.AppearancePage.Header.Options.UseFont = True
        Me.tabmsg.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabmsg.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabmsg.Location = New System.Drawing.Point(12, 12)
        Me.tabmsg.LookAndFeel.SkinName = "Metropolis"
        Me.tabmsg.Name = "tabmsg"
        Me.tabmsg.SelectedTabPage = Me.XtraTabPage1
        Me.tabmsg.Size = New System.Drawing.Size(854, 266)
        Me.tabmsg.TabIndex = 0
        Me.tabmsg.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.btUnread)
        Me.XtraTabPage1.Controls.Add(Me.btReadE)
        Me.XtraTabPage1.Controls.Add(Me.btReadNEx)
        Me.XtraTabPage1.Controls.Add(Me.gcMessenger)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.XtraTabPage1.Size = New System.Drawing.Size(852, 241)
        Me.XtraTabPage1.Text = "Message Details"
        '
        'btUnread
        '
        Me.btUnread.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUnread.Appearance.Options.UseFont = True
        Me.btUnread.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btUnread.Location = New System.Drawing.Point(12, 19)
        Me.btUnread.Name = "btUnread"
        Me.btUnread.Size = New System.Drawing.Size(122, 23)
        Me.btUnread.TabIndex = 5
        Me.btUnread.Text = "UnRead"
        '
        'btReadE
        '
        Me.btReadE.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReadE.Appearance.Options.UseFont = True
        Me.btReadE.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btReadE.Location = New System.Drawing.Point(278, 19)
        Me.btReadE.Name = "btReadE"
        Me.btReadE.Size = New System.Drawing.Size(122, 23)
        Me.btReadE.TabIndex = 4
        Me.btReadE.Text = "Read-Expired"
        '
        'btReadNEx
        '
        Me.btReadNEx.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReadNEx.Appearance.Options.UseFont = True
        Me.btReadNEx.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btReadNEx.Location = New System.Drawing.Point(140, 19)
        Me.btReadNEx.Name = "btReadNEx"
        Me.btReadNEx.Size = New System.Drawing.Size(122, 23)
        Me.btReadNEx.TabIndex = 3
        Me.btReadNEx.Text = "Read-Not Expired"
        '
        'gcMessenger
        '
        Me.gcMessenger.Location = New System.Drawing.Point(8, 58)
        Me.gcMessenger.LookAndFeel.SkinName = "Metropolis"
        Me.gcMessenger.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcMessenger.MainView = Me.gvMessenger
        Me.gcMessenger.Name = "gcMessenger"
        Me.gcMessenger.Size = New System.Drawing.Size(836, 175)
        Me.gcMessenger.TabIndex = 0
        Me.gcMessenger.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMessenger})
        '
        'gvMessenger
        '
        Me.gvMessenger.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvMessenger.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvMessenger.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvMessenger.Appearance.Row.Options.UseFont = True
        Me.gvMessenger.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMsgID, Me.colMsgRecipient, Me.colMsg, Me.colADate})
        Me.gvMessenger.GridControl = Me.gcMessenger
        Me.gvMessenger.Name = "gvMessenger"
        Me.gvMessenger.OptionsView.ShowGroupPanel = False
        '
        'colMsgID
        '
        Me.colMsgID.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMsgID.AppearanceCell.Options.UseFont = True
        Me.colMsgID.AppearanceHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMsgID.AppearanceHeader.Options.UseFont = True
        Me.colMsgID.AppearanceHeader.Options.UseTextOptions = True
        Me.colMsgID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMsgID.Caption = "Id"
        Me.colMsgID.FieldName = "MessId"
        Me.colMsgID.Name = "colMsgID"
        Me.colMsgID.Visible = True
        Me.colMsgID.VisibleIndex = 0
        Me.colMsgID.Width = 35
        '
        'colMsgRecipient
        '
        Me.colMsgRecipient.Caption = "From"
        Me.colMsgRecipient.FieldName = "MsgFrom"
        Me.colMsgRecipient.Name = "colMsgRecipient"
        Me.colMsgRecipient.Visible = True
        Me.colMsgRecipient.VisibleIndex = 1
        Me.colMsgRecipient.Width = 150
        '
        'colMsg
        '
        Me.colMsg.Caption = "Message"
        Me.colMsg.FieldName = "Msg"
        Me.colMsg.Name = "colMsg"
        Me.colMsg.Visible = True
        Me.colMsg.VisibleIndex = 2
        Me.colMsg.Width = 500
        '
        'colADate
        '
        Me.colADate.Caption = "Action Date"
        Me.colADate.FieldName = "MsgADate"
        Me.colADate.Name = "colADate"
        Me.colADate.Visible = True
        Me.colADate.VisibleIndex = 3
        Me.colADate.Width = 122
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.lbl28)
        Me.XtraTabPage2.Controls.Add(Me.dtDateDep)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage2.Controls.Add(Me.cmbUsers)
        Me.XtraTabPage2.Controls.Add(Me.txtMsg)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.txtMsgFrm)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(852, 241)
        Me.XtraTabPage2.Text = " Add New Msg"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl3.Location = New System.Drawing.Point(233, 46)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(8, 16)
        Me.LabelControl3.TabIndex = 116
        Me.LabelControl3.Text = "*"
        '
        'lbl28
        '
        Me.lbl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl28.Location = New System.Drawing.Point(514, 103)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(8, 16)
        Me.lbl28.TabIndex = 115
        Me.lbl28.Text = "*"
        '
        'dtDateDep
        '
        Me.dtDateDep.EditValue = Nothing
        Me.dtDateDep.Location = New System.Drawing.Point(109, 167)
        Me.dtDateDep.Name = "dtDateDep"
        Me.dtDateDep.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDateDep.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtDateDep.Size = New System.Drawing.Size(118, 20)
        Me.dtDateDep.TabIndex = 114
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(16, 170)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl2.TabIndex = 113
        Me.LabelControl2.Text = "Action Date"
        '
        'cmbUsers
        '
        Me.cmbUsers.Location = New System.Drawing.Point(109, 41)
        Me.cmbUsers.Name = "cmbUsers"
        Me.cmbUsers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbUsers.Size = New System.Drawing.Size(118, 20)
        Me.cmbUsers.TabIndex = 112
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(109, 79)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(399, 69)
        Me.txtMsg.TabIndex = 26
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(16, 46)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Message To"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(16, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Message From"
        '
        'txtMsgFrm
        '
        Me.txtMsgFrm.Location = New System.Drawing.Point(109, 7)
        Me.txtMsgFrm.Name = "txtMsgFrm"
        Me.txtMsgFrm.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMsgFrm.Properties.Appearance.Options.UseFont = True
        Me.txtMsgFrm.Properties.ReadOnly = True
        Me.txtMsgFrm.Size = New System.Drawing.Size(118, 20)
        Me.txtMsgFrm.TabIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(16, 106)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Message"
        '
        'btRead
        '
        Me.btRead.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRead.Appearance.Options.UseFont = True
        Me.btRead.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btRead.Location = New System.Drawing.Point(873, 67)
        Me.btRead.Name = "btRead"
        Me.btRead.Size = New System.Drawing.Size(92, 23)
        Me.btRead.TabIndex = 2
        Me.btRead.Text = "Read Msg"
        '
        'btAdd
        '
        Me.btAdd.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAdd.Appearance.Options.UseFont = True
        Me.btAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btAdd.Location = New System.Drawing.Point(873, 36)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(92, 23)
        Me.btAdd.TabIndex = 0
        Me.btAdd.Text = "New Msg"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureEdit1.EditValue = Global.HRM_Pro.My.Resources.Resources.logo1
        Me.PictureEdit1.Location = New System.Drawing.Point(872, 241)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 42)
        Me.PictureEdit1.TabIndex = 19
        '
        'frmMessengers
        '
        Me.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.HRM_Pro.My.Resources.Resources.bg33
        Me.ClientSize = New System.Drawing.Size(977, 282)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.tabmsg)
        Me.Controls.Add(Me.btRead)
        Me.Controls.Add(Me.btAdd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Metropolis"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.Name = "frmMessengers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Messenger"
        CType(Me.tabmsg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabmsg.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.gcMessenger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMessenger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.dtDateDep.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDateDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUsers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMsg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMsgFrm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabmsg As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcMessenger As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMessenger As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMsgID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMsgRecipient As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMsg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMsgFrm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMsg As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btRead As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btUnread As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btReadE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btReadNEx As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbUsers As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dtDateDep As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colADate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl28 As DevExpress.XtraEditors.LabelControl
End Class
