Public Class frmFileLeave
    Sub clear()
        txtLFN.Text = ""
        txtEmployeeID.Text = ""
        txtName.Text = ""
        txtPos.Text = ""
        txtDept.Text = ""
        txtDivision.Text = ""
        cmbLeaveType.Text = ""
        dtpFrom.Value = Now
        dtpTo.Value = Now
        txtNoOfDays.Text = ""
        cmbWithpay.Text = ""
        txtReason.Text = ""

    End Sub
    Sub generateLeaveFileNo()
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
                .CommandText = "SELECT * from tblLeave order by LeaveNo DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 7, Len(OleDBDR(0)))
                txtLFN.Text = "LFN-" & Format(Val(StrID) + 1, "00000")
            Else
                txtLFN.Text = "LFN-00001"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    Sub save()
        If MsgBox("ARE YOU SURE?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
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
                    .CommandText = "INSERT INTO tblLeave VALUES('" & txtLFN.Text & _
                        "','" & dtpDateFilled.Value.ToString("MM/dd/yyyy") & _
                        "','" & txtEmployeeID.Text & _
                        "','" & cmbLeaveType.Text & _
                        "','" & txtReason.Text & _
                        "','" & dtpFrom.Value.ToString("MM/dd/yyyy") & _
                        "','" & dtpTo.Value.ToString("MM/dd/yyyy") & _
                        "','" & txtNoOfDays.Text & _
                        "','" & cmbWithpay.Text & "','Date Filed " & Now & "')"
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("Employee Requested Leave Filed !", MsgBoxStyle.Information, "SUCCESS")
                Me.Close()
            End Try
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        save()
    End Sub

    Private Sub frmFileLeave_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clear()
    End Sub

    Private Sub frmFileLeave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        generateLeaveFileNo()
        'dtpFrom.Value = dtpFrom.Value.AddDays(1)
        'dtpTo.Value = dtpTo.Value.AddDays(1)
        'dtpFrom.Value = dtpFrom.Value.AddDays(-1)
        'dtpTo.Value = dtpTo.Value.AddDays(-1)


    End Sub

    Private Sub dtpFrom_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFrom.LostFocus
        Dim datefrom As DateTime = Convert.ToDateTime(dtpFrom.Text)
        Dim dateto As DateTime = Convert.ToDateTime(dtpTo.Text)
        Dim ts As TimeSpan = dateto.Subtract(datefrom)
        If Convert.ToInt32(ts.Days) >= 0 Then
            txtNoOfDays.Text = Convert.ToInt32(ts.Days) + 1
        Else
            txtNoOfDays.Text = "0"
        End If
    End Sub

    Private Sub dtpFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFrom.ValueChanged

      
    End Sub

    Private Sub dtpTo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpTo.LostFocus
        Dim datefrom As DateTime = Convert.ToDateTime(dtpFrom.Text)
        Dim dateto As DateTime = Convert.ToDateTime(dtpTo.Text)
        Dim ts As TimeSpan = dateto.Subtract(datefrom)
        If Convert.ToInt32(ts.Days) >= 0 Then
            txtNoOfDays.Text = Convert.ToInt32(ts.Days) + 1
        Else
            txtNoOfDays.Text = "0"
        End If
    End Sub

    Private Sub dtpTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTo.ValueChanged
        'txtNoOfDays.Text = dtpTo.Value.Day - dtpFrom.Value.Day + 1
        'If txtNoOfDays.Text <= 0 Then
        '    txtNoOfDays.Text = "0"
        'End If
      
    End Sub

    Private Sub txtReason_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReason.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub

End Class