Public Class CustomerSearchForm
    Dim dsCustomer As New DataSet
    Private _customer As Customer
    Private _CusID As Integer


    Public Property Customer As Customer
        Get
            Return _customer
        End Get
        Set(value As Customer)
            _customer = Customer
        End Set
    End Property
    Public Property CusID As Integer
        Get
            Return _CusID
        End Get
        Set(value As Integer)
            _CusID = value
        End Set
    End Property


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'MessageBox.Show(Searchstring(txtSearchField.Text))
        Dim pg As New CyberClasses.PG
        ' Dim dsCustomer As New DataSet
        pg.ConnectToDB(Searchstring(txtSearchField.Text), dsCustomer)
        dg1.DataSource = dsCustomer
        dg1.DataMember = "Table"
        dg1.Columns.Item(10).Visible = False



    End Sub


    Private Function Searchstring(ByVal searchfield As String) As String
        Searchstring = ""
        If searchfield.Contains(" ") Then
            searchfield = searchfield.Replace(" ", "%")
        End If
        Searchstring = String.Format("Select id, cust_id_number, cust_nm_last, cust_nm_first, cust_nm_middle, cust_nm_suffix, cust_addr1, cust_city, cust_state, cust_zip, search_field  FROM customer WHERE search_field like '%{0}%'", searchfield)
        Return Searchstring
    End Function

    Private Sub btnScanID_Click(sender As Object, e As EventArgs) Handles btnScanID.Click

    End Sub

    Private Sub cboFieldName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchField.KeyDown
        If e.KeyCode = Keys.Enter Then
            'MessageBox.Show(txtSearchField.Text)
            Call btnSearch_Click(sender, e)

        End If
    End Sub

    Private Sub CustomerSearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        dsCustomer = New DataSet
        dg1.DataSource = dsCustomer
        ' dg1.Columns.Item(0).Width = 2
        If txtSearchField.Text <> "" Then
            Call btnSearch_Click(sender, e)
        End If
        ' If Me.Visible = True Then
        txtSearchField.Focus()
        Timer1.Enabled = True
        Timer1.Start()

        ' End If


        '  dg1.DataMember = "customer"

    End Sub

    Private Sub dg1_DoubleClick(sender As Object, e As EventArgs) Handles dg1.DoubleClick
        Try
            Dim selcustomer As Integer = dg1.SelectedRows.Item(0).Index
            Dim strID As Integer = CInt(dsCustomer.Tables(0).Rows.Item(selcustomer).Item("id"))
            CusID = strID
            Me.Close()

            'Customer = New Customer(strID)
            'Me.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtSearchField.Focus()
        If txtSearchField.Focused = True Then
            Timer1.Stop()
            Timer1.Enabled = False

        End If
    End Sub
End Class