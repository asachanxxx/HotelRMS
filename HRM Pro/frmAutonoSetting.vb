Imports System.Data.SqlClient
Imports System.Xml

Public Class frmAutonoSetting

  

#Region " General Procs & Funds "

    Private Sub frmAutonoSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        LoadPageDetails()
    End Sub

    Private Sub tabAutoNo_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tabAutoNo.SelectedPageChanged
        LoadPageDetails()
    End Sub

    Private Sub LoadPageDetails()

        Try
            Select Case tabAutoNo.SelectedTabPageIndex
                Case 0 'Item'

                Case 1 'Supplier
                    ShowDetails_Supplier()


            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)

        End Try

    End Sub

#End Region

#Region " Supplier "

#Region " Procs & Funcs "
    Sub ShowDetails_Supplier()
        Dim Conn As New SqlConnection(ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Dim daGetSupps As New SqlDataAdapter("select * from AutoNumberMaster where maintype like 'Supplier' order by INCNUMBER ASC", Conn)
        Dim dsShowSupps As New DataSet

        Try

            Conn.Open()
            daGetSupps.Fill(dsShowSupps)

            If dsShowSupps.Tables(0).Rows.Count > 0 Then
                'daGetDets = New SqlDataAdapter("select * from AutoNumberMaster MAINTYPE='Supplier'", Conn)
                'daGetDets.Fill(dsShow)

                'txtInc_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("INCNUMBER")
                'txtLen_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("TOTALLENGTH")
                'txtPF_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("PREFIX")
                ' txtSample_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("CurrCode")
                txtCurr_Supplier.Text = dsShowSupps.Tables(0).Rows(0).Item("CurrCode")
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetSupps.Dispose()
            dsShowSupps.Dispose()
           
        End Try

    End Sub

    ''' <summary>
    ''' This ll generate the Suppliercode.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Create_Supplier() As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand()


        Try
            Conn.Open()

            dcExec = New SqlCommand("spAutoNumberGen", Conn)
            dcExec.CommandType = CommandType.StoredProcedure

            With dcExec.Parameters
                .Add("@MAINTYPE", SqlDbType.NVarChar).Value = "Supplier"
                .Add("@PREFIX", SqlDbType.NVarChar).Value = txtPF_Supp.Text.Trim
                .Add("@INCNUMBER", SqlDbType.Float).Value = txtInc_Supp.Text.Trim
                .Add("@TOTALLENGTH", SqlDbType.Float).Value = txtLen_Supp.Text
                .Add("@CURRCODE", SqlDbType.NVarChar).Value = txtSample_Supp.Text.Trim
            End With

            dcExec.ExecuteNonQuery()


            Return True
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcExec.Dispose()

        End Try

    End Function

    Function GenerateCode_Supplier() As String


        Try

            Dim GeneCode As String

            If txtPF_Supp.Text = "" Then
                Return 0
            End If

            If txtLen_Supp.Text = "" Or txtLen_Supp.Text.Length = 0 Or Val(txtLen_Supp.Text) <= 0 Then
                Return 0
            End If

            If txtInc_Supp.Text = "" Or txtInc_Supp.Text.Length = 0 Then
                Return 0
            End If

            GeneCode = txtPF_Supp.Text.Trim & txtInc_Supp.Text.PadLeft(Val(txtLen_Supp.Text) - (txtPF_Supp.Text.Length), "0")

            GenerateCode_Supplier = GeneCode


        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            GenerateCode_Supplier = ""
        End Try


    End Function

#End Region

#Region " Control Events "

    Private Sub cmdApplySupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApplySupplier.Click
        If txtSample_Supp.Text = "" Or txtSample_Supp.Text.Length = 0 Then
            Exit Sub
        End If

        Call Create_Supplier()

    End Sub

    Private Sub txtCurr_Supplier_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurr_Supplier.Enter
        txtCurr_Supplier.Properties.ReadOnly = True
    End Sub

    Private Sub txtCurr_Supplier_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCurr_Supplier.Leave
        txtCurr_Supplier.Properties.ReadOnly = False
    End Sub

    ''' <summary>
    ''' Whenever these three value changed, we need to recreate the sample code.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub txtPF_Supp_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPF_Supp.EditValueChanged, txtInc_Supp.EditValueChanged, txtLen_Supp.EditValueChanged
        txtSample_Supp.Text = GenerateCode_Supplier()
    End Sub

#End Region

#End Region

#Region " Item "


#Region " Procs & Funcs "

    Sub ShowDetails_Item()
        Dim Conn As New SqlConnection(ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Dim daGetSupps As New SqlDataAdapter("select ItemCategoryLengh,ItemcodeLengh from ItemcodeSetting", Conn)
        Dim dsShowSupps As New DataSet

        Try

            Conn.Open()
            daGetSupps.Fill(dsShowSupps)

            If dsShowSupps.Tables(0).Rows.Count > 0 Then
                txtPrefixLength_Itemcode.Text = dsShowSupps.Tables(0).Rows(0).Item("ItemcodeLengh")
                txtPrefixLength_ItemCat.Text = dsShowSupps.Tables(0).Rows(0).Item("ItemCategoryLengh")
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetSupps.Dispose()
            dsShowSupps.Dispose()
        End Try

    End Sub

    ''' <summary>
    ''' This ll generate the Suppliercode.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Create_Item() As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand()


        Try
            Conn.Open()

            dcExec = New SqlCommand("spItemcodesetting", Conn)
            dcExec.CommandType = CommandType.StoredProcedure

            With dcExec.Parameters
                .Add("@ICODELENG", SqlDbType.SmallInt).Value = txtPrefixLength_Itemcode.Text.Trim
                .Add("@ICATLENG", SqlDbType.SmallInt).Value = txtPrefixLength_ItemCat.Text.Trim
             End With

            dcExec.ExecuteNonQuery()


            Return True
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcExec.Dispose()

        End Try

    End Function

#End Region

#Region " Control Events "

    Private Sub cmdApply_ItemCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply_ItemCat.Click
        If txtPrefixLength_ItemCat.Text = "" Or txtPrefixLength_ItemCat.Text.Length = 0 Or Val(txtPrefixLength_ItemCat.Text) = 0 Then
            Exit Sub
        ElseIf txtPrefixLength_Itemcode.Text = "" Or txtPrefixLength_Itemcode.Text.Length = 0 Or Val(txtPrefixLength_Itemcode.Text) = 0 Then
            Exit Sub
        End If

        Call Create_Item()
    End Sub

#End Region

#End Region

#Region " Item Requisition "

#Region " Procs & Funcs "
    Sub ShowDetails_ItemReq()
        Dim Conn As New SqlConnection(ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Dim daGetSupps As New SqlDataAdapter("select * from AutoNumberMaster where maintype like 'ItemReq' order by INCNUMBER ASC", Conn)
        Dim dsShowSupps As New DataSet

        Try

            Conn.Open()
            daGetSupps.Fill(dsShowSupps)

            If dsShowSupps.Tables(0).Rows.Count > 0 Then
                'daGetDets = New SqlDataAdapter("select * from AutoNumberMaster MAINTYPE='Supplier'", Conn)
                'daGetDets.Fill(dsShow)

                'txtInc_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("INCNUMBER")
                'txtLen_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("TOTALLENGTH")
                'txtPF_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("PREFIX")
                ' txtSample_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("CurrCode")
                txtCurr_ItemReq.Text = dsShowSupps.Tables(0).Rows(0).Item("CurrCode")
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetSupps.Dispose()
            dsShowSupps.Dispose()

        End Try

    End Sub

    ''' <summary>
    ''' This ll generate the ITReq code.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Create_ItemReq() As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand()


        Try
            Conn.Open()

            dcExec = New SqlCommand("spAutoNumberGen", Conn)
            dcExec.CommandType = CommandType.StoredProcedure

            With dcExec.Parameters
                .Add("@MAINTYPE", SqlDbType.NVarChar).Value = "ItemReq"
                .Add("@PREFIX", SqlDbType.NVarChar).Value = txtPF_ItemReq.Text.Trim
                .Add("@INCNUMBER", SqlDbType.Float).Value = txtInc_ItemReq.Text.Trim
                .Add("@TOTALLENGTH", SqlDbType.Float).Value = txtLen_ItemReq.Text
                .Add("@CURRCODE", SqlDbType.NVarChar).Value = txtSample_ItemReq.Text.Trim
            End With

            dcExec.ExecuteNonQuery()

            MsgBox("Successfully Updated")
            Return True
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcExec.Dispose()

        End Try

    End Function

    Function GenerateCode_ItemReq() As String


        Try

            Dim GeneCode As String

            If txtPF_ItemReq.Text = "" Then
                Return 0
            End If

            If txtLen_ItemReq.Text = "" Or txtLen_ItemReq.Text.Length = 0 Or Val(txtLen_ItemReq.Text) <= 0 Then
                Return 0
            End If

            If txtInc_ItemReq.Text = "" Or txtInc_ItemReq.Text.Length = 0 Then
                Return 0
            End If

            GeneCode = txtPF_ItemReq.Text.Trim & txtInc_ItemReq.Text.PadLeft(Val(txtLen_ItemReq.Text) - (txtPF_ItemReq.Text.Length), "0")

            GenerateCode_ItemReq = GeneCode


        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            GenerateCode_ItemReq = ""
        End Try


    End Function

#End Region

#Region " Control Events "

    Private Sub cmdApplyItemReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApplyItemReq.Click
        If txtSample_ItemReq.Text = "" Or txtSample_ItemReq.Text.Length = 0 Then
            Exit Sub
        End If

        Call Create_ItemReq()

    End Sub

    Private Sub txtCurr_ItemReq_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurr_ItemReq.Enter
        txtCurr_ItemReq.Properties.ReadOnly = True
    End Sub

    Private Sub txtCurr_ItemReq_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCurr_ItemReq.Leave
        txtCurr_ItemReq.Properties.ReadOnly = False
    End Sub

    ''' <summary>
    ''' Whenever these three value changed, we need to recreate the sample code.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub txtPF_ItemReq_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPF_ItemReq.EditValueChanged, txtInc_ItemReq.EditValueChanged, txtLen_ItemReq.EditValueChanged
        txtSample_ItemReq.Text = GenerateCode_ItemReq()
    End Sub

#End Region

#End Region

#Region " Contracts "

#Region " Procs & Funcs "
    Sub ShowDetails_Contracts()
        Dim Conn As New SqlConnection(ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Dim daGetSupps As New SqlDataAdapter("select * from AutoNumberMaster where maintype like 'Contracts' order by INCNUMBER ASC", Conn)
        Dim dsShowSupps As New DataSet

        Try

            Conn.Open()
            daGetSupps.Fill(dsShowSupps)

            If dsShowSupps.Tables(0).Rows.Count > 0 Then
                'daGetDets = New SqlDataAdapter("select * from AutoNumberMaster MAINTYPE='Supplier'", Conn)
                'daGetDets.Fill(dsShow)

                'txtInc_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("INCNUMBER")
                'txtLen_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("TOTALLENGTH")
                'txtPF_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("PREFIX")
                ' txtSample_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("CurrCode")
                txtCurr_Supplier.Text = dsShowSupps.Tables(0).Rows(0).Item("CurrCode")
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetSupps.Dispose()
            dsShowSupps.Dispose()

        End Try

    End Sub

    ''' <summary>
    ''' This ll generate the TOP code.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Create_Contracts() As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand()


        Try
            Conn.Open()

            dcExec = New SqlCommand("spAutoNumberGen", Conn)
            dcExec.CommandType = CommandType.StoredProcedure

            With dcExec.Parameters
                .Add("@MAINTYPE", SqlDbType.NVarChar).Value = "Contracts"
                .Add("@PREFIX", SqlDbType.NVarChar).Value = txtPF_TOP.Text.Trim
                .Add("@INCNUMBER", SqlDbType.Float).Value = txtInc_TOP.Text.Trim
                .Add("@TOTALLENGTH", SqlDbType.Float).Value = txtLen_TOP.Text
                .Add("@CURRCODE", SqlDbType.NVarChar).Value = txtSample_TOP.Text.Trim
            End With

            dcExec.ExecuteNonQuery()


            Return True
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcExec.Dispose()

        End Try

    End Function

    Function GenerateCode_Contracts() As String


        Try

            Dim GeneCode As String

            If txtPF_TOP.Text = "" Then
                Return 0
            End If

            If txtLen_TOP.Text = "" Or txtLen_TOP.Text.Length = 0 Or Val(txtLen_TOP.Text) <= 0 Then
                Return 0
            End If

            If txtInc_TOP.Text = "" Or txtInc_TOP.Text.Length = 0 Then
                Return 0
            End If

            GeneCode = txtPF_TOP.Text.Trim & txtInc_TOP.Text.PadLeft(Val(txtLen_TOP.Text) - (txtPF_TOP.Text.Length), "0")

            GenerateCode_Contracts = GeneCode


        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            GenerateCode_Contracts = ""
        End Try


    End Function

#End Region

#Region " Control Events "

    Private Sub cmdApplyTOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApplyTOP.Click
        If txtSample_TOP.Text = "" Or txtSample_TOP.Text.Length = 0 Then
            Exit Sub
        End If

        Call Create_Contracts()

    End Sub

    Private Sub txtCurr_TOP_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurr_TOP.Enter
        txtCurr_TOP.Properties.ReadOnly = True
    End Sub

    Private Sub txtCurr_TOP_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCurr_TOP.Leave
        txtCurr_TOP.Properties.ReadOnly = False
    End Sub

    ''' <summary>
    ''' Whenever these three value changed, we need to recreate the sample code.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub txtPF_TOP_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPF_TOP.EditValueChanged, txtInc_TOP.EditValueChanged, txtLen_TOP.EditValueChanged
        txtSample_TOP.Text = GenerateCode_Contracts()
    End Sub

#End Region

#End Region





#Region " Reservation "

#Region " Procs & Funcs "
    Sub ShowDetails_Reservation()
        Dim Conn As New SqlConnection(ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Dim daGetSupps As New SqlDataAdapter("select * from AutoNumberMaster where maintype like 'Reservation' order by INCNUMBER ASC", Conn)
        Dim dsShowSupps As New DataSet

        Try

            Conn.Open()
            daGetSupps.Fill(dsShowSupps)

            If dsShowSupps.Tables(0).Rows.Count > 0 Then
                'daGetDets = New SqlDataAdapter("select * from AutoNumberMaster MAINTYPE='Reservation'", Conn)
                'daGetDets.Fill(dsShow)

                'txtInc_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("INCNUMBER")
                'txtLen_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("TOTALLENGTH")
                'txtPF_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("PREFIX")
                ' txtSample_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("CurrCode")
                txtCurr_Res.Text = dsShowSupps.Tables(0).Rows(0).Item("CurrCode")
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetSupps.Dispose()
            dsShowSupps.Dispose()

        End Try

    End Sub

    ''' <summary>
    ''' This ll generate the Reservationcode.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Create_Reservation() As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand()


        Try
            Conn.Open()

            dcExec = New SqlCommand("spAutoNumberGen", Conn)
            dcExec.CommandType = CommandType.StoredProcedure

            With dcExec.Parameters
                .Add("@MAINTYPE", SqlDbType.NVarChar).Value = "Reservation"
                .Add("@PREFIX", SqlDbType.NVarChar).Value = txtPF_Res.Text.Trim
                .Add("@INCNUMBER", SqlDbType.Float).Value = txtInc_Res.Text.Trim
                .Add("@TOTALLENGTH", SqlDbType.Float).Value = txtLen_Res.Text
                .Add("@CURRCODE", SqlDbType.NVarChar).Value = txtSample_Res.Text.Trim
            End With

            dcExec.ExecuteNonQuery()


            Return True
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcExec.Dispose()

        End Try

    End Function

    Function GenerateCode_Reservation() As String


        Try

            Dim GeneCode As String

            If txtPF_Res.Text = "" Then
                Return 0
            End If

            If txtLen_Res.Text = "" Or txtLen_Res.Text.Length = 0 Or Val(txtLen_Res.Text) <= 0 Then
                Return 0
            End If

            If txtInc_Res.Text = "" Or txtInc_Res.Text.Length = 0 Then
                Return 0
            End If

            GeneCode = txtPF_Res.Text.Trim & txtInc_Res.Text.PadLeft(Val(txtLen_Res.Text) - (txtPF_Res.Text.Length), "0")

            GenerateCode_Reservation = GeneCode


        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            GenerateCode_Reservation = ""
        End Try


    End Function

#End Region

#Region " Control Events "

    Private Sub cmdApplyReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApplyRes.Click
        If txtSample_Res.Text = "" Or txtSample_Res.Text.Length = 0 Then
            Exit Sub
        End If

        Call Create_Reservation()

    End Sub

    Private Sub txtCurr_Resn_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurr_Res.Enter
        txtCurr_Res.Properties.ReadOnly = True
    End Sub

    Private Sub txtCurr_Res_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCurr_Res.Leave
        txtCurr_Res.Properties.ReadOnly = False
    End Sub

    ''' <summary>
    ''' Whenever these three value changed, we need to recreate the sample code.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub txtPF_Res_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPF_Res.EditValueChanged, txtInc_Res.EditValueChanged, txtLen_Res.EditValueChanged
        txtSample_Res.Text = GenerateCode_Reservation()
    End Sub

#End Region

#End Region







#Region " ProInv "

#Region " Procs & Funcs "
    Sub ShowDetails_ProInv()
        Dim Conn As New SqlConnection(ConnString)
        Dim daGetDets As New SqlDataAdapter()
        Dim dsShow As New DataSet

        Dim daGetSupps As New SqlDataAdapter("select * from AutoNumberMaster where maintype like 'ProInv' order by INCNUMBER ASC", Conn)
        Dim dsShowSupps As New DataSet

        Try

            Conn.Open()
            daGetSupps.Fill(dsShowSupps)

            If dsShowSupps.Tables(0).Rows.Count > 0 Then
                'daGetDets = New SqlDataAdapter("select * from AutoNumberMaster MAINTYPE='Reservation'", Conn)
                'daGetDets.Fill(dsShow)

                'txtInc_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("INCNUMBER")
                'txtLen_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("TOTALLENGTH")
                'txtPF_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("PREFIX")
                ' txtSample_Supp.Text = dsShowSupps.Tables(0).Rows(0).Item("CurrCode")
                txtCurr_ProInv.Text = dsShowSupps.Tables(0).Rows(0).Item("CurrCode")
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetSupps.Dispose()
            dsShowSupps.Dispose()

        End Try

    End Sub

    ''' <summary>
    ''' This ll generate the Reservationcode.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Create_ProInv() As Boolean
        Dim Conn As New SqlConnection(ConnString)
        Dim dcExec As New SqlCommand()


        Try
            Conn.Open()

            dcExec = New SqlCommand("spAutoNumberGen", Conn)
            dcExec.CommandType = CommandType.StoredProcedure

            With dcExec.Parameters
                .Add("@MAINTYPE", SqlDbType.NVarChar).Value = "ProInv"
                .Add("@PREFIX", SqlDbType.NVarChar).Value = txtPF_ProInv.Text.Trim
                .Add("@INCNUMBER", SqlDbType.Float).Value = txtInc_ProInv.Text.Trim
                .Add("@TOTALLENGTH", SqlDbType.Float).Value = txtLen_ProInv.Text
                .Add("@CURRCODE", SqlDbType.NVarChar).Value = txtSample_ProInv.Text.Trim
            End With

            dcExec.ExecuteNonQuery()


            Return True
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            dcExec.Dispose()

        End Try

    End Function

    Function GenerateCode_ProInv() As String


        Try

            Dim GeneCode As String

            If txtPF_ProInv.Text = "" Then
                Return 0
            End If

            If txtLen_ProInv.Text = "" Or txtLen_ProInv.Text.Length = 0 Or Val(txtLen_ProInv.Text) <= 0 Then
                Return 0
            End If

            If txtInc_ProInv.Text = "" Or txtInc_ProInv.Text.Length = 0 Then
                Return 0
            End If

            GeneCode = txtPF_ProInv.Text.Trim & txtInc_ProInv.Text.PadLeft(Val(txtLen_ProInv.Text) - (txtPF_ProInv.Text.Length), "0")

            GenerateCode_ProInv = GeneCode


        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            GenerateCode_ProInv = ""
        End Try


    End Function

#End Region

#Region " Control Events "

    Private Sub cmdApplyProInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApplyProInv.Click
        If txtSample_ProInv.Text = "" Or txtSample_ProInv.Text.Length = 0 Then
            Exit Sub
        End If

        Call Create_ProInv()

    End Sub

    Private Sub txtCurr_ProInv_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurr_ProInv.Enter
        txtCurr_ProInv.Properties.ReadOnly = True
    End Sub

    Private Sub txtCurr_ProInv_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCurr_ProInv.Leave
        txtCurr_ProInv.Properties.ReadOnly = False
    End Sub

    ''' <summary>
    ''' Whenever these three value changed, we need to recreate the sample code.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub txtPF_ProInv_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPF_ProInv.EditValueChanged, txtInc_ProInv.EditValueChanged, txtLen_ProInv.EditValueChanged
        txtSample_ProInv.Text = GenerateCode_ProInv()
    End Sub

#End Region

#End Region






End Class