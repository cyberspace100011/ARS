<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerSearchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnScanID = New System.Windows.Forms.ToolStripButton()
        Me.btnClear = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.tsCustomerSearch = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtSearchField = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataSet1 = New System.Data.DataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsCustomerSearch.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'btnScanID
        '
        Me.btnScanID.Image = Global.ARS.My.Resources.Resources.barcode_scanner
        Me.btnScanID.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnScanID.Name = "btnScanID"
        Me.btnScanID.Size = New System.Drawing.Size(116, 24)
        Me.btnScanID.Text = "Scan ID Barcode"
        Me.btnScanID.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Image = Global.ARS.My.Resources.Resources.clear
        Me.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(58, 24)
        Me.btnClear.Text = "Clear"
        '
        'btnSearch
        '
        Me.btnSearch.Image = Global.ARS.My.Resources.Resources.search
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 24)
        Me.btnSearch.Text = "Search"
        '
        'dg1
        '
        Me.dg1.AllowUserToDeleteRows = False
        Me.dg1.AllowUserToOrderColumns = True
        Me.dg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg1.Location = New System.Drawing.Point(0, 27)
        Me.dg1.Margin = New System.Windows.Forms.Padding(2)
        Me.dg1.MultiSelect = False
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.RowTemplate.Height = 24
        Me.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg1.Size = New System.Drawing.Size(1054, 640)
        Me.dg1.TabIndex = 1
        '
        'tsCustomerSearch
        '
        Me.tsCustomerSearch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCustomerSearch.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsCustomerSearch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearchField, Me.btnSearch, Me.btnClear, Me.ToolStripSeparator5, Me.btnScanID, Me.ToolStripSeparator4})
        Me.tsCustomerSearch.Location = New System.Drawing.Point(0, 0)
        Me.tsCustomerSearch.Name = "tsCustomerSearch"
        Me.tsCustomerSearch.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsCustomerSearch.Size = New System.Drawing.Size(1054, 27)
        Me.tsCustomerSearch.TabIndex = 0
        Me.tsCustomerSearch.Text = "ToolStrip2"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'txtSearchField
        '
        Me.txtSearchField.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearchField.Name = "txtSearchField"
        Me.txtSearchField.Size = New System.Drawing.Size(300, 27)
        Me.txtSearchField.ToolTipText = "Input customers first and /or last name," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or Drivers License ID Number and then p" &
    "ress enter"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'CustomerSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 667)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.tsCustomerSearch)
        Me.Name = "CustomerSearchForm"
        Me.Text = "Customer Search"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsCustomerSearch.ResumeLayout(False)
        Me.tsCustomerSearch.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents btnScanID As ToolStripButton
    Friend WithEvents btnClear As ToolStripButton
    Friend WithEvents btnSearch As ToolStripButton
    Protected Friend WithEvents dg1 As DataGridView
    Friend WithEvents tsCustomerSearch As ToolStrip
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents txtSearchField As ToolStripTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents Timer1 As Timer
End Class
