<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Order_Details = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(66, 193)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 56)
        Button1.TabIndex = 0
        Button1.Text = "Shoe"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(246, 193)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 56)
        Button2.TabIndex = 1
        Button2.Text = "customer"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(423, 193)
        Button3.Name = "Button3"
        Button3.Size = New Size(134, 56)
        Button3.TabIndex = 2
        Button3.Text = "customization"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(312, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 37)
        Label1.TabIndex = 3
        Label1.Text = "DASHBOARD"
        ' 
        ' Order_Details
        ' 
        Order_Details.Location = New Point(620, 193)
        Order_Details.Name = "Order_Details"
        Order_Details.Size = New Size(107, 56)
        Order_Details.TabIndex = 4
        Order_Details.Text = "Order Details"
        Order_Details.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(352, 347)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 5
        Button4.Text = "EXIT"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(Order_Details)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Dashboard"
        Text = "Dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Order_Details As Button
    Friend WithEvents Button4 As Button
End Class
