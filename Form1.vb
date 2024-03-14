Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passw.PasswordChar = "*"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles user.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click
        If user.Text = "Admin" AndAlso passw.Text = "XYZ" Then
            MessageBox.Show("username authenticated")
            Me.Hide()
            Dim Dashboard As New Dashboard
            Dashboard.Show()
        Else
            MessageBox.Show("Invalid username or password")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles showpass.CheckedChanged
        If showpass.Checked Then
            passw.PasswordChar = ""
        Else
            passw.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Reset.Click
        user.Text = String.Empty
        passw.Text = String.Empty
    End Sub

    Private Sub password_Click(sender As Object, e As EventArgs) Handles password.Click

    End Sub
End Class
