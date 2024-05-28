Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class Login
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim username As String = UsernameTextbox.Text.Trim()
        Dim password As String = PasswordTextbox.Text.Trim()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dbConnection As New DatabaseConnection()
        Dim connectionString As String = "server=localhost;user=root;database=cdmips;port=3306;password="

        Try
            Using connection = New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT id, schedule FROM users WHERE username = @username AND password = @password"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        Dim userID As Integer = reader.GetInt32("id")
                        Dim userSchedule As String = reader.GetString("schedule")

                        MessageBox.Show("Login successful! User ID: " & userID.ToString() & vbCrLf & "Schedule: " & userSchedule, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim form1 As New Form1(userID.ToString(), userSchedule)
                        form1.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error connecting to the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
