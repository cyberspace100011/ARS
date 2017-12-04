Module modARS
#Region "Image Processing"
    Public Sub SaveImage(ByVal ImageID As String, ByVal ImageClass As Int32, ByVal transno As String, ByVal ItemNo As String, ByVal pictureID As String, ByVal pb As PictureBox, ByVal ds As DataSet, ByVal da As OleDb.OleDbDataAdapter)

        Dim ImagePath As String = ""
        'imagename breakdown - "IMG_<Image Code>_<leadsOnline Store ID>_<transaction date>_<transaction #>_<Item #>_<pictureID>.<Extension>
        Dim strStoreID As String = My.Settings.strStoreIDLeadsOnline.ToString
        Dim strTransDate As String = Format(Now(), "yyyyMMdd")
        Dim strExtension As String = "jpg"
        Dim strTransNo As String = transno
        Dim strItemNo As String = ItemNo
        Dim strPictureID As String = pictureID
        Dim strDirectory As String = ""
        Dim strCode As String = ""

        Select Case ImageClass
            Case 1  '1 - Customer Photo - CFY
                'Customer, Front, Unknown Transaction Type)
                strCode = "CFY"
                strDirectory = "Z:\DataNest\Customer\Photo"
            Case 2  '2 - Identification - INY
                'ID (Drivers Lic etc), Position unknown or unspecified, Unknown transaction type)
                strCode = "INY"
                strDirectory = "Z:\DataNest\Customer\DL"

            Case 3  '3 -Customer Signature (Customer Signature) - SNY
                'Signature, Unknown or unspec positon, Unknown transaction tupe)
                strCode = "SNY"
                strDirectory = "Z:\DataNest\Customer\Sig"
            Case 4  '4 - Special License (Professional licenses or permits) - (Not Used By LO, Internal Coding is just SL)
                'No codes needed beyond internal SL (Special Licenses) as Leads online doesn't use this type of image
                strCode = "SL"
                strDirectory = "Z:\DataNest\Customer\Licenses"
            Case 5  '5 - Special Documents (Fire Reports, police reports, or receipts for purchases ie wire, etc) -(Not Used by LO, Internal Code is  SD)
                'No codes needed beyond internal SD (Special Documents) as Leads online doesn't use this type of image
                strCode = "SD"
                strDirectory = "Z:\DataNest\Customer\Docs"
            Case 6  '6 - Vehicle or Trailer image - VNY 
                'Vehicle (Or Trailer), Position unknown or not supplied, unknown transaction type
                strCode = "VNY"
                strDirectory = "Z:\DataNest\Customer\transport"
            Case 7  '7 - License Plate Image - LBY
                'License plate, from Behind, Unknown transaction type
                strCode = "LBY"
                strDirectory = "Z:\DataNest\Customer\Licenses"
            Case 8  '8 - property image (Materials that you purchase) - ANB
                'Article Image (Item being purchased etc), Position not supplied, Buy is the type of transaction 
                strCode = "ANB"
                strDirectory = "Z:\DataNest\Tickets\Materials"
            Case 9     '3 - Ticket Signature (Ticket Signature) - SNB
                'Signature, Unknown or unspec positon, Buy is the transaction tupe)
                strCode = "SNB"
                strDirectory = "Z:\DataNest\Tickets\Sig"

        End Select

        ImagePath = String.Format("{7}\IMG_{5}_{0}_{1}_{2}_{3}_{4}.{6}", strStoreID, strTransDate, strTransNo, strItemNo, strPictureID, strCode, strExtension, strDirectory)
        pb.Image.Save(ImagePath)
        da.Fill(ds)
        Dim id As Integer = (CInt(ds.Tables(0).Rows.Item(ds.Tables(0).Rows.Count - 1).Item("ID").ToString)) + 1
        Dim myimage As DataRow = ds.Tables(0).NewRow
        myimage("ID") = id
        myimage("image_type") = ImageClass
        myimage("image_path") = ImagePath
        ds.Tables(0).Rows.Add(myimage)
        da.Update(ds)

    End Sub
    Public Sub LoadImage(ByVal ImageId As String, ByVal pb As PictureBox, ByVal ds As DataSet, ByVal da As OleDb.OleDbDataAdapter)
        Dim strOrigImageSelCommandFilter As String = da.SelectCommand.CommandText
        Dim strNewSelectCommand As String = String.Format("{0} WHERE  (ID = {1})", strOrigImageSelCommandFilter, ImageId)
        da.SelectCommand.CommandText = strNewSelectCommand
        da.Fill(ds)
        If ds.Tables(0).Rows.Count = 1 Then
            '   Debug.WriteLine(ds.Tables(0).Rows.Item(0).Item("Image_path").ToString)

            pb.Image = Image.FromFile(ds.Tables(0).Rows.Item(0).Item("image_path").ToString)
        End If
        da.SelectCommand.CommandText = strOrigImageSelCommandFilter
        ds.Clear()
    End Sub

