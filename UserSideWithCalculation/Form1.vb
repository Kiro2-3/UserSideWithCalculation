Public Class Form1
    Dim dbConn As New DatabaseConnection
    Dim calc As New Calculation
    Dim dbFunc As New DatabaseFunctions
    Dim shiftStarted As Boolean = False
    Dim shiftStartTime As DateTime
    Dim employeeID As String = ""

    Public Sub New(ByVal userID As String)
        InitializeComponent()

        employeeID = userID

        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.ControlBox = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dbConn.TestDatabaseConnection()

        If dbConn.TestDatabaseConnection Then
            MessageBox.Show("Successfully connected to the database.")

            StartShift()
        End If
    End Sub

    Private Sub StartShift()
        shiftStarted = True
        shiftStartTime = DateTime.Now
        EndShiftButton.Enabled = True

        Timer1.Start()
    End Sub

    Private Sub EndShift()
        If shiftStarted Then
            Timer1.Stop()

            Dim totalHours As Decimal = (DateTime.Now - shiftStartTime).TotalHours

            Dim dailyPay As Decimal = calc.CalculateSalaryWithDeductions(totalHours)

            dbFunc.InsertTotalDailyHours(employeeID, DateTime.Now.Date, totalHours)

            Dim salaryDate As Date = DateTime.Now.Date
            dbFunc.StoreDailySalary(employeeID, salaryDate, dailyPay)

            dbFunc.UpdateMonthlySalary(employeeID, salaryDate.Month, salaryDate.Year)

            shiftStarted = False
            EndShiftButton.Enabled = False
        Else
            MessageBox.Show("Shift has not started yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub EndShiftButton_Click(sender As Object, e As EventArgs) Handles EndShiftButton.Click
        EndShift()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim shiftDuration As TimeSpan = DateTime.Now - shiftStartTime
        SalaryValue.Text = "Shift Duration: " & shiftDuration.ToString("hh\:mm\:ss")
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        If shiftStarted Then
            Me.WindowState = FormWindowState.Minimized
        Else
            Application.Exit()
        End If
    End Sub
End Class
