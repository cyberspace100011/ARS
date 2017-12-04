
Imports CyberClasses

Public Class Ticket
    Private mstrTicketNo As String
    Private mdateCreationDate As Date
    Private mstrClerk As String
    Private mboolVoid As Boolean
    Private mstrCustomer As Customer
    Private mtvTransportVehicle As TransportVehicle
    Private mstrCustomerSignature As String
    Private mdecTotal As Decimal
    Private mticTicketItemsCollection As Dictionary(Of Integer, TicketItem)
    Private mttTransportTrailer As ARS.TransportTrailer
    Private mstrRecycler As ARS.SecondaryMetalRecycler
    Dim dsTicket As DataSet




#Region "Properties"
    Public Property TicketNumber As String
        Get
            Return mstrTicketNo
        End Get
        Set(value As String)
            mstrTicketNo = value
        End Set
    End Property

    Public Property CreationDate As Date
        Get
            Return mdateCreationDate
        End Get
        Set(value As Date)
            mdateCreationDate = value
        End Set
    End Property

    Public Property Clerk As String
        Get
            Return mstrClerk
        End Get
        Set(value As String)
            mstrClerk = value
        End Set
    End Property

    Public Property VoidTicket As Boolean
        Get
            Return mboolVoid
        End Get
        Set(value As Boolean)
            mboolVoid = value
        End Set
    End Property

    Public Property Customer As Customer
        Get
            Return mstrCustomer
        End Get
        Set(value As Customer)
            mstrCustomer = value
            mstrCustomer = New Customer
        End Set
    End Property

    Public Property Vehicle As TransportVehicle
        Get
            Return mtvTransportVehicle
        End Get
        Set(value As TransportVehicle)
            mtvTransportVehicle = value
        End Set
    End Property

    Public Property Signature As String
        Get
            Return mstrCustomerSignature
        End Get
        Set(value As String)
            mstrCustomerSignature = value
        End Set
    End Property

    Public Property Total As Decimal
        Get
            Return mdecTotal
        End Get
        Set(value As Decimal)
            mdecTotal = value
        End Set
    End Property

    Public Property TicketLineItems As Dictionary(Of Integer, TicketItem)
        Get
            Return mticTicketItemsCollection
        End Get
        Set(value As Dictionary(Of Integer, TicketItem))
            mticTicketItemsCollection = value
        End Set
    End Property

    Public Property Trailer As ARS.TransportTrailer
        Get
            Return mttTransportTrailer
        End Get
        Set(value As ARS.TransportTrailer)
            mttTransportTrailer = value
        End Set
    End Property

    Public Property Recycler As ARS.SecondaryMetalRecycler
        Get
            Return mstrRecycler
        End Get
        Set(value As ARS.SecondaryMetalRecycler)
            mstrRecycler = value
        End Set
    End Property

