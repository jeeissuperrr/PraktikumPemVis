<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Btambah = New Button()
        Breset = New Button()
        Tlayar1 = New TextBox()
        Tlayar2 = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(222, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 0
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(222, 257)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 1
        Label2.Text = "IP Kumulatif"
        ' 
        ' Btambah
        ' 
        Btambah.Location = New Point(357, 193)
        Btambah.Name = "Btambah"
        Btambah.Size = New Size(83, 29)
        Btambah.TabIndex = 2
        Btambah.Text = "Tambah"
        Btambah.UseVisualStyleBackColor = True
        ' 
        ' Breset
        ' 
        Breset.Location = New Point(446, 193)
        Breset.Name = "Breset"
        Breset.Size = New Size(101, 29)
        Breset.TabIndex = 3
        Breset.Text = "Reset"
        Breset.UseVisualStyleBackColor = True
        ' 
        ' Tlayar1
        ' 
        Tlayar1.Location = New Point(357, 142)
        Tlayar1.Name = "Tlayar1"
        Tlayar1.Size = New Size(190, 27)
        Tlayar1.TabIndex = 4
        ' 
        ' Tlayar2
        ' 
        Tlayar2.Location = New Point(357, 250)
        Tlayar2.Name = "Tlayar2"
        Tlayar2.Size = New Size(190, 27)
        Tlayar2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(222, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(362, 31)
        Label3.TabIndex = 6
        Label3.Text = "2309106037 Muhammad Jahron"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Tlayar2)
        Controls.Add(Tlayar1)
        Controls.Add(Breset)
        Controls.Add(Btambah)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "l"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btambah As Button
    Friend WithEvents Breset As Button
    Friend WithEvents Tlayar1 As TextBox
    Friend WithEvents Tlayar2 As TextBox
    Friend WithEvents Label3 As Label

End Class
