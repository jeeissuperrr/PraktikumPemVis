Public Class MenuForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim loginForm As New LoginForm()
        If loginForm.ShowDialog() = DialogResult.OK Then
            Me.Hide()
            Dim Program As New MainForm()
            Program.Show()
        End If
    End Sub
    Private Sub btnRegister_Click() Handles btnRegister.Click
        Dim regForm As New RegisterForm()
        If regForm.ShowDialog() = DialogResult.OK Then
            Me.Hide()
            Dim Program As New MainForm()
            Program.Show()
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub OnClose(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class