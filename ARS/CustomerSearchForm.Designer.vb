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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerSearchForm))
        Me.OleDbCustomers = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
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
        Me.BSCustomer = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.tsLabels = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsCustomerSearch = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtCusID = New System.Windows.Forms.ToolStripTextBox()
        Me.txtDL = New System.Windows.Forms.ToolStripTextBox()
        Me.txtCompany = New System.Windows.Forms.ToolStripTextBox()
        Me.txtFName = New System.Windows.Forms.ToolStripTextBox()
        Me.txtLName = New System.Windows.Forms.ToolStripTextBox()
        CType(Me.BSCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsLabels.SuspendLayout()
        Me.tsCustomerSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'OleDbCustomers
        '
        Me.OleDbCustomers.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbCustomers.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbCustomers.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbCustomers.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "customer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cust_id", "cust_id"), New System.Data.Common.DataColumnMapping("cust_nm_last", "cust_nm_last"), New System.Data.Common.DataColumnMapping("cust_nm_first", "cust_nm_first"), New System.Data.Common.DataColumnMapping("cust_nm_middle", "cust_nm_middle"), New System.Data.Common.DataColumnMapping("cust_addr1", "cust_addr1"), New System.Data.Common.DataColumnMapping("cust_addr2", "cust_addr2"), New System.Data.Common.DataColumnMapping("cust_city", "cust_city"), New System.Data.Common.DataColumnMapping("cust_state", "cust_state"), New System.Data.Common.DataColumnMapping("cust_zip", "cust_zip"), New System.Data.Common.DataColumnMapping("cust_id_number", "cust_id_number"), New System.Data.Common.DataColumnMapping("employer_nm", "employer_nm")})})
        Me.OleDbCustomers.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_cust_id", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_nm_last", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_nm_last", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_nm_last", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_nm_last", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_nm_first", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_nm_first", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_nm_first", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_nm_first", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_nm_middle", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_nm_middle", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_nm_middle", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_nm_middle", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_addr1", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_addr1", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_addr1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_addr1", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_addr2", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_addr2", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_addr2", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_addr2", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_city", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_city", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_city", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_city", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_state", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_state", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_state", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_state", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_zip", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_zip", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_zip", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_zip", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_id_number", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_id_number", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_id_number", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_id_number", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_employer_nm", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "employer_nm", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_employer_nm", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employer_nm", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\DataNest\DB\ARS.mdb"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = resources.GetString("OleDbInsertCommand1.CommandText")
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("cust_id", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_id"), New System.Data.OleDb.OleDbParameter("cust_nm_last", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_nm_last"), New System.Data.OleDb.OleDbParameter("cust_nm_first", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_nm_first"), New System.Data.OleDb.OleDbParameter("cust_nm_middle", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_nm_middle"), New System.Data.OleDb.OleDbParameter("cust_addr1", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_addr1"), New System.Data.OleDb.OleDbParameter("cust_addr2", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_addr2"), New System.Data.OleDb.OleDbParameter("cust_city", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_city"), New System.Data.OleDb.OleDbParameter("cust_state", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_state"), New System.Data.OleDb.OleDbParameter("cust_zip", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_zip"), New System.Data.OleDb.OleDbParameter("cust_id_number", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_id_number"), New System.Data.OleDb.OleDbParameter("employer_nm", System.Data.OleDb.OleDbType.VarWChar, 0, "employer_nm")})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT cust_id, cust_nm_last, cust_nm_first, cust_nm_middle, cust_addr1, cust_add" &
    "r2, cust_city, cust_state, cust_zip, cust_id_number, employer_nm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     custo" &
    "mer"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("cust_id", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_id"), New System.Data.OleDb.OleDbParameter("cust_nm_last", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_nm_last"), New System.Data.OleDb.OleDbParameter("cust_nm_first", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_nm_first"), New System.Data.OleDb.OleDbParameter("cust_nm_middle", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_nm_middle"), New System.Data.OleDb.OleDbParameter("cust_addr1", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_addr1"), New System.Data.OleDb.OleDbParameter("cust_addr2", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_addr2"), New System.Data.OleDb.OleDbParameter("cust_city", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_city"), New System.Data.OleDb.OleDbParameter("cust_state", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_state"), New System.Data.OleDb.OleDbParameter("cust_zip", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_zip"), New System.Data.OleDb.OleDbParameter("cust_id_number", System.Data.OleDb.OleDbType.VarWChar, 0, "cust_id_number"), New System.Data.OleDb.OleDbParameter("employer_nm", System.Data.OleDb.OleDbType.VarWChar, 0, "employer_nm"), New System.Data.OleDb.OleDbParameter("Original_cust_id", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_nm_last", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_nm_last", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_nm_last", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_nm_last", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_nm_first", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_nm_first", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_nm_first", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_nm_first", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_nm_middle", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_nm_middle", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_nm_middle", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_nm_middle", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_addr1", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_addr1", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_addr1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_addr1", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_addr2", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_addr2", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_addr2", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_addr2", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_city", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_city", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_city", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_city", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_state", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_state", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_state", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_state", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_zip", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_zip", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_zip", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_zip", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_cust_id_number", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "cust_id_number", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_cust_id_number", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_id_number", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_employer_nm", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "employer_nm", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_employer_nm", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employer_nm", System.Data.DataRowVersion.Original, Nothing)})
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
        'BSCustomer
        '
        Me.BSCustomer.DataMember = "customer"
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
        Me.dg1.Location = New System.Drawing.Point(0, 52)
        Me.dg1.Margin = New System.Windows.Forms.Padding(2)
        Me.dg1.MultiSelect = False
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.RowTemplate.Height = 24
        Me.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg1.Size = New System.Drawing.Size(1054, 615)
        Me.dg1.TabIndex = 5
        Me.dg1.Visible = False
        '
        'tsLabels
        '
        Me.tsLabels.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsLabels.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsLabels.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripSeparator8, Me.ToolStripTextBox2, Me.ToolStripSeparator9, Me.ToolStripTextBox3, Me.ToolStripSeparator10, Me.ToolStripTextBox4, Me.ToolStripSeparator11, Me.ToolStripTextBox5, Me.ToolStripSeparator12})
        Me.tsLabels.Location = New System.Drawing.Point(0, 27)
        Me.tsLabels.Name = "tsLabels"
        Me.tsLabels.Size = New System.Drawing.Size(1054, 25)
        Me.tsLabels.TabIndex = 3
        Me.tsLabels.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(79, 22)
        Me.ToolStripTextBox1.Text = "Customer ID  "
        Me.ToolStripTextBox1.ToolTipText = "Customer ID Number"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(74, 22)
        Me.ToolStripTextBox2.Text = "Drivers Lic # "
        Me.ToolStripTextBox2.ToolTipText = "Drivers Lic Number"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(82, 22)
        Me.ToolStripTextBox3.Text = "Company Nm"
        Me.ToolStripTextBox3.ToolTipText = "Company Name"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripTextBox4.Text = "First Name    "
        Me.ToolStripTextBox4.ToolTipText = "First Name"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox5
        '
        Me.ToolStripTextBox5.Name = "ToolStripTextBox5"
        Me.ToolStripTextBox5.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripTextBox5.Text = "Last Name    "
        Me.ToolStripTextBox5.ToolTipText = "Last Name"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'tsCustomerSearch
        '
        Me.tsCustomerSearch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCustomerSearch.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsCustomerSearch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.txtCusID, Me.txtDL, Me.txtCompany, Me.txtFName, Me.txtLName, Me.btnSearch, Me.btnClear, Me.ToolStripSeparator5, Me.ToolStripSeparator6, Me.btnAddCustomer, Me.ToolStripSeparator7, Me.btnScanID, Me.btnBarcodeOptions})
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
        'txtCusID
        '
        Me.txtCusID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCusID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCusID.Name = "txtCusID"
        Me.txtCusID.Size = New System.Drawing.Size(76, 27)
        Me.txtCusID.ToolTipText = "Customer ID Number"
        '
        'txtDL
        '
        Me.txtDL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDL.Name = "txtDL"
        Me.txtDL.Size = New System.Drawing.Size(76, 27)
        Me.txtDL.ToolTipText = "Drivers Lic Number"
        '
        'txtCompany
        '
        Me.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(76, 27)
        Me.txtCompany.ToolTipText = "Company Name"
        '
        'txtFName
        '
        Me.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(76, 27)
        Me.txtFName.ToolTipText = "First Name"
        '
        'txtLName
        '
        Me.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(76, 27)
        Me.txtLName.ToolTipText = "Last Name"
        '
        'CustomerSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 667)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.tsLabels)
        Me.Controls.Add(Me.tsCustomerSearch)
        Me.Name = "CustomerSearchForm"
        Me.Text = "CustomerSearchForm"
        CType(Me.BSCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsLabels.ResumeLayout(False)
        Me.tsLabels.PerformLayout()
        Me.tsCustomerSearch.ResumeLayout(False)
        Me.tsCustomerSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OleDbCustomers As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
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
    Friend WithEvents BSCustomer As BindingSource
    Friend WithEvents btnSearch As ToolStripButton
    Protected Friend WithEvents dg1 As DataGridView
    Friend WithEvents tsLabels As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox3 As ToolStripLabel
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox4 As ToolStripLabel
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox5 As ToolStripLabel
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents tsCustomerSearch As ToolStrip
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents txtCusID As ToolStripTextBox
    Friend WithEvents txtDL As ToolStripTextBox
    Friend WithEvents txtCompany As ToolStripTextBox
    Friend WithEvents txtFName As ToolStripTextBox
    Friend WithEvents txtLName As ToolStripTextBox
End Class
