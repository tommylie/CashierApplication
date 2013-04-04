Public Class OrderItem

    Private Sub OrderItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.PenjualanDataSet.item)
        'TODO: This line of code loads data into the 'PenjualanDataSet.item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.PenjualanDataSet.item)
        'TODO: This line of code loads data into the 'PenjualanDataSet.distributor_list' table. You can move, or remove it, as needed.
        Me.Distributor_listTableAdapter.Fill(Me.PenjualanDataSet.distributor_list)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ItemTableAdapter.FillBy(Me.PenjualanDataSet.item)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class