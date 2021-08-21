Public Class Form1
    Private ListID As New List(Of Long)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyStudent As New Student
        MyStudent.FN = TextBoxFN.Text
        MyStudent.LN = TextBoxLN.Text
        MyStudent.ID = TextBoxID.Text
        If check(MyStudent.ID) Then
            ListBox2.Items.Add(MyStudent)
            ListID.Add(MyStudent.ID)
        Else
            MessageBox.Show(MyStudent.ID & " is not unique.")
        End If
    End Sub

    Private Sub TextBoxIndex_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIndex.TextChanged
        Dim i As Integer = CInt(TextBoxIndex.Text)
        Dim MyStudent As Student
        MyStudent = ListBox2.Items(i)
        MessageBox.Show(MyStudent.FN)
        MessageBox.Show(MyStudent.LN)
        MessageBox.Show(MyStudent.ID)

    End Sub

    Public Function check(ByVal ID As Integer) As Boolean
        For i As Integer = 0 To ListBox2.Items.Count - 1
            Dim MyStudent As Student

            MyStudent = ListBox2.Items(i)
            If MyStudent.ID = ID Then
                Return False
            End If
        Next

        For Each item As Student In ListBox2.Items
            If item.ID = ID Then
                Return False
            End If
        Next
        Return True

    End Function

    Private Sub ButtonSort_Click(sender As Object, e As EventArgs) Handles ButtonSort.Click
        ListID.Sort()
        Dim StudentListTemp As New List(Of Student)
        For Each item As Student In ListBox2.Items
            StudentListTemp.Add(item)
        Next
        ListBox2.Items.Clear()

        For Each id In ListID
            For Each student In StudentListTemp
                If student.ID = id Then
                    ListBox2.Items.Add(student)
                    Exit For
                End If
            Next
        Next
    End Sub
End Class
