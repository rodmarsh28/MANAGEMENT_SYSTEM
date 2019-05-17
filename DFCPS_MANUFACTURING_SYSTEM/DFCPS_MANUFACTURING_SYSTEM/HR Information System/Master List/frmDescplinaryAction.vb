Public Class frmDescplinaryAction
    Sub generateDescActionNo()
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
                .CommandText = "SELECT * from tblDesciplinaryAction order by descActionNo DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 7, Len(OleDBDR(0)))
                txtDescActNo.Text = "DSA-" & Format(Val(StrID) + 1, "00000")
            Else
                txtDescActNo.Text = "DSA-00001"
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
                    If CheckBox1.Checked = True Then
                        .CommandText = "INSERT INTO tblDesciplinaryAction VALUES('" & txtDescActNo.Text & _
                            "','" & dtpDate.Value.ToString("MM/dd/yyyy") & _
                            "','" & txtEmployeeID.Text & _
                            "','" & txtViolation.Text & _
                            "','" & txtActionTaken.Text & _
                            "','" & dtpPunishFrom.Value.ToString("MM/dd/yyyy") & _
                            "','" & dtpPunishTo.Value.ToString("MM/dd/yyyy") & _
                            "','" & txtDetailsOfIncident.Text & "','Elvira Dela Serna')"
                    Else
                        .CommandText = "INSERT INTO tblDesciplinaryAction VALUES('" & txtDescActNo.Text & _
                            "','" & dtpDate.Value.ToString("MM/dd/yyyy") & _
                            "','" & txtEmployeeID.Text & _
                            "','" & txtViolation.Text & _
                            "','" & txtActionTaken.Text & _
                            "','" & DBNull.Value & _
                            "','" & DBNull.Value & _
                            "','" & txtDetailsOfIncident.Text & "','Elvira Dela Serna')"
                    End If

                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MsgBox("Employee Desciplinary Action Saved !", MsgBoxStyle.Information, "SUCCESS")

                Me.Close()
            End Try
        End If
    End Sub
    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        save()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            dtpPunishFrom.Enabled = True
            dtpPunishTo.Enabled = True
        Else
            dtpPunishFrom.Enabled = False
            dtpPunishTo.Enabled = False
        End If
    End Sub

    Private Sub frmDescplinaryAction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckBox1.Checked = False
        generateDescActionNo()

    End Sub

    Private Sub txtDetailsOfIncident_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDetailsOfIncident.KeyPress
        e.KeyChar = Char.ToUpper(e.KeyChar)
    End Sub
    'MsgBox("Employees Information Updated !", MsgBoxStyle.Information, "Success")

    '            Me.Close()


  
End Class