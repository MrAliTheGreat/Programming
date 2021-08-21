Public Class Student
    Public FN, LN As String
    Public ID As Long

    Public Overrides Function ToString() As String
        Return ID & "_" & FN & "_" & LN
    End Function
End Class
