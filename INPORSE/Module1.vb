﻿Imports MySql.Data.MySqlClient
Module Module1
    Public mysqlconexion As New MySqlConnection
    Public Sub funcionConectarBD()
        If mysqlconexion.State = ConnectionState.Closed Then
            mysqlconexion.ConnectionString = "Server=localhost; User ID=root; Password=W$F3cKvHU$; Port=3306; Database=INPORSE;"
            mysqlconexion.Open()
        End If
    End Sub

End Module
