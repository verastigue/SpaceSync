Imports MySql.Data.MySqlClient

Module Database
    Private conn As New MySqlConnection
    Private cmd As MySqlCommand

    Sub openConn()
        conn.ConnectionString = "server=localhost;user=root;password=;database=scheduling_schema"
        conn.Open()
    End Sub

    Sub closeConn()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Sub executeNonQuery(sql As String)
        openConn()
        Try
            cmd = New MySqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("Error executing non-query: " & ex.Message)
        End Try
        closeConn()
    End Sub

    Function executeScalar(sql As String) As Boolean
        openConn()
        Dim result As Boolean = False
        Try
            cmd = New MySqlCommand(sql, conn)
            Dim count As Integer = Convert.ToInt64(cmd.ExecuteScalar())

            If count > 0 Then
                result = True
            End If

        Catch ex As Exception
            Console.WriteLine("Error executing Scalar: " & ex.Message)
        Finally
            closeConn()
        End Try

        Return result

    End Function
End Module
