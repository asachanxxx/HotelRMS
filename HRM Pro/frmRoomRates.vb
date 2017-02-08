Imports System.Data.SqlClient

Public Class frmRoomRates
    Public PubRatesId As String = ""

    Private Sub frmRoomRates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()


        LoadGrid()
        LoadMealPalns()
    End Sub
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select Custype,ValidSDate,ValidEDate,Roomtype,Countype,Packagetype,Rate,RatesId from  dbo.[Rooms.Rates] where Status='OPEN'and Custype !='TOP' order by Custype,status", Conn)


            ' sql command to adapter conversion and get the details to dataset.
            ' keep in mind, This DevXpress grid only takes tables and dataset 
            ' so if u want to present any details in grid,u must take the details from multiple tables or view or whatever to dataset or single table.


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcRoomRates.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

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
    Private Sub InsertRoomRates()


        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InsertRoomRate_SP", Conn) With {.CommandType = CommandType.StoredProcedure}


        Dim getCusType As String = ""
        Dim getCusId As String = ""

        If cmbGuesttype.Text = "FIT" Then
            getCusType = "FIT"
            getCusId = "FIT Customer"
        End If


        If cmbGuesttype.Text = "COMPLEMENTARY" Then
            getCusType = "COM"
            getCusId = "COM Customer"
        End If

        If cmbGuesttype.Text = "TOP NON CONTRACTS" Then
            getCusType = "TOPNONCONTRACT"
            getCusId = "TOP Customer"
        End If
       

        Dim Ratesautoid As String = System.Guid.NewGuid().ToString()

        dcInsertNewAcc.Parameters.Add("@RatesId", SqlDbType.VarChar).Value = Ratesautoid
        dcInsertNewAcc.Parameters.Add("@Custype", SqlDbType.VarChar).Value = getCusType
        dcInsertNewAcc.Parameters.Add("@Cusid", SqlDbType.VarChar).Value = getCusId
        dcInsertNewAcc.Parameters.Add("@RatesTopContractId", SqlDbType.VarChar).Value = ""
        dcInsertNewAcc.Parameters.Add("@Topcontractid", SqlDbType.VarChar).Value = ""
        dcInsertNewAcc.Parameters.Add("@Roomtype", SqlDbType.VarChar).Value = cmbRoom.Text.Trim
        dcInsertNewAcc.Parameters.Add("@ValidSDate", SqlDbType.DateTime).Value = CDate(dtsubsdate.Text)
        dcInsertNewAcc.Parameters.Add("@ValidEDate", SqlDbType.DateTime).Value = CDate(dtsubedate.Text)
        dcInsertNewAcc.Parameters.Add("@Packagetype", SqlDbType.VarChar).Value = cmbMealplan.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Countype", SqlDbType.VarChar).Value = cmbRoomtyp.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.Decimal).Value = CDec(txtrate.Text.Trim)
        dcInsertNewAcc.Parameters.Add("@Allocatedrooms", SqlDbType.Int).Value = 0
        dcInsertNewAcc.Parameters.Add("@Releasedate ", SqlDbType.Int).Value = 0
        dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = "rashad"

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Room Rate Details Saved Successfully", "Save Room Rates", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Conn.Close()

    End Sub
    Function DSCheckInsertRoomRates() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim getcustype As String = cmbGuesttype.Text.Trim
            Dim getValidSDate As DateTime = CDate(dtsubsdate.Text).Date
            Dim getValidEDate As DateTime = CDate(dtsubedate.Text).Date
            Dim getRoom As String = cmbRoom.Text.Trim
            Dim getRoomType As String = cmbRoomtyp.Text.Trim
            Dim getPackage As String = cmbMealplan.Text.Trim

            dcSearch = New SqlCommand("select * from  dbo.[Rooms.Rates] where Status='OPEN' and Custype=@getcustype and ValidSDate=DATEADD(dd, 0, DATEDIFF(dd, 0, @getValidSDate)) and ValidEDate=DATEADD(dd, 0, DATEDIFF(dd, 0, @getValidEDate)) and Roomtype=@getRoom and Countype=@getRoomType and Packagetype=@getPackage", Conn)
            dcSearch.Parameters.Add("@getcustype", SqlDbType.VarChar).Value = getcustype
            dcSearch.Parameters.Add("@getValidSDate", SqlDbType.DateTime).Value = getValidSDate
            dcSearch.Parameters.Add("@getValidEDate", SqlDbType.DateTime).Value = getValidEDate
            dcSearch.Parameters.Add("@getRoom", SqlDbType.VarChar).Value = getRoom
            dcSearch.Parameters.Add("@getRoomType", SqlDbType.VarChar).Value = getRoomType
            dcSearch.Parameters.Add("@getPackage", SqlDbType.VarChar).Value = getPackage


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertRoomRates = dsMain
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            Return Nothing
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Function
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "RoomRates", "Add")

        If CheckAccess = True Then


            If String.Compare(btnAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btnAdd.Text = "Save"
                btnEdit.Enabled = False
                btnInactive.Enabled = False
                tabRoomrates.SelectedTabPageIndex = 1

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)

                    Exit Sub

                Else

                    Try

                        Dim dscheckAddbefore As New DataSet
                        dscheckAddbefore = DSCheckInsertRoomRates()

                        If dscheckAddbefore Is Nothing Then

                            Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Room Rate Details", "Save Room Rates", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If bt = Windows.Forms.DialogResult.Yes Then

                                InsertRoomRates()


                            End If
                            LoadGrid()

                            btnAdd.Text = "Add"
                            btnEdit.Enabled = True
                            btnInactive.Enabled = True
                            tabRoomrates.SelectedTabPageIndex = 0
                            Exit Sub

                        Else
                            MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
                    End Try
                End If
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Sub ClearFields()

        cmbGuesttype.SelectedIndex = 0
        cmbRoom.SelectedIndex = 0
        cmbRoomtyp.SelectedIndex = 0
        cmbMealplan.SelectedIndex = 0
        txtrate.Text = ""

        dtsubsdate.Text = DateTime.Now.Date
        dtsubedate.Text = DateTime.Now.Date


    End Sub

    Private Sub txtrate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrate.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.btnAdd.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub btnInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInactive.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "RoomRates", "Delete")

        If CheckAccess = True Then


            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Delete This Room Rate", "Delete Room Rate", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveRoomRates()


                End If
                LoadGrid()
                tabRoomrates.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try

        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub
    Private Sub InactiveRoomRates()

        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        dcInsertNewAcc = New SqlCommand("InactiveRoomRates_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@RatesId", SqlDbType.VarChar).Value = PubRatesId
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Room Rate Deleted Successfully", "Delete Room Rate", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Conn.Close()
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "RoomRates", "Edit")

        If CheckAccess = True Then



            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Update Room Rates", "Update Room Rates", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    UpdateRoomRates()


                End If
                LoadGrid()
                tabRoomrates.SelectedTabPageIndex = 0
                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub
    Private Sub UpdateRoomRates()

        Try


            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand


            dcInsertNewAcc = New SqlCommand("UpdateRoomRates_SP", Conn)
            dcInsertNewAcc.CommandType = CommandType.StoredProcedure

            dcInsertNewAcc.Parameters.Add("@RatesId", SqlDbType.VarChar).Value = PubRatesId
            dcInsertNewAcc.Parameters.Add("@Custype", SqlDbType.VarChar).Value = cmbGuesttype.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Room", SqlDbType.VarChar).Value = cmbRoom.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Countype", SqlDbType.VarChar).Value = cmbRoomtyp.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Packagetype", SqlDbType.VarChar).Value = cmbMealplan.Text.Trim

            dcInsertNewAcc.Parameters.Add("@ValidSDate", SqlDbType.DateTime).Value = dtsubsdate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@ValidEDate", SqlDbType.DateTime).Value = dtsubedate.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.Decimal).Value = Convert.ToDecimal(txtrate.Text.Trim)
            

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            MessageBox.Show("Room Rates Updated Successfully", "Update Room Rate Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub
    Private Sub ShowGridDets()
        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try
            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select * from dbo.[Rooms.Rates]  where Status='OPEN' and RatesId= '{0}' ", gviewRoomrate.GetRowCellValue(gviewRoomrate.FocusedRowHandle, "RatesId")), Conn)
            daShow.Fill(dsShow)


            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            tabRoomrates.SelectedTabPageIndex = 1

            PubRatesId = dsShow.Tables(0).Rows(0).Item("RatesId")
            cmbGuesttype.Text = dsShow.Tables(0).Rows(0).Item("Custype")
            cmbGuesttype.ClosePopup()
            cmbRoom.Text = dsShow.Tables(0).Rows(0).Item("Roomtype")
            cmbRoom.ClosePopup()
            cmbRoomtyp.Text = dsShow.Tables(0).Rows(0).Item("Countype")
            cmbRoomtyp.ClosePopup()
            cmbMealplan.Text = dsShow.Tables(0).Rows(0).Item("Packagetype")
            cmbMealplan.ClosePopup()


            dtsubsdate.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("ValidSDate"))
            dtsubedate.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("ValidEDate"))

            txtrate.Text = Convert.ToDecimal(dsShow.Tables(0).Rows(0).Item("Rate"))
           
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daShow.Dispose()
            dsShow.Dispose()
        End Try
    End Sub
    Private Sub gviewRoomrate_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gviewRoomrate.DoubleClick
        ShowGridDets()
    End Sub
    Function FieldValidation() As Boolean

        Return IIf(String.Compare(txtrate.Text, "", False) = 0 Or String.Compare(cmbGuesttype.Text, "", False) = 0 Or String.Compare(cmbRoomtyp.Text, "", False) = 0 Or String.Compare(cmbMealplan.Text, "", False) = 0 Or String.Compare(cmbRoom.Text, "", False) = 0, 0, 1)

    End Function

    Private Sub frmRoomRates_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class