#End Region
    Sub New()
        TicketNumber = GenTicketNumber()
        CreationDate = Now()
        Clerk = "Unspecified"
        VoidTicket = False
        Recycler = New SecondaryMetalRecycler
        dsTicket = New DataSet
        Dim db As New CyberClasses.PG 'CyberAddins.PGReader

        'prepare the dataset to hold the ticket items
        db.ConnectToDB(String.Format("Select lineid,itemname,quantity,price,linetotal,pictures,ticket_number from ticketitems WHERE ticket_number = '{0}'", TicketNumber), dsTicket)
        'prepare the dataset to hold the ticket itself as well
        TicketLineItems() = New Dictionary(Of Integer, TicketItem)



    End Sub

    Public Function GenTicketNumber() As String
        Dim mpg As New CyberClasses.PG 'CyberAddins.PGReader
        Dim ds As New DataSet

        With mpg
            '.Host = My.Settings.Host
            '.UserName = My.Settings.UserName
            '.Password = My.Settings.Password
            '.Database = My.Settings.Database
            .ConnectToDB("SELECT ticket_number FROM tickets ORDER BY ticket_number DESC", ds)

        End With
        'Dim strSelectCommand As String = ""
        'Dim dc As New OleDb.OleDbConnection(My.Settings.ARSConnectionString)
        'Dim da As New OleDb.OleDbDataAdapter(strSelectCommand, dc)
        ' Dim ds As DataSet = New dsTicketsNos


        'dc.Open()
        ''  da.Fill(ds, 0, 1, "tickets")
        'dc.Close()
        Dim intOldTicketNo As Integer
        If ds.Tables(0).Rows.Count > 1 Then
            intOldTicketNo = CInt(ds.Tables(0).Rows.Item(0).Item("ticket_number").ToString)
        Else
            intOldTicketNo = 0
        End If
        intOldTicketNo += 1
        Return intOldTicketNo.ToString

    End Function
    Public Sub DisplayTotal(ByVal tb As ToolStripTextBox, ByVal tk As Ticket)
        tb.Text = FormatCurrency(tk.Total.ToString)
    End Sub
    Public Sub DisplayTotal(ByVal textbox As TextBox, ByVal tk As Ticket)
        textbox.Text = FormatCurrency(tk.Total.ToString)

    End Sub
    Public Function ProductPriceLookup(ByRef cbo As ComboBox, ByVal ds As DataSet) As Decimal
        If cbo.SelectedIndex > -1 Then


            Dim mpg As New CyberClasses.PG 'CyberAddins.PGReader
            Dim productName As String = cbo.Text
            Dim strLookup As String = String.Format("select product,currentprice FROM products WHERE product='{0}'", productName)

            With mpg
                '.Constring = My.Settings.PGConstring
                .ConnectToDB(strLookup, ds)
                '.selectcommand = strLookup
                '  .ReadData(strLookup, ds)
            End With
            Dim price As Decimal
            If ds.Tables(0).Rows.Item(0).Item("currentprice") Is System.DBNull.Value Then
                price = Nothing
            Else
                price = CDec(ds.Tables(0).Rows.Item(0).Item("currentprice"))

            End If
            Return price
        Else
            Return Nothing
        End If

    End Function
    Public Sub AddItemToTicket(ByVal t As TicketItem, dv As DataGridView)


        TicketLineItems.Add(TicketLineItems.Count, t)
        Total += t.LineTotal


        ' Dim count As Integer
        'If dsTicket.Tables(0).Rows.Count > 0 Then
        '    count = dsTicket.Tables(0).Rows.Count
        'Else
        '    count = 0
        'End If

        Dim TI As DataRow = dsTicket.Tables(0).NewRow
        With TI
            .Item("itemname") = t.ItemName
            .Item("quantity") = t.quantity
            .Item("price") = t.Price
            .Item("linetotal") = t.LineTotal
            .Item("ticket_number") = TicketNumber
            .Item("pictures") = t.ItemPhotoID
            .Item("lineid") = t.GenLineID
        End With
        dsTicket.Tables(0).Rows.Add(TI)


        dv.DataSource = dsTicket
        dv.DataMember = "table"
        dv.Columns.Item("ticket_number").Visible = False

        dv.Refresh()


    End Sub
    Public Function calculateLineTotal(ByVal p As TextBox, ByVal q As TextBox) As Decimal
        Dim lineprice As Decimal
        If p.Text <> "" And q.Text <> "" Then
            If IsNumeric(p.Text) And IsNumeric(q.Text) Then
                lineprice = CDec(p.Text) * CDec(q.Text)
            Else
                lineprice = 0D
            End If
        Else
            lineprice = 0D
        End If
        Return lineprice
    End Function

    Public Sub SaveTicketToDatabase()
        '1) save ticket
        '''SaveTickets()

        ''''2) save ticket items
        '''SaveTicketItems()

        '3) Save ticket item photos
    End Sub
    ''Private Sub SaveTickets()
    ''    Dim strTicketData As String = String.Format("INSERT INTO tickets(ticket_number, enter_date, customer, total) VALUES ('{0}', '{1}', {2}, {3});", Me.TicketNumber, Me.CreationDate.ToString, Me.Customer.CustomerID, Me.Total)

    ''    Dim PG As New CyberClasses.PG 'CyberAddins.PGReader
    ''    With PG
    ''        .InsertData(strTicketData)
    ''        .WriteNewData(strTicketData)
    ''    End With
    ''End Sub
    ''Private Sub SaveTicketItems()
    ''    Dim I As Integer
    ''    For I = 0 To Me.TicketLineItems.Count - 1
    ''        Dim strTicketItemData As String = String.Format("INSERT INTO ticketitems (lineid, itemname, quantity, price, linetotal, ticket_number, pictures) VALUES ({0}, '{1}', {2}, {3}, {4}, '{5}', {6});", Me.TicketLineItems.Item(I).GenLineID _
    ''                                                        , Me.TicketLineItems.Item(I).ItemName, Me.TicketLineItems.Item(I).quantity, Me.TicketLineItems.Item(I).Price, Me.TicketLineItems.Item(I).LineTotal, Me.TicketNumber, Me.TicketLineItems.Item(I).ItemPhotoID)
    ''        Dim PG As New CyberAddins.PGReader
    ''        With PG
    ''            .WriteNewData(strTicketItemData)
    ''        End With
    ''    Next

    ' End Sub
    Public Sub DisplayTicket(ByVal ticketno As Integer)



    End Sub
End Class
