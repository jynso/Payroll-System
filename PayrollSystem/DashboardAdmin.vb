Public Class DashboardAdmin
    Private Sub DashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gp As New System.Drawing.Drawing2D.GraphicsPath()
        Dim radius As Integer = 30
        Dim rectpanel1 As New Rectangle(0, 0, Panel1.Width, Panel1.Height)
        'Dim rectlabel1 As New Rectangle(0, 0, Labeladd.Width, Labeladd.Height)

        gp.AddArc(rectpanel1.X, rectpanel1.Y, radius, radius, 180, 90)
        gp.AddArc(rectpanel1.Right - radius, rectpanel1.Y, radius, radius, 270, 90)
        gp.AddArc(rectpanel1.Right - radius, rectpanel1.Bottom - radius, radius, radius, 0, 90)
        gp.AddArc(rectpanel1.X, rectpanel1.Bottom - radius, radius, radius, 90, 90)
        gp.CloseFigure()

        Panel1.Region = New Region(gp)

        'gp.AddArc(rectlabel1.X, rectlabel1.Y, radius, radius, 180, 90)
        'gp.AddArc(rectlabel1.Right - radius, rectlabel1.Y, radius, radius, 270, 90)
        'gp.AddArc(rectlabel1.Right - radius, rectlabel1.Bottom - radius, radius, radius, 0, 90)
        'gp.AddArc(rectlabel1.X, rectlabel1.Bottom - radius, radius, radius, 90, 90)
        'gp.CloseFigure()

        'Labeladd.Region = New Region(gp)


    End Sub

    Private Sub Labeladd_Click(sender As Object, e As EventArgs) Handles Labeladd.Click

    End Sub
End Class