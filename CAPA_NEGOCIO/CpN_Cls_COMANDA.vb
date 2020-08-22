Imports CAPA_DATOS
Imports CAPA_ENTIDAD
Public Class CpN_Cls_COMANDA

    Public Sub FAC_CAPTURAS(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_COMANDA
        objdatos.FAC_CAPTURAS(obj)
    End Sub
    Public Sub REGISTRAR_COMANDA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_COMANDA
        objdatos.REGISTRAR_COMANDA(obj)
    End Sub
    Public Sub REGISTRAR_DETALLE_COMANDA_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_COMANDA
        objdatos.REGISTRAR_DETALLE_COMANDA_PLATO(obj)
    End Sub
    Public Sub REGISTRAR_DETALLE_COMANDA_PRODUCTOS(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_COMANDA
        objdatos.REGISTRAR_DETALLE_COMANDA_PRODUCTOS(obj)
    End Sub
    Public Sub MODIFICAR_COMANDA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_COMANDA
        objdatos.MODIFICAR_COMANDA(obj)
    End Sub
    Public Sub MODIFICAR_DETALLE_COMANDA_PLATOS(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_COMANDA
        objdatos.MODIFICAR_DETALLE_COMANDA_PLATOS(obj)
    End Sub
    Public Sub MODIFICAR_DETALLE_COMANDA_PRODUCTOS(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_COMANDA
        objdatos.MODIFICAR_DETALLE_COMANDA_PRODUCTOS(obj)
    End Sub

    Public Sub CAPTURA_CODIGO_COMANDA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_COMANDA
        objdatos.CAPTURA_CODIGO_COMANDA(obj)
    End Sub
    Public Sub AGREGAR_DETALLE_COMANDA_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_COMANDA
        objdatos.AGREGAR_DETALLE_COMANDA_PRODUCTO(obj)
    End Sub
    Public Sub AGREGAR_DETALLE_COMANDA_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_COMANDA
        objdatos.AGREGAR_DETALLE_COMANDA_PLATO(obj)
    End Sub

    Public Sub ELIMINAR_DETALLE_COMANDA_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_COMANDA
        objdatos.ELIMINAR_DETALLE_COMANDA_PLATO(obj)
    End Sub
    Public Sub ELIMINAR_DETALLE_COMANDA_PRODUCTO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_COMANDA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_COMANDA
        objdatos.ELIMINAR_DETALLE_COMANDA_PRODUCTO(obj)
    End Sub
End Class
