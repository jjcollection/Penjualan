<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTerimaStok
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
        Dim Label6 As System.Windows.Forms.Label
        Dim NoTransaksiLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim KodeBarangLabel As System.Windows.Forms.Label
        Dim TanggalBeliLabel As System.Windows.Forms.Label
        Dim IdSupplierLabel1 As System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PenjualanDetilDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TanggalBeliDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.KodeBarangTextBox = New System.Windows.Forms.TextBox()
        Me.NoTransaksiTextBox = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbTanggal = New System.Windows.Forms.Label()
        Me.lbitem = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.IdSupplierLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.btnCetakPemesanan = New System.Windows.Forms.Button()
        Me.btnPemesananBaru = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridPembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanDataSet = New Penjualan.penjualanDataSet()
        Me.GridSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridPembelianTableAdapter = New Penjualan.penjualanDataSetTableAdapters.gridPembelianTableAdapter()
        Me.PembelianMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembelianMasterTableAdapter = New Penjualan.penjualanDataSetTableAdapters.PembelianMasterTableAdapter()
        Me.TableAdapterManager = New Penjualan.penjualanDataSetTableAdapters.TableAdapterManager()
        Me.GridSupplierTableAdapter = New Penjualan.penjualanDataSetTableAdapters.gridSupplierTableAdapter()
        Me.IdPembelianDetilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPembelianMasterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahBeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jmlDatang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PembelianDetilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembelianDetilTableAdapter = New Penjualan.penjualanDataSetTableAdapters.PembelianDetilTableAdapter()
        Label6 = New System.Windows.Forms.Label()
        NoTransaksiLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        KodeBarangLabel = New System.Windows.Forms.Label()
        TanggalBeliLabel = New System.Windows.Forms.Label()
        IdSupplierLabel1 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.PenjualanDetilDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GridPembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianDetilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(133, 11)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(14, 21)
        Label6.TabIndex = 3
        Label6.Text = ":"
        '
        'NoTransaksiLabel
        '
        NoTransaksiLabel.AutoSize = True
        NoTransaksiLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoTransaksiLabel.Location = New System.Drawing.Point(13, 11)
        NoTransaksiLabel.Name = "NoTransaksiLabel"
        NoTransaksiLabel.Size = New System.Drawing.Size(125, 21)
        NoTransaksiLabel.TabIndex = 3
        NoTransaksiLabel.Text = "No Pemesanan"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(412, 9)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(14, 21)
        Label4.TabIndex = 5
        Label4.Text = ":"
        '
        'KodeBarangLabel
        '
        KodeBarangLabel.AutoSize = True
        KodeBarangLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KodeBarangLabel.Location = New System.Drawing.Point(292, 11)
        KodeBarangLabel.Name = "KodeBarangLabel"
        KodeBarangLabel.Size = New System.Drawing.Size(85, 21)
        KodeBarangLabel.TabIndex = 5
        KodeBarangLabel.Text = "No Faktur"
        '
        'TanggalBeliLabel
        '
        TanggalBeliLabel.AutoSize = True
        TanggalBeliLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TanggalBeliLabel.Location = New System.Drawing.Point(33, 41)
        TanggalBeliLabel.Name = "TanggalBeliLabel"
        TanggalBeliLabel.Size = New System.Drawing.Size(128, 21)
        TanggalBeliLabel.TabIndex = 0
        TanggalBeliLabel.Text = "Tanggal Pesan :"
        '
        'IdSupplierLabel1
        '
        IdSupplierLabel1.AutoSize = True
        IdSupplierLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdSupplierLabel1.Location = New System.Drawing.Point(29, 84)
        IdSupplierLabel1.Name = "IdSupplierLabel1"
        IdSupplierLabel1.Size = New System.Drawing.Size(132, 21)
        IdSupplierLabel1.TabIndex = 3
        IdSupplierLabel1.Text = "Nama Supplier :"
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
        Me.Panel4.Location = New System.Drawing.Point(276, 69)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1039, 659)
        Me.Panel4.TabIndex = 18
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
        Me.PenjualanDetilDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPembelianDetilDataGridViewTextBoxColumn, Me.IdPembelianMasterDataGridViewTextBoxColumn, Me.KodeBarangDataGridViewTextBoxColumn, Me.NamaBarangDataGridViewTextBoxColumn, Me.JumlahBeliDataGridViewTextBoxColumn, Me.jmlDatang, Me.HargaDataGridViewTextBoxColumn, Me.SubTotal})
        Me.PenjualanDetilDataGridView.DataSource = Me.GridPembelianBindingSource
        Me.PenjualanDetilDataGridView.Location = New System.Drawing.Point(6, 214)
        Me.PenjualanDetilDataGridView.Name = "PenjualanDetilDataGridView"
        Me.PenjualanDetilDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.PenjualanDetilDataGridView.Size = New System.Drawing.Size(1024, 440)
        Me.PenjualanDetilDataGridView.TabIndex = 10
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Controls.Add(Me.KodeBarangTextBox)
        Me.Panel5.Controls.Add(Label6)
        Me.Panel5.Controls.Add(NoTransaksiLabel)
        Me.Panel5.Controls.Add(Me.NoTransaksiTextBox)
        Me.Panel5.Controls.Add(Label4)
        Me.Panel5.Controls.Add(KodeBarangLabel)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(703, 230)
        Me.Panel5.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IdSupplierLabel1)
        Me.GroupBox1.Controls.Add(Me.IdSupplierLabel)
        Me.GroupBox1.Controls.Add(TanggalBeliLabel)
        Me.GroupBox1.Controls.Add(Me.TanggalBeliDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(669, 135)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detil Pemesanan"
        '
        'TanggalBeliDateTimePicker
        '
        Me.TanggalBeliDateTimePicker.Location = New System.Drawing.Point(169, 37)
        Me.TanggalBeliDateTimePicker.Name = "TanggalBeliDateTimePicker"
        Me.TanggalBeliDateTimePicker.Size = New System.Drawing.Size(298, 29)
        Me.TanggalBeliDateTimePicker.TabIndex = 1
        '
        'KodeBarangTextBox
        '
        Me.KodeBarangTextBox.BackColor = System.Drawing.Color.White
        Me.KodeBarangTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KodeBarangTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeBarangTextBox.ForeColor = System.Drawing.Color.Black
        Me.KodeBarangTextBox.Location = New System.Drawing.Point(296, 35)
        Me.KodeBarangTextBox.Name = "KodeBarangTextBox"
        Me.KodeBarangTextBox.Size = New System.Drawing.Size(255, 29)
        Me.KodeBarangTextBox.TabIndex = 6
        '
        'NoTransaksiTextBox
        '
        Me.NoTransaksiTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.NoTransaksiTextBox.BackColor = System.Drawing.Color.DodgerBlue
        Me.NoTransaksiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NoTransaksiTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.NoTransaksiTextBox.ForeColor = System.Drawing.Color.White
        Me.NoTransaksiTextBox.Location = New System.Drawing.Point(17, 35)
        Me.NoTransaksiTextBox.Name = "NoTransaksiTextBox"
        Me.NoTransaksiTextBox.Size = New System.Drawing.Size(255, 29)
        Me.NoTransaksiTextBox.TabIndex = 4
        Me.NoTransaksiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(708, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(324, 22)
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
        Me.Label3.Size = New System.Drawing.Size(320, 18)
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
        Me.Panel7.Location = New System.Drawing.Point(708, 99)
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
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.lbTotal)
        Me.Panel8.Location = New System.Drawing.Point(708, 28)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(324, 64)
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
        Me.lbTotal.Size = New System.Drawing.Size(320, 60)
        Me.lbTotal.TabIndex = 4
        Me.lbTotal.Text = "0"
        Me.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Controls.Add(Me.btnBayar)
        Me.Panel1.Controls.Add(Me.btnCetakPemesanan)
        Me.Panel1.Controls.Add(Me.btnPemesananBaru)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 721)
        Me.Panel1.TabIndex = 16
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
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(277, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1038, 59)
        Me.Panel3.TabIndex = 17
        '
        'IdSupplierLabel
        '
        Me.IdSupplierLabel.Location = New System.Drawing.Point(169, 84)
        Me.IdSupplierLabel.Name = "IdSupplierLabel"
        Me.IdSupplierLabel.Size = New System.Drawing.Size(302, 23)
        Me.IdSupplierLabel.TabIndex = 4
        Me.IdSupplierLabel.Text = "-"
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
        Me.Button6.Location = New System.Drawing.Point(7, 303)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(251, 47)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Keluar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Image = Global.Penjualan.My.Resources.Resources.Save_32px
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(7, 159)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(251, 47)
        Me.btnSimpan.TabIndex = 0
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
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
        Me.btnHapus.Location = New System.Drawing.Point(7, 111)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(251, 47)
        Me.btnHapus.TabIndex = 0
        Me.btnHapus.Text = "Hapus Item"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnBayar
        '
        Me.btnBayar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBayar.FlatAppearance.BorderSize = 0
        Me.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBayar.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.ForeColor = System.Drawing.Color.White
        Me.btnBayar.Image = Global.Penjualan.My.Resources.Resources.Sync_32px
        Me.btnBayar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBayar.Location = New System.Drawing.Point(7, 207)
        Me.btnBayar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(251, 47)
        Me.btnBayar.TabIndex = 0
        Me.btnBayar.Text = "Return"
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
        Me.btnCetakPemesanan.Location = New System.Drawing.Point(7, 255)
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Image = Global.Penjualan.My.Resources.Resources.Move_Stock_64px
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1036, 57)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PEMBELIAN - STOK MASUK"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridPembelianBindingSource
        '
        Me.GridPembelianBindingSource.DataMember = "gridPembelian"
        Me.GridPembelianBindingSource.DataSource = Me.PenjualanDataSet
        '
        'PenjualanDataSet
        '
        Me.PenjualanDataSet.DataSetName = "penjualanDataSet"
        Me.PenjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridSupplierBindingSource
        '
        Me.GridSupplierBindingSource.DataMember = "gridSupplier"
        Me.GridSupplierBindingSource.DataSource = Me.PenjualanDataSet
        '
        'GridPembelianTableAdapter
        '
        Me.GridPembelianTableAdapter.ClearBeforeFill = True
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
        'GridSupplierTableAdapter
        '
        Me.GridSupplierTableAdapter.ClearBeforeFill = True
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
        'KodeBarangDataGridViewTextBoxColumn
        '
        Me.KodeBarangDataGridViewTextBoxColumn.DataPropertyName = "kodeBarang"
        Me.KodeBarangDataGridViewTextBoxColumn.HeaderText = "Kode Barang"
        Me.KodeBarangDataGridViewTextBoxColumn.Name = "KodeBarangDataGridViewTextBoxColumn"
        Me.KodeBarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.KodeBarangDataGridViewTextBoxColumn.Width = 180
        '
        'NamaBarangDataGridViewTextBoxColumn
        '
        Me.NamaBarangDataGridViewTextBoxColumn.DataPropertyName = "namaBarang"
        Me.NamaBarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang"
        Me.NamaBarangDataGridViewTextBoxColumn.Name = "NamaBarangDataGridViewTextBoxColumn"
        Me.NamaBarangDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamaBarangDataGridViewTextBoxColumn.Width = 250
        '
        'JumlahBeliDataGridViewTextBoxColumn
        '
        Me.JumlahBeliDataGridViewTextBoxColumn.DataPropertyName = "jumlahBeli"
        Me.JumlahBeliDataGridViewTextBoxColumn.HeaderText = "Jml Beli"
        Me.JumlahBeliDataGridViewTextBoxColumn.Name = "JumlahBeliDataGridViewTextBoxColumn"
        Me.JumlahBeliDataGridViewTextBoxColumn.ReadOnly = True
        '
        'jmlDatang
        '
        Me.jmlDatang.HeaderText = "Jml Datang"
        Me.jmlDatang.Name = "jmlDatang"
        Me.jmlDatang.Width = 120
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        Me.HargaDataGridViewTextBoxColumn.Width = 180
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "Sub Total"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        Me.SubTotal.Width = 180
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
        'FormTerimaStok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1319, 733)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormTerimaStok"
        Me.Text = "FormTerimaStok"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel4.ResumeLayout(False)
        CType(Me.PenjualanDetilDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GridPembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianDetilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PenjualanDetilDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents KodeBarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoTransaksiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lbTanggal As System.Windows.Forms.Label
    Friend WithEvents lbitem As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBayar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCetakPemesanan As System.Windows.Forms.Button
    Friend WithEvents btnPemesananBaru As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PenjualanDataSet As Penjualan.penjualanDataSet
    Friend WithEvents GridPembelianBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridPembelianTableAdapter As Penjualan.penjualanDataSetTableAdapters.gridPembelianTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PembelianMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PembelianMasterTableAdapter As Penjualan.penjualanDataSetTableAdapters.PembelianMasterTableAdapter
    Friend WithEvents TableAdapterManager As Penjualan.penjualanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TanggalBeliDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GridSupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridSupplierTableAdapter As Penjualan.penjualanDataSetTableAdapters.gridSupplierTableAdapter
    Friend WithEvents IdSupplierLabel As System.Windows.Forms.Label
    Friend WithEvents IdPembelianDetilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPembelianMasterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahBeliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jmlDatang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PembelianDetilBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PembelianDetilTableAdapter As Penjualan.penjualanDataSetTableAdapters.PembelianDetilTableAdapter
End Class
