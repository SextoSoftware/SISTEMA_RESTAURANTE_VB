Imports CAPA_DATOS
Imports CAPA_ENTIDAD
Public Class CpN_Cls_ABASTECER
    Public Sub REGISTRAR_ABASTECER(ByVal obj As CAPA_ENTIDAD.CpE_Cls_ABASTECER)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_ABASTECER
        objdatos.REGISTRAR_ABASTECER(obj)
    End Sub
    Public Sub REGISTRAR_DETALLE_ABASTECER(ByVal obj As CAPA_ENTIDAD.CpE_Cls_ABASTECER)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_ABASTECER
        objdatos.REGISTRAR_DETALLE_ABASTECER(obj)
    End Sub

    Public Sub CAPTURA_CODIGO_ABASTECER(ByVal obj As CAPA_ENTIDAD.CpE_Cls_ABASTECER)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_ABASTECER
        objdatos.CAPTURA_CODIGO_ABASTECER(obj)
    End Sub
    Function MOSTRAR_PRODUCTO_ABASTECE_PROVEEDOR(ByVal obj As CAPA_ENTIDAD.CpE_Cls_ABASTECER)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_ABASTECER
        Return objdatos.MOSTRAR_PRODUCTO_ABASTECE_PROVEEDOR(obj)
    End Function
End Class
