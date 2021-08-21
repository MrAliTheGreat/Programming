Module Module1

    Sub Main()
        Dim a, b, j As Integer
        Console.WriteLine("This Program is Designed for finding odd and even number")
        Console.Write("How many times you want to repeat? ")

        j = Console.ReadLine

        For i As Integer = 1 To j
            Console.Write("Enter Number ")
            a = Console.ReadLine()
            b = a Mod 2
            If b > 0 Then
                Console.WriteLine("FARD")
            Else
                Console.WriteLine("ZOOJ")
            End If
        Next

        Console.ReadLine()

    End Sub

End Module
