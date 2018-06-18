Public Class ImageControls
    Private mintImageType As Integer
    Private mboolShowClearButton As Boolean
    Private mboolFinishedSavingImage As Boolean
    Private mboolAddedImage As Boolean

    Private mstrImageLoc As String
    Private mintImageID As Integer
    Private _ControlLabel As String



    Public Property ControlLabel As String
        Get
            Return _ControlLabel
        End Get
        Set(value As String)
            _ControlLabel = value
            lblControlLabel.Text = value
        End Set
    End Property
    Property IMGType As Integer
        Get
            Return mintImageType
        End Get
        Set(value As Integer)
            mintImageType = value
        End Set
    End Property

    Public Property ShowClearButton As Boolean
        Get
            Return mboolShowClearButton
        End Get
        Set(value As Boolean)
            mboolShowClearButton = value
            btnClearImage.Visible = ShowClearButton

        End Set
    End Property
    Public Property ImageLocation As String
        Get
            Return mstrImageLoc
        End Get
        Set(value As String)
            mstrImageLoc = value
            If value = Nothing Then
                pb1.Image = Nothing
            Else
                'Try
                pb1.Image = System.Drawing.Image.FromFile(mstrImageLoc)

                ' processImage(mstrImageLoc)
                '  BGSave.RunWorkerAsync()
                AddedImage = True
                '''processImage(mstrImageLoc)
                ' Catch ex As Exception

                ' End Try

            End If

        End Set
    End Property

    Public Property imageId As Integer
        Get
            Return mintImageID
        End Get
        Set(value As Integer)
            mintImageID = value
        End Set
    End Property
    Public Property FinishedSavingImage As Boolean
        Get
            Return mboolFinishedSavingImage
        End Get
        Set(value As Boolean)
            mboolFinishedSavingImage = value
        End Set
    End Property
    Public Property AddedImage As Boolean
        Get
            Return mboolAddedImage
        End Get
        Set(value As Boolean)
            mboolAddedImage = value
        End Set
    End Property

    '''Private Sub processImage(ByRef loc As String)       'Altered This to prevent saving image to DB, and instead : save the image location to the db only for later processing.
    '''    'TODO: Setup image processing for Batched sets taken from the database when usage is nill
    '''    AddedImage = True

    '''    ' Dim img As New CyberAddins.ImageProcessing(False, IMGType, loc)
    '''    ' Dim imageid As Integer
    '''    Dim img As New CyberAddins.TempImageProcessing(loc, IMGType.ToString)
    '''    imageId = img.ID
    '''    If imageId > -1 Then
    '''        FinishedSavingImage = True
    '''    Else
    '''        FinishedSavingImage = False
    '''    End If
    '''End Sub
    Private Sub pb1_Paint(sender As Object, e As PaintEventArgs) Handles pb1.Paint
        If pb1.Image IsNot Nothing Then
            'ShowAddButton = True
            ShowClearButton = True
        Else
            ' ShowAddButton = False
            ShowClearButton = False

        End If
    End Sub


    Private Sub CameraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CameraToolStripMenuItem.Click
        Dim camera As New CaptureCameraImage
        With camera
            .ShowDialog()
            ImageLocation = camera.NewImagePath

        End With

        'TakeNewPhoto()
    End Sub
    'TODO: Implement Take New Photo Form
    ''Private Sub TakeNewPhoto()
    ''    Dim imgcapture As New frmCaptureImage
    ''    With imgcapture
    ''        .StartPosition = FormStartPosition.CenterScreen
    ''        .WindowState = FormWindowState.Maximized
    ''        .IMGType = IMGType
    ''        .ShowDialog()
    ''        If .mboolIMGCanceled = False Then
    ''            ImageLocation = .tempFilePath
    ''        Else
    ''            ImageLocation = Nothing
    ''        End If
    ''    End With
    ''End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnClearImage.Click
        pb1.Image = Nothing
    End Sub

    Private Sub pb1_Click(sender As Object, e As EventArgs) Handles pb1.Click
        If pb1.Image IsNot Nothing Then
            Dim prev As New frmImagePopup
            With prev
                .pic = pb1.Image
                .Show()

            End With
        End If
    End Sub

    Private Sub BGSave_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGSave.DoWork

    End Sub

    Private Sub BGSave_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGSave.RunWorkerCompleted
        If FinishedSavingImage = True Then
            MessageBox.Show("Processing Image Complete")

        End If

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ScannerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScannerToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("c:\windows\system32\wiaacmgr.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilesToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog
        With ofd
            If .ShowDialog() = DialogResult.OK Then
                If .FileName <> Nothing Then
                    ImageLocation = .FileName

                End If
            End If

        End With
    End Sub
End Class
