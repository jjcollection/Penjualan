Imports System.Data.OleDb

Public Class FormPembelian
    Dim tbl As New DataTable
    Dim tgl, tahun, digit, kodebr As String
    Dim subtotal, hargabr As Double
    Sub kode_otomatis()
        tgl = Date.Now.Day
        tahun = Date.Now.Year
        digit = Microsoft.VisualBasic.Right(tahun, 2)
        tbl = Me.PembelianMasterTableAdapter.GetDataByPembelianMasterDesc
        If tbl.Rows.Count = 0 Then
            NoTransaksiTextBox.Text = tgl + digit + "0001"
        Else
            With tbl.Rows(0)
                NoTransaksiTextBox.Text = .Item("idPembelianMaster")
            End With
            NoTransaksiTextBox.Text = Val(Microsoft.VisualBasic.Mid(NoTransaksiTextBox.Text, 5, 4)) + 1
            If Len(NoTransaksiTextBox.Text) = 1 Then
                NoTransaksiTextBox.Text = tgl + digit + "000" & NoTransaksiTextBox.Text & ""
            ElseIf Len(NoTransaksiTextBox.Text) = 2 Then
                NoTransaksiTextBox.Text = tgl + digit + "00" & NoTransaksiTextBox.Text & ""
            ElseIf Len(NoTransaksiTextBox.Text) = 3 Then
                NoTransaksiTextBox.Text = tgl + digit + "0" & NoTransaksiTextBox.Text & ""
            ElseIf Len(NoTransaksiTextBox.Text) = 4 Then
                NoTransaksiTextBox.Text = tgl + digit + NoTransaksiTextBox.Text
            End If

        End If
    End Sub

    Private Sub btnPemesananBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPemesananBaru.Click
        kode_otomatis()
        PembelianMasterTableAdapter.InsertQuery(NoTransaksiTextBox.Text, IdSupplierComboBox.SelectedValue, Date.Now, 0, 0)
        KodeBarangTextBox.Focus()
    End Sub



    Private Sub FormPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridPembelianTableAdapter.FillByNoPembelian(PenjualanDataSet.gridPembelian, NoTransaksiTextBox.Text)
        Me.SupplierTableAdapter.Fill(Me.PenjualanDataSet.Supplier)
        Dim Conn = New OleDbConnection(My.Settings.penjualanConnectionString)
        Dim CMD = New OleDbCommand("SELECT * from Barang", Conn)
        Dim RD As OleDbDataReader
        Conn.Open()
        RD = CMD.ExecuteReader
        While RD.read
            With KodeBarangTextBox
                .AutoCompleteCustomSource.Add(RD("kodeBarang").ToString)
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
        End While
        Conn.Close()
        kode_otomatis()
        PembelianMasterTableAdapter.InsertQuery(NoTransaksiTextBox.Text, IdSupplierComboBox.SelectedValue, Date.Now, 0, 0)
        KodeBarangTextBox.Focus()

    End Sub




    Private Sub txtNama_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNama.KeyDown
        If e.KeyCode = Keys.Enter Then
            JumlahBeliTextBox.Focus()

        End If
    End Sub

    Private Sub KodeBarangTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles KodeBarangTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dt = BarangTableAdapter.GetDataByKode(KodeBarangTextBox.Text)
            txtNama.Text = dt.Rows(0).Item("namaBarang")
            txtHarga.Text = dt.Rows(0).Item("harga")
            JumlahBeliTextBox.Focus()
        End If
    End Sub

    Private Sub JumlahBeliTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles JumlahBeliTextBox.KeyDown
        If e.KeyCode = Keys.Up Then
            JumlahBeliTextBox.Text = Val(JumlahBeliTextBox.Text) + 1
        ElseIf e.KeyCode = Keys.Down Then
            JumlahBeliTextBox.Text = Val(JumlahBeliTextBox.Text) - 1
        ElseIf e.KeyCode = Keys.Enter Then
            PembelianDetilTableAdapter.InsertQuery(NoTransaksiTextBox.Text, KodeBarangTextBox.Text, JumlahBeliTextBox.Text, Val(txtHarga.Text) * Val(JumlahBeliTextBox.Text))
            GridPembelianTableAdapter.FillByNoPembelian(PenjualanDataSet.gridPembelian, NoTransaksiTextBox.Text)
            KodeBarangTextBox.Text = ""
            txtNama.Text = "-"
            txtHarga.Text = "0"
            KodeBarangTextBox.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormCariBarang.ShowDialog()
    End Sub
End Class