#End Region
#Region "Shared Functions"
    Public Function TicketNumber(ByVal ds As DataSet, ByVal da As OleDb.OleDbDataAdapter) As Int32
        da.Fill(ds, 0, 1, "tickets")
        Dim ticketno As Int32
        If ds.Tables("tickets").Rows.Count = 0 Then
            ticketno = 1
        Else
            ticketno = CInt(ds.Tables("tickets").Rows.Item(0).Item("ticket_number")) + 1
        End If
        Return ticketno
    End Function

#End Region
#Region "Shared Subs"
    Public Sub LoadCustomerInfo(ByVal dsCustomer As DataSet, ByVal daCustomer As OleDb.OleDbDataAdapter, ByVal strCustomerID As String, ByVal CusCompany As Label, ByVal CusFName As Label, ByVal CusMI As Label, _
                                ByVal CusLName As Label)

        'cusPhotoPath As String, cusSignature As String, cusSignatureImage As String, _
        'cusIDPath As String)

        Dim strOrigCusSelectCommandText As String = daCustomer.SelectCommand.CommandText
        Dim strSelectCommand As String = String.Format("{0} WHERE (cust_id = '{1}')", strOrigCusSelectCommandText, strCustomerID)
        daCustomer.SelectCommand.CommandText = strSelectCommand
        daCustomer.Fill(dsCustomer)
        If dsCustomer.Tables(0).Rows.Count = 1 Then
            With dsCustomer.Tables(0).Rows.Item(0)
                If .Item("cust_nm_last") Is System.DBNull.Value Then
                    CusLName.Text = ""
                Else
                    CusLName.Text = .Item("cust_nm_last").ToString
                End If

                If .Item("cust_nm_first") Is System.DBNull.Value Then
                    CusFName.Text = ""
                Else
                    CusFName.Text = .Item("cust_nm_first").ToString
                End If

                If .Item("cust_nm_middle") Is System.DBNull.Value Then
                    CusMI.Text = ""

                Else
                    CusMI.Text = .Item("cust_nm_middle").ToString
                End If

                'If .Item("cust_addr1") Is System.DBNull.Value Then
                '    CusAddress1.Clear()
                'Else
                '    CusAddress1.Text = .Item("cust_addr1").ToString
                'End If

                'If .Item("cust_city") Is System.DBNull.Value Then
                '    CusCity.Clear()
                'Else
                '    CusCity.Text = .Item("cust_city").ToString
                'End If

                'If .Item("cust_state") Is System.DBNull.Value Then
                '    CusState.Clear()
                'Else
                '    CusState.Text = .Item("cust_state").ToString
                'End If

                'If .Item("cust_zip") Is System.DBNull.Value Then
                '    cusZip.Clear()
                'Else
                '    cusZip.Text = .Item("cust_zip").ToString
                'End If

                'If .Item("employer_nm") Is System.DBNull.Value Then
                '    CusCompany.Clear()
                'Else
                '    CusCompany.Text = .Item("employer_nm").ToString
                'End If
                'If .Item("cust_photo") Is System.DBNull.Value Then
                '    cusPhoto.Image = Nothing
                'Else
                '    LoadImage(.Item("cust_photo").ToString, cusPhoto, dsImage, daImage)
                'End If
                'If .Item("cust_dl") Is System.DBNull.Value Then
                '    IDImage.Image = Nothing
                'Else
                '    LoadImage(.Item("cust_dl").ToString, IDImage, dsImage, daImage)
                'End If
                'If .Item("Cust_sig") Is System.DBNull.Value Then
                '    CusSignature.Image = Nothing
                'Else
                '    LoadImage(.Item("Cust_sig").ToString, CusSignature, dsImage, daImage)
                'End If
                'daCustomer.SelectCommand.CommandText = strOrigCusSelectCommandText


            End With
        End If

    End Sub
    Public Sub LoadCustomerRecord(ByVal dsCustomer As DataSet, ByVal daCustomer As OleDb.OleDbDataAdapter, ByVal strCustomerID As String, ByVal CusFName As TextBox, ByVal CusMI As TextBox, _
                            ByVal CusLName As TextBox, ByVal CusAddress1 As TextBox, ByVal CusAddress2 As TextBox, ByVal CusCity As TextBox, ByVal CusState As TextBox, _
                           ByVal cusZip As TextBox, ByVal cusDLNumber As TextBox, ByVal cusBday As TextBox, ByVal cusSex As TextBox, ByVal cusHeight As TextBox, ByVal cusWeight As TextBox, _
                           ByVal cusEyeColor As TextBox, ByVal cusIDType As TextBox, ByVal cusIDExpDate As TextBox, ByVal cusIDState As TextBox, _
                           ByVal IDImage As PictureBox, ByVal cusPhoto As PictureBox, ByVal CusSignature As PictureBox, ByVal dsImage As DataSet, ByVal daImage As OleDb.OleDbDataAdapter)

        'cusPhotoPath As String, cusSignature As String, cusSignatureImage As String, _
        'cusIDPath As String)

        Dim strOrigCusSelectCommandText As String = daCustomer.SelectCommand.CommandText
        Dim strSelectCommand As String = String.Format("{0} WHERE (cust_id = '{1}')", strOrigCusSelectCommandText, strCustomerID)
        daCustomer.SelectCommand.CommandText = strSelectCommand
        daCustomer.Fill(dsCustomer)
        If dsCustomer.Tables(0).Rows.Count = 1 Then
            With dsCustomer.Tables(0).Rows.Item(0)
                If .Item("cust_nm_last") Is System.DBNull.Value Then
                    CusLName.Clear()
                Else
                    CusLName.Text = .Item("cust_nm_last").ToString
                End If

                If .Item("cust_nm_first") Is System.DBNull.Value Then
                    CusFName.Clear()
                Else
                    CusFName.Text = .Item("cust_nm_first").ToString
                End If

                If .Item("cust_nm_middle") Is System.DBNull.Value Then
                    CusMI.Clear()
                Else
                    CusMI.Text = .Item("cust_nm_middle").ToString
                End If

                If .Item("cust_addr1") Is System.DBNull.Value Then
                    CusAddress1.Clear()
                Else
                    CusAddress1.Text = .Item("cust_addr1").ToString
                End If

                If .Item("cust_city") Is System.DBNull.Value Then
                    CusCity.Clear()
                Else
                    CusCity.Text = .Item("cust_city").ToString
                End If

                If .Item("cust_state") Is System.DBNull.Value Then
                    CusState.Clear()
                Else
                    CusState.Text = .Item("cust_state").ToString
                End If

                If .Item("cust_zip") Is System.DBNull.Value Then
                    cusZip.Clear()
                Else
                    cusZip.Text = .Item("cust_zip").ToString
                End If

                If .Item("cust_id_type") Is System.DBNull.Value Then
                    cusIDType.Clear()
                Else
                    cusIDType.Text = .Item("cust_id_type").ToString
                End If

                If .Item("cust_id_state") Is System.DBNull.Value Then
                    cusIDState.Clear()
                Else
                    cusIDState.Text = .Item("cust_id_state").ToString
                End If

                If .Item("cust_id_number") Is System.DBNull.Value Then
                    cusDLNumber.Clear()
                Else
                    cusDLNumber.Text = .Item("cust_id_number").ToString
                End If

                If .Item("cust_id_exp") Is System.DBNull.Value Then
                    cusIDExpDate.Clear()
                Else
                    cusIDExpDate.Text = .Item("cust_id_exp").ToString
                End If

                'If .Item("cust_race") Is System.DBNull.Value Then
                '    cusRace.Clear()
                'Else
                '    cusRace.Text = .Item("cust_race").ToString
                'End If

                If .Item("cust_birthdate") Is System.DBNull.Value Then
                    cusBday.Clear()
                Else
                    cusBday.Text = .Item("cust_birthdate").ToString
                End If

                If .Item("cust_sex") Is System.DBNull.Value Then
                    cusSex.Clear()
                Else
                    cusSex.Text = .Item("cust_sex").ToString
                End If

                If .Item("cust_height") Is System.DBNull.Value Then
                    cusHeight.Clear()
                Else
                    cusHeight.Text = .Item("cust_height").ToString
                End If

                If .Item("cust_eye") Is System.DBNull.Value Then
                    cusEyeColor.Clear()
                Else
                    cusEyeColor.Text = .Item("cust_eye").ToString
                End If

                'If .Item("cust_hair") Is System.DBNull.Value Then
                '    cushairColor.Clear()
                'Else
                '    cushairColor.Text = .Item("cust_hair").ToString
                'End If


                If .Item("cust_photo") Is System.DBNull.Value Then
                    cusPhoto.Image = Nothing
                Else
                    LoadImage(.Item("cust_photo").ToString, cusPhoto, dsImage, daImage)
                End If
                If .Item("cust_dl") Is System.DBNull.Value Then
                    IDImage.Image = Nothing
                Else
                    LoadImage(.Item("cust_dl").ToString, IDImage, dsImage, daImage)
                End If
                If .Item("Cust_sig") Is System.DBNull.Value Then
                    CusSignature.Image = Nothing
                Else
                    LoadImage(.Item("Cust_sig").ToString, CusSignature, dsImage, daImage)
                End If
                daCustomer.SelectCommand.CommandText = strOrigCusSelectCommandText
            End With

        End If

    End Sub
    Public Sub UpdateScannedRecord(ByVal dsCustomer As DataSet, ByVal daCustomer As OleDb.OleDbDataAdapter, ByVal strCustomerID As String, ByVal scannedCustomer As scannedId)

        Dim strOrigCusSelectCommandText As String = daCustomer.SelectCommand.CommandText
        Dim strSelectCommand As String = String.Format("{0} WHERE (cust_id = '{1}')", strOrigCusSelectCommandText, strCustomerID)
        daCustomer.SelectCommand.CommandText = strSelectCommand
        daCustomer.Fill(dsCustomer)
        If dsCustomer.Tables(0).Rows.Count = 1 Then
            With dsCustomer.Tables(0).Rows.Item(0)
                .Item("cust_nm_last") = ARS.frmMain.scannedCustomer.LastName
                .Item("cust_nm_first") = ARS.frmMain.scannedCustomer.FirstName
                .Item("cust_nm_middle") = ARS.frmMain.scannedCustomer.MiddleName
                .Item("cust_addr1") = ARS.frmMain.scannedCustomer.Address1
                .Item("cust_addr2") = ARS.frmMain.scannedCustomer.Address2
                .Item("cust_city") = ARS.frmMain.scannedCustomer.City
                .Item("cust_state") = ARS.frmMain.scannedCustomer.State
                .Item("cust_zip") = ARS.frmMain.scannedCustomer.Zip
                .Item("cust_id_type") = ARS.frmMain.scannedCustomer.ID_Type
                .Item("cust_id_state") = ARS.frmMain.scannedCustomer.ID_State
                .Item("cust_id_number") = ARS.frmMain.scannedCustomer.ID_Number
                .Item("cust_id_exp") = ARS.frmMain.scannedCustomer.ID_Expiration_Date
                .Item("cust_birthdate") = ARS.frmMain.scannedCustomer.Birthdate
                .Item("cust_sex") = ARS.frmMain.scannedCustomer.Sex
                .Item("cust_height") = ARS.frmMain.scannedCustomer.CusHeight
                .Item("cust_eye") = ARS.frmMain.scannedCustomer.EyeColor
                daCustomer.Update(dsCustomer)

            End With
        End If

    End Sub
    Public Sub numbersOnly(ByVal textbox As TextBox)
        If IsNumeric(textbox.Text) Then
        Else
            SendKeys.Send("{BACKSPACE}")
        End If
    End Sub
 
#End Region

End Module
