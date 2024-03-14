<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Username = New Label()
        password = New Label()
        user = New TextBox()
        passw = New TextBox()
        Login = New Button()
        showpass = New CheckBox()
        Reset = New Button()
        SuspendLayout()
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.Location = New Point(129, 77)
        Username.Name = "Username"
        Username.Size = New Size(75, 20)
        Username.TabIndex = 0
        Username.Text = "Username"
        ' 
        ' password
        ' 
        password.AutoSize = True
        password.Location = New Point(129, 159)
        password.Name = "password"
        password.Size = New Size(70, 20)
        password.TabIndex = 1
        password.Text = "Password"
        ' 
        ' user
        ' 
        user.Location = New Point(373, 80)
        user.Name = "user"
        user.Size = New Size(238, 27)
        user.TabIndex = 2
        ' 
        ' passw
        ' 
        passw.Location = New Point(373, 152)
        passw.Name = "passw"
        passw.Size = New Size(238, 27)
        passw.TabIndex = 3
        ' 
        ' Login
        ' 
        Login.Location = New Point(450, 306)
        Login.Name = "Login"
        Login.Size = New Size(270, 42)
        Login.TabIndex = 4
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = True
        ' 
        ' showpass
        ' 
        showpass.AutoSize = True
        showpass.Location = New Point(654, 154)
        showpass.Name = "showpass"
        showpass.Size = New Size(134, 24)
        showpass.TabIndex = 5
        showpass.Text = "Show password"
        showpass.UseVisualStyleBackColor = True
        ' 
        ' Reset
        ' 
        Reset.Location = New Point(129, 313)
        Reset.Name = "Reset"
        Reset.Size = New Size(233, 35)
        Reset.TabIndex = 6
        Reset.Text = "Reset"
        Reset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Reset)
        Controls.Add(showpass)
        Controls.Add(Login)
        Controls.Add(passw)
        Controls.Add(user)
        Controls.Add(password)
        Controls.Add(Username)
        Name = "Form1"
        Text = " Login Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Username As Label
    Friend WithEvents password As Label
    Friend WithEvents user As TextBox
    Friend WithEvents passw As TextBox
    Friend WithEvents Login As Button
    Friend WithEvents showpass As CheckBox
    Friend WithEvents Reset As Button

End Class
