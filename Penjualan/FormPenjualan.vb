Public Class FormPenjualan

    Private Sub PenjualanDetilBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PenjualanDetilBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PenjualanDataSet)

    End Sub

    Private Sub FormPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.PembelianDetil' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'PenjualanDataSet.gridPenjualan' table. You can move, or remove it, as needed.
        Me.GridPenjualanTableAdapter.Fill(Me.PenjualanDataSet.gridPenjualan)
        'TODO: This line of code loads data into the 'PenjualanDataSet.Barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.PenjualanDataSet.Barang)
        'TODO: This line of code loads data into the 'PenjualanDataSet.PenjualanMaster' table. You can move, or remove it, as needed.
        Me.PenjualanMasterTableAdapter.Fill(Me.PenjualanDataSet.PenjualanMaster)
        'TODO: This line of code loads data into the 'PenjualanDataSet.PenjualanDetil' table. You can move, or remove it, as needed.
        Me.PenjualanDetilTableAdapter.Fill(Me.PenjualanDataSet.PenjualanDetil)

    End Sub
End Class