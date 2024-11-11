Public Class DashboardAdmin
    Private Sub DashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim radius As Integer = 30

        'Dim gp As New System.Drawing.Drawing2D.GraphicsPath()
        'Dim rectpanel1 As New Rectangle(0, 0, Btnmanage.Width, Btnmanage.Height)


        'gp.AddArc(rectpanel1.X, rectpanel1.Y, radius, radius, 180, 90)
        'gp.AddArc(rectpanel1.Right - radius, rectpanel1.Y, radius, radius, 270, 90)
        'gp.AddArc(rectpanel1.Right - radius, rectpanel1.Bottom - radius, radius, radius, 0, 90)
        'gp.AddArc(rectpanel1.X, rectpanel1.Bottom - radius, radius, radius, 90, 90)
        'gp.CloseFigure()

        'Btnmanage.Region = New Region(gp)

        'Dim gp2 As New System.Drawing.Drawing2D.GraphicsPath()
        'Dim rectpanel2 As New Rectangle(0, 0, Btnpayslip.Width, Btnpayslip.Height)

        'gp2.AddArc(rectpanel2.X, rectpanel2.Y, radius, radius, 180, 90)
        'gp2.AddArc(rectpanel2.Right - radius, rectpanel2.Y, radius, radius, 270, 90)
        'gp2.AddArc(rectpanel2.Right - radius, rectpanel2.Bottom - radius, radius, radius, 0, 90)
        'gp2.AddArc(rectpanel2.X, rectpanel2.Bottom - radius, radius, radius, 90, 90)
        'gp2.CloseFigure()

        'Btnpayslip.Region = New Region(gp2)

    End Sub

    Private Sub Btnlogout_Click(sender As Object, e As EventArgs) Handles Btnlogout.Click
        Login.Show()
        Me.Close()

    End Sub
End Class