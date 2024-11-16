Imports System.Data.SQLite
Public Class Login

    Public connString As String = "Data Source=C:\Users\ecwt2\source\repos\PayrollSystem\PayrollSystem\bin\Debug\net8.0-windows\Information.db;Version=3;"

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Try
        '    Using connection As New SQLiteConnection(connString)
        '        connection.Open()
        '        MessageBox.Show("Database connection successful!")
        '    End Using

        'Catch ex As Exception
        '    MessageBox.Show("Error: " & ex.Message)
        'End Try


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
        DashboardEmp.Show()
    End Sub
End Class
