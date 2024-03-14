Public Class Dashboard
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim shoecustomization As New shoecustomization
        shoecustomization.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim Shoedetails As New Shoedetails
        Shoedetails.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim customerdetails As New Customerdetails
        customerdetails.Show()
    End Sub

    Private Sub Order_Details_Click(sender As Object, e As EventArgs) Handles Order_Details.Click
        Dim order As New order()
        order.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Application.Exit()
    End Sub
End Class
