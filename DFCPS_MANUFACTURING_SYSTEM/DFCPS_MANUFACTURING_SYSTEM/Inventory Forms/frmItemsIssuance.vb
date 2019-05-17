Public Class frmItemsIssuance
    Dim totalCost As Decimal
    Sub generateIssuanceNo()
        Dim strID As String
        Try
            If conn.State = ConnectionState.Open Then
                OleDBC.Dispose()
                conn.Close()
            End If
            If conn.State <> ConnectionState.Open Then
                ConnectDatabase()
            End If
            With OleDBC
                .Connection = conn
                .CommandText = "SELECT widthrawalNo from tblItemWidthrawal order by widthrawalNo DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                strID = OleDBDR.Item(0).Substring(OleDBDR.Item(0).Length - 5)
                txtIssuanceNo.Text = "IN-" & Format(Val(strID) + 1, "00000")
            Else
                txtIssuanceNo.Text = "IN-" & "00001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
    Sub save()
        Dim inventoryClass As New inventory_class
        inventoryClass.refNo = txtIssuanceNo.Text
        inventoryClass.IssuanceNo = txtIssuanceNo.Text
        inventoryClass.IssuanceDate = Format(Now, "MM/dd/yyyy")
        inventoryClass.totalItemCount = dgv.Rows.Count
        inventoryClass.totalCost = totalCost
        inventoryClass.chargeToAccount = txtAccount.Text
        inventoryClass.memo = txtRemarks.Text
        inventoryClass.insert_itemWidthrawal()
        Dim row1 As Integer
        Dim col As Integer
        col = 0
        row1 = dgv.RowCount
        While col < row1
            inventoryClass.itemNo = dgv.Item(0, col).Value
            inventoryClass.unitCost = dgv.Item(4, col).Value
            inventoryClass.qty = -+dgv.Item(3, col).Value
            inventoryClass.insert_invItem_transaction()

            inventoryClass.accAsset = dgv.Item(5, col).Value
            inventoryClass.debit = inventoryClass.unitCost
            inventoryClass.credit = "0"
            inventoryClass.insert_Acc_entry_class()
        End While
    End Sub

    Private Sub frmWidthrawItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        generateIssuanceNo()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtQty.Text = "" Then
            txtQty.Text = "1"
        End If
        InventoryList.mode = "Issuance"
        InventoryList.ShowDialog()
    End Sub
End Class