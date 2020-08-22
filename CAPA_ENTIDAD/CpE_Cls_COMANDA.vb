Public Class CpE_Cls_COMANDA
    Private _OpcionCapturar As Integer
    Public Property OpcionCapturar As Integer
        Get
            Return _OpcionCapturar
        End Get
        Set(ByVal value As Integer)
            _OpcionCapturar = value
        End Set
    End Property
    Private _Numero As Integer
    Public Property Numero As Integer
        Get
            Return _Numero
        End Get
        Set(ByVal value As Integer)
            _Numero = value
        End Set
    End Property
    Private _ValorIngresado
    Public Property ValorIngresado() As String
        Get
            Return _ValorIngresado
        End Get
        Set(ByVal value As String)
            _ValorIngresado = value
        End Set
    End Property
    Private _ValorSalida
    Public Property ValorSalida() As String
        Get
            Return _ValorSalida
        End Get
        Set(ByVal value As String)
            _ValorSalida = value
        End Set
    End Property
    Private _NumeroD
    Public Property NumeroD() As String
        Get
            Return _NumeroD
        End Get
        Set(ByVal value As String)
            _NumeroD = value
        End Set
    End Property
    Private _idMOZO As Integer
    Public Property idMOZO() As Integer
        Get
            Return _idMOZO
        End Get
        Set(ByVal value As Integer)
            _idMOZO = value
        End Set
    End Property
    Private _idcomanda As Integer
    Public Property idcomanda() As Integer
        Get
            Return _idcomanda
        End Get
        Set(ByVal value As Integer)
            _idcomanda = value
        End Set
    End Property

    Private _fecha As DateTime
    Public Property fecha As DateTime
        Get
            Return _fecha
        End Get
        Set(ByVal value As DateTime)
            _fecha = value
        End Set
    End Property

    Private _estado As String
    Public Property estado As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
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

    Private _descuento As Double
    Public Property descuento() As Double
        Get
            Return _descuento
        End Get
        Set(ByVal value As Double)
            _descuento = value
        End Set
    End Property


    Private _monto As Double
    Public Property monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    Private _idmesa As Integer
    Public Property idmesa() As Integer
        Get
            Return _idmesa
        End Get
        Set(ByVal value As Integer)
            _idmesa = value
        End Set
    End Property


    Private _idtipoDocu As Integer
    Public Property idtipoDucu() As Integer
        Get
            Return _idtipoDocu
        End Get
        Set(ByVal value As Integer)
            _idtipoDocu = value
        End Set
    End Property


    Private _idcliente As Integer
    Public Property idcliente() As Integer
        Get
            Return _idcliente
        End Get
        Set(ByVal value As Integer)
            _idcliente = value
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

    Private _idplato As Integer
    Public Property idplato() As Integer
        Get
            Return _idplato
        End Get
        Set(ByVal value As Integer)
            _idplato = value
        End Set
    End Property

    Private _idproducto As Integer
    Public Property idproducto() As Integer
        Get
            Return _idproducto
        End Get
        Set(ByVal value As Integer)
            _idproducto = value
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

    Private _importe As Double
    Public Property importe() As Double
        Get
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
        End Set
    End Property

    Private _notas As String
    Public Property notas As String
        Get
            Return _notas
        End Get
        Set(ByVal value As String)
            _notas = value
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
    Private _nombre As String
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
End Class
