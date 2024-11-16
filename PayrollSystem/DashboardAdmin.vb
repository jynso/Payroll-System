Imports System.Data.SQLite
Public Class DashboardAdmin

    
    Private Sub DashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Btnlogout_Click(sender As Object, e As EventArgs) Handles Btnlogout.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub Btnmanage_Click(sender As Object, e As EventArgs) Handles Btnmanage.Click
        ManageEmp.Show()
    End Sub


End Class