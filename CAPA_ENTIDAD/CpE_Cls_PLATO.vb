Public Class CpE_Cls_PLATO
    Private _idplato As Integer
    Public Property idplato() As Integer
        Get
            Return _idplato
        End Get
        Set(ByVal value As Integer)
            _idplato = value
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

    Private _descripcion As String
    Public Property descripcion As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _precio As Double
    Public Property precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = value
        End Set
    End Property

    Private _Estado As Integer
    Public Property Estado() As Integer
        Get
            Return _Estado
        End Get
        Set(ByVal value As Integer)
            _Estado = value
        End Set
    End Property

    Private _idcate As Integer
    Public Property idcate() As Integer
        Get
            Return _idcate
        End Get
        Set(ByVal value As Integer)
            _idcate = value
        End Set
    End Property

    Private _opcion As Integer
    Public Property opcion() As Integer
        Get
            Return _opcion
        End Get
        Set(ByVal value As Integer)
            _opcion = value
        End Set
    End Property
End Class
