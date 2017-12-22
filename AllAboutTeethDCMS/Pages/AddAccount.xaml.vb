Public Class AddAccount
    Private Sub PasswordBox_PasswordChanged(sender As Object, e As RoutedEventArgs)
        Dim passwordBox As PasswordBox = sender
        Dim control As UserControl = CType(CType(CType(CType(passwordBox.Parent, StackPanel).Parent, StackPanel).Parent, Grid).Parent, UserControl)
        Dim addAccountViewModel As AddAccountViewModel = control.DataContext
        addAccountViewModel.Password = passwordBox.Password
        comparePasswords(password.Password, confirm.Password)
    End Sub

    Public Function comparePasswords(first As String, second As String) As Boolean
        If first = second Then
            Return True
        End If
        Return False
    End Function

    Private Sub PasswordBox_PasswordChanged_1(sender As Object, e As RoutedEventArgs)
        comparePasswords(password.Password, confirm.Password)
    End Sub
End Class
