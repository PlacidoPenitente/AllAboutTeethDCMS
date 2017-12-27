Imports System.ComponentModel
Imports AllAboutTeethDCMS

Public Class ViewUsersViewModel
    Implements INotifyPropertyChanged

    Private m_container As WrapPanel
    Private m_database As Database

    Public Sub New()
        m_database = New Database(Me)
    End Sub

    Public Sub loadUsers()
        For i = 0 To 100
            Container.Children.Add(New UserView)
        Next
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

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Public Sub OnPropertyChanged(propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
