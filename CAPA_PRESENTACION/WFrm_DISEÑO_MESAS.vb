Public Class WFrm_DISEÑO_MESAS
    Inherits DevComponents.DotNetBar.Office2007Form

    Private Sub WFrm_DISEÑO_MESAS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        actualiza_panel_mesas()
        Cargar_Mesas_Ocupadas()
        ButtonX20.Text = contar - contaocupado

        '  ButtonX23.Text = 20 - contar

        Label6.Text = Format(Now, "MMM,d,yyyy").ToUpper
        Cargar_Mesas_Ocupadas()
        'Label4.Text = contaocupado
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label5.Text = Date.Now.ToLongTimeString

      
        HORARIO()


       


            '  Dim final As String = Now.ToString("HH:mm:ss")
            '   Dim inicial As String = "14:42:07"
            '  Dim tiempoI As TimeSpan = TimeSpan.Parse(inicial)
            '  Dim tiempoF As TimeSpan = TimeSpan.Parse(final)
            '  Dim resta As TimeSpan = tiempoF - tiempoI
            '  H1.Text = resta.ToString

    End Sub

    Public Sub obtenerDatosComanda()
        DataGridView1.DataSource = objnegocio.MOSTRAR_ACTIVAS_OCUPADAS(objentidade)
        Dim tipo As Integer
        Dim estadoComanda As String
        For z = 0 To DataGridView1.RowCount - 2
            If NombreMesa = DataGridView1.Rows.Item(z).Cells(0).Value Then
                WFrm_COMANDA.TextBox1.Text = DataGridView1.Rows.Item(z).Cells(1).Value
                WFrm_COMANDA.DateTimePicker2.Text = DataGridView1.Rows.Item(z).Cells(2).Value
                estadoComanda = DataGridView1.Rows.Item(z).Cells(3).Value
                WFrm_COMANDA.txtdescuentos.Text = DataGridView1.Rows.Item(z).Cells(4).Value
                WFrm_COMANDA.txtmonto.Text = DataGridView1.Rows.Item(z).Cells(5).Value
                WFrm_COMANDA.txtdescripcion.Text = Convert.ToString(DataGridView1.Rows.Item(z).Cells(6).Value)
                tipo = DataGridView1.Rows.Item(z).Cells(8).Value
                WFrm_COMANDA.txtidcliente.Text = DataGridView1.Rows.Item(z).Cells(9).Value
                WFrm_COMANDA.txtdnruc.Text = Convert.ToString(DataGridView1.Rows.Item(z).Cells(10).Value)
                WFrm_COMANDA.txtnom.Text = Convert.ToString(DataGridView1.Rows.Item(z).Cells(11).Value)
                WFrm_COMANDA.txtidmoz.Text = Convert.ToString(DataGridView1.Rows.Item(z).Cells(12).Value)
                WFrm_COMANDA.TextBoxX2.Text = Convert.ToString(DataGridView1.Rows.Item(z).Cells(12).Value)
                WFrm_COMANDA.Label11.Text = Convert.ToString(DataGridView1.Rows.Item(z).Cells(13).Value)
                If tipo = 1 Then
                    WFrm_COMANDA.RadioButton2.Checked = True
                End If
                If tipo = 2 Then
                    WFrm_COMANDA.RadioButton1.Checked = True

                End If
                WFrm_COMANDA.ButtonRegistrar.Enabled = False
                WFrm_COMANDA.ButttonModificar.Enabled = True
                WFrm_COMANDA.ButtonCobrar.Enabled = True
                WFrm_COMANDA.ButtonNuevo.Enabled = True
                WFrm_COMANDA.ListarListview()
            End If
        Next
       
    End Sub


    Private Sub bm1_Click(sender As Object, e As System.EventArgs) Handles bm1.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm1.Text
        nombrebutton = bm1.Name
        WFrm_COMANDA.NombreMesaActivo()

        obtenerDatosComanda()
    End Sub

    Private Sub bm2_Click(sender As System.Object, e As System.EventArgs) Handles bm2.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm2.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm3_Click(sender As System.Object, e As System.EventArgs) Handles bm3.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm3.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm4_Click(sender As System.Object, e As System.EventArgs) Handles bm4.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm4.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm5_Click(sender As System.Object, e As System.EventArgs) Handles bm5.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm5.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm6_Click(sender As System.Object, e As System.EventArgs) Handles bm6.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm6.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm7_Click(sender As System.Object, e As System.EventArgs) Handles bm7.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm7.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm8_Click(sender As System.Object, e As System.EventArgs) Handles bm8.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm8.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm9_Click(sender As System.Object, e As System.EventArgs) Handles bm9.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm9.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm10_Click(sender As System.Object, e As System.EventArgs) Handles bm10.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm10.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs)
        a()

    End Sub
    Public Sub a()
        actualiza_panel_mesas()
        ButtonX20.Text = contar
        ' ButtonX23.Text = 20 - contar

        Label6.Text = Format(Now, "MMM,d,yyyy").ToUpper
        obtenerDatosComanda()
        Cargar_Mesas_Ocupadas()
        obtenerDatosComanda()
    End Sub


    Private Sub bm11_Click(sender As System.Object, e As System.EventArgs) Handles bm11.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm11.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm12_Click(sender As System.Object, e As System.EventArgs) Handles bm12.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm12.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm13_Click(sender As System.Object, e As System.EventArgs) Handles bm13.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm13.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm14_Click(sender As System.Object, e As System.EventArgs) Handles bm14.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm14.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm15_Click(sender As System.Object, e As System.EventArgs) Handles bm15.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm15.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm16_Click(sender As System.Object, e As System.EventArgs) Handles bm16.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm16.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm17_Click(sender As System.Object, e As System.EventArgs) Handles bm17.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm17.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm18_Click(sender As System.Object, e As System.EventArgs) Handles bm18.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm18.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm19_Click(sender As System.Object, e As System.EventArgs) Handles bm19.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm19.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm20_Click(sender As System.Object, e As System.EventArgs) Handles bm20.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm20.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm21_Click(sender As System.Object, e As System.EventArgs) Handles bm21.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm21.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm22_Click(sender As System.Object, e As System.EventArgs) Handles bm22.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm22.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm23_Click(sender As System.Object, e As System.EventArgs) Handles bm23.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm23.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm24_Click(sender As System.Object, e As System.EventArgs) Handles bm24.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm24.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm25_Click(sender As System.Object, e As System.EventArgs) Handles bm25.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm25.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm26_Click(sender As System.Object, e As System.EventArgs) Handles bm26.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm26.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm27_Click(sender As System.Object, e As System.EventArgs) Handles bm27.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm27.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm28_Click(sender As System.Object, e As System.EventArgs) Handles bm28.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm28.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm29_Click(sender As System.Object, e As System.EventArgs) Handles bm29.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm29.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm30_Click(sender As System.Object, e As System.EventArgs) Handles bm30.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm30.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm31_Click(sender As System.Object, e As System.EventArgs) Handles bm31.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm31.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm32_Click(sender As System.Object, e As System.EventArgs) Handles bm32.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm32.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm33_Click(sender As System.Object, e As System.EventArgs) Handles bm33.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm33.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm34_Click(sender As System.Object, e As System.EventArgs) Handles bm34.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm34.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm35_Click(sender As System.Object, e As System.EventArgs) Handles bm35.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm35.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm36_Click(sender As System.Object, e As System.EventArgs) Handles bm36.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm36.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm37_Click(sender As System.Object, e As System.EventArgs) Handles bm37.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm37.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm38_Click(sender As System.Object, e As System.EventArgs) Handles bm38.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm38.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm39_Click(sender As System.Object, e As System.EventArgs) Handles bm39.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm39.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm40_Click(sender As System.Object, e As System.EventArgs) Handles bm40.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm40.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm41_Click(sender As System.Object, e As System.EventArgs) Handles bm41.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm41.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm42_Click(sender As System.Object, e As System.EventArgs) Handles bm42.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm42.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm43_Click(sender As System.Object, e As System.EventArgs) Handles bm43.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm43.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm44_Click(sender As System.Object, e As System.EventArgs) Handles bm44.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm44.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm45_Click(sender As System.Object, e As System.EventArgs) Handles bm45.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm45.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm46_Click(sender As System.Object, e As System.EventArgs) Handles bm46.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm46.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm47_Click(sender As System.Object, e As System.EventArgs) Handles bm47.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm47.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm48_Click(sender As System.Object, e As System.EventArgs) Handles bm48.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm48.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles bm49.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm49.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub bm50_Click(sender As System.Object, e As System.EventArgs) Handles bm50.Click
        My.Forms.MENU_PRINCIPAL.AbrirVentana_COMANDA()
        NombreMesa = bm50.Text
        WFrm_COMANDA.NombreMesaActivo()
        obtenerDatosComanda()
    End Sub

    Private Sub groupPanel1_Click(sender As System.Object, e As System.EventArgs) Handles groupPanel1.Click

    End Sub
End Class