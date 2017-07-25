Imports System.Data.OleDb


Public Class FormPembelian
    Dim tbl As New DataTable
    Dim tgl, tahun, digit, kodebr As String
    Dim subtotal, hargabr As Double
    Dim total, item As Double
    Sub kode_otomatis()
        PembelianMasterTableAdapter.DeleteBeliMasterNol()
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
        tampilPemesanan(NoTransaksiTextBox.Text)
        GridPembelianTableAdapter.FillByNoPembelian(PenjualanDataSet.gridPembelian, NoTransaksiTextBox.Text)
        Me.SupplierTableAdapter.Fill(Me.PenjualanDataSet.Supplier)
        'Dim Conn = New OleDbConnection(My.Settings.penjualanConnectionString)
        'Dim CMD = New OleDbCommand("SELECT * from Barang", Conn)
        'Dim RD As OleDbDataReader
        'Conn.Open()
        'RD = CMD.ExecuteReader
        'While RD.Read
        '    With KodeBarangTextBox
        '        .AutoCompleteCustomSource.Add(RD("kodeBarang").ToString)
        '        ' .AutoCompleteMode = AutoCompleteMode.Suggest
        '        '.AutoCompleteSource = AutoCompleteSource.CustomSource
        '    End With
        'End While
        'Conn.Close()
        kode_otomatis()
        PembelianMasterTableAdapter.InsertQuery(NoTransaksiTextBox.Text, IdSupplierComboBox.SelectedValue, Date.Now, 0, 0)
        KodeBarangTextBox.Focus()
        lbTanggal.Text = Date.Now.Date
    End Sub




    Private Sub txtNama_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNama.KeyDown
        If e.KeyCode = Keys.Enter Then
            JumlahBeliTextBox.Focus()

        End If
    End Sub
    Public Sub tampilPemesanan(ByVal no As String)
        Try
            GridPembelianTableAdapter.FillByNoPembelian(PenjualanDataSet.gridPembelian, no)
            JumlahBeliTextBox.Focus()
        Catch ex As Exception
            MsgBox("Barang tidak ditemukan", MsgBoxStyle.Information, "info")
        End Try

    End Sub
    Public Sub tampilharga()
        Try
            Dim dt = BarangTableAdapter.GetDataByKode(KodeBarangTextBox.Text)
            txtNama.Text = dt.Rows(0).Item("namaBarang")
            txtHarga.Text = dt.Rows(0).Item("harga")
            JumlahBeliTextBox.Focus()
        Catch ex As Exception
            MsgBox("Barang tidak ditemukan", MsgBoxStyle.Information, "info")
        End Try

    End Sub
    Private Sub KodeBarangTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles KodeBarangTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            tampilharga()
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
            total = PembelianDetilTableAdapter.ScalarQuery(NoTransaksiTextBox.Text)
            item = PembelianDetilTableAdapter.ScalarQueryItem(NoTransaksiTextBox.Text)
            lbTotal.Text = Format(total, "Currency")
            lbitem.Text = item
            KodeBarangTextBox.Text = ""
            txtNama.Text = "-"
            txtHarga.Text = "0"
            KodeBarangTextBox.Focus()
            PembelianMasterTableAdapter.UpdateQuery(NoTransaksiTextBox.Text, lbitem.Text, lbTotal.Text, NoTransaksiTextBox.Text)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormCariBarang.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Try
            PembelianDetilTableAdapter.DeleteQuery(PenjualanDetilDataGridView.SelectedCells(0).Value)
            GridPembelianTableAdapter.FillByNoPembelian(PenjualanDataSet.gridPembelian, NoTransaksiTextBox.Text)
            total = PembelianDetilTableAdapter.ScalarQuery(NoTransaksiTextBox.Text)
            item = PembelianDetilTableAdapter.ScalarQueryItem(NoTransaksiTextBox.Text)
            lbTotal.Text = Format(total, "Currency")
            lbitem.Text = item
            KodeBarangTextBox.Text = ""
            txtNama.Text = "-"
            txtHarga.Text = "0"
            KodeBarangTextBox.Focus()
            PembelianMasterTableAdapter.UpdateQuery(NoTransaksiTextBox.Text, lbitem.Text, lbTotal.Text, NoTransaksiTextBox.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Apakah anda yakin akan menghapus PO Nomor " & NoTransaksiTextBox.Text & "?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PembelianMasterTableAdapter.DeleteQuery(NoTransaksiTextBox.Text)
            GridPembelianTableAdapter.FillByNoPembelian(PenjualanDataSet.gridPembelian, NoTransaksiTextBox.Text)
            lbTotal.Text = "0"
            lbitem.Text = "0"
            KodeBarangTextBox.Text = ""
            txtNama.Text = "-"
            txtHarga.Text = "0"
            kode_otomatis()
            PembelianMasterTableAdapter.InsertQuery(NoTransaksiTextBox.Text, IdSupplierComboBox.SelectedValue, Date.Now, 0, 0)
            KodeBarangTextBox.Focus()
        Else
            KodeBarangTextBox.Focus()
        End If
    End Sub

    Private Sub btnBayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBayar.Click
        DialogPO.ShowDialog()
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
    Private Sub ExportToExcel()
        ' Creating a Excel object.
        Dim excel As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = excel.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing

        Try

            worksheet = workbook.ActiveSheet

            worksheet.Name = "ExportedFromDatGrid"

            Dim cellRowIndex As Integer = 1
            Dim cellColumnIndex As Integer = 1

            'Loop through each row and read value from each column.
            For i As Integer = 0 To (PenjualanDetilDataGridView.Rows.Count + 2) - 2
                For j As Integer = 0 To PenjualanDetilDataGridView.Columns.Count - 1
                    ' Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                    If cellRowIndex = 1 Then
                        worksheet.Cells(cellRowIndex, cellColumnIndex) = PenjualanDetilDataGridView.Columns(j).HeaderText
                    Else
                        worksheet.Cells(cellRowIndex, cellColumnIndex) = PenjualanDetilDataGridView.Rows(i).Cells(j).Value.ToString()
                    End If
                    cellColumnIndex += 1
                Next
                cellColumnIndex = 1
                cellRowIndex += 1
            Next

            'Getting the location and file name of the excel to save from user.
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            saveDialog.FilterIndex = 2

            If saveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                workbook.SaveAs(saveDialog.FileName)
                MessageBox.Show("Export Successful")
            End If
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        Finally
            excel.Quit()
            workbook = Nothing
            excel = Nothing
        End Try

    End Sub
   
    Private Sub btnCetakPemesanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetakPemesanan.Click
        ExportToExcel()
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    
End Class