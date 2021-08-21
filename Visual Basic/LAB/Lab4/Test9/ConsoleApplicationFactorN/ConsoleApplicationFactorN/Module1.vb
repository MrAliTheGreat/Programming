Module Module1
    Private a As Integer


    Sub Main()

        Dim Valid As Boolean = False
        Console.WriteLine("Give a positive number:")


        'Do
        '    Dim st As String = Console.ReadLine()
        '    If IsNumeric(st) AndAlso CShort(st) >= 0 Then
        '        Valid = True
        '        Dim result As Long = F(CShort(st))
        '        Console.WriteLine(st & "! = " & result)
        '    Else
        '        Valid = False
        '        Console.WriteLine("Input is not valid (positve number).")
        '    End If

        'Loop Until Valid = True

        'Do
        '    Dim st As String = Console.ReadLine()
        '    If IsNumeric(st) AndAlso CShort(st) >= 0 Then
        '        Valid = True
        '        Dim result As Long = F(CShort(st))
        '        Console.WriteLine(st & "! = " & result)
        '    Else
        '        Valid = False
        '        Console.WriteLine("Input is not valid (positve number).")
        '    End If

        'Loop While Valid = False

        'Do Until Valid = True
        '    Dim st As String = Console.ReadLine()
        '    If IsNumeric(st) AndAlso CShort(st) >= 0 Then
        '        Valid = True
        '        Dim result As Long = F(CShort(st))
        '        Console.WriteLine(st & "! = " & result)
        '    Else
        '        Valid = False
        '        Console.WriteLine("Input is not valid (positve number).")
        '    End If

        'Loop

        'Do While Valid = False
        '    Dim st As String = Console.ReadLine()
        '    If IsNumeric(st) AndAlso CShort(st) >= 0 Then
        '        Valid = True
        '        Dim result As Long = F(CShort(st))
        '        Console.WriteLine(st & "! = " & result)
        '    Else
        '        Valid = False
        '        Console.WriteLine("Input is not valid (positve number).")
        '    End If

        'Loop
        Dim st As String

        Do
            st = Console.ReadLine()
        Loop Until IsNumeric(st) AndAlso CShort(st) >= 0

        Dim result As Long = F(CShort(st))
        Console.WriteLine(st & "! = " & result)

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
