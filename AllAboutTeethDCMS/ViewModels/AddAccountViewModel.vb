Imports System.ComponentModel

Public Class AddAccountViewModel
    Implements INotifyPropertyChanged
    Private user As New User

    Public Property FamilyName As String
        Get
            Return user.FamilyName
        End Get
        Set(value As String)
            user.FamilyName = value
        End Set
    End Property

    Public Property GivenName As String
        Get
            Return user.GivenName
        End Get
        Set(value As String)
            user.GivenName = value
        End Set
    End Property

    Public Property MiddleInitial As String
        Get
            Return user.MiddleInitial
        End Get
        Set(value As String)
            user.MiddleInitial = value
        End Set
    End Property

    Public Property Birthdate As Date
        Get
            Return user.Birthdate
        End Get
        Set(value As Date)
            user.Birthdate = value
        End Set
    End Property

    Public Property AccountID As String
        Get
            Return user.AccountID
        End Get
        Set(value As String)
            user.AccountID = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return user.Password
        End Get
        Set(value As String)
            user.Password = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return user.Gender
        End Get
        Set(value As String)
            user.Gender = value
        End Set
    End Property

    Public Property ContactNo As String
        Get
            Return user.ContactNo
        End Get
        Set(value As String)
            user.ContactNo = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return user.Address
        End Get
        Set(value As String)
            user.Address = value
        End Set
    End Property

    Public Property EmailAddress As String
        Get
            Return user.EmailAddress
        End Get
        Set(value As String)
            user.EmailAddress = value
        End Set
    End Property

    Public Property Image As String
        Get
            Return user.Image
        End Get
        Set(value As String)
            user.Image = value
        End Set
    End Property

    Public Property Question1 As String
        Get
            Return user.Question1
        End Get
        Set(value As String)
            user.Question1 = value
        End Set
    End Property

    Public Property Question2 As String
        Get
            Return user.Question2
        End Get
        Set(value As String)
            user.Question2 = value
        End Set
    End Property

    Public Property Question3 As String
        Get
            Return user.Question3
        End Get
        Set(value As String)
            user.Question3 = value
        End Set
    End Property

    Public Property Answer1 As String
        Get
            Return user.Answer1
        End Get
        Set(value As String)
            user.Answer1 = value
        End Set
    End Property

    Public Property Answer2 As String
        Get
            Return user.Answer2
        End Get
        Set(value As String)
            user.Answer2 = value
        End Set
    End Property

    Public Property Answer3 As String
        Get
            Return user.Answer3
        End Get
        Set(value As String)
            user.Answer3 = value
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
