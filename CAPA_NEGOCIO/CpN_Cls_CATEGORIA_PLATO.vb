Imports CAPA_DATOS
Imports CAPA_ENTIDAD
Public Class CpN_Cls_CATEGORIA_PLATO
    Function MOSTRAR_CATEGORIA_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CATEGORIA_PLATO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_CATEGORIA_PLATO
        Return objdatos.MOSTRAR_CATEGORIA_PLATO(obj)
    End Function
    Function MOSTRAR_CATEGORIA_PLATO_ACTIVO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CATEGORIA_PLATO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_CATEGORIA_PLATO
        Return objdatos.MOSTRAR_CATEGORIA_PLATO_ACTIVO(obj)
    End Function

    Public Sub REGISTRAR_CATEGORIA_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CATEGORIA_PLATO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_CATEGORIA_PLATO
        objdatos.REGISTRAR_CATEGORIA_PLATO(obj)
    End Sub
    Public Sub MODIFICAR_CATEGORIA_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CATEGORIA_PLATO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_CATEGORIA_PLATO
        objdatos.MODIFICAR_CATEGORIA_PLATO(obj)
    End Sub

    Function BUSCAR_CATEGORIA_PLATO(ByVal obj As CAPA_ENTIDAD.CpE_Cls_CATEGORIA_PLATO)
        Dim objdatos As New CAPA_DATOS.CpD_Cls_CATEGORIA_PLATO
        Return objdatos.BUSCAR_CATEGORIA_PLATO(obj)
    End Function
End Class
