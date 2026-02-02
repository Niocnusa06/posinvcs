Imports MySql.Data.MySqlClient

Module DBConnection

    Public ReadOnly connString As String =
        "server=localhost;port=3307;user=root;password=;database=posinv"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connString)
    End Function

    ' ===== GET CASHIER NAME =====
    Public Function GetCashierName(username As String) As String
        Dim name As String = ""

        Using con As MySqlConnection = GetConnection()
            con.Open()

            Using cmd As New MySqlCommand(
                "SELECT username FROM user WHERE username=@u", con)

                cmd.Parameters.AddWithValue("@u", username)

                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    name = result.ToString()
                End If
            End Using
        End Using

        Return name
    End Function

End Module
