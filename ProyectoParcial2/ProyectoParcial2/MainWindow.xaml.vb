Imports System.Data.OleDb
Imports System.Data
Class MainWindow
    Public cuentas As ArrayList
    Public loggedIn As Boolean
    Public cuentaIngresada As Cuentas

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Dim dbath = "C:\bdProyecto.mdb"
        Dim strConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbath

        Using conexion As New OleDbConnection(strConexion)
            Dim query As String = "Select * From Usuarios;"
            Dim adapter As New OleDbDataAdapter(query, conexion)
            Dim dsCuentas As New DataSet("cuenta")
            adapter.Fill(dsCuentas, "cuenta")
            Me.cuentas = New ArrayList

            For Each u As DataRow In dsCuentas.Tables("cuenta").Rows
                Me.cuentas.Add(New Cuentas(u))
            Next
        End Using
    End Sub


    Private Sub lblRegistro_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles lblRegistro.MouseDown
        MessageBox.Show("Shalalalaaa")
    End Sub



    Private Sub btnInciarSesion_Click(sender As Object, e As RoutedEventArgs) Handles btnInciarSesion.Click
        Me.cuentaIngresada = New Cuentas(txtUser.Text, txtPass.Password)
        Me.loggedIn = cuentaIngresada.logIn(cuentas)

            If Me.loggedIn Then
                Dim winUsuario As New WinUsuario
                winUsuario.Owner = Me
                winUsuario.Show()
                Me.Hide()
            MessageBox.Show("Ingreso exitoso")
            txtPass.Password = ""
            txtUser.Text = ""
        Else
            MessageBox.Show("Credenciales incorrectas")
            txtPass.Password = ""
            txtUser.Text = ""
        End If

    End Sub


End Class
