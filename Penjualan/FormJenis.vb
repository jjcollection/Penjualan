Public Class FormJenis

    Private Sub txtNama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNamaJenis.TextChanged

    End Sub

    Private Sub FormJenis_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.Jenis' table. You can move, or remove it, as needed.
        Me.JenisTableAdapter.Fill(Me.PenjualanDataSet.Jenis)

    End Sub

    Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnTambah.Click
        txtNamaJenis.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        Try
            JenisTableAdapter.InsertQuery(txtNamaJenis.Text)
            MsgBox("Data telah disimpan", MsgBoxStyle.Information, "Informasi")
            Me.JenisTableAdapter.Fill(Me.PenjualanDataSet.Jenis)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUbah_Click(sender As System.Object, e As System.EventArgs) Handles btnUbah.Click
        Try
            JenisTableAdapter.UpdateQuery(txtNamaJenis.Text, BarangDataGridView.SelectedCells(0).Value)
            MsgBox("Data telah diubah", MsgBoxStyle.Information, "Informasi")
            Me.JenisTableAdapter.Fill(Me.PenjualanDataSet.Jenis)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As System.Object, e As System.EventArgs) Handles btnHapus.Click
        Try
            JenisTableAdapter.DeleteQuery(BarangDataGridView.SelectedCells(0).Value)
            MsgBox("Data telah dihapus", MsgBoxStyle.Information, "Informasi")
            Me.JenisTableAdapter.Fill(Me.PenjualanDataSet.Jenis)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarangDataGridView_RowPostPaint(sender As System.Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles BarangDataGridView.RowPostPaint
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

    Private Sub BarangDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BarangDataGridView.CellClick
        Try
            txtNamaJenis.Text = BarangDataGridView.SelectedCells(1).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class