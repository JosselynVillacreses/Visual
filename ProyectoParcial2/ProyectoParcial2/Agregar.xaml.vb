Imports System.Data.OleDb
Imports System.Data
Public Class Agregar
    Public resId As Integer
    Dim datos As New DataSet("Datos")
    Dim dbPath As String = "C:\Users\Jenniffer Trelles\Desktop\PROYECTOVISUALFINAL20152S\bdProyecto.mdb"
    Dim strConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbPath

    Private Sub btnVolver_Click(sender As Object, e As RoutedEventArgs) Handles btnVolver.Click
        Me.Owner.IsEnabled = True
        Me.Close()
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As RoutedEventArgs) Handles btnagregar.Click
        datos.Tables("juegos").Rows.Add(datos.Tables("juegos").Rows.Count + 1, txtTitulo.Text, txtTituloOriginal.Text, txtDesarrollador.Text, txtDsitribuidor.Text, txtDiseñador.Text, txtProgrmador.Text, txtLanzamiento.Text, txtPlataforma.Text, txtGenero.Text, txtModo.Text, txtPrecio.Text, chckAvalaible.IsChecked, txtStock.Text)
        Using conexion As New OleDbConnection(strConexion)
            Dim consulta As String = "SELECT * FROM Juegos;"
            Dim adapter As New OleDbDataAdapter(consulta, conexion)
            Dim cmdBuilder = New OleDbCommandBuilder(adapter)

            Try
                adapter.Update(datos.Tables("juegos"))
                MessageBox.Show("Su juego" + txtTitulo.Text + "se agregó", "Juego Añadido", MessageBoxButton.OK, MessageBoxImage.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error al agregar")
            End Try
        End Using

        '************otro 

        'Dim padre As WinUsuario = CType(Me.Owner, WinUsuario)
        'padre.agregarNuevo(txtTitulo.Text, txtTituloOriginal.Text, txtDesarrollador.Text, txtDsitribuidor.Text, txtDiseñador.Text, txtProgrmador.Text, txtLanzamiento.Text, txtPlataforma.Text, txtGenero.Text, txtModo.Text, txtPrecio.Text, chckAvalaible.IsChecked, txtStock.Text)


    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Using conexion As New OleDbConnection(strConexion)
            Dim consulta As String = "SELECT * FROM Juegos"
            Dim adapter As New OleDbDataAdapter(consulta, conexion)
            adapter.Fill(datos, "juegos")
        End Using
    End Sub

    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Me.Owner.IsEnabled = True

    End Sub
End Class
