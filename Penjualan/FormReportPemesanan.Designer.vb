<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportPemesanan
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.penjualanDataSet = New Penjualan.penjualanDataSet()
        Me.GridReportBeliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridReportBeliTableAdapter = New Penjualan.penjualanDataSetTableAdapters.GridReportBeliTableAdapter()
        CType(Me.penjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridReportBeliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSetPembelian"
        ReportDataSource2.Value = Me.GridReportBeliBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Penjualan.ReportPembelian.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(709, 568)
        Me.ReportViewer1.TabIndex = 0
        '
        'penjualanDataSet
        '
        Me.penjualanDataSet.DataSetName = "penjualanDataSet"
        Me.penjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridReportBeliBindingSource
        '
        Me.GridReportBeliBindingSource.DataMember = "GridReportBeli"
        Me.GridReportBeliBindingSource.DataSource = Me.penjualanDataSet
        '
        'GridReportBeliTableAdapter
        '
        Me.GridReportBeliTableAdapter.ClearBeforeFill = True
        '
        'FormReportPemesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 568)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReportPemesanan"
        Me.Text = "FormReportPemesanan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.penjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridReportBeliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GridReportBeliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents penjualanDataSet As Penjualan.penjualanDataSet
    Friend WithEvents GridReportBeliTableAdapter As Penjualan.penjualanDataSetTableAdapters.GridReportBeliTableAdapter
End Class
