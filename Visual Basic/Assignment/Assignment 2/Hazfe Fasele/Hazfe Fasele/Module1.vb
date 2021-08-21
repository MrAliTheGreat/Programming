Module Module1
    'This program is Designed for removing the spaces between words in a given sentence
    'We should note that using (sentence.split).count won't be enough if we have a lot of spaces between words because (sentence.split).count 
    'will only count the words and one space between them so if we have a lot of spaces then (sentence.split).count will count every other 
    'spaces and count them as words this means when we put 2 words and 20 spaces (sentence.split).count will be 21 and the program won't run properly
    'so I defined a new array and put sentence.split in it, this way we can find the number of words in a sentence without counting the spaces
    Sub Main()
        Console.WriteLine("This Program Is Designed For Removing The Spaces Between Words In Your Sentence")
        Console.WriteLine("")
1:      Console.Write("Please Enter Your Sentence: ")
        Dim i As Integer
        Dim j As Short   'j is for counting the number of words in the sentence
        j = 0    'I put j = 0 here because when we choose continue at the end, j will still be the number of words in the last sentence but for the new sentence j must be 0 again
        Dim sentence As String    'sentence is a string that we give to the program
        sentence = Console.ReadLine

        Dim split((sentence.Split).Count - 1) As String    'split is an array that I put sentence.split in it for finding the number of words  
        split = sentence.Split

        For i = 0 To (sentence.Split).Count - 1
            If split(i) <> "" Then
                j = j + 1
            End If
        Next

        If j <= 10 Then     'Program must only run for the sentences with maximum of 10 words so number of words <= 10
            sentence = sentence.Replace(" ", "")     'We replace space with nothing this means we delete the spaces
            Console.WriteLine(sentence)
        Else
            Console.WriteLine("The Number of Words In Your Sentence Is More Than 10 This Program Only Runs For Sentsenences With Maximum of 10 Words ")
        End If
        'From here to end is for continuing the program if wanted
        Console.WriteLine("")
        Console.WriteLine("Do You Want To Continue?")
        Console.WriteLine("YES = 1 , NO = 0")
2:      sentence = Console.ReadLine     'The value of sentence is not important at this point of the program so instead of defining a new variable I decided to use sentence again
        If IsNumeric(sentence) Then
            If CDbl(sentence) = 1 Then
                GoTo 1
            ElseIf CDbl(sentence) = 0 Then
                Exit Sub
            Else
                Console.WriteLine("Your Input Must Be 1 For YES Or 0 For NO !!!")
                GoTo 2
            End If
        Else
            Console.WriteLine("Your Input Must Be 1 For YES Or 0 For NO !!!")
            GoTo 2
        End If
            Console.ReadLine()
    End Sub

End Module
