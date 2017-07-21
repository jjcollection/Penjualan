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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.btnCetakPemesanan = New System.Windows.Forms.Button()
        Me.btnPemesananBaru = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PenjualanDetilDataGridView = New System.Windows.Forms.DataGridView()
        Me.PembelianMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembelianMasterTableAdapter = New Penjualan.penjualanDataSetTableAdapters.PembelianMasterTableAdapter()
        Me.TableAdapterManager = New Penjualan.penjualanDataSetTableAdapters.TableAdapterManager()
        Me.SupplierTableAdapter = New Penjualan.penjualanDataSetTableAdapters.SupplierTableAdapter()
        Me.GridBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridBarangTableAdapter = New Penjualan.penjualanDataSetTableAdapters.gridBarangTableAdapter()
        Me.KodeBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NoTransaksiLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        JumlahBeliLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        KodeBarangLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
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
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanDetilDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoTransaksiLabel
        '
        NoTransaksiLabel.AutoSize = True
        NoTransaksiLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoTransaksiLabel.Location = New System.Drawing.Point(11, 28)
        NoTransaksiLabel.Name = "NoTransaksiLabel"
        NoTransaksiLabel.Size = New System.Drawing.Size(68, 21)
        NoTransaksiLabel.TabIndex = 3
        NoTransaksiLabel.Text = "Nomor "
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(131, 28)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(14, 21)
        Label6.TabIndex = 3
        Label6.Text = ":"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(131, 96)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(14, 21)
        Label5.TabIndex = 7
        Label5.Text = ":"
        '
        'JumlahBeliLabel
        '
        JumlahBeliLabel.AutoSize = True
        JumlahBeliLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JumlahBeliLabel.Location = New System.Drawing.Point(11, 96)
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
        KodeBarangLabel.Location = New System.Drawing.Point(11, 61)
        KodeBarangLabel.Name = "KodeBarangLabel"
        KodeBarangLabel.Size = New System.Drawing.Size(107, 21)
        KodeBarangLabel.TabIndex = 5
        KodeBarangLabel.Text = "Kode Barang"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(308, 28)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(74, 21)
        Label7.TabIndex = 3
        Label7.Text = "Supplier"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(382, 28)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(14, 21)
        Label8.TabIndex = 3
        Label8.Text = ":"
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.lbTanggal)
        Me.Panel7.Controls.Add(Me.lbitem)
        Me.Panel7.Location = New System.Drawing.Point(664, 99)
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
        Me.Panel8.Location = New System.Drawing.Point(664, 28)
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
        Me.KodeBarangTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KodeBarangTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeBarangTextBox.Location = New System.Drawing.Point(149, 57)
        Me.KodeBarangTextBox.Name = "KodeBarangTextBox"
        Me.KodeBarangTextBox.Size = New System.Drawing.Size(503, 29)
        Me.KodeBarangTextBox.TabIndex = 6
        '
        'JumlahBeliTextBox
        '
        Me.JumlahBeliTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JumlahBeliTextBox.Location = New System.Drawing.Point(149, 92)
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
        Me.NoTransaksiTextBox.Location = New System.Drawing.Point(149, 24)
        Me.NoTransaksiTextBox.Name = "NoTransaksiTextBox"
        Me.NoTransaksiTextBox.ReadOnly = True
        Me.NoTransaksiTextBox.Size = New System.Drawing.Size(153, 28)
        Me.NoTransaksiTextBox.TabIndex = 4
        Me.NoTransaksiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(664, 0)
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
        Me.Panel3.Size = New System.Drawing.Size(994, 59)
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
        Me.Label2.Size = New System.Drawing.Size(992, 57)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PEMBELIAN - PURCHASE ORDER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.IdSupplierComboBox)
        Me.Panel5.Controls.Add(Me.KodeBarangTextBox)
        Me.Panel5.Controls.Add(Me.JumlahBeliTextBox)
        Me.Panel5.Controls.Add(Label8)
        Me.Panel5.Controls.Add(Label6)
        Me.Panel5.Controls.Add(Label7)
        Me.Panel5.Controls.Add(NoTransaksiLabel)
        Me.Panel5.Controls.Add(Label5)
        Me.Panel5.Controls.Add(JumlahBeliLabel)
        Me.Panel5.Controls.Add(Me.NoTransaksiTextBox)
        Me.Panel5.Controls.Add(Label4)
        Me.Panel5.Controls.Add(KodeBarangLabel)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(659, 145)
        Me.Panel5.TabIndex = 14
        '
        'IdSupplierComboBox
        '
        Me.IdSupplierComboBox.DataSource = Me.SupplierBindingSource
        Me.IdSupplierComboBox.DisplayMember = "namaSupplier"
        Me.IdSupplierComboBox.FormattingEnabled = True
        Me.IdSupplierComboBox.Location = New System.Drawing.Point(402, 23)
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
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Controls.Add(Me.PenjualanDetilDataGridView)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Location = New System.Drawing.Point(278, 69)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(995, 659)
        Me.Panel4.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Penjualan.My.Resources.Resources.Forward_Button_32px
        Me.PictureBox2.Location = New System.Drawing.Point(494, 355)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Penjualan.My.Resources.Resources.Back_Arrow_32px
        Me.PictureBox1.Location = New System.Drawing.Point(494, 317)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarangDataGridViewTextBoxColumn, Me.NamaBarangDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GridBarangBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 150)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(487, 428)
        Me.DataGridView1.TabIndex = 10
        '
        'PenjualanDetilDataGridView
        '
        Me.PenjualanDetilDataGridView.AllowUserToAddRows = False
        Me.PenjualanDetilDataGridView.AllowUserToDeleteRows = False
        Me.PenjualanDetilDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PenjualanDetilDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PenjualanDetilDataGridView.Location = New System.Drawing.Point(532, 151)
        Me.PenjualanDetilDataGridView.Name = "PenjualanDetilDataGridView"
        Me.PenjualanDetilDataGridView.ReadOnly = True
        Me.PenjualanDetilDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PenjualanDetilDataGridView.Size = New System.Drawing.Size(454, 428)
        Me.PenjualanDetilDataGridView.TabIndex = 10
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
        'GridBarangBindingSource
        '
        Me.GridBarangBindingSource.DataMember = "gridBarang"
        Me.GridBarangBindingSource.DataSource = Me.PenjualanDataSet
        '
        'GridBarangTableAdapter
        '
        Me.GridBarangTableAdapter.ClearBeforeFill = True
        '
        'KodeBarangDataGridViewTextBoxColumn
        '
        Me.KodeBarangDataGridViewTextBoxColumn.DataPropertyName = "kodeBarang"
        Me.KodeBarangDataGridViewTextBoxColumn.HeaderText = "Kode "
        Me.KodeBarangDataGridViewTextBoxColumn.Name = "KodeBarangDataGridViewTextBoxColumn"
        Me.KodeBarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.KodeBarangDataGridViewTextBoxColumn.Width = 120
        '
        'NamaBarangDataGridViewTextBoxColumn
        '
        Me.NamaBarangDataGridViewTextBoxColumn.DataPropertyName = "namaBarang"
        Me.NamaBarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang"
        Me.NamaBarangDataGridViewTextBoxColumn.Name = "NamaBarangDataGridViewTextBoxColumn"
        Me.NamaBarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaBarangDataGridViewTextBoxColumn.Width = 250
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        Me.HargaDataGridViewTextBoxColumn.ReadOnly = True
        Me.HargaDataGridViewTextBoxColumn.Width = 180
        '
        'FormPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1275, 741)
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
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanDetilDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GridBarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridBarangTableAdapter As Penjualan.penjualanDataSetTableAdapters.gridBarangTableAdapter
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
