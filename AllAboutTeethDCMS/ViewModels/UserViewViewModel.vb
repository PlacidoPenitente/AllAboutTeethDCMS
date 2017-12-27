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

    Public Property AccountType As String
        Get
            Return User.AccountType
        End Get
        Set(value As String)
            User.AccountType = value
            OnPropertyChanged("AccountType")
        End Set
    End Property

    Public Property FamilyName As String
        Get
            Return User.FamilyName
        End Get
        Set(value As String)
            User.FamilyName = value
            OnPropertyChanged("FamilyName")
        End Set
    End Property

    Public Property GivenName As String
        Get
            Return User.GivenName
        End Get
        Set(value As String)
            User.GivenName = value
            OnPropertyChanged("GivenName")
        End Set
    End Property

    Public Property MiddleInitial As String
        Get
            Return User.MiddleInitial
        End Get
        Set(value As String)
            User.MiddleInitial = value
            OnPropertyChanged("MiddleInitial")
        End Set
    End Property

    Public Property Birthdate As Date
        Get
            Return User.Birthdate
        End Get
        Set(value As Date)
            User.Birthdate = value
            OnPropertyChanged("Birthdate")
        End Set
    End Property

    Public Property AccountID As String
        Get
            Return User.AccountID
        End Get
        Set(value As String)
            User.AccountID = value
            OnPropertyChanged("AccountID")
        End Set
    End Property

    Public Property Password As String
        Get
            Return User.Password
        End Get
        Set(value As String)
            User.Password = value
            OnPropertyChanged("Password")
        End Set
    End Property

    Public Property Gender As String
        Get
            Return User.Gender
        End Get
        Set(value As String)
            User.Gender = value
            OnPropertyChanged("Gender")
        End Set
    End Property

    Public Property ContactNo As String
        Get
            Return User.ContactNo
        End Get
        Set(value As String)
            User.ContactNo = value
            OnPropertyChanged("ContactNo")
        End Set
    End Property

    Public Property Address As String
        Get
            Return User.Address
        End Get
        Set(value As String)
            User.Address = value
            OnPropertyChanged("Address")
        End Set
    End Property

    Public Property EmailAddress As String
        Get
            Return User.EmailAddress
        End Get
        Set(value As String)
            User.EmailAddress = value
            OnPropertyChanged("EmailAddress")
        End Set
    End Property

    Public Property Image As String
        Get
            Return User.Image
        End Get
        Set(value As String)
            User.Image = value
            OnPropertyChanged("Image")
        End Set
    End Property

    Public Property Question1 As String
        Get
            Return User.Question1
        End Get
        Set(value As String)
            User.Question1 = value
            OnPropertyChanged("Question1")
        End Set
    End Property

    Public Property Question2 As String
        Get
            Return User.Question2
        End Get
        Set(value As String)
            User.Question2 = value
            OnPropertyChanged("Question2")
        End Set
    End Property

    Public Property Question3 As String
        Get
            Return User.Question3
        End Get
        Set(value As String)
            User.Question3 = value
            OnPropertyChanged("Question3")
        End Set
    End Property

    Public Property Answer1 As String
        Get
            Return User.Answer1
        End Get
        Set(value As String)
            User.Answer1 = value
            OnPropertyChanged("Answer1")
        End Set
    End Property

    Public Property Answer2 As String
        Get
            Return User.Answer2
        End Get
        Set(value As String)
            User.Answer2 = value
            OnPropertyChanged("Answer2")
        End Set
    End Property

    Public Property Answer3 As String
        Get
            Return User.Answer3
        End Get
        Set(value As String)
            User.Answer3 = value
            OnPropertyChanged("Answer3")
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Public Sub OnPropertyChanged(propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
