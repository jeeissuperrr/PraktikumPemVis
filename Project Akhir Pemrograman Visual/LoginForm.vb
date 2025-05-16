Imports MySql.Data.MySqlClient

Public Class LoginForm
    Function AuthenticateUser() As Boolean
        Try
            OpenConnection()
            Using cmd As New MySqlCommand(
                "SELECT id_user, password FROM users 
                WHERE username = @user", CONN)

                cmd.Parameters.AddWithValue("@user", txtUsername.Text)
                Using rd = cmd.ExecuteReader()
                    If rd.Read() Then
                        Dim storedHash = rd("password").ToString()
                        Dim inputHash = Sha256Encryption(txtPassword.Text)

                        If inputHash = storedHash Then
                            GlobalUserID = rd("id_user")
                            Return True
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CONN.Close()
        End Try
        Return False
    End Function

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Username atau Password tidak boleh kosong")
        Else
            If AuthenticateUser() Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                lblErrorMessage.Text = "Username atau Password salah"
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class