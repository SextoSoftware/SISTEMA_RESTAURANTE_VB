Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Public Class Login
    Public variable As String
    Public objnegocio As New CAPA_NEGOCIO.CpNCls_USUARIO
    Public objentidade As New CAPA_ENTIDAD.CpECls_USUARIO
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Dim CONT As Integer
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRegistrar.Click
        objentidade.usu = Me.textBoxX1.Text
        objentidade.cla = Me.textBoxX2.Text
        If (objnegocio.Logeo(objentidade.usu = Me.textBoxX1.Text, objentidade.cla = Me.textBoxX2.Text, objentidade)) Then
            objentidade.usu = Me.textBoxX1.Text
            objnegocio.CapturarNombreTipo(objentidade)
            usuario = textBoxX1.Text
            contra = textBoxX2.Text
            tipo_usuario = objentidade.NomTipo
            If objentidade.NomTipo = "ADMINISTRADOR  " Then
                MsgBox("*** BIENVENIDO AL SISTEMA " + Me.textBoxX1.Text + " ***", MsgBoxStyle.Information, "ADMINISTRADOR")
                ' GuardaNombre = "BIENVENIDO CLIENTE " + TextBox1.Text
                My.Forms.MENU_PRINCIPAL.Show()
                Me.Hide()
            End If
            If objentidade.NomTipo = "MESERO         " Then
                MsgBox("*** BIENVENIDO AL SISTEMA " + Me.textBoxX1.Text + " ***", MsgBoxStyle.Information, "MESERO/A")
                ' GuardaNombre = "BIENVENIDO CLIENTE " + TextBox1.Text
                My.Forms.MENU_PRINCIPAL.Show()
                Me.Hide()
            End If
            If objentidade.NomTipo = "JEFE DE ALMACEN" Then
                MsgBox("*** BIENVENIDO AL SISTEMA " + Me.textBoxX1.Text + " ***", MsgBoxStyle.Information, "JEFE DE ALMACEN")
                ' GuardaNombre = "BIENVENIDO CLIENTE " + TextBox1.Text
                My.Forms.MENU_PRINCIPAL.Show()
                Me.Hide()
            End If
        Else
            MsgBox(" LOGIN INCORRECTO ", MsgBoxStyle.Critical, "ERRROR")
            Me.textBoxX1.Text = ""
            Me.textBoxX2.Text = ""
            Me.textBoxX1.Focus()
            CONT = CONT + 1
        End If

        If CONT = 3 Then
            Close()

        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Close()

    End Sub
End Class