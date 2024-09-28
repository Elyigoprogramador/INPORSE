Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class CONTENEDORES
    Dim conjuntoDatos As New DataSet
    Dim adaptadorDatos As New MySqlClient.MySqlDataAdapter
    Dim sentenciaSQL As String
    Dim comandoSQL As New MySqlClient.MySqlCommand

    Private Sub ActualizarGrid()
        Try
            conjuntoDatos.Clear()
            sentenciaSQL = "Select * from CONTENEDOR"
            adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
            adaptadorDatos.Fill(conjuntoDatos, "CONTENEDOR")
            data1.DataSource = conjuntoDatos.Tables("CONTENEDOR")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub CONTENEDORES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Module1.funcionConectarBD()
            ActualizarGrid()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub CONTENEDORES_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SUPERVISORENTRAR.Show()
        Me.Hide()
    End Sub

    Private Sub N_Click(sender As Object, e As EventArgs) Handles N.Click
        If N.Text = "NUEVO" Then
            N.Text = "GUARDAR"
            txtID.Enabled = True
            T.Enabled = True
            TI.Enabled = True
            TID.Enabled = False
            TTIPO.Enabled = False
            M.Enabled = False
            Eliminar.Enabled = False
        Else
            Try
                sentenciaSQL = "INSERT INTO CONTENEDOR VALUES ('" & txtID.Text & "','" & T.Text & "','" & TI.Text & "')"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                MessageBox.Show("El registro ha sido creado.", "Informacion", MessageBoxButtons.OK)
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            N.Text = "NUEVO"
            txtID.Enabled = False
            T.Enabled = False
            TI.Enabled = False
            TID.Enabled = False
            TTIPO.Enabled = False
            M.Enabled = True
            Eliminar.Enabled = True
        End If
    End Sub

    Private Sub M_Click(sender As Object, e As EventArgs) Handles M.Click
        If M.Text = "MODIFICAR" Then
            M.Text = "GUARDAR"
            txtID.Enabled = True
            T.Enabled = True
            TI.Enabled = True
            TID.Enabled = False
            TTIPO.Enabled = False
            N.Enabled = False
            Eliminar.Enabled = False
        Else
            Try

                sentenciaSQL = "UPDATE CONTENEDOR SET TAMANYO='" & T.Text & "', TIPO='" & TI.Text & "' WHERE ID_CONTENEDOR='" & txtID.Text & "'"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                MessageBox.Show("El registro a sido modificado.", "Informacion", MessageBoxButtons.OK)
                conjuntoDatos.Clear()
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            M.Text = "MODIFICAR"
            txtID.Enabled = False
            T.Enabled = False
            TI.Enabled = False
            TID.Enabled = False
            TTIPO.Enabled = False
            M.Enabled = True
            N.Enabled = True
            Eliminar.Enabled = True
        End If
    End Sub


    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If MessageBox.Show("¿Desea eliminar un registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MessageBox.Show("Cancelado")
          txtID.Enabled = True
            T.Enabled = True
            TI.Enabled = True
            TID.Enabled = False
            TTIPO.Enabled = False
            N.Enabled = False
            M.Enabled = False
        Else
            Dim CodigoEliminar As String
            CodigoEliminar = InputBox("Digite el codigo del registro a eliminar:", "Eliminar")
            Try
                sentenciaSQL = "DELETE FROM CONTENEDOR WHERE ID_CONTENEDOR='" & CodigoEliminar & "'"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                conjuntoDatos.Clear()
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try
              txtID.Enabled = False
            T.Enabled = False
            TI.Enabled = False
            TID.Enabled = False
            TTIPO.Enabled = False
            N.Enabled = True
            M.Enabled = True
        End If
    End Sub



    Private Sub CONSULTA_Click(sender As Object, e As EventArgs) Handles CONSULTA.Click
        TID.Enabled = True
        TTIPO.Enabled = True
    End Sub

    Private Sub TID_KeyUp(sender As Object, e As KeyEventArgs) Handles TID.KeyUp
        TTIPO.Clear()
        conjuntoDatos.Clear()
        If TID.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM CONTENEDOR WHERE ID_CONTENEDOR like '%" & TID.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "CONTENEDOR")
                data1.DataSource = conjuntoDatos.Tables("CONTENEDOR")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub

    Private Sub TTIPO_KeyUp(sender As Object, e As KeyEventArgs) Handles TTIPO.KeyUp
        TID.Clear()
        conjuntoDatos.Clear()
        If TTIPO.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM CONTENEDOR WHERE TIPO like '%" & TTIPO.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "CONTENEDOR")
                data1.DataSource = conjuntoDatos.Tables("CONTENEDOR")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub
End Class