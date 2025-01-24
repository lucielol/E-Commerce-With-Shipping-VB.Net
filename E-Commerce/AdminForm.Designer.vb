<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ProductNameBox = New TextBox()
        PriceBox = New TextBox()
        StockBox = New TextBox()
        AddButton = New Button()
        RemoveButton = New Button()
        ListProducts = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        no = New DataGridViewTextBoxColumn()
        product_name = New DataGridViewTextBoxColumn()
        price = New DataGridViewTextBoxColumn()
        stock = New DataGridViewTextBoxColumn()
        UpdateButton = New Button()
        CType(ListProducts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nama Produk"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(44, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 25)
        Label2.TabIndex = 1
        Label2.Text = "Harga"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(44, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 25)
        Label3.TabIndex = 2
        Label3.Text = "Stok"
        ' 
        ' ProductNameBox
        ' 
        ProductNameBox.Location = New Point(242, 37)
        ProductNameBox.Name = "ProductNameBox"
        ProductNameBox.PlaceholderText = "Nama Produk"
        ProductNameBox.Size = New Size(481, 31)
        ProductNameBox.TabIndex = 3
        ' 
        ' PriceBox
        ' 
        PriceBox.Location = New Point(242, 81)
        PriceBox.Name = "PriceBox"
        PriceBox.PlaceholderText = "100000"
        PriceBox.Size = New Size(481, 31)
        PriceBox.TabIndex = 4
        ' 
        ' StockBox
        ' 
        StockBox.Location = New Point(242, 129)
        StockBox.Name = "StockBox"
        StockBox.PlaceholderText = "10"
        StockBox.Size = New Size(481, 31)
        StockBox.TabIndex = 5
        ' 
        ' AddButton
        ' 
        AddButton.Enabled = False
        AddButton.Location = New Point(243, 178)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(158, 42)
        AddButton.TabIndex = 6
        AddButton.Text = "+ Tambah"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' RemoveButton
        ' 
        RemoveButton.Enabled = False
        RemoveButton.Location = New Point(565, 178)
        RemoveButton.Name = "RemoveButton"
        RemoveButton.Size = New Size(158, 42)
        RemoveButton.TabIndex = 8
        RemoveButton.Text = "- Hapus"
        RemoveButton.UseVisualStyleBackColor = True
        ' 
        ' ListProducts
        ' 
        ListProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ListProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        ListProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ListProducts.Columns.AddRange(New DataGridViewColumn() {id, no, product_name, price, stock})
        ListProducts.Location = New Point(44, 238)
        ListProducts.Name = "ListProducts"
        ListProducts.RowHeadersWidth = 62
        ListProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ListProducts.Size = New Size(679, 263)
        ListProducts.TabIndex = 9
        ' 
        ' id
        ' 
        id.HeaderText = "Id"
        id.MinimumWidth = 8
        id.Name = "id"
        id.Visible = False
        ' 
        ' no
        ' 
        no.FillWeight = 20F
        no.HeaderText = "No"
        no.MinimumWidth = 8
        no.Name = "no"
        ' 
        ' product_name
        ' 
        product_name.FillWeight = 57.5757561F
        product_name.HeaderText = "Nama Produk"
        product_name.MinimumWidth = 8
        product_name.Name = "product_name"
        ' 
        ' price
        ' 
        price.FillWeight = 57.5757561F
        price.HeaderText = "Harga"
        price.MinimumWidth = 8
        price.Name = "price"
        ' 
        ' stock
        ' 
        stock.FillWeight = 57.5757561F
        stock.HeaderText = "Stok"
        stock.MinimumWidth = 8
        stock.Name = "stock"
        ' 
        ' UpdateButton
        ' 
        UpdateButton.Location = New Point(407, 178)
        UpdateButton.Name = "UpdateButton"
        UpdateButton.Size = New Size(152, 42)
        UpdateButton.TabIndex = 10
        UpdateButton.Text = "Update"
        UpdateButton.UseVisualStyleBackColor = True
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(784, 545)
        ControlBox = False
        Controls.Add(UpdateButton)
        Controls.Add(ListProducts)
        Controls.Add(RemoveButton)
        Controls.Add(AddButton)
        Controls.Add(StockBox)
        Controls.Add(PriceBox)
        Controls.Add(ProductNameBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "AdminForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Admin"
        WindowState = FormWindowState.Maximized
        CType(ListProducts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProductNameBox As TextBox
    Friend WithEvents PriceBox As TextBox
    Friend WithEvents StockBox As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents RemoveButton As Button
    Friend WithEvents ListProducts As DataGridView
    Friend WithEvents UpdateButton As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents product_name As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
End Class
