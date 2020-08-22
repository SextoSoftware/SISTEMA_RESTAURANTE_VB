Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text
Public Class WFrm_USUARIO
    Inherits DevComponents.DotNetBar.Office2007Form
    Public objnegocio As New CAPA_NEGOCIO.CpNCls_USUARIO
    Public objentidade As New CAPA_ENTIDAD.CpECls_USUARIO
    Public v As New CAPA_NEGOCIO.CpN_Cls_VALIDACIONES
    Public estado As Integer
    Public buscar As Integer

    Public Sub limpiar_textos()
        Me.txtnom.Text = ""
        Me.txtnomape.Text = ""
        Me.txtdni.Text = ""
        Me.txttele.Text = ""
        Me.txtclave.Text = ""
        Me.txtder.Text = ""
        Me.TextBox1.Text = ""
        Me.RadioButtonActivo.Checked = True
        Me.RadioButtonInactivo.Enabled = False
        ButtonRegistrar.Enabled = True
        Me.txtnom.Enabled = True
        Me.ButttonModificar.Enabled = False
        Me.ComboBoxEx1.SelectedIndex = -1

    End Sub
    Public Sub llenarDatos()
        objentidade.usu = Me.txtnom.Text
        objentidade.cla = Me.txtclave.Text
        objentidade.idtipo = Me.TextBox2.Text
        objentidade.direcion = Me.txtder.Text
        objentidade.dni = Me.txtdni.Text
        objentidade.tele = Me.txttele.Text
        objentidade.NomApe = Me.txtnomape.Text
        objentidade.Estado = estado
    End Sub
    Private Sub WFrm_MENU_USUARIO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dg_Proveedores.DataSource = objnegocio.MOSTRAR_USUARIO(objentidade)
        Dg_Proveedores.Columns(0).HeaderText = "ID"
        Dg_Proveedores.Columns(0).Visible = False
        Dg_Proveedores.Columns(0).Width = 40
        Dg_Proveedores.Columns(4).Width = 150
        ' Dg_Proveedores.Columns(2).Width = 40
        Dg_Proveedores.Columns(3).Width = 60
        ' Dg_Proveedores.Columns(4).Width = 70
        '  Dg_Proveedores.Columns(5).Width = 80
        ' Dg_Proveedores.Columns(6).Width = 70
        Dg_Proveedores.Columns(8).Width = 55

        Me.ComboBoxEx1.DataSource = objnegocio.MOSTRAR_TIPO_USUARIO(objentidade)
        Me.ComboBoxEx1.DisplayMember = "Nombre"
        Me.ComboBoxEx1.ValueMember = "IdTipoUsuario"
        Me.ComboBoxEx1.SelectedIndex = -1
    End Sub

    Private Sub ButtonNuevo_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNuevo.Click
        limpiar_textos()
    End Sub

    Private Sub txtdni_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtdni.KeyPress
        e.Handled = v.validaNumeros(e)
    End Sub

    Private Sub txtdni_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtdni.TextChanged

    End Sub

    Private Sub txttele_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txttele.KeyDown

    End Sub

    Private Sub txttele_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txttele.KeyPress
        e.Handled = v.validaNumeros(e)
    End Sub

    Private Sub txttele_TextChanged(sender As System.Object, e As System.EventArgs) Handles txttele.TextChanged

    End Sub

    Private Sub ButtonRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRegistrar.Click
        If txtnom.Text.Trim = "" Or TextBox2.Text.Trim = "" Or txtclave.Text.Trim = "" Or txtnomape.Text.Trim = "" Or txtdni.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If v.MensajeGuardar() = 6 Then
                llenarDatos()
                objnegocio.REGISTRAR_USUARIO(objentidade)
                Dg_Proveedores.DataSource = objnegocio.MOSTRAR_USUARIO(objentidade)
                limpiar_textos()
            End If
        End If
    End Sub

    Private Sub ComboBoxEx1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxEx1.SelectedIndexChanged

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
            txtclave.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(2).Value()
            TextBox2.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(3).Value()
            txtnomape.Text = Convert.ToString(Me.Dg_Proveedores.Rows(e.RowIndex).Cells(4).Value())
            txtdni.Text = Convert.ToString(Me.Dg_Proveedores.Rows(e.RowIndex).Cells(5).Value())
            txttele.Text = Convert.ToString(Me.Dg_Proveedores.Rows(e.RowIndex).Cells(6).Value())
            txtder.Text = Convert.ToString(Me.Dg_Proveedores.Rows(e.RowIndex).Cells(7).Value())
            estado = Convert.ToString(Me.Dg_Proveedores.Rows(e.RowIndex).Cells(8).Value())
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

    Private Sub Dg_Proveedores_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellContentClick

    End Sub

    Private Sub ButttonModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButttonModificar.Click
        If txtnom.Text.Trim = "" Or TextBox2.Text.Trim = "" Or txtclave.Text.Trim = "" Or txtnomape.Text.Trim = "" Or txtdni.Text.Trim = "" Or TextBox1.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If v.MensajeModificar() = 6 Then
                llenarDatos()
                objentidade.Idusuario = TextBox1.Text
                objnegocio.MODIFICAR_USUARIO(objentidade)
                Dg_Proveedores.DataSource = objnegocio.MOSTRAR_USUARIO(objentidade)
                limpiar_textos()
            End If
        End If
    End Sub

    Private Sub txtnom_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtnom.KeyPress
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
            e.Handled = True
        Else
            'que se bloquee
            e.Handled = True
        End If
    End Sub

    Private Sub txtnom_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnom.TextChanged
       
    End Sub

    Private Sub txtclave_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtclave.KeyPress
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
            e.Handled = True
        Else
            'que se bloquee
            e.Handled = True
        End If
    End Sub

    Private Sub txtclave_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtclave.TextChanged
       
    End Sub

    Private Sub txtnomape_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtnomape.KeyPress
        e.Handled = v.validaletras(e)
    End Sub

    Private Sub txtnomape_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnomape.TextChanged
        If txtnomape.Text.StartsWith(" ") Then
            txtnomape.Text = txtnomape.Text.Trim
        ElseIf txtnomape.Text.EndsWith(" ") Then
            txtnomape.Text = txtnomape.Text.Trim + " "
            txtnomape.SelectionStart = txtnomape.Text.Length
        End If
    End Sub

    Private Sub txtder_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtder.TextChanged
        If txtder.Text.StartsWith(" ") Then
            txtder.Text = txtder.Text.Trim
        ElseIf txtder.Text.EndsWith(" ") Then
            txtder.Text = txtder.Text.Trim + " "
            txtder.SelectionStart = txtder.Text.Length
        End If
    End Sub

    Private Sub Dg_Proveedores_DataBindingComplete(sender As Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles Dg_Proveedores.DataBindingComplete
        Dim i As Integer
        For i = 0 To Dg_Proveedores.Rows.Count - 2

            If Dg_Proveedores.Item(8, i).Value() = 0 Then
                Dg_Proveedores.Rows(i).DefaultCellStyle.BackColor = Color.Black
                Dg_Proveedores.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub Dg_Proveedores_DataMemberChanged(sender As Object, e As System.EventArgs) Handles Dg_Proveedores.DataMemberChanged
       
    End Sub
End Class