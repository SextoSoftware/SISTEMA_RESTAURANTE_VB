Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text
Public Class Wfrm_INGREDIENTES
    Inherits DevComponents.DotNetBar.Office2007Form

    Public objnegocio As New CAPA_NEGOCIO.CpN_Cls_INGREDIENTE
    Public objentidade As New CAPA_ENTIDAD.CpE_Cls_INGREDIENTE
    Public v As New CAPA_NEGOCIO.CpN_Cls_VALIDACIONES
    Public Sub limpiar_textos()
        Me.txtnom.Text = ""
        Me.txtStock.Text = ""
        Me.TextBox1.Text = ""
       
        ButtonRegistrar.Enabled = True
        Me.ButttonModificar.Enabled = False
    End Sub
    Public Sub llenarDatos()
        objentidade.Nombre = Me.txtnom.Text
        objentidade.Unidad = Me.cbunidad.Text
        objentidade.Stock = Me.txtStock.Text
    End Sub
    Private Sub Wfrm_INGREDIENTES_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dg_Proveedores.DataSource = objnegocio.MOSTRAR_INGREDIENTE(objentidade)
        Dg_Proveedores.Columns(0).Visible = False
        Dg_Proveedores.Columns(0).HeaderText = "ID"
    End Sub

    Private Sub GroupPanel2_Click(sender As System.Object, e As System.EventArgs) Handles GroupPanel2.Click

    End Sub

    Private Sub Dg_Proveedores_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellClick
        ButtonRegistrar.Enabled = False

        Me.ButttonModificar.Enabled = True
        If (e.RowIndex = -1) Then Return
        If IsDBNull(Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value) Then

            Return
        Else
            TextBox1.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value()
            cbunidad.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(2).Value()

            txtnom.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(1).Value()
            txtStock.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(3).Value()
           
        End If
    End Sub

    Private Sub Dg_Proveedores_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellContentClick

    End Sub

    Private Sub ButtonRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRegistrar.Click
        If txtnom.Text.Trim = "" Or txtStock.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else

            If v.MensajeGuardar() = 6 Then
                llenarDatos()
                objnegocio.REGISTRAR_INGREDIENTE(objentidade)
                Dg_Proveedores.DataSource = objnegocio.MOSTRAR_INGREDIENTE(objentidade)
                limpiar_textos()
            End If

        End If
    End Sub

    Private Sub ButttonModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButttonModificar.Click
        If txtnom.Text.Trim = "" Or txtStock.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else


            If v.MensajeModificar() = 6 Then
                llenarDatos()
                objentidade.idingrediente = TextBox1.Text
                objnegocio.MODIFICAR_INGREDIENTE(objentidade)
                Dg_Proveedores.DataSource = objnegocio.MOSTRAR_INGREDIENTE(objentidade)
                limpiar_textos()
            End If
        End If

    End Sub

    Private Sub ButtonNuevo_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNuevo.Click
        limpiar_textos()
    End Sub
End Class