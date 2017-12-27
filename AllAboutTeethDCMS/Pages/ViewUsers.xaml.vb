Imports AllAboutTeethDCMS

Public Class ViewUsers

    Public Sub New()
        InitializeComponent()
        Dim vm As ViewUsersViewModel = DataContext
        vm.Container = container
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim vm As ViewUsersViewModel = DataContext
        vm.addUsers()
        vm.loadUsers()
    End Sub
End Class
