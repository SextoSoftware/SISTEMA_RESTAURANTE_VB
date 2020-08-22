Imports CAPA_DATOS
Imports CAPA_ENTIDAD
Public Class CpN_Cls_MOZO
    Function MOSTRAR_MOZO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MOZO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MOZO
        Return objdatos.MOSTRAR_mozo(obj)
    End Function
    Function MOSTRAR_MOZO_ESTADO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MOZO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MOZO
        Return objdatos.MOSTRAR_mozo_ESTADO(obj)
    End Function

    Public Sub REGISTRAR_MOZO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MOZO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MOZO
        objdatos.REGISTRAR_mozo(obj)
    End Sub
    Public Sub MODIFICAR_MOZO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MOZO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MOZO
        objdatos.MODIFICAR_mozo(obj)
    End Sub

    Function BUSCAR_PROVEEDOR(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PROVEEDOR)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PROVEEDOR
        Return objdatos.BUSCAR_PROVEEDOR(obj)
    End Function
    Function BUSCAR_PROVEEDOR_ACTIVOS(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PROVEEDOR)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PROVEEDOR
        Return objdatos.BUSCAR_PROVEEDOR_ACTIVOS(obj)
    End Function
End Class
