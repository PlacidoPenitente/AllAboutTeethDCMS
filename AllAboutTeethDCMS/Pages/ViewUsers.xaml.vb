Imports AllAboutTeethDCMS

Public Class ViewUsers
    Private m_grid As WrapPanel
    Private m_list As StackPanel

    Public Sub New()
        InitializeComponent()
        m_grid = New WrapPanel
        m_list = New StackPanel
        Dim vm As ViewUsersViewModel = DataContext
        vm.loadUsers()
        loadGrid()
    End Sub

    Public Sub loadGrid()
        container.Children.Clear()
        container.Children.Add(Grid)
        Dim vm As ViewUsersViewModel = DataContext
        vm.Container = Grid
        vm.addUsers()
        vm.loadUsers()
    End Sub

    Public Sub loadList()
        container.Children.Clear()
        container.Children.Add(List)
        Dim vm As ViewUsersViewModel = DataContext
        vm.Container = List
        vm.addUsers()
        vm.loadUsers()
    End Sub

    Public Property Grid As WrapPanel
        Get
            Return m_grid
        End Get
        Set(value As WrapPanel)
            m_grid = value
        End Set
    End Property

    Public Property List As StackPanel
        Get
            Return m_list
        End Get
        Set(value As StackPanel)
            m_list = value
        End Set
    End Property

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim vm As ViewUsersViewModel = DataContext
        vm.addUsers()
        vm.loadUsers()
    End Sub
End Class
