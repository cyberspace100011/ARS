Public Class NewCustomerForm
    Private _newcus As scannedId
    Private _existingCustomer As Boolean
    Private nc2 As Customer



    Public Property NewCus As scannedId
        Get
            Return _newcus
        End Get
        Set(value As scannedId)
            _newcus = value
        End Set
    End Property
    Public Property ExistingCustomer As Boolean
        Get
            Return _existingCustomer
        End Get
        Set(value As Boolean)
            _existingCustomer = value
        End Set
    End Property

    Private Sub NewCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub txtCusTelephone_Click(sender As Object, e As EventArgs) Handles txtCusTelephone.Click
        txtCusTelephone.SelectionStart = 0
    End Sub

    Private Sub txtEmpTelephone_Click(sender As Object, e As EventArgs) Handles txtEmpTelephone.Click
        txtEmpTelephone.SelectionStart = 0
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ExistingCustomer = False Then

            SaveNewCustomer(nc2)

        Else
            ' If MessageBox.Show("This Customer Record already exists, Would you like to see the Update Customer View?", "Update Customer", "Update Customer Record?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0) = DialogResult.Yes Then
            If MessageBox.Show("Customer Record Already Exists", "Update Record?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                MessageBox.Show("Open up the Customer Record Update Form")
            End If

        End If
    End Sub

    Private Sub SaveNewCustomer(ByRef nc As Customer)
        '1) Create a new Customer object
        nc = New Customer(txtCusLName.Text, txtCusFName.Text, txtCusAddress1.Text, txtCusCity.Text, txtCusState.Text, txtCusZip.Text, txtCusTelephone.Text, NewCus.ID_Type, txtIDState.Text, txtIDNumber.Text,
                               dtpIDExpiration.Value, dtpBirthdate.Value, CInt(txtWeight.Text), txtHeight.Text, txtEyeColor.Text, txtHairColor.Text, txtSex.Text, txtCusSuffixName.Text, txtRace.Text, txtCusMI.Text,
                               txtCusAddress2.Text, txtNotes.Text,,,,,)


        '2) Save the new customer using Classes I have already created
        nc.SaveCustomerToDatabase(nc)
        ' MessageBox.Show("Success")
        Me.Close()


    End Sub
End Class