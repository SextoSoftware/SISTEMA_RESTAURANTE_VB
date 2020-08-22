Imports CAPA_DATOS
Imports CAPA_ENTIDAD
Public Class CpN_Cls_CLIENTE
    Function MOSTRAR_CLIENTE_NATURAL(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_CLIENTE
        Return objdatos.MOSTRAR_CLIENTE_NATURAL(obj)
    End Function
    Function MOSTRAR_CLIENTE_JURIDICO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_CLIENTE
        Return objdatos.MOSTRAR_CLIENTE_JURIDICO(obj)
    End Function
    Public Sub REGISTRAR_CLIENTE_NATURAL(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_CLIENTE
        objdatos.REGISTRAR_CLIENTE_NATURAL(obj)
    End Sub
    Public Sub REGISTRAR_CLIENTE_JURIDICO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_CLIENTE
        objdatos.REGISTRAR_CLIENTE_JURIDICO(obj)
    End Sub
    Public Sub MODIFICAR_CLIENTE_NATURAL(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_CLIENTE
        objdatos.MODIFICAR_CLIENTE_NATURAL(obj)
    End Sub
    Public Sub MODIFICAR_CLIENTE_JURIDICO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_CLIENTE
        objdatos.MODIFICAR_CLIENTE_JURIDICO(obj)
    End Sub
    Function BUSCAR_CLIENTE_NATURAL(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_CLIENTE
        Return objdatos.BUSCAR_CLIENTE_NATURAL(obj)
    End Function
    Function BUSCAR_CLIENTE_JURIDICO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_CLIENTE
        Return objdatos.BUSCAR_CLIENTE_JURIDICO(obj)
    End Function
    Function MOSTRAR_CLIENTE_ACTIVO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_CLIENTE
        Return objdatos.MOSTRAR_CLIENTE_ACTIVO(obj)
    End Function
    Function BUSCAR_CLIENTE_NATURAL_ACTIVO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_CLIENTE
        Return objdatos.BUSCAR_CLIENTE_NATURAL_ACTIVO(obj)
    End Function
    Function BUSCAR_CLIENTE_JURIDICO_ACTIVO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CLIENTE)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_CLIENTE
        Return objdatos.BUSCAR_CLIENTE_JURIDICO_ACTIVO(obj)
    End Function
End Class
