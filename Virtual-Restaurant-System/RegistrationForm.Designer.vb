<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrationForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ContainerControl3 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.Guna2ContainerControl2 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.cbTastePreference = New System.Windows.Forms.ComboBox()
        Me.dtBirthdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtPhoneNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRegistration = New Guna.UI2.WinForms.Guna2Button()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ContainerControl1 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Me.Guna2ContainerControl2.SuspendLayout()
        Me.Guna2ContainerControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ContainerControl3
        '
        Me.Guna2ContainerControl3.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Guna2ContainerControl3.BackgroundImage = Global.Virtual_Restaurant_System.My.Resources.Resources.image_1
        Me.Guna2ContainerControl3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2ContainerControl3.BorderRadius = 50
        Me.Guna2ContainerControl3.FillColor = System.Drawing.Color.Empty
        Me.Guna2ContainerControl3.Location = New System.Drawing.Point(851, 26)
        Me.Guna2ContainerControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2ContainerControl3.Name = "Guna2ContainerControl3"
        Me.Guna2ContainerControl3.Size = New System.Drawing.Size(587, 741)
        Me.Guna2ContainerControl3.TabIndex = 2
        Me.Guna2ContainerControl3.Text = "Guna2ContainerControl3"
        '
        'Guna2ContainerControl2
        '
        Me.Guna2ContainerControl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Guna2ContainerControl2.BorderRadius = 15
        Me.Guna2ContainerControl2.Controls.Add(Me.cbTastePreference)
        Me.Guna2ContainerControl2.Controls.Add(Me.dtBirthdate)
        Me.Guna2ContainerControl2.Controls.Add(Me.txtPhoneNum)
        Me.Guna2ContainerControl2.Controls.Add(Me.Label4)
        Me.Guna2ContainerControl2.Controls.Add(Me.Guna2CircleButton1)
        Me.Guna2ContainerControl2.Controls.Add(Me.LinkLabel1)
        Me.Guna2ContainerControl2.Controls.Add(Me.Label3)
        Me.Guna2ContainerControl2.Controls.Add(Me.btnRegistration)
        Me.Guna2ContainerControl2.Controls.Add(Me.txtUsername)
        Me.Guna2ContainerControl2.Controls.Add(Me.Guna2TextBox2)
        Me.Guna2ContainerControl2.Controls.Add(Me.txtPassword)
        Me.Guna2ContainerControl2.Controls.Add(Me.Label2)
        Me.Guna2ContainerControl2.Controls.Add(Me.Label1)
        Me.Guna2ContainerControl2.Location = New System.Drawing.Point(41, 26)
        Me.Guna2ContainerControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2ContainerControl2.Name = "Guna2ContainerControl2"
        Me.Guna2ContainerControl2.Size = New System.Drawing.Size(801, 741)
        Me.Guna2ContainerControl2.TabIndex = 1
        Me.Guna2ContainerControl2.Text = "Guna2ContainerControl2"
        '
        'cbTastePreference
        '
        Me.cbTastePreference.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTastePreference.FormattingEnabled = True
        Me.cbTastePreference.Items.AddRange(New Object() {"Sour", "Bitter", "Spicy", "Sweet", "Salty"})
        Me.cbTastePreference.Location = New System.Drawing.Point(443, 409)
        Me.cbTastePreference.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTastePreference.Name = "cbTastePreference"
        Me.cbTastePreference.Size = New System.Drawing.Size(300, 38)
        Me.cbTastePreference.TabIndex = 14
        Me.cbTastePreference.Text = "Taste Preference"
        '
        'dtBirthdate
        '
        Me.dtBirthdate.BorderRadius = 50
        Me.dtBirthdate.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.dtBirthdate.Checked = True
        Me.dtBirthdate.FillColor = System.Drawing.Color.White
        Me.dtBirthdate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtBirthdate.Location = New System.Drawing.Point(81, 409)
        Me.dtBirthdate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtBirthdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtBirthdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtBirthdate.Name = "dtBirthdate"
        Me.dtBirthdate.Size = New System.Drawing.Size(301, 44)
        Me.dtBirthdate.TabIndex = 13
        Me.dtBirthdate.Value = New Date(2024, 11, 23, 5, 43, 43, 403)
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhoneNum.DefaultText = ""
        Me.txtPhoneNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhoneNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhoneNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhoneNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNum.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNum.Location = New System.Drawing.Point(81, 306)
        Me.txtPhoneNum.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneNum.PlaceholderText = "Phone Number"
        Me.txtPhoneNum.SelectedText = ""
        Me.txtPhoneNum.Size = New System.Drawing.Size(663, 55)
        Me.txtPhoneNum.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 268)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 31)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Phone Number"
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.BorderThickness = 1
        Me.Guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(15, 15)
        Me.Guna2CircleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(53, 49)
        Me.Guna2CircleButton1.TabIndex = 8
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Gray
        Me.LinkLabel1.Location = New System.Drawing.Point(457, 613)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(66, 25)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Log In"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 613)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Already Have an Account?"
        '
        'btnRegistration
        '
        Me.btnRegistration.BorderRadius = 20
        Me.btnRegistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRegistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRegistration.FillColor = System.Drawing.Color.Black
        Me.btnRegistration.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistration.ForeColor = System.Drawing.Color.White
        Me.btnRegistration.Location = New System.Drawing.Point(140, 523)
        Me.btnRegistration.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegistration.Name = "btnRegistration"
        Me.btnRegistration.Size = New System.Drawing.Size(484, 66)
        Me.btnRegistration.TabIndex = 5
        Me.btnRegistration.Text = "Sign Up"
        '
        'txtUsername
        '
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(81, 161)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(301, 55)
        Me.txtUsername.TabIndex = 4
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(140, 743)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(7)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = "Password"
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(1117, 89)
        Me.Guna2TextBox2.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(443, 161)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(301, 55)
        Me.txtPassword.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(436, 123)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 119)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Guna2ContainerControl1
        '
        Me.Guna2ContainerControl1.Controls.Add(Me.Guna2ContainerControl3)
        Me.Guna2ContainerControl1.Controls.Add(Me.Guna2ContainerControl2)
        Me.Guna2ContainerControl1.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Guna2ContainerControl1.Location = New System.Drawing.Point(41, 39)
        Me.Guna2ContainerControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2ContainerControl1.Name = "Guna2ContainerControl1"
        Me.Guna2ContainerControl1.Size = New System.Drawing.Size(1473, 806)
        Me.Guna2ContainerControl1.TabIndex = 1
        Me.Guna2ContainerControl1.Text = "Guna2ContainerControl1"
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1556, 884)
        Me.Controls.Add(Me.Guna2ContainerControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RegistrationForm"
        Me.Text = "Form2"
        Me.Guna2ContainerControl2.ResumeLayout(False)
        Me.Guna2ContainerControl2.PerformLayout()
        Me.Guna2ContainerControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ContainerControl1 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents Guna2ContainerControl3 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents Guna2ContainerControl2 As Guna.UI2.WinForms.Guna2ContainerControl
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegistration As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPhoneNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtBirthdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents cbTastePreference As ComboBox
End Class
