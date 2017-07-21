<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJual
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
        Dim JumlahBeliLabel As System.Windows.Forms.Label
        Dim KodeBarangLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.btnTransaksiBaru = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PenjualanDetilDataGridView = New System.Windows.Forms.DataGridView()
        Me.idPenjulanDetil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahBeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridPenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanDataSet = New Penjualan.penjualanDataSet()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.KodeBarangTextBox = New System.Windows.Forms.TextBox()
        Me.JumlahBeliTextBox = New System.Windows.Forms.TextBox()
        Me.NoTransaksiTextBox = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbTanggal = New System.Windows.Forms.Label()
        Me.lbitem = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PenjualanMasterPenjualanDetilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanDetilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridPenjualanTableAdapter = New Penjualan.penjualanDataSetTableAdapters.gridPenjualanTableAdapter()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanMasterTableAdapter = New Penjualan.penjualanDataSetTableAdapters.PenjualanMasterTableAdapter()
        Me.BarangTableAdapter = New Penjualan.penjualanDataSetTableAdapters.BarangTableAdapter()
        Me.TableAdapterManager = New Penjualan.penjualanDataSetTableAdapters.TableAdapterManager()
        Me.PenjualanDetilTableAdapter = New Penjualan.penjualanDataSetTableAdapters.PenjualanDetilTableAdapter()
        NoTransaksiLabel = New System.Windows.Forms.Label()
        JumlahBeliLabel = New System.Windows.Forms.Label()
        KodeBarangLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PenjualanDetilDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PenjualanMasterPenjualanDetilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanDetilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoTransaksiLabel
        '
        NoTransaksiLabel.AutoSize = True
        NoTransaksiLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoTransaksiLabel.Location = New System.Drawing.Point(7, 29)
        NoTransaksiLabel.Name = "NoTransaksiLabel"
        NoTransaksiLabel.Size = New System.Drawing.Size(107, 21)
        NoTransaksiLabel.TabIndex = 3
        NoTransaksiLabel.Text = "No Transaksi"
        '
        'JumlahBeliLabel
        '
        JumlahBeliLabel.AutoSize = True
        JumlahBeliLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JumlahBeliLabel.Location = New System.Drawing.Point(7, 99)
        JumlahBeliLabel.Name = "JumlahBeliLabel"
        JumlahBeliLabel.Size = New System.Drawing.Size(70, 21)
        JumlahBeliLabel.TabIndex = 7
        JumlahBeliLabel.Text = "Jumlah "
        '
        'KodeBarangLabel
        '
        KodeBarangLabel.AutoSize = True
        KodeBarangLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KodeBarangLabel.Location = New System.Drawing.Point(7, 64)
        KodeBarangLabel.Name = "KodeBarangLabel"
        KodeBarangLabel.Size = New System.Drawing.Size(107, 21)
        KodeBarangLabel.TabIndex = 5
        KodeBarangLabel.Text = "Kode Barang"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(127, 64)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(14, 21)
        Label4.TabIndex = 5
        Label4.Text = ":"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(127, 99)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(14, 21)
        Label5.TabIndex = 7
        Label5.Text = ":"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(127, 29)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(14, 21)
        Label6.TabIndex = 3
        Label6.Text = ":"
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
        Me.Panel1.Controls.Add(Me.btnTransaksiBaru)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(3, 8)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 721)
        Me.Panel1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(7, 8)
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
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = Global.Penjualan.My.Resources.Resources.Shutdown_32px
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(7, 210)
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
        Me.btnHapus.Location = New System.Drawing.Point(7, 114)
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
        Me.btnBayar.Location = New System.Drawing.Point(7, 162)
        Me.btnBayar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(251, 47)
        Me.btnBayar.TabIndex = 0
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = False
        '
        'btnTransaksiBaru
        '
        Me.btnTransaksiBaru.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnTransaksiBaru.FlatAppearance.BorderSize = 0
        Me.btnTransaksiBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksiBaru.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksiBaru.ForeColor = System.Drawing.Color.White
        Me.btnTransaksiBaru.Image = Global.Penjualan.My.Resources.Resources.Plus_Math_32px
        Me.btnTransaksiBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaksiBaru.Location = New System.Drawing.Point(7, 66)
        Me.btnTransaksiBaru.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTransaksiBaru.Name = "btnTransaksiBaru"
        Me.btnTransaksiBaru.Size = New System.Drawing.Size(251, 47)
        Me.btnTransaksiBaru.TabIndex = 0
        Me.btnTransaksiBaru.Text = "Transaksi Baru"
        Me.btnTransaksiBaru.UseVisualStyleBackColor = False
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
        Me.Panel4.Controls.Add(Me.Panel9)
        Me.Panel4.Location = New System.Drawing.Point(279, 70)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(828, 659)
        Me.Panel4.TabIndex = 12
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
        Me.PenjualanDetilDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPenjulanDetil, Me.KodeBarangDataGridViewTextBoxColumn, Me.NamaBarangDataGridViewTextBoxColumn, Me.SatuanDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.JumlahBeliDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn})
        Me.PenjualanDetilDataGridView.DataSource = Me.GridPenjualanBindingSource
        Me.PenjualanDetilDataGridView.Location = New System.Drawing.Point(6, 225)
        Me.PenjualanDetilDataGridView.Name = "PenjualanDetilDataGridView"
        Me.PenjualanDetilDataGridView.ReadOnly = True
        Me.PenjualanDetilDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PenjualanDetilDataGridView.Size = New System.Drawing.Size(814, 428)
        Me.PenjualanDetilDataGridView.TabIndex = 10
        '
        'idPenjulanDetil
        '
        Me.idPenjulanDetil.DataPropertyName = "idPenjulanDetil"
        Me.idPenjulanDetil.HeaderText = "idPenjulanDetil"
        Me.idPenjulanDetil.Name = "idPenjulanDetil"
        Me.idPenjulanDetil.ReadOnly = True
        Me.idPenjulanDetil.Visible = False
        '
        'KodeBarangDataGridViewTextBoxColumn
        '
        Me.KodeBarangDataGridViewTextBoxColumn.DataPropertyName = "kodeBarang"
        Me.KodeBarangDataGridViewTextBoxColumn.HeaderText = "Kode Barang"
        Me.KodeBarangDataGridViewTextBoxColumn.Name = "KodeBarangDataGridViewTextBoxColumn"
        Me.KodeBarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.KodeBarangDataGridViewTextBoxColumn.Width = 150
        '
        'NamaBarangDataGridViewTextBoxColumn
        '
        Me.NamaBarangDataGridViewTextBoxColumn.DataPropertyName = "namaBarang"
        Me.NamaBarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang"
        Me.NamaBarangDataGridViewTextBoxColumn.Name = "NamaBarangDataGridViewTextBoxColumn"
        Me.NamaBarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaBarangDataGridViewTextBoxColumn.Width = 280
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
        Me.HargaDataGridViewTextBoxColumn.Width = 180
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
        Me.SubTotalDataGridViewTextBoxColumn.HeaderText = "Sub Total"
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        Me.SubTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GridPenjualanBindingSource
        '
        Me.GridPenjualanBindingSource.DataMember = "gridPenjualan"
        Me.GridPenjualanBindingSource.DataSource = Me.PenjualanDataSet
        '
        'PenjualanDataSet
        '
        Me.PenjualanDataSet.DataSetName = "penjualanDataSet"
        Me.PenjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.KodeBarangTextBox)
        Me.Panel5.Controls.Add(Me.JumlahBeliTextBox)
        Me.Panel5.Controls.Add(Label6)
        Me.Panel5.Controls.Add(NoTransaksiLabel)
        Me.Panel5.Controls.Add(Label5)
        Me.Panel5.Controls.Add(JumlahBeliLabel)
        Me.Panel5.Controls.Add(Me.NoTransaksiTextBox)
        Me.Panel5.Controls.Add(Label4)
        Me.Panel5.Controls.Add(KodeBarangLabel)
        Me.Panel5.Location = New System.Drawing.Point(5, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(504, 149)
        Me.Panel5.TabIndex = 14
        '
        'KodeBarangTextBox
        '
        Me.KodeBarangTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeBarangTextBox.Location = New System.Drawing.Point(145, 60)
        Me.KodeBarangTextBox.Name = "KodeBarangTextBox"
        Me.KodeBarangTextBox.Size = New System.Drawing.Size(340, 29)
        Me.KodeBarangTextBox.TabIndex = 6
        '
        'JumlahBeliTextBox
        '
        Me.JumlahBeliTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JumlahBeliTextBox.Location = New System.Drawing.Point(145, 95)
        Me.JumlahBeliTextBox.Name = "JumlahBeliTextBox"
        Me.JumlahBeliTextBox.Size = New System.Drawing.Size(56, 29)
        Me.JumlahBeliTextBox.TabIndex = 8
        Me.JumlahBeliTextBox.Text = "1"
        Me.JumlahBeliTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NoTransaksiTextBox
        '
        Me.NoTransaksiTextBox.BackColor = System.Drawing.Color.Black
        Me.NoTransaksiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NoTransaksiTextBox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoTransaksiTextBox.ForeColor = System.Drawing.Color.Lime
        Me.NoTransaksiTextBox.Location = New System.Drawing.Point(145, 25)
        Me.NoTransaksiTextBox.Name = "NoTransaksiTextBox"
        Me.NoTransaksiTextBox.ReadOnly = True
        Me.NoTransaksiTextBox.Size = New System.Drawing.Size(340, 28)
        Me.NoTransaksiTextBox.TabIndex = 4
        Me.NoTransaksiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(515, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(308, 22)
        Me.Panel6.TabIndex = 15
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
        Me.Label3.Size = New System.Drawing.Size(304, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.lbTanggal)
        Me.Panel7.Controls.Add(Me.lbitem)
        Me.Panel7.Location = New System.Drawing.Point(515, 101)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(308, 30)
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
        Me.lbTanggal.Size = New System.Drawing.Size(152, 26)
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
        Me.lbitem.Size = New System.Drawing.Size(152, 26)
        Me.lbitem.TabIndex = 4
        Me.lbitem.Text = "Item : 0"
        Me.lbitem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.lbTotal)
        Me.Panel8.Location = New System.Drawing.Point(515, 31)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(308, 64)
        Me.Panel8.TabIndex = 11
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
        Me.lbTotal.Size = New System.Drawing.Size(304, 60)
        Me.lbTotal.TabIndex = 4
        Me.lbTotal.Text = "0"
        Me.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Controls.Add(Me.LabelInfo)
        Me.Panel9.Location = New System.Drawing.Point(6, 147)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(814, 72)
        Me.Panel9.TabIndex = 12
        '
        'LabelInfo
        '
        Me.LabelInfo.BackColor = System.Drawing.Color.White
        Me.LabelInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelInfo.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfo.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LabelInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelInfo.Location = New System.Drawing.Point(0, 0)
        Me.LabelInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(810, 68)
        Me.LabelInfo.TabIndex = 2
        Me.LabelInfo.Text = "-"
        Me.LabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(279, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(829, 59)
        Me.Panel3.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Image = Global.Penjualan.My.Resources.Resources.Add_Shopping_Cart_64px
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(827, 57)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "APLIKASI PENJUALAN MITRA RAYA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'PenjualanDetilBindingSource
        '
        Me.PenjualanDetilBindingSource.DataMember = "PenjualanDetil"
        Me.PenjualanDetilBindingSource.DataSource = Me.PenjualanDataSet
        '
        'GridPenjualanTableAdapter
        '
        Me.GridPenjualanTableAdapter.ClearBeforeFill = True
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "Barang"
        Me.BarangBindingSource.DataSource = Me.PenjualanDataSet
        '
        'PenjualanMasterTableAdapter
        '
        Me.PenjualanMasterTableAdapter.ClearBeforeFill = True
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
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
        'PenjualanDetilTableAdapter
        '
        Me.PenjualanDetilTableAdapter.ClearBeforeFill = True
        '
        'FormJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1111, 732)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FormJual"
        Me.Text = "FormJual"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PenjualanDetilDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PenjualanMasterPenjualanDetilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanDetilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBayar As System.Windows.Forms.Button
    Friend WithEvents btnTransaksiBaru As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PenjualanDetilDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GridPenjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PenjualanDataSet As Penjualan.penjualanDataSet
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents KodeBarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PenjualanDetilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JumlahBeliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoTransaksiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents GridPenjualanTableAdapter As Penjualan.penjualanDataSetTableAdapters.gridPenjualanTableAdapter
    Friend WithEvents BarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PenjualanMasterTableAdapter As Penjualan.penjualanDataSetTableAdapters.PenjualanMasterTableAdapter
    Friend WithEvents BarangTableAdapter As Penjualan.penjualanDataSetTableAdapters.BarangTableAdapter
    Friend WithEvents TableAdapterManager As Penjualan.penjualanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PenjualanDetilTableAdapter As Penjualan.penjualanDataSetTableAdapters.PenjualanDetilTableAdapter
    Friend WithEvents PenjualanMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PenjualanMasterPenjualanDetilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LabelInfo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents lbTanggal As System.Windows.Forms.Label
    Friend WithEvents lbitem As System.Windows.Forms.Label
    Friend WithEvents idPenjulanDetil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SatuanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahBeliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
