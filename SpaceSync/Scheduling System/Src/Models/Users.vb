Public Class Users
    Private sql As String
    Sub addNewUser(username As String, password As String, role As String)
        sql = "INSERT INTO tbl_users(username, password, role) VALUES('" & username & "', '" & password & "', '" & role & "')"
        executeNonQuery(sql)
        MessageBox.Show("Successfuly inserted")
    End Sub

    Function loginUser(username As String, password As String, role As String) As Boolean
        Dim success As Boolean = False
        Try
            sql = "SELECT COUNT(*) FROM tbl_users WHERE username = '" & username & "' AND password =  '" & password & "' AND  role = '" & role & "'"
            success = executeScalar(sql)
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try

        Return success
    End Function

    Function validateUsername(username As String) As Boolean
        Dim success As Boolean = False
        Try
            sql = "SELECT COUNT(username) FROM tbl_users WHERE username = '" & username & "'"
            success = executeScalar(sql)
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
        Return success
    End Function
End Class
