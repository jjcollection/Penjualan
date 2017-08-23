Public Class FormSupplier

    Private Sub FormSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.PenjualanDataSet.Supplier)

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

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        Try
            SupplierTableAdapter.InsertQuery(txtNama.Text, txtTlp.Text, txtAlamat.Text)
            MsgBox("data telah disimpan", MsgBoxStyle.Information, "Berhasil")
            Me.SupplierTableAdapter.Fill(Me.PenjualanDataSet.Supplier)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnUbah_Click(sender As System.Object, e As System.EventArgs) Handles btnUbah.Click
        Try
            SupplierTableAdapter.UpdateQuery(txtNama.Text, txtTlp.Text, txtAlamat.Text, BarangDataGridView.SelectedCells(0).Value)
            MsgBox("data telah diubah", MsgBoxStyle.Information, "Berhasil")
            Me.SupplierTableAdapter.Fill(Me.PenjualanDataSet.Supplier)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As System.Object, e As System.EventArgs) Handles btnHapus.Click
        Try
            SupplierTableAdapter.DeleteQuery(BarangDataGridView.SelectedCells(0).Value)
            MsgBox("data telah dihapus", MsgBoxStyle.Information, "Berhasil")
            Me.SupplierTableAdapter.Fill(Me.PenjualanDataSet.Supplier)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarangDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BarangDataGridView.CellClick
        txtNama.Text = BarangDataGridView.SelectedCells(1).Value
        txtTlp.Text = BarangDataGridView.SelectedCells(2).Value
        txtAlamat.Text = BarangDataGridView.SelectedCells(3).Value
    End Sub
End Class