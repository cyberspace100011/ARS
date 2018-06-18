Public Class BarcodeScannerForm
    Private _newCustomer As scannedId
    Private _mboolScannedBarcode As Boolean
    Private _scannedFromMain As Boolean
    Private _customerScan As Boolean
    Private _ticketScan As Boolean
    Private _callSource(4) As Boolean

    Public Property NewCustomer As scannedId
        Get
            Return _newCustomer
        End Get
        Set(value As scannedId)
            _newCustomer = value
        End Set
    End Property
    Public Property ScannedFromMain As Boolean     'scan originated from main form (May phase this out, depending further dev)
        Get
            Return _callSource(0)
        End Get
        Set(value As Boolean)
            _callSource(0) = value
        End Set
    End Property
    Public Property NewCustomerScan As Boolean      'scan originates from menu item New Customer
        Get
            Return _callSource(1)
        End Get
        Set(value As Boolean)
            _callSource(1) = value
        End Set
    End Property
    Public Property ExisCustomerScan As Boolean       'Scan originates from menu item Manage Customer
        Get
            Return _callSource(2)
        End Get
        Set(value As Boolean)
            _callSource(2) = value
        End Set
    End Property
    Public Property NewTicketScan As Boolean        'Scan Originates from menu item New Ticket (Choose Customer Before Creation of ticket)
        Get
            Return _callSource(3)
        End Get
        Set(value As Boolean)
            _callSource(3) = value
        End Set
    End Property
    Public Property OpenTicketScan As Boolean       'Scan Originates from within an open ticket (Choose Customer after Creation of ticket)
        Get
            Return _callSource(4)
        End Get
        Set(value As Boolean)
            _callSource(4) = value
        End Set
    End Property
    Private Function SourceValue() As Integer
        If _callSource(0) = True Then
            SourceValue = 0
        ElseIf _callSource(1) = True Then
            SourceValue = 1
        ElseIf _callSource(2) = True Then
            SourceValue = 2
        ElseIf _callSource(3) = True Then
            SourceValue = 3
        ElseIf _callSource(4) = True Then
            SourceValue = 4
        End If
        Return SourceValue
    End Function

    Public Sub ScannedBarcode(ByRef sourceid As Integer)
        If sourceid = 1 Then
            If NewCustomer.CustomerExists(NewCustomer.ID_Number, -1) = True Then
                sourceid = 2
            End If
        End If

        Select Case sourceid

            Case 0    '0=main

            Case 1    '1=NewCustomer
                Dim NC As New NewCustomerForm
                With NC
                    .MdiParent = Me.MdiParent
                    .NewCus = newCustomer
                    .WindowState = FormWindowState.Maximized
                    .Show()
                End With
            Case 2    '2=manageCustomer
                Dim NC As New CustomerSearchForm
                With NC
                    '.NewCus = newCustomer
                    .MdiParent = Me.MdiParent
                    .txtSearchField.Text = newCustomer.ID_Number
                    .WindowState = FormWindowState.Maximized
                    .Show()
                End With
            Case 3    '3=NewTicketCreation

            Case 4    '4=openTicketSelection

        End Select

    End Sub

    Private Sub txtBarcodeData_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcodeData.KeyDown
        If e.KeyCode = Keys.Enter Then
            If scannedId.CorrectTypeOfBarCode(txtBarcodeData) = True Then
                newCustomer = scannedId.ParseDLData(txtBarcodeData)
                'ScannedBarcode(SourceValue())
                Me.Close()

            Else
                MessageBox.Show("This is not the correct barcode")
                txtBarcodeData.Clear()
            End If
        End If
    End Sub



    Private Sub frmBarcodeScanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ARS.frmMain.mboolUsedScanner = False
        Me.WindowState = FormWindowState.Normal
    End Sub

End Class