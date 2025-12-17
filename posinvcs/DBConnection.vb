Imports MySql.Data.MySqlClient
Public Class DBConnection
    Private Shared ReadOnly connectionstring As String =
        "server=localhost;port=3307;user=root;password=;database=posinv"
    Public Shared Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connectionstring)
        Return conn
    End Function
End Class
