Imports CAPA_DATOS
Public Class CpN_Cls_VALIDACIONES
    Function validaletras(ByVal obj) As Boolean
        Dim objdatos As New CAPA_DATOS.CpD_Cls_VALIDACIONES
        Return objdatos.validaLetras(obj)
    End Function
    Function validaNumeros(ByVal obj) As Boolean
        Dim objdatos As New CAPA_DATOS.CpD_Cls_VALIDACIONES
        Return objdatos.validaNumeros(obj)
    End Function

    Function MensajeGuardar()
        Dim objdatos As New CAPA_DATOS.CpD_Cls_VALIDACIONES
        Return objdatos.MensajeGuardar()
    End Function
    Function MensajeModificar()
        Dim objdatos As New CAPA_DATOS.CpD_Cls_VALIDACIONES
        Return objdatos.MensajeModificar()
    End Function
    Function MensajeEliminar()
        Dim objdatos As New CAPA_DATOS.CpD_Cls_VALIDACIONES
        Return objdatos.MensajeEliminar()
    End Function
    Function MensajeImprimir()
        Dim objdatos As New CAPA_DATOS.CpD_Cls_VALIDACIONES
        Return objdatos.MensajeImprimir()
    End Function
End Class
