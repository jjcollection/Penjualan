Public Class FormCariBarang


    Private Sub FormCariBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GridBarangTableAdapter.Fill(Me.PenjualanDataSet.gridBarang)
        Me.BarangTableAdapter.Fill(Me.PenjualanDataSet.Barang)
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GridBarangTableAdapter.FillByLike(PenjualanDataSet.gridBarang, TextBox1.Text, TextBox1.Text)
    End Sub

    Private Sub BarangDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BarangDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            FormPembelian.KodeBarangTextBox.Text = BarangDataGridView.SelectedCells(0).Value
            FormJual.KodeBarangTextBox.Text = BarangDataGridView.SelectedCells(0).Value
            FormPembelian.tampilharga()
            TextBox1.Text = ""
            Me.Close()
        ElseIf e.KeyCode = Keys.F1 Then
            TextBox1.Text = ""
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        GridBarangTableAdapter.FillByLike(PenjualanDataSet.gridBarang, TextBox1.Text, TextBox1.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            BarangDataGridView.Focus()
        ElseIf e.KeyCode = Keys.Down Then
            BarangDataGridView.Focus()
        End If

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
End Class