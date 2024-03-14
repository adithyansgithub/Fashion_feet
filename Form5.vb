Imports Microsoft.VisualBasic.ApplicationServices

Public Class shoecustomization
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub shoecustomization_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox4.Text = String.Empty
        ComboBox1.Text = String.Empty
        ComboBox2.Text = String.Empty
        ComboBox3.Text = String.Empty
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim Dashboard As New Dashboard
        Dashboard.Show()
    End Sub
End Class