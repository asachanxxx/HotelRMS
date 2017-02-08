Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports System.Runtime.Serialization
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Xml

Public Class frmKOT_BOT_Billing
    Public Itemcode, Itemname, Itemqty, Itemprice, KotBotNo, mode As String
    Public ItemcodeDp, ItemnameDp, ItemqtyDp, ItempriceDp, KotBotNoDp, modeDp As String
    Public TotQty As Double
    Public frmGridRow As Double
    Dim dsDepartments As New DataSet
    Dim dsPayMethod As New DataSet
    Dim dsCurrency As New DataSet
    Dim dsDepartmentsOutLet As New DataSet
    Dim unboundDataOutLetBill As New ArrayList()
    Dim dsItemList As New DataSet
    Dim dsPaid As New DataSet
    Dim dsUnPaid As New DataSet
    Dim Discountds As New DataSet

    Public PubPrefixcode As String = ""
    Public PubMaintype As String = ""
    Public PubIsStaff As Integer = 0
    Public PubWaitno As Integer = 0
    Public PubOutletbillno As String = ""
    Public PubOutletbilmasno As String = ""
    Public PubMPAI As String = ""
    Public PubItemAI As String = ""
    Public PublicTempOutletBillNo As String = ""
    Public PubTempBillCheck As Integer = 0
    Public PubGetbillnoList As String = ""
    Public PubGetMasbillnoList As String = ""






    Private Sub frmKOT_BOT_Billing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        GridView1.OptionsSelection.MultiSelect = True
        GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
        dtDate.Text = Date.Today.ToShortDateString


       



        LoadGridDets()
        loadKotDataGrid()
        loadPendingKotDataGrid()
        LoadDepartmentID()
        'LoadDepartment(cmboutletID.Text.Trim, 1)
        GetServerDate()

        'LoadDepartmentsForOutLetBill()

        GridView5.OptionsSelection.MultiSelect = True
        GridView5.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect
        GridView5.OptionsSelection.UseIndicatorForSelection = True
        cmbWaiter.SelectedIndex = 0

        '    If (tabMain.SelectedTabPageIndex = 1) Then
        LoadRoomNo()
        '  End If
        ' If (tabMain.SelectedTabPageIndex = 1) Then
        ' LoadRoomNo()
        '  End If
        '   If (tabMain.SelectedTabPageIndex = 3) Then
        LoadCurrencyType()
        loadPayMethod()
        ' End If
        '   If (tabMain.SelectedTabPageIndex = 2) Then
        LoadDiscounts()
        '  End If

        cmbType.SelectedIndex = 0
        'gridItemDets.Enabled = False
        tabMain.SelectedTabPageIndex = 0

        If (String.IsNullOrEmpty(txtGuest.Text.Trim())) Then
            'gridItemDets.Enabled = False
            gvItemDets.OptionsBehavior.Editable = False
        Else
            'gridItemDets.Enabled = True
            gvItemDets.OptionsBehavior.Editable = True
        End If

        txtGuest.Properties.ReadOnly = True
        ' txtOutlet.Properties.ReadOnly = True


        tabMain.TabPages(1).PageEnabled = True
        tabMain.TabPages(0).PageEnabled = True

        cmbWaiter.SelectedIndex = -1

        cmbType.Focus()

    End Sub

    Private Sub frmKOT_BOT_Billing_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EnabledChanged
        If Me.Enabled Then
            Dim dataRowList() As DataRow
            gvItemDets.SetRowCellValue(frmGridRow, "Itemcode", Itemcode)
            gvItemDets.SetRowCellValue(frmGridRow, "Itemname", Itemname)
            gvItemDets.SetRowCellValue(frmGridRow, "Itemqty", Itemqty)
            gvItemDets.SetRowCellValue(frmGridRow, "TotQty", TotQty)
            If (Itemcode Is Nothing) Then
                Itemcode = ""
            End If
            If (Itemname Is Nothing) Then
                Itemname = ""
            End If
            If (Itemqty Is Nothing) Then
                Itemqty = 0
            End If

            If (Not dsItemList Is Nothing) Then
                If (dsItemList.Tables.Count > 0) Then

                    dataRowList = dsItemList.Tables(0).Select(String.Format("Itemcode ='{0}'", Itemcode.Trim()))
                    If (Not dataRowList Is Nothing) Then
                        If (dataRowList.Length > 0) Then


                            '---Set Selling Price ----------


                            LoadResDetails(txtResNo.Text.Trim)

                            LoadAIItems(Itemcode)



                            GetServerDate()

                            Dim GetBiilingTime As DateTime = dtDate.Text





                            If PubMPAI = "AI" And PubItemAI = "AI" Then

                                If cmboutletID.Text = "Main Bar" Then

                                    If GetBiilingTime.Hour >= 10 And GetBiilingTime.Hour <= 24 Then

                                        Dim val As String = "0"
                                        gvItemDets.SetRowCellValue(frmGridRow, "Itemprice", val)


                                    Else

                                        Dim val As String = dataRowList(0)("SellingPrice").ToString()
                                        gvItemDets.SetRowCellValue(frmGridRow, "Itemprice", val)


                                    End If



                                ElseIf cmboutletID.Text = "Coffee Shop" Then

                                    'If GetBiilingTime.Hour >= 16 And (GetBiilingTime.Hour <= 17 And GetBiilingTime.Minute <= 30) Then


                                    Dim CofStart As DateTime = dtDate.DateTime.Date + " 16:00:00.000"
                                    Dim CofEnd As DateTime = dtDate.DateTime.Date + " 17:30:00.000"


                                    If GetBiilingTime >= CofStart And GetBiilingTime <= CofEnd Then

                                        'If ((GetBiilingTime.Hour >= 16) And (GetBiilingTime.Hour <= 17 And GetBiilingTime.Minute <= 30)) Then


                                        Dim val As String = "0"
                                        gvItemDets.SetRowCellValue(frmGridRow, "Itemprice", val)

                                    Else

                                        Dim val As String = dataRowList(0)("SellingPrice").ToString()
                                        gvItemDets.SetRowCellValue(frmGridRow, "Itemprice", val)


                                    End If



                                ElseIf cmboutletID.Text = "Restaurant Bar" Then




                                    Dim val As String = "0"
                                    gvItemDets.SetRowCellValue(frmGridRow, "Itemprice", val)














                                Else

                                    Dim val As String = dataRowList(0)("SellingPrice").ToString()
                                    gvItemDets.SetRowCellValue(frmGridRow, "Itemprice", val)

                                End If




                            Else


                                Dim val As String = dataRowList(0)("SellingPrice").ToString()
                                gvItemDets.SetRowCellValue(frmGridRow, "Itemprice", val)



                            End If



                        Else
                            gvItemDets.SetRowCellValue(frmGridRow, "Itemprice", 0)
                        End If
                    End If
                End If
            End If
            Itemcode = Nothing
            Itemname = Nothing
            Itemqty = Nothing
        End If
    End Sub
#Region "Proc & Functions"

    Sub ClearFields()



        txtOutlet.Text = ""
        ' txtRefBillNo.Text = ""
        txtResNo.Text = ""
        txtGuest.Text = ""

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet

        '--- here what i hv done is, get a dummy dataset for itemreqdetails
        daGetDets = New SqlDataAdapter("select Itemcode,Itemname,Itemqty,Itemprice,UID from BillingTemp where itemcode like 'nothing'", Conn)
        daGetDets.Fill(dsShow)

        gridItemDets.DataSource = dsShow.Tables(0)


        'gridItemDets.DataSource = Nothing


    End Sub
