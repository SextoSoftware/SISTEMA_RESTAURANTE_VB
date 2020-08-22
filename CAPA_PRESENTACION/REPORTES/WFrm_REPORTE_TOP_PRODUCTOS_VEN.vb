Public Class WFrm_REPORTE_TOP_PRODUCTOS_VEN
    Inherits DevComponents.DotNetBar.Office2007Form
    Public v As New CAPA_NEGOCIO.CpN_Cls_VALIDACIONES
    Private Sub WFrm_REPORTE_TOP_PRODUCTOS_VEN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Restaurante.PA_ReporteTopProductosVendidosFechas' table. You can move, or remove it, as needed.
     

        'TODO: This line of code loads data into the 'DataSet_Restaurante.PA_ReporteTopProductosVendidos' table. You can moveD:\SISTEMA_RESTAURANTE_SAMARITANA\CAPA_PRESENTACION\REPORTES\Report_ProductoStock.rdlc, or remove it, as needed.


    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        If txtNomNatu.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR UNA CANTIDAD", MsgBoxStyle.Exclamation)
        Else
            Me.PA_ReporteTopProductosVendidosTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteTopProductosVendidos, txtNomNatu.Text)
            Me.PA_ReporteTopPlatosVendidosTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteTopPlatosVendidos, txtNomNatu.Text)
            Me.ReportViewer2.RefreshReport()
            Me.ReportViewer1.Visible = False
            Me.ReportViewer2.Visible = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        If txtNomNatu.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR UNA CANTIDAD", MsgBoxStyle.Exclamation)
        ElseIf (DateTimePicker1.Text.Trim > Date.Now Or DateTimePicker2.Text.Trim > Date.Now) Then
            MsgBox("NO PUEDES INGRESAR UNA FECHA ADELANTADA", MsgBoxStyle.Critical)
        Else
            Me.PA_ReporteTopProductosVendidosFechasTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteTopProductosVendidosFechas, txtNomNatu.Text, DateTimePicker1.Text, DateTimePicker2.Text)
            Me.PA_ReporteTopPlatosVendidosFechasTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteTopPlatosVendidosFechas, txtNomNatu.Text, DateTimePicker1.Text, DateTimePicker2.Text)
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer2.Visible = False
            Me.ReportViewer1.Visible = True
        End If
    End Sub

    Private Sub ReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub ReportViewer2_Load(sender As System.Object, e As System.EventArgs) Handles ReportViewer2.Load

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub
End Class