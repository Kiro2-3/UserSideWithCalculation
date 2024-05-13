Imports MySql.Data.MySqlClient

Public Class DatabaseFunctions
    Dim connectionString As String = "server=localhost;user=root;database=cdmips;port=3306;password="

    Public Function TestDatabaseConnection() As Boolean
        Try
            Using connection = New MySqlConnection(connectionString)
                connection.Open()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Error connecting to the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetUserSchedule(employeeID As String) As String
        Dim schedule As String = ""

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT Schedule FROM users WHERE id = @employeeID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@employeeID", employeeID)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        schedule = reader("Schedule").ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving user schedule: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return schedule
    End Function
    Public Sub InsertTotalDailyHours(ByVal id As String, ByVal shiftDate As Date, ByVal totalDailyHours As Double)
        Dim query As String = "INSERT INTO usertime (ID, ShiftDate, DailyHours) VALUES (@id, @shiftDate, @totalDailyHours)"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@shiftDate", shiftDate)
                    cmd.Parameters.AddWithValue("@totalDailyHours", totalDailyHours)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub StoreDailySalary(ByVal id As String, ByVal salaryDate As Date, ByVal dailySalary As Decimal)
        Dim query As String = "INSERT INTO salary_info (id, salary_date, daily_salary) VALUES (@id, @salaryDate, @dailySalary)"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@salaryDate", salaryDate)
                    cmd.Parameters.AddWithValue("@dailySalary", dailySalary)
                    cmd.ExecuteNonQuery()

                    ' Check if it's the last day of the month
                    If salaryDate.Day = DateTime.DaysInMonth(salaryDate.Year, salaryDate.Month) Then
                        UpdateMonthlySalary(id, salaryDate.Month, salaryDate.Year) ' Pass the year as well
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Public Sub UpdateMonthlySalary(ByVal id As String, ByVal month As Integer, ByVal year As Integer)

        Dim totalMonthlySalary As Decimal = 0

        Dim startDate As New Date(year, month, 1)
        Dim endDate As Date = startDate.AddMonths(1).AddDays(-1)

        Dim query As String = "SELECT daily_salary FROM salary_info WHERE id = @id AND salary_date >= @startDate AND salary_date <= @endDate"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@startDate", startDate)
                    cmd.Parameters.AddWithValue("@endDate", endDate)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            totalMonthlySalary += Convert.ToDecimal(reader("daily_salary"))
                        End While
                    End Using
                End Using

                Dim updateQuery As String = "UPDATE salary_info SET monthly_salary = @totalMonthlySalary WHERE id = @id AND MONTH(salary_date) = @month AND YEAR(salary_date) = @year"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@totalMonthlySalary", totalMonthlySalary)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@month", month)
                    cmd.Parameters.AddWithValue("@year", year)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class