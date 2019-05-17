﻿Imports System.Data.SqlClient

Public Class accEntry_class
    Public refno As String
    Public account As String
    Public memo As String
    Public debit As Double
    Public credit As Double
    Public Sub insert_Acc_entry_class()
        Try
            Dim cmd As New SqlCommand("insert_Acc_entry", conn)
            checkConn()
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@refNo", SqlDbType.VarChar).Value = refNo
                .Parameters.AddWithValue("@src", SqlDbType.VarChar).Value = Form.ActiveForm.Text
                .Parameters.AddWithValue("@accNo", SqlDbType.VarChar).Value = account
                .Parameters.AddWithValue("@memo", SqlDbType.VarChar).Value = memo
                .Parameters.AddWithValue("@debit", SqlDbType.Decimal).Value = debit
                .Parameters.AddWithValue("@credit", SqlDbType.Decimal).Value = credit
            End With
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
