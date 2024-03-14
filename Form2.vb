Imports System.Data.SqlClient
Public Class Shoedetails
    Private Sqlconstring As String = "Data Source=TERMINATOR\MSSQLSERVER05;Initial Catalog=Fashion_Feet;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim query As String = "SELECT * FROM Shoe Table"
        Dim connection As New SqlConnection("Data Source=TERMINATOR\MSSQLSERVER05;Initial Catalog=Fashion_Feet;Integrated Security=True;Encrypt=False")
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim dataTable As New DataTable()
        Try
            connection.Open()
            adapter.Fill(dataTable)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub




    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        TextBox1.Text = String.Empty
        ComboBox1.Text = String.Empty
        ComboBox2.Text = String.Empty
        ComboBox3.Text = String.Empty
        ComboBox4.Text = String.Empty
        ComboBox5.Text = String.Empty
        TextBox2.Text = String.Empty
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Dim Dashboard As New Dashboard
        Dashboard.Show()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim query As String = "INSERT INTO
      Shoe Table(Shoe ID, Brand, Model, Size,color, quantity, Price)VALUES 
            (@Shoe ID,@Brand,@Model,@Size,@Color,@quantity,@Price)"
            Dim connection As New SqlConnection("Data Source=TERMINATOR\MSSQLSERVER05;Initial Catalog=Fashion_Feet;Integrated Security=True;Encrypt=False;Trust Server Certificate=True")
        Dim command As New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@Shoe ID", TextBox1.Text)
        command.Parameters.AddWithValue("@Brand", ComboBox1.Text)
        command.Parameters.AddWithValue("@Model", ComboBox2.Text)
        command.Parameters.AddWithValue("@Size", ComboBox3.Text)
        command.Parameters.AddWithValue("@Color", ComboBox4.Text)
        command.Parameters.AddWithValue("@quantity", ComboBox5.Text)
        command.Parameters.AddWithValue("@Price", TextBox2.Text)
        Try
            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Data inserted successfully.")
            LoadData() ' Reload data after insertion
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try






    End Sub
End Class