Imports CAPA_DATOS
Imports CAPA_ENTIDAD
Public Class CpN_Cls_PLATO
    Function MOSTRAR_PLATO_ESTADO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PLATO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PLATO
        Return objdatos.MOSTRAR_PLATO_ESTADO(obj)
    End Function
    Function MOSTRAR_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PLATO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PLATO
        Return objdatos.MOSTRAR_PLATO(obj)
    End Function

    Public Sub REGISTRAR_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PLATO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PLATO
        objdatos.REGISTRAR_PLATO(obj)
    End Sub
    Public Sub MODIFICAR_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PLATO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PLATO
        objdatos.MODIFICAR_PLATO(obj)
    End Sub

    Function BUSCAR_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PLATO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PLATO
        Return objdatos.BUSCAR_PLATO(obj)
    End Function

    Function BUSCAR_PLATO_ACTIVOS(ByVal obj As CAPA_ENTIDAD.CpE_Cls_PLATO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_PLATO
        Return objdatos.BUSCAR_PLATO_ACTIVOS(obj)
    End Function
End Class
