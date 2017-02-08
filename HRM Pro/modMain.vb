Imports System.Data.SqlClient
Imports System.Configuration


Module modMain
    

    '-------------------------------------------------------------------------



    ' Public ConnString As String = "Data Source=RASHAD-PC;Initial Catalog=RMSDB;Integrated Security=True"

    Public ConnString As String = "Data Source= " + ReadSetting("DB_Datasource") + " ;Initial Catalog=" + ReadSetting("DB_Name") +
                                 ";User ID=" + ReadSetting("DB_Username") + ";Password=" + ReadSetting("DB_Password")

    'Public ConnString As String = "Data Source=RASHAD-PC;Initial Catalog=RMSDB;Integrated Security=True"

    'Public ConnString As String = "Data Source=192.168.0.100\INFOCRAFT;Initial Catalog=RmsDB;User ID=sa;Password=infocraft.com"


    Function ReadSetting(key As String)
        Try
            Dim appSettings = ConfigurationManager.AppSettings
            Dim result As String = appSettings(key)
            If IsNothing(result) Then
                result = "Not found"
            End If
            Return result
        Catch e As ConfigurationErrorsException
            Console.WriteLine("Error reading app settings")
        End Try
    End Function



    Public RMSDBSVR As String = "RASHAD-PC"
    'Public RMSDBSVR As String = "192.168.0.100\INFOCRAFT"

    '   RASHAD-PC  =========   192.168.0.100\INFOCRAFT




    Public RMSDBNAME As String = "RMSDB"

    'Public RMSDBNAME As String = "RMSDB"

    'Public RMSDBNAME As String = "RMSDB"

    ' RMSDB


    Public RMSDBUSER As String = "sa"
    Public RMSDBPASS As String = "infocraft.com"



    'Public DBBACKUPPATH As String = "TO DISK = N'D:\DBBACKING\"
    Public DBBACKUPPATH As String = "TO DISK = N'D:\RMSDB_BACKUPS\"



    '------------------------------------------------------------------------------

    Public ErrTitle As String = "Inforcraft RMS Pro™"
    Public CurrUser As String = frmMain.PubLoginuserid
    Public Pubmailfunction As Integer
    Public PubResConNo As String
    Public PubResEmail As String






    Function ValidateAutoNoFunction(ByVal MAINTYPE As String) As Boolean

        Dim Conn As New SqlConnection(ConnString)
        Dim daCount As New SqlDataAdapter
        Dim dsShow As New DataSet
        Dim sqlString As String = String.Empty

        Try
            Conn.Open()

            Select Case MAINTYPE

                Case "Contracts"
                    sqlString = "select count(CURRCODE) from AutoNumberMaster where MAINTYPE like 'Contracts'"
                Case "Reservation"
                    sqlString = "select count(CURRCODE) from AutoNumberMaster where MAINTYPE like 'Reservation'"
                Case "Supplier"
                    sqlString = "select count(CURRCODE) from AutoNumberMaster where MAINTYPE like 'Supplier'"
                Case "Item Category"
                    sqlString = "select ItemCategoryLength from ItemcodeSetting"
                Case "ItemReq"
                    sqlString = "select count(CURRCODE) from AutoNumberMaster where MAINTYPE like 'ItemReq'"
                Case "POReq"
                    sqlString = "select count(CURRCODE) from AutoNumberMaster where MAINTYPE like 'POReq'"
                Case "POMain"
                    sqlString = "select count(CURRCODE) from AutoNumberMaster where MAINTYPE like 'POMain'"
                Case "BN"
                    sqlString = "select count(CURRCODE) from AutoNumberMaster where MAINTYPE like 'BN'"
                Case "GRN"
                    sqlString = "select count(CURRCODE) from AutoNumberMaster where MAINTYPE like 'GRN'"
                Case "GIN"
                    sqlString = "select count(CURRCODE) from AutoNumberMaster where MAINTYPE like 'GIN'"
                Case "MiniBar"
                    sqlString = "select count(CURRCODE) from AutoNumberMaster where MAINTYPE like 'MiniBar'"
                Case "KIC"
                    sqlString = "select count(CURRCODE) from AutoNumberMaster where MAINTYPE like 'KIC'"





                Case Else
            End Select

            daCount = New SqlDataAdapter(sqlString, Conn)
            daCount.Fill(dsShow)


            If dsShow.Tables(0).Rows(0).Item(0) > 0 Then
                Return True 'It means code created
            Else
                Return False
            End If
        Catch ex As ApplicationException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
            Return False
        Finally
            Conn.Dispose()
            daCount.Dispose()
            dsShow.Dispose()
        End Try

    End Function
    Function UserPermission(ByVal Username As String, ByVal ProcessHeader As String, ByVal Action As String) As Boolean


        Dim getAction As String = "[" + Action + "]"
        Dim Conn As New SqlConnection(ConnString)
        Dim daGetPerm As New SqlDataAdapter("select " & getAction & " from vwUsersInAdminPanel where username like '" & Username & "' and processheader like '" & ProcessHeader & "'", Conn)
        Dim dsGetPerm As New DataSet

        Try
            daGetPerm.Fill(dsGetPerm)

            If dsGetPerm.Tables(0).Rows.Count = 0 Then
                Return False
            End If

            Return dsGetPerm.Tables(0).Rows(0).Item(0)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ErrTitle)
        Finally
            Conn.Dispose()
            daGetPerm.Dispose()
            dsGetPerm.Dispose()
        End Try



    End Function

End Module
