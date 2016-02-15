Public Class WinUsuario
    Dim winLoggin As MainWindow

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        winLoggin = Me.Owner
        Userlbl.Content = "Bienvenid@ " + winLoggin.cuentaIngresada.Nombre
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

    Private Sub MenuItem_Click(sender As Object, e As RoutedEventArgs)
        Dim winModificar As New Modificar
        winModificar.Owner = Me
        winModificar.Show()
        Me.Hide()
    End Sub
End Class
