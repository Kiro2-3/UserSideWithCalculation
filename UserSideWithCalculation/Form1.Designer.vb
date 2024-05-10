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
        Total_Hours = New Label()
        SalaryValue = New Label()
        SuspendLayout()
        ' 
        ' Total_Hours
        ' 
        Total_Hours.AutoSize = True
        Total_Hours.Location = New Point(12, 19)
        Total_Hours.Name = "Total_Hours"
        Total_Hours.Size = New Size(97, 15)
        Total_Hours.TabIndex = 0
        Total_Hours.Text = "Calculated Salary"
        ' 
        ' SalaryValue
        ' 
        SalaryValue.AutoSize = True
        SalaryValue.Location = New Point(126, 68)
        SalaryValue.Name = "SalaryValue"
        SalaryValue.Size = New Size(41, 15)
        SalaryValue.TabIndex = 1
        SalaryValue.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(364, 186)
        Controls.Add(SalaryValue)
        Controls.Add(Total_Hours)
        Name = "Form1"
        Text = "Main UI"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Total_Hours As Label
    Friend WithEvents SalaryValue As Label

End Class
