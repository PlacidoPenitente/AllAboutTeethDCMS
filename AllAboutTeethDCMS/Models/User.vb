Public Class User
    Inherits Person
    Private m_accountid As String = "2012-102622"
    Private m_position As String = "Admnistrator"
    Private m_password As String = "12345"
    Private m_question1 As String = "q1"
    Private m_answer1 As String = "a1"
    Private m_question2 As String = "q2"
    Private m_answer2 As String = "a2"
    Private m_question3 As String = "q3"
    Private m_answer3 As String = "a3"

    Public Property AccountID As String
        Get
            Return m_accountid
        End Get
        Set(value As String)
            m_accountid = value
        End Set
    End Property

    Public Property Position As String
        Get
            Return m_position
        End Get
        Set(value As String)
            m_position = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return m_password
        End Get
        Set(value As String)
            m_password = value
        End Set
    End Property

    Public Property Question1 As String
        Get
            Return m_question1
        End Get
        Set(value As String)
            m_question1 = value
        End Set
    End Property

    Public Property Question2 As String
        Get
            Return m_question2
        End Get
        Set(value As String)
            m_question2 = value
        End Set
    End Property

    Public Property Question3 As String
        Get
            Return m_question3
        End Get
        Set(value As String)
            m_question3 = value
        End Set
    End Property

    Public Property Answer1 As String
        Get
            Return m_answer1
        End Get
        Set(value As String)
            m_answer1 = value
        End Set
    End Property

    Public Property Answer2 As String
        Get
            Return m_answer2
        End Get
        Set(value As String)
            m_answer2 = value
        End Set
    End Property

    Public Property Answer3 As String
        Get
            Return m_answer3
        End Get
        Set(value As String)
            m_answer3 = value
        End Set
    End Property
End Class
