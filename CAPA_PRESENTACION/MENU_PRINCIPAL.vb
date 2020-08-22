Public Class MENU_PRINCIPAL
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub MENU_PRINCIPAL_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LabelItem1.Text = "   USUARIO CONECTADO - BIENVENDO AL SISTEMA  " + tipo_usuario + "  " + usuario

        If tipo_usuario = "ADMINISTRADOR  " Then
            ' bubbleButton7.Enabled = False
            My.Forms.WFrm_DISEÑO_MESAS.MdiParent = Me

            My.Forms.WFrm_DISEÑO_MESAS.Show()
        End If
        If tipo_usuario = "MESERO         " Then
            'bubbleButton7.Enabled = False
            BubbleButton22.Enabled = False
            bubbleButton8.Enabled = False
            bubbleButton6.Enabled = False
            bubbleButton11.Enabled = False
            bubbleButton15.Enabled = False
            BubbleButton3.Enabled = False
            BubbleButton23.Enabled = False
            BubbleButton27.Enabled = False
            buttonItem6.Enabled = False
            ButtonItem3.Enabled = False
            ' ButtonItem19.Enabled = False
            buttonItem7.Enabled = False
            ButtonItem9.Enabled = False
            ButtonItem10.Enabled = False
            ButtonItem16.Enabled = False
            ButtonItem15.Enabled = False
            ButtonItem12.Enabled = False
            '  bubbleButton10.Enabled = False

            My.Forms.WFrm_DISEÑO_MESAS.MdiParent = Me

            My.Forms.WFrm_DISEÑO_MESAS.Show()

        End If
        If tipo_usuario = "JEFE DE ALMACEN" Then
            BubbleButton3.Enabled = False
            BubbleButton23.Enabled = False
            bubbleButton7.Enabled = False

            BubbleButton21.Enabled = False
            bubbleButton5.Enabled = False

            bubbleButton1.Enabled = False
            BubbleButton20.Enabled = False
            bubbleButton9.Enabled = False
            bubbleButton12.Enabled = False
            bubbleButton13.Enabled = False

            buttonItem6.Enabled = False
            ButtonItem8.Enabled = False
            ButtonItem18.Enabled = False
            ButtonItem17.Enabled = False
            buttonItem4.Enabled = False
            buttonItem5.Enabled = False
            ButtonItem3.Enabled = False
            ButtonItem10.Enabled = False
            ButtonItem11.Enabled = False
            ButtonItem14.Enabled = False
        End If


      
    End Sub

    Public Sub AbrirVentana_Reporte_MenuDia()
        My.Forms.WFrm_REPORTE_MENU_DIA.MdiParent = Me

        My.Forms.WFrm_REPORTE_MENU_DIA.Show()
    End Sub
    Public Sub AbrirVentana_Buscar_Proveedor()
        My.Forms.WFrm_BuscarProveedor.MdiParent = Me

        My.Forms.WFrm_BuscarProveedor.Show()
    End Sub

    Public Sub AbrirVentana_Reporte_OrdenCompra()
        My.Forms.WFrm_REPORTE_ORDEN_COMPRA.MdiParent = Me

        My.Forms.WFrm_REPORTE_ORDEN_COMPRA.Show()
    End Sub

    Public Sub AbrirVentana_Reporte_Comanda()
        My.Forms.WFrm_REPORTE_COMANDAS.MdiParent = Me

        My.Forms.WFrm_REPORTE_COMANDAS.Show()
    End Sub
    Public Sub AbrirVentana_Reporte_Boleta()
        My.Forms.WFrm_REPORTE_BOLETAS.MdiParent = Me

        My.Forms.WFrm_REPORTE_BOLETAS.Show()
    End Sub

    Public Sub AbrirVentana_COMANDA()
        My.Forms.WFrm_COMANDA.MdiParent = Me

        My.Forms.WFrm_COMANDA.Show()
    End Sub
    Private Sub bubbleButton4_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs)
        AbrirVentanaListadoMenuDia()
    End Sub
    Public Sub AbrirVentanaListadoMenuDia()
        My.Forms.WFrm_MENU_DIA_LISTADO.MdiParent = Me

        My.Forms.WFrm_MENU_DIA_LISTADO.Show()
    End Sub

    Private Sub buttonSilverScheme_Click(sender As System.Object, e As System.EventArgs) Handles buttonSilverScheme.Click
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver

    End Sub

    Private Sub buttonBlueScheme_Click(sender As System.Object, e As System.EventArgs) Handles buttonBlueScheme.Click
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue
    End Sub

    Private Sub ButtonItem13_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem13.Click
        Me.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black
    End Sub

    Private Sub bar1_ItemClick(sender As System.Object, e As System.EventArgs) Handles bar1.ItemClick
        If ComboBoxItem1.SelectedIndex = 1 Then
            For Each ctrl As Control In Me.Controls
                ctrl.Enabled = False
            Next
            TextBoxItem1.Visible = False
            ButtonItem1.Visible = False
        End If

        If ComboBoxItem1.SelectedIndex = 0 Then
            If bubbleBar1.Enabled = False Then
                TextBoxItem1.Visible = True
                ButtonItem1.Visible = True
                TextBoxItem1.Focus()

            End If
        End If
        If ComboBoxItem1.SelectedIndex = 2 Then
            Close()

            My.Forms.INICIAR_SECCION.Show()
            Me.Hide()
        End If
        bar1.Enabled = True




    End Sub

    Private Sub ButtonItem1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem1.Click
        If contra = TextBoxItem1.Text Then
            TextBoxItem1.Visible = False
            ButtonItem1.Visible = False
            For Each ctrl As Control In Me.Controls
                ctrl.Enabled = True
            Next
            TextBoxItem1.Text = ""
        Else
            MsgBox("CONTRASÑA INCORRECTA ", MsgBoxStyle.Critical, "ERRROR")
            TextBoxItem1.Text = ""
            TextBoxItem1.Focus()
        End If
    End Sub

    Private Sub bubbleButton1_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton1.Click
        AbrirVentana_DISEÑO_MESAS()
    End Sub

    Private Sub bubbleButton10_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs)

    End Sub

    Private Sub bubbleButton7_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs)
        My.Forms.WFrm_USUARIO.MdiParent = Me

        My.Forms.WFrm_USUARIO.Show()
    End Sub

    Private Sub bubbleButton2_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs)
        AbrirVentana_DISEÑO_MESAS()
    End Sub
    Public Sub AbrirVentana_DISEÑO_MESAS()
        My.Forms.WFrm_DISEÑO_MESAS.MdiParent = Me

        My.Forms.WFrm_DISEÑO_MESAS.Show()

    End Sub
    Private Sub bubbleBar1_ButtonClick(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleBar1.ButtonClick

    End Sub

    Private Sub bubbleButton5_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton5.Click
        My.Forms.WFrm_CATEGORIA_PLATO.MdiParent = Me

        My.Forms.WFrm_CATEGORIA_PLATO.Show()
    End Sub
    Public Sub AbrirVentana_MENU_DIA()
        My.Forms.WFrm_MENU_DIA.MdiParent = Me

        My.Forms.WFrm_MENU_DIA.Show()
    End Sub


    Private Sub bubbleButton8_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton8.Click
        My.Forms.WFrm_PRODUCTO.MdiParent = Me

        My.Forms.WFrm_PRODUCTO.Show()
    End Sub

    Private Sub bubbleButton9_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton9.Click
        My.Forms.WFrm_CLIENTE.MdiParent = Me

        My.Forms.WFrm_CLIENTE.Show()
    End Sub

    Private Sub bubbleButton6_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton6.Click
        My.Forms.WFrm_PROVEEDOR.MdiParent = Me

        My.Forms.WFrm_PROVEEDOR.Show()
    End Sub

    Private Sub BubbleButton20_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton20.Click
        My.Forms.WFrm_Mesa.MdiParent = Me

        My.Forms.WFrm_Mesa.Show()
    End Sub

    Private Sub BubbleButton21_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs)
        My.Forms.WFrm_CATEGORIA_PLATO.MdiParent = Me

        My.Forms.WFrm_CATEGORIA_PLATO.Show()
    End Sub

    Private Sub ButtonItem2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem2.Click
      
        Process.Start("http://localhost:5864/WEB_RESTAURANTE/Default.aspx")

    End Sub

    Private Sub BubbleButton21_Click_1(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton21.Click
        My.Forms.WFrm_PLATO.MdiParent = Me

        My.Forms.WFrm_PLATO.Show()
    End Sub

    Private Sub BubbleButton22_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton22.Click
        My.Forms.WFrm_TIPOPRODCUTO.MdiParent = Me

        My.Forms.WFrm_TIPOPRODCUTO.Show()
    End Sub

    Private Sub BubbleButton24_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs)
        My.Forms.WFrm_REPORTE_STOCK_PRODUCTO.MdiParent = Me

        My.Forms.WFrm_REPORTE_STOCK_PRODUCTO.Show()
    End Sub

    Private Sub BubbleButton23_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton23.Click
        My.Forms.WFrm_REPORTE_TOP_PRODUCTOS_VEN.MdiParent = Me

        My.Forms.WFrm_REPORTE_TOP_PRODUCTOS_VEN.Show()
    End Sub

    Private Sub bubbleButton13_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton13.Click
        AbrirVentana_MENU_DIA()

    End Sub

    Private Sub bubbleButton12_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton12.Click
        AbrirVentanaListadoMenuDia()
    End Sub

    Private Sub bubbleButton15_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton15.Click
        My.Forms.WFrm_ABASTECER.MdiParent = Me

        My.Forms.WFrm_ABASTECER.Show()
    End Sub

    Private Sub bubbleButton11_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton11.Click
        My.Forms.WFrm_ORDEN_COMPRA.MdiParent = Me

        My.Forms.WFrm_ORDEN_COMPRA.Show()

    End Sub

    Private Sub BubbleButton3_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton3.Click
        My.Forms.WFrm_REPORTE_VENTAS_FECHAS.MdiParent = Me

        My.Forms.WFrm_REPORTE_VENTAS_FECHAS.Show()

    End Sub

    Private Sub ButtonItem3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem3.Click
        My.Forms.WFrm_USUARIO.MdiParent = Me

        My.Forms.WFrm_USUARIO.Show()
    End Sub

    Private Sub ButtonItem11_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem11.Click
        My.Forms.WFrm_CATEGORIA_PLATO.MdiParent = Me

        My.Forms.WFrm_CATEGORIA_PLATO.Show()
    End Sub

    Private Sub ButtonItem14_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem14.Click
        My.Forms.WFrm_PLATO.MdiParent = Me

        My.Forms.WFrm_PLATO.Show()
    End Sub

    Private Sub ButtonItem12_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem12.Click
        My.Forms.WFrm_TIPOPRODCUTO.MdiParent = Me

        My.Forms.WFrm_TIPOPRODCUTO.Show()
    End Sub

    Private Sub ButtonItem15_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem15.Click
        My.Forms.WFrm_PRODUCTO.MdiParent = Me

        My.Forms.WFrm_PRODUCTO.Show()
    End Sub

    Private Sub ButtonItem16_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem16.Click
        My.Forms.WFrm_PROVEEDOR.MdiParent = Me

        My.Forms.WFrm_PROVEEDOR.Show()
    End Sub

    Private Sub ButtonItem18_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem18.Click

        My.Forms.WFrm_Mesa.Close()
        My.Forms.WFrm_Mesa.MdiParent = Me
        My.Forms.WFrm_Mesa.Show()
    End Sub

    Private Sub buttonItem6_Click(sender As System.Object, e As System.EventArgs) Handles buttonItem6.Click
        AbrirVentana_DISEÑO_MESAS()
    End Sub

    Private Sub ButtonItem17_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem17.Click
        My.Forms.WFrm_CLIENTE.MdiParent = Me

        My.Forms.WFrm_CLIENTE.Show()
    End Sub

    Private Sub buttonItem4_Click(sender As System.Object, e As System.EventArgs) Handles buttonItem4.Click
        AbrirVentanaListadoMenuDia()
    End Sub

    Private Sub buttonItem5_Click(sender As System.Object, e As System.EventArgs) Handles buttonItem5.Click
        AbrirVentanaListadoMenuDia()
    End Sub

    Private Sub buttonItem7_Click(sender As System.Object, e As System.EventArgs) Handles buttonItem7.Click
        My.Forms.WFrm_ORDEN_COMPRA.MdiParent = Me

        My.Forms.WFrm_ORDEN_COMPRA.Show()
    End Sub

    Private Sub ButtonItem19_Click(sender As System.Object, e As System.EventArgs)
        My.Forms.WFrm_ABASTECER.MdiParent = Me

        My.Forms.WFrm_ABASTECER.Show()
    End Sub

    Private Sub ButtonItem8_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem8.Click
        My.Forms.WFrm_REPORTE_VENTAS_FECHAS.MdiParent = Me

        My.Forms.WFrm_REPORTE_VENTAS_FECHAS.Show()
    End Sub

    Private Sub ButtonItem9_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem9.Click
        My.Forms.WFrm_REPORTE_STOCK_PRODUCTO.MdiParent = Me

        My.Forms.WFrm_REPORTE_STOCK_PRODUCTO.Show()
    End Sub

    Private Sub ButtonItem10_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem10.Click
        My.Forms.WFrm_REPORTE_TOP_PRODUCTOS_VEN.MdiParent = Me

        My.Forms.WFrm_REPORTE_TOP_PRODUCTOS_VEN.Show()
    End Sub

    Private Sub LabelItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelItem1.Click

    End Sub

    Private Sub ComboBoxItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxItem1.Click

    End Sub

    Private Sub BubbleButton4_Click_1(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton4.Click
        My.Forms.WFrm_MOZO.MdiParent = Me

        My.Forms.WFrm_MOZO.Show()
    End Sub

    Private Sub BubbleButton17_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton17.Click
        My.Forms.WFrm_REPORTE_VENTAS_FECHAS_DETALLE.MdiParent = Me

        My.Forms.WFrm_REPORTE_VENTAS_FECHAS_DETALLE.Show()
    End Sub

   

  

    Private Sub BubbleButton28_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton28.Click
        My.Forms.WFrm_REPORTE_VENTAS_DETALLE_ESTADO.MdiParent = Me

        My.Forms.WFrm_REPORTE_VENTAS_DETALLE_ESTADO.Show()
    End Sub

    Private Sub BubbleButton29_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton29.Click
        My.Forms.WFrm_REPORTE_TOP_PRODUCTO_GRAFICO.MdiParent = Me

        My.Forms.WFrm_REPORTE_TOP_PRODUCTO_GRAFICO.Show()
    End Sub

    Private Sub BubbleButton27_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton27.Click
        My.Forms.WFrm_USUARIO.MdiParent = Me

        My.Forms.WFrm_USUARIO.Show()
    End Sub

    Private Sub ButtonItem19_Click_1(sender As System.Object, e As System.EventArgs) Handles ButtonItem19.Click
        My.Forms.WFrm_MOZO.Close()
        My.Forms.WFrm_MOZO.MdiParent = Me
        My.Forms.WFrm_MOZO.Show()
    End Sub

    Private Sub ButtonItem21_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem21.Click
        My.Forms.WFrm_REPORTE_PRODUCTO.Close()
        My.Forms.WFrm_REPORTE_PRODUCTO.MdiParent = Me
        My.Forms.WFrm_REPORTE_PRODUCTO.Show()
    End Sub

    Private Sub ButtonItem22_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem22.Click
        My.Forms.WFrm_REPORTE_VENTAS_FECHAS_DETALLE.Close()
        My.Forms.WFrm_REPORTE_VENTAS_FECHAS_DETALLE.MdiParent = Me
        My.Forms.WFrm_REPORTE_VENTAS_FECHAS_DETALLE.Show()
    End Sub

    Private Sub ButtonItem23_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem23.Click
        My.Forms.WFrm_REPORTE_VENTAS_DETALLE_ESTADO.Close()
        My.Forms.WFrm_REPORTE_VENTAS_DETALLE_ESTADO.MdiParent = Me
        My.Forms.WFrm_REPORTE_VENTAS_DETALLE_ESTADO.Show()
    End Sub

    Private Sub ButtonItem25_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem25.Click
        My.Forms.WFrm_REPORTE_TOP_PRODUCTO_GRAFICO.Close()
        My.Forms.WFrm_REPORTE_TOP_PRODUCTO_GRAFICO.MdiParent = Me
        My.Forms.WFrm_REPORTE_TOP_PRODUCTO_GRAFICO.Show()
    End Sub

    Private Sub ButtonItem27_Click(sender As System.Object, e As System.EventArgs)
        My.Forms.WFrm_REPORTE_VENTA_DIA_GRAFICO.Close()
        My.Forms.WFrm_REPORTE_VENTA_DIA_GRAFICO.MdiParent = Me
        My.Forms.WFrm_REPORTE_VENTA_DIA_GRAFICO.Show()
    End Sub

    Private Sub ButtonItem27_Click_1(sender As System.Object, e As System.EventArgs) Handles ButtonItem27.Click
        My.Forms.WFrm_REPORTE_VENTA_DIA_GRAFICO.Close()
        My.Forms.WFrm_REPORTE_VENTA_DIA_GRAFICO.MdiParent = Me
        My.Forms.WFrm_REPORTE_VENTA_DIA_GRAFICO.Show()
    End Sub

    Private Sub ButtonItem28_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem28.Click
        My.Forms.Wfrm_INGREDIENTES.Close()
        My.Forms.Wfrm_INGREDIENTES.MdiParent = Me
        My.Forms.Wfrm_INGREDIENTES.Show()
    End Sub
End Class