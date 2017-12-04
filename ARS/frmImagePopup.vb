Public Class frmImagePopup
    Dim mstrImageLocation As String
    Dim mypic As Image


    Property MyImage As String
        Get
            Return mstrImageLocation
        End Get
        Set(value As String)
            mstrImageLocation = value
            If value <> Nothing Then
                PictureBox1.Image = System.Drawing.Image.FromFile(value)
            Else
                PictureBox1.Image = Nothing
            End If
        End Set
    End Property
    Public Property pic As Image
        Get
            Return mypic
        End Get
        Set(value As Image)
            mypic = value
            PictureBox1.Image = value
        End Set
    End Property

    Private Sub frmImagePopup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        PictureBox1.Image.Dispose()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub frmImagePopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class