﻿Public Class FormBarang

    Private Sub BarangBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BarangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PenjualanDataSet)

    End Sub

    Private Sub FormBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.gridBarang' table. You can move, or remove it, as needed.
        Me.GridBarangTableAdapter.Fill(Me.PenjualanDataSet.gridBarang)
        'TODO: This line of code loads data into the 'PenjualanDataSet.Jenis' table. You can move, or remove it, as needed.
        Me.JenisTableAdapter.Fill(Me.PenjualanDataSet.Jenis)
        'TODO: This line of code loads data into the 'PenjualanDataSet.Barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.PenjualanDataSet.Barang)

    End Sub

    Private Sub Panel6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub IdJenisComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdJenisComboBox.SelectedIndexChanged

    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Try
            BarangTableAdapter.InsertQuery(KodeBarangTextBox.Text, IdJenisComboBox.SelectedValue, NamaBarangTextBox.Text, HargaTextBox.Text, SatuanComboBox.Text)
            MsgBox("data telah disimpan.", MsgBoxStyle.Information, "Informasi")
            Me.GridBarangTableAdapter.Fill(Me.PenjualanDataSet.gridBarang)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarangDataGridView_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles BarangDataGridView.RowPostPaint
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Dim xlApp As Microsoft.Office.Interop.Excel.Application
        'Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        'Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        'Dim misValue As Object = System.Reflection.Missing.Value
        'Dim i As Integer
        'Dim j As Integer
        'xlApp = New Microsoft.Office.Interop.Excel.Application
        'xlWorkBook = xlApp.Workbooks.Add(misValue)
        'xlWorkSheet = xlWorkBook.Sheets("sheet1")
        'xlWorkSheet.Columns.AutoFit()

        'For i = 0 To (BarangDataGridView.RowCount + 1) - 2
        '    For j = 0 To BarangDataGridView.ColumnCount - 1
        '        For k As Integer = 1 To BarangDataGridView.Columns.Count
        '            xlWorkSheet.Cells(1, k) = BarangDataGridView.Columns(k - 1).HeaderText
        '            xlWorkSheet.Cells(i + 2, j + 1) = BarangDataGridView(j, i).Value.ToString()
        '        Next
        '    Next
        'Next

        'xlWorkSheet.SaveAs("D:\vbexcel.xlsx")
        'xlWorkBook.Close()
        'xlApp.Quit()

        'releaseObject(xlApp)
        'releaseObject(xlWorkBook)
        'releaseObject(xlWorkSheet)

        'MsgBox("You can find the file D:\vbexcel.xlsx")
        FormReportBarang.Show()
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

    Private Sub btnUbah_Click(sender As System.Object, e As System.EventArgs) Handles btnUbah.Click
        Try
            BarangTableAdapter.UpdateQuery(KodeBarangTextBox.Text, IdJenisComboBox.SelectedValue, NamaBarangTextBox.Text, HargaTextBox.Text, SatuanComboBox.Text, KodeBarangTextBox.Text)
            MsgBox("data telah diubah", MsgBoxStyle.Information, "Berhasil")
            Me.GridBarangTableAdapter.Fill(Me.PenjualanDataSet.gridBarang)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As System.Object, e As System.EventArgs) Handles btnHapus.Click
        Try
            BarangTableAdapter.DeleteQuery(KodeBarangTextBox.Text)
            MsgBox("data telah dihapus", MsgBoxStyle.Information, "Berhasil")
            Me.GridBarangTableAdapter.Fill(Me.PenjualanDataSet.gridBarang)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        FormCariBarang.ShowDialog()
    End Sub

    Private Sub BarangDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BarangDataGridView.CellClick
        ' Try
        KodeBarangTextBox.Text = BarangDataGridView.SelectedCells(0).Value
        NamaBarangTextBox.Text = BarangDataGridView.SelectedCells(1).Value
        IdJenisComboBox.Text = BarangDataGridView.SelectedCells(2).Value
        SatuanComboBox.Text = BarangDataGridView.SelectedCells(3).Value

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
End Class
