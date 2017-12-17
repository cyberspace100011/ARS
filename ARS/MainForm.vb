Public Class MainForm


#Region "Module Level Variables"
    Public Shared scannedCustomer As New scannedId

#End Region
#Region "Toolbar And Button Appearance Control"
    Dim toolbarCollection(5) As ToolStrip
    Dim buttonlist(5) As ToolStripButton
    Private Sub LoadToolbarsIntoList()
        toolbarCollection(0) = tsPurchasing
        toolbarCollection(1) = tsSales
        toolbarCollection(2) = tsInventory
        toolbarCollection(3) = tsExpenses
        toolbarCollection(4) = tsReports
        toolbarCollection(5) = tsSettings
    End Sub
    Private Sub LoadButtonsIntoList()
        buttonlist(0) = btnPurchasing
        buttonlist(1) = btnSales
        buttonlist(2) = btnInventory
        buttonlist(3) = btnExpenses
        buttonlist(4) = btnReports
        buttonlist(5) = btnAdvanced
    End Sub
    Private Sub HideToolbars()
        Dim I As Integer
        For I = 0 To 5
            toolbarCollection(I).Visible = False
        Next
    End Sub
    Private Sub UncheckButtons(ByVal ExcludedButton As Integer)
        Dim I As Integer
        For I = 0 To 5
            If I <> ExcludedButton Then
                buttonlist(I).Checked = False
            End If
        Next
    End Sub
    Private Sub btnPurchasing_Click(sender As Object, e As EventArgs) Handles btnPurchasing.Click
        HideToolbars()
        UncheckButtons(0)
        tsPurchasing.Visible = btnPurchasing.Checked
    End Sub
    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        HideToolbars()
        UncheckButtons(1)
        tsSales.Visible = btnSales.Checked
    End Sub
    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        HideToolbars()
        UncheckButtons(2)
        tsInventory.Visible = btnInventory.Checked
    End Sub
    Private Sub btnExpenses_Click(sender As Object, e As EventArgs) Handles btnExpenses.Click
        HideToolbars()
        UncheckButtons(3)
        tsExpenses.Visible = btnExpenses.Checked
    End Sub
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        HideToolbars()
        UncheckButtons(4)
        tsReports.Visible = btnReports.Checked
    End Sub
    Private Sub btnAdvanced_Click(sender As Object, e As EventArgs) Handles btnAdvanced.Click
        HideToolbars()
        UncheckButtons(5)
        tsSettings.Visible = btnAdvanced.Checked
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadToolbarsIntoList()
        LoadButtonsIntoList()

    End Sub

    Private Sub btnCustomersNew_Click(sender As Object, e As EventArgs) Handles btnCustomersNew.Click
        ' btnCustomersNew.HideDropDown()
        btnCustomers.HideDropDown()

        Dim nc As New NewCustomerForm
        With nc
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub btnScanID_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tsHome_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsHome.ItemClicked

    End Sub

    Private Sub btnCustomersManage_Click(sender As Object, e As EventArgs) Handles btnCustomersManage.Click
        btnCustomers.HideDropDown()

        Dim cs As New CustomerSearchForm
        With cs
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub ScanCustomerIDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ScanCustomerIDToolStripMenuItem1.Click
        Dim scanid As New BarcodeScannerForm
        With scanid
            .MdiParent = Me
            .ScannedFromMain = False
            .CustomerScan = True
            .TicketScan = False
            .Show()
        End With
    End Sub

    Private Sub btnTicketsNew_Click(sender As Object, e As EventArgs) Handles btnTicketsNew.Click

    End Sub

    Private Sub ScanCustomerIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScanCustomerIDToolStripMenuItem.Click
        Dim scanid As New BarcodeScannerForm
        With scanid
            .MdiParent = Me
            .ScannedFromMain = False
            .CustomerScan = False
            .TicketScan = True
            .Show()
        End With
    End Sub

    Private Sub ScanCustomerIDToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ScanCustomerIDToolStripMenuItem2.Click

    End Sub



#End Region


End Class
