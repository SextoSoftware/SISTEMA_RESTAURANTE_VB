Public Class WFrm_REPORTE_MENU_DIA
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub WFrm_REPORTE_MENU_DIA_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Restaurante.PA_Reporte_MenuDia' table. You can move, or remove it, as needed.
        Me.PA_Reporte_MenuDiaTableAdapter.Fill(Me.DataSet_Restaurante.PA_Reporte_MenuDia, CodigoMenuDia)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub RadioButtonInactivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonInactivo.CheckedChanged
        If RadioButtonInactivo.Checked = True Then
            ReportViewer2.Visible = True
            ReportViewer1.Visible = False
            Me.ReportViewer2.RefreshReport()
        Else
            ReportViewer1.Visible = False
        End If
    End Sub

    Private Sub RadioButtonActivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonActivo.CheckedChanged
        If RadioButtonActivo.Checked = True Then
            ReportViewer1.Visible = True
            Me.PA_Reporte_MenuDiaTableAdapter.Fill(Me.DataSet_Restaurante.PA_Reporte_MenuDia, CodigoMenuDia)

            Me.ReportViewer1.RefreshReport()
            ReportViewer2.Visible = False
        Else
            ReportViewer2.Visible = False
        End If
    End Sub


End Class