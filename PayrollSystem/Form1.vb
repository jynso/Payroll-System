Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Labelwelcome.Location = New Point(Labelwelcome.Left - whale.Left, Labelwelcome.Top - whale.Top)
        Labelwelcome.Parent = whale

        Labelusername.Location = New Point(Labelusername.Left - whale.Left, Labelusername.Top - whale.Top)
        Labelusername.Parent = whale

        txtboxusername.Location = New Point(txtboxusername.Left - whale.Left, txtboxusername.Top - whale.Top)
        txtboxusername.Parent = whale

        txtboxpassword.PasswordChar = "*"c

        'Labelpassword.Location = New Point(Labelpassword.Left - whale.Left, Labelpassword.Top - whale.Top)
        'Labelpassword.Parent = whale




    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Me.Hide()
        DashboardAdmin.Show()
    End Sub
End Class
