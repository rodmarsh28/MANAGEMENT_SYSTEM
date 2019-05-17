Public Class frmCheckVoucher
    Dim nl As Integer = 0
    Dim checkbookID As String
    Dim particulars As String
    Dim partamount As Double
    Dim accEntryId As String
    Dim accno As String
    Dim debit As Double
    Dim credit As Double
    Public Totamount As Double = 0.0
    Public totDebit As Double = 0.0
    Public totCredit As Double = 0.0
    Dim No As String = ""
    Dim command As Integer


  
    Sub selectCVNo()
        Dim StrID As String
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
                .CommandText = "SELECT checkVoucherNo from tblCheckVoucher order by checkVoucherNo DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 6, Len(OleDBDR(0)))
                txtCVNo.Text = "CV-" & Format(Val(StrID) + 1, "00000")
            Else
                txtCVNo.Text = "CV-00001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub

    Sub save()
        If MsgBox("ARE YOU SURE YOU WANT TO CREATE AND SAVE CASH / CHECK VOUCHER ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            Try
                Dim ac As New Accounting_class
                ac.command = command
                ac.transNo = txtCVNo.Text
                ac.refNo = txtReqNo.Text
                ac.transDate = dtpDate.Value
                ac.tinNo = txtTIN.Text
                ac.payee = txtPayee.Text
                ac.address = txtAddress.Text
                ac.checkbookid = checkbookID
                ac.checkNo = txtCheckNo.Text
                ac.totAmount = lblTotAmount.Text
                ac.totDebit = lblDebit.Text
                ac.totCredit = lblCredit.Text
                ac.amountinWords = txtAmountinWords.Text
                ac.status = "Pending for Approval"
                ac.insert_update_checkvoucher()
                ac.insert_CheckTransaction()
                saveAccEntry()
                updateRFP()
                MsgBox("TRANSACTION COMPLETED !", MsgBoxStyle.Information, "SUCCESS")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Sub updateRFP()
        Dim req As New Puchase_Requisition_class
        req.command = 2
        req.transNo = txtReqNo.Text
        req.src = Form.ActiveForm.Text
        req.totAmount = Totamount
        req.status = txtCVNo.Text & " Prepared"
        req.insert_RFP()
    End Sub

    Sub saveAccEntry()
        Dim ac As New accEntry_class
        For Each row As DataGridViewRow In dgv.Rows
            ac.refno = txtCVNo.Text
            ac.account = row.Cells(0).Value
            ac.memo = txtMemo.Text
            ac.debit = row.Cells(2).Value
            ac.credit = row.Cells(3).Value
            ac.insert_Acc_entry_class()
        Next
    End Sub
  
    Sub printCheque()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each row As DataGridViewRow In dgv.SelectedRows
            Totamount = Totamount - dgv.CurrentRow.Cells(1).Value
            dgv.Rows.Remove(row)
            lblTotAmount.Text = CDbl(Totamount).ToString("#,##0.00")
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For Each row As DataGridViewRow In dgv.SelectedRows
            totDebit = totDebit - dgv.CurrentRow.Cells(2).Value
            totCredit = totCredit - dgv.CurrentRow.Cells(3).Value
            dgv.Rows.Remove(row)
            lblDebit.Text = CDbl(totDebit).ToString("#,##0.00")
            lblCredit.Text = CDbl(totCredit).ToString("#,##0.00")
        Next
    End Sub

   
    Private Sub txtAmountinWords_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountinWords.TextChanged
        txtAmountinWords.Text = UCase(txtAmountinWords.Text)
    End Sub

    Private Sub btnGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub lblTotAmount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTotAmount.TextChanged
        If lblTotAmount.Text = "0" Then
            txtAmountinWords.Text = ""
        Else
            txtAmountinWords.Text = ConvertNumberToENG(CDbl(lblTotAmount.Text))
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If btnSave.Text = "Record" Then
            command = 0
        ElseIf btnSave.Text = "Update" Then
            command = 1
        End If
        If lblTotAmount.Text = lblDebit.Text And lblCredit.Text = lblDebit.Text Then
            save()
        Else
            MsgBox("THE AMOUNT YOU INPUT IS NOT BALANCED, PLEASE CHECK AND TRY AGAIN", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub
    Sub getAccName()
        Dim ac As New Account_Class
        For Each row As DataGridViewRow In dgv.Rows
            ac.searchValue = row.Cells(0).Value
            ac.getaccountName()
            row.Cells(1).Value = ac.AccName
        Next
    End Sub

    Private Sub frmCheckVoucher_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub frmCheckVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        selectCVNo()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmAccountList.mode = "Checkvoucher"
        frmAccountList.ShowDialog()
        If frmAccountList.successClick = True Then
            Dim r As Integer = dgv.Rows.Count
            dgv.Rows.Add()
            dgv.Item(0, r).Value = frmAccountList.dgv.CurrentRow.Cells(0).Value
            dgv.Item(2, r).Value = "0.00"
            dgv.Item(3, r).Value = "0.00"
            frmAccountList.successClick = False
        End If
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDoubleClick
        Try
            If dgv.CurrentCell.ColumnIndex = 2 Then
                Dim dbt As Decimal = InputBox("Debit Value")
                dgv.CurrentRow.Cells(2).Value = Format(dbt, "N")
           
            ElseIf dgv.CurrentCell.ColumnIndex = 3 Then
                Dim cdt As Decimal = InputBox("Credit Value")
                dgv.CurrentRow.Cells(3).Value = Format(cdt, "N")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgv_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellValueChanged
        getAccName()
        Dim cdt As Decimal
        Dim dbt As Decimal
        For Each row As DataGridViewRow In dgv.Rows
            dbt += row.Cells(2).Value
            cdt += row.Cells(3).Value
        Next
        lblDebit.Text = Format(dbt, "N")
        lblCredit.Text = Format(cdt, "N")
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged
        Try
            lblTotAmount.Text = Format(CDbl(txtAmount.Text), "N")
        Catch ex As Exception
            lblTotAmount.Text = "0.00"
        End Try

    End Sub

    Private Sub lblTotAmount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotAmount.Click

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        formBankSelection.get_CheckbookList()
        formBankSelection.mode = "checkbookList"
        formBankSelection.ShowDialog()
        If formBankSelection.itemClicked = True Then
            checkbookID = formBankSelection.dgv.CurrentRow.Cells(0).Value
            txtBankName.Text = formBankSelection.dgv.CurrentRow.Cells(2).Value
            formBankSelection.itemClicked = False
        End If
    End Sub
End Class