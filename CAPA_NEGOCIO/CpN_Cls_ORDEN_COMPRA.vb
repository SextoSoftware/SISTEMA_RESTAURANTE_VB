Imports CAPA_DATOS
Imports CAPA_ENTIDAD
Public Class CpN_Cls_ORDEN_COMPRA
    Public Sub REGISTRAR_ORDEN_COMPRA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_ORDEN_COMPRA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_ORDEN_COMPRA
        objdatos.REGISTRAR_ORDEN_COMPRA(obj)
    End Sub
    Public Sub REGISTRAR_DETALLE_ORDEN_COMPRA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_ORDEN_COMPRA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_ORDEN_COMPRA
        objdatos.REGISTRAR_DETALLE_ORDEN_COMPRA(obj)
    End Sub
    Public Sub CAPTURA_CODIGO_ORDEN_COMPRA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_ORDEN_COMPRA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_ORDEN_COMPRA
        objdatos.CAPTURA_CODIGO_ORDEN_COMPRA(obj)
    End Sub
End Class
