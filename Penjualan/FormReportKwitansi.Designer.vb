<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportKwitansi
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.gridPenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.penjualanDataSet = New Penjualan.penjualanDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.gridPenjualanTableAdapter = New Penjualan.penjualanDataSetTableAdapters.gridPenjualanTableAdapter()
        CType(Me.gridPenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.penjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSetPenjualan"
        ReportDataSource2.Value = Me.gridPenjualanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Penjualan.ReportKwitansi.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(384, 399)
        Me.ReportViewer1.TabIndex = 0
        '
        'gridPenjualanTableAdapter
        '
        Me.gridPenjualanTableAdapter.ClearBeforeFill = True
        '
        'FormReportKwitansi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 399)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReportKwitansi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormReportKwitansi"
        CType(Me.gridPenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.penjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents gridPenjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents penjualanDataSet As Penjualan.penjualanDataSet
    Friend WithEvents gridPenjualanTableAdapter As Penjualan.penjualanDataSetTableAdapters.gridPenjualanTableAdapter
End Class
