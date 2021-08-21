Public Class Form1


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Average()
    End Sub

   
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Average()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Average()
    End Sub

    Private Sub Average()
        Dim Sum As Double
        If IsNumeric(TextBox1.Text) Then
            Sum = CDbl(TextBox1.Text)
        End If
        If IsNumeric(TextBox2.Text) Then
            Sum = Sum + CDbl(TextBox2.Text)
        End If
        If IsNumeric(TextBox3.Text) Then
            Sum = Sum + CDbl(TextBox3.Text)
        End If

        TextBoxAvg.Text = CStr(Sum / 3)
    End Sub

End Class
