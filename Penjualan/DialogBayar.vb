Imports System.Windows.Forms

Public Class DialogBayar

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DialogBayar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fokuskan()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim kembali = CDbl(txtBayar.Text) - CDbl(lbTotal.Text)
                lbKembali.Text = Format(kembali, "Currency")
                txtBayar.Text = Format(txtBayar.Text, "Currency")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Public Sub fokuskan()
        txtBayar.Text = ""
        txtBayar.Focus()

    End Sub
  
    Private Sub txtBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar.TextChanged
        
    End Sub
End Class
