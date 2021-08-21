Module Module1

    Sub Main()

        ' Get R as input 
        Console.Write("Radious (positve integer) =")

        ' Declare R as integer variable
        Dim R As Integer
        R = Console.ReadLine()

        ' Declare A,B as Double variabl for Area and Perimeter
        Dim A, P As Double

        'Caluclate Area
        A = 3.14 * R ^ 2

        'Caluclate Perimeter
        P = 2 * R * 3.14

        Console.WriteLine("Area = " & A)
        Console.WriteLine("Perimeter = " & P)

        Console.ReadLine()


    End Sub

End Module
