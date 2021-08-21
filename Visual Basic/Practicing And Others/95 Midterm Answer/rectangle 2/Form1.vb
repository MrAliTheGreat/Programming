Public Class Form1
    Public i As Short = 1
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

        TextBoxPerimeter.Text = 2 * TextBoxA.Text + 2 * TextBoxB.Text
        TextBoxArea.Text = TextBoxA.Text * TextBoxB.Text
        Dim information As New rectangleID
        information.a = TextBoxA.Text
        information.b = TextBoxB.Text
        information.perimeter = TextBoxPerimeter.Text
        information.area = TextBoxArea.Text
        TextBoxName.Text = "Rectangle " & i
        information.name = TextBoxName.Text
        ListBox1.Items.Add(information)
        i = i + 1
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        Dim information1 As New rectangleID
        information1 = ListBox1.Items(ListBox1.SelectedIndex)
        TextBoxA.Text = information1.a
        TextBoxB.Text = information1.b
        TextBoxPerimeter.Text = information1.perimeter
        TextBoxArea.Text = information1.area
        TextBoxName.Text = information1.name
    End Sub

End Class
