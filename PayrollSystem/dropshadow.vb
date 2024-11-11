Public Class dropshadow
    Inherits Panel

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim shadowColor As Color = Color.FromArgb(100, Color.Black) ' Semi-transparent black
        Dim shadowOffset As Integer = 10

        Using shadowBrush As New SolidBrush(shadowColor)
            e.Graphics.FillRectangle(shadowBrush, shadowOffset, shadowOffset, Width, Height)
        End Using
    End Sub
End Class
