<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFoodForm
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
        Me.Guna2ContainerControl1 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.txtFoodName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbFoodCategory = New System.Windows.Forms.ComboBox()
        Me.cbTasteCategory = New System.Windows.Forms.ComboBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pbFoodImage = New System.Windows.Forms.PictureBox()
        Me.btnImageSelector = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddFood = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClearFields = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ContainerControl2 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.btnClose = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2ContainerControl1.SuspendLayout()
        CType(Me.pbFoodImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ContainerControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2ContainerControl1
        '
        Me.Guna2ContainerControl1.BorderRadius = 5
        Me.Guna2ContainerControl1.Controls.Add(Me.btnClearFields)
        Me.Guna2ContainerControl1.Controls.Add(Me.btnAddFood)
        Me.Guna2ContainerControl1.Controls.Add(Me.cbTasteCategory)
        Me.Guna2ContainerControl1.Controls.Add(Me.cbFoodCategory)
        Me.Guna2ContainerControl1.Controls.Add(Me.txtDescription)
        Me.Guna2ContainerControl1.Controls.Add(Me.txtPrice)
        Me.Guna2ContainerControl1.Controls.Add(Me.txtFoodName)
        Me.Guna2ContainerControl1.FillColor = System.Drawing.Color.Gray
        Me.Guna2ContainerControl1.Location = New System.Drawing.Point(457, 60)
        Me.Guna2ContainerControl1.Name = "Guna2ContainerControl1"
        Me.Guna2ContainerControl1.Size = New System.Drawing.Size(764, 664)
        Me.Guna2ContainerControl1.TabIndex = 0
        Me.Guna2ContainerControl1.Text = "Guna2ContainerControl1"
        '
        'txtFoodName
        '
        Me.txtFoodName.BackColor = System.Drawing.Color.Transparent
        Me.txtFoodName.BorderRadius = 20
        Me.txtFoodName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFoodName.DefaultText = ""
        Me.txtFoodName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFoodName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFoodName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFoodName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFoodName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFoodName.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoodName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFoodName.Location = New System.Drawing.Point(32, 70)
        Me.txtFoodName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtFoodName.Name = "txtFoodName"
        Me.txtFoodName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFoodName.PlaceholderText = "Food Name"
        Me.txtFoodName.SelectedText = ""
        Me.txtFoodName.Size = New System.Drawing.Size(338, 45)
        Me.txtFoodName.TabIndex = 0
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.Transparent
        Me.txtPrice.BorderRadius = 20
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.DefaultText = ""
        Me.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(392, 70)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PlaceholderText = "Food Price"
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.Size = New System.Drawing.Size(340, 45)
        Me.txtPrice.TabIndex = 1
        '
        'txtDescription
        '
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Location = New System.Drawing.Point(32, 200)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.PlaceholderText = "Description"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.Size = New System.Drawing.Size(695, 351)
        Me.txtDescription.TabIndex = 4
        '
        'cbFoodCategory
        '
        Me.cbFoodCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFoodCategory.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.cbFoodCategory.FormattingEnabled = True
        Me.cbFoodCategory.Items.AddRange(New Object() {"Dessert", "Appetizer", "Main Dish", "Appetizer"})
        Me.cbFoodCategory.Location = New System.Drawing.Point(32, 142)
        Me.cbFoodCategory.Name = "cbFoodCategory"
        Me.cbFoodCategory.Size = New System.Drawing.Size(338, 33)
        Me.cbFoodCategory.TabIndex = 5
        Me.cbFoodCategory.Text = "Food Category"
        '
        'cbTasteCategory
        '
        Me.cbTasteCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTasteCategory.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.cbTasteCategory.FormattingEnabled = True
        Me.cbTasteCategory.Items.AddRange(New Object() {"Sour", "Bitter", "Taste", "Spicy", "Salty", "Sweet"})
        Me.cbTasteCategory.Location = New System.Drawing.Point(394, 142)
        Me.cbTasteCategory.Name = "cbTasteCategory"
        Me.cbTasteCategory.Size = New System.Drawing.Size(338, 33)
        Me.cbTasteCategory.TabIndex = 6
        Me.cbTasteCategory.Text = "Taste Category"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'pbFoodImage
        '
        Me.pbFoodImage.Location = New System.Drawing.Point(17, 18)
        Me.pbFoodImage.Name = "pbFoodImage"
        Me.pbFoodImage.Size = New System.Drawing.Size(296, 335)
        Me.pbFoodImage.TabIndex = 1
        Me.pbFoodImage.TabStop = False
        '
        'btnImageSelector
        '
        Me.btnImageSelector.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnImageSelector.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnImageSelector.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnImageSelector.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnImageSelector.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnImageSelector.ForeColor = System.Drawing.Color.White
        Me.btnImageSelector.Location = New System.Drawing.Point(84, 359)
        Me.btnImageSelector.Name = "btnImageSelector"
        Me.btnImageSelector.Size = New System.Drawing.Size(180, 45)
        Me.btnImageSelector.TabIndex = 2
        Me.btnImageSelector.Text = "Select Image"
        '
        'btnAddFood
        '
        Me.btnAddFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddFood.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddFood.ForeColor = System.Drawing.Color.White
        Me.btnAddFood.Location = New System.Drawing.Point(552, 595)
        Me.btnAddFood.Name = "btnAddFood"
        Me.btnAddFood.Size = New System.Drawing.Size(180, 45)
        Me.btnAddFood.TabIndex = 3
        Me.btnAddFood.Text = "Add"
        '
        'btnClearFields
        '
        Me.btnClearFields.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClearFields.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClearFields.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClearFields.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClearFields.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClearFields.ForeColor = System.Drawing.Color.White
        Me.btnClearFields.Location = New System.Drawing.Point(355, 595)
        Me.btnClearFields.Name = "btnClearFields"
        Me.btnClearFields.Size = New System.Drawing.Size(180, 45)
        Me.btnClearFields.TabIndex = 7
        Me.btnClearFields.Text = "Clear"
        '
        'Guna2ContainerControl2
        '
        Me.Guna2ContainerControl2.Controls.Add(Me.pbFoodImage)
        Me.Guna2ContainerControl2.Controls.Add(Me.btnImageSelector)
        Me.Guna2ContainerControl2.FillColor = System.Drawing.Color.Gray
        Me.Guna2ContainerControl2.Location = New System.Drawing.Point(84, 60)
        Me.Guna2ContainerControl2.Name = "Guna2ContainerControl2"
        Me.Guna2ContainerControl2.Size = New System.Drawing.Size(333, 413)
        Me.Guna2ContainerControl2.TabIndex = 3
        Me.Guna2ContainerControl2.Text = "Guna2ContainerControl2"
        '
        'btnClose
        '
        Me.btnClose.BorderThickness = 1
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1213, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnClose.Size = New System.Drawing.Size(53, 49)
        Me.btnClose.TabIndex = 9
        '
        'AddFoodForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 794)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Guna2ContainerControl2)
        Me.Controls.Add(Me.Guna2ContainerControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddFoodForm"
        Me.Text = "AddFood"
        Me.Guna2ContainerControl1.ResumeLayout(False)
        CType(Me.pbFoodImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ContainerControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2ContainerControl1 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents txtFoodName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbFoodCategory As ComboBox
    Friend WithEvents cbTasteCategory As ComboBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents pbFoodImage As PictureBox
    Friend WithEvents btnImageSelector As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClearFields As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddFood As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ContainerControl2 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2CircleButton
End Class
