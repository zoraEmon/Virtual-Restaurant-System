Imports System.Windows.Forms
Imports System.Drawing

Public Class ImageHelper
    ' Method to select an image and return it as Bitmap
    Public Shared Function SelectImage() As Bitmap
        Using openFileDialog As New OpenFileDialog()
            ' Configure the file dialog
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            openFileDialog.Title = "Select an Image"

            ' Show the file dialog and check if the user selected a file
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    ' Return the selected image as a Bitmap
                    Return New Bitmap(openFileDialog.FileName)
                Catch ex As Exception
                    MessageBox.Show($"Error: {ex.Message}", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using

        ' Return Nothing if no file was selected or an error occurred
        Return Nothing
    End Function
End Class
