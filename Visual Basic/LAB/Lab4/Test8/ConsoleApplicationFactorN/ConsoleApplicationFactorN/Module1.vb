Module Module1
    Private a As Integer


    Sub Main()
        Dim st As String = Console.ReadLine()

        If IsNumeric(st) Then
            Dim n As Short = CShort(st)
            If n >= 0 Then
                Dim result As Long = F(n)
                Console.WriteLine(n & "! = " & result)
            Else
                Console.WriteLine("Input is negative.")
            End If
            
        Else
            Console.WriteLine("Input is not a number.")

        End If
        Console.ReadLine()

    End Sub

    Private Function F(ByVal k As Short) As Long
        If k > 0 Then
            Return k * F(k - 1)
        Else
            Return 1
        End If

    End Function
End Module
