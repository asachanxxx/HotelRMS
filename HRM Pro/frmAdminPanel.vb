Imports System.Data.SqlClient

Public Class frmAdminPanel

    Private Shared Function GetTempTab() As DataTable
        Dim TempTab As New DataTable
        Return TempTab
    End Function

    Private Sub frmAdminPanel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        loadGroups()

        LoadGroupPanelDetails()
    End Sub

    Sub loadGroups()
        Dim Conn As New SqlConnection(ConnString)
        Dim dashow As New SqlDataAdapter("select ID,Name,Description from [Admin.Usergroups]", Conn)
        Dim dsShow As New DataSet

        Try
            dashow.Fill(dsShow)

            With cmbGroups.Properties
                .DataSource = dsShow.Tables(0)
                .DisplayMember = "Name"
                .ValueMember = "ID"
                .NullText = ""
            End With
            'cmbGroups.Properties
        Catch ex As Exception

            MsgBox(ex.Message, , ErrTitle)

        Finally
            Conn.Dispose()
            dashow.Dispose()
            dsShow.Dispose()
        End Try

    End Sub
    Sub LoadGroupPanelDetails()

        Dim Conn As New SqlConnection(ConnString)
        Dim dashow As New SqlDataAdapter("select * from Adminpanel where groupid like 'nothing'", Conn)
        Dim dsShow As New DataSet

        Try

            'Dim gpTable As New DataTable

            'Dim datacol As New DataColumn("IsSelect", System.Type.GetType("System.Boolean"))

            'gpTable.Columns.Add(datacol)


            dashow.Fill(dsShow)



            Dim TempTab As DataTable = dsShow.Tables(0) ' GetTempTab()
            Dim datacol As New DataColumn("IsSelect", System.Type.GetType("System.Boolean"))

            dsShow.Tables(0).Columns.Add(datacol)

            Dim NewRow As DataRow = TempTab.NewRow

            NewRow.Item("ProcessHeader") = "BoatMaster"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow

            NewRow.Item("ProcessHeader") = "FlightMaster"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "TourOperatorMaster"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "EventDetailsMaster"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "RoomRates"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "DiscountPlan"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "MealPlans"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "All Inclusive Rates"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "TourOperatorContracts Master"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "SeaConditionMaster"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "ExchangeRateMaster"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Discount Billing"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "TaxMaster"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "PriceListMaster"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Cocktails"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "KitchenFoodRecipes"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Amentities"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Boat Rates"
            TempTab.Rows.Add(NewRow)


            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Foodcosting"
            TempTab.Rows.Add(NewRow)


            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Room Master"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Item Adjustment"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "ItemTemp"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Items"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "ItemCategory"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "SupplierMaster"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "DepartmentMaster"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Reservation"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "GuestRegistration"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "GuestProfile"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "GuestReminder"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "RoomStatus"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "ForecastDetails"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "ArrivalDepartureExpected"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "AssignRoom"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "BoatScheduling"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "EventBoard"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "GuestFeedbackAndComments"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Room number Change"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Room Block"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Room Allocation Edit"
            TempTab.Rows.Add(NewRow)


            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Checkout"
            TempTab.Rows.Add(NewRow)


            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "KOTBOTBilling"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "OutletBilling"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "DirectPurchase"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Master billing-Temp"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Master billing"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Pro-formaInvoicing"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "TaxInvoicing"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "CrDbNote"
            TempTab.Rows.Add(NewRow)


            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Payments"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "PaymentsVerification"
            TempTab.Rows.Add(NewRow)


            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Housekeeping"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "GINSforMiniBar"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "ItemRequest"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "PurchaseRequisitions"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "GeneratePurchaseOrders"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "BoatNote"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "GoodReceivedNote"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Kitchen Item Consumption"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "GoodIssuedNote"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Item write off"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Messenger"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "RoomStatusGraphicalFormat"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Directory"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Report Front Office"
            TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Report Back Office"
            TempTab.Rows.Add(NewRow)

            'NewRow = TempTab.NewRow
            'NewRow.Item("ProcessHeader") = "Authorize"
            'TempTab.Rows.Add(NewRow)

            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Report Inventory"
            TempTab.Rows.Add(NewRow)


            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Employee Master"
            TempTab.Rows.Add(NewRow)


            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "Manual Checkout"
            TempTab.Rows.Add(NewRow)


            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "DB Backup"
            TempTab.Rows.Add(NewRow)


            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "MP Change"
            TempTab.Rows.Add(NewRow)


            NewRow = TempTab.NewRow
            NewRow.Item("ProcessHeader") = "RoomBill Change"
            TempTab.Rows.Add(NewRow)

            

            gcMain.DataSource = TempTab

            For i As Int16 = 0 To TempTab.Rows.Count - 1
                For j As Int16 = 0 To TempTab.Columns.Count - 1

                    If TempTab.Columns(j).ColumnName <> "ProcessHeader" Then
                        TempTab.Rows(i).Item(j) = 0
                    End If

                    
                Next

                'MsgBox(TempTab.Columns(i).ColumnName)
                'MsgBox()
            Next



        Catch ex As Exception
            MsgBox(ex.Message, , ErrTitle)
        Finally
            Conn.Dispose()
            dashow.Dispose()
            dsShow.Dispose()
        End Try

    End Sub


    ''' <summary>
    ''' When user group changed, need to shows relevant portion of syste authentication level.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmbGroups_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbGroups.EditValueChanged
        ShowGroupPermission(cmbGroups.GetColumnValue("ID"))
    End Sub

    Function ShowGroupPermission(ByVal GroupID As String) As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim daGetDetz As New SqlDataAdapter("select * from Adminpanel where groupid like '" & GroupID & "'", Conn)
        Dim dsShowGroups As New DataSet


        Try

            LoadGroupPanelDetails()

            daGetDetz.Fill(dsShowGroups)

            For i As Int16 = 0 To dsShowGroups.Tables(0).Rows.Count - 1
                For j As Int16 = 0 To gvMain.RowCount - 1

                    If dsShowGroups.Tables(0).Rows(i).Item("ProcessHeader") = gvMain.GetRowCellValue(j, "ProcessHeader") Then
                        gvMain.SetRowCellValue(j, "Add", IIf(IsDBNull(dsShowGroups.Tables(0).Rows(i).Item("Add")), 0, dsShowGroups.Tables(0).Rows(i).Item("Add")))
                        gvMain.SetRowCellValue(j, "Edit", IIf(IsDBNull(dsShowGroups.Tables(0).Rows(i).Item("Edit")), 0, dsShowGroups.Tables(0).Rows(i).Item("Edit")))
                        gvMain.SetRowCellValue(j, "Delete", IIf(IsDBNull(dsShowGroups.Tables(0).Rows(i).Item("Delete")), 0, dsShowGroups.Tables(0).Rows(i).Item("Delete")))
                        gvMain.SetRowCellValue(j, "View", IIf(IsDBNull(dsShowGroups.Tables(0).Rows(i).Item("View")), 0, dsShowGroups.Tables(0).Rows(i).Item("View")))
                        gvMain.SetRowCellValue(j, "Authorize", IIf(IsDBNull(dsShowGroups.Tables(0).Rows(i).Item("Authorize")), 0, dsShowGroups.Tables(0).Rows(i).Item("Authorize")))
                        gvMain.SetRowCellValue(j, "Certify", IIf(IsDBNull(dsShowGroups.Tables(0).Rows(i).Item("Certify")), 0, dsShowGroups.Tables(0).Rows(i).Item("Certify")))
                        gvMain.SetRowCellValue(j, "Print", IIf(IsDBNull(dsShowGroups.Tables(0).Rows(i).Item("Print")), 0, dsShowGroups.Tables(0).Rows(i).Item("Print")))
                        gvMain.SetRowCellValue(j, "Reverse", IIf(IsDBNull(dsShowGroups.Tables(0).Rows(i).Item("Reverse")), 0, dsShowGroups.Tables(0).Rows(i).Item("Reverse")))
                        gvMain.SetRowCellValue(j, "PayBill", IIf(IsDBNull(dsShowGroups.Tables(0).Rows(i).Item("PayBill")), 0, dsShowGroups.Tables(0).Rows(i).Item("PayBill")))
                        gvMain.SetRowCellValue(j, "MasterBill", IIf(IsDBNull(dsShowGroups.Tables(0).Rows(i).Item("MasterBill")), 0, dsShowGroups.Tables(0).Rows(i).Item("MasterBill")))
                        gvMain.SetRowCellValue(j, "DirectPurchase", IIf(IsDBNull(dsShowGroups.Tables(0).Rows(i).Item("DirectPurchase")), 0, dsShowGroups.Tables(0).Rows(i).Item("DirectPurchase")))
                        gvMain.SetRowCellValue(j, "ItemWriteOff", IIf(IsDBNull(dsShowGroups.Tables(0).Rows(i).Item("ItemWriteOff")), 0, dsShowGroups.Tables(0).Rows(i).Item("ItemWriteOff")))
                        gvMain.SetRowCellValue(j, "Block", IIf(IsDBNull(dsShowGroups.Tables(0).Rows(i).Item("Block")), 0, dsShowGroups.Tables(0).Rows(i).Item("Block")))
                        gvMain.SetRowCellValue(j, "UnBlock", IIf(IsDBNull(dsShowGroups.Tables(0).Rows(i).Item("UnBlock")), 0, dsShowGroups.Tables(0).Rows(i).Item("UnBlock")))
                        gvMain.SetRowCellValue(j, "Approve", IIf(IsDBNull(dsShowGroups.Tables(0).Rows(i).Item("Approve")), 0, dsShowGroups.Tables(0).Rows(i).Item("Approve")))
                    End If
                Next
            Next

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Conn.Dispose()
            daGetDetz.Dispose()
            dsShowGroups.Dispose()
        End Try

    End Function

    Private Sub gvMain_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvMain.CellValueChanged
        If e.Column.FieldName <> "IsSelect" Then
            ValidateIsSelect()


        End If


    End Sub


    Sub ValidateIsSelect()



        Dim IsSelect As Boolean '= False


        For i As Int16 = 0 To gvMain.RowCount - 1
            IsSelect = False

            For j As Int16 = 2 To gvMain.Columns.Count - 1
                If gvMain.GetRowCellValue(i, gvMain.Columns(j)) Then
                    IsSelect = True
                End If
                'If gvMain.Columns(j).ColumnEdit.ToString = "gvCheck" Then

                'End If
            Next

            'If IsSelect Then
            gvMain.SetRowCellValue(i, "IsSelect", IsSelect)
            ' End If
        Next
    End Sub

    Sub UpdateUserPermission()
        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand
        Dim InsTrans As SqlTransaction
        Dim IsTrans As Boolean = False
        Dim daIsExists As New SqlDataAdapter()
        Dim dsGetDetz As New DataSet
        Dim sqlStr As String
        Dim dcSearch As New SqlCommand

        Try
            Conn.Open()

            

            For i As Int16 = 0 To gvMain.RowCount - 1

                If gvMain.GetRowCellValue(i, "IsSelect") Then
                    'Conn.Open()
                    sqlStr = "select * from adminpanel where ProcessHeader ='" & gvMain.GetRowCellValue(i, "ProcessHeader") & "' and groupid = '" & cmbGroups.GetColumnValue("ID") & "'"
                    dcSearch = New SqlCommand(sqlStr, Conn)
                    Dim drGet As SqlDataReader = dcSearch.ExecuteReader()

                    If Not drGet.Read Then
                        drGet.Close()

                        InsTrans = Conn.BeginTransaction
                        IsTrans = True

                        sqlStr = "insert into adminpanel (groupid,groupname,processheader) values('" & cmbGroups.GetColumnValue("ID") & "','" & cmbGroups.GetColumnValue("Name") & "','" & gvMain.GetRowCellValue(i, "ProcessHeader") & "')"
                        dcExec = New SqlCommand(sqlStr, Conn)
                        dcExec.Transaction = InsTrans
                        dcExec.ExecuteNonQuery()
                        'If Not drGet.HasRows Then

                        '    MsgBox(drGet.Item("processheader"))
                        'End If
                        InsTrans.Commit()
                        IsTrans = False
                    End If

                    drGet.Close()

                    'daIsExists = New SqlDataAdapter() '(sqlStr, Conn)
                    'daIsExists.SelectCommand = dcSearch
                    'daIsExists.Fill(dsGetDetz)

                    'If dsGetDetz.Tables(0).Rows.Count = 0 Then

                    '    InsTrans = Conn.BeginTransaction
                    '    IsTrans = True

                    '    sqlStr = "insert into adminpanel (groupid,groupname,processheader) values('" & cmbGroups.GetColumnValue("ID") & "','" & cmbGroups.GetColumnValue("Name") & "','" & gvMain.GetRowCellValue(i, "ProcessHeader") & "')"
                    '    dcExec = New SqlCommand(sqlStr, Conn)
                    '    dcExec.Transaction = InsTrans
                    '    dcExec.ExecuteNonQuery()


                    'End If



                    'sqlStr = " update adminpanel set [ADD]=" & gvMain.GetRowCellValue(i, "Add") & ",Edit=" & gvMain.GetRowCellValue(i, "Edit") & ",[Delete]=" & gvMain.GetRowCellValue(i, "Edit") & _
                    '    ",[View]=" & gvMain.GetRowCellValue(i, gvMain.GetRowCellValue(i, "View")) & ",Authorize=" & gvMain.GetRowCellValue(i, "Authorize") & ",Certify=" & gvMain.GetRowCellValue(i, "Certify") & ",[Print]=" & gvMain.GetRowCellValue(i, "Print") & ",Reverse=" & gvMain.GetRowCellValue(i, "Reverse") & ",PayBill=" & gvMain.GetRowCellValue(i, "PayBill") & ",MasterBill=" & gvMain.GetRowCellValue(i, "MasterBill") & ",DirectPurchase=" & _
                    '    gvMain.GetRowCellValue(i, "DirectPurchase") & ",ItemWriteOff=" & gvMain.GetRowCellValue(i, "ItemWriteOff") & ",Block=" & gvMain.GetRowCellValue(i, "Block") & ",UnBlock=" & gvMain.GetRowCellValue(i, "UnBlock") & ",Approve=" & gvMain.GetRowCellValue(i, "Approve") & " where groupid like '" & cmbGroups.GetColumnValue("GroupID") & "'"

                    sqlStr = " update adminpanel set [ADD]=" & IIf(gvMain.GetRowCellValue(i, "Add") = True, 1, 0) & _
                                ",Edit=" & IIf(gvMain.GetRowCellValue(i, "Edit") = True, 1, 0) & ",[Delete]=" & IIf(gvMain.GetRowCellValue(i, "Delete") = True, 1, 0) & _
                        ",[View]=" & IIf(gvMain.GetRowCellValue(i, "View") = True, 1, 0) & ",Authorize=" & IIf(gvMain.GetRowCellValue(i, "Authorize") = True, 1, 0) & _
                        ",Certify=" & IIf(gvMain.GetRowCellValue(i, "Certify") = True, 1, 0) & ",[Print]=" & IIf(gvMain.GetRowCellValue(i, "Print") = True, 1, 0) & ",Reverse=" & _
                        IIf(gvMain.GetRowCellValue(i, "Reverse") = True, 1, 0) & ",PayBill=" & IIf(gvMain.GetRowCellValue(i, "PayBill") = True, 1, 0) & ",MasterBill=" & _
                        IIf(gvMain.GetRowCellValue(i, "MasterBill") = True, 1, 0) & ",DirectPurchase=" & _
                        IIf(gvMain.GetRowCellValue(i, "DirectPurchase") = True, 1, 0) & ",ItemWriteOff=" & IIf(gvMain.GetRowCellValue(i, "ItemWriteOff") = True, 1, 0) & _
                        ",Block=" & IIf(gvMain.GetRowCellValue(i, "Block") = True, 1, 0) & ",UnBlock=" & IIf(gvMain.GetRowCellValue(i, "UnBlock") = True, 1, 0) & _
                        ",Approve=" & IIf(gvMain.GetRowCellValue(i, "Approve") = True, 1, 0) & " where groupid like '" & cmbGroups.GetColumnValue("ID") & "' and ProcessHeader like '" & gvMain.GetRowCellValue(i, "ProcessHeader") & "'"


                    InsTrans = Conn.BeginTransaction
                    IsTrans = True

                    'sqlStr = " update adminpanel set [ADD]=" & IIf(gvMain.GetRowCellValue(i, "Add") = True, 1, 0) & " where groupid like '" & cmbGroups.GetColumnValue("GroupID") & "'"

                    dcExec = New SqlCommand(sqlStr, Conn)
                    dcExec.Transaction = InsTrans
                    dcExec.ExecuteNonQuery()

                    InsTrans.Commit()
                    IsTrans = False

                Else
                    InsTrans = Conn.BeginTransaction
                    IsTrans = True

                    dcExec = New SqlCommand("Delete from Adminpanel where groupid like '" & cmbGroups.GetColumnValue("GroupID") & "' and ProcessHeader like '" & gvMain.GetRowCellValue(i, "ProcessHeader") & "'", Conn)
                    dcExec.Transaction = InsTrans
                    dcExec.ExecuteNonQuery()

                    InsTrans.Commit()
                    IsTrans = False
                End If

                dsGetDetz.Dispose()
                daIsExists.Dispose()
                dcSearch.Dispose()
            Next

           
            'InsTrans.Rollback()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            dcExec.Dispose()

            If IsTrans Then
                InsTrans.Rollback()
            End If
        End Try

    End Sub

    Private Sub cmdUpdate_Click(sender As System.Object, e As System.EventArgs) Handles cmdUpdate.Click
        UpdateUserPermission()
    End Sub
End Class