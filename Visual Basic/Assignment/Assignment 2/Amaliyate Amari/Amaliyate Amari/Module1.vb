Module Module1
    'This program is Designed to do statistical operations for given numbers
    'I designed a menu for this program, You can use all operations at once or one by one
    'The hardest part of this program is its exceptions which in every step I covered them!!!
    Sub Main()
        Dim a, i As String   'a is the number of each operation and i is the number of digits we input
        Dim j As Short       'j is the number of each space in array (number)
        Console.WriteLine("This Program is Designed to Do Statistical Operations")
1:      Console.WriteLine("")
        Console.WriteLine("Average = 1")
        Console.WriteLine("Median = 2")
        Console.WriteLine("Standard Deviation = 3")
        Console.WriteLine("Variance = 4")
        Console.WriteLine("All Operations = 5")
        Console.WriteLine("")
2:      Console.Write("Which Operation do You Want to Use? ")
        a = Console.ReadLine
        If IsNumeric(a) = True Then
            If a >= 1 AndAlso a <= 5 Then
                If a - CInt(a) = 0 Then
                    If CInt(a) = 1 Then     'CInt isn't need we can just say if a = 1 but I put it just for being sure!!!
3:                      Console.Write("For Calculating The Average How Many Numbers Do You Want? ")
                        i = Console.ReadLine
                        If IsNumeric(i) = True Then
                            If CDbl(i) < 0 Then
                                Console.WriteLine("Your Input Must Be Positive Please Enter a Positive Number ")
                                Console.WriteLine("")
                                GoTo 3
                            End If
                            If i - CInt(i) = 0 Then
                                Dim number(CInt(i) - 1) As String   'number could be defined at the upper part of the program but I put it after if every time for better understanding 
                                Console.WriteLine("Please Enter Your Numbers")
                                For j = 0 To i - 1
4:                                  number(j) = Console.ReadLine
                                    If IsNumeric(number(j)) = False Then
                                        Console.WriteLine("Your Input Is Not Valid Please Only Enter Numbers ")
                                        GoTo 4
                                    End If
                                Next
                                Console.WriteLine("Average = " & average(i, number))   'here we call the average function
                                Console.WriteLine("")
                            Else
                                Console.WriteLine("The Input Is Not Integer Your Input Must Be Integer !!!")
                                Console.WriteLine("")
                                GoTo 3
                            End If
                        Else
                            Console.WriteLine("The Input Is Not Valid Your Input Must Be an Integer Number!!!")
                            Console.WriteLine("")
                            GoTo 3
                        End If
                        Console.WriteLine("Do You Want to Continue?")
                        Console.WriteLine("YES = 1")
                        Console.WriteLine("NO = 0")
5:                      a = Console.ReadLine
                        If IsNumeric(a) = True Then
                            If a = 1 Then
                                GoTo 1
                            ElseIf a = 0 Then
                                Exit Sub
                            Else
                                Console.WriteLine("Your Answer Must Be 1 or 0")
                                GoTo 5
                            End If
                        Else
                            Console.WriteLine("Your Answer Must Be 1 or 0")
                            GoTo 5
                        End If
                    End If
                    'from here to end it is similar to above but for other operations of the menu
                    If CInt(a) = 2 Then
6:                      Console.Write("For Calculating The Median How Many Numbers Do You Want? ")
                        i = Console.ReadLine
                        If IsNumeric(i) = True Then
                            If i < 0 Then
                                Console.WriteLine("Your Input Must Be Positive Please Enter a Positive Number ")
                                Console.WriteLine("")
                                GoTo 6
                            End If
                            If i - CInt(i) = 0 Then
                                Dim number(CInt(i) - 1) As String
                                Console.WriteLine("Please Enter Your Numbers")
                                For j = 0 To i - 1
7:                                  number(j) = Console.ReadLine
                                    If IsNumeric(number(j)) = False Then
                                        Console.WriteLine("Your Input Is Not Valid Please Only Enter Numbers ")
                                        GoTo 7
                                    End If
                                Next
                                Console.WriteLine("Median = " & median(i, number))
                                Console.WriteLine("")
                            Else
                                Console.WriteLine("The Input Is Not Integer Your Input Must Be Integer!!!")
                                Console.WriteLine("")
                                GoTo 6
                            End If
                        Else
                            Console.WriteLine("The Input Is Not Valid Your Input Must Be an Integer Number!!!")
                            Console.WriteLine("")
                            GoTo 6
                        End If
                        Console.WriteLine("Do You Want to Continue?")
                        Console.WriteLine("YES = 1")
                        Console.WriteLine("NO = 0")
