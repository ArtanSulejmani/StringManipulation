Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox6.Text = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If RadioButton1.Checked Then
            TextBox6.Text = LCase(TextBox2.Text)
        ElseIf RadioButton2.Checked Then
            TextBox6.Text = UCase(TextBox2.Text)
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If LCase(TextBox1.Text).Contains(LCase(TextBox3.Text)) Then
            Label6.Text = "Found"
            Label6.ForeColor = Color.Red
        Else
            Label6.Text = "Not Found"
            Label6.ForeColor = Color.Black
        End If
    End Sub
End Class
