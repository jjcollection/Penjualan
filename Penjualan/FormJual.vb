Public Class FormJual
    Dim tbl As New DataTable
    Dim tgl, tahun, digit, kodebr As String
    Dim subtotal, hargabr As Double
    Sub kode_otomatis()
        tgl = Date.Now.Day
        tahun = Date.Now.Year
        digit = Microsoft.VisualBasic.Right(tahun, 2)
        tbl = Me.PenjualanMasterTableAdapter.GetDataByDesc
        If tbl.Rows.Count = 0 Then
            NoTransaksiTextBox.Text = tgl + digit + "0001"
        Else
            With tbl.Rows(0)
                NoTransaksiTextBox.Text = .Item("noTransaksi")
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
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub btnTransaksiBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaksiBaru.Click
        Try
            kode_otomatis()
            PenjualanMasterTableAdapter.InsertQuery(NoTransaksiTextBox.Text, Date.Now, 0, 0)
            GridPenjualanTableAdapter.FillByTransaksi(PenjualanDataSet.gridPenjualan, NoTransaksiTextBox.Text)
            KodeBarangTextBox.Focus()
            JumlahBeliTextBox.Text = "1"
            lbitem.Text = "Item : 0"
            lbTotal.Text = "0"
            LabelInfo.Text = "-"
            KodeBarangTextBox.Text = ""
            btnenable()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub KodeBarangTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles KodeBarangTextBox.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Dim dt = BarangTableAdapter.GetDataByKode(KodeBarangTextBox.Text)
            Dim br = BarangTableAdapter.FillByKode(PenjualanDataSet.Barang, KodeBarangTextBox.Text)
            If dt.Rows.Count = 0 Then
                MsgBox("Barang tidak ditemukan", MsgBoxStyle.Information, "Informasi")
            Else
                kodebr = dt.Rows(0).Item("namaBarang")
                hargabr = dt.Rows(0).Item("harga")
                LabelInfo.Text = dt.Rows(0).Item("namaBarang") & "#" & Format(hargabr, "currency")
                JumlahBeliTextBox.Focus()
            End If
        End If

    End Sub
    Sub btnenable()
        If PenjualanDetilDataGridView.RowCount = 0 Then
            btnHapus.Enabled = False
            btnBayar.Enabled = False
        Else
            btnHapus.Enabled = True
            btnBayar.Enabled = True
        End If
    End Sub
    Private Sub JumlahBeliTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles JumlahBeliTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PenjualanDetilTableAdapter.InsertQuery(NoTransaksiTextBox.Text, KodeBarangTextBox.Text.ToUpper, JumlahBeliTextBox.Text, Val(JumlahBeliTextBox.Text) * hargabr)
            GridPenjualanTableAdapter.FillByTransaksi(PenjualanDataSet.gridPenjualan, NoTransaksiTextBox.Text)

            Dim totalbelanja = PenjualanDetilTableAdapter.subtotal(NoTransaksiTextBox.Text)
            Dim totalItem = PenjualanDetilTableAdapter.jmlitem(NoTransaksiTextBox.Text)

            lbTotal.Text = totalbelanja
            lbitem.Text = "Item :" & totalItem
            lbTanggal.Text = Date.Today.Date
            PenjualanMasterTableAdapter.UpdateTotal(totalItem, totalbelanja, NoTransaksiTextBox.Text)
            KodeBarangTextBox.Focus()
            KodeBarangTextBox.Text = ""
            JumlahBeliTextBox.Text = "1"
            btnenable()
        End If
    End Sub

    Private Sub FormJual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbTanggal.Text = Date.Now.Date
        If PenjualanDetilDataGridView.RowCount = 0 Then
            btnHapus.Enabled = False
            btnBayar.Enabled = False
        Else
            btnHapus.Enabled = True
            btnBayar.Enabled = True
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Try
            PenjualanDetilTableAdapter.DeleteQuery(PenjualanDetilDataGridView.SelectedCells(0).Value)


            Dim totalbelanja = PenjualanDetilTableAdapter.subtotal(NoTransaksiTextBox.Text)
            Dim totalItem = PenjualanDetilTableAdapter.jmlitem(NoTransaksiTextBox.Text)

            lbTotal.Text = totalbelanja
            lbitem.Text = "Item :" & totalItem
            lbTanggal.Text = Date.Today.Date

            PenjualanMasterTableAdapter.UpdateTotal(totalItem, totalbelanja, NoTransaksiTextBox.Text)
            KodeBarangTextBox.Focus()
            KodeBarangTextBox.Text = ""
            JumlahBeliTextBox.Text = "1"
            btnenable()
            GridPenjualanTableAdapter.FillByTransaksi(PenjualanDataSet.gridPenjualan, NoTransaksiTextBox.Text)
        Catch ex As Exception
            PenjualanMasterTableAdapter.DeleteQuery(NoTransaksiTextBox.Text)
            GridPenjualanTableAdapter.FillByTransaksi(PenjualanDataSet.gridPenjualan, NoTransaksiTextBox.Text)
            lbTotal.Text = "0"
            lbitem.Text = "Item : 0"
            LabelInfo.Text = "-"
            NoTransaksiTextBox.Text = "-"
        End Try
    End Sub
End Class