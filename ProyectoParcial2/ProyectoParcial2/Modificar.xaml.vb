Public Class Modificar


    Private Sub Window_Closed(sender As Object, e As EventArgs)
        Dim winUser As WinUsuario
        winUser = Me.Owner
        winUser.Show()
        Me.Close()
    End Sub
End Class
