Module Module1

    Sub Main()
        Dim student1 As New Student
        student1.ID = 123456789
        student1.FN = "Ali"
        student1.LN = "Moradi"
        student1.Courses.Add("Static")
        student1.Courses.Add("Math")
        student1.Courses.Add("Programming")
        student1.CourseGrades.Add(20)
        student1.CourseGrades.Add(18)
        student1.CourseGrades.Add(7)
        'student1.TypeGrades()
        TypeGrades(student1)
        Console.WriteLine("Average: " & student1.Average)

        Dim student2 As New Student
        student2.ID = 123456788
        student2.FN = "Sara"
        student2.LN = "Moradi"
        student2.Courses.Add("Static")
        student2.Courses.Add("Math")
        student2.Courses.Add("Programming")
        student2.CourseGrades.Add(10)
        student2.CourseGrades.Add(12)
        student2.CourseGrades.Add(19)
        'student2.TypeGrades()
        TypeGrades(student2)
        Console.WriteLine("Average: " & student2.Average)


        Console.ReadLine()

    End Sub

    Public Sub TypeGrades(ByVal Mystudent As Student)
        If Mystudent.Courses.Count <> Mystudent.CourseGrades.Count Then
            Console.WriteLine("Courses.Count <> CourseGrades.Count")
            Exit Sub
        End If

        For i As Integer = 0 To Mystudent.Courses.Count - 1
            Console.WriteLine(Mystudent.Courses(i) & " : " & Mystudent.CourseGrades(i))
        Next
    End Sub


End Module
