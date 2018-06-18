Public Class CaptureCameraImage

    Private _NewImagePath As String


    Public Property NewImagePath As String
        Get
            Return _NewImagePath
        End Get
        Set(value As String)
            _NewImagePath = value
        End Set
    End Property


    Private Sub CaptureCameraImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With VideoGrabber1
            .LicenseString = "18531899108803084-cybertek"
            .StartPreview()
        End With
    End Sub
    Private Function GenerateNewImageFilename() As String
        Dim filecount As Integer = System.IO.Directory.GetFiles(My.Settings.tempFolder).Count
        GenerateNewImageFilename = My.Settings.tempFolder & "\IMG-" & filecount.ToString & ".jpg"
        Return GenerateNewImageFilename
    End Function

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        SaveImage()
    End Sub

    Private Sub SaveImage()
        NewImagePath = GenerateNewImageFilename()
        VideoGrabber1.CaptureFrameTo(VidGrab.TFrameCaptureDest.fc_JpegFile, NewImagePath)

    End Sub

    Private Sub VideoGrabber1_OnFrameCaptureCompleted(sender As Object, e As VidGrab.TOnFrameCaptureCompletedEventArgs) Handles VideoGrabber1.OnFrameCaptureCompleted
        'e.fileName = NewImage.GenerateNewImageFilename
        'NewImage.Path = NewImagePath
        VideoGrabber1.Dispose()

        Me.Close()


    End Sub
End Class