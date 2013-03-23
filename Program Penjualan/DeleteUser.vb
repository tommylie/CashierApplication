Public Class DeleteUser

    Private Sub DeleteUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.account' table. You can move, or remove it, as needed.
        Me.AccountTableAdapter.Fill(Me.PenjualanDataSet.account)

    End Sub
End Class