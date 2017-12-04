
Imports ARS
Imports CyberClasses


Public Class TicketItem
#Region "Variables"
    Private mintItemNumber As Integer
    Private mstrItemName As String
    Private mdecQuantity As Decimal
    Private mstrTicketNumber As String
    Private mboolVehicleItem As Boolean
    Private mstrMake As String
    Private mstrModel As String
    Private mstrColor As String
    Private mstrCondition As String
    Private mstrDescription As String
    Private mstrNotes As String
    Private mintNetWeight As Decimal
    Private mdecPrice As Decimal
    Private mdecAmount As Decimal
    Private mboolRecTitle As Boolean
    Private mstrItemPictureID As Integer
    Private mintDocumentationID As Integer

    'Sub New()
    '    ItemPhotos = New List(Of ImageFile)
    'End Sub

#End Region
#Region "Properties"

    Public Property ItemNumber As Integer
        Get
            Return mintItemNumber
        End Get
        Set(value As Integer)
            mintItemNumber = value
        End Set
    End Property
    Public Property ItemName As String
        Get
            Return mstrItemName
        End Get
        Set(value As String)
            mstrItemName = value
        End Set
    End Property
    Public Property quantity As Decimal
        Get
            Return mdecQuantity
        End Get
        Set(value As Decimal)
            mdecQuantity = value
        End Set
    End Property
    Public Property TicketNumber As String
        Get
            Return mstrTicketNumber
        End Get
        Set(value As String)
            mstrTicketNumber = value
        End Set
    End Property
    Public Property Is_This_A_Vehicle As Boolean
        Get
            Return mboolVehicleItem
        End Get
        Set(value As Boolean)
            mboolVehicleItem = value
        End Set
    End Property
    Public Property make As String
        Get
            Return mstrMake
        End Get
        Set(value As String)
            mstrMake = value
        End Set
    End Property
    Public Property model As String
        Get
            Return mstrModel
        End Get
        Set(value As String)
            mstrModel = value
        End Set
    End Property
    Public Property Color As String
        Get
            Return mstrColor
        End Get
        Set(value As String)
            mstrColor = value
        End Set
    End Property
    Public Property Condition As String
        Get
            Return mstrCondition
        End Get
        Set(value As String)
            mstrCondition = value
        End Set
    End Property
    Public Property Description As String
        Get
            Return mstrDescription
        End Get
        Set(value As String)
            mstrDescription = value
        End Set
    End Property
    Public Property Notes As String
        Get
            Return mstrNotes
        End Get
        Set(value As String)
            mstrNotes = value
        End Set
    End Property
    Public Property Weight As Decimal
        Get
            Return mintNetWeight
        End Get
        Set(value As Decimal)
            mintNetWeight = value
        End Set
    End Property
    Public Property Price As Decimal
        Get
            Return mdecPrice
        End Get
        Set(value As Decimal)
            mdecPrice = value
        End Set
    End Property
    Public Property LineTotal As Decimal
        Get
            Return mdecAmount
        End Get
        Set(value As Decimal)
            mdecAmount = value
        End Set
    End Property
    Public Property Received_Title As Boolean
        Get
            Return mboolRecTitle
        End Get
        Set(value As Boolean)
            mboolRecTitle = value
        End Set
    End Property
    Public Property ItemPhotoID As Integer 'corresponds to the ID of the image stored in the images table of the database
        Get
            Return mstrItemPictureID
        End Get
        Set(value As Integer)
            mstrItemPictureID = value
        End Set
    End Property
    Public Property Documentation As Integer
        Get
            Return mintDocumentationID
        End Get
        Set(value As Integer)
            mintDocumentationID = value
        End Set
    End Property

#End Region
#Region "Subs"
    Public Sub AddToDataView(ByVal DV As DataGridView, ByVal ti As TicketItem, ByVal ds As DataSet)
        Dim newrow As DataRow
        ' Dim dt As New DataTable

        newrow = ds.Tables(0).NewRow
        newrow("colItemNumber") = ti.ItemNumber.ToString
        newrow("colDescription") = ti.Description
        newrow("colQuantity") = ti.Weight
        newrow("colPrice") = ti.Price
        newrow("colLineTotal") = ti.LineTotal
        'TODO: implement Image Methods once this is secured as a viable processing means
        'DV.DataSource = dt
        ds.Tables(0).Rows.Add(newrow)

        'DV.Rows.Add(newrow)


    End Sub

    Public Sub SaveTicketItemsToDB()

    End Sub
#End Region
#Region "Functions"
    Public Function GenLineID() As Integer
        Dim mpg As New CyberClasses.PG 'CyberAddins.PGReader
        Dim ds As New DataSet

        With mpg

            .ConnectToDB("SELECT lineid FROM ticketitems ORDER BY lineid DESC", ds)

        End With

        Dim intOldLineID As Integer
        If ds.Tables(0).Rows.Count > 1 Then
            intOldLineID = CInt(ds.Tables(0).Rows.Item(0).Item("lineid").ToString)
        Else
            intOldLineID = 0
        End If
        intOldLineID += 1
        Return intOldLineID
    End Function
#End Region



End Class


'''Public Class TicketItemsList
'''    Implements Collections.Generic.ICollection(Of TicketItem)
'''    Public ReadOnly Property Count As Integer Implements ICollection(Of TicketItem).Count
'''        Get
'''            Throw New NotImplementedException()
'''        End Get
'''    End Property
'''    Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of TicketItem).IsReadOnly
'''        Get
'''            Throw New NotImplementedException()
'''        End Get
'''    End Property
'''    Public Sub Add(item As TicketItem) Implements ICollection(Of TicketItem).Add
'''        Throw New NotImplementedException()
'''    End Sub
'''    Public Sub Clear() Implements ICollection(Of TicketItem).Clear
'''        Throw New NotImplementedException()
'''    End Sub
'''    Public Sub CopyTo(array() As TicketItem, arrayIndex As Integer) Implements ICollection(Of TicketItem).CopyTo
'''        Throw New NotImplementedException()
'''    End Sub
'''    Public Function Contains(item As TicketItem) As Boolean Implements ICollection(Of TicketItem).Contains
'''        Throw New NotImplementedException()
'''    End Function
'''    Public Function GetEnumerator() As IEnumerator(Of TicketItem) Implements IEnumerable(Of TicketItem).GetEnumerator
'''        Throw New NotImplementedException()
'''    End Function
'''    Public Function Remove(item As TicketItem) As Boolean Implements ICollection(Of TicketItem).Remove
'''        Throw New NotImplementedException()
'''    End Function
'''    Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
'''        Throw New NotImplementedException()
'''    End Function
'''End Class
'''Public TicketItemsCollection As ArrayList
''''Inherits Collections.CollectionBase
'''Private mticTicketItems As ARS.TicketItem
'''    Public Property TicketItems As ARS.TicketItem
'''        Get
'''            Return mticTicketItems
'''        End Get
'''        Set(value As ARS.TicketItem)
'''            mticTicketItems = value
'''        End Set
'''    End Property
'''End Class
