Imports System.Threading
Imports AllAboutTeethDCMS
Imports MySql.Data.MySqlClient

Public Class Database
    Private m_connection As MySqlConnection
    Private m_addUserAccountViewModel As AddAccountViewModel
    Private m_insertThread As Thread

    Public Property AddUserAccountViewModel As AddAccountViewModel
        Get
            Return m_addUserAccountViewModel
        End Get
        Set(value As AddAccountViewModel)
            m_addUserAccountViewModel = value
        End Set
    End Property

    Public Property Connection As MySqlConnection
        Get
            Return m_connection
        End Get
        Set(value As MySqlConnection)
            m_connection = value
        End Set
    End Property

    Public Sub New(x As AddAccountViewModel)
        m_addUserAccountViewModel = x
        createConnection()
    End Sub

    Private Sub createConnection()
        Connection = New MySqlConnection()
        Connection.ConnectionString = "server=localhost; user=allaboutteeth; password=allaboutteeth; database=allaboutteeth_database"
        Connection.Open()
    End Sub

    Public Sub insertUser()
        If IsNothing(m_insertThread) Then
            m_insertThread = New Thread(AddressOf startInsertProcess)
            m_insertThread.IsBackground = True
            m_insertThread.Start()
        End If
        If Not m_insertThread.IsAlive Then
            m_insertThread = New Thread(AddressOf startInsertProcess)
            m_insertThread.IsBackground = True
            m_insertThread.Start()
        End If
    End Sub

    Private Sub startInsertProcess()
        Dim insertCommand As MySqlCommand = Connection.CreateCommand
        insertCommand.CommandText = "INSERT INTO allaboutteeth_users VALUES (NULL, @id, @fname, @lname, @mi, @address, @email, @contact, @password, @gender, @image, @q1, @q2, @q3, @a1, @a2, @a3, @bday, NOW(), NOW(), @current);"
        insertCommand.Parameters.AddWithValue("@id", AddUserAccountViewModel.User.AccountID)
        insertCommand.Parameters.AddWithValue("@fname", AddUserAccountViewModel.User.GivenName)
        insertCommand.Parameters.AddWithValue("@lname", AddUserAccountViewModel.User.FamilyName)
        insertCommand.Parameters.AddWithValue("@mi", AddUserAccountViewModel.User.MiddleInitial)
        insertCommand.Parameters.AddWithValue("@address", AddUserAccountViewModel.User.Address)
        insertCommand.Parameters.AddWithValue("@email", AddUserAccountViewModel.User.EmailAddress)
        insertCommand.Parameters.AddWithValue("@contact", AddUserAccountViewModel.User.ContactNo)
        insertCommand.Parameters.AddWithValue("@password", AddUserAccountViewModel.User.Password)
        insertCommand.Parameters.AddWithValue("@gender", AddUserAccountViewModel.User.Gender)
        insertCommand.Parameters.AddWithValue("@image", AddUserAccountViewModel.User.Image)
        insertCommand.Parameters.AddWithValue("@q1", AddUserAccountViewModel.User.Question1)
        insertCommand.Parameters.AddWithValue("@q2", AddUserAccountViewModel.User.Question2)
        insertCommand.Parameters.AddWithValue("@q3", AddUserAccountViewModel.User.Question3)
        insertCommand.Parameters.AddWithValue("@a1", AddUserAccountViewModel.User.Answer1)
        insertCommand.Parameters.AddWithValue("@a2", AddUserAccountViewModel.User.Answer2)
        insertCommand.Parameters.AddWithValue("@a3", AddUserAccountViewModel.User.Answer3)
        insertCommand.Parameters.AddWithValue("@bday", AddUserAccountViewModel.User.Birthdate)
        insertCommand.Parameters.AddWithValue("@current", AddUserAccountViewModel.CurrentUser.AccountID)
        insertCommand.Prepare()
        insertCommand.ExecuteNonQuery()
    End Sub
End Class
