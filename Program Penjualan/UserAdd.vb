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

    Private Sub UserAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.account_position' table. You can move, or remove it, as needed.
        Me.Account_positionTableAdapter.Fill(Me.PenjualanDataSet.account_position)
        'TODO: This line of code loads data into the 'PenjualanDataSet.account_position' table. You can move, or remove it, as needed.
        Me.Account_positionTableAdapter.Fill(Me.PenjualanDataSet.account_position)

    End Sub
End Class
