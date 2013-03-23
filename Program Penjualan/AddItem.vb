Public Class AddItem

    Private Sub buttonReset_Click(sender As Object, e As EventArgs) Handles buttonReset.Click
        cmbBarcode.Text = ""
        txtCategory.Text = ""
        txtItemName.Text = ""
        txtPurchase.Text = ""
        txtQty.Text = ""
        txtSelling.Text = ""
        richTxtNotes.Text = ""
    End Sub

    Private Sub buttonNew_Click(sender As Object, e As EventArgs) Handles buttonNew.Click
        cmbBarcode.Text = ""
        txtCategory.Text = ""
        txtItemName.Text = ""
        txtPurchase.Text = ""
        txtQty.Text = ""
        txtSelling.Text = ""
        richTxtNotes.Text = ""
    End Sub

    Private Sub AddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.PenjualanDataSet.item)

    End Sub
End Class