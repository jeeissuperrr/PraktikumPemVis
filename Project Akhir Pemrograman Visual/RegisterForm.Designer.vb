<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        txtNewUsername = New TextBox()
        txtNewPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        btnRegister = New Button()
        btnCancel = New Button()
        lblRegErrorMessage = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNewUsername
        ' 
        txtNewUsername.BackColor = Color.DarkOliveGreen
        txtNewUsername.BorderStyle = BorderStyle.None
        txtNewUsername.Font = New Font("Segoe UI", 13F)
        txtNewUsername.ForeColor = Color.White
        txtNewUsername.Location = New Point(137, 111)
        txtNewUsername.Margin = New Padding(4, 3, 4, 3)
        txtNewUsername.Name = "txtNewUsername"
        txtNewUsername.Size = New Size(181, 24)
        txtNewUsername.TabIndex = 0
        txtNewUsername.Text = "New Username"
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.BackColor = Color.DarkOliveGreen
        txtNewPassword.BorderStyle = BorderStyle.None
        txtNewPassword.Font = New Font("Segoe UI", 13F)
        txtNewPassword.ForeColor = Color.White
        txtNewPassword.Location = New Point(137, 152)
        txtNewPassword.Margin = New Padding(4, 3, 4, 3)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.PasswordChar = "*"c
        txtNewPassword.Size = New Size(181, 24)
        txtNewPassword.TabIndex = 1
        txtNewPassword.Text = "New Password"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BackColor = Color.DarkOliveGreen
        txtConfirmPassword.BorderStyle = BorderStyle.None
        txtConfirmPassword.Font = New Font("Segoe UI", 13F)
        txtConfirmPassword.ForeColor = Color.White
        txtConfirmPassword.Location = New Point(137, 190)
        txtConfirmPassword.Margin = New Padding(4, 3, 4, 3)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "*"c
        txtConfirmPassword.Size = New Size(181, 24)
        txtConfirmPassword.TabIndex = 2
        txtConfirmPassword.Text = "Confirm Password"
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Black
        btnRegister.FlatAppearance.BorderColor = Color.Black
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(99, 248)
        btnRegister.Margin = New Padding(4, 3, 4, 3)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(105, 35)
        btnRegister.TabIndex = 3
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Black
        btnCancel.FlatAppearance.BorderColor = Color.Black
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(213, 248)
        btnCancel.Margin = New Padding(4, 3, 4, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(105, 35)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' lblRegErrorMessage
        ' 
        lblRegErrorMessage.ForeColor = Color.Red
        lblRegErrorMessage.Location = New Point(23, 23)
        lblRegErrorMessage.Margin = New Padding(4, 0, 4, 0)
        lblRegErrorMessage.Name = "lblRegErrorMessage"
        lblRegErrorMessage.Size = New Size(350, 23)
        lblRegErrorMessage.TabIndex = 8
        lblRegErrorMessage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(173, 33)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(62, 46)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(99, 111)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(31, 26)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(99, 152)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(31, 26)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(99, 190)
        PictureBox4.Margin = New Padding(3, 2, 3, 2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(31, 26)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 12
        PictureBox4.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Location = New Point(99, 139)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(219, 1)
        Panel1.TabIndex = 13
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(99, 178)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(219, 1)
        Panel2.TabIndex = 14
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Black
        Panel3.Location = New Point(99, 217)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(219, 1)
        Panel3.TabIndex = 15
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOliveGreen
        ClientSize = New Size(410, 338)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(lblRegErrorMessage)
        Controls.Add(btnCancel)
        Controls.Add(btnRegister)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtNewPassword)
        Controls.Add(txtNewUsername)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "RegisterForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User Registration"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtNewUsername As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblRegErrorMessage As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class