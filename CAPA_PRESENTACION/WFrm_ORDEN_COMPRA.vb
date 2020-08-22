
Public Class WFrm_ORDEN_COMPRA
    Inherits DevComponents.DotNetBar.Office2007Form
    Public i As Integer
    Public estado, NOMBRE, MEDIDA As String
    Public contar, CODIGO, CANT_MEDIDA As Integer
    Public v As New CAPA_NEGOCIO.CpN_Cls_VALIDACIONES
    Public objnegocio As New CAPA_NEGOCIO.CpN_Cls_ORDEN_COMPRA
    Public objentidade As New CAPA_ENTIDAD.CpE_Cls_ORDEN_COMPRA
    Public objnegocio1 As New CAPA_NEGOCIO.CpN_Cls_ABASTECER
    Public objentidade1 As New CAPA_ENTIDAD.CpE_Cls_ABASTECER
    Public objnegocio2 As New CAPA_NEGOCIO.CpN_Cls_PRODUCTO
    Public objentidade2 As New CAPA_ENTIDAD.CpE_Cls_PRODUCTO
    Public Sub limpiar_textos()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBoxX1.Text = ""
     
        ListView1.Items.Clear()
        i = 0
        Dg_Proveedores.DataSource = Nothing
        Dg_Proveedores.Refresh()
    End Sub
    Private Sub WFrm_ORDEN_COMPRA_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub MostraProductos()
        objentidade1.idproveedor = Me.TextBox2.Text
        Dg_Proveedores.DataSource = objnegocio1.MOSTRAR_PRODUCTO_ABASTECE_PROVEEDOR(objentidade1)
        Dg_Proveedores.Columns(0).Width = 30
        Dg_Proveedores.Columns(1).Width = 125
        ' Dg_Proveedores.Columns(0).Visible = False
        Dg_Proveedores.Columns(2).Visible = False
        Dg_Proveedores.Columns(4).Visible = False
        Dg_Proveedores.Columns(5).Visible = False
    End Sub


    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        opcionbusqueda = 2
        MENU_PRINCIPAL.AbrirVentana_Buscar_Proveedor()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs)
        My.Forms.WFrm_BuscarProducto.Show()
    End Sub


    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        For o As Integer = ListView1.SelectedItems.Count - 1 To 0 Step -1
            ListView1.SelectedItems(o).Remove()
        Next
        i = i - 1
    End Sub

    Private Sub ButtonX3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX3.Click
        ListView1.Items.Clear()
        i = 0
    End Sub

    Private Sub GroupPanel3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub buttonX11_Click(sender As System.Object, e As System.EventArgs) Handles buttonX11.Click
        If estado = "PENDIENTE" Then
            contar = ListView1.Items.Count
            If Me.TextBox2.Text = "" Or Me.TextBox2.Text = "" Or contar = 0 Then
                MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
            Else
                If v.MensajeGuardar() = 6 Then
                    objentidade.idproveedor = TextBox2.Text
                    objentidade.Estado = estado
                    objentidade.descripcion = TextBox2.Text
                    objentidade.fecha = DateTimePicker2.Text.Trim
                    objnegocio.REGISTRAR_ORDEN_COMPRA(objentidade)
                    objnegocio.CAPTURA_CODIGO_ORDEN_COMPRA(objentidade)
                    TextBox1.Text = objentidade.idOrdenCompra
                    Dim z As Integer
                    For z = 0 To ListView1.Items.Count - 1
                        objentidade.idproducto = ListView1.Items(z).SubItems(0).Text
                        objentidade.cantidad = ListView1.Items(z).SubItems(4).Text
                        objentidade.idOrdenCompra = CInt(TextBox1.Text)
                        objentidade.estadoPro = ListView1.Items(z).SubItems(5).Text
                        objnegocio.REGISTRAR_DETALLE_ORDEN_COMPRA(objentidade)
                    Next

                    Dim stock, stocktotal As Integer
                    Dim canti As Integer
                    For x = 0 To ListView1.Items.Count - 1

                        objentidade2.idproducto = ListView1.Items(x).SubItems(0).Text

                        canti = ListView1.Items(x).SubItems(4).Text

                        Dim zz As Integer
                        For zz = 0 To Dg_Proveedores.RowCount - 2
                            If objentidade2.idproducto = Dg_Proveedores.Rows.Item(zz).Cells(0).Value Then
                                stock = Dg_Proveedores.Rows.Item(zz).Cells(3).Value
                            End If
                        Next
                        stocktotal = stock + canti
                        objentidade2.stock = stocktotal
                        objnegocio2.MODIFICAR_STOCK_PRODUCTO(objentidade2)

                    Next

                    i = 0

                    idordencompraImprime = TextBox1.Text
                    MENU_PRINCIPAL.AbrirVentana_Reporte_OrdenCompra()
                    limpiar_textos()
                    Close()

                End If



             


            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        estado = "PENDIENTE"
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        limpiar_textos()
    End Sub

    Private Sub Dg_Proveedores_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellContentClick

    End Sub

    Private Sub Dg_Proveedores_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellDoubleClick
        If (e.RowIndex = -1) Then Return
        If IsDBNull(Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value) Then

            Return
        Else
            codigo = Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value()
            nombre = Dg_Proveedores.Rows(e.RowIndex).Cells(1).Value()
            tipo = Dg_Proveedores.Rows(e.RowIndex).Cells(2).Value()
            MEDIDA = Dg_Proveedores.Rows(e.RowIndex).Cells(4).Value()
            CANT_MEDIDA = Dg_Proveedores.Rows(e.RowIndex).Cells(5).Value()
            codigoNuevaCantidad = 3
            My.Forms.WFrm_Cantidad.Show()
        End If
    End Sub

    Private Sub Dg_Proveedores_DataBindingComplete(sender As Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles Dg_Proveedores.DataBindingComplete
        Dim i As Integer
        For i = 0 To Dg_Proveedores.Rows.Count - 2

            If Dg_Proveedores.Item(3, i).Value() <= 10 Then
                Dg_Proveedores.Rows(i).DefaultCellStyle.BackColor = Color.Red
                Dg_Proveedores.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Public Sub Agregar()
        Dim conta As Integer

        Dim cod, cod1 As String
        If codigo = 0 Or nombre = "" Then
            MsgBox("DEBES INGRESAR DATOS DEL PRODUCTO", MsgBoxStyle.Exclamation)
        Else

            If ListView1.Items.Count > 0 Then
                cod = codigo
                Dim z As Integer
                For z = 0 To ListView1.Items.Count - 1
                    cod1 = ListView1.Items(z).SubItems(0).Text
                    If cod = cod1 Then
                        conta = conta + 1
                    End If
                Next

            End If

            If conta > 0 Then
                MsgBox("EL PRODUCTO YA EXISTE EN LA LISTA", MsgBoxStyle.Critical)
                codigo = 0
                nombre = ""
                '  TextBox7.Text = ""
            Else
                ListView1.Items.Add(codigo)
                ListView1.Items(i).SubItems.Add(nombre)
                ListView1.Items(i).SubItems.Add(tipo)
                ListView1.Items(i).SubItems.Add(MEDIDA)
                ListView1.Items(i).SubItems.Add(cantidadplato)
                ListView1.Items(i).SubItems.Add("PENDIENTE")
                ListView1.Items(i).SubItems.Add(CANT_MEDIDA)
                i = i + 1
                codigo = 0
                nombre = ""
                'TextBox7.Text = ""
            End If

        End If
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As System.EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            codigoNuevaCantidad = 4
            My.Forms.WFrm_Cantidad.Show()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class