Module Module1
    'This program is Designed for finding a word in a given Text
    'We can't change the color of a particular word, we can only change the font color so the key for answering this question is  
    'to print the text letter by letter, changing color when we get to our word and returning to the default color when we get to 
    'the rest of the text. Note that knowing the first letter of the word isn't enough so we must first check whether the word is 
    'the given word or not. We also should know the number of words in our text (description in assignment 3). In this program we 
    'can also search a text as many times as we want.
    'Note That I Choose The Default Color of Console White  ===>  Default Color Of Console = White  
    Sub Main()
        Console.WriteLine("This Program Is Designed For Finding a Word In a Text")
        Console.WriteLine("")
        Dim text, word, answer As String
        Dim i As Integer
        Dim j, k, t As Short   'j is for the length of the word we want to search and k is for number of words in the text and t is number of matches that we found in text

        Console.WriteLine("Please Enter Your Text")
        text = Console.ReadLine

1:      Console.Write("Please Enter The Word You Want to Find: ")
        word = Console.ReadLine
        t = 0
        k = 0
        Dim Split((text.Split).Count - 1) As String
        Split = text.Split
        'Here I found number of words in the text
        For i = 0 To (text.Split).Count - 1
            If Split(i) <> "" Then
                k = k + 1
            End If
        Next

        If k <= 50 Then    'Program runs for texts with max of 50 words
            If text.Contains(word) Then
                For i = 0 To text.Length - 1
                    For j = 0 To word.Length - 1
                        If word(j) = text(i + j) Then   'Here I compared every letter of the word with the text
                            GoTo 2
                        Else
                            Exit For
                        End If
2:                  Next
                    If j = word.Length Then  'Here I checked whether part of the text is our word or not
                        Console.ForegroundColor = ConsoleColor.Cyan   'Changing Color
                        For j = 0 To word.Length - 1
                            Console.Write(text(i + j))
                        Next
                        i = i + j - 1   'I put this here because we don't want to print the rest of our word again
                        '-1 is because at the end of the for 1 will be added to i and if we don't put -1 the space 
                        'between words won't be printed
                        t = t + 1
                    Else
                        Console.ForegroundColor = ConsoleColor.White    'Returning to default color
                        Console.Write(text(i))
                    End If
                Next
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("")
                Console.WriteLine("")
                If t > 1 Then       'when we have more than one match we must use matches so the if here is for grammer reasons !!!
                    Console.WriteLine(t & " Matches Found")
                Else
                    Console.WriteLine(t & " Match Found")
                End If

                Console.WriteLine("")
            Else
                Console.WriteLine("The Text Doesn't Have Your Word!")
                Console.WriteLine("0 match Found")
                Console.WriteLine("")
            End If
        Else
            Console.WriteLine("The Text Has More Than 50 Words This Program Only Runs For Texts With Maximum Of 50 Words")
            Console.WriteLine("")
        End If
        'From Here to end is for searching another word in the given text
        Console.WriteLine("Do You Want To Search Another Word In Your Text?")
        Console.WriteLine("YES = 1 , NO = 0")
3:      answer = Console.ReadLine

        If IsNumeric(answer) Then
            If CDbl(answer) = 1 Then
                GoTo 1
            ElseIf CDbl(answer) = 0 Then
                Exit Sub
            Else
                Console.WriteLine("Your Input Must Be 1 For YES Or 0 For NO !!!")
                GoTo 3
            End If
        Else
            Console.WriteLine("Your Input Must Be 1 For YES Or 0 For NO !!!")
            GoTo 3
        End If

        Console.ReadLine()

    End Sub

End Module
