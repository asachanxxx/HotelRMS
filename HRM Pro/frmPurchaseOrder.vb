
Imports System.Data.SqlClient

Public Class frmPurchaseOrder

#Region " Proc & Functions "

    Sub ClearFields()

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter("select * from POMaster where status=1", Conn)
        Dim dsShow As New DataSet

        Dim dcDel As New SqlCommand



        Try

            Conn.Open()

            txtReference.Text = ""
            txtReqID.Text = GetPOCode()
            txtRequestBy.Text = CurrUser
            cmbPriority.Text = "Medium"
            txtUIDMaster.Text = Guid.NewGuid.ToString()

            txtPRPriority.Text = ""
            txtPRRef.Text = ""
            txtPRDate.Text = ""



            dcDel = New SqlCommand(String.Format("delete from potemporary where curruser like '{0}'", CurrUser), Conn)
            dcDel.ExecuteNonQuery()


            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            daGetDets = New SqlDataAdapter("select * from poreqtemporary where itemcode like 'nothing'", Conn)
            daGetDets.Fill(dsShow)

            gridItemDets.DataSource = dsShow.Tables(0)

            '----- coz editing time poreq code is disabled
            cmbPOReq.Properties.ReadOnly = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            dcDel.Dispose()
            dsShow.Dispose()
            daGetDets.Dispose()
        End Try


        'gridItemDets.DataSource = Nothing
    End Sub

    ''' <summary>
    ''' Insert New PO
    ''' </summary>
    ''' <returns>True-Sucess,False-Failed</returns>
    ''' <remarks></remarks>
    Function InsertNewPO(ByVal Proc As String) As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim Procedure As String
        Dim TransInsert As SqlTransaction
        Dim IsTransEnable As Boolean = False  'Track the transection status

        Dim Ischeckfound As Boolean = False

        If String.Compare(Proc, "Add", False) = 0 Then
            Procedure = "spPOAdd"
        Else
            Procedure = "spPOEdit"
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

            sqlstring = String.Format("Delete from POTemporary where curruser like '{0}'", CurrUser)

            dcExecProc = New SqlCommand(sqlstring, Conn)
            dcExecProc.Transaction = TransInsert

            dcExecProc.ExecuteNonQuery()




            For i As Int16 = 0 To gvItemDets.RowCount - 1

                If cmdEdit.Text <> "Save" And cmdNew.Text = "Save" Then
                    If gvItemDets.GetRowCellValue(i, "IsSelect") Then
                        Ischeckfound = True
                    Else
                        GoTo L
                    End If
                End If


                If gvItemDets.GetRowCellValue(i, "Itemcode") = "" Then
                    Exit For
                End If

                If IsDBNull(gvItemDets.GetRowCellValue(i, "Itemprice")) Then
                    Throw New Exception("Item price can't be empty")
                ElseIf gvItemDets.GetRowCellValue(i, "Itemprice") = 0 Then
                    Dim msgrslt As MsgBoxResult = MsgBox("Do you allow Zero value item price", MsgBoxStyle.YesNo)
                    If msgrslt = MsgBoxResult.No Then
                        GoTo L
                    End If
                End If

                If IsDBNull(gvItemDets.GetRowCellValue(i, "ProcessQty")) Then
                    GoTo l
                End If



                sqlstring = "insert into potemporary (POCode,PODate,CreatedBy,Reference,UIDMaster,PriorityLevel,SupplierID,POReqCode,ReqDate,ReferencePR,PriorityLevelPR,Itemcode,Itemname,OrdQty,UIDDetail,Itemprice,Consumption,TaxCode,ProcessQty,TaxValue,SubTotal,CurrUser)"
                sqlstring = sqlstring & "values(@POCode,@PODate,@CreatedBy,@Reference,@UIDMaster,@PriorityLevel,@SupplierID,@POReqCode,@ReqDate,@ReferencePR,@PriorityLevelPR,@Itemcode,@Itemname,@OrdQty,@UIDDetail,@Itemprice,@Consumption,@TaxCode,@ProcessQty,@TaxValue,@SubTotal,@CurrUser)"

                dcExecProc = New SqlCommand(sqlstring, Conn)
                dcExecProc.Transaction = TransInsert


                Dim UIDMaster As Guid = New Guid(txtUIDMaster.Text)

                Dim UIDDetail As Guid = New Guid(gvItemDets.GetRowCellValue(i, "UIDDetail").ToString)

                With dcExecProc.Parameters
                    .Add("@POCode", SqlDbType.NVarChar, 50).Value = txtReqID.Text
                    .Add("@PODate", SqlDbType.Date).Value = dtReqDate.Text
                    .Add("@CreatedBy", SqlDbType.NVarChar).Value = txtRequestBy.Text
                    .Add("@Reference", SqlDbType.NVarChar).Value = txtReference.Text
                    .Add("@UIDMASTER", SqlDbType.UniqueIdentifier).Value = UIDMaster
                    .Add("@PRIORITYLEVEL", SqlDbType.NVarChar).Value = cmbPriority.Text
                    .Add("@SupplierID", SqlDbType.NVarChar).Value = IIf(IsNothing(cmbSupplier.GetColumnValue("Suppliercode")), String.Empty, cmbSupplier.GetColumnValue("Suppliercode"))

                    .Add("@POREQCODE", SqlDbType.NVarChar, 50).Value = cmbPOReq.GetColumnValue("POReqCode")
                    .Add("@ReqDate", SqlDbType.Date).Value = txtPRDate.Text
                    .Add("@ReferencePR", SqlDbType.NVarChar).Value = txtPRRef.Text
                    .Add("@PriorityLevelPR", SqlDbType.NVarChar).Value = txtPRPriority.Text

                    .Add("@Itemcode", SqlDbType.NVarChar).Value = gvItemDets.GetRowCellValue(i, "Itemcode")
                    .Add("@Itemname", SqlDbType.NVarChar).Value = gvItemDets.GetRowCellValue(i, "Itemname")
                    .Add("@OrdQty", SqlDbType.Float).Value = gvItemDets.GetRowCellValue(i, "OrdQty")
                    .Add("@UIDDetail", SqlDbType.UniqueIdentifier).Value = UIDDetail
                    .Add("@Itemprice", SqlDbType.Float).Value = gvItemDets.GetRowCellValue(i, "Itemprice")
                    .Add("@Consumption", SqlDbType.Float).Value = gvItemDets.GetRowCellValue(i, "Consumption") ' GetCurrItemQty(Conn, TransInsert, gvItemDets.GetRowCellValue(i, "Itemcode"))
                    .Add("@TaxCode", SqlDbType.NVarChar).Value = gvItemDets.GetRowCellValue(i, "TaxCode") ' GetCurrItemQty(Conn, TransInsert, gvItemDets.GetRowCellValue(i, "Itemcode"))
                    .Add("@ProcessQty", SqlDbType.Float).Value = gvItemDets.GetRowCellValue(i, "ProcessQty") ' GetCurrItemQty(Conn, TransInsert, gvItemDets.GetRowCellValue(i, "Itemcode"))
                    .Add("@TaxValue", SqlDbType.Float).Value = gvItemDets.GetRowCellValue(i, "TaxValue") ' GetCurrItemQty(Conn, TransInsert, gvItemDets.GetRowCellValue(i, "Itemcode"))
                    .Add("@SubTotal", SqlDbType.Float).Value = gvItemDets.GetRowCellValue(i, "SubTotal") ' GetCurrItemQty(Conn, TransInsert, gvItemDets.GetRowCellValue(i, "Itemcode"))

                    .Add("@CurrUser", SqlDbType.NVarChar).Value = CurrUser
                End With

                dcExecProc.ExecuteNonQuery()

L:
            Next


            TransInsert.Commit()
            IsTransEnable = False

            dcExecProc.Dispose()

            '--------------------------------------------------
            If cmdEdit.Text <> "Save" And cmdNew.Text = "Save" Then
               If Not Ischeckfound Then
                    Throw New Exception("Zero Item selected,please select any single item to continue")
                End If
            End If

            

            dcExecProc = New SqlCommand(Procedure, Conn)
            dcExecProc.CommandType = CommandType.StoredProcedure

            With dcExecProc.Parameters
                .Add("@CurrUser", SqlDbType.NVarChar).Value = CurrUser
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
            Ischeckfound = False

        End Try

        If IsTransEnable Then
            TransInsert.Rollback()
        End If


    End Function


    Sub ShowFields(ByVal POcode As String)

        Dim Conn As New SqlConnection(modMain.ConnString)

        Dim daGetDets As New SqlDataAdapter(String.Format("select * from POMaster where POcode like '{0}'", POcode), Conn)
        Dim dsShow As New DataSet
        Dim dcExec As New SqlCommand


        Try

            tabMain.SelectedTabPageIndex = 1
            daGetDets.Fill(dsShow)


            txtReference.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Reference")), "", dsShow.Tables(0).Rows(0).Item("Reference"))
            txtReqID.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("POcode")), "", dsShow.Tables(0).Rows(0).Item("POcode"))
            txtRequestBy.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("CreatedBy")), "", dsShow.Tables(0).Rows(0).Item("CreatedBy"))
            cmbPriority.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Reference")), "", dsShow.Tables(0).Rows(0).Item("Reference"))
            txtUIDMaster.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("UID")), "", dsShow.Tables(0).Rows(0).Item("UID").ToString)
            dtReqDate.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("PODate")), "", dsShow.Tables(0).Rows(0).Item("PODate"))
            dtReqDate.Text = Now.Date

            txtPRPriority.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("PriorityLevelPR")), "", dsShow.Tables(0).Rows(0).Item("PriorityLevelPR"))
            txtPRRef.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("ReferencePR")), "", dsShow.Tables(0).Rows(0).Item("ReferencePR"))
            txtPRDate.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("ReqDate")), "", dsShow.Tables(0).Rows(0).Item("ReqDate"))

            '---- in view time it shouldnt be allow to edit poreqcode
            cmbPOReq.Properties.ReadOnly = True
            cmbPOReq.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("POReqCode")), "", dsShow.Tables(0).Rows(0).Item("POReqCode"))
            cmbPriority.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("PriorityLevel")), "", dsShow.Tables(0).Rows(0).Item("PriorityLevel"))
            cmbSupplier.EditValue = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Supplierid")), "", dsShow.Tables(0).Rows(0).Item("Supplierid"))

            daGetDets.Dispose()
            dsShow.Dispose()

            '------ 

            gridItemDets.DataSource = Nothing


 

            '------ after showing these details we need to run podetails to potemp table and 

            dcExec = New SqlCommand("spPODetShow", Conn)
            dcExec.CommandType = CommandType.StoredProcedure

            dcExec.Parameters.Add("@POCODE", SqlDbType.NVarChar).Value = txtReqID.Text
            dcExec.Parameters.Add("@CURRUSER", SqlDbType.NVarChar).Value = CurrUser


            daGetDets = New SqlDataAdapter
            daGetDets.SelectCommand = dcExec
            daGetDets.Fill(dsShow)


            gridItemDets.DataSource = dsShow.Tables(0)


            For i As Int16 = 0 To gvItemDets.RowCount - 1

                If IsDBNull(gvItemDets.GetRowCellValue(i, "Itemcode")) Then
                    gvItemDets.DeleteRow(i)
                End If
            Next

            Dim Totalz As Double() = SetGrandTotz()


            txtSubtot.Text = Totalz(0)
            txtTaxValue.Text = Totalz(1)
            txtPOTot.Text = Totalz(2)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()

        End Try


    End Sub

    Sub LoadMain(ByVal All As Boolean, ByVal Open As Boolean)

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim dcExec As New SqlCommand()
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try

            If dtFrom.Text = "" Then
                Exit Sub
            End If
            dcExec = New SqlCommand("spPOMasterShow", Conn)
            dcExec.CommandType = CommandType.StoredProcedure

            dcExec.Parameters.Add("@ALL", SqlDbType.Bit).Value = All
            dcExec.Parameters.Add("@OPEN", SqlDbType.Bit).Value = Open
            dcExec.Parameters.Add("@FROM", SqlDbType.DateTime).Value = dtFrom.Text
            dcExec.Parameters.Add("@TO", SqlDbType.DateTime).Value = dtTo.Text

            daGetDets.SelectCommand = dcExec
            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                gridPOMain.DataSource = Nothing
            Else
                gridPOMain.DataSource = dsShow.Tables(0)
            End If


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
    Sub LoadGridDets()

        Dim Conn As New SqlConnection(modMain.ConnString)
        ' Dim daGetDets As New SqlDataAdapter("select * from POMaster where status=1 order by POCode", Conn)
        Dim daGetDets As New SqlDataAdapter
        Dim dsShow As New DataSet

        Try

            'daGetDets.Fill(dsShow)

            'gridPOMain.DataSource = dsShow.Tables(0)

            'daGetDets.Dispose()
            'dsShow.Dispose()


            '--- here what i hv done is, get a dummy dataset for itemreqdetails
            daGetDets = New SqlDataAdapter(String.Format("select * from POtemporary where curruser like '{0}' and POCode like '{1}' ", CurrUser, txtReqID.Text), Conn)
            daGetDets.Fill(dsShow)


            gridItemDets.DataSource = dsShow.Tables(0)



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Sub

    Sub LoadCombos()
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets, daGridLookup As New SqlDataAdapter()
        Dim dsShow, dsGridLookup As New DataSet

        Try

            '----- Load Department Master

            daGetDets = New SqlDataAdapter("select Suppliercode,Suppliername from SupplierMaster order by suppliercode", Conn)
            daGetDets.Fill(dsShow)

            With cmbSupplier.Properties
                .DataSource = dsShow.Tables(0)
                .DisplayMember = "Suppliername"
                .ValueMember = "Suppliercode"
                .Columns(0).Width = 125
                .Columns(1).Width = 275
                .PopupWidth = 400

            End With

            daGridLookup = New SqlDataAdapter("select POReqCode,ReqDate,PriorityLevel as Priority from POReqMaster where status = 1 and iscertified = 1 and isauthorized = 1 order by poreqcode", Conn)
            daGridLookup.Fill(dsGridLookup)

            With cmbPOReq.Properties
                .DataSource = dsGridLookup.Tables(0)
                .DisplayMember = "POReqCode"
                .ValueMember = "POReqCode"
                '.Columns(0).Width = 125
                '.Columns(1).Width = 275
                '.Columns(2).Width = 125
                .PopupWidth = 525

            End With



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

    Function FieldValidation() As Boolean
        Return IIf(String.Compare(txtReqID.Text, "", False) = 0 Or String.Compare(dtReqDate.Text, "", False) = 0 Or ItemcodeValid() = False Or IsNothing(cmbSupplier.GetColumnValue("Suppliercode")), 0, 1)
    End Function

    Function GetPOCode() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNo", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "POMain"
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output

            dcGetCode.ExecuteNonQuery()

            GetPOCode = dcGetCode.Parameters("@Currcode").Value


            Return GetPOCode
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()

        End Try

    End Function

    Function ItemcodeValid() As Boolean

        Try
            If gvItemDets.RowCount = 0 Then
                Return False
            End If

            For i As Integer = 0 To gvItemDets.RowCount - 1
                If IsDBNull(gvItemDets.GetRowCellValue(i, "Itemcode")) Then
                    Throw New Exception("Itemcode can't be empty")
                End If
            Next

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        End Try

    End Function

    Sub ShowPRDetails()
        Dim Conn As New SqlConnection(modMain.ConnString)

        Dim daGetDets As New SqlDataAdapter(String.Format("select * from POReqMaster where POReqCode like '{0}'", cmbPOReq.GetColumnValue("POReqCode")), Conn)
        Dim dsShow, dsGridDets As New DataSet
        Dim dcExecProc As New SqlCommand
        Dim dagriddets As SqlDataAdapter

        Try

            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count = 0 Then
                Exit Sub
            End If

            txtPRPriority.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("PriorityLevel")), "", dsShow.Tables(0).Rows(0).Item("PriorityLevel"))
            txtPRRef.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("Reference")), "", dsShow.Tables(0).Rows(0).Item("Reference"))
            txtPRDate.Text = IIf(IsDBNull(dsShow.Tables(0).Rows(0).Item("ReqDate")), "", dsShow.Tables(0).Rows(0).Item("ReqDate"))

            '---- before we run this sp, we need to insert current date to [temp.prreq] table
            ' coz it holds the date to get consumption qty.
            Conn.Open()

            dcExecProc = New SqlCommand("delete from [Temp.PurReqDate]", Conn)
            dcExecProc.ExecuteNonQuery()
            dcExecProc.Dispose()


            dcExecProc = New SqlCommand("insert into [Temp.PurReqDate] (preqdate) values(getdate())", Conn)
            dcExecProc.ExecuteNonQuery()
            dcExecProc.Dispose()


            '---- here i have done small tricks.
            ' ie. when we select the POREQCODE,insert the details to potemp table and call them,
            ' coz in order to update column values relevant columns should be loaded in grid.

            dcExecProc = New SqlCommand("spPRTempView", Conn)
            dcExecProc.CommandType = CommandType.StoredProcedure
            dcExecProc.Parameters.Add("@POREQCODE", SqlDbType.NVarChar).Value = cmbPOReq.GetColumnValue("POReqCode")
            dcExecProc.Parameters.Add("@CURRUSER", SqlDbType.NVarChar).Value = CurrUser

            dagriddets = New SqlDataAdapter
            dagriddets.SelectCommand = dcExecProc
            'daGetDets = New SqlDataAdapter(String.Format("select * from POReqDetails where POReqCode like '{0}'", cmbPOReq.GetColumnValue("POReqCode")), Conn)
            dsGridDets = New DataSet

            dagriddets.Fill(dsGridDets)

            gridItemDets.DataSource = dsGridDets.Tables(0)

            '----- Monthly or weekly consumption should come here..


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Sub

    Function TaxCalc(ByVal ItemQty As Double, ByVal ItemPrice As Double, ByVal TaxCode As String) As Double

        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet
        Dim TaxVal As Double

        Try

            daGetDets = New SqlDataAdapter(String.Format("select Percentage from TaxMaster where taxcode like'{0}'", TaxCode), Conn)
            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count > 0 Then

                If dsShow.Tables(0).Rows(0).Item("Percentage") > 0 Then
                    TaxVal = ItemQty * ItemPrice * dsShow.Tables(0).Rows(0).Item(0) / 100
                    TaxCalc = TaxVal
               End If

            Else
                TaxCalc = 0
            End If

            Return TaxCalc

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Function

    Function SetGrandTotz() As Double()

        Try
            Dim SubTot, TaxTotal, POtotal As Double

            SubTot = 0
            TaxTotal = 0
            POtotal = 0

            For i As Int16 = 0 To gvItemDets.RowCount - 1

                If IsDBNull(gvItemDets.GetRowCellValue(i, "ProcessQty")) Then
                    GoTo nl
                End If

                SubTot += (gvItemDets.GetRowCellValue(i, "Itemprice") * gvItemDets.GetRowCellValue(i, "ProcessQty"))

                TaxTotal += gvItemDets.GetRowCellValue(i, "TaxValue")

nl:
            Next

            POtotal = SubTot + TaxTotal

            Dim Totalz(2) As Double

            Totalz(0) = SubTot
            Totalz(1) = TaxTotal
            Totalz(2) = POtotal

            SetGrandTotz = Totalz


            Return SetGrandTotz
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return Nothing
        End Try

    End Function

    Function SetSubTotal(ByVal Qty As Double, ByVal Price As Double, ByVal TaxVal As Double) As Double
        Try
            Dim SubTot As Double

            SubTot = Qty * Price + TaxVal
            SetSubTotal = SubTot

            Return SetSubTotal
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return 0

        End Try

    End Function

    Function InactivateRequisition(ByVal ItemReqCode As String) As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim dcExecDel As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Dim msgbxrslt As MsgBoxResult = MsgBox("Are you sure,you want to delete this Purchase Order", MsgBoxStyle.YesNo, ErrTitle)

            If msgbxrslt = MsgBoxResult.No Then
                Return False
            End If

            Conn.Open()

            dcExecDel = New SqlCommand(String.Format("update POMaster set status = 0 where POCode ='{0}'", ItemReqCode), Conn)
            dcExecDel.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcExecDel.Dispose()

        End Try

    End Function

    Function AthorizePO(ByVal POCode As String) As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim dcExecDel As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Dim msgbxrslt As MsgBoxResult = MsgBox("Do you want to Authorized this Purchase Order", MsgBoxStyle.YesNo, ErrTitle)

            If msgbxrslt = MsgBoxResult.No Then
                Return False
            End If

            Conn.Open()

            dcExecDel = New SqlCommand(String.Format("update POMaster set IsAuthorized = 1 where POCode ='{0}'", POCode), Conn)
            dcExecDel.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcExecDel.Dispose()

        End Try

    End Function

    Function IsAuthorized() As Boolean
        Dim Conn As New SqlConnection(ConnString)

        Dim daGetCode As New SqlDataAdapter(String.Format("Select isauthorized from POMaster where POCode ='{0}'", txtReqID.Text), Conn)
        Dim dsGetDets As New DataSet

        Try

            daGetCode.Fill(dsGetDets)

            If dsGetDets.Tables(0).Rows.Count = 0 Then
                Return True
            End If

            Return dsGetDets.Tables(0).Rows(0).Item(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return True
        Finally
            Conn.Dispose()
            daGetCode.Dispose()
            dsGetDets.Dispose()
        End Try
    End Function

    Function DataAuthenticationChecking(ByVal RowHandle As Int16) As Boolean
        Dim Conn As New SqlConnection(modMain.ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Try

            '----- Load Department Master
            Dim POReqCode As String = gvPOMain.GetRowCellValue(RowHandle, "POCode")

            If String.IsNullOrEmpty(POReqCode) Then
                Exit Function
            End If

            daGetDets = New SqlDataAdapter(String.Format("select IsAuthorized from POMaster where POCode like '{0}'", POReqCode), Conn)
            daGetDets.Fill(dsShow)

            If dsShow.Tables(0).Rows.Count > 0 Then
                cmdAuthorized.Enabled = Not dsShow.Tables(0).Rows(0).Item(0)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetDets.Dispose()
            dsShow.Dispose()
        End Try

    End Function
#End Region


    Private Sub frmPurchaseOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        dtReqDate.Text = Now.Date
        dtFrom.Text = Now.Date
        dtTo.Text = Now.Date

        LoadMain(True, True)
        LoadGridDets()
        LoadCombos()

       

        txtReqID.Properties.ReadOnly = True


    End Sub

    Private Sub cmbPOReq_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cmbPOReq.EditValueChanged

        If cmdNew.Text = "Record" Then
            ShowPRDetails()
        End If

    End Sub

    Private Sub cmdNew_Click(sender As System.Object, e As System.EventArgs) Handles cmdNew.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GeneratePurchaseOrders", "Add")

        If CheckAccess = True Then





            If cmdNew.Text = "New" Then

                ClearFields()

                tabMain.SelectedTabPageIndex = 1
                tabMain.TabPages(0).PageEnabled = False

                cmdNew.Text = "Record"
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False
            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If Not InsertNewPO("Add") Then
                    Exit Sub
                End If

                MsgBox("Successfully Inserted...", , ErrTitle)
                LoadMain(True, True)

                cmdNew.Text = "New"
                cmdEdit.Enabled = True
                cmdDelete.Enabled = True

                tabMain.TabPages(0).PageEnabled = True

            End If


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub gvItemDets_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvItemDets.CellValueChanged

        If e.Column.FieldName = "ProcessQty" Or e.Column.FieldName = "Itemprice" Then

            '----- need to verify processqty > ord qty
            Dim POQty As Double = IIf(IsDBNull(gvItemDets.GetRowCellValue(e.RowHandle, "OrdQty")), 0, gvItemDets.GetRowCellValue(e.RowHandle, "OrdQty"))
            Dim ProcQty As Double = IIf(IsDBNull(gvItemDets.GetRowCellValue(e.RowHandle, "ProcessQty")), 0, gvItemDets.GetRowCellValue(e.RowHandle, "ProcessQty"))
            Dim ItemPrice As Double = IIf(IsDBNull(gvItemDets.GetRowCellValue(e.RowHandle, "Itemprice")), 0, gvItemDets.GetRowCellValue(e.RowHandle, "Itemprice"))

            If POQty < ProcQty Then
                MsgBox("You can't enter more than ordered Qty", MsgBoxStyle.Critical, ErrTitle)
                gvItemDets.SetFocusedRowCellValue("ProcessQty", POQty)
                Exit Sub
            End If

            gvItemDets.SetFocusedRowCellValue("TaxValue", TaxCalc(ProcQty, ItemPrice, gvItemDets.GetFocusedRowCellValue("TaxCode")))
            gvItemDets.SetFocusedRowCellValue("SubTotal", SetSubTotal(ProcQty, ItemPrice, gvItemDets.GetFocusedRowCellValue("TaxValue")))

            'gvItemDets.SetFocusedRowCellValue("TaxValue", TaxCalc(gvItemDets.GetFocusedRowCellValue("ProcessQty"), gvItemDets.GetFocusedRowCellValue("Itemprice"), gvItemDets.GetFocusedRowCellValue("TaxCode")))
            'gvItemDets.SetFocusedRowCellValue("SubTotal", SetSubTotal(gvItemDets.GetFocusedRowCellValue("ProcessQty"), gvItemDets.GetFocusedRowCellValue("Itemprice"), gvItemDets.GetFocusedRowCellValue("TaxValue")))

            'gvItemDets.SetFocusedRowCellValue("SubTotal", SetSubTotz)
            'gvItemDets.SetFocusedRowCellValue("SubTotal",

            Dim Totalz As Double() = SetGrandTotz()


            txtSubtot.Text = Totalz(0)
            txtTaxValue.Text = Totalz(1)
            txtPOTot.Text = Totalz(2)

        End If
    End Sub

    Private Sub gvPOMain_DoubleClick(sender As Object, e As System.EventArgs) Handles gvPOMain.DoubleClick
        ShowFields(gvPOMain.GetFocusedRowCellValue("POCode"))
    End Sub

    Private Sub cmdEdit_Click(sender As System.Object, e As System.EventArgs) Handles cmdEdit.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GeneratePurchaseOrders", "Edit")

        If CheckAccess = True Then


            If String.Compare(cmdEdit.Text, "Edit", False) = 0 Then


                cmdEdit.Text = "Save"
                cmdNew.Enabled = False
                cmdDelete.Enabled = False

                txtReqID.Properties.ReadOnly = True

                tabMain.SelectedTabPageIndex = 1
                tabMain.TabPages(0).PageEnabled = False

            Else

                If FieldValidation() = False Then
                    MsgBox("Compulsary feilds must be filled", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If IsAuthorized() Then
                    MsgBox("You can't edit Authorized Purchase Order", MsgBoxStyle.Critical, ErrTitle)
                    Exit Sub
                End If

                If Not InsertNewPO("Edit") Then
                    Exit Sub
                End If

                MsgBox("Successfully Update...", , ErrTitle)
                LoadMain(True, True)

                cmdEdit.Text = "Edit"
                cmdNew.Enabled = True
                cmdDelete.Enabled = True

                'txtReqID.Properties.ReadOnly = False

                tabMain.SelectedTabPageIndex = 0
                tabMain.TabPages(0).PageEnabled = True

            End If


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub cmdDelete_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelete.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GeneratePurchaseOrders", "Delete")

        If CheckAccess = True Then



            If String.IsNullOrEmpty(txtReqID.Text) Then
                Exit Sub
            End If

            If InactivateRequisition(txtReqID.Text) Then
                MsgBox("Successfully Deleted", , ErrTitle)

            Else
                MsgBox("Unsuccessful Delete operation", MsgBoxStyle.Critical, ErrTitle)
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub optOpen_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optOpen.CheckedChanged, optClosed.CheckedChanged
        LoadMain(True, optOpen.Checked)
        'If optOpen.Checked Then
        '    LoadMain(True, True)
        'Else
        '    LoadMain(True, False)
        'End If
    End Sub

    Private Sub cmdAuthorized_Click(sender As System.Object, e As System.EventArgs) Handles cmdAuthorized.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GeneratePurchaseOrders", "Authorize")

        If CheckAccess = True Then


            If String.IsNullOrEmpty(txtReqID.Text) Then
                Exit Sub
            End If

            If AthorizePO(txtReqID.Text) Then
                MsgBox("Successfully Authorized", , ErrTitle)
                DataAuthenticationChecking(gvPOMain.FocusedRowHandle)
                LoadMain(True, True)
            Else
                MsgBox("Unsuccessful Authorized operation", MsgBoxStyle.Critical, ErrTitle)
            End If


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub cmdSearch_Click(sender As System.Object, e As System.EventArgs) Handles cmdSearch.Click
        LoadMain(False, optOpen.Checked)
    End Sub

    Private Sub cmdClose_Click(sender As System.Object, e As System.EventArgs) Handles cmdClose.Click
        If cmdNew.Enabled = False Or cmdEdit.Enabled = False Then
            Dim msgres As MsgBoxResult = MsgBox("There are unsaved datas in this form, do you want to cancel this process", MsgBoxStyle.YesNo)
            If msgres = MsgBoxResult.Yes Then
                Me.Close()

            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub gvPOMain_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvPOMain.FocusedRowChanged
        DataAuthenticationChecking(e.FocusedRowHandle)
    End Sub

    Private Sub cmdPrint_Click(sender As System.Object, e As System.EventArgs) Handles cmdPrint.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GeneratePurchaseOrders", "Print")

        If CheckAccess = True Then

            If txtReqID.Text = "" Then
                MsgBox("Select Purchase Order to print", MsgBoxStyle.Critical)
                Exit Sub

            End If
            'frmPurchReq_Report.POReqCode = txtReqID.Text

            'frmPurchReq_Report.btnPrint_Click()

            frmReportViewerZ.selectionForumla = String.Format("{{POMaster.POCode}}='{0}'", txtReqID.Text)
            frmReportViewerZ.rptPath = "frmPOReport.rpt"
            frmReportViewerZ.rptTitle = "Purchase Order Report"
            frmReportViewerZ.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If




    End Sub

    Private Sub frmPurchaseOrder_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()


        End If
    End Sub
End Class