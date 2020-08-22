Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Public Class WFrm_REPORTE_TOP_PRODUCTO_GRAFICO
    Inherits DevComponents.DotNetBar.Office2007Form
    Public objnegocio1 As New CAPA_NEGOCIO.CpN_Cls_TIPO_PRODUCTO
    Public objentidade1 As New CAPA_ENTIDAD.CpE_Cls_TIPO_PRODUCTO
    Public objnegocio As New CAPA_NEGOCIO.CpN_Cls_CATEGORIA_PLATO
    Public objentidade As New CAPA_ENTIDAD.CpE_Cls_CATEGORIA_PLATO
    Private Sub WFrm_REPORTE_TOP_PRODUCTO_GRAFICO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



        Me.ComboBoxEx1.DataSource = objnegocio1.MOSTRAR_TIPO_PRODCUTO_ACTIVO(objentidade1)
        Me.ComboBoxEx1.DisplayMember = "Nombre"
        Me.ComboBoxEx1.ValueMember = "IdTipoProducto"
        Me.ComboBoxEx1.SelectedIndex = -1


        Me.ComboBoxEx2.DataSource = objnegocio.MOSTRAR_CATEGORIA_PLATO_ACTIVO(objentidade)
        Me.ComboBoxEx2.DisplayMember = "Nombre"
        Me.ComboBoxEx2.ValueMember = "IdCategoria"
        Me.ComboBoxEx2.SelectedIndex = -1


        Me.PA_ReporteTopPlatoGraficoTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteTopPlatoGrafico, "")
        'TODO: This line of code loads data into the 'DataSet_Restaurante.PA_ReporteTopPlatoGrafico' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'DataSet_Restaurante.PA_ReporteTopProductoGrafico' table. You can move, or remove it, as needed.
        Me.PA_ReporteTopProductoGraficoTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteTopProductoGrafico, "")

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxEx1.SelectedIndexChanged
        Me.PA_ReporteTopProductoGraficoTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteTopProductoGrafico, Me.ComboBoxEx1.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ComboBoxEx2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxEx2.SelectedIndexChanged
        Me.PA_ReporteTopPlatoGraficoTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteTopPlatoGrafico, Me.ComboBoxEx2.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.ComboBoxEx1.DataSource = objnegocio1.MOSTRAR_TIPO_PRODCUTO_ACTIVO(objentidade1)
        Me.ComboBoxEx1.DisplayMember = "Nombre"
        Me.ComboBoxEx1.ValueMember = "IdTipoProducto"
        Me.ComboBoxEx1.SelectedIndex = -1


        Me.ComboBoxEx2.DataSource = objnegocio.MOSTRAR_CATEGORIA_PLATO_ACTIVO(objentidade)
        Me.ComboBoxEx2.DisplayMember = "Nombre"
        Me.ComboBoxEx2.ValueMember = "IdCategoria"
        Me.ComboBoxEx2.SelectedIndex = -1

        Me.PA_ReporteTopPlatoGraficoTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteTopPlatoGrafico, "")
        'TODO: This line of code loads data into the 'DataSet_Restaurante.PA_ReporteTopPlatoGrafico' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'DataSet_Restaurante.PA_ReporteTopProductoGrafico' table. You can move, or remove it, as needed.
        Me.PA_ReporteTopProductoGraficoTableAdapter.Fill(Me.DataSet_Restaurante.PA_ReporteTopProductoGrafico, "")

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class