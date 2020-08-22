Public Class WFrm_REPORTE_STOCK_PRODUCTO
    Inherits DevComponents.DotNetBar.Office2007Form
    Public v As New CAPA_NEGOCIO.CpN_Cls_VALIDACIONES
    Private Sub WFrm_REPORTE_STOCK_PRODUCTO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Restaurante.PA_ReporteXstock' table. You can move, or remove it, as needed.

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        If txtNomNatu.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR UNA CANTIDAD", MsgBoxStyle.Exclamation)
        Else
            Me.PA_ReporteXstockTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteXstock, txtNomNatu.Text)
            Me.ReportViewer2.RefreshReport()
        End If
    End Sub

    Private Sub txtNomNatu_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNomNatu.KeyPress
        e.Handled = v.validaNumeros(e)
    End Sub

    Private Sub txtNomNatu_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNomNatu.TextChanged

    End Sub
End Class