#End Region

    ''' <summary>
    ''' Insert NewKOTBOTBilling
    ''' </summary>
    ''' <returns>True-Sucess,False-Failed</returns>
    ''' <remarks></remarks>
    Function InsertNewKOTBOTBilling(ByVal Proc As String) As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim Procedure As String
        Dim TransInsert As SqlTransaction
        Dim IsTransEnable As Boolean = False  'Track the transection status

        If String.Compare(Proc, "Add", False) = 0 Then
            Procedure = "spItemReqAdd"
        Else
            Procedure = "spItemReqEdit"
        End If

        Dim dcExecProc As New SqlCommand(Procedure, Conn)

        Try


            '/* 
            '    In this process two things going to happen. 
            ' 1) Insert all the details to temp table 
            ' 2) Run the stored procedures to insert all the details from temp table
            '*/


            Conn.Open()

            '--- Assign the transection
            TransInsert = Conn.BeginTransaction
            IsTransEnable = True


            Dim sqlstring As String = ""

            '------- remove any previous entries if exists

            ' sqlstring = String.Format("Delete from BillingTemp where KOTBOTNo like '{0}' And Users like '{0}'", KOTBOTNo,Users),Conn)

            dcExecProc = New SqlCommand(sqlstring, Conn)
            dcExecProc.Transaction = TransInsert

            dcExecProc.ExecuteNonQuery()

            For i As Int16 = 0 To gvItemDets.RowCount - 1

                If gvItemDets.GetRowCellValue(i, "Itemcode") = "" Then
                    Exit For
                End If

                If IsDBNull(gvItemDets.GetRowCellValue(i, "Itemprice")) Then
                    Throw New Exception("Item price must be non zero value")
                    Exit For
                End If


                sqlstring = "Insert Into BillingTemp(TempID,Type,Outlet,Date,KOTBOTNo,RoomNo,ReservationNo,Guest,Itemcode,Itemname,Itemqty,Itemprice,Users("
                sqlstring = sqlstring & "@TempID,@Type,@Outlet,@Date,@KOTBOTNo,@RoomNo,@ReservationNo,@Guest,@Itemcode,@Itemname,@Itemqty,@Itemprice,@Users)"

                dcExecProc = New SqlCommand(sqlstring, Conn)
                dcExecProc.Transaction = TransInsert



                With dcExecProc.Parameters
                    .Add("@TempID", SqlDbType.NVarChar).Value = "001"
                    .Add("@Type", SqlDbType.Date).Value = cmbType.Text
                    .Add("@Outlet", SqlDbType.NVarChar).Value = cmboutletID.Text
                    .Add("@Date", SqlDbType.NVarChar).Value = dtDate.Text
                    .Add("@KOTBOTNo", SqlDbType.NVarChar).Value = "K01"
                    .Add("@RoomNo", SqlDbType.NVarChar).Value =
                    .Add("@ReservationNo", SqlDbType.NVarChar).Value = txtResNo.Text
                    .Add("@Guest", SqlDbType.Float).Value = txtGuest.Text
                    .Add("@Itemcode", SqlDbType.Float).Value = gvItemDets.GetRowCellValue(i, "Itemcode")
                    .Add("@Itemname", SqlDbType.UniqueIdentifier).Value = gvItemDets.GetRowCellValue(i, "Itemname")
                    .Add("@Itemqty", SqlDbType.NVarChar).Value = gvItemDets.GetRowCellValue(i, "Itemqty")
                    .Add("@Itemprice", SqlDbType.NVarChar).Value = gvItemDets.GetRowCellValue(i, "Itemprice")
                    .Add("@User", SqlDbType.NVarChar).Value = "User"
                End With

                dcExecProc.ExecuteNonQuery()

            Next


            TransInsert.Commit()
            IsTransEnable = False

            dcExecProc.Dispose()

            '--------------------------------------------------

            dcExecProc = New SqlCommand(Procedure, Conn)
            dcExecProc.CommandType = CommandType.StoredProcedure

            With dcExecProc.Parameters
                .Add("@CurrUser", SqlDbType.VarChar).Value = CurrUser
            End With

            dcExecProc.ExecuteNonQuery()

            Return 1
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Finally
            Conn.Dispose()
            dcExecProc.Dispose()

        End Try

        If IsTransEnable Then
            TransInsert.Rollback()
        End If

    End Function
    Sub ShowFields(ByVal kotID As String)
        Dim dsShow As New DataSet
        Dim dsShowDetail As New DataSet
        KotBotNo = kotID
        mode = "Edit"
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetItemToDisplay As New SqlDataAdapter("SELECT [ItemCode] as 'Itemcode',[ItemName] as 'Itemname',[Qty] as 'Itemqty',[UnitPrice] as 'Itemprice' FROM [KotBotDetail] where KOTBOTID='" & kotID & "'", Conn)
        Dim daGetDets As New SqlDataAdapter("SELECT * FROM [KotBotMaster] where [id]='" & kotID & "'", Conn)


        tabMain.TabPages(1).PageEnabled = True
        tabMain.TabPages(0).PageEnabled = False

        Try

            Conn.Open()
            daGetDets.Fill(dsShow)
            Conn.Close()

            Conn.Open()
            daGetItemToDisplay.Fill(dsShowDetail)
            Conn.Close()

            If (Not dsShowDetail Is Nothing) Then
                gridItemDets.DataSource = dsShowDetail.Tables(0)
            End If

            cmbType.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Type")), "", dsShow.Tables(0).Rows(0).Item("Type"))
            dtDate.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Date")), "", dsShow.Tables(0).Rows(0).Item("Date"))
            cmbRmNo.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("RoomNo")), "", dsShow.Tables(0).Rows(0).Item("RoomNo"))
            txtResNo.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("ReservationNo")), "", dsShow.Tables(0).Rows(0).Item("ReservationNo"))
            LoadUserData(dsShow.Tables(0).Rows(0).Item("RoomNo"), 1)
            daGetDets.Dispose()
            dsShow.Dispose()

            tabMain.SelectedTabPageIndex = 1

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()

        End Try


    End Sub
    Sub ShowFieldsTemp(ByVal kotID As String)


        Dim dsShow As New DataSet
        Dim dsShowDetail As New DataSet
        KotBotNo = kotID
        mode = "Edit"

        SimpleButton1.Text = "Save To List"
        btnBilling.Text = "Save Final"

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetItemToDisplay As New SqlDataAdapter("SELECT [ItemCode] as 'Itemcode',[ItemName] as 'Itemname',[Qty] as 'Itemqty',[UnitPrice] as 'Itemprice' FROM [KotBotDetailTemp] where KOTBOTID='" & kotID & "'", Conn)
        Dim daGetDets As New SqlDataAdapter("SELECT * FROM [KotBotMasterTemp] where [id]='" & kotID & "'", Conn)




        cmbType.Enabled = False
        cmboutletID.Enabled = False
        cmbRmNo.Enabled = False
        cmbWaiter.Enabled = False
        ' txtManualnos.Enabled = False




        tabMain.TabPages(2).PageEnabled = True
        tabMain.TabPages(1).PageEnabled = False
        tabMain.TabPages(0).PageEnabled = False

        Try

            Conn.Open()
            daGetDets.Fill(dsShow)
            Conn.Close()

            Conn.Open()
            daGetItemToDisplay.Fill(dsShowDetail)
            Conn.Close()

            If (Not dsShowDetail Is Nothing) Then
                gridItemDets.DataSource = dsShowDetail.Tables(0)
            End If


            PublicTempOutletBillNo = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Id")), "", dsShow.Tables(0).Rows(0).Item("Id"))




            cmbType.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Type")), "", dsShow.Tables(0).Rows(0).Item("Type"))

            cmboutletID.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Department")), "", dsShow.Tables(0).Rows(0).Item("Department"))

            cmbWaiter.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("WaiterNo")), "", dsShow.Tables(0).Rows(0).Item("WaiterNo"))
            txtManualnos.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("ManualBillno")), "", dsShow.Tables(0).Rows(0).Item("ManualBillno"))

            dtDate.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Date")), "", dsShow.Tables(0).Rows(0).Item("Date"))
            cmbRmNo.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("RoomNo")), "", dsShow.Tables(0).Rows(0).Item("RoomNo"))
            txtResNo.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("ReservationNo")), "", dsShow.Tables(0).Rows(0).Item("ReservationNo"))
            LoadUserData(dsShow.Tables(0).Rows(0).Item("RoomNo"), 1)
            daGetDets.Dispose()
            dsShow.Dispose()

            tabMain.SelectedTabPageIndex = 1

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()

        End Try


    End Sub
    ''' <summary>
    ''' Its Load Grid Details
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Sub loadKotDataGrid()
        Dim Conn As New SqlConnection(modMain.ConnString)
        '  Dim daGetDets As New SqlDataAdapter("SELECT top 0 [ItemCode] as 'Itemcode',[ItemName] as 'Itemname',[Qty] as 'Itemqty',[UnitPrice] as 'Itemprice' FROM [KotBotDetail]", Conn)
        Dim daGetItemToDisplay As New SqlDataAdapter("SELECT [Id] as KOTBOTNo,[Date],[RoomNo] as 'Room No',[ReservationNo] as 'Reservation No',[Type],[Department] FROM [KotBotMaster] where [BillGenerated] =0 and [Active] = 1", Conn)
        Dim dsShow As New DataSet
        Dim dsMainShow As New DataSet

        Try

            If (Not daGetItemToDisplay Is Nothing) Then
                daGetItemToDisplay.Fill(dsMainShow)
            End If

            '  gridItemDets.DataSource = dsShow.Tables(0)
            gcKOTBOTBilling.DataSource = dsMainShow.Tables(0)
            dsShow.Dispose()
            dsMainShow.Dispose()
            daGetItemToDisplay.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            dsShow.Dispose()
            daGetItemToDisplay.Dispose()
            dsMainShow.Dispose()
        End Try
    End Sub
    Sub loadPendingKotDataGrid()
        Dim Conn As New SqlConnection(modMain.ConnString)
        '  Dim daGetDets As New SqlDataAdapter("SELECT top 0 [ItemCode] as 'Itemcode',[ItemName] as 'Itemname',[Qty] as 'Itemqty',[UnitPrice] as 'Itemprice' FROM [KotBotDetail]", Conn)
        Dim daGetItemToDisplay As New SqlDataAdapter("SELECT [Id] as KOTBOTNo,[Date],[RoomNo] as 'Room No',[ReservationNo] as 'Reservation No',[Type],[Department] FROM [KotBotMasterTemp] where [BillGenerated] =0 and [Active] = 1", Conn)
        Dim dsShow As New DataSet
        Dim dsMainShow As New DataSet

        Try

            If (Not daGetItemToDisplay Is Nothing) Then
                daGetItemToDisplay.Fill(dsMainShow)
            End If

            '  gridItemDets.DataSource = dsShow.Tables(0)
            GcKotBotPending.DataSource = dsMainShow.Tables(0)
            dsShow.Dispose()
            dsMainShow.Dispose()
            daGetItemToDisplay.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            dsShow.Dispose()
            daGetItemToDisplay.Dispose()
            dsMainShow.Dispose()
        End Try
    End Sub
    Private Sub GetServerDate()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("select GETDATE()as sysdate", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim SysDate As DateTime = Convert.ToDateTime(dsMain.Tables(0).Rows(0).Item("sysdate"))


            dtDate.Text = SysDate



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub




    Sub LoadGridDets()

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter("SELECT top 0 [ItemCode] as 'Itemcode',[ItemName] as 'Itemname',[Qty] as 'Itemqty',[UnitPrice] as 'Itemprice' FROM [KotBotDetail] ", Conn)
        '  Dim daGetItemToDisplay As New SqlDataAdapter("SELECT [Id] as KOTBOTNo,[Date],[RoomNo] as 'Room No',[ReservationNo] as 'Reservation No',[Type],[Department] FROM [KotBotMaster]", Conn)
        Dim dsShow As New DataSet
        '    Dim dsMainShow As New DataSet

        Try
            If (Not daGetDets Is Nothing) Then
                daGetDets.Fill(dsShow)
            End If

            'If (Not daGetItemToDisplay Is Nothing) Then
            '    daGetItemToDisplay.Fill(dsMainShow)
            'End If

            'create a totqty column
            Dim dtcol As New DataColumn("TotQty", System.Type.GetType("System.Double"))
            dsShow.Tables(0).Columns.Add(dtcol)


            gridItemDets.DataSource = dsShow.Tables(0)

            '   gcKOTBOTBilling.DataSource = dsMainShow.Tables(0)

            dsShow.Dispose()
            '   dsMainShow.Dispose()
            daGetDets.Dispose()
            '   daGetItemToDisplay.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
            '     daGetItemToDisplay.Dispose()
            '    dsMainShow.Dispose()
        End Try
    End Sub

    Private Function GetDataForSQL(ByVal sql As String) As Data.DataTable
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter(sql, Conn)

        Dim dsShow As New DataSet

        Try
            If (Not daGetDets Is Nothing) Then
                daGetDets.Fill(dsShow)
            End If
            dsShow.Dispose()

            daGetDets.Dispose()

            GetDataForSQL = dsShow.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try
    End Function

    Private Sub btnBilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBilling.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "KOTBOTBilling", "Add")

        If CheckAccess = True Then

            GetServerDate()

            cmbType.Focus()



            If String.Compare(btnBilling.Text, "Add Final", False) = 0 Then
                ' ClearFields()
                btnBilling.Text = "Save Final"
                btnCreateBilling.Enabled = False
                btnInactive.Enabled = False
                SimpleButton1.Enabled = False
                'btnBlock.Enabled = False
                tabMain.SelectedTabPageIndex = 1

                tabMain.TabPages(2).PageEnabled = True
                tabMain.TabPages(1).PageEnabled = False
                tabMain.TabPages(0).PageEnabled = False




            Else
                If (Not String.IsNullOrEmpty(txtGuest.Text)) Then
                    If (mode = "Edit") Then
                        mode = ""
                    Else
                        Dim dscheckAddbefore As New DataSet
                        dscheckAddbefore = DSCheckInsertBillingTemp()
                        If dscheckAddbefore Is Nothing Then

                            If (txtManualnos.Text = "" Or cmbWaiter.Text = "") And cmboutletID.Text <> "Mishrapshop" Then


                                MessageBox.Show("Enter Manual Bill/Waiter No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                Exit Sub
                            Else

                                InsertBillingKOTBOT()
                                LoadKOTBOTDataOutLet(ComboDept.Text)
                                DeleteKOTBOTempMaster()
                                DeleteKOTBOTempMasterDetail()

                                LoadGridDets()

                                loadPendingKotDataGrid()


                                tabMain.TabPages(2).PageEnabled = False
                                tabMain.TabPages(0).PageEnabled = True
                                tabMain.TabPages(1).PageEnabled = True

                                cmbWaiter.SelectedIndex = -1

                            End If

                        Else
                            MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End If
                        ' LoadGrid()
                        btnBilling.Text = "Add Final"
                        SimpleButton1.Text = "Add To List"

                        btnCreateBilling.Enabled = True
                        btnInactive.Enabled = True
                        SimpleButton1.Enabled = False
                        tabMain.SelectedTabPageIndex = 1

                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Please define a guest ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            End If

            'End If

            'GridControlOutLetBill.DataSource = Nothing


            'txtManualnos.Text = ""
            'txtResNo.Text = ""

            'cmbType.SelectedIndex = 0
            'cmboutletID.SelectedIndex = 0

            'cmbRmNo.SelectedIndex = 0
            'txtGuest.Text = ""


            'cmbEmpType.Visible = False
            'cbEmp.Visible = False
            ' cbOthers.Visible = False

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Function getOutLetBillNO() As String
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim daGetDets As SqlDataAdapter
        Try

            Conn.Open()
            daGetDets = New SqlDataAdapter("select isnull(MAX(no),0) as no from [OutLetBillMaster]", Conn)
            Dim dsShow As DataSet = New DataSet
            daGetDets.Fill(dsShow)
            If (Not dsShow Is Nothing) Then
                If (dsShow.Tables(0).Rows.Count > 0) Then
                    getOutLetBillNO = dsShow.Tables(0).Rows(0)("no")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
            Return Nothing
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
        End Try
    End Function

    Private Function getNewKotBotNO() As String
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim daGetDets As SqlDataAdapter
        Try

            Conn.Open()
            daGetDets = New SqlDataAdapter("select isnull(MAX(no),0) as no from [KotBotMaster]", Conn)
            Dim dsShow As DataSet = New DataSet
            daGetDets.Fill(dsShow)
            If (Not dsShow Is Nothing) Then
                If (dsShow.Tables(0).Rows.Count > 0) Then
                    getNewKotBotNO = dsShow.Tables(0).Rows(0)("no")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
            Return Nothing
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
        End Try
    End Function

    Private Function getNewBillNO() As String
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim daGetDets As SqlDataAdapter
        Try

            Conn.Open()
            daGetDets = New SqlDataAdapter("select isnull(MAX(no),0) as no from [OutLetBillMaster]", Conn)
            Dim dsShow As DataSet = New DataSet
            daGetDets.Fill(dsShow)
            If (Not dsShow Is Nothing) Then
                If (dsShow.Tables(0).Rows.Count > 0) Then
                    getNewBillNO = dsShow.Tables(0).Rows(0)("no").ToString()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
            Return Nothing
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
        End Try
    End Function

    Function GetKOTBOTNo(ByVal maintype As String) As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()

        Try

            Dim GetBillcode As String = maintype

            Dim GetPrefix As String = ""

            If GetBillcode = "KOT" Then
                GetPrefix = "KOT-13-"
            End If

            If GetBillcode = "BOT" Then
                GetPrefix = "BOT-13-"
            End If


            If GetBillcode = "OOT" Then
                GetPrefix = "OOT-13-"
            End If


            If GetBillcode = "BCOM" Then
                GetPrefix = "COM-13-"
            End If


            If GetBillcode = "BILL" Then
                GetPrefix = "BILL-13-"
            End If

            PubPrefixcode = GetPrefix
            PubMaintype = GetBillcode

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNo", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = GetBillcode
            ' dcGetCode.Parameters.Add("@PREFIX1", SqlDbType.NVarChar).Value = GetPrefix
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output
            dcGetCode.ExecuteNonQuery()




            If (Not IsDBNull(dcGetCode.Parameters("@Currcode").Value)) Then

                GetKOTBOTNo = dcGetCode.Parameters("@Currcode").Value


                Return GetKOTBOTNo

            Else

                GetKOTBOTNo = ""

                Return GetKOTBOTNo

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()

        End Try

    End Function
    Function GetOutletMasBillNo(ByVal maintype As String) As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()

        Try


            Dim GetBillcode As String = maintype

            Dim GetPrefix As String = ""
            Dim PassMaintype As String = ""




            If GetBillcode = "B/L" Then

                GetPrefix = "BLB-13-"
                PassMaintype = "OB-BL"

            End If

            If GetBillcode = "BedTax" Then

                GetPrefix = "BTB-13-"
                PassMaintype = "OB-BedTax"

            End If


            If GetBillcode = "Coffee Shop" Then

                GetPrefix = "CSB-13-"
                PassMaintype = "OB-CoffeeShop"

            End If


            If GetBillcode = "Divingschool" Then

                GetPrefix = "DSB-13-"
                PassMaintype = "OB-Divingschool"

            End If


            If GetBillcode = "Excursions" Then

                GetPrefix = "EXB-13-"
                PassMaintype = "OB-Excursions"

            End If





            If GetBillcode = "GardenSpa" Then

                GetPrefix = "GSB-13-"
                PassMaintype = "OB-GardenSpa"


            End If

            If GetBillcode = "Laundry" Then

                GetPrefix = "LAB-13-"
                PassMaintype = "OB-Laundry"

            End If

            If GetBillcode = "Main Bar" Then

                GetPrefix = "MBB-13-"
                PassMaintype = "OB-MainBar"

            End If

            If GetBillcode = "MiniBar" Then

                GetPrefix = "MIB-13-"
                PassMaintype = "OB-MiniBar"

            End If

            If GetBillcode = "Mishrapshop" Then

                GetPrefix = "MSB-13-"
                PassMaintype = "OB-Mishrapshop"

            End If

            If GetBillcode = "Office" Then

                GetPrefix = "OFB-13-"
                PassMaintype = "OB-Office"

            End If

            If GetBillcode = "Restaurant Bar" Then

                GetPrefix = "RBB-13-"
                PassMaintype = "OB-RestaurantBar"

            End If

            If GetBillcode = "Snookel Rental" Then

                GetPrefix = "SRB-13-"
                PassMaintype = "OB-SnookelRental"

            End If

            If GetBillcode = "Tel/Fax" Then

                GetPrefix = "TFB-13-"
                PassMaintype = "OB-TelFax"

            End If

            If GetBillcode = "Transfer" Then

                GetPrefix = "TRB-13-"
                PassMaintype = "OB-Transfer"

            End If


            If GetBillcode = "Day Use" Then

                GetPrefix = "DUB-13-"
                PassMaintype = "OB-DayUse"


            End If


            If GetBillcode = "Others" Then

                GetPrefix = "OTB-13-"
                PassMaintype = "OB-Others"


            End If



            If GetBillcode = "Water-Sports" Then

                GetPrefix = "WSP-14-"
                PassMaintype = "OB-WaterSports"


            End If

            If GetBillcode = "Beach-Bar" Then

                GetPrefix = "BEB-14-"
                PassMaintype = "OB-BeachBar"


            End If


            If GetBillcode = "GreenTax" Then

                GetPrefix = "GTX-15-"
                PassMaintype = "OB-GreenTax"


            End If



            'PubPrefixcode = GetPrefix
            'PubMaintype = GetBillcode

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNo", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = PassMaintype
            ' dcGetCode.Parameters.Add("@PREFIX1", SqlDbType.NVarChar).Value = GetPrefix
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output
            dcGetCode.ExecuteNonQuery()




            If (Not IsDBNull(dcGetCode.Parameters("@Currcode").Value)) Then

                GetOutletMasBillNo = dcGetCode.Parameters("@Currcode").Value


                Return GetOutletMasBillNo

            Else

                GetOutletMasBillNo = ""

                Return GetOutletMasBillNo

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()

        End Try

    End Function
    Private Sub InsertBillingKOTBOT()
        Dim cnumberPart As String = ""
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim dcInsertNewAccDetail As New SqlCommand
        Dim dcUpdateInventory As New SqlCommand

        Dim dateVal As DateTime = Convert.ToDateTime(dtDate.Text)
        Dim intNo As Integer = getNewKotBotNO()
        intNo = intNo + 1
        cnumberPart = intNo.ToString()
        'cnumberPart = cnumberPart.PadLeft(25, "0")







        ' Dim autoid As String = cmbType.Text.Trim().ToUpper() & dateVal.Year.ToString().Trim() & dateVal.Month.ToString().Trim() & dateVal.Day.ToString().Trim() & cnumberPart

        Dim autoid As String = GetKOTBOTNo(cmbType.Text.Trim())



        'KOT20121004
        Dim KotBotDetails As New DataTable

        Dim TransIns As SqlTransaction
        Dim IsTrans As Boolean = False

        Dim CurrentUser As String = CurrUser

        Try
            KotBotDetails.TableName = "KotBotDetails"
            KotBotDetails.Columns.Add("KotBotId")
            KotBotDetails.Columns.Add("ItemCode")
            KotBotDetails.Columns.Add("ItemName")
            KotBotDetails.Columns.Add("Qty")
            KotBotDetails.Columns.Add("UnitPrice")

            Conn.Open()
            TransIns = Conn.BeginTransaction
            IsTrans = True

            Dim DataRowCount As Integer = gvItemDets.DataRowCount
            Dim I As Integer
            For I = 0 To DataRowCount - 1
                Dim drDetail As DataRow = KotBotDetails.NewRow()
                Dim CellValNaME As String = gvItemDets.GetRowCellValue(I, "Itemname")
                Dim CellValItemCode As String = gvItemDets.GetRowCellValue(I, "Itemcode")


                Dim CellValQty As Int32 = gvItemDets.GetRowCellValue(I, "Itemqty")
                Dim CellValPrice As Double = Double.Parse(gvItemDets.GetRowCellValue(I, "Itemprice"))

                drDetail("KotBotId") = autoid
                drDetail("ItemCode") = CellValItemCode
                drDetail("ItemName") = CellValNaME
                drDetail("Qty") = CellValQty.ToString()
                drDetail("UnitPrice") = CellValPrice.ToString()
                KotBotDetails.Rows.Add(drDetail)

                dcInsertNewAccDetail = New SqlCommand("InsertBillingKOTBOTDetail_SP", Conn)
                dcInsertNewAccDetail.Transaction = TransIns

                dcInsertNewAccDetail.CommandType = CommandType.StoredProcedure
                dcInsertNewAccDetail.Parameters.Add("KOTBOTID ", SqlDbType.VarChar).Value = autoid.ToString()
                dcInsertNewAccDetail.Parameters.Add("ItemCode", SqlDbType.VarChar).Value = CellValItemCode
                dcInsertNewAccDetail.Parameters.Add("ItemName", SqlDbType.VarChar).Value = CellValNaME
                dcInsertNewAccDetail.Parameters.Add("Qty", SqlDbType.Int).Value = CellValQty
                dcInsertNewAccDetail.Parameters.Add("UnitPrice", SqlDbType.Money).Value = CellValPrice
                ' dcInsertNewAccDetail.Parameters.Add("CreatedDate", SqlDbType.DateTime).Value = dtDate.Text


                If CellValQty = 0 Then
                    Throw New Exception("Please Add A Valid Qty")
                    Exit Sub

                Else
                    dcInsertNewAccDetail.ExecuteNonQuery()

                End If


            Next
            'Conn.Close()

            'Conn.Open()
            dcInsertNewAcc = New SqlCommand("InsertBillingKOTBOT_SP", Conn)
            dcInsertNewAcc.Transaction = TransIns

            Dim Resno As String = txtResNo.Text

            If cmbType.Text.Trim = "BCOM" Then
                Resno = txtGuest.Text.Trim
            Else
                Resno = txtResNo.Text

            End If


            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("Id", SqlDbType.VarChar).Value = autoid.ToString()
            dcInsertNewAcc.Parameters.Add("Date", SqlDbType.DateTime).Value = DateTime.Now().ToString() 'dtDate.Text.Trim
            dcInsertNewAcc.Parameters.Add("RoomNo", SqlDbType.VarChar).Value = cmbRmNo.Text.Trim
            dcInsertNewAcc.Parameters.Add("BillGenerated", SqlDbType.Bit).Value = False
            dcInsertNewAcc.Parameters.Add("ReservationNo", SqlDbType.VarChar).Value = Resno.ToString
            dcInsertNewAcc.Parameters.Add("CreatedBy ", SqlDbType.VarChar).Value = CurrentUser
            dcInsertNewAcc.Parameters.Add("Type", SqlDbType.VarChar).Value = cmbType.Text
            dcInsertNewAcc.Parameters.Add("Department", SqlDbType.VarChar).Value = cmboutletID.Text
            dcInsertNewAcc.Parameters.Add("WaiterNo", SqlDbType.Int).Value = Convert.ToInt16(cmbWaiter.Text)
            dcInsertNewAcc.Parameters.Add("ManualBillno", SqlDbType.VarChar).Value = txtManualnos.Text
            dcInsertNewAcc.Parameters.Add("CreatedDate", SqlDbType.DateTime).Value = dtDate.Text

            dcInsertNewAcc.ExecuteNonQuery()
            'Conn.Close()



            '----- my sp should come here 'zuhri
            dcUpdateInventory = New SqlCommand("spBilledItemUpdate", Conn)
            dcUpdateInventory.CommandType = CommandType.StoredProcedure
            dcUpdateInventory.Transaction = TransIns

            With dcUpdateInventory.Parameters
                .Add("@BILLNO", SqlDbType.NVarChar).Value = autoid.ToString
                .Add("@ISSUCCESS", SqlDbType.Bit).Direction = ParameterDirection.Output
            End With
            'dcUpdateInventory.Parameters("@ISSUCESS").Direction = ParameterDirection.Output
            dcUpdateInventory.ExecuteNonQuery()

            Dim Result As Boolean = dcUpdateInventory.Parameters("@ISSUCCESS").Value

            If Not Result Then
                Throw New Exception("Update not successfull")
            End If
            '---------------------

            TransIns.Commit()
            IsTrans = False
            'Conn.Close()

            MessageBox.Show("Successfully saved", "Add KOT/BOT Billing Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim rmsDbDataSet As New DataSet
            rmsDbDataSet.DataSetName = "rmsDbDataSet"
            Dim KotBotMaster As New DataTable

            KotBotMaster.TableName = "KotBotMaster"
            KotBotMaster.Columns.Add("id")
            KotBotMaster.Columns.Add("Date")
            KotBotMaster.Columns.Add("RoomNo")
            KotBotMaster.Columns.Add("ReservationNo")
            KotBotMaster.Columns.Add("Type")
            KotBotMaster.Columns.Add("Department")
            KotBotMaster.Columns.Add("GuestName")
            KotBotMaster.Columns.Add("BillNo")

            Dim s As DataRow = KotBotMaster.NewRow()
            s("id") = autoid.ToString()
            s("Date") = DateTime.Now().ToString()
            s("RoomNo") = cmbRmNo.Text.Trim
            s("ReservationNo") = txtResNo.Text
            s("Type") = cmbType.Text
            s("Department") = txtOutlet.Text
            s("GuestName") = txtGuest.Text
            s("BillNo") = autoid.ToString()
            KotBotMaster.Rows.Add(s)

            rmsDbDataSet.Tables.Add(KotBotMaster)
            rmsDbDataSet.Tables.Add(KotBotDetails)
            ShowReportView(New Kot_Bot_Invoice, rmsDbDataSet)




            loadKotDataGrid()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            If IsTrans Then
                TransIns.Rollback()
            End If

            Conn.Dispose()
            dcInsertNewAcc.Dispose()
            dcInsertNewAccDetail.Dispose()
            dcUpdateInventory.Dispose()
        End Try



        TransIns.Dispose()

    End Sub
    Private Sub InsertBillingKOTBOTemp()

        Dim cnumberPart As String = ""
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim dcInsertNewAccDetail As New SqlCommand
        Dim dcUpdateInventory As New SqlCommand

        Dim dateVal As DateTime = Convert.ToDateTime(dtDate.Text)
        Dim intNo As Integer = getNewKotBotNO()
        intNo = intNo + 1
        cnumberPart = intNo.ToString()
        'cnumberPart = cnumberPart.PadLeft(25, "0")




        ' Dim autoid As String = cmbType.Text.Trim().ToUpper() & dateVal.Year.ToString().Trim() & dateVal.Month.ToString().Trim() & dateVal.Day.ToString().Trim() & cnumberPart

        ' Dim autoid As String = GetKOTBOTNo(cmbType.Text.Trim())
        Dim autoid As String = System.Guid.NewGuid().ToString()


        'KOT20121004
        Dim KotBotDetails As New DataTable

        Dim TransIns As SqlTransaction
        Dim IsTrans As Boolean = False

        Dim CurrentUser As String = CurrUser

        Try
            KotBotDetails.TableName = "KotBotDetails"
            KotBotDetails.Columns.Add("KotBotId")
            KotBotDetails.Columns.Add("ItemCode")
            KotBotDetails.Columns.Add("ItemName")
            KotBotDetails.Columns.Add("Qty")
            KotBotDetails.Columns.Add("UnitPrice")

            Conn.Open()
            TransIns = Conn.BeginTransaction
            IsTrans = True

            Dim DataRowCount As Integer = gvItemDets.DataRowCount
            Dim I As Integer
            For I = 0 To DataRowCount - 1
                Dim drDetail As DataRow = KotBotDetails.NewRow()
                Dim CellValNaME As String = gvItemDets.GetRowCellValue(I, "Itemname")
                Dim CellValItemCode As String = gvItemDets.GetRowCellValue(I, "Itemcode")


                Dim CellValQty As Int32 = gvItemDets.GetRowCellValue(I, "Itemqty")
                Dim CellValPrice As Double = Double.Parse(gvItemDets.GetRowCellValue(I, "Itemprice"))

                drDetail("KotBotId") = autoid
                drDetail("ItemCode") = CellValItemCode
                drDetail("ItemName") = CellValNaME
                drDetail("Qty") = CellValQty.ToString()
                drDetail("UnitPrice") = CellValPrice.ToString()
                KotBotDetails.Rows.Add(drDetail)

                dcInsertNewAccDetail = New SqlCommand("InsertBillingKOTBOTDetailTemp_SP", Conn)
                dcInsertNewAccDetail.Transaction = TransIns

                dcInsertNewAccDetail.CommandType = CommandType.StoredProcedure
                dcInsertNewAccDetail.Parameters.Add("KOTBOTID ", SqlDbType.VarChar).Value = autoid.ToString()
                dcInsertNewAccDetail.Parameters.Add("ItemCode", SqlDbType.VarChar).Value = CellValItemCode
                dcInsertNewAccDetail.Parameters.Add("ItemName", SqlDbType.VarChar).Value = CellValNaME
                dcInsertNewAccDetail.Parameters.Add("Qty", SqlDbType.Int).Value = CellValQty
                dcInsertNewAccDetail.Parameters.Add("UnitPrice", SqlDbType.Money).Value = CellValPrice
                ' dcInsertNewAccDetail.Parameters.Add("CreatedDate", SqlDbType.DateTime).Value = dtDate.Text


                If CellValQty = 0 Then
                    Throw New Exception("Please Add A Valid Qty")
                    Exit Sub

                Else
                    dcInsertNewAccDetail.ExecuteNonQuery()

                End If


            Next
            'Conn.Close()

            'Conn.Open()





            dcInsertNewAcc = New SqlCommand("InsertBillingKOTBOT_Temp_SP", Conn)
            dcInsertNewAcc.Transaction = TransIns

            Dim Resno As String = txtResNo.Text

            If cmbType.Text.Trim = "BCOM" Then
                Resno = txtGuest.Text.Trim
            Else
                Resno = txtResNo.Text

            End If


            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("Id", SqlDbType.VarChar).Value = autoid.ToString()
            dcInsertNewAcc.Parameters.Add("Date", SqlDbType.DateTime).Value = DateTime.Now().ToString() 'dtDate.Text.Trim
            dcInsertNewAcc.Parameters.Add("RoomNo", SqlDbType.VarChar).Value = cmbRmNo.Text.Trim
            dcInsertNewAcc.Parameters.Add("BillGenerated", SqlDbType.Bit).Value = False
            dcInsertNewAcc.Parameters.Add("ReservationNo", SqlDbType.VarChar).Value = Resno.ToString
            dcInsertNewAcc.Parameters.Add("CreatedBy ", SqlDbType.VarChar).Value = CurrentUser
            dcInsertNewAcc.Parameters.Add("Type", SqlDbType.VarChar).Value = cmbType.Text
            dcInsertNewAcc.Parameters.Add("Department", SqlDbType.VarChar).Value = cmboutletID.Text
            dcInsertNewAcc.Parameters.Add("WaiterNo", SqlDbType.Int).Value = Convert.ToInt16(cmbWaiter.Text)
            dcInsertNewAcc.Parameters.Add("ManualBillno", SqlDbType.VarChar).Value = txtManualnos.Text
            dcInsertNewAcc.Parameters.Add("CreatedDate", SqlDbType.DateTime).Value = dtDate.Text

            dcInsertNewAcc.ExecuteNonQuery()
            'Conn.Close()



            '----- my sp should come here 'zuhri
            'dcUpdateInventory = New SqlCommand("spBilledItemUpdate", Conn)
            'dcUpdateInventory.CommandType = CommandType.StoredProcedure
            'dcUpdateInventory.Transaction = TransIns

            'With dcUpdateInventory.Parameters
            '    .Add("@BILLNO", SqlDbType.NVarChar).Value = autoid.ToString
            '    .Add("@ISSUCCESS", SqlDbType.Bit).Direction = ParameterDirection.Output
            'End With
            ''dcUpdateInventory.Parameters("@ISSUCESS").Direction = ParameterDirection.Output
            'dcUpdateInventory.ExecuteNonQuery()

            'Dim Result As Boolean = dcUpdateInventory.Parameters("@ISSUCCESS").Value

            'If Not Result Then
            '    Throw New Exception("Update not successfull")
            'End If
            '---------------------

            TransIns.Commit()
            IsTrans = False
            Conn.Close()

            MessageBox.Show("Successfully saved", "Add KOT/BOT Billing Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Dim rmsDbDataSet As New DataSet
            'rmsDbDataSet.DataSetName = "rmsDbDataSet"
            'Dim KotBotMaster As New DataTable

            'KotBotMaster.TableName = "KotBotMaster"
            'KotBotMaster.Columns.Add("id")
            'KotBotMaster.Columns.Add("Date")
            'KotBotMaster.Columns.Add("RoomNo")
            'KotBotMaster.Columns.Add("ReservationNo")
            'KotBotMaster.Columns.Add("Type")
            'KotBotMaster.Columns.Add("Department")
            'KotBotMaster.Columns.Add("GuestName")
            'KotBotMaster.Columns.Add("BillNo")

            'Dim s As DataRow = KotBotMaster.NewRow()
            's("id") = autoid.ToString()
            's("Date") = DateTime.Now().ToString()
            's("RoomNo") = cmbRmNo.Text.Trim
            's("ReservationNo") = txtResNo.Text
            's("Type") = cmbType.Text
            's("Department") = txtOutlet.Text
            's("GuestName") = txtGuest.Text
            's("BillNo") = autoid.ToString()
            'KotBotMaster.Rows.Add(s)

            'rmsDbDataSet.Tables.Add(KotBotMaster)
            'rmsDbDataSet.Tables.Add(KotBotDetails)
            'ShowReportView(New Kot_Bot_Invoice, rmsDbDataSet)




            ' loadKotDataGrid()

            loadPendingKotDataGrid()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            If IsTrans Then
                TransIns.Rollback()
            End If

            Conn.Dispose()
            dcInsertNewAcc.Dispose()
            dcInsertNewAccDetail.Dispose()
            dcUpdateInventory.Dispose()
        End Try



        TransIns.Dispose()

    End Sub
    Private Sub InsertBillingKOTBOTempAlreadyAdd()

        Dim cnumberPart As String = ""
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim dcInsertNewAccDetail As New SqlCommand
        Dim dcUpdateInventory As New SqlCommand

        Dim dateVal As DateTime = Convert.ToDateTime(dtDate.Text)
        Dim intNo As Integer = getNewKotBotNO()
        intNo = intNo + 1
        cnumberPart = intNo.ToString()
        'cnumberPart = cnumberPart.PadLeft(25, "0")




        ' Dim autoid As String = cmbType.Text.Trim().ToUpper() & dateVal.Year.ToString().Trim() & dateVal.Month.ToString().Trim() & dateVal.Day.ToString().Trim() & cnumberPart

        ' Dim autoid As String = GetKOTBOTNo(cmbType.Text.Trim())



        'KOT20121004
        Dim KotBotDetails As New DataTable

        Dim TransIns As SqlTransaction
        Dim IsTrans As Boolean = False

        Dim CurrentUser As String = CurrUser

        Try


            If PubTempBillCheck = 1 Then


                DelTempDetailKOTBOT()



            End If


            KotBotDetails.TableName = "KotBotDetails"
            KotBotDetails.Columns.Add("KotBotId")
            KotBotDetails.Columns.Add("ItemCode")
            KotBotDetails.Columns.Add("ItemName")
            KotBotDetails.Columns.Add("Qty")
            KotBotDetails.Columns.Add("UnitPrice")

            Conn.Open()
            TransIns = Conn.BeginTransaction
            IsTrans = True

            Dim DataRowCount As Integer = gvItemDets.DataRowCount
            Dim I As Integer
            For I = 0 To DataRowCount - 1
                Dim drDetail As DataRow = KotBotDetails.NewRow()
                Dim CellValNaME As String = gvItemDets.GetRowCellValue(I, "Itemname")
                Dim CellValItemCode As String = gvItemDets.GetRowCellValue(I, "Itemcode")


                Dim CellValQty As Int32 = gvItemDets.GetRowCellValue(I, "Itemqty")
                Dim CellValPrice As Double = Double.Parse(gvItemDets.GetRowCellValue(I, "Itemprice"))

                drDetail("KotBotId") = PublicTempOutletBillNo
                drDetail("ItemCode") = CellValItemCode
                drDetail("ItemName") = CellValNaME
                drDetail("Qty") = CellValQty.ToString()
                drDetail("UnitPrice") = CellValPrice.ToString()
                KotBotDetails.Rows.Add(drDetail)

                dcInsertNewAccDetail = New SqlCommand("InsertBillingKOTBOTDetailTemp_SP", Conn)
                dcInsertNewAccDetail.Transaction = TransIns

                dcInsertNewAccDetail.CommandType = CommandType.StoredProcedure
                dcInsertNewAccDetail.Parameters.Add("KOTBOTID ", SqlDbType.VarChar).Value = PublicTempOutletBillNo
                dcInsertNewAccDetail.Parameters.Add("ItemCode", SqlDbType.VarChar).Value = CellValItemCode
                dcInsertNewAccDetail.Parameters.Add("ItemName", SqlDbType.VarChar).Value = CellValNaME
                dcInsertNewAccDetail.Parameters.Add("Qty", SqlDbType.Int).Value = CellValQty
                dcInsertNewAccDetail.Parameters.Add("UnitPrice", SqlDbType.Money).Value = CellValPrice
                ' dcInsertNewAccDetail.Parameters.Add("CreatedDate", SqlDbType.DateTime).Value = dtDate.Text


                If CellValQty = 0 Then
                    Throw New Exception("Please Add A Valid Qty")
                    Exit Sub

                Else
                    dcInsertNewAccDetail.ExecuteNonQuery()

                End If


            Next
            'Conn.Close()

            'Conn.Open()





            'dcInsertNewAcc = New SqlCommand("InsertBillingKOTBOT_Temp_SP", Conn)
            'dcInsertNewAcc.Transaction = TransIns

            'Dim Resno As String = txtResNo.Text

            'If cmbType.Text.Trim = "BCOM" Then
            '    Resno = txtGuest.Text.Trim
            'Else
            '    Resno = txtResNo.Text

            'End If


            'dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            'dcInsertNewAcc.Parameters.Add("Id", SqlDbType.VarChar).Value = autoid.ToString()
            'dcInsertNewAcc.Parameters.Add("Date", SqlDbType.DateTime).Value = DateTime.Now().ToString() 'dtDate.Text.Trim
            'dcInsertNewAcc.Parameters.Add("RoomNo", SqlDbType.VarChar).Value = cmbRmNo.Text.Trim
            'dcInsertNewAcc.Parameters.Add("BillGenerated", SqlDbType.Bit).Value = False
            'dcInsertNewAcc.Parameters.Add("ReservationNo", SqlDbType.VarChar).Value = Resno.ToString
            'dcInsertNewAcc.Parameters.Add("CreatedBy ", SqlDbType.VarChar).Value = CurrentUser
            'dcInsertNewAcc.Parameters.Add("Type", SqlDbType.VarChar).Value = cmbType.Text
            'dcInsertNewAcc.Parameters.Add("Department", SqlDbType.VarChar).Value = cmboutletID.Text
            'dcInsertNewAcc.Parameters.Add("WaiterNo", SqlDbType.Int).Value = Convert.ToInt16(cmbWaiter.Text)
            'dcInsertNewAcc.Parameters.Add("ManualBillno", SqlDbType.VarChar).Value = txtManualnos.Text
            'dcInsertNewAcc.Parameters.Add("CreatedDate", SqlDbType.DateTime).Value = dtDate.Text

            'dcInsertNewAcc.ExecuteNonQuery()
            'Conn.Close()



            '----- my sp should come here 'zuhri
            'dcUpdateInventory = New SqlCommand("spBilledItemUpdate", Conn)
            'dcUpdateInventory.CommandType = CommandType.StoredProcedure
            'dcUpdateInventory.Transaction = TransIns

            'With dcUpdateInventory.Parameters
            '    .Add("@BILLNO", SqlDbType.NVarChar).Value = autoid.ToString
            '    .Add("@ISSUCCESS", SqlDbType.Bit).Direction = ParameterDirection.Output
            'End With
            ''dcUpdateInventory.Parameters("@ISSUCESS").Direction = ParameterDirection.Output
            'dcUpdateInventory.ExecuteNonQuery()

            'Dim Result As Boolean = dcUpdateInventory.Parameters("@ISSUCCESS").Value

            'If Not Result Then
            '    Throw New Exception("Update not successfull")
            'End If
            '---------------------

            TransIns.Commit()
            IsTrans = False
            Conn.Close()

            MessageBox.Show("Successfully saved", "Add KOT/BOT Billing Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Dim rmsDbDataSet As New DataSet
            'rmsDbDataSet.DataSetName = "rmsDbDataSet"
            'Dim KotBotMaster As New DataTable

            'KotBotMaster.TableName = "KotBotMaster"
            'KotBotMaster.Columns.Add("id")
            'KotBotMaster.Columns.Add("Date")
            'KotBotMaster.Columns.Add("RoomNo")
            'KotBotMaster.Columns.Add("ReservationNo")
            'KotBotMaster.Columns.Add("Type")
            'KotBotMaster.Columns.Add("Department")
            'KotBotMaster.Columns.Add("GuestName")
            'KotBotMaster.Columns.Add("BillNo")

            'Dim s As DataRow = KotBotMaster.NewRow()
            's("id") = autoid.ToString()
            's("Date") = DateTime.Now().ToString()
            's("RoomNo") = cmbRmNo.Text.Trim
            's("ReservationNo") = txtResNo.Text
            's("Type") = cmbType.Text
            's("Department") = txtOutlet.Text
            's("GuestName") = txtGuest.Text
            's("BillNo") = autoid.ToString()
            'KotBotMaster.Rows.Add(s)

            'rmsDbDataSet.Tables.Add(KotBotMaster)
            'rmsDbDataSet.Tables.Add(KotBotDetails)
            'ShowReportView(New Kot_Bot_Invoice, rmsDbDataSet)




            ' loadKotDataGrid()

            loadPendingKotDataGrid()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            If IsTrans Then
                TransIns.Rollback()
            End If

            Conn.Dispose()
            dcInsertNewAcc.Dispose()
            dcInsertNewAccDetail.Dispose()
            dcUpdateInventory.Dispose()
        End Try



        TransIns.Dispose()


    End Sub
    Private Sub DelTempDetailKOTBOT()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand



        dcInsertNewAcc = New SqlCommand("delete from KotBotDetailTemp where KOTBOTID=@Billno", Conn) With {.CommandType = CommandType.Text}
        dcInsertNewAcc.Parameters.Add("@Billno", SqlDbType.VarChar).Value = PublicTempOutletBillNo

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Private Sub UpdateManualBillNo(ByVal passManualBill As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Dim getpassManualBill As String = passManualBill

        dcInsertNewAcc = New SqlCommand("update KotBotMasterTemp set ManualBillno=@ManualBillno where Id=@Billno", Conn) With {.CommandType = CommandType.Text}
        dcInsertNewAcc.Parameters.Add("@Billno", SqlDbType.VarChar).Value = PublicTempOutletBillNo
        dcInsertNewAcc.Parameters.Add("@ManualBillno", SqlDbType.VarChar).Value = getpassManualBill

        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Private Sub DeleteKOTBOTempMaster()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand



        dcInsertNewAcc = New SqlCommand("delete from KotBotMasterTemp where Id=@Id", Conn) With {.CommandType = CommandType.Text}
        dcInsertNewAcc.Parameters.Add("@Id", SqlDbType.VarChar).Value = PublicTempOutletBillNo


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
    End Sub
    Private Sub DeleteKOTBOTempMasterDetail()

        Dim Conn As New SqlConnection(ConnString)
        Dim dcInsertNewAcc As New SqlCommand

        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand



        dcInsertNewAcc = New SqlCommand("delete  from KotBotDetailTemp where KOTBOTID=@Id", Conn) With {.CommandType = CommandType.Text}
        dcInsertNewAcc.Parameters.Add("@Id", SqlDbType.VarChar).Value = PublicTempOutletBillNo


        Conn.Open()
        dcInsertNewAcc.ExecuteNonQuery()
        Conn.Close()
    End Sub

    Private Sub ShowReportView(ByVal reportClass As CrystalDecisions.CrystalReports.Engine.ReportClass, ByVal dataSet As System.Data.DataSet)
        Dim frmReport As New frmViewReport(reportClass, dataSet)
        frmReport.Show()
    End Sub
    Function DSCheckAddTempBillNo() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            dcSearch = New SqlCommand("select * from dbo.[KotBotMasterTemp] where Id=@Id", Conn)
            dcSearch.Parameters.Add("@Id", SqlDbType.VarChar).Value = PublicTempOutletBillNo


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            'Dim count As Integer = dsMain.Tables(0).Rows.Count
            'If count > 0 Then
            DSCheckAddTempBillNo = dsMain


            'End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
            Return Nothing
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Function
    Function DSCheckInsertBillingTemp() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            Dim RefBillNo As String = "" 'txtRefBillNo.Text.Trim

            dcSearch = New SqlCommand("select * from dbo.[KotBotMaster] where id=@RefBillNo", Conn)
            dcSearch.Parameters.Add("@RefBillNo", SqlDbType.VarChar).Value = RefBillNo

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckInsertBillingTemp = dsMain
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
            Return Nothing
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Function
    Private Sub LoadDepartmentID()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        '   Dim dsDepartments As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            '  dcSearch = New SqlCommand("select DepartmentID from [DepartmentMaster] order by DepartmentID", Conn)
            dcSearch = New SqlCommand("SELECT [DepartmentID],[Description] FROM [DepartmentMaster] order by DepartmentID", Conn)


            ' dcSearch = New SqlCommand("SELECT [DepartmentID],[Description] FROM [DepartmentMaster]  where [DepartmentID]='Coffee Shop' OR [DepartmentID]='Main Bar' OR  [DepartmentID]='Restaurant Bar' order by DepartmentID", Conn)



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsDepartments)

            Dim Dscount As Integer = dsDepartments.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)
                cmboutletID.Properties.Items.Add(dsDepartments.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While

            DscountTest = 0
            While (DscountTest < Dscount)
                cmboutletIDDp.Properties.Items.Add(dsDepartments.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While


            DscountTest = 0
            While (DscountTest < Dscount)
                cmbBilllist.Properties.Items.Add(dsDepartments.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While

            cmboutletIDDp.SelectedIndex = 0
            cmboutletID.SelectedIndex = 0
            cmbBilllist.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            '  dsMain.Dispose()
        End Try
    End Sub

    Private Sub LoadDepartmentIDbyKOTBOT(ByVal Kbtype As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        '   Dim dsDepartments As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getKbtype As String = Kbtype

            'cmboutletID.Text = ""


            cmboutletID.EditValue = ""


            cmboutletID.Properties.Items.Clear()

            cmboutletID.Refresh()

           

            Conn.Open()


            'If getKbtype = "KOT" Then

            'dcSearch = New SqlCommand("SELECT [DepartmentID],[Description] FROM [DepartmentMaster] where [DepartmentID]='Coffee Shop' OR [DepartmentID]='Main Bar' OR  [DepartmentID]='Restaurant Bar' order by DepartmentID", Conn)

            'ElseIf getKbtype = "BOT" Then

            '    dcSearch = New SqlCommand("SELECT [DepartmentID],[Description] FROM [DepartmentMaster] where [DepartmentID]='Coffee Shop' OR [DepartmentID]='Main Bar' OR  [DepartmentID]='Restaurant Bar' order by DepartmentID", Conn)

            'ElseIf getKbtype = "OOT" Then

            '    dcSearch = New SqlCommand("SELECT [DepartmentID],[Description] FROM [DepartmentMaster] where [DepartmentID]='MiniBar' OR [DepartmentID]='GardenSpa' OR  [DepartmentID]='Divingschool' OR [DepartmentID]='Excursions' OR [DepartmentID]='mishrapshop' OR [DepartmentID]='BedTax' OR [DepartmentID]='B/L' OR [DepartmentID]='Laundry' OR [DepartmentID]='Office' OR [DepartmentID]='Transfer' OR [DepartmentID]='Tel/Fax' OR [DepartmentID]='Snookel Rental' order by DepartmentID ", Conn)

            'ElseIf getKbtype = "BCOM" Then

            ' dcSearch = New SqlCommand("SELECT [DepartmentID],[Description] FROM [DepartmentMaster] where [DepartmentID]='MiniBar' OR [DepartmentID]='GardenSpa' OR  [DepartmentID]='Divingschool' OR [DepartmentID]='Excursions' OR [DepartmentID]='mishrapshop' OR [DepartmentID]='BedTax' OR [DepartmentID]='B/L' OR [DepartmentID]='Laundry' OR [DepartmentID]='Office' OR [DepartmentID]='Transfer' OR [DepartmentID]='Tel/Fax' OR [DepartmentID]='Snookel Rental' OR [DepartmentID]='Coffee Shop' OR [DepartmentID]='Main Bar' OR  [DepartmentID]='Restaurant Bar' order by DepartmentID ", Conn)

            'Else

            dcSearch = New SqlCommand("SELECT [DepartmentID],[Description] FROM [DepartmentMaster]  order by DepartmentID", Conn)


            'End If



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsDepartments)

            Dim Dscount As Integer = dsDepartments.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)
                cmboutletID.Properties.Items.Add(dsDepartments.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While


            cmboutletID.Properties.Items.Add("")

            'DscountTest = 0
            'While (DscountTest < Dscount)
            '    cmboutletIDDp.Properties.Items.Add(dsDepartments.Tables(0).Rows(DscountTest)(0).ToString())
            '    DscountTest = DscountTest + 1
            'End While

            cmboutletIDDp.SelectedIndex = 0
            cmboutletID.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            '  dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadDepartment(ByVal DepartmentID As String, ByVal combo As Int32)
        Try
            Dim PassDepartmentID As String = DepartmentID
            If (Not dsDepartments Is Nothing) Then
                Dim dataRowList() As DataRow
                dataRowList = dsDepartments.Tables(0).Select(String.Format("DepartmentID ='{0}'", PassDepartmentID))
                If (Not dataRowList Is Nothing) Then
                    If (dataRowList.Length > 0) Then
                        If (combo = 1) Then
                            txtOutlet.Text = dataRowList(0)("Description").ToString()
                        ElseIf (combo = 2) Then
                            txtOutletName.Text = dataRowList(0)("Description").ToString()
                        ElseIf (combo = 3) Then
                            txtOutletDp.Text = dataRowList(0)("Description").ToString()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        End Try
    End Sub
    Private Sub LoadRoomNo()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            'dcSearch = New SqlCommand("select Roomno from [Rooms.Master] order by Roomno", Conn)
            dcSearch = New SqlCommand("select [RoomNo] from [Room.CurrentStatus] order by [RoomNo] ", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)
                cmbRmNo.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While

            DscountTest = 0
            While (DscountTest < Dscount)
                ComboBoxEditRoom.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While

            DscountTest = 0
            While (DscountTest < Dscount)
                cmbRoombilllist.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While

            'DscountTest = 0
            'While (DscountTest < Dscount)
            '    ComboRoom.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
            '    DscountTest = DscountTest + 1
            'End While

            'ComboRoom.SelectedIndex = 0
            'ComboBoxRoomNo.SelectedIndex = 0
            cmbRmNo.SelectedIndex = 0
            cmbRoombilllist.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub LoadDiscounts()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter

        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT [ID],[DisCountType] ,[Amount],[Name] FROM [KotBotDiscountType] order by [Name]", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(Discountds)

            Dim Dscount As Integer = Discountds.Tables(0).Rows.Count
            Dim DscountTest As Integer
            ComboBoxEditDiscount.Properties.Items.Add("None")
            While (DscountTest < Dscount)
                ComboBoxEditDiscount.Properties.Items.Add(Discountds.Tables(0).Rows(DscountTest)("Name").ToString())
                DscountTest = DscountTest + 1
            End While
            ComboBoxEditDiscount.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
        End Try
    End Sub

    ' 
    'Private Sub loadCurrency()
    '    Dim Conn As New SqlConnection(ConnString)
    '    Dim daMain As New SqlDataAdapter
    '    Dim dcSearch As New SqlCommand
    '    Try
    '        Conn.Open()
    '        dcSearch = New SqlCommand("SELECT [Currency],[CurrencuSymbol],[Country] FROM [dbo].[CurrencyType]", Conn)

    '        daMain = New SqlDataAdapter()
    '        daMain.SelectCommand = dcSearch
    '        daMain.Fill(dsCurrency)

    '        Dim Dscount As Integer = dsCurrency.Tables(0).Rows.Count
    '        Dim DscountTest As Integer = 0


    '        While (DscountTest < Dscount)
    '            ComboBoxEditCurrency.Properties.Items.Add(dsCurrency.Tables(0).Rows(DscountTest)(0).ToString())
    '            DscountTest = DscountTest + 1
    '        End While
    '        ComboBoxEditCurrency.SelectedIndex = 0
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
    '    Finally
    '        Conn.Dispose()
    '        daMain.Dispose()
    '    End Try
    'End Sub

    Private Sub loadPayMethod()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        '      Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT [PaymentTypeCode],[Description],[NumberRequired] FROM [dbo].[PaymentType]", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsPayMethod)

            Dim Dscount As Integer = dsPayMethod.Tables(0).Rows.Count
            Dim DscountTest As Integer
            ComboBoxPayMethod.Properties.Items.Clear()
            While (DscountTest < Dscount)
                ComboBoxPayMethod.Properties.Items.Add(dsPayMethod.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While
            ComboBoxPayMethod.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            '  dsMain.Dispose()
        End Try
    End Sub

    Private Function IsNonInvItem(ByVal Itemcode As String) As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim daGet As New SqlDataAdapter("select IsNonInv from ItemMaster where itemcode ='" & Itemcode & "'", Conn)
        Dim dsGet As New DataSet

        Try

            daGet.Fill(dsGet)

            Return dsGet.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            daGet.Dispose()
            dsGet.Dispose()
        End Try

    End Function


    Private Sub cmboutletID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmboutletID.SelectedIndexChanged
        LoadDepartment(cmboutletID.Text, 1)
        LoadCombos(cmboutletID.Text)

        If cmboutletID.Text = "Mishrapshop" Or cmboutletID.Text = "Laundry" Or cmboutletID.Text = "Snookel Rental" Or cmboutletID.Text = "Office" Or cmboutletID.Text = "B/L" Then
            gvItemDets.Columns("Itemprice").OptionsColumn.AllowEdit = True
        Else
            gvItemDets.Columns("Itemprice").OptionsColumn.AllowEdit = False
        End If
    End Sub

    Private Sub gvKOTBOTBilling_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvKOTBOTBilling.DoubleClick
        ShowFields(gvKOTBOTBilling.GetFocusedRowCellValue("KOTBOTNo"))
    End Sub

    'Private Sub gvItemDets_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvItemDets.CellValueChanged
    '    If e.Column.FieldName = "Itemcode" And String.IsNullOrEmpty(Itemcode) Then
    '        If (Not IsDBNull(e.Value)) Then
    '            Dim RefBillNo As String = e.Value
    '            frmItemSelection.frmHandle = Me
    '            frmItemSelection.InvLocation = cmboutletID.Text
    '            Me.frmGridRow = e.RowHandle
    '            '  frmItemSelection.Show()
    '            frmItemSelection.ShowDialog()
    '            'Me.Enabled = False
    '        End If
    '    End If


    '    If e.Column.FieldName = "Itemcode" Then '  "Itemqty" Then
    '        If IsDBNull(e.Value) Or IsDBNull(gvItemDets.GetRowCellValue(e.RowHandle, "Itemcode")) Then
    '            Exit Sub
    '        End If
    '        If (Not IsDBNull(e.Value)) And Not IsNonInvItem(gvItemDets.GetRowCellValue(e.RowHandle, "Itemcode")) Then
    '            If e.Value > gvItemDets.GetFocusedRowCellValue("TotQty") And String.IsNullOrEmpty(Itemcode) Then
    '                MsgBox("You can't bill more than stock", MsgBoxStyle.Critical, ErrTitle)
    '                gvItemDets.SetRowCellValue(gvItemDets.FocusedRowHandle, "Itemqty", 0)
    '            End If
    '        End If
    '    End If

    '    'If e.Column.FieldName = "Itemcode" Then
    '    '    ' And String.IsNullOrEmpty(Itemcode) Then
    '    '    If (Not IsDBNull(e.Value)) Then
    '    '        Dim RefBillNo As String = e.Value
    '    '        frmItemSelection.frmHandle = Me
    '    '        frmItemSelection.InvLocation = cmboutletID.Text
    '    '        Me.frmGridRow = e.RowHandle
    '    '        '  frmItemSelection.Show()
    '    '        frmItemSelection.ShowDialog()
    '    '        'Me.Enabled = False
    '    '    End If
    '    'ElseIf e.Column.FieldName = "Itemcode" Then '  "Itemqty" Then
    '    '    If IsDBNull(e.Value) Or IsDBNull(gvItemDets.GetRowCellValue(e.RowHandle, "Itemcode")) Then
    '    '        Exit Sub
    '    '    End If
    '    '    If (Not IsDBNull(e.Value)) And Not IsNonInvItem(gvItemDets.GetRowCellValue(e.RowHandle, "Itemcode")) Then
    '    '        If e.Value > gvItemDets.GetFocusedRowCellValue("TotQty") And String.IsNullOrEmpty(Itemcode) Then
    '    '            MsgBox("You can't bill more than stock", MsgBoxStyle.Critical, ErrTitle)
    '    '            gvItemDets.SetRowCellValue(gvItemDets.FocusedRowHandle, "Itemqty", 0)
    '    '        End If
    '    '    End If
    '    'End If
    'End Sub

    Private Sub gvItemDets_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvItemDets.CellValueChanged
        If e.Column.FieldName = "Itemcode" And String.IsNullOrEmpty(Itemcode) Then
            If (Not IsDBNull(e.Value)) Then
                Dim RefBillNo As String = e.Value
                frmItemSelection.frmHandle = Me
                frmItemSelection.InvLocation = cmboutletID.Text
                'frmItemSelection.PubMP = "AI"
                Me.frmGridRow = e.RowHandle
                frmItemSelection.Show()

                frmItemSelection.txtsearch.Focus()


                ' PubMPAI = "AI"

                'Me.Enabled = False
            End If







        ElseIf e.Column.FieldName = "Itemqty" Then
            If IsDBNull(e.Value) Or IsDBNull(gvItemDets.GetRowCellValue(e.RowHandle, "Itemcode")) Then
                Exit Sub
            End If

            Dim getTotalQty As Decimal = TotQty

            If (Not IsDBNull(e.Value)) And Not IsNonInvItem(gvItemDets.GetRowCellValue(e.RowHandle, "Itemcode")) Then

                'If e.Value > gvItemDets.GetFocusedRowCellValue("TotQty") And String.IsNullOrEmpty(Itemcode) Then
                If e.Value > getTotalQty And String.IsNullOrEmpty(Itemcode) Then

                    MsgBox("You can't bill more than stock", MsgBoxStyle.Critical, ErrTitle)
                    gvItemDets.SetRowCellValue(gvItemDets.FocusedRowHandle, "Itemqty", 0)

                    SimpleButton1.Enabled = False
                    btnBilling.Enabled = False

                    Exit Sub

                Else

                    SimpleButton1.Enabled = True
                    btnBilling.Enabled = True
                    'ElseIf e.Value = 0 Then
                    '    MsgBox("You can't add zero stock", MsgBoxStyle.Critical, ErrTitle)
                    '    gvItemDets.SetRowCellValue(gvItemDets.FocusedRowHandle, "Itemqty", 1)
                    '    Exit Sub
                End If

                'If e.Value = 0 Then
                '    MsgBox("You can't add zero stock", MsgBoxStyle.Critical, ErrTitle)
                '    gvItemDets.SetRowCellValue(gvItemDets.FocusedRowHandle, "Itemqty", 1)
                '    Exit Sub
                'End If

            End If
        End If



        '  gridItemDets.Columns(0).ReadOnly = True






    End Sub

    Private Sub gvItemDets_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvItemDets.InitNewRow
        If gvItemDets.RowCount > 0 Then
            If gvItemDets.GetRowCellValue(gvItemDets.RowCount - 1, "Itemcode") = "" Then
                Exit Sub
            End If

            gvItemDets.SetRowCellValue(e.RowHandle, "Itemcode", Guid.NewGuid)
        End If
    End Sub

    Private Sub cmbRmNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRmNo.SelectedIndexChanged

        If cmbType.Text.Trim = "BCOM" Then

            txtResNo.Text = "STAFF"
            txtGuest.Text = ""
            gvItemDets.OptionsBehavior.Editable = True

        Else

            txtResNo.Text = ""
            txtGuest.Text = ""
            LoadUserData(cmbRmNo.Text, 1)
            'gridItemDets.Enabled = False
            If (String.IsNullOrEmpty(txtGuest.Text.Trim())) Then
                MsgBox("Master guest for this room is not define", MsgBoxStyle.Critical, "Error..")

                'gridItemDets.Enabled = False
                gvItemDets.OptionsBehavior.Editable = False

                'ElseIf (String.IsNullOrEmpty(txtManualnos.Text.Trim())) Then

                '    MsgBox("Enter Manual KOT/BOT No", MsgBoxStyle.Critical, "Error..")

                '    'gridItemDets.Enabled = False
                '    gvItemDets.OptionsBehavior.Editable = False

            Else
                'gridItemDets.Enabled = True
                gvItemDets.OptionsBehavior.Editable = True
            End If

        End If


      
    End Sub

    Private Sub LoadUserData(ByVal RoomNo As String, ByVal tab As Int16)
        'Throw New NotImplementedException
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsGuest As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            'dcSearch = New SqlCommand("select c.ReservationNo,c.BillingGuest as 'GuestName' from [Guest.RegisterMaster] R inner join [Room.CurrentStatus] c on c.ReservationNo=R.ReservationNo where R.IsMasterRecord=1 and (c.IsBillBlock=0 or c.IsBillBlock=null) and c.RoomNo='" & RoomNo & "'", Conn)
            dcSearch = New SqlCommand("select c.ReservationNo,c.BillingGuest as 'GuestName' from [GuestRegistration] R inner join [Room.CurrentStatus] c on c.ReservationNo=R.ReservationNo where R.IsBillingGuest=1 and (c.IsBillBlock=0 or c.IsBillBlock=null) and c.RoomNo='" & RoomNo & "'", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsGuest)
            If (Not dsGuest Is Nothing) Then
                If (dsGuest.Tables(0).Rows.Count > 0) Then
                    If (tab = 1) Then
                        If (IsDBNull(dsGuest.Tables(0).Rows(0)("GuestName"))) Then
                            txtGuest.Text = ""
                        Else
                            txtGuest.Text = dsGuest.Tables(0).Rows(0)("GuestName")
                        End If

                        If (IsDBNull(dsGuest.Tables(0).Rows(0)("ReservationNo"))) Then
                            txtResNo.Text = ""
                        Else
                            txtResNo.Text = dsGuest.Tables(0).Rows(0)("ReservationNo")
                        End If
                    ElseIf (tab = 4) Then
                        '  
                        If (IsDBNull(dsGuest.Tables(0).Rows(0)("GuestName"))) Then
                            TextEditGuest.Text = ""
                        Else
                            TextEditGuest.Text = dsGuest.Tables(0).Rows(0)("GuestName")
                        End If
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

    Sub LoadCombos(ByVal depNo As String)
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets, daGridLookup As New SqlDataAdapter()
        Dim dsShow, dsGridLookup As New DataSet
        Try

            '----- Load Item Master to Grid
            daGridLookup = New SqlDataAdapter(" SELECT its.[Itemcode],it.[Description],its.[SellingPrice] FROM [ItemSellingDetail] its inner join dbo.ItemMaster It on IT.Itemcode=its.Itemcode  WHERE its.[DepartmentID]='" & depNo & "'", Conn)
            'Dim sql As String = "  select a.* from [vwItemWithCocktail] a where a.status=1 and(a.IsNonInv =1 or a.Location like '{0}')"
            'sql = String.Format(sql, depNo)

            'daGridLookup = New SqlDataAdapter(sql, Conn)
            daGridLookup.Fill(dsGridLookup)
            dsItemList = dsGridLookup

            For i As Integer = 0 To dsGridLookup.Tables(0).Rows.Count - 1
                repItemList.Items.Add(dsGridLookup.Tables(0).Rows(i).Item(0))
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
            daGridLookup.Dispose()
            dsGridLookup.Dispose()
        End Try
    End Sub

    '    Private Sub gvItemDets_CellValueChanging(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvItemDets.CellValueChanging

    '        If e.Column.FieldName = "Itemcode" And String.IsNullOrEmpty(Itemcode) Then
    '            Dim RefBillNo As String = e.Value
    '            Dim PassDepartmentID As String = e.Value
    '            If (Not dsItemList Is Nothing) Then
    '                Dim dataRowList() As DataRow
    '                dataRowList = dsItemList.Tables(0).Select(String.Format("Itemcode ='{0}'", PassDepartmentID.Trim()))
    '                If (Not dataRowList Is Nothing) Then
    '                    If (dataRowList.Length > 0) Then
    '                        Dim dd As String = dataRowList(0)("Description").ToString()
    '                        Dim val As String = dataRowList(0)("SellingPrice").ToString()

    '                        gvItemDets.SetRowCellValue(gvItemDets.FocusedRowHandle, "Itemname", dd)
    '                        gvItemDets.SetRowCellValue(gvItemDets.FocusedRowHandle, "Itemprice", val)
    '                    End If
    '                End If
    '            End If


    '        End If
    '    End Sub
    'End Class

    'Private Sub gvItemDets_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvItemDets.CellValueChanged

    '    Dim view As GridView = TryCast(sender, GridView)
    '    If e.Column.FieldName = "Itemcode" And String.IsNullOrEmpty(Itemcode) Then

    '        Dim RefBillNo As String = e.Value
    '        Dim PassDepartmentID As String = e.Value
    '        If (Not dsItemList Is Nothing) Then
    '            Dim dataRowList() As DataRow
    '            dataRowList = dsItemList.Tables(0).Select(String.Format("Itemcode ='{0}'", PassDepartmentID.Trim()))
    '            If (Not dataRowList Is Nothing) Then
    '                If (dataRowList.Length > 0) Then
    '                    Dim dd As String = dataRowList(0)("Description").ToString()
    '                    Dim val As String = dataRowList(0)("SellingPrice").ToString()
    '                    view.SetRowCellValue(e.RowHandle, "Itemname", dd)
    '                    view.SetRowCellValue(e.RowHandle, "Itemprice", val)
    '                    'gvItemDets.SetRowCellValue(gvItemDets.FocusedRowHandle, "Itemname", dd)
    '                    ' gvItemDets.SetRowCellValue(gvItemDets.FocusedRowHandle, "Itemprice", val)
    '                End If
    '            End If
    '        End If


    '    End If
    'End Sub

    Private Sub btnInactive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInactive.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "KOTBOTBilling", "Delete")

        If CheckAccess = True Then


            Dim Conn As SqlConnection
            Dim command As SqlCommand
            Try
                If (tabMain.SelectedTabPageIndex <> 1) Then
                    tabMain.SelectedTabPageIndex = 1
                Else
                    KotBotNo = gvKOTBOTBilling.GetFocusedRowCellValue("KOTBOTNo")

                    Dim bt As DialogResult = MessageBox.Show("Do You Want To Inactive the selected KotBot", " KotBot to Inactive ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If bt = Windows.Forms.DialogResult.Yes Then
                        If (String.IsNullOrEmpty(KotBotNo)) Then
                            MessageBox.Show("Please select KotBot to Inactive", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else
                            Dim sqlstring As String = ""
                            Dim ConnStr As String = ConnString
                            Conn = New SqlConnection(ConnStr)
                            command = New SqlCommand
                            Dim dcInsertNewAccDetail As New SqlCommand

                            Conn.Open()
                            sqlstring = "UPDATE [KotBotMaster] SET [Active] = 0  WHERE Id='" & KotBotNo & "'"
                            command = New SqlCommand(sqlstring, Conn)
                            command.ExecuteNonQuery()
                            Conn.Close()
                            loadKotDataGrid()
                        End If
                    End If
                End If


                Conn.Open()
                '----- my sp should come here 'zuhri
                Dim TransIns As SqlTransaction
                Dim IsTrans As Boolean = False
                Dim dcUpdateInventory As New SqlCommand

                dcUpdateInventory = New SqlCommand("spBilledItemUpdateCancelKOT", Conn)
                dcUpdateInventory.CommandType = CommandType.StoredProcedure
                dcUpdateInventory.Transaction = TransIns

                With dcUpdateInventory.Parameters
                    .Add("@BILLNO", SqlDbType.NVarChar).Value = KotBotNo
                    .Add("@ISSUCCESS", SqlDbType.Bit).Direction = ParameterDirection.Output
                End With
                'dcUpdateInventory.Parameters("@ISSUCESS").Direction = ParameterDirection.Output
                dcUpdateInventory.ExecuteNonQuery()

                Dim Result As Boolean = dcUpdateInventory.Parameters("@ISSUCCESS").Value

                If Not Result Then
                    Throw New Exception("Update not successfull")
                End If

                Conn.Close()








            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Finally
                If (Not Conn Is Nothing) Then
                    Conn.Dispose()
                End If
            End Try



        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub btnBlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim unboundValue As Object = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Unbound1")
        '    unboundValue = Not (boolean)unboundValue
        'GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "Unbound1", unboundValue)
    End Sub
    Private Sub btnCreateBilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateBilling.Click
        If (tabMain.SelectedTabPageIndex <> 4) Then
            tabMain.SelectedTabPageIndex = 4
        ElseIf (tabMain.SelectedTabPageIndex = 4) Then
            Dim bt As DialogResult = MessageBox.Show("Do Generate master bill for Room Number: " & ComboBoxRoomNo.Text, " Master bill Generate ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If bt = Windows.Forms.DialogResult.Yes Then

                Dim cnumberPart As String = ""
                Dim ConnStr As String = ConnString
                Dim Conn As New SqlConnection(ConnStr)
                Dim dcMasterBill As New SqlCommand
                Dim dateVal As DateTime = Convert.ToDateTime(dtDate.Text)
                Dim intNo As Integer = getNewBillNO()
                intNo = intNo + 1

                cnumberPart = intNo.ToString()
                Dim billnumbers As String = String.Empty
                Dim autoid As String = "B" & dateVal.Year.ToString().Trim() & dateVal.Month.ToString().Trim() & dateVal.Day.ToString().Trim() & cnumberPart
                Dim I As Integer
                Dim DataRowCount As Integer = GridView1.DataRowCount
                For I = 0 To DataRowCount - 1
                    Dim outLetBill As String = GridView1.GetRowCellValue(I, "Bill No")
                    billnumbers = billnumbers & outLetBill & ","
                    dsUnPaid.Tables(0).Rows(I)("sum") = TextEditUnPaid.Text
                Next

                I = 0

                DataRowCount = GridView4.DataRowCount
                For I = 0 To DataRowCount - 1
                    Dim outLetBill As String = GridView4.GetRowCellValue(I, "Bill No")
                    billnumbers = billnumbers & outLetBill & ","
                    dsPaid.Tables(0).Rows(I)("sum") = TextEditPaid.Text
                Next
                If (billnumbers.Length > 0) Then
                    billnumbers = billnumbers.Remove(billnumbers.Length - 1)
                End If
                Dim rmsDbDataSet As New DataSet

                Conn.Open()
                dcMasterBill = New SqlCommand("genarate_masterBill_SP", Conn)
                dcMasterBill.CommandType = CommandType.StoredProcedure
                dcMasterBill.Parameters.Add("billNo ", SqlDbType.VarChar).Value = autoid
                dcMasterBill.Parameters.Add("OutLetbillNo", SqlDbType.VarChar).Value = billnumbers
                dcMasterBill.ExecuteNonQuery()
                Conn.Close()

                Dim dt As New DataTable
                dt = dsUnPaid.Tables(0).Clone()

                Dim drBlank1 As DataRow = dt.NewRow()
                drBlank1("t") = "Paid recipts"
                drBlank1("MasterBillNo") = autoid
                drBlank1("guest") = TextEditGuest.Text
                drBlank1("RoomNo") = ComboBoxRoomNo.Text
                drBlank1("balance") = TextEditUnPaid.Text
                drBlank1("grandTot") = TextEditTotal.Text
                dt.Rows.Add(drBlank1)

                If (Not dsPaid Is Nothing) Then
                    Dim k As Integer
                    For k = 0 To dsPaid.Tables(0).Rows.Count - 1
                        Dim dr As DataRow = dt.NewRow()
                        dr("MasterBillNo") = autoid
                        dr("Receipt") = dsPaid.Tables(0).Rows(k)("Receipt")
                        dr("Bill No") = dsPaid.Tables(0).Rows(k)("Bill No")
                        dr("Amount") = dsPaid.Tables(0).Rows(k)("Amount")
                        dr("RoomNo") = dsPaid.Tables(0).Rows(k)("RoomNo")
                        dr("guest") = dsPaid.Tables(0).Rows(k)("guest")
                        dr("PayType") = dsPaid.Tables(0).Rows(k)("PayType")
                        dr("sum") = dsPaid.Tables(0).Rows(k)("sum")
                        dr("balance") = TextEditUnPaid.Text
                        dr("grandTot") = TextEditTotal.Text
                        dt.Rows.Add(dr)
                    Next
                End If

                Dim drBlank2 As DataRow = dt.NewRow()
                dt.Rows.Add(drBlank2)

                Dim drBlank3 As DataRow = dt.NewRow()
                drBlank3("MasterBillNo") = autoid
                drBlank3("guest") = TextEditGuest.Text
                drBlank3("RoomNo") = ComboBoxRoomNo.Text
                drBlank3("balance") = TextEditUnPaid.Text
                drBlank3("grandTot") = TextEditTotal.Text
                drBlank3("t") = "Un Piad Bills"

                dt.Rows.Add(drBlank3)

                If (Not dsUnPaid Is Nothing) Then
                    Dim J As Integer
                    For J = 0 To dsUnPaid.Tables(0).Rows.Count - 1
                        Dim dr As DataRow = dt.NewRow()
                        dr("Bill No") = dsUnPaid.Tables(0).Rows(J)("Bill No")
                        dr("Receipt") = dsUnPaid.Tables(0).Rows(J)("Receipt")
                        dr("MasterBillNo") = autoid ' dsUnPaid.Tables(0).Rows(J)("Bill No")
                        dr("Amount") = dsUnPaid.Tables(0).Rows(J)("Amount")
                        dr("RoomNo") = dsUnPaid.Tables(0).Rows(J)("RoomNo")
                        dr("guest") = dsUnPaid.Tables(0).Rows(J)("guest")
                        dr("PayType") = dsUnPaid.Tables(0).Rows(J)("PayType")
                        dr("sum") = dsUnPaid.Tables(0).Rows(J)("sum")
                        dr("balance") = TextEditUnPaid.Text
                        dr("grandTot") = TextEditTotal.Text
                        dt.Rows.Add(dr)
                    Next
                End If

                Dim drBlank4 As DataRow = dt.NewRow()
                '  Dim drBlank4 As DataRow = dt.NewRow()
                drBlank4("MasterBillNo") = autoid
                drBlank4("guest") = TextEditGuest.Text
                drBlank4("RoomNo") = ComboBoxRoomNo.Text
                drBlank4("balance") = TextEditUnPaid.Text
                drBlank4("grandTot") = TextEditTotal.Text

                dt.Rows.Add(drBlank4)

                rmsDbDataSet.Tables.Add(dt)
                ShowReportView(New MasterBill1, rmsDbDataSet)
                loadmasterBillData()

            End If
        End If
    End Sub

    Private Sub ComboBoxRoomNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxRoomNo.SelectedIndexChanged
        loadmasterBillData()
    End Sub
    Private Sub loadmasterBillData()
        TextEditGuest.Text = ""
        LoadUserData(ComboBoxRoomNo.Text, 4)
        LoadPaid(ComboBoxRoomNo.Text)
    End Sub

    Private Sub DateSelect_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LoadPaid(ByVal RoomNo As String)
        Dim Conn As New SqlConnection(ConnString)

        dsPaid = New DataSet
        dsUnPaid = New DataSet

        Dim daApid As New SqlDataAdapter
        Dim daUnpid As New SqlDataAdapter

        Dim dcPaid As New SqlCommand
        Dim dcUnPaid As New SqlCommand
        Dim unPaidAmount As Double
        Dim totalUnPaidAmount As Double
        Dim paidAmount As Double
        Dim totalPaidAmount As Double
        Try
            Conn.Open()
            dcPaid = New SqlCommand("SELECT '' as t, o.[BillNo] as 'Bill No' ,o.[KOTBOTNo] ,o.[MasterBillGenerated],o.[MasterBillNo] ,o.[Paid] ,o.[ReciptNo]  as Receipt,o.[Total] as 'Amount',o.[RoomNo],o.[ReservationNo] ,o.[Type],'guest' as guest,'' as 'sum','' as balance,'' as grandTot,p.[Description] as 'PayType' FROM [OutLetBillMaster] o inner join dbo.KotBotMaster k on k.Id=o.KOTBOTNo inner join dbo.DepartmentMaster d on k.Department =d.DepartmentID Collate SQL_Latin1_General_CP1_CI_AS inner join [PaymentType] P on P.[PaymentTypeCode]=[PayType] where o.[Paid]=1 and o.[MasterBillGenerated]=0 and o.[RoomNo] ='" & RoomNo & "'", Conn)
            daApid = New SqlDataAdapter()
            daApid.SelectCommand = dcPaid
            daApid.Fill(dsPaid)


            If (Not dsPaid Is Nothing) Then
                GridControlPaid.DataSource = dsPaid.Tables(0)
                dsPaid.Tables(0).TableName = "Paid"
                Dim I As Integer
                For I = 0 To dsPaid.Tables(0).Rows.Count - 1
                    paidAmount = Double.Parse(dsPaid.Tables(0).Rows(I)("Amount").ToString())
                    dsPaid.Tables(0).Rows(I)("guest") = TextEditGuest.Text
                    totalPaidAmount = totalPaidAmount + paidAmount
                Next
                TextEditPaid.Text = totalPaidAmount.ToString()
            End If
            Conn.Close()

            Conn.Open()
            dcUnPaid = New SqlCommand("SELECT '' as t, o.[BillNo]  as 'Bill No' ,o.[KOTBOTNo] ,o.[MasterBillGenerated],o.[MasterBillNo] ,o.[Paid] ,o.[ReciptNo] as Receipt ,o.[Total] as 'Amount',o.[RoomNo],o.[ReservationNo] ,o.[Type],'guest' as guest,'sum' as 'sum','' as balance,'' as grandTot,p.[Description] as 'PayType' FROM [OutLetBillMaster] o inner join dbo.KotBotMaster k on k.Id=o.KOTBOTNo inner join dbo.DepartmentMaster d on k.Department =d.DepartmentID Collate SQL_Latin1_General_CP1_CI_AS inner join [PaymentType] P on P.[PaymentTypeCode]=[PayType] where o.[Paid]=0 and o.[MasterBillGenerated]=0 and o.[RoomNo] ='" & RoomNo & "'", Conn)
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
                Next
                TextEditUnPaid.Text = totalUnPaidAmount.ToString()
                dsUnPaid.Tables(0).TableName = "dsUnPaid"
            End If
            Conn.Close()

            Dim balance As Double = totalPaidAmount + totalUnPaidAmount
            '    If ((balance) > 0) Then
            TextEditTotal.Text = balance.ToString()
            '     Else
            '    TextEditTotal.Text = "0"
            '   End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daApid.Dispose()

            daUnpid.Dispose()
        End Try
    End Sub

    'Private Sub LoadKOTBOTData(RoomNo As String)
    '    Dim Conn As New SqlConnection(ConnString)
    '    Dim dsKOTBOT As New DataSet
    '    Dim daMain As New SqlDataAdapter
    '    Dim dcSearch As New SqlCommand
    '    Try
    '        Conn.Open()
    '        dcSearch = New SqlCommand("SELECT k.[Id] as KOTBOTID,k.[Date] ,k.[RoomNo],g.GuestName ,k.[Type],k.[Department] FROM [KotBotMaster] k inner join [Guest.RegisterMaster] R on k.ReservationNo =R.ReservationNo inner join [Guest.Master] g  on g.GuestID =R.GuestId where k.Active=1 and k.BillGenerated =0 and k.RoomNo='" & RoomNo & "'", Conn)
    '        daMain = New SqlDataAdapter()
    '        daMain.SelectCommand = dcSearch
    '        daMain.Fill(dsKOTBOT)
    '        If (Not dsKOTBOT Is Nothing) Then
    '            GridControUnPaidBill.DataSource = dsKOTBOT.Tables(0)

    '            For i As Int16 = 0 To GridView1.RowCount - 1
    '                unboundData.Add(False)
    '            Next

    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
    '    Finally
    '        Conn.Dispose()
    '        daMain.Dispose()
    '    End Try
    'End Sub

    Private Function getsellingRate(ByVal currenyCode As String) As Decimal
        Dim rate As Decimal = 1
        Dim j As Integer
        For j = 0 To dsCurrency.Tables(0).Rows.Count - 1
            If (dsCurrency.Tables(0).Rows(j)("RepCurrencyCode").ToString().Trim() = currenyCode.Trim()) Then
                rate = Decimal.Parse(dsCurrency.Tables(0).Rows(j)("SellingRate").ToString().Trim())
            End If
        Next
        getsellingRate = rate
    End Function

    Private Sub PayBillReciptDirctPurchasse(bill As String, tot As String)
        Dim Conn As New SqlConnection
        Dim OutLetBillRecipet As New DataTable
        OutLetBillRecipet.TableName = "OutLetBillRecipet"
        OutLetBillRecipet.Columns.Add("BillNo")
        OutLetBillRecipet.Columns.Add("Date")
        OutLetBillRecipet.Columns.Add("RoomNo")
        OutLetBillRecipet.Columns.Add("ReceiptNo")
        OutLetBillRecipet.Columns.Add("PayMethod")
        OutLetBillRecipet.Columns.Add("amount")
        OutLetBillRecipet.Columns.Add("GuestName")
        OutLetBillRecipet.Columns.Add("PayMethodNo")
        OutLetBillRecipet.Columns.Add("Currency")

        Dim dsOutLetBillRecipet As New DataSet
        Dim dcInsertNewAccDetail As New SqlCommand
        Try

            Dim reciptNo As String = String.Empty
            Dim PayType As String = ComboBoxPayMethod.Text.Trim()
            Dim DataRowCount As Integer = GridView3.DataRowCount
            Dim PayMethod As String = ComboBoxPayMethod.Text

            Conn = New SqlConnection(ConnString)
            Conn.Open()
            Dim drDetail As DataRow = OutLetBillRecipet.NewRow()
            Dim OutLetBillNo As String = bill
            dcInsertNewAccDetail = New SqlCommand("OutLet_Bill_Pay_SP", Conn)
            dcInsertNewAccDetail.CommandType = CommandType.StoredProcedure
            reciptNo = "REC" & OutLetBillNo
            dcInsertNewAccDetail.Parameters.Add("billNo", SqlDbType.VarChar).Value = OutLetBillNo
            dcInsertNewAccDetail.Parameters.Add("reciptNo", SqlDbType.VarChar).Value = reciptNo
            dcInsertNewAccDetail.Parameters.Add("payType", SqlDbType.VarChar).Value = PayType
            dcInsertNewAccDetail.Parameters.Add("Amount", SqlDbType.Float).Value = Decimal.Parse(tot)
            dcInsertNewAccDetail.Parameters.Add("ChqORCreditCardNumber", SqlDbType.VarChar).Value = ""
            dcInsertNewAccDetail.Parameters.Add("CurrencyCode", SqlDbType.VarChar).Value = ComboBoxEditcurrenc.Text
            dcInsertNewAccDetail.Parameters.Add("SellingRate", SqlDbType.Decimal).Value = getsellingRate(ComboBoxEditCurrency.Text)

            dcInsertNewAccDetail.ExecuteNonQuery()
            Conn.Close()

            drDetail("BillNo") = OutLetBillNo
            drDetail("Date") = DateTime.Now.ToString()
            drDetail("RoomNo") = TextEditRoom.Text
            drDetail("ReceiptNo") = reciptNo
            drDetail("PayMethod") = getPayTypeDescription(PayType) + " Receipt "
            drDetail("amount") = Decimal.Parse(tot)
            drDetail("GuestName") = TextEditGuestName.Text
            drDetail("PayMethodNo") = getPaymethod("CH", True)
            drDetail("Currency") = ComboBoxEditCurrency.Text
            OutLetBillRecipet.Rows.Add(drDetail)

            dsOutLetBillRecipet.Tables.Clear()
            dsOutLetBillRecipet.Tables.Add(OutLetBillRecipet)
            loadPaydata()
            loadmasterBillData()
            ShowReportView(New Receipt, dsOutLetBillRecipet)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            dcInsertNewAccDetail.Dispose()
        End Try
    End Sub

    Function payOutletBillDirectPurchase(kot As String, ByRef tot As String) As String
        Dim DataRowCount As Integer = GridView2.DataRowCount
        Dim cnumberPart As String = ""
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim dcInsertNewAccDetail As New SqlCommand
        Dim autoid As String = ""
        Try

            Dim dateVal As DateTime = DateTime.Now()
            Dim DateString As String = ""
            Dim intNo As Integer = getNewBillNO()
            intNo = intNo + 1
            cnumberPart = intNo.ToString()
            Dim ishavingRow As Boolean = False
            autoid = "OB" & dateVal.Year.ToString().Trim() & dateVal.Month.ToString().Trim() & dateVal.Day.ToString().Trim() & cnumberPart

            Conn.Open()
            dcInsertNewAccDetail = New SqlCommand("genarate_OutLetBill_SP", Conn)
            dcInsertNewAccDetail.CommandType = CommandType.StoredProcedure
            dcInsertNewAccDetail.Parameters.Add("KOTBOTID ", SqlDbType.VarChar).Value = kot
            dcInsertNewAccDetail.Parameters.Add("billNo", SqlDbType.VarChar).Value = autoid
            dcInsertNewAccDetail.Parameters.Add("Department", SqlDbType.VarChar).Value = cmboutletIDDp.Text
            DateString = DateTime.Now.ToString()
            dcInsertNewAccDetail.ExecuteNonQuery()
            Conn.Close()

            Dim sqlBillHeader As String = " SELECT B.BillNo, B.KOTBOTNo, B.BillGeneratedDate AS Date, B.RoomNo, B.ReservationNo, B.Type, 'Department' AS 'Department',  dbo.[Room.CurrentStatus].BillingGuest as FullName,B.Total FROM dbo.OutLetBillMaster AS B INNER JOIN dbo.[Room.CurrentStatus] ON B.ReservationNo = dbo.[Room.CurrentStatus].ReservationNo  WHERE [BillNo]='" & autoid & "'"
            Dim sqlBillDetail As String = " SELECT [BillNo] as KotBotId, [ItemCode],[ItemName],[Qty],[UnitPrice] FROM [OutLetBillDetail] where BillNo = '" & autoid & "'"
            Dim dtBillHeader As DataTable = GetDataForSQL(sqlBillHeader)
            Dim dtBillDetail As DataTable = GetDataForSQL(sqlBillDetail)

            If (dtBillDetail.Rows.Count > 0) Then
                tot = dtBillDetail.Rows(0)("Total").ToString()
            End If
            dtBillHeader.TableName = "KotBotMaster"
            dtBillDetail.TableName = "KotBotDetails"

            Dim rmsDbDataSet As New DataSet
            rmsDbDataSet.Tables.Add(dtBillHeader.Copy())
            rmsDbDataSet.Tables.Add(dtBillDetail.Copy())
            ShowReportView(New KotBotBill, rmsDbDataSet)
            payOutletBillDirectPurchase = autoid
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            dcInsertNewAcc.Dispose()
            dcInsertNewAccDetail.Dispose()
            payOutletBillDirectPurchase = autoid
        End Try
    End Function

    Private Sub SimpleButtonCreateOutLetBilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButtonCreateOutLetBilling.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "OutletBilling", "Add")

        If CheckAccess = True Then

            GetServerDate()

            Dim DataRowCount As Integer = GridView2.DataRowCount
            Dim cnumberPart As String = ""
            Dim ConnStr As String = ConnString
            Dim Conn As New SqlConnection(ConnStr)
            Dim dcInsertNewAcc As New SqlCommand
            Dim dcInsertNewAccDetail As New SqlCommand

            Try
                If (tabMain.SelectedTabPageIndex <> 3) Then
                    tabMain.SelectedTabPageIndex = 3
                ElseIf (tabMain.SelectedTabPageIndex = 3) Then
                    Dim dateVal As DateTime = DateTime.Now()
                    Dim DateString As String = ""
                    Dim intNo As Integer = getNewBillNO() ' getNewKotBotNO()
                    intNo = intNo + 1
                    cnumberPart = intNo.ToString()
                    Dim ishavingRow As Boolean = False

                    'Dim autoid As String = "OB" & dateVal.Year.ToString().Trim() & dateVal.Month.ToString().Trim() & dateVal.Day.ToString().Trim() & cnumberPart


                    Dim autoid As String = GetKOTBOTNo("BILL")


                    '''''''
                    Dim discountAmount As String = ""
                    Dim discountID As String = ""
                    Dim DisCountType As String = ""
                    Dim hasdiscount As Boolean = False
                    Dim ispresntage As Boolean = False
                    If (ComboBoxEditDiscount.Text = "" Or ComboBoxEditDiscount.Text.ToLower() = "none") Then
                        discountAmount = "0"
                        hasdiscount = False
                        discountID = ""
                        DisCountType = ""
                        ispresntage = False
                    Else
                        If (Not dsDepartments Is Nothing) Then
                            Dim dataRowList() As DataRow
                            dataRowList = Discountds.Tables(0).Select(String.Format("Name ='{0}'", ComboBoxEditDiscount.Text.Trim()))
                            If (Not dataRowList Is Nothing) Then
                                If (dataRowList.Length > 0) Then
                                    hasdiscount = True
                                    discountAmount = dataRowList(0)("Amount").ToString()
                                    discountID = dataRowList(0)("ID").ToString()
                                    DisCountType = dataRowList(0)("DisCountType").ToString()
                                    If (DisCountType.ToLower() = "per") Then
                                        ispresntage = True
                                    Else
                                        ispresntage = False
                                    End If
                                End If
                            End If
                        End If
                    End If
                    ''''''

                    '---------***************************************-------------------------------------------











                    '-----------------************************************------------------------------------








                    Dim I As Integer
                    For I = 0 To DataRowCount - 1
                        'Dim s As String = GridView2.GetRowCellValue(I, "GridColumn12")
                        'If (Not String.IsNullOrEmpty(s)) Then
                        '    If (Boolean.Parse(s) = True) Then
                        If (Not GridView2.GetDataRow(I) Is Nothing) Then
                            If GridView2.IsRowSelected(I) Then
                                ishavingRow = True
                                Conn.Open()


                                Dim KOTBOTID As String = GridView2.GetRowCellValue(I, "KOTBOTID")
                                Dim department As String = GridView2.GetRowCellValue(I, "Department")


                                Dim OutletMasBillNo As String = GetOutletMasBillNo(department)
                                PubOutletbilmasno = OutletMasBillNo




                                dcInsertNewAccDetail = New SqlCommand("genarate_OutLetBill_SP", Conn)
                                dcInsertNewAccDetail.CommandType = CommandType.StoredProcedure
                                dcInsertNewAccDetail.Parameters.Add("KOTBOTID ", SqlDbType.VarChar).Value = KOTBOTID
                                dcInsertNewAccDetail.Parameters.Add("billNo", SqlDbType.VarChar).Value = autoid
                                dcInsertNewAccDetail.Parameters.Add("Department", SqlDbType.VarChar).Value = department

                                dcInsertNewAccDetail.Parameters.Add("hasdiscount", SqlDbType.Bit).Value = hasdiscount
                                dcInsertNewAccDetail.Parameters.Add("discountvalue", SqlDbType.VarChar).Value = discountAmount
                                dcInsertNewAccDetail.Parameters.Add("ispresntage", SqlDbType.Bit).Value = ispresntage
                                dcInsertNewAccDetail.Parameters.Add("discountID", SqlDbType.VarChar).Value = discountID
                                dcInsertNewAccDetail.Parameters.Add("EnteredBy", SqlDbType.VarChar).Value = CurrUser
                                dcInsertNewAccDetail.Parameters.Add("Outletmasbillno", SqlDbType.VarChar).Value = OutletMasBillNo
                                'dcInsertNewAccDetail.Parameters.Add("tax", SqlDbType.Decimal).Value = OutletMasBillNo
                                'dcInsertNewAccDetail.Parameters.Add("serviceCharge", SqlDbType.Decimal).Value = getScharge

                                dcInsertNewAccDetail.Parameters.Add("BillGeneratedDate", SqlDbType.DateTime).Value = dtDate.Text


                                DateString = GridView2.GetRowCellValue(I, "Date")
                                dcInsertNewAccDetail.ExecuteNonQuery()
                                Conn.Close()
                            End If
                        End If
                    Next

                    If (ishavingRow = True) Then
                        'Guestcase
                        ' Dim sqlBillHeader As String = "  SELECT B.[BillNo] as BillNo ,B.[KOTBOTNo],B.[BillGeneratedDate] as Date ,B.[RoomNo],B.[ReservationNo],B.[Type],'Department' as 'Department',g.GuestName as 'GuestName'  FROM [OutLetBillMaster] B inner join [Guest.RegisterMaster] R ON R.ReservationNo  = B.ReservationNo  inner join [Guest.Master] g on g.GuestID=R.GuestId  WHERE [BillNo]='" & autoid & "'"
                        'Dim sqlBillHeader As String = " SELECT B.BillNo, B.KOTBOTNo, B.BillGeneratedDate AS Date, B.RoomNo, B.ReservationNo, B.Type, 'Department' AS 'Department', dbo.GuestRegistration.FullName FROM dbo.OutLetBillMaster AS B INNER JOIN dbo.GuestRegistration ON B.ReservationNo = dbo.GuestRegistration.ReservationNo  WHERE [BillNo]='" & autoid & "'"

                        Dim sqlBillHeader As String = ""
                        Dim sqlBillDetail As String = ""

                        If PubIsStaff = 1 Then


                            sqlBillHeader = " SELECT B.BillNo, B.KOTBOTNo, B.BillGeneratedDate AS Date, B.RoomNo, B.Department AS 'ReservationNo', B.Type, 'Department' AS 'Department',  B.ReservationNo as FullName, B.discountAmount,'' discounttype,B.Total  FROM dbo.OutLetBillMaster B  WHERE B.[BillNo]='" & autoid & "'"
                            'sqlBillDetail = " SELECT [BillNo] as KotBotId, [ItemCode],[ItemName],[Qty],[UnitPrice] FROM [OutLetBillDetail] where BillNo = '" & autoid & "'"

                            sqlBillDetail = "SELECT [BillNo] as KotBotId, [ItemCode],[ItemName],sum([Qty]) as [Qty], [UnitPrice] FROM [OutLetBillDetail] where BillNo = '" & autoid & "' group by [ItemCode],[BillNo],[ItemName],[UnitPrice]"


                        Else


                            ' sqlBillHeader = " SELECT B.BillNo, B.KOTBOTNo, B.BillGeneratedDate AS Date, B.RoomNo, B.Department AS 'ReservationNo', B.Type, 'Department' AS 'Department',  dbo.[Room.CurrentStatus].BillingGuest as FullName, B.discountAmount,'' discounttype,B.Total  FROM dbo.OutLetBillMaster AS B INNER JOIN dbo.[Room.CurrentStatus] ON B.ReservationNo = dbo.[Room.CurrentStatus].ReservationNo  WHERE [BillNo]='" & autoid & "'"


                            sqlBillHeader = "SELECT B.BillNo, B.KOTBOTNo, B.BillGeneratedDate AS Date, B.RoomNo, B.Department AS 'ReservationNo', B.Type, 'Department' AS 'Department',  dbo.[Room.CurrentStatus].BillingGuest as FullName, B.discountAmount,'' discounttype,B.Total  FROM dbo.OutLetBillMaster AS B INNER JOIN dbo.[Room.CurrentStatus] ON B.RoomNo = dbo.[Room.CurrentStatus].RoomNo  WHERE [BillNo]='" & autoid & "'"

                            'sqlBillDetail = " SELECT [BillNo] as KotBotId, [ItemCode],[ItemName],[Qty],[UnitPrice] FROM [OutLetBillDetail] where BillNo = '" & autoid & "'"

                            sqlBillDetail = "SELECT [BillNo] as KotBotId, [ItemCode],[ItemName],sum([Qty]) as [Qty], [UnitPrice] FROM [OutLetBillDetail] where BillNo ='" & autoid & "' group by [ItemCode],[BillNo],[ItemName],[UnitPrice]"

                        End If


                        Dim dtBillHeader As DataTable = GetDataForSQL(sqlBillHeader)
                        Dim dtBillDetail As DataTable = GetDataForSQL(sqlBillDetail)

                        dtBillHeader.TableName = "KotBotMaster"
                        dtBillDetail.TableName = "KotBotDetails"

                        Dim rmsDbDataSet As New DataSet
                        rmsDbDataSet.Tables.Add(dtBillHeader.Copy())

                        Dim q As Integer
                        For q = 0 To rmsDbDataSet.Tables(0).Rows.Count - 1
                            Dim tot As Double = Double.Parse(rmsDbDataSet.Tables(0).Rows(q)("Total"))
                            Dim discount As Double = Double.Parse(rmsDbDataSet.Tables(0).Rows(q)("discountAmount"))

                            rmsDbDataSet.Tables(0).Rows(q)("Department") = FormatNumber((tot - discount).ToString(), 2)
                            LoadWaiterNo(autoid)





                            rmsDbDataSet.Tables(0).Rows(q)("Type") = PubOutletbillno.ToString + "--" + "Waiter No: " + PubWaitno.ToString + "**" + PubOutletbilmasno


                            If (ComboBoxEditDiscount.Text.ToLower().Trim() = "none") Then
                                rmsDbDataSet.Tables(0).Rows(q)("discounttype") = ""
                            Else
                                rmsDbDataSet.Tables(0).Rows(q)("discounttype") = ComboBoxEditDiscount.Text
                            End If
                        Next
                        'End If
                        rmsDbDataSet.Tables.Add(dtBillDetail.Copy())

                        ShowReportView(New KotBotBillNew, rmsDbDataSet)
                        '   ShowReportView(New Kot_Bot_Bill, rmsDbDataSet)
                    End If
                    '  LoadKOTBOTDataOutLet(ComboDept.Text)
                    LoadKOTBOTDataOutLetByRoom(ComboBoxEditRoom.Text)
                    loadKotDataGrid()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Finally
                Conn.Dispose()
                dcInsertNewAcc.Dispose()
                dcInsertNewAccDetail.Dispose()
            End Try



        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub
    Private Sub PrintBillList(ByVal BillnoList As String)

        Dim sqlBillHeader As String = ""
        Dim sqlBillDetail As String = ""

        If PubIsStaff = 1 Then


            sqlBillHeader = " SELECT B.BillNo, B.KOTBOTNo, B.BillGeneratedDate AS Date, B.RoomNo, B.Department AS 'ReservationNo', B.Type, 'Department' AS 'Department',  B.ReservationNo as FullName, B.discountAmount,'' discounttype,B.Total  FROM dbo.OutLetBillMaster B  WHERE B.[BillNo]='" & BillnoList & "'"
            'sqlBillDetail = " SELECT [BillNo] as KotBotId, [ItemCode],[ItemName],[Qty],[UnitPrice] FROM [OutLetBillDetail] where BillNo = '" & autoid & "'"

            sqlBillDetail = "SELECT [BillNo] as KotBotId, [ItemCode],[ItemName],sum([Qty]) as [Qty], [UnitPrice] FROM [OutLetBillDetail] where BillNo = '" & BillnoList & "' group by [ItemCode],[BillNo],[ItemName],[UnitPrice]"


        Else


            ' sqlBillHeader = " SELECT B.BillNo, B.KOTBOTNo, B.BillGeneratedDate AS Date, B.RoomNo, B.Department AS 'ReservationNo', B.Type, 'Department' AS 'Department',  dbo.[Room.CurrentStatus].BillingGuest as FullName, B.discountAmount,'' discounttype,B.Total  FROM dbo.OutLetBillMaster AS B INNER JOIN dbo.[Room.CurrentStatus] ON B.ReservationNo = dbo.[Room.CurrentStatus].ReservationNo  WHERE [BillNo]='" & autoid & "'"


            sqlBillHeader = "SELECT B.BillNo, B.KOTBOTNo, B.BillGeneratedDate AS Date, B.RoomNo, B.Department AS 'ReservationNo', B.Type, 'Department' AS 'Department',  dbo.[Room.CurrentStatus].BillingGuest as FullName, B.discountAmount,'' discounttype,B.Total  FROM dbo.OutLetBillMaster AS B INNER JOIN dbo.[Room.CurrentStatus] ON B.RoomNo = dbo.[Room.CurrentStatus].RoomNo  WHERE [BillNo]='" & BillnoList & "'"

            'sqlBillDetail = " SELECT [BillNo] as KotBotId, [ItemCode],[ItemName],[Qty],[UnitPrice] FROM [OutLetBillDetail] where BillNo = '" & autoid & "'"

            sqlBillDetail = "SELECT [BillNo] as KotBotId, [ItemCode],[ItemName],sum([Qty]) as [Qty], [UnitPrice] FROM [OutLetBillDetail] where BillNo ='" & BillnoList & "' group by [ItemCode],[BillNo],[ItemName],[UnitPrice]"

        End If


        Dim dtBillHeader As DataTable = GetDataForSQL(sqlBillHeader)
        Dim dtBillDetail As DataTable = GetDataForSQL(sqlBillDetail)

        dtBillHeader.TableName = "KotBotMaster"
        dtBillDetail.TableName = "KotBotDetails"

        Dim rmsDbDataSet As New DataSet
        rmsDbDataSet.Tables.Add(dtBillHeader.Copy())

        Dim q As Integer
        For q = 0 To rmsDbDataSet.Tables(0).Rows.Count - 1
            Dim tot As Double = Double.Parse(rmsDbDataSet.Tables(0).Rows(q)("Total"))
            Dim discount As Double = Double.Parse(rmsDbDataSet.Tables(0).Rows(q)("discountAmount"))

            rmsDbDataSet.Tables(0).Rows(q)("Department") = FormatNumber((tot - discount).ToString(), 2)
            LoadWaiterNo(BillnoList)





            rmsDbDataSet.Tables(0).Rows(q)("Type") = PubOutletbillno.ToString + "--" + "Waiter No: " + PubWaitno.ToString + "**" + PubGetMasbillnoList


            If (ComboBoxEditDiscount.Text.ToLower().Trim() = "none") Then
                rmsDbDataSet.Tables(0).Rows(q)("discounttype") = ""
            Else
                rmsDbDataSet.Tables(0).Rows(q)("discounttype") = ComboBoxEditDiscount.Text
            End If
        Next
        'End If
        rmsDbDataSet.Tables.Add(dtBillDetail.Copy())

        ShowReportView(New KotBotBillNew, rmsDbDataSet)



    End Sub
    Private Sub LoadWaiterNo(ByVal bill As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand


        Dim getBill As String = bill


        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT dbo.KotBotMaster.WaiterNo ,dbo.OutLetBillMaster.BillGeneratedBy FROM dbo.OutLetBillMaster INNER JOIN dbo.KotBotMaster ON dbo.OutLetBillMaster.KOTBOTNo = dbo.KotBotMaster.Id where dbo.OutLetBillMaster.BillNo=@Billno", Conn)


            dcSearch.Parameters.Add("@Billno", SqlDbType.VarChar).Value = getBill

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count


            If Dscount > 0 Then


                PubWaitno = dsMain.Tables(0).Rows(0)(0).ToString()
                PubOutletbillno = dsMain.Tables(0).Rows(0)(1).ToString()



            Else

                PubWaitno = 0
                PubOutletbillno = ""

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub tabMain_TabIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabMain.TabIndexChanged

        If (tabMain.SelectedTabPageIndex = 1) Then
            cmbType.Focus()
            cmbType.Select()
        End If

        If (tabMain.SelectedTabPageIndex = 2) Then
            ComboBoxEditRoom.Focus()
            ComboBoxEditRoom.Select()

        End If

        If (tabMain.SelectedTabPageIndex = 2) Then
            LoadDepartmentsForOutLetBill()
        End If
    End Sub

    Private Sub LoadDepartmentsForOutLetBill()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        '   Dim dsDepartments As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT [DepartmentID],[Description] FROM [DepartmentMaster] order by DepartmentID", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsDepartmentsOutLet)

            Dim Dscount As Integer = dsDepartments.Tables(0).Rows.Count
            Dim DscountTest As Integer

            While (DscountTest < Dscount)
                ComboDept.Properties.Items.Add(dsDepartments.Tables(0).Rows(DscountTest)(0).ToString())
                DscountTest = DscountTest + 1
            End While
            ComboDept.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            '  dsMain.Dispose()
        End Try
    End Sub

    'Private Sub ComboDept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboDept.SelectedIndexChanged
    '    txtOutletName.Text = ""
    '    LoadDepartment(ComboDept.Text, 2)
    '    LoadKOTBOTDataOutLet(ComboDept.Text)
    'End Sub

    Private Sub LoadKOTBOTDataOutLetByRoom(ByVal roomNumber As String)
        Dim Conn As New SqlConnection(ConnString)
        Dim dsKOTBOT As New DataSet
        Dim daMain As New SqlDataAdapter
        Dim dcSearch As New SqlCommand
        Try

            PubIsStaff = 0

            Conn.Open()
            'dcSearch = New SqlCommand("SELECT k.Id AS KOTBOTID, k.Date, k.RoomNo, g.BillingGuest AS 'GuestName', k.Type, k.Department, k.ReservationNo FROM dbo.KotBotMaster AS k INNER JOIN dbo.[Room.CurrentStatus] AS g ON k.ReservationNo = g.ReservationNo WHERE   (k.Active = 1) AND (k.BillGenerated = 0)  and k.Department='" & department & "'", Conn)
            ' dcSearch = New SqlCommand("SELECT k.Id AS KOTBOTID, k.Date, k.RoomNo, g.BillingGuest AS 'GuestName', k.Type, k.Department, k.ReservationNo FROM dbo.KotBotMaster AS k INNER JOIN dbo.[Room.CurrentStatus] AS g ON k.ReservationNo = g.ReservationNo WHERE   (k.Active = 1) AND (k.BillGenerated = 0)  and k.RoomNo='" & roomNumber & "'", Conn)



            dcSearch = New SqlCommand("SELECT  k.Id AS KOTBOTID, k.Date, k.RoomNo, g.BillingGuest AS 'GuestName', k.Type, k.Department, k.ReservationNo FROM dbo.KotBotMaster AS k INNER JOIN dbo.[Room.CurrentStatus] AS g ON k.RoomNo = g.RoomNo WHERE   (k.Active = 1) AND (k.BillGenerated = 0)  and k.RoomNo='" & roomNumber & "' and k.ReservationNo=(select ReservationNo from [Room.CurrentStatus] where RoomNo='" & roomNumber & "')", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsKOTBOT)
            If (Not dsKOTBOT Is Nothing) Then
                GridControlOutLetBill.DataSource = Nothing

                GridControlOutLetBill.DataSource = dsKOTBOT.Tables(0)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
        End Try
    End Sub
    Private Sub LoadbillList(ByVal Dep As String, ByVal Roomno As String)
        Dim Conn As New SqlConnection(ConnString)
        Dim dsKOTBOT As New DataSet
        Dim daMain As New SqlDataAdapter
        Dim dcSearch As New SqlCommand
        Try

            Dim getDep As String = Dep
            Dim getRoomno As String = Roomno

            Conn.Open()


            ' dcSearch = New SqlCommand("SELECT  k.Id AS KOTBOTID, k.Date, k.RoomNo, g.BillingGuest AS 'GuestName', k.Type, k.Department, k.ReservationNo FROM dbo.KotBotMaster AS k INNER JOIN dbo.[Room.CurrentStatus] AS g ON k.RoomNo = g.RoomNo WHERE   (k.Active = 1) AND (k.BillGenerated = 0)  and k.RoomNo='" & roomNumber & "' and k.ReservationNo=(select ReservationNo from [Room.CurrentStatus] where RoomNo='" & roomNumber & "')", Conn)


            dcSearch = New SqlCommand("select * from outletbillmaster where Department=@dep and RoomNo=@rmno order by billgenerateddate desc", Conn)

            '  dcSearch = New SqlCommand("select * from outletbillmaster  where billgenerateddate >= @billdate and  billgenerateddate < @billdate2   and Department=@dep", Conn)

           
            dcSearch.Parameters.Add("@dep", SqlDbType.VarChar).Value = getDep
            dcSearch.Parameters.Add("@rmno", SqlDbType.VarChar).Value = getRoomno



            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsKOTBOT)
            If (Not dsKOTBOT Is Nothing) Then
                gcBilllist.DataSource = Nothing

                gcBilllist.DataSource = dsKOTBOT.Tables(0)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
        End Try
    End Sub
    Private Sub LoadKOTBOTDataOutLetByStaff()
        Dim Conn As New SqlConnection(ConnString)
        Dim dsKOTBOT As New DataSet
        Dim daMain As New SqlDataAdapter
        Dim dcSearch As New SqlCommand
        Try

            PubIsStaff = 1

            Conn.Open()
            'dcSearch = New SqlCommand("SELECT k.Id AS KOTBOTID, k.Date, k.RoomNo, g.BillingGuest AS 'GuestName', k.Type, k.Department, k.ReservationNo FROM dbo.KotBotMaster AS k INNER JOIN dbo.[Room.CurrentStatus] AS g ON k.ReservationNo = g.ReservationNo WHERE   (k.Active = 1) AND (k.BillGenerated = 0)  and k.Department='" & department & "'", Conn)
            dcSearch = New SqlCommand("SELECT k.Id AS KOTBOTID, k.Date, k.RoomNo, k.ReservationNo AS 'GuestName', k.Type, k.Department, k.ReservationNo FROM dbo.KotBotMaster k WHERE   (k.Active = 1) AND (k.BillGenerated = 0)  and k.RoomNo='STAFF'", Conn)
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsKOTBOT)
            If (Not dsKOTBOT Is Nothing) Then
                GridControlOutLetBill.DataSource = Nothing

                GridControlOutLetBill.DataSource = dsKOTBOT.Tables(0)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
        End Try
    End Sub

    Private Sub LoadKOTBOTDataOutLet(ByVal department As String)
        Dim Conn As New SqlConnection(ConnString)
        Dim dsKOTBOT As New DataSet
        Dim daMain As New SqlDataAdapter
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            'dcSearch = New SqlCommand("SELECT k.[Id] as KOTBOTID,k.[Date] ,k.[RoomNo],g.[BillingGuest] as 'GuestName' ,k.[Type],k.[Department] FROM [KotBotMaster] k inner join [Guest.RegisterMaster] R on k.ReservationNo =R.ReservationNo  inner join [Room.CurrentStatus] g on g.ReservationNo =R.ReservationNo where k.Active=1 and k.BillGenerated =0 and k.Department='" & department & "'", Conn)
            'dcSearch = New SqlCommand("SELECT k.[Id] as KOTBOTID,k.[Date] ,k.[RoomNo],g.[BillingGuest] as 'GuestName' ,k.[Type],k.[Department] FROM [KotBotMaster] k inner join [GuestRegistration] R on k.ReservationNo =R.ReservationNo  inner join [Room.CurrentStatus] g on g.ReservationNo =R.ReservationNo where k.Active=1 and k.BillGenerated =0 and k.Department='" & department & "'", Conn)
            dcSearch = New SqlCommand("SELECT k.Id AS KOTBOTID, k.Date, k.RoomNo, g.BillingGuest AS 'GuestName', k.Type, k.Department, k.ReservationNo FROM dbo.KotBotMaster AS k INNER JOIN dbo.[Room.CurrentStatus] AS g ON k.ReservationNo = g.ReservationNo WHERE   (k.Active = 1) AND (k.BillGenerated = 0)  and k.Department='" & department & "'", Conn)
            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsKOTBOT)
            If (Not dsKOTBOT Is Nothing) Then
                GridControlOutLetBill.DataSource = dsKOTBOT.Tables(0)
                'gayan bb
                'For i As Int16 = 0 To GridView2.RowCount - 1
                '    unboundData.Add(False)
                'Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            '  dsMain.Dispose()
        End Try
    End Sub

    Private Sub GridView1_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView1.CustomUnboundColumnData
        'If (e.Column.FieldName = "GridColumn20") Then
        '    If (unboundData.Count > e.ListSourceRowIndex) Then 
        '    If (e.IsGetData = True) Then
        '        e.Value = unboundData(e.ListSourceRowIndex)
        '    Else
        '        unboundData(e.ListSourceRowIndex) = e.Value
        '        End If
        '    End If

        'End If
    End Sub

    Private Sub ComboBoxPayMethod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxPayMethod.SelectedIndexChanged
        Try
            Dim PayMethod As String = ComboBoxPayMethod.Text
            LabelControlPayMethod.Text = ""
            If (Not PayMethod Is Nothing) Then
                Dim dataRowList() As DataRow
                dataRowList = dsPayMethod.Tables(0).Select(String.Format("PaymentTypeCode ='{0}'", PayMethod))
                If (Not dataRowList Is Nothing) Then
                    If (dataRowList.Length > 0) Then
                        TextEditPay.Text = dataRowList(0)("Description").ToString()
                        If (dataRowList(0)("NumberRequired").ToString().ToLower() = "true") Then
                            TextEditPayMethodNumber.Enabled = True
                            LabelControlPayMethod.Text = dataRowList(0)("Description").ToString() + " No."
                        Else
                            TextEditPayMethodNumber.Enabled = False
                            LabelControlPayMethod.Text = ""
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        End Try
    End Sub

    Private Function getPaymethod(ByVal number As String, ByVal append As Boolean) As String
        Try
            Dim PayMethod As String = ComboBoxPayMethod.Text
            LabelControlPayMethod.Text = ""
            If (Not PayMethod Is Nothing) Then
                Dim dataRowList() As DataRow
                dataRowList = dsPayMethod.Tables(0).Select(String.Format("PaymentTypeCode ='{0}'", PayMethod))
                If (Not dataRowList Is Nothing) Then
                    If (dataRowList.Length > 0) Then
                        If (dataRowList(0)("NumberRequired").ToString().ToLower() = "true") Then
                            If (append = True) Then
                                getPaymethod = dataRowList(0)("Description").ToString() & "No: " & number
                            Else
                                getPaymethod = dataRowList(0)("Description").ToString()
                            End If
                        Else
                            getPaymethod = ""
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Function


    Private Function getPayTypeDescription(ByVal number As String) As String
        Try
            Dim PayMethod As String = ComboBoxPayMethod.Text
            LabelControlPayMethod.Text = ""
            If (Not PayMethod Is Nothing) Then
                Dim dataRowList() As DataRow
                dataRowList = dsPayMethod.Tables(0).Select(String.Format("PaymentTypeCode ='{0}'", PayMethod))
                If (Not dataRowList Is Nothing) Then
                    If (dataRowList.Length > 0) Then

                        getPayTypeDescription = dataRowList(0)("Description").ToString()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Function

    Private Sub ComboRoom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboRoom.SelectedIndexChanged
        loadPaydata()
    End Sub

    Private Sub loadPaydata()
        Dim Conn As New SqlConnection(ConnString)
        Dim dsKOTBOT As New DataSet
        Dim daMain As New SqlDataAdapter
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()

            ' dcSearch = New SqlCommand("SELECT OB.[BillNo] as 'Bill No' ,OB.[KOTBOTNo] as 'KOTBOT No',OB.[Total],OB.[RoomNo] as 'Room No',g.[GuestName] as 'Guest Name',d.[Description] AS 'Department' FROM [OutLetBillMaster] OB inner join [Guest.RegisterMaster] R on ob.ReservationNo =R.ReservationNo  inner join [Guest.Master] g  on g.GuestID =R.GuestId  inner join [KotBotMaster] k  on k.Id = OB.KOTBOTNo   inner join [DepartmentMaster] d on k.Department = d.DepartmentID Collate SQL_Latin1_General_CP1_CI_AS  where ob.Paid =0 and  OB.[RoomNo] ='" & ComboRoom.Text & "'", Conn)

            dcSearch = New SqlCommand("SELECT dbo.OutLetBillMaster.BillNo AS 'Bill No', dbo.OutLetBillMaster.KOTBOTNo AS 'KOTBOT No', dbo.OutLetBillMaster.RoomNo AS 'Room No', dbo.OutLetBillMaster.Total,dbo.GuestRegistration.FullName AS 'Guest Name', dbo.DepartmentMaster.Description AS 'Department' FROM dbo.OutLetBillMaster INNER JOIN dbo.KotBotMaster ON dbo.OutLetBillMaster.KOTBOTNo = dbo.KotBotMaster.Id INNER JOIN dbo.DepartmentMaster ON dbo.KotBotMaster.Department = dbo.DepartmentMaster.DepartmentID INNER JOIN dbo.GuestRegistration ON dbo.OutLetBillMaster.ReservationNo = dbo.GuestRegistration.ReservationNo and  dbo.OutLetBillMaster.[RoomNo] ='" & ComboRoom.Text & "'", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsKOTBOT)
            If (Not dsKOTBOT Is Nothing) Then
                GridControl1.DataSource = dsKOTBOT.Tables(0)
            End If

            For i As Int16 = 0 To GridView3.RowCount - 1
                unboundDataOutLetBill.Add(False)
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daMain.Dispose()
            '  dsMain.Dispose()
        End Try
    End Sub


    Private Sub SimpleButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButtonSave.Click
        Dim Conn As New SqlConnection
        Dim OutLetBillRecipet As New DataTable
        OutLetBillRecipet.TableName = "OutLetBillRecipet"
        OutLetBillRecipet.Columns.Add("BillNo")
        OutLetBillRecipet.Columns.Add("Date")
        OutLetBillRecipet.Columns.Add("RoomNo")
        OutLetBillRecipet.Columns.Add("ReceiptNo")
        OutLetBillRecipet.Columns.Add("PayMethod")
        OutLetBillRecipet.Columns.Add("amount")
        OutLetBillRecipet.Columns.Add("GuestName")
        OutLetBillRecipet.Columns.Add("PayMethodNo")
        OutLetBillRecipet.Columns.Add("Currency")


        ' OutLetBillRecipet.WriteXmlSchema("c:\\dd.xsd")
        Dim dsOutLetBillRecipet As New DataSet
        Dim dcInsertNewAccDetail As New SqlCommand
        Try
            If (tabMain.SelectedTabPageIndex <> 3) Then
                tabMain.SelectedTabPageIndex = 3
            ElseIf (tabMain.SelectedTabPageIndex = 3) Then
                If (String.IsNullOrEmpty(ComboBoxPayMethod.Text.Trim())) Then
                    MsgBox("Please Select a payment method", MsgBoxStyle.Critical, errTitle)
                    ComboBoxPayMethod.Focus()
                Else
                    'If (String.IsNullOrEmpty(TextEditReciptNumber.Text.Trim())) Then
                    '    MsgBox("Please Enter a Receipt No", MsgBoxStyle.Critical, errTitle)
                    '    TextEditReciptNumber.Focus()
                    'Else
                    Conn = New SqlConnection(ConnString)
                    Dim reciptNo As String = String.Empty '// TextEditReciptNumber.Text.Trim()
                    Dim PayType As String = ComboBoxPayMethod.Text.Trim()
                    Dim DataRowCount As Integer = GridView3.DataRowCount

                    Dim I As Integer
                    For I = 0 To DataRowCount - 1
                        Dim s As String = GridView3.GetRowCellValue(I, "GridColumn24")
                        If (Boolean.Parse(s) = True) Then
                            Conn.Open()
                            Dim drDetail As DataRow = OutLetBillRecipet.NewRow()
                            Dim OutLetBillNo As String = GridView3.GetRowCellValue(I, "Bill No")
                            dcInsertNewAccDetail = New SqlCommand("OutLet_Bill_Pay_SP", Conn)
                            dcInsertNewAccDetail.CommandType = CommandType.StoredProcedure
                            reciptNo = "REC" & OutLetBillNo
                            dcInsertNewAccDetail.Parameters.Add("billNo", SqlDbType.VarChar).Value = OutLetBillNo
                            dcInsertNewAccDetail.Parameters.Add("reciptNo", SqlDbType.VarChar).Value = reciptNo
                            dcInsertNewAccDetail.Parameters.Add("payType", SqlDbType.VarChar).Value = PayType
                            dcInsertNewAccDetail.Parameters.Add("Amount", SqlDbType.Float).Value = GridView3.GetRowCellValue(I, "Total")
                            dcInsertNewAccDetail.Parameters.Add("ChqORCreditCardNumber", SqlDbType.VarChar).Value = TextEditPayMethodNumber.Text


                            dcInsertNewAccDetail.ExecuteNonQuery()
                            Conn.Close()

                            drDetail("BillNo") = OutLetBillNo
                            drDetail("Date") = System.DateTime.Now.ToShortDateString()
                            drDetail("RoomNo") = GridView3.GetRowCellValue(I, "Room No")
                            drDetail("ReceiptNo") = reciptNo
                            drDetail("PayMethod") = getPayTypeDescription(PayType) + " Receipt "
                            drDetail("amount") = GridView3.GetRowCellValue(I, "Total")
                            drDetail("GuestName") = GridView3.GetRowCellValue(I, "Guest Name")
                            drDetail("PayMethodNo") = getPaymethod(TextEditPayMethodNumber.Text, True)
                            drDetail("Currency") = ComboBoxEditCurrency.Text
                            OutLetBillRecipet.Rows.Add(drDetail)

                        End If
                    Next
                    '  End If
                    dsOutLetBillRecipet.Tables.Clear()
                    dsOutLetBillRecipet.Tables.Add(OutLetBillRecipet)
                    ShowReportView(New Receipt, dsOutLetBillRecipet)
                    ' ComboRoom.SelectedIndex = 0
                    loadPaydata()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            dcInsertNewAccDetail.Dispose()
        End Try
    End Sub

    Private Sub GridView3_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView3.CustomUnboundColumnData
        If (e.Column.FieldName = "GridColumn24") Then
            If (unboundDataOutLetBill.Count > e.ListSourceRowIndex) Then
                If (e.IsGetData = True) Then
                    e.Value = unboundDataOutLetBill(e.ListSourceRowIndex)
                Else
                    unboundDataOutLetBill(e.ListSourceRowIndex) = e.Value
                End If
            End If

        End If
    End Sub

    'Private Sub GridView2_CustomUnboundColumnData(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView2.CustomUnboundColumnData
    '    If (e.Column.FieldName = "GridColumn12") Then


    '        If (unboundData.Count > e.ListSourceRowIndex) Then
    '            If (e.IsGetData = True) Then
    '                e.Value = unboundData(e.ListSourceRowIndex)
    '            Else
    '                unboundData(e.ListSourceRowIndex) = e.Value
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub GridView2_CellValueChanging(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanging
    '    If unboundData.Count > 0 Then
    '        Dim I As Integer
    '        For I = 0 To unboundData.Count - 1
    '            unboundData(I) = False
    '        Next
    '    End If
    'End Sub

    Private Sub LoadCurrencyType()
        Dim Conn As New SqlConnection(ConnString)
        Dim daCurrency As New SqlDataAdapter
        Dim dcCurrency As New SqlCommand
        Try
            Conn.Open()
            dcCurrency = New SqlCommand("SELECT [RepCurrencyCode],[RepCurrencyName] ,[SellingRate] ,[BuyingRate] FROM [ExchangeRate.Master] ORDER BY [RepCurrencyCode]", Conn)
            daCurrency = New SqlDataAdapter()
            daCurrency.SelectCommand = dcCurrency
            daCurrency.Fill(dsCurrency)
            Dim Dscount As Integer = dsCurrency.Tables(0).Rows.Count
            Dim DscountTest As Integer
            DscountTest = 0
            ComboBoxEditcurrenc.Properties.Items.Clear()
            While (DscountTest < Dscount)
                ComboBoxEditcurrenc.Properties.Items.Add(dsCurrency.Tables(0).Rows(DscountTest)("RepCurrencyCode").ToString())
                DscountTest = DscountTest + 1
            End While
            ComboBoxEditcurrenc.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errTitle)
        Finally
            Conn.Dispose()
            daCurrency.Dispose()
        End Try
    End Sub
    Private Sub frmKOT_BOT_Billing_MaximizedBoundsChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MaximizedBoundsChanged

    End Sub

    Private Function validateDirectPuircahse() As String
        Dim message = ""
        If (String.IsNullOrEmpty(ComboBoxEditDPurchaseType.Text)) Then
            message = "purcahse type not selected"
        End If

        If (String.IsNullOrEmpty(cmboutletIDDp.Text)) Then
            message = "department not selected"
        End If

        If (String.IsNullOrEmpty(TextEditRoom.Text)) Then
            message = "Room number not given"
        End If

        If (String.IsNullOrEmpty(TextEditGuestName.Text)) Then
            message = "Guest name not given"
        End If

        If (String.IsNullOrEmpty(ComboBoxEditcurrenc.Text)) Then
            message = "currency type not selected"
        End If


        validateDirectPuircahse = message
    End Function

    Private Sub SimpleButtonPayDpurchase_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButtonPayDpurchase.Click
        Try
            Dim message = validateDirectPuircahse()
            If (String.IsNullOrEmpty(message)) Then
                If (tabMain.SelectedTabPageIndex <> 3) Then
                    tabMain.SelectedTabPageIndex = 3
                ElseIf (tabMain.SelectedTabPageIndex = 3) Then
                    If (String.IsNullOrEmpty(ComboBoxPayMethod.Text.Trim())) Then
                        MsgBox("Please Select a Direct Purchase ", MsgBoxStyle.Critical, ErrTitle)
                        ComboBoxPayMethod.Focus()
                    Else
                        Dim kotbotID As String = InsertBillingKOTBOTDirectPurchase()
                        Dim total As String = "0"
                        Dim bill As String = payOutletBillDirectPurchase(kotbotID, total)
                        PayBillReciptDirctPurchasse(bill, total)
                    End If
                End If
            Else
                   MsgBox(message, MsgBoxStyle.Critical, ErrTitle)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
        End Try
    End Sub

    Private Function InsertBillingKOTBOTDirectPurchase() As String
        Dim cnumberPart As String = ""
        Dim ConnStr As String = ConnString
        Dim Conn As New SqlConnection(ConnStr)
        Dim dcInsertNewAcc As New SqlCommand
        Dim dcInsertNewAccDetail As New SqlCommand
        Dim dcUpdateInventory As New SqlCommand

        Dim dateVal As DateTime = Convert.ToDateTime(dtDate.Text)
        Dim intNo As Integer = getNewKotBotNO()
        intNo = intNo + 1
        cnumberPart = intNo.ToString()

        Dim autoid As String = "DP" & cmbType.Text.Trim().ToUpper() & dateVal.Year.ToString().Trim() & dateVal.Month.ToString().Trim() & dateVal.Day.ToString().Trim() & cnumberPart
        'KOT20121004
        Dim KotBotDetails As New DataTable
        Dim TransIns As SqlTransaction
        Dim IsTrans As Boolean = False

        Try
            KotBotDetails.TableName = "KotBotDetails"
            KotBotDetails.Columns.Add("KotBotId")
            KotBotDetails.Columns.Add("ItemCode")
            KotBotDetails.Columns.Add("ItemName")
            KotBotDetails.Columns.Add("Qty")
            KotBotDetails.Columns.Add("UnitPrice")

            Conn.Open()
            TransIns = Conn.BeginTransaction
            IsTrans = True

            Dim DataRowCount As Integer = gvItemDets.DataRowCount
            Dim I As Integer
            For I = 0 To DataRowCount - 1
                Dim drDetail As DataRow = KotBotDetails.NewRow()
                Dim CellValNaME As String = gvItemDets.GetRowCellValue(I, "Itemname")
                Dim CellValItemCode As String = gvItemDets.GetRowCellValue(I, "Itemcode")
                Dim CellValQty As Int32 = gvItemDets.GetRowCellValue(I, "Itemqty")
                Dim CellValPrice As Double = Double.Parse(gvItemDets.GetRowCellValue(I, "Itemprice"))

                drDetail("KotBotId") = autoid
                drDetail("ItemCode") = CellValItemCode
                drDetail("ItemName") = CellValNaME
                drDetail("Qty") = CellValQty.ToString()
                drDetail("UnitPrice") = CellValPrice.ToString()
                KotBotDetails.Rows.Add(drDetail)

                dcInsertNewAccDetail = New SqlCommand("InsertBillingKOTBOTDetail_SP", Conn)
                dcInsertNewAccDetail.Transaction = TransIns

                dcInsertNewAccDetail.CommandType = CommandType.StoredProcedure
                dcInsertNewAccDetail.Parameters.Add("KOTBOTID ", SqlDbType.VarChar).Value = autoid.ToString()
                dcInsertNewAccDetail.Parameters.Add("ItemCode", SqlDbType.VarChar).Value = CellValItemCode
                dcInsertNewAccDetail.Parameters.Add("ItemName", SqlDbType.VarChar).Value = CellValNaME
                dcInsertNewAccDetail.Parameters.Add("Qty", SqlDbType.Int).Value = CellValQty
                dcInsertNewAccDetail.Parameters.Add("UnitPrice", SqlDbType.Money).Value = CellValPrice
                dcInsertNewAccDetail.ExecuteNonQuery()
            Next
            'Conn.Close()

            'Conn.Open()
            dcInsertNewAcc = New SqlCommand("InsertBillingKOTBOT_SP", Conn)
            dcInsertNewAcc.Transaction = TransIns

            dcInsertNewAcc.CommandType = CommandType.StoredProcedure
            dcInsertNewAcc.Parameters.Add("Id", SqlDbType.VarChar).Value = autoid.ToString()
            dcInsertNewAcc.Parameters.Add("Date", SqlDbType.DateTime).Value = DateTime.Now().ToString() 'dtDate.Text.Trim
            dcInsertNewAcc.Parameters.Add("RoomNo", SqlDbType.VarChar).Value = TextEditRoom.Text.Trim
            dcInsertNewAcc.Parameters.Add("BillGenerated", SqlDbType.Bit).Value = False
            dcInsertNewAcc.Parameters.Add("ReservationNo", SqlDbType.VarChar).Value = "Direct"
            dcInsertNewAcc.Parameters.Add("CreatedBy ", SqlDbType.VarChar).Value = ""
            dcInsertNewAcc.Parameters.Add("Type", SqlDbType.VarChar).Value = ComboBoxEditDPurchaseType.Text
            dcInsertNewAcc.Parameters.Add("Department", SqlDbType.VarChar).Value = cmboutletIDDp.Text

            dcInsertNewAcc.ExecuteNonQuery()
            'Conn.Close()
            '----- my sp should come here 'zuhri
            dcUpdateInventory = New SqlCommand("spBilledItemUpdate", Conn)
            dcUpdateInventory.CommandType = CommandType.StoredProcedure
            dcUpdateInventory.Transaction = TransIns

            With dcUpdateInventory.Parameters
                .Add("@BILLNO", SqlDbType.NVarChar).Value = autoid.ToString
                .Add("@ISSUCCESS", SqlDbType.Bit).Direction = ParameterDirection.Output
            End With
            'dcUpdateInventory.Parameters("@ISSUCESS").Direction = ParameterDirection.Output
            dcUpdateInventory.ExecuteNonQuery()

            Dim Result As Boolean = dcUpdateInventory.Parameters("@ISSUCCESS").Value

            If Not Result Then
                Throw New Exception("Update not successfull")
            End If
            '---------------------

            TransIns.Commit()
            IsTrans = False
            'Conn.Close()

            ' MessageBox.Show("Successfully saved", "Add KOT/BOT Billing Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Dim rmsDbDataSet As New DataSet
            'rmsDbDataSet.DataSetName = "rmsDbDataSet"
            'Dim KotBotMaster As New DataTable

            'KotBotMaster.TableName = "KotBotMaster"
            'KotBotMaster.Columns.Add("id")
            'KotBotMaster.Columns.Add("Date")
            'KotBotMaster.Columns.Add("RoomNo")
            'KotBotMaster.Columns.Add("ReservationNo")
            'KotBotMaster.Columns.Add("Type")
            'KotBotMaster.Columns.Add("Department")
            'KotBotMaster.Columns.Add("GuestName")
            'KotBotMaster.Columns.Add("BillNo")

            'Dim s As DataRow = KotBotMaster.NewRow()
            's("id") = autoid.ToString()
            's("Date") = DateTime.Now().ToString()
            's("RoomNo") = cmbRmNo.Text.Trim
            's("ReservationNo") = txtResNo.Text
            's("Type") = cmbType.Text
            's("Department") = txtOutlet.Text
            's("GuestName") = txtGuest.Text
            's("BillNo") = autoid.ToString()
            'KotBotMaster.Rows.Add(s)

            'rmsDbDataSet.Tables.Add(KotBotMaster)
            'rmsDbDataSet.Tables.Add(KotBotDetails)
            'ShowReportView(New Kot_Bot_Invoice, rmsDbDataSet)
            'loadKotDataGrid()
            InsertBillingKOTBOTDirectPurchase = autoid
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            If IsTrans Then
                TransIns.Rollback()
            End If

            Conn.Dispose()
            dcInsertNewAcc.Dispose()
            dcInsertNewAccDetail.Dispose()
            dcUpdateInventory.Dispose()
        End Try
        TransIns.Dispose()
    End Function

    Private Sub cmboutletIDDp_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmboutletIDDp.SelectedIndexChanged
        LoadDepartment(cmboutletIDDp.Text, 3)
        LoadCombosDp(cmboutletIDDp.Text)
    End Sub

    Sub LoadCombosDp(ByVal depNo As String)
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets, daGridLookup As New SqlDataAdapter()
        Dim dsShow, dsGridLookup As New DataSet
        Try
            daGridLookup = New SqlDataAdapter(" SELECT its.[Itemcode],it.[Description],its.[SellingPrice] FROM [ItemSellingDetail] its inner join dbo.ItemMaster It on IT.Itemcode=its.Itemcode  WHERE its.[DepartmentID]='" & depNo & "'", Conn)
            daGridLookup.Fill(dsGridLookup)
            dsItemList = dsGridLookup

            For i As Integer = 0 To dsGridLookup.Tables(0).Rows.Count - 1
                RepositoryItemComboBox1.Items.Add(dsGridLookup.Tables(0).Rows(i).Item(0))
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
            daGridLookup.Dispose()
            dsGridLookup.Dispose()
        End Try
    End Sub

    Private Sub GridView5_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView5.CellValueChanged
        If e.Column.FieldName = "Itemcode" And String.IsNullOrEmpty(Itemcode) Then
            If (Not IsDBNull(e.Value)) Then
                Dim RefBillNo As String = e.Value
                frmItemSelection.frmHandle = Me
                frmItemSelection.InvLocation = cmboutletIDDp.Text
                Me.frmGridRow = e.RowHandle
                frmItemSelection.Show()
                'Me.Enabled = False
            End If
        ElseIf e.Column.FieldName = "Itemqty" Then
            If IsDBNull(e.Value) Or IsDBNull(GridView5.GetRowCellValue(e.RowHandle, "Itemcode")) Then
                Exit Sub
            End If
            If (Not IsDBNull(e.Value)) And Not IsNonInvItem(GridView5.GetRowCellValue(e.RowHandle, "Itemcode")) Then
                If e.Value > GridView5.GetFocusedRowCellValue("TotQty") And String.IsNullOrEmpty(Itemcode) Then
                    MsgBox("You can't bill more than stock", MsgBoxStyle.Critical, ErrTitle)
                    GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "Itemqty", 0)
                End If
            End If
        End If
    End Sub
    Private Sub GridView5_InitNewRow(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView5.InitNewRow
        If GridView5.RowCount > 0 Then
            If GridView5.GetRowCellValue(GridView5.RowCount - 1, "Itemcode") = "" Then
                Exit Sub
            End If
            GridView5.SetRowCellValue(e.RowHandle, "Itemcode", Guid.NewGuid)
        End If
    End Sub

    Private Sub GridView2_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        Dim view As GridView = DirectCast(sender, GridView)
        If (view.IsFilterRow(e.PrevFocusedRowHandle)) Then
            view.SelectRow(e.FocusedRowHandle)
        End If
        'if (view.IsFilterRow(e.PrevFocusedRowHandle)) {
        '   view.SelectRow(e.FocusedRowHandle);
    End Sub

    Private Sub ComboBoxEditRoom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxEditRoom.SelectedIndexChanged
        LoadKOTBOTDataOutLetByRoom(ComboBoxEditRoom.Text)
    End Sub

    Private Sub cmbType_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbType.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmboutletID.Focus()
        End If
    End Sub

    Private Sub cmboutletID_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cmboutletID.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbRmNo.Focus()
        End If
    End Sub

    Private Sub cmbRmNo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbRmNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbWaiter.Focus()
        End If
    End Sub

    Private Sub ComboBoxEditRoom_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxEditRoom.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBoxEditDiscount.Focus()
        End If
    End Sub

    Private Sub ComboBoxEditDiscount_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxEditDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridControlOutLetBill.Focus()
        End If
    End Sub

    'Private Sub tabMain_TabStopChanged(sender As System.Object, e As System.EventArgs) Handles tabMain.TabStopChanged
    '    If (tabMain.SelectedTabPageIndex = 2) Then
    '        ComboBoxEditRoom.Focus()
    '        ComboBoxEditRoom.Select()

    '    End If

    '    If (tabMain.SelectedTabPageIndex = 2) Then
    '        LoadDepartmentsForOutLetBill()
    '    End If
    'End Sub

    Private Sub XtraTabPage2_TabIndexChanged(sender As System.Object, e As System.EventArgs) Handles XtraTabPage2.TabIndexChanged

        If (tabMain.SelectedTabPageIndex = 1) Then
            cmbType.Focus()
            cmbType.Select()
        End If

        If (tabMain.SelectedTabPageIndex = 2) Then
            ComboBoxEditRoom.Focus()
            ComboBoxEditRoom.Select()

        End If
    End Sub

    Private Sub cmbType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.EditValueChanged



        cmbRmNo.Properties.Items.Clear()
        cmbRmNo.Refresh()

        LoadRoomNo()



        LoadDepartmentIDbyKOTBOT(cmbType.Text.Trim)

        If cmbType.Text.Trim = "BCOM" Then
            cmbRmNo.Text = "STAFF"

            cmbEmpType.Visible = True
            cbEmp.Visible = True

            txtGuest.Text = ""

            ' txtGuest.Properties.ReadOnly = True

        Else

            cmbEmpType.Visible = False
            cbEmp.Visible = False
            cbOthers.Visible = False


            txtGuest.Text = ""

            ' txtGuest.Properties.ReadOnly = True

        End If
    End Sub
    Private Sub LoadEmp(ByVal PassEmpType As String)

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getEmpType As String = PassEmpType

            Conn.Open()
            dcSearch = New SqlCommand("select Empno,EmpName from [Emp] where Status='OPEN' AND Category=@Category order by Empno", Conn)
            dcSearch.Parameters.Add("@Category", SqlDbType.NVarChar).Value = getEmpType

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            Dim DscountTest As Integer

            Dim newCustomersRow As DataRow = dsMain.Tables(0).NewRow()


            'While (DscountTest < Dscount)

            '    cbTopcode2.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
            '    DscountTest = DscountTest + 1

            'End While

            With cbEmp.Properties
                .DataSource = dsMain.Tables(0)
                .DisplayMember = "EmpName"
                .ValueMember = "EmpName"
                .Columns(0).Width = 100
                .Columns(1).Width = 150
                .PopupWidth = 400
                .AutoSearchColumnIndex = 1
                .TextEditStyle = True

            End With

            'cbTopcode2.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub
    Private Sub LoadBillingothers()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try



            Conn.Open()
            dcSearch = New SqlCommand("select Id,Description from BillingOthers order by Id", Conn)


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim Dscount As Integer = dsMain.Tables(0).Rows.Count
            'Dim DscountTest As Integer



            'Dim newCustomersRow As DataRow = dsMain.Tables(0).NewRow()


            'While (DscountTest < Dscount)

            '    cbTopcode2.Properties.Items.Add(dsMain.Tables(0).Rows(DscountTest)(0).ToString())
            '    DscountTest = DscountTest + 1

            'End While

            With cbOthers.Properties
                .DataSource = dsMain.Tables(0)
                .DisplayMember = "Description"
                .ValueMember = "Description"
                .Columns(0).Width = 100
                .Columns(1).Width = 150
                .PopupWidth = 400
                .AutoSearchColumnIndex = 1
                .TextEditStyle = True

            End With

            'cbTopcode2.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try
    End Sub

    Private Sub btStaffbill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStaffbill.Click
        LoadKOTBOTDataOutLetByStaff()
    End Sub

    Private Sub txtGuest_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuest.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub frmKOT_BOT_Billing_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then


            If btnBilling.Text = "Add KOT/BOT" Then
                btnBilling_Click(sender, New System.EventArgs())
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub XtraTabPage2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles XtraTabPage2.Paint

    End Sub

    Private Sub txtManualnos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtManualnos.KeyPress
        gvItemDets.OptionsBehavior.Editable = True
    End Sub

    Private Sub cmbEmpType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpType.SelectedIndexChanged

        cbEmp.Properties.DataSource = Nothing

        

        If cmbEmpType.Text.Trim = "OTHERS" Then



            cbEmp.Visible = False

            txtGuest.Text = ""
            cbOthers.Visible = True



            LoadBillingothers()


        Else

            txtGuest.Text = ""
            cbOthers.Visible = False
            cbEmp.Visible = True
            LoadEmp(cmbEmpType.Text.Trim)

        End If



    End Sub
    Private Sub LoadResDetails(ByVal Resno As String)
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getResno As String = Resno

            Conn.Open()
            dcSearch = New SqlCommand("select MEALPLAN  from dbo.[Reservation.Master] where ResNo=@ResNo", Conn)
            dcSearch.Parameters.Add("@ResNo", SqlDbType.VarChar).Value = getResno


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)



            If dsMain Is Nothing Then
                Dim ddd As Integer = 0

            Else


                If dsMain.Tables(0).Rows.Count > 0 Then

                    If (Not IsDBNull(dsMain.Tables(0).Rows(0).Item("MEALPLAN"))) Then

                        PubMPAI = dsMain.Tables(0).Rows(0).Item("MEALPLAN")

                    Else
                        PubMPAI = ""
                    End If


                End If

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub
    Private Sub LoadAIItems(ByVal ItemCode As String)
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try

            Dim getItemCode As String = ItemCode

            Conn.Open()
            dcSearch = New SqlCommand("select Notes from Itemmaster where Itemcode=@Itemcode and status=1", Conn)
            dcSearch.Parameters.Add("@Itemcode", SqlDbType.VarChar).Value = getItemCode


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)



            If dsMain Is Nothing Then
                Dim ddd As Integer = 0

            Else


                If dsMain.Tables(0).Rows.Count > 0 Then

                    If (Not IsDBNull(dsMain.Tables(0).Rows(0).Item("Notes"))) Then

                        PubItemAI = dsMain.Tables(0).Rows(0).Item("Notes")

                    Else
                        PubItemAI = ""

                    End If


                End If

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub

    Private Sub cbEmp_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEmp.EditValueChanged

        txtGuest.Text = cbEmp.Text

    End Sub

    Private Sub cmbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged

        'cmbRmNo.Properties.Items.Clear()
        'cmbRmNo.Refresh()

        'LoadRoomNo()

        ' LoadDepartmentIDbyKOTBOT(cmbType.Text.Trim)
    End Sub

    Private Sub cmbType_DrawItem(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.ListBoxDrawItemEventArgs) Handles cmbType.DrawItem

    End Sub

    Private Sub cmbWaiter_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbWaiter.KeyDown
        If e.KeyCode = Keys.Enter Then


            If cmboutletID.Text <> "Mishrapshop" Then



                If cmbWaiter.Text = "" Then
                    MsgBox("Please Select Waiter No")

                Else
                    txtManualnos.Focus()

                End If


            Else


                txtManualnos.Focus()




            End If


        End If
    End Sub

    Private Sub txtManualnos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtManualnos.KeyDown

        If e.KeyCode = Keys.Enter Then

            If txtManualnos.Text = "" Then
                MsgBox("Please Enter Manual Bill No")

            Else
                gridItemDets.Focus()

            End If


        End If


    End Sub

    Private Sub cbOthers_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        txtGuest.Text = cbOthers.Text
    End Sub

    Private Sub cmbEmpType_QueryPopUp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbEmpType.QueryPopUp

    End Sub

    Private Sub cbOthers_EditValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbOthers.EditValueChanged
        txtGuest.Text = cbOthers.Text
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "KOTBOTBilling", "Add")

        If CheckAccess = True Then


            GetServerDate()

            cmbType.Focus()



            If String.Compare(SimpleButton1.Text, "Add To List", False) = 0 Then
                ' ClearFields()
                SimpleButton1.Text = "Save To List"
                btnCreateBilling.Enabled = False
                btnInactive.Enabled = False
                btnBilling.Enabled = False
                'btnBlock.Enabled = False
                tabMain.SelectedTabPageIndex = 2

                tabMain.TabPages(2).PageEnabled = True
                tabMain.TabPages(1).PageEnabled = False
                tabMain.TabPages(0).PageEnabled = False




            Else
                If (Not String.IsNullOrEmpty(txtGuest.Text)) Then
                    If (mode = "Edit") Then
                        mode = ""
                    Else
                        Dim dscheckAddbefore As New DataSet
                        dscheckAddbefore = DSCheckInsertBillingTemp()
                        If dscheckAddbefore Is Nothing Then

                            If (txtManualnos.Text = "" Or cmbWaiter.Text = "") And cmboutletID.Text <> "Mishrapshop" Then


                                MessageBox.Show("Enter Manual Bill/Waiter No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                                Exit Sub
                            Else


                                '------------------------------------------------
                                Dim dscheckBillAddbefore As New DataSet
                                dscheckBillAddbefore = DSCheckAddTempBillNo()

                                If dscheckBillAddbefore.Tables(0) Is DBNull.Value Then
                                    Exit Sub
                                Else
                                    If dscheckBillAddbefore.Tables(0).Rows.Count > 0 Then

                                        PubTempBillCheck = 1
                                        InsertBillingKOTBOTempAlreadyAdd()
                                        UpdateManualBillNo(txtManualnos.Text)

                                    Else

                                        PubTempBillCheck = 0

                                        InsertBillingKOTBOTemp()


                                    End If

                                End If



                                '-------------------------------------------------


                                'InsertBillingKOTBOT()
                                LoadKOTBOTDataOutLet(ComboDept.Text)

                                loadPendingKotDataGrid()

                                'LoadGridDets()

                                tabMain.TabPages(2).PageEnabled = False
                                tabMain.TabPages(0).PageEnabled = True
                                cmbWaiter.SelectedIndex = -1

                            End If

                        Else
                            MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End If
                        ' LoadGrid()
                        SimpleButton1.Text = "Add To List"

                        btnBilling.Text = "Add Final"

                        btnCreateBilling.Enabled = True
                        btnInactive.Enabled = True
                        btnBilling.Enabled = True
                        tabMain.SelectedTabPageIndex = 0
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Please define a guest ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            End If

            ' End If

            'GridControlOutLetBill.DataSource = Nothing


            'txtManualnos.Text = ""
            'txtResNo.Text = ""

            'cmbType.SelectedIndex = 0
            'cmboutletID.SelectedIndex = 0

            'cmbRmNo.SelectedIndex = 0
            'txtGuest.Text = ""


            'cmbEmpType.Visible = False
            'cbEmp.Visible = False
            ' cbOthers.Visible = False


            '--------------------------------------------------------------------------------------

















        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub GvKotBotPendings_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GvKotBotPendings.DoubleClick
        ShowFieldsTemp(GvKotBotPendings.GetFocusedRowCellValue("KOTBOTNo"))
    End Sub

    Private Sub GvKotBotPendings_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GvKotBotPendings.InvalidRowException

    End Sub

    Private Sub btViewbilllist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btViewbilllist.Click

        LoadbillList(cmbBilllist.Text.Trim, cmbRoombilllist.Text.Trim)

    End Sub

    Private Sub btReprintbills_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReprintbills.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "OutletBilling", "Add")

        If CheckAccess = True Then

            PrintBillList(PubGetbillnoList)

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub gvBilllist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gvBilllist.Click
        PubGetbillnoList = gvBilllist.GetRowCellValue(gvBilllist.FocusedRowHandle, "BillNo")
        PubGetMasbillnoList = gvBilllist.GetRowCellValue(gvBilllist.FocusedRowHandle, "OutletMasBill")
    End Sub

    Private Sub cmbType_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbType.KeyPress


        'If CType(sender, ComboBox).FindString(CType(sender, ComboBox).Text, 1) = True Then
        '    'if it doesnt exist then remove the last character/s that dont match and set the cursor position to the end
        '    CType(sender, ComboBox).Text = CType(sender, ComboBox).Text.Substring(0, CType(sender, ComboBox).Text.Length - 1)
        '    CType(sender, ComboBox).SelectionStart = CType(sender, ComboBox).Text.Length
        '    e.Handled = True
        '    ' accepting backspase

        '    If Asc(e.KeyChar) = 8 Then
        '        e.Handled = True
        '    End If



        'End If


        e.Handled = True



    End Sub

    Private Sub cmboutletID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmboutletID.KeyPress

        e.Handled = True

    End Sub
End Class
