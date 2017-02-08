Imports System.Data.SqlClient
Public Class frmDiscountplan

    Public PubDisId As Integer = 0
    Public PusIsEdit As Integer = 0
    Public PubSelecDisDetailId As String = ""
    Private Sub frmDiscountplan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        DisplanSdate.Text = Now.Date
        DisplanEdate.Text = Now.Date

        cmbDistype.SelectedIndex = 0

        cbTopcode.SelectedIndex = 0

        gcTop.DataSource = Nothing

        LoadGrid()
        LoadTopcodes()

        tabDiscou.TabPages(1).PageEnabled = False

    End Sub
    Sub ClearFields()

        DisplanName.Text = ""
        DisplanDetails.Text = ""
        DisplanAmt.Text = ""

        CbAll.Checked = False
        CbFIT.Checked = False
        CbComp.Checked = False
        CbTop.Checked = False
        CbTopAll.Checked = False
        CbTopGroup.Checked = False
        CbTopGroupA.Checked = False
        CbTopGroupB.Checked = False
        CbTopGroupC.Checked = False
        CbTopInd.Checked = False


        cbTopcode.SelectedIndex = 0

        cbTopcode.Visible = False
        txtTopname.Visible = False
        btAssign.Visible = False
        gcTop.Visible = False
        gcTop.DataSource = Nothing

        PusIsEdit = 0
        PubSelecDisDetailId = ""
        DeleteTemp()


    End Sub
    Private Sub InsertDiscount()

        Try

            Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim Applicable As String = ""
            Dim Credit As Integer = 0
            Dim Prepaid As Integer = 0
            Dim Others As Integer = 0
            Dim Selective As Integer = 0


        If CbAll.Checked = True Then
            Applicable = "ALL"

        End If

        If CbFIT.Checked = True Then
            Applicable = "FIT"
        End If


        If CbComp.Checked = True Then
            Applicable = "COM"
        End If


        If CbTop.Checked = True Then
            Applicable = "TOP"

            End If


        If CbTopAll.Checked = True Then
            Applicable = "TOP"
                Credit = 1
                Prepaid = 1
                Others = 1


        End If

        If CbTopGroupA.Checked = True Then
            Applicable = "TOP"
                Credit = 1
        End If

        If CbTopGroupB.Checked = True Then
            Applicable = "TOP"
                Prepaid = 1
        End If

        If CbTopGroupC.Checked = True Then
            Applicable = "TOP"
                Others = 1
            End If

            If CbTopInd.Checked = True Then
                Applicable = "TOP"
                Selective = 1
            End If




            Dim SelecDisDetailId As String = System.Guid.NewGuid().ToString()
            Dim PassId As String = ""

            If Selective = 1 Then
                PassId = SelecDisDetailId

            Else
                PassId = ""

            End If

            dcInsertNewAcc = New SqlCommand("InsertDiscountMaster_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            Dim CurrentUser As String = CurrUser

            dcInsertNewAcc.Parameters.Add("@DisPlan", SqlDbType.VarChar).Value = DisplanName.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Details", SqlDbType.VarChar).Value = DisplanDetails.Text.Trim
            dcInsertNewAcc.Parameters.Add("@DisType", SqlDbType.VarChar).Value = cmbDistype.Text.Trim
            dcInsertNewAcc.Parameters.Add("@DisAmt", SqlDbType.Decimal).Value = Convert.ToDecimal(DisplanAmt.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@DisSDate", SqlDbType.DateTime).Value = DisplanSdate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@DisEDate", SqlDbType.DateTime).Value = DisplanEdate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@Applicable", SqlDbType.VarChar).Value = Applicable
            dcInsertNewAcc.Parameters.Add("@Credit", SqlDbType.VarChar).Value = Credit
            dcInsertNewAcc.Parameters.Add("@Prepaid", SqlDbType.VarChar).Value = Prepaid
            dcInsertNewAcc.Parameters.Add("Others", SqlDbType.VarChar).Value = Others
            dcInsertNewAcc.Parameters.Add("@Selective", SqlDbType.VarChar).Value = Selective
            dcInsertNewAcc.Parameters.Add("@SelectiveDetailId", SqlDbType.VarChar).Value = PassId

            dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
            dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Discount Details Saved Successfully", "Save Discount Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()



            If Selective = 1 Then
                InsertDisscountIndTop(SelecDisDetailId)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub LoadTopName(ByVal topcode As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim Passtopcode As String = topcode

            dcSearch = New SqlCommand("select TopName from [Touroperator.Master] where  TopCode=@Passtopcode", Conn)
            dcSearch.Parameters.Add("@PASSTOPCODE", SqlDbType.NVarChar).Value = Passtopcode

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            txtTopname.Text = dsMain.Tables(0).Rows(0)(0).ToString()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub CbTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbTop.CheckedChanged

        CbAll.Checked = False
        CbFIT.Checked = False
        CbComp.Checked = False

        CbTopAll.Checked = False
        CbTopGroup.Checked = False
        CbTopGroupA.Checked = False
        CbTopGroupB.Checked = False
        CbTopGroupB.Checked = False
        CbTopGroupB.Checked = False
        CbTopAll.Enabled = True
        CbTopGroup.Enabled = True
        CbTopInd.Enabled = True
    End Sub

    Private Sub CbTopAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbTopAll.CheckedChanged
        'CbAll.Checked = True

        CbTopGroup.Checked = True
        CbTopGroupA.Checked = True
        CbTopGroupB.Checked = True
        CbTopGroupC.Checked = True



    End Sub

    Private Sub CbTopGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbTopGroup.CheckedChanged

        CbAll.Checked = False
        CbFIT.Checked = False
        CbComp.Checked = False
        CbTop.Checked = False
        CbTopAll.Checked = False
  

        CbTopGroupA.Enabled = True
        CbTopGroupB.Enabled = True
        CbTopGroupC.Enabled = True



        

    End Sub

    Private Sub CbAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbAll.CheckedChanged

        'CbAll.Checked = True
        CbFIT.Checked = False
        CbComp.Checked = False
        CbTop.Checked = False
        CbTopAll.Checked = False
        CbTopGroup.Checked = False
        CbTopGroupA.Checked = False
        CbTopGroupB.Checked = False
        CbTopGroupB.Checked = False
        CbTopGroupB.Checked = False


    End Sub
    Private Sub CbFIT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbFIT.CheckedChanged
        'CbFIT.Checked = True
        CbAll.Checked = False
        CbComp.Checked = False
        CbTop.Checked = False
        CbTopAll.Checked = False
        CbTopGroup.Checked = False
        CbTopGroupA.Checked = False
        CbTopGroupB.Checked = False
        CbTopGroupB.Checked = False
        CbTopGroupB.Checked = False
    End Sub
    Private Sub CbComp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbComp.CheckedChanged
        'CbComp.Checked = True
        CbFIT.Checked = False
        CbAll.Checked = False
        CbTop.Checked = False
        CbTopAll.Checked = False
        CbTopGroup.Checked = False
        CbTopGroupA.Checked = False
        CbTopGroupB.Checked = False
        CbTopGroupB.Checked = False
        CbTopGroupB.Checked = False
    End Sub
    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "DiscountPlan", "Add")

        If CheckAccess = True Then


            If String.Compare(btAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btAdd.Text = "Save"
                btEdit.Enabled = False
                btDel.Enabled = False
                tabDiscou.TabPages(1).PageEnabled = True
                tabDiscou.SelectedTabPageIndex = 1

            Else

                Try

                    Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Discount Details", "Save Discount Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If bt = Windows.Forms.DialogResult.Yes Then

                        InsertDiscount()


                    End If
                    LoadGrid()
                    gcTop.DataSource = Nothing
                    btAdd.Text = "Add"
                    btEdit.Enabled = True
                    btDel.Enabled = True
                    tabDiscou.TabPages(1).PageEnabled = False
                    tabDiscou.SelectedTabPageIndex = 0
                    gcTop.DataSource = Nothing
                    Exit Sub

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
                End Try
            End If

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select DisID as DiscountId ,DisPlan as PlanName,Details,DisAmt as DiscountPer,DisSDate as PlanStartDate,DisEDate as PlanEndDate,Applicable from dbo.[Discounts.Master] where Status='OPEN' order by DiscountId", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            GcDisscounts.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub DisplanAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DisplanAmt.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.DisplanSdate.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub
    Private Sub ShowGridDets()
        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try


            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Discounts.Master]  where Status='OPEN' and DisId= '{0}' ", GcDisscountview.GetRowCellValue(GcDisscountview.FocusedRowHandle, "DiscountId")), Conn)
            daShow.Fill(dsShow)

            PusIsEdit = 1


            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If


            tabDiscou.TabPages(1).PageEnabled = True
            tabDiscou.SelectedTabPageIndex = 1

            PubDisId = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("DisID"))
            DisplanName.Text = dsShow.Tables(0).Rows(0).Item("DisPlan")
            DisplanDetails.Text = dsShow.Tables(0).Rows(0).Item("Details")
            cmbDistype.Text = dsShow.Tables(0).Rows(0).Item("DisType")
            cmbDistype.ClosePopup()

            If cmbDistype.Text = "Percentage" Then

                lbldistype.Text = "Discount %"
            End If

            If cmbDistype.Text = "Value" Then
                lbldistype.Text = "Discount Value"
            End If


            DisplanAmt.Text = dsShow.Tables(0).Rows(0).Item("DisAmt")
            DisplanSdate.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("DisSDate"))
            DisplanEdate.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("DisEDate"))

            Dim getApplicable As String = dsShow.Tables(0).Rows(0).Item("Applicable")

            Dim getGroupA As Integer = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("Credit"))
            Dim getGroupB As Integer = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("Prepaid"))
            Dim getGroupC As Integer = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("Others"))
            Dim getSelectiveid As Integer = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("Selective"))



            If getApplicable = "ALL" Then

                CbAll.Checked = True

            End If

            If getApplicable = "FIT" Then

                CbFIT.Checked = True

            End If


            If getApplicable = "COM" Then

                CbComp.Checked = True

            End If


            If getApplicable = "TOP" Then

                CbTop.Checked = True

                If getGroupA = 1 Then

                    CbTopGroupA.Checked = True
                    CbTopGroup.Checked = True

                End If

                If getGroupB = 1 Then

                    CbTopGroupB.Checked = True
                    CbTopGroup.Checked = True
                End If


                If getGroupC = 1 Then
                    CbTopGroupC.Checked = True
                    CbTopGroup.Checked = True
                End If

                If getSelectiveid = 1 Then

                    CbTopGroup.Checked = True
                    CbTopInd.Checked = True
                End If

                Dim dsLoadDisTop As New DataSet



                Dim selecId As String = dsShow.Tables(0).Rows(0).Item("SelectiveDetailId")
                PubSelecDisDetailId = dsShow.Tables(0).Rows(0).Item("SelectiveDetailId")

                dsLoadDisTop = DSGetSelectiveDisDetails(selecId)

                'Dim aa As Integer = dsLoadDisTop.Tables(0).Rows.Count

                'MessageBox.Show("Total : " + aa)

                If dsLoadDisTop IsNot Nothing Then

                    gcTop.DataSource = dsLoadDisTop.Tables(0)

                End If



            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
    Private Sub LoadTopcodes()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select TopCode from [Touroperator.Master] where Status='Active' order by TopCode", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            Dim newCustomersRow As DataRow = dsMain.Tables(0).NewRow()


            While (DscountTest < Dscount)

                cbTopcode.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cbTopcode.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub GcDisscountview_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GcDisscountview.DoubleClick
        ShowGridDets()
    End Sub
    Private Sub UpdateDiscount()

        Try

        
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim Applicable As String = ""
        Dim GroupA As Integer = 0
        Dim GroupB As Integer = 0
        Dim GroupC As Integer = 0
        Dim GroupD As Integer = 0




        If CbAll.Checked = True Then
            Applicable = "ALL"

        End If

        If CbFIT.Checked = True Then
            Applicable = "FIT"
        End If


        If CbComp.Checked = True Then
            Applicable = "COM"
        End If


        If CbTop.Checked = True Then
            Applicable = "TOP"

        End If


        If CbTopAll.Checked = True Then
            Applicable = "TOP"
            GroupA = 1
            GroupB = 1
            GroupC = 1
            GroupD = 1

        End If

        If CbTopGroupA.Checked = True Then
            Applicable = "TOP"
            GroupA = 1
        End If

        If CbTopGroupB.Checked = True Then
            Applicable = "TOP"
            GroupB = 1
        End If

        If CbTopGroupC.Checked = True Then
            Applicable = "TOP"
            GroupC = 1
            End If

            If CbTopInd.Checked = True Then
                Applicable = "TOP"
                GroupD = 1
            End If

        


        dcInsertNewAcc = New SqlCommand("UpdateDiscountDetails_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@DisID", SqlDbType.Int).Value = PubDisId
        dcInsertNewAcc.Parameters.Add("@DisPlan", SqlDbType.VarChar).Value = DisplanName.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Details", SqlDbType.VarChar).Value = DisplanDetails.Text.Trim
            dcInsertNewAcc.Parameters.Add("@DisType", SqlDbType.VarChar).Value = cmbDistype.Text.Trim
        dcInsertNewAcc.Parameters.Add("@DisAmt", SqlDbType.Decimal).Value = Convert.ToDecimal(DisplanAmt.Text.Trim)
        dcInsertNewAcc.Parameters.Add("@DisSDate", SqlDbType.DateTime).Value = DisplanSdate.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@DisEDate", SqlDbType.DateTime).Value = DisplanEdate.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@Applicable", SqlDbType.VarChar).Value = Applicable
            dcInsertNewAcc.Parameters.Add("@Credit", SqlDbType.VarChar).Value = GroupA
            dcInsertNewAcc.Parameters.Add("@Prepaid", SqlDbType.VarChar).Value = GroupB
            dcInsertNewAcc.Parameters.Add("@Others", SqlDbType.VarChar).Value = GroupC
            dcInsertNewAcc.Parameters.Add("@Selective", SqlDbType.VarChar).Value = GroupD

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Discount Details Updated Successfully", "Update Discount Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub InactiveDiscount()
        Try

       
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        dcInsertNewAcc = New SqlCommand("InactiveDiscounts_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@DisID", SqlDbType.Int).Value = PubDisId
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Discount Details Inactivated Successfully", "Inactivate Discount Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "DiscountPlan", "Edit")

        If CheckAccess = True Then



            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This Discount Details", "Update Disocunt Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    UpdateDiscount()


                End If
                LoadGrid()
                tabDiscou.TabPages(1).PageEnabled = False
                tabDiscou.SelectedTabPageIndex = 0
                Exit Sub

                btDelup.Visible = False

                PubSelecDisDetailId = ""
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDel.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "DiscountPlan", "Delete")

        If CheckAccess = True Then



            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Delete This Discount Details", "Delete Discount Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveDiscount()


                End If
                LoadGrid()
                tabDiscou.TabPages(1).PageEnabled = False
                tabDiscou.SelectedTabPageIndex = 0
                Exit Sub
                btDelup.Visible = False
                PusIsEdit = 0
                PubSelecDisDetailId = ""
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub cmbDistype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDistype.SelectedIndexChanged
        If cmbDistype.Text = "Percentage" Then
            lbldistype.Text = "Discount %"
        End If

        If cmbDistype.Text = "Value" Then
            lbldistype.Text = "Discount Value"
        End If


    End Sub

    Private Sub cbTopcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTopcode.SelectedIndexChanged
        LoadTopName(cbTopcode.Text)
    End Sub

    Private Sub CbTopInd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbTopInd.CheckedChanged
        cbTopcode.Visible = True
        txtTopname.Visible = True
        btAssign.Visible = True
        gcTop.Visible = True

        cbTopcode.Enabled = True
        txtTopname.Enabled = True
        btAssign.Enabled = True
        gcTop.Enabled = True

        If PusIsEdit = 1 Then
            btDelup.Visible = True
        End If

    End Sub
    Private Sub DeleteTemp()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Dim CurrentUser As String = CurrUser

        dcInsertNewAcc = New SqlCommand("DelDisdetailtemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
        dcInsertNewAcc.Parameters.Add("@UserId", SqlDbType.VarChar).Value = CurrentUser

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub
    Private Sub InsertResRoomCountTemp()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InsertDiscountDetailTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

        Dim CurrentUser As String = CurrUser

        dcInsertNewAcc.Parameters.Add("@Code", SqlDbType.VarChar).Value = cbTopcode.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Detail", SqlDbType.VarChar).Value = txtTopname.Text.Trim
        dcInsertNewAcc.Parameters.Add("@UserId", SqlDbType.VarChar).Value = CurrentUser
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub
    Private Sub LoadDisDetails()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim CurrentUser As String = CurrUser

            dcSearch = New SqlCommand("select Code,Detail from dbo.[Discount.Detail.Temp] where UserId=@User order by Id", Conn)
            dcSearch.Parameters.Add("@User", SqlDbType.NVarChar).Value = CurrentUser

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            gcTop.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadDisMasDetails()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()



            dcSearch = New SqlCommand("SELECT  dbo.[Discounts.Detail].TopCode, dbo.[Touroperator.Master].TopName, dbo.[Discounts.Detail].DisId ,dbo.[Discounts.Detail].DisDetailID FROM dbo.[Discounts.Detail] INNER JOIN dbo.[Touroperator.Master] ON dbo.[Discounts.Detail].TopCode COLLATE SQL_Latin1_General_CP1_CI_AS = dbo.[Touroperator.Master].TopCode where dbo.[Discounts.Detail].DisId=@DisId order by dbo.[Touroperator.Master].Topcode", Conn)
            dcSearch.Parameters.Add("@DisId", SqlDbType.VarChar).Value = PubSelecDisDetailId

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            gcTop.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub btAssign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAssign.Click

        ' gcTop.DataSource = Nothing

        If PusIsEdit = 1 Then
            InsertDisDirectTop(PubSelecDisDetailId)

            LoadDisMasDetails()
        Else
            InsertResRoomCountTemp()
            LoadDisDetails()
        End If



    End Sub
    Private Sub InsertDisscountIndTop(ByVal detailid As String)

        Try

            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand

            Dim getDetailId As String = detailid

            Dim CurrentUser As String = CurrUser

            dcSearch = New SqlCommand("select * from dbo.[Discount.Detail.Temp]  where UserId=@UserId", Conn)
            dcSearch.Parameters.Add("@UserId", SqlDbType.VarChar).Value = CurrentUser


            Conn.Open()
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            Conn.Close()

            Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1


            While DScount >= 0

                dcInsertNewAcc = New SqlCommand("InsertDiscountDetail_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                dcInsertNewAcc.Parameters.Add("@DisId", SqlDbType.VarChar).Value = getDetailId
                dcInsertNewAcc.Parameters.Add("@TopCode", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(1).ToString

                Conn.Open()
                dcInsertNewAcc.ExecuteNonQuery()
                Conn.Close()
                DScount = DScount - 1
            End While

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub InsertDisDirectTop(ByVal detailid As String)

        Try

            Dim Conn As New SqlConnection(ConnString)
            Dim dcInsertNewAcc As New SqlCommand

            Dim daMain As New SqlDataAdapter
            Dim dsMain As New DataSet
            Dim dcSearch As New SqlCommand

            Dim getDetailId As String = detailid

                dcInsertNewAcc = New SqlCommand("InsertDiscountDetail_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

                dcInsertNewAcc.Parameters.Add("@DisId", SqlDbType.VarChar).Value = getDetailId
            dcInsertNewAcc.Parameters.Add("@TopCode", SqlDbType.VarChar).Value = cbTopcode.Text.ToString

                Conn.Open()
                dcInsertNewAcc.ExecuteNonQuery()
                Conn.Close()
              

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Function DSGetSelectiveDisDetails(ByVal DisdetailId As String) As DataSet
        Dim Conn As New SqlConnection(ConnString)

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Try
            Conn.Open()

            Dim getDisdetailId As String = DisdetailId
            dcSearch = New SqlCommand("SELECT  dbo.[Discounts.Detail].TopCode, dbo.[Touroperator.Master].TopName, dbo.[Discounts.Detail].DisId ,dbo.[Discounts.Detail].DisDetailID FROM dbo.[Discounts.Detail] INNER JOIN dbo.[Touroperator.Master] ON dbo.[Discounts.Detail].TopCode COLLATE SQL_Latin1_General_CP1_CI_AS = dbo.[Touroperator.Master].TopCode where dbo.[Discounts.Detail].DisId=@DisId order by dbo.[Touroperator.Master].Topcode", Conn)
            dcSearch.Parameters.Add("@DisId", SqlDbType.VarChar).Value = getDisdetailId
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSGetSelectiveDisDetails = dsMain
            End If
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            Return Nothing
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Function

    Private Sub DeleteDisMasTop()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand




        Dim DetailId As Integer = gcViewTop.GetRowCellValue(gcViewTop.FocusedRowHandle, "DisDetailID")

        dcInsertNewAcc = New SqlCommand("DelDisDetail_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
        dcInsertNewAcc.Parameters.Add("@DetailId", SqlDbType.Int).Value = DetailId

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Private Sub LoadDisDetailsMaster()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            Dim getDisdetailid As String = gcViewTop.GetRowCellValue(gcViewTop.FocusedRowHandle, "DisId").ToString

            dcSearch = New SqlCommand("select Code,Detail from dbo.[Discount.Detail] where DisId=@DisId order by DisDetailID", Conn)
            dcSearch.Parameters.Add("@DisId", SqlDbType.NVarChar).Value = getDisdetailid

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            gcTop.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub btDelup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelup.Click

        ' gcTop.DataSource = Nothing

        DeleteDisMasTop()

        ' LoadDisDetailsMaster()

        LoadDisMasDetails()

    End Sub

    Private Sub frmDiscountplan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class