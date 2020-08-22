Public Class CpNCls_USUARIO
    Public Sub CapturarNombreTipo(ByVal obj As CAPA_ENTIDAD.CpECls_USUARIO)
        Dim objdatos As New CAPA_DATOS.CpDCls_USUARIO
        objdatos.CapturarNombreTipo(obj)
    End Sub
    Function Logeo(ByVal n As String, ByVal cl As String, ByVal obj As CAPA_ENTIDAD.CpECls_USUARIO)
        Dim objdatos As New CAPA_DATOS.CpDCls_USUARIO
        Return objdatos.logeo(n, cl, obj)
    End Function

    Function MOSTRAR_USUARIO(ByVal obj As CAPA_ENTIDAD.CpECls_USUARIO)
        Dim objdatos As New CAPA_DATOS.CpDCls_USUARIO
        Return objdatos.MOSTRAR_USUARIO(obj)
    End Function


    Function MOSTRAR_TIPO_USUARIO(ByVal obj As CAPA_ENTIDAD.CpECls_USUARIO)
        Dim objdatos As New CAPA_DATOS.CpDCls_USUARIO
        Return objdatos.MOSTRAR_TIPO_USUARIO(obj)
    End Function

    Public Sub REGISTRAR_USUARIO(ByVal obj As CAPA_ENTIDAD.CpECls_USUARIO)
        Dim objdatos As New CAPA_DATOS.CpDCls_USUARIO
        objdatos.REGISTRAR_USUARIO(obj)
    End Sub

    Public Sub MODIFICAR_USUARIO(ByVal obj As CAPA_ENTIDAD.CpECls_USUARIO)
        Dim objdatos As New CAPA_DATOS.CpDCls_USUARIO
        objdatos.MODIFICAR_USUARIO(obj)
    End Sub
End Class
