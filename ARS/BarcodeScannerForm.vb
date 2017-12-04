Public Class BarcodeScannerForm
    Public Shared newCustomer As New scannedId
    Public Shared mboolScannedBarcode As Boolean
    Private _scannedFromMain As Boolean

    Public Property ScannedFromMain As Boolean
        Get
            Return _scannedFromMain
        End Get
        Set(value As Boolean)
            _scannedFromMain = value
        End Set
    End Property








    Private Sub txtBarcodeData_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcodeData.KeyDown
        If e.KeyCode = Keys.Enter Then
            If scannedId.CorrectTypeOfBarCode(txtBarcodeData) = True Then
                'MessageBox.Show("This is an ID barcode scan")
                'ARS.frmMain.mboolUsedScanner = True

                newCustomer = scannedId.ParseDLData(txtBarcodeData)
                If newCustomer.CustomerExists(newCustomer.ID_Number) = True Then
                    MessageBox.Show("This Customer is already in the system")
                Else
                    If ScannedFromMain = True Then
                        Dim NC As New NewCustomerForm
                        With NC
                            .NewCus = newCustomer
                            .MdiParent = Me.MdiParent
                            .WindowState = FormWindowState.Maximized
                            .Show()
                        End With
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