Public Class CpD_Cls_VALIDACIONES
    Public respuesta As Integer
    Public Function validaLetras(ByVal e) As Boolean
        Dim valor As Boolean
        If Char.IsLetter(e.KeyChar) Then
            valor = False
        ElseIf Char.IsControl(e.KeyChar) Then
            valor = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            valor = False
        Else
            valor = True
        End If
        Return valor
    End Function
    Public Function validaNumeros(ByVal e) As Boolean
        Dim valor As Boolean
        If Char.IsDigit(e.KeyChar) Then
            valor = False
        ElseIf Char.IsControl(e.KeyChar) Then
            valor = False
        Else
            valor = True
        End If
        Return valor
    End Function


    Public Function MensajeGuardar()
        respuesta = MsgBox("DESEA GUARDAR LOS DATOS INGRESADOS", MsgBoxStyle.YesNo, "ESTA SEGURO ?")
        If respuesta = MsgBoxResult.Yes Then
            ' MsgBox("DATOS GUARDADOS CORRECTAMENTE", MsgBoxStyle.Information)
        Else
        End If
        Return respuesta
    End Function

    Public Function MensajeModificar()
        respuesta = MsgBox("DESEA MODIFICAR LOS DATOS INGRESADOS", MsgBoxStyle.YesNo, "ESTA SEGURO ?")
        If respuesta = MsgBoxResult.Yes Then
            '  MsgBox("DATOS MODFICADOS CORRECTAMENTE", MsgBoxStyle.Information)
        Else
        End If
        Return respuesta
    End Function
    Public Function MensajeEliminar()
        respuesta = MsgBox("DESEA ELIMINAR LA FILA SELECCIONADA", MsgBoxStyle.YesNo, "ESTA SEGURO ?")
        If respuesta = MsgBoxResult.Yes Then
            ' MsgBox("DATOS ELIMINADOS CORRECTAMENTE", MsgBoxStyle.Information)
        Else
        End If
        Return respuesta
    End Function

    Public Function MensajeImprimir()
        respuesta = MsgBox("DESEA IMPRIMIR DOCUMENTO", MsgBoxStyle.YesNo, "ESTA SEGURO ?")
        If respuesta = MsgBoxResult.Yes Then
            ' MsgBox("DATOS ELIMINADOS CORRECTAMENTE", MsgBoxStyle.Information)
        Else
        End If
        Return respuesta
    End Function
End Class
