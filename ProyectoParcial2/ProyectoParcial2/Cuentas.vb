Imports System.Data
Public Class Cuentas
    Protected _userName As String
    Protected _password As String
    Protected _cedula As String
    Protected _nombre As String
    Protected _apellido As String

    Private _isLogged As Boolean
    Public Property Islogged() As Boolean
        Get
            Return _isLogged
        End Get
        Set(ByVal value As Boolean)
            _isLogged = value
        End Set
    End Property

    Protected _priority As Boolean  'True = Administrador
    '                              False = Usuario común
    Public ReadOnly Property Priority() As Boolean
        Get
            Return _priority
        End Get
    End Property

    Public Property UserName() As String
        Get
            Return _userName
        End Get
        Set(ByVal value As String)
            _userName = value
        End Set
    End Property
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property
    Public Property Cedula() As String
        Get
            Return _cedula
        End Get
        Set(ByVal value As String)
            _cedula = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property


    Sub New(userName As String, password As String, cedula As String, nombre As String, apellidos As String)
        Me._userName = userName
        Me._password = password
        Me._cedula = cedula
        Me._nombre = nombre
        Me._apellido = apellido
    End Sub

    Sub New()

    End Sub

    Sub New(userName As String, password As String)
        Me._userName = userName
        Me._password = password
    End Sub

    Sub New(u As DataRow)
        Me.UserName = u("user")
        Me.Password = u("pass")
        Me.Cedula = u("cedula")
        Me.Nombre = u("name")
        Me.Apellido = u("lastname")
        Me._priority = u("priority")

    End Sub

    'LOGIN
    Public Function logIn(usuarios As ArrayList)

        For Each u As Cuentas In usuarios

            If Me.UserName = u.UserName And Me.Password = u.Password Then
                Me._isLogged = True
                Me.Nombre = u.Nombre
                Me.Apellido = u.Apellido
                Me.Cedula = u.Cedula
                Exit For
            End If
        Next
        Return IsLogged
    End Function
End Class
