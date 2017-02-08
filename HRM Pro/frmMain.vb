Imports System.Threading
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Public Class frmMain

    Public PubLoginUser As String
    Public PubLoginuserid As String

    Public POR111 As Integer = 0

    Public POR112 As Integer = 0
    Public POR113 As Integer = 0
    Public POR114 As Integer = 0
    Public POR115 As Integer = 0
    Public POR116 As Integer = 0
    Public POR117 As Integer = 0

    Public POR118 As Integer = 0
    Public POR119 As Integer = 0
    Public POR120 As Integer = 0
    Public POR121 As Integer = 0
    Public POR122 As Integer = 0
    Public POR123 As Integer = 0
    Public POR124 As Integer = 0
    Public POR125 As Integer = 0

    Public POR126 As Integer = 0
    Public POR127 As Integer = 0
    Public POR128 As Integer = 0
    Public POR129 As Integer = 0
    Public POR130 As Integer = 0
    Public POR131 As Integer = 0
    Public POR132 As Integer = 0
    Public POR133 As Integer = 0
    Public POR134 As Integer = 0
    Public POR135 As Integer = 0
    Public POR136 As Integer = 0
    Public POR137 As Integer = 0
    Public POR138 As Integer = 0
    Public POR139 As Integer = 0
    Public POR140 As Integer = 0
    Public POR141 As Integer = 0
    Public POR142 As Integer = 0
    Public POR143 As Integer = 0
    Public POR144 As Integer = 0
    Public POR145 As Integer = 0
    Public POR146 As Integer = 0

    Public POR147 As Integer = 0
    Public POR148 As Integer = 0
    Public POR149 As Integer = 0
    Public POR150 As Integer = 0
    Public POR151 As Integer = 0
    Public POR152 As Integer = 0
    Public POR153 As Integer = 0
    Public POR154 As Integer = 0
    Public POR155 As Integer = 0
    Public POR156 As Integer = 0
    Public POR157 As Integer = 0
    Public POR158 As Integer = 0
    Public POR159 As Integer = 0
    Public POR160 As Integer = 0


    Public POR161 As Integer = 0
    Public POR162 As Integer = 0
    Public POR163 As Integer = 0
    Public POR164 As Integer = 0
    Public POR165 As Integer = 0
    Public POR166 As Integer = 0


    Public POR201 As Integer = 0
    Public POR202 As Integer = 0
    Public POR203 As Integer = 0
    Public POR204 As Integer = 0

    Public POR205 As Integer = 0
    Public POR206 As Integer = 0
    Public POR207 As Integer = 0
    Public POR208 As Integer = 0
    Public POR209 As Integer = 0
    Public POR210 As Integer = 0


    Public PGR111 As String = ""

    Public PGR112 As String = ""
    Public PGR113 As String = ""
    Public PGR114 As String = ""
    Public PGR115 As String = ""
    Public PGR116 As String = ""
    Public PGR117 As String = ""

    Public PGR118 As String = ""
    Public PGR119 As String = ""
    Public PGR120 As String = ""
    Public PGR121 As String = ""
    Public PGR122 As String = ""
    Public PGR123 As String = ""
    Public PGR124 As String = ""
    Public PGR125 As String = ""

    Public PGR126 As String = ""
    Public PGR127 As String = ""
    Public PGR128 As String = ""
    Public PGR129 As String = ""
    Public PGR130 As String = ""
    Public PGR131 As String = ""
    Public PGR132 As String = ""
    Public PGR133 As String = ""
    Public PGR134 As String = ""
    Public PGR135 As String = ""
    Public PGR136 As String = ""
    Public PGR137 As String = ""
    Public PGR138 As String = ""
    Public PGR139 As String = ""
    Public PGR140 As String = ""
    Public PGR141 As String = ""
    Public PGR142 As String = ""
    Public PGR143 As String = ""
    Public PGR144 As String = ""
    Public PGR145 As String = ""
    Public PGR146 As String = ""

    Public PGR147 As String = ""
    Public PGR148 As String = ""
    Public PGR149 As String = ""
    Public PGR150 As String = ""
    Public PGR151 As String = ""
    Public PGR152 As String = ""
    Public PGR153 As String = ""
    Public PGR154 As String = ""
    Public PGR155 As String = ""
    Public PGR156 As String = ""
    Public PGR157 As String = ""
    Public PGR158 As String = ""
    Public PGR159 As String = ""
    Public PGR160 As String = ""


    Public PGR161 As String = ""
    Public PGR162 As String = ""
    Public PGR163 As String = ""
    Public PGR164 As String = ""
    Public PGR165 As String = ""
    Public PGR166 As String = ""


    Public PGR201 As String = ""
    Public PGR202 As String = ""
    Public PGR203 As String = ""
    Public PGR204 As String = ""

    Public PGR205 As String = ""
    Public PGR206 As String = ""
    Public PGR207 As String = ""
    Public PGR208 As String = ""
    Public PGR209 As String = ""
    Public PGR210 As String = ""
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        'Dim abc As DevExpress.XtraEditors.XtraForm = frmLogin
        'abc.Close()



        'frmLogin.Visible = False

        'frmLogin.Hide()
        'frmLogin.Close()


        Dim CurrentUser As String = CurrUser
        If CurrentUser = "Admin" Then

            AdminPanelToolStripMenuItem.Visible = True

            'nbiFrontOffice.Enabled = True
            'nbiBackOffice.Enabled = True
            'nbiInventory.Enabled = True

            'nbFrontOfficeOp.Enabled = True
            'nbBackOfficeOp.Enabled = True
            'nbInvOp.Enabled = True
            'nbHKOp.Enabled = True

            'nbiPrevillage.Enabled = True
            'nbiUsers.Enabled = True
            'nbiRestore.Enabled = True
            'nbiBackup.Enabled = True

        Else

            'If CurrentUser = "Res" Then
            '    nbiFrontOffice.Enabled = True
            '    'nbiBackOffice.Enabled = True
            '    nbFrontOfficeOp.Enabled = True
            'End If

            'If CurrentUser = "Janaka" Then
            '    nbiBackOffice.Enabled = True
            '    nbBackOfficeOp.Enabled = True
            '    nbiInventory.Enabled = True
            '    nbiFrontOffice.Enabled = True

            'End If


            'If CurrentUser = "Koshi" Then
            '    nbiBackOffice.Enabled = True
            '    nbBackOfficeOp.Enabled = True
            '    nbiInventory.Enabled = True
            '    nbiFrontOffice.Enabled = True
            'End If


            'If CurrentUser = "stores" Then
            '    nbiInventory.Enabled = True
            '    nbInvOp.Enabled = True

            'End If


        End If

        CheckNewMsg()


    End Sub
    Private Sub icoMaster_ItemCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ItemCategory", "View")

        If CheckAccess = True Then




            frmItemCategory.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If


    End Sub
    Sub EnableGroup(ByVal GroupControl As String)

        Select Case GroupControl
            Case "Inventory_Master"
                ' gbMaster_Inventory.BringToFront()
            Case Else

        End Select
    End Sub
    Private Sub icoMaster_Supplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "SupplierMaster", "View")

        If CheckAccess = True Then


            frmSupplier.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If


    End Sub
    Private Sub nbiFrontOffice_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiFrontOffice.LinkClicked

        gbMaster_FrontOffice.Visible = True

        gbMaster_BackOffice.Visible = False
        gbMaster_Inventory.Visible = False
        gbOperation_FrontOffice.Visible = False
        gbOperation_BackOffice.Visible = False
        gbOperation_Inventory.Visible = False
        gbOperation_housekeeping.Visible = False
        gbRoomStatus.Visible = False



    End Sub
    Private Sub nbiBackOffice_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiBackOffice.LinkClicked
        gbMaster_BackOffice.Visible = True

        gbMaster_FrontOffice.Visible = False
        gbMaster_Inventory.Visible = False
        gbOperation_FrontOffice.Visible = False
        gbOperation_BackOffice.Visible = False
        gbOperation_Inventory.Visible = False
        gbOperation_housekeeping.Visible = False
        gbRoomStatus.Visible = False

    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmBoat.Show()

    End Sub
    Private Sub SimpleButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatMaster", "View")

        If CheckAccess = True Then

            frmBoat.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "FlightMaster", "View")

        If CheckAccess = True Then


            frmFlightSchedule.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TourOperatorMaster", "View")

        If CheckAccess = True Then

            frmTourOperators.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        frmEventDetails.Show()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "RoomRates", "View")

        If CheckAccess = True Then

            frmRoomRates.Show()
            'frmRoomMaster.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "DiscountPlan", "View")

        If CheckAccess = True Then


            frmDiscountplan.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmOfferComplimentary.Show()

    End Sub

    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "MealPlans", "View")

        If CheckAccess = True Then
            frmMealplan.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TourOperatorContracts Master", "View")

        If CheckAccess = True Then

            'frmTourOperatorContractMaster.Show()

            'SplashScreenManagerMain.ShowWaitForm()

            'SplashScreenManagerMain.SetWaitFormDescription("Validating for AutoNo")

            'Thread.Sleep(5000)

            'If ValidateAutoNoFunction("Contracts") Then
            '    SplashScreenManagerMain.SetWaitFormDescription("Loading Tour Operator Contracts Details")
            '    Thread.Sleep(1000)
            '    SplashScreenManagerMain.CloseWaitForm()
            frmTourOperatorContractMaster.Show()

            'Else
            'SplashScreenManagerMain.SetWaitFormDescription("Redirecting to Autono Creation")
            'Thread.Sleep(1000)
            'SplashScreenManagerMain.CloseWaitForm()

            ''frmAutonoSetting.tabAutoNo.SelectedTabPageIndex = 1
            'frmAutonoSetting.Show()
            'End If


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton10.Click
        frmLaunchsectionfoodrates.Show()

    End Sub

    Private Sub SimpleButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton11.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "SeaConditionMaster", "View")

        If CheckAccess = True Then


            frmSeacondition.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub SimpleButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton12.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ExchangeRateMaster", "View")

        If CheckAccess = True Then


            frmExchangeRate.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton13.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TaxMaster", "View")

        If CheckAccess = True Then
            frmTax.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton19.Click
        frmDepartment.Show()
    End Sub

    Private Sub SimpleButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton18.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "SupplierMaster", "View")

        If CheckAccess = True Then


            frmSupplier.Show()



        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton17.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ItemCategory", "View")

        If CheckAccess = True Then



            'SplashScreenManagerMain.ShowWaitForm()

            'SplashScreenManagerMain.SetWaitFormDescription("Validating for AutoNo")

            'Thread.Sleep(5000)

            'If ValidateAutoNoFunction("Item Category") Then
            '    SplashScreenManagerMain.SetWaitFormDescription("Item Category")
            '    Thread.Sleep(1000)
            '    SplashScreenManagerMain.CloseWaitForm()
            frmItemCategory.Show()

            'Else
            'SplashScreenManagerMain.SetWaitFormDescription("Redirecting to Item category")
            'Thread.Sleep(1000)
            'SplashScreenManagerMain.CloseWaitForm()

            ''frmAutonoSetting.tabAutoNo.SelectedTabPageIndex = 1
            'frmAutonoSetting.Show()
            'End If

        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub SimpleButton28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton28.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Items", "View")

        If CheckAccess = True Then


            frmItemMain.Show()



        Else

            MsgBox("You Do Not Have Access")


        End If
    End Sub

    Private Sub nbiInventory_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiInventory.LinkClicked

        gbMaster_Inventory.Visible = True

        gbMaster_BackOffice.Visible = False
        gbMaster_FrontOffice.Visible = False
        gbOperation_FrontOffice.Visible = False
        gbOperation_BackOffice.Visible = False
        gbOperation_Inventory.Visible = False
        gbOperation_housekeeping.Visible = False
        gbRoomStatus.Visible = False


    End Sub

    Private Sub SimpleButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton23.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Reservation", "View")

        If CheckAccess = True Then

        'SplashScreenManagerMain.ShowWaitForm()

        'SplashScreenManagerMain.SetWaitFormDescription("Validating for AutoNo")

        'Thread.Sleep(5000)

        'If ValidateAutoNoFunction("Reservation") Then
        '    SplashScreenManagerMain.SetWaitFormDescription("Loading Reservation")
        '    Thread.Sleep(1000)
        '    SplashScreenManagerMain.CloseWaitForm()
        frmReservation.Show()

        'Else
        'SplashScreenManagerMain.SetWaitFormDescription("Redirecting to Auto no Creation")
        'Thread.Sleep(1000)
        'SplashScreenManagerMain.CloseWaitForm()

        ''frmAutonoSetting.tabAutoNo.SelectedTabPageIndex = 1
        'frmAutonoSetting.Show()
        'End If


            ''frmReservation.Show()



        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton20.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GuestRegistration", "View")

        If CheckAccess = True Then

            'SplashScreenManagerMain.ShowWaitForm()

            'SplashScreenManagerMain.SetWaitFormDescription("Validating for AutoNo")

            'Thread.Sleep(5000)

            'If ValidateAutoNoFunction("Reservation") Then
            '    SplashScreenManagerMain.SetWaitFormDescription("Loading Reservation")
            '    Thread.Sleep(1000)
            '    SplashScreenManagerMain.CloseWaitForm()
            '    frmReservation.Show()

            'Else
            '    SplashScreenManagerMain.SetWaitFormDescription("Redirecting to Auto no Creation")
            '    Thread.Sleep(1000)
            '    SplashScreenManagerMain.CloseWaitForm()

            '    'frmAutonoSetting.tabAutoNo.SelectedTabPageIndex = 1
            '    frmAutonoSetting.Show()
            'End If

            frmReservertionSearch.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub SimpleButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton21.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GuestProfile", "View")

        If CheckAccess = True Then


            '  frmGuestregister.Show()
            ' frmGuestView.Show()
            frmGuestRegisterView.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub nbFrontOfficeOp_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbFrontOfficeOp.LinkClicked

        gbOperation_FrontOffice.Visible = True
        gbMaster_Inventory.Visible = False

        gbMaster_BackOffice.Visible = False
        gbMaster_FrontOffice.Visible = False
        gbOperation_BackOffice.Visible = False
        gbOperation_Inventory.Visible = False
        gbOperation_housekeeping.Visible = False
        gbRoomStatus.Visible = False

    End Sub

    Private Sub SimpleButton30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton30.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GuestFeedbackAndComments", "View")

        If CheckAccess = True Then



            frmGuestFeedBack_Comments.Show()




        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton31.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatScheduling", "View")

        If CheckAccess = True Then


            'frmBoatScheduling.Show()
            frmBoatSchedule.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton32.Click
        frmEventBoard.Show()

    End Sub

    Private Sub SimpleButton44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' frmBOT_Billing.Show()


    End Sub

    Private Sub SimpleButton33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  frmKOT_Billing.Show()

    End Sub

    Private Sub SimpleButton34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton34.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "KOTBOTBilling", "View")

        Dim CheckAccess2 As Boolean = UserPermission(CurrUser, "OutletBilling", "View")

        If CheckAccess = True Or CheckAccess2 = True Then



            frmKOT_BOT_Billing.Show()
            ' frmKOT_BOT_Billing.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub SimpleButton37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton37.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Pro-formaInvoicing", "View")

        If CheckAccess = True Then

            frmProfomainvoice.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub SimpleButton39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton39.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "TaxInvoicing", "View")

        If CheckAccess = True Then


            frmTaxinvoice.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub nbBackOfficeOp_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbBackOfficeOp.LinkClicked
        gbOperation_BackOffice.Visible = True


        gbOperation_FrontOffice.Visible = False
        gbMaster_Inventory.Visible = False
        gbMaster_BackOffice.Visible = False
        gbMaster_FrontOffice.Visible = False
        gbOperation_Inventory.Visible = False
        gbOperation_housekeeping.Visible = False
        gbRoomStatus.Visible = False


    End Sub

    Private Sub SimpleButton48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton48.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ItemRequest", "View")

        If CheckAccess = True Then


            'SplashScreenManagerMain.ShowWaitForm()

            'SplashScreenManagerMain.SetWaitFormDescription("Validating for AutoNo")



            'Thread.Sleep(1000)

            'If ValidateAutoNoFunction("ItemReq") Then
            '    SplashScreenManagerMain.SetWaitFormDescription("Loading Item Requisition Details")
            '    Thread.Sleep(1000)
            '    SplashScreenManagerMain.CloseWaitForm()
            frmItemReq.Show()

            'Else
            'SplashScreenManagerMain.SetWaitFormDescription("Redirecting to Autono Creation")
            'Thread.Sleep(1000)
            'SplashScreenManagerMain.CloseWaitForm()

            ''frmAutonoSetting.tabAutoNo.SelectedTabPageIndex = 1
            'frmAutonoSetting.Show()
            'End If


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub SimpleButton40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton40.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "PurchaseRequisitions", "View")

        If CheckAccess = True Then


            'SplashScreenManagerMain.ShowWaitForm()

            'SplashScreenManagerMain.SetWaitFormDescription("Validating for AutoNo")

            'Thread.Sleep(5000)

            'If ValidateAutoNoFunction("POReq") Then
            '    SplashScreenManagerMain.SetWaitFormDescription("Loading Po Req")
            '    Thread.Sleep(1000)
            '    SplashScreenManagerMain.CloseWaitForm()
            '    ' frmPurchaseReq.Show()
            frmPurchReq.Show()


            'Else
            'SplashScreenManagerMain.SetWaitFormDescription("Redirecting to Auto no Creation")
            'Thread.Sleep(1000)
            'SplashScreenManagerMain.CloseWaitForm()

            ''frmAutonoSetting.tabAutoNo.SelectedTabPageIndex = 1
            'frmAutonoSetting.Show()
            'End If

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub SimpleButton42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton42.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatNote", "View")

        If CheckAccess = True Then

            'SplashScreenManagerMain.ShowWaitForm()

            'SplashScreenManagerMain.SetWaitFormDescription("Validating for AutoNo")

            'Thread.Sleep(5000)

            'If ValidateAutoNoFunction("BN") Then
            '    SplashScreenManagerMain.SetWaitFormDescription("Loading Boat Note")
            '    Thread.Sleep(1000)
            '    SplashScreenManagerMain.CloseWaitForm()
            frmBoteNote.Show()

            'Else
            'SplashScreenManagerMain.SetWaitFormDescription("Redirecting to Auto no Creation")
            'Thread.Sleep(1000)
            'SplashScreenManagerMain.CloseWaitForm()

            ''frmAutonoSetting.tabAutoNo.SelectedTabPageIndex = 1
            'frmAutonoSetting.Show()
            'End If

        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub SimpleButton43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton43.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GoodReceivedNote", "View")

        If CheckAccess = True Then

            'SplashScreenManagerMain.ShowWaitForm()

            'SplashScreenManagerMain.SetWaitFormDescription("Validating for AutoNo")

            'Thread.Sleep(5000)

            'If ValidateAutoNoFunction("GRN") Then
            '    SplashScreenManagerMain.SetWaitFormDescription("Loading GRN")
            '    Thread.Sleep(1000)
            '    SplashScreenManagerMain.CloseWaitForm()
            frmGRN.Show()

            'Else
            'SplashScreenManagerMain.SetWaitFormDescription("Redirecting to Auto no Creation")
            'Thread.Sleep(1000)
            'SplashScreenManagerMain.CloseWaitForm()

            ''frmAutonoSetting.tabAutoNo.SelectedTabPageIndex = 1
            'frmAutonoSetting.Show()
            'End If

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub nbInvOp_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbInvOp.LinkClicked
        gbOperation_Inventory.Visible = True


        gbOperation_BackOffice.Visible = False


        gbOperation_FrontOffice.Visible = False
        gbMaster_Inventory.Visible = False
        gbMaster_BackOffice.Visible = False
        gbMaster_FrontOffice.Visible = False
        gbOperation_housekeeping.Visible = False
        gbRoomStatus.Visible = False





    End Sub

    Private Sub nbHKOp_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbHKOp.LinkClicked
        gbOperation_housekeeping.Visible = True


        gbOperation_Inventory.Visible = False


        gbOperation_BackOffice.Visible = False


        gbOperation_FrontOffice.Visible = False
        gbMaster_Inventory.Visible = False
        gbMaster_BackOffice.Visible = False
        gbMaster_FrontOffice.Visible = False
        gbRoomStatus.Visible = False



    End Sub

    Private Sub SimpleButton24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton24.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Amentities", "View")

        If CheckAccess = True Then

            frmAmentities.Show()



        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton33_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton33.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Boat Rates", "View")

        If CheckAccess = True Then



            frmTransferRate.Show()



        Else

            MsgBox("You Do Not Have Access")


        End If
    End Sub

    Private Sub SimpleButton41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton41.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GeneratePurchaseOrders", "View")

        If CheckAccess = True Then


            'SplashScreenManagerMain.ShowWaitForm()

            'SplashScreenManagerMain.SetWaitFormDescription("Validating for AutoNo")

            'Thread.Sleep(5000)

            'If ValidateAutoNoFunction("POMain") Then
            '    SplashScreenManagerMain.SetWaitFormDescription("Loading PO")
            '    Thread.Sleep(1000)
            '    SplashScreenManagerMain.CloseWaitForm()
            frmPurchaseOrder.Show()

            'Else
            'SplashScreenManagerMain.SetWaitFormDescription("Redirecting to Auto no Creation")
            'Thread.Sleep(1000)
            'SplashScreenManagerMain.CloseWaitForm()

            ''frmAutonoSetting.tabAutoNo.SelectedTabPageIndex = 1
            'frmAutonoSetting.Show()
            'End If

        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub SimpleButton46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton46.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GoodIssuedNote", "View")

        If CheckAccess = True Then


            'SplashScreenManagerMain.ShowWaitForm()

            'SplashScreenManagerMain.SetWaitFormDescription("Validating for AutoNo")

            'Thread.Sleep(5000)

            'If ValidateAutoNoFunction("GIN") Then
            '    SplashScreenManagerMain.SetWaitFormDescription("Loading GIN")
            '    Thread.Sleep(1000)
            '    SplashScreenManagerMain.CloseWaitForm()
            frmGIN.Show()

            'Else
            'SplashScreenManagerMain.SetWaitFormDescription("Redirecting to Auto no Creation")
            'Thread.Sleep(1000)
            'SplashScreenManagerMain.CloseWaitForm()

            ''frmAutonoSetting.tabAutoNo.SelectedTabPageIndex = 1
            'frmAutonoSetting.Show()
            'End If
        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub SimpleButton26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton26.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ForecastDetails", "View")

        If CheckAccess = True Then

            frmForecastDetails.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton27.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ArrivalDepartureExpected", "View")

        If CheckAccess = True Then


            'frmArrivalDepartureExpexted.Show()
            NewfrmExpectedArrivalDeparture.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub SimpleButton38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton38.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Room Master", "View")

        If CheckAccess = True Then


            frmRoomMaster.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton44_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton44.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Room Allocation Edit", "View")

        If CheckAccess = True Then


            frmRoomChange.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If
    End Sub

    Private Sub PerformaInvoiceTOPWiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerformaInvoiceTOPWiseToolStripMenuItem.Click
        frmOccupancy_Report_Of_Room_By_Type.Show()
    End Sub

    Private Sub PerformaInvoiceRaisedToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerformaInvoiceRaisedToolStripMenuItem1.Click
        frmPerforma_Invoice_Raised_Report.Show()
    End Sub

    Private Sub BedTaxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BedTaxToolStripMenuItem.Click
        frmBed_Tax_Report.Show()
    End Sub

    Private Sub DailyFrontOfficeInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmDaily_Front_Office_Information.Show()
    End Sub

    Private Sub DepartureInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartureInformationToolStripMenuItem.Click
        frmDeparture_Information.Show()
    End Sub

    Private Sub ExpectedArrivalListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmExpected_Arrival_List.Show()
    End Sub

    Private Sub GuestInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestInformationToolStripMenuItem.Click
        frmGuest_Information_Report.Show()
    End Sub

    Private Sub HistoryStatisticToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryStatisticToolStripMenuItem.Click
        frmHistory_Statistic_Report.Show()
    End Sub

    Private Sub HouseCountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HouseCountToolStripMenuItem.Click
        frmHouse_Count_Report.Show()
    End Sub

    Private Sub PaxByMealPlanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaxByMealPlanToolStripMenuItem.Click
        frmOccupancy_Report_Of_Pax_By_Meal_Plan.Show()
    End Sub

    Private Sub RoomByTOPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomByTOPToolStripMenuItem.Click
        frmOccupancy_Report_Of_Room_By_Operator.Show()
    End Sub

    Private Sub PerformaInvoiceRaisedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerformaInvoiceRaisedToolStripMenuItem.Click
        frmOccupancy_Report_Of_Rooms_By_Bedding.Show()
    End Sub

    Private Sub PerformaInvoiceTOPWiseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerformaInvoiceTOPWiseToolStripMenuItem1.Click
        frmOperator_Wise_Performa_Invoice_Breakup_Report.Show()
    End Sub

    Private Sub ReservationCreationGuestWiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationCreationGuestWiseToolStripMenuItem.Click
        frmReservation_Creation__Report_Guest_Wise.Show()

    End Sub

    Private Sub ReservationCreationDeletionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationCreationDeletionToolStripMenuItem.Click
        frmReservation_Creation_Deletion_Report.Show()
    End Sub

    Private Sub ReservationCreationTOPWiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationCreationTOPWiseToolStripMenuItem.Click
        frmReservation_Creation_Report_Tour_Operator_Wise.Show()
    End Sub

    Private Sub TaxInvoiceCreationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaxInvoiceCreationToolStripMenuItem.Click

        frmTax_Invoice_Creation__Report.Show()

    End Sub

    Private Sub InventoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmItem_Request_Raised_Report.Show()
    End Sub

    Private Sub DetailToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmBoat_Note_Raised_Detail_Report.Show()
    End Sub

    Private Sub MasterToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmBoat_Note_Raised_Report.Show()
    End Sub

    Private Sub DetailToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGIN_Raised_Detail_Report.Show()
    End Sub

    Private Sub MasterToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGIN_Raised_Report.Show()
    End Sub

    Private Sub DetailToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGRN_Raised_Detail_Report.Show()
    End Sub

    Private Sub MasterToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGRN_Raised_Report.Show()
    End Sub

    Private Sub DetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmItem_Request_Raised_Detail_Report.Show()
    End Sub

    Private Sub MasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmItem_Request_Raised_Report.Show()
    End Sub

    Private Sub DetailToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPO_Raised_Detail_Report.Show()
    End Sub

    Private Sub MasterToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPO_Raised_Report.Show()
    End Sub

    Private Sub DetailToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPO_Request_Raised_Detail_Report.Show()
    End Sub

    Private Sub MasterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPO_Request_Raised_Report.Show()
    End Sub

    Private Sub SimpleButton52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton52.Click
        frmSpaservices.Show()
    End Sub

    Private Sub SimpleButton50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton50.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Payments", "View")

        If CheckAccess = True Then

            KOTBOTBilling.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton25.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "RoomStatus", "View")

        If CheckAccess = True Then

            frmRoomMaster.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub SimpleButton53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton53.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Room number Change", "View")

        If CheckAccess = True Then

            frmRoomnochange.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        frmUserAssignGroup.Show()
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserToolStripMenuItem.Click
        frmUsers.Show()
    End Sub

    Private Sub AddUserGroupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserGroupToolStripMenuItem.Click
        frmUserGroups.Show()
    End Sub

    Private Sub AddGroupToProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmUserGroupAssignProcess.Show()
    End Sub

    Private Sub SimpleButton35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton35.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Master billing-Temp", "View")

        If CheckAccess = True Then


            'KOTBOTBilling.Show()
            frmMasterBill.Show()



        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton54.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Room Block", "View")

        If CheckAccess = True Then



            frmRoomblock.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub SimpleButton60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton60.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Housekeeping", "View")

        If CheckAccess = True Then



            frmRoomMaster.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub AdminPanelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminPanelToolStripMenuItem.Click

        Dim CurrentUser As String = CurrUser
        If CurrentUser = "Admin" Then
            AdminPanelToolStripMenuItem.Enabled = True
        Else
            AdminPanelToolStripMenuItem.Enabled = False
        End If

    End Sub

    Private Sub SimpleButton7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Item Adjustment", "View")

        If CheckAccess = True Then



            frmItemAdjustment.Show()



        Else

            MsgBox("You Do Not Have Access")


        End If
    End Sub

    Private Sub SimpleButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton15.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Cocktails", "View")

        If CheckAccess = True Then


            frmCoktailItemCreation.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton51.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GINSforMiniBar", "View")

        If CheckAccess = True Then



            frmMinibarTransfer.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub GuestListForInHouseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestListForInHouseToolStripMenuItem.Click
        frmGuest_List_For_In_House.Show()
    End Sub

    Private Sub SimpleButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton22.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Master billing", "View")

        If CheckAccess = True Then



            KOTBOTBilling.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub SimpleButton29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton29.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "All Inclusive Rates", "View")

        If CheckAccess = True Then


            frmAllinclusive.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub BinCardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmInventory_Report.ReportTitle = "Bincard Report"
        frmInventory_Report.Show()
    End Sub

    Private Sub StockInHandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmInventory_Report.ReportTitle = "Stock In Hand Report"
        frmInventory_Report.Show()
    End Sub

    Private Sub GINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGINReport.Show()
    End Sub

    Private Sub SimpleButton45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton45.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Kitchen Item Consumption", "View")

        If CheckAccess = True Then


            frmKitchenStockMainvb.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton55.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Discount Billing", "View")

        If CheckAccess = True Then



            frmDisscountBilling.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub SimpleButton56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton56.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GuestReminder", "View")

        If CheckAccess = True Then


            frmGuestreminder.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If
    End Sub

    Private Sub nbiRoomStat_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiRoomStat.LinkClicked

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "RoomStatusGraphicalFormat", "View")

        If CheckAccess = True Then




            frmRoomGraphical.Show()


            'LoadGrid()


            'gbRoomStatus.Visible = True
            'gbOperation_Inventory.Visible = False
            'gbOperation_BackOffice.Visible = False
            'gbOperation_FrontOffice.Visible = False
            'gbMaster_Inventory.Visible = False
            'gbMaster_BackOffice.Visible = False
            'gbMaster_FrontOffice.Visible = False


        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub
    Private Sub LoadGrid()
        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
            dcSearch = New SqlCommand("SELECT   TOP (100) PERCENT dbo.[Rooms.Master].Roomno, dbo.[Rooms.Master].Category, dbo.[Rooms.Master].Status, dbo.[Room.CurrentStatus].BillingGuest,dbo.[Room.CurrentStatus].ReservationNo FROM dbo.[Room.CurrentStatus] RIGHT OUTER JOIN dbo.[Rooms.Master] ON dbo.[Room.CurrentStatus].RoomNo = dbo.[Rooms.Master].Roomno ORDER BY dbo.[Rooms.Master].Roomno", Conn)

            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)



         





            Dim DScount As Integer = dsMain.Tables(0).Rows.Count - 1


            While DScount >= 0

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "111" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R111.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R111.BackgroundImage = My.Resources.occupied
                        POR111 = 1
                        PGR111 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R111.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R111.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "112" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R112.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R112.BackgroundImage = My.Resources.occupied
                        POR112 = 1
                        PGR112 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R112.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R112.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "113" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R113.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R113.BackgroundImage = My.Resources.occupied
                        POR113 = 1
                        PGR113 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R113.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R113.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "114" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R114.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R114.BackgroundImage = My.Resources.occupied
                        POR114 = 1
                        PGR114 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R114.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R114.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "115" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R115.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R115.BackgroundImage = My.Resources.occupied
                        POR115 = 1
                        PGR115 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R115.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R115.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "116" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R116.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R116.BackgroundImage = My.Resources.occupied
                        POR116 = 1
                        PGR116 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R116.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R116.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "117" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R117.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R117.BackgroundImage = My.Resources.occupied
                        POR117 = 1
                        PGR117 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R117.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R117.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "118" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R118.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R118.BackgroundImage = My.Resources.occupied
                        POR118 = 1
                        PGR118 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R118.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R118.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "119" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R119.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R119.BackgroundImage = My.Resources.occupied
                        POR119 = 1
                        PGR119 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R119.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R119.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "120" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R120.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R120.BackgroundImage = My.Resources.occupied
                        POR120 = 1
                        PGR120 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R120.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R120.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "121" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R121.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R121.BackgroundImage = My.Resources.occupied
                        POR121 = 1
                        PGR121 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R121.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R121.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "122" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R122.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R122.BackgroundImage = My.Resources.occupied
                        POR122 = 1
                        PGR122 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R122.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R122.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "123" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R123.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R123.BackgroundImage = My.Resources.occupied
                        POR123 = 1
                        PGR123 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R123.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R123.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "124" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R124.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R124.BackgroundImage = My.Resources.occupied
                        POR124 = 1
                        PGR124 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R124.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R124.BackgroundImage = My.Resources.out_of_service
                    End If

                End If



                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "125" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R125.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R125.BackgroundImage = My.Resources.occupied
                        POR125 = 1
                        PGR125 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R125.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R125.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "126" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R126.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R126.BackgroundImage = My.Resources.occupied
                        POR126 = 1
                        PGR126 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R126.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R126.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "127" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R127.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R127.BackgroundImage = My.Resources.occupied
                        POR127 = 1
                        PGR127 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R127.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R127.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "128" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R128.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R128.BackgroundImage = My.Resources.occupied
                        POR128 = 1
                        PGR128 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R128.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R128.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "129" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R129.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R129.BackgroundImage = My.Resources.occupied
                        POR129 = 1
                        PGR129 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R129.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R129.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "130" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R130.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R130.BackgroundImage = My.Resources.occupied
                        POR130 = 1
                        PGR130 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R130.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R130.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "131" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R131.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R131.BackgroundImage = My.Resources.occupied
                        POR131 = 1
                        PGR131 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R131.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R131.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "132" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R132.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R132.BackgroundImage = My.Resources.occupied
                        POR132 = 1
                        PGR132 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R132.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R132.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "133" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R133.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R133.BackgroundImage = My.Resources.occupied
                        POR133 = 1
                        PGR133 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R133.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R133.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "134" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R134.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R134.BackgroundImage = My.Resources.occupied
                        POR134 = 1
                        PGR134 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R134.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R134.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "135" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R135.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R135.BackgroundImage = My.Resources.occupied
                        POR135 = 1
                        PGR135 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R135.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R135.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "136" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R136.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R136.BackgroundImage = My.Resources.occupied
                        POR136 = 1
                        PGR136 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R136.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R136.BackgroundImage = My.Resources.out_of_service
                    End If

                End If



                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "137" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R137.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R137.BackgroundImage = My.Resources.occupied
                        POR137 = 1
                        PGR137 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R137.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R137.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "138" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R138.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R138.BackgroundImage = My.Resources.occupied
                        POR138 = 1
                        PGR138 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R138.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R138.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "139" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R139.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R139.BackgroundImage = My.Resources.occupied
                        POR139 = 1
                        PGR139 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R139.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R139.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "140" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R140.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R140.BackgroundImage = My.Resources.occupied
                        POR140 = 1
                        PGR140 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R140.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R140.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "141" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R141.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R141.BackgroundImage = My.Resources.occupied
                        POR141 = 1
                        PGR141 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R141.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R141.BackgroundImage = My.Resources.out_of_service
                    End If

                End If



                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "142" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R142.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R142.BackgroundImage = My.Resources.occupied
                        POR142 = 1
                        PGR142 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R142.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R142.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "143" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R143.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R143.BackgroundImage = My.Resources.occupied
                        POR143 = 1
                        PGR143 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R143.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R143.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "144" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R144.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R144.BackgroundImage = My.Resources.occupied
                        POR144 = 1
                        PGR144 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R144.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R144.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "145" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R145.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R145.BackgroundImage = My.Resources.occupied
                        POR145 = 1
                        PGR145 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R145.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R145.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "146" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R146.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R146.BackgroundImage = My.Resources.occupied
                        POR146 = 1
                        PGR146 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R146.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R146.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "147" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R147.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R147.BackgroundImage = My.Resources.occupied
                        POR147 = 1
                        PGR147 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R147.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R147.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "148" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R148.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R148.BackgroundImage = My.Resources.occupied
                        POR148 = 1
                        PGR148 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R148.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R148.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "149" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R149.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R149.BackgroundImage = My.Resources.occupied
                        POR149 = 1
                        PGR149 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R149.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R149.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "150" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R150.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R150.BackgroundImage = My.Resources.occupied
                        POR150 = 1
                        PGR150 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R150.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R150.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "151" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R151.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R151.BackgroundImage = My.Resources.occupied
                        POR151 = 1
                        PGR151 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R151.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R151.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "152" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R152.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R152.BackgroundImage = My.Resources.occupied
                        POR152 = 1
                        PGR152 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R152.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R152.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "153" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R153.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R153.BackgroundImage = My.Resources.occupied
                        POR153 = 1
                        PGR153 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R153.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R153.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "154" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R154.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R154.BackgroundImage = My.Resources.occupied
                        POR154 = 1
                        PGR154 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R154.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R154.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "155" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R155.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R155.BackgroundImage = My.Resources.occupied
                        POR155 = 1
                        PGR155 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R155.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R155.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "156" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R156.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R156.BackgroundImage = My.Resources.occupied
                        POR156 = 1
                        PGR156 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R156.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R156.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "157" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R157.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R157.BackgroundImage = My.Resources.occupied
                        POR157 = 1
                        PGR157 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R157.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R157.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "158" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R158.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R158.BackgroundImage = My.Resources.occupied
                        POR158 = 1
                        PGR158 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R158.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R158.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "159" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R159.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R159.BackgroundImage = My.Resources.occupied
                        POR159 = 1
                        PGR159 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R159.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R159.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "160" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R160.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R160.BackgroundImage = My.Resources.occupied
                        POR160 = 1
                        PGR160 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R160.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R160.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "161" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R161.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R161.BackgroundImage = My.Resources.occupied
                        POR161 = 1
                        PGR161 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R161.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R161.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "162" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R162.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R162.BackgroundImage = My.Resources.occupied
                        POR162 = 1
                        PGR162 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R162.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R162.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "163" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R163.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R163.BackgroundImage = My.Resources.occupied
                        POR163 = 1
                        PGR163 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R163.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R163.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "164" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R164.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R164.BackgroundImage = My.Resources.occupied
                        POR164 = 1
                        PGR164 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R164.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R164.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "165" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R165.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R165.BackgroundImage = My.Resources.occupied
                        POR165 = 1
                        PGR165 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R165.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R165.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "166" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R166.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R166.BackgroundImage = My.Resources.occupied
                        POR166 = 1
                        PGR166 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R166.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R166.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                'If dsMain.Tables(0).Rows(DScount)(0).ToString() = "166" Then

                '    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                '        R166.BackgroundImage = My.Resources.vacant
                '    End If

                '    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                '        R166.BackgroundImage = My.Resources.occupied
                '        POR160 = 1
                '        PGR160 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                '    End If


                '    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                '        R166.BackgroundImage = My.Resources.dirty
                '    End If

                '    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                '        R166.BackgroundImage = My.Resources.out_of_service
                '    End If

                'End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "201" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R201.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R201.BackgroundImage = My.Resources.occupied
                        POR201 = 1
                        PGR201 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R201.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R201.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "202" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R202.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R202.BackgroundImage = My.Resources.occupied
                        POR202 = 1
                        PGR202 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R202.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R202.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "203" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R203.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R203.BackgroundImage = My.Resources.occupied
                        POR203 = 1
                        PGR203 = dsMain.Tables(0).Rows(DScount)(3).ToString()

                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R203.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R203.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "204" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R204.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R204.BackgroundImage = My.Resources.occupied
                        POR204 = 1
                        PGR204 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R204.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R204.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "205" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R205.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R205.BackgroundImage = My.Resources.occupied
                        POR205 = 1
                        PGR205 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R205.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R205.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "206" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R206.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R206.BackgroundImage = My.Resources.occupied
                        POR206 = 1
                        PGR206 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R206.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R206.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "207" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R207.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R207.BackgroundImage = My.Resources.occupied
                        POR207 = 1
                        PGR207 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R207.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R207.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "208" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R208.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R208.BackgroundImage = My.Resources.occupied
                        POR208 = 1
                        PGR208 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R208.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R208.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "209" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R209.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R209.BackgroundImage = My.Resources.occupied
                        POR209 = 1
                        PGR209 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R209.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R209.BackgroundImage = My.Resources.out_of_service
                    End If

                End If

                If dsMain.Tables(0).Rows(DScount)(0).ToString() = "210" Then

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "vacant" Then
                        R210.BackgroundImage = My.Resources.vacantNew
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "occupied" Then
                        R210.BackgroundImage = My.Resources.occupied
                        POR210 = 1
                        PGR210 = dsMain.Tables(0).Rows(DScount)(3).ToString()
                    End If


                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "dirty" Then
                        R210.BackgroundImage = My.Resources.dirty
                    End If

                    If dsMain.Tables(0).Rows(DScount)(2).ToString() = "out of service" Then
                        R210.BackgroundImage = My.Resources.out_of_service
                    End If

                End If


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

    Private Sub R111_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R111.MouseHover
        If POR111 = 1 Then


            ToolTip1.SetToolTip(R111, PGR111)

            'MsgBox("Guest: " + PGR111)
        End If
    End Sub
    Private Sub R112_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R112.MouseHover
        If POR112 = 1 Then

            ToolTip1.SetToolTip(R112, PGR112)
            ' MsgBox("Guest: " + PGR112)
        End If
    End Sub
    Private Sub R113_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R113.MouseHover
        If POR113 = 1 Then

            ToolTip1.SetToolTip(R113, PGR113)
            'MsgBox("Guest: " + PGR113)

        End If
    End Sub
    Private Sub R114_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R114.MouseHover
        If POR114 = 1 Then

            ToolTip1.SetToolTip(R114, PGR114)

            ' MsgBox("Guest: " + PGR114)
        End If
    End Sub
    Private Sub R115_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R115.MouseHover
        If POR115 = 1 Then

            ToolTip1.SetToolTip(R115, PGR115)
            'MsgBox("Guest: " + PGR115)
        End If
    End Sub
    Private Sub R116_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R116.MouseHover
        If POR116 = 1 Then

            ToolTip1.SetToolTip(R116, PGR116)

            ' MsgBox("Guest: " + PGR116)
        End If
    End Sub
    Private Sub R117_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R117.MouseHover
        If POR117 = 1 Then

            ToolTip1.SetToolTip(R117, PGR117)

            'MsgBox("Guest: " + PGR117)
        End If
    End Sub
    Private Sub R118_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R118.MouseHover
        If POR118 = 1 Then

            ToolTip1.SetToolTip(R118, PGR118)

            'MsgBox("Guest: " + PGR118)
        End If
    End Sub
    Private Sub R119_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R119.MouseHover
        If POR119 = 1 Then

            ToolTip1.SetToolTip(R119, PGR119)

            'MsgBox("Guest: " + PGR119)
        End If
    End Sub
    Private Sub R120_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R120.MouseHover
        If POR120 = 1 Then

            ToolTip1.SetToolTip(R120, PGR120)

            'MsgBox("Guest: " + PGR120)
        End If
    End Sub
    Private Sub R121_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R121.MouseHover
        If POR121 = 1 Then

            ToolTip1.SetToolTip(R121, PGR121)

            ' MsgBox("Guest: " + PGR121)
        End If
    End Sub
    Private Sub R122_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R122.MouseHover
        If POR122 = 1 Then

            ToolTip1.SetToolTip(R122, PGR122)

            'MsgBox("Guest: " + PGR122)
        End If
    End Sub
    Private Sub R123_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R123.MouseHover
        If POR123 = 1 Then
            ToolTip1.SetToolTip(R123, PGR123)

            ' MsgBox("Guest: " + PGR123)
        End If
    End Sub
    Private Sub R124_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R124.MouseHover
        If POR124 = 1 Then

            ToolTip1.SetToolTip(R124, PGR124)

            ' MsgBox("Guest: " + PGR124)
        End If
    End Sub
    Private Sub R125_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R125.MouseHover
        If POR125 = 1 Then

            ToolTip1.SetToolTip(R125, PGR125)

            'MsgBox("Guest: " + PGR125)
        End If
    End Sub
    Private Sub R126_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R126.MouseHover
        If POR126 = 1 Then

            ToolTip1.SetToolTip(R126, PGR126)
            'MsgBox("Guest: " + PGR126)
        End If
    End Sub
    Private Sub R127_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R127.MouseHover
        If POR127 = 1 Then

            ToolTip1.SetToolTip(R127, PGR127)

            ' MsgBox("Guest: " + PGR127)
        End If
    End Sub
    Private Sub R128_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R128.MouseHover
        If POR128 = 1 Then

            ToolTip1.SetToolTip(R128, PGR128)

            'MsgBox("Guest: " + PGR128)
        End If
    End Sub
    Private Sub R129_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R129.MouseHover
        If POR129 = 1 Then

            ToolTip1.SetToolTip(R129, PGR129)

            'MsgBox("Guest: " + PGR129)
        End If
    End Sub
    Private Sub R130_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R130.MouseHover
        If POR130 = 1 Then

            ToolTip1.SetToolTip(R130, PGR130)

            ' MsgBox("Guest: " + PGR130)
        End If
    End Sub
    Private Sub R131_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R131.MouseHover
        If POR131 = 1 Then
            ToolTip1.SetToolTip(R131, PGR131)

            ' MsgBox("Guest: " + PGR131)
        End If
    End Sub
    Private Sub R132_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R132.MouseHover
        If POR132 = 1 Then

            ToolTip1.SetToolTip(R132, PGR132)

            ' MsgBox("Guest: " + PGR132)
        End If
    End Sub
    Private Sub R133_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R133.MouseHover
        If POR133 = 1 Then

            ToolTip1.SetToolTip(R133, PGR133)
            ' MsgBox("Guest: " + PGR133)
        End If
    End Sub
    Private Sub R134_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R134.MouseHover
        If POR134 = 1 Then
            ToolTip1.SetToolTip(R134, PGR134)
            ' MsgBox("Guest: " + PGR134)
        End If
    End Sub
    Private Sub R135_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R135.MouseHover
        If POR135 = 1 Then

            ToolTip1.SetToolTip(R135, PGR135)

            ' MsgBox("Guest: " + PGR135)
        End If
    End Sub
    Private Sub R136_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R136.MouseHover
        If POR136 = 1 Then
            ToolTip1.SetToolTip(R136, PGR136)

            'MsgBox("Guest: " + PGR136)
        End If
    End Sub
    Private Sub R137_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R137.MouseHover
        If POR137 = 1 Then

            ToolTip1.SetToolTip(R137, PGR137)
            'MsgBox("Guest: " + PGR137)
        End If
    End Sub
    Private Sub R138_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R138.MouseHover
        If POR138 = 1 Then

            ToolTip1.SetToolTip(R138, PGR138)

            'MsgBox("Guest: " + PGR138)
        End If
    End Sub
    Private Sub R139_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R139.MouseHover
        If POR139 = 1 Then

            ToolTip1.SetToolTip(R139, PGR139)

            ' MsgBox("Guest: " + PGR139)
        End If
    End Sub
    Private Sub R140_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R140.MouseHover
        If POR140 = 1 Then

            ToolTip1.SetToolTip(R140, PGR140)

            'MsgBox("Guest: " + PGR140)
        End If
    End Sub
    Private Sub R141_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R141.MouseHover
        If POR141 = 1 Then

            ToolTip1.SetToolTip(R141, PGR141)

            ' MsgBox("Guest: " + PGR141)
        End If
    End Sub
    Private Sub R142_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R142.MouseHover
        If POR142 = 1 Then
            ToolTip1.SetToolTip(R142, PGR142)
            'MsgBox("Guest: " + PGR142)
        End If
    End Sub
    Private Sub R143_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R143.MouseHover
        If POR143 = 1 Then

            ToolTip1.SetToolTip(R143, PGR143)

            'MsgBox("Guest: " + PGR143)
        End If
    End Sub
    Private Sub R144_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R144.MouseHover
        If POR144 = 1 Then
            ToolTip1.SetToolTip(R144, PGR144)
            '  MsgBox("Guest: " + PGR144)
        End If
    End Sub
    Private Sub R145_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R145.MouseHover
        If POR145 = 1 Then

            ToolTip1.SetToolTip(R145, PGR145)
            ' MsgBox("Guest: " + PGR145)
        End If
    End Sub
    Private Sub R146_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R146.MouseHover
        If POR146 = 1 Then

            ToolTip1.SetToolTip(R146, PGR146)

            ' MsgBox("Guest: " + PGR146)
        End If
    End Sub
    Private Sub R147_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R147.MouseHover
        If POR147 = 1 Then

            ToolTip1.SetToolTip(R147, PGR147)

            ' MsgBox("Guest: " + PGR147)
        End If
    End Sub
    Private Sub R148_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R148.MouseHover
        If POR148 = 1 Then

            ToolTip1.SetToolTip(R148, PGR148)

            ' MsgBox("Guest: " + PGR148)
        End If
    End Sub
    Private Sub R149_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R149.MouseHover
        If POR149 = 1 Then

            ToolTip1.SetToolTip(R149, PGR149)
            ' MsgBox("Guest: " + PGR149)
        End If
    End Sub
    Private Sub R150_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R150.MouseHover
        If POR150 = 1 Then

            ToolTip1.SetToolTip(R150, PGR150)

            '  MsgBox("Guest: " + PGR150)
        End If
    End Sub
    Private Sub R151_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R151.MouseHover
        If POR151 = 1 Then

            ToolTip1.SetToolTip(R151, PGR151)
            ' MsgBox("Guest: " + PGR151)
        End If
    End Sub

    Private Sub R152_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R152.MouseHover
        If POR152 = 1 Then
            ToolTip1.SetToolTip(R152, PGR152)
            ' MsgBox("Guest: " + PGR152)
        End If
    End Sub
    Private Sub R153_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R153.MouseHover
        If POR153 = 1 Then
            ToolTip1.SetToolTip(R153, PGR153)

            ' MsgBox("Guest: " + PGR153)
        End If
    End Sub
    Private Sub R154_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R154.MouseHover
        If POR154 = 1 Then

            ToolTip1.SetToolTip(R154, PGR154)
            'MsgBox("Guest: " + PGR154)
        End If
    End Sub
    Private Sub R155_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R155.MouseHover
        If POR155 = 1 Then

            ToolTip1.SetToolTip(R155, PGR155)

            'MsgBox("Guest: " + PGR155)
        End If
    End Sub
    Private Sub R156_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R156.MouseHover
        If POR156 = 1 Then

            ToolTip1.SetToolTip(R156, PGR156)

            ' MsgBox("Guest: " + PGR156)
        End If
    End Sub
    Private Sub R157_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R157.MouseHover
        If POR157 = 1 Then

            ToolTip1.SetToolTip(R157, PGR157)

            ' MsgBox("Guest: " + PGR157)
        End If
    End Sub
    Private Sub R158_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R158.MouseHover
        If POR158 = 1 Then

            ToolTip1.SetToolTip(R158, PGR158)
            'MsgBox("Guest: " + PGR158)
        End If
    End Sub
    Private Sub R159_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R159.MouseHover
        If POR159 = 1 Then

            ToolTip1.SetToolTip(R159, PGR159)
            ' MsgBox("Guest: " + PGR159)
        End If
    End Sub
   
    Private Sub R160_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R160.MouseHover
        If POR160 = 1 Then

            ToolTip1.SetToolTip(R160, PGR160)
            'MsgBox("Guest: " + PGR160)
        End If
    End Sub
    Private Sub R161_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R161.MouseHover
        If POR161 = 1 Then

            ToolTip1.SetToolTip(R161, PGR161)
            'MsgBox("Guest: " + PGR161)
        End If
    End Sub
    Private Sub R162_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R162.MouseHover
        If POR162 = 1 Then

            ToolTip1.SetToolTip(R162, PGR162)
            ' MsgBox("Guest: " + PGR162)
        End If
    End Sub
    Private Sub R163_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R163.MouseHover
        If POR163 = 1 Then

            ToolTip1.SetToolTip(R163, PGR163)
            'MsgBox("Guest: " + PGR163)
        End If
    End Sub
    Private Sub R164_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R164.MouseHover
        If POR164 = 1 Then

            ToolTip1.SetToolTip(R164, PGR164)
            ' MsgBox("Guest: " + PGR164)
        End If
    End Sub
    Private Sub R165_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R165.MouseHover
        If POR165 = 1 Then
            ToolTip1.SetToolTip(R165, PGR165)
            ' MsgBox("Guest: " + PGR165)
        End If
    End Sub
    Private Sub R166_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R166.MouseHover
        If POR166 = 1 Then

            ToolTip1.SetToolTip(R166, PGR166)

            ' MsgBox("Guest: " + PGR166)
        End If
    End Sub
    Private Sub R201_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R201.MouseHover
        If POR201 = 1 Then

            ToolTip1.SetToolTip(R201, PGR201)

            'MsgBox("Guest: " + PGR201)
        End If
    End Sub
    Private Sub R202_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R202.MouseHover
        If POR202 = 1 Then

            ToolTip1.SetToolTip(R202, PGR202)
            'MsgBox("Guest: " + PGR202)
        End If
    End Sub
    Private Sub R203_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R203.MouseHover
        If POR203 = 1 Then

            ToolTip1.SetToolTip(R203, PGR203)

            ' MsgBox("Guest: " + PGR203)
        End If
    End Sub
    Private Sub R204_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R204.MouseHover
        If POR204 = 1 Then

            ToolTip1.SetToolTip(R204, PGR204)
            ' MsgBox("Guest: " + PGR204)
        End If
    End Sub
    Private Sub R205_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R205.MouseHover
        If POR205 = 1 Then

            ToolTip1.SetToolTip(R205, PGR205)
            ' MsgBox("Guest: " + PGR205)
        End If
    End Sub
    Private Sub R206_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R206.MouseHover
        If POR206 = 1 Then

            ToolTip1.SetToolTip(R206, PGR206)
            ' MsgBox("Guest: " + PGR206)
        End If
    End Sub
    Private Sub R207_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R207.MouseHover
        If POR207 = 1 Then

            ToolTip1.SetToolTip(R207, PGR207)
            ' MsgBox("Guest: " + PGR207)
        End If
    End Sub
    Private Sub R208_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R208.MouseHover
        If POR208 = 1 Then

            ToolTip1.SetToolTip(R208, PGR208)

            'MsgBox("Guest: " + PGR208)
        End If
    End Sub
    Private Sub R209_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R209.MouseHover
        If POR209 = 1 Then

            ToolTip1.SetToolTip(R209, PGR209)

            ' MsgBox("Guest: " + PGR209)
        End If
    End Sub
    Private Sub R210_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R210.MouseHover
        If POR210 = 1 Then

            ToolTip1.SetToolTip(R210, PGR210)

            'MsgBox("Guest: " + PGR210)
        End If
    End Sub

    Private Sub nbiMsn_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiMsn.LinkClicked

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Messenger", "View")

        If CheckAccess = True Then



            frmMessengers.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub
    Function DSCheckNewMsg() As DataSet

        Dim Conn As New SqlConnection(ConnString)
        Dim daMain As New SqlDataAdapter
        Dim dsMain As New DataSet
        Dim dcSearch As New SqlCommand
        Try
            Conn.Open()
           
            Dim CurrentUser As String = CurrUser
            dcSearch = New SqlCommand("select * from Messenger where IsRead=0 and MsgTo=@MsgTo and MsgADate >= getdate() order by MessId", Conn)
            dcSearch.Parameters.Add("@MsgTo", SqlDbType.VarChar).Value = CurrentUser


            daMain = New SqlDataAdapter()
            daMain.SelectCommand = dcSearch
            daMain.Fill(dsMain)

            Dim count As Integer = dsMain.Tables(0).Rows.Count
            If count > 0 Then
                DSCheckNewMsg = dsMain
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
    Private Sub CheckNewMsg()

        Dim dscheckAddbefore As New DataSet
        dscheckAddbefore = DSCheckNewMsg()

        If dscheckAddbefore Is Nothing Then
            Exit Sub

        Else

            frmMessengers.Show()

        End If
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown


        If e.KeyCode = Keys.F1 Then

            If nbiFrontOffice.Enabled = True Then


                gbMaster_FrontOffice.Visible = True

                gbMaster_BackOffice.Visible = False
                gbMaster_Inventory.Visible = False
                gbOperation_FrontOffice.Visible = False
                gbOperation_BackOffice.Visible = False
                gbOperation_Inventory.Visible = False
                gbOperation_housekeeping.Visible = False
                gbRoomStatus.Visible = False


            Else

                MsgBox("You Do Not Have Access")

            End If


        End If


            If e.KeyCode = Keys.F2 Then

                If nbiBackOffice.Enabled = True Then



                    gbMaster_BackOffice.Visible = True

                    gbMaster_FrontOffice.Visible = False
                    gbMaster_Inventory.Visible = False
                    gbOperation_FrontOffice.Visible = False
                    gbOperation_BackOffice.Visible = False
                    gbOperation_Inventory.Visible = False
                    gbOperation_housekeeping.Visible = False
                    gbRoomStatus.Visible = False

            Else

                MsgBox("You Do Not Have Access")

                End If


            End If



        If e.KeyCode = Keys.F3 Then

            If nbiInventory.Enabled = True Then



                gbMaster_Inventory.Visible = True

                gbMaster_BackOffice.Visible = False
                gbMaster_FrontOffice.Visible = False
                gbOperation_FrontOffice.Visible = False
                gbOperation_BackOffice.Visible = False
                gbOperation_Inventory.Visible = False
                gbOperation_housekeeping.Visible = False
                gbRoomStatus.Visible = False

            Else

                MsgBox("You Do Not Have Access")


            End If

        End If



        If e.KeyCode = Keys.F4 Then



            If nbFrontOfficeOp.Enabled = True Then



                gbOperation_FrontOffice.Visible = True
                gbMaster_Inventory.Visible = False

                gbMaster_BackOffice.Visible = False
                gbMaster_FrontOffice.Visible = False
                gbOperation_BackOffice.Visible = False
                gbOperation_Inventory.Visible = False
                gbOperation_housekeeping.Visible = False
                gbRoomStatus.Visible = False

            Else

                MsgBox("You Do Not Have Access")


            End If




        End If


        If e.KeyCode = Keys.F5 Then


            If nbBackOfficeOp.Enabled = True Then



                gbOperation_BackOffice.Visible = True


                gbOperation_FrontOffice.Visible = False
                gbMaster_Inventory.Visible = False
                gbMaster_BackOffice.Visible = False
                gbMaster_FrontOffice.Visible = False
                gbOperation_Inventory.Visible = False
                gbOperation_housekeeping.Visible = False
                gbRoomStatus.Visible = False

            Else

                MsgBox("You Do Not Have Access")

            End If



        End If



        If e.KeyCode = Keys.F6 Then


            If nbInvOp.Enabled = True Then



                gbOperation_Inventory.Visible = True


                gbOperation_BackOffice.Visible = False


                gbOperation_FrontOffice.Visible = False
                gbMaster_Inventory.Visible = False
                gbMaster_BackOffice.Visible = False
                gbMaster_FrontOffice.Visible = False
                gbOperation_housekeeping.Visible = False
                gbRoomStatus.Visible = False

            Else

                MsgBox("You Do Not Have Access")


            End If




        End If


        If e.KeyCode = Keys.F7 Then

            If nbHKOp.Enabled = True Then



                gbOperation_housekeeping.Visible = True


                gbOperation_Inventory.Visible = False


                gbOperation_BackOffice.Visible = False


                gbOperation_FrontOffice.Visible = False
                gbMaster_Inventory.Visible = False
                gbMaster_BackOffice.Visible = False
                gbMaster_FrontOffice.Visible = False
                gbRoomStatus.Visible = False

            Else

                MsgBox("You Do Not Have Access")

            End If




        End If



        If e.KeyCode = Keys.F8 Then

            Dim CheckAccess As Boolean = UserPermission(CurrUser, "RoomStatusGraphicalFormat", "View")

            If CheckAccess = True Then

                LoadGrid()


                gbRoomStatus.Visible = True
                gbOperation_Inventory.Visible = False
                gbOperation_BackOffice.Visible = False
                gbOperation_FrontOffice.Visible = False
                gbMaster_Inventory.Visible = False
                gbMaster_BackOffice.Visible = False
                gbMaster_FrontOffice.Visible = False

            Else

                MsgBox("You Do Not Have Access")


            End If



        End If


        If e.KeyCode = Keys.F9 Then

            Dim CheckAccess As Boolean = UserPermission(CurrUser, "Messenger", "View")

            If CheckAccess = True Then


                frmMessengers.Show()


            Else

                MsgBox("You Do Not Have Access")


            End If



        End If



        If e.KeyCode = Keys.F10 Then

            Dim CheckAccess As Boolean = UserPermission(CurrUser, "KOTBOTBilling", "View")

            Dim CheckAccess2 As Boolean = UserPermission(CurrUser, "OutletBilling", "View")

            If CheckAccess = True Or CheckAccess2 = True Then



                frmKOT_BOT_Billing.Show()
                ' frmKOT_BOT_Billing.Show()


            Else

                MsgBox("You Do Not Have Access")


            End If



        End If





            If e.KeyCode = Keys.Escape Then

                Me.Close()
                frmLogin.Close()


            End If



            If (e.KeyCode = Keys.B AndAlso e.Modifiers = Keys.Control) Then
                Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatMaster", "View")

                If CheckAccess = True Then

                    frmBoat.Show()

                Else

                    MsgBox("You Do Not Have Access")


                End If

            End If


            If (e.KeyCode = Keys.F AndAlso e.Modifiers = Keys.Control) Then

                Dim CheckAccess As Boolean = UserPermission(CurrUser, "FlightMaster", "View")

                If CheckAccess = True Then

                    frmFlightSchedule.Show()

                Else

                    MsgBox("You Do Not Have Access")


                End If

            End If


            If (e.KeyCode = Keys.T AndAlso e.Modifiers = Keys.Control) Then

                Dim CheckAccess As Boolean = UserPermission(CurrUser, "TourOperatorMaster", "View")

                If CheckAccess = True Then

                    frmTourOperators.Show()

                Else

                    MsgBox("You Do Not Have Access")


                End If

            End If


            If (e.KeyCode = Keys.R AndAlso e.Modifiers = Keys.Control) Then

                Dim CheckAccess As Boolean = UserPermission(CurrUser, "Reservation", "View")

                If CheckAccess = True Then

                    frmReservation.Show()

                Else

                    MsgBox("You Do Not Have Access")


                End If


        End If


        If (e.KeyCode = Keys.E AndAlso e.Modifiers = Keys.Control) Then

            Dim CheckAccess As Boolean = UserPermission(CurrUser, "Checkout", "View")

            If CheckAccess = True Then


                frmCheckOuts.Show()

            Else

                MsgBox("You Do Not Have Access")


            End If


        End If






            If (e.KeyCode = Keys.G AndAlso e.Modifiers = Keys.Control) Then

                Dim CheckAccess As Boolean = UserPermission(CurrUser, "GuestRegistration", "View")

                If CheckAccess = True Then

                    frmReservertionSearch.Show()

                Else

                    MsgBox("You Do Not Have Access")


                End If
            End If

            If (e.KeyCode = Keys.P AndAlso e.Modifiers = Keys.Control) Then

                Dim CheckAccess As Boolean = UserPermission(CurrUser, "GuestProfile", "View")

                If CheckAccess = True Then

                    frmGuestRegisterView.Show()

                Else

                    MsgBox("You Do Not Have Access")


                End If


            End If

            If (e.KeyCode = Keys.D AndAlso e.Modifiers = Keys.Control) Then


                Dim CheckAccess As Boolean = UserPermission(CurrUser, "GuestReminder", "View")

                If CheckAccess = True Then


                    frmGuestreminder.Show()

                Else

                    MsgBox("You Do Not Have Access")


                End If

            End If

            If (e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control) Then


                Dim CheckAccess As Boolean = UserPermission(CurrUser, "RoomStatus", "View")

                If CheckAccess = True Then


                    frmRoomMaster.Show()

                Else

                    MsgBox("You Do Not Have Access")


                End If

            End If

            If (e.KeyCode = Keys.O AndAlso e.Modifiers = Keys.Control) Then

                Dim CheckAccess As Boolean = UserPermission(CurrUser, "ForecastDetails", "View")

                If CheckAccess = True Then

                    frmForecastDetails.Show()

                Else

                    MsgBox("You Do Not Have Access")


                End If


            End If

            If (e.KeyCode = Keys.A AndAlso e.Modifiers = Keys.Control) Then

                Dim CheckAccess As Boolean = UserPermission(CurrUser, "ArrivalDepartureExpected", "View")

                If CheckAccess = True Then

                    ' frmArrivalDepartureExpexted.Show()

                    NewfrmExpectedArrivalDeparture.Show()

                Else

                    MsgBox("You Do Not Have Access")


                End If

            End If

            If (e.KeyCode = Keys.H AndAlso e.Modifiers = Keys.Control) Then

                Dim CheckAccess As Boolean = UserPermission(CurrUser, "BoatScheduling", "View")

                If CheckAccess = True Then


                    frmBoatSchedule.Show()

                Else

                    MsgBox("You Do Not Have Access")


                End If

            End If


            If (e.KeyCode = Keys.N AndAlso e.Modifiers = Keys.Control) Then


                Dim CheckAccess As Boolean = UserPermission(CurrUser, "Room number Change", "View")

                If CheckAccess = True Then


                    frmRoomnochange.Show()


                Else

                    MsgBox("You Do Not Have Access")


                End If

            End If


            If (e.KeyCode = Keys.C AndAlso e.Modifiers = Keys.Control) Then

                Dim CheckAccess As Boolean = UserPermission(CurrUser, "GuestFeedbackAndComments", "View")

                If CheckAccess = True Then


                    frmGuestFeedBack_Comments.Show()

                Else

                    MsgBox("You Do Not Have Access")


                End If

            End If

            If (e.KeyCode = Keys.Y AndAlso e.Modifiers = Keys.Control) Then

                Dim CheckAccess As Boolean = UserPermission(CurrUser, "Room Allocation Edit", "View")

                If CheckAccess = True Then


                    frmRoomChange.Show()

                Else

                    MsgBox("You Do Not Have Access")


                End If

            End If

            If (e.KeyCode = Keys.L AndAlso e.Modifiers = Keys.Control) Then

                Dim CheckAccess As Boolean = UserPermission(CurrUser, "Room Block", "View")

                If CheckAccess = True Then

                    frmRoomblock.Show()

                Else

                    MsgBox("You Do Not Have Access")


                End If


            End If


        If (e.KeyCode = Keys.Q AndAlso e.Modifiers = Keys.Control) Then


            Dim CheckAccess As Boolean = UserPermission(CurrUser, "AssignRoom", "View")

            If CheckAccess = True Then




                frmReservertionRoomAssign.Show()




            Else

                MsgBox("You Do Not Have Access")

            End If
        End If


    End Sub

    Private Sub SimpleButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton16.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "ItemTemp", "View")

        If CheckAccess = True Then



            frmItemTemplate.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If

    End Sub

    Private Sub SimpleButton49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton49.Click

    End Sub

    Private Sub SimpleButton47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton47.Click

    End Sub
    Private Sub StockInHandToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockInHandToolStripMenuItem1.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Inventory", "View")

        If CheckAccess = True Then


            frmInventory_Report.ReportTitle = "Stock In Hand Report"
            frmInventory_Report.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If

    End Sub

    Private Sub BinCardToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BinCardToolStripMenuItem1.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Inventory", "View")

        If CheckAccess = True Then


            frmInventory_Report.ReportTitle = "Bincard Report"
            frmInventory_Report.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub GINToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GINToolStripMenuItem1.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Inventory", "View")

        If CheckAccess = True Then

            frmGINReport.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub PriceListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriceListToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Inventory", "View")

        If CheckAccess = True Then



            frmReportViewerZ.rptPath = "rptPriceList.rpt"
            frmReportViewerZ.rptTitle = "Item Price List Report"
            frmReportViewerZ.selectionForumla = ""
            frmReportViewerZ.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If


    End Sub

    Private Sub MinibarStocksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinibarStocksToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Inventory", "View")

        If CheckAccess = True Then


            frmReportViewerZ.rptPath = "rptStockInHandMiniBar.rpt"
            frmReportViewerZ.rptTitle = "Minibar Stock Report"
            frmReportViewerZ.selectionForumla = "{vwItemInventoryFull.RoomNo}  <> ''"

            frmReportViewerZ.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If



    End Sub

  

    Private Sub ItemAdjustmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemAdjustmentToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Inventory", "View")

        If CheckAccess = True Then



            frmInventory_Report.ReportTitle = "Item Ajustment"
            frmInventory_Report.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If


    End Sub

    Private Sub ItemAdjustmentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub KitchenConsumtionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KitchenConsumtionsToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Inventory", "View")

        If CheckAccess = True Then


            frmInventory_Report.ReportTitle = "Item WriteOff Report"
            frmInventory_Report.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If


    End Sub

    Private Sub BedTaxToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BedTaxToolStripMenuItem1.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then


            frmBed_Tax_Report.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If


    End Sub

    Private Sub BDayReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDayReportToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then


            NewfrmBirtday_Report.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If


    End Sub

    Private Sub GuestFeedbackCommentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestFeedbackCommentsToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then



            NewfrmGuestFeedback_Comments.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If



    End Sub

    Private Sub BookingCheckListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingCheckListToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then

            NewfrmBooking_Check_List_Report.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If


    End Sub

    Private Sub RoomStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomStatusToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then


            NewfrmRoom_Staus_Report.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If



    End Sub

    Private Sub GuestListInHouseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestListInHouseToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then



            NewfrmGuest_List_In_House.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If



    End Sub

    Private Sub GuestInHouseRepeatersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestInHouseRepeatersToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then


            NewfrmGuest_List_For_In_House_Repeaters.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If


    End Sub

    Private Sub ExpectedArrivalDepartureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpectedArrivalDepartureToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then


            NewfrmExpectedArrivalDeparture.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If



    End Sub

    Private Sub SimpleButton62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton62.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "AssignRoom", "View")

        If CheckAccess = True Then



            frmReservertionRoomAssign.Show()



        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub AdminPanelToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminPanelToolStripMenuItem1.Click
        frmAdminPanel.Show()
    End Sub

    Private Sub SimpleButton63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton63.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "DirectPurchase", "View")

        If CheckAccess = True Then




            DirectPurchase.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If



    End Sub

    Private Sub OccupancyStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OccupancyStatusToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then


            NewfrmOccupancy_Status_Report.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If


    End Sub

    Private Sub OccupancyStatusAdvanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OccupancyStatusAdvanceToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then


            NewfrmOccupanAdv.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If

    End Sub

    Private Sub ReservationCreationGuestWiseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationCreationGuestWiseToolStripMenuItem1.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then

            frmReservation_Creation__Report_Guest_Wise.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If


    End Sub

    Private Sub ReservationCreationDeletionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationCreationDeletionToolStripMenuItem1.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then

            frmReservation_Creation_Deletion_Report.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then

            NewfrmOccupancyTOP.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then



            NewOccupancyRoomGraphical.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If



    End Sub

    Private Sub DepartureInformationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  frmDeparture_Information.Show()
    End Sub

    Private Sub SimpleButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton14.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "PriceListMaster", "View")

        If CheckAccess = True Then


            frmReportViewerZ.rptPath = "rptPriceList.rpt"
            frmReportViewerZ.rptTitle = "Item Price List Report"
            frmReportViewerZ.selectionForumla = ""
            frmReportViewerZ.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub ReportsInventoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsInventoryToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Inventory", "View")

        If CheckAccess = True Then


            ReportsInventoryToolStripMenuItem.Enabled = True

        Else

            MsgBox("You Do Not Have Access")
            ReportsInventoryToolStripMenuItem.Enabled = False




        End If


    End Sub

    Private Sub ReportFrontOfficeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFrontOfficeToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then


            ReportFrontOfficeToolStripMenuItem.Enabled = True

        Else

            MsgBox("You Do Not Have Access")
            ReportFrontOfficeToolStripMenuItem.Enabled = False




        End If
    End Sub

    Private Sub ReportBackOfficeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportBackOfficeToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then


            ReportBackOfficeToolStripMenuItem.Enabled = True

        Else

            MsgBox("You Do Not Have Access")

            ReportBackOfficeToolStripMenuItem.Enabled = False




        End If


    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmPasswordChange.Show()
    End Sub

    Private Sub PerformaInvoiceTOPWiseToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerformaInvoiceTOPWiseToolStripMenuItem2.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then


            frmOperator_Wise_Performa_Invoice_Breakup_Report.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If

    End Sub

    Private Sub PerformaInvoiceRaisedToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerformaInvoiceRaisedToolStripMenuItem2.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then


            frmPerforma_Invoice_Raised_Report.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If


    End Sub

    Private Sub OutletWiseSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutletWiseSalesToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then


            frmOutletwisesales.Show()



        Else

            MsgBox("You Do Not Have Access")





        End If




    End Sub

    Private Sub OutletSalesCollectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutletSalesCollectionToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then

            frmSalesCollection.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If

    End Sub

    Private Sub SimpleButton64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton64.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Checkout", "View")

        If CheckAccess = True Then



            frmCheckOuts.Show()



        Else

            MsgBox("You Do Not Have Access")





        End If





    End Sub

    Private Sub DailyFrontOfficeInformationToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DailyFrontOfficeInformationToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then

            frmDailyFrnt.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub TaxInvoiceTrackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaxInvoiceTrackToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then

            NewTaxInvTrackRep.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub OccupancyMonthlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OccupancyMonthlyToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then

            frmMonthlyoccuRPT.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If


    End Sub

    Private Sub DeparmentWiseConsumptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeparmentWiseConsumptionToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Inventory", "View")

        If CheckAccess = True Then


            'Deparment Wise Consumption
            frmInventory_Report.ReportTitle = "Deparment Wise Consumption"
            frmInventory_Report.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub DeparmentWiseStockReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeparmentWiseStockReportToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Inventory", "View")

        If CheckAccess = True Then

            frmInventory_Report.ReportTitle = "Deparment Wise Stock Report"
            frmInventory_Report.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If

    End Sub

    Private Sub POVsBNReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POVsBNReportToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Inventory", "View")

        If CheckAccess = True Then

            frmInventory_Report.ReportTitle = "PO vs BN Report"
            frmInventory_Report.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub GuestInHouseByAgeCountryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestInHouseByAgeCountryToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then

            frmcountryage.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub TOPExisistingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOPExisistingToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then

            frmtopcon.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub TOPCurrentContractDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOPCurrentContractDetailsToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then

            frmtopcon.Show()


        Else

            MsgBox("You Do Not Have Access")



        End If

    End Sub

    Private Sub R147_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R147.Click

    End Sub

    Private Sub SimpleButton65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton65.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "CrDbNote", "View")

        If CheckAccess = True Then


            frmDbcrnote.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If
    End Sub

    Private Sub HouseCountToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HouseCountToolStripMenuItem1.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then

            House_Count.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub SimpleButton66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton66.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Foodcosting", "View")

        If CheckAccess = True Then

            frmCosting.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub ReprintOutletBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReprintOutletBillToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then

            frmoutbillreprint.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub ReprintMasterBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReprintMasterBillToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then

            frmmasterbillrpt.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub MasterBillSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterBillSummaryToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then

            frmmasterbilsum.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub ComplimentaryRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplimentaryRToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then

            frmmonthlycomrpt.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub AIItemConsumptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AIItemConsumptionToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then

            frmmonthlysalesrpt.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub ComplimentaryOtherReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComplimentaryOtherReportToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then

            frmmonthlycomother.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub SalesOutletAccoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesOutletAccoToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then


            frmsalesoutacco.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub EmployeeSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeSalesToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then



            frmmonthlycomEMP.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub OutletSalesDetailReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutletSalesDetailReportToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then



            frmoutsales.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub RoomChangeReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomChangeReportToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then



            frmroomchangerpt.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub TaxInvoiceTrackToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaxInvoiceTrackToolStripMenuItem1.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then



            frmTaxInvoiceRaiseRpt.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If


    End Sub

    Private Sub GardenSpaStatementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GardenSpaStatementToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then


            frmSpaSales.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If



    End Sub

    Private Sub GuestInhouseBillsOnBoardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuestInhouseBillsOnBoardToolStripMenuItem.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then


            frmOnboardbills.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If








    End Sub

    Private Sub SalesCollectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesCollectionToolStripMenuItem.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then


            frmrptmbillcollections.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If







    End Sub

    Private Sub OutletWiseSalesDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutletWiseSalesDetailToolStripMenuItem.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then


            frmOutletSales.Show()


        Else

            MsgBox("You Do Not Have Access")





        End If




    End Sub

    Private Sub RoomChangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomChangeToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then



            frmroomchangerpt.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub SimpleButton67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton67.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "PaymentsVerification", "View")

        If CheckAccess = True Then

            frmPayCollectionVerification.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If
    End Sub

    Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub nbiDbBackup_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiDbBackup.LinkClicked

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "DB Backup", "Add")

        If CheckAccess = True Then



            frmDBbackup.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If







    End Sub

    Private Sub SimpleButton69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton69.Click


        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Employee Master", "View")

        If CheckAccess = True Then



            frmEmployee.Show()



        Else

            MsgBox("You Do Not Have Access")


        End If









    End Sub

    Private Sub SimpleButton68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton68.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Manual Checkout", "View")

        If CheckAccess = True Then



            frmManualCheckout.Show()



        Else

            MsgBox("You Do Not Have Access")


        End If


    End Sub

    Private Sub SimpleButton70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton70.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "GuestRegistration", "View")

        If CheckAccess = True Then


            frmGuestRegPrint.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub SimpleButton71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton71.Click

        frmOfferComplimentary.Show()

    End Sub

    Private Sub ItemConsumptionOutletWiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemConsumptionOutletWiseToolStripMenuItem.Click
        frmItemConumption.Show()
    End Sub

    Private Sub SimpleButton72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton72.Click
        frmMasterbillStaff.Show()
    End Sub

    Private Sub OccupancyStatusDetailTOPWiseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OccupancyStatusDetailTOPWiseToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Front Office", "View")

        If CheckAccess = True Then



            NewOccupancyTopDetails.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub GRNDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRNDetailsToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Inventory", "View")

        If CheckAccess = True Then


            NewGrnTrackReport.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub SimpleButton73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton73.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "MP Change", "View")

        If CheckAccess = True Then


            frmChangeMP.Show()


        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub MealPlanChangeLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MealPlanChangeLogToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then



            frmMPChangeLogRep.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub SimpleButton74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton74.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "RoomBill Change", "View")

        If CheckAccess = True Then


            frmChangeBillsRooms.Show()

        Else

            MsgBox("You Do Not Have Access")


        End If

    End Sub

    Private Sub RoomBillTransferLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomBillTransferLogToolStripMenuItem.Click
        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then


            frmRoomBillChangeRep.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub

    Private Sub CancelBillLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBillLogToolStripMenuItem.Click

        Dim CheckAccess As Boolean = UserPermission(CurrUser, "Report Back Office", "View")

        If CheckAccess = True Then


            frmBillCancelRep.Show()

        Else

            MsgBox("You Do Not Have Access")





        End If
    End Sub
End Class