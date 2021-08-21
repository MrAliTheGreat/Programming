Public Class Form3

    Private Sub ButtonReturnToContacts_Click(sender As Object, e As EventArgs) Handles ButtonReturnToContacts.Click
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub
End Class