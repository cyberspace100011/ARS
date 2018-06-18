Public Class ManagePropertyTypes
    Private ds As New DataSet
    Private mboolnamefocused As Boolean

    Private Sub ManagePropertyTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItems()

    End Sub

    Private Sub LoadItems()
        mboolnamefocused = False

        Dim pg As New CyberClasses.PG
        ds.Clear()
        With pg
            .ConnectToDB("select * from products_list", ds)
        End With
        dgProducts.DataSource = ds.Tables(0)
    End Sub

    Private Function getNextID() As Integer
        Dim pg As New CyberClasses.PG
        Dim ds2 As New DataSet
        ds2.Clear()
        With pg
            .ConnectToDB("select * from products_list", ds2)
        End With
        Dim lastID As Integer = CInt(ds2.Tables(0).Rows.Item(ds2.Tables(0).Rows.Count - 1).Item("id"))
        getNextID = lastID + 1
        Return getNextID
    End Function
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        InsertNewItem()
        ' Me.Close()
        LoadItems()

    End Sub

    Private Sub InsertNewItem()
        If txtName.Text <> "" Then
            Dim strEntryString As String = ""
            Dim pname As String = txtName.Text
            Dim pprice As Decimal
            Dim id As Integer = getNextID()

            If txtPrice.Text <> "" Then
                pprice = CDec(txtPrice.Text)
            Else
                pprice = Nothing

            End If
            strEntryString = String.Format("INSERT INTO products_list VALUES({0}, '{1}', {2}) ", id, pname, pprice)
            Dim pg As New CyberClasses.PG
            With pg
                .InsertStringData(strEntryString)
            End With

        End If
    End Sub

    Private Sub ToolStrip1_Paint(sender As Object, e As PaintEventArgs) Handles ToolStrip1.Paint
        If txtName.Focused = True Then
            mboolnamefocused = True

        Else
            If mboolnamefocused = False Then
                txtName.Focus()
                mboolnamefocused = True
            End If

        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub DeleteProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteProductToolStripMenuItem.Click
        Dim selectedindex As Integer = dgProducts.CurrentRow.Index
        Dim product As String = ds.Tables(0).Rows.Item(selectedindex).Item("product").ToString
        Dim delstring As String = String.Format("DELETE from products_list where product = '{0}';", product)
        Dim pg As New CyberClasses.PG
        With pg
            .DeleteStringData(delstring)
        End With
        'MessageBox.Show(strmessage)
        LoadItems()

    End Sub

    Private Sub dgProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProducts.CellContentClick

    End Sub
End Class