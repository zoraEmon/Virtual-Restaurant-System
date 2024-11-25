Public Class AddFoodForm
    Private Sub btnImageSelector_Click(sender As Object, e As EventArgs) Handles btnImageSelector.Click
        Dim selectedImage As Bitmap = ImageHelper.SelectImage

        If selectedImage IsNot Nothing Then
            pbFoodImage.Image = selectedImage
        Else
            MessageBox.Show("No image was selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAddFood_Click(sender As Object, e As EventArgs) Handles btnAddFood.Click
        Dim name As String = txtFoodName.Text.Trim
        Dim price As Decimal
        Dim isValidPrice As Boolean = Decimal.TryParse(txtPrice.Text.Trim(), price)

        Dim category As String = cbFoodCategory.SelectedItem?.ToString()
        Dim taste As String = cbTasteCategory.SelectedItem?.ToString()
        Dim description As String = txtDescription.Text.Trim()
        Dim photo As Image = pbFoodImage.Image

        If String.IsNullOrEmpty(name) OrElse
           Not isValidPrice OrElse
           String.IsNullOrEmpty(category) OrElse
           String.IsNullOrEmpty(taste) Then
            MessageBox.Show("Please fill in all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim foodDal As New FoodDAL

        If foodDal.addFood(name, price, category, taste, description, photo) Then
            MessageBox.Show("Food added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Optional: Clear the form inputs after successful insertion
            ClearForm()
        Else
            MessageBox.Show("Failed to add food.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ClearForm()
        txtFoodName.Clear()
        txtPrice.Clear()
        txtDescription.Clear()
        cbFoodCategory.SelectedIndex = -1
        cbTasteCategory.SelectedIndex = -1
        pbFoodImage.Image = Nothing

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub
End Class