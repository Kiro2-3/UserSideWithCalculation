Public Class Form1
    Dim dbConn As New DatabaseConnection
    Dim calc As New Calculation
    Dim dbFunc As New DatabaseFunctions


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dbConn.TestDatabaseConnection()

        If dbConn.TestDatabaseConnection Then
            MessageBox.Show("Successfully connected to the database.")

            Dim idToGet As String = "9"

            Dim idAndTotalHours = dbFunc.GetIDAndTotalHours(idToGet)

            Dim totalHours As Decimal = idAndTotalHours.Item2

            Dim netPay As Decimal = calc.CalculateSalaryWithDeductions(totalHours)
            SalaryValue.Text = netPay.ToString("C")
        End If
    End Sub
End Class
