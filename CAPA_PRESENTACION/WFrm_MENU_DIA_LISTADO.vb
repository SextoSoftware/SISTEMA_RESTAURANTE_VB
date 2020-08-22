Public Class WFrm_MENU_DIA_LISTADO
    Inherits DevComponents.DotNetBar.Office2007Form
    Public objnegocio As New CAPA_NEGOCIO.CpN_Cls_MENU_DIA
    Public objentidade As New CAPA_ENTIDAD.CpE_Cls_MENU_DIA
    'Public v As New CAPA_NEGOCIO.CpN_Cls_VALIDACIONES
    Public estado As String
    'Public buscar As Integer
    Private Sub WFrm_MENU_DIA_LISTADO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dg_Proveedores.DataSource = objnegocio.MOSTRAR_MENU_DIA(objentidade)
        Dg_Proveedores.Columns(0).HeaderText = "ID"
        Dg_Proveedores.Columns(0).Width = 45
        Dg_Proveedores.Columns(1).Width = 190
        Dg_Proveedores.Columns(2).Width = 130
        Dg_Proveedores.Columns(3).Width = 80

    End Sub

    Private Sub ButtonRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRegistrar.Click
        If CodigoMenuDia = 0 Then
            MsgBox("DEBES SELECCIONAR UN PEDIDO PARA PROCESAR", MsgBoxStyle.Exclamation)
        Else
            My.Forms.MENU_PRINCIPAL.AbrirVentana_Reporte_MenuDia()
        End If
    End Sub

    Private Sub Dg_Proveedores_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellClick
        If (e.RowIndex = -1) Then Return
        If IsDBNull(Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value) Then

            Return
        Else
            CodigoMenuDia = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value()
            menu_nombre = (Me.Dg_Proveedores.Rows(e.RowIndex).Cells(1).Value())
            estado = (Me.Dg_Proveedores.Rows(e.RowIndex).Cells(3).Value())
            ' proveedor_id = Convert.ToString(Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value())
            'proveedor_nombre = Convert.ToString(Me.DataGridView1.Rows(e.RowIndex).Cells(3).Value())
            'proveedor_ruc = Convert.ToString(Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value())
            'estado1 = Me.DataGridView1.Rows(e.RowIndex).Cells(5).Value()
            ' descripcion = Convert.ToString(Me.DataGridView1.Rows(e.RowIndex).Cells(6).Value())
        End If
    End Sub

    Private Sub Dg_Proveedores_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellContentClick

    End Sub

    Private Sub Dg_Proveedores_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Proveedores.CellDoubleClick
        If (e.RowIndex = -1) Then Return
        If IsDBNull(Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value) Then

            Return
        Else
            WFrm_MENU_DIA.TextBox1.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(0).Value()
            WFrm_MENU_DIA.txtnom.text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(1).Value()
            WFrm_MENU_DIA.txtdes.Text = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(2).Value()
            estado = Me.Dg_Proveedores.Rows(e.RowIndex).Cells(3).Value()
            If estado = "ACTIVADO" Then
                WFrm_MENU_DIA.RadioButtonActivo.Checked = True
                WFrm_MENU_DIA.RadioButtonInactivo.Checked = False
                WFrm_MENU_DIA.RadioButtonPendiiente.Checked = False
            End If
            If estado = "PENDIENTE" Then
                WFrm_MENU_DIA.RadioButtonActivo.Checked = False
                WFrm_MENU_DIA.RadioButtonInactivo.Checked = False
                WFrm_MENU_DIA.RadioButtonPendiiente.Checked = True
            End If
            If estado = "INACTVO" Then
                WFrm_MENU_DIA.RadioButtonActivo.Checked = False
                WFrm_MENU_DIA.RadioButtonInactivo.Checked = True
                WFrm_MENU_DIA.RadioButtonPendiiente.Checked = False
            End If

            WFrm_MENU_DIA.ButtonRegistrar.Enabled = False
            WFrm_MENU_DIA.ButttonModificar.Enabled = True

            WFrm_MENU_DIA.RadioButtonActivo.Enabled = True
            WFrm_MENU_DIA.RadioButtonInactivo.Enabled = True

            WFrm_MENU_DIA.ButtonX1.Enabled = False
            WFrm_MENU_DIA.ButtonX3.Enabled = False
            WFrm_MENU_DIA.GroupPanel2.Enabled = False

            WFrm_MENU_DIA.ListarListview()


            MENU_PRINCIPAL.AbrirVentana_MENU_DIA()

          
            'My.Forms.WFrm_MENU_DIA.MdiParent = Me
            'My.Forms.WFrm_MENU_DIA.Show()
            Close()
        End If
    End Sub

    Private Sub txtbusqueda_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbusqueda.TextChanged
        objentidade.Nombre = txtbusqueda.Text
        Dg_Proveedores.DataSource = objnegocio.BUSCAR_MENU(objentidade)
    End Sub



    
    Private Sub Dg_Proveedores_DataBindingComplete(sender As Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles Dg_Proveedores.DataBindingComplete
        Dim i As Integer
        For i = 0 To Dg_Proveedores.Rows.Count - 2

            If Dg_Proveedores.Item(3, i).Value() = "ACTIVADO" Then
                Dg_Proveedores.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
                Dg_Proveedores.Rows(i).DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
    End Sub
End Class