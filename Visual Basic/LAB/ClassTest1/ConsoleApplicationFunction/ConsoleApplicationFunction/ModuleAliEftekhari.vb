Module ModuleAliEftekhari
    Sub Main()
        Dim x, y As Integer
        x = Console.ReadLine()
        y = Console.ReadLine()
        Console.WriteLine("x=" & x & ", y=" & y)
        Console.WriteLine("F1(x^2, x^2)=" & F1(x, x))
        Console.WriteLine("F1(x^2, y^2)=" & F1(x, y))
        Console.WriteLine("F1(y^2, x^2)=" & F1(y, x))
        Console.WriteLine("F1(y^2, y^2)=" & F1(y, y))

        Console.ReadLine()
    End Sub
    Function F1(ByRef x As Integer, ByVal y As Integer) As Integer
        x = x ^ 2
        y = y ^ 2
        Return 2 * x + 3 * y

    End Function


End Module
