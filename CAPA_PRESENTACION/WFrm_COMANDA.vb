Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text
Public Class WFrm_COMANDA
    Inherits DevComponents.DotNetBar.Office2007Form
    Public objnegocio1 As New CAPA_NEGOCIO.CpN_Cls_MESA
    Public objentidade1 As New CAPA_ENTIDAD.CpE_Cls_MESA

    Public objnegocio2 As New CAPA_NEGOCIO.CpN_Cls_PRODUCTO
    Public objentidade2 As New CAPA_ENTIDAD.CpE_Cls_PRODUCTO

    Public objnegocio3 As New CAPA_NEGOCIO.CpN_Cls_PLATO
    Public objentidade3 As New CAPA_ENTIDAD.CpE_Cls_PLATO

    Public objnegocio5 As New CAPA_NEGOCIO.CpN_Cls_MENU_DIA
    Public objentidade5 As New CAPA_ENTIDAD.CpE_Cls_MENU_DIA

    Public objnegocio4 As New CAPA_NEGOCIO.CpN_Cls_CLIENTE
    Public objentidade4 As New CAPA_ENTIDAD.CpE_Cls_CLIENTE

    Public objnegocio6 As New CAPA_NEGOCIO.CpN_Cls_COMANDA
    Public objentidade6 As New CAPA_ENTIDAD.CpE_Cls_COMANDA
    Public v As New CAPA_NEGOCIO.CpN_Cls_VALIDACIONES
    Public buscar, codigo, i, iddocumento As Integer
    Public MONTOGLOBAL As Double
    Public documento As String
    Private Sub WFrm_COMANDA_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



        dgplatos.DataSource = objnegocio5.MOSTRAR_MENU_DIA_ACTIVO(objentidade5)
        dgplatos.Columns(0).Width = 25
        dgplatos.Columns(0).Visible = False
        dgplatos.Columns(1).Width = 160
        dgplatos.Columns(2).Width = 50
        dgplatos.Columns(3).Width = 80
        dgplatos.Columns(4).Visible = False

        Me.ComboBoxEx2.DataSource = objnegocio1.MOSTRAR_MESA(objentidade1)
        Me.ComboBoxEx2.DisplayMember = "Nombre"
        Me.ComboBoxEx2.ValueMember = "IdMesa"

        ' NombreMesaActivo()

        Dg_productos.DataSource = objnegocio2.MOSTRAR_PRODUCTO_ESTADO(objentidade2)
        Dg_productos.Columns(0).Width = 25
        Dg_productos.Columns(0).Visible = False
        Dg_productos.Columns(1).Width = 125
        Dg_productos.Columns(2).Visible = False
        ' Dg_Proveedores.Columns(3).Visible = False
        Dg_productos.Columns(4).Visible = False
        Dg_productos.Columns(3).Width = 50
        Dg_productos.Columns(5).Width = 80


        ' dgplatos.DataSource = objnegocio3.MOSTRAR_PLATO_ESTADO(objentidade3)
        ''dgplatos.Columns(0).Width = 22
        'dgplatos.Columns(1).Width = 115
        'dgplatos.Columns(2).Visible = False
        ' dgplatos.Columns(3).Visible = False


        objentidade4.opcion = 1
        Dgcliente.DataSource = objnegocio4.MOSTRAR_CLIENTE_ACTIVO(objentidade4)
        Dgcliente.Columns(0).Visible = False
        Dgcliente.Columns(0).HeaderText = "ID"
        Dgcliente.Columns(0).Width = 40
        Dgcliente.Columns(1).Width = 75

      

        NombreMesa = ComboBoxEx2.Text




    End Sub
    Public Sub llenarDatos()
        objentidade6.idmesa = Me.txtIdmesa.Text
        objentidade6.fecha = Me.DateTimePicker2.Text
        objentidade6.descripcion = Me.txtdescripcion.Text
        objentidade6.idcliente = Me.txtidcliente.Text
        objentidade6.estado = "PENDIENTE"
        objentidade6.idtipoDucu = Me.iddocumento
        objentidade6.monto = Me.txtmonto.Text
        objentidade6.descuento = CDbl(Me.txtdescuentos.Text)
        If Me.txtidmoz.Text = "" Then
            objentidade6.idMOZO = 0
        Else
            objentidade6.idMOZO = Me.txtidmoz.Text
        End If

    End Sub



    Private Sub ComboBoxEx2_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles ComboBoxEx2.SelectionChangeCommitted
        Dim x As String
        x = Me.ComboBoxEx2.SelectedValue
        txtIdmesa.Text = x
    End Sub
    Public Sub CodigoMesa()
        Dim x As String
        x = Me.ComboBoxEx2.SelectedValue
        txtIdmesa.Text = x
    End Sub
    Public Sub NombreMesaActivo()
        Me.ComboBoxEx2.Text = NombreMesa
        CodigoMesa()
    End Sub


    Private Sub txtbusqueda_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbusqueda.TextChanged
        objentidade2.Nombre = txtbusqueda.Text

        txtbusqueda.MaxLength = 30
        objentidade2.opcion = 1
        Dg_productos.DataSource = objnegocio2.BUSCAR_PRODUCTOS_ACTIVOS(objentidade2)

        If txtbusqueda.Text.StartsWith(" ") Then
            txtbusqueda.Text = txtbusqueda.Text.Trim
        ElseIf txtbusqueda.Text.EndsWith(" ") Then
            txtbusqueda.Text = txtbusqueda.Text.Trim + " "
            txtbusqueda.SelectionStart = txtbusqueda.Text.Length
        End If
    End Sub

    Private Sub Dg_productos_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_productos.CellDoubleClick
        Dim conta As Integer
        Dim validastock As Integer
        Dim cod, cod1, nombre, TIPO, TIPO1 As String
        Dim total, total1, precio As Double


        TIPO = "PR"
        If (e.RowIndex = -1) Then Return
        If IsDBNull(Dg_productos.Rows(e.RowIndex).Cells(0).Value) Then

            Return
        Else
            validastock = Dg_productos.Rows(e.RowIndex).Cells(3).Value()
            codigo = Dg_productos.Rows(e.RowIndex).Cells(0).Value()
            nombre = Dg_productos.Rows(e.RowIndex).Cells(1).Value()
            precio = Dg_productos.Rows(e.RowIndex).Cells(5).Value()
        End If
        If ListView1.Items.Count > 0 Then
            cod = codigo
            Dim z As Integer
            For z = 0 To ListView1.Items.Count - 1
                cod1 = ListView1.Items(z).SubItems(0).Text
                TIPO1 = ListView1.Items(z).SubItems(6).Text

                If cod = cod1 And TIPO1 = "PR" Then
                    conta = conta + 1
                End If
            Next

        End If

        If conta > 0 Then
            MsgBox("EL PRODUCTO YA EXISTE EN LA LISTA", MsgBoxStyle.Critical)
            codigo = 0
            ' TextBox6.Text = ""
            'Me.NumericUpDown1.Value = 1
        Else

            If validastock >= 1 Then
                i = ListView1.Items.Count
                ListView1.Items.Add(codigo)
                ListView1.Items(i).SubItems.Add(nombre)
                ListView1.Items(i).SubItems.Add(1)
                ListView1.Items(i).SubItems.Add(precio)
                ListView1.Items(i).SubItems.Add(precio * 1)
                ListView1.Items(i).SubItems.Add("")
                ListView1.Items(i).SubItems.Add(TIPO)
                i = i + 1
                codigo = 0
                nombre = ""

                For z = 0 To ListView1.Items.Count - 1
                    total = ListView1.Items(z).SubItems(4).Text
                    total1 = total + total1
                    txtmonto.Text = total1
                    MONTOGLOBAL = txtmonto.Text
                Next
            Else
                MsgBox("CANTIDAD NO PERMITIDA EN EL STOCK", MsgBoxStyle.Exclamation)
            End If
        End If


    End Sub


    Private Sub ButtonRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRegistrar.Click
        Dim contar As Integer
        contar = ListView1.Items.Count
        If contar = 0 Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If v.MensajeGuardar() = 6 Then
                llenarDatos()
                objnegocio6.REGISTRAR_COMANDA(objentidade6)
                ' Dg_Proveedores.DataSource = objnegocio.MOSTRAR_CATEGORIA_PLATO(objentidade)
                'limpiar_textos()

                objnegocio6.CAPTURA_CODIGO_COMANDA(objentidade6)
                Me.TextBox1.Text = objentidade6.idcomanda
                Dim tipo As String
                Dim z As Integer
                For z = 0 To ListView1.Items.Count - 1
                    tipo = ListView1.Items(z).SubItems(6).Text
                    objentidade6.idcomanda = CInt(TextBox1.Text)
                    objentidade6.idproducto = ListView1.Items(z).SubItems(0).Text
                    objentidade6.idplato = ListView1.Items(z).SubItems(0).Text
                    objentidade6.cantidad = ListView1.Items(z).SubItems(2).Text
                    objentidade6.importe = ListView1.Items(z).SubItems(4).Text
                    objentidade6.notas = ListView1.Items(z).SubItems(5).Text
                    If tipo = "PR" Then
                        objnegocio6.REGISTRAR_DETALLE_COMANDA_PRODUCTOS(objentidade6)
                    End If
                    If tipo = "PL" Then
                        objnegocio6.REGISTRAR_DETALLE_COMANDA_PLATO(objentidade6)
                    End If
                Next
                Imprimr()

                If documento = "BOLETA" Then
                    ' codigoventa = CInt(TextBox10.Text)
                    ' My.Forms.Reporte_Boleta_Venta.Show()
                End If
                If documento = "FACTURA" Then
                    ' codigoventa = CInt(TextBox10.Text)
                    ' My.Forms.Reporte_Venta_Facturavb.Show()
                End If

                i = 0
                'limpiar_textos()
                Cargar_Mesas_Ocupadas()

                Close()
            End If
        End If
    End Sub





    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCobrar.Click
        If TextBox1.Text.Trim = "" Or ListView1.Items.Count = 0 Or txtnom.Text = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If v.MensajeGuardar() = 6 Then
                llenarDatos()
                objentidade6.Numero = 2
                objentidade6.estado = "CANCELADO"
                objentidade6.OpcionCapturar = 3
                objentidade6.ValorIngresado = ""
                objnegocio6.FAC_CAPTURAS(objentidade6)
                objentidade6.numeroD = objentidade6.ValorSalida
                objnegocio6.MODIFICAR_COMANDA(objentidade6)

                Dim x As Integer
                For x = 0 To ListView1.Items.Count - 1
                    tipo = ListView1.Items(x).SubItems(6).Text
                    objentidade6.idcomanda = Me.TextBox1.Text
                    objentidade6.idproducto = ListView1.Items(x).SubItems(0).Text
                    objentidade6.idplato = ListView1.Items(x).SubItems(0).Text
                    objentidade6.cantidad = ListView1.Items(x).SubItems(2).Text
                    objentidade6.importe = ListView1.Items(x).SubItems(4).Text
                    objentidade6.notas = ListView1.Items(x).SubItems(5).Text
                    If tipo = "PR" Then
                        objnegocio6.MODIFICAR_DETALLE_COMANDA_PRODUCTOS(objentidade6)
                        objnegocio6.AGREGAR_DETALLE_COMANDA_PRODUCTO(objentidade6)
                    End If
                    If tipo = "PL" Then
                        objnegocio6.MODIFICAR_DETALLE_COMANDA_PLATOS(objentidade6)
                        objnegocio6.AGREGAR_DETALLE_COMANDA_PLATO(objentidade6)
                    End If
                Next

                '  Dim x As Integer
                Dim stock, stocktotal As Integer
                Dim canti As Integer
                For x = 0 To ListView1.Items.Count - 1
                    tipo = ListView1.Items(x).SubItems(6).Text
                    objentidade2.idproducto = ListView1.Items(x).SubItems(0).Text
                    objentidade5.idPlato = ListView1.Items(x).SubItems(0).Text
                    canti = ListView1.Items(x).SubItems(2).Text
                    If tipo = "PR" Then
                        Dim z As Integer
                        For z = 0 To Dg_productos.RowCount - 2
                            If objentidade2.idproducto = Dg_productos.Rows.Item(z).Cells(0).Value Then
                                stock = Dg_productos.Rows.Item(z).Cells(3).Value
                            End If
                        Next
                        stocktotal = stock - canti
                        objentidade2.stock = stocktotal
                        objnegocio2.MODIFICAR_STOCK_PRODUCTO(objentidade2)
                    End If
                    If tipo = "PL" Then
                        Dim z As Integer
                        For z = 0 To dgplatos.RowCount - 2
                            If objentidade5.idPlato = dgplatos.Rows.Item(z).Cells(0).Value Then
                                stock = dgplatos.Rows.Item(z).Cells(2).Value
                                objentidade5.idMenu = dgplatos.Rows.Item(z).Cells(4).Value
                            End If
                        Next
                        stocktotal = stock - canti
                        objentidade5.cantidad = stocktotal
                        objnegocio5.MODIFICAR_MENU_CANTDIDAD(objentidade5)
                    End If

                Next

                i = 0

                WFrm_DISEÑO_MESAS.Close()
                MENU_PRINCIPAL.AbrirVentana_DISEÑO_MESAS()
                ImprimerDocumentoVenta()
                Cargar_Mesas_Ocupadas()
                Close()
            End If

        End If


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged

        txtdnruc.MaxLength = 8
        documento = "BOLETA"
        iddocumento = 1
        Label6.Text = "NOMBRE - APELLIDO"
        Label7.Text = "RUT"
        txtnom.Text = ""
        txtdnruc.Text = ""
        'TextBox2.Text = 0
        'TextBox1.Focus()
        CheckBox2.Enabled = True
        CheckBox2.Checked = False

        RadioButtonNom.Text = "Nombre/Apellido"
        RadioButtondniRuc.Text = "Dni"

        RadioButtonNom.Checked = True
        RadioButtondniRuc.Checked = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        iddocumento = 2
        txtdnruc.MaxLength = 11
        documento = "FACTURA"
        Label6.Text = "RAZON SOCIAL"
        Label7.Text = "RUT"
        txtnom.Text = ""
        txtdnruc.Text = ""
        ' TextBox2.Text = 0
        'TextBox1.Focus()
        CheckBox2.Enabled = True
        CheckBox2.Checked = False
        RadioButtonNom.Text = "Razon Social"
        RadioButtondniRuc.Text = "Rut"

        RadioButtonNom.Checked = True
        RadioButtondniRuc.Checked = False
    End Sub




    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        ' If documento = "BOLETA" Then

        If CheckBox2.Checked = True Then
            Button5.Enabled = True
            txtnom.Enabled = False
            txtdnruc.Enabled = False
        Else
            Button5.Enabled = False
            txtnom.Enabled = True
            txtdnruc.Enabled = True
            txtnom.Text = ""
            txtdnruc.Text = ""
            txtidcliente.Text = 0
            TabItem3.Visible = False
            ' TextBox2.Text = 0
            ' TextBox1.Focus()
            'End If
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If documento = "FACTURA" Then
            objentidade4.opcion = 2
            Dgcliente.DataSource = objnegocio4.MOSTRAR_CLIENTE_ACTIVO(objentidade4)
            Dgcliente.Columns(0).HeaderText = "ID"
            Dgcliente.Columns(0).Width = 40
            Dgcliente.Columns(1).Width = 100
            Dgcliente.Columns(2).Width = 150
            Dgcliente.Columns(3).Visible = False
        End If
        If documento = "BOLETA" Then
            objentidade4.opcion = 1
            Dgcliente.DataSource = objnegocio4.MOSTRAR_CLIENTE_ACTIVO(objentidade4)
            Dgcliente.Columns(0).HeaderText = "ID"
            Dgcliente.Columns(0).Width = 40
            Dgcliente.Columns(1).Width = 75
        End If
        TabControl1.SelectedTab = TabItem3
        TabItem3.Visible = True
    End Sub

    Private Sub Dgcliente_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgcliente.CellClick
        If (e.RowIndex = -1) Then Return
        If IsDBNull(Dgcliente.Rows(e.RowIndex).Cells(0).Value) Then

            Return
        Else
            txtidcliente.Text = Dgcliente.Rows(e.RowIndex).Cells(0).Value()
            txtdnruc.Text = Dgcliente.Rows(e.RowIndex).Cells(1).Value()
            txtnom.Text = Dgcliente.Rows(e.RowIndex).Cells(2).Value()
        End If
    End Sub

    Private Sub Dgcliente_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgcliente.CellContentClick

    End Sub

    Private Sub RadioButtonNom_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonNom.CheckedChanged
        buscar = 1
    End Sub

    Private Sub RadioButtondniRuc_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtondniRuc.CheckedChanged
        buscar = 2
    End Sub

    Private Sub TextBoxX1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbusquedaCliente.TextChanged
        If documento = "BOLETA" Then
            objentidade4.dni = txtbusquedaCliente.Text
            objentidade4.Nombre = txtbusquedaCliente.Text
            If buscar = 1 Then
                txtbusquedaCliente.MaxLength = 30
                objentidade4.opcion = 1
                Dgcliente.DataSource = objnegocio4.BUSCAR_CLIENTE_NATURAL_ACTIVO(objentidade4)
            End If
            If buscar = 2 Then
                txtbusquedaCliente.MaxLength = 8
                objentidade4.opcion = 2
                Dgcliente.DataSource = objnegocio4.BUSCAR_CLIENTE_NATURAL_ACTIVO(objentidade4)
            End If

        End If
        If documento = "FACTURA" Then
            objentidade4.ruc = txtbusquedaCliente.Text
            objentidade4.RazonSocial = txtbusquedaCliente.Text
            If buscar = 1 Then
                txtbusquedaCliente.MaxLength = 30
                objentidade4.opcion = 1
                Dgcliente.DataSource = objnegocio4.BUSCAR_CLIENTE_JURIDICO_ACTIVO(objentidade4)
            End If
            If buscar = 2 Then
                txtbusquedaCliente.MaxLength = 11
                objentidade4.opcion = 2
                Dgcliente.DataSource = objnegocio4.BUSCAR_CLIENTE_JURIDICO_ACTIVO(objentidade4)
            End If

        End If

    End Sub

    Private Sub dgplatos_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgplatos.CellDoubleClick
        Dim conta As Integer
        Dim validastock As Integer
        Dim cod, cod1, nombre, TIPO, TIPO1 As String
        Dim total, total1, precio As Double
        TIPO = "PL"
        If (e.RowIndex = -1) Then Return
        If IsDBNull(Dg_productos.Rows(e.RowIndex).Cells(0).Value) Then

            Return
        Else
            validastock = dgplatos.Rows(e.RowIndex).Cells(2).Value()
            codigo = dgplatos.Rows(e.RowIndex).Cells(0).Value()
            nombre = dgplatos.Rows(e.RowIndex).Cells(1).Value()
            precio = dgplatos.Rows(e.RowIndex).Cells(3).Value()
        End If


        If ListView1.Items.Count > 0 Then
            cod = codigo
            Dim z As Integer
            For z = 0 To ListView1.Items.Count - 1
                cod1 = ListView1.Items(z).SubItems(0).Text
                TIPO1 = ListView1.Items(z).SubItems(6).Text
                If cod = cod1 And TIPO1 = "PL" Then
                    conta = conta + 1
                End If
            Next

        End If


        If conta > 0 Then
            MsgBox("EL PRODUCTO YA EXISTE EN LA LISTA", MsgBoxStyle.Critical)
            codigo = 0
        Else

            If validastock >= 1 Then
                i = ListView1.Items.Count
                ListView1.Items.Add(codigo)
                ListView1.Items(i).SubItems.Add(nombre)
                ListView1.Items(i).SubItems.Add(1)
                ListView1.Items(i).SubItems.Add(precio)
                ListView1.Items(i).SubItems.Add(precio * 1)
                ListView1.Items(i).SubItems.Add("")
                ListView1.Items(i).SubItems.Add(TIPO)
                i = i + 1
                codigo = 0
                nombre = ""

                For z = 0 To ListView1.Items.Count - 1
                    total = ListView1.Items(z).SubItems(4).Text
                    total1 = total + total1
                    txtmonto.Text = total1
                    MONTOGLOBAL = txtmonto.Text
                Next
            Else
                MsgBox("CANTIDAD NO PERMITIDA EN EL STOCK", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub dgplatos_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgplatos.CellContentClick

    End Sub

    Private Sub ButttonModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButttonModificar.Click
        If TextBox1.Text.Trim = "" Or ListView1.Items.Count = 0 Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If v.MensajeModificar() = 6 Then
                llenarDatos()
                objentidade6.NumeroD = ""
                objentidade6.Numero = 1
                objnegocio6.MODIFICAR_COMANDA(objentidade6)

                Dim x As Integer
                For x = 0 To ListView1.Items.Count - 1
                    tipo = ListView1.Items(x).SubItems(6).Text
                    objentidade6.idcomanda = Me.TextBox1.Text
                    objentidade6.idproducto = ListView1.Items(x).SubItems(0).Text
                    objentidade6.idplato = ListView1.Items(x).SubItems(0).Text
                    objentidade6.cantidad = ListView1.Items(x).SubItems(2).Text
                    objentidade6.importe = ListView1.Items(x).SubItems(4).Text
                    objentidade6.notas = ListView1.Items(x).SubItems(5).Text
                    If tipo = "PR" Then
                        objnegocio6.MODIFICAR_DETALLE_COMANDA_PRODUCTOS(objentidade6)
                        objnegocio6.AGREGAR_DETALLE_COMANDA_PRODUCTO(objentidade6)
                    End If
                    If tipo = "PL" Then
                        objnegocio6.MODIFICAR_DETALLE_COMANDA_PLATOS(objentidade6)
                        objnegocio6.AGREGAR_DETALLE_COMANDA_PLATO(objentidade6)
                    End If
                Next
                i = 0
                'limpiar_textos()

                Cargar_Mesas_Ocupadas()
                Imprimr()
                'Close()
            End If
        End If



    End Sub

    Private Sub ButtonNuevo_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNuevo.Click
        Imprimr()
    End Sub

    Public Sub Imprimr()
        If ListView1.Items.Count = 0 Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If v.MensajeImprimir() = 6 Then
                CodigoImprimirComanda = TextBox1.Text
                MENU_PRINCIPAL.AbrirVentana_Reporte_Comanda()
            End If
        End If
    End Sub

    Public Sub ImprimerDocumentoVenta()
        If ListView1.Items.Count = 0 Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If v.MensajeImprimir() = 6 Then
                CodigoImprimirComanda = TextBox1.Text

                CodigoImprimirComanda = TextBox1.Text
                If documento = "BOLETA" Then
                    MENU_PRINCIPAL.AbrirVentana_Reporte_Boleta()
          
                End If
                If documento = "FACTURA" Then
                    ' codigoventa = CInt(TextBox10.Text)
                    ' My.Forms.Reporte_Venta_Facturavb.Show()
                End If

            End If
        End If
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As System.EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            ' codigoNuevaCantidad = 1
            My.Forms.WFrm_Cantidad_Notas.Show()

        End If
    End Sub
    Public Sub ActualizaMonto()
        Dim total, total1 As Double
        For z = 0 To ListView1.Items.Count - 1
            total = ListView1.Items(z).SubItems(4).Text
            total1 = total + total1
            txtmonto.Text = total1
            MONTOGLOBAL = txtmonto.Text
        Next
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ButtonX3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX3.Click
        ListView1.Items.Clear()
        Me.txtmonto.Text = ""
        i = 0
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        Dim total, total1 As Double
        Dim tipo As String


        If ButtonRegistrar.Enabled = True Then
            For o As Integer = ListView1.SelectedItems.Count - 1 To 0 Step -1
                ListView1.SelectedItems(o).Remove()
            Next
        End If
        If ButtonRegistrar.Enabled = False Then
            If v.MensajeEliminar() = 6 Then
                For o As Integer = ListView1.SelectedItems.Count - 1 To 0 Step -1
                    tipo = ListView1.SelectedItems(o).SubItems(6).Text
                    objentidade6.idcomanda = Me.TextBox1.Text
                    objentidade6.idproducto = ListView1.SelectedItems(o).SubItems(0).Text
                    objentidade6.idplato = ListView1.SelectedItems(o).SubItems(0).Text
                    If tipo = "PR" Then
                        objnegocio6.ELIMINAR_DETALLE_COMANDA_PRODUCTO(objentidade6)
                    End If
                    If tipo = "PL" Then
                        objnegocio6.ELIMINAR_DETALLE_COMANDA_PLATO(objentidade6)
                    End If
                Next
                For o As Integer = ListView1.SelectedItems.Count - 1 To 0 Step -1
                    ListView1.SelectedItems(o).Remove()
                Next
            End If
        End If

        For z = 0 To ListView1.Items.Count - 1
            total = ListView1.Items(z).SubItems(4).Text
            total1 = total + total1
            txtmonto.Text = total1
            MONTOGLOBAL = txtmonto.Text
        Next

        If ListView1.Items.Count = 0 Then
            txtmonto.Text = ""
            MONTOGLOBAL = 0
        Else
        End If
        i = i - 1
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If txtmonto.Text = "" Or txtmonto.Text = "0" Then
            CheckBox1.Checked = False
        Else
            txtdescuentos.Enabled = True
            Button9.Enabled = True
        End If

        If CheckBox1.Checked = True Then
            txtdescuentos.Enabled = True
            Button9.Enabled = True
        Else
            txtdescuentos.Enabled = False
            txtdescuentos.Text = "0.0"
            Button9.PerformClick()

            Button9.Enabled = False
        End If
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescuentos.KeyPress
        If e.KeyChar = "." Then
            e.Handled = False
            Exit Sub
        End If
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtdescuentos.TextChanged

    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click

        Dim totolmonto As Double
        totolmonto = MONTOGLOBAL - (CDbl(txtdescuentos.Text) * CDbl(MONTOGLOBAL))
        txtmonto.Text = totolmonto
    End Sub

    Private Sub ComboBoxEx2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxEx2.SelectedIndexChanged
    End Sub


    Public Sub ListarListview()
        objentidade6.idcomanda = Me.TextBox1.Text
        For Each listar In MostrarListviewComandaPlatos()
            Dim fila As New ListViewItem
            fila.Text = listar.idplato
            fila.SubItems.Add(listar.nombre)
            fila.SubItems.Add(listar.cantidad)
            fila.SubItems.Add(listar.precio)
            fila.SubItems.Add(listar.importe)
            fila.SubItems.Add(listar.notas)
            fila.SubItems.Add("PL")
            Me.ListView1.Items.Add(fila)
        Next

        For Each listar In MostrarListviewComandaProductos()
            Dim fila As New ListViewItem
            fila.Text = listar.idproducto
            fila.SubItems.Add(listar.nombre)
            fila.SubItems.Add(listar.cantidad)
            fila.SubItems.Add(listar.precio)
            fila.SubItems.Add(listar.importe)
            fila.SubItems.Add(listar.notas)
            fila.SubItems.Add("PR")
            Me.ListView1.Items.Add(fila)
        Next
    End Sub

    Private Sub Dg_productos_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_productos.CellContentClick

    End Sub

    Private Sub dgplatos_DataBindingComplete(sender As Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgplatos.DataBindingComplete
        Dim i As Integer
        For i = 0 To dgplatos.Rows.Count - 2

            If dgplatos.Item(2, i).Value() = 0 Then
                dgplatos.Rows(i).DefaultCellStyle.BackColor = Color.Red
                dgplatos.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub Dg_productos_DataBindingComplete(sender As Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles Dg_productos.DataBindingComplete
        Dim i As Integer
        For i = 0 To Dg_productos.Rows.Count - 2

            If Dg_productos.Item(3, i).Value() = 0 Then
                Dg_productos.Rows(i).DefaultCellStyle.BackColor = Color.Red
                Dg_productos.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub TextBoxX2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX2.KeyDown
        Select Case e.KeyData

            Case Keys.Enter
                objentidade6.OpcionCapturar = 1
                objentidade6.ValorIngresado = TextBoxX2.Text
                objnegocio6.FAC_CAPTURAS(objentidade6)
                If objentidade6.ValorSalida = "" Then
                    Label11.Text = ""
                    TextBoxX2.Text = ""
                    txtidmoz.Text = 0
                Else
                    Label11.Text = objentidade6.ValorSalida
                    objentidade6.OpcionCapturar = 2
                    objentidade6.ValorIngresado = TextBoxX2.Text
                    objnegocio6.FAC_CAPTURAS(objentidade6)
                    txtidmoz.Text = objentidade6.ValorSalida
                End If
        End Select

    End Sub




    Private Sub TextBoxX2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxX2.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        ' My.Forms.WFrm_BuscarProveedor.MdiParent = Me

        My.Forms.WFrm_BuscarProveedor.Show()
    End Sub
End Class