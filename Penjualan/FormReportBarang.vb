Public Class FormReportBarang

    Private Sub FormReportBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'penjualanDataSet.Barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.penjualanDataSet.Barang)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class