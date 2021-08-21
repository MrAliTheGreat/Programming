Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Designed By Ali Bahari , Mohammad Reza Esmaili , Ali PooraliSefat January 2018" & vbNewLine & vbNewLine & "Computer Programming Dr.Taghaddos" & vbNewLine & vbNewLine & "*Note That In This Version Finding The Position of a Point Which Is On the Polygon Is Harder Because You Must Click On The Sides of The Polygon Very Precisely.", "About")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class