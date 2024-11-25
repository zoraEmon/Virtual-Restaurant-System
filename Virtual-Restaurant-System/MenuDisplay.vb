Public Class MenuDisplay
    Private addFoodForm As New AddFoodForm

    Private Sub MenuDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateFoodData()
    End Sub
    Private Sub PopulateFoodData()
        Dim repository As New FoodDAL
        Dim foodData As DataTable = repository.getFoodData()


        dgvFood.DataSource = foodData

        dgvFood.Columns("FoodID").HeaderText = "ID"
        dgvFood.Columns("Name").HeaderText = "Name"
        dgvFood.Columns("Description").HeaderText = "Description"
        dgvFood.Columns("Category").HeaderText = "Category"
        dgvFood.Columns("Price").HeaderText = "Price"
        dgvFood.Columns("Price").DefaultCellStyle.Format = "C" ' Format as currency
    End Sub

    Private Sub btnGoAddFoodForm_Click(sender As Object, e As EventArgs) Handles btnGoAddFoodForm.Click
        addFoodForm.Show()
    End Sub


    Private Sub btnRefreshFoodTable_Click(sender As Object, e As EventArgs) Handles btnRefreshFoodTable.Click
        PopulateFoodData()
    End Sub


End Class