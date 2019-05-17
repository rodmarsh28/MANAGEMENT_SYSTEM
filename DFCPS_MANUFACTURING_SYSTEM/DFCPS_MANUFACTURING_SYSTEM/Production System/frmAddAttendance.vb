Public Class frmAddAttendance
    Dim WorkedHours As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmEmployeesList.FORMSTATUS = "ATT"
        frmEmployeesList.ShowDialog()
    End Sub
    Sub clear()
        txtBioNo.Text = ""
        txtName.Text = ""
        txtPos.Text = ""
        txtLate.Text = "0"
        txtAbsent.Text = "0"
    End Sub

    Private Sub frmAddAttendance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dgv.Rows.Clear()
        clear()
    End Sub

    Private Sub frmAddAttendance_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3.PerformClick()
        End If
    End Sub
    Sub calculateWorkedHours()
        Dim AM_IN As DateTime = Format(txtDate.Value, "dd/MM/yyyy") & " " & Format(txtInA.Value, "hh:mm:00 tt")
        Dim AM_OUT As DateTime = Format(txtDate.Value, "dd/MM/yyyy") & " " & Format(txtOutA.Value, "hh:mm:00 tt")
        Dim PM_IN As DateTime = Format(txtDate.Value, "dd/MM/yyyy") & " " & Format(txtInP.Value, "hh:mm:00 tt")
        Dim PM_OUT As DateTime = Format(txtDate.Value, "dd/MM/yyyy") & " " & Format(txtOutP.Value, "hh:mm:00 tt")
        WorkedHours = (DateDiff(DateInterval.Minute, AM_IN, AM_OUT) / 60) + (DateDiff(DateInterval.Minute, PM_IN, PM_OUT) / 60)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        calculateWorkedHours()
        If txtBioNo.Text = "" Then
            Exit Sub
        End If
        Dim R As Integer = dgv.Rows.Count
        dgv.Rows.Add()
        dgv.Item(0, R).Value = txtBioNo.Text
        dgv.Item(1, R).Value = txtName.Text
        dgv.Item(2, R).Value = txtInA.Text
        dgv.Item(3, R).Value = txtOutA.Text
        dgv.Item(4, R).Value = txtInP.Text
        dgv.Item(5, R).Value = txtOutP.Text
        'dgv.Item(6, R).Value = WorkedHours
        dgv.Item(6, R).Value = txtWhours.Text
        dgv.Item(7, R).Value = txtAbsent.Text
        dgv.Item(8, R).Value = txtLate.Text
        dgv.Item(9, R).Value = txtDate.Text
        clear()
        For Each row As DataGridViewRow In frmEmployeesList.dgv.SelectedRows
            frmEmployeesList.dgv.Rows.Remove(row)
        Next
    End Sub
    Sub saveItem()
        Try
            If dgv.Rows.Count = "0" Then
                Exit Sub
            End If
        If MsgBox("ARE YOU SURE YOU WANT TO SAVE ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
            Dim row1 As Integer
            Dim col As Integer
            col = 0
            row1 = dgv.RowCount
            While col < row1
                If conn.State = ConnectionState.Open Then
                    OleDBC.Dispose()
                    conn.Close()
                End If
                If conn.State <> ConnectionState.Open Then
                    ConnectDatabase()
                End If
                With OleDBC
                    .Connection = conn
                        .CommandText = "INSERT INTO tblAttendance VALUES('" & dgv.Item(0, col).Value & _
                                "','" & Format(txtDate.Value, "MM/dd/yyyy") & " " & Format(txtInA.Value, "hh:mm:00 tt") & _
                                "','" & dgv.Item(3, col).Value & _
                                "','" & dgv.Item(4, col).Value & _
                                "','" & dgv.Item(5, col).Value & _
                                "','" & dgv.Item(6, col).Value & _
                                "','" & dgv.Item(8, col).Value & "') "
                        .ExecuteNonQuery()
                    End With
                    col = col + 1
                End While
                MsgBox("Success", MsgBoxStyle.Information, "")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLate.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        saveItem()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        For Each row As DataGridViewRow In dgv.SelectedRows
            Dim R As Integer = frmEmployeesList.dgv.Rows.Count
            frmEmployeesList.dgv.Rows.Add()
            frmEmployeesList.dgv.Item(0, R).Value = dgv.CurrentRow.Cells(0).Value
            frmEmployeesList.dgv.Item(1, R).Value = dgv.CurrentRow.Cells(1).Value
            frmEmployeesList.dgv.Item(2, R).Value = dgv.CurrentRow.Cells(2).Value
            dgv.Rows.Remove(row)
        Next
    End Sub
    Private Sub dgv_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDown
        Try
            If e.Button = MouseButtons.Right Then
                dgv.CurrentCell = dgv(e.ColumnIndex, e.RowIndex)
                dgv.ContextMenuStrip = ContextMenuStrip1
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ContextMenuStrip1_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosingEventArgs) Handles ContextMenuStrip1.Closing
        dgv.ContextMenuStrip = ContextMenuStrip2
    End Sub
    Private Sub txtWhours_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWhours.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub frmAddAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtWhours.Text = "0"
        txtLate.Text = "0"
        txtAbsent.Text = "0"
    End Sub
End Class