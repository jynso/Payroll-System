Public Class DashboardEmp
    Private Sub DashboardEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gp As New System.Drawing.Drawing2D.GraphicsPath()
        Dim radius As Integer = 30
        Dim rect As New Rectangle(0, 0, Panel1.Width, Panel1.Height)

        gp.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        gp.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        gp.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        gp.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        gp.CloseFigure()

        Panel1.Region = New Region(gp)
    End Sub
End Class