Imports System.Data.OleDb

Public Class UserAdd

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles buttonReset.Click
        txtAddr.Text = ""
        txtName.Text = ""
        txtPassword.Text = ""
        txtPhone.Text = ""
        txtUsername.Text = ""
        cmbPosition.Text = ""
    End Sub

End Class
