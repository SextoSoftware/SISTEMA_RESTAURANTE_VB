Imports CAPA_DATOS
Imports CAPA_ENTIDAD
Public Class CpN_Cls_MESA
    Function MOSTRAR_MESA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MESA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MESA
        Return objdatos.MOSTRAR_MESA(obj)
    End Function
    Function MOSTRAR_ACTIVAS_OCUPADAS(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MESA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MESA
        Return objdatos.MOSTRAR_ACTIVAS_OCUPADAS(obj)
    End Function
    Public Sub REGISTRAR_MESA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MESA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MESA
        objdatos.REGISTRAR_MESA(obj)
    End Sub
    Public Sub MODIFICAR_MESA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MESA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MESA
        objdatos.MODIFICAR_MESA(obj)
    End Sub

    Function BUSCAR_TIPO_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_TIPO_PRODUCTO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_TIPO_PRODUCTO
        Return objdatos.BUSCAR_TIPO_PRODUCTO(obj)
    End Function
End Class
