Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Imports System.Text.RegularExpressions
Imports System.Text

Public Class WFrm_CLIENTE
    Inherits DevComponents.DotNetBar.Office2007Form
    Public objnegocio As New CAPA_NEGOCIO.CpN_Cls_CLIENTE
    Public objentidade As New CAPA_ENTIDAD.CpE_Cls_CLIENTE
    Public v As New CAPA_NEGOCIO.CpN_Cls_VALIDACIONES
    Public estado As Integer
    Public estado1 As Integer
    Public buscar As Integer
    Public Sub limpiar_textos_Natural()

        Me.txtruc.Text = ""
        Me.txtnombre.Text = ""
        Me.txtrazonSocial.Text = ""
        Me.txtTelefonoJuri.Text = ""
        Me.txtdireJuri.Text = ""
        Me.txtemalJuri.Text = ""
        Me.TextBoxX1.Text = ""
        Me.txtDNI.Text = ""
        Me.txtNomNatu.Text = ""
        Me.TextBox2.Text = ""
        Me.txtApeNatu.Text = ""
        Me.txttelefonoNatu.Text = ""
        Me.txtemailNatu.Text = ""
        Me.txtdieNatu.Text = ""
        Me.txtbusqueda.Text = ""
        Me.RadioButtonActivo.Checked = True
        Me.RadioButtonInactivo.Enabled = False
        ButtonRegistrar.Enabled = True
        Me.ButttonModificar.Enabled = False
        Me.ButtonX3.Enabled = True
        Me.ButtonX2.Enabled = False

        ButtonX1.Enabled = True
        Me.RadioButton4.Checked = True
        Me.RadioButton3.Enabled = False
    End Sub
    Public Sub llenarDatosClienteNatural()
        objentidade.dni = Me.txtDNI.Text
        objentidade.Nombre = Me.txtNomNatu.Text
        objentidade.Apellido = Me.txtApeNatu.Text
        objentidade.telefono = Me.txttelefonoNatu.Text
        objentidade.direccion = Me.txtdieNatu.Text
        objentidade.correo = Me.txtemailNatu.Text
        objentidade.estado = estado
        objentidade.fechaNacimiento = DateTimePicker1.Text.Trim
    End Sub
    Public Sub llenarDatosClienteJurdico()
        objentidade.ruc = Me.txtruc.Text
        objentidade.RazonSocial = Me.txtrazonSocial.Text
        objentidade.Nombre = Me.txtnombre.Text
        objentidade.telefono = Me.txtTelefonoJuri.Text
        objentidade.direccion = Me.txtdireJuri.Text
        objentidade.correo = Me.txtemalJuri.Text
        objentidade.estado = estado1
        objentidade.fechaNacimiento = DateTimePicker2.Text.Trim
    End Sub
    Private Sub WFrm_CLIENTE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TabControlPanel1.Select()
        Dg_ClienteNatural.DataSource = objnegocio.MOSTRAR_CLIENTE_NATURAL(objentidade)
        Dg_ClienteNatural.Columns(0).Width = 40
        Dg_ClienteNatural.Columns(1).Width = 80
        Dg_ClienteNatural.Columns(5).Width = 110
        Dg_ClienteNatural.Columns(3).Width = 120
        Dg_ClienteNatural.Columns(6).Width = 100
        Dg_ClienteNatural.Columns(8).Width = 50
        Dg_ClienteNatural.Columns(0).Visible = False

        Dg_ClienteJuridco.DataSource = objnegocio.MOSTRAR_CLIENTE_JURIDICO(objentidade)
        Dg_ClienteJuridco.Columns(0).Width = 40
        Dg_ClienteJuridco.Columns(1).Width = 100
        Dg_ClienteJuridco.Columns(2).Width = 120
        Dg_ClienteJuridco.Columns(3).Width = 120
        Dg_ClienteJuridco.Columns(4).Width = 85
        Dg_ClienteJuridco.Columns(8).Width = 50
        Dg_ClienteJuridco.Columns(5).Width = 110
        Dg_ClienteJuridco.Columns(0).Visible = False
    End Sub


    Private Sub TabControl1_Click(sender As System.Object, e As System.EventArgs) Handles TabControl1.Click

    End Sub

    Private Sub ButtonNuevo_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNuevo.Click
        limpiar_textos_Natural()
    End Sub




    Private Sub Dg_ClienteNatural_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub




    Private Sub ButtonRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRegistrar.Click
        If txtDNI.Text.Trim = "" Or txtNomNatu.Text.Trim = "" Or txtApeNatu.Text.Trim = "" Or txttelefonoNatu.Text.Trim = "" Or txtdieNatu.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If ValidarRuc() And ValidarTelefono() And ValidarApellidoParternoMaterno() And ValidarEmail() Then
                If v.MensajeGuardar() = 6 Then
                    llenarDatosClienteNatural()
                    objnegocio.REGISTRAR_CLIENTE_NATURAL(objentidade)
                    Dg_ClienteNatural.DataSource = objnegocio.MOSTRAR_CLIENTE_NATURAL(objentidade)
                    limpiar_textos_Natural()
                End If
            End If
        End If
    End Sub

    Private Sub txtDNI_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        e.Handled = v.validaNumeros(e)
    End Sub

    Private Sub txtDNI_LostFocus(sender As Object, e As System.EventArgs) Handles txtDNI.LostFocus
        ' If Len(txtDNI.Text) < 8 Then
        ' MsgBox("DNI DEBE SER DE 8 DIGITOS DEL 0-9", MsgBoxStyle.Critical, "DATO INCORRECTO")
        '  txtDNI.Focus()
        ' Else
        ' End If
    End Sub

    Private Sub txtDNI_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDNI.TextChanged

    End Sub

    Private Sub txtNomNatu_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNomNatu.KeyPress
        e.Handled = v.validaletras(e)
    End Sub

    Private Sub txtNomNatu_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNomNatu.TextChanged

    End Sub

    Private Sub txtApeNatu_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtApeNatu.KeyPress
        e.Handled = v.validaletras(e)
    End Sub

    Private Sub txtApeNatu_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtApeNatu.TextChanged

    End Sub

    Private Sub txttelefonoNatu_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefonoNatu.KeyPress
        e.Handled = v.validaNumeros(e)
    End Sub
    Public Function ValidarRuc1() As Boolean
        Dim pasa As Boolean
        If Len(txtruc.Text) < 11 Then
            MsgBox("RUC DEBE SER DE 11 DIGITOS DEL 0-9", MsgBoxStyle.Critical, "DATO INCORRECTO")
            txtruc.Focus()
            pasa = False
        Else
            pasa = True
        End If
        Return pasa
    End Function
    Public Function ValidarRuc() As Boolean
        Dim pasa As Boolean
        If Len(txtDNI.Text) < 9 Then
            MsgBox("DNI DEBE SER DE 9 DIGITOS DEL 0-9", MsgBoxStyle.Critical, "DATO INCORRECTO")
            txtDNI.Focus()
            pasa = False
        Else
            pasa = True
        End If
        Return pasa
    End Function

    Public Function ValidarTelefono() As Boolean
        Dim pasa As Boolean
        If Len(txttelefonoNatu.Text) < 10 Then
            MsgBox("EL TELEFONO DEBE SER DE 9 DIGITOS DEL 0-9", MsgBoxStyle.Critical, "DATO INCORRECTO")
            txttelefonoNatu.Focus()
            pasa = False
        Else
            pasa = True
        End If
        Return pasa
    End Function
    Public Function ValidarTelefono1() As Boolean
        Dim pasa As Boolean
        If Len(txtTelefonoJuri.Text) < 10 Then
            MsgBox("EL TELEFONO DEBE SER DE 10 DIGITOS DEL 0-9", MsgBoxStyle.Critical, "DATO INCORRECTO")
            txtTelefonoJuri.Focus()
            pasa = False
        Else
            pasa = True
        End If
        Return pasa
    End Function

    Public Function ValidarApellidoParternoMaterno() As Boolean
        Dim pasa As Boolean
        Dim partes() As String = txtApeNatu.Text.Trim.Split(" "c)
        If partes.Length > 2 Or partes.Length = 1 Then
            MsgBox("DEBES INGRESAR APELLIDO PATERNO Y MATERNO", MsgBoxStyle.Critical, "DATO INCORRECTO")
            txtApeNatu.Focus()
            pasa = False
        Else
            pasa = True
        End If
        Return pasa
    End Function
    Public Function ValidarEmail() As Boolean
        Dim pasa As Boolean
        Dim strCorreo As String
        strCorreo = txtemailNatu.Text
        Dim blnCorreo As Boolean
        If txtemailNatu.Text = "" Then
            pasa = True
        Else
            Dim rgx As New RegularExpressions.Regex("\w+([-+.´]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")
            If rgx.IsMatch(strCorreo) Then
                blnCorreo = True
                pasa = True
            Else : blnCorreo = False
                pasa = False
                MsgBox("CORREO ELECTRONICO NO VALIDO", MsgBoxStyle.Critical, "DATO INCORRECTO")
                txtemailNatu.Focus()
            End If
        End If
        Return pasa
    End Function
    Public Function ValidarEmail1() As Boolean
        Dim pasa As Boolean
        Dim strCorreo As String
        strCorreo = txtemalJuri.Text
        Dim blnCorreo As Boolean
        If txtemalJuri.Text = "" Then
            pasa = True
        Else
            Dim rgx As New RegularExpressions.Regex("\w+([-+.´]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")
            If rgx.IsMatch(strCorreo) Then
                blnCorreo = True
                pasa = True
            Else : blnCorreo = False
                pasa = False
                MsgBox("CORREO ELECTRONICO NO VALIDO", MsgBoxStyle.Critical, "DATO INCORRECTO")
                txtemalJuri.Focus()
            End If
        End If
        Return pasa
    End Function

    Private Sub ButttonModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButttonModificar.Click
        If txtDNI.Text.Trim = "" Or txtNomNatu.Text.Trim = "" Or txtApeNatu.Text.Trim = "" Or txttelefonoNatu.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If ValidarRuc() And ValidarTelefono() And ValidarApellidoParternoMaterno() And ValidarEmail() Then
                If v.MensajeModificar() = 6 Then
                    objentidade.idcliente = TextBox1.Text
                    llenarDatosClienteNatural()
                    objnegocio.MODIFICAR_CLIENTE_NATURAL(objentidade)
                    Dg_ClienteNatural.DataSource = objnegocio.MOSTRAR_CLIENTE_NATURAL(objentidade)
                    limpiar_textos_Natural()
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ButtonX3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX3.Click
        If txtruc.Text.Trim = "" Or txtrazonSocial.Text.Trim = "" Or txtnombre.Text.Trim = "" Or txtTelefonoJuri.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If ValidarRuc1() And ValidarTelefono1() And ValidarEmail1() Then
                If v.MensajeGuardar() = 6 Then
                    llenarDatosClienteJurdico()
                    objnegocio.REGISTRAR_CLIENTE_JURIDICO(objentidade)
                    Dg_ClienteJuridco.DataSource = objnegocio.MOSTRAR_CLIENTE_JURIDICO(objentidade)
                    limpiar_textos_Natural()
                End If
            End If
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        estado1 = 1
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        estado1 = 0
    End Sub

    Private Sub TextBoxX7_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtruc.KeyPress
        e.Handled = v.validaNumeros(e)
    End Sub

    Private Sub TextBoxX7_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtruc.TextChanged

    End Sub

    Private Sub TextBoxX6_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtrazonSocial.KeyPress
        e.Handled = v.validaletras(e)
    End Sub

    Private Sub TextBoxX6_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtrazonSocial.TextChanged

    End Sub

    Private Sub TextBoxX5_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        e.Handled = v.validaletras(e)
    End Sub

    Private Sub TextBoxX5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txttelefonoNatu_TextChanged(sender As System.Object, e As System.EventArgs) Handles txttelefonoNatu.TextChanged

    End Sub

    Private Sub TextBoxX4_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefonoJuri.KeyPress
        e.Handled = v.validaNumeros(e)
    End Sub

    Private Sub TextBoxX4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTelefonoJuri.TextChanged

    End Sub

    Private Sub RadioButtonActivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonActivo.CheckedChanged
        estado = 1
    End Sub

    Private Sub RadioButtonInactivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonInactivo.CheckedChanged
        estado = 0
    End Sub

    Private Sub Dg_ClienteJuridco_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub



    Private Sub GroupPanel2_Click(sender As System.Object, e As System.EventArgs) Handles GroupPanel2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub GroupPanel4_Click(sender As System.Object, e As System.EventArgs) Handles GroupPanel4.Click

    End Sub

    Private Sub Dg_ClienteJuridco_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_ClienteJuridco.CellClick
        ButtonX3.Enabled = False
        RadioButton3.Enabled = True
        Me.ButtonX2.Enabled = True

        If (e.RowIndex = -1) Then Return
        If IsDBNull(Dg_ClienteJuridco.Rows(e.RowIndex).Cells(0).Value) Then

            Return
        Else
            TextBox2.Text = Me.Dg_ClienteJuridco.Rows(e.RowIndex).Cells(0).Value()
            txtruc.Text = Me.Dg_ClienteJuridco.Rows(e.RowIndex).Cells(1).Value()
            txtrazonSocial.Text = Me.Dg_ClienteJuridco.Rows(e.RowIndex).Cells(2).Value()
            txtnombre.Text = Me.Dg_ClienteJuridco.Rows(e.RowIndex).Cells(3).Value()
            txtTelefonoJuri.Text = Me.Dg_ClienteJuridco.Rows(e.RowIndex).Cells(4).Value()
            DateTimePicker2.Text = Dg_ClienteJuridco.Rows(e.RowIndex).Cells(5).Value()
            txtdireJuri.Text = Me.Dg_ClienteJuridco.Rows(e.RowIndex).Cells(6).Value()
            txtemalJuri.Text = Me.Dg_ClienteJuridco.Rows(e.RowIndex).Cells(7).Value()
            estado1 = Me.Dg_ClienteJuridco.Rows(e.RowIndex).Cells(8).Value()
            If estado1 = 1 Then
                RadioButton4.Checked = True
            End If
            If estado1 = 0 Then
                RadioButton3.Checked = True
            End If
        End If
    End Sub

    Private Sub DataGridViewX1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_ClienteJuridco.CellContentClick

    End Sub

    Private Sub Dg_ClienteNatural_CellClick1(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_ClienteNatural.CellClick

        ButtonRegistrar.Enabled = False
        RadioButtonInactivo.Enabled = True
        Me.ButttonModificar.Enabled = True

        If (e.RowIndex = -1) Then Return
        If IsDBNull(Dg_ClienteNatural.Rows(e.RowIndex).Cells(0).Value) Then

            Return
        Else
            TextBox1.Text = Me.Dg_ClienteNatural.Rows(e.RowIndex).Cells(0).Value()
            txtDNI.Text = Me.Dg_ClienteNatural.Rows(e.RowIndex).Cells(1).Value()
            txtNomNatu.Text = Me.Dg_ClienteNatural.Rows(e.RowIndex).Cells(2).Value()
            txtApeNatu.Text = Me.Dg_ClienteNatural.Rows(e.RowIndex).Cells(3).Value()
            txttelefonoNatu.Text = Me.Dg_ClienteNatural.Rows(e.RowIndex).Cells(4).Value()
            DateTimePicker1.Text = Me.Dg_ClienteNatural.Rows(e.RowIndex).Cells(5).Value()
            txtdieNatu.Text = Me.Dg_ClienteNatural.Rows(e.RowIndex).Cells(6).Value()
            txtemailNatu.Text = Me.Dg_ClienteNatural.Rows(e.RowIndex).Cells(7).Value()
            estado = Me.Dg_ClienteNatural.Rows(e.RowIndex).Cells(8).Value()
            If estado = 1 Then
                RadioButtonActivo.Checked = True
            End If
            If estado = 0 Then
                RadioButtonInactivo.Checked = True
            End If
        End If
    End Sub

    Private Sub Dg_ClienteNatural_CellContentClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_ClienteNatural.CellContentClick

    End Sub

    Private Sub txtemailNatu_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtemailNatu.TextChanged
        If txtemailNatu.Text.StartsWith("") Then
            txtemailNatu.Text = txtemailNatu.Text.Trim
        ElseIf txtemailNatu.Text.EndsWith("") Then
            txtemailNatu.Text = txtemailNatu.Text.Trim + ""
            txtemailNatu.SelectionStart = txtemailNatu.Text.Length
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        limpiar_textos_Natural()
    End Sub

    Private Sub txtbusqueda_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbusqueda.TextChanged
        objentidade.dni = txtbusqueda.Text
        objentidade.Nombre = txtbusqueda.Text
        If buscar = 1 Then
            txtbusqueda.MaxLength = 30
            'objentidade.opcion = 1
            Dg_ClienteNatural.DataSource = objnegocio.BUSCAR_CLIENTE_NATURAL(objentidade)
        End If
        If buscar = 2 Then
            txtbusqueda.MaxLength = 8
            objentidade.opcion = 2
            Dg_ClienteNatural.DataSource = objnegocio.BUSCAR_CLIENTE_NATURAL(objentidade)
        End If
    End Sub

    Private Sub RadioButtonNomComp_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonNomComp.CheckedChanged
        buscar = 1
    End Sub

    Private Sub RadioButtonRuc_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButtonRuc.CheckedChanged
        buscar = 2
    End Sub

    Private Sub TextBoxX1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxX1.TextChanged
        objentidade.ruc = TextBoxX1.Text
        objentidade.RazonSocial = TextBoxX1.Text
        If buscar = 3 Then
            TextBoxX1.MaxLength = 30
            objentidade.opcion = 1
            Dg_ClienteJuridco.DataSource = objnegocio.BUSCAR_CLIENTE_JURIDICO(objentidade)
        End If
        If buscar = 4 Then
            TextBoxX1.MaxLength = 11
            objentidade.opcion = 2
            Dg_ClienteJuridco.DataSource = objnegocio.BUSCAR_CLIENTE_JURIDICO(objentidade)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        buscar = 3
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        buscar = 4
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        If txtruc.Text.Trim = "" Or txtrazonSocial.Text.Trim = "" Or txtnombre.Text.Trim = "" Or txtTelefonoJuri.Text.Trim = "" Then
            MsgBox("DEBES INGRESAR DATOS", MsgBoxStyle.Exclamation, "DATOS VACIOS")
        Else
            If ValidarRuc1() And ValidarTelefono1() And ValidarEmail1() Then
                If v.MensajeModificar() = 6 Then
                    objentidade.idcliente = TextBox2.Text
                    llenarDatosClienteJurdico()
                    objnegocio.MODIFICAR_CLIENTE_JURIDICO(objentidade)
                    Dg_ClienteJuridco.DataSource = objnegocio.MOSTRAR_CLIENTE_JURIDICO(objentidade)
                    limpiar_textos_Natural()
                End If
            End If
        End If
    End Sub

    Private Sub Dg_ClienteJuridco_DataBindingComplete(sender As Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles Dg_ClienteJuridco.DataBindingComplete
        Dim i As Integer
        For i = 0 To Dg_ClienteJuridco.Rows.Count - 2

            If Dg_ClienteJuridco.Item(8, i).Value() = 0 Then
                Dg_ClienteJuridco.Rows(i).DefaultCellStyle.BackColor = Color.Black
                Dg_ClienteJuridco.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub


    Private Sub Dg_ClienteNatural_DataBindingComplete(sender As Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles Dg_ClienteNatural.DataBindingComplete
        Dim i As Integer
        For i = 0 To Dg_ClienteNatural.Rows.Count - 2

            If Dg_ClienteNatural.Item(8, i).Value() = 0 Then
                Dg_ClienteNatural.Rows(i).DefaultCellStyle.BackColor = Color.Black
                Dg_ClienteNatural.Rows(i).DefaultCellStyle.ForeColor = Color.White
            End If
        Next
    End Sub

End Class