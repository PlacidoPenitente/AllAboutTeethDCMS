Public Class Person
    Private m_familyname As String = "Estrera"
    Private m_givenname As String = "Jay Mark"
    Private m_middleinitial As String = "P"
    Private m_gender As String = "Male"
    Private m_birthdate As Date = Date.Now
    Private m_contactno As String = "09568032571"
    Private m_address As String = "Taytay, Rizal"
    Private m_emailaddress As String = "estrerajaymark@ymail.com"
    Private m_image As String = "none"


    Public Property FamilyName As String
        Get
            Return m_familyname
        End Get
        Set(value As String)
            m_familyname = value
        End Set
    End Property

    Public Property GivenName As String
        Get
            Return m_givenname
        End Get
        Set(value As String)
            m_givenname = value
        End Set
    End Property

    Public Property MiddleInitial As String
        Get
            Return m_middleinitial
        End Get
        Set(value As String)
            m_middleinitial = value
        End Set
    End Property

    Public Property Birthdate As Date
        Get
            Return m_birthdate
        End Get
        Set(value As Date)
            m_birthdate = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return m_gender
        End Get
        Set(value As String)
            m_gender = value
        End Set
    End Property

    Public Property ContactNo As String
        Get
            Return m_contactno
        End Get
        Set(value As String)
            m_contactno = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return m_address
        End Get
        Set(value As String)
            m_address = value
        End Set
    End Property

    Public Property EmailAddress As String
        Get
            Return m_emailaddress
        End Get
        Set(value As String)
            m_emailaddress = value
        End Set
    End Property

    Public Property Image As String
        Get
            Return m_image
        End Get
        Set(value As String)
            m_image = value
        End Set
    End Property

End Class
