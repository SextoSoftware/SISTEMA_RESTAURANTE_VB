Imports CAPA_DATOS
Imports CAPA_ENTIDAD
Public Class CpN_Cls_PROVEEDOR

    Function MOSTRAR_PROVEEDORES(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PROVEEDOR)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PROVEEDOR
        Return objdatos.MOSTRAR_PROVEEDORES(obj)
    End Function
    Function MOSTRAR_PROVEEDORES_ESTADO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PROVEEDOR)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PROVEEDOR
        Return objdatos.MOSTRAR_PROVEEDORES_ESTADO(obj)
    End Function

    Public Sub REGISTRAR_PROVEEDOR(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PROVEEDOR)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PROVEEDOR
        objdatos.REGISTRAR_PROVEEDOR(obj)
    End Sub
    Public Sub MODIFICAR_PROVEEDOR(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PROVEEDOR)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PROVEEDOR
        objdatos.MODIFICAR_PROVEEDOR(obj)
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
