Public Class CpE_Cls_MESA
    Private _IdMesa As Integer
    Public Property idmesa() As Integer
        Get
            Return _IdMesa
        End Get
        Set(ByVal value As Integer)
            _IdMesa = value
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
