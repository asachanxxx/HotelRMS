Imports System.Data.SqlClient
Imports System.Xml
Imports System.Text.RegularExpressions
Public Class frmChangeBillsRooms

    Private Sub frmChangeBillsRooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        LoadRoomNo()


    End Sub
    Private Sub LoadRoomNo()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            '   dcSearch = New SqlCommand("select Roomno from [Rooms.Master] order by Roomno", Conn)
            dcSearch = New SqlCommand("select [RoomNo] from [Room.CurrentStatus] order by [RoomNo]", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            DscountTest = 0
            While (DscountTest < Dscount)
                cmbroomno.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While

            DscountTest = 0
            While (DscountTest < Dscount)
                cmbroomno2.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While

            cmbroomno.SelectedIndex = 0
            cmbroomno2.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadPaid(ByVal RoomNo As String)
        Dim Conn As New SqlConnection(ConnString)


        Dim dsUnPaid As New DataSet

        Dim daApid As New SqlDataAdapter
        Dim daUnpid As New SqlDataAdapter

        Dim dcPaid As New SqlCommand
        Dim dcUnPaid As New SqlCommand
        Dim unPaidAmount As Double
        Dim serviceCharge As Double
        Dim totalUnPaidAmount As Double
        Dim totalUnPaidServiceChargeAmount As Double
        Dim paidAmount As Double
        Dim totalPaidAmount As Double
        Try
          
            Conn.Open()
          

            dcUnPaid = New SqlCommand("SELECT distinct '' as t, o.[BillNo]  as 'Bill No' ,o.[KOTBOTNo] ,o.[MasterBillGenerated],o.[MasterBillNo] ,o.[Paid] ,o.[ReciptNo] as Receipt ,(o.[Total]-o.discountAmount) as 'Amount',o.[RoomNo],o.[ReservationNo] ,o.[Type],'guest' as guest,'sum' as 'sum','' as balance,'' as grandTot,isnull(p.[Description],'') as 'PayType',  o.BillGeneratedDate, d.Department,''as 'GrandTotaloftheInvoices'  ,'' as 'ServiceCharge',''as 'Total',''as 'GSTTax'   ,''as 'GrandTotal' ,''as 'Discountgiven','' as Discount ,''as 'AdvancePaid',''as 'NetAmounttobesettled' , g.DepDate,g.ArriveDate,'' opdetail,'' department1,'' departmenttot ,o.OutletMasBill as OutMasNo  FROM [OutLetBillMaster] o inner join dbo.KotBotMaster k on k.Id=o.KOTBOTNo inner join  dbo.GuestRegistration g  on g.ReservationNo =o.ReservationNo  inner join dbo.DepartmentMaster d on k.Department =d.DepartmentID Collate SQL_Latin1_General_CP1_CI_AS  inner join dbo.[Room.CurrentStatus] c on  c.ReservationNo = o.ReservationNo left join [PaymentType] P on P.[PaymentTypeCode]=[PayType] where  o.[Paid]=0 and   o.[MasterBillGenerated]=0 and g.IsBillingGuest =1 and o.[RoomNo] ='" & RoomNo & "' and o.ReservationNo = (select  ReservationNo from dbo.[Room.CurrentStatus] where RoomNo='" & RoomNo & "')", Conn)


            daUnpid = New SqlDataAdapter()
            daUnpid.SelectCommand = dcUnPaid
            daUnpid.Fill(dsUnPaid)
            If (Not dsUnPaid Is Nothing) Then
                GridControUnPaidBill.DataSource = dsUnPaid.Tables(0)
                Dim I As Integer
                For I = 0 To dsUnPaid.Tables(0).Rows.Count - 1
                    unPaidAmount = Double.Parse(dsUnPaid.Tables(0).Rows(I)("Amount").ToString())
                    dsUnPaid.Tables(0).Rows(I)("guest") = TextEditGuest.Text
                    totalUnPaidAmount = totalUnPaidAmount + unPaidAmount


                    If (Not dsUnPaid.Tables(0).Rows(I)("Department").ToString().ToLower() = "divingschool") Then
                        If (Not dsUnPaid.Tables(0).Rows(I)("Department").ToString().ToLower() = "mishrapshop") Then
                            serviceCharge = Double.Parse(dsUnPaid.Tables(0).Rows(I)("Amount").ToString())
                            totalUnPaidServiceChargeAmount = totalUnPaidServiceChargeAmount + serviceCharge
                        End If
                    End If
                Next
                '  TextEditUnPaid.Text = totalUnPaidAmount.ToString()
                dsUnPaid.Tables(0).TableName = "dsUnPaid"
            End If
            Conn.Close()

            'serviceCharge = totalUnPaidServiceChargeAmount * 0.1
            'TextEditServiceCharges.Text = FormatNumber(serviceCharge, 2)

            'Dim balance As Double = totalUnPaidAmount - totalPaidAmount
            'If ((balance) > 0) Then
            '    TextEditTotal.Text = balance.ToString()
            '    btnCreateBilling.Enabled = False
            '    If (balance > 0) Then
            '        btnCreateBilling.Enabled = False
            '    End If

            '    If (balance = 0) Then
            '        btnCreateBilling.Enabled = True
            '    End If
            'Else
            '    TextEditTotal.Text = "0"
            '    'Rashad Added
            '    btnCreateBilling.Enabled = True
            'End If
            'btnCreateBilling.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daApid.Dispose()
            daUnpid.Dispose()
        End Try
    End Sub
    Private Sub loadmasterBillData()
        TextEditGuest.Text = ""
        LoadUserData(cmbroomno.Text)
        If (String.IsNullOrEmpty(TextEditGuest.Text.Trim())) Then
            MsgBox("Master guest for this room is not define", MsgBoxStyle.Critical, "Error..")
        Else
            LoadPaid(cmbroomno.Text)
        End If
    End Sub
    Private Sub LoadUserData(ByVal RoomNo As String)
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsGuest As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            'dcSearch = New SqlCommand("select c.ReservationNo,c.BillingGuest as 'GuestName' from [Guest.RegisterMaster] R inner join [Room.CurrentStatus] c on c.ReservationNo=R.ReservationNo where R.IsMasterRecord=1 and c.RoomNo='" & RoomNo & "'", Conn)
            dcSearch = New SqlCommand("select c.ReservationNo,c.BillingGuest as 'GuestName' from [GuestRegistration] R inner join [Room.CurrentStatus] c on c.ReservationNo=R.ReservationNo where R.IsBillingGuest=1 and c.RoomNo='" & RoomNo & "'", Conn)
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsGuest)
            If (Not dsGuest Is Nothing) Then
                If (dsGuest.Tables(0).Rows.Count > 0) Then
                    If (IsDBNull(dsGuest.Tables(0).Rows(0)("GuestName"))) Then
                        TextEditGuest.Text = ""
                    Else
                        TextEditGuest.Text = dsGuest.Tables(0).Rows(0)("GuestName")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
        End Try
    End Sub
    Private Sub LoadUserData2(ByVal RoomNo As String)
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsGuest As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            'dcSearch = New SqlCommand("select c.ReservationNo,c.BillingGuest as 'GuestName' from [Guest.RegisterMaster] R inner join [Room.CurrentStatus] c on c.ReservationNo=R.ReservationNo where R.IsMasterRecord=1 and c.RoomNo='" & RoomNo & "'", Conn)
            dcSearch = New SqlCommand("select c.ReservationNo,c.BillingGuest as 'GuestName' from [GuestRegistration] R inner join [Room.CurrentStatus] c on c.ReservationNo=R.ReservationNo where R.IsBillingGuest=1 and c.RoomNo='" & RoomNo & "'", Conn)
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsGuest)
            If (Not dsGuest Is Nothing) Then
                If (dsGuest.Tables(0).Rows.Count > 0) Then
                    If (IsDBNull(dsGuest.Tables(0).Rows(0)("GuestName"))) Then
                        txtguest2.Text = ""
                    Else
                        txtguest2.Text = dsGuest.Tables(0).Rows(0)("GuestName")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
        End Try
    End Sub

    Private Sub cmbroomno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbroomno.SelectedIndexChanged
        loadmasterBillData()
    End Sub

    Private Sub BillGview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillGview.Click

        txtbillno.Text = BillGview.GetRowCellValue(BillGview.FocusedRowHandle, "Bill No")
        txtbillamt.Text = Convert.ToDecimal(BillGview.GetRowCellValue(BillGview.FocusedRowHandle, "Amount"))
        txtDep.Text = BillGview.GetRowCellValue(BillGview.FocusedRowHandle, "Department")

    End Sub

    Private Sub LabelControl6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl6.Click

    End Sub

    Private Sub cmbroomno2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbroomno2.SelectedIndexChanged
        txtguest2.Text = ""
        LoadUserData2(cmbroomno2.Text)
        If (String.IsNullOrEmpty(txtguest2.Text.Trim())) Then
            MsgBox("Master guest for this room is not define", MsgBoxStyle.Critical, "Error..")
        End If
    End Sub

    Private Sub btBillchange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBillchange.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "RoomBill Change", "Add")

        If CheckAccess = True Then


            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Change the Bill no : " + txtbillno.Text + " to Room No : " + cmbroomno2.Text + "", "Reverce Bill", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If bt = Windows.Forms.DialogResult.Yes Then

                    If FieldValidation() = False Then

                        MsgBox("Please select a Bill to transfer", MsgBoxStyle.Critical, ErrTitle)
                        Exit Sub

                    Else

                        If cmbroomno.Text = cmbroomno2.Text Then
                            MsgBox("You are not allowed to Transfer Bill to the Same Room", MsgBoxStyle.Critical, ErrTitle)
                            Exit Sub

                        Else

                            ChangeRoomBill()
                            Clearfields()

                        End If
                    End If
                End If



            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Private Sub ChangeRoomBill()

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand


            dcInsertNewAcc = New SqlCommand("InsertRoomBillChange_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@Billno", SqlDbType.VarChar).Value = txtbillno.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Roomno", SqlDbType.VarChar).Value = cmbroomno.Text.Trim
            dcInsertNewAcc.Parameters.Add("@NewRoomno", SqlDbType.VarChar).Value = cmbroomno2.Text.Trim
            dcInsertNewAcc.Parameters.Add("@ChangeBy", SqlDbType.VarChar).Value = CurrUser



            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Bill No : " + txtbillno.Text.Trim + " Successfully Transfered To Room No : " + cmbroomno2.Text.Trim + ".", "Bill Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try
    End Sub

    Private Sub Clearfields()

        cmbroomno.SelectedIndex = 0
        cmbroomno2.SelectedIndex = 0

        GridControUnPaidBill.DataSource = Nothing

        txtbillno.Text = ""
        txtbillamt.Text = ""
        txtDep.Text = ""
    End Sub
    Function FieldValidation() As Boolean
        Return IIf(String.Compare(txtbillno.Text, "", False) = 0 Or String.Compare(txtbillamt.Text, "", False) = 0 Or String.Compare(txtDep.Text, "", False) = 0 Or String.Compare(cmbroomno2.Text, "", False) = 0 Or String.Compare(txtguest2.Text, "", False) = 0, 0, 1)
    End Function

End Class