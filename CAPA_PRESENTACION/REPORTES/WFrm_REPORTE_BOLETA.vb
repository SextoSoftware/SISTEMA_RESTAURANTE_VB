Public Class WFrm_REPORTE_BOLETA
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub WFrm_REPORTE_BOLETA_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Restaurante.PA_ReportarBoleta' table. You can move, or remove it, as needed.
        Me.PA_ReportarBoletaTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReportarBoleta, CodigoImprimirComanda)
        Me.ReportViewer2.RefreshReport()
    End Sub
End Class