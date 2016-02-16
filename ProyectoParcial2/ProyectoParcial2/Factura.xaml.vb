Imports System.Data

Public Class Factura
    Private Sub btnEliminarCompra_Click(sender As Object, e As RoutedEventArgs) Handles btnEliminarCompra.Click


        '        var Grid = dataGrid1;
        'If (Grid.SelectedIndex >= 0) Then
        '             {
        '   For (Int() i = 0; i <= grid.SelectedItems.Count; i++)
        '   {
        '      Grid.Items.Remove(Grid.SelectedItems[i]);
        '   };
        ' }
        'If dgFacturaVideoJuegos.SelectedItem = True Then
        '    dgFacturaVideoJuegos.
        'End If
    End Sub
    Private Sub Window_Closing(sender As Object, e As ComponentModel.CancelEventArgs)
        Me.Owner.IsEnabled = True

    End Sub
    'Private Sub btnVolver_Click(sender As Object, e As RoutedEventArgs) Handles btnVolver.Click
    '    Me.Owner.IsEnabled = True
    '    Me.Close()
    'End Sub
End Class
