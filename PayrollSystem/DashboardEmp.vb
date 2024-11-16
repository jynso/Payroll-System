Imports System.Data.Entity
Imports System.Data.SQLite

Public Class DashboardEmp
    Public connString As String = "Data Source=C:\Users\ecwt2\source\repos\PayrollSystem\PayrollSystem\bin\Debug\net8.0-windows\Information.db;Version=3;"
    Private Sub DashboardEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For rounded corners
        Dim gp As New System.Drawing.Drawing2D.GraphicsPath()
        Dim radius As Integer = 30
        Dim rect As New Rectangle(0, 0, Panel1.Width, Panel1.Height)

        gp.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        gp.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        gp.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        gp.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        gp.CloseFigure()

        Panel1.Region = New Region(gp)

        LoadData()

    End Sub

    Private Sub LoadData()
        Try
            Using connection As New SQLiteConnection(connString)
                connection.Open()
                Dim query As String = "SELECT * FROM Details"
                Dim adapter As New SQLiteDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                adapter.Fill(dataTable) ' Fill the DataTable with data
                ListBox1.DataSource = dataTable ' Bind the DataTable to the DataGridView
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
End Class