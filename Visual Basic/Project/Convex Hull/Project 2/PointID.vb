Public Class PointID
    Public x, y As Double
    Public Overrides Function ToString() As String
        Return "(" & x - 160 & "," & 160 - y & ")"
    End Function
End Class
