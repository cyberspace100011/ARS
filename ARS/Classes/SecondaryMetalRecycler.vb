Public Class SecondaryMetalRecycler
    Private strCompanyName As String
    Private strDefaultID As Integer
    Private strAddress1 As String
    Private strAddress2 As String
    Private strCity As String
    Private strState As String
    Private strZip As String
    Private strCounty As String
    Private strLeadsOnlineUsername As String
    Private strLeadsPassword As String
    Private strLOStoreID As String
    Private strLocationName As String
    Private strPhone As String

    Sub New()
        DataID = 1
        'LoadFromDatabase(DataID)
    End Sub

    ''' <summary>
    ''' If more than one location exists, then this is the corp name
    ''' </summary>
    Public Property CompanyName As String
        Get
            Return strCompanyName
        End Get
        Set(value As String)
            strCompanyName = value
        End Set
    End Property

    ''' <summary>
    ''' The name that identifies this particular location as opposed to other locations within the same corporation
    ''' </summary>
    Public Property LocationName As String
        Get
            Return strLocationName
        End Get
        Set(value As String)
            strLocationName = value
        End Set
    End Property

    Private Property LeadsOnlineUsername As String
        Get
            Return strLeadsOnlineUsername
        End Get
        Set(value As String)
            strLeadsOnlineUsername = value
        End Set
    End Property

    Private Property LeadsOnlinePassword As String
        Get
            Return strLeadsPassword
        End Get
        Set(value As String)
            strLeadsPassword = value
        End Set
    End Property

    Private Property LOStoreIDNumber As String
        Get
            Return strLOStoreID
        End Get
        Set(value As String)
            strLOStoreID = value
        End Set
    End Property

    Public Property County As String
        Get
            Return strCounty
        End Get
        Set(value As String)
            strCounty = value
        End Set
    End Property

    Public Property State As String
        Get
            Return strState
        End Get
        Set(value As String)
            strState = value
        End Set
    End Property

    Public Property City As String
        Get
            Return strCity
        End Get
        Set(value As String)
            strCity = value
        End Set
    End Property

    Public Property zip As String
        Get
            Return strZip
        End Get
        Set(value As String)
            strZip = value
        End Set
    End Property

    Public Property Address1 As String
        Get
            Return strAddress1
        End Get
        Set(value As String)
            strAddress1 = value
        End Set
    End Property

    Public Property Address2 As String
        Get
            Return strAddress2
        End Get
        Set(value As String)
            strAddress2 = value
        End Set
    End Property

    Public Property DataID As Integer
        Get
            Return strDefaultID
        End Get
        Set(value As Integer)
            strDefaultID = value
        End Set
    End Property

    Public Property Phone As String
        Get
            Return strPhone
        End Get
        Set(value As String)
            strPhone = value
        End Set
    End Property

    ''' <summary>
    ''' Loads the Secondary Metal Recycler's information from the datafile
    ''' </summary>
    ''' 
    '''Public Sub LoadFromDatabase(ID As Integer)
    '''    Dim strSelectCommandText As String = String.Format("SELECT ID, company_nm, store_number, store_nm, store_addr1, store_addr2, store_city, store_state, store_zip, store_county, store_phone FROM store_info WHERE (ID = {0})", ID.ToString)
    '''    Dim dc As New OleDb.OleDbConnection(My.Settings.ARSConnectionString)
    '''    Dim da As New OleDb.OleDbDataAdapter(strSelectCommandText, dc)
    '''    Dim dt As New DataTable
    '''    dc.Open()
    '''    da.Fill(dt)
    '''    dc.Close()
    '''    If dt.Rows.Count = 1 Then
    '''        With dt.Rows.Item(0)
    '''            If .Item("company_nm") Is System.DBNull.Value Then
    '''                CompanyName = Nothing
    '''            Else
    '''                CompanyName = .Item("company_nm").ToString
    '''            End If

    '''            If .Item("store_number") Is System.DBNull.Value Then
    '''                LOStoreIDNumber = Nothing
    '''            Else
    '''                LOStoreIDNumber = .Item("store_number").ToString
    '''            End If

    '''            If .Item("store_nm") Is System.DBNull.Value Then
    '''                LocationName = Nothing
    '''            Else
    '''                LocationName = .Item("store_nm").ToString
    '''            End If

    '''            If .Item("store_addr1") Is System.DBNull.Value Then
    '''                Address1 = Nothing
    '''            Else
    '''                Address1 = .Item("store_addr1").ToString
    '''            End If

    '''            If .Item("store_addr2") Is System.DBNull.Value Then
    '''                Address2 = Nothing
    '''            Else
    '''                Address2 = .Item("store_addr2").ToString
    '''            End If

    '''            If .Item("store_city") Is System.DBNull.Value Then
    '''                City = Nothing
    '''            Else
    '''                City = .Item("store_city").ToString
    '''            End If

    '''            If .Item("store_state") Is System.DBNull.Value Then
    '''                State = Nothing
    '''            Else
    '''                State = .Item("store_state").ToString
    '''            End If

    '''            If .Item("store_zip") Is System.DBNull.Value Then
    '''                zip = Nothing
    '''            Else
    '''                zip = .Item("store_zip").ToString
    '''            End If

    '''            If .Item("store_county") Is System.DBNull.Value Then
    '''                County = Nothing
    '''            Else
    '''                County = .Item("store_county").ToString
    '''            End If

    '''            If .Item("store_phone") Is System.DBNull.Value Then
    '''                Phone = Nothing
    '''            Else
    '''                Phone = .Item("store_phone").ToString
    '''            End If

    '''            'dt.Dispose()
    '''            'dc.Dispose()
    '''            'da.Dispose()

    '''        End With

    '''    End If
    '''End Sub
End Class
