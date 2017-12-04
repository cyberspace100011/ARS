
Public Class Customer
    Private IsNew As Boolean
    Private mstrCustomerID As String
    Private mstrLName As String
    Private mstrMiddleName As String
    Private mstrFName As String
    Private mstrSuffixName As String
    Private mstrAddress1 As String
    Private mstrAddress2 As String
    Private mstrCity As String
    Private mstrState As String
    Private mstrZip As String
    Private mstrPhone As String
    Private mdtBirthdate As Date
    Private mintWeight As Integer
    Private mstrHeight As String
    Private mstreyeColor As String
    Private mstrSex As String
    Private mstrmiscInfo As String
    Private mintCusPhoto As Integer
    Private mintIDImage As Integer
    Private mintSignatureImage As Integer
    Private mstrCustomerSignature As String 'the actual signature data from the signature pad
    Private mstrEmployerName As String
    Private mstrEmployerAddress1 As String
    Private mstrEmployerAddress2 As String
    Private mstrEmployerCity As String
    Private mstrEmployerState As String
    Private mstrEmployerZip As String
    Private mstrEmployerPHone As String
    Private mstrDLNumber As String
    Private mstrIDState As String
    Private mdtIDExpiration As Date
    Private mintIDType As IDTypes
    Private mtvTransportVehicles As TransportVehicleList
    Private mttTransportTrailers As TransportTrailerList

    Public Event NewCustomerCreated As EventHandler

    Sub New(Optional ByVal CusID As String = "-1")
        If CusID <> "-1" And CusID <> "" Then
            ' NewCus = True
            ' Else
            CustomerID = CusID
            ' NewCus = False
        End If
    End Sub
    Public Property NewCus As Boolean
        Get
            Return IsNew
        End Get
        Set(value As Boolean)
            IsNew = value
        End Set
    End Property
    Public Property CustomerID As String
        Get
            Return mstrCustomerID
        End Get
        Set(value As String)
            mstrCustomerID = value
            If value = "-1" Then
                NewCus = True
                ' UnloadPreviousCustomerData()

            Else
                NewCus = False
                'LoadFromDatabase(value)
            End If
            'If NewCus = False Then
            '    If mstrCustomerID <> "" Then
            '        LoadFromDatabase(mstrCustomerID)
            '    End If
            'End If
        End Set
    End Property
    Public Property FirstName As String
        Get
            Return mstrFName
        End Get
        Set(value As String)
            mstrFName = value
        End Set
    End Property
    Public Property MiddleName As String
        Get
            Return mstrMiddleName
        End Get
        Set(value As String)
            mstrMiddleName = value
        End Set
    End Property
    Public Property LastName As String
        Get
            Return mstrLName
        End Get
        Set(value As String)
            mstrLName = value
        End Set
    End Property
    Public Property SuffixName As String
        Get
            Return mstrSuffixName
        End Get
        Set(value As String)
            mstrSuffixName = value
        End Set
    End Property
    Public Property Address1 As String
        Get
            Return mstrAddress1
        End Get
        Set(value As String)
            mstrAddress1 = value
        End Set
    End Property
    Public Property Address2 As String
        Get
            Return mstrAddress2
        End Get
        Set(value As String)
            mstrAddress2 = value
        End Set
    End Property
    Public Property City As String
        Get
            Return mstrCity
        End Get
        Set(value As String)
            mstrCity = value
        End Set
    End Property
    Public Property State As String
        Get
            Return mstrState
        End Get
        Set(value As String)
            mstrState = value
        End Set
    End Property
    Public Property Zip As String
        Get
            Return mstrZip
        End Get
        Set(value As String)
            mstrZip = value
        End Set
    End Property
    Public Property EmployerName As String
        Get
            Return mstrEmployerName
        End Get
        Set(value As String)
            mstrEmployerName = value
        End Set
    End Property
    Public Property EmployerAddress1 As String
        Get
            Return mstrEmployerAddress1
        End Get
        Set(value As String)
            mstrEmployerAddress1 = value
        End Set
    End Property
    Public Property EmployerAddress2 As String
        Get
            Return mstrEmployerAddress2
        End Get
        Set(value As String)
            mstrEmployerAddress2 = value
        End Set
    End Property
    Public Property EmployerCity As String
        Get
            Return mstrEmployerCity
        End Get
        Set(value As String)
            mstrEmployerCity = value
        End Set
    End Property
    Public Property EmployerState As String
        Get
            Return mstrEmployerState
        End Get
        Set(value As String)
            mstrEmployerState = value
        End Set
    End Property
    Public Property EmployerZip As String
        Get
            Return mstrEmployerZip
        End Get
        Set(value As String)
            mstrEmployerZip = value
        End Set
    End Property
    Public Property EmployerPhone As String
        Get
            Return mstrEmployerPHone
        End Get
        Set(value As String)
            mstrEmployerPHone = value
        End Set
    End Property
    Public Property Birthday As Date
        Get
            Return mdtBirthdate
        End Get
        Set(value As Date)
            mdtBirthdate = value
        End Set
    End Property
    Public Property Phone As String
        Get
            Return mstrPhone
        End Get
        Set(value As String)
            mstrPhone = value
        End Set
    End Property
    Public Property Weight As Integer
        Get
            Return mintWeight
        End Get
        Set(value As Integer)
            mintWeight = value
        End Set
    End Property
    Public Property Height As String
        Get
            Return mstrHeight
        End Get
        Set(value As String)
            mstrHeight = value
        End Set
    End Property
    Public Property EyeColor As String
        Get
            Return mstreyeColor
        End Get
        Set(value As String)
            mstreyeColor = value
        End Set
    End Property
    Public Property Sex As String
        Get
            Return mstrSex
        End Get
        Set(value As String)
            mstrSex = value
        End Set
    End Property
    Public Property CustomerNotes As String
        Get
            Return mstrmiscInfo
        End Get
        Set(value As String)
            mstrmiscInfo = value
        End Set
    End Property
    Public Property CustomerPhoto As Integer

        Get
            Return mintCusPhoto
        End Get
        Set(value As Integer)
            mintCusPhoto = value
        End Set
    End Property
    Public Property ID_Image As Integer
        Get
            Return mintIDImage
        End Get
        Set(value As Integer)
            mintIDImage = value
        End Set
    End Property
    Public Property SignatureImage As Integer
        Get
            Return mintSignatureImage
        End Get
        Set(value As Integer)
            mintSignatureImage = value
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
    Public Property IdType As IDTypes
        Get
            Return mintIDType
        End Get
        Set(value As IDTypes)
            mintIDType = value
        End Set
    End Property
    Public Property DL_Number As String
        Get
            Return mstrDLNumber
        End Get
        Set(value As String)
            mstrDLNumber = value
        End Set
    End Property
    Public Property ID_State As String
        Get
            Return mstrIDState
        End Get
        Set(value As String)
            mstrIDState = value
        End Set
    End Property
    Public Property DL_Expiration As Date
        Get
            Return mdtIDExpiration
        End Get
        Set(value As Date)
            mdtIDExpiration = value
        End Set
    End Property
    Public Property PreviousVehiclesList As ARS.TransportVehicleList
        Get
            Return mtvTransportVehicles
        End Get
        Set(value As ARS.TransportVehicleList)
            mtvTransportVehicles = value
        End Set
    End Property
    Public Property PreviousTrailersList As ARS.TransportTrailerList
        Get
            Return mttTransportTrailers
        End Get
        Set(value As ARS.TransportTrailerList)
            mttTransportTrailers = value
        End Set
    End Property

    '' <param name="CustomerID">Customer ID to load a customer from the database into memory, I.E. this class</param>
    ''Public Sub LoadFromDatabase(CustomerID As String)
    ''    Dim sc As String = String.Format("SELECT cust_id, cust_nm_last, cust_nm_first, cust_nm_middle, cust_addr1, cust_addr2, cust_city, cust_state, cust_zip, cust_id_number, employer_nm, cust_nm_suffix, cust_phone," &
    ''    "cust_id_type, cust_id_state, cust_id_exp, cust_birthdate, cust_weight, cust_height, cust_eye, cust_sex, cust_info, employer_addr1, employer_addr2, employer_city," &
    ''    "employer_state, employer_zip, employer_phone, cust_photo, cust_dl, cust_sig  FROM  customer WHERE (cust_id = '{0}')", CustomerID)

    ''    Dim ds As New DataSet
    ''    Dim pg As New CyberAddins.PGReader
    ''    With pg
    ''        '.Host = My.Settings.Host
    ''        '.UserName = My.Settings.UserName
    ''        '.Password = My.Settings.Password
    ''        '.Database = My.Settings.Database
    ''        .ReadData(sc, ds)

    ''    End With
    ''    'Dim da As New OleDb.OleDbDataAdapter(sc, My.Settings.ARSConnectionString)
    ''    'Dim dc As New OleDb.OleDbConnection(My.Settings.ARSConnectionString)
    ''    'Dim dt As New DataTable
    ''    'dc.Open()
    ''    'da.Fill(dt)
    ''    'dc.Close()
    ''    If ds.Tables(0).Rows.Count = 1 Then
    ''        With ds.Tables(0).Rows.Item(0)
    ''            FirstName = .Item("cust_nm_first").ToString
    ''            LastName = .Item("cust_nm_last").ToString
    ''            MiddleName = .Item("cust_nm_middle").ToString
    ''            SuffixName = .Item("cust_nm_suffix").ToString
    ''            Address1 = .Item("cust_addr1").ToString
    ''            Address2 = .Item("cust_addr2").ToString
    ''            City = .Item("cust_city").ToString
    ''            State = .Item("cust_state").ToString
    ''            Zip = .Item("cust_zip").ToString
    ''            DL_Number = .Item("cust_id_Number").ToString
    ''            If .Item("cust_id_exp") Is System.DBNull.Value Then
    ''            Else
    ''                DL_Expiration = CDate(.Item("cust_id_exp"))
    ''            End If
    ''            If .Item("cust_birthdate") Is System.DBNull.Value Then
    ''            Else
    ''                Birthday = CDate(.Item("cust_birthdate"))
    ''            End If
    ''            Phone = .Item("cust_phone").ToString
    ''            EmployerName = .Item("employer_nm").ToString
    ''            EmployerAddress1 = .Item("employer_addr1").ToString
    ''            EmployerAddress2 = .Item("employer_addr2").ToString
    ''            EmployerState = .Item("employer_state").ToString
    ''            EmployerCity = .Item("employer_city").ToString
    ''            EmployerZip = .Item("employer_zip").ToString
    ''            EmployerPhone = .Item("employer_phone").ToString
    ''            If .Item("cust_photo") Is System.DBNull.Value Then
    ''                CustomerPhoto = Nothing
    ''            Else
    ''                CustomerPhoto = CInt(.Item("cust_photo"))

    ''            End If
    ''            If .Item("cust_dl") Is System.DBNull.Value Then
    ''                ID_Image = Nothing
    ''            Else
    ''                ID_Image = CInt(.Item("cust_dl").ToString)

    ''            End If
    ''            If .Item("cust_sig") Is System.DBNull.Value Then
    ''                SignatureImage = Nothing
    ''            Else
    ''                SignatureImage = CInt(.Item("cust_sig").ToString)


    ''            End If

    ''        End With
    ''    End If
    ''End Sub
    ''Public Sub UpdateCustomerRecordToDatabase(CustomerID As String)
    ''    Dim sc As String = String.Format("SELECT cust_id, cust_nm_last, cust_nm_first, cust_nm_middle, cust_addr1, cust_addr2, cust_city, cust_state, cust_zip, cust_id_number, employer_nm, cust_nm_suffix, cust_phone," &
    ''    "cust_id_type, cust_id_state, cust_id_exp, cust_birthdate, cust_weight, cust_height, cust_eye, cust_sex, cust_info, employer_addr1, employer_addr2, employer_city," &
    ''    "employer_state, employer_zip, employer_phone, cust_photo, cust_dl, cust_sig  FROM  customer WHERE (cust_id = '{0}')", CustomerID)
    ''    'Dim da As New OleDb.OleDbDataAdapter(sc, My.Settings.ARSConnectionString)
    ''    'Dim dc As New OleDb.OleDbConnection(My.Settings.ARSConnectionString)
    ''    'Dim dt As New DataTable
    ''    'dc.Open()
    ''    'da.Fill(dt)
    ''    'dc.Close()
    ''    Dim ds As New DataSet
    ''    Dim pg As New CyberAddins.PGReader
    ''    With pg
    ''        '.Host = My.Settings.Host
    ''        '.UserName = My.Settings.UserName
    ''        '.Password = My.Settings.Password
    ''        '.Database = My.Settings.Database
    ''        .ReadData(sc, ds)

    ''    End With
    ''    If ds.Tables(0).Rows.Count = 1 Then
    ''        With ds.Tables(0).Rows.Item(0)
    ''            .Item("cust_nm_first") = FirstName
    ''            .Item("cust_nm_last") = LastName
    ''            .Item("cust_nm_middle") = MiddleName
    ''            .Item("cust_nm_suffix") = SuffixName
    ''            .Item("cust_addr1") = Address1
    ''            .Item("cust_addr2") = Address2
    ''            .Item("cust_city") = City
    ''            .Item("cust_state") = State
    ''            .Item("cust_zip") = Zip
    ''            .Item("cust_id_Number") = DL_Number
    ''            .Item("cust_id_exp") = DL_Expiration
    ''            .Item("cust_phone") = Phone
    ''            .Item("cust_birthdate") = Birthday
    ''            .Item("employer_nm") = EmployerName
    ''            .Item("Employer_addr1") = EmployerAddress1
    ''            .Item("Employer_addr2") = EmployerAddress2
    ''            .Item("employer_state") = EmployerState
    ''            .Item("employer_city") = EmployerCity
    ''            .Item("employer_zip") = EmployerZip
    ''            .Item("employer_phone") = EmployerPhone
    ''        End With
    ''        Dim strUpdateText As String = " Update customer set cust_id=cust_id, cust_nm_last=cust_nm_last, cust_nm_first=cust_nm_first, cust_nm_middle=cust_nm_middle, cust_addr1=cust_addr1, cust_addr2=cust_addr2, cust_city=cust_city, cust_state=cust_state, cust_zip=cust_zip, cust_id_number=cust_id_number, employer_nm=employer_nm, cust_nm_suffix=cust_nm_suffix, cust_phone=cust_phone," &
    ''    "cust_id_type=cust_id_type, cust_id_state=cust_id_state, cust_id_exp=cust_id_exp, cust_birthdate=cust_birthdate, cust_weight=cust_weight, cust_height=cust_height, cust_eye=cust_eye, cust_sex=cust_sex, cust_info=cust_info, employer_addr1=employer_addr1, employer_addr2=employer_addr2, employer_city=employer_city," &
    ''    "employer_state=employer_state, employer_zip=employer_zip, employer_phone=employer_phone, cust_photo=cust_photo, cust_dl=cust_dl, cust_sig=cust_sig"
    ''        pg.UpdateData(strUpdateText, ds)


    ''    End If
    ''End Sub

    ''Private Sub UnloadPreviousCustomerData(ByVal CurrentCustomer As Customer)
    ''    CurrentCustomer = Nothing

    ''    'With CurrentCustomer
    ''    '    .CustomerID = "-1"
    ''    '    .Address1 = Nothing
    ''    '    .Address2 = Nothing
    ''    '    .Birthday = Nothing
    ''    '    .City = Nothing
    ''    '    .State = Nothing
    ''    '    .Zip = Nothing
    ''    '    .CustomerNotes = Nothing
    ''    '    .DL_Expiration = Nothing
    ''    '    .DL_Number = Nothing
    ''    '    .EmployerAddress1 = Nothing



    ''    'End With
    ''    'Throw New NotImplementedException()
    ''End Sub




End Class
