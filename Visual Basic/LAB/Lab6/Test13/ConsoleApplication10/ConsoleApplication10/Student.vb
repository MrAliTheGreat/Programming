Public Class Student
    Public ID As Long
    Public FN, LN As String
    Public Courses As New List(Of String)
    Public CourseGrades As New List(Of Integer)

    Public Function Average() As Double
        Dim Sum As Integer = 0
        For i As Integer = 0 To CourseGrades.Count - 1
            Sum = Sum + CourseGrades(i)
        Next

        Return Sum / CourseGrades.Count

    End Function

    'Public Sub TypeGrades()
    '    If Courses.Count <> CourseGrades.Count Then
    '        Console.WriteLine("Courses.Count <> CourseGrades.Count")
    '        Exit Sub
    '    End If

    '    For i As Integer = 0 To Courses.Count - 1
    '        Console.WriteLine(Courses(i) & " : " & CourseGrades(i))
    '    Next
    'End Sub
End Class
