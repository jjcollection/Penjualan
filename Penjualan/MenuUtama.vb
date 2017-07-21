Imports System.Windows.Forms

Public Class MenuUtama

    Private Sub btnPenjualan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPenjualan.Click
        FormJual.Show()
    End Sub

    Private Sub btnBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBarang.Click
        FormBarang.Show()
    End Sub
End Class
