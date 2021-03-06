﻿Public Class FormJual
    Dim tbl As New DataTable
    Dim tgl, tahun, digit, kodebr As String
    Dim subtotal, hargabr As Double
    Sub kode_otomatis()
        PenjualanMasterTableAdapter.DeletePenjualanMasterNol()
        tgl = Date.Now.Day
        tahun = Date.Now.Year
        digit = Microsoft.VisualBasic.Right(tahun, 2)
        tbl = Me.PenjualanMasterTableAdapter.GetDataByDesc
        If tbl.Rows.Count = 0 Then
            NoTransaksiTextBox.Text = tgl + digit + "00001"
        Else
            With tbl.Rows(0)
                NoTransaksiTextBox.Text = .Item("noTransaksi")
            End With
            NoTransaksiTextBox.Text = Val(Microsoft.VisualBasic.Mid(NoTransaksiTextBox.Text, 5, 5)) + 1
            If Len(NoTransaksiTextBox.Text) = 1 Then
                NoTransaksiTextBox.Text = tgl + digit + "0000" & NoTransaksiTextBox.Text & ""
            ElseIf Len(NoTransaksiTextBox.Text) = 2 Then
                NoTransaksiTextBox.Text = tgl + digit + "000" & NoTransaksiTextBox.Text & ""
            ElseIf Len(NoTransaksiTextBox.Text) = 3 Then
                NoTransaksiTextBox.Text = tgl + digit + "00" & NoTransaksiTextBox.Text & ""
            ElseIf Len(NoTransaksiTextBox.Text) = 4 Then
                NoTransaksiTextBox.Text = tgl + digit + "0" & NoTransaksiTextBox.Text & ""
            ElseIf Len(NoTransaksiTextBox.Text) = 5 Then
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
            Dim dtcelada = BarangTableAdapter.GetDataByCekAda(KodeBarangTextBox.Text)
            Dim br = BarangTableAdapter.FillByKode(PenjualanDataSet.Barang, KodeBarangTextBox.Text)
            If dtcelada.Rows.Count = 0 Then
                MsgBox("Kode Barang tidak ditemukan", MsgBoxStyle.Critical, "Informasi")
            ElseIf dt.Rows.Count = 0 Then
                MsgBox("Stok Tidak Cukup", MsgBoxStyle.Information, "Informasi")
            Else
                kodebr = dt.Rows(0).Item("namaBarang")
                hargabr = dt.Rows(0).Item("harga")
                LabelInfo.Text = dt.Rows(0).Item("namaBarang") & "#" & Format(hargabr, "currency")
                Dim brcek = BarangTableAdapter.GetDataByKode(KodeBarangTextBox.Text)
                Dim jmlstok = brcek.Rows(0).Item("stok")
                If (Val(jmlstok) < Val(JumlahBeliTextBox.Text)) Then
                    MsgBox("Stok tidak cukup")
                Else
                    PenjualanDetilTableAdapter.InsertQuery(NoTransaksiTextBox.Text, KodeBarangTextBox.Text.ToUpper, JumlahBeliTextBox.Text, Val(JumlahBeliTextBox.Text) * hargabr)
                    GridPenjualanTableAdapter.FillByTransaksi(PenjualanDataSet.gridPenjualan, NoTransaksiTextBox.Text)

                    Dim totalbelanja = PenjualanDetilTableAdapter.subtotal(NoTransaksiTextBox.Text)
                    Dim totalItem = PenjualanDetilTableAdapter.jmlitem(NoTransaksiTextBox.Text)

                    lbTotal.Text = Format(totalbelanja, "Currency")
                    lbitem.Text = "Item :" & totalItem
                    lbTanggal.Text = Date.Today.Date
                    PenjualanMasterTableAdapter.UpdateTotal(totalItem, totalbelanja, NoTransaksiTextBox.Text)
                    BarangTableAdapter.UpdateKurangiStok(KodeBarangTextBox.Text, JumlahBeliTextBox.Text, KodeBarangTextBox.Text)
                    KodeBarangTextBox.Focus()
                    KodeBarangTextBox.Text = ""
                    JumlahBeliTextBox.Text = "1"
                    btnenable()
                End If

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
        ambiltransaksi(NoTransaksiTextBox.Text)

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

    Private Sub PenjualanDetilDataGridView_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles PenjualanDetilDataGridView.RowPostPaint
        Dim dg As DataGridView = DirectCast(sender, DataGridView)
        ' Current row record
        Dim rowNumber As String = (e.RowIndex + 1).ToString()

        ' Format row based on number of records displayed by using leading zeros
        While rowNumber.Length < dg.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        ' Position text
        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If dg.RowHeadersWidth < CInt(size.Width + 20) Then
            dg.RowHeadersWidth = CInt(size.Width + 20)
        End If

        ' Use default system text brush
        Dim b As Brush = SystemBrushes.ControlText

        ' Draw row number
        e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub KodeBarangTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KodeBarangTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        NoTransaksiTextBox.ReadOnly = False
    End Sub
    Public Sub ambiltransaksi(ByVal no As String)
        GridPenjualanTableAdapter.FillByTransaksi(PenjualanDataSet.gridPenjualan, no)
    End Sub
    Private Sub NoTransaksiTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NoTransaksiTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridPenjualanTableAdapter.FillByTransaksi(PenjualanDataSet.gridPenjualan, NoTransaksiTextBox.Text)
        End If


       

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DialogPenjualan.ShowDialog()
    End Sub

    Private Sub btnBayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBayar.Click
        ' DialogBayar.lbTotal.Text = lbTotal.Text
        DialogBayar.fokuskan()
        DialogBayar.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        FormCariBarang.ShowDialog()
    End Sub

    Private Sub FormJual_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            DialogBayar.ShowDialog()
        ElseIf e.KeyCode = Keys.F1 Then
            KodeBarangTextBox.Text = ""
            KodeBarangTextBox.Focus()
        ElseIf e.KeyCode = Keys.F3 Then
            Button3.PerformClick()
        ElseIf e.KeyCode = Keys.F4 Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F2 Then
            JumlahBeliTextBox.Focus()
        ElseIf e.KeyCode = Keys.F5 Then
            btnTransaksiBaru.PerformClick()
        End If
    End Sub
End Class