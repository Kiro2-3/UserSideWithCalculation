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
        CloseButton = New Button()
        LogoutButton = New Button()
        PictureBox5 = New PictureBox()
        PictureBox2 = New PictureBox()
        Button1 = New Button()
        Label1 = New Label()
        PictureBox14 = New PictureBox()
        Button2 = New Button()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SalaryValue
        ' 
        SalaryValue.AutoSize = True
        SalaryValue.Font = New Font("Segoe UI", 30F, FontStyle.Bold)
        SalaryValue.ForeColor = Color.Gold
        SalaryValue.Location = New Point(23, 425)
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
        EndShiftButton.Location = New Point(917, 238)
        EndShiftButton.Name = "EndShiftButton"
        EndShiftButton.Size = New Size(271, 70)
        EndShiftButton.TabIndex = 2
        EndShiftButton.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' CloseButton
        ' 
        CloseButton.BackColor = Color.DarkGreen
        CloseButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        CloseButton.ForeColor = Color.White
        CloseButton.Location = New Point(1147, -4)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(30, 28)
        CloseButton.TabIndex = 3
        CloseButton.Text = "X"
        CloseButton.UseVisualStyleBackColor = False
        ' 
        ' LogoutButton
        ' 
        LogoutButton.FlatAppearance.BorderColor = Color.White
        LogoutButton.FlatAppearance.BorderSize = 3
        LogoutButton.FlatStyle = FlatStyle.Flat
        LogoutButton.Image = CType(resources.GetObject("LogoutButton.Image"), Image)
        LogoutButton.Location = New Point(917, 170)
        LogoutButton.Name = "LogoutButton"
        LogoutButton.Size = New Size(271, 62)
        LogoutButton.TabIndex = 4
        LogoutButton.UseVisualStyleBackColor = True
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.DarkGreen
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(127, 26)
        PictureBox5.Margin = New Padding(4, 3, 4, 3)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(131, 122)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 11
        PictureBox5.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.DarkGreen
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(935, 26)
        PictureBox2.Margin = New Padding(4, 3, 4, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(130, 122)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gold
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(-17, 154)
        Button1.Name = "Button1"
        Button1.Size = New Size(1205, 333)
        Button1.TabIndex = 14
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(146, 240)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 32)
        Label1.TabIndex = 15
        Label1.Text = "Hi!"
        ' 
        ' PictureBox14
        ' 
        PictureBox14.BackColor = Color.DarkGreen
        PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), Image)
        PictureBox14.Location = New Point(265, 26)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(663, 122)
        PictureBox14.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox14.TabIndex = 24
        PictureBox14.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkGreen
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(-7, 410)
        Button2.Name = "Button2"
        Button2.Size = New Size(1205, 89)
        Button2.TabIndex = 25
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGreen
        ClientSize = New Size(1189, 487)
        ControlBox = False
        Controls.Add(SalaryValue)
        Controls.Add(Button2)
        Controls.Add(PictureBox14)
        Controls.Add(Label1)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox2)
        Controls.Add(LogoutButton)
        Controls.Add(CloseButton)
        Controls.Add(EndShiftButton)
        Controls.Add(Button1)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Main UI"
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents SalaryValue As Label
    Friend WithEvents EndShiftButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CloseButton As Button
    Friend WithEvents LogoutButton As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents Button2 As Button

End Class
