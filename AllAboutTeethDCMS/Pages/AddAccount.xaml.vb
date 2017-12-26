Public Class AddAccount
    Private open As Forms.OpenFileDialog

    Private Sub PasswordBox_PasswordChanged(sender As Object, e As RoutedEventArgs)
        Dim passwordBox As PasswordBox = sender
        Dim addAccountViewModel As AddAccountViewModel = DataContext
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

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim addAccountViewModel As AddAccountViewModel = DataContext
        addAccountViewModel.Image = browseImage()
    End Sub

    Public Function browseImage() As String
        If IsNothing(open) Then
            open = New Forms.OpenFileDialog
        End If
        open.Title = "Select an image."
        open.Filter = "Image (*.jpg)|*.jpg"
        open.ShowDialog()
        Return open.FileName.Replace("\\", "/")
    End Function

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim addAccountViewModel As AddAccountViewModel = DataContext
        addAccountViewModel.insertUser()
    End Sub
End Class
