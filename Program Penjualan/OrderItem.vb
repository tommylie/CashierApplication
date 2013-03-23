Public Class OrderItem

    Private Sub OrderItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.distributor_list' table. You can move, or remove it, as needed.
        Me.Distributor_listTableAdapter.Fill(Me.PenjualanDataSet.distributor_list)

    End Sub
End Class