8:                      a = Console.ReadLine
                        If IsNumeric(a) = True Then
                            If a = 1 Then
                                GoTo 1
                            ElseIf a = 0 Then
                                Exit Sub
                            Else
                                Console.WriteLine("Your Answer Must Be 1 or 0")
                                GoTo 8
                            End If
                        Else
                            Console.WriteLine("Your Answer Must Be 1 or 0")
                            GoTo 8
                        End If
                    End If

                    If CInt(a) = 3 Then
9:                      Console.Write("For Calculating The Standard Deviation How Many Numbers Do You Want? ")
                        i = Console.ReadLine
                        If IsNumeric(i) = True Then
                            If i < 0 Then
                                Console.WriteLine("Your Input Must Be Positive Please Enter a Positive Number ")
                                Console.WriteLine("")
                                GoTo 9
                            End If
                            If i - CInt(i) = 0 Then
                                Dim number(CInt(i) - 1) As String
                                Console.WriteLine("Please Enter Your Numbers")
                                For j = 0 To i - 1
10:                                 number(j) = Console.ReadLine
                                    If IsNumeric(number(j)) = False Then
                                        Console.WriteLine("Your Input Is Not Valid Please Only Enter Numbers ")
                                        GoTo 10
                                    End If
                                Next
                                Console.WriteLine("Standard Deviation = " & StandardDeviation(i, number))
                                Console.WriteLine("")
                            Else
                                Console.WriteLine("The Input Is Not Integer Your Input Must Be Integer!!!")
                                Console.WriteLine("")
                                GoTo 9
                            End If
                        Else
                            Console.WriteLine("The Input Is Not Valid Your Input Must Be an Integer Number!!!")
                            Console.WriteLine("")
                            GoTo 9
                        End If
                        Console.WriteLine("Do You Want to Continue?")
                        Console.WriteLine("YES = 1")
                        Console.WriteLine("NO = 0")
11:                     a = Console.ReadLine
                        If IsNumeric(a) = True Then
                            If a = 1 Then
                                GoTo 1
                            ElseIf a = 0 Then
                                Exit Sub
                            Else
                                Console.WriteLine("Your Answer Must Be 1 or 0")
                                GoTo 11
                            End If
                        Else
                            Console.WriteLine("Your Answer Must Be 1 or 0")
                            GoTo 11
                        End If
                    End If

                    If CInt(a) = 4 Then
12:                     Console.Write("For Calculating The Variance How Many Numbers Do You Want? ")
                        i = Console.ReadLine
                        If IsNumeric(i) = True Then
                            If i < 0 Then
                                Console.WriteLine("Your Input Must Be Positive Please Enter a Positive Number ")
                                Console.WriteLine("")
                                GoTo 12
                            End If
                            If i - CInt(i) = 0 Then
                                Dim number(CInt(i) - 1) As String
                                Console.WriteLine("Please Enter Your Numbers")
                                For j = 0 To i - 1
13:                                 number(j) = Console.ReadLine
                                    If IsNumeric(number(j)) = False Then
                                        Console.WriteLine("Your Input Is Not Valid Please Only Enter Numbers ")
                                        GoTo 13
                                    End If
                                Next
                                Console.WriteLine("Variance = " & variance(i, number))
                                Console.WriteLine("")
                            Else
                                Console.WriteLine("The Input Is Not Integer Your Input Must Be Integer!!!")
                                Console.WriteLine("")
                                GoTo 12
                            End If
                        Else
                            Console.WriteLine("The Input Is Not Valid Your Input Must Be an Integer Number!!!")
                            Console.WriteLine("")
                            GoTo 12
                        End If
                        Console.WriteLine("Do You Want to Continue?")
                        Console.WriteLine("YES = 1")
                        Console.WriteLine("NO = 0")
14:                     a = Console.ReadLine
                        If IsNumeric(a) = True Then
                            If a = 1 Then
                                GoTo 1
                            ElseIf a = 0 Then
                                Exit Sub
                            Else
                                Console.WriteLine("Your Answer Must Be 1 or 0")
                                GoTo 14
                            End If
                        Else
                            Console.WriteLine("Your Answer Must Be 1 or 0")
                            GoTo 14
                        End If
                    End If

                    If CInt(a) = 5 Then
