Module Module2

    Sub Main()
        Dim x As Integer = 3
        Dim y As Integer = F(x, False)
        Dim str As String = "Hello. How are you?"
        str = str.ToUpper()

        Dim Numbers As New List(Of Integer)
        Numbers.Add(2)
        Numbers.Add(18)
        Numbers.Add(15)

        Dim chair1, chair2 As Chair

        Dim ListChair As New List(Of Chair)


        chair1 = New Chair
        chair1.color = "red"
        chair1.Cost = 10
        chair1.Height = 0.5
        chair1.Material = "wood"
        ListChair.Add(chair1)

        chair2 = New Chair
        chair2.color = "yellow"
        chair2.Cost = 20
        chair2.Height = 0.7
        chair2.Material = "wood"
        ListChair.Add(chair2)

        Dim chairi As Chair
        For i As Integer = 0 To ListChair.Count - 1
            chairi = ListChair(i)
            Console.WriteLine("color of chair" & i & " is " & chairi.color)
        Next

        Console.ReadLine()

    End Sub

    Function F(ByVal i As Integer, Optional ByRef Flag As Boolean = True) As Integer
        If Flag = True Then
            Return 2 * i
        Else
            Return -2 * i
        End If

    End Function



End Module
