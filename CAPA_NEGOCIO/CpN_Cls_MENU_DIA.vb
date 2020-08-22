Imports CAPA_DATOS
Imports CAPA_ENTIDAD
Public Class CpN_Cls_MENU_DIA
    Function MOSTRAR_MENU_DIA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MENU_DIA
        Return objdatos.MOSTRAR_MENU_DIA(obj)
    End Function
    Function MOSTRAR_MENU_DIA_ACTIVO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MENU_DIA
        Return objdatos.MOSTRAR_MENU_DIA_ACTIVO(obj)
    End Function
    Public Sub REGISTRAR_MENU_DIA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MENU_DIA
        objdatos.REGISTRAR_MENU_DIA(obj)
    End Sub
    Public Sub REGISTRAR_DETALLE_MENU(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MENU_DIA
        objdatos.REGISTRAR_DETALLE_MENU(obj)
    End Sub
    Public Sub MODIFICAR_MENU(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MENU_DIA
        objdatos.MODIFICAR_MENU(obj)
    End Sub
    Public Sub MODIFICAR_DETALLE_MENU(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MENU_DIA
        objdatos.MODIFICAR_DETALLE_MENU(obj)
    End Sub
    Function BUSCAR_MENU(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MENU_DIA
        Return objdatos.BUSCAR_MENU(obj)
    End Function
    Public Sub CAPTURA_CODIGO_MENU_DIA(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MENU_DIA
        objdatos.CAPTURA_CODIGO_MENU_DIA(obj)
    End Sub
    Public Sub CAPTURA_CANTIDAD_ESTADO_ACTIVADO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MENU_DIA
        objdatos.CAPTURA_CANTIDAD_ESTADO_ACTIVADO(obj)
    End Sub
    Public Sub MODIFICAR_MENU_CANTDIDAD(ByVal obj As CAPA_ENTIDAD.CpE_Cls_MENU_DIA)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_MENU_DIA
        objdatos.MODIFICAR_MENU_CANTDIDAD(obj)
    End Sub
End Class
