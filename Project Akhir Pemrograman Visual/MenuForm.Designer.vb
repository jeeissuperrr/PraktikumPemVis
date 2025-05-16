<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuForm
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
        btnLogin = New Button()
        btnRegister = New Button()
        btnExit = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Black
        btnLogin.Font = New Font("Microsoft Sans Serif", 12F)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(58, 69)
        btnLogin.Margin = New Padding(4, 3, 4, 3)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(233, 46)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Black
        btnRegister.Font = New Font("Microsoft Sans Serif", 12F)
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(58, 127)
        btnRegister.Margin = New Padding(4, 3, 4, 3)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(233, 46)
        btnRegister.TabIndex = 1
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Black
        btnExit.Font = New Font("Microsoft Sans Serif", 12F)
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(58, 185)
        btnExit.Margin = New Padding(4, 3, 4, 3)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(233, 46)
        btnExit.TabIndex = 2
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(97, 23)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 24)
        Label1.TabIndex = 3
        Label1.Text = "Authentication"
        ' 
        ' MenuForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOliveGreen
        ClientSize = New Size(350, 254)
        Controls.Add(Label1)
        Controls.Add(btnExit)
        Controls.Add(btnRegister)
        Controls.Add(btnLogin)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "MenuForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Menu"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
End Class