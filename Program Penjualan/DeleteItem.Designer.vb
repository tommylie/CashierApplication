﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteItem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.buttonRemove = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSelling = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPurchase = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBarcode = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'buttonRemove
        '
        Me.buttonRemove.Location = New System.Drawing.Point(112, 293)
        Me.buttonRemove.Name = "buttonRemove"
        Me.buttonRemove.Size = New System.Drawing.Size(75, 23)
        Me.buttonRemove.TabIndex = 33
        Me.buttonRemove.Text = "Remove"
        Me.buttonRemove.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(17, 212)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(255, 75)
        Me.RichTextBox1.TabIndex = 32
        Me.RichTextBox1.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Notes"
        '
        'txtSelling
        '
        Me.txtSelling.Location = New System.Drawing.Point(119, 166)
        Me.txtSelling.Name = "txtSelling"
        Me.txtSelling.ReadOnly = True
        Me.txtSelling.Size = New System.Drawing.Size(153, 20)
        Me.txtSelling.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Selling Price"
        '
        'txtPurchase
        '
        Me.txtPurchase.Location = New System.Drawing.Point(119, 140)
        Me.txtPurchase.Name = "txtPurchase"
        Me.txtPurchase.ReadOnly = True
        Me.txtPurchase.Size = New System.Drawing.Size(153, 20)
        Me.txtPurchase.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Purchase Price"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(119, 115)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.ReadOnly = True
        Me.txtQty.Size = New System.Drawing.Size(153, 20)
        Me.txtQty.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Quantity"
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(119, 90)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(153, 20)
        Me.txtCategory.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Category"
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(119, 65)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.ReadOnly = True
        Me.txtItemName.Size = New System.Drawing.Size(153, 20)
        Me.txtItemName.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Item Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Barcode Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Delete Item"
        '
        'cmbBarcode
        '
        Me.cmbBarcode.FormattingEnabled = True
        Me.cmbBarcode.Location = New System.Drawing.Point(119, 40)
        Me.cmbBarcode.Name = "cmbBarcode"
        Me.cmbBarcode.Size = New System.Drawing.Size(153, 21)
        Me.cmbBarcode.TabIndex = 34
        Me.cmbBarcode.ValueMember = "Barcode"
        '
        'DeleteItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 344)
        Me.Controls.Add(Me.cmbBarcode)
        Me.Controls.Add(Me.buttonRemove)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSelling)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPurchase)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DeleteItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonRemove As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSelling As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPurchase As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbBarcode As System.Windows.Forms.ComboBox
End Class