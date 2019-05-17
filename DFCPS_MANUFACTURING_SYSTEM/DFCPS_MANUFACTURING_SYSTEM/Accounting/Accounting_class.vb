Imports System.Data.SqlClient

Public Class Accounting_class
    Public command As Integer


    Public transNo As String
    Public transDate As DateTime
    Public refNo As String
    Public tinNo As String
    Public payee As String
    Public address As String
    Public checkbookid As String
    Public checkNo As String
    Public totAmount As Double
    Public totDebit As Double
    Public totCredit As Double
    Public amountinWords As String
    Public status As String
    Public Sub insert_update_checkvoucher()
        Dim cmd As New SqlCommand("insert_update_checkVoucher", conn)
            checkConn()
        With cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@command", SqlDbType.Int).Value = command
            .Parameters.AddWithValue("@transNo", SqlDbType.VarChar).Value = transNo
            .Parameters.AddWithValue("@refNo", SqlDbType.VarChar).Value = refNo
            .Parameters.AddWithValue("@transdate", SqlDbType.VarChar).Value = transDate
            .Parameters.AddWithValue("@tinNo", SqlDbType.Decimal).Value = tinNo
            .Parameters.AddWithValue("@payee", SqlDbType.VarChar).Value = payee
            .Parameters.AddWithValue("@address", SqlDbType.Decimal).Value = address
            .Parameters.AddWithValue("@checkbookID", SqlDbType.VarChar).Value = checkbookid
            .Parameters.AddWithValue("@checkNo", SqlDbType.VarChar).Value = checkNo
            .Parameters.AddWithValue("@totalAmount", SqlDbType.VarChar).Value = totAmount
            .Parameters.AddWithValue("@totalDebit", SqlDbType.VarChar).Value = totDebit
            .Parameters.AddWithValue("@totalCredit", SqlDbType.VarChar).Value = totCredit
            .Parameters.AddWithValue("@amountInwords", SqlDbType.VarChar).Value = amountinWords
            .Parameters.AddWithValue("@userid", SqlDbType.Int).Value = MainForm.LBLID.Text
            .Parameters.AddWithValue("@status", SqlDbType.VarChar).Value = status
        End With
            cmd.ExecuteNonQuery()
    End Sub

    Public Sub insert_CheckTransaction()
        Dim cmd As New SqlCommand("insert_update_checkTransaction", conn)
        checkConn()
        With cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@command", SqlDbType.Int).Value = command
            .Parameters.AddWithValue("@transNo", SqlDbType.VarChar).Value = transNo
            .Parameters.AddWithValue("@checkbookID", SqlDbType.VarChar).Value = checkbookid
            .Parameters.AddWithValue("@checkNo", SqlDbType.VarChar).Value = checkNo
            .Parameters.AddWithValue("@Amount", SqlDbType.VarChar).Value = totAmount
            .Parameters.AddWithValue("@status", SqlDbType.VarChar).Value = "Outstanding Check"
        End With
        cmd.ExecuteNonQuery()
    End Sub
End Class
