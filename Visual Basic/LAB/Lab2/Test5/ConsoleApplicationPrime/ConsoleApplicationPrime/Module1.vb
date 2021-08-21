Module Module1

    Sub Main()

        Console.WriteLine("Type an integer postive number here.")
        Dim N As Integer
        N = CInt(Console.ReadLine())

        Dim F As Long

        'For i As Integer = 1 To N
        '    F = F * i
        'Next
        For i As Integer = 1 To N
            F = CalculateF(i)
            Console.WriteLine(i & "!= " & F)
        Next



        Console.ReadLine()
    End Sub

    Function CalculateF(ByVal k As Integer) As Long
        Dim F As Long = 1

        For i As Integer = 1 To k
            F = F * i
        Next
        Return F

    End Function

End Module
