﻿Imports System.Data.SqlClient

Public Class InventoryList
    Dim buyable As String
    Dim sellable As String
    Dim inventorable As String
    Dim costacc As String
    Dim incomeacc As String
    Dim assetacc As String
    Public mode As String
    Public clickedItem As Boolean
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewItem.Click
        If mode = "Item Requisition" Then
            AddNewItem.ShowDialog()
        ElseIf mode = "Sales" Or mode = "Issuance" Or mode = "Purchases" Then
            frmAddItemsInventory.cmbItemType.SelectedIndex = 1
            frmAddItemsInventory.btnAdd.Text = "Add Item"
            frmAddItemsInventory.ShowDialog()
        End If
        
    End Sub
    Sub getItemlist()
        Dim cmd
        If mode = "Sales" Then
            cmd = New SqlCommand("get_item_sellable", conn)
            dgv.Columns("Column3").HeaderText = "Sell Price"
        ElseIf mode = "Purchases" Then
            cmd = New SqlCommand("get_item_buyable", conn)
            dgv.Columns("Column3").HeaderText = "Sell Price"
        ElseIf mode = "Issuance" Or mode = "Item Requisition" Or mode = "Receiving" Then
            cmd = New SqlCommand("get_item_inventoriable", conn)
            dgv.Columns("Column3").HeaderText = "Cost"

        End If
        conn.Close()
        ConnectDatabase()
        With cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@SEARCH_VALUE", SqlDbType.VarChar).Value = txtSearch.Text
        End With
        Try
            Dim c As Integer = 0
            Using r = cmd.ExecuteReader
                dgv.Rows.Clear()
                If r.HasRows Then
                    While r.Read
                        dgv.Rows.Add()
                        dgv.Item(0, c).Value = r.Item(0)
                        dgv.Item(1, c).Value = r.Item(1)
                        dgv.Item(2, c).Value = r.Item(2)
                        dgv.Item(3, c).Value = Format(r.Item(3), "N")
                        dgv.Item(4, c).Value = Format(r.Item(4), "N0")
                        dgv.Item(5, c).Value = r.Item(5)
                        dgv.Item(6, c).Value = r.Item(6)
                        dgv.Item(7, c).Value = r.Item(7)
                        c = c + 1
                    End While
                End If
            End Using
            dgv.ClearSelection()
            lblItemsCount.Text = Format(dgv.Rows.Count, "N0")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If GetActiveWindow = Me.Handle Then
            getItemlist()
        End If
    End Sub

    Private Sub InventoryList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getItemlist()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        getItemlist()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDoubleClick
        clickedItem = True
        If mode = "Sales" Then
            Dim r As Integer = frmSalesInvoice.dgv.Rows.Count
            frmSalesInvoice.dgv.Rows.Add()
            frmSalesInvoice.dgv.Item(0, r).Value = dgv.CurrentRow.Cells(0).Value
            frmSalesInvoice.dgv.Item(1, r).Value = dgv.CurrentRow.Cells(1).Value
            frmSalesInvoice.dgv.Item(2, r).Value = dgv.CurrentRow.Cells(2).Value
            frmSalesInvoice.dgv.Item(3, r).Value = dgv.CurrentRow.Cells(3).Value
            frmSalesInvoice.dgv.Item(4, r).Value = frmSalesInvoice.txtQty.Text
            frmSalesInvoice.dgv.Item(5, r).Value = CDbl(dgv.CurrentRow.Cells(3).Value) * CDbl(frmSalesInvoice.txtQty.Text)
            Me.Close()
        ElseIf mode = "Purchases" Then
            Me.Close()
        ElseIf mode = "Item Requisition" Then
            Dim r As Integer = frmItemRequisition.dgv.Rows.Count
            frmItemRequisition.dgv.Rows.Add()
            frmItemRequisition.dgv.Item(0, r).Value = dgv.CurrentRow.Cells(0).Value
            frmItemRequisition.dgv.Item(1, r).Value = dgv.CurrentRow.Cells(1).Value
            frmItemRequisition.dgv.Item(2, r).Value = dgv.CurrentRow.Cells(2).Value
            frmItemRequisition.dgv.Item(3, r).Value = dgv.CurrentRow.Cells(4).Value
            frmItemRequisition.dgv.Item(4, r).Value = frmItemRequisition.txtQty.Text
            Me.Close()
        ElseIf mode = "Issuance" Then
            Dim r As Integer = frmItemsIssuance.dgv.Rows.Count
            frmItemsIssuance.dgv.Rows.Add()
            frmItemsIssuance.dgv.Item(0, r).Value = dgv.CurrentRow.Cells(0).Value
            frmItemsIssuance.dgv.Item(1, r).Value = dgv.CurrentRow.Cells(1).Value
            frmItemsIssuance.dgv.Item(2, r).Value = dgv.CurrentRow.Cells(2).Value
            frmItemsIssuance.dgv.Item(3, r).Value = dgv.CurrentRow.Cells(4).Value
            frmItemsIssuance.dgv.Item(4, r).Value = frmItemsIssuance.txtQty.Text
            frmItemsIssuance.dgv.Item(5, r).Value = CDbl(dgv.CurrentRow.Cells(3).Value) * CDbl(frmItemsIssuance.txtQty.Text)
            frmItemsIssuance.dgv.Item(6, r).Value = dgv.CurrentRow.Cells(7).Value
            Me.Close()
        ElseIf mode = "Receiving" Then
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub
End Class