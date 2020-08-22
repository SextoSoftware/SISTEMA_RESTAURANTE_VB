Imports CAPA_NEGOCIO
Imports CAPA_ENTIDAD
Public Class INICIAR_SECCION
    Public variable As String
    Public objnegocio As New CAPA_NEGOCIO.CpNCls_USUARIO
    Public objentidade As New CAPA_ENTIDAD.CpECls_USUARIO
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Dim CONT As Integer
    Private Sub INICIAR_SECCION_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '   If My.Settings.ReUsu = 1 Then
        'textBoxX1.Text = My.Settings.Usuario
        '    CheckBox1.Checked = True
        '   End If
        '   If My.Settings.ReCon = 1 Then
        ''textBoxX2.Text = My.Settings.Contra
        '   CheckBox2.Checked = True
        '  End If
    End Sub
    Private Sub INICIAR_SECCION_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        '   ex = e.X
        '   ey = e.Y
        '  Arrastre = True
    End Sub

    Private Sub INICIAR_SECCION_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        '    If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub INICIAR_SECCION_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        ' Arrastre = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '   If CheckBox1.Checked = True Then
        'My.Settings.Usuario = textBoxX1.Text
        '   My.Settings.ReUsu = 1
        '   My.Settings.Save()
        '   End If
        '   If CheckBox1.Checked = False Then
        'My.Settings.Usuario = ""
        ' My.Settings.ReUsu = 0
        '  My.Settings.Save()
        '  End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  If CheckBox2.Checked = True Then
        'My.Settings.Contra = textBoxX2.Text
        '   My.Settings.ReCon = 1
        '    My.Settings.Save()
        '   End If
        '  If CheckBox2.Checked = False Then
        ' 'My.Settings.Contra = ""
        '  My.Settings.ReCon = 0
        '  My.Settings.Save()
        ' End If
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
                MsgBox("*** BIENVENIDO AL SISTEMA " + Me.textBoxX1.Text + " ***", MsgBoxStyle.Information, "MESERO")
                ' GuardaNombre = "BIENVENIDO CLIENTE " + TextBox1.Text
                My.Forms.MENU_PRINCIPAL.Show()
                Me.Hide()
            End If
            If objentidade.NomTipo = "MESERO         " Then
                MsgBox("*** BIENVENIDO AL SISTEMA " + Me.textBoxX1.Text + " ***", MsgBoxStyle.Information, "JEFE DE BODEGA")
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