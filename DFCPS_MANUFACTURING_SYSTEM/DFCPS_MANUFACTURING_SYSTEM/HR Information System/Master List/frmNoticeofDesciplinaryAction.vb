﻿Public Class frmNoticeofDesciplinaryAction
    Sub generateNotDescActionNo()
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
                .CommandText = "SELECT * from tblNODA order by NotdescActionNo DESC"
            End With
            OleDBDR = OleDBC.ExecuteReader
            If OleDBDR.Read Then
                StrID = Mid(OleDBDR(0), 5, Len(OleDBDR(0)))
                txtDescActNo.Text = Format(Val(StrID) + 1, "00000")
            Else
                txtDescActNo.Text = "00001"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
    'Sub save()
    '    If MsgBox("ARE YOU SURE?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
    '        Try
    '            If conn.State = ConnectionState.Open Then
    '                OleDBC.Dispose()
    '                conn.Close()
    '            End If
    '            If conn.State <> ConnectionState.Open Then
    '                ConnectDatabase()
    '            End If
    '            With OleDBC
    '                .Connection = conn

    '                .CommandText = "INSERT INTO tblNODA VALUES('" & txtDescActNo.Text & _
    '                    "','" & dtpDate.Value.ToString("MM/dd/yyyy") & _
    '                    "','" & txtEmployeeID.Text & _
    '                    "','" & txtViolation.Text & _
    '                    "','" & txtActionTaken.Text & _
    '                    "','" & dtpPunishFrom.Value.ToString("MM/dd/yyyy") & _
    '                    "','" & dtpPunishTo.Value.ToString("MM/dd/yyyy") & _
    '                    "','" & txtDetailsOfIncident.Text & "','Elvira Dela Serna')"
    '                .ExecuteNonQuery()
    '            End With
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        Finally
    '            MsgBox("Employee Desciplinary Action Saved !", MsgBoxStyle.Information, "SUCCESS")

    '            Me.Close()
    '        End Try
    '    End If
    'End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

    End Sub
End Class