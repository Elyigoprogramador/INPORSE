Imports MySql.Data.MySqlClient
Module Module1
    Public mysqlconexion As New MySqlConnection
    Public Sub funcionConectarBD()
        If mysqlconexion.State = ConnectionState.Closed Then
            mysqlconexion.ConnectionString = "Server=localhost; User ID=root; Password=admin123; Port=3308; Database=INPORSE;"
            mysqlconexion.Open()
        End If
    End Sub



End Module
