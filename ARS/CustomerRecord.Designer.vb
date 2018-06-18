<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFName = New ARS.CustomTextboxControl()
        Me.txtLName = New ARS.CustomTextboxControl()
        Me.txtAddress = New ARS.CustomTextboxControl()
        Me.txtCity = New ARS.CustomTextboxControl()
        Me.txtState = New ARS.CustomTextboxControl()
        Me.txtZip = New ARS.CustomTextboxControl()
        Me.txtDLNo = New ARS.CustomTextboxControl()
        Me.txtPhone = New ARS.CustomTextboxControl()
        Me.SuspendLayout()
        '
        'txtFName
        '
        Me.txtFName.labeltext = "First Name"
        Me.txtFName.Location = New System.Drawing.Point(33, 25)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(189, 40)
        Me.txtFName.TabIndex = 0
        '
        'txtLName
        '
        Me.txtLName.labeltext = "Last Name"
        Me.txtLName.Location = New System.Drawing.Point(228, 25)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(189, 40)
        Me.txtLName.TabIndex = 0
        '
        'txtAddress
        '
        Me.txtAddress.labeltext = "Address"
        Me.txtAddress.Location = New System.Drawing.Point(33, 62)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(384, 40)
        Me.txtAddress.TabIndex = 1
        '
        'txtCity
        '
        Me.txtCity.labeltext = "City"
        Me.txtCity.Location = New System.Drawing.Point(35, 106)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(123, 40)
        Me.txtCity.TabIndex = 2
        '
        'txtState
        '
        Me.txtState.labeltext = "State"
        Me.txtState.Location = New System.Drawing.Point(164, 106)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(123, 40)
        Me.txtState.TabIndex = 2
        '
        'txtZip
        '
        Me.txtZip.labeltext = "Zip"
        Me.txtZip.Location = New System.Drawing.Point(294, 106)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(123, 40)
        Me.txtZip.TabIndex = 2
        '
        'txtDLNo
        '
        Me.txtDLNo.labeltext = "Drivers License No"
        Me.txtDLNo.Location = New System.Drawing.Point(35, 152)
        Me.txtDLNo.Name = "txtDLNo"
        Me.txtDLNo.Size = New System.Drawing.Size(382, 40)
        Me.txtDLNo.TabIndex = 2
        '
        'txtPhone
        '
        Me.txtPhone.labeltext = "Telephone Number"
        Me.txtPhone.Location = New System.Drawing.Point(35, 198)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(382, 40)
        Me.txtPhone.TabIndex = 2
        '
        'CustomerRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 281)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtDLNo)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.txtAddress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CustomerRecord"
        Me.Text = "CustomerRecord"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtFName As CustomTextboxControl
    Friend WithEvents txtLName As CustomTextboxControl
    Friend WithEvents txtAddress As CustomTextboxControl
    Friend WithEvents txtCity As CustomTextboxControl
    Friend WithEvents txtState As CustomTextboxControl
    Friend WithEvents txtZip As CustomTextboxControl
    Friend WithEvents txtDLNo As CustomTextboxControl
    Friend WithEvents txtPhone As CustomTextboxControl
End Class
