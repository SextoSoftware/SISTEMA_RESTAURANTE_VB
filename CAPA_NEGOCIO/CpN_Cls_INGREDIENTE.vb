Imports CAPA_DATOS
Imports CAPA_ENTIDAD
Public Class CpN_Cls_INGREDIENTE
    Function MOSTRAR_INGREDIENTE(ByVal obj As CAPA_ENTIDAD.CpE_Cls_INGREDIENTE)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_INGREDIENTE
        Return objdatos.MOSTRAR_INGREDIENTE(obj)
    End Function


    Public Sub REGISTRAR_INGREDIENTE(ByVal obj As CAPA_ENTIDAD.CpE_Cls_INGREDIENTE)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_INGREDIENTE
        objdatos.REGISTRAR_INGREDIENTE(obj)
    End Sub
    Public Sub MODIFICAR_INGREDIENTE(ByVal obj As CAPA_ENTIDAD.CpE_Cls_INGREDIENTE)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_INGREDIENTE
        objdatos.MODIFICAR_INGREDIENTE(obj)
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
