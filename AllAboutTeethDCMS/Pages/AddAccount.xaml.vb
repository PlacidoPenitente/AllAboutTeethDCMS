Imports System.Drawing

Public Class AddAccount
    Private open As Forms.OpenFileDialog

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

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        browseImage()
    End Sub

    Public Function browseImage() As Image
        If IsNothing(open) Then
            open = New Forms.OpenFileDialog
        End If
        open.Title = "Select an image."
        open.Filter = "Image (*.jpg)|*.jpg"
        open.ShowDialog()
        Return Image.FromFile(open.FileName)
    End Function
End Class
