Imports System.Data.SqlClient
Public Class TopCodes

   



    Private Sub TopCodes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadAutonos()

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand

        Try

            Dim InvType As String = cmbType.Text.Trim

            Dim passcode As String

            If InvType = "PRO" Then
                passcode = "'INV-PRO-%'"
            End If

            If InvType = "TAX" Then
                passcode = "'INV-TAX-%'"
            End If



            Conn.Open()


            If passcode = "'INV-PRO-%'" Then
                dcSearch = New SqlCommand("select * from AutoNumberMasterTopInv where MAINTYPE='TOP' AND PREFIX LIKE 'INV-PRO-%'", Conn)
            End If

            If passcode = "'INV-TAX-%'" Then
                dcSearch = New SqlCommand("select * from AutoNumberMasterTopInv where MAINTYPE='TOP' AND PREFIX LIKE 'INV-TAX-%'", Conn)
            End If


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            gcProforma.DataSource = dsMain.Tables(0)


            Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1



            While (DScount >= 0)

                Dim topprefx As String = dsMain.Tables(0).Rows(DScount)(0).ToString

                Dim Passtopprefx As String = topprefx + "%"

                Dim Conn3 As New SqlConnection(ConnString)
                Dim dcInsertNewAcc As New SqlCommand

                dcInsertNewAcc = New SqlCommand("spSetAutoNo_Case", Conn) With {.CommandType = CommandType.StoredProcedure}

                dcInsertNewAcc.Parameters.Add("@MainType", SqlDbType.VarChar).Value = InvType
                dcInsertNewAcc.Parameters.Add("@PREFIX1", SqlDbType.VarChar).Value = topprefx
                dcInsertNewAcc.Parameters.Add("@passPREFIX1", SqlDbType.VarChar).Value = Passtopprefx

                'dcInsertNewAcc.Parameters.Add("@MainType", SqlDbType.VarChar).Value = InvType
                'dcInsertNewAcc.Parameters.Add("@PREFIX1", SqlDbType.VarChar).Value = "INV-PRO-NUR-"
                'dcInsertNewAcc.Parameters.Add("@passPREFIX1", SqlDbType.VarChar).Value = "INV-PRO-NUR-%"




                Conn3.Open()
                dcInsertNewAcc.ExecuteNonQuery()

                Conn3.Close()
                DScount = DScount - 1
            End While


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SBSCC Exception")
        Finally
            Conn.Dispose()
            daMain.Dispose()
            dsMain.Dispose()
        End Try

    End Sub


    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        LoadAutonos()
    End Sub

   
End Class