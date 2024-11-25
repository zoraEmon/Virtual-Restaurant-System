Imports System.Configuration
Imports System.Windows
Imports Microsoft.Data.SqlClient


Public Class RegistrationForm
    Private Sub btnRegistration_Click(sender As Object, e As EventArgs) Handles btnRegistration.Click
        'Validate Inputs'
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtPhoneNum.Text) OrElse
           String.IsNullOrWhiteSpace(cbTastePreference.SelectedIndex.ToString) Then

            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Create a New User Object
        Dim newUser As New User(
            txtUsername.Text.Trim(),
            PasswordHasher.HashPassword(txtPassword.Text.Trim()),
            txtPhoneNum.Text.Trim(),
            dtBirthdate.Value.Date,
            cbTastePreference.SelectedItem.ToString.Trim()
        )

        ' Use UserDAL to Register the User
        Dim userDal As New UserDAL()
        If userDal.Register(newUser) Then
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optionally, clear the input fields
            ClearInputs()
        Else
            MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ClearInputs()
        txtUsername.Clear()
        txtPassword.Clear()
        txtPhoneNum.Clear()
        dtBirthdate.Value = DateTime.Now
        cbTastePreference.SelectedIndex = -1 ' Reset ComboBox selection
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim loginForm As New LoginForm
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Close()

    End Sub
End Class