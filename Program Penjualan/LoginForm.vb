Public Class LoginForm

    Private Sub buttonReset_Click(sender As Object, e As EventArgs) Handles buttonReset.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        If (Login.doLogin(txtUsername.Text(), txtPassword.Text())) Then
            MainForm.Show()
            Me.Hide()
        End If
    End Sub
End Class
