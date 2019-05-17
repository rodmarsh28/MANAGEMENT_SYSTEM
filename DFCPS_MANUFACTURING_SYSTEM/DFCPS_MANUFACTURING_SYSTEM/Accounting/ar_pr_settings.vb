Public Class ar_pr_settings

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmAccountList.mode = "Checkvoucher"
        frmAccountList.ShowDialog()
        If frmAccountList.successClick = True Then
            Dim r As Integer = dgvAP.Rows.Count
            dgvAP.Rows.Add()
            dgvAP.Item(0, r).Value = frmAccountList.dgv.CurrentRow.Cells(0).Value
            frmAccountList.successClick = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmAccountList.mode = "Checkvoucher"
        frmAccountList.ShowDialog()
        If frmAccountList.successClick = True Then
            Dim r As Integer = dgvAR.Rows.Count
            dgvAR.Rows.Add()
            dgvAR.Item(0, r).Value = frmAccountList.dgv.CurrentRow.Cells(0).Value
            frmAccountList.successClick = False
        End If
    End Sub

    Private Sub dgvAP_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAP.CellContentClick

    End Sub

    Private Sub dgvAP_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAP.CellValueChanged
        Dim ac As New Account_Class
        For Each row As DataGridViewRow In dgvAP.Rows
            ac.searchValue = row.Cells(0).Value
            ac.getaccountName()
            row.Cells(1).Value = ac.AccName
        Next
    End Sub

    Private Sub dgvAR_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAR.CellValueChanged
        Dim ac As New Account_Class
        For Each row As DataGridViewRow In dgvAR.Rows
            ac.searchValue = row.Cells(0).Value
            ac.getaccountName()
            row.Cells(1).Value = ac.AccName
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For Each row As DataGridViewRow In dgvAP.SelectedRows
            dgvAP.Rows.Remove(row)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each row As DataGridViewRow In dgvAR.SelectedRows
            dgvAR.Rows.Remove(row)
        Next
    End Sub
End Class