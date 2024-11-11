Imports System.Data.SQLite
Public Class Login

    Public dbCommand As String = ""
    Public bindinSrc As BindingSource

    Public dbName As String = "Information.db"
    Public dbPath As String = Application.StartupPath & "\" & dbName
    Public connString As String = "Data Source=" & dbPath & ";Version=3"

    Public connection As New SQLiteConnection(connString)
    Public command As New SQLiteCommand("", connection)

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection.Open()

        If connection.State = ConnectionState.Open Then
            MsgBox("The connection is: " & connection.State.ToString)

        End If
        Labelwelcome.Location = New Point(Labelwelcome.Left - whale.Left, Labelwelcome.Top - whale.Top)
        Labelwelcome.Parent = whale

        Labelusername.Location = New Point(Labelusername.Left - whale.Left, Labelusername.Top - whale.Top)
        Labelusername.Parent = whale

        txtboxusername.Location = New Point(txtboxusername.Left - whale.Left, txtboxusername.Top - whale.Top)
        txtboxusername.Parent = whale

        txtboxpassword.PasswordChar = "*"c

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Me.Hide()
        DashboardAdmin.Show()
    End Sub
End Class
