<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportPenjualan
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tglAwal = New System.Windows.Forms.DateTimePicker()
        Me.tglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.gridPenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.penjualanDataSet = New Penjualan.penjualanDataSet()
        Me.gridPenjualanTableAdapter = New Penjualan.penjualanDataSetTableAdapters.gridPenjualanTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.gridPenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.penjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.tglAkhir)
        Me.Panel1.Controls.Add(Me.tglAwal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 51)
        Me.Panel1.TabIndex = 0
        '
        'tglAwal
        '
        Me.tglAwal.Location = New System.Drawing.Point(16, 13)
        Me.tglAwal.Name = "tglAwal"
        Me.tglAwal.Size = New System.Drawing.Size(200, 20)
        Me.tglAwal.TabIndex = 0
        '
        'tglAkhir
        '
        Me.tglAkhir.Location = New System.Drawing.Point(243, 13)
        Me.tglAkhir.Name = "tglAkhir"
        Me.tglAkhir.Size = New System.Drawing.Size(200, 20)
        Me.tglAkhir.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(453, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Tampilkan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "s/d"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "DataSetLaporan"
        ReportDataSource3.Value = Me.gridPenjualanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Penjualan.ReportJual.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 51)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(670, 569)
        Me.ReportViewer1.TabIndex = 1
        '
        'gridPenjualanBindingSource
        '
        Me.gridPenjualanBindingSource.DataMember = "gridPenjualan"
        Me.gridPenjualanBindingSource.DataSource = Me.penjualanDataSet
        '
        'penjualanDataSet
        '
        Me.penjualanDataSet.DataSetName = "penjualanDataSet"
        Me.penjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gridPenjualanTableAdapter
        '
        Me.gridPenjualanTableAdapter.ClearBeforeFill = True
        '
        'FormReportPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 620)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormReportPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Penjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gridPenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.penjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents tglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents gridPenjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents penjualanDataSet As Penjualan.penjualanDataSet
    Friend WithEvents gridPenjualanTableAdapter As Penjualan.penjualanDataSetTableAdapters.gridPenjualanTableAdapter
End Class
