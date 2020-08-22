Public Class CpE_Cls_CATEGORIA_PLATO
    Private _IdCate As Integer
    Public Property idcate() As Integer
        Get
            Return _IdCate
        End Get
        Set(ByVal value As Integer)
            _IdCate = value
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
