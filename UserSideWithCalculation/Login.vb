Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        ' Retrieve username and password from textboxes
        Dim username As String = UsernameTextbox.Text.Trim()
        Dim password As String = PasswordTextbox.Text.Trim()

        ' Check if username or password is empty
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Connect to the database
        Dim dbConnection As New DatabaseConnection()
        Dim connectionString As String = "server=localhost;user=root;database=cdmips;port=3306;password="

        Try
            Using connection = New MySqlConnection(connectionString)
                connection.Open()

                ' Query to check if username exists and password is correct
                Dim query As String = "SELECT id FROM users WHERE username = @username AND password = @password"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Dim userID As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If userID > 0 Then
                        ' Username and password are correct, show the user ID
                        MessageBox.Show("Login successful! User ID: " & userID.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Show Form1
                        Dim form1 As New Form1(userID)
                        form1.Show()
                        Me.Hide()
                    Else
                        ' Username or password is incorrect
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error connecting to the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
