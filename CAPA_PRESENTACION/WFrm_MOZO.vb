Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text
Public Class WFrm_MOZO
    Inherits DevComponents.DotNetBar.Office2007Form
    Public objnegocio As New CAPA_NEGOCIO.CpN_Cls_MOZO
    Public objentidade As New CAPA_ENTIDAD.CpE_Cls_MOZO
    Public v As New CAPA_NEGOCIO.CpN_Cls_VALIDACIONES
    Public estado As Integer
    Public buscar As Integer
    Public Sub limpiar_textos()
        Me.txtnomcomp.Text = ""
        Me.txtDNI.Text = ""
        Me.txttelefonoNatu.Text = ""
        Me.txtemail.Text = ""
        Me.txtdire.Text = ""
        '  Me.txtbusqueda.Text = ""
        Me.RadioButtonActivo.Checked = True
        Me.RadioButtonInactivo.Enabled = False
        ButtonRegistrar.Enabled = True
        Me.ButttonModificar.Enabled = False
    End Sub
    Public Sub llenarDatos()
        objentidade.NombreCompañia = Me.txtnomcomp.Text
        objentidade.ruc = Me.txtDNI.Text
        objentidade.telefono = Me.txttelefonoNatu.Text
        objentidade.direccion = Me.txtdire.Text
        objentidade.observacion = Me.txtemail.Text
        objentidade.Estado = estado
    End Sub
    Private Sub WFrm_MOZO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dg_Proveedores.DataSource = objnegocio.MOSTRAR_MOZO(objentidade)
        Dg_Proveedores.Columns(0).HeaderText = "ID"
        Dg_Proveedores.Columns(0).Width = 40
        Dg_Proveedores.Columns(1).Width = 85
        Dg_Proveedores.Columns(2).Width = 180
        Dg_Proveedores.Columns(3).Width = 90
        ' Dg_Proveedores.Columns(4).Width = 70
        Dg_Proveedores.Columns(6).Width = 50
        Dg_Proveedores.Columns(0).Visible = False
    End Sub

    Private Sub groupPanel1_Click(sender As System.Object, e As System.EventArgs) Handles groupPanel1.Click

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
            txtnomcomp.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(2).Value()

            txtDNI.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(1).Value()
            txttelefonoNatu.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(3).Value()
            txtdire.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(4).Value()
            txtemail.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(5).Value()
            estado = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(6).Value()
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

    Private Sub ButtonRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRegistrar.Click
        If txtnomcomp.Text.Trim = "" Or txtDNI.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else

            If v.MensajeGuardar() = 6 Then
                llenarDatos()
                objnegocio.REGISTRAR_MOZO(objentidade)
                Dg_Proveedores.DataSource = objnegocio.MOSTRAR_MOZO(objentidade)
                limpiar_textos()
            End If

        End If
    End Sub

    Private Sub ButttonModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButttonModificar.Click
        If txtnomcomp.Text.Trim = "" Or txtDNI.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else


            If v.MensajeModificar() = 6 Then
                llenarDatos()
                objentidade.idmozo = TextBox1.Text
                objnegocio.MODIFICAR_MOZO(objentidade)
                Dg_Proveedores.DataSource = objnegocio.MOSTRAR_MOZO(objentidade)
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

    Private Sub ButtonNuevo_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNuevo.Click
        limpiar_textos()
    End Sub

    Private Sub txttelefonoNatu_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefonoNatu.KeyPress
        e.Handled = v.validaNumeros(e)
    End Sub

    Private Sub txttelefonoNatu_TextChanged(sender As System.Object, e As System.EventArgs) Handles txttelefonoNatu.TextChanged

    End Sub

    Private Sub txtDNI_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        e.Handled = v.validaNumeros(e)
    End Sub

    Private Sub txtDNI_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDNI.TextChanged

    End Sub

    Private Sub txtnomcomp_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtnomcomp.KeyPress
        e.Handled = v.validaletras(e)
    End Sub

    Private Sub txtnomcomp_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnomcomp.TextChanged

    End Sub

    Private Sub Dg_Proveedores_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Dg_Proveedores.DataBindingComplete
        Dim i As Integer
        For i = 0 To Dg_Proveedores.Rows.Count - 2

            If Dg_Proveedores.Item(6, i).Value() = 0 Then
                Dg_Proveedores.Rows(i).DefaultCellStyle.BackColor = Color.Black
                Dg_Proveedores.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub
End Class