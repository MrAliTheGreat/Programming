Module Module1

    Sub Main()

        Dim x, y As Integer
        x = 2
        y = 4
        Dim a() As Integer = {1, 2, 3, 4}
        Dim b() As Integer = {2, 3, 4, 5}
        Dim Result(3) As Integer

        F(a, b, x, y, Result)

        For i = 0 To Result.Length - 1
            Console.WriteLine(Result(i))
        Next

        Console.ReadLine()

    End Sub

    Private Sub F(ByVal a() As Integer, ByVal b() As Integer, ByVal x As Integer, ByVal y As Integer, ByRef P() As Integer)

        For i = 0 To a.Length - 1

            P(i) = a(i) * x + b(i) * y
        Next


    End Sub



End Module
