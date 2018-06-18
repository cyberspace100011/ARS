<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTicketForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewTicketForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.txtSelectedCustomer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnViewCustomerRecord = New System.Windows.Forms.Button()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgItems = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpMetals = New System.Windows.Forms.TabPage()
        Me.tpAutos = New System.Windows.Forms.TabPage()
        Me.PropertyLookupControl1 = New ARS.PropertyLookupControl()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tpMetals.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1155, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSave
        '
        Me.btnSave.Image = Global.ARS.My.Resources.Resources.Save
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.ARS.My.Resources.Resources.cancel
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 22)
        Me.btnCancel.Text = "&Cancel"
        '
        'txtSelectedCustomer
        '
        Me.txtSelectedCustomer.Location = New System.Drawing.Point(12, 51)
        Me.txtSelectedCustomer.Name = "txtSelectedCustomer"
        Me.txtSelectedCustomer.ReadOnly = True
        Me.txtSelectedCustomer.Size = New System.Drawing.Size(268, 20)
        Me.txtSelectedCustomer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer"
        '
        'btnViewCustomerRecord
        '
        Me.btnViewCustomerRecord.Enabled = False
        Me.btnViewCustomerRecord.Location = New System.Drawing.Point(12, 78)
        Me.btnViewCustomerRecord.Name = "btnViewCustomerRecord"
        Me.btnViewCustomerRecord.Size = New System.Drawing.Size(267, 22)
        Me.btnViewCustomerRecord.TabIndex = 6
        Me.btnViewCustomerRecord.Text = "View Customer Record"
        Me.ToolTip1.SetToolTip(Me.btnViewCustomerRecord, "Click here to open Customer Manager")
        Me.btnViewCustomerRecord.UseVisualStyleBackColor = True
        '
        'btnScan
        '
        Me.btnScan.Location = New System.Drawing.Point(286, 51)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(75, 23)
        Me.btnScan.TabIndex = 7
        Me.btnScan.Text = "Scan ID"
        Me.ToolTip1.SetToolTip(Me.btnScan, "Scan ID Barcode of Customer")
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(367, 51)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search"
        Me.ToolTip1.SetToolTip(Me.btnSearch, "Search for an Existing Customer")
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dgItems
        '
        Me.dgItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItems.Location = New System.Drawing.Point(3, 69)
        Me.dgItems.Name = "dgItems"
        Me.dgItems.Size = New System.Drawing.Size(1141, 350)
        Me.dgItems.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(320, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Assign Customer"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1120, 1)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Add Items"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tpMetals)
        Me.TabControl1.Controls.Add(Me.tpAutos)
        Me.TabControl1.Location = New System.Drawing.Point(0, 141)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1155, 451)
        Me.TabControl1.TabIndex = 12
        '
        'tpMetals
        '
        Me.tpMetals.Controls.Add(Me.PropertyLookupControl1)
        Me.tpMetals.Controls.Add(Me.dgItems)
        Me.tpMetals.Location = New System.Drawing.Point(4, 25)
        Me.tpMetals.Name = "tpMetals"
        Me.tpMetals.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMetals.Size = New System.Drawing.Size(1147, 422)
        Me.tpMetals.TabIndex = 0
        Me.tpMetals.Text = "Bulk Metals Etc"
        Me.tpMetals.UseVisualStyleBackColor = True
        '
        'tpAutos
        '
        Me.tpAutos.Location = New System.Drawing.Point(4, 25)
        Me.tpAutos.Name = "tpAutos"
        Me.tpAutos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAutos.Size = New System.Drawing.Size(1147, 422)
        Me.tpAutos.TabIndex = 1
        Me.tpAutos.Text = "Automobiles"
        Me.tpAutos.UseVisualStyleBackColor = True
        '
        'PropertyLookupControl1
        '
        Me.PropertyLookupControl1.LineTotal = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PropertyLookupControl1.Location = New System.Drawing.Point(17, 13)
        Me.PropertyLookupControl1.Name = "PropertyLookupControl1"
        Me.PropertyLookupControl1.Price = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.PropertyLookupControl1.ProdName = "#1 copper wire"
        Me.PropertyLookupControl1.Productid = 2
        Me.PropertyLookupControl1.Quantity = New Decimal(New Integer() {0, 0, 0, 0})
        Me.PropertyLookupControl1.Size = New System.Drawing.Size(711, 48)
        Me.PropertyLookupControl1.TabIndex = 9
        '
        'NewTicketForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 592)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.btnViewCustomerRecord)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSelectedCustomer)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewTicketForm"
        Me.Text = "Ticket"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tpMetals.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnCancel As ToolStripButton
    Friend WithEvents txtSelectedCustomer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnViewCustomerRecord As Button
    Friend WithEvents btnScan As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents dgItems As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpMetals As TabPage
    Friend WithEvents tpAutos As TabPage
    Friend WithEvents PropertyLookupControl1 As PropertyLookupControl
End Class
