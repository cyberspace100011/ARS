Public Class CustomTextboxControl
    Private _labeltext As String

    Public Property labeltext As String
        Get
            Return _labeltext
        End Get
        Set(value As String)
            _labeltext = value
            TextBoxLabel.Text = value
        End Set
    End Property


    Private Sub CustomTextboxControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
