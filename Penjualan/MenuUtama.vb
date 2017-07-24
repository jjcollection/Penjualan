Imports System.Windows.Forms

Public Class MenuUtama

    Private Sub btnPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPenjualan.Click
        FormJual.Show()
    End Sub

    Private Sub btnBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBarang.Click
        FormBarang.Show()
    End Sub

    Private Sub btnSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupplier.Click
        FormSupplier.Show()
    End Sub

    Private Sub btnJenisBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJenisBarang.Click
        FormJenis.Show()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnPembelian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPembelian.Click
        FormPembelian.Show()
    End Sub

    Private Sub btnTerima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerima.Click
        FormTerimaStok.Show()
    End Sub
End Class
