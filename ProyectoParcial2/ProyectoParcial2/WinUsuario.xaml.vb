Imports System.Data.OleDb
Imports System.Data
Public Class WinUsuario
    Dim winLoggin As MainWindow
    Public juego As Juego
    Property privilegios As String
    Dim dsjuegos As New DataSet("juegos")
    Dim dbath = "C:\bdProyecto.mdb"
    Dim strConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbath

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)


        Using conexion As New OleDbConnection(strConexion)
            lblUser.Content = "Bienvenid@ " + winLoggin.cuentaIngresada.Nombre
            Dim query As String = "Select * From Juegos;" 'comando para consulta en base que se ha llamado
            Dim adapter As New OleDbDataAdapter(query, conexion) 'con la conexion tratar de acceder a los datos
            Dim builder As New OleDbCommandBuilder(adapter)
            adapter.Fill(dsjuegos, "juegos")
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey

            Me.dgDescripcionVideojuegos.ItemsSource = dsjuegos.Tables("juegos").DefaultView
            'dgDescripcionVideojuegos.DataContext = dsjuegos
            winLoggin = Me.Owner

        End Using
    End Sub

    Private Sub Label_MouseDown(sender As Object, e As MouseButtonEventArgs)
        winLoggin = Me.Owner
        winLoggin.Show()
        Me.Close()
    End Sub

    Private Sub Window_Closed(sender As Object, e As EventArgs)
        winLoggin = Me.Owner
        winLoggin.Show()
        Me.Close()
    End Sub



    Private Sub menuEditar_Click(sender As Object, e As RoutedEventArgs)
        Dim winModificar As New Modificar
        winModificar.Owner = Me
        winModificar.Show()
        Me.Hide()
    End Sub

    'Private Sub Sub_Eliminar_Click(sender As Object, e As RoutedEventArgs) Handles Sub_Eliminar.Click
    '    MessageBox.Show("Esta seguro que desea eliminar el juego" + juego.Titulo, "Juego a Eliminar", MessageBoxButton.OKCancel, MessageBoxImage.Stop)
    'End Sub


    Private Sub btnComprar_Click(sender As Object, e As RoutedEventArgs) Handles btnComprar.Click
        Dim contador As Integer = 0
        txtxNumCompra.Text = contador + 1 + "juegos seleccionados"
    End Sub


    Private Sub menuCrear_Click(sender As Object, e As RoutedEventArgs)
        'Dim ventanaAgregar As New Agregar
        'ventanaAgregar.Owner = Me

        'ventanaAgregar.Show()
        ''Me.Hide()
        'Me.IsEnabled = False
    End Sub

    Private Sub MenuItem_Click(sender As Object, e As RoutedEventArgs)

    End Sub
End Class
