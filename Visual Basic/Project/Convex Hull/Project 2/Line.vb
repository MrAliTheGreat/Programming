Public Class Line
    Public Sub CreateLine()
        Dim a, b As New PointID
        Dim m, x, y As Double
        m = (b.y - a.y) / (b.x - a.x)
        y = m * (x - a.x) + a.y
    End Sub
End Class
