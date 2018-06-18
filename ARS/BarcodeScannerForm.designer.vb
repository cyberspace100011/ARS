<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarcodeScannerForm
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
        Me.txtBarcodeData = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtBarcodeData
        '
        Me.txtBarcodeData.BackColor = System.Drawing.SystemColors.WindowText
        Me.txtBarcodeData.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBarcodeData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBarcodeData.ForeColor = System.Drawing.SystemColors.Window
        Me.txtBarcodeData.Location = New System.Drawing.Point(0, 0)
        Me.txtBarcodeData.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBarcodeData.Multiline = True
        Me.txtBarcodeData.Name = "txtBarcodeData"
        Me.txtBarcodeData.Size = New System.Drawing.Size(337, 304)
        Me.txtBarcodeData.TabIndex = 1
        '
        'BarcodeScannerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 304)
        Me.Controls.Add(Me.txtBarcodeData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BarcodeScannerForm"
        Me.Text = "Scan Code on Drivers Licence Now"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBarcodeData As System.Windows.Forms.TextBox
End Class
