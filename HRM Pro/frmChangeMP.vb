Imports System.Data.SqlClient
Imports Word = Microsoft.Office.Interop.Word




Public Class frmChangeMP

    Private Sub txtReservationno_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReservationno.EditValueChanged

    End Sub

    Private Sub TextEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbMealplan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMealplan.SelectedIndexChanged

    End Sub

    Private Sub frmChangeMP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadMealPalns()

    End Sub

    Private Sub LoadMealPalns()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select Distinct MealType from dbo.[MealPlan.Master]  where Status='OPEN'", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)

                cmbMealplan.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cmbMealplan.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub LoadResDetails()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try

            Dim getResno As String = txtReservationno.Text.Trim

            Conn.Open()
            ' dcSearch = New SqlCommand("select ResNo,ResDate,Guest,ResType,Topcode,IsTopcontract,TopContractId,ArrDate,DepDate,ArrFlight,DepFlight,convert(char(5), ArrTime, 108) [ArrTime],convert(char(5), DepTime, 108) [DepTime],ArrTrans,DepTrans,PaxId,AdultQty,ChildrenQty,InfantsQty,MealPlan,Rate,DisPlanId,OfferId,AmenId,Total,PayMode,PayExpiryDate,PayCCNo,Guestlikes,Guestdislikes,BillingInst,Remarks,Refno,PaymentStatus,Status,IsProformaCreated,ProfomaInvoiceno,EnteredBy,EnteredDate,InactivatedBy,InactivatedDate from dbo.[Reservation.Master] where ResNo=@ResNo", Conn)
            dcSearch = New SqlCommand("select ResNo,ResDate,Guest,ResType,Topcode,IsTopcontract,TopContractId,ArrDate,DepDate,ArrFlight,DepFlight,convert(char(5), ArrTime, 108) [ArrTime],convert(char(5), DepTime, 108) [DepTime],ArrTrans,DepTrans,PaxId,AdultQty,ChildrenQty,InfantsQty,MealPlan,Rate,DisPlanId,OfferId,AmenId,Total,PayMode,PayExpiryDate,PayCCNo,Guestlikes,Guestdislikes,BillingInst,Remarks,Refno,Status,IsProformaCreated,ProfomaInvoiceno,EnteredBy,EnteredDate,InactivatedBy,InactivatedDate,ArrTransTime,DepTransTime from dbo.[Reservation.Master] where ResNo=@ResNo and Status='OPEN'", Conn)


            dcSearch.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = getResno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)


            If dsMain.Tables(0).Rows.Count > 0 Then

                gcResdetails.DataSource = dsMain.Tables(0)

                txtExMP.Text = dsMain.Tables(0).Rows(0)(19).ToString

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try


    End Sub


    Private Sub LabelControl3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl3.Click

    End Sub

    Private Sub btUnblock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUnblock.Click
        LoadResDetails()
    End Sub

    Private Sub btUpdateMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpdateMP.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "MP Change", "Add")

        If CheckAccess = True Then




            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Update This Meal Plan Details", "Update Meal Plan Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    UpdateMealPlanDetails()
                    ClearFields()

                End If
               

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "INFO Exception")

            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub


    Private Sub UpdateMealPlanDetails()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()


        dcInsertNewAcc = New SqlCommand("UpdateRESMealPlan_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure

        dcInsertNewAcc.Parameters.Add("@OldMP", SqlDbType.VarChar).Value = txtExMP.Text.Trim
        dcInsertNewAcc.Parameters.Add("@NewMP", SqlDbType.VarChar).Value = cmbMealplan.Text.Trim
        dcInsertNewAcc.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = txtReservationno.Text.Trim
        dcInsertNewAcc.Parameters.Add("@UpdateBy", SqlDbType.VarChar).Value = CurrUser


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Meal Plan Details Updated Successfully", "Update Meal Plan Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub
    Sub ClearFields()

        txtReservationno.Text = "RES"
      

        gcResdetails.DataSource = Nothing
       
        txtExMP.Text = ""


    End Sub

    
End Class