<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaptureCameraImage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CaptureCameraImage))
        Me.VideoGrabber1 = New VidGrab.VideoGrabber()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VideoGrabber1
        '
        Me.VideoGrabber1.AdjustOverlayAspectRatio = True
        Me.VideoGrabber1.AdjustPixelAspectRatio = True
        Me.VideoGrabber1.Aero = VidGrab.TAero.ae_Default
        Me.VideoGrabber1.AnalogVideoStandard = -1
        Me.VideoGrabber1.ApplicationPriority = VidGrab.TApplicationPriority.ap_default
        Me.VideoGrabber1.ASFAudioBitRate = -1
        Me.VideoGrabber1.ASFAudioChannels = -1
        Me.VideoGrabber1.ASFBufferWindow = -1
        Me.VideoGrabber1.ASFDeinterlaceMode = VidGrab.TASFDeinterlaceMode.adm_NotInterlaced
        Me.VideoGrabber1.ASFFixedFrameRate = True
        Me.VideoGrabber1.ASFMediaServerPublishingPoint = ""
        Me.VideoGrabber1.ASFMediaServerRemovePublishingPointAfterDisconnect = False
        Me.VideoGrabber1.ASFMediaServerTemplatePublishingPoint = ""
        Me.VideoGrabber1.ASFNetworkMaxUsers = 5
        Me.VideoGrabber1.ASFNetworkPort = 0
        Me.VideoGrabber1.ASFProfile = -1
        Me.VideoGrabber1.ASFProfileFromCustomFile = ""
        Me.VideoGrabber1.ASFProfileVersion = VidGrab.TASFProfileVersion.apv_ProfileVersion_8
        Me.VideoGrabber1.ASFVideoBitRate = -1
        Me.VideoGrabber1.ASFVideoFrameRate = 0R
        Me.VideoGrabber1.ASFVideoHeight = -1
        Me.VideoGrabber1.ASFVideoMaxKeyFrameSpacing = -1
        Me.VideoGrabber1.ASFVideoQuality = 80
        Me.VideoGrabber1.ASFVideoWidth = -1
        Me.VideoGrabber1.AspectRatioToUse = -1.0R
        Me.VideoGrabber1.AssociateAudioAndVideoDevices = False
        Me.VideoGrabber1.AudioBalance = 0
        Me.VideoGrabber1.AudioChannelRenderMode = VidGrab.TAudioChannelRenderMode.acrm_Normal
        Me.VideoGrabber1.AudioCompressor = 0
        Me.VideoGrabber1.AudioDevice = -1
        Me.VideoGrabber1.AudioDeviceRendering = False
        Me.VideoGrabber1.AudioFormat = VidGrab.TAudioFormat.af_default
        Me.VideoGrabber1.AudioInput = -1
        Me.VideoGrabber1.AudioInputBalance = 0
        Me.VideoGrabber1.AudioInputLevel = 65535
        Me.VideoGrabber1.AudioInputMono = False
        Me.VideoGrabber1.AudioPeakEvent = False
        Me.VideoGrabber1.AudioRecording = False
        Me.VideoGrabber1.AudioRenderer = -1
        Me.VideoGrabber1.AudioSource = VidGrab.TAudioSource.as_Default
        Me.VideoGrabber1.AudioStreamNumber = -1
        Me.VideoGrabber1.AudioSyncAdjustment = 0
        Me.VideoGrabber1.AudioSyncAdjustmentEnabled = False
        Me.VideoGrabber1.AudioVolume = 32767
        Me.VideoGrabber1.AutoConnectRelatedPins = True
        Me.VideoGrabber1.AutoFileName = VidGrab.TAutoFileName.fn_Sequential
        Me.VideoGrabber1.AutoFileNameDateTimeFormat = "yymmdd_hhmmss_zzz"
        Me.VideoGrabber1.AutoFileNameMinDigits = 6
        Me.VideoGrabber1.AutoFilePrefix = "vg"
        Me.VideoGrabber1.AutoRefreshPreview = False
        Me.VideoGrabber1.AutoStartPlayer = True
        Me.VideoGrabber1.AVIDurationUpdated = True
        Me.VideoGrabber1.AVIFormatOpenDML = True
        Me.VideoGrabber1.AVIFormatOpenDMLCompatibilityIndex = True
        Me.VideoGrabber1.BackColor = System.Drawing.Color.DarkGray
        Me.VideoGrabber1.BackgroundColor = 0
        Me.VideoGrabber1.BufferCount = -1
        Me.VideoGrabber1.BurstCount = 3
        Me.VideoGrabber1.BurstInterval = 0
        Me.VideoGrabber1.BurstMode = False
        Me.VideoGrabber1.BurstType = VidGrab.TFrameCaptureDest.fc_TBitmap
        Me.VideoGrabber1.BusyCursor = VidGrab.TCursors.cr_HourGlass
        Me.VideoGrabber1.CameraControlSettings = True
        Me.VideoGrabber1.CaptureFileExt = ""
        Me.VideoGrabber1.ColorKey = 1048592
        Me.VideoGrabber1.ColorKeyEnabled = False
        Me.VideoGrabber1.CompressionMode = VidGrab.TCompressionMode.cm_NoCompression
        Me.VideoGrabber1.CompressionType = VidGrab.TCompressionType.ct_Video
        Me.VideoGrabber1.Cropping_Enabled = False
        Me.VideoGrabber1.Cropping_Height = 120
        Me.VideoGrabber1.Cropping_Outbounds = True
        Me.VideoGrabber1.Cropping_Width = 160
        Me.VideoGrabber1.Cropping_X = 0
        Me.VideoGrabber1.Cropping_Y = 0
        Me.VideoGrabber1.Cropping_Zoom = 1.0R
        Me.VideoGrabber1.Display_Active = True
        Me.VideoGrabber1.Display_AlphaBlendEnabled = False
        Me.VideoGrabber1.Display_AlphaBlendValue = 180
        Me.VideoGrabber1.Display_AspectRatio = VidGrab.TAspectRatio.ar_Stretch
        Me.VideoGrabber1.Display_AutoSize = False
        Me.VideoGrabber1.Display_Embedded = True
        Me.VideoGrabber1.Display_FullScreen = False
        Me.VideoGrabber1.Display_Height = 240
        Me.VideoGrabber1.Display_Left = 10
        Me.VideoGrabber1.Display_Monitor = 0
        Me.VideoGrabber1.Display_MouseMovesWindow = True
        Me.VideoGrabber1.Display_PanScanRatio = 50
        Me.VideoGrabber1.Display_StayOnTop = False
        Me.VideoGrabber1.Display_Top = 10
        Me.VideoGrabber1.Display_TransparentColorEnabled = False
        Me.VideoGrabber1.Display_TransparentColorValue = 255
        Me.VideoGrabber1.Display_VideoPortEnabled = True
        Me.VideoGrabber1.Display_Visible = True
        Me.VideoGrabber1.Display_Width = 320
        Me.VideoGrabber1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoGrabber1.DoubleBuffered = False
        Me.VideoGrabber1.DroppedFramesPollingInterval = -1
        Me.VideoGrabber1.DualDisplay_Active = False
        Me.VideoGrabber1.DualDisplay_AlphaBlendEnabled = False
        Me.VideoGrabber1.DualDisplay_AlphaBlendValue = 180
        Me.VideoGrabber1.DualDisplay_AspectRatio = VidGrab.TAspectRatio.ar_Stretch
        Me.VideoGrabber1.DualDisplay_AutoSize = False
        Me.VideoGrabber1.DualDisplay_Embedded = False
        Me.VideoGrabber1.DualDisplay_FullScreen = False
        Me.VideoGrabber1.DualDisplay_Height = 240
        Me.VideoGrabber1.DualDisplay_Left = 20
        Me.VideoGrabber1.DualDisplay_Monitor = 0
        Me.VideoGrabber1.DualDisplay_MouseMovesWindow = True
        Me.VideoGrabber1.DualDisplay_PanScanRatio = 50
        Me.VideoGrabber1.DualDisplay_StayOnTop = False
        Me.VideoGrabber1.DualDisplay_Top = 400
        Me.VideoGrabber1.DualDisplay_TransparentColorEnabled = False
        Me.VideoGrabber1.DualDisplay_TransparentColorValue = 255
        Me.VideoGrabber1.DualDisplay_VideoPortEnabled = False
        Me.VideoGrabber1.DualDisplay_Visible = True
        Me.VideoGrabber1.DualDisplay_Width = 320
        Me.VideoGrabber1.DVDateTimeEnabled = True
        Me.VideoGrabber1.DVDiscontinuityMinimumInterval = 3
        Me.VideoGrabber1.DVDTitle = 0
        Me.VideoGrabber1.DVEncoder_VideoFormat = VidGrab.TDVVideoFormat.dvf_DVSD
        Me.VideoGrabber1.DVEncoder_VideoResolution = VidGrab.TDVSize.dv_Full
        Me.VideoGrabber1.DVEncoder_VideoStandard = VidGrab.TDVVideoStandard.dvs_Default
        Me.VideoGrabber1.DVRecordingInNativeFormatSeparatesStreams = False
        Me.VideoGrabber1.DVReduceFrameRate = False
        Me.VideoGrabber1.DVRgb219 = False
        Me.VideoGrabber1.DVTimeCodeEnabled = True
        Me.VideoGrabber1.EventNotificationSynchrone = True
        Me.VideoGrabber1.FixFlickerOrBlackCapture = False
        Me.VideoGrabber1.FrameCaptureHeight = -1
        Me.VideoGrabber1.FrameCaptureWidth = -1
        Me.VideoGrabber1.FrameCaptureWithoutOverlay = False
        Me.VideoGrabber1.FrameCaptureZoomSize = 100
        Me.VideoGrabber1.FrameGrabber = VidGrab.TFrameGrabber.fg_BothStreams
        Me.VideoGrabber1.FrameGrabberRGBFormat = VidGrab.TFrameGrabberRGBFormat.fgf_Default
        Me.VideoGrabber1.FrameNumberStartsFromZero = False
        Me.VideoGrabber1.FrameRate = 0R
        Me.VideoGrabber1.HoldRecording = False
        Me.VideoGrabber1.ImageOverlay_AlphaBlend = False
        Me.VideoGrabber1.ImageOverlay_AlphaBlendValue = 180
        Me.VideoGrabber1.ImageOverlay_ChromaKey = False
        Me.VideoGrabber1.ImageOverlay_ChromaKeyLeewayPercent = 25
        Me.VideoGrabber1.ImageOverlay_ChromaKeyRGBColor = 0
        Me.VideoGrabber1.ImageOverlay_Height = -1
        Me.VideoGrabber1.ImageOverlay_LeftLocation = 10
        Me.VideoGrabber1.ImageOverlay_RotationAngle = 0R
        Me.VideoGrabber1.ImageOverlay_StretchToVideoSize = False
        Me.VideoGrabber1.ImageOverlay_TopLocation = 10
        Me.VideoGrabber1.ImageOverlay_Transparent = False
        Me.VideoGrabber1.ImageOverlay_TransparentColorValue = 0
        Me.VideoGrabber1.ImageOverlay_UseTransparentColor = False
        Me.VideoGrabber1.ImageOverlay_Width = -1
        Me.VideoGrabber1.ImageOverlayEnabled = False
        Me.VideoGrabber1.ImageOverlaySelector = 0
        Me.VideoGrabber1.IPCameraURL = ""
        Me.VideoGrabber1.JPEGPerformance = VidGrab.TJPEGPerformance.jpBestQuality
        Me.VideoGrabber1.JPEGProgressiveDisplay = False
        Me.VideoGrabber1.JPEGQuality = 100
        Me.VideoGrabber1.LicenseString = "N/A"
        Me.VideoGrabber1.Location = New System.Drawing.Point(0, 0)
        Me.VideoGrabber1.LogoDisplayed = False
        Me.VideoGrabber1.LogoLayout = VidGrab.TLogoLayout.lg_Stretched
        Me.VideoGrabber1.MixAudioSamples_CurrentSourceLevel = 100
        Me.VideoGrabber1.MixAudioSamples_ExternalSourceLevel = 100
        Me.VideoGrabber1.Mixer_MosaicColumns = 1
        Me.VideoGrabber1.Mixer_MosaicLines = 1
        Me.VideoGrabber1.MotionDetector_CompareBlue = True
        Me.VideoGrabber1.MotionDetector_CompareGreen = True
        Me.VideoGrabber1.MotionDetector_CompareRed = True
        Me.VideoGrabber1.MotionDetector_Enabled = False
        Me.VideoGrabber1.MotionDetector_GreyScale = False
        Me.VideoGrabber1.MotionDetector_Grid = "5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555555555 5555" &
    "555555 5555555555 5555555555"
        Me.VideoGrabber1.MotionDetector_MaxDetectionsPerSecond = 0R
        Me.VideoGrabber1.MotionDetector_ReduceCPULoad = 1
        Me.VideoGrabber1.MotionDetector_ReduceVideoNoise = False
        Me.VideoGrabber1.MotionDetector_Triggered = False
        Me.VideoGrabber1.MouseWheelEventEnabled = True
        Me.VideoGrabber1.MpegStreamType = VidGrab.TMpegStreamType.mpst_Default
        Me.VideoGrabber1.MultiplexedInputEmulation = True
        Me.VideoGrabber1.MultiplexedRole = VidGrab.TMultiplexedRole.mr_NotMultiplexed
        Me.VideoGrabber1.MultiplexedStabilizationDelay = 100
        Me.VideoGrabber1.MultiplexedSwitchDelay = 0
        Me.VideoGrabber1.Multiplexer = -1
        Me.VideoGrabber1.MuteAudioRendering = False
        Me.VideoGrabber1.Name = "VideoGrabber1"
        Me.VideoGrabber1.NetworkStreaming = VidGrab.TNetworkStreaming.ns_Disabled
        Me.VideoGrabber1.NetworkStreamingType = VidGrab.TNetworkStreamingType.nst_AudioVideoStreaming
        Me.VideoGrabber1.NormalCursor = VidGrab.TCursors.cr_Default
        Me.VideoGrabber1.NotificationMethod = VidGrab.TNotificationMethod.nm_Thread
        Me.VideoGrabber1.NotificationPriority = VidGrab.TThreadPriority.tpNormal
        Me.VideoGrabber1.NotificationSleepTime = -1
        Me.VideoGrabber1.OnFrameBitmapEventSynchrone = False
        Me.VideoGrabber1.OpenURLAsync = False
        Me.VideoGrabber1.OverlayAfterTransform = False
        Me.VideoGrabber1.OwnerObject = Nothing
        Me.VideoGrabber1.PlayerAudioRendering = True
        Me.VideoGrabber1.PlayerDuration = CType(1, Long)
        Me.VideoGrabber1.PlayerDVSize = VidGrab.TDVSize.dv_Full
        Me.VideoGrabber1.PlayerFastSeekSpeedRatio = 4
        Me.VideoGrabber1.PlayerFileName = ""
        Me.VideoGrabber1.PlayerForcedCodec = ""
        Me.VideoGrabber1.PlayerFramePosition = CType(1, Long)
        Me.VideoGrabber1.PlayerRefreshPausedDisplay = False
        Me.VideoGrabber1.PlayerRefreshPausedDisplayFrameRate = 0R
        Me.VideoGrabber1.PlayerSpeedRatio = 1.0R
        Me.VideoGrabber1.PlayerTimePosition = CType(0, Long)
        Me.VideoGrabber1.PlayerTrackBarSynchrone = False
        Me.VideoGrabber1.PlaylistIndex = 0
        Me.VideoGrabber1.PreallocCapFileCopiedAfterRecording = True
        Me.VideoGrabber1.PreallocCapFileEnabled = False
        Me.VideoGrabber1.PreallocCapFileName = ""
        Me.VideoGrabber1.PreallocCapFileSizeInMB = 100
        Me.VideoGrabber1.PreviewZoomSize = 100
        Me.VideoGrabber1.QuickDeviceInitialization = False
        Me.VideoGrabber1.RawAudioSampleCapture = False
        Me.VideoGrabber1.RawCaptureAsyncEvent = True
        Me.VideoGrabber1.RawSampleCaptureLocation = VidGrab.TRawSampleCaptureLocation.rl_SourceFormat
        Me.VideoGrabber1.RawVideoSampleCapture = False
        Me.VideoGrabber1.RecordingAudioBitRate = -1
        Me.VideoGrabber1.RecordingBacktimedFramesCount = 0
        Me.VideoGrabber1.RecordingCanPause = False
        Me.VideoGrabber1.RecordingFileName = ""
        Me.VideoGrabber1.RecordingInNativeFormat = True
        Me.VideoGrabber1.RecordingMethod = VidGrab.TRecordingMethod.rm_AVI
        Me.VideoGrabber1.RecordingOnMotion_Enabled = False
        Me.VideoGrabber1.RecordingOnMotion_MotionThreshold = 0R
        Me.VideoGrabber1.RecordingOnMotion_NoMotionPauseDelayMs = 5000
        Me.VideoGrabber1.RecordingPauseCreatesNewFile = False
        Me.VideoGrabber1.RecordingSize = VidGrab.TRecordingSize.rs_Default
        Me.VideoGrabber1.RecordingTimer = VidGrab.TRecordingTimer.rt_Disabled
        Me.VideoGrabber1.RecordingTimerInterval = 0
        Me.VideoGrabber1.RecordingVideoBitRate = -1
        Me.VideoGrabber1.Reencoding_IncludeAudioStream = True
        Me.VideoGrabber1.Reencoding_IncludeVideoStream = True
        Me.VideoGrabber1.Reencoding_Method = VidGrab.TRecordingMethod.rm_ASF
        Me.VideoGrabber1.Reencoding_NewVideoClip = ""
        Me.VideoGrabber1.Reencoding_SourceVideoClip = ""
        Me.VideoGrabber1.Reencoding_StartFrame = CType(-1, Long)
        Me.VideoGrabber1.Reencoding_StartTime = CType(-1, Long)
        Me.VideoGrabber1.Reencoding_StopFrame = CType(-1, Long)
        Me.VideoGrabber1.Reencoding_StopTime = CType(-1, Long)
        Me.VideoGrabber1.Reencoding_UseAudioCompressor = False
        Me.VideoGrabber1.Reencoding_UseFrameGrabber = True
        Me.VideoGrabber1.Reencoding_UseVideoCompressor = False
        Me.VideoGrabber1.Reencoding_WMVOutput = False
        Me.VideoGrabber1.ScreenRecordingLayeredWindows = False
        Me.VideoGrabber1.ScreenRecordingMonitor = 0
        Me.VideoGrabber1.ScreenRecordingNonVisibleWindows = False
        Me.VideoGrabber1.ScreenRecordingThroughClipboard = False
        Me.VideoGrabber1.ScreenRecordingWithCursor = True
        Me.VideoGrabber1.SendToDV_DeviceIndex = -1
        Me.VideoGrabber1.Size = New System.Drawing.Size(736, 502)
        Me.VideoGrabber1.SpeakerBalance = 0
        Me.VideoGrabber1.SpeakerControl = False
        Me.VideoGrabber1.SpeakerVolume = 65535
        Me.VideoGrabber1.StoragePath = "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE"
        Me.VideoGrabber1.StoreDeviceSettingsInRegistry = True
        Me.VideoGrabber1.SyncCommands = True
        Me.VideoGrabber1.SynchronizationRole = VidGrab.TSynchronizationRole.sr_Master
        Me.VideoGrabber1.Synchronized = False
        Me.VideoGrabber1.SyncPreview = VidGrab.TSyncPreview.sp_Auto
        Me.VideoGrabber1.TabIndex = 0
        Me.VideoGrabber1.TextOverlay_Align = VidGrab.TTextOverlayAlign.tf_Left
        Me.VideoGrabber1.TextOverlay_BkColor = 16777215
        Me.VideoGrabber1.TextOverlay_Enabled = False
        'TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
        Me.VideoGrabber1.TextOverlay_FontColor = 16776960
        Me.VideoGrabber1.TextOverlay_Left = 0
        Me.VideoGrabber1.TextOverlay_Right = -1
        Me.VideoGrabber1.TextOverlay_Scrolling = False
        Me.VideoGrabber1.TextOverlay_ScrollingSpeed = 1
        Me.VideoGrabber1.TextOverlay_Selector = 0
        Me.VideoGrabber1.TextOverlay_Shadow = True
        Me.VideoGrabber1.TextOverlay_ShadowColor = 0
        Me.VideoGrabber1.TextOverlay_ShadowDirection = VidGrab.TCardinalDirection.cd_NorthWest
        Me.VideoGrabber1.TextOverlay_String = resources.GetString("VideoGrabber1.TextOverlay_String")
        Me.VideoGrabber1.TextOverlay_Top = 0
        Me.VideoGrabber1.TextOverlay_Transparent = True
        Me.VideoGrabber1.ThirdPartyDeinterlacer = ""
        Me.VideoGrabber1.TranslateMouseCoordinates = True
        Me.VideoGrabber1.TunerFrequency = -1
        Me.VideoGrabber1.TunerMode = VidGrab.TTunerMode.tm_TVTuner
        Me.VideoGrabber1.TVChannel = 0
        Me.VideoGrabber1.TVCountryCode = 0
        Me.VideoGrabber1.TVTunerInputType = VidGrab.TTunerInputType.TunerInputCable
        Me.VideoGrabber1.TVUseFrequencyOverrides = False
        Me.VideoGrabber1.UseClock = True
        Me.VideoGrabber1.VCRHorizontalLocking = False
        Me.VideoGrabber1.Version = "v8.8.4.2 (build 131122) - Copyright ©2013 Datastead"
        Me.VideoGrabber1.VideoCompression_DataRate = -1
        Me.VideoGrabber1.VideoCompression_KeyFrameRate = 15
        Me.VideoGrabber1.VideoCompression_PFramesPerKeyFrame = 0
        Me.VideoGrabber1.VideoCompression_Quality = 1.0R
        Me.VideoGrabber1.VideoCompression_WindowSize = -1
        Me.VideoGrabber1.VideoCompressor = 0
        Me.VideoGrabber1.VideoControlSettings = True
        Me.VideoGrabber1.VideoCursor = VidGrab.TCursors.cr_Default
        Me.VideoGrabber1.VideoDevice = -1
        Me.VideoGrabber1.VideoFormat = -1
        Me.VideoGrabber1.VideoFromImages_BitmapsSortedBy = VidGrab.TFileSort.fs_TimeAsc
        Me.VideoGrabber1.VideoFromImages_RepeatIndefinitely = False
        Me.VideoGrabber1.VideoFromImages_SourceDirectory = "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE"
        Me.VideoGrabber1.VideoFromImages_TemporaryFile = "SetOfBitmaps01.dat"
        Me.VideoGrabber1.VideoInput = -1
        Me.VideoGrabber1.VideoProcessing_Brightness = 0
        Me.VideoGrabber1.VideoProcessing_Contrast = 0
        Me.VideoGrabber1.VideoProcessing_Deinterlacing = VidGrab.TVideoDeinterlacing.di_Disabled
        Me.VideoGrabber1.VideoProcessing_FlipHorizontal = False
        Me.VideoGrabber1.VideoProcessing_FlipVertical = False
        Me.VideoGrabber1.VideoProcessing_GrayScale = False
        Me.VideoGrabber1.VideoProcessing_Hue = 0
        Me.VideoGrabber1.VideoProcessing_InvertColors = False
        Me.VideoGrabber1.VideoProcessing_Pixellization = 1
        Me.VideoGrabber1.VideoProcessing_Rotation = VidGrab.TVideoRotation.rt_0_deg
        Me.VideoGrabber1.VideoProcessing_RotationCustomAngle = 45.5R
        Me.VideoGrabber1.VideoProcessing_Saturation = 0
        Me.VideoGrabber1.VideoQualitySettings = True
        Me.VideoGrabber1.VideoRenderer = VidGrab.TVideoRenderer.vr_AutoSelect
        Me.VideoGrabber1.VideoRendererExternal = VidGrab.TVideoRendererExternal.vre_None
        Me.VideoGrabber1.VideoRendererExternalIndex = -1
        Me.VideoGrabber1.VideoSize = -1
        Me.VideoGrabber1.VideoSource = VidGrab.TVideoSource.vs_VideoCaptureDevice
        Me.VideoGrabber1.VideoSource_FileOrURL = ""
        Me.VideoGrabber1.VideoSource_FileOrURL_StartTime = CType(-1, Long)
        Me.VideoGrabber1.VideoSource_FileOrURL_StopTime = CType(-1, Long)
        Me.VideoGrabber1.VideoSubtype = -1
        Me.VideoGrabber1.VideoVisibleWhenStopped = False
        Me.VideoGrabber1.VirtualAudioStreamControl = -1
        Me.VideoGrabber1.VirtualVideoStreamControl = -1
        Me.VideoGrabber1.VuMeter = VidGrab.TVuMeter.vu_Disabled
        Me.VideoGrabber1.WebcamStillCaptureButton = VidGrab.TWebcamStillCaptureButton.wb_Disabled
        Me.VideoGrabber1.ZoomCoeff = 1000
        Me.VideoGrabber1.ZoomXCenter = 0
        Me.VideoGrabber1.ZoomYCenter = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(736, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.ARS.My.Resources.Resources.Cam
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(105, 22)
        Me.ToolStripButton1.Text = "Capture Image"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.ARS.My.Resources.Resources.cancel
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripButton2.Text = "Cancel"
        '
        'CaptureCameraImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 502)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.VideoGrabber1)
        Me.Name = "CaptureCameraImage"
        Me.Text = "Capture Images from Web Cam"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VideoGrabber1 As VidGrab.VideoGrabber
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
