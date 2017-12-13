Public Class AddAccountViewModel
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
End Class
