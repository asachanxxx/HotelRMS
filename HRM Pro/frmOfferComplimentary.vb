Imports System.Data.SqlClient
Public Class frmOfferComplimentary
    Public PubOffId As Integer = 0
    Private Sub frmOfferComplimentary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        'DtStart.Text = Now.Date
        'DtEnd.Text = Now.Date

        LoadGrid()

        LoadTopcodes()

    End Sub
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()


            dcSearch = New SqlCommand("select OfferID, OfferName,Details,OfferSDate as OfferStartDate,OfferEDate as OfferEndDate,Applicable from dbo.[Offers.Master] where Status='OPEN' order by OfferID", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcOffer.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
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
    Sub ClearFields()

        txtOffername.Text = ""
        txtOfferdetail.Text = ""

        CbAll.Checked = False
        CbFIT.Checked = False
        CbComp.Checked = False
        CbTop.Checked = False
        CbTopAll.Checked = False
        CbTopGroup.Checked = False
        'CbTopGroupA.Checked = False
        'CbTopGroupB.Checked = False
        'CbTopGroupC.Checked = False
        'CbTopGroupD.Checked = False

    End Sub
    Private Sub InsertOffer()

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

            'If CbTopGroupA.Checked = True Then
            '    Applicable = "TOP"
            '    GroupA = 1
            'End If

            'If CbTopGroupB.Checked = True Then
            '    Applicable = "TOP"
            '    GroupB = 1
            'End If

            'If CbTopGroupC.Checked = True Then
            '    Applicable = "TOP"
            '    GroupC = 1
            'End If

            'If CbTopGroupD.Checked = True Then
            '    Applicable = "TOP"
            '    GroupD = 1
            'End If

        dcInsertNewAcc = New SqlCommand("InsertOfferMaster_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@OfferName", SqlDbType.VarChar).Value = txtOffername.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Details", SqlDbType.VarChar).Value = txtOfferdetail.Text.Trim
            'dcInsertNewAcc.Parameters.Add("@OfferSDate", SqlDbType.DateTime).Value = DtStart.DateTime.Date
            'dcInsertNewAcc.Parameters.Add("@OfferEDate", SqlDbType.DateTime).Value = DtEnd.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@Applicable", SqlDbType.VarChar).Value = Applicable
        dcInsertNewAcc.Parameters.Add("@TopGroupA", SqlDbType.VarChar).Value = GroupA
        dcInsertNewAcc.Parameters.Add("@TopGroupB", SqlDbType.VarChar).Value = GroupB
        dcInsertNewAcc.Parameters.Add("@TopGroupC", SqlDbType.VarChar).Value = GroupC
        dcInsertNewAcc.Parameters.Add("@TopGroupD", SqlDbType.VarChar).Value = GroupD
        dcInsertNewAcc.Parameters.Add("@Status", SqlDbType.VarChar).Value = "OPEN"
        dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = "Rashad"

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Offer Details Saved Successfully", "Save Offer Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub CbTop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        CbAll.Checked = False
        CbFIT.Checked = False
        CbComp.Checked = False

        CbTopAll.Checked = False
        CbTopGroup.Checked = False
        'CbTopGroupA.Checked = False
        'CbTopGroupB.Checked = False
        'CbTopGroupB.Checked = False
        'CbTopGroupB.Checked = False
        CbTopAll.Enabled = True
        CbTopGroup.Enabled = True
    End Sub
    Private Sub CbTopAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'CbAll.Checked = True

        CbTopGroup.Checked = True
        'CbTopGroupA.Checked = True
        'CbTopGroupB.Checked = True
        'CbTopGroupC.Checked = True
        'CbTopGroupD.Checked = True


    End Sub

    Private Sub CbTopGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        CbAll.Checked = False
        CbFIT.Checked = False
        CbComp.Checked = False
        CbTop.Checked = False
        CbTopAll.Checked = False
        'CbTopGroup.Checked = True


        'CbTopGroupA.Enabled = True
        'CbTopGroupB.Enabled = True
        'CbTopGroupC.Enabled = True
        'CbTopGroupD.Enabled = True




    End Sub

    Private Sub CbAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'CbAll.Checked = True
        CbFIT.Checked = False
        CbComp.Checked = False
        CbTop.Checked = False
        CbTopAll.Checked = False
        CbTopGroup.Checked = False
        'CbTopGroupA.Checked = False
        'CbTopGroupB.Checked = False
        'CbTopGroupB.Checked = False
        'CbTopGroupB.Checked = False


    End Sub
    Private Sub CbFIT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'CbFIT.Checked = True
        CbAll.Checked = False
        CbComp.Checked = False
        CbTop.Checked = False
        CbTopAll.Checked = False
        CbTopGroup.Checked = False
        'CbTopGroupA.Checked = False
        'CbTopGroupB.Checked = False
        'CbTopGroupB.Checked = False
        'CbTopGroupB.Checked = False
    End Sub
    Private Sub CbComp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'CbComp.Checked = True
        CbFIT.Checked = False
        CbAll.Checked = False
        CbTop.Checked = False
        CbTopAll.Checked = False
        CbTopGroup.Checked = False
        'CbTopGroupA.Checked = False
        'CbTopGroupB.Checked = False
        'CbTopGroupB.Checked = False
        'CbTopGroupB.Checked = False
    End Sub
    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        If String.Compare(btAdd.Text, "Add", False) = 0 Then

            ClearFields()
            btAdd.Text = "Save"
            btEdit.Enabled = False
            btDel.Enabled = False
            tabOffers.SelectedTabPageIndex = 1

        Else

            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Offer Details", "Save Offer Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InsertOffer()


                End If
                LoadGrid()

                btAdd.Text = "Add"
                btEdit.Enabled = True
                btDel.Enabled = True
                tabOffers.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try
        End If


    End Sub
    Private Sub ShowGridDets()
        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try
            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Offers.Master]  where Status='OPEN' and OfferID= '{0}' ", gvOffer.GetRowCellValue(gvOffer.FocusedRowHandle, "OfferID")), Conn)
            daShow.Fill(dsShow)


            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabOffers.SelectedTabPageIndex = 1

            PubOffId = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("OfferID"))
            txtOffername.Text = dsShow.Tables(0).Rows(0).Item("OfferName")
            txtOfferdetail.Text = dsShow.Tables(0).Rows(0).Item("Details")
            'DtStart.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("OfferSDate"))
            'DtEnd.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("OfferEDate"))

            Dim getApplicable As String = dsShow.Tables(0).Rows(0).Item("Applicable")

            Dim getGroupA As Integer = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("TopGroupA"))
            Dim getGroupB As Integer = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("TopGroupB"))
            Dim getGroupC As Integer = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("TopGroupC"))
            Dim getGroupD As Integer = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("TopGroupD"))



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

                If getGroupD = 1 Then
                    'CbTopGroupD.Checked = True
                    CbTopGroup.Checked = True
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

    Private Sub gvOffer_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvOffer.DoubleClick
        ShowGridDets()
    End Sub
    Private Sub UpdateOffers()

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

            'If CbTopGroupA.Checked = True Then
            '    Applicable = "TOP"
            '    GroupA = 1
            'End If

            'If CbTopGroupB.Checked = True Then
            '    Applicable = "TOP"
            '    GroupB = 1
            'End If

            'If CbTopGroupC.Checked = True Then
            '    Applicable = "TOP"
            '    GroupC = 1
            'End If

            'If CbTopGroupD.Checked = True Then
            '    Applicable = "TOP"
            '    GroupD = 1
            'End If


        dcInsertNewAcc = New SqlCommand("UpdateOfferDetails_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@OfferID", SqlDbType.Int).Value = PubOffId
        dcInsertNewAcc.Parameters.Add("@OfferName", SqlDbType.VarChar).Value = txtOffername.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Details", SqlDbType.VarChar).Value = txtOfferdetail.Text.Trim
            'dcInsertNewAcc.Parameters.Add("@OfferSDate", SqlDbType.DateTime).Value = DtStart.DateTime.Date
            'dcInsertNewAcc.Parameters.Add("@OfferEDate", SqlDbType.DateTime).Value = DtEnd.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@Applicable", SqlDbType.VarChar).Value = Applicable
        dcInsertNewAcc.Parameters.Add("@TopGroupA", SqlDbType.VarChar).Value = GroupA
        dcInsertNewAcc.Parameters.Add("@TopGroupB", SqlDbType.VarChar).Value = GroupB
        dcInsertNewAcc.Parameters.Add("@TopGroupC", SqlDbType.VarChar).Value = GroupC
        dcInsertNewAcc.Parameters.Add("@TopGroupD", SqlDbType.VarChar).Value = GroupD

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Offer Details Updated Successfully", "Update Offer Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub InactiveOffers()
        Try

       
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        dcInsertNewAcc = New SqlCommand("InactiveOffers_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@OfferID", SqlDbType.Int).Value = PubOffId
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Offer Details Deleted Successfully", "Delete Offer Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click
        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This Offer Details", "Update Offer Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                UpdateOffers()


            End If
            LoadGrid()
            tabOffers.SelectedTabPageIndex = 0
            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub
    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDel.Click
        Try

            Dim bt As DialogResult = MessageBox.Show("Do You Want To Delete This Offer Details", "Delete Offer Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                InactiveOffers()


            End If
            LoadGrid()
            tabOffers.SelectedTabPageIndex = 0
            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub

    Private Sub CbTop_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbTop.CheckedChanged
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

    Private Sub CbTopAll_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbTopAll.CheckedChanged
        CbTopGroup.Checked = True
        CbTopGroupA.Checked = True
        CbTopGroupB.Checked = True
        CbTopGroupC.Checked = True
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

        'If PusIsEdit = 1 Then
        btDelup.Visible = True
        'End If
    End Sub
End Class