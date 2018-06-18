<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomTextboxControl
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
        Me.txtTextBox = New System.Windows.Forms.TextBox()
        Me.TextBoxLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTextBox
        '
        Me.txtTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTextBox.Location = New System.Drawing.Point(0, 20)
        Me.txtTextBox.Name = "txtTextBox"
        Me.txtTextBox.Size = New System.Drawing.Size(150, 20)
        Me.txtTextBox.TabIndex = 0
        '
        'TextBoxLabel
        '
        Me.TextBoxLabel.AutoSize = True
        Me.TextBoxLabel.Location = New System.Drawing.Point(3, 4)
        Me.TextBoxLabel.Name = "TextBoxLabel"
        Me.TextBoxLabel.Size = New System.Drawing.Size(78, 13)
        Me.TextBoxLabel.TabIndex = 1
        Me.TextBoxLabel.Text = "Text Box Label"
        '
        'CustomTextboxControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextBoxLabel)
        Me.Controls.Add(Me.txtTextBox)
        Me.Name = "CustomTextboxControl"
        Me.Size = New System.Drawing.Size(150, 40)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTextBox As TextBox
    Friend WithEvents TextBoxLabel As Label
End Class
