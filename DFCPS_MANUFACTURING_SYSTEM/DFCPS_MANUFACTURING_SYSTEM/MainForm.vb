Public Class MainForm

    Private Sub ABOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABOUTToolStripMenuItem.Click

    End Sub

    Private Sub REGISTERACCOUNTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTERACCOUNTToolStripMenuItem.Click
        frmRegForm.ShowDialog()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        frmLogin.ShowDialog()
    End Sub

    Private Sub MetroButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        HRISMain.ShowDialog()
    End Sub

    Private Sub ACCOUNTLISTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmUserList.ShowDialog()
    End Sub

    Private Sub MANAGEACCOUNTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MANAGEACCOUNTToolStripMenuItem.Click
        frmUserList.ShowDialog()
    End Sub

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmAccountingSystem.ShowDialog()
    End Sub

    Private Sub MANAGECHARTOFACCOUNTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MANAGECHARTOFACCOUNTSToolStripMenuItem.Click
        frmManageAccounts.ShowDialog()
    End Sub

    Private Sub MetroButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ProductionMain.ShowDialog()
    End Sub

   
    Private Sub MetroButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        frmInventorySystemMain.ShowDialog()
    End Sub

    Private Sub MetroButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton6.Click
        frmPurchaseMain.ShowDialog()
    End Sub

    Private Sub MetroButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton5.Click
        frmSalesMain.ShowDialog()
    End Sub

    Private Sub MetroButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton4.Click
        ProductionMain.ShowDialog()
    End Sub

    Private Sub MetroButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton3.Click
        HRISMain.ShowDialog()
    End Sub

    Private Sub MetroButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        frmAccountingMain.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Are you sure ?", MsgBoxStyle.YesNo, "Question") = MsgBoxResult.Yes Then
            Me.Hide()
            frmLogin.txtPassword.Text = ""
            frmLogin.ShowDialog()
        End If
    End Sub
End Class