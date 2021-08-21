Imports System.Math

Module Module1

    Sub Main()

        Dim N, j As Integer
        Dim s As Double
        Dim Flag As Boolean

        Console.WriteLine("Please give a integer number:")
        N = Console.ReadLine()

        For i = 2 To N
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


            If Flag = True Then
                Console.WriteLine(i & " Is Prime")
                'Else
                '    Console.WriteLine(i & " is not Prime")
            End If
        Next
    

        Console.ReadLine()

    End Sub

End Module
