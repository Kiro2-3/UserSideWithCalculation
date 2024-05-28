Imports MySql.Data.MySqlClient

Public Class DatabaseConnection
    Public Function TestDatabaseConnection() As Boolean
        Dim connectionString As String = "server=localhost;user=root;database=cdmips; port=3306;password="

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
End Class
