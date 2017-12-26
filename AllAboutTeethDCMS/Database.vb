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

    Public Sub New(m_addNewUserAccountViewModel As AddAccountViewModel)
        Me.m_addUserAccountViewModel = m_addUserAccountViewModel
        createConnection()
    End Sub

    Private Sub createConnection()
        Connection = New MySqlConnection()
        Connection.ConnectionString = "server=localhost; user=allaboutteeth; password=allaboutteeth; database=allaboutteeth_database"
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
        Dim insertCommad As MySqlCommand = Connection.CreateCommand
        insertCommad.CommandText = ""
        insertCommad.Prepare()
        insertCommad.ExecuteNonQuery()
    End Sub
End Class
