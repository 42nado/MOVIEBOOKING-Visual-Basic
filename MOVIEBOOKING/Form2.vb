Public Class Form2
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        password.Clear()
        username.Clear()

    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        If (username.Text = "" Or password.Text = "") Then
            MessageBox.Show("Please enter required field")
        End If
        If password.Text = "123" And username.Text = "admin" Then
            MessageBox.Show("Login Succesfully!")
            Form3.Show()
            Me.Close()
        Else
            MessageBox.Show("Incorrect Usernamne or Password")
        End If
    End Sub

    Private Sub showpass_CheckedChanged(sender As Object, e As EventArgs) Handles showpass.CheckedChanged
        If showpass.Checked = True Then
            password.PasswordChar = ""
        Else
            password.PasswordChar = Chr(42)
        End If
    End Sub
End Class