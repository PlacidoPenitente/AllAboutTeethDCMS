Public Class AddAccount
    Private Sub PasswordBox_PasswordChanged(sender As Object, e As RoutedEventArgs)
        Dim passwordBox As PasswordBox = sender
        Dim control As UserControl = CType(CType(CType(CType(passwordBox.Parent, StackPanel).Parent, StackPanel).Parent, Grid).Parent, UserControl)
        Dim addAccountViewModel As AddAccountViewModel = control.DataContext
        addAccountViewModel.Password = passwordBox.Password
    End Sub
End Class
