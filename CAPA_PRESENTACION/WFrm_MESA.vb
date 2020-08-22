Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text
Public Class WFrm_Mesa
    Inherits DevComponents.DotNetBar.Office2007Form
    Public objnegocio As New CAPA_NEGOCIO.CpN_Cls_MESA
    Public objentidade As New CAPA_ENTIDAD.CpE_Cls_MESA
    Public v As New CAPA_NEGOCIO.CpN_Cls_VALIDACIONES
    Public estado As Integer
    Public buscar As Integer
    Public Sub limpiar_textos()
        Me.txtnom.Text = ""
        Me.TextBox1.Text = ""
        Me.RadioButtonActivo.Checked = True
        Me.RadioButtonInactivo.Enabled = False
        ButtonRegistrar.Enabled = True
        Me.txtnom.Enabled = True
        Me.ButttonModificar.Enabled = False
    End Sub
    Public Sub llenarDatos()
        objentidade.Nombre = Me.txtnom.Text
        objentidade.Estado = estado
    End Sub


    Private Sub WFrm_Mesa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dg_Proveedores.DataSource = objnegocio.MOSTRAR_MESA(objentidade)
        Dg_Proveedores.Columns(0).HeaderText = "ID"
        Dg_Proveedores.Columns(0).Width = 50
        Dg_Proveedores.Columns(1).Width = 170
        Dg_Proveedores.Columns(0).Visible = False

        'Recorremos el DataGridView con un bucle for


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
            estado = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(2).Value()
            If estado = 1 Then
                RadioButtonActivo.Checked = True
            End If
            If estado = 0 Then
                RadioButtonInactivo.Checked = True

            End If
        End If
    End Sub



    Private Sub ButtonRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRegistrar.Click
        If txtnom.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If v.MensajeGuardar() = 6 Then
                llenarDatos()
                objnegocio.REGISTRAR_MESA(objentidade)
                Dg_Proveedores.DataSource = objnegocio.MOSTRAR_MESA(objentidade)
                limpiar_textos()
                actualiza_panel_mesas()
            End If
        End If
    End Sub

    Private Sub ButtonNuevo_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNuevo.Click
        limpiar_textos()
       


    End Sub

    Private Sub txtnom_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtnom.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
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

    Private Sub RadioButtonActivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonActivo.CheckedChanged
        estado = 1
    End Sub

    Private Sub RadioButtonInactivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonInactivo.CheckedChanged
        estado = 0
    End Sub

    Private Sub ButttonModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButttonModificar.Click
        If txtnom.Text.Trim = "" Or TextBox1.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If v.MensajeModificar() = 6 Then
                llenarDatos()
                objentidade.idmesa = TextBox1.Text
                objnegocio.MODIFICAR_MESA(objentidade)
                Dg_Proveedores.DataSource = objnegocio.MOSTRAR_MESA(objentidade)
                limpiar_textos()
                actualiza_panel_mesas()
            End If
        End If
    End Sub

    Private Sub Dg_Proveedores_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellContentClick

    End Sub

    Private Sub Dg_Proveedores_DataBindingComplete(sender As Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles Dg_Proveedores.DataBindingComplete
        Dim i As Integer
        For i = 0 To Dg_Proveedores.Rows.Count - 2

            If Dg_Proveedores.Item(2, i).Value() = 0 Then
                Dg_Proveedores.Rows(i).DefaultCellStyle.BackColor = Color.Black
                Dg_Proveedores.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next

    End Sub
End Class