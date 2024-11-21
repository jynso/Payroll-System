Imports System.Data.SQLite
Public Class DashboardAdmin

    Public connString As String = "Data Source=C:\Users\ecwt2\source\repos\PayrollSystem\PayrollSystem\bin\Debug\net8.0-windows\Information.db;Version=3;"
    Public connection As SQLiteConnection

    Private Sub DashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New SQLiteConnection(connString)
        connection.Open()

        If connection.State = ConnectionState.Open Then
            Loaduserdata()
        End If

    End Sub
    Private Sub Loaduserdata()
        If connection.State = ConnectionState.Open Then

            Dim command As New SQLiteCommand()

            command.Connection = connection
            command.CommandText = "SELECT * FROM Details"

            Dim rdr As SQLiteDataReader = command.ExecuteReader

            Dim dataTable As New DataTable
            dataTable.Load(rdr)

            For Each row As DataRow In dataTable.Rows

                Dim displayText As String = String.Format("{0}-{1,-20}{2,-10}{3,-5}{4,-5}{5,-5}{6,-5}{7,-5}",
                                         row("Id"),
                                         row("Name"),
                                         row("Password"),
                                         row("Hours_Work"),
                                         row("Hour_Rate"),
                                         row("Overtime"),
                                         row("Bonus"),
                                         row("Income_Tax"))
                lbdisplay.Items.Add(displayText)
            Next
        End If

    End Sub

    Private Sub Btnlogout_Click(sender As Object, e As EventArgs) Handles Btnlogout.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub Btnmanage_Click(sender As Object, e As EventArgs)
        ManageEmp.Show()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        Dim idinput As String = InputBox("Enter Id:")
        Dim id As Integer
        Integer.TryParse(idinput, id)

        Dim name As String = InputBox("Enter name:")

        Dim hourworkinput As String = InputBox("Enter hours work:")
        Dim hourwork As Decimal
        Decimal.TryParse(hourworkinput, hourwork)

        Dim pass As String = InputBox("Enter password:")

        Dim rateinput As String = InputBox("Enter hour rate:")
        Dim rate As Integer
        Integer.TryParse(rateinput, rate)

        Dim overtimeinput As String = InputBox("Enter overtime pay:")
        Dim ot As Integer
        Integer.TryParse(overtimeinput, ot)

        Dim bonusinput As String = InputBox("Enter bonus pay")
        Dim bonus As Integer
        Integer.TryParse(bonusinput, ot)

        Dim incomeinput As String = InputBox("Enter Income tax deduction")
        Dim income As Integer
        Integer.TryParse(incomeinput, income)



        Dim insertCommand As New SQLiteCommand("INSERT INTO Details (Id, Name, Password, Hours_Work, Hour_Rate, Overtime, Bonus, Income_Tax) VALUES (@Id, @Name, @Password, @Hours_Work, @Hour_Rate, @Overtime, @Bonus, @Income_Tax)", connection)
        insertCommand.Parameters.AddWithValue("@Id", id)
        insertCommand.Parameters.AddWithValue("@Name", name)
        insertCommand.Parameters.AddWithValue("@Password", pass)
        insertCommand.Parameters.AddWithValue("@Hours_Work", hourwork)
        insertCommand.Parameters.AddWithValue("@Hour_Rate", rate)
        insertCommand.Parameters.AddWithValue("@Overtime", ot)
        insertCommand.Parameters.AddWithValue("@Bonus", bonus)
        insertCommand.Parameters.AddWithValue("@Income_Tax", income)

        insertCommand.ExecuteNonQuery()

        lbdisplay.Items.Clear()
        Loaduserdata()
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click

        Dim selectedItem As String = lbdisplay.SelectedItem.ToString()

        Dim selectedId As Integer

        selectedId = Integer.Parse(selectedItem.Split("-"c)(0).Trim())

        Dim deleteCommand As New SQLiteCommand($"DELETE FROM Details WHERE Id = @Id", connection)
        deleteCommand.Parameters.AddWithValue("@Id", selectedId)


        Dim rowsAffected As Integer = deleteCommand.ExecuteNonQuery()
        lbdisplay.Items.Remove(lbdisplay.SelectedItem)

        lbdisplay.Items.Clear()
        Loaduserdata()

    End Sub


End Class