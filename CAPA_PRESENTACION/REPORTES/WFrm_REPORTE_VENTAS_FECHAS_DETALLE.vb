Public Class WFrm_REPORTE_VENTAS_FECHAS_DETALLE
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub WFrm_REPORTE_VENTAS_FECHAS_DETALLE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Restaurante.PA_ReporteVentasFechasDetallado' table. You can move, or remove it, as needed.
        Me.PA_ReporteVentasFechasDetalladoTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteVentasFechasDetallado, DateTimePicker1.Text, DateTimePicker2.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        If (DateTimePicker1.Text.Trim > Date.Now Or DateTimePicker2.Text.Trim > Date.Now) Then
            MsgBox("NO PUEDES INGRESAR UNA FECHA ADELANTADA", MsgBoxStyle.Critical)
        Else
            Me.PA_ReporteVentasFechasDetalladoTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteVentasFechasDetallado, DateTimePicker1.Text, DateTimePicker2.Text)
            Me.ReportViewer1.RefreshReport()

        End If
    End Sub
End Class