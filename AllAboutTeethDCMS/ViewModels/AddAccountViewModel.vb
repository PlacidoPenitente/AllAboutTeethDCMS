Imports System.ComponentModel
Imports AllAboutTeethDCMS

Public Class AddAccountViewModel
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Private m_databaseConnection As Database
    Private m_user As User
    Private m_currentUser As User
    Private m_genders As ArrayList
    Private m_accountTypes As ArrayList
    Private m_userCopy As User

    Public Sub New()
        m_user = New User()
        CurrentUser = New User()
        m_databaseConnection = New Database(Me)
        m_genders = New ArrayList()
        m_genders.Add("Male")
        m_genders.Add("Female")
        m_accountTypes = New ArrayList()
        m_accountTypes.Add("Dentist")
        m_accountTypes.Add("Staff")
        m_userCopy = m_user.Clone()
    End Sub

    Public Sub OnPropertyChanged(propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

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

    Public Property DatabaseConnection As Database
        Get
            Return m_databaseConnection
        End Get
        Set(value As Database)
            m_databaseConnection = value
        End Set
    End Property

    Public Property User As User
        Get
            Return m_user
        End Get
        Set(value As User)
            m_user = value
        End Set
    End Property

    Public Property CurrentUser As User
        Get
            Return m_currentUser
        End Get
        Set(value As User)
            m_currentUser = value
        End Set
    End Property

    Public Property Genders As ArrayList
        Get
            Return m_genders
        End Get
        Set(value As ArrayList)
            m_genders = value
        End Set
    End Property

    Public Property AccountTypes As ArrayList
        Get
            Return m_accountTypes
        End Get
        Set(value As ArrayList)
            m_accountTypes = value
        End Set
    End Property

    Public Property UserCopy As User
        Get
            Return m_userCopy
        End Get
        Set(value As User)
            m_userCopy = value
        End Set
    End Property

    Public Sub insertUser()
        DatabaseConnection.insertUser()
    End Sub
End Class
