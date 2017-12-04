<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageControls
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CameraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScannerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnClearImage = New System.Windows.Forms.ToolStripButton()
        Me.BGSave = New System.ComponentModel.BackgroundWorker()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pb1
        '
        Me.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb1.Location = New System.Drawing.Point(2, 27)
        Me.pb1.Margin = New System.Windows.Forms.Padding(2)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(234, 180)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb1.TabIndex = 13
        Me.pb1.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripSeparator1, Me.btnClearImage})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(241, 25)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CameraToolStripMenuItem, Me.ScannerToolStripMenuItem, Me.FilesToolStripMenuItem})
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripDropDownButton1.Text = "Obtain Image From:"
        '
        'CameraToolStripMenuItem
        '
        Me.CameraToolStripMenuItem.Image = Global.ARS.My.Resources.Resources.Cam
        Me.CameraToolStripMenuItem.Name = "CameraToolStripMenuItem"
        Me.CameraToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CameraToolStripMenuItem.Text = "Camera"
        '
        'ScannerToolStripMenuItem
        '
        Me.ScannerToolStripMenuItem.Image = Global.ARS.My.Resources.Resources.Scanner
        Me.ScannerToolStripMenuItem.Name = "ScannerToolStripMenuItem"
        Me.ScannerToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ScannerToolStripMenuItem.Text = "Scanner"
        '
        'FilesToolStripMenuItem
        '
        Me.FilesToolStripMenuItem.Image = Global.ARS.My.Resources.Resources.FlashDrive
        Me.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem"
        Me.FilesToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.FilesToolStripMenuItem.Text = "Files"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnClearImage
        '
        Me.btnClearImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClearImage.Image = Global.ARS.My.Resources.Resources.clear2
        Me.btnClearImage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClearImage.Name = "btnClearImage"
        Me.btnClearImage.Size = New System.Drawing.Size(23, 22)
        Me.btnClearImage.Text = "ToolStripButton1"
        '
        'BGSave
        '
        Me.BGSave.WorkerReportsProgress = True
        '
        'ImageControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pb1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ImageControls"
        Me.Size = New System.Drawing.Size(241, 210)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents CameraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScannerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClearImage As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BGSave As System.ComponentModel.BackgroundWorker
End Class
