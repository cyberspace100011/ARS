Public Class scannedId
    Private strFName As String
    Private strMI As String
    Private strLName As String
    Private strSuffix As String
    Private strAddress1 As String
    Private strAddress2 As String
    Private strCity As String
    Private strState As String
    Private strZip As String
    Private dtDOB As Date
    Private strWeight As String
    Private strHeight As String
    Private strEyeColor As String
    Private strHairColor As String
    Private strRace As String
    Private strSex As String
    Private strIDType As String
    Private strIDState As String
    Private strIDNumber As String
    Private dtIDExpiration As Date
    Private mintIDImage As Image

    Public Property FirstName As String
        Get
            Return strFName
        End Get
        Set(value As String)
            strFName = value
        End Set
    End Property
    Public Property MiddleName As String
        Get
            Return strMI
        End Get
        Set(value As String)
            strMI = value
        End Set
    End Property
    Public Property LastName As String
        Get
            Return strLName
        End Get
        Set(value As String)
            strLName = value
        End Set
    End Property
    Public Property NameSuffix As String
        Get
            Return strSuffix
        End Get
        Set(value As String)
            strSuffix = value
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
    Public Property City As String
        Get
            Return strCity
        End Get
        Set(value As String)
            strCity = value
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
    Public Property Zip As String
        Get
            Return strZip
        End Get
        Set(value As String)
            strZip = value
        End Set
    End Property
    Public Property Birthdate As Date
        Get
            Return dtDOB
        End Get
        Set(value As Date)
            dtDOB = value
        End Set
    End Property
    Public Property Weight As String
        Get
            Return strWeight
        End Get
        Set(value As String)
            strWeight = value
        End Set
    End Property
    Public Property CusHeight As String
        Get
            Return strHeight
        End Get
        Set(value As String)
            strHeight = value
        End Set
    End Property
    Public Property EyeColor As String
        Get
            Return strEyeColor
        End Get
        Set(value As String)
            strEyeColor = value
        End Set
    End Property
    Public Property HairColor As String
        Get
            Return strHairColor
        End Get
        Set(value As String)
            strHairColor = value
        End Set
    End Property
    Public Property Race As String
        Get
            Return strRace
        End Get
        Set(value As String)
            strRace = value
        End Set
    End Property
    Public Property Sex As String
        Get
            Return strSex
        End Get
        Set(value As String)
            strSex = value
            If value = "1" Then
                strSex = "male"
            ElseIf value = "2" Then
                strSex = "female"
            End If
        End Set
    End Property
    Public Property ID_Type As String
        Get
            Return strIDType
        End Get
        Set(value As String)
            strIDType = value
        End Set
    End Property
    Public Property ID_State As String
        Get
            Return strIDState
        End Get
        Set(value As String)
            strIDState = value
        End Set
    End Property
    Public Property ID_Number As String
        Get
            Return strIDNumber
        End Get
        Set(value As String)
            strIDNumber = value
        End Set
    End Property
    Public Property ID_Expiration_Date As Date
        Get
            Return dtIDExpiration
        End Get
        Set(value As Date)
            dtIDExpiration = value
        End Set
    End Property
    Public Property ID_Image As Image
        Get
            Return mintIDImage
        End Get
        Set(value As Image)
            mintIDImage = value
        End Set
    End Property
    Public Shared Function ParseDLData(tf As TextBox) As scannedId
        Dim scID As New scannedId
        Dim I As Integer
        For I = 0 To tf.Lines.Count - 1
            If tf.Lines(I).Length > 2 Then
                ftype(tf.Lines(I).ToString, scID)

            End If
        Next
        Return scID
    End Function
    Public Shared Sub ftype(ByVal teststring As String, ByRef cust As scannedId)

        teststring = teststring.ToUpper.Trim

        Dim LD As String
        LD = teststring.Substring(0, 3)

        Select Case LD
            Case "DAC" 'First Name
                cust.FirstName = teststring.Substring(3)
            Case "DAD" 'middle name
                cust.MiddleName = teststring.Substring(3)
            Case "DCS" 'last name
                cust.LastName = teststring.Substring(3)
            Case "DCU" 'suffix (optional)
                cust.NameSuffix = teststring.Substring(3)
            Case "DAG" 'address 1
                cust.Address1 = teststring.Substring(3)
            Case "DAH" 'address 2  (optional)
                cust.Address2 = teststring.Substring(3)
            Case "DAI" 'city
                cust.City = teststring.Substring(3)
            Case "DAJ" 'state
                cust.State = teststring.Substring(3)
                cust.ID_State = teststring.Substring(3)
            Case "DAK" 'zip
                cust.Zip = teststring.Substring(3)
            Case "DAQ" 'id number
                cust.ID_Number = teststring.Substring(3)
            Case "DBA" 'id expiration date
                ' Dim expdate As String = teststring.Substring(3)
                ' Format(expdate,"D"
                'newCustomer.ID_Expiration_Date = teststring.Substring(3)
                Dim datestring As String = teststring.Substring(3)
                Dim mymonth As String = datestring.Chars(0) & datestring.Chars(1)
                Dim myday As String = datestring.Chars(2) & datestring.Chars(3)

                Dim myyear As String = datestring.Chars(4) & datestring.Chars(5) & datestring.Chars(6) & datestring.Chars(7)
                Dim expdate As String = String.Format("#{0}/{1}/{2}#", mymonth, myday, myyear)
                Dim newdate As Date = Convert.ToDateTime(expdate)
                cust.ID_Expiration_Date = newdate



                '   newCustomer.ID_Expiration_Date = CDate(teststring.Substring(3))
            Case "DBB" 'birthdate
                ' newCustomer.Birthdate = teststring.Substring(3)
                Dim datestring As String = teststring.Substring(3)
                Dim mymonth As String = datestring.Chars(0) & datestring.Chars(1)
                Dim myday As String = datestring.Chars(2) & datestring.Chars(3)

                Dim myyear As String = datestring.Chars(4) & datestring.Chars(5) & datestring.Chars(6) & datestring.Chars(7)
                Dim expdate As String = String.Format("#{0}/{1}/{2}#", mymonth, myday, myyear)
                Dim newdate As Date = Convert.ToDateTime(expdate)
                cust.Birthdate = newdate
            Case "DAW" 'weight   (optional)
                cust.Weight = teststring.Substring(3)
            Case "DAU" 'height
                cust.CusHeight = teststring.Substring(3)
            Case "DAY" 'eye color
                cust.EyeColor = teststring.Substring(3)
            Case "DAZ" 'Hair Color (optional)
                cust.HairColor = teststring.Substring(3)
            Case "DCL" 'Race        (optional)
                cust.Race = teststring.Substring(3)
            Case "DBC" 'sex
                cust.Sex = teststring.Substring(3)
            Case "ANS" 'Type of ID
                parseANSIline(teststring, cust)

                ' newScannedID.ID_Type = teststring.Substring(3)
        End Select

    End Sub
    Public Shared Sub parseANSIline(ByVal ANSILine As String, ByVal cust As scannedId)

        If ANSILine.Contains("DBA") Then
            Dim datestring As String = ANSILine.Substring(ANSILine.LastIndexOf("A") + 1, 8)
            Dim mymonth As String = datestring.Chars(0) & datestring.Chars(1)
            Dim myday As String = datestring.Chars(2) & datestring.Chars(3)

            Dim myyear As String = datestring.Chars(4) & datestring.Chars(5) & datestring.Chars(6) & datestring.Chars(7)
            Dim expdate As String = String.Format("#{0}/{1}/{2}#", mymonth, myday, myyear)
            Dim newdate As Date = Convert.ToDateTime(expdate)
            cust.ID_Expiration_Date = newdate
        End If
        If ANSILine.Contains("DL") Then
            cust.ID_Type = "DL"
        ElseIf ANSILine.Contains("ID") Then

            cust.ID_Type = "ID"
        End If

        ' End If
    End Sub
    Public Shared Function CorrectTypeOfBarCode(ByVal tf As TextBox) As Boolean
        Dim strTest As String = tf.Lines(0).ToString
        If strTest.Chars(0).ToString = "@" Then
            ' mboolScannedBarcode = True
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Sub Clear(ByVal cust As scannedId)
        With cust
            .FirstName = Nothing
            .MiddleName = Nothing
            .LastName = Nothing
            .NameSuffix = Nothing
            .Address1 = Nothing
            .Address2 = Nothing
            .City = Nothing
            .State = Nothing
            .Zip = Nothing
            .Birthdate = Nothing
            .Weight = Nothing
            .CusHeight = Nothing
            .EyeColor = Nothing
            .HairColor = Nothing
            .Race = Nothing
            .Sex = Nothing
            .ID_Type = Nothing
            .ID_State = Nothing
            .ID_Number = Nothing
            .ID_Expiration_Date = Nothing
        End With

    End Sub
    Public Function CustomerExists(ByVal ID_Number As String) As Boolean
        Dim strSelect As String = String.Format(" SELECT * FROM customer WHERE cust_id_number = '{0}';", ID_Number)

        Dim pg As New CyberClasses.PG
        Dim ds As New DataSet
        pg.ConnectToDB(strSelect, ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class

Public Enum IDTypes
    Drivers_License = 1
    ID_Card = 2
    Military_ID = 3
    Passport = 4
    Other = 5
End Enum
