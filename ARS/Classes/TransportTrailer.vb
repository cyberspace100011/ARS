
Imports ARS

Public Class TransportTrailer
    ''' <summary>
    ''' Data ID Reference
    ''' </summary>
    Private intID As Integer
    Private strDescription As String
    Private strColor As String
    Private strTagNo As String
    Private strTagState As String
    Private dtExpirationDate As Date
    ' Private imgPhoto As CyberAddins.ImageProcessing
    Private strCustomer As String
    Private cusOwner As ARS.Customer

    Public Property ID As Integer
        Get
            Return intID
        End Get
        Set(value As Integer)
            intID = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return strDescription
        End Get
        Set(value As String)
            strDescription = value
        End Set
    End Property

    Public Property TagNo As String
        Get
            Return strTagNo
        End Get
        Set(value As String)
            strTagNo = value
        End Set
    End Property

    Public Property TagState As String
        Get
            Return strTagState
        End Get
        Set(value As String)
            strTagState = value
        End Set
    End Property

    Public Property Expiration As Date
        Get
            Return dtExpirationDate
        End Get
        Set(value As Date)
            dtExpirationDate = value
        End Set
    End Property

    'Public Property Photo As CyberAddins.ImageProcessing
    '    Get
    '        Return imgPhoto
    '    End Get
    '    Set(value As CyberAddins.ImageProcessing)
    '        imgPhoto = value
    '    End Set
    'End Property

    Public Property Owner As ARS.Customer
        Get
            Return cusOwner
        End Get
        Set(value As ARS.Customer)
            cusOwner = value
        End Set
    End Property

    'Public Sub NewTrailerRecord(ID As Integer, Owner As ARS.Customer, TagNo As String, TagState As String, Expiration As Date, Description As String, Photo As CyberAddins.ImageProcessing)

    'End Sub
End Class

Public Class TransportTrailerList
    Implements ICollection(Of TransportTrailer)

    Public ReadOnly Property Count As Integer Implements ICollection(Of TransportTrailer).Count
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of TransportTrailer).IsReadOnly
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Sub Add(item As TransportTrailer) Implements ICollection(Of TransportTrailer).Add
        Throw New NotImplementedException()
    End Sub

    Public Sub Clear() Implements ICollection(Of TransportTrailer).Clear
        Throw New NotImplementedException()
    End Sub

    Public Sub CopyTo(array() As TransportTrailer, arrayIndex As Integer) Implements ICollection(Of TransportTrailer).CopyTo
        Throw New NotImplementedException()
    End Sub

    Public Function Contains(item As TransportTrailer) As Boolean Implements ICollection(Of TransportTrailer).Contains
        Throw New NotImplementedException()
    End Function

    Public Function GetEnumerator() As IEnumerator(Of TransportTrailer) Implements IEnumerable(Of TransportTrailer).GetEnumerator
        Throw New NotImplementedException()
    End Function

    Public Function Remove(item As TransportTrailer) As Boolean Implements ICollection(Of TransportTrailer).Remove
        Throw New NotImplementedException()
    End Function

    Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Throw New NotImplementedException()
    End Function
End Class
