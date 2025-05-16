<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnCancel = New Button()
        lblErrorMessage = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.DarkOliveGreen
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 13F)
        txtUsername.ForeColor = Color.White
        txtUsername.Location = New Point(131, 118)
        txtUsername.Margin = New Padding(4, 3, 4, 3)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(167, 24)
        txtUsername.TabIndex = 0
        txtUsername.Text = "Username"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.DarkOliveGreen
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 13F)
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(131, 171)
        txtPassword.Margin = New Padding(4, 3, 4, 3)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(167, 24)
        txtPassword.TabIndex = 1
        txtPassword.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.InactiveCaptionText
        btnLogin.FlatAppearance.BorderColor = Color.Black
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(107, 249)
        btnLogin.Margin = New Padding(4, 3, 4, 3)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(105, 35)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Black
        btnCancel.FlatAppearance.BorderColor = Color.Black
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(220, 249)
        btnCancel.Margin = New Padding(4, 3, 4, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(105, 35)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' lblErrorMessage
        ' 
        lblErrorMessage.ForeColor = Color.Red
        lblErrorMessage.Location = New Point(71, 7)
        lblErrorMessage.Margin = New Padding(4, 0, 4, 0)
        lblErrorMessage.Name = "lblErrorMessage"
        lblErrorMessage.Size = New Size(303, 23)
        lblErrorMessage.TabIndex = 6
        lblErrorMessage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(180, 32)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(65, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(93, 118)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(31, 26)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(93, 171)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(31, 26)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Location = New Point(93, 146)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(234, 1)
        Panel1.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(94, 199)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(234, 1)
        Panel2.TabIndex = 11
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOliveGreen
        ClientSize = New Size(415, 370)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(lblErrorMessage)
        Controls.Add(btnCancel)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblErrorMessage As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class