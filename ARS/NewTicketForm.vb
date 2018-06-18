Public Class NewTicketForm

    Private _Customer As Customer
    Private _ScannedID As scannedId


    Public Property Customer As Customer
        Get
            Return _Customer
        End Get
        Set(value As Customer)
            _Customer = value
        End Set
    End Property
    Public Property ScannedID As scannedId
        Get
            Return _ScannedID
        End Get
        Set(value As scannedId)
            _ScannedID = value
        End Set
    End Property



    Private Sub ScanCustomermIDToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ScanID()
        Dim scanid As New BarcodeScannerForm
        With scanid
            ' .MdiParent = Me
            .ScannedFromMain = False
            .NewCustomerScan = False
            .ExisCustomerScan = False
            .NewTicketScan = False
            .OpenTicketScan = True
            .ShowDialog()
            If scanid.NewCustomer IsNot Nothing Then
                ScannedID = scanid.NewCustomer
                Dim cusid As Integer
                If ScannedID.CustomerExists(ScannedID.ID_Number, cusid) = True Then
                    Customer = New Customer(cusid)
                    txtSelectedCustomer.Text = ScannedID.FirstName & " " & ScannedID.LastName
                    'btnViewCustomerRecord.Enabled = True

                    btnViewCustomerRecord.Enabled = True
                Else
                    If MessageBox.Show("This Customer is not in the system, would you like to add customer now?", "Add Customer?", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
                        Dim NC As New NewCustomerForm
                        With NC
                            .MdiParent = Me.MdiParent
                            .NewCus = ScannedID
                            .Show()
                        End With

                    End If
                End If


            End If

        End With
    End Sub

    Private Sub UseSearchFormToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SearchForCustomer()
        Dim sf As New CustomerSearchForm
        With sf
            ' .MdiParent = Me.MdiParent
            .ShowDialog()
            If sf.CusID > -1 Then
                Try
                    Dim CusID As Integer = sf.CusID
                    Customer = New Customer(CusID)

                    txtSelectedCustomer.Text = Customer.FirstName & " " & Customer.LastName
                    btnViewCustomerRecord.Enabled = True
                Catch ex As Exception
                    ' MessageBox.Show(ex.Message)
                    Debug.WriteLine(ex.Message)


                End Try

            End If


        End With
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        ScanID()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchForCustomer()
    End Sub


    Private Sub btnViewCustomerRecord_Click(sender As Object, e As EventArgs) Handles btnViewCustomerRecord.Click
        If Customer Is Nothing Then
        Else
            Dim CR As New CustomerRecord
            With CR
                '  .MdiParent = Me.MdiParent
                .StartPosition = FormStartPosition.CenterScreen
                .WindowState = FormWindowState.Normal
                .Customer = Customer
                .Show()
            End With
        End If
    End Sub


End Class