Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
Imports System.Data.SQLite
Public Class ManageEmp

    Public connString As String = "Data Source=C:\Users\ecwt2\source\repos\PayrollSystem\PayrollSystem\bin\Debug\net8.0-windows\Information.db;Version=3;"
    Private Sub ManageEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        Me.Close()
    End Sub
    Private Sub LoadData()

        Try
            Using connection As New SQLiteConnection(connString)

                connection.Open()

                Dim query As String = "SELECT CONCAT(Id, ' | ', Name, ' | ', Base_Salary, ' | ', Hour_Rate) AS Details FROM Details"
                Dim adapter As New SQLiteDataAdapter(query, connection)
                Dim dataTable As New DataTable()


                adapter.Fill(dataTable)

                LBdisplay.DataSource = dataTable
                LBdisplay.DisplayMember = "Details"




            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


End Class