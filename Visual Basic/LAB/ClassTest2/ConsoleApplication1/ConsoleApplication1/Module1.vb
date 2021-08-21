Module Module1

    Sub Main()
        Dim str As String
        Dim N As Double
        str = Console.ReadLine()
        If IsNumeric(str) Then
            N = CDbl(str)
            If N >= 0 And N = CInt(str) Then
                Console.WriteLine("Valid positve integer number")
            Else
                Console.WriteLine("Not positve integer number")
            End If

        Else
            ' str input
            Console.WriteLine("Not Valid Number")
        End If
        Dim i As Integer
        For i = 1 To N
            '            ...................
            '................
            '........
        Next

        i = 1
        Do While i <= N And str.Contains("5")
            '            ...................
            '................
            '........
            i = i + 1
        Loop

        Do Until i > N

        Loop

        Do

        Loop Until i > N

        Do

        Loop While i <= N


        Console.ReadLine()
    End Sub

End Module
