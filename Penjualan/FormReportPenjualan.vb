Public Class FormReportPenjualan

    Private Sub FormReportPenjualan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'penjualanDataSet.gridPenjualan' table. You can move, or remove it, as needed.
        ' Me.gridPenjualanTableAdapter.Fill(Me.penjualanDataSet.gridPenjualan)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.gridPenjualanTableAdapter.FillByTanggal(Me.penjualanDataSet.gridPenjualan, tglAwal.Value, tglAkhir.Value)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        Me.gridPenjualanTableAdapter.Fill(Me.penjualanDataSet.gridPenjualan)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private count As Integer = 0
    Private iniRow As Integer = 0
    Private iniGrp As Object = ""
    Public Function MatrixRow(ByVal rowNum As Integer, ByVal rowGrp As Object) As Integer

        If iniGrp = "" Then
            iniGrp = rowGrp
        End If

        If rowGrp <> iniGrp Then
            iniRow = 0
            count = 0
            iniGrp = rowGrp
        End If

        If iniRow = 0 Then
            iniRow = rowNum
        End If

        If rowNum = iniRow Then
            count = 0
        End If

        count = count + 1
        Return count
    End Function
End Class