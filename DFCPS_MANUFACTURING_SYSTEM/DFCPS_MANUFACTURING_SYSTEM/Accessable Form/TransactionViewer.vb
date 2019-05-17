Imports System.Data.SqlClient

Public Class TransactionViewer
    Dim rowIndex As Integer
    Public MODE As String
    Dim cardID As String
    Dim cardName As String
    Dim payment As String
    Sub get_info_purchaseOrder()
        Try
            checkConn()
            Dim cmd As New SqlCommand("select distinct tblCardsProfile.cardID,tblCardsProfile.cardName,PAYMENT from tblPurchaseOrder inner join tblCardsProfile on tblPurchaseOrder.cardid = tblCardsProfile.cardid where purchaseOrderNo = '" & LV.SelectedItems(0).SubItems(1).Text & "'", conn)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.Read Then
                cardID = dr.Item(0)
                cardName = dr.Item(1)
                payment = dr.Item(2)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
    Sub get_pending_requisition()
        Dim dt As New DataTable
        Try
            checkConn()
            Dim cmd As New SqlCommand("get_requisition_data", conn)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@command", SqlDbType.VarChar).Value = Command()
                .Parameters.AddWithValue("@searchValue", SqlDbType.VarChar).Value = txtSearch.Text
            End With
            Dim da As New SqlDataAdapter(cmd)
            da.SelectCommand = cmd
            dt.Rows.Clear()
            da.Fill(dt)
            LV.Items.Clear()
            LV.Columns.Clear()
            For Each col As DataColumn In dt.Columns
                LV.Columns.Add(col.ToString)
            Next
            For Each row As DataRow In dt.Rows
                Dim lst As ListViewItem
                lst = LV.Items.Add(If(row(0) IsNot Nothing, row(0).ToString, ""))
                For i As Integer = 1 To dt.Columns.Count - 1
                    lst.SubItems.Add(If(row(i) IsNot Nothing, row(i).ToString, ""))
                Next
            Next
            LV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            If rowIndex < LV.Items.Count Then
                LV.Items(rowIndex).Selected = True
            End If
            lblItemCount.Text = Format(LV.Items.Count, "N0")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Sub get_pending_purchaseOrder()
        Dim dt As New DataTable
        Try
            checkConn()
            Dim cmd As New SqlCommand("get_PurchaseOrder_list", conn)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@searchValue", SqlDbType.VarChar).Value = txtSearch.Text
            End With
            Dim da As New SqlDataAdapter(cmd)
            da.SelectCommand = cmd
            dt.Rows.Clear()
            da.Fill(dt)
            LV.Items.Clear()
            LV.Columns.Clear()
            For Each col As DataColumn In dt.Columns
                LV.Columns.Add(col.ToString)
            Next
            For Each row As DataRow In dt.Rows
                Dim lst As ListViewItem
                lst = LV.Items.Add(If(row(0) IsNot Nothing, row(0).ToString, ""))
                For i As Integer = 1 To dt.Columns.Count - 1
                    lst.SubItems.Add(If(row(i) IsNot Nothing, row(i).ToString, ""))
                Next
            Next
            LV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            If rowIndex < LV.Items.Count Then
                LV.Items(rowIndex).Selected = True
            End If
            lblItemCount.Text = Format(LV.Items.Count, "N0")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
    Sub get_pending_RFP()
        Dim dt As New DataTable
        Try
            checkConn()
            Dim cmd As New SqlCommand("get_RFP_list", conn)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@searchValue", SqlDbType.VarChar).Value = txtSearch.Text
            End With
            Dim da As New SqlDataAdapter(cmd)
            da.SelectCommand = cmd
            dt.Rows.Clear()
            da.Fill(dt)
            LV.Items.Clear()
            LV.Columns.Clear()
            For Each col As DataColumn In dt.Columns
                LV.Columns.Add(col.ToString)
            Next
            For Each row As DataRow In dt.Rows
                Dim lst As ListViewItem
                lst = LV.Items.Add(If(row(0) IsNot Nothing, row(0).ToString, ""))
                For i As Integer = 1 To dt.Columns.Count - 1
                    lst.SubItems.Add(If(row(i) IsNot Nothing, row(i).ToString, ""))
                Next
            Next
            LV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LV.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            If rowIndex < LV.Items.Count Then
                LV.Items(rowIndex).Selected = True
            End If
            lblItemCount.Text = Format(LV.Items.Count, "N0")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub TransactionViewer_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub


    Private Sub TransactionViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MODE = "GET_REQUISITION" Then
            get_pending_requisition()
        ElseIf MODE = "GET_PURCHASEORDER" Then
            get_pending_purchaseOrder()
        ElseIf MODE = "GET_RFP" Then
            get_pending_RFP()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If MODE = "GET_REQUISITION" Then
            get_pending_requisition()
        ElseIf MODE = "GET_PURCHASEORDER" Then
            get_pending_purchaseOrder()
        ElseIf MODE = "GET_RFP" Then
            get_pending_RFP()
        End If
    End Sub

    Private Sub LV_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LV.MouseClick
        Try
            If e.Button = MouseButtons.Right Then
                If LV.SelectedItems.Count > 0 Then
                    If MODE = "GET_REQUISITION" Then
                        LV.ContextMenuStrip = cmsRequisition
                    ElseIf MODE = "GET_PURCHASEORDER" Then
                        LV.ContextMenuStrip = cmsPurchaseOrder
                    ElseIf MODE = "GET_RFP" Then
                        LV.ContextMenuStrip = cmsRFP
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmsRequisition_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosingEventArgs) Handles cmsRequisition.Closing
        LV.ContextMenuStrip = disable_context
    End Sub

    Private Sub IssueRequisitionSlipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueRequisitionSlipToolStripMenuItem.Click

    End Sub

    Private Sub PreparePurchaseOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreparePurchaseOrderToolStripMenuItem.Click
        frmPurchases.txtRefNo.Text = LV.SelectedItems(0).SubItems(1).Text
        frmPurchases.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        get_info_purchaseOrder()
        frmPurchasedReceiving.txtRefNo.Text = LV.SelectedItems(0).SubItems(1).Text
        frmPurchasedReceiving.cardID = cardID
        frmPurchasedReceiving.txtName.Text = cardName
        If payment = "CREDIT" Then
            frmPurchasedReceiving.cmbPayment.SelectedIndex = 0
        ElseIf payment = "CASH" Then
            frmPurchasedReceiving.cmbPayment.SelectedIndex = 1
        End If
        frmPurchasedReceiving.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        frmCheckVoucher.txtAmount.Text = LV.SelectedItems(0).SubItems(2).Text
        frmCheckVoucher.txtReqNo.Text = LV.SelectedItems(0).SubItems(1).Text
        frmCheckVoucher.txtAmount.Enabled = False
        frmCheckVoucher.ShowDialog()

    End Sub
End Class