Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBoxInput.Items.Add("Meter")
        ListBoxInput.Items.Add("Centimeter")
        ListBoxInput.Items.Add("Milimeter")
        ListBoxInput.Items.Add("Kilometer")
        ListBoxOutput.Items.Add("Meter")
        ListBoxOutput.Items.Add("Centimeter")
        ListBoxOutput.Items.Add("Milimeter")
        ListBoxOutput.Items.Add("Kilometer")
    End Sub
    Private Sub TextBoxIN_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIN.TextChanged
        Select Case (ListBoxInput.SelectedItem)
            Case "Meter"
                Select Case (ListBoxOutput.SelectedItem)
                    Case "Meter"
                        TextBoxOUT.Text = TextBoxIN.Text
                    Case "Centimeter"
                        TextBoxOUT.Text = TextBoxIN.Text * 100
                    Case "Milimeter"
                        TextBoxOUT.Text = TextBoxIN.Text * 1000
                    Case "Kilometer"
                        TextBoxOUT.Text = TextBoxIN.Text / 1000
                End Select
            Case "Centimeter"
                Select Case (ListBoxOutput.SelectedItem)
                    Case "Meter"
                        TextBoxOUT.Text = TextBoxIN.Text / 100
                    Case "Centimeter"
                        TextBoxOUT.Text = TextBoxIN.Text
                    Case "Milimeter"
                        TextBoxOUT.Text = TextBoxIN.Text * 10
                    Case "Kilometer"
                        TextBoxOUT.Text = TextBoxIN.Text / 100000
                End Select
            Case "Milimeter"
                Select Case (ListBoxOutput.SelectedItem)
                    Case "Meter"
                        TextBoxOUT.Text = TextBoxIN.Text / 1000
                    Case "Centimeter"
                        TextBoxOUT.Text = TextBoxIN.Text / 10
                    Case "Milimeter"
                        TextBoxOUT.Text = TextBoxIN.Text
                    Case "Kilometer"
                        TextBoxOUT.Text = TextBoxIN.Text / 1000000
                End Select
            Case "Kilometer"
                Select Case (ListBoxOutput.SelectedItem)
                    Case "Meter"
                        TextBoxOUT.Text = TextBoxIN.Text * 1000
                    Case "Centimeter"
                        TextBoxOUT.Text = TextBoxIN.Text * 100000
                    Case "Milimeter"
                        TextBoxOUT.Text = TextBoxIN.Text * 1000000
                    Case "Kilometer"
                        TextBoxOUT.Text = TextBoxIN.Text
                End Select
        End Select
    End Sub

    Private Sub ListBoxInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxInput.SelectedIndexChanged
        Select Case (ListBoxInput.SelectedItem)
            Case "Meter"
                Select Case (ListBoxOutput.SelectedItem)
                    Case "Meter"
                        TextBoxOUT.Text = TextBoxIN.Text
                    Case "Centimeter"
                        TextBoxOUT.Text = TextBoxIN.Text * 100
                    Case "Milimeter"
                        TextBoxOUT.Text = TextBoxIN.Text * 1000
                    Case "Kilometer"
                        TextBoxOUT.Text = TextBoxIN.Text / 1000
                End Select
            Case "Centimeter"
                Select Case (ListBoxOutput.SelectedItem)
                    Case "Meter"
                        TextBoxOUT.Text = TextBoxIN.Text / 100
                    Case "Centimeter"
                        TextBoxOUT.Text = TextBoxIN.Text
                    Case "Milimeter"
                        TextBoxOUT.Text = TextBoxIN.Text * 10
                    Case "Kilometer"
                        TextBoxOUT.Text = TextBoxIN.Text / 100000
                End Select
            Case "Milimeter"
                Select Case (ListBoxOutput.SelectedItem)
                    Case "Meter"
                        TextBoxOUT.Text = TextBoxIN.Text / 1000
                    Case "Centimeter"
                        TextBoxOUT.Text = TextBoxIN.Text / 10
                    Case "Milimeter"
                        TextBoxOUT.Text = TextBoxIN.Text
                    Case "Kilometer"
                        TextBoxOUT.Text = TextBoxIN.Text / 1000000
                End Select
            Case "Kilometer"
                Select Case (ListBoxOutput.SelectedItem)
                    Case "Meter"
                        TextBoxOUT.Text = TextBoxIN.Text * 1000
                    Case "Centimeter"
                        TextBoxOUT.Text = TextBoxIN.Text * 100000
                    Case "Milimeter"
                        TextBoxOUT.Text = TextBoxIN.Text * 1000000
                    Case "Kilometer"
                        TextBoxOUT.Text = TextBoxIN.Text
                End Select
        End Select
    End Sub

    Private Sub ListBoxOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxOutput.SelectedIndexChanged
        Select Case (ListBoxInput.SelectedItem)
            Case "Meter"
                Select Case (ListBoxOutput.SelectedItem)
                    Case "Meter"
                        TextBoxOUT.Text = TextBoxIN.Text
                    Case "Centimeter"
                        TextBoxOUT.Text = TextBoxIN.Text * 100
                    Case "Milimeter"
                        TextBoxOUT.Text = TextBoxIN.Text * 1000
                    Case "Kilometer"
                        TextBoxOUT.Text = TextBoxIN.Text / 1000
                End Select
            Case "Centimeter"
                Select Case (ListBoxOutput.SelectedItem)
                    Case "Meter"
                        TextBoxOUT.Text = TextBoxIN.Text / 100
                    Case "Centimeter"
                        TextBoxOUT.Text = TextBoxIN.Text
                    Case "Milimeter"
                        TextBoxOUT.Text = TextBoxIN.Text * 10
                    Case "Kilometer"
                        TextBoxOUT.Text = TextBoxIN.Text / 100000
                End Select
            Case "Milimeter"
                Select Case (ListBoxOutput.SelectedItem)
                    Case "Meter"
                        TextBoxOUT.Text = TextBoxIN.Text / 1000
                    Case "Centimeter"
                        TextBoxOUT.Text = TextBoxIN.Text / 10
                    Case "Milimeter"
                        TextBoxOUT.Text = TextBoxIN.Text
                    Case "Kilometer"
                        TextBoxOUT.Text = TextBoxIN.Text / 1000000
                End Select
            Case "Kilometer"
                Select Case (ListBoxOutput.SelectedItem)
                    Case "Meter"
                        TextBoxOUT.Text = TextBoxIN.Text * 1000
                    Case "Centimeter"
                        TextBoxOUT.Text = TextBoxIN.Text * 100000
                    Case "Milimeter"
                        TextBoxOUT.Text = TextBoxIN.Text * 1000000
                    Case "Kilometer"
                        TextBoxOUT.Text = TextBoxIN.Text
                End Select
        End Select
    End Sub
End Class
