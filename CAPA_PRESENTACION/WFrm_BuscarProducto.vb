Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Public Class WFrm_BuscarProducto
    Inherits DevComponents.DotNetBar.Office2007Form
    Public objnegocio As New CAPA_NEGOCIO.CpN_Cls_PRODUCTO
    Public objentidade As New CAPA_ENTIDAD.CpE_Cls_PRODUCTO
    Public v As New CAPA_NEGOCIO.CpN_Cls_VALIDACIONES
    Private Sub WFrm_BuscarProducto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dg_Producto.DataSource = objnegocio.MOSTRAR_PRODUCTO_ESTADO(objentidade)
        Dg_Producto.Columns(0).Width = 40
        Dg_Producto.Columns(1).Width = 140
        Dg_Producto.Columns(2).Width = 140
        Dg_Producto.Columns(3).Width = 80
        Dg_Producto.Columns(4).Width = 80
    End Sub

    Private Sub Dg_Producto_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Producto.CellContentClick

    End Sub

    Private Sub Dg_Producto_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Producto.CellDoubleClick
       
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Close()
    End Sub
End Class