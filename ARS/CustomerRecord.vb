Public Class CustomerRecord

    Private _customer As Customer

    Public Property Customer As Customer
        Get
            Return _customer
        End Get
        Set(value As Customer)
            _customer = value
        End Set
    End Property
    Private Sub LoadCustomerRecord(ByRef Cust As Customer)
        Dim dsCustomer As New DataSet
        Dim strSelectCustomer As String = String.Format("select * from customer WHERE (id = {0})", Cust.CustomerID)
        Dim pg As New CyberClasses.PG
        pg.ConnectToDB(strSelectCustomer, dsCustomer)
        With dsCustomer.Tables(0).Rows.Item(0)

            If .Item("cust_nm_last") Is System.DBNull.Value Then
            Else
                txtLName.txtTextBox.Text = .Item("cust_nm_last").ToString
            End If
            If .Item("cust_nm_first") Is System.DBNull.Value Then
            Else
                txtFName.txtTextBox.Text = .Item("cust_nm_first").ToString
            End If
            If .Item("cust_addr1") Is System.DBNull.Value Then
            Else
                txtAddress.txtTextBox.Text = .Item("cust_addr1").ToString
            End If
            If .Item("cust_city") Is System.DBNull.Value Then
            Else
                txtCity.txtTextBox.Text = .Item("cust_city").ToString
            End If
            If .Item("cust_state") Is System.DBNull.Value Then
            Else
                txtState.txtTextBox.Text = .Item("cust_state").ToString
            End If
            If .Item("cust_zip") Is System.DBNull.Value Then
            Else
                txtZip.txtTextBox.Text = .Item("cust_zip").ToString
            End If
            If .Item("cust_id_number") Is System.DBNull.Value Then
            Else
                txtDLNo.txtTextBox.Text = .Item("cust_id_number").ToString
            End If
            If .Item("cust_phone") Is System.DBNull.Value Then
            Else
                txtPhone.txtTextBox.Text = .Item("cust_phone").ToString
            End If
        End With
    End Sub

    Private Sub CustomerRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Customer Is Nothing Then
        Else
            LoadCustomerRecord(Customer)

        End If
    End Sub
End Class