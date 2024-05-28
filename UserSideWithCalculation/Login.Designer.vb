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
        PictureBox1 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UsernameTextbox
        ' 
        UsernameTextbox.Font = New Font("Segoe UI Symbol", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UsernameTextbox.Location = New Point(699, 294)
        UsernameTextbox.Name = "UsernameTextbox"
        UsernameTextbox.PlaceholderText = "Username"
        UsernameTextbox.Size = New Size(343, 51)
        UsernameTextbox.TabIndex = 0
        ' 
        ' PasswordTextbox
        ' 
        PasswordTextbox.Font = New Font("Segoe UI", 25F)
        PasswordTextbox.Location = New Point(699, 374)
        PasswordTextbox.Name = "PasswordTextbox"
        PasswordTextbox.PasswordChar = "*"c
        PasswordTextbox.PlaceholderText = "Password"
        PasswordTextbox.Size = New Size(343, 52)
        PasswordTextbox.TabIndex = 1
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.DarkGreen
        LoginButton.Font = New Font("Segoe UI", 13F)
        LoginButton.ForeColor = Color.Yellow
        LoginButton.Location = New Point(699, 464)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(343, 53)
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
        PictureBox4.Location = New Point(696, 355)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(84, 54)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 5
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(696, 294)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(84, 52)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Vanilla_1x_0_5s_280px_92px
        PictureBox1.Location = New Point(696, 152)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(346, 117)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Gray
        PictureBox6.Image = My.Resources.Resources.CDM1
        PictureBox6.Location = New Point(0, 0)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(1126, 672)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 15
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.wired_lineal_50_minus_circle
        PictureBox5.Location = New Point(998, 0)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(35, 35)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 16
        PictureBox5.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(1080, 0)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(35, 35)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 17
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(1039, 0)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(35, 35)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 18
        PictureBox8.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.LightGray
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(625, 66)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(477, 590)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 19
        PictureBox9.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1121, 668)
        ControlBox = False
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox1)
        Controls.Add(UsernameTextbox)
        Controls.Add(PasswordTextbox)
        Controls.Add(LoginButton)
        Controls.Add(PictureBox9)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox4)
        Controls.Add(LinkLabel1)
        Controls.Add(PictureBox6)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UsernameTextbox As TextBox
    Friend WithEvents PasswordTextbox As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
End Class
