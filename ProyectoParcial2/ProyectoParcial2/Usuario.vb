Public Class Usuario : Inherits Cuentas
 
    Protected _creditCard As String


    Public Property creditCard() As String
        Get
            Return _creditCard
        End Get
        Set(ByVal value As String)
            _creditCard = value
        End Set
    End Property



    Sub New(userName As String, password As String, cedula As String, nombre As String, apellidos As String,
            creditCard As String)
        MyBase.New(userName, password, cedula, nombre, apellidos)
        Me._priority = False
        Me.creditCard = creditCard
    End Sub

    Sub New(creditCard As String)
        Me._priority = False
        Me._creditCard = creditCard
    End Sub

    Sub New()
        Me._priority = False
    End Sub

    Sub New(userName As String, password As String)
        MyBase.New(userName, password)
        Me._priority = False
    End Sub



End Class
