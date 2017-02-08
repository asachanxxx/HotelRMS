Imports System.Data.SqlClient
Imports System.IO


Public Class frmTextFileImport

    Private Sub cmdBrowse_Click(sender As System.Object, e As System.EventArgs) Handles cmdBrowse.Click
        With fbAccounts
            .Filter = "Accounts List Detail|*.txt"
            .ShowDialog()
        End With

        If fbAccounts.FileName.ToString <> "" Then
            txtPathItemMaster.Text = fbAccounts.FileName.ToString
        End If

    End Sub

    Private Sub cmdImport_Item_Click(sender As System.Object, e As System.EventArgs) Handles cmdImport_Item.Click

        Dim Conn As New SqlConnection(ConnString)

        Dim dcExec As New SqlCommand("spImportItemMaster", Conn)

        Try

            If ImportTextFile() Then

                If ExportTextFile() Then

                    '---- update item master file.
                    'Conn.ConnectionTimeout = 400
                    'Conn.Open()
                    'dcExec.CommandType = CommandType.StoredProcedure
                    'dcExec.ExecuteNonQuery()

                    If ExportToTable Then
                        Throw New Exception("Imports unsucessful")
                    End If


                    '--- we need to add uom from imported text files to system if not exists.
                    InsertUOMDetails()

                    MsgBox("Itemcodes Updated Successfully...!", MsgBoxStyle.Information, ErrTitle)

                Else
                    MsgBox("Error in Import File", MsgBoxStyle.Critical, ErrTitle)
                End If

            End If


        Catch ex As SqlException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Dispose()
            dcExec.Dispose()
        End Try

        Me.Cursor = Cursors.WaitCursor


        Me.Cursor = Cursors.Default
    End Sub
    Function ExportToTable() As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim daGet As New SqlDataAdapter("select * from [temp.itemmaster]", Conn)
        Dim dsShow As New DataSet
        'Dim Category As String = ""
        Dim dcExec As New SqlCommand


        Try

            daGet.Fill(dsShow)

            Dim AdjustmentCode As String = GetAdjCode()
            Dim CategoryID, ItemCode, sqlstring As String

            Conn.Open()

            For i As Int16 = 0 To dsShow.Tables(0).Rows.Count - 1

                '---- category and itemno create'
                CategoryID = dsShow.Tables(0).Rows(i).Item("CatCode") '.ToString.Substring(0, 3)
                InsertNewCategory(CategoryID, dsShow.Tables(0).Rows(i).Item("Category"))

                ItemCode = GetItemCode(CategoryID)

                sqlstring = "INSERT INTO ItemMaster(Itemcode,Description,Category,CreateDate,UOM,Status,Avgcost,Stockvalue,Stocks,Suppliercode,Taxcode,IsSplit)"
                sqlstring = sqlstring + " VALUES (@CURRCODE,@Description,@NEWCATCODE,@ADJDATE,@UOM,'1',0,0,0,'DEFAULT','N-T',@IsSplit)"

                dcExec = New SqlCommand(sqlstring, Conn)
                dcExec.Parameters.Add("@CURRCODE", SqlDbType.NVarChar).Value = ItemCode
                dcExec.Parameters.Add("@Description", SqlDbType.NVarChar).Value = dsShow.Tables(0).Rows(i).Item("Description")
                dcExec.Parameters.Add("@NEWCATCODE", SqlDbType.NVarChar).Value = CategoryID
                dcExec.Parameters.Add("@ADJDATE", SqlDbType.DateTime).Value = Now.Date
                dcExec.Parameters.Add("@UOM", SqlDbType.NVarChar).Value = dsShow.Tables(0).Rows(i).Item("UOM")
                dcExec.Parameters.Add("@IsSplit", SqlDbType.Bit).Value = dsShow.Tables(0).Rows(i).Item("IsSplit")
                dcExec.ExecuteNonQuery()
                dcExec.Dispose()

                '---- 
                SetItemCode(CategoryID)

                '---- now insert them to adjustment so we can update inventory table too... 
                UpdateInvTable(dsShow.Tables(0).Rows(i), AdjustmentCode, ItemCode)

                '-----
                SetItemAdj()

            Next

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Conn.Dispose()
            dcExec.Dispose()
            dsShow.Dispose()
            daGet.Dispose()

        End Try

    End Function

    Private Function ImportTextFile() As Boolean

        Dim ErrFinder As String
        Dim fsAccs As FileStream
        Dim srFileOpen As StreamReader
        Dim ReadLine As String = ""

        Dim ItemCode, Description, Category, UOM, CatCode, IsSplit As String
        Dim Stocks, ItemPrice, StockValue As String

        Dim strArray As String()
        Dim UOMMix As String()

        Dim fsAccW As FileStream
        Dim srFileWrite As StreamWriter

        Try
            If txtPathItemMaster.Text = "" Then
                Throw New Exception("Select the ME File")
            End If


            If File.Exists(Application.StartupPath & "\FormatAcc.txt") Then
                File.Delete(Application.StartupPath & "\FormatAcc.txt")
            End If

            '------ File Reading Process-----'
            fsAccs = New FileStream(txtPathItemMaster.Text, FileMode.Open, FileAccess.Read)
            srFileOpen = New StreamReader(fsAccs)

            '------ File Writing Process-----'
            fsAccW = New FileStream(Application.StartupPath & "\FormatAcc.txt", FileMode.Append)
            srFileWrite = New StreamWriter(fsAccW)


            'For i As Integer = 1 To 14
            '    ReadLine = srFileOpen.ReadLine
            'Next

            ReadLine = srFileOpen.ReadLine

            'For i As Int16 = 0 To 7
            '    ReadLine = srFileOpen.ReadLine
            'Next

            While Not ReadLine Is Nothing

                If ReadLine = "" Or String.IsNullOrWhiteSpace(ReadLine) Or ReadLine.Contains("CODE") Or ReadLine.Contains("Page") Then
                    GoTo NextLine
                End If

                ReadLine = ReadLine.Replace("'", "")
                ReadLine = ReadLine.Replace(",", ".")
                ReadLine = ReadLine.Replace(Chr(34), "")
                ReadLine = Replace(ReadLine, "(", "-").Replace(")", "")

                strArray = ReadLine.Split(vbTab)


                If strArray.Length <= 0 Then
                    GoTo NextLine
                End If

                '                ErrFinder = ""
                'X:
                '                If ReadLine.Contains(ErrFinder) And ErrFinder <> "" Then
                '                    MsgBox("hi")
                '                End If

                If String.IsNullOrEmpty(strArray(0)) Then
                    GoTo NextLine
                End If

                ItemCode = strArray(0)
                'UOMMix = strArray(1).Split(" ")
                UOM = strArray(2)
                Description = strArray(3)
                Category = strArray(4)
                CatCode = strArray(5)
                IsSplit = strArray(6)
                ItemPrice = strArray(8) ' IIf(IsNumeric(strArray(5)), strArray(5), 0)
                StockValue = strArray(9) ' IIf(IsNumeric(strArray(6)), strArray(6), 0)

                Stocks = strArray(1) 'IIf(IsNumeric(UOMMix(0)), UOMMix(0), 0)
                'If UOMMix.Length = 2 Then
                '    UOM = UOMMix(1)
                'Else
                '    UOM = UOMMix(2)
                'End If



                'srFileWrite.WriteLine(ItemCode & vbTab & Description & vbTab & Amount & vbTab & HeaderID & vbTab & Header)
                srFileWrite.WriteLine(ItemCode & vbTab & Description & vbTab & CatCode & vbTab & Category & vbTab & UOM & vbTab & Stocks & vbTab & ItemPrice & vbTab & StockValue & vbTab & IsSplit)


