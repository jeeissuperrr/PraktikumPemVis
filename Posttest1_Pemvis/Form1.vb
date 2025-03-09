Public Class Form1
    ' Variabel untuk menyimpan total IP dan jumlah semester
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub Btambah_Click(sender As Object, e As EventArgs) Handles Btambah.Click
        Dim ipSemester As Double

        ' Coba ubah teks di Tlayar1 jadi angka
        If Double.TryParse(Tlayar1.Text, ipSemester) Then
            ' Pastikan IP Semester dalam rentang yang benar
            If ipSemester >= 0 AndAlso ipSemester <= 4 Then
                ' Tambahkan ke total dan hitung IPK rata-rata
                totalIP += ipSemester
                jumlahSemester += 1
                Dim ipKumulatif As Double = totalIP / jumlahSemester

                ' Tampilkan hasil dengan predikat
                Tlayar2.Text = ipKumulatif.ToString("0.00") & " - " & PredikatIPK(ipKumulatif)

                ' Bersihkan input untuk masukkan berikutnya
                Tlayar1.Clear()
            Else
                MessageBox.Show("Masukkan IP Semester antara 0.00 sampai 4.00 ya!", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Masukkan angka yang benar untuk IP Semester!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Breset_Click(sender As Object, e As EventArgs) Handles Breset.Click
        ' Hapus semua data biar mulai dari awal
        totalIP = 0
        jumlahSemester = 0
        Tlayar1.Clear()
        Tlayar2.Clear()
    End Sub

    Private Function PredikatIPK(ipk As Double) As String
        ' Cek predikat berdasarkan nilai IPK
        If ipk >= 3.01 Then
            Return "Sangat Memuaskan"
        ElseIf ipk >= 2.76 Then
            Return "Memuaskan"
        ElseIf ipk >= 2.0 Then
            Return "Cukup"
        Else
            Return "Kurang"
        End If
    End Function
End Class
