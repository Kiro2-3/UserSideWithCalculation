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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        UsernameTextbox = New TextBox()
        PasswordTextbox = New TextBox()
        LoginButton = New Button()
        LinkLabel1 = New LinkLabel()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox7 = New PictureBox()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UsernameTextbox
        ' 
        UsernameTextbox.Font = New Font("Segoe UI", 25F)
        UsernameTextbox.Location = New Point(576, 282)
        UsernameTextbox.Name = "UsernameTextbox"
        UsernameTextbox.PlaceholderText = "Username"
        UsernameTextbox.Size = New Size(268, 52)
        UsernameTextbox.TabIndex = 0
        ' 
        ' PasswordTextbox
        ' 
        PasswordTextbox.Font = New Font("Segoe UI", 25F)
        PasswordTextbox.Location = New Point(573, 366)
        PasswordTextbox.Name = "PasswordTextbox"
        PasswordTextbox.PasswordChar = "*"c
        PasswordTextbox.PlaceholderText = "Password"
        PasswordTextbox.Size = New Size(271, 52)
        PasswordTextbox.TabIndex = 1
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.Green
        LoginButton.Font = New Font("Segoe UI", 13F)
        LoginButton.ForeColor = Color.Yellow
        LoginButton.Location = New Point(548, 515)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(272, 53)
        LoginButton.TabIndex = 2
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Verdana", 9F)
        LinkLabel1.LinkColor = Color.FromArgb(CByte(255), CByte(199), CByte(0))
        LinkLabel1.Location = New Point(671, 464)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(0, 14)
        LinkLabel1.TabIndex = 9
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(483, 364)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(84, 54)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 5
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(483, 280)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(84, 54)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(483, 107)
        PictureBox5.Margin = New Padding(4, 3, 4, 3)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(78, 79)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 10
        PictureBox5.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Vanilla_1x_0_5s_280px_92px
        PictureBox1.Location = New Point(594, 120)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(181, 57)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(782, 107)
        PictureBox2.Margin = New Padding(4, 3, 4, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(83, 79)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Green
        PictureBox7.Location = New Point(388, -11)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(564, 716)
        PictureBox7.TabIndex = 14
        PictureBox7.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(913, 668)
        ControlBox = False
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(LinkLabel1)
        Controls.Add(LoginButton)
        Controls.Add(PasswordTextbox)
        Controls.Add(UsernameTextbox)
        Controls.Add(PictureBox7)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UsernameTextbox As TextBox
    Friend WithEvents PasswordTextbox As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
End Class
