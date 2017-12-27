Imports AllAboutTeethDCMS

Public Class ViewUsers

    Public Sub New()
        InitializeComponent()
        Dim vm As ViewUsersViewModel = DataContext
        vm.Container = container
    End Sub
End Class
