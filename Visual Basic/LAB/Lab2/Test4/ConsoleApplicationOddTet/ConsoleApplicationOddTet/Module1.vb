Module Module1
    Sub Main()
        Dim N, Count As Integer
        Dim st As String
        Console.Write("Type number of iterations here: ")
        st = Console.ReadLine

        If IsNumeric(st) = True Then
            Count = CInt(st)
        Else
            Console.Write(st & " is not a valid number. Run again!")
            Console.ReadLine()
            Exit Sub
        End If
        Console.WriteLine()

        For i As Integer = 1 To Count
            Console.Write("Type an integer number here: ")
            st = Console.ReadLine

            If IsNumeric(st) = True Then
                N = CInt(st)
            Else
                Console.Write(st & " is not a valid number. Run again!")
                Console.ReadLine()
                Exit Sub
            End If

            If (N Mod 2) = 0 Then
                Console.WriteLine(st & " is even.")
            Else
                Console.WriteLine(st & " is odd.")
            End If
        Next

        Console.ReadLine()

    End Sub
End Module
