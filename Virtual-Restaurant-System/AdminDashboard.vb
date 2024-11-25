Public Class AdminDashboard
    Private adminName As String
    Private menuDisplayForm As New MenuDisplay
    Private ordersDisplayForm As New OrdersDisplay
    Private staffDisplayForm As New StaffDisplay

    Public Sub New(adminName As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.adminName = adminName

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelAdminName.Text = adminName
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles btnMenu.Click
        btnMenu.FillColor = ColorTranslator.FromHtml("#a250fa")
        btnMenu.ForeColor = ColorTranslator.FromHtml("#f2f0f5")
        menuDisplayForm.TopLevel = False
        menuDisplayForm.Dock = DockStyle.Fill

        panelMain.Controls.Clear()
        panelMain.Controls.Add(menuDisplayForm)

        menuDisplayForm.Show()


    End Sub


    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        btnOrders.FillColor = ColorTranslator.FromHtml("#a250fa")
        btnOrders.ForeColor = ColorTranslator.FromHtml("#f2f0f5")
        ordersDisplayForm.TopLevel = False
        ordersDisplayForm.Dock = DockStyle.Fill

        panelMain.Controls.Clear()
        panelMain.Controls.Add(ordersDisplayForm)

        ordersDisplayForm.Show()
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        btnStaff.FillColor = ColorTranslator.FromHtml("#a250fa")
        btnStaff.ForeColor = ColorTranslator.FromHtml("#f2f0f5")
        staffDisplayForm.TopLevel = False
        staffDisplayForm.Dock = DockStyle.Fill

        panelMain.Controls.Clear()
        panelMain.Controls.Add(staffDisplayForm)

        staffDisplayForm.Show()

    End Sub


End Class