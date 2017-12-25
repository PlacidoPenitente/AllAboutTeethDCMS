Imports MySql.Data.MySqlClient

Public Class Database
    Private m_connection As MySqlConnection

    Public Sub _New()

    End Sub

    Private Sub createConnection()
        m_connection = New MySqlConnection()
        m_connection.ConnectionString = "server=localhost; user=allaboutteeth; password=allaboutteeth; database=allaboutteeth_database"
    End Sub
End Class
