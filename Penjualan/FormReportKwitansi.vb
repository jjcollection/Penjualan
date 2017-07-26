Public Class FormReportKwitansi

    Private Sub FormReportKwitansi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'penjualanDataSet.gridPenjualan' table. You can move, or remove it, as needed.
        Me.gridPenjualanTableAdapter.FillByTransaksi(Me.penjualanDataSet.gridPenjualan, FormJual.NoTransaksiTextBox.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub FormReportKwitansi_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
    End Sub
End Class