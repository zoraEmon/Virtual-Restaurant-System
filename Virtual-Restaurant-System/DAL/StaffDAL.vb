Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO

Public Class StaffDAL

    Public Function GetStaffData() As DataTable
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyDbConnection").ConnectionString
        Dim query As String = "SELECT StaffID, Name, Role, PerformanceRating FROM Staff"

        Dim staffTable As New DataTable

        Using connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, connection)
            Try
                adapter.Fill(staffTable)
                Return staffTable
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return staffTable
    End Function
End Class
