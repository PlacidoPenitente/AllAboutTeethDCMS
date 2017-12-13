Public Class Person
    Private family_name As String = "Estrera"

    Public Property FamilyName As String
        Get
            Return family_name
        End Get
        Set(value As String)
            family_name = value
        End Set
    End Property
    Public Property GivenName As String
    Public Property MiddleInitial As String
    Public Property Birthdate As Date
    Public Property Gender As String
    Public Property ContactNo As String
    Public Property Address As String
    Public Property EmailAddress As String
    Public Property Image As String
End Class
