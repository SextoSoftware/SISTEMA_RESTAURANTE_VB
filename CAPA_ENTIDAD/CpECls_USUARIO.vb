Public Class CpECls_USUARIO
    Private _Idusuario As Integer
    Public Property Idusuario() As Integer
        Get
            Return _Idusuario
        End Get
        Set(ByVal value As Integer)
            _Idusuario = value
        End Set
    End Property

    Private _usu As String
    Public Property usu() As String
        Get
            Return _usu
        End Get
        Set(ByVal value As String)
            _usu = value
        End Set
    End Property

    Private _cla As String
    Public Property cla() As String
        Get
            Return _cla
        End Get
        Set(ByVal value As String)
            _cla = value
        End Set
    End Property

    Private _NomTipo As String
    Public Property NomTipo() As String
        Get
            Return _NomTipo
        End Get
        Set(ByVal value As String)
            _NomTipo = value
        End Set
    End Property

    Private _IdTipo As Integer
    Public Property Idtipo() As Integer
        Get
            Return _IdTipo
        End Get
        Set(ByVal value As Integer)
            _IdTipo = value
        End Set
    End Property

    Private _NomApe As String
    Public Property NomApe() As String
        Get
            Return _NomApe
        End Get
        Set(ByVal value As String)
            _NomApe = value
        End Set
    End Property


    Private _dni As String
    Public Property dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property


    Private _tele As String
    Public Property tele() As String
        Get
            Return _tele
        End Get
        Set(ByVal value As String)
            _tele = value
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

    Private _direccion As String
    Public Property direcion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property
End Class
