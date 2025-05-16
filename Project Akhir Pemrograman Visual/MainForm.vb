Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class MainForm
    ' Fungsi untuk memuat data ke DataGridView
    Public Sub LoadData()
        Try
            OpenConnection()
            CMD = New MySqlCommand(
            "SELECT 
                tugas.id, 
                tugas.kategori_id,
                tugas.judul, 
                kategori.nama as nama_kategori, 
                tugas.deskripsi, 
                tugas.deadline,
                tugas.status
            FROM tugas 
            INNER JOIN kategori ON tugas.kategori_id = kategori.id
            WHERE tugas.user_id=@userid
            ORDER BY tugas.deadline ASC", CONN)
            CMD.Parameters.AddWithValue("@userid", GlobalUserID)
            DA = New MySqlDataAdapter(CMD)
            DT.Clear()
            DA.Fill(DT)
            DataGridView1.DataSource = DT
            DataGridView1.Columns("id").Visible = False
            DataGridView1.Columns("kategori_id").Visible = False

            DataGridView1.ClearSelection()
            DataGridView1.CurrentCell = Nothing
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub
    Public Sub LoadKategori()
        Try
            OpenConnection()
            CMD = New MySqlCommand("SELECT id, nama FROM kategori WHERE user_id=@userid", CONN)
            CMD.Parameters.AddWithValue("@userid", GlobalUserID)
            DA = New MySqlDataAdapter(CMD)
            Dim dtKategori As New DataTable
            DA.Fill(dtKategori)

            ' Bind the ComboBox
            KategoriCombo.DataSource = dtKategori
            KategoriCombo.DisplayMember = "nama"  ' Display the category name
            KategoriCombo.ValueMember = "id"      ' Store the category ID
            KategoriCombo.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Fungsi untuk membersihkan form
    Public Sub ClearForm()
        Judul.Clear()
        Deskripsi.Clear()
        Statuscombo.SelectedIndex = -1
        DateTimePicker1.Value = DateTime.Now
    End Sub

    Public Function CekValueTugas()
        If String.IsNullOrWhiteSpace(Judul.Text) Then
            MessageBox.Show("Judul tidak boleh kosong!")
            Judul.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(Deskripsi.Text) Then
            MessageBox.Show("Deskripsi tidak boleh kosong!")
            Deskripsi.Focus()
            Return False
        End If
        If KategoriCombo.SelectedIndex = -1 Then
            MessageBox.Show("Kategori tidak boleh kosong!")
            KategoriCombo.Focus()
            Return False
        End If
        If Statuscombo.SelectedIndex = -1 Then
            MessageBox.Show("Status tidak boleh kosong!")
            Statuscombo.Focus()
            Return False
        End If
        If DateTimePicker1.Value < DateTime.Now Then
            MessageBox.Show("Tanggal deadline tidak boleh kurang dari hari ini!")
            DateTimePicker1.Focus()
            Return False
        End If

        Return True
    End Function

    ' Fungsi untuk menambah tugas
    Private Sub Btambah_Click(sender As Object, e As EventArgs) Handles Btambah.Click
        If CekValueTugas() Then
            Try
                OpenConnection()
                CMD = New MySqlCommand(
                "INSERT INTO tugas (judul, user_id, kategori_id, deskripsi, deadline, status) 
                VALUES (@judul, @userid, @kategori_id, @deskripsi, @deadline, @status)", CONN)
                CMD.Parameters.AddWithValue("@judul", Judul.Text)
                CMD.Parameters.AddWithValue("@userid", GlobalUserID) ' Use the global user ID
                CMD.Parameters.AddWithValue("@kategori_id", KategoriCombo.SelectedValue) ' Get ID from ComboBox
                CMD.Parameters.AddWithValue("@deskripsi", Deskripsi.Text)
                CMD.Parameters.AddWithValue("@deadline", DateTimePicker1.Value.Date)
                CMD.Parameters.AddWithValue("@status", Statuscombo.SelectedItem.ToString())
                CMD.ExecuteNonQuery()
                MessageBox.Show("Tugas berhasil ditambahkan!")
                LoadData()
                ClearForm()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub

    ' Fungsi untuk mengedit tugas
    Private Sub Bedit_Click(sender As Object, e As EventArgs) Handles Bedit.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih tugas yang akan diedit terlebih dahulu!")
            Return
        End If

        If CekValueTugas() Then
            Try
                Dim taskId As Integer = CInt(DataGridView1.SelectedRows(0).Cells("id").Value)

                OpenConnection()
                CMD = New MySqlCommand(
                "UPDATE tugas 
                SET judul = @judul,
                    kategori_id = @kategori_id,
                    deskripsi = @deskripsi, 
                    deadline = @deadline, 
                    status = @status 
                WHERE id = @id", CONN)

                CMD.Parameters.AddWithValue("@id", taskId)
                CMD.Parameters.AddWithValue("@judul", Judul.Text)
                CMD.Parameters.AddWithValue("@kategori_id", KategoriCombo.SelectedValue)
                CMD.Parameters.AddWithValue("@deskripsi", Deskripsi.Text)
                CMD.Parameters.AddWithValue("@deadline", DateTimePicker1.Value.Date)
                CMD.Parameters.AddWithValue("@status", Statuscombo.SelectedItem.ToString())

                Dim rowsAffected As Integer = CMD.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Tugas berhasil diperbarui!")
                    LoadData()
                    ClearForm()
                Else
                    MessageBox.Show("Gagal memperbarui tugas")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub

    ' Fungsi untuk menghapus tugas
    Private Sub Bhapus_Click(sender As Object, e As EventArgs) Handles Bhapus.Click
        Try
            If DataGridView1.SelectedRows.Count = 0 Then
                MessageBox.Show("Pilih tugas yang akan dihapus terlebih dahulu!")
                Return
            End If

            Dim confirm = MessageBox.Show("Yakin ingin menghapus tugas ini?",
                                        "Konfirmasi Hapus",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning)

            If confirm = DialogResult.Yes Then
                Dim taskId As Integer = CInt(DataGridView1.SelectedRows(0).Cells("id").Value)

                OpenConnection()
                CMD = New MySqlCommand("DELETE FROM tugas WHERE id = @id", CONN)
                CMD.Parameters.AddWithValue("@id", taskId)

                Dim rowsAffected As Integer = CMD.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Tugas berhasil dihapus!")
                    LoadData()
                Else
                    MessageBox.Show("Gagal menghapus tugas")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Fungsi untuk mencari tugas berdasarkan judul
    Private Sub Bcari_Click(sender As Object, e As EventArgs) Handles Bcari.Click
        Try
            OpenConnection()
            CMD = New MySqlCommand(
            "SELECT 
            tugas.id, 
            tugas.kategori_id, 
            tugas.judul, 
            kategori.nama as nama_kategori, 
            tugas.deskripsi, 
            tugas.deadline,
            tugas.status
            FROM tugas 
            INNER JOIN kategori ON tugas.kategori_id = kategori.id
            WHERE tugas.judul LIKE CONCAT('%', @cari, '%') AND tugas.user_id = @userid
            ORDER BY tugas.deadline ASC", CONN)
            CMD.Parameters.AddWithValue("@userid", GlobalUserID) ' Use the global user ID
            CMD.Parameters.AddWithValue("@cari", Tcari.Text)
            DA = New MySqlDataAdapter(CMD)
            DT.Clear()
            DA.Fill(DT)
            DataGridView1.DataSource = DT
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Fungsi untuk memuat data saat aplikasi dimuat
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        Statuscombo.Items.Add("Belum")
        Statuscombo.Items.Add("Selesai")
        Statuscombo.Items.Add("Dalam Proses")
        DateTimePicker1.MinDate = DateTime.Now
        DateTimePicker1.MaxDate = DateTime.Now.AddYears(5)
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        LoadData()
        LoadKategori()
    End Sub

    ' Fungsi untuk mengisi DataGridView saat sel baris di klik
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso Not DataGridView1.Rows(e.RowIndex).IsNewRow Then
            ' Explicitly select the row
            DataGridView1.Rows(e.RowIndex).Selected = True

            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Populate fields
            Judul.Text = selectedRow.Cells("judul").Value.ToString()
            Deskripsi.Text = selectedRow.Cells("deskripsi").Value.ToString()
            DateTimePicker1.Value = DateTime.Parse(selectedRow.Cells("deadline").Value.ToString())
            Statuscombo.SelectedItem = selectedRow.Cells("status").Value.ToString()
            KategoriCombo.SelectedValue = selectedRow.Cells("kategori_id").Value
        End If
    End Sub

    ' Add these methods to your existing MainForm class
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Try
            ' Create sorted view by deadline
            sortedData = New DataView(DT)
            sortedData.Sort = "deadline ASC"

            ' Configure print document
            printDocument = New Printing.PrintDocument()
            AddHandler printDocument.PrintPage, AddressOf PrintDocument_PrintPage
            printDocument.DefaultPageSettings.Margins = New Margins(50, 50, 50, 50)

            ' Show preview
            printPreviewDialog.Document = printDocument
            printPreviewDialog.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Print Error: " & ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim fontHeader As New Font("Arial", 16, FontStyle.Bold)
        Dim fontTitle As New Font("Arial", 12, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 11)
        Dim brush As New SolidBrush(Color.Black)
        Dim yPos As Single = e.MarginBounds.Top
        Dim xPos As Single = e.MarginBounds.Left + 20 ' Increased left margin
        Dim maxWidth As Single = e.MarginBounds.Width - 40

        ' Print header
        e.Graphics.DrawString("TO-DO LIST REPORT", fontHeader, brush, xPos, yPos)
        yPos += fontHeader.GetHeight(e.Graphics) * 1.5
        e.Graphics.DrawString($"Printed: {DateTime.Now.ToString("dd MMMM yyyy HH:mm")}", fontBody, brush, xPos, yPos)
        yPos += fontBody.GetHeight(e.Graphics) * 2

        ' Calculate available height
        Dim pageHeight As Single = e.MarginBounds.Height - yPos

        While currentRowIndex < sortedData.Count
            Dim row As DataRowView = sortedData(currentRowIndex)

            ' Start task section
            e.Graphics.DrawString("Judul: ", fontTitle, brush, xPos, yPos)
            yPos += fontTitle.GetHeight(e.Graphics)
            e.Graphics.DrawString(row("judul").ToString(), fontBody, brush, xPos, yPos)
            yPos += fontBody.GetHeight(e.Graphics) * 1.5

            ' Kategori
            e.Graphics.DrawString("Kategori: ", fontTitle, brush, xPos, yPos)
            yPos += fontTitle.GetHeight(e.Graphics)
            e.Graphics.DrawString(row("nama_kategori").ToString(), fontBody, brush, xPos, yPos)
            yPos += fontBody.GetHeight(e.Graphics) * 1.5

            ' Deskripsi with text wrapping
            e.Graphics.DrawString("Deskripsi: ", fontTitle, brush, xPos, yPos)
            yPos += fontTitle.GetHeight(e.Graphics)
            Dim description As String = row("deskripsi").ToString()
            Dim descriptionRect As New RectangleF(xPos, yPos, maxWidth, pageHeight - yPos)
            yPos += DrawWrappedText(e.Graphics, description, fontBody, brush, descriptionRect)
            yPos += fontBody.GetHeight(e.Graphics) * 1.5

            ' Deadline
            e.Graphics.DrawString("Deadline: ", fontTitle, brush, xPos, yPos)
            yPos += fontTitle.GetHeight(e.Graphics)
            Dim deadline As DateTime = DateTime.Parse(row("deadline").ToString())
            e.Graphics.DrawString(deadline.ToString("dd MMMM yyyy"), fontBody, brush, xPos, yPos)
            yPos += fontBody.GetHeight(e.Graphics) * 1.5

            ' Status
            e.Graphics.DrawString("Status: ", fontTitle, brush, xPos, yPos)
            yPos += fontTitle.GetHeight(e.Graphics)
            e.Graphics.DrawString(row("status").ToString(), New Font(fontBody, FontStyle.Bold), brush, xPos, yPos)
            yPos += fontBody.GetHeight(e.Graphics) * 2

            ' Separator line
            e.Graphics.DrawLine(Pens.Gray, xPos, yPos, xPos + maxWidth, yPos)
            yPos += 10

            ' Check page bounds
            If yPos > pageHeight Then
                e.HasMorePages = True
                currentRowIndex += 1
                Return
            End If

            currentRowIndex += 1
        End While

        e.HasMorePages = False
        currentRowIndex = 0
    End Sub

    Private Function DrawWrappedText(g As Graphics, text As String, font As Font, brush As Brush, layoutArea As RectangleF) As Single
        Dim format As New StringFormat()
        format.Trimming = StringTrimming.Word
        format.FormatFlags = StringFormatFlags.LineLimit

        Dim characterFitted As Integer
        Dim linesFilled As Integer
        Dim measuredSize = g.MeasureString(text, font, layoutArea.Size, format, characterFitted, linesFilled)

        ' Draw the text
        g.DrawString(text.Substring(0, characterFitted), font, brush, layoutArea, format)

        Return measuredSize.Height
    End Function

    Private Sub Bclear_Click(sender As Object, e As EventArgs) Handles Bclear.Click
        ClearForm()
    End Sub
    Private Sub BKategori_Click(sender As Object, e As EventArgs) Handles BKategori.Click
        Dim kategoriForm As New Kategori()
        kategoriForm.ShowDialog()
        LoadKategori()
        LoadData()
    End Sub
    Private Sub OnClose(sender As Object, e As EventArgs) Handles MyBase.Closed
        MenuForm.Show()
    End Sub
End Class
