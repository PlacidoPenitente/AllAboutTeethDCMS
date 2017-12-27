Imports System.Threading
Imports AllAboutTeethDCMS
Imports MySql.Data.MySqlClient

Public Class Database
    Private m_connection As MySqlConnection
    Private m_addUserAccountViewModel As AddAccountViewModel
    Private m_viewUsersViewModel As ViewUsersViewModel
    Private m_insertThread As Thread
    Private m_getUsersThread As Thread

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

    Public Property ViewUsersViewModel As ViewUsersViewModel
        Get
            Return m_viewUsersViewModel
        End Get
        Set(value As ViewUsersViewModel)
            m_viewUsersViewModel = value
        End Set
    End Property

    Public Sub New(viewModel As AddAccountViewModel)
        m_addUserAccountViewModel = viewModel
        createConnection()
    End Sub

    Public Sub New(viewModel As ViewUsersViewModel)
        m_viewUsersViewModel = viewModel
        createConnection()
    End Sub

    Private Sub createConnection()
        Connection = New MySqlConnection()
        Connection.ConnectionString = "server=localhost; user=allaboutteeth; password=allaboutteeth; database=allaboutteeth_database"
        Connection.Open()
    End Sub

    Public Sub getUsers()
        If IsNothing(m_getUsersThread) Then
            m_getUsersThread = New Thread(AddressOf startGettingUserProcess)
            m_getUsersThread.IsBackground = True
            m_getUsersThread.Start()
        End If
        If Not m_getUsersThread.IsAlive Then
            m_getUsersThread = New Thread(AddressOf startGettingUserProcess)
            m_getUsersThread.IsBackground = True
            m_getUsersThread.Start()
        End If
    End Sub

    Private Sub startGettingUserProcess()
        Dim getCommand As MySqlCommand = Connection.CreateCommand
        getCommand.CommandText = "SELECT * FROM allaboutteeth_users"
        Dim usersReader As MySqlDataReader = getCommand.ExecuteReader()
        While usersReader.Read()
            Dim user As New User
            user.AccountID = usersReader.GetString("user_id")
            user.Image = usersReader.GetString("user_image")
            user.FamilyName = usersReader.GetString("user_lname")
            user.GivenName = usersReader.GetString("user_fname")
            user.MiddleInitial = usersReader.GetString("user_mi")
            user.Address = usersReader.GetString("user_address")
            user.EmailAddress = usersReader.GetString("user_email")
            user.ContactNo = usersReader.GetString("user_contact")
            ViewUsersViewModel.Users.Add(user)
        End While
        usersReader.Close()
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
        Try
            If Not AddUserAccountViewModel.User.AccountID = AddUserAccountViewModel.UserCopy.AccountID And Not AddUserAccountViewModel.UserCopy.AccountID = "" Then
                Throw New Exception
            End If
            Dim insertCommand As MySqlCommand = Connection.CreateCommand
            insertCommand.CommandText = "INSERT INTO allaboutteeth_users VALUES (NULL, @id, @type, @fname, @lname, @mi, @address, @email, @contact, @password, @gender, @image, @q1, @q2, @q3, @a1, @a2, @a3, @bday, NOW(), NOW(), @current);"
            insertCommand.Parameters.AddWithValue("@id", AddUserAccountViewModel.User.AccountID)
            insertCommand.Parameters.AddWithValue("@type", AddUserAccountViewModel.User.AccountType)
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
        Catch ex As Exception
            Dim insertCommand As MySqlCommand = Connection.CreateCommand
            insertCommand.CommandText = "UPDATE allaboutteeth_users SET user_id=@id, user_type=@type, user_fname=@fname, user_lname=@lname, user_mi=@mi, user_address=@address, user_email=@email, user_contact=@contact, user_password=@password, user_gender=@gender, user_image=@image, user_q1=@q1, user_q2=@q2, user_q3=@q3, user_a1=@a1, user_a2=@a2, user_a3=@a3, user_editedby=@current WHERE user_id=@original"
            insertCommand.Parameters.AddWithValue("@id", AddUserAccountViewModel.User.AccountID)
            insertCommand.Parameters.AddWithValue("@type", AddUserAccountViewModel.User.AccountType)
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
            insertCommand.Parameters.AddWithValue("@original", AddUserAccountViewModel.UserCopy.AccountID)
            insertCommand.Prepare()
            insertCommand.ExecuteNonQuery()
        End Try
    End Sub
End Class
