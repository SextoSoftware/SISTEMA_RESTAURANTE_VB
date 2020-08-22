Public Class CpE_Cls_PRODUCTO
    Private _idproducto As Integer
    Public Property idproducto() As Integer
        Get
            Return _idproducto
        End Get
        Set(ByVal value As Integer)
            _idproducto = value
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

    Private _medida As String
    Public Property medida() As String
        Get
            Return _medida
        End Get
        Set(ByVal value As String)
            _medida = value
        End Set
    End Property

    Private _cantiunidad As String
    Public Property cantiunidad As String
        Get
            Return _cantiunidad
        End Get
        Set(ByVal value As String)
            _cantiunidad = value
        End Set
    End Property

    Private _stock As String
    Public Property stock As String
        Get
            Return _stock
        End Get
        Set(ByVal value As String)
            _stock = value
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

    Private _idtipo As Integer
    Public Property idtipo() As Integer
        Get
            Return _idtipo
        End Get
        Set(ByVal value As Integer)
            _idtipo = value
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
