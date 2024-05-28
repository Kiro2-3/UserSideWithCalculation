Imports MySql.Data.MySqlClient

Imports System.Globalization
Imports System.Windows.Forms


Public Class Form1
    Private dbConn As New DatabaseConnection
    Private calc As New Calculation
    Private dbFunc As New DatabaseFunctions
    Private shiftStarted As Boolean = False
    Private shiftStartTime As DateTime
    Private loggedInShiftStartTime As DateTime
    Private originalLoggedInShiftStartTime As DateTime
    Private employeeID As String = ""
    Private schedule As String = ""
    Dim login As New Login
    Private connectionString As String = "server=localhost;user=root;database=cdmips;port=3306;password="
    Dim topMostForm As Form = CType(Application.OpenForms(0), Form)

    Private Shared instances As New Dictionary(Of String, Form1)


    Public Sub New(ByVal userID As String, ByVal userSchedule As String)
        InitializeComponent()

        employeeID = userID
        schedule = userSchedule

        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.ControlBox = False
    End Sub

    Public Sub Logout()
        login.Show()
        Me.WindowState = FormWindowState.Minimized
        login.WindowState = FormWindowState.Normal
    End Sub

    Public Shared Function GetInstance(ByVal userID As String, ByVal userSchedule As String) As Form1
        If instances.ContainsKey(userID) Then
            Return instances(userID)
        Else
            Dim newInstance As New Form1(userID, userSchedule)
            instances.Add(userID, newInstance)
            Return newInstance
        End If
    End Function

    Private Sub StartShift()
        shiftStarted = True
        shiftStartTime = DateTime.Now - (DateTime.Now - loggedInShiftStartTime)
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
            MessageBox.Show(Me, "Shift has not started yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dbConn.TestDatabaseConnection()

        If dbConn.TestDatabaseConnection Then
            MessageBox.Show(Me, "SUCCESSFULLY CONNECTED TO DATABASE", "Caption", MessageBoxButtons.OK)

            ' Load the first name into Label1
            LoadFirstNameIntoLabel()

            Dim currentTime As DateTime = DateTime.Now
            Dim scheduleParts As String() = schedule.Split(" to ")
            If scheduleParts.Length = 2 Then
                Dim scheduleStart As DateTime
                Dim scheduleEnd As DateTime

                If DateTime.TryParseExact(scheduleParts(0), "h:mmtt", Nothing, DateTimeStyles.None, scheduleStart) Then
                    If DateTime.TryParseExact(scheduleParts(1), "h:mmtt", Nothing, DateTimeStyles.None, scheduleEnd) Then
                        If currentTime >= scheduleStart AndAlso currentTime <= scheduleEnd Then

                            loggedInShiftStartTime = DateTime.Now
                            originalLoggedInShiftStartTime = loggedInShiftStartTime
                            StartShift()
                        Else
                            MessageBox.Show(Me, "You are logging in outside your scheduled shift. Shift won't start.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show(Me, "Error parsing end time of the schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show(Me, "Error parsing start time of the schedule.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show(Me, "Invalid schedule format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub LoadFirstNameIntoLabel()
        Dim query As String = "SELECT first_name FROM users WHERE id = @id"
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", employeeID)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Label1.Text = reader("first_name").ToString()
                    Else
                        Label1.Text = "No user found."
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error loading user: " & ex.Message)
        End Try
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Logout()
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
