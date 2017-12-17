<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerSearchForm
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAddCustomer = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NewCustomerFromScratchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsingScannedIDDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnScanID = New System.Windows.Forms.ToolStripButton()
        Me.btnBarcodeOptions = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SearchByDriversLicenseIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchByCompanyNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CreateANewCustomerUsingScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClear = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.tsCustomerSearch = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtSearchField = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsCustomerSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCustomerFromScratchToolStripMenuItem, Me.UsingScannedIDDataToolStripMenuItem})
        Me.btnAddCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(97, 24)
        Me.btnAddCustomer.Text = "Add Customer"
        '
        'NewCustomerFromScratchToolStripMenuItem
        '
        Me.NewCustomerFromScratchToolStripMenuItem.Name = "NewCustomerFromScratchToolStripMenuItem"
        Me.NewCustomerFromScratchToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.NewCustomerFromScratchToolStripMenuItem.Text = "From Scratch"
        '
        'UsingScannedIDDataToolStripMenuItem
        '
        Me.UsingScannedIDDataToolStripMenuItem.Name = "UsingScannedIDDataToolStripMenuItem"
        Me.UsingScannedIDDataToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.UsingScannedIDDataToolStripMenuItem.Text = "Using Scanned I.D. data"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'btnScanID
        '
        Me.btnScanID.Image = Global.ARS.My.Resources.Resources.barcode_scanner
        Me.btnScanID.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnScanID.Name = "btnScanID"
        Me.btnScanID.Size = New System.Drawing.Size(116, 24)
        Me.btnScanID.Text = "Scan ID Barcode"
        '
        'btnBarcodeOptions
        '
        Me.btnBarcodeOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBarcodeOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchByDriversLicenseIDToolStripMenuItem, Me.SearchByCompanyNameToolStripMenuItem, Me.ToolStripSeparator2, Me.CreateANewCustomerUsingScanToolStripMenuItem})
        Me.btnBarcodeOptions.Image = Global.ARS.My.Resources.Resources.barcode_scanner
        Me.btnBarcodeOptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBarcodeOptions.Name = "btnBarcodeOptions"
        Me.btnBarcodeOptions.Size = New System.Drawing.Size(33, 24)
        Me.btnBarcodeOptions.Text = "ToolStripDropDownButton1"
        Me.btnBarcodeOptions.ToolTipText = "Previously Scanned ID Options"
        Me.btnBarcodeOptions.Visible = False
        '
        'SearchByDriversLicenseIDToolStripMenuItem
        '
        Me.SearchByDriversLicenseIDToolStripMenuItem.Name = "SearchByDriversLicenseIDToolStripMenuItem"
        Me.SearchByDriversLicenseIDToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.SearchByDriversLicenseIDToolStripMenuItem.Text = "Search by First and Last Name"
        '
        'SearchByCompanyNameToolStripMenuItem
        '
        Me.SearchByCompanyNameToolStripMenuItem.Name = "SearchByCompanyNameToolStripMenuItem"
        Me.SearchByCompanyNameToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.SearchByCompanyNameToolStripMenuItem.Text = "Search by Driver's License ID"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(257, 6)
        '
        'CreateANewCustomerUsingScanToolStripMenuItem
        '
        Me.CreateANewCustomerUsingScanToolStripMenuItem.Name = "CreateANewCustomerUsingScanToolStripMenuItem"
        Me.CreateANewCustomerUsingScanToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.CreateANewCustomerUsingScanToolStripMenuItem.Text = "Create a New Customer Using Scan"
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
        Me.dg1.AllowUserToAddRows = False
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
        Me.dg1.TabIndex = 5
        Me.dg1.Visible = False
        '
        'tsCustomerSearch
        '
        Me.tsCustomerSearch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCustomerSearch.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsCustomerSearch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.txtSearchField, Me.btnSearch, Me.btnClear, Me.ToolStripSeparator5, Me.ToolStripSeparator6, Me.btnAddCustomer, Me.ToolStripSeparator7, Me.btnScanID, Me.btnBarcodeOptions})
        Me.tsCustomerSearch.Location = New System.Drawing.Point(0, 0)
        Me.tsCustomerSearch.Name = "tsCustomerSearch"
        Me.tsCustomerSearch.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsCustomerSearch.Size = New System.Drawing.Size(1054, 27)
        Me.tsCustomerSearch.TabIndex = 4
        Me.tsCustomerSearch.Text = "ToolStrip2"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'txtSearchField
        '
        Me.txtSearchField.Name = "txtSearchField"
        Me.txtSearchField.Size = New System.Drawing.Size(300, 27)
        Me.txtSearchField.ToolTipText = "Input customers first and /or last name," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or Drivers License ID Number and then p" &
    "ress enter"
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents btnAddCustomer As ToolStripDropDownButton
    Friend WithEvents NewCustomerFromScratchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsingScannedIDDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents btnScanID As ToolStripButton
    Friend WithEvents btnBarcodeOptions As ToolStripDropDownButton
    Friend WithEvents SearchByDriversLicenseIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchByCompanyNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CreateANewCustomerUsingScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClear As ToolStripButton
    Friend WithEvents btnSearch As ToolStripButton
    Protected Friend WithEvents dg1 As DataGridView
    Friend WithEvents tsCustomerSearch As ToolStrip
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents txtSearchField As ToolStripTextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
