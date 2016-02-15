Public Class Administrador : Inherits Cuentas


    Sub New(userName As String, password As String, cedula As String, nombre As String, apellidos As String)
        MyBase.New(userName, password, cedula, nombre, apellidos)
        Me._priority = True
    End Sub

    Sub New()
        Me._priority = True
    End Sub

    Sub New(userName As String, password As String)
        MyBase.New(userName, password)
        Me._priority = True
    End Sub
End Class
