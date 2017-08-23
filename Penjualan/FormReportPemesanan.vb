Public Class FormReportPemesanan

    Private Sub FormReportPemesanan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'penjualanDataSet.GridReportBeli' table. You can move, or remove it, as needed.
        Me.GridReportBeliTableAdapter.FillByIDBeli(Me.penjualanDataSet.GridReportBeli, "231700005")
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class