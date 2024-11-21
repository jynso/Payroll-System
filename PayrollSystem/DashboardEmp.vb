Imports System.Data.SQLite
Imports System.Net

Public Class DashboardEmp

    Public connString As String = "Data Source=C:\Users\ecwt2\source\repos\PayrollSystem\PayrollSystem\bin\Debug\net8.0-windows\Information.db;Version=3;"
    Public connection As SQLiteConnection
    Private Sub DashbonardEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection = New SQLiteConnection(connString)
        connection.Open()

        'rounded corners mabisa
        Dim gp As New System.Drawing.Drawing2D.GraphicsPath()
        Dim radius As Integer = 30
        Dim rect As New Rectangle(0, 0, Panel1.Width, Panel1.Height)

        gp.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        gp.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        gp.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        gp.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        gp.CloseFigure()

        Panel1.Region = New Region(gp)

        labelname.Text = username

        Dim command As New SQLiteCommand("SELECT Name, Hours_Work, Hour_Rate, Password, Overtime, Bonus, Income_Tax FROM Details WHERE Name = @Name", connection)
        command.Parameters.AddWithValue("@Name", username)

        Dim reader As SQLiteDataReader = command.ExecuteReader()

        If reader.Read Then
            Dim hourswork As Integer = Convert.ToInt32(reader("Hours_Work"))
            Dim hourrate As Integer = Convert.ToInt32(reader("Hour_Rate"))
            Dim overtime As Integer = Convert.ToInt32(reader("Overtime"))
            Dim bonus As Integer = Convert.ToInt32(reader("Bonus"))
            Dim incometax As Integer = Convert.ToInt32(reader("Income_Tax"))

            namedepends.Text = reader("Name")
            ratedepends.Text = reader("Hour_Rate")
            otdepends.Text = reader("Overtime")
            bonusdepends.Text = reader("Bonus")
            incometaxtxt.Text = reader("Income_Tax")

            Dim regularpay As Integer = hourswork * hourrate
            Dim grosspay As Integer = regularpay + overtime + bonus
            Dim tax As Integer = grosspay * incometax
            Dim netpay As Integer = grosspay - tax

            regularpaytxt.Text = regularpay
            grosspaytxt.Text = grosspay
            incometaxtxt.Text = tax
            netpaytxt.Text = netpay
        End If


    End Sub


    Private Sub Btnlogout_Click(sender As Object, e As EventArgs) Handles Btnlogout.Click

        Login.Show()
        Me.Close()
    End Sub
End Class