Public Class PropertyLookupControl
    Private _productid As Integer
    Private _ProdName As String
    Private _price As Decimal
    Private _quantity As Decimal
    Private _LineTotal As Decimal
    Private _dsData As DataSet


    Public Property Productid As Integer
        Get
            Return _productid
        End Get
        Set(value As Integer)
            _productid = value
        End Set
    End Property
    Public Property ProdName As String
        Get
            Return _ProdName
        End Get
        Set(value As String)
            _ProdName = value
        End Set
    End Property
    Public Property Price As Decimal
        Get
            Return _price
        End Get
        Set(value As Decimal)
            _price = value
        End Set
    End Property
    Public Property Quantity As Decimal
        Get
            Return _quantity
        End Get
        Set(value As Decimal)
            _quantity = value
        End Set
    End Property
    Public Property LineTotal As Decimal
        Get
            Return _LineTotal
        End Get
        Set(value As Decimal)
            _LineTotal = value
        End Set
    End Property



    Private Sub PropertyLookupControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItems()
    End Sub

    Private Sub LoadItems()
        Dim pg As New CyberClasses.PG
        _dsData = New DataSet
        _dsData.Clear()
        pg.ConnectToDB("SELECT * FROM products_list ORDER BY product ASC", _dsData)
        cboProducts.DataSource = _dsData.Tables(0)
        cboProducts.DisplayMember = "product"
    End Sub

    Private Sub cboProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProducts.SelectedIndexChanged
        Dim intIndex As Integer = cboProducts.SelectedIndex
        Try

            Productid = CInt(_dsData.Tables(0).Rows.Item(intIndex).Item("id"))
            ProdName = _dsData.Tables(0).Rows.Item(intIndex).Item("product").ToString
            Price = CDec(_dsData.Tables(0).Rows.Item(intIndex).Item("price"))
            txtPrice.txtTextBox.Text = FormatCurrency(Price.ToString)

            CalculateTotal()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim prod As New ManagePropertyTypes
        With prod
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            LoadItems()
        End With
    End Sub

    Private Sub txtQuantity_Validated(sender As Object, e As EventArgs) Handles txtQuantity.Validated
        CalculateTotal()
    End Sub

    Private Sub CalculateTotal()
        If txtQuantity.txtTextBox.Text <> "" Then
            If txtPrice.txtTextBox.Text <> "" Then
                Try
                    Dim price As Decimal = CDec(txtPrice.txtTextBox.Text)
                    Dim quantity As Decimal = CDec(txtQuantity.txtTextBox.Text)
                    Dim total As Decimal = price * quantity
                    txtTotal.txtTextBox.Text = FormatCurrency(total)

                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub txtPrice_Validated(sender As Object, e As EventArgs) Handles txtPrice.Validated
        CalculateTotal()

    End Sub
End Class
