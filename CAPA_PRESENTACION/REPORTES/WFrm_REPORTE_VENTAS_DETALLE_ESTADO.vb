Public Class WFrm_REPORTE_VENTAS_DETALLE_ESTADO
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub WFrm_REPORTE_VENTAS_DETALLE_ESTADO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Restaurante.PA_ReporteVentasDetalladoEstado' table. You can move, or remove it, as needed.
        Me.PA_ReporteVentasDetalladoEstadoTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteVentasDetalladoEstado, DateTimePicker1.Text, DateTimePicker2.Text, "PENDIENTE")

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        If RadioButton1.Checked = True Then
            If (DateTimePicker1.Text.Trim > Date.Now Or DateTimePicker2.Text.Trim > Date.Now) Then
                MsgBox("NO PUEDES INGRESAR UNA FECHA ADELANTADA", MsgBoxStyle.Critical)
            Else
                Me.PA_ReporteVentasDetalladoEstadoTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteVentasDetalladoEstado, DateTimePicker1.Text, DateTimePicker2.Text, "PENDIENTE")
                Me.ReportViewer1.RefreshReport()

            End If
        End If
        If RadioButton2.Checked = True Then
            If (DateTimePicker1.Text.Trim > Date.Now Or DateTimePicker2.Text.Trim > Date.Now) Then
                MsgBox("NO PUEDES INGRESAR UNA FECHA ADELANTADA", MsgBoxStyle.Critical)
            Else
                Me.PA_ReporteVentasDetalladoEstadoTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteVentasDetalladoEstado, DateTimePicker1.Text, DateTimePicker2.Text, "CANCELADO")
                Me.ReportViewer1.RefreshReport()

            End If
        End If
    End Sub
End Class