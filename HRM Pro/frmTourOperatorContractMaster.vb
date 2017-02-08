Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
Public Class frmTourOperatorContractMaster

    Public ReportName As String
    Public rptTitle As String
    Public SF As String = ""
    Public PubIsEdit As Integer = 0
    Public PubTempIdSTD As Integer = 0
    Public PubTempIdSD As Integer = 0
    Public PubTempIdSUP As Integer = 0
    Public PubTempIdMas As Integer = 0
    Private Sub frmTourOperatorContractMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        LoadTopcodes()

        dtCon.Text = Now.Date
        dtConStart.Text = Now.Date
        'dtConStart.Text = DateAdd(DateInterval.Day, -1, Now.Date)
        dtConEnd.Text = Now.Date
        'dtsubsdate.Text = DateAdd(DateInterval.Day, -1, Now.Date)
        dtsubedate.Text = Now.Date
        dtsubsdate.Text = Now.Date
        cmbroomtype.SelectedIndex = 0
        cmbcountype.SelectedIndex = 0
        cmbpacktype.SelectedIndex = 0
        Cbguestype.SelectedIndex = 0
        CbShift.SelectedIndex = 0

        cbTopcode.SelectedIndex = 0

        ' txtContactno.Text = GetItemCode()

        LoadTopContracts()

        LoadMealPalns()

        tabTopContarcts.TabPages(1).PageEnabled = False


    End Sub

    Function GetItemCode() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutono", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "Contracts"
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output


            'drGetDets = dcGetCode.ExecuteReader
            dcGetCode.ExecuteNonQuery()


            'If drGetDets.Read Then
            GetItemCode = dcGetCode.Parameters("@Currcode").Value
            'Else
            'GetSupplierCode = ""
            'End If


            'If Not IsDBNull(dsGetDets.Tables(0).Rows(0).Item(0)) Then
            '    GetSupplierCode = dsGetDets.Tables(0).Rows(0).Item(0).ToString
            'Else
            '    GetSupplierCode = ""
            'End If

            Return GetItemCode
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()
            ' drGetDets.Close()

        End Try

    End Function
    Private Sub LoadTopcodes()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select TopCode from [Touroperator.Master] order by TopCode", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

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
    Private Sub LoadTopContracts()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select TopId ,Contractno,SignDate,SDate as StartDate,EDate as EndDate from [dbo].[Touroperator.Contracts] where Iscurrent='1' and Isinactive='0' order by TopId", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count

            If Dscount > 0 Then
                gcTopAgreements.DataSource = dsMain.Tables(0)

            Else

                MessageBox.Show("No Contract Details", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
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
    Private Sub cbTopcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTopcode.SelectedIndexChanged
        LoadTopName(cbTopcode.Text)
    End Sub
    Private Sub dtConStart_DateTimeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtConStart.DateTimeChanged
    
    End Sub
    Private Sub dtConEnd_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtConEnd.EditValueChanged

        If btMAdd.Text = "" Then
            Exit Sub
        End If


        If (dtConStart.DateTime.Date > dtConEnd.DateTime.Date) Then
            MessageBox.Show("Contract End Date Should Be Greater Than Start Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End If

        If (dtConStart.DateTime.Date < dtConEnd.DateTime.Date) Then
            gbRoomRates.Enabled = True
        End If
    End Sub

    Private Sub dtsubsdate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtsubsdate.EditValueChanged

        If btMAdd.Text = "" Then
            Exit Sub
        End If

        If (dtConStart.DateTime.Date > dtsubsdate.DateTime.Date) Then
            MessageBox.Show("Contract Sub Date Should Be Greater Than Start Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End If


    End Sub
    Private Sub dtsubedate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtsubedate.EditValueChanged
        If btMAdd.Text = "" Then
            Exit Sub
        End If

        If (dtsubsdate.DateTime.Date > dtConStart.DateTime.Date) And (dtsubedate.DateTime.Date > dtConEnd.DateTime.Date) Then
            MessageBox.Show("Contract Sub Date Should Be With in the Contract Period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End If
    End Sub
    Private Sub txtrate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrate.KeyPress

        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtAllocatedrooms.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If


    End Sub
    Private Sub txtAllocatedrooms_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAllocatedrooms.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub txtreleasedate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtreleasedate.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub btAddroomtemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddroomtemp.Click


        If FieldValidationRoom() = False Then
            MsgBox("Compulsary fields must be filled", MsgBoxStyle.Critical, ErrTitle)
            Exit Sub
        Else


            Dim dscheckAddbefore As New DataSet
            dscheckAddbefore = DSCheckAddRoomTemp()

            If dscheckAddbefore Is Nothing Then
                InsertRoomRatesTemp()

            Else
                MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
            LoadRoomRatesTempStd()
            LoadRoomRatesTempDelux()
            LoadRoomRatesTempSup()
        End If

        txtrate.Text = ""
        txtAllocatedrooms.Text = "0"
        txtreleasedate.Text = "0"


    End Sub
    Private Sub LoadRoomRatesTempStd()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim contractno As String = txtContactno.Text.Trim

            dcSearch = New SqlCommand("select ValidSDate,ValidEDate,Countype,Rate,Tempid from dbo.[Rooms.Rates.Temp]  where  Contactno=@contractno and Roomtype='Standard' order by ValidSDate,Countype desc", Conn)
            dcSearch.Parameters.Add("@contractno", SqlDbType.NVarChar).Value = contractno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            gcRoomStand.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadRoomRatesTempSup()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim contractno As String = txtContactno.Text.Trim

            dcSearch = New SqlCommand("select ValidSDate,ValidEDate,Countype,Rate,Tempid from dbo.[Rooms.Rates.Temp]  where  Contactno=@contractno and Roomtype='Superior' order by ValidSDate,Countype desc", Conn)
            dcSearch.Parameters.Add("@contractno", SqlDbType.NVarChar).Value = contractno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            gcRoomSup.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadRoomRatesTempDelux()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim contractno As String = txtContactno.Text.Trim


            dcSearch = New SqlCommand("select ValidSDate,ValidEDate,Countype,Rate,Tempid from dbo.[Rooms.Rates.Temp]  where  Contactno=@contractno and Roomtype='Deluxe' order by ValidSDate,Countype desc", Conn)
            dcSearch.Parameters.Add("@contractno", SqlDbType.NVarChar).Value = contractno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            gcRoomSd.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub CheckAddRoomTemp()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim contractno As String = txtContactno.Text.Trim
            Dim ValidSDate As DateTime = dtsubsdate.DateTime.Date
            Dim ValidEDate As DateTime = dtsubedate.DateTime.Date
            Dim Countype As String = cmbcountype.Text.Trim
            Dim Packagetype As String = cmbpacktype.Text.Trim
            Dim Cusid As String = cbTopcode.Text.Trim
            Dim Roomtype As String = cmbroomtype.Text.Trim

            dcSearch = New SqlCommand("select * from dbo.[Rooms.Rates.Temp] where ValidSDate=@ValidSDate and ValidEDate=@ValidEDate and Countype=@Countype and Packagetype=@Packagetype and Contactno=@contractno and Cusid=@Cusid and Roomtype=@Roomtype", Conn)
            dcSearch.Parameters.Add("@contractno", SqlDbType.VarChar).Value = contractno
            dcSearch.Parameters.Add("@ValidSDate", SqlDbType.DateTime).Value = ValidSDate
            dcSearch.Parameters.Add("@ValidEDate", SqlDbType.DateTime).Value = ValidEDate
            dcSearch.Parameters.Add("@Countype", SqlDbType.VarChar).Value = Countype
            dcSearch.Parameters.Add("@Packagetype", SqlDbType.VarChar).Value = Packagetype
            dcSearch.Parameters.Add("@Cusid", SqlDbType.VarChar).Value = Cusid
            dcSearch.Parameters.Add("@Roomtype", SqlDbType.VarChar).Value = Roomtype


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim dsMainCount = dsMain.Tables(0).Rows.Count

            If (dsMainCount > 0) Then
                MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Function DSCheckAddRoomTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim contractno As String = txtContactno.Text.Trim
            Dim ValidSDate As DateTime = dtsubsdate.DateTime.Date
            Dim ValidEDate As DateTime = dtsubedate.DateTime.Date
            Dim Countype As String = cmbcountype.Text.Trim
            Dim Packagetype As String = cmbpacktype.Text.Trim
            Dim Cusid As String = cbTopcode.Text.Trim
            Dim Roomtype As String = cmbroomtype.Text.Trim

            dcSearch = New SqlCommand("select * from dbo.[Rooms.Rates.Temp] where ValidSDate=@ValidSDate and ValidEDate=@ValidEDate and Countype=@Countype and Packagetype=@Packagetype and Contactno=@contractno and Cusid=@Cusid and Roomtype=@Roomtype", Conn)
            dcSearch.Parameters.Add("@contractno", SqlDbType.VarChar).Value = contractno
            dcSearch.Parameters.Add("@ValidSDate", SqlDbType.DateTime).Value = ValidSDate
            dcSearch.Parameters.Add("@ValidEDate", SqlDbType.DateTime).Value = ValidEDate
            dcSearch.Parameters.Add("@Countype", SqlDbType.VarChar).Value = Countype
            dcSearch.Parameters.Add("@Packagetype", SqlDbType.VarChar).Value = Packagetype
            dcSearch.Parameters.Add("@Cusid", SqlDbType.VarChar).Value = Cusid
            dcSearch.Parameters.Add("@Roomtype", SqlDbType.VarChar).Value = Roomtype


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckAddRoomTemp = dsMain
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
    Private Sub InsertRoomRatesTemp()


        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()

        dcInsertNewAcc = New SqlCommand("InsertRoomRateTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

        dcInsertNewAcc.Parameters.Add("@Contactno", SqlDbType.VarChar).Value = txtContactno.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Cusid", SqlDbType.VarChar).Value = cbTopcode.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Roomtype", SqlDbType.VarChar).Value = cmbroomtype.Text.Trim
        dcInsertNewAcc.Parameters.Add("@ValidSDate", SqlDbType.DateTime).Value = dtsubsdate.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@ValidEDate", SqlDbType.DateTime).Value = dtsubedate.DateTime.Date
        dcInsertNewAcc.Parameters.Add("@Packagetype", SqlDbType.VarChar).Value = cmbpacktype.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Countype", SqlDbType.VarChar).Value = cmbcountype.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.Decimal).Value = CDec(txtrate.Text.Trim)
        dcInsertNewAcc.Parameters.Add("@Allocatedrooms", SqlDbType.Int).Value = Convert.ToInt32(txtAllocatedrooms.Text)
        dcInsertNewAcc.Parameters.Add("@Releasedate ", SqlDbType.Int).Value = Convert.ToInt32(txtreleasedate.Text)

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub
    Private Sub InsertRoomRates(ByVal PubRatesTopContractId As String, ByVal PubContractno As String)


        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand


        Dim RatesTopContractId As String = PubRatesTopContractId

        Dim Contractno As String = PubContractno

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        dcSearch = New SqlCommand("select Cusid,Roomtype,ValidSDate,ValidEDate,Packagetype,Countype,Rate,Allocatedrooms,Releasedate from dbo.[Rooms.Rates.Temp] where Contactno=@contractno", Conn)
        dcSearch.Parameters.Add("@contractno", SqlDbType.VarChar).Value = Contractno
        Conn.Open()
        daMain = New SqlDataAdapter()
        daMain.SelectCommand = dcSearch
        daMain.Fill(dsMain)
        Conn.Close()

        Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1



        While DScount >= 0

            dcInsertNewAcc = New SqlCommand("InsertRoomRate_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            Dim Ratesautoid As String = System.Guid.NewGuid().ToString()

            Dim CurrentUser As String = CurrUser

            dcInsertNewAcc.Parameters.Add("@RatesId", SqlDbType.VarChar).Value = Ratesautoid
            dcInsertNewAcc.Parameters.Add("@Custype", SqlDbType.VarChar).Value = "TOP"
            dcInsertNewAcc.Parameters.Add("@Cusid", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(0).ToString()
            dcInsertNewAcc.Parameters.Add("@RatesTopContractId", SqlDbType.VarChar).Value = RatesTopContractId
            dcInsertNewAcc.Parameters.Add("@Topcontractid", SqlDbType.VarChar).Value = txtContactno.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Roomtype", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(1).ToString()
            dcInsertNewAcc.Parameters.Add("@ValidSDate", SqlDbType.DateTime).Value = CDate(dsMain.Tables(0).Rows(DScount)(2).ToString())
            dcInsertNewAcc.Parameters.Add("@ValidEDate", SqlDbType.DateTime).Value = CDate(dsMain.Tables(0).Rows(DScount)(3).ToString())
            dcInsertNewAcc.Parameters.Add("@Packagetype", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(4).ToString()
            dcInsertNewAcc.Parameters.Add("@Countype", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(5).ToString()
            dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.Decimal).Value = CDec(dsMain.Tables(0).Rows(DScount)(6).ToString())
            dcInsertNewAcc.Parameters.Add("@Allocatedrooms", SqlDbType.Int).Value = Convert.ToInt32(dsMain.Tables(0).Rows(DScount)(7).ToString())
            dcInsertNewAcc.Parameters.Add("@Releasedate ", SqlDbType.Int).Value = Convert.ToInt32(dsMain.Tables(0).Rows(DScount)(8).ToString())
            dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()
            DScount = DScount - 1
        End While
    End Sub
    Private Sub InsertRoomRatesTempToOriginal(ByVal PubContractno As String)


        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim Contractno As String = PubContractno

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        dcSearch = New SqlCommand("select Cusid,Roomtype,ValidSDate,ValidEDate,Packagetype,Countype,Rate,Allocatedrooms,Releasedate from dbo.[Rooms.Rates] where Topcontractid=@contractno", Conn)
        dcSearch.Parameters.Add("@contractno", SqlDbType.VarChar).Value = Contractno
        Conn.Open()
        daMain = New SqlDataAdapter()
        daMain.SelectCommand = dcSearch
        daMain.Fill(dsMain)
        Conn.Close()

        Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1

        While DScount >= 0

            dcInsertNewAcc = New SqlCommand("InsertRoomRateTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcInsertNewAcc.Parameters.Add("@Contactno", SqlDbType.VarChar).Value = Contractno
            dcInsertNewAcc.Parameters.Add("@Cusid", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(0).ToString()
            dcInsertNewAcc.Parameters.Add("@Roomtype", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(1).ToString()
            dcInsertNewAcc.Parameters.Add("@ValidSDate", SqlDbType.DateTime).Value = Convert.ToDateTime(dsMain.Tables(0).Rows(DScount)(2).ToString())
            dcInsertNewAcc.Parameters.Add("@ValidEDate", SqlDbType.DateTime).Value = Convert.ToDateTime(dsMain.Tables(0).Rows(DScount)(3).ToString())
            dcInsertNewAcc.Parameters.Add("@Packagetype", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(4).ToString()
            dcInsertNewAcc.Parameters.Add("@Countype", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(5).ToString()
            dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.Decimal).Value = CDec(dsMain.Tables(0).Rows(DScount)(6).ToString())
            dcInsertNewAcc.Parameters.Add("@Allocatedrooms", SqlDbType.Int).Value = Convert.ToInt32(dsMain.Tables(0).Rows(DScount)(7).ToString())
            dcInsertNewAcc.Parameters.Add("@Releasedate ", SqlDbType.Int).Value = Convert.ToInt32(dsMain.Tables(0).Rows(DScount)(8).ToString())

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()
            DScount = DScount - 1
        End While
    End Sub
    Private Sub InsertTransRatesTemp()


        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        dcInsertNewAcc = New SqlCommand("InsertTransRateTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

        dcInsertNewAcc.Parameters.Add("@Contactno", SqlDbType.VarChar).Value = txtContactno.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Cusid", SqlDbType.VarChar).Value = cbTopcode.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Guesttype", SqlDbType.VarChar).Value = Cbguestype.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Shift", SqlDbType.VarChar).Value = CbShift.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.Decimal).Value = CDec(txtTransrate.Text.Trim)

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Private Sub InsertTransRates(ByVal PubTransTopContractId As String, ByVal PubContractno As String)


        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Dim Contractno As String = PubContractno
        Dim TransTopContractId As String = PubTransTopContractId



        dcSearch = New SqlCommand("select * from dbo.[Boat.Transferrates.Temp] where Contactno=@contractno", Conn)
        dcSearch.Parameters.Add("@contractno", SqlDbType.VarChar).Value = Contractno
        Conn.Open()
        daMain = New SqlDataAdapter()
        daMain.SelectCommand = dcSearch
        daMain.Fill(dsMain)
        Conn.Close()

        Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1


        While DScount >= 0

            Dim autoid As String = System.Guid.NewGuid().ToString()
            dcInsertNewAcc = New SqlCommand("InsertTransRate_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcInsertNewAcc.Parameters.Add("@TransferrateId", SqlDbType.VarChar).Value = autoid
            dcInsertNewAcc.Parameters.Add("@Custype", SqlDbType.VarChar).Value = "TOP"
            dcInsertNewAcc.Parameters.Add("@CusId", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(2).ToString()
            dcInsertNewAcc.Parameters.Add("@TransTopContracid", SqlDbType.VarChar).Value = TransTopContractId
            dcInsertNewAcc.Parameters.Add("@TopcontractId", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(1).ToString()
            dcInsertNewAcc.Parameters.Add("@Guesttype", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(3).ToString()
            dcInsertNewAcc.Parameters.Add("@Shift", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(DScount)(4).ToString()
            dcInsertNewAcc.Parameters.Add("@Rate", SqlDbType.Decimal).Value = CDec(dsMain.Tables(0).Rows(DScount)(5).ToString())
            dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = "Rasahd"

            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()
            DScount = DScount - 1
        End While
    End Sub
    Private Sub LoadTransferRatesTemp()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim contractno As String = txtContactno.Text.Trim


            dcSearch = New SqlCommand("select Guesttype,Shift,Rate from dbo.[Boat.Transferrates.Temp] where  Contactno=@contractno", Conn)
            dcSearch.Parameters.Add("@contractno", SqlDbType.VarChar).Value = contractno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            gdTransrate.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadTransferRatesMaster(ByVal TopContract As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim contractno As String = TopContract


            dcSearch = New SqlCommand("select Guesttype,Shift,Rate from dbo.[Boat.Transferrates] where  TopcontractId=@contractno", Conn)
            dcSearch.Parameters.Add("@contractno", SqlDbType.VarChar).Value = contractno

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)
            gdTransrate.DataSource = dsMain.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub btAddtransrate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAddtransrate.Click

        If txtTransrate.Text.Trim = "" Then

            MessageBox.Show("Please Enter Rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else

            Dim dscheckAddbefore As New DataSet
            dscheckAddbefore = DSCheckAddTransTemp()

            If dscheckAddbefore Is Nothing Then
                InsertTransRatesTemp()

            Else
                MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            End If
            LoadTransferRatesTemp()

        End If
        txtTransrate.Text = ""

        
    End Sub
    Function DSCheckAddTransTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim contractno As String = txtContactno.Text.Trim
            Dim Cusid As String = cbTopcode.Text.Trim
            Dim Guesttype As String = Cbguestype.Text.Trim
            Dim shift As String = CbShift.Text.Trim

            dcSearch = New SqlCommand("select * from dbo.[Boat.Transferrates.Temp] where Contactno=@contractno and CusId=@Cusid and Guesttype=@Guesttype and Shift=@shift", Conn)
            dcSearch.Parameters.Add("@contractno", SqlDbType.VarChar).Value = contractno
            dcSearch.Parameters.Add("@Cusid", SqlDbType.VarChar).Value = Cusid
            dcSearch.Parameters.Add("@Guesttype", SqlDbType.VarChar).Value = Guesttype
            dcSearch.Parameters.Add("@shift", SqlDbType.VarChar).Value = shift


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckAddTransTemp = dsMain
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
    Private Sub DelRoomRatesTemp(ByVal gridFoca As String, ByVal Tempid As Integer)


        'Dim Conn As New SqlConnection(ConnString)
        'Dim dcInsertNewAcc As New SqlCommand

        'Dim getgridFoca As String = gridFoca

        'dcInsertNewAcc = New SqlCommand("DelTransRateTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

        'If getgridFoca = "GridView2" Then
        '    dcInsertNewAcc.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Tempid"))
        'End If


        'If getgridFoca = "GridView3" Then
        '    dcInsertNewAcc.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Tempid"))
        'End If


        'If getgridFoca = "GridView4" Then
        '    dcInsertNewAcc.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "Tempid"))
        'End If

        'Conn.Open()
        'dcInsertNewAcc.ExecuteNonQuery()
        'Conn.Close()




        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand


        Dim getgridFoca As String = gridFoca

        Dim GetTempId As Integer = Tempid


        'If getgridFoca = "GridView2" Then
        '    '  TempId = Convert.ToInt32(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Tempid"))
        '    Tempid = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Tempid")


        'End If


        'If getgridFoca = "GridView3" Then

        '    'TempId = Convert.ToInt32(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Tempid"))
        '    Tempid = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Tempid")

        'End If


        'If getgridFoca = "GridView4" Then

        '    ' TempId = Convert.ToInt32(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "Tempid"))
        '    TempId = GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "Tempid")

        'End If

        dcInsertNewAcc = New SqlCommand("DelTransRateTemp_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
        dcInsertNewAcc.Parameters.Add("@Id", SqlDbType.Int).Value = GetTempId

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()








    End Sub
    Private Sub DelTopContractHistory()


        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand
        dcInsertNewAcc = New SqlCommand("DelTopContractHistory_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub
    Private Sub DelTopContractHistoryRoom(ByVal Contractno As String)


        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim GetContract As String = Contractno

        dcInsertNewAcc = New SqlCommand("DelTopContractHistoryRoomRates_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
        dcInsertNewAcc.Parameters.Add("@Contactno", SqlDbType.VarChar).Value = GetContract

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub
    Private Sub DelTopContractRoomRateMaster(ByVal Contractno As String)


        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim GetContract As String = Contractno

        dcInsertNewAcc = New SqlCommand("DelTopContractRoomRatesMaster_SP", Conn) With {.CommandType = CommandType.StoredProcedure}
        dcInsertNewAcc.Parameters.Add("@Contactno", SqlDbType.VarChar).Value = GetContract

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub
    Private Sub btDelroomratestemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelroomratestemp.Click

        If gcRoomStand.Focused = True Then
            DelRoomRatesTemp("GridView2", PubTempIdMas)
            LoadRoomRatesTempStd()


        End If

        If gcRoomSd.Focus = True Then
            DelRoomRatesTemp("GridView3", PubTempIdMas)
            LoadRoomRatesTempDelux()


        End If


        If gcRoomSup.Focus = True Then
            DelRoomRatesTemp("GridView4", PubTempIdMas)
            LoadRoomRatesTempSup()


        End If

        LoadRoomRatesTempStd()
        LoadRoomRatesTempDelux()
        LoadRoomRatesTempSup()


    End Sub
    Private Sub btMAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMAdd.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TourOperatorContracts Master", "Add")

        If CheckAccess = True Then


            If String.Compare(btMAdd.Text, "Add", False) = 0 Then

                ClearFields()
                btMAdd.Text = "Save"
                btMEdit.Enabled = False
                'btMView.Enabled = False
                btMDel.Enabled = False
                tabTopContarcts.TabPages(1).PageEnabled = True
                tabTopContarcts.SelectedTabPageIndex = 1

            Else

                Try


                    If FieldValidation() = False Then
                        MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                        Exit Sub
                    Else


                        Dim bt As DialogResult = MessageBox.Show("Do You Want To Save This Contract Details", "Save Contract Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If bt = Windows.Forms.DialogResult.Yes Then

                            Dim PubId_Allinclusive As String = System.Guid.NewGuid().ToString()
                            Dim PubId_RoomRates As String = System.Guid.NewGuid().ToString()
                            Dim PubId_TransRates As String = System.Guid.NewGuid().ToString()

                            InsertRoomRates(PubId_RoomRates, txtContactno.Text.Trim)
                            InsertTransRates(PubId_TransRates, txtContactno.Text.Trim)

                            If Checkallin.Checked = True Then
                                If txtallinadultrate.Text.Length > 0 Then
                                    InsertAllinclusivRates("Adults", CDec(txtallinadultrate.Text.Trim), PubId_Allinclusive)

                                End If

                                If txtallininfanrate.Text.Length > 0 Then
                                    InsertAllinclusivRates("Infants", CDec(txtallininfanrate.Text.Trim), PubId_Allinclusive)
                                End If

                                If txtallinchildrate.Text.Length > 0 Then
                                    InsertAllinclusivRates("Children", CDec(txtallinchildrate.Text.Trim), PubId_Allinclusive)
                                End If

                            End If

                            InsertContract()


                            LoadTopContracts()
                            'LoadGrid()

                            btMAdd.Text = "Add"
                            btMEdit.Enabled = True
                            'btMView.Enabled = True
                            btMDel.Enabled = True
                            tabTopContarcts.TabPages(1).PageEnabled = False
                            tabTopContarcts.SelectedTabPageIndex = 0
                            Exit Sub

                        End If
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
                End Try

            End If

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Private Sub InsertAllinclusivRates(ByVal category As String, ByVal rates As Decimal, ByVal PubId As String)


        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()
        Dim getCategory As String = category
        Dim getRates As Decimal = rates
        Dim getPubId As String = PubId

        dcInsertNewAcc = New SqlCommand("InsertAllInclusives_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

        dcInsertNewAcc.Parameters.Add("@InclusiveId", SqlDbType.VarChar).Value = autoid
        dcInsertNewAcc.Parameters.Add("@Custype", SqlDbType.VarChar).Value = "TOP"
        dcInsertNewAcc.Parameters.Add("@CusId", SqlDbType.VarChar).Value = cbTopcode.Text.Trim
        dcInsertNewAcc.Parameters.Add("@IncluTopContractId", SqlDbType.VarChar).Value = getPubId
        dcInsertNewAcc.Parameters.Add("@TopContractId", SqlDbType.VarChar).Value = txtContactno.Text.Trim
        dcInsertNewAcc.Parameters.Add("@Category", SqlDbType.VarChar).Value = getCategory
        dcInsertNewAcc.Parameters.Add("@Rates", SqlDbType.Decimal).Value = getRates



        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()

    End Sub
    Private Sub InsertContract()

        Try

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim autoid As String = System.Guid.NewGuid().ToString()


        '--------------------------Room Rates-------------------------------------------------
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        dcSearch = New SqlCommand("select RatesTopContractId from dbo.[Rooms.Rates] where Topcontractid=@contractno", Conn)
        dcSearch.Parameters.Add("@contractno", SqlDbType.VarChar).Value = txtContactno.Text.Trim
        Conn.Open()
        daMain = New SqlDataAdapter()
        daMain.SelectCommand = dcSearch
        daMain.Fill(dsMain)
        Conn.Close()

        '--------------------------End-------------------------------------------------


        '--------------------------Transfer Rates-------------------------------------------------
        Dim daMain2 As New SqlDataAdapter
        Dim dsMain2 As New DataSet
        Dim dcSearch2 As New SqlCommand
        dcSearch2 = New SqlCommand("select TransTopContracid from dbo.[Boat.Transferrates] where TopcontractId=@contractno", Conn)
        dcSearch2.Parameters.Add("@contractno", SqlDbType.VarChar).Value = txtContactno.Text.Trim
        Conn.Open()
        daMain2 = New SqlDataAdapter()
        daMain2.SelectCommand = dcSearch2
        daMain2.Fill(dsMain2)
        Conn.Close()

        '--------------------------End-------------------------------------------------

        '--------------------------All Inclusive Rates-------------------------------------------------
        Dim daMain3 As New SqlDataAdapter
        Dim dsMain3 As New DataSet
        Dim dcSearch3 As New SqlCommand
        dcSearch3 = New SqlCommand("select IncluTopContractId from dbo.[Meals.Allinclusive] where TopContractId=@contractno", Conn)
        dcSearch3.Parameters.Add("@contractno", SqlDbType.VarChar).Value = txtContactno.Text.Trim
        Conn.Open()
        daMain3 = New SqlDataAdapter()
        daMain3.SelectCommand = dcSearch3
        daMain3.Fill(dsMain3)
        Conn.Close()

            Dim Allinclusivetopid As String = ""

            If dsMain3.Tables(0).Rows.Count > 0 Then

                Allinclusivetopid = dsMain3.Tables(0).Rows(0)(0).ToString.Trim

            Else

                Allinclusivetopid = ""


            End If



            

            '--------------------------End-------------------------------------------------

            Dim CurrentUser As String = CurrUser


            dcInsertNewAcc = New SqlCommand("InsertContracts_SP", Conn) With {.CommandType = CommandType.StoredProcedure}

            dcInsertNewAcc.Parameters.Add("@ContractId", SqlDbType.VarChar).Value = autoid
            dcInsertNewAcc.Parameters.Add("@TopId", SqlDbType.VarChar).Value = cbTopcode.Text.Trim
            dcInsertNewAcc.Parameters.Add("@Contractno", SqlDbType.VarChar).Value = txtContactno.Text.Trim
            dcInsertNewAcc.Parameters.Add("@SignDate", SqlDbType.DateTime).Value = dtCon.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@SDate", SqlDbType.DateTime).Value = dtConStart.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@EDate", SqlDbType.DateTime).Value = dtConEnd.DateTime.Date
            dcInsertNewAcc.Parameters.Add("@RatesTopContractId", SqlDbType.VarChar).Value = dsMain.Tables(0).Rows(0)(0).ToString.Trim
            dcInsertNewAcc.Parameters.Add("@IncluTopContractId", SqlDbType.VarChar).Value = Allinclusivetopid
            dcInsertNewAcc.Parameters.Add("@TransTopContracid", SqlDbType.VarChar).Value = dsMain2.Tables(0).Rows(0)(0).ToString.Trim
            dcInsertNewAcc.Parameters.Add("@Minnights", SqlDbType.Int).Value = Convert.ToInt32(txtMimnights.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@Payduedate", SqlDbType.Int).Value = Convert.ToInt32(txtPayduedate.Text.Trim)
            dcInsertNewAcc.Parameters.Add("@Createdby", SqlDbType.VarChar).Value = CurrentUser


            Conn.Open()
            dcInsertNewAcc.ExecuteNonQuery()
            Conn.Close()
            MessageBox.Show("Contract Details Saved Successfully", "Save Contract Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        End Try

    End Sub

    Private Sub txtallinadultrate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtallinadultrate.KeyPress

        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtallininfanrate.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtallininfanrate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtallininfanrate.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtallinchildrate.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtallinchildrate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtallinchildrate.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.Cbguestype.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtMimnights_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMimnights.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtPayduedate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayduedate.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub txtTransrate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTransrate.KeyPress
        Dim DSep As String = "."
        If Char.IsNumber(e.KeyChar) = False And Microsoft.VisualBasic.AscW(e.KeyChar) <> 46 Then

            If e.KeyChar = CChar(DSep) Then

                e.Handled = True

            ElseIf Microsoft.VisualBasic.AscW(e.KeyChar) = 13 Then

                Me.txtMimnights.Select() ''<---jump to next text box after press Enter  

                e.Handled = False

            Else

                e.Handled = True
            End If

        End If

    End Sub
    Private Sub dtConStart_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtConStart.EditValueChanged
        If btMAdd.Text = "" Then
            Exit Sub
        End If

        If (dtCon.DateTime.Date > dtConStart.DateTime.Date) Then
            MessageBox.Show("Contract Start Date Can Not Be Less Than Contract Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
    Private Sub GridView2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView2.KeyDown
        If e.KeyCode = Keys.Delete Then
            GridView2.DeleteRow(GridView2.FocusedRowHandle)
        End If
    End Sub

    Sub ClearFields()


        txtContactno.Text = GetTopContractCode()
        txtrate.Text = ""
        txtAllocatedrooms.Text = ""
        txtreleasedate.Text = ""
        txtallinadultrate.Text = ""
        txtallininfanrate.Text = ""
        txtallinchildrate.Text = ""
        txtTransrate.Text = ""
        txtMimnights.Text = ""
        txtPayduedate.Text = ""


        txtAllocatedrooms.Text = "0"
        txtreleasedate.Text = "0"
        txtMimnights.Text = "0"
        txtPayduedate.Text = "0"



        gbTransrate.Enabled = True
        gbOthrs.Enabled = True
        gbAI.Enabled = True
        gbContract.Enabled = True
        gbRoomRates.Enabled = True

        gcRoomSd.DataSource = Nothing
        gcRoomStand.DataSource = Nothing
        gcRoomSup.DataSource = Nothing

        DelTopContractHistory()



    End Sub

    Function FieldValidationRoom() As Boolean
        Return IIf(String.Compare(txtrate.Text, "", False) = 0 Or String.Compare(txtAllocatedrooms.Text, "", False) = 0 Or String.Compare(txtreleasedate.Text, "", False) = 0, 0, 1)
    End Function
    Function FieldValidation() As Boolean
        Return IIf(String.Compare(txtMimnights.Text, "", False) = 0 Or String.Compare(txtPayduedate.Text, "", False) = 0, 0, 1)
    End Function

    Private Sub PrintTopContracts()
        Dim Conn As New SqlConnection(ConnString)


        Dim sqlString As String
        Dim dcIns As New SqlCommand()
        Dim daMain As New SqlDataAdapter()
        Dim dsMain As New DataSet

        Dim fltString As String

        Try

            Conn.Open()

            dcIns = New SqlCommand("select * from Top_Contracts_Transfer", Conn)
            ' dcIns.Parameters.Add("@ProInvNo", SqlDbType.VarChar).Value = txtProninvno.Text

            Dim ParaProinv As String = gvTopAgreements.GetRowCellValue(gvTopAgreements.FocusedRowHandle, "Contractno")
            dcIns.CommandType = CommandType.Text
            dcIns.ExecuteNonQuery()


            ' fltString = "{rpt_Proforma_Invoice.ProInvNo}='" & Trim(txtProninvno.Text) & "'"

            fltString = "{Top_Contracts_Transfer.Contractno}='" & ParaProinv & "'"

            ReportName = "TopContracts.rpt"
            rptTitle = "Top Contracts"

            frmReportViewer.rptPath = ReportName
            frmReportViewer.rptTitle = rptTitle
            frmReportViewer.selectionForumla = fltString
            frmReportViewer.reporttype = 1

            'frmReportViewer.paraRepName = "TestPara"
            'frmReportViewer.paraRepVale = DtToday.Text.ToString

            'frmReportViewer.paraRepName2 = "TestPara2"
            'frmReportViewer.paraRepVale2 = DtToday.Text.ToString


            frmReportViewer.Show()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcIns.Dispose()

        End Try
    End Sub

    Private Sub btPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrint.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TourOperatorContracts Master", "Print")

        If CheckAccess = True Then


            PrintTopContracts()


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub btMDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMDel.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TourOperatorContracts Master", "Delete")

        If CheckAccess = True Then


            Try

                Dim bt As DialogResult = MessageBox.Show("Do You Want To Delete This Contract", "Delete Contract Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If bt = Windows.Forms.DialogResult.Yes Then

                    InactiveContracts()


                End If
                LoadTopContracts()

                Exit Sub

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            End Try



        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub
    Private Sub InactiveContracts()


        Dim ContractNo As String = gvTopAgreements.GetRowCellValue(gvTopAgreements.FocusedRowHandle, "Contractno")
        Dim CurrentUser As String = CurrUser


        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        dcInsertNewAcc = New SqlCommand("InactiveContracts_SP", Conn)
        dcInsertNewAcc.CommandType = CommandType.StoredProcedure
        dcInsertNewAcc.Parameters.Add("@Contractno", SqlDbType.VarChar).Value = ContractNo
        dcInsertNewAcc.Parameters.Add("@User", SqlDbType.VarChar).Value = CurrentUser
        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        MessageBox.Show("Contract Inactivated Successfully", "Inactivate Contract Details", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Conn.Close()
    End Sub
    Function GetTopContractCode() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNo", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "Contracts"
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output

            dcGetCode.ExecuteNonQuery()

            GetTopContractCode = dcGetCode.Parameters("@Currcode").Value


            Return GetTopContractCode
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()

        End Try

    End Function
    Private Sub ShowGridDets()
        Dim Conn As New SqlConnection(ConnString)
        Dim daShow As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try
            ' PubIsEdit = 1


            gbTransrate.Enabled = False
            gbOthrs.Enabled = False
            gbAI.Enabled = False
            gbContract.Enabled = False
            gbRoomRates.Enabled = False

            btMAdd.Enabled = False
            btMDel.Enabled = False
            btPrint.Enabled = False


            Conn.Open()
            daShow = New SqlDataAdapter(String.Format("select *  from dbo.[Touroperator.Contracts] where Contractno= '{0}'", gvTopAgreements.GetRowCellValue(gvTopAgreements.FocusedRowHandle, "Contractno")), Conn)
            daShow.Fill(dsShow)


            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If



            tabTopContarcts.TabPages(1).PageEnabled = True

            tabTopContarcts.SelectedTabPageIndex = 1

            txtContactno.Text = dsShow.Tables(0).Rows(0).Item("Contractno")
            dtCon.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("SignDate"))
            dtConStart.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("SDate"))
            dtConEnd.Text = Convert.ToDateTime(dsShow.Tables(0).Rows(0).Item("EDate"))

            cbTopcode.Text = dsShow.Tables(0).Rows(0).Item("TopId")
            cbTopcode.ClosePopup()

            txtMimnights.Text = dsShow.Tables(0).Rows(0).Item("Minnights")
            txtPayduedate.Text = Convert.ToInt16(dsShow.Tables(0).Rows(0).Item("Payduedate"))


            DelTopContractHistoryRoom(dsShow.Tables(0).Rows(0).Item("Contractno"))


            InsertRoomRatesTempToOriginal(dsShow.Tables(0).Rows(0).Item("Contractno"))
            LoadRoomRatesTempDelux()
            LoadRoomRatesTempStd()
            LoadRoomRatesTempSup()


            LoadTransferRatesMaster(dsShow.Tables(0).Rows(0).Item("Contractno"))


            Dim Inclusiveid As String = dsShow.Tables(0).Rows(0).Item("IncluTopContractId")
            If Inclusiveid = "" Then

                Checkallin.Checked = False

            Else

                Checkallin.Checked = True

                Dim dsGetAdult As New DataSet
                dsGetAdult = DSGetAllInclusiveRate(dsShow.Tables(0).Rows(0).Item("Contractno"), "Adults")

                If dsGetAdult.Tables(0).Rows.Count > 0 Then
                    txtallinadultrate.Text = dsGetAdult.Tables(0).Rows(0)(0).ToString
                End If



                Dim dsGetChild As New DataSet
                dsGetChild = DSGetAllInclusiveRate(dsShow.Tables(0).Rows(0).Item("Contractno"), "Children")

                If dsGetChild.Tables(0).Rows.Count > 0 Then
                    txtallinchildrate.Text = dsGetChild.Tables(0).Rows(0)(0).ToString
                End If


                Dim dsGetInfants As New DataSet
                dsGetInfants = DSGetAllInclusiveRate(dsShow.Tables(0).Rows(0).Item("Contractno"), "Infants")

                If dsGetInfants.Tables(0).Rows.Count > 0 Then
                    txtallininfanrate.Text = dsGetInfants.Tables(0).Rows(0)(0).ToString
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

    Private Sub ShowGridDetsStandardRoom()
        'Dim Conn As New SqlConnection(ConnString)
        'Dim daShow As New SqlDataAdapter()
        'Dim dsShow As New DataSet

        'Try
        '    ' PubIsEdit = 1

        '    Conn.Open()
        '    ' daShow = New SqlDataAdapter(String.Format("select *  from dbo.[Invoice.Tax.Master] where TaxInvNo= '{0}'", gvtaxinvs.GetRowCellValue(gvtaxinvs.FocusedRowHandle, "TaxInvNo")), Conn)

        '    daShow = New SqlDataAdapter(String.Format("SELECT TOP (100) PERCENT dbo.[Touroperator.Contracts].Contractno, dbo.[Touroperator.Contracts].TopId, dbo.[Touroperator.Contracts].SignDate, dbo.[Touroperator.Contracts].SDate, dbo.[Touroperator.Contracts].EDate, dbo.[Touroperator.Contracts].Minnights, dbo.[Touroperator.Contracts].Payduedate, dbo.[Rooms.Rates].Roomtype, dbo.[Rooms.Rates].Custype, dbo.[Rooms.Rates].ValidSDate, dbo.[Rooms.Rates].ValidEDate, dbo.[Rooms.Rates].Packagetype, dbo.[Rooms.Rates].Countype, dbo.[Rooms.Rates].Rate, dbo.[Rooms.Rates].Allocatedrooms, dbo.[Rooms.Rates].BalanceRooms,dbo.[Rooms.Rates].Releasedate FROM dbo.[Touroperator.Contracts] INNER JOIN dbo.[Rooms.Rates] ON dbo.[Touroperator.Contracts].Contractno = dbo.[Rooms.Rates].Topcontractid WHERE  (dbo.[Rooms.Rates].Roomtype = 'Standard') and (dbo.[Touroperator.Contracts].Contractno) = '{0}'", gvTopAgreements.GetRowCellValue(gvTopAgreements.FocusedRowHandle, "Contractno")), Conn)


        '    daShow.Fill(dsShow)

        '    If dsShow.Tables(0).Rows.Count = 0 Then
        '        Exit Sub
        '    End If
        '    tabTopContarcts.SelectedTabPageIndex = 1




        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        'Finally
        '    Conn.Dispose()
        '    daShow.Dispose()
        '    dsShow.Dispose()
        'End Try
    End Sub


    Private Sub gvTopAgreements_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvTopAgreements.DoubleClick
        ShowGridDets()
    End Sub

    Private Sub btMEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btMEdit.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TourOperatorContracts Master", "Edit")

        If CheckAccess = True Then




            gbRoomRates.Enabled = True

            PubIsEdit = 1


            If String.Compare(btMEdit.Text, "Edit", False) = 0 Then

                ' ClearFields()
                btMEdit.Text = "Update"
                btMAdd.Enabled = False
                'btMView.Enabled = False
                btMDel.Enabled = False
                tabTopContarcts.TabPages(1).PageEnabled = True
                tabTopContarcts.SelectedTabPageIndex = 1

            Else

                Try

                    Dim bt As DialogResult = MessageBox.Show("Do You Want To Update Contract Details", "Update Contract Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If bt = Windows.Forms.DialogResult.Yes Then

                        UpdateContractDetails()


                    End If
                    LoadTopContracts()


                    btMEdit.Text = "Edit"
                    btMAdd.Enabled = True
                    'btMView.Enabled = True
                    btMDel.Enabled = True
                    tabTopContarcts.TabPages(1).PageEnabled = False
                    tabTopContarcts.SelectedTabPageIndex = 0
                    Exit Sub

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")

                End Try

            End If



        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub
    Private Sub UpdateContractDetails()


        DelTopContractRoomRateMaster(txtContactno.Text.Trim)

        Dim PubId_RoomRates As String = System.Guid.NewGuid().ToString()

        InsertRoomRates(PubId_RoomRates, txtContactno.Text.Trim)


    End Sub
    Function DSGetAllInclusiveRate(ByVal Contractno As String, ByVal GuestType As String) As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim getContractno As String = Contractno
            Dim getGuestType As String = GuestType

            dcSearch = New SqlCommand("select Rates  from dbo.[Meals.Allinclusive] where TopContractId=@TopContractId and Category=@Category", Conn)
            dcSearch.Parameters.Add("@TopContractId", SqlDbType.VarChar).Value = getContractno
            dcSearch.Parameters.Add("@Category", SqlDbType.VarChar).Value = getGuestType


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSGetAllInclusiveRate = dsMain
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
    Private Sub GridView2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView2.Click

        PubTempIdMas = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Tempid")

    End Sub

    Private Sub GridView3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView3.Click
        PubTempIdMas = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Tempid")
    End Sub

    Private Sub GridView4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView4.Click
        PubTempIdMas = GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "Tempid")
    End Sub

    Private Sub frmTourOperatorContractMaster_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub

    Private Sub tabTopContarcts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabTopContarcts.Click

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

                cmbpacktype.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1

            End While

            cmbpacktype.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
End Class