Public Class Calculation
    Public Function CalculateSalaryWithDeductions(ByVal totalHours As Decimal) As Decimal
        Const regularHourlyRate As Decimal = 108.33
        Const overtimeHourlyRate As Decimal = regularHourlyRate * 1.5
        Const regularHoursPerWeek As Decimal = 40

        Dim regularPay As Decimal = 0
        Dim overtimePay As Decimal = 0
        Dim grossPay As Decimal = 0
        Dim socialSecurityDeduction As Decimal = 0
        Dim philHealthDeduction As Decimal = 0
        Dim pagIbigDeduction As Decimal = 0
        Dim netPay As Decimal = 0

        Try
            regularPay = totalHours * regularHourlyRate

            If totalHours > regularHoursPerWeek Then
                Dim overtimeHours As Decimal = totalHours - regularHoursPerWeek

                overtimePay = overtimeHours * overtimeHourlyRate

                grossPay = regularPay + overtimePay
            Else
                grossPay = regularPay
            End If

            socialSecurityDeduction = grossPay * 0.0572
            philHealthDeduction = grossPay * 0.082
            pagIbigDeduction = grossPay * 0.055

            netPay = grossPay - (socialSecurityDeduction + philHealthDeduction + pagIbigDeduction)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return netPay
    End Function


End Class
