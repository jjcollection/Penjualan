Public Class FormPembelian
    Dim tbl As New DataTable
    Dim tgl, tahun, digit, kodebr As String
    Dim subtotal, hargabr As Double
    Sub kode_otomatis()
        tgl = Date.Now.Day
        tahun = Date.Now.Year
        digit = Microsoft.VisualBasic.Right(tahun, 2)
        tbl = Me.PembelianMasterTableAdapter.GetDataByPembelianMasterDesc
        If tbl.Rows.Count = 0 Then
            NoTransaksiTextBox.Text = tgl + digit + "0001"
        Else
            With tbl.Rows(0)
                NoTransaksiTextBox.Text = .Item("idPembelianMaster")
            End With
            NoTransaksiTextBox.Text = Val(Microsoft.VisualBasic.Mid(NoTransaksiTextBox.Text, 5, 4)) + 1
            If Len(NoTransaksiTextBox.Text) = 1 Then
                NoTransaksiTextBox.Text = tgl + digit + "000" & NoTransaksiTextBox.Text & ""
            ElseIf Len(NoTransaksiTextBox.Text) = 2 Then
                NoTransaksiTextBox.Text = tgl + digit + "00" & NoTransaksiTextBox.Text & ""
            ElseIf Len(NoTransaksiTextBox.Text) = 3 Then
                NoTransaksiTextBox.Text = tgl + digit + "0" & NoTransaksiTextBox.Text & ""
            ElseIf Len(NoTransaksiTextBox.Text) = 4 Then
                NoTransaksiTextBox.Text = tgl + digit + NoTransaksiTextBox.Text
            End If

        End If
    End Sub
  
    Private Sub btnPemesananBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPemesananBaru.Click
        kode_otomatis()
        PembelianMasterTableAdapter.InsertQuery(NoTransaksiTextBox.Text, IdSupplierComboBox.SelectedValue, Date.Now, 0, 0)
    End Sub

   

    Private Sub FormPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.gridBarang' table. You can move, or remove it, as needed.
        Me.GridBarangTableAdapter.Fill(Me.PenjualanDataSet.gridBarang)
        'TODO: This line of code loads data into the 'PenjualanDataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.PenjualanDataSet.Supplier)
        'TODO: This line of code loads data into the 'PenjualanDataSet.PembelianMaster' table. You can move, or remove it, as needed.
        Me.PembelianMasterTableAdapter.Fill(Me.PenjualanDataSet.PembelianMaster)

    End Sub
End Class