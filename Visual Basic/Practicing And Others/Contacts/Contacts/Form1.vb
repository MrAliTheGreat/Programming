Public Class Form1

    Private Sub ButtonAddNewContact_Click(sender As Object, e As EventArgs) Handles ButtonAddNewContact.Click
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub ListBoxContacts_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxContacts.DoubleClick
        Form3.Show()
        Dim SelectedContact As New Contact
        SelectedContact = ListBoxContacts.SelectedItem
        Form3.TextBoxFullName.Text = SelectedContact.FirstName & " " & SelectedContact.LastName
        Form3.TextBoxNumberContact.Text = SelectedContact.Number
        Me.Hide()
    End Sub
End Class
