Module Module1

    Sub Main()
        Dim F(10) As String
        F(0) = "3"
        F(4) = "7"

        ReDim F(2)


        Dim str As String
        str = "Hello. How are u?"
        F = str.Split()

        Dim num As New List(Of Integer)
        num.Add(2)
        num.Add(1)
        num.Add(3)
        num.Add(20)
        num.Add(12)
        num.Insert(1, 20)
        num.RemoveAt(2)
        'num.Clear()

        If num.Contains(5) Then
            Console.WriteLine("5 exists")
            Console.ReadLine()
        Else
            Console.WriteLine("5 does not exist")
            Console.ReadLine()

        End If
        num.Sort()

    End Sub

End Module
