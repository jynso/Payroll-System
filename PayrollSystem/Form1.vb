Imports System.Data.SQLite
Public Class Login


    Dim adminUsername As String = "admin"
    Dim adminPassword As String = "admin"

    Public connString As String = "Data Source=C:\Users\ecwt2\source\repos\PayrollSystem\PayrollSystem\bin\Debug\net8.0-windows\Information.db;Version=3;"
    Public connection As SQLiteConnection
    Public Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection = New SQLiteConnection(connString)
        connection.Open()

        Labelwelcome.Location = New Point(Labelwelcome.Left - whale.Left, Labelwelcome.Top - whale.Top)
        Labelwelcome.Parent = whale

        Labelusername.Location = New Point(Labelusername.Left - whale.Left, Labelusername.Top - whale.Top)
        Labelusername.Parent = whale

        txtboxusername.Location = New Point(txtboxusername.Left - whale.Left, txtboxusername.Top - whale.Top)
        txtboxusername.Parent = whale

        txtboxpassword.PasswordChar = "*"c

    End Sub

    Public Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        username = txtboxusername.Text
        Dim password As String = txtboxpassword.Text

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Error please try again", "Login Error", MessageBoxButtons.OK)
            Return
        End If

        If username = adminPassword AndAlso password = adminUsername Then
            DashboardAdmin.Show()
            Me.Hide()
            txtboxusername.Text = ""
            txtboxpassword.Text = ""
        End If

        Dim query As String = "SELECT COUNT(*) FROM Details WHERE Name = @Name AND Password = @Password"
        Dim command As New SQLiteCommand(query, connection)
        command.Parameters.AddWithValue("@Name", username)
        command.Parameters.AddWithValue("@Password", password)

        Dim logintrigger As Integer = Convert.ToInt32(command.ExecuteScalar())

        If logintrigger > 0 Then
            MessageBox.Show("Login successful", "Login", MessageBoxButtons.OK)

            DashboardEmp.Show()
            txtboxusername.Text = ""
            txtboxpassword.Text = ""

        End If
    End Sub

End Class
