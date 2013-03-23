Public Class AddItem

    Private Sub buttonReset_Click(sender As Object, e As EventArgs) Handles buttonReset.Click
        txtBarcode.Text = ""
        txtCategory.Text = ""
        txtItemName.Text = ""
        txtPurchase.Text = ""
        txtQty.Text = ""
        txtSelling.Text = ""
        richTxtNotes.Text = ""
    End Sub

    Private Sub buttonNew_Click(sender As Object, e As EventArgs) Handles buttonNew.Click
        txtBarcode.Text = ""
        txtCategory.Text = ""
        txtItemName.Text = ""
        txtPurchase.Text = ""
        txtQty.Text = ""
        txtSelling.Text = ""
        richTxtNotes.Text = ""
    End Sub
End Class