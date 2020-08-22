Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Public Class WFrm_BuscarProveedor
    Inherits DevComponents.DotNetBar.Office2007Form
    Public objnegocio As New CAPA_NEGOCIO.CpN_Cls_PROVEEDOR
    Public objentidade As New CAPA_ENTIDAD.CpE_Cls_PROVEEDOR
    Public v As New CAPA_NEGOCIO.CpN_Cls_VALIDACIONES
    Public buscar As Integer
    Private Sub WFrm_BuscarProveedor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dg_Proveedores.DataSource = objnegocio.MOSTRAR_PROVEEDORES_ESTADO(objentidade)
        Dg_Proveedores.Columns(0).Width = 40
        Dg_Proveedores.Columns(1).Width = 140
        Dg_Proveedores.Columns(2).Width = 140
        Dg_Proveedores.Columns(3).Width = 80
        Dg_Proveedores.Columns(4).Width = 70
    End Sub

    Private Sub Dg_Proveedores_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellContentClick

    End Sub

    Private Sub Dg_Proveedores_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellDoubleClick
        If opcionbusqueda = 2 Then
            If (e.RowIndex = -1) Then Return
            If IsDBNull(Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value) Then

                Return
            Else
                Dim OrdenCompra As New WFrm_ORDEN_COMPRA
                WFrm_ORDEN_COMPRA.TextBox2.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value()
                WFrm_ORDEN_COMPRA.TextBoxX1.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(1).Value()
                WFrm_ORDEN_COMPRA.MostraProductos()
                Close()
            End If

        End If
        If opcionbusqueda = 1 Then
            If (e.RowIndex = -1) Then Return
            If IsDBNull(Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value) Then

                Return
            Else
                Dim OrdenCompra As New WFrm_ORDEN_COMPRA
                WFrm_ABASTECER.TextBox2.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value()
                WFrm_ABASTECER.TextBoxX1.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(1).Value()
                WFrm_ABASTECER.TextBoxX3.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(3).Value()
                Close()
            End If
        End If
    End Sub

    Private Sub GroupPanel2_Click(sender As System.Object, e As System.EventArgs) Handles GroupPanel2.Click

    End Sub

    Private Sub TextBoxX7_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbusqueda.TextChanged
        objentidade.ruc = txtbusqueda.Text
        objentidade.NombreCompañia = txtbusqueda.Text
        If buscar = 1 Then
            txtbusqueda.MaxLength = 30
            objentidade.opcion = 1
            Dg_Proveedores.DataSource = objnegocio.BUSCAR_PROVEEDOR_ACTIVOS(objentidade)
        End If
        If buscar = 2 Then
            txtbusqueda.MaxLength = 11
            objentidade.opcion = 2
            Dg_Proveedores.DataSource = objnegocio.BUSCAR_PROVEEDOR_ACTIVOS(objentidade)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        buscar = 1
        txtbusqueda.Text = ""
        txtbusqueda.Focus()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        buscar = 2
        txtbusqueda.Text = ""
        txtbusqueda.Focus()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Close()
    End Sub
End Class