Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class ConsultaCliente
    Dim conjuntoDatos As New DataSet
    Dim adaptadorDatos As New MySqlClient.MySqlDataAdapter
    Dim sentenciaSQL As String
    Private Sub CargarTodos()
        Try
            sentenciaSQL = "SELECT * FROM PRODUCTO"
            adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
            adaptadorDatos.Fill(conjuntoDatos, "PRODUCTO")
            data2.DataSource = conjuntoDatos.Tables("PRODUCTO")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Consultas1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.funcionConectarBD()
        CargarTodos()
        ID.Enabled = True
        NOM.Enabled = True
        UP.Enabled = True
    End Sub

    Private Sub ID_KeyUp(sender As Object, e As KeyEventArgs) Handles ID.KeyUp
        conjuntoDatos.Clear()
        If ID.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM PRODUCTO WHERE ID_PRODUCTO like '%" & ID.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "PRODUCTO")
                data2.DataSource = conjuntoDatos.Tables("PRODUCTO")
            Catch ex As Exception

            End Try
        Else

            CargarTodos()

        End If
    End Sub
End Class