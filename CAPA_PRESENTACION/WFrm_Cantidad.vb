Public Class WFrm_Cantidad
    Inherits DevComponents.DotNetBar.Office2007Form
    Private Sub WFrm_Cantidad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonX4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX4.Click
        If codigoNuevaCantidad = 2 Then
            If NumericUpDown1.Text = "" Then
                MsgBox("LA CANTIDAD NO PUEDE SER NULA", MsgBoxStyle.Critical)
                NumericUpDown1.Text = 1
            Else
                cantidadplato = NumericUpDown1.Text
                WFrm_MENU_DIA.Agregar()
                NumericUpDown1.Text = 1
                codigoNuevaCantidad = 0
                Close()
            End If
        End If

        If codigoNuevaCantidad = 1 Then

            If NumericUpDown1.Text = "" Then
                MsgBox("LA CANTIDAD NO PUEDE SER NULA", MsgBoxStyle.Critical)
                NumericUpDown1.Text = 1
            Else
                Dim menu As New WFrm_MENU_DIA
                If WFrm_MENU_DIA.ListView1.SelectedItems.Count > 0 Then
                    WFrm_MENU_DIA.ListView1.FocusedItem.SubItems(3).Text = NumericUpDown1.Text
                End If
                NumericUpDown1.Text = 1
                codigoNuevaCantidad = 0
                Me.Close()
            End If
        End If


        If codigoNuevaCantidad = 3 Then
            If NumericUpDown1.Text = "" Then
                MsgBox("LA CANTIDAD NO PUEDE SER NULA", MsgBoxStyle.Critical)
                NumericUpDown1.Text = 1
            Else
                cantidadplato = NumericUpDown1.Text
                WFrm_ORDEN_COMPRA.Agregar()
                NumericUpDown1.Text = 1
                codigoNuevaCantidad = 0
                Close()
            End If
        End If

        If codigoNuevaCantidad = 4 Then

            If NumericUpDown1.Text = "" Then
                MsgBox("LA CANTIDAD NO PUEDE SER NULA", MsgBoxStyle.Critical)
                NumericUpDown1.Text = 1
            Else
                Dim menu As New WFrm_MENU_DIA
                If WFrm_ORDEN_COMPRA.ListView1.SelectedItems.Count > 0 Then
                    WFrm_ORDEN_COMPRA.ListView1.FocusedItem.SubItems(4).Text = NumericUpDown1.Text
                End If
                NumericUpDown1.Text = 1
                codigoNuevaCantidad = 0
                Me.Close()
            End If
        End If
    End Sub
End Class