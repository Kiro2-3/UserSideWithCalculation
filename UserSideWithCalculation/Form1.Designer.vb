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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        SalaryValue = New Label()
        EndShiftButton = New Button()
        Timer1 = New Timer(components)
        LogoutButton = New Button()
        PictureBox5 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        PictureBox14 = New PictureBox()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        PictureBox7 = New PictureBox()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        Label3 = New Label()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SalaryValue
        ' 
        SalaryValue.AutoSize = True
        SalaryValue.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        SalaryValue.Font = New Font("Segoe UI", 30F, FontStyle.Bold)
        SalaryValue.ForeColor = Color.Red
        SalaryValue.Location = New Point(23, 361)
        SalaryValue.Name = "SalaryValue"
        SalaryValue.Size = New Size(394, 54)
        SalaryValue.TabIndex = 1
        SalaryValue.Text = "Shift still not ended"
        ' 
        ' EndShiftButton
        ' 
        EndShiftButton.BackColor = Color.Gold
        EndShiftButton.FlatAppearance.BorderColor = Color.White
        EndShiftButton.FlatAppearance.BorderSize = 3
        EndShiftButton.FlatStyle = FlatStyle.Flat
        EndShiftButton.Image = My.Resources.Resources.Vanilla_1x_3_7s_265px_56px__2_
        EndShiftButton.Location = New Point(602, 454)
        EndShiftButton.Name = "EndShiftButton"
        EndShiftButton.Size = New Size(291, 59)
        EndShiftButton.TabIndex = 2
        EndShiftButton.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' LogoutButton
        ' 
        LogoutButton.FlatAppearance.BorderColor = Color.White
        LogoutButton.FlatAppearance.BorderSize = 3
        LogoutButton.FlatStyle = FlatStyle.Flat
        LogoutButton.Image = CType(resources.GetObject("LogoutButton.Image"), Image)
        LogoutButton.Location = New Point(912, 454)
        LogoutButton.Name = "LogoutButton"
        LogoutButton.Size = New Size(265, 59)
        LogoutButton.TabIndex = 4
        LogoutButton.UseVisualStyleBackColor = True
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.DarkGreen
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(127, 54)
        PictureBox5.Margin = New Padding(4, 3, 4, 3)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(131, 111)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 11
        PictureBox5.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.DarkGreen
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(935, 54)
        PictureBox2.Margin = New Padding(4, 3, 4, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(117, 111)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label1.Font = New Font("Arial Black", 50F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.OrangeRed
        Label1.Location = New Point(243, 181)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 95)
        Label1.TabIndex = 15
        Label1.Text = "Hi!"
        ' 
        ' PictureBox14
        ' 
        PictureBox14.BackColor = Color.DarkGreen
        PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), Image)
        PictureBox14.Location = New Point(265, 43)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(663, 131)
        PictureBox14.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox14.TabIndex = 24
        PictureBox14.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkGreen
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(-7, 43)
        Button3.Name = "Button3"
        Button3.Size = New Size(1205, 131)
        Button3.TabIndex = 26
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.wired_lineal_50_minus_circle
        PictureBox1.Location = New Point(1108, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(36, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(1150, 2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(35, 35)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 29
        PictureBox7.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label2.Font = New Font("Arial Black", 50F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Orange
        Label2.Location = New Point(12, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(252, 95)
        Label2.TabIndex = 30
        Label2.Text = "Hello!"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        PictureBox3.Location = New Point(-7, 431)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(1205, 139)
        PictureBox3.TabIndex = 31
        PictureBox3.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label3.Font = New Font("Arial Black", 25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Orange
        Label3.Location = New Point(821, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(356, 96)
        Label3.TabIndex = 32
        Label3.Text = "You are currently " & vbCrLf & "using CDMIPS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        ClientSize = New Size(1189, 549)
        ControlBox = False
        Controls.Add(LogoutButton)
        Controls.Add(EndShiftButton)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox7)
        Controls.Add(SalaryValue)
        Controls.Add(PictureBox14)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox2)
        Controls.Add(Button3)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox3)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Main UI"
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents SalaryValue As Label
    Friend WithEvents EndShiftButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LogoutButton As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label

End Class
