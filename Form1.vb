

Public Class Form1
    Private Sub AddProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProductsToolStripMenuItem.Click
        Dim frm = Add_Product
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub UpdateProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateProductsToolStripMenuItem.Click
        Dim frm = update_product
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub ExitToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem2.Click
        Dim frm = Barcode
        frm.Show()
        frm.MdiParent = Me
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim frm = Backup
        frm.Show()
        frm.MdiParent = Me

    End Sub
End Class
