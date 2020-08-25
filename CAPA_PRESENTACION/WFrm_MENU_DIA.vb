Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text
Imports System.Data.SqlClient
Public Class WFrm_MENU_DIA
    Inherits DevComponents.DotNetBar.Office2007Form
    Public objnegocio As New CAPA_NEGOCIO.CpN_Cls_PLATO
    Public objentidade As New CAPA_ENTIDAD.CpE_Cls_PLATO
    Public objnegocio2 As New CAPA_NEGOCIO.CpN_Cls_CATEGORIA_PLATO
    Public objentidade2 As New CAPA_ENTIDAD.CpE_Cls_CATEGORIA_PLATO
    Public objnegocio1 As New CAPA_NEGOCIO.CpN_Cls_MENU_DIA
    Public objentidade1 As New CAPA_ENTIDAD.CpE_Cls_MENU_DIA
    Public v As New CAPA_NEGOCIO.CpN_Cls_VALIDACIONES
    Public estado As String
    Public nombre As String
    Public codigo, i, buscar, cantidadActivo As Integer
    Public precio As Double
    Public Sub limpiar_textos()
        Me.txtnom.Text = ""
        Me.txtdes.Text = ""
        Me.RadioButtonActivo.Checked = True
        Me.txtbusqueda.Text = ""
        Me.TextBox1.Text = ""
        Me.RadioButtonInactivo.Enabled = True
        Me.RadioButtonPendiiente.Enabled = True
        ButtonRegistrar.Enabled = True
        Me.ButttonModificar.Enabled = False
        Me.ComboBoxEx2.SelectedIndex = -1
        Me.ButtonX1.Enabled = True
        Me.ButtonX3.Enabled = True
        ListView1.Items.Clear()
        i = 0


    End Sub
    Private Sub WFrm_MENU_DIA_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dg_Proveedores.DataSource = objnegocio.MOSTRAR_PLATO_ESTADO(objentidade)
        Dg_Proveedores.Columns(0).Width = 22
        Dg_Proveedores.Columns(1).Width = 120
        ' Dg_Proveedores.Columns(0).Visible = False
        Dg_Proveedores.Columns(2).Visible = False
        Dg_Proveedores.Columns(3).Visible = False
        ' Dg_Proveedores.Columns(4).Visible = False

        Me.ComboBoxEx2.DataSource = objnegocio2.MOSTRAR_CATEGORIA_PLATO_ACTIVO(objentidade2)
        Me.ComboBoxEx2.DisplayMember = "Nombre"
        Me.ComboBoxEx2.ValueMember = "IdCategoria"
        Me.ComboBoxEx2.SelectedIndex = -1

    End Sub

    Private Sub Dg_Proveedores_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellDoubleClick
        If (e.RowIndex = -1) Then Return
        If IsDBNull(Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value) Then

            Return
        Else
            codigo = Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value()
            nombre = Dg_Proveedores.Rows(e.RowIndex).Cells(1).Value()
            precio = Dg_Proveedores.Rows(e.RowIndex).Cells(4).Value()
            codigoNuevaCantidad = 2
            My.Forms.WFrm_Cantidad.Show()
        End If
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
                ListView1.Items(i).SubItems.Add(precio)
                ListView1.Items(i).SubItems.Add(cantidadplato)
                i = i + 1
                codigo = 0
                nombre = ""
                'TextBox7.Text = ""
            End If

        End If
    End Sub

    Private Sub ButtonRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRegistrar.Click
        contar = ListView1.Items.Count
        If Me.txtnom.Text = "" Or contar = 0 Then
            MsgBox("DEBES INGRESAR LOS DATOS", MsgBoxStyle.Exclamation)
        Else
            objnegocio1.CAPTURA_CANTIDAD_ESTADO_ACTIVADO(objentidade1)
            cantidadActivo = objentidade1.CantActivo
            If cantidadActivo > 0 And estado = "ACTIVADO" Then
                MsgBox("YA EXISTE UN MENU ACTIVADO EN LA BASE DE DATOS", MsgBoxStyle.Critical, )
            Else

                If v.MensajeGuardar() = 6 Then

                    objentidade1.Nombre = Me.txtnom.Text
                    objentidade1.descripcion = Me.txtdes.Text
                    objentidade1.Estado = estado
                    objnegocio1.REGISTRAR_MENU_DIA(objentidade1)
                    objnegocio1.CAPTURA_CODIGO_MENU_DIA(objentidade1)
                    TextBox1.Text = objentidade1.idMenu
                    Dim z As Integer
                    For z = 0 To ListView1.Items.Count - 1
                        objentidade1.idPlato = ListView1.Items(z).SubItems(0).Text
                        objentidade1.cantidad = ListView1.Items(z).SubItems(3).Text
                        objentidade1.idMenu = CInt(TextBox1.Text)
                        objnegocio1.REGISTRAR_DETALLE_MENU(objentidade1)
                    Next
                    CodigoMenuDia = TextBox1.Text
                    My.Forms.MENU_PRINCIPAL.AbrirVentanaListadoMenuDia()
                    My.Forms.MENU_PRINCIPAL.AbrirVentana_Reporte_MenuDia()
                    Me.Close()
                    ListView1.Items.Clear()
                    i = 0
                    limpiar_textos()
                End If
            End If
        End If

    End Sub

    Private Sub RadioButtonActivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonActivo.CheckedChanged
        estado = "ACTIVADO"
    End Sub

    Private Sub RadioButtonInactivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonInactivo.CheckedChanged
        estado = "INACTIVO"
    End Sub

    Private Sub ButtonNuevo_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNuevo.Click
        limpiar_textos()
    End Sub

    Private Sub txtbusqueda_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbusqueda.TextChanged
        objentidade.Nombre = txtbusqueda.Text
        If buscar = 1 Then
            txtbusqueda.MaxLength = 30
            objentidade.opcion = 1
            Dg_Proveedores.DataSource = objnegocio.BUSCAR_PLATO_ACTIVOS(objentidade)
        End If

        If txtbusqueda.Text.StartsWith(" ") Then
            txtbusqueda.Text = txtbusqueda.Text.Trim
        ElseIf txtbusqueda.Text.EndsWith(" ") Then
            txtbusqueda.Text = txtbusqueda.Text.Trim + " "
            txtbusqueda.SelectionStart = txtbusqueda.Text.Length
        End If
    End Sub

    Private Sub RadioButtonNomComp_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonNomComp.CheckedChanged
        buscar = 1
        If RadioButtonNomComp.Checked = True Then
            Dg_Proveedores.DataSource = objnegocio.MOSTRAR_PLATO_ESTADO(objentidade)
            ComboBoxEx2.Enabled = False
            txtbusqueda.Enabled = True
            Me.ComboBoxEx2.SelectedIndex = -1
            txtbusqueda.Focus()

        End If

    End Sub

    Private Sub RadioButtonRuc_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonRuc.CheckedChanged
        buscar = 2
        If RadioButtonRuc.Checked = True Then
            txtbusqueda.Text = ""
            Dg_Proveedores.DataSource = objnegocio.MOSTRAR_PLATO_ESTADO(objentidade)
            ComboBoxEx2.Enabled = True
            txtbusqueda.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxEx2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxEx2.SelectedIndexChanged
        objentidade.Nombre = ComboBoxEx2.Text
        If buscar = 2 Then
            objentidade.opcion = 2
            Dg_Proveedores.DataSource = objnegocio.BUSCAR_PLATO_ACTIVOS(objentidade)
        End If
    End Sub

    Private Sub txtnom_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnom.TextChanged
        If txtnom.Text.StartsWith(" ") Then
            txtnom.Text = txtnom.Text.Trim
        ElseIf txtnom.Text.EndsWith(" ") Then
            txtnom.Text = txtnom.Text.Trim + " "
            txtnom.SelectionStart = txtnom.Text.Length
        End If
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As System.EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            codigoNuevaCantidad = 1
            My.Forms.WFrm_Cantidad.Show()
        End If
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
    Public Sub ListarListview()
        objentidade1.idMenu = Me.TextBox1.Text
        For Each listar In MostrarListview()
            Dim fila As New ListViewItem
            fila.Text = listar.idPlato
            fila.SubItems.Add(listar.Nombre)
            fila.SubItems.Add(listar.precio)
            fila.SubItems.Add(listar.cantidad)
            Me.ListView1.Items.Add(fila)
        Next
    End Sub

    Private Sub ButttonModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButttonModificar.Click


        If txtnom.Text.Trim = "" Or TextBox1.Text.Trim = "" Or ListView1.Items.Count = 0 Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If v.MensajeModificar() = 6 Then
                objentidade1.idMenu = Me.TextBox1.Text
                objentidade1.Nombre = Me.txtnom.Text
                objentidade1.descripcion = Me.txtdes.Text
                objentidade1.Estado = estado
                objnegocio1.MODIFICAR_MENU(objentidade1)
                WFrm_MENU_DIA_LISTADO.Dg_Proveedores.DataSource = objnegocio1.MOSTRAR_MENU_DIA(objentidade1)

                Dim x As Integer
                For x = 0 To ListView1.Items.Count - 1
                    objentidade1.idMenu = Me.TextBox1.Text
                    objentidade1.idPlato = ListView1.Items(x).SubItems(0).Text
                    objentidade1.cantidad = ListView1.Items(x).SubItems(3).Text
                    objnegocio1.MODIFICAR_DETALLE_MENU(objentidade1)
                Next
                My.Forms.MENU_PRINCIPAL.AbrirVentanaListadoMenuDia()
                My.Forms.MENU_PRINCIPAL.AbrirVentana_Reporte_MenuDia()
                limpiar_textos()
                Close()
            End If
        End If



    End Sub

    Function MostrarListview() As List(Of CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim dapprov As New SqlDataAdapter
        Dim c As New CAPA_ENTIDAD.Cls_Conexion
        c.conectar()
        Try
            Dim comando As New SqlCommand
            Dim lector As SqlDataReader
            Dim entidadmenu As New List(Of CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
            Dim objentidadmenu As CAPA_ENTIDAD.CpE_Cls_MENU_DIA
            dapprov.SelectCommand = c.cn.CreateCommand
            dapprov.SelectCommand.CommandText = "PA_ListarMenuListview"
            dapprov.SelectCommand.CommandType = CommandType.StoredProcedure
            dapprov.SelectCommand.Parameters.AddWithValue("@idmenu", Me.TextBox1.Text)
            dapprov.SelectCommand.ExecuteNonQuery()
            lector = dapprov.SelectCommand.ExecuteReader
            If lector.HasRows = True Then
                While lector.Read
                    objentidadmenu = New CAPA_ENTIDAD.CpE_Cls_MENU_DIA
                    objentidadmenu.idPlato = lector.Item(0)
                    objentidadmenu.Nombre = lector.Item(1)
                    objentidadmenu.precio = lector.Item(2)
                    objentidadmenu.cantidad = lector.Item(3)
                    entidadmenu.Add(objentidadmenu)
                End While
            End If
            Return entidadmenu
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            c.desconectar()
        End Try
    End Function

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonPendiiente.CheckedChanged
        estado = "PENDIENTE"
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Dg_Proveedores_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellContentClick

    End Sub
End Class