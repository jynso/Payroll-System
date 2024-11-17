Imports System.Configuration
Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
Imports System.Data.Entity.Infrastructure
Imports System.Data.SQLite
Imports System.DirectoryServices.ActiveDirectory
Public Class ManageEmp

    Public connString As String = "Data Source=C:\Users\ecwt2\source\repos\PayrollSystem\PayrollSystem\bin\Debug\net8.0-windows\Information.db;Version=3;"
    Public connection As SQLiteConnection
    Private Sub ManageEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection = New SQLiteConnection(connString)
        connection.Open()

        If connection.State = ConnectionState.Open Then

            Dim command As New SQLiteCommand()

            command.Connection = connection
            command.CommandText = "SELECT * FROM Details"

            Dim rdr As SQLiteDataReader = command.ExecuteReader

            Dim dataTable As New DataTable
            dataTable.Load(rdr)

            'lbdisplay.DataSource = dataTable

            For Each row As DataRow In dataTable.Rows

                Dim displayText As String = $"{row("Id")} - {row("Name")} -  {row("Base_Salary")} - {row("Hour_Rate")}"
                lbdisplay.Items.Add(displayText)
            Next
        End If



    End Sub
    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        Close()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        Dim idinput As String = InputBox("Enter Id:", "Add User")
        Dim id As Integer
        Integer.TryParse(idinput, id)

        Dim name As String = InputBox("Enter name:", "Add User")

        Dim salaryinput As String = InputBox("Enter Salary:", "Add User")
        Dim salary As Decimal
        Decimal.TryParse(salaryinput, salary)

        Dim rateinput As String = InputBox("Enter hour rate:", "Add User")
        Dim rate As Integer
        Integer.TryParse(rateinput, rate)

        Dim insertCommand As New SQLiteCommand("INSERT INTO Details (Id, Name, Base_Salary, Hour_Rate) VALUES (@Name, @Base_Salary, @Hour_Rate)", connection)
        insertCommand.Parameters.AddWithValue("@Id", id)
        insertCommand.Parameters.AddWithValue("@Name", name)
        insertCommand.Parameters.AddWithValue("@Base_Salary", salary)
        insertCommand.Parameters.AddWithValue("@Hour_Rate", rate)

        Dim displayText As String = $"{id} - {name} - {salary} - {rate}"
        lbdisplay.Items.Add(displayText)
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click

        Dim selectedItem As String = lbdisplay.SelectedItem.ToString()

        Dim selectedId As Integer

        selectedId = Integer.Parse(selectedItem.Split("-"c)(0).Trim())

        Dim deleteCommand As New SQLiteCommand($"DELETE FROM Details WHERE Id = @Id", connection)
        deleteCommand.Parameters.AddWithValue("@Id", selectedId)


        Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()
        lbdisplay.Items.Remove(lbdisplay.SelectedItem)



    End Sub
End Class