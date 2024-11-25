Imports Microsoft.Data.SqlClient
Imports System.Configuration
Imports System.Management
Public Class LoginForm

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim username As String = txtUsername.Text.Trim
        Dim password As String = txtPassword.Text.Trim

        Dim userFunctions As New UserDAL

        Dim userRole As Integer = userFunctions.ValidateUser(username, PasswordHasher.HashPassword(password))

        Select Case userRole
            Case 1
                Dim adminDash As New AdminDashboard(username)
                adminDash.Show()
                Me.Hide()
            Case 0
                MessageBox.Show("Hi user, Welcome to user dashboard.", "User Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case -1
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

        'If userFunctions.ValidateUser(username, PasswordHasher.HashPassword(password)) Then
        '    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    ' Navigate to the main application form'
        'Else
        '    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim regForm As New RegistrationForm()

        regForm.Show()

        Me.Hide()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
