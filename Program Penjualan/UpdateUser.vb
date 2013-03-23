Public Class UpdateUser

    Private Sub UpdateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.account_position' table. You can move, or remove it, as needed.
        Me.Account_positionTableAdapter.Fill(Me.PenjualanDataSet.account_position)

    End Sub
End Class