15:                     Console.Write("For Calculating All Operations At Once How Many Numbers Do You Want? ")
                        i = Console.ReadLine
                        If IsNumeric(i) = True Then
                            If i < 0 Then
                                Console.WriteLine("Your Input Must Be Positive Please Enter a Positive Number ")
                                Console.WriteLine("")
                                GoTo 15
                            End If
                            If i - CInt(i) = 0 Then
                                Dim number(CInt(i) - 1) As String
                                Console.WriteLine("Please Enter Your Numbers")
                                For j = 0 To i - 1
16:                                 number(j) = Console.ReadLine
                                    If IsNumeric(number(j)) = False Then
                                        Console.WriteLine("Your Input Is Not Valid Please Only Enter Numbers ")
                                        GoTo 16
                                    End If
                                Next
                                Console.WriteLine("Average = " & average(i, number))
                                Console.WriteLine("Median = " & median(i, number))
                                Console.WriteLine("Standard Deviation = " & StandardDeviation(i, number))
                                Console.WriteLine("Variance = " & variance(i, number))
                                Console.WriteLine("")
                            Else
                                Console.WriteLine("The Input Is Not Integer Your Input Must Be Integer!!!")
                                Console.WriteLine("")
                                GoTo 15
                            End If
                        Else
                            Console.WriteLine("The Input Is Not Valid Your Input Must Be an Integer Number!!!")
                            Console.WriteLine("")
                            GoTo 15
                        End If
                        Console.WriteLine("Do You Want to Continue?")
                        Console.WriteLine("YES = 1")
                        Console.WriteLine("NO = 0")
17:                     a = Console.ReadLine
                        If IsNumeric(a) = True Then
                            If a = 1 Then
                                GoTo 1
                            ElseIf a = 0 Then
                                Exit Sub
                            Else
                                Console.WriteLine("Your Answer Must Be 1 or 0")
                                GoTo 17
                            End If
                        Else
                            Console.WriteLine("Your Answer Must Be 1 or 0")
                            GoTo 17
                        End If
                    End If

                Else
                    Console.WriteLine("Your Number is Not Integer According to the Description Please Enter an Integer Number from 1 to 4")
                    Console.WriteLine("")
                    GoTo 2
                End If
            Else
                Console.WriteLine("Your Number is Not Between 1 and 4 According to the Description Please Enter a Number from 1 to 4")
                Console.WriteLine("")
                GoTo 2
            End If

        Else
            Console.WriteLine("Your Input is Not Valid According to the Description Please Enter a Number from 1 to 4")
            Console.WriteLine("")
            GoTo 2
        End If
        Console.ReadLine()
    End Sub

    'For every function we have 2 inputs: the number of digits = i and the digits themselves = number()
    Function average(ByVal i As Short, ByVal number() As String) As Double
        Dim sum, j, avg As Double     'sum is for finding the sum total, j is a counter and avg is average of the numbers
        For j = 0 To i - 1
            sum = sum + CDbl(number(j))
        Next
        avg = sum / i
        Return avg
    End Function
    Function median(ByVal i As Short, ByVal number() As String) As Double
        Dim j, k, a, m As Double    'j and k are counters, a is used for changing the value of two number(j) and number(j+1), m is median of the numbers
        For k = 1 To i - 1    'instead of using array.sort I wrote the whole code for sorting!!! (Bubble Sort)
            For j = 0 To i - 2
                If CDbl(number(j)) > CDbl(number(j + 1)) Then
                    a = number(j)
                    number(j) = number(j + 1)
                    number(j + 1) = a
                End If
            Next
        Next
        If i Mod 2 = 0 Then   'If the number of the words is even median will be the average of two middle numbers
            m = (CDbl(number(i / 2 - 1)) + CDbl(number(i / 2))) / 2
        Else  'If the number of the words is odd median will be the middle number
            m = number(Math.Floor(i / 2))
        End If
        Return m
    End Function
    Function StandardDeviation(ByVal i As Short, ByVal number() As String) As Double
        Return Math.Sqrt(variance(i, number))  'Standard Deviation is square root of variance
    End Function
    Function variance(ByVal i As Short, ByVal number() As String) As Double
        Dim a, sum, var As Double  'a is for sum total of number^2, sum is for sum total of the numbers, var is variance of the numbers
        Dim j As Short   'j is a counter
        For j = 0 To i - 1
            sum = sum + CDbl(number(j))
            a = a + (CDbl((number(j))) ^ 2)
        Next
        var = (a / i) - ((sum / i) ^ 2)
        Return var
    End Function

End Module
