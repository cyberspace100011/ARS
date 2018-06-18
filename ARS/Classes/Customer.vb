
Public Class Customer
    Private _existing As Boolean
    Private _customerid As Integer
    Private _fname As String
    Private _middle As String
    Private _lname As String
    Private _suffix As String
    Private _addr1 As String
    Private _addr2 As String
    Private _city As String
    Private _state As String
    Private _zip As String
    Private _phone As String
    Private _birthdate As Date
    Private _weight As Integer
    Private _height As String
    Private _eyecolor As String
    Private _haircolor As String
    Private _sex As String
    Private _race As String
    Private _miscInfo As String
    Private _cusphoto As Integer
    Private _idimage As Integer
    Private _signaturerecord As Integer
    Private _signaturestring As String 'the actual signature data from the signature pad
    Private _Employer As Integer
    Private _idNumber As String
    Private _idstate As String
    Private _idexpiration As Date
    Private _idtype As IDTypes
    Private _idimageThumbnail As CyberClasses.Imaging
    Private _cusphotoThumbnail As CyberClasses.Imaging
    '  Private _transportvehicles As TransportVehicleList
    ' Private _transporttrailers As TransportTrailerList

    Public Event NewCustomerCreated As EventHandler

    Sub New(Optional ByVal CusID As Integer = -1)       'For Database Retrieval Only - Existing Customer
        If CusID > -1 Then
            ' NewCus = True
            ' Else
            CustomerID = CusID
            Dim strSelect As String = String.Format("Select * from customer where (id = {0});", CusID)
            Dim pg As New CyberClasses.PG
            Dim ds As New DataSet
            pg.ConnectToDB(strSelect, ds)
            With ds.Tables(0).Rows.Item(0)

                FirstName = .Item("cust_nm_first").ToString
                MiddleName = .Item("cust_nm_middle").ToString
                LastName = .Item("cust_nm_last").ToString
                SuffixName = .Item("cust_nm_suffix").ToString
                Address1 = .Item("cust_addr1").ToString
                Address2 = .Item("cust_addr2").ToString
                City = .Item("cust_city").ToString
                State = .Item("cust_state").ToString
                Zip = .Item("cust_zip").ToString
                Phone = .Item("cust_phone").ToString
                Height = .Item("cust_height").ToString
                EyeColor = .Item("cust_eye").ToString
                HairColor = .Item("cust_hair").ToString
                Sex = .Item("cust_sex").ToString
                Race = .Item("cust_race").ToString
                CustomerNotes = .Item("cust_info").ToString

                If .Item("cust_birthdate") Is System.DBNull.Value Then
                    Birthday = Nothing
                Else
                    Birthday = CDate(.Item("cust_birthdate"))
                End If

                If .Item("cust_employer") Is System.DBNull.Value Then
                    Employer = Nothing
                Else
                    Employer = CInt(.Item("cust_employer"))
                End If

                Weight = CInt(.Item("cust_weight"))

                'TODO: Need to finish customer load, images etc

            End With

            ' NewCus = False
        End If
    End Sub

    Public Sub New(ByRef lname As String, ByRef fname As String, ByRef addr1 As String, ByRef ccity As String, ByRef cstate As String,
                   ByRef czip As String, ByRef cphone As String, ByRef idtype As String, ByRef idstate As String, ByRef idnumber As String, ByRef idexpiration As Date, ByRef birthdate As Date,
                   ByRef cweight As Integer, ByRef cheight As String, ByRef ceyecolor As String, ByRef chaircolor As String, ByRef csex As String, Optional ByRef csuffix As String = "", Optional ByRef crace As String = "",
                   Optional ByRef middle As String = "", Optional ByRef Addr2 As String = "", Optional ByRef miscInfo As String = "",
                   Optional ByRef photo As Integer = -1, Optional ByRef idimage As Integer = -1, Optional ByRef signaturerecord As Integer = -1,
                   Optional ByRef signaturestring As String = "", Optional ByRef CEmployer As Integer = -1)      'For Creating a New Customer Record from Scratch - Not Already in the Database


        CustomerID = getid()
        FirstName = fname
        MiddleName = middle
        LastName = lname
        SuffixName = csuffix
        Address1 = addr1
        Address2 = Addr2
        City = ccity
        State = cstate
        Zip = czip
        Birthday = birthdate
        Phone = cphone
        Weight = cweight
        Height = cheight
        EyeColor = ceyecolor
        HairColor = chaircolor
        Sex = csex
        Race = crace
        CustomerNotes = miscInfo
        ID_State = idstate
        DL_Number = idnumber
        DL_Expiration = idexpiration
        CustomerPhoto = photo
        ID_Image = idimage
        SignatureImage = signaturerecord
        Signature = signaturestring
        Employer = CEmployer
        ' TypeOfID = idtype



    End Sub

    Public Property ExistingCustomer As Boolean
        Get
            Return _existing
        End Get
        Set(value As Boolean)
            _existing = value
        End Set
    End Property
    Public Property CustomerID As Integer
        Get
            Return _customerid
        End Get
        Set(value As Integer)
            _customerid = value
            'If value = -1 Then
            '    ExistingCustomer = False
            'Else
            '    ExistingCustomer = True
            'End If

        End Set
    End Property
    Public Property FirstName As String
        Get
            Return _fname
        End Get
        Set(value As String)
            _fname = value
        End Set
    End Property
    Public Property MiddleName As String
        Get
            Return _middle
        End Get
        Set(value As String)
            _middle = value
        End Set
    End Property
    Public Property LastName As String
        Get
            Return _lname
        End Get
        Set(value As String)
            _lname = value
        End Set
    End Property
    Public Property SuffixName As String
        Get
            Return _suffix
        End Get
        Set(value As String)
            _suffix = value
        End Set
    End Property
    Public Property Address1 As String
        Get
            Return _addr1
        End Get
        Set(value As String)
            _addr1 = value
        End Set
    End Property
    Public Property Address2 As String
        Get
            Return _addr2
        End Get
        Set(value As String)
            _addr2 = value
        End Set
    End Property
    Public Property City As String
        Get
            Return _city
        End Get
        Set(value As String)
            _city = value
        End Set
    End Property
    Public Property State As String
        Get
            Return _state
        End Get
        Set(value As String)
            _state = value
        End Set
    End Property
    Public Property Zip As String
        Get
            Return _zip
        End Get
        Set(value As String)
            _zip = value
        End Set
    End Property
    Public Property Birthday As Date
        Get
            Return _birthdate
        End Get
        Set(value As Date)
            _birthdate = value
        End Set
    End Property
    Public Property Phone As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property
    Public Property Employer As Integer
        Get
            Return _Employer
        End Get
        Set(value As Integer)
            _Employer = value
        End Set
    End Property
    Public Property Weight As Integer
        Get
            Return _weight
        End Get
        Set(value As Integer)
            _weight = value
        End Set
    End Property
    Public Property Height As String
        Get
            Return _height
        End Get
        Set(value As String)
            _height = value
        End Set
    End Property
    Public Property EyeColor As String
        Get
            Return _eyecolor
        End Get
        Set(value As String)
            _eyecolor = value
        End Set
    End Property
    Public Property HairColor As String
        Get
            Return _haircolor
        End Get
        Set(value As String)
            _haircolor = value
        End Set
    End Property
    Public Property Sex As String
        Get
            Return _sex
        End Get
        Set(value As String)
            _sex = value
        End Set
    End Property
    Public Property Race As String
        Get
            Return _race
        End Get
        Set(value As String)
            _race = value
        End Set
    End Property
    Public Property CustomerNotes As String
        Get
            Return _miscInfo
        End Get
        Set(value As String)
            _miscInfo = value
        End Set
    End Property
    Public Property CustomerPhoto As Integer

        Get
            Return _cusphoto
        End Get
        Set(value As Integer)
            _cusphoto = value
        End Set
    End Property
    Public Property ID_Image As Integer
        Get
            Return _idimage
        End Get
        Set(value As Integer)
            _idimage = value
        End Set
    End Property
    Public Property SignatureImage As Integer
        Get
            Return _signaturerecord
        End Get
        Set(value As Integer)
            _signaturerecord = value
        End Set
    End Property
    Public Property Signature As String
        Get
            Return _signaturestring
        End Get
        Set(value As String)
            _signaturestring = value
        End Set
    End Property
    Public Property TypeOfID As IDTypes
        Get
            Return _idtype
        End Get
        Set(value As IDTypes)
            _idtype = value
        End Set
    End Property
    Public Property DL_Number As String
        Get
            Return _idNumber
        End Get
        Set(value As String)
            _idNumber = value
        End Set
    End Property
    Public Property ID_State As String
        Get
            Return _idstate
        End Get
        Set(value As String)
            _idstate = value
        End Set
    End Property
    Public Property DL_Expiration As Date
        Get
            Return _idexpiration
        End Get
        Set(value As Date)
            _idexpiration = value
        End Set
    End Property
    Public Property IDImageThumbnail As CyberClasses.Imaging
        Get
            Return _idimageThumbnail
        End Get
        Set(value As CyberClasses.Imaging)
            _idimageThumbnail = value

        End Set
    End Property
    Public Property CustomerPhotoThumbnail As CyberClasses.Imaging
        Get
            Return _cusphotoThumbnail
        End Get
        Set(value As CyberClasses.Imaging)
            _cusphotoThumbnail = value
        End Set
    End Property
    'Public Property PreviousVehiclesList As ARS.TransportVehicleList
    '    Get
    '        Return _transportvehicles
    '    End Get
    '    Set(value As ARS.TransportVehicleList)
    '        _transportvehicles = value
    '    End Set
    'End Property
    'Public Property PreviousTrailersList As ARS.TransportTrailerList
    '    Get
    '        Return _transporttrailers
    '    End Get
    '    Set(value As ARS.TransportTrailerList)
    '        _transporttrailers = value
    '    End Set
    'End Property

    Private Function getid() As Integer
        getid = 0
        Dim strSelect As String = String.Format("Select id from customer ORDER BY id ASC")

        Dim dsIDs As New DataSet
        Dim cid As New CyberClasses.PG
        With cid
            .ConnectToDB(strSelect, dsIDs)
        End With
        Dim intCount As Integer = dsIDs.Tables(0).Rows.Count
        If intCount = 0 Then
            getid = 0
        Else
            getid = CInt(dsIDs.Tables(0).Rows.Item(intCount - 1).Item("id"))
        End If
        getid += 1


        Return getid
    End Function
    Public Sub SaveCustomerToDatabase(ByRef nc As Customer)
        Dim strInsert As String = String.Format("INSERT INTO customer VALUES({0},'{1}', '{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}', DATE('{14}'), DATE('{15}'), {16},'{17}','{18}','{19}','{20}','{21}','{22}',null,null,null,null,'{2}{3}{1}{13}');", nc.CustomerID, nc.LastName, nc.FirstName, nc.MiddleName, nc.SuffixName, nc.Address1, nc.Address2, nc.City, nc.State,
                                                nc.Zip, nc.Phone, nc.TypeOfID, nc.ID_State, nc.DL_Number, nc.DL_Expiration, nc.Birthday, nc.Weight, nc.Height, nc.EyeColor, nc.HairColor, nc.Race, nc.Sex, nc.CustomerNotes)

        'TODO: Note, this has been modified to drop the last 4 null fields altogether. This will be handled in future update, as this is in the process of debugging my code.
        '''Dim strInsert As String = String.Format("INSERT INTO customer VALUES({0},'{1}', '{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}', DATE('{14}'), DATE('{15}'), {16},'{17}','{18}','{19}','{20}','{21}','{22}',{23},{24},{25},{26});", nc.CustomerID, nc.LastName, nc.FirstName, nc.MiddleName, nc.SuffixName, nc.Address1, nc.Address2, nc.City, nc.State,
        '''                                        nc.Zip, nc.Phone, nc.TypeOfID, nc.ID_State, nc.DL_Number, nc.DL_Expiration, nc.Birthday, nc.Weight, nc.Height, nc.EyeColor, nc.HairColor, nc.Race, nc.Sex, nc.CustomerNotes, Nothing, Nothing, Nothing, Nothing)


        Dim pg As New CyberClasses.PG
        With pg
            .InsertStringData(strInsert)
        End With
    End Sub

End Class
