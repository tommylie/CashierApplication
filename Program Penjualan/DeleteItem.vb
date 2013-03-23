Imports System.Data.SqlClient

Public Class DeleteItem

    Private Sub DeleteItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.PenjualanDataSet.item)

    End Sub
End Class