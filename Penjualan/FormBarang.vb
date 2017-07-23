Public Class FormBarang

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

    Private Sub IdJenisComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdJenisComboBox.SelectedIndexChanged, cbbKriteria.SelectedIndexChanged

    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Try
            BarangTableAdapter.InsertQuery(KodeBarangTextBox.Text, IdJenisComboBox.SelectedValue, NamaBarangTextBox.Text, HargaTextBox.Text, SatuanComboBox.Text)
            MsgBox("data telah disimpan.", MsgBoxStyle.Information, "Informasi")
            BarangTableAdapter.Fill(PenjualanDataSet.Barang)

        Catch ex As Exception

        End Try
    End Sub
End Class
