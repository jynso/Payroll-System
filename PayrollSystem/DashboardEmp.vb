Imports System.Data.Entity

Public Class DashboardEmp
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

        'for database
        Dim SQLite_conn As SQLite.SQLiteConnection
        SQLite_conn = New SQLite.SQLiteConnection("Data source=C:\Users\ecwt2\source\repos\PayrollSystem\PayrollSystem\Information.db;")
        SQLite_conn.Open()
        SQLite_conn.Close()
        MsgBox("Database Connected.", vbOKOnly)

    End Sub
End Class