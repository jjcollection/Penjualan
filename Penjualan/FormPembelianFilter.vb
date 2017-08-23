Public Class FormPembelianFilter

    Private Sub FormPembelianFilter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'penjualanDataSet.GridReportBeli' table. You can move, or remove it, as needed.
        Me.GridReportBeliTableAdapter.Fill(Me.penjualanDataSet.GridReportBeli)
        'TODO: This line of code loads data into the 'penjualanDataSet.GridReportBeli' table. You can move, or remove it, as needed.
       
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.GridReportBeliTableAdapter.FillByTanggalSupplier(Me.penjualanDataSet.GridReportBeli, tglAwal.Value, tglAkhir.Value)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class