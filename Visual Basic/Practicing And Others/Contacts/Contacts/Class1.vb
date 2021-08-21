Public Class Contact
    Public FirstName, LastName, Number As String
    Public Overrides Function ToString() As String
        Return FirstName & " " & LastName
    End Function
End Class
