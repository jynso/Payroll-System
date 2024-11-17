Imports System.Configuration
Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
Imports System.Data.SQLite
Imports System.DirectoryServices.ActiveDirectory
Public Class ManageEmp

    Public connString As String = "Data Source=C:\Users\ecwt2\source\repos\PayrollSystem\PayrollSystem\bin\Debug\net8.0-windows\Information.db;Version=3;"
    Private Sub ManageEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        Close()
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

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click

        Dim selectedText As String = LBdisplay.GetItemText(LBdisplay.SelectedItem)

        Dim Iddata As String = selectedText.Split("|c")(0).Trim()

        Using connection As New SQLiteConnection(connString)
            connection.Open()

            Dim deleteitem As String = "DELETE FROM Details WHERE Id = @Id"
            Using command As New SQLiteCommand(deleteitem, connection)
                command.Parameters.AddWithValue("@Id", Iddata)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

            End Using
        End Using


    End Sub
End Class