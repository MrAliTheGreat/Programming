Module Module1

    Sub Main()
        Dim n, a As Integer
        Console.WriteLine("This program is designed to find whether your number is prime or not ")
        Console.WriteLine("Enter Your Number")
        n = Console.ReadLine
        If n = 2 Then
            Console.WriteLine("Is prime")
            Console.ReadLine()
            Exit Sub
        End If
        For i As Integer = 2 To n / 2
            a = n Mod i
            If a = 0 Then
                Console.WriteLine("Is not prime")
                Console.ReadLine()
                Exit Sub
            End If
        Next
        Console.WriteLine("Is prime")
        Console.ReadLine()

    End Sub

End Module
