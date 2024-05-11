<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        UsernameTextbox = New TextBox()
        PasswordTextbox = New TextBox()
        LoginButton = New Button()
        SuspendLayout()
        ' 
        ' UsernameTextbox
        ' 
        UsernameTextbox.Location = New Point(72, 88)
        UsernameTextbox.Name = "UsernameTextbox"
        UsernameTextbox.PlaceholderText = "Username"
        UsernameTextbox.Size = New Size(100, 23)
        UsernameTextbox.TabIndex = 0
        ' 
        ' PasswordTextbox
        ' 
        PasswordTextbox.Location = New Point(72, 138)
        PasswordTextbox.Name = "PasswordTextbox"
        PasswordTextbox.PasswordChar = "*"c
        PasswordTextbox.PlaceholderText = "Password"
        PasswordTextbox.Size = New Size(100, 23)
        PasswordTextbox.TabIndex = 1
        ' 
        ' LoginButton
        ' 
        LoginButton.Location = New Point(72, 197)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(75, 23)
        LoginButton.TabIndex = 2
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(246, 339)
        Controls.Add(LoginButton)
        Controls.Add(PasswordTextbox)
        Controls.Add(UsernameTextbox)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UsernameTextbox As TextBox
    Friend WithEvents PasswordTextbox As TextBox
    Friend WithEvents LoginButton As Button
End Class
