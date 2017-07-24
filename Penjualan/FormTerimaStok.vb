﻿Public Class FormTerimaStok

    Private Sub FormTerimaStok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        For i As Integer = 0 To PenjualanDetilDataGridView.Rows.Count - 1
            PembelianDetilTableAdapter  .UpdateQuer(NoTransaksiTextBox .Text ,
        Next
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
        End If

    End Sub
End Class