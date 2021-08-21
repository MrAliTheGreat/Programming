Module Module1
    'This program is Designed to reverse a given input
    Sub Main()
        Console.WriteLine("This Program Is Designed To Reverse an Input")
        Console.WriteLine("")
1:      Console.Write("Please Enter Your Input: ")
        Dim mainword As String   'mainword is the word that we get from the user
        mainword = Console.ReadLine
        Dim reversedword(mainword.Length - 1) As String   'reversedword is an array that we put every letter of mainword in it
        For i As Short = 0 To mainword.Length - 1
            reversedword(i) = mainword(i)     'Here we put every letter of mainword in a new array according to the assignment (This is part isn't necessary if we delete it nothing will happen)
            reversedword(i) = mainword(-i + mainword.Length - 1)  'Here I change the first letters with last letters one by one using a new array (reversedword)
            Console.Write(reversedword(i))
        Next
        'From here to end is for continuing program if wanted
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Do You Want To Continue?")
        Console.WriteLine("YES = 1 , NO = 0")
2:      mainword = Console.ReadLine  'I used mainword instead of defining a new variable because the value of mainword isn't importent at this point
        If IsNumeric(mainword) Then
            If CDbl(mainword) = 1 Then
                GoTo 1
            ElseIf CDbl(mainword) = 0 Then
                Exit Sub
            Else
                Console.WriteLine("Your Input Must Be 1 For YES Or 0 For NO !!!")
                GoTo 2
            End If
        Else
            Console.WriteLine("Your Input Must Be 1 For YES Or 0 For NO !!!")
            GoTo 2
        End If
    End Sub

End Module
