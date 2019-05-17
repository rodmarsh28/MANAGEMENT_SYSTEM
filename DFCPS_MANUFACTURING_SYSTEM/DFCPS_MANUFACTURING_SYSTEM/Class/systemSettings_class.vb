Imports System.Data.SqlClient

Public Class systemSettings_class
    Public settingsName As String
    Public settingsValue As String
    Public return_settingsValue As String
    Public dt As DataTable
    Public Sub insert_update_settingsVariable()
        Try
            Dim cmd As New SqlCommand("insert_settingsVariable", conn)
            checkConn()
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@settingsName", SqlDbType.Int).Value = settingsName
                .Parameters.AddWithValue("@settingsValue", SqlDbType.VarChar).Value = settingsValue
            End With
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub get_settingsValue()
        Try
            checkConn()
            Dim cmd As New SqlCommand("select_settingsVariable", conn)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@settingsName", SqlDbType.VarChar).Value = settingsName
                .Parameters.AddWithValue("@settingsValue", SqlDbType.VarChar).Value = settingsValue
            End With
            OleDBDR = cmd.ExecuteReader
            If OleDBDR.Read Then
                return_settingsValue = OleDBDR.Item(0)
            Else
                return_settingsValue = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Sub
End Class
