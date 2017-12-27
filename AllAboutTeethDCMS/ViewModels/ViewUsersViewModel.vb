Imports System.ComponentModel
Imports AllAboutTeethDCMS

Public Class ViewUsersViewModel
    Implements INotifyPropertyChanged

    Private m_container As WrapPanel
    Private m_database As Database
    Private m_users As ArrayList

    Public Sub New()
        m_database = New Database(Me)
        Users = New ArrayList
    End Sub

    Public Sub addUsers()
        Container.Children.Clear()
        For i = 0 To Users.Count - 1
            Dim userView As New UserView
            TryCast(userView.DataContext, UserViewViewModel).User = Users(i)
            Container.Children.Add(userView)
        Next
    End Sub

    Public Sub loadUsers()
        Users.Clear()
        Database.getUsers()
    End Sub

    Public Property Container As WrapPanel
        Get
            Return m_container
        End Get
        Set(value As WrapPanel)
            m_container = value
            loadUsers()
        End Set
    End Property

    Public Property Database As Database
        Get
            Return m_database
        End Get
        Set(value As Database)
            m_database = value
        End Set
    End Property

    Public Property Users As ArrayList
        Get
            Return m_users
        End Get
        Set(value As ArrayList)
            m_users = value
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Public Sub OnPropertyChanged(propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
