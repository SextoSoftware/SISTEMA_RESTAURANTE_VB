<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WFrm_REPORTE_ORDEN_COMPRA
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WFrm_REPORTE_ORDEN_COMPRA))
        Me.PA_ReporteOrdenCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.barrica_bdDataSet = New CAPA_PRESENTACION.barrica_bdDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PA_ReporteOrdenCompraTableAdapter = New CAPA_PRESENTACION.barrica_bdDataSetTableAdapters.PA_ReporteOrdenCompraTableAdapter()
        CType(Me.PA_ReporteOrdenCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barrica_bdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PA_ReporteOrdenCompraBindingSource
        '
        Me.PA_ReporteOrdenCompraBindingSource.DataMember = "PA_ReporteOrdenCompra"
        Me.PA_ReporteOrdenCompraBindingSource.DataSource = Me.barrica_bdDataSet
        '
        'barrica_bdDataSet
        '
        Me.barrica_bdDataSet.DataSetName = "barrica_bdDataSet"
        Me.barrica_bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PA_ReporteOrdenCompraBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CAPA_PRESENTACION.Report_OrdenCompra.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(641, 532)
        Me.ReportViewer1.TabIndex = 0
        '
        'PA_ReporteOrdenCompraTableAdapter
        '
        Me.PA_ReporteOrdenCompraTableAdapter.ClearBeforeFill = True
        '
        'WFrm_REPORTE_ORDEN_COMPRA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 532)
        Me.Controls.Add(Me.ReportViewer1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WFrm_REPORTE_ORDEN_COMPRA"
        Me.Text = "FORMULARIO REPORTE ORDEN DE COMPRA"
        CType(Me.PA_ReporteOrdenCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barrica_bdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PA_ReporteOrdenCompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents barrica_bdDataSet As CAPA_PRESENTACION.barrica_bdDataSet
    Friend WithEvents PA_ReporteOrdenCompraTableAdapter As CAPA_PRESENTACION.barrica_bdDataSetTableAdapters.PA_ReporteOrdenCompraTableAdapter
End Class
