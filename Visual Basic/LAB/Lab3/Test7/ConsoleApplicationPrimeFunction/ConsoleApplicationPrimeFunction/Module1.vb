Imports System.Math

Module Module1

    Sub Main()
        Dim N As Integer
        Dim Flag1 As Boolean

        Console.WriteLine("Please give a integer number:")
        N = Console.ReadLine()
        For i = 2 To N
            Flag1 = CheckPrime(i)
            If Flag1 Then
                Console.WriteLine(i & " Is Prime")
            End If
        Next

        Console.ReadLine()

    End Sub

    Function CheckPrime(ByVal i As Integer) As Boolean
        Dim s As Double
        Dim Flag As Boolean

        s = Sqrt(i)

        Flag = True

        If i > 2 Then
            If i Mod 2 = 0 Then
                Flag = False
            End If

            For j = 3 To Floor(s) Step 2
                If i Mod j = 0 Then
                    Flag = False
                    Exit For
                End If
            Next
        End If

        Return Flag

    End Function

End Module
