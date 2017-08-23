<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogBayar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbKembali = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PenjualanDataSet = New Penjualan.penjualanDataSet()
        Me.PenjualanMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanMasterTableAdapter = New Penjualan.penjualanDataSetTableAdapters.PenjualanMasterTableAdapter()
        Me.TableAdapterManager = New Penjualan.penjualanDataSetTableAdapters.TableAdapterManager()
        Me.txtDiskon = New System.Windows.Forms.TextBox()
        Me.jmlDiskon = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbTotalBayar = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PenjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Label1.ForeColor = System.Drawing.Color.Lime
        Label1.Location = New System.Drawing.Point(132, 120)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(19, 30)
        Label1.TabIndex = 10
        Label1.Text = ":"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Label4.ForeColor = System.Drawing.Color.Lime
        Label4.Location = New System.Drawing.Point(28, 121)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(81, 30)
        Label4.TabIndex = 9
        Label4.Text = "Diskon"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Label12.ForeColor = System.Drawing.Color.Lime
        Label12.Location = New System.Drawing.Point(28, 167)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(109, 30)
        Label12.TabIndex = 9
        Label12.Text = "Potongan"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Label13.ForeColor = System.Drawing.Color.Lime
        Label13.Location = New System.Drawing.Point(132, 168)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(19, 30)
        Label13.TabIndex = 10
        Label13.Text = ":"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(430, 351)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(121, 47)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.DodgerBlue
        Me.OK_Button.FlatAppearance.BorderSize = 0
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.ForeColor = System.Drawing.Color.White
        Me.OK_Button.Location = New System.Drawing.Point(5, 5)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(111, 37)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'lbTotal
        '
        Me.lbTotal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.ForeColor = System.Drawing.Color.Lime
        Me.lbTotal.Location = New System.Drawing.Point(149, 83)
        Me.lbTotal.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(325, 30)
        Me.lbTotal.TabIndex = 1
        Me.lbTotal.Text = "0"
        Me.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBayar
        '
        Me.txtBayar.BackColor = System.Drawing.Color.Black
        Me.txtBayar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBayar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar.ForeColor = System.Drawing.Color.Yellow
        Me.txtBayar.Location = New System.Drawing.Point(154, 245)
        Me.txtBayar.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(331, 28)
        Me.txtBayar.TabIndex = 1
        Me.txtBayar.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(28, 244)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bayar "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(28, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 30)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total "
        '
        'lbKembali
        '
        Me.lbKembali.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbKembali.ForeColor = System.Drawing.Color.Lime
        Me.lbKembali.Location = New System.Drawing.Point(149, 306)
        Me.lbKembali.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbKembali.Name = "lbKembali"
        Me.lbKembali.Size = New System.Drawing.Size(325, 30)
        Me.lbKembali.TabIndex = 1
        Me.lbKembali.Text = "0"
        Me.lbKembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(571, 417)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Yellow
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 149
        Me.LineShape3.X2 = 478
        Me.LineShape3.Y1 = 152
        Me.LineShape3.Y2 = 152
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Yellow
        Me.LineShape2.BorderWidth = 3
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 144
        Me.LineShape2.X2 = 473
        Me.LineShape2.Y1 = 285
        Me.LineShape2.Y2 = 285
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 144
        Me.LineShape1.X2 = 219
        Me.LineShape1.Y1 = 281
        Me.LineShape1.Y2 = 304
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(28, 303)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 30)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Kembali "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(130, 243)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 30)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Lime
        Me.Label7.Location = New System.Drawing.Point(132, 83)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 30)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Lime
        Me.Label8.Location = New System.Drawing.Point(132, 306)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 30)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = ":"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(571, 67)
        Me.Panel2.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.DimGray
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Image = Global.Penjualan.My.Resources.Resources.Happy_64px
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(569, 65)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "TERIMA KASIH"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PenjualanDataSet
        '
        Me.PenjualanDataSet.DataSetName = "penjualanDataSet"
        Me.PenjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PenjualanMasterBindingSource
        '
        Me.PenjualanMasterBindingSource.DataMember = "PenjualanMaster"
        Me.PenjualanMasterBindingSource.DataSource = Me.PenjualanDataSet
        '
        'PenjualanMasterTableAdapter
        '
        Me.PenjualanMasterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BarangTableAdapter = Nothing
        Me.TableAdapterManager.JenisTableAdapter = Nothing
        Me.TableAdapterManager.PembelianDetilTableAdapter = Nothing
        Me.TableAdapterManager.PembelianMasterTableAdapter = Nothing
        Me.TableAdapterManager.PengaturanTableAdapter = Nothing
        Me.TableAdapterManager.PenjualanDetilTableAdapter = Nothing
        Me.TableAdapterManager.PenjualanMasterTableAdapter = Me.PenjualanMasterTableAdapter
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Penjualan.penjualanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtDiskon
        '
        Me.txtDiskon.BackColor = System.Drawing.Color.Black
        Me.txtDiskon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiskon.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiskon.ForeColor = System.Drawing.Color.Yellow
        Me.txtDiskon.Location = New System.Drawing.Point(154, 120)
        Me.txtDiskon.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDiskon.Name = "txtDiskon"
        Me.txtDiskon.Size = New System.Drawing.Size(331, 28)
        Me.txtDiskon.TabIndex = 0
        Me.txtDiskon.Text = "0"
        '
        'jmlDiskon
        '
        Me.jmlDiskon.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jmlDiskon.ForeColor = System.Drawing.Color.Lime
        Me.jmlDiskon.Location = New System.Drawing.Point(149, 170)
        Me.jmlDiskon.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.jmlDiskon.Name = "jmlDiskon"
        Me.jmlDiskon.Size = New System.Drawing.Size(325, 30)
        Me.jmlDiskon.TabIndex = 1
        Me.jmlDiskon.Text = "0"
        Me.jmlDiskon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Lime
        Me.Label11.Location = New System.Drawing.Point(132, 208)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 30)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = ":"
        '
        'lbTotalBayar
        '
        Me.lbTotalBayar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalBayar.ForeColor = System.Drawing.Color.Lime
        Me.lbTotalBayar.Location = New System.Drawing.Point(149, 211)
        Me.lbTotalBayar.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbTotalBayar.Name = "lbTotalBayar"
        Me.lbTotalBayar.Size = New System.Drawing.Size(325, 30)
        Me.lbTotalBayar.TabIndex = 1
        Me.lbTotalBayar.Text = "0"
        Me.lbTotalBayar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DialogBayar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(571, 417)
        Me.Controls.Add(Me.lbTotalBayar)
        Me.Controls.Add(Label13)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.jmlDiskon)
        Me.Controls.Add(Me.txtDiskon)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbKembali)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogBayar"
        Me.Opacity = 0.98R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembayaran"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PenjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents txtBayar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbKembali As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PenjualanDataSet As Penjualan.penjualanDataSet
    Friend WithEvents PenjualanMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PenjualanMasterTableAdapter As Penjualan.penjualanDataSetTableAdapters.PenjualanMasterTableAdapter
    Friend WithEvents TableAdapterManager As Penjualan.penjualanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtDiskon As System.Windows.Forms.TextBox
    Friend WithEvents jmlDiskon As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbTotalBayar As System.Windows.Forms.Label

End Class
