Public Class WFrm_REPORTE_COMANDAS
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub WFrm_REPORTE_COMANDAS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Restaurante.PA_ReporteComandas' table. You can move, or remove it, as needed.
        Me.PA_ReporteComandasTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteComandas, CodigoImprimirComanda)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class