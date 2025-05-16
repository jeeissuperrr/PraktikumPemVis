Imports MySql.Data.MySqlClient
Public Class RegisterForm
    Sub RegisterUser()
        Try
            OpenConnection()
            Using cmd As New MySqlCommand(
                "INSERT INTO users (username, password) 
                VALUES (@user, @pass)", CONN)

                Dim hashedPassword = Sha256Encryption(txtNewPassword.Text)

                cmd.Parameters.AddWithValue("@user", txtNewUsername.Text)
                cmd.Parameters.AddWithValue("@pass", hashedPassword)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registration successful!")
                Me.Close()
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Username already exists!")
            Else
                MessageBox.Show(ex.Message)
            End If
        Finally
            CONN.Close()
        End Try
    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNewUsername.Text = ""
        txtNewPassword.Text = ""
        txtConfirmPassword.Text = ""
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            If txtNewUsername.Text = "" Then
                Throw New Exception("Username tidak boleh kosong")
            ElseIf txtNewPassword.Text = "" Then
                Throw New Exception("Password tidak boleh kosong")
            ElseIf txtNewPassword.Text <> txtConfirmPassword.Text Then
                Throw New Exception("Password tidak sama")
            Else
                RegisterUser()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class