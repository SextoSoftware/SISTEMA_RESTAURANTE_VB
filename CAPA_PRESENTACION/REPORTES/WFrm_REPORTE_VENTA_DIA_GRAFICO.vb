Public Class WFrm_REPORTE_VENTA_DIA_GRAFICO
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub WFrm_REPORTE_VENTA_DIA_GRAFICO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Restaurante.PA_ReporteVentasDiasGrafico' table. You can move, or remove it, as needed.
        Me.PA_ReporteVentasDiasGraficoTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteVentasDiasGrafico, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)

        Me.ReportViewer1.RefreshReport()
    End Sub

 

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Me.PA_ReporteVentasDiasGraficoTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteVentasDiasGrafico, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class