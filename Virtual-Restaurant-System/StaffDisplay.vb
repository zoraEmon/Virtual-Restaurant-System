Public Class StaffDisplay

    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaffData()
    End Sub

    Private Sub LoadStaffData()
        Dim staffDAL As New StaffDAL()
        Dim staffData As DataTable = staffDAL.GetStaffData()

        If staffData IsNot Nothing Then
            dgvStaff.DataSource = staffData
            dgvStaff.AutoResizeColumns() ' Adjust column width for better visibility
        End If
    End Sub
End Class