Public Class NewCustomerForm
    Private _newcus As scannedId

    Public Property NewCus As scannedId
        Get
            Return _newcus
        End Get
        Set(value As scannedId)
            _newcus = value
        End Set
    End Property
    Private Sub NewCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dim main As MainForm = CType(Me.MdiParent, MainForm)





        If NewCus IsNot Nothing Then
            LoadScannedCustomerData()
        End If
    End Sub

    Private Sub LoadScannedCustomerData()
        With NewCus
            txtCusFName.Text = .FirstName
            txtCusMI.Text = .MiddleName
            txtCusLName.Text = .LastName
            txtCusSuffixName.Text = .NameSuffix
            txtCusAddress1.Text = .Address1
            txtCusAddress2.Text = .Address2
            txtCusCity.Text = .City
            txtCusState.Text = .State
            txtCusZip.Text = .Zip
            dtpBirthdate.Value = .Birthdate.Date
            txtWeight.Text = .Weight
            txtHeight.Text = .CusHeight
            txtEyeColor.Text = .EyeColor
            txtHairColor.Text = .HairColor
            txtSex.Text = .Sex
            txtRace.Text = .Race
            cboIDType.Text = .ID_Type
            txtIDNumber.Text = .ID_Number
            txtIDState.Text = .ID_State
            dtpIDExpiration.Value = .ID_Expiration_Date.Date



        End With
    End Sub
End Class