Public Class Juego
    Private _tituloOriginal As String
    Private _titulo As String
    Private _desarrollador As String
    Private _distribuidora As String
    Private _diseñador As String
    Private _programador As String
    Private _fechaLanzamiento As String
    Private _plataforma As String
    Private _genero As String
    Private _modo As String
    Private _precio As Double
    Private _avaliable As Boolean
    Private _stock As Integer
    Dim _id As Integer
    Private _idPelicula As Integer

    Public Property id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    'Public Sub New(ByRef childs As XmlNode)
    '    For Each att As XmlElement In childs.ChildNodes
    '        Me.TituloOriginal = childs.Attributes("tittle").Value
    '        Select Case att.Name
    '            Case "id"
    '                Me.id = att.InnerText
    '            Case "titulo"
    '                Me.Titulo = att.InnerText
    '            Case "desarrollador"
    '                Me._desarrollador = att.InnerText
    '            Case "distribuidor"
    '                Me._distribuidora = att.InnerText
    '            Case "disenador"
    '                Me._diseñador = att.InnerText
    '            Case "programador"
    '                Me._programador = att.InnerText
    '            Case "fechalanzamiento"
    '                Me._fechaLanzamiento = att.InnerText
    '            Case "plataforma"
    '                Me._plataforma = att.InnerText
    '            Case "genero"
    '                Me._genero = att.InnerText
    '            Case "modo"
    '                Me._modo = att.InnerText
    '            Case "precio"
    '                Me._precio = att.InnerText
    '            Case "avaliable"
    '                Me._avaliable = att.InnerText
    '            Case "stock"
    '                Me._stock = att.InnerText

    '        End Select

    '    Next

    'End Sub

    'Constructor 
    Public Sub New(tituloOriginal As String, titulo As String, desarrollador As String, distribuidor As String, diseñador As String, programador As String, fecha As String, plataforma As String, genero As String, modo As String, precio As Double, avaliable As Boolean, stock As Integer)
        Me._tituloOriginal = tituloOriginal
        Me._titulo = titulo
        Me._desarrollador = desarrollador
        Me._distribuidora = distribuidor
        Me._diseñador = diseñador
        Me._programador = programador
        Me._fechaLanzamiento = fecha
        Me._plataforma = plataforma
        Me._genero = genero
        Me._modo = modo
        Me._precio = precio
        Me._avaliable = avaliable
        Me._stock = stock

    End Sub

    'Constructor vacío
    Sub New()
        ' TODO: Complete member initialization 
    End Sub


    'Constructor para la compra
    Public Sub New(tituloOriginal As String, titulo As String, genero As String, precio As Double)
        Me._tituloOriginal = tituloOriginal
        Me._titulo = titulo
        Me._genero = genero
        Me._precio = precio
    End Sub


    'Set y get

    Public Property Stock() As Integer
        Get
            Return _stock
        End Get
        Set(ByVal value As Integer)
            _stock = value
        End Set
    End Property
    Public Property Avaliable() As Boolean
        Get
            Return _avaliable
        End Get
        Set(ByVal value As Boolean)
            _avaliable = value
        End Set
    End Property
    Public Property Precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = value
        End Set
    End Property
    Public Property Modo() As String
        Get
            Return _modo
        End Get
        Set(ByVal value As String)
            _modo = value
        End Set
    End Property
    Public Property Genero() As String
        Get
            Return _genero
        End Get
        Set(ByVal value As String)
            _genero = value
        End Set
    End Property
    Public Property Plataforma() As String
        Get
            Return _plataforma
        End Get
        Set(ByVal value As String)
            _plataforma = value
        End Set
    End Property
    Public Property FechaLanzamiento() As String
        Get
            Return _fechaLanzamiento
        End Get
        Set(ByVal value As String)
            _fechaLanzamiento = value
        End Set
    End Property
    Public Property Programador() As String
        Get
            Return _programador
        End Get
        Set(ByVal value As String)
            _programador = value
        End Set
    End Property
    Public Property Diseñador() As String
        Get
            Return _diseñador
        End Get
        Set(ByVal value As String)
            _diseñador = value
        End Set
    End Property
    Public Property Distribuidora() As String
        Get
            Return _distribuidora
        End Get
        Set(ByVal value As String)
            _distribuidora = value
        End Set
    End Property
    Public Property Desarrollador() As String
        Get
            Return _desarrollador
        End Get
        Set(ByVal value As String)
            _desarrollador = value
        End Set
    End Property
    Public Property Titulo() As String
        Get
            Return _titulo
        End Get
        Set(ByVal value As String)
            _titulo = value
        End Set
    End Property
    Public Property TituloOriginal() As String
        Get
            Return _tituloOriginal
        End Get
        Set(ByVal value As String)
            _tituloOriginal = value
        End Set
    End Property

    Public Property IdPelicula() As Integer
        Get
            Return _idPelicula
        End Get
        Set(ByVal value As Integer)
            _idPelicula = value
        End Set
    End Property

End Class
