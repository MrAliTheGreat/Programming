Public Class Form2
    Public c, d As New List(Of Double)
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pt As New PointID

        If IsNumeric(TextBox1.Text) = True AndAlso IsNumeric(TextBox2.Text) = True Then

            For i As Short = 0 To ListBoxPoint.Items.Count - 1
                If TextBox1.Text + 160 = ListBoxPoint.Items(i).x AndAlso 160 - TextBox2.Text = ListBoxPoint.Items(i).y Then
                    MessageBox.Show("You Have Already Entered This Point Please Enter a Different Point.", "Error")
                    TextBox1.Clear()
                    TextBox2.Clear()
                    Exit Sub
                End If
            Next

            pt.x = (TextBox1.Text) + 160
            pt.y = -(TextBox2.Text) + 160
            ListBoxPoint.Items.Add(pt)
            TextBox1.Clear()
            TextBox2.Clear()

        Else

            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MessageBox.Show("You Must Enter Coordinates of Your Point In X and Y.", "Error")
            Else
                MessageBox.Show("Your Input For a Point Is NOT Valid Check Your Inputs Again.", "Error")
            End If

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim k, i, j, z As Short
        Dim ymax, a(ListBoxPoint.Items.Count - 1), b(ListBoxPoint.Items.Count - 1) As Double
        Dim n As New List(Of Double)

        If ListBoxPoint.Items.Count = 0 Then

            MessageBox.Show("For Drawing a Convex Hull You Need To Insert Points First.", "Error")
            Exit Sub

        ElseIf ListBoxPoint.Items.Count > 0 AndAlso ListBoxPoint.Items.Count <= 2 Then
            MessageBox.Show("For Drawing A Shape You Must Enter At Least 3 Points.", "Error")
            Exit Sub
        Else

            For i = 0 To ListBoxPoint.Items.Count - 2
                n.Add((ListBoxPoint.Items(i + 1).y - ListBoxPoint.Items(i).y) / (ListBoxPoint.Items(i + 1).x - ListBoxPoint.Items(i).x))
            Next

            For i = 0 To n.Count - 2
                If n.Item(i) <> n.Item(i + 1) Then
                    Exit For
                Else
                    k = k + 1
                End If
            Next

            If k = n.Count - 1 Then
                MessageBox.Show("All of Your Points Are On a Line So There Won't Be Any Convex Hull.", "Error")
                Exit Sub
            End If

        End If

        i = 0
        z = 0
        'Finding Y max:'
        ymax = ListBoxPoint.Items(0).y
        a(0) = ListBoxPoint.Items(0).x
        b(0) = ListBoxPoint.Items(0).y
        j = 0
        For i = 1 To ListBoxPoint.Items.Count - 1
            a(i) = ListBoxPoint.Items(i).x
            b(i) = ListBoxPoint.Items(i).y
            If ListBoxPoint.Items(i).y = ymax Then
                If a(i) > a(j) Then
                    ymax = b(i)
                    j = i
                End If
            ElseIf ListBoxPoint.Items(i).y > ymax Then
                ymax = ListBoxPoint.Items(i).y
                j = i
            End If
        Next

        Dim startingpoint As New PointID
        Dim secondpoint As New PointID
        Dim alfa, alfamin, lastalfa, m As Double

        startingpoint.x = a(j)
        startingpoint.y = b(j)
        c.Add(startingpoint.x)
        d.Add(startingpoint.y)

        Do
            For i = 0 To ListBoxPoint.Items.Count - 1

                If a(i) = startingpoint.x AndAlso b(i) = startingpoint.y Then
                    If i = ListBoxPoint.Items.Count - 1 Then
                        Exit For
                    ElseIf i = 0 Then
                        'Any degree more than biggest alfa can be here but 
                        'because we want to be sure then we put a degree more than 450
                        alfamin = 7200
                    End If
                    i = i + 1
                End If

                m = (b(i) - startingpoint.y) / (a(i) - startingpoint.x)
                alfa = Math.Atan(Math.Abs(m)) * (180 / Math.PI)

                If a(i) - startingpoint.x >= 0 AndAlso b(i) - startingpoint.y > 0 Then
                    alfa = 360 - alfa
                ElseIf a(i) - startingpoint.x <= 0 AndAlso b(i) - startingpoint.y <= 0 Then
                    alfa = 180 - alfa
                ElseIf a(i) - startingpoint.x <= 0 AndAlso b(i) - startingpoint.y >= 0 Then
                    alfa = 180 + alfa
                End If
                If lastalfa >= 180 AndAlso lastalfa < 270 Then
                    If a(i) - startingpoint.x >= 0 AndAlso b(i) - startingpoint.y <= 0 Then
                        alfa = 360 + alfa
                    End If
                End If
                If lastalfa >= 270 AndAlso lastalfa <= 360 Then
                    If a(i) - startingpoint.x >= 0 AndAlso b(i) - startingpoint.y <= 0 Then
                        alfa = 360 + alfa
                    ElseIf a(i) - startingpoint.x <= 0 AndAlso b(i) - startingpoint.y <= 0 Then
                        alfa = 360 + alfa
                    End If
                End If

                If i = 0 Then
                    alfamin = alfa
                    z = 0
                ElseIf alfamin > alfa Then
                    alfamin = alfa
                    z = i
                End If

            Next

            lastalfa = alfamin

            secondpoint.x = a(z)
            secondpoint.y = b(z)
            c.Add(secondpoint.x)
            d.Add(secondpoint.y)

            Dim pts(1) As Point
            pts(0) = New Point(startingpoint.x, startingpoint.y)
            pts(1) = New Point(secondpoint.x, secondpoint.y)
            PictureBox1.CreateGraphics.DrawLine(Pens.Black, pts(0), pts(1))

            startingpoint.x = secondpoint.x
            startingpoint.y = secondpoint.y

        Loop Until startingpoint.x = a(j) AndAlso startingpoint.y = b(j)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If IsNumeric(TextBox3.Text) = True AndAlso IsNumeric(TextBox4.Text) = True Then

            If ListBoxPoint.Items.Count = 0 Then
                MessageBox.Show("No Shape Has Been Drawn Yet First Enter The Points of Your Shape Then Enter The Point You Want Its Position.", "Error")
            Else
                Dim PositionPoint As New PointID
                Dim Cross As Double
                Dim Negetive, positive, Zero As Short
                PositionPoint.x = TextBox3.Text
                PositionPoint.y = TextBox4.Text
                For i = 0 To c.Count - 2

                    Cross = ((c.Item(i + 1) - c.Item(i)) * (-PositionPoint.y + 160 - d.Item(i))) - ((PositionPoint.x + 160 - c.Item(i)) * (d.Item(i + 1) - d.Item(i)))

                    If Cross > 0 Then
                        positive = positive + 1
                    ElseIf Cross < 0 Then
                        Negetive = Negetive + 1
                    ElseIf Cross = 0 Then
                        Zero = Zero + 1
                    End If
                Next

                If positive > 0 AndAlso Negetive > 0 Then
                    MessageBox.Show("Outside The Polygon", "Result")
                ElseIf Negetive > 0 AndAlso Zero > 0 Then
                    MessageBox.Show("On The Polygon", "Result")
                Else
                    MessageBox.Show("Inside The Polygon", "Result")
                End If
            End If

        Else

            If TextBox3.Text = "" Or TextBox4.Text = "" Then
                MessageBox.Show("For Finding The Position Of a Point You Must Enter Coordinates of Your Point First.", "Error")
            Else
                MessageBox.Show("Your Input For a Point Is NOT Valid Check Your Inputs Again.", "Error")
            End If

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBoxPoint.SelectedItem Is Nothing Then
            MessageBox.Show("You Must Choose A point First.", "Error")
        Else
            ListBoxPoint.Items.RemoveAt(ListBoxPoint.SelectedIndex)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListBoxPoint.Items.Count = 0 Then
            MessageBox.Show("You Have Not Entered A point Yet The List Is Empty.", "Error")
        Else
            ListBoxPoint.Items.Clear()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox1.Invalidate()
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are You Sure You Want To Exit The Program?", "Convex Hull", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

End Class