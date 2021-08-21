Module Module1
    Dim sum As Long
    Dim NFactor() As Long

    Sub Main()
        Console.WriteLine("Give a positive number:")
        Dim st As String
        Dim str As String
        sum = 1

        Do
            st = Console.ReadLine()
        Loop Until IsNumeric(st) AndAlso CShort(st) >= 0

        Dim n As Short = CShort(st)
        ReDim NFactor(n)
        NFactor(0) = 1
        Console.WriteLine("0! = " & NFactor(0))
        str = "0!"
        Call F(n, str)
        str = str & " ="

        Console.WriteLine(str & sum)
        Console.ReadLine()
    End Sub

    Private Sub F(ByVal n As Short, ByRef name As String)
        For i As Short = 1 To n
            NFactor(i) = i * NFactor(i - 1)
            Console.WriteLine(i & "! = " & NFactor(i))
            sum = sum + NFactor(i)
            name = name & " +" & CStr(i) & "!"
        Next
    End Sub

End Module
