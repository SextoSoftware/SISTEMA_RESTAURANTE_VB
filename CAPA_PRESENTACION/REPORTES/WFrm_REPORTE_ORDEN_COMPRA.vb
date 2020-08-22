Public Class WFrm_REPORTE_ORDEN_COMPRA
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub WFrm_REPORTE_ORDEN_COMPRA_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'barrica_bdDataSet.PA_ReporteOrdenCompra' Puede moverla o quitarla según sea necesario.
        Me.PA_ReporteOrdenCompraTableAdapter.Fill(Me.barrica_bdDataSet.PA_ReporteOrdenCompra, idordencompraImprime)
        'TODO: esta línea de código carga datos en la tabla 'barrica_bdDataSet.PA_ReporteVentasFechas' Puede moverla o quitarla según sea necesario.
      
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class