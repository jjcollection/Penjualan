Public Class FormCariBarang

    Private Sub BarangBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BarangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PenjualanDataSet)

    End Sub

    Private Sub FormCariBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.gridBarang' table. You can move, or remove it, as needed.
        Me.GridBarangTableAdapter.Fill(Me.PenjualanDataSet.gridBarang)
        'TODO: This line of code loads data into the 'PenjualanDataSet.Barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.PenjualanDataSet.Barang)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GridBarangTableAdapter.FillByLike(PenjualanDataSet.gridBarang, TextBox1.Text, TextBox1.Text)
    End Sub

    Private Sub BarangDataGridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BarangDataGridView.KeyDown
        FormPembelian.KodeBarangTextBox.Text = BarangDataGridView.SelectedCells(0).Value
        FormPembelian.JumlahBeliTextBox.Focus()
        Me.Close()

    End Sub
End Class