NextLine:
                ReadLine = srFileOpen.ReadLine
            End While

            srFileOpen.Close()
            fsAccs.Close()

            srFileWrite.Close()
            fsAccW.Close()

            ImportTextFile = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            'ErrFinder = ItemCode
            'GoTo x
            ImportTextFile = False
        End Try

        srFileOpen = Nothing
        fsAccs = Nothing

        srFileWrite = Nothing
        fsAccW = Nothing

    End Function

    Private Function ExportTextFile() As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim transInsert As SqlTransaction
        Dim dcInsertNewAcc, dcDeleteAll As New SqlCommand

        Dim fsAccs As FileStream
        Dim srFileOpen As StreamReader
        Dim ReadLine As String = ""
        Dim strArray As String()
        Dim sqlString As String
        Dim UID As Boolean

        Try


            If Not File.Exists(Application.StartupPath & "\FormatAcc.txt") Then
                Throw New Exception("Error Found,Restart your Application")
            End If

            Conn.Open()

            '------ File Reading Process-----'
            fsAccs = New FileStream(Application.StartupPath & "\FormatAcc.txt", FileMode.Open, FileAccess.Read)
            srFileOpen = New StreamReader(fsAccs)

            '----- start local transection -----'
            transInsert = Conn.BeginTransaction("InsertNewAccNo")


            sqlString = "delete from [Temp.ItemMaster]"

            dcDeleteAll = New SqlCommand(sqlString, Conn)
            dcDeleteAll.Transaction = transInsert

            dcDeleteAll.ExecuteNonQuery()
            transInsert.Commit()



            While Not ReadLine Is Nothing

                If ReadLine = "" Then
                    GoTo NextLine
                End If


                strArray = ReadLine.Split(vbTab)


                '----- check for item exists -----'
                UID = IsItemExists(strArray(1))
                If Not UID Then

                    '----- start local transection -----'
                    transInsert = Conn.BeginTransaction("InsertNewAccNo")

                    '               srFileWrite.WriteLine(ItemCode & vbTab & Description & vbTab & CatCode & vbTab & Category & vbTab & UOM & vbTab & Stocks & vbTab & ItemPrice & vbTab & StockValue & vbTab & IsSplit)

                    sqlString = "Insert into [Temp.ItemMaster] (ItemCode, Description,CatCode,Category, UOM,Stocks, ItemPrice, StockValue,IsSplit) Values('" & _
                        strArray(0) & "','" & strArray(1) & "','" & strArray(2) & "','" & strArray(3) & "','" & strArray(4) & "','" & IIf(IsNumeric(strArray(5)), strArray(5), 0) & "','" & IIf(IsNumeric(strArray(6)), strArray(6), 0) & "','" & IIf(IsNumeric(strArray(7)), strArray(7), 0) & "','" & IIf(strArray(8) = "", 0, 1) & "')"

                    dcInsertNewAcc = New SqlCommand(sqlString, Conn)
                    dcInsertNewAcc.Transaction = transInsert


                    dcInsertNewAcc.ExecuteNonQuery()
                    transInsert.Commit()

                End If



