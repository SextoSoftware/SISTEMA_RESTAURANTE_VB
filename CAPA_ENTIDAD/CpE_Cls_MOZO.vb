Public Class CpE_Cls_MOZO
    Private _idmozo As Integer
    Public Property idmozo() As Integer
        Get
            Return _idmozo
        End Get
        Set(ByVal value As Integer)
            _idmozo = value
        End Set
    End Property

    Private _NombreCompañia As String
    Public Property NombreCompañia As String
        Get
            Return _NombreCompañia
        End Get
        Set(ByVal value As String)
            _NombreCompañia = value
        End Set
    End Property

    Private _ruc As String
    Public Property ruc() As String
        Get
            Return _ruc
        End Get
        Set(ByVal value As String)
            _ruc = value
        End Set
    End Property

    Private _telefono As String
    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Private _direccion As String
    Public Property direccion As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Private _observacion As String
    Public Property observacion As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
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


    'OPCIONE DE BUSQUEDA
    Private _opcion As Integer
    Public Property opcion() As Integer
        Get
            Return _opcion
        End Get
        Set(ByVal value As Integer)
            _opcion = value
        End Set
    End Property

    Private _dato As Integer
    Public Property dato() As Integer
        Get
            Return _dato
        End Get
        Set(ByVal value As Integer)
            _opcion = value
        End Set
    End Property
End Class
