Public Class CpE_Cls_TIPO_PRODUCTO
    Private _IdTipo As Integer
    Public Property idTipo() As Integer
        Get
            Return _IdTipo
        End Get
        Set(ByVal value As Integer)
            _IdTipo = value
        End Set
    End Property

    Private _Nombre As String
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Private _estado As Integer
    Public Property estado() As Integer
        Get
            Return _estado
        End Get
        Set(ByVal value As Integer)
            _estado = value
        End Set
    End Property
End Class
