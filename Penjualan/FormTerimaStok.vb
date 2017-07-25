Public Class FormTerimaStok
    Dim item As Double
    Private Sub FormTerimaStok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.Pengaturan' table. You can move, or remove it, as needed.
        Me.PengaturanTableAdapter.Fill(Me.PenjualanDataSet.Pengaturan)
        'TODO: This line of code loads data into the 'PenjualanDataSet.Barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.PenjualanDataSet.Barang)
        'TODO: This line of code loads data into the 'PenjualanDataSet.Barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.PenjualanDataSet.Barang)
        'TODO: This line of code loads data into the 'PenjualanDataSet.PembelianDetil' table. You can move, or remove it, as needed.
        Me.PembelianDetilTableAdapter.Fill(Me.PenjualanDataSet.PembelianDetil)
        'TODO: This line of code loads data into the 'PenjualanDataSet.PembelianDetil' table. You can move, or remove it, as needed.
        Me.PembelianDetilTableAdapter.Fill(Me.PenjualanDataSet.PembelianDetil)
        'TODO: This line of code loads data into the 'PenjualanDataSet.gridSupplier' table. You can move, or remove it, as needed.
        Me.GridSupplierTableAdapter.Fill(Me.PenjualanDataSet.gridSupplier)
        'TODO: This line of code loads data into the 'PenjualanDataSet.PembelianMaster' table. You can move, or remove it, as needed.
        Me.PembelianMasterTableAdapter.Fill(Me.PenjualanDataSet.PembelianMaster)
        'TODO: This line of code loads data into the 'PenjualanDataSet.gridPembelian' table. You can move, or remove it, as needed.
        tampilPemesanan(NoTransaksiTextBox.Text)
        lbTanggal.Text = Date.Now.Date

    End Sub
    Public Sub tampilPemesanan(ByVal no As String)
        Try
            GridPembelianTableAdapter.FillByNoPembelian(PenjualanDataSet.gridPembelian, no)
        Catch ex As Exception
            MsgBox("Barang tidak ditemukan", MsgBoxStyle.Information, "info")
        End Try

    End Sub
    Private Sub NoTransaksiTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NoTransaksiTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dt = GridSupplierTableAdapter.GetDataByPembelian(NoTransaksiTextBox.Text)
            If dt.Rows.Count = 0 Then
                MsgBox("data tidak ditemukan", MsgBoxStyle.Information, "Informasi")
            Else
                TanggalBeliDateTimePicker.Value = dt.Rows(0).Item("tanggalBeli")
                IdSupplierLabel.Text = dt.Rows(0).Item("namaSupplier")
                tampilPemesanan(NoTransaksiTextBox.Text)
            End If
           
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim aturan = PengaturanTableAdapter.GetDataById(1)
        Dim keuntungan As Double
        keuntungan = aturan.Rows(0).Item("keuntungan")
        For i As Integer = 0 To PenjualanDetilDataGridView.Rows.Count - 1
            PembelianDetilTableAdapter.UpdatePenerimaan(Val(PenjualanDetilDataGridView.Rows(i).Cells(5).Value), Val(PenjualanDetilDataGridView.Rows(i).Cells(7).Value), Val(PenjualanDetilDataGridView.Rows(i).Cells(6).Value), "Komplet", PenjualanDetilDataGridView.Rows(i).Cells(0).Value)
            BarangTableAdapter.UpdateJumlahBarang(PenjualanDetilDataGridView.Rows(i).Cells(2).Value, (keuntungan / 100) * Val(CDbl(PenjualanDetilDataGridView.Rows(i).Cells(6).Value)) + CDbl(PenjualanDetilDataGridView.Rows(i).Cells(6).Value), Val(PenjualanDetilDataGridView.Rows(i).Cells(5).Value), Val(PenjualanDetilDataGridView.Rows(i).Cells(6).Value), PenjualanDetilDataGridView.Rows(i).Cells(2).Value)
        Next
        PembelianMasterTableAdapter.UpdateQuery(NoTransaksiTextBox.Text, item, lbTotal.Text, NoTransaksiTextBox.Text)

        MsgBox("Data telah disimpan", MsgBoxStyle.Information, "Informasi")
    End Sub

    Private Sub KodeBarangTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KodeBarangTextBox.TextChanged

    End Sub

    Private Sub PenjualanDetilDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PenjualanDetilDataGridView.CellEndEdit
        If e.ColumnIndex = 5 Then
            'Dim mEditRow As Integer = -1
            'Dim NewRow As Integer = mEditRow
            'mEditRow = -1
            'PenjualanDetilDataGridView.CurrentCell = PenjualanDetilDataGridView.Rows(NewRow).Cells(PenjualanDetilDataGridView.CurrentCell.ColumnIndex)
        ElseIf e.ColumnIndex = 6 Then
            PenjualanDetilDataGridView.Rows(e.RowIndex).Cells(7).Value = Val(PenjualanDetilDataGridView.Rows(e.RowIndex).Cells(5).Value) * Val(PenjualanDetilDataGridView.Rows(e.RowIndex).Cells(6).Value)
            hitungsummary()
            hitungItem()
        End If
    End Sub
    Public Sub hitungsummary()
        Dim qry0 = From theRow As DataGridViewRow In PenjualanDetilDataGridView.Rows Select theRow
        Dim sumBeli As Double
        sumBeli = qry0.Sum(Function(x As DataGridViewRow) CDec(x.Cells(7).Value))
        lbTotal.Text = Format(sumBeli, "Currency")
    End Sub
    Public Sub hitungItem()
        item = PenjualanDetilDataGridView.Rows.Count
        lbitem.Text = "Item : " & Format(item, "0.###")
    End Sub

    Private Sub PenjualanDetilDataGridView_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles PenjualanDetilDataGridView.RowPostPaint
        Dim dg As DataGridView = DirectCast(sender, DataGridView)
        ' Current row record
        Dim rowNumber As String = (e.RowIndex + 1).ToString()

        ' Format row based on number of records displayed by using leading zeros
        While rowNumber.Length < dg.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        ' Position text
        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If dg.RowHeadersWidth < CInt(size.Width + 20) Then
            dg.RowHeadersWidth = CInt(size.Width + 20)
        End If

        ' Use default system text brush
        Dim b As Brush = SystemBrushes.ControlText

        ' Draw row number
        e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub
    Private Sub btnPemesananBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPemesananBaru.Click
        NoTransaksiTextBox.Text = ""
        NoTransaksiTextBox.Focus()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class