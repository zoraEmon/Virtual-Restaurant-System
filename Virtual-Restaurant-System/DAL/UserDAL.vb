Imports System.Data.SqlClient
Imports System.Configuration
Public Class UserDAL
    Public Function Register(user As User) As Boolean
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyDbConnection").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO Users (Username, Password, PhoneNumber, Birthdate, TastePreference, IsAdmin) VALUES (@Username, @Password, @PhoneNumber, @Birthdate, @TastePreference, 0)"
            Dim command As New SqlCommand(query, connection)

            ' Parameters lamang to para ma inject sa database
            command.Parameters.AddWithValue("@Username", user.Username)
            command.Parameters.AddWithValue("@Password", user.Password)
            command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber)
            command.Parameters.AddWithValue("@Birthdate", user.Birthdate)
            command.Parameters.AddWithValue("@TastePreference", user.TastePreference)

            Try
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                Return rowsAffected > 0 ' Returns True if at least one row is inserted
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Public Function ValidateUser(username As String, password As String) As Integer
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyDbConnection").ConnectionString
        Dim query As String = "SELECT IsAdmin FROM Users WHERE UserName = @Username AND Password = @Password"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@Password", password) ' Dito dat naka hashed or else makikita password mo sa database

            Try
                connection.Open()
                Dim result = command.ExecuteScalar()

                If result IsNot Nothing Then
                    ' Check whether kung admin or nah
                    Return If(Convert.ToBoolean(result), 1, 0)
                Else
                    ' User not found. User??
                    Return -1
                End If
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return -1
            End Try
        End Using
    End Function
End Class
