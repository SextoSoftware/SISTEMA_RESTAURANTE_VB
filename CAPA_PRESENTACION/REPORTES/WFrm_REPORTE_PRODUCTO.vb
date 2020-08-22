Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Public Class WFrm_REPORTE_PRODUCTO
    Inherits DevComponents.DotNetBar.Office2007Form
    Public objnegocio1 As New CAPA_NEGOCIO.CpN_Cls_TIPO_PRODUCTO
    Public objentidade1 As New CAPA_ENTIDAD.CpE_Cls_TIPO_PRODUCTO
    Private Sub WFrm_REPORTE_PRODUCTO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Restaurante.PA_ReporteProductos' table. You can move, or remove it, as needed.

        Me.ComboBoxEx1.DataSource = objnegocio1.MOSTRAR_TIPO_PRODCUTO_ACTIVO(objentidade1)
        Me.ComboBoxEx1.DisplayMember = "Nombre"
        Me.ComboBoxEx1.ValueMember = "IdTipoProducto"
        Me.ComboBoxEx1.SelectedIndex = -1


        Me.PA_ReporteProductosTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteProductos, "")
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.ComboBoxEx1.DataSource = objnegocio1.MOSTRAR_TIPO_PRODCUTO_ACTIVO(objentidade1)
        Me.ComboBoxEx1.DisplayMember = "Nombre"
        Me.ComboBoxEx1.ValueMember = "IdTipoProducto"
        Me.ComboBoxEx1.SelectedIndex = -1


        Me.PA_ReporteProductosTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteProductos, "")
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        Me.PA_ReporteProductosTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteProductos, Me.ComboBoxEx1.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class