NextLine:
                ReadLine = srFileOpen.ReadLine
            End While


            srFileOpen.Close()
            fsAccs.Close()

            ExportTextFile = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, errtitle)
            'transInsert.Rollback("InsertNewAccNo")

            ExportTextFile = False
        Finally
            srFileOpen.Close()
            fsAccs.Close()

            Conn.Dispose()
            transInsert = Nothing
            dcDeleteAll.Dispose()
            dcInsertNewAcc.Dispose()
            dcInsertNewAcc.Dispose()
        End Try



    End Function

    Private Function IsItemExists(ByVal ItemName As String) As Boolean
        'in this process what im going to do is... if accno not exists then send a unique no to update it
        Dim Connx As New SqlConnection(ConnString)

        Dim dcRead As New SqlCommand(String.Format("select count(itemcode) from itemmaster where description ='{0}'", ItemName), Connx)
        Dim drRead As SqlDataReader
        Try
            Connx.Open()
            drRead = dcRead.ExecuteReader

            If drRead.HasRows Then
                drRead.Read()

                If drRead.Item(0) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Else
                Return False
            End If

            'If dcRead.ExecuteScalar() = 0 Then
            '    IsItemExists = Guid.NewGuid.ToString
            'Else
            '    IsItemExists = ""
            'End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Connx.Dispose()
            dcRead.Dispose()
            drRead.Close()

        End Try

        'dcRead.Dispose()

    End Function

    Function GetAdjCode() As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()

        Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Adj'", Conn)
        Dim dsGetDets As New DataSet

        Try
            Conn.Open()

            daGetCode.Fill(dsGetDets)

            If dsGetDets.Tables(0).Rows.Count = 0 Then
                dcGetCode = New SqlCommand("INSERT INTO dbo.AutoNumberMaster ( PREFIX ,INCNUMBER ,TOTALLENGTH ,MAINTYPE ,CURRCODE )	VALUES  ( 'ADJ' , 1 , 10 , 'Adj' ,'ADJ0000001')", Conn)
                dcGetCode.ExecuteNonQuery()

                dcGetCode.Dispose()

            End If


            dcGetCode = New SqlCommand("spGetAutoNo", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "Adj"
            dcGetCode.Parameters.Add("@Currcode", SqlDbType.NVarChar, 50)
            dcGetCode.Parameters("@Currcode").Direction = ParameterDirection.Output

            dcGetCode.ExecuteNonQuery()

            GetAdjCode = dcGetCode.Parameters("@Currcode").Value


            Return GetAdjCode
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return ""
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()

        End Try

    End Function

    Function InsertNewCategory(ByVal CategoryID As String, ByVal CatName As String) As Boolean

        Dim Conn As New SqlConnection(modMain.ConnString)

        'If String.Compare(Proc, "Add", False) = 0 Then
        'Else
        'Procedure = "spItemCategoryEdit"
        'End If
        Dim daGetCat As New SqlDataAdapter(String.Format("select categoryid from categorymaster where categoryid like '{0}'", CategoryID), Conn)
        Dim dsCat As New DataSet

        Dim dcExecProc As New SqlCommand("spItemCategoryAdd", Conn)

        Try

            daGetCat.Fill(dsCat)

            If dsCat.Tables(0).Rows.Count <> 0 Then
                Return False
            End If


            Conn.Open()

            dcExecProc.CommandType = CommandType.StoredProcedure

            With dcExecProc.Parameters
                .Add("@CategoryID", SqlDbType.NVarChar).Value = CategoryID
                .Add("@Category", SqlDbType.NVarChar).Value = CatName
                .Add("@Description", SqlDbType.NVarChar).Value = ""

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

    End Function

    Function GetItemCode(ByVal CategoryID As String) As String

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Conn.Open()

            dcGetCode = New SqlCommand("spGetAutoNoItem", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "Item"
            dcGetCode.Parameters.Add("@CatCode", SqlDbType.NVarChar).Value = CategoryID ' cmbCategory.GetColumnValue("CATEGORYID")
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

    Function UpdateInvTable(ByVal DataRow As DataRow, ByVal AdjNo As String, ByVal Itemcode As String) As Boolean
        Dim Conn As New SqlConnection(modMain.ConnString)


        Dim dcExecProc As New SqlCommand("spItemAdjustment", Conn)
        Dim sqlstring As String = ""
        Try

            Conn.Open()

            dcExecProc.CommandType = CommandType.StoredProcedure

            With dcExecProc.Parameters
                .Add("@ADJUSTNO", SqlDbType.NVarChar).Value = AdjNo
                .Add("@ADJDATE", SqlDbType.DateTime).Value = Now.Date
                .Add("@ITEMCODE", SqlDbType.NVarChar).Value = Itemcode
                .Add("@LOCATION", SqlDbType.NVarChar).Value = "Ware House"
                .Add("@PROCQTY", SqlDbType.Float).Value = DataRow("Stocks")
                .Add("@NEWCOST", SqlDbType.Float).Value = 0
                .Add("@TYPE", SqlDbType.NVarChar).Value = "Stock"
                .Add("@PROCSHOTS", SqlDbType.Int).Value = 0

            End With

            dcExecProc.ExecuteNonQuery()
            dcExecProc.Dispose()

            '----- 
            sqlstring = "UPDATE dbo.ItemMaster SET AVGCOST = @ItemPrice,Stockvalue = @Stocks * @ItemPrice WHERE ITEMCODE = @ITEMCODE"
            dcExecProc = New SqlCommand(sqlstring, Conn)
            With dcExecProc.Parameters
                .Add("@ItemPrice", SqlDbType.Float).Value = DataRow("ItemPrice")
                .Add("@Stocks", SqlDbType.Float).Value = DataRow("Stocks")
                .Add("@ITEMCODE", SqlDbType.NVarChar).Value = Itemcode

            End With

            dcExecProc.ExecuteNonQuery()
            dcExecProc.Dispose()


            '----- 
            sqlstring = "UPDATE dbo.ItemInventory SET ITEMPRICE = @ItemPrice WHERE ITEMCODE = @ITEMCODE"
            dcExecProc = New SqlCommand(sqlstring, Conn)
            With dcExecProc.Parameters
                .Add("@ItemPrice", SqlDbType.Float).Value = DataRow("ItemPrice")
                .Add("@ITEMCODE", SqlDbType.NVarChar).Value = Itemcode

            End With

            dcExecProc.ExecuteNonQuery()
            dcExecProc.Dispose()



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

    End Function

    Function SetItemCode(ByVal CategoryID As String) As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Conn.Open()

            dcGetCode = New SqlCommand("spSetAutoNoItem", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "Item"
            dcGetCode.Parameters.Add("@CatCode", SqlDbType.NVarChar).Value = CategoryID ' cmbCategory.GetColumnValue("CATEGORYID")
            dcGetCode.Parameters.Add("@ISSUCCESS", SqlDbType.Bit)
            dcGetCode.Parameters("@ISSUCCESS").Direction = ParameterDirection.Output


            'drGetDets = dcGetCode.ExecuteReader
            dcGetCode.ExecuteNonQuery()


            'If drGetDets.Read Then
            SetItemCode = dcGetCode.Parameters("@ISSUCCESS").Value
            'Else
            'GetSupplierCode = ""
            'End If


            'If Not IsDBNull(dsGetDets.Tables(0).Rows(0).Item(0)) Then
            '    GetSupplierCode = dsGetDets.Tables(0).Rows(0).Item(0).ToString
            'Else
            '    GetSupplierCode = ""
            'End If

            Return SetItemCode
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()
            ' drGetDets.Close()

        End Try

    End Function

    Function SetItemAdj() As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim dcGetCode As New SqlCommand()
        'Dim drGetDets As SqlDataReader


        'Dim daGetCode As New SqlDataAdapter("Select CurrCode from AutoNumberMaster where maintype like 'Supplier'", Conn)
        'Dim dsGetDets As New DataSet

        Try

            Conn.Open()

            dcGetCode = New SqlCommand("spSetAutoNo", Conn)
            dcGetCode.CommandType = CommandType.StoredProcedure
            dcGetCode.Parameters.Add("@MainType", SqlDbType.NVarChar).Value = "Adj"
            dcGetCode.Parameters.Add("@ISSUCCESS", SqlDbType.Bit)
            dcGetCode.Parameters("@ISSUCCESS").Direction = ParameterDirection.Output


            'drGetDets = dcGetCode.ExecuteReader
            dcGetCode.ExecuteNonQuery()


            'If drGetDets.Read Then
            SetItemAdj = dcGetCode.Parameters("@ISSUCCESS").Value
            'Else
            'GetSupplierCode = ""
            'End If


            'If Not IsDBNull(dsGetDets.Tables(0).Rows(0).Item(0)) Then
            '    GetSupplierCode = dsGetDets.Tables(0).Rows(0).Item(0).ToString
            'Else
            '    GetSupplierCode = ""
            'End If

            Return SetItemAdj
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcGetCode.Dispose()
            ' drGetDets.Close()

        End Try

    End Function

    Function InsertUOMDetails() As Boolean
        Dim conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand()
        Dim sqlstr As String = ""

        Try
            conn.Open()

            sqlstr = "INSERT INTO dbo.UOMMaster ( UOMCode ,Description) SELECT DISTINCT UOM,UOM FROM [TEMP.ITEMMASTER] WHERE UOM NOT IN (SELECT DISTINCT UOMCode FROM dbo.UOMMaster)"
            dcExec = New SqlCommand(sqlstr, conn)
            dcExec.ExecuteNonQuery()
            dcExec.Dispose()


            '---- same time we can insert default supplier,default tax
            sqlstr = "INSERT INTO dbo.TaxMaster ( TaxCode ,Description,Percentage,Value) SELECT 'N-T','NO TAX',0,0 WHERE not exists(SELECT * from TaxMaster WHERE TaxCode='N-T')"
            dcExec = New SqlCommand(sqlstr, conn)
            dcExec.ExecuteNonQuery()
            dcExec.Dispose()

            '---- same time we can insert default supplier,default tax
            sqlstr = "INSERT INTO dbo.SupplierMaster ( Suppliercode ,Suppliername ,Status ) SELECT 'DEFAULT','DEFAULT SUPPLIER',1 WHERE not exists(SELECT * from SupplierMaster WHERE Suppliercode='DEFAULT')"
            dcExec = New SqlCommand(sqlstr, conn)
            dcExec.ExecuteNonQuery()
            dcExec.Dispose()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conn.Dispose()
            dcExec.Dispose()
        End Try

    End Function

    Private Sub frmTextFileImport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class