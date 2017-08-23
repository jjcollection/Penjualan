Imports System.Windows.Forms

Public Class DialogBayar

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DialogBayar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.PenjualanMaster' table. You can move, or remove it, as needed.
        ' Me.PenjualanMasterTableAdapter.Fill(Me.PenjualanDataSet.PenjualanMaster 
        lbTotal.Text = FormJual.lbTotal.Text
        fokuskan()
    End Sub


    Public Sub fokuskan()
        txtBayar.Text = ""
        txtBayar.Focus()

    End Sub
  
    Private Sub txtBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar.TextChanged

    End Sub

    Private Sub PenjualanMasterBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PenjualanMasterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PenjualanDataSet)

    End Sub

    Private Sub txtDiskon_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDiskon.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim diskon = (Val(txtDiskon.Text) / 100) * CDbl(lbTotal.Text)
            jmlDiskon.Text = "-" & diskon
            lbTotalBayar.Text = CDbl(lbTotal.Text) - diskon
            txtBayar.Text = "0"
            txtBayar.Focus()
        End If
    End Sub

    Private Sub txtBayar_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim kembali = CDbl(txtBayar.Text) - CDbl(lbTotalBayar.Text)
                lbKembali.Text = Format(kembali, "Currency")
                txtBayar.Text = Format(txtBayar.Text, "Currency")
                PenjualanMasterTableAdapter.UpdateBayar(FormJual.NoTransaksiTextBox.Text, txtBayar.Text, kembali, FormJual.NoTransaksiTextBox.Text)
                If MessageBox.Show("Cetak Kwitansi ?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    FormReportKwitansi.ShowDialog()
                    FormJual.kode_otomatis()
                Else
                    Me.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class
