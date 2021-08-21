Public Class Form2

    Private Sub ButtonAddContactToContacts_Click(sender As Object, e As EventArgs) Handles ButtonAddContactToContacts.Click
        Form1.Show()
        Dim NewContact As New Contact
        NewContact.FirstName = TextBoxFirstName.Text
        NewContact.LastName = TextBoxLastName.Text
        NewContact.Number = TextBoxNumber.Text
        Form1.ListBoxContacts.Items.Add(NewContact)
        Me.Close()
    End Sub
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub
End Class