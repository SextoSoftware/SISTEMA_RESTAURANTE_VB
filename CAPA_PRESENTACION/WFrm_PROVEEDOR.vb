Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text

Public Class WFrm_PROVEEDOR
    Public objnegocio As New CAPA_NEGOCIO.CpN_Cls_PROVEEDOR
    Public objentidade As New CAPA_ENTIDAD.CpE_Cls_PROVEEDOR
    Public v As New CAPA_NEGOCIO.CpN_Cls_VALIDACIONES
    Public estado As Integer
    Public buscar As Integer
    Public Sub limpiar_textos()
        Me.txtnomcomp.Text = ""
        Me.txtnomcontac.Text = ""
        Me.txtruc.Text = ""
        Me.txttelefono.Text = ""
        Me.txtemail.Text = ""
        Me.txtdire.Text = ""
        Me.txtbusqueda.Text = ""
        Me.RadioButtonActivo.Checked = True
        Me.RadioButtonInactivo.Enabled = False
        ButtonRegistrar.Enabled = True
         Me.ButttonModificar.Enabled = False
    End Sub
    Public Sub llenarDatos()
        objentidade.NombreCompañia = Me.txtnomcomp.Text
        objentidade.NombreContacto = Me.txtnomcontac.Text
        objentidade.ruc = Me.txtruc.Text
        objentidade.telefono = Me.txttelefono.Text
        objentidade.direccion = Me.txtdire.Text
        objentidade.Email = Me.txtemail.Text
        objentidade.Estado = estado
    End Sub

    Private Sub WFrm_PROVEEDOR_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dg_Proveedores.DataSource = objnegocio.MOSTRAR_PROVEEDORES(objentidade)
        Dg_Proveedores.Columns(0).HeaderText = "ID"
        Dg_Proveedores.Columns(0).Width = 40
        Dg_Proveedores.Columns(1).Width = 140
        Dg_Proveedores.Columns(2).Width = 140
        Dg_Proveedores.Columns(3).Width = 80
        Dg_Proveedores.Columns(4).Width = 70
        Dg_Proveedores.Columns(7).Width = 50
        Dg_Proveedores.Columns(0).Visible = False

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
            txtnomcomp.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(1).Value()
            txtnomcontac.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(2).Value()
            txtruc.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(3).Value()
            txttelefono.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(4).Value()
            txtdire.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(5).Value()
            txtemail.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(6).Value()
            estado = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(7).Value()
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

    Private Sub buttonX11_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRegistrar.Click
        If txtnomcomp.Text.Trim = "" Or txtnomcontac.Text.Trim = "" Or txtruc.Text.Trim = "" Or txttelefono.Text.Trim = "" Or txtdire.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If ValidarRuc() And ValidarTelefono() And ValidarNombreApellido() And ValidarMinimoLetras() And ValidarEmail() Then
                If v.MensajeGuardar() = 6 Then
                    llenarDatos()
                    objnegocio.REGISTRAR_PROVEEDOR(objentidade)
                    Dg_Proveedores.DataSource = objnegocio.MOSTRAR_PROVEEDORES(objentidade)
                    limpiar_textos()
                End If
            End If
        End If
    End Sub

    Private Sub TextBoxX3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtruc.KeyPress
        e.Handled = v.validaNumeros(e)
    End Sub

    Private Sub TextBoxX2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtnomcontac.KeyPress
        e.Handled = v.validaletras(e)
    End Sub
    Private Sub TextBoxX2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnomcontac.TextChanged
        If txtnomcontac.Text.StartsWith(" ") Then
            txtnomcontac.Text = txtnomcontac.Text.Trim
        ElseIf txtnomcontac.Text.EndsWith(" ") Then
            txtnomcontac.Text = txtnomcontac.Text.Trim + " "
            txtnomcontac.SelectionStart = txtnomcontac.Text.Length
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNuevo.Click
        limpiar_textos()
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButttonModificar.Click
        If txtnomcomp.Text.Trim = "" Or txtnomcontac.Text.Trim = "" Or txtruc.Text.Trim = "" Or txttelefono.Text.Trim = "" Or txtdire.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If ValidarRuc() And ValidarTelefono() And ValidarNombreApellido() And ValidarMinimoLetras() And ValidarEmail() Then

                If v.MensajeModificar() = 6 Then
                    llenarDatos()
                    objentidade.idproveedor = TextBox1.Text
                    objnegocio.MODIFICAR_PROVEEDOR(objentidade)
                    Dg_Proveedores.DataSource = objnegocio.MOSTRAR_PROVEEDORES(objentidade)
                    limpiar_textos()
                End If
            End If
        End If




    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonActivo.CheckedChanged
        estado = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonInactivo.CheckedChanged
        estado = 0
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonNomComp.CheckedChanged
        buscar = 1
        txtbusqueda.Text = ""
        txtbusqueda.Focus()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonRuc.CheckedChanged
        buscar = 2
        txtbusqueda.Text = ""
        txtbusqueda.Focus()
    End Sub

    Private Sub TextBoxX7_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtbusqueda.KeyPress
        If buscar = 2 Then
            e.Handled = v.validaNumeros(e)
        End If
    End Sub

    Private Sub TextBoxX7_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbusqueda.TextChanged
        objentidade.ruc = txtbusqueda.Text
        objentidade.NombreCompañia = txtbusqueda.Text
        If buscar = 1 Then
            txtbusqueda.MaxLength = 30
            objentidade.opcion = 1
            Dg_Proveedores.DataSource = objnegocio.BUSCAR_PROVEEDOR(objentidade)
        End If
        If buscar = 2 Then
            txtbusqueda.MaxLength = 11
            objentidade.opcion = 2
            Dg_Proveedores.DataSource = objnegocio.BUSCAR_PROVEEDOR(objentidade)
        End If
    End Sub
    Private Sub TextBoxX1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnomcomp.TextChanged
        If txtnomcomp.Text.StartsWith(" ") Then
            txtnomcomp.Text = txtnomcomp.Text.Trim
        ElseIf txtnomcomp.Text.EndsWith(" ") Then
            txtnomcomp.Text = txtnomcomp.Text.Trim + " "
            txtnomcomp.SelectionStart = txtnomcomp.Text.Length
        End If
    End Sub
    Public Function ValidarRuc() As Boolean
        Dim pasa As Boolean
        If Len(txtruc.Text) < 10 Then
            MsgBox("RUT DEBE SER DE 10 DIGITOS DEL 0-9", MsgBoxStyle.Critical, "DATO INCORRECTO")
            txtruc.Focus()
            pasa = False
        Else
            pasa = True
        End If
        Return pasa
    End Function
    Public Function ValidarTelefono() As Boolean
        Dim pasa As Boolean
        If Len(txttelefono.Text) < 8 Then
            MsgBox("EL TELEFONO DEBE SER DE 8 DIGITOS DEL 0-9", MsgBoxStyle.Critical, "DATO INCORRECTO")
            txttelefono.Focus()
            pasa = False
        Else
            pasa = True
        End If
        Return pasa
    End Function

    Public Function ValidarNombreApellido() As Boolean
        Dim pasa As Boolean
        Dim partes() As String = txtnomcontac.Text.Trim.Split(" "c)
        If partes.Length > 3 Or partes.Length = 1 Then
            MsgBox("DEBES INGRESAR NOMBRE Y APELLIDO", MsgBoxStyle.Critical, "DATO INCORRECTO")
            txtnomcontac.Focus()
            pasa = False
        Else
            pasa = True
        End If
        Return pasa
    End Function

    Private Sub TextBoxX5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtemail.TextChanged
        If txtemail.Text.StartsWith(" ") Then
            txtemail.Text = txtemail.Text.Trim
        ElseIf txtemail.Text.EndsWith(" ") Then
            txtemail.Text = txtemail.Text.Trim + " "
            txtemail.SelectionStart = txtemail.Text.Length
        End If

        txtemail.Text = Trim(Replace(Me.txtemail.Text, "  ", " "))
    End Sub

    Private Sub TextBoxX6_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtdire.TextChanged
        If txtdire.Text.StartsWith(" ") Then
            txtdire.Text = txtdire.Text.Trim
        ElseIf txtnomcontac.Text.EndsWith(" ") Then
            txtdire.Text = txtdire.Text.Trim + " "
            txtdire.SelectionStart = txtdire.Text.Length
        End If
    End Sub
    Public Sub bloquearTextbox()
        txtnomcomp.Enabled = False
        txtnomcontac.Enabled = False
        txtruc.Enabled = False
        txttelefono.Enabled = False
        txtemail.Enabled = False
        txtdire.Enabled = False
    End Sub
    Public Sub habilitarTextbox()
        txtnomcomp.Enabled = True
        txtnomcontac.Enabled = True
        txtruc.Enabled = True
        txttelefono.Enabled = True
        txtemail.Enabled = True
        txtdire.Enabled = True
    End Sub
    Public Function ValidarMinimoLetras() As Boolean
        Dim pasa As Boolean
        If Len(txtnomcomp.Text.Trim) < 4 Then
            MsgBox("NOMBRE DE COMPAÑIA SUPERIR A 3 CARACTERES", MsgBoxStyle.Critical, "DATO INCORRECTO")
            txtnomcomp.Focus()
            pasa = False
        Else
            pasa = True
        End If
        Return pasa
    End Function
    Public Function ValidarEmail() As Boolean
        Dim pasa As Boolean
        Dim strCorreo As String
        strCorreo = txtemail.Text
        Dim blnCorreo As Boolean
        Dim rgx As New RegularExpressions.Regex("\w+([-+.´]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")
        If txtemail.Text = "" Then
            pasa = True
        Else
            If rgx.IsMatch(strCorreo) Then
                blnCorreo = True
                pasa = True
            Else : blnCorreo = False
                pasa = False
                MsgBox("CORREO ELECTRONICO NO VALIDO", MsgBoxStyle.Critical, "DATO INCORRECTO")
                txtemail.Focus()
            End If
        End If
        
        Return pasa
    End Function

    Private Sub Dg_Proveedores_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellContentClick

    End Sub

    Private Sub txttelefono_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress
        e.Handled = v.validaNumeros(e)
    End Sub

    Private Sub groupPanel1_Click(sender As System.Object, e As System.EventArgs) Handles groupPanel1.Click

    End Sub

    Private Sub Dg_Proveedores_DataBindingComplete(sender As Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles Dg_Proveedores.DataBindingComplete
        Dim i As Integer
        For i = 0 To Dg_Proveedores.Rows.Count - 2

            If Dg_Proveedores.Item(7, i).Value() = 0 Then
                Dg_Proveedores.Rows(i).DefaultCellStyle.BackColor = Color.Black
                Dg_Proveedores.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub txttelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttelefono.TextChanged

    End Sub

    Private Sub txtruc_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtruc.TextChanged

    End Sub
End Class