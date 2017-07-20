<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Dim NoTransaksiLabel As System.Windows.Forms.Label
        Dim KodeBarangLabel As System.Windows.Forms.Label
        Dim JumlahBeliLabel As System.Windows.Forms.Label
        Me.PenjualanDetilDataGridView = New System.Windows.Forms.DataGridView()
        Me.PenjualanMasterPenjualanDetilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanDataSet = New Penjualan.penjualanDataSet()
        Me.PenjualanDetilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanDetilTableAdapter = New Penjualan.penjualanDataSetTableAdapters.PenjualanDetilTableAdapter()
        Me.TableAdapterManager = New Penjualan.penjualanDataSetTableAdapters.TableAdapterManager()
        Me.BarangTableAdapter = New Penjualan.penjualanDataSetTableAdapters.BarangTableAdapter()
        Me.PenjualanMasterTableAdapter = New Penjualan.penjualanDataSetTableAdapters.PenjualanMasterTableAdapter()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridPenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridPenjualanTableAdapter = New Penjualan.penjualanDataSetTableAdapters.gridPenjualanTableAdapter()
        Me.KodeBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahBeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoTransaksiTextBox = New System.Windows.Forms.TextBox()
        Me.KodeBarangTextBox = New System.Windows.Forms.TextBox()
        Me.JumlahBeliTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        NoTransaksiLabel = New System.Windows.Forms.Label()
        KodeBarangLabel = New System.Windows.Forms.Label()
        JumlahBeliLabel = New System.Windows.Forms.Label()
        CType(Me.PenjualanDetilDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanMasterPenjualanDetilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanDetilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PenjualanDetilDataGridView
        '
        Me.PenjualanDetilDataGridView.AllowUserToAddRows = False
        Me.PenjualanDetilDataGridView.AllowUserToDeleteRows = False
        Me.PenjualanDetilDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PenjualanDetilDataGridView.AutoGenerateColumns = False
        Me.PenjualanDetilDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PenjualanDetilDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarangDataGridViewTextBoxColumn, Me.NamaBarangDataGridViewTextBoxColumn, Me.SatuanDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.JumlahBeliDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn})
        Me.PenjualanDetilDataGridView.DataSource = Me.GridPenjualanBindingSource
        Me.PenjualanDetilDataGridView.Location = New System.Drawing.Point(12, 232)
        Me.PenjualanDetilDataGridView.Name = "PenjualanDetilDataGridView"
        Me.PenjualanDetilDataGridView.ReadOnly = True
        Me.PenjualanDetilDataGridView.Size = New System.Drawing.Size(901, 295)
        Me.PenjualanDetilDataGridView.TabIndex = 1
        '
        'PenjualanMasterPenjualanDetilBindingSource
        '
        Me.PenjualanMasterPenjualanDetilBindingSource.DataMember = "PenjualanMasterPenjualanDetil"
        Me.PenjualanMasterPenjualanDetilBindingSource.DataSource = Me.PenjualanMasterBindingSource
        '
        'PenjualanMasterBindingSource
        '
        Me.PenjualanMasterBindingSource.DataMember = "PenjualanMaster"
        Me.PenjualanMasterBindingSource.DataSource = Me.PenjualanDataSet
        '
        'PenjualanDataSet
        '
        Me.PenjualanDataSet.DataSetName = "penjualanDataSet"
        Me.PenjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PenjualanDetilBindingSource
        '
        Me.PenjualanDetilBindingSource.DataMember = "PenjualanDetil"
        Me.PenjualanDetilBindingSource.DataSource = Me.PenjualanDataSet
        '
        'PenjualanDetilTableAdapter
        '
        Me.PenjualanDetilTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BarangTableAdapter = Me.BarangTableAdapter
        Me.TableAdapterManager.JenisTableAdapter = Nothing
        Me.TableAdapterManager.PembelianDetilTableAdapter = Nothing
        Me.TableAdapterManager.PembelianMasterTableAdapter = Nothing
        Me.TableAdapterManager.PenjualanDetilTableAdapter = Me.PenjualanDetilTableAdapter
        Me.TableAdapterManager.PenjualanMasterTableAdapter = Me.PenjualanMasterTableAdapter
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Penjualan.penjualanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'PenjualanMasterTableAdapter
        '
        Me.PenjualanMasterTableAdapter.ClearBeforeFill = True
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "Barang"
        Me.BarangBindingSource.DataSource = Me.PenjualanDataSet
        '
        'GridPenjualanBindingSource
        '
        Me.GridPenjualanBindingSource.DataMember = "gridPenjualan"
        Me.GridPenjualanBindingSource.DataSource = Me.PenjualanDataSet
        '
        'GridPenjualanTableAdapter
        '
        Me.GridPenjualanTableAdapter.ClearBeforeFill = True
        '
        'KodeBarangDataGridViewTextBoxColumn
        '
        Me.KodeBarangDataGridViewTextBoxColumn.DataPropertyName = "kodeBarang"
        Me.KodeBarangDataGridViewTextBoxColumn.HeaderText = "Kode Barang"
        Me.KodeBarangDataGridViewTextBoxColumn.Name = "KodeBarangDataGridViewTextBoxColumn"
        Me.KodeBarangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaBarangDataGridViewTextBoxColumn
        '
        Me.NamaBarangDataGridViewTextBoxColumn.DataPropertyName = "namaBarang"
        Me.NamaBarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang"
        Me.NamaBarangDataGridViewTextBoxColumn.Name = "NamaBarangDataGridViewTextBoxColumn"
        Me.NamaBarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaBarangDataGridViewTextBoxColumn.Width = 200
        '
        'SatuanDataGridViewTextBoxColumn
        '
        Me.SatuanDataGridViewTextBoxColumn.DataPropertyName = "satuan"
        Me.SatuanDataGridViewTextBoxColumn.HeaderText = "Satuan"
        Me.SatuanDataGridViewTextBoxColumn.Name = "SatuanDataGridViewTextBoxColumn"
        Me.SatuanDataGridViewTextBoxColumn.ReadOnly = True
        Me.SatuanDataGridViewTextBoxColumn.Width = 80
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        Me.HargaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JumlahBeliDataGridViewTextBoxColumn
        '
        Me.JumlahBeliDataGridViewTextBoxColumn.DataPropertyName = "jumlahBeli"
        Me.JumlahBeliDataGridViewTextBoxColumn.HeaderText = "Jml"
        Me.JumlahBeliDataGridViewTextBoxColumn.Name = "JumlahBeliDataGridViewTextBoxColumn"
        Me.JumlahBeliDataGridViewTextBoxColumn.ReadOnly = True
        Me.JumlahBeliDataGridViewTextBoxColumn.Width = 50
        '
        'SubTotalDataGridViewTextBoxColumn
        '
        Me.SubTotalDataGridViewTextBoxColumn.DataPropertyName = "subTotal"
        Me.SubTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal"
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        Me.SubTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoTransaksiLabel
        '
        NoTransaksiLabel.AutoSize = True
        NoTransaksiLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        NoTransaksiLabel.Location = New System.Drawing.Point(3, 15)
        NoTransaksiLabel.Name = "NoTransaksiLabel"
        NoTransaksiLabel.Size = New System.Drawing.Size(125, 24)
        NoTransaksiLabel.TabIndex = 3
        NoTransaksiLabel.Text = "No Transaksi:"
        '
        'NoTransaksiTextBox
        '
        Me.NoTransaksiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PenjualanDetilBindingSource, "noTransaksi", True))
        Me.NoTransaksiTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.NoTransaksiTextBox.Location = New System.Drawing.Point(136, 13)
        Me.NoTransaksiTextBox.Name = "NoTransaksiTextBox"
        Me.NoTransaksiTextBox.Size = New System.Drawing.Size(335, 29)
        Me.NoTransaksiTextBox.TabIndex = 4
        '
        'KodeBarangLabel
        '
        KodeBarangLabel.AutoSize = True
        KodeBarangLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        KodeBarangLabel.Location = New System.Drawing.Point(3, 50)
        KodeBarangLabel.Name = "KodeBarangLabel"
        KodeBarangLabel.Size = New System.Drawing.Size(125, 24)
        KodeBarangLabel.TabIndex = 5
        KodeBarangLabel.Text = "Kode Barang:"
        '
        'KodeBarangTextBox
        '
        Me.KodeBarangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PenjualanDetilBindingSource, "kodeBarang", True))
        Me.KodeBarangTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeBarangTextBox.Location = New System.Drawing.Point(136, 48)
        Me.KodeBarangTextBox.Name = "KodeBarangTextBox"
        Me.KodeBarangTextBox.Size = New System.Drawing.Size(335, 29)
        Me.KodeBarangTextBox.TabIndex = 6
        '
        'JumlahBeliLabel
        '
        JumlahBeliLabel.AutoSize = True
        JumlahBeliLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        JumlahBeliLabel.Location = New System.Drawing.Point(3, 85)
        JumlahBeliLabel.Name = "JumlahBeliLabel"
        JumlahBeliLabel.Size = New System.Drawing.Size(81, 24)
        JumlahBeliLabel.TabIndex = 7
        JumlahBeliLabel.Text = "Jumlah :"
        '
        'JumlahBeliTextBox
        '
        Me.JumlahBeliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PenjualanDetilBindingSource, "jumlahBeli", True))
        Me.JumlahBeliTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.JumlahBeliTextBox.Location = New System.Drawing.Point(136, 83)
        Me.JumlahBeliTextBox.Name = "JumlahBeliTextBox"
        Me.JumlahBeliTextBox.Size = New System.Drawing.Size(100, 29)
        Me.JumlahBeliTextBox.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(12, 154)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 72)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.KodeBarangTextBox)
        Me.Panel2.Controls.Add(Me.JumlahBeliTextBox)
        Me.Panel2.Controls.Add(NoTransaksiLabel)
        Me.Panel2.Controls.Add(JumlahBeliLabel)
        Me.Panel2.Controls.Add(Me.NoTransaksiTextBox)
        Me.Panel2.Controls.Add(KodeBarangLabel)
        Me.Panel2.Location = New System.Drawing.Point(12, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(502, 128)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Location = New System.Drawing.Point(520, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(393, 59)
        Me.Panel3.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Location = New System.Drawing.Point(520, 103)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(393, 35)
        Me.Panel4.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Location = New System.Drawing.Point(520, 10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(393, 22)
        Me.Panel5.TabIndex = 9
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 539)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PenjualanDetilDataGridView)
        Me.Name = "FormPenjualan"
        Me.Text = "FormPenjualan"
        CType(Me.PenjualanDetilDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanMasterPenjualanDetilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanDetilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PenjualanDataSet As Penjualan.penjualanDataSet
    Friend WithEvents PenjualanDetilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PenjualanDetilTableAdapter As Penjualan.penjualanDataSetTableAdapters.PenjualanDetilTableAdapter
    Friend WithEvents TableAdapterManager As Penjualan.penjualanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PenjualanMasterTableAdapter As Penjualan.penjualanDataSetTableAdapters.PenjualanMasterTableAdapter
    Friend WithEvents PenjualanDetilDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PenjualanMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarangTableAdapter As Penjualan.penjualanDataSetTableAdapters.BarangTableAdapter
    Friend WithEvents PenjualanMasterPenjualanDetilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridPenjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridPenjualanTableAdapter As Penjualan.penjualanDataSetTableAdapters.gridPenjualanTableAdapter
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatuanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahBeliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoTransaksiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KodeBarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JumlahBeliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
