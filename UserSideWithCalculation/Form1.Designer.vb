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
        Total_Hours = New Label()
        SalaryValue = New Label()
        EndShiftButton = New Button()
        Timer1 = New Timer(components)
        CloseButton = New Button()
        SuspendLayout()
        ' 
        ' Total_Hours
        ' 
        Total_Hours.AutoSize = True
        Total_Hours.Location = New Point(47, 54)
        Total_Hours.Name = "Total_Hours"
        Total_Hours.Size = New Size(97, 15)
        Total_Hours.TabIndex = 0
        Total_Hours.Text = "Calculated Salary"
        ' 
        ' SalaryValue
        ' 
        SalaryValue.AutoSize = True
        SalaryValue.Location = New Point(142, 101)
        SalaryValue.Name = "SalaryValue"
        SalaryValue.Size = New Size(109, 15)
        SalaryValue.TabIndex = 1
        SalaryValue.Text = "Shift still not ended"
        ' 
        ' EndShiftButton
        ' 
        EndShiftButton.Location = New Point(176, 12)
        EndShiftButton.Name = "EndShiftButton"
        EndShiftButton.Size = New Size(75, 23)
        EndShiftButton.TabIndex = 2
        EndShiftButton.Text = "EndShift"
        EndShiftButton.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' CloseButton
        ' 
        CloseButton.Location = New Point(303, 12)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(49, 23)
        CloseButton.TabIndex = 3
        CloseButton.Text = "X"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(364, 186)
        ControlBox = False
        Controls.Add(CloseButton)
        Controls.Add(EndShiftButton)
        Controls.Add(SalaryValue)
        Controls.Add(Total_Hours)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Main UI"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Total_Hours As Label
    Friend WithEvents SalaryValue As Label
    Friend WithEvents EndShiftButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CloseButton As Button

End Class
