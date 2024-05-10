Imports MySql.Data.MySqlClient

Public Class DatabaseFunctions
    Public Function GetIDAndTotalHours(ByVal id As String) As (String, Decimal)
        Dim totalHours As Decimal = 0
        Dim dbConn As New DatabaseConnection

        Dim connectionString As String = "server=localhost;user=root;database=cdmips;port=3306;password="

        Dim query As String = "SELECT ID, SUM(DailyHours) AS TotalHours FROM usertime WHERE ID = @id GROUP BY ID"

        Try
            If dbConn.TestDatabaseConnection() Then
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@id", id)

                        Dim reader As MySqlDataReader = command.ExecuteReader()

                        If reader.Read() Then
                            Dim extractedID As String = reader("ID").ToString()
                            totalHours = If(reader("TotalHours") IsNot DBNull.Value, Convert.ToDecimal(reader("TotalHours")), 0)

                            Return (extractedID, totalHours)
                        End If
                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return (String.Empty, 0)
    End Function

End Class
