Public Class frmInventorySystemMain

    Private Sub InventoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryToolStripMenuItem.Click
        frmInventory.ShowDialog()
    End Sub

    Private Sub AddEmployeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEmployeesToolStripMenuItem.Click
        frmAddItemsInventory.btnAdd.Text = "Add Item"
        frmAddItemsInventory.ShowDialog()
    End Sub

    Private Sub frmInventorySystemMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub AdjustInventoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdjustInventoryToolStripMenuItem.Click

    End Sub

    Private Sub WidthrawItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WidthrawItemsToolStripMenuItem.Click
        frmItemsIssuance.ShowDialog()
    End Sub

    Private Sub PendingRequisitionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendingRequisitionToolStripMenuItem.Click
        TransactionViewer.MODE = "GET_REQUISITION"
        TransactionViewer.ShowDialog()
    End Sub
End Class