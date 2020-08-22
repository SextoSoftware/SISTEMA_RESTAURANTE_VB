Imports CAPA_DATOS
Imports CAPA_ENTIDAD
Public Class CpN_Cls_TIPO_PRODUCTO
    Function MOSTRAR_TIPO_PRODCUTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_TIPO_PRODUCTO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_TIPO_PRODUCTO
        Return objdatos.MOSTRAR_TIPO_PRODCUTO(obj)
    End Function
    Function MOSTRAR_TIPO_PRODCUTO_ACTIVO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_TIPO_PRODUCTO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_TIPO_PRODUCTO
        Return objdatos.MOSTRAR_TIPO_PRODCUTO_ACTIVO(obj)
    End Function

    Public Sub REGISTRAR_TIPO_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_TIPO_PRODUCTO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_TIPO_PRODUCTO
        objdatos.REGISTRAR_TIPO_PRODUCTO(obj)
    End Sub
    Public Sub MODIFICAR_TIPO_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_TIPO_PRODUCTO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_TIPO_PRODUCTO
        objdatos.MODIFICAR_TIPO_PRODUCTO(obj)
    End Sub

    Function BUSCAR_TIPO_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_TIPO_PRODUCTO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_TIPO_PRODUCTO
        Return objdatos.BUSCAR_TIPO_PRODUCTO(obj)
    End Function
End Class
