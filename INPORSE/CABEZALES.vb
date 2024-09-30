Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class CABEZALES
    Dim conjuntoDatos As New DataSet
    Dim adaptadorDatos As New MySqlClient.MySqlDataAdapter
    Dim sentenciaSQL As String
    Dim comandoSQL As New MySqlClient.MySqlCommand

    Private Sub ActualizarGrid()
        Try
            conjuntoDatos.Clear()
            sentenciaSQL = "Select * from CABEZAL"
            adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
            adaptadorDatos.Fill(conjuntoDatos, "CABEZAL")
            data1.DataSource = conjuntoDatos.Tables("CABEZAL")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub CABEZALES_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
    Private Sub CABEZALES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Module1.funcionConectarBD()
            ActualizarGrid()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub N_Click(sender As Object, e As EventArgs) Handles N.Click
        If N.Text = "NUEVO" Then
            N.Text = "GUARDAR"
            P.Enabled = True
            MEN.Enabled = True
            MR.Enabled = True
            CC.Enabled = True
            PLACA.Enabled = False
            MOTORISTA.Enabled = False
            CAPACIDAD.Enabled = False
            M.Enabled = False
            Eliminar.Enabled = False
        Else
            Try
                sentenciaSQL = "INSERT INTO CABEZAL VALUES ('" & P.Text & "','" & MEN.Text & "','" & MR.Text & "','" & CC.Text & "')"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                MessageBox.Show("El registro ha sido creado.", "Informacion", MessageBoxButtons.OK)
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            N.Text = "NUEVO"
            P.Enabled = False
            MEN.Enabled = False
            MR.Enabled = False
            CC.Enabled = False
            PLACA.Enabled = False
            MOTORISTA.Enabled = False
            CAPACIDAD.Enabled = False
            M.Enabled = True
            Eliminar.Enabled = True
        End If
    End Sub

    Private Sub M_Click(sender As Object, e As EventArgs) Handles M.Click
        If M.Text = "MODIFICAR" Then
            M.Text = "GUARDAR"
            P.Enabled = True
            MEN.Enabled = True
            MR.Enabled = True
            CC.Enabled = True
            PLACA.Enabled = False
            MOTORISTA.Enabled = False
            CAPACIDAD.Enabled = False
            N.Enabled = False
            Eliminar.Enabled = False
        Else
            Try

                sentenciaSQL = "UPDATE CABEZAL SET MOTORISTA_ENCARGADO='" & MEN.Text & "', MARCA='" & MR.Text & "', CAPACIDAD_DE_CARGA='" & CC.Text & "' WHERE PLACA='" & P.Text & "'"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                MessageBox.Show("El registro a sido modificado.", "Informacion", MessageBoxButtons.OK)
                conjuntoDatos.Clear()
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            M.Text = "MODIFICAR"
            P.Enabled = False
            MEN.Enabled = False
            MR.Enabled = False
            CC.Enabled = False
            PLACA.Enabled = False
            MOTORISTA.Enabled = False
            CAPACIDAD.Enabled = False
            N.Enabled = True
            Eliminar.Enabled = True
        End If

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If MessageBox.Show("¿Desea eliminar un registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MessageBox.Show("Cancelado")
            P.Enabled = True
            MEN.Enabled = True
            MR.Enabled = True
            CC.Enabled = True
            PLACA.Enabled = False
            MOTORISTA.Enabled = False
            CAPACIDAD.Enabled = False
            N.Enabled = False
            M.Enabled = False
        Else
            Dim CodigoEliminar As String
            CodigoEliminar = InputBox("Digite el codigo del registro a eliminar:", "Eliminar")
            Try
                sentenciaSQL = "DELETE FROM CABEZAL WHERE PLACA='" & CodigoEliminar & "'"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                conjuntoDatos.Clear()
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try

            P.Enabled = False
            MEN.Enabled = False
            MR.Enabled = False
            CC.Enabled = False
            PLACA.Enabled = False
            MOTORISTA.Enabled = False
            CAPACIDAD.Enabled = False
            N.Enabled = True
            M.Enabled = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PLACA.Enabled = True
        MOTORISTA.Enabled = True
        CAPACIDAD.Enabled = True
    End Sub

    Private Sub PLACA_KeyUp(sender As Object, e As KeyEventArgs) Handles PLACA.KeyUp


        conjuntoDatos.Clear()
        If PLACA.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM CABEZAL WHERE PLACA like '%" & PLACA.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "CABEZAL")
                data1.DataSource = conjuntoDatos.Tables("CABEZAL")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub

    Private Sub MOTORISTA_KeyUp(sender As Object, e As KeyEventArgs) Handles MOTORISTA.KeyUp
        PLACA.Clear()
        conjuntoDatos.Clear()
        If MOTORISTA.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM CABEZAL WHERE MOTORISTA_ENCARGADO like '%" & MOTORISTA.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "CABEZAL")
                data1.DataSource = conjuntoDatos.Tables("CABEZAL")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub

    Private Sub CAPACIDAD_KeyUp(sender As Object, e As KeyEventArgs) Handles CAPACIDAD.KeyUp
        MOTORISTA.Clear()
        conjuntoDatos.Clear()
        If CAPACIDAD.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM CABEZAL WHERE CAPACIDAD_DE_CARGA like '%" & CAPACIDAD.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "CABEZAL")
                data1.DataSource = conjuntoDatos.Tables("CABEZAL")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub
End Class