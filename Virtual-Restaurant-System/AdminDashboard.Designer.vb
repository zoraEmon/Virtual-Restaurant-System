<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnOrders = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelAdminName = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.btnStaff = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnStaff)
        Me.Guna2Panel1.Controls.Add(Me.btnOrders)
        Me.Guna2Panel1.Controls.Add(Me.btnMenu)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(220, 837)
        Me.Guna2Panel1.TabIndex = 0
        '
        'btnOrders
        '
        Me.btnOrders.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnOrders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOrders.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrders.FillColor = System.Drawing.Color.White
        Me.btnOrders.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnOrders.ForeColor = System.Drawing.Color.Black
        Me.btnOrders.Location = New System.Drawing.Point(0, 222)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(220, 45)
        Me.btnOrders.TabIndex = 3
        Me.btnOrders.Text = "Orders"
        '
        'btnMenu
        '
        Me.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenu.FillColor = System.Drawing.SystemColors.Window
        Me.btnMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMenu.Location = New System.Drawing.Point(0, 177)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(220, 45)
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.Text = "Menu"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.Label2)
        Me.Guna2Panel4.Controls.Add(Me.labelAdminName)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 59)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(220, 118)
        Me.Guna2Panel4.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Admin"
        '
        'labelAdminName
        '
        Me.labelAdminName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelAdminName.AutoSize = True
        Me.labelAdminName.Font = New System.Drawing.Font("Arial Black", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAdminName.Location = New System.Drawing.Point(61, 44)
        Me.labelAdminName.Name = "labelAdminName"
        Me.labelAdminName.Size = New System.Drawing.Size(93, 32)
        Me.labelAdminName.TabIndex = 2
        Me.labelAdminName.Text = "Admin"
        Me.labelAdminName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(220, 59)
        Me.Guna2Panel3.TabIndex = 2
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(220, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1318, 59)
        Me.Guna2Panel2.TabIndex = 1
        '
        'panelMain
        '
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(220, 59)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1318, 778)
        Me.panelMain.TabIndex = 2
        '
        'btnStaff
        '
        Me.btnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStaff.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStaff.FillColor = System.Drawing.Color.White
        Me.btnStaff.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnStaff.ForeColor = System.Drawing.Color.Black
        Me.btnStaff.Location = New System.Drawing.Point(0, 267)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(220, 45)
        Me.btnStaff.TabIndex = 4
        Me.btnStaff.Text = "Staffs"
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1538, 837)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "AdminDashboard"
        Me.Text = "Form1"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labelAdminName As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOrders As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelMain As Panel
    Friend WithEvents btnStaff As Guna.UI2.WinForms.Guna2Button
End Class
