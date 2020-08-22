Public Class CpE_Cls_MENU_DIA
    Private _idMenu As Integer
    Public Property idMenu() As Integer
        Get
            Return _idMenu
        End Get
        Set(ByVal value As Integer)
            _idMenu = value
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
    Private _Estado As String
    Public Property Estado() As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property

    Private _idPlato As Integer
    Public Property idPlato() As Integer
        Get
            Return _idPlato
        End Get
        Set(ByVal value As Integer)
            _idPlato = value
        End Set
    End Property

    Private _cantidad As Integer
    Public Property cantidad() As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
            _cantidad = value
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


    'DATO DE LA CANTIDAD DE ESTADOS ACTIVOS
    Private _CantActivo As Integer
    Public Property CantActivo() As Integer
        Get
            Return _CantActivo
        End Get
        Set(ByVal value As Integer)
            _CantActivo = value
        End Set
    End Property
End Class
