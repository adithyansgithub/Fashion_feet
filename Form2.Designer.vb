<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shoedetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        shoeid = New Label()
        shoebrand = New Label()
        Shoemodel = New Label()
        shoesize = New Label()
        label = New Label()
        quantity = New Label()
        Price = New Label()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox5 = New ComboBox()
        TextBox2 = New TextBox()
        Cancel = New Button()
        OK = New Button()
        Back = New Button()
        SuspendLayout()
        ' 
        ' shoeid
        ' 
        shoeid.AutoSize = True
        shoeid.Location = New Point(279, 63)
        shoeid.Name = "shoeid"
        shoeid.Size = New Size(70, 23)
        shoeid.TabIndex = 0
        shoeid.Text = "Shoe ID"
        ' 
        ' shoebrand
        ' 
        shoebrand.AutoSize = True
        shoebrand.Location = New Point(269, 119)
        shoebrand.Name = "shoebrand"
        shoebrand.Size = New Size(98, 23)
        shoebrand.TabIndex = 1
        shoebrand.Text = "Shoe Brand"
        ' 
        ' Shoemodel
        ' 
        Shoemodel.AutoSize = True
        Shoemodel.Location = New Point(269, 187)
        Shoemodel.Name = "Shoemodel"
        Shoemodel.Size = New Size(101, 23)
        Shoemodel.TabIndex = 2
        Shoemodel.Text = "Shoe Model"
        ' 
        ' shoesize
        ' 
        shoesize.AutoSize = True
        shoesize.Location = New Point(269, 246)
        shoesize.Name = "shoesize"
        shoesize.Size = New Size(83, 23)
        shoesize.TabIndex = 3
        shoesize.Text = "Shoe Size"
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Location = New Point(261, 301)
        label.Name = "label"
        label.Size = New Size(91, 23)
        label.TabIndex = 4
        label.Text = "Shoe color"
        ' 
        ' quantity
        ' 
        quantity.AutoSize = True
        quantity.Location = New Point(279, 357)
        quantity.Name = "quantity"
        quantity.Size = New Size(73, 23)
        quantity.TabIndex = 5
        quantity.Text = "quantity"
        ' 
        ' Price
        ' 
        Price.AutoSize = True
        Price.Location = New Point(305, 415)
        Price.Name = "Price"
        Price.Size = New Size(47, 23)
        Price.TabIndex = 6
        Price.Text = "Price"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(488, 56)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 30)
        TextBox1.TabIndex = 7
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Puma", "Adidas", "Nike", "Reebok", "Sparx", "Converse"})
        ComboBox1.Location = New Point(488, 111)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 31)
        ComboBox1.TabIndex = 8
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Sneakers", "Loafers", "Boots", "High Heels"})
        ComboBox2.Location = New Point(488, 179)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 31)
        ComboBox2.TabIndex = 9
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"6", "7", "8", "9", "10", "11", "12"})
        ComboBox3.Location = New Point(488, 246)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(151, 31)
        ComboBox3.TabIndex = 10
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"Black ", "White", "Red", "Blue", "Yellow", "Green"})
        ComboBox4.Location = New Point(488, 301)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(151, 31)
        ComboBox4.TabIndex = 11
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        ComboBox5.Location = New Point(488, 354)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(151, 31)
        ComboBox5.TabIndex = 12
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(488, 408)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(151, 30)
        TextBox2.TabIndex = 13
        ' 
        ' Cancel
        ' 
        Cancel.Location = New Point(406, 460)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 29)
        Cancel.TabIndex = 14
        Cancel.Text = "Reset"
        Cancel.UseVisualStyleBackColor = True
        ' 
        ' OK
        ' 
        OK.Location = New Point(568, 460)
        OK.Name = "OK"
        OK.Size = New Size(94, 29)
        OK.TabIndex = 15
        OK.Text = "OK"
        OK.UseVisualStyleBackColor = True
        ' 
        ' Back
        ' 
        Back.Location = New Point(255, 460)
        Back.Name = "Back"
        Back.Size = New Size(94, 29)
        Back.TabIndex = 16
        Back.Text = "Back"
        Back.UseVisualStyleBackColor = True
        ' 
        ' Shoedetails
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(894, 516)
        Controls.Add(Back)
        Controls.Add(OK)
        Controls.Add(Cancel)
        Controls.Add(TextBox2)
        Controls.Add(ComboBox5)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        Controls.Add(Price)
        Controls.Add(quantity)
        Controls.Add(label)
        Controls.Add(shoesize)
        Controls.Add(Shoemodel)
        Controls.Add(shoebrand)
        Controls.Add(shoeid)
        Font = New Font("Segoe UI", 10F)
        Name = "Shoedetails"
        Text = "Shoe Details"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents shoeid As Label
    Friend WithEvents shoebrand As Label
    Friend WithEvents Shoemodel As Label
    Friend WithEvents shoesize As Label
    Friend WithEvents label As Label
    Friend WithEvents quantity As Label
    Friend WithEvents Price As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents Back As Button
End Class
