Module Module1

    Sub Main()

        Console.WriteLine("Give a positive number:")
        Dim st As String

        Do
            st = Console.ReadLine()
        Loop Until IsNumeric(st) AndAlso CShort(st) >= 0

        Dim n As Short = CShort(st)

        Dim NFactor(n) As Long
        NFactor(0) = 1

        For i As Short = 1 To n
            NFactor(i) = i * NFactor(i - 1)
        Next

        Dim result As Long = NFactor(n)
        Console.WriteLine(st & "! = " & result)

        Console.ReadLine()

    End Sub

    'Private Function F(ByVal k As Short) As Long
    '    Dim x As Long = 1

    '    For i As Short = 1 To k
    '        x = x * i
    '    Next

    '    Return x

    'End Function
End Module
