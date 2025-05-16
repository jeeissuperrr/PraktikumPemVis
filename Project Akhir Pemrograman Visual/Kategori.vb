Imports MySql.Data.MySqlClient

Public Class Kategori
    ' Key Fix 1: Add proper row selection checks
    ' Key Fix 2: Add confirmation dialogs
    ' Key Fix 3: Improve error handling

    Public Sub LoadKategori()
        Try
            OpenConnection()
            CMD = New MySqlCommand("SELECT id, nama FROM kategori WHERE user_id = @userid", CONN)
            CMD.Parameters.AddWithValue("@userid", GlobalUserID)
            DA = New MySqlDataAdapter(CMD)
            Dim dtKategori As New DataTable
            DA.Fill(dtKategori)
            DataGridView1.DataSource = dtKategori
            ' Key Fix 4: Check if columns exist before hiding
            If DataGridView1.Columns.Contains("id") Then
                DataGridView1.Columns("id").Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Nama kategori tidak boleh kosong!")
            Return
        End If

        Try
            OpenConnection()
            CMD = New MySqlCommand("INSERT INTO kategori (nama, user_id) VALUES (@nama, @userid)", CONN)
            CMD.Parameters.AddWithValue("@userid", GlobalUserID)
            CMD.Parameters.AddWithValue("@nama", TextBox1.Text)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Kategori berhasil ditambahkan!")
            LoadKategori()
            TextBox1.Clear()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub Kategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKategori()
        ' Key Fix 5: Set selection mode
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Key Fix 6: Handle header clicks
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("nama").Value.ToString()
        End If
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        ' Key Fix 7: Add row selection check
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih kategori yang akan diedit terlebih dahulu!")
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Nama kategori tidak boleh kosong!")
            Return
        End If

        Try
            OpenConnection()
            CMD = New MySqlCommand("UPDATE kategori SET nama = @nama WHERE id = @id AND user_id = @userid", CONN)
            CMD.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells("id").Value)
            CMD.Parameters.AddWithValue("@nama", TextBox1.Text)
            CMD.Parameters.AddWithValue("@userid", GlobalUserID)

            Dim rowsAffected As Integer = CMD.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Kategori berhasil diubah!")
                LoadKategori()
                TextBox1.Clear()
            Else
                MessageBox.Show("Gagal mengubah kategori")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        ' Key Fix 8: Add proper deletion checks
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih kategori yang akan dihapus terlebih dahulu!")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus kategori ini?",
                                                    "Konfirmasi Hapus",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                OpenConnection()
                CMD = New MySqlCommand("DELETE FROM kategori WHERE id = @id AND user_id = @userid", CONN)
                CMD.Parameters.AddWithValue("@id", DataGridView1.SelectedRows(0).Cells("id").Value)
                CMD.Parameters.AddWithValue("@userid", GlobalUserID)

                Dim rowsAffected As Integer = CMD.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Kategori berhasil dihapus!")
                    LoadKategori()
                    TextBox1.Clear()
                Else
                    MessageBox.Show("Gagal menghapus kategori")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                CloseConnection()
            End Try
        End If
    End Sub

    Private Sub Kembali_Click(sender As Object, e As EventArgs) Handles Kembali.Click
        Me.Close()
        ' Key Fix 9: Refresh main form properly
        MainForm.LoadData()
        MainForm.LoadKategori()
        MainForm.Show()
    End Sub
End Class