Module Module1

    Sub Main()
        Dim n, m, l, min, max As Integer
        Console.WriteLine("This Program is Designed to Find MIN and MAX in Series of Numbers")
        Console.Write("How Many Numbers Do You Want? ")
        n = Console.ReadLine
        Console.WriteLine("Please Enter Your Numbers: ")
        m = Console.ReadLine
        max = m
        min = m
        For i As Integer = 1 To n - 1
            l = Console.ReadLine
            If l > max Then
                max = l
            End If
            If l < min Then
                min = l
            End If
        Next
        Console.WriteLine("MIN is: " & min)
        Console.WriteLine("MAX is: " & max)
        Console.ReadLine()

    End Sub

End Module
