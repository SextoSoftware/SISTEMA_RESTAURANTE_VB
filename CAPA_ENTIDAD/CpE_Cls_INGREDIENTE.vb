Public Class CpE_Cls_INGREDIENTE
    Private _idingrediente As Integer
    Public Property idingrediente() As Integer
        Get
            Return _idingrediente
        End Get
        Set(ByVal value As Integer)
            _idingrediente = value
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

    Private _Unidad As String
    Public Property Unidad() As String
        Get
            Return _Unidad
        End Get
        Set(ByVal value As String)
            _Unidad = value
        End Set
    End Property
    Private _Stock As Double
    Public Property Stock() As Double
        Get
            Return _Stock
        End Get
        Set(ByVal value As Double)
            _Stock = value
        End Set
    End Property
End Class
