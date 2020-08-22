Public Class WFrm_Cantidad_Notas
    Inherits DevComponents.DotNetBar.Office2007Form
    Public objnegocio2 As New CAPA_NEGOCIO.CpN_Cls_PRODUCTO
    Public objentidade2 As New CAPA_ENTIDAD.CpE_Cls_PRODUCTO
    Public objnegocio As New CAPA_NEGOCIO.CpN_Cls_PLATO
    Public objentidade As New CAPA_ENTIDAD.CpE_Cls_PLATO
    Private Sub WFrm_Cantidad_Notas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        NumericUpDown1.Text = WFrm_COMANDA.ListView1.FocusedItem.SubItems(2).Text
        Me.TextBox1.Text = WFrm_COMANDA.ListView1.FocusedItem.SubItems(5).Text
    End Sub

    Private Sub ButtonX4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX4.Click
        objentidade2.idproducto = WFrm_COMANDA.ListView1.FocusedItem.SubItems(0).Text
        objentidade.idplato = WFrm_COMANDA.ListView1.FocusedItem.SubItems(0).Text
        Dim z, STOCK As Integer
        For z = 0 To WFrm_COMANDA.Dg_productos.RowCount - 2
            If objentidade2.idproducto = WFrm_COMANDA.Dg_productos.Rows.Item(z).Cells(0).Value Then
                STOCK = WFrm_COMANDA.Dg_productos.Rows.Item(z).Cells(3).Value
            End If
        Next

        For z = 0 To WFrm_COMANDA.dgplatos.RowCount - 2
            If objentidade.idplato = WFrm_COMANDA.dgplatos.Rows.Item(z).Cells(0).Value Then
                STOCK = WFrm_COMANDA.dgplatos.Rows.Item(z).Cells(2).Value
            End If
        Next


        If NumericUpDown1.Text = "" Then
            MsgBox("LA CANTIDAD NO PUEDE SER NULA", MsgBoxStyle.Critical)
            NumericUpDown1.Text = 1
        Else
            If TextBox1.Text = "" Then
                If WFrm_COMANDA.ListView1.SelectedItems.Count > 0 Then

                    If STOCK >= NumericUpDown1.Text Then
                        WFrm_COMANDA.ListView1.FocusedItem.SubItems(2).Text = NumericUpDown1.Text
                        WFrm_COMANDA.ListView1.FocusedItem.SubItems(4).Text = WFrm_COMANDA.ListView1.FocusedItem.SubItems(2).Text * WFrm_COMANDA.ListView1.FocusedItem.SubItems(3).Text
                        WFrm_COMANDA.ActualizaMonto()
                        Me.Close()
                    Else
                        MsgBox("CANTIDAD NO PERMITIDA EN EL STOCK", MsgBoxStyle.Exclamation)
                    End If
                End If
            Else
                WFrm_COMANDA.ListView1.FocusedItem.SubItems(5).Text = TextBox1.Text
                Me.Close()
            End If

            NumericUpDown1.Text = 1
            codigoNuevaCantidad = 0

            End If



    End Sub
End Class