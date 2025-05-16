Imports MySql.Data.MySqlClient

Module Connections
    Public CONN As New MySqlConnection("Server=localhost;Port=3307;Database=db_todolist;Uid=root;Pwd=;")
    Public CMD As New MySqlCommand
    Public DA As New MySqlDataAdapter
    Public DT As New DataTable

    ' Fungsi untuk membuka koneksi ke database
    Public Sub OpenConnection()
        Try
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Fungsi untuk menutup koneksi
    Public Sub CloseConnection()
        If CONN.State = ConnectionState.Open Then
            CONN.Close()
        End If
    End Sub

    Public GlobalUserID As Integer
End Module
