Public Class WFrm_ABASTECER
    Inherits DevComponents.DotNetBar.Office2007Form
    Public objnegocio As New CAPA_NEGOCIO.CpN_Cls_PRODUCTO
    Public objentidade As New CAPA_ENTIDAD.CpE_Cls_PRODUCTO
    Public objnegocio1 As New CAPA_NEGOCIO.CpN_Cls_TIPO_PRODUCTO
    Public objentidade1 As New CAPA_ENTIDAD.CpE_Cls_TIPO_PRODUCTO
    Public objnegocio2 As New CAPA_NEGOCIO.CpN_Cls_ABASTECER
    Public objentidade2 As New CAPA_ENTIDAD.CpE_Cls_ABASTECER
    Public v As New CAPA_NEGOCIO.CpN_Cls_VALIDACIONES
    Public buscar, i, codigo, estado As Integer
    Private Sub WFrm_ABASTECER_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dg_Proveedores.DataSource = objnegocio.MOSTRAR_PRODUCTO_ESTADO(objentidade)
        Dg_Proveedores.Columns(0).Width = 25
        Dg_Proveedores.Columns(1).Width = 80
        ' Dg_Proveedores.Columns(0).Visible = False
        Dg_Proveedores.Columns(2).Visible = False
        Dg_Proveedores.Columns(3).Visible = False
        Dg_Proveedores.Columns(4).Visible = False
        Dg_Proveedores.Columns(5).Visible = False

        Me.ComboBoxEx2.DataSource = objnegocio1.MOSTRAR_TIPO_PRODCUTO_ACTIVO(objentidade1)
        Me.ComboBoxEx2.DisplayMember = "Nombre"
        Me.ComboBoxEx2.ValueMember = "IdTipoProducto"
        Me.ComboBoxEx2.SelectedIndex = -1

    End Sub

    
    Public Sub limpiar_textos()
        Me.RadioButtonActivo.Checked = True
        Me.txtbusqueda.Text = ""
        Me.TextBox1.Text = ""
        Me.RadioButtonInactivo.Enabled = False
        ButtonRegistrar.Enabled = True
        Me.ButttonModificar.Enabled = False
        Me.ComboBoxEx2.SelectedIndex = -1
        Me.ButtonX1.Enabled = True
        Me.ButtonX3.Enabled = True
        ListView1.Items.Clear()
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBoxX1.Text = ""
        Me.TextBoxX3.Text = ""
        i = 0
    End Sub

    Private Sub txtbusqueda_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbusqueda.TextChanged
        objentidade.Nombre = txtbusqueda.Text
        If buscar = 1 Then
            txtbusqueda.MaxLength = 30
            objentidade.opcion = 1
            Dg_Proveedores.DataSource = objnegocio.BUSCAR_PRODUCTOS_ACTIVOS(objentidade)
        End If
    End Sub

    Private Sub RadioButtonNomComp_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonNomComp.CheckedChanged
        buscar = 1

        If RadioButtonNomComp.Checked = True Then
            Dg_Proveedores.DataSource = objnegocio.MOSTRAR_PRODUCTO_ESTADO(objentidade)
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
            Dg_Proveedores.DataSource = objnegocio.MOSTRAR_PRODUCTO_ESTADO(objentidade)
            ComboBoxEx2.Enabled = True
            txtbusqueda.Enabled = False
        End If
    End Sub

    Private Sub ComboBoxEx2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxEx2.SelectedIndexChanged
        objentidade.Nombre = ComboBoxEx2.Text
        If buscar = 2 Then
            objentidade.opcion = 2
            Dg_Proveedores.DataSource = objnegocio.BUSCAR_PRODUCTOS_ACTIVOS(objentidade)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        opcionbusqueda = 1
        MENU_PRINCIPAL.AbrirVentana_Buscar_Proveedor()

    End Sub

    Private Sub Dg_Proveedores_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellClick
        Dim conta As Integer
        Dim cod, cod1, nombre, TIPO As String
        If (e.RowIndex = -1) Then Return
        If IsDBNull(Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value) Then

            Return
        Else
            codigo = Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value()
            nombre = Dg_Proveedores.Rows(e.RowIndex).Cells(1).Value()
            TIPO = Dg_Proveedores.Rows(e.RowIndex).Cells(2).Value()
        End If


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
        Else

            i = ListView1.Items.Count
            ListView1.Items.Add(codigo)
            ListView1.Items(i).SubItems.Add(nombre)
            ListView1.Items(i).SubItems.Add(TIPO)
            i = i + 1
            codigo = 0
            nombre = ""
        End If
    End Sub

    Private Sub Dg_Proveedores_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellContentClick

    End Sub

    Private Sub ButtonNuevo_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNuevo.Click
        limpiar_textos()
    End Sub

    Private Sub ButtonRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRegistrar.Click
        contar = ListView1.Items.Count
        If Me.TextBox2.Text = "" Or contar = 0 Then
            MsgBox("DEBES INGRESAR LOS DATOS", MsgBoxStyle.Exclamation)
        Else
       

                If v.MensajeGuardar() = 6 Then

                objentidade2.idproveedor = Me.TextBox2.Text
                objentidade2.Estado = estado
                objnegocio2.REGISTRAR_ABASTECER(objentidade2)
                objnegocio2.CAPTURA_CODIGO_ABASTECER(objentidade2)
                TextBox1.Text = objentidade2.idAbastece
                    Dim z As Integer
                    For z = 0 To ListView1.Items.Count - 1
                    objentidade2.idProducto = ListView1.Items(z).SubItems(0).Text
                    objentidade2.idAbastece = CInt(TextBox1.Text)
                    objnegocio2.REGISTRAR_DETALLE_ABASTECER(objentidade2)
                    Next
                    CodigoMenuDia = TextBox1.Text
                'My.Forms.WFrm_MENU_DIA_LISTADO.Show()
                ' My.Forms.MENU_PRINCIPAL.AbrirVentana_Reporte_MenuDia()
                '  Me.Close()
                ListView1.Items.Clear()
                i = 0
                limpiar_textos()
                End If
            End If
    End Sub

    Private Sub RadioButtonActivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonActivo.CheckedChanged
        estado = 1
    End Sub

    Private Sub RadioButtonInactivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonInactivo.CheckedChanged
        estado = 0
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
End Class