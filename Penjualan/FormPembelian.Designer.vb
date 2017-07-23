<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembelian
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
        Dim Label6 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim JumlahBeliLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim KodeBarangLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbTanggal = New System.Windows.Forms.Label()
        Me.lbitem = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.KodeBarangTextBox = New System.Windows.Forms.TextBox()
        Me.JumlahBeliTextBox = New System.Windows.Forms.TextBox()
        Me.NoTransaksiTextBox = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.IdSupplierComboBox = New System.Windows.Forms.ComboBox()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanDataSet = New Penjualan.penjualanDataSet()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.btnCetakPemesanan = New System.Windows.Forms.Button()
        Me.btnPemesananBaru = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PenjualanDetilDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdPembelianDetilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPembelianMasterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeBarangDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahBeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalBeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridPembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembelianMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembelianMasterTableAdapter = New Penjualan.penjualanDataSetTableAdapters.PembelianMasterTableAdapter()
        Me.TableAdapterManager = New Penjualan.penjualanDataSetTableAdapters.TableAdapterManager()
        Me.SupplierTableAdapter = New Penjualan.penjualanDataSetTableAdapters.SupplierTableAdapter()
        Me.GridBarangTableAdapter = New Penjualan.penjualanDataSetTableAdapters.gridBarangTableAdapter()
        Me.GridPembelianTableAdapter = New Penjualan.penjualanDataSetTableAdapters.gridPembelianTableAdapter()
        Me.PembelianDetilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembelianDetilTableAdapter = New Penjualan.penjualanDataSetTableAdapters.PembelianDetilTableAdapter()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangTableAdapter = New Penjualan.penjualanDataSetTableAdapters.BarangTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        NoTransaksiLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        JumlahBeliLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        KodeBarangLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PenjualanDetilDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianDetilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoTransaksiLabel
        '
        NoTransaksiLabel.AutoSize = True
        NoTransaksiLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoTransaksiLabel.Location = New System.Drawing.Point(11, 24)
        NoTransaksiLabel.Name = "NoTransaksiLabel"
        NoTransaksiLabel.Size = New System.Drawing.Size(68, 21)
        NoTransaksiLabel.TabIndex = 3
        NoTransaksiLabel.Text = "Nomor "
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(131, 24)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(14, 21)
        Label6.TabIndex = 3
        Label6.Text = ":"
        '
        'Label5
        '
        Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(608, 131)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(14, 21)
        Label5.TabIndex = 7
        Label5.Text = ":"
        '
        'JumlahBeliLabel
        '
        JumlahBeliLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        JumlahBeliLabel.AutoSize = True
        JumlahBeliLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JumlahBeliLabel.Location = New System.Drawing.Point(539, 131)
        JumlahBeliLabel.Name = "JumlahBeliLabel"
        JumlahBeliLabel.Size = New System.Drawing.Size(70, 21)
        JumlahBeliLabel.TabIndex = 7
        JumlahBeliLabel.Text = "Jumlah "
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(131, 61)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(14, 21)
        Label4.TabIndex = 5
        Label4.Text = ":"
        '
        'KodeBarangLabel
        '
        KodeBarangLabel.AutoSize = True
        KodeBarangLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KodeBarangLabel.Location = New System.Drawing.Point(11, 63)
        KodeBarangLabel.Name = "KodeBarangLabel"
        KodeBarangLabel.Size = New System.Drawing.Size(107, 21)
        KodeBarangLabel.TabIndex = 5
        KodeBarangLabel.Text = "Kode Barang"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(341, 24)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(74, 21)
        Label7.TabIndex = 3
        Label7.Text = "Supplier"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(415, 24)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(14, 21)
        Label8.TabIndex = 3
        Label8.Text = ":"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(11, 97)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(56, 21)
        Label9.TabIndex = 5
        Label9.Text = "Nama"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(131, 97)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(14, 21)
        Label10.TabIndex = 5
        Label10.Text = ":"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.Location = New System.Drawing.Point(11, 129)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(56, 21)
        Label11.TabIndex = 5
        Label11.Text = "Harga"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.Location = New System.Drawing.Point(131, 129)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(14, 21)
        Label12.TabIndex = 5
        Label12.Text = ":"
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.lbTanggal)
        Me.Panel7.Controls.Add(Me.lbitem)
        Me.Panel7.Location = New System.Drawing.Point(698, 99)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(324, 40)
        Me.Panel7.TabIndex = 13
        '
        'lbTanggal
        '
        Me.lbTanggal.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbTanggal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbTanggal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbTanggal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTanggal.ForeColor = System.Drawing.Color.White
        Me.lbTanggal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbTanggal.Location = New System.Drawing.Point(152, 0)
        Me.lbTanggal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTanggal.Name = "lbTanggal"
        Me.lbTanggal.Size = New System.Drawing.Size(168, 36)
        Me.lbTanggal.TabIndex = 5
        Me.lbTanggal.Text = "## : ## : ####"
        Me.lbTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbitem
        '
        Me.lbitem.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbitem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbitem.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbitem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbitem.ForeColor = System.Drawing.Color.White
        Me.lbitem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbitem.Location = New System.Drawing.Point(0, 0)
        Me.lbitem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbitem.Name = "lbitem"
        Me.lbitem.Size = New System.Drawing.Size(152, 36)
        Me.lbitem.TabIndex = 4
        Me.lbitem.Text = "Item : 0"
        Me.lbitem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbTotal
        '
        Me.lbTotal.BackColor = System.Drawing.Color.White
        Me.lbTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbTotal.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbTotal.Location = New System.Drawing.Point(0, 0)
        Me.lbTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(320, 60)
        Me.lbTotal.TabIndex = 4
        Me.lbTotal.Text = "0"
        Me.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.lbTotal)
        Me.Panel8.Location = New System.Drawing.Point(698, 28)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(324, 64)
        Me.Panel8.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(320, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'KodeBarangTextBox
        '
        Me.KodeBarangTextBox.BackColor = System.Drawing.Color.White
        Me.KodeBarangTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KodeBarangTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeBarangTextBox.ForeColor = System.Drawing.Color.Black
        Me.KodeBarangTextBox.Location = New System.Drawing.Point(151, 61)
        Me.KodeBarangTextBox.Name = "KodeBarangTextBox"
        Me.KodeBarangTextBox.Size = New System.Drawing.Size(253, 29)
        Me.KodeBarangTextBox.TabIndex = 6
        '
        'JumlahBeliTextBox
        '
        Me.JumlahBeliTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JumlahBeliTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JumlahBeliTextBox.Location = New System.Drawing.Point(630, 128)
        Me.JumlahBeliTextBox.Name = "JumlahBeliTextBox"
        Me.JumlahBeliTextBox.Size = New System.Drawing.Size(56, 29)
        Me.JumlahBeliTextBox.TabIndex = 8
        Me.JumlahBeliTextBox.Text = "1"
        Me.JumlahBeliTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NoTransaksiTextBox
        '
        Me.NoTransaksiTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.NoTransaksiTextBox.BackColor = System.Drawing.Color.DodgerBlue
        Me.NoTransaksiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NoTransaksiTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.NoTransaksiTextBox.ForeColor = System.Drawing.Color.White
        Me.NoTransaksiTextBox.Location = New System.Drawing.Point(149, 20)
        Me.NoTransaksiTextBox.Name = "NoTransaksiTextBox"
        Me.NoTransaksiTextBox.ReadOnly = True
        Me.NoTransaksiTextBox.Size = New System.Drawing.Size(186, 29)
        Me.NoTransaksiTextBox.TabIndex = 4
        Me.NoTransaksiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(698, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(324, 22)
        Me.Panel6.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(279, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1028, 59)
        Me.Panel3.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Image = Global.Penjualan.My.Resources.Resources.Buy_64px
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1026, 57)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PEMBELIAN - PURCHASE ORDER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.IdSupplierComboBox)
        Me.Panel5.Controls.Add(Me.txtHarga)
        Me.Panel5.Controls.Add(Me.txtNama)
        Me.Panel5.Controls.Add(Me.KodeBarangTextBox)
        Me.Panel5.Controls.Add(Me.JumlahBeliTextBox)
        Me.Panel5.Controls.Add(Label8)
        Me.Panel5.Controls.Add(Label6)
        Me.Panel5.Controls.Add(Label7)
        Me.Panel5.Controls.Add(NoTransaksiLabel)
        Me.Panel5.Controls.Add(Label5)
        Me.Panel5.Controls.Add(JumlahBeliLabel)
        Me.Panel5.Controls.Add(Me.NoTransaksiTextBox)
        Me.Panel5.Controls.Add(Label12)
        Me.Panel5.Controls.Add(Label10)
        Me.Panel5.Controls.Add(Label4)
        Me.Panel5.Controls.Add(Label11)
        Me.Panel5.Controls.Add(Label9)
        Me.Panel5.Controls.Add(KodeBarangLabel)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(693, 165)
        Me.Panel5.TabIndex = 14
        '
        'IdSupplierComboBox
        '
        Me.IdSupplierComboBox.DataSource = Me.SupplierBindingSource
        Me.IdSupplierComboBox.DisplayMember = "namaSupplier"
        Me.IdSupplierComboBox.FormattingEnabled = True
        Me.IdSupplierComboBox.Location = New System.Drawing.Point(436, 20)
        Me.IdSupplierComboBox.Name = "IdSupplierComboBox"
        Me.IdSupplierComboBox.Size = New System.Drawing.Size(250, 29)
        Me.IdSupplierComboBox.TabIndex = 12
        Me.IdSupplierComboBox.ValueMember = "idSupplier"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.PenjualanDataSet
        '
        'PenjualanDataSet
        '
        Me.PenjualanDataSet.DataSetName = "penjualanDataSet"
        Me.PenjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtHarga
        '
        Me.txtHarga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHarga.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHarga.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.ForeColor = System.Drawing.Color.White
        Me.txtHarga.Location = New System.Drawing.Point(149, 129)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(384, 29)
        Me.txtHarga.TabIndex = 6
        '
        'txtNama
        '
        Me.txtNama.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNama.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.ForeColor = System.Drawing.Color.White
        Me.txtNama.Location = New System.Drawing.Point(149, 94)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.ReadOnly = True
        Me.txtNama.Size = New System.Drawing.Size(537, 29)
        Me.txtNama.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(7, 5)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(251, 48)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.Penjualan.My.Resources.Resources.Menu_White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MENU"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Controls.Add(Me.btnBayar)
        Me.Panel1.Controls.Add(Me.btnCetakPemesanan)
        Me.Panel1.Controls.Add(Me.btnPemesananBaru)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 721)
        Me.Panel1.TabIndex = 13
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = Global.Penjualan.My.Resources.Resources.Shutdown_32px
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(7, 263)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(251, 47)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Keluar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Image = Global.Penjualan.My.Resources.Resources.Trash_Can_32px
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHapus.Location = New System.Drawing.Point(7, 113)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(251, 47)
        Me.btnHapus.TabIndex = 0
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnBayar
        '
        Me.btnBayar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBayar.FlatAppearance.BorderSize = 0
        Me.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBayar.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.ForeColor = System.Drawing.Color.White
        Me.btnBayar.Image = Global.Penjualan.My.Resources.Resources.Money_32px
        Me.btnBayar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBayar.Location = New System.Drawing.Point(7, 163)
        Me.btnBayar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(251, 47)
        Me.btnBayar.TabIndex = 0
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = False
        '
        'btnCetakPemesanan
        '
        Me.btnCetakPemesanan.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCetakPemesanan.FlatAppearance.BorderSize = 0
        Me.btnCetakPemesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetakPemesanan.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetakPemesanan.ForeColor = System.Drawing.Color.White
        Me.btnCetakPemesanan.Image = Global.Penjualan.My.Resources.Resources.Printer_Maintenance_32px
        Me.btnCetakPemesanan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCetakPemesanan.Location = New System.Drawing.Point(7, 213)
        Me.btnCetakPemesanan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCetakPemesanan.Name = "btnCetakPemesanan"
        Me.btnCetakPemesanan.Size = New System.Drawing.Size(251, 47)
        Me.btnCetakPemesanan.TabIndex = 0
        Me.btnCetakPemesanan.Text = "Cetak Pemesanan"
        Me.btnCetakPemesanan.UseVisualStyleBackColor = False
        '
        'btnPemesananBaru
        '
        Me.btnPemesananBaru.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnPemesananBaru.FlatAppearance.BorderSize = 0
        Me.btnPemesananBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPemesananBaru.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPemesananBaru.ForeColor = System.Drawing.Color.White
        Me.btnPemesananBaru.Image = Global.Penjualan.My.Resources.Resources.Plus_Math_32px
        Me.btnPemesananBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPemesananBaru.Location = New System.Drawing.Point(7, 63)
        Me.btnPemesananBaru.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPemesananBaru.Name = "btnPemesananBaru"
        Me.btnPemesananBaru.Size = New System.Drawing.Size(251, 47)
        Me.btnPemesananBaru.TabIndex = 0
        Me.btnPemesananBaru.Text = "Pemesanan Baru"
        Me.btnPemesananBaru.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PenjualanDetilDataGridView)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Location = New System.Drawing.Point(278, 69)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1029, 659)
        Me.Panel4.TabIndex = 15
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
        Me.PenjualanDetilDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPembelianDetilDataGridViewTextBoxColumn, Me.IdPembelianMasterDataGridViewTextBoxColumn, Me.KodeBarangDataGridViewTextBoxColumn1, Me.NamaBarangDataGridViewTextBoxColumn1, Me.JumlahBeliDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn1, Me.SubTotalBeliDataGridViewTextBoxColumn})
        Me.PenjualanDetilDataGridView.DataSource = Me.GridPembelianBindingSource
        Me.PenjualanDetilDataGridView.Location = New System.Drawing.Point(6, 190)
        Me.PenjualanDetilDataGridView.Name = "PenjualanDetilDataGridView"
        Me.PenjualanDetilDataGridView.ReadOnly = True
        Me.PenjualanDetilDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PenjualanDetilDataGridView.Size = New System.Drawing.Size(1014, 464)
        Me.PenjualanDetilDataGridView.TabIndex = 10
        '
        'IdPembelianDetilDataGridViewTextBoxColumn
        '
        Me.IdPembelianDetilDataGridViewTextBoxColumn.DataPropertyName = "idPembelianDetil"
        Me.IdPembelianDetilDataGridViewTextBoxColumn.HeaderText = "idPembelianDetil"
        Me.IdPembelianDetilDataGridViewTextBoxColumn.Name = "IdPembelianDetilDataGridViewTextBoxColumn"
        Me.IdPembelianDetilDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPembelianDetilDataGridViewTextBoxColumn.Visible = False
        '
        'IdPembelianMasterDataGridViewTextBoxColumn
        '
        Me.IdPembelianMasterDataGridViewTextBoxColumn.DataPropertyName = "idPembelianMaster"
        Me.IdPembelianMasterDataGridViewTextBoxColumn.HeaderText = "idPembelianMaster"
        Me.IdPembelianMasterDataGridViewTextBoxColumn.Name = "IdPembelianMasterDataGridViewTextBoxColumn"
        Me.IdPembelianMasterDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPembelianMasterDataGridViewTextBoxColumn.Visible = False
        '
        'KodeBarangDataGridViewTextBoxColumn1
        '
        Me.KodeBarangDataGridViewTextBoxColumn1.DataPropertyName = "kodeBarang"
        Me.KodeBarangDataGridViewTextBoxColumn1.HeaderText = "Kode "
        Me.KodeBarangDataGridViewTextBoxColumn1.Name = "KodeBarangDataGridViewTextBoxColumn1"
        Me.KodeBarangDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NamaBarangDataGridViewTextBoxColumn1
        '
        Me.NamaBarangDataGridViewTextBoxColumn1.DataPropertyName = "namaBarang"
        Me.NamaBarangDataGridViewTextBoxColumn1.HeaderText = "Nama Barang"
        Me.NamaBarangDataGridViewTextBoxColumn1.Name = "NamaBarangDataGridViewTextBoxColumn1"
        Me.NamaBarangDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NamaBarangDataGridViewTextBoxColumn1.Width = 350
        '
        'JumlahBeliDataGridViewTextBoxColumn
        '
        Me.JumlahBeliDataGridViewTextBoxColumn.DataPropertyName = "jumlahBeli"
        Me.JumlahBeliDataGridViewTextBoxColumn.HeaderText = "Jumlah "
        Me.JumlahBeliDataGridViewTextBoxColumn.Name = "JumlahBeliDataGridViewTextBoxColumn"
        Me.JumlahBeliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HargaDataGridViewTextBoxColumn1
        '
        Me.HargaDataGridViewTextBoxColumn1.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn1.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn1.Name = "HargaDataGridViewTextBoxColumn1"
        Me.HargaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SubTotalBeliDataGridViewTextBoxColumn
        '
        Me.SubTotalBeliDataGridViewTextBoxColumn.DataPropertyName = "subTotalBeli"
        Me.SubTotalBeliDataGridViewTextBoxColumn.HeaderText = "Sub Total"
        Me.SubTotalBeliDataGridViewTextBoxColumn.Name = "SubTotalBeliDataGridViewTextBoxColumn"
        Me.SubTotalBeliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GridPembelianBindingSource
        '
        Me.GridPembelianBindingSource.DataMember = "gridPembelian"
        Me.GridPembelianBindingSource.DataSource = Me.PenjualanDataSet
        '
        'GridBarangBindingSource
        '
        Me.GridBarangBindingSource.DataMember = "gridBarang"
        Me.GridBarangBindingSource.DataSource = Me.PenjualanDataSet
        '
        'PembelianMasterBindingSource
        '
        Me.PembelianMasterBindingSource.DataMember = "PembelianMaster"
        Me.PembelianMasterBindingSource.DataSource = Me.PenjualanDataSet
        '
        'PembelianMasterTableAdapter
        '
        Me.PembelianMasterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BarangTableAdapter = Nothing
        Me.TableAdapterManager.JenisTableAdapter = Nothing
        Me.TableAdapterManager.PembelianDetilTableAdapter = Nothing
        Me.TableAdapterManager.PembelianMasterTableAdapter = Me.PembelianMasterTableAdapter
        Me.TableAdapterManager.PenjualanDetilTableAdapter = Nothing
        Me.TableAdapterManager.PenjualanMasterTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Penjualan.penjualanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'GridBarangTableAdapter
        '
        Me.GridBarangTableAdapter.ClearBeforeFill = True
        '
        'GridPembelianTableAdapter
        '
        Me.GridPembelianTableAdapter.ClearBeforeFill = True
        '
        'PembelianDetilBindingSource
        '
        Me.PembelianDetilBindingSource.DataMember = "PembelianDetil"
        Me.PembelianDetilBindingSource.DataSource = Me.PenjualanDataSet
        '
        'PembelianDetilTableAdapter
        '
        Me.PembelianDetilTableAdapter.ClearBeforeFill = True
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "Barang"
        Me.BarangBindingSource.DataSource = Me.PenjualanDataSet
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.Penjualan.My.Resources.Resources.Search_16px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(410, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 29)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cari"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FormPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1309, 741)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormPembelian"
        Me.Text = "FormPembelian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PenjualanDetilDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianDetilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lbTanggal As System.Windows.Forms.Label
    Friend WithEvents lbitem As System.Windows.Forms.Label
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents KodeBarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JumlahBeliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoTransaksiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnBayar As System.Windows.Forms.Button
    Friend WithEvents btnPemesananBaru As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PenjualanDetilDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnCetakPemesanan As System.Windows.Forms.Button
    Friend WithEvents PenjualanDataSet As Penjualan.penjualanDataSet
    Friend WithEvents PembelianMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PembelianMasterTableAdapter As Penjualan.penjualanDataSetTableAdapters.PembelianMasterTableAdapter
    Friend WithEvents TableAdapterManager As Penjualan.penjualanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdSupplierComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As Penjualan.penjualanDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents GridBarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridBarangTableAdapter As Penjualan.penjualanDataSetTableAdapters.gridBarangTableAdapter
    Friend WithEvents GridPembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridPembelianTableAdapter As Penjualan.penjualanDataSetTableAdapters.gridPembelianTableAdapter
    Friend WithEvents PembelianDetilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PembelianDetilTableAdapter As Penjualan.penjualanDataSetTableAdapters.PembelianDetilTableAdapter
    Friend WithEvents BarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarangTableAdapter As Penjualan.penjualanDataSetTableAdapters.BarangTableAdapter
    Friend WithEvents IdPembelianDetilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPembelianMasterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahBeliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalBeliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
