Imports System.ComponentModel
Imports AllAboutTeethDCMS

Public Class UserViewViewModel
    Implements INotifyPropertyChanged
    Private m_user As User

    Public Property User As User
        Get
            Return m_user
        End Get
        Set(value As User)
            m_user = value
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Public Sub OnPropertyChanged(propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
