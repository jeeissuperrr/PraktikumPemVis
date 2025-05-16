<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    ' Add these at the top of your MainForm class (under "Public Class MainForm")
    Private printDocument As New Printing.PrintDocument()
    Private printPreviewDialog As New PrintPreviewDialog()
    Private currentRowIndex As Integer = 0
    Private rowsPerPage As Integer = 0
    Private sortedData As DataView

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
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Judul = New TextBox()
        Deskripsi = New RichTextBox()
        Statuscombo = New ComboBox()
        Tcari = New TextBox()
        DataGridView1 = New DataGridView()
        Btambah = New Button()
        Bedit = New Button()
        Bhapus = New Button()
        Bclear = New Button()
        Bcari = New Button()
        DateTimePicker1 = New DateTimePicker()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        KategoriCombo = New ComboBox()
        Label7 = New Label()
        BKategori = New Button()
        PrintButton = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(102, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 15)
        Label1.TabIndex = 0
        Label1.Text = "Judul"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(102, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 1
        Label2.Text = "Deskripsi"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(664, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 15)
        Label3.TabIndex = 2
        Label3.Text = "Status"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(664, 103)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 15)
        Label4.TabIndex = 3
        Label4.Text = "Deadline"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(102, 308)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 15)
        Label5.TabIndex = 4
        Label5.Text = "Cari Tugas"
        ' 
        ' Judul
        ' 
        Judul.Location = New Point(251, 92)
        Judul.Margin = New Padding(3, 2, 3, 2)
        Judul.Name = "Judul"
        Judul.Size = New Size(218, 23)
        Judul.TabIndex = 1
        ' 
        ' Deskripsi
        ' 
        Deskripsi.Location = New Point(251, 152)
        Deskripsi.Margin = New Padding(3, 2, 3, 2)
        Deskripsi.Name = "Deskripsi"
        Deskripsi.Size = New Size(218, 103)
        Deskripsi.TabIndex = 2
        Deskripsi.Text = ""
        ' 
        ' Statuscombo
        ' 
        Statuscombo.FormattingEnabled = True
        Statuscombo.Location = New Point(757, 182)
        Statuscombo.Margin = New Padding(3, 2, 3, 2)
        Statuscombo.Name = "Statuscombo"
        Statuscombo.Size = New Size(219, 23)
        Statuscombo.TabIndex = 4
        ' 
        ' Tcari
        ' 
        Tcari.Location = New Point(251, 308)
        Tcari.Margin = New Padding(3, 2, 3, 2)
        Tcari.Name = "Tcari"
        Tcari.Size = New Size(725, 23)
        Tcari.TabIndex = 10
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(102, 359)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(873, 155)
        DataGridView1.TabIndex = 10
        ' 
        ' Btambah
        ' 
        Btambah.Location = New Point(502, 97)
        Btambah.Margin = New Padding(3, 2, 3, 2)
        Btambah.Name = "Btambah"
        Btambah.Size = New Size(82, 22)
        Btambah.TabIndex = 6
        Btambah.Text = "Tambah"
        Btambah.UseVisualStyleBackColor = True
        ' 
        ' Bedit
        ' 
        Bedit.Location = New Point(502, 123)
        Bedit.Margin = New Padding(3, 2, 3, 2)
        Bedit.Name = "Bedit"
        Bedit.Size = New Size(82, 22)
        Bedit.TabIndex = 7
        Bedit.Text = "Edit"
        Bedit.UseVisualStyleBackColor = True
        ' 
        ' Bhapus
        ' 
        Bhapus.Location = New Point(502, 151)
        Bhapus.Margin = New Padding(3, 2, 3, 2)
        Bhapus.Name = "Bhapus"
        Bhapus.Size = New Size(82, 22)
        Bhapus.TabIndex = 8
        Bhapus.Text = "Hapus"
        Bhapus.UseVisualStyleBackColor = True
        ' 
        ' Bclear
        ' 
        Bclear.Location = New Point(502, 177)
        Bclear.Margin = New Padding(3, 2, 3, 2)
        Bclear.Name = "Bclear"
        Bclear.Size = New Size(82, 22)
        Bclear.TabIndex = 9
        Bclear.Text = "Clear"
        Bclear.UseVisualStyleBackColor = True
        ' 
        ' Bcari
        ' 
        Bcari.Location = New Point(251, 333)
        Bcari.Margin = New Padding(3, 2, 3, 2)
        Bcari.Name = "Bcari"
        Bcari.Size = New Size(82, 22)
        Bcari.TabIndex = 11
        Bcari.Text = "Cari"
        Bcari.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(757, 97)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(219, 23)
        DateTimePicker1.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.bg_pemvis
        PictureBox1.Location = New Point(4, 0)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1067, 514)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Times New Roman", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(251, 7)
        Label6.Name = "Label6"
        Label6.Size = New Size(547, 55)
        Label6.TabIndex = 18
        Label6.Text = "APLIKASI TO DO-LIST"
        ' 
        ' KategoriCombo
        ' 
        KategoriCombo.FormattingEnabled = True
        KategoriCombo.Location = New Point(757, 232)
        KategoriCombo.Margin = New Padding(3, 2, 3, 2)
        KategoriCombo.Name = "KategoriCombo"
        KategoriCombo.Size = New Size(219, 23)
        KategoriCombo.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(664, 235)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 15)
        Label7.TabIndex = 20
        Label7.Text = "Kategori"
        ' 
        ' BKategori
        ' 
        BKategori.Location = New Point(893, 271)
        BKategori.Margin = New Padding(3, 2, 3, 2)
        BKategori.Name = "BKategori"
        BKategori.Size = New Size(82, 33)
        BKategori.TabIndex = 9
        BKategori.Text = "Kategori"
        BKategori.UseVisualStyleBackColor = True
        ' 
        ' PrintButton
        ' 
        PrintButton.Location = New Point(502, 203)
        PrintButton.Margin = New Padding(3, 2, 3, 2)
        PrintButton.Name = "PrintButton"
        PrintButton.Size = New Size(82, 22)
        PrintButton.TabIndex = 21
        PrintButton.Text = "Print"
        PrintButton.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1073, 524)
        Controls.Add(PrintButton)
        Controls.Add(BKategori)
        Controls.Add(Label7)
        Controls.Add(KategoriCombo)
        Controls.Add(Label6)
        Controls.Add(DateTimePicker1)
        Controls.Add(Bcari)
        Controls.Add(Bclear)
        Controls.Add(Bhapus)
        Controls.Add(Bedit)
        Controls.Add(Btambah)
        Controls.Add(DataGridView1)
        Controls.Add(Tcari)
        Controls.Add(Statuscombo)
        Controls.Add(Deskripsi)
        Controls.Add(Judul)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "MainForm"
        Text = "To-Do List"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Judul As TextBox
    Friend WithEvents Deskripsi As RichTextBox
    Friend WithEvents Statuscombo As ComboBox
    Friend WithEvents Tcari As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btambah As Button
    Friend WithEvents Bedit As Button
    Friend WithEvents Bhapus As Button
    Friend WithEvents Bclear As Button
    Friend WithEvents Bcari As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents KategoriCombo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BKategori As Button
    Friend WithEvents PrintButton As Button

End Class
