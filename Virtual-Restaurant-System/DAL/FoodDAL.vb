Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO

Public Class FoodDAL
    Public Function getFoodData() As DataTable
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyDbConnection").ConnectionString
        Dim query As String = "SELECT FoodID, Name, Description, Category, Price FROM Food"

        Dim foodTable As New DataTable

        Using connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, connection)

            Try
                adapter.Fill(foodTable)
                Return foodTable
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return foodTable
    End Function

    Public Function addFood(foodName As String, foodPrice As Decimal, foodCategory As String, foodTaste As String, foodDescription As String, foodPhoto As Image) As Boolean
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyDbConnection").ConnectionString
        Dim query As String = "INSERT INTO Food (Name, Description, Category, Price, Photo, Taste) VALUES (@Name, @Description, @Category, @Price, @Photo, @Taste)"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)

            command.Parameters.AddWithValue("@Name", foodName)
            command.Parameters.AddWithValue("@Description", foodDescription)
            command.Parameters.AddWithValue("@Category", foodCategory)
            command.Parameters.AddWithValue("@Price", foodPrice)

            command.Parameters.AddWithValue("@Taste", foodTaste)

            If foodPhoto IsNot Nothing Then
                Using ms As New MemoryStream()
                    foodPhoto.Save(ms, foodPhoto.RawFormat)
                    command.Parameters.AddWithValue("@Photo", ms.ToArray)
                End Using
            Else
                command.Parameters.AddWithValue("@Photo", DBNull.Value)
            End If

            Try
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                Return rowsAffected > 0
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function
End Class
