Public Class BarcodeScannerForm
    Public Shared newCustomer As New scannedId
    Public Shared mboolScannedBarcode As Boolean
    Private _scannedFromMain As Boolean
    Private _CustomerScan As Boolean
    Private _TicketScan As Boolean

    Public Property ScannedFromMain As Boolean
        Get
            Return _scannedFromMain
        End Get
        Set(value As Boolean)
            _scannedFromMain = value
        End Set
    End Property
    Public Property CustomerScan As Boolean
        Get
            Return _CustomerScan
        End Get
        Set(value As Boolean)
            _CustomerScan = value
        End Set
    End Property
    Public Property TicketScan As Boolean
        Get
            Return _TicketScan
        End Get
        Set(value As Boolean)
            _TicketScan = value
        End Set
    End Property









    Private Sub txtBarcodeData_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcodeData.KeyDown
        If e.KeyCode = Keys.Enter Then
            If scannedId.CorrectTypeOfBarCode(txtBarcodeData) = True Then
                'MessageBox.Show("This is an ID barcode scan")
                'ARS.frmMain.mboolUsedScanner = True

                newCustomer = scannedId.ParseDLData(txtBarcodeData)
                If newCustomer.CustomerExists(newCustomer.ID_Number) = True Then
                    ' If MessageBox.Show("This Customer is already in the system, would you like to open the Customer Update Form?", "Existing Customer Found", "Duplicate Entry", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) = DialogResult.Yes Then
                    MessageBox.Show("Put code here to create a new ticket and load this customer")

                Else
                    If ScannedFromMain = True Then
                        Dim NC As New NewCustomerForm
                        With NC
                            .NewCus = newCustomer
                            .MdiParent = Me.MdiParent
                            .WindowState = FormWindowState.Maximized
                            .Show()
                        End With
                    ElseIf CustomerScan = True Then
                        Dim NC As New NewCustomerForm
                        With NC
                            .NewCus = newCustomer
                            .MdiParent = Me.MdiParent
                            .WindowState = FormWindowState.Maximized
                            .Show()
                        End With

                    ElseIf TicketScan = True Then
                        MessageBox.Show("Implement New Ticket Form")

                    End If
                End If


                ' mboolScannedBarcode = True
                Me.Close()

            Else
                MessageBox.Show("This is not the correct barcode")
                txtBarcodeData.Clear()
            End If
        End If
    End Sub



    Private Sub frmBarcodeScanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ARS.frmMain.mboolUsedScanner = False
    End Sub

End Class