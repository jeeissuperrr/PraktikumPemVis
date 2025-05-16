<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kategori
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
        Label1 = New Label()
        Tambah = New Button()
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        Edit = New Button()
        Hapus = New Button()
        Kembali = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 13.8F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(44, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 24)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Tambah
        ' 
        Tambah.BackColor = Color.Black
        Tambah.Font = New Font("Microsoft Sans Serif", 9F)
        Tambah.ForeColor = Color.White
        Tambah.Location = New Point(12, 94)
        Tambah.Name = "Tambah"
        Tambah.Size = New Size(81, 36)
        Tambah.TabIndex = 1
        Tambah.Text = "Tambah"
        Tambah.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 136)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(421, 150)
        DataGridView1.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(128, 32)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(197, 23)
        TextBox1.TabIndex = 3
        ' 
        ' Edit
        ' 
        Edit.BackColor = Color.Black
        Edit.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Edit.ForeColor = Color.White
        Edit.Location = New Point(99, 94)
        Edit.Name = "Edit"
        Edit.Size = New Size(81, 36)
        Edit.TabIndex = 4
        Edit.Text = "Edit"
        Edit.UseVisualStyleBackColor = False
        ' 
        ' Hapus
        ' 
        Hapus.BackColor = Color.Black
        Hapus.Font = New Font("Microsoft Sans Serif", 9F)
        Hapus.ForeColor = Color.White
        Hapus.Location = New Point(186, 94)
        Hapus.Name = "Hapus"
        Hapus.Size = New Size(81, 36)
        Hapus.TabIndex = 5
        Hapus.Text = "Hapus"
        Hapus.UseVisualStyleBackColor = False
        ' 
        ' Kembali
        ' 
        Kembali.BackColor = Color.Black
        Kembali.Font = New Font("Microsoft Sans Serif", 9F)
        Kembali.ForeColor = Color.White
        Kembali.Location = New Point(329, 94)
        Kembali.Name = "Kembali"
        Kembali.Size = New Size(81, 36)
        Kembali.TabIndex = 6
        Kembali.Text = "Kembali"
        Kembali.UseVisualStyleBackColor = False
        ' 
        ' Kategori
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkOliveGreen
        ClientSize = New Size(422, 288)
        Controls.Add(Kembali)
        Controls.Add(Hapus)
        Controls.Add(Edit)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Tambah)
        Controls.Add(Label1)
        Name = "Kategori"
        Text = "Kategori"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Tambah As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Edit As Button
    Friend WithEvents Hapus As Button
    Friend WithEvents Kembali As Button
End Class
