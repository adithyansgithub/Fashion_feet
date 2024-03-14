<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class order
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
        orderid = New Label()
        custid = New Label()
        Shoeid = New Label()
        CustomizationID = New Label()
        Label5 = New Label()
        totalprice = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox6 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' orderid
        ' 
        orderid.AutoSize = True
        orderid.Location = New Point(57, 83)
        orderid.Name = "orderid"
        orderid.Size = New Size(66, 20)
        orderid.TabIndex = 0
        orderid.Text = "Order ID"
        ' 
        ' custid
        ' 
        custid.AutoSize = True
        custid.Location = New Point(44, 129)
        custid.Name = "custid"
        custid.Size = New Size(91, 20)
        custid.TabIndex = 1
        custid.Text = "Customer ID"
        ' 
        ' Shoeid
        ' 
        Shoeid.AutoSize = True
        Shoeid.Location = New Point(62, 182)
        Shoeid.Name = "Shoeid"
        Shoeid.Size = New Size(61, 20)
        Shoeid.TabIndex = 2
        Shoeid.Text = "Shoe ID"
        ' 
        ' CustomizationID
        ' 
        CustomizationID.AutoSize = True
        CustomizationID.Location = New Point(34, 232)
        CustomizationID.Name = "CustomizationID"
        CustomizationID.Size = New Size(123, 20)
        CustomizationID.TabIndex = 3
        CustomizationID.Text = "Customization ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(57, 274)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 20)
        Label5.TabIndex = 4
        Label5.Text = "Order Date"
        ' 
        ' totalprice
        ' 
        totalprice.AutoSize = True
        totalprice.Location = New Point(62, 325)
        totalprice.Name = "totalprice"
        totalprice.Size = New Size(78, 20)
        totalprice.TabIndex = 5
        totalprice.Text = "Total Price"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(294, 76)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(294, 126)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(294, 179)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(294, 225)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(294, 318)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(125, 27)
        TextBox6.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(103, 371)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 12
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(325, 371)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 13
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(559, 371)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 14
        Button3.Text = "Save"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(294, 274)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(185, 27)
        DateTimePicker1.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Myanmar Text", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(304, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 51)
        Label1.TabIndex = 16
        Label1.Text = "Order Details"
        ' 
        ' order
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(totalprice)
        Controls.Add(Label5)
        Controls.Add(CustomizationID)
        Controls.Add(Shoeid)
        Controls.Add(custid)
        Controls.Add(orderid)
        Name = "order"
        Text = "Order Details"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents orderid As Label
    Friend WithEvents custid As Label
    Friend WithEvents Shoeid As Label
    Friend WithEvents CustomizationID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents totalprice As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
