
Imports ARS

Public Class TransportVehicle

    Private mintID As Integer
    Private mstrTagNumber As String
    Private mstrTagState As String
    Private mdtTagExpiration As Date

    Private mstrVMake As String
    Private mstrVModel As String
    Private mstrVColor As String
    Private mstrVYear As String
    '  Private imgVehiclePhoto As CyberAddins.ImageProcessing
    Private mstrCustomer As Customer

    Public Property ID As Integer 'this is the internal program id that represents this vehicle in the database
        Get
            Return mintID
        End Get
        Set(value As Integer)
            mintID = value
        End Set
    End Property

    Public Property Tag_Number As String
        Get
            Return mstrTagNumber
        End Get
        Set(value As String)
            mstrTagNumber = value
        End Set
    End Property

    Public Property Tag_State As String
        Get
            Return mstrTagState
        End Get
        Set(value As String)
            mstrTagState = value
        End Set
    End Property

    Public Property tag_expiration As Date
        Get
            Return mdtTagExpiration
        End Get
        Set(value As Date)
            mdtTagExpiration = value
        End Set
    End Property

    Public Property Veh_Make As String
        Get
            Return mstrVMake
        End Get
        Set(value As String)
            mstrVMake = value
        End Set
    End Property

    Public Property veh_model As String
        Get
            Return mstrVModel
        End Get
        Set(value As String)
            mstrVModel = value
        End Set
    End Property

    Public Property veh_color As String
        Get
            Return mstrVColor
        End Get
        Set(value As String)
            mstrVColor = value
        End Set
    End Property

    Public Property veh_year As String
        Get
            Return mstrVYear
        End Get
        Set(value As String)
            mstrVYear = value
        End Set
    End Property

    'Public Property veh_Image As CyberAddins.ImageProcessing
    '    Get
    '        Return imgVehiclePhoto
    '    End Get
    '    Set(value As CyberAddins.ImageProcessing)
    '        imgVehiclePhoto = value
    '    End Set
    'End Property

    Public Property Owner As Customer
        Get
            Return mstrCustomer
        End Get
        Set(value As Customer)
            mstrCustomer = value
        End Set
    End Property

    'Public Function CustomerVehicleList(ByVal mycus As Customer) As ArrayList
    '    ' Dim strSelectCommand As String = String.Format("SELECT ID, vehicle_license, vehicle_license_state, vehicle_license_exp, vehicle_make, vehicle_model, vehicle_color, vehicle_year, vehicle_picture, cust_ID FROM transport_vehicle WHERE (cust_ID = '{0}')", mycus.CustomerID)
    '    Dim dc As New OleDb.OleDbConnection(My.Settings.ARSConnectionString)
    '    Dim da As New OleDb.OleDbDataAdapter(strSelectCommand, dc)
    '    Dim dt As New DataTable
    '    Dim vlist As New ArrayList

    '    dc.Open()
    '    da.Fill(dt)
    '    dc.Close()
    '    If dt.Rows.Count > 0 Then
    '        Dim mycount As Integer = dt.Rows.Count
    '        Dim CTL(mycount) As TransportVehicle
    '        Dim I As Integer
    '        For I = 0 To mycount - 1
    '            With dt.Rows.Item(I)
    '                vlist.Add(.Item("ID"))
    '            End With
    '        Next
    '    End If
    '    Return vlist
    'End Function

    '''Public Sub NewTransportVehicle(ByVal ID As Integer, tv As TransportVehicle, ByVal cust As Customer)
    '''    Dim strSelectCommand As String = String.Format("SELECT ID, vehicle_license, vehicle_license_state, vehicle_license_exp, vehicle_make, vehicle_model, vehicle_color, vehicle_year, vehicle_picture, cust_ID FROM transport_vehicle WHERE (ID = {0})", ID)
    '''    Dim dc As New OleDb.OleDbConnection(My.Settings.ARSConnectionString)
    '''    Dim da As New OleDb.OleDbDataAdapter(strSelectCommand, dc)
    '''    Dim dt As New DataTable
    '''    dc.Open()
    '''    da.Fill(dt)
    '''    dc.Close()
    '''    If dt.Rows.Count = 1 Then
    '''        With dt.Rows.Item(0)
    '''            'tv.Vlist_ID = CInt(.Item("ID").ToString)
    '''            tv.Tag_Number = .Item("vehicle_license").ToString
    '''            tv.Tag_State = .Item("vehicle_license_state").ToString
    '''            tv.tag_expiration = CDate(.Item("vehicle_license_exp").ToString)
    '''            tv.Veh_Make = .Item("vehicle_make").ToString
    '''            tv.veh_model = .Item("vehicle_model").ToString
    '''            tv.veh_color = .Item("vehicle_color").ToString
    '''            tv.veh_year = .Item("vehicle_year").ToString
    '''            tv.mstrCustomer = cust
    '''            'TODO: Need to implememt code for images if images are wanted (Probably Not for Vehicles)

    '''        End With
    '''    End If

    '''End Sub

    Public Function VehicleCount(ByVal dt As DataTable) As Integer
        Dim rc As Integer = dt.Rows.Count
        Return rc
    End Function

End Class

Public Class TransportVehicleList
    Implements ICollection(Of TransportVehicle)

    Public ReadOnly Property Count As Integer Implements ICollection(Of TransportVehicle).Count
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of TransportVehicle).IsReadOnly
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Sub Add(item As TransportVehicle) Implements ICollection(Of TransportVehicle).Add
        Throw New NotImplementedException()
    End Sub

    Public Sub Clear() Implements ICollection(Of TransportVehicle).Clear
        Throw New NotImplementedException()
    End Sub

    Public Sub CopyTo(array() As TransportVehicle, arrayIndex As Integer) Implements ICollection(Of TransportVehicle).CopyTo
        Throw New NotImplementedException()
    End Sub

    Public Function Contains(item As TransportVehicle) As Boolean Implements ICollection(Of TransportVehicle).Contains
        Throw New NotImplementedException()
    End Function

    Public Function GetEnumerator() As IEnumerator(Of TransportVehicle) Implements IEnumerable(Of TransportVehicle).GetEnumerator
        Throw New NotImplementedException()
    End Function

    Public Function Remove(item As TransportVehicle) As Boolean Implements ICollection(Of TransportVehicle).Remove
        Throw New NotImplementedException()
    End Function

    Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Throw New NotImplementedException()
    End Function
End Class
