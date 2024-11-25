<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuDisplay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvFood = New System.Windows.Forms.DataGridView()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnGoAddFoodForm = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRefreshFoodTable = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvFood, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFood
        '
        Me.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFood.Location = New System.Drawing.Point(149, 93)
        Me.dgvFood.Name = "dgvFood"
        Me.dgvFood.RowHeadersWidth = 51
        Me.dgvFood.RowTemplate.Height = 24
        Me.dgvFood.Size = New System.Drawing.Size(1021, 457)
        Me.dgvFood.TabIndex = 0
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btnGoAddFoodForm
        '
        Me.btnGoAddFoodForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGoAddFoodForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGoAddFoodForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGoAddFoodForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGoAddFoodForm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGoAddFoodForm.ForeColor = System.Drawing.Color.White
        Me.btnGoAddFoodForm.Location = New System.Drawing.Point(990, 628)
        Me.btnGoAddFoodForm.Name = "btnGoAddFoodForm"
        Me.btnGoAddFoodForm.Size = New System.Drawing.Size(180, 45)
        Me.btnGoAddFoodForm.TabIndex = 1
        Me.btnGoAddFoodForm.Text = "Add Food"
        '
        'btnRefreshFoodTable
        '
        Me.btnRefreshFoodTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRefreshFoodTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRefreshFoodTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRefreshFoodTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRefreshFoodTable.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefreshFoodTable.ForeColor = System.Drawing.Color.White
        Me.btnRefreshFoodTable.Location = New System.Drawing.Point(778, 628)
        Me.btnRefreshFoodTable.Name = "btnRefreshFoodTable"
        Me.btnRefreshFoodTable.Size = New System.Drawing.Size(180, 45)
        Me.btnRefreshFoodTable.TabIndex = 2
        Me.btnRefreshFoodTable.Text = "Refresh Table"
        '
        'MenuDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 731)
        Me.Controls.Add(Me.btnRefreshFoodTable)
        Me.Controls.Add(Me.btnGoAddFoodForm)
        Me.Controls.Add(Me.dgvFood)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuDisplay"
        Me.Text = "MenuDisplay"
        CType(Me.dgvFood, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvFood As DataGridView
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnGoAddFoodForm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRefreshFoodTable As Guna.UI2.WinForms.Guna2Button
End Class
