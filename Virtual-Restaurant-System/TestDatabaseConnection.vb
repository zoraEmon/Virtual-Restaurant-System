Imports System.Configuration
Imports Microsoft.Data.SqlClient
Module TestDatabaseConnection
    Sub Main()
        ' Read the connection string from app.config
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyDbConnection").ConnectionString

        ' Test the connection
        Using connection As New SqlConnection(connectionString)
            Try
                Console.WriteLine("Attempting to open database connection...")
                connection.Open()
                Console.WriteLine("Connection successful!")
            Catch ex As Exception
                Console.WriteLine($"Error: {ex.Message}")
            Finally
                ' Close the connection
                If connection.State = System.Data.ConnectionState.Open Then
                    connection.Close()
                    Console.WriteLine("Connection closed.")
                End If
            End Try
        End Using

        Console.ReadLine()
    End Sub
End Module
