<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shoecustomization
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        TextBox2 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(324, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(187, 28)
        Label1.TabIndex = 0
        Label1.Text = "Shoe Customization"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(64, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 20)
        Label2.TabIndex = 1
        Label2.Text = "Customization ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(64, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 20)
        Label3.TabIndex = 2
        Label3.Text = "Lace Tpe"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(64, 199)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 20)
        Label4.TabIndex = 3
        Label4.Text = "Shoe Material"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(64, 251)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 20)
        Label5.TabIndex = 4
        Label5.Text = "Heel Size"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(64, 302)
        Label6.Name = "Label6"
        Label6.Size = New Size(130, 20)
        Label6.TabIndex = 5
        Label6.Text = "Custom Name Tag"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(84, 361)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 20)
        Label7.TabIndex = 6
        Label7.Text = "Price"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(340, 100)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 27)
        TextBox1.TabIndex = 7
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Flat laces", "Round laces", "Leather laces", "Elastic laces"})
        ComboBox1.Location = New Point(340, 146)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 8
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Mesh", "Leather", "Canvas", "Microfiber"})
        ComboBox2.Location = New Point(340, 191)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 9
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"1 inch", "2 inch", "3 inch", "4 inch", "5 inch"})
        ComboBox3.Location = New Point(340, 243)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(151, 28)
        ComboBox3.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(340, 302)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(151, 27)
        TextBox2.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(340, 354)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(151, 27)
        TextBox4.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(84, 395)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 13
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(312, 395)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 14
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(554, 395)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 15
        Button3.Text = "Save"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' shoecustomization
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "shoecustomization"
        Text = "Shoe Customization"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
