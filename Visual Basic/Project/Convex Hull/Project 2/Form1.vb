Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Designed By Ali Bahari , Mohammad Reza Esmaili , Ali PooraliSefat January 2018" & vbNewLine & vbNewLine & "Computer Programming Dr.Taghaddos", "About")
    End Sub

End Class