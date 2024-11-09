Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Labelwelcome.Location = New Point(Labelwelcome.Left - dolphin.Left, Labelwelcome.Top - dolphin.Top)
        Labelwelcome.Parent = dolphin

        Labelusername.Location = New Point(Labelusername.Left - dolphin.Left, Labelusername.Top - dolphin.Top)
        Labelusername.Parent = dolphin

        Labelpassword.Location = New Point(Labelpassword.Left - dolphin.Left, Labelpassword.Top - dolphin.Top)
        Labelpassword.Parent = dolphin


    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Me.Hide()
        DashboardAdmin.Show()
    End Sub
End Class
