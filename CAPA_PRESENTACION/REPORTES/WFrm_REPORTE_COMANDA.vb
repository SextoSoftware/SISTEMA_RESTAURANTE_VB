Public Class WFrm_REPORTE_COMANDA
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub WFrm_REPORTE_COMANDA_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Restaurante.PA_ReporteComanda' table. You can move, or remove it, as needed.
        Me.PA_ReporteComandaTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteComanda, CodigoImprimirComanda)
        Me.ReportViewer2.RefreshReport()
    End Sub
End Class