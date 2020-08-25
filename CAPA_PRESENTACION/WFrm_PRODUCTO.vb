Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text
Public Class WFrm_PRODUCTO
    Inherits DevComponents.DotNetBar.Office2007Form
    Public objnegocio As New CAPA_NEGOCIO.CpN_Cls_PRODUCTO
    Public objentidade As New CAPA_ENTIDAD.CpE_Cls_PRODUCTO
    Public objnegocio1 As New CAPA_NEGOCIO.CpN_Cls_TIPO_PRODUCTO
    Public objentidade1 As New CAPA_ENTIDAD.CpE_Cls_TIPO_PRODUCTO
    Public v As New CAPA_NEGOCIO.CpN_Cls_VALIDACIONES
    Public estado As Integer
    Public buscar As Integer
    Public Sub limpiar_textos()
        Me.txtnom.Text = ""
        Me.txtdes.Text = ""
        Me.txtprecio.Text = ""
        Me.ComboBoxEx2.SelectedIndex = -1
        Me.txtcanmedi.Text = ""
        Me.txtstock.Text = ""
        Me.txtbusqueda.Text = ""
        Me.TextBox1.Text = ""
        Me.RadioButtonActivo.Checked = True
        Me.RadioButtonInactivo.Enabled = False
        ButtonRegistrar.Enabled = True
        Me.txtnom.Enabled = True
        Me.ButttonModificar.Enabled = False
        Me.ComboBoxEx1.SelectedIndex = -1
        Me.RadioButtonNomComp.Checked = True
    End Sub
    Public Sub llenarDatos()
        objentidade.Nombre = Me.txtnom.Text
        objentidade.idtipo = Me.TextBox2.Text
        objentidade.descripcion = Me.txtdes.Text
        objentidade.precio = Me.txtprecio.Text
        objentidade.medida = Me.ComboBoxEx3.Text
        objentidade.cantiunidad = Me.txtcanmedi.Text
        objentidade.stock = Me.txtstock.Text
        objentidade.Estado = estado
    End Sub
    Private Sub WFrm_PRODUCTO_PLATO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dg_Proveedores.DataSource = objnegocio.MOSTRAR_PRODCUTO(objentidade)
        Dg_Proveedores.Columns(0).HeaderText = "ID"
        Dg_Proveedores.Columns(0).Width = 40
        Dg_Proveedores.Columns(1).Width = 150
        Dg_Proveedores.Columns(2).HeaderText = "Tipo"
        Dg_Proveedores.Columns(2).Width = 40
        Dg_Proveedores.Columns(3).Width = 80
        Dg_Proveedores.Columns(4).Width = 70
        Dg_Proveedores.Columns(5).HeaderText = "Cant-Unidad"
        Dg_Proveedores.Columns(5).Width = 80
        Dg_Proveedores.Columns(6).Width = 70
        Dg_Proveedores.Columns(7).Width = 55

        Dg_Proveedores.Columns(0).Visible = False

        Me.ComboBoxEx1.DataSource = objnegocio1.MOSTRAR_TIPO_PRODCUTO_ACTIVO(objentidade1)
        Me.ComboBoxEx1.DisplayMember = "Nombre"
        Me.ComboBoxEx1.ValueMember = "IdTipoProducto"
        Me.ComboBoxEx1.SelectedIndex = -1

        Me.ComboBoxEx2.DataSource = objnegocio1.MOSTRAR_TIPO_PRODCUTO_ACTIVO(objentidade1)
        Me.ComboBoxEx2.DisplayMember = "Nombre"
        Me.ComboBoxEx2.ValueMember = "IdTipoProducto"
        Me.ComboBoxEx2.SelectedIndex = -1

        '  ResaltarStockBajo()
       
    End Sub
    Public Sub ResaltarStockBajo()
        Dim i As Integer
        For i = 0 To Dg_Proveedores.Rows.Count - 1

            If Dg_Proveedores.Item(6, i).Value() = 0 Then
                Dg_Proveedores.Rows(i).DefaultCellStyle.BackColor = Color.Red
                Dg_Proveedores.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub
    Private Sub ButtonNuevo_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNuevo.Click
        limpiar_textos()
    End Sub

    Private Sub txtprecio_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress
        If e.KeyChar = "," Then
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

    Private Sub txtstock_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtstock.KeyPress
        e.Handled = v.validaNumeros(e)
    End Sub
    Private Sub txtcanmedi_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcanmedi.KeyPress
        e.Handled = v.validaNumeros(e)
    End Sub

    Private Sub txtcanmedi_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtcanmedi.TextChanged

    End Sub

    Private Sub ButtonRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRegistrar.Click
        If txtnom.Text.Trim = "" Or TextBox2.Text.Trim = "" Or txtprecio.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If v.MensajeGuardar() = 6 Then
                llenarDatos()
                objnegocio.REGISTRAR_PRODUCTO(objentidade)
                Dg_Proveedores.DataSource = objnegocio.MOSTRAR_PRODCUTO(objentidade)
                limpiar_textos()
            End If
        End If
    End Sub
    Private Sub ComboBoxEx1_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles ComboBoxEx1.SelectionChangeCommitted
        Dim x As String
        x = Me.ComboBoxEx1.SelectedValue
        TextBox2.Text = x
    End Sub

    Private Sub RadioButtonActivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonActivo.CheckedChanged
        estado = 1
    End Sub

    Private Sub RadioButtonInactivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonInactivo.CheckedChanged
        estado = 0
    End Sub

    Private Sub Dg_Proveedores_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellClick
        ButtonRegistrar.Enabled = False
        RadioButtonInactivo.Enabled = True
        Me.ButttonModificar.Enabled = True
        If (e.RowIndex = -1) Then Return
        If IsDBNull(Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value) Then

            Return
        Else
            TextBox1.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value()
            txtnom.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(1).Value()
            estado = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(7).Value()
            TextBox2.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(2).Value()
            txtprecio.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(3).Value()
            Me.ComboBoxEx3.Text = Convert.ToString(Me.Dg_Proveedores.Rows(e.RowIndex).Cells(4).Value())
            txtcanmedi.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(5).Value()
            txtstock.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(6).Value()
            txtdes.Text = Convert.ToString(Me.Dg_Proveedores.Rows(e.RowIndex).Cells(8).Value())
            Dim x As String
            x = Me.TextBox2.Text
            ComboBoxEx1.SelectedValue = x
            If estado = 1 Then
                RadioButtonActivo.Checked = True
                '  habilitarTextbox()
            End If
            If estado = 0 Then
                RadioButtonInactivo.Checked = True
                '  bloquearTextbox()
            End If
        End If
    End Sub


    Private Sub ButttonModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButttonModificar.Click
        If txtnom.Text.Trim = "" Or TextBox2.Text.Trim = "" Or txtprecio.Text.Trim = "" Or txtnom.Text.Trim = "" Or TextBox1.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If v.MensajeModificar() = 6 Then
                llenarDatos()
                objentidade.idproducto = TextBox1.Text
                objnegocio.MODIFICAR_PRODUCTO(objentidade)
                Dg_Proveedores.DataSource = objnegocio.MOSTRAR_PRODCUTO(objentidade)
                limpiar_textos()
            End If
        End If
    End Sub

    Private Sub RadioButtonRuc_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonRuc.CheckedChanged
        buscar = 2
        If RadioButtonRuc.Checked = True Then
            txtbusqueda.Text = ""
            Dg_Proveedores.DataSource = objnegocio.MOSTRAR_PRODCUTO(objentidade)
            ComboBoxEx2.Enabled = True
            txtbusqueda.Enabled = False
        End If
    End Sub

    Private Sub RadioButtonNomComp_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonNomComp.CheckedChanged
        buscar = 1
        If RadioButtonNomComp.Checked = True Then
            Dg_Proveedores.DataSource = objnegocio.MOSTRAR_PRODCUTO(objentidade)
            ComboBoxEx2.Enabled = False
            txtbusqueda.Enabled = True
            Me.ComboBoxEx2.SelectedIndex = -1
        End If

    End Sub

    Private Sub txtbusqueda_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbusqueda.TextChanged
        objentidade.Nombre = txtbusqueda.Text
        If buscar = 1 Then
            txtbusqueda.MaxLength = 30
            objentidade.opcion = 1
            Dg_Proveedores.DataSource = objnegocio.BUSCAR_PRODUCTO(objentidade)
        End If
    End Sub

    Private Sub ComboBoxEx2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxEx2.SelectedIndexChanged
        objentidade.Nombre = ComboBoxEx2.Text
        If buscar = 2 Then
            objentidade.opcion = 2
            Dg_Proveedores.DataSource = objnegocio.BUSCAR_PRODUCTO(objentidade)
        End If
    End Sub

    Private Sub txtnom_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtnom.KeyPress
        'Si es letra
        If Char.IsLetter(e.KeyChar) Then
            'que se digite
            e.Handled = False
            'Para habilitar el enter, backspace...
        ElseIf Char.IsControl(e.KeyChar) Then
            'que se digite
            e.Handled = False
            'Si es digito
        ElseIf Char.IsDigit(e.KeyChar) Then
            'que se digite
            e.Handled = False
            'Solo numeros
        ElseIf Char.IsDigit(e.KeyChar) Then
            'que se digite
            e.Handled = False
            'Si es separador(barra espaciadora)
        ElseIf Char.IsSeparator(e.KeyChar) Then
            'que se digite
            e.Handled = False
        Else
            'que se bloquee
            e.Handled = True
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

    Private Sub txtmedida_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub txtdes_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtdes.TextChanged
        If txtdes.Text.StartsWith(" ") Then
            txtdes.Text = txtdes.Text.Trim
        ElseIf txtdes.Text.EndsWith(" ") Then
            txtdes.Text = txtdes.Text.Trim + " "
            txtdes.SelectionStart = txtdes.Text.Length
        End If
    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxEx1.SelectedIndexChanged

    End Sub

    Private Sub Dg_Proveedores_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellContentClick

    End Sub

    Private Sub Dg_Proveedores_DataBindingComplete(sender As Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles Dg_Proveedores.DataBindingComplete
        Dim i As Integer
        For i = 0 To Dg_Proveedores.Rows.Count - 2

            If Dg_Proveedores.Item(6, i).Value() = 0 Then
                Dg_Proveedores.Rows(i).DefaultCellStyle.BackColor = Color.Red
                Dg_Proveedores.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub txtprecio_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtprecio.TextChanged

    End Sub
End Class