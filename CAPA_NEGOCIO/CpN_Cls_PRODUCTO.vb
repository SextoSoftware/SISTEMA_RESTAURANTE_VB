Imports CAPA_DATOS
Imports CAPA_ENTIDAD
Public Class CpN_Cls_PRODUCTO
    Function MOSTRAR_PRODUCTO_ESTADO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PRODUCTO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PRODUCTO
        Return objdatos.MOSTRAR_PRODUCTO_ESTADO(obj)
    End Function
    Function MOSTRAR_PRODCUTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PRODUCTO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PRODUCTO
        Return objdatos.MOSTRAR_PRODCUTO(obj)
    End Function

    Public Sub REGISTRAR_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PRODUCTO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PRODUCTO
        objdatos.REGISTRAR_PRODUCTO(obj)
    End Sub
    Public Sub MODIFICAR_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PRODUCTO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PRODUCTO
        objdatos.MODIFICAR_PRODUCTO(obj)
    End Sub

    Function BUSCAR_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PRODUCTO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PRODUCTO
        Return objdatos.BUSCAR_PRODUCTO(obj)
    End Function

    Function BUSCAR_PRODUCTOS_ACTIVOS(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PRODUCTO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PRODUCTO
        Return objdatos.BUSCAR_PRODUCTOS_ACTIVOS(obj)
    End Function
    Public Sub MODIFICAR_STOCK_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PRODUCTO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PRODUCTO
        objdatos.MODIFICAR_STOCK_PRODUCTO(obj)
    End Sub
End Class
