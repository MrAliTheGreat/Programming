Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim x1, y1, x2, y2 As Single
        Dim i, sum, T As Double
        Dim DefiniteIntegral As New Integral
        If IsNumeric(TextBoxA.Text) AndAlso IsNumeric(TextBoxB.Text) AndAlso IsNumeric(TextBoxDx.Text) Then
            DefiniteIntegral.a = CDbl(TextBoxA.Text)
            DefiniteIntegral.b = CDbl(TextBoxB.Text)
            DefiniteIntegral.dx = CDbl(TextBoxDx.Text)
            If CDbl(TextBoxB.Text) < CDbl(TextBoxA.Text) Then
                T = DefiniteIntegral.a
                DefiniteIntegral.a = DefiniteIntegral.b
                DefiniteIntegral.b = T
            End If
            For i = DefiniteIntegral.dx To DefiniteIntegral.b - DefiniteIntegral.a - DefiniteIntegral.dx Step DefiniteIntegral.dx
                x1 = (DefiniteIntegral.a + i - DefiniteIntegral.dx) * 80 + 160
                y1 = 160 - ((((Math.E) ^ (-((DefiniteIntegral.a + i - DefiniteIntegral.dx) ^ 2))) * Math.Cos(DefiniteIntegral.a + i - DefiniteIntegral.dx)) * 80)
                x2 = ((DefiniteIntegral.a + i) * 80) + 160
                y2 = 160 - ((((Math.E) ^ (-((DefiniteIntegral.a + i) ^ 2))) * Math.Cos(DefiniteIntegral.a + i)) * 80)

                PictureBox3.CreateGraphics.DrawLine(Pens.Black, x1, y1, x2, y2)
                sum = sum + ((Math.E) ^ (-((DefiniteIntegral.a + i) ^ 2))) * Math.Cos(DefiniteIntegral.a + i) * DefiniteIntegral.dx

            Next
            If CDbl(TextBoxB.Text) < CDbl(TextBoxA.Text) Then
                TextBoxResult.Text = -Math.Round(sum, 8)
            Else
                TextBoxResult.Text = Math.Round(sum, 8)
            End If
        Else
            MessageBox.Show("Your Input Must Be A Number Please Check Your Inputs Again.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox3.Invalidate()
    End Sub
End Class
