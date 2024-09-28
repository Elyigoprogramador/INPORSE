Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class CON
    Dim conjuntoDatos As New DataSet
    Dim adaptadorDatos As New MySqlClient.MySqlDataAdapter
    Dim sentenciaSQL As String
    Dim comandoSQL As New MySqlClient.MySqlCommand
    Private Sub ActualizarGrid()
        Try
            conjuntoDatos.Clear()
            sentenciaSQL = "Select * from MOTORISTAS"
            adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
            adaptadorDatos.Fill(conjuntoDatos, "MOTORISTAS")
            data1.DataSource = conjuntoDatos.Tables("MOTORISTAS")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub MOTORISTAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Module1.funcionConectarBD()
            ActualizarGrid()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub MOTORISTAS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SUPERVISORENTRAR.Show()
        Me.Hide()
    End Sub

    Private Sub N_Click(sender As Object, e As EventArgs) Handles N.Click
        If N.Text = "NUEVO" Then
            N.Text = "GUARDAR"
            txtID.Enabled = True
            txtNOM.Enabled = True
            NL.Enabled = True
            DISPO.Enabled = True
            DUI.Enabled = True
            TEL.Enabled = True
            DIREC.Enabled = True
            SB.Enabled = True
            M.Enabled = False
            Eliminar.Enabled = False
        Else
            Try
                sentenciaSQL = "INSERT INTO MOTORISTAS VALUES ('" & txtID.Text & "','" & txtNOM.Text & "','" & NL.Text & "','" & DISPO.Text & "','" & DUI.Text & "','" & TEL.Text & "','" & DIREC.Text & "','" & SB.Text & "')"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                MessageBox.Show("El registro ha sido creado.", "Informacion", MessageBoxButtons.OK)
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            N.Text = "NUEVO"
            txtID.Enabled = False
            txtNOM.Enabled = False
            NL.Enabled = False
            DISPO.Enabled = False
            DUI.Enabled = False
            TEL.Enabled = False
            DIREC.Enabled = False
            SB.Enabled = False
            M.Enabled = True
            Eliminar.Enabled = True
        End If
    End Sub

    Private Sub M_Click(sender As Object, e As EventArgs) Handles M.Click
        If M.Text = "MODIFICAR" Then
            M.Text = "GUARDAR"
            txtID.Enabled = True
            txtNOM.Enabled = True
            NL.Enabled = True
            DISPO.Enabled = True
            DUI.Enabled = True
            TEL.Enabled = True
            DIREC.Enabled = True
            SB.Enabled = True
            N.Enabled = False
            Eliminar.Enabled = False
        Else
            Try

                sentenciaSQL = "UPDATE MOTORISTAS SET NOMBRE='" & txtNOM.Text & "', NUM_LICENCIA='" & NL.Text & "', DISPONIBILIDAD='" & DISPO.Text & "', DUI='" & DUI.Text & "', TELEFONO='" & TEL.Text & "', DIRECCION='" & DIREC.Text & "', SUELDO_BASE='" & SB.Text & "' WHERE ID_MOTORISTA='" & txtID.Text & "'"

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
            txtNOM.Enabled = False
            NL.Enabled = False
            DISPO.Enabled = False
            DUI.Enabled = False
            TEL.Enabled = False
            DIREC.Enabled = False
            SB.Enabled = False
            N.Enabled = True
            Eliminar.Enabled = True
        End If
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If MessageBox.Show("¿Desea eliminar un registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MessageBox.Show("Cancelado")
            txtID.Enabled = True
            txtNOM.Enabled = True
            NL.Enabled = True
            DISPO.Enabled = True
            DUI.Enabled = True
            TEL.Enabled = True
            DIREC.Enabled = True
            SB.Enabled = True
            N.Enabled = False
            M.Enabled = False
        Else
            Dim CodigoEliminar As String
            CodigoEliminar = InputBox("Digite el codigo del registro a eliminar:", "Eliminar")
            Try
                sentenciaSQL = "DELETE FROM MOTORISTAS WHERE ID_MOTORISTA='" & CodigoEliminar & "'"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                conjuntoDatos.Clear()
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try
            txtID.Enabled = False
            txtNOM.Enabled = False
            NL.Enabled = False
            DISPO.Enabled = False
            DUI.Enabled = False
            TEL.Enabled = False
            DIREC.Enabled = False
            SB.Enabled = False
            N.Enabled = True
            M.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tID.Enabled = True
        Tnombre.Enabled = True
        Tlicencia.Enabled = True
    End Sub

    Private Sub tID_KeyUp(sender As Object, e As KeyEventArgs) Handles tID.KeyUp
        conjuntoDatos.Clear()
        If tID.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM MOTORISTAS WHERE ID_MOTORISTA like '%" & tID.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "MOTORISTAS")
                data1.DataSource = conjuntoDatos.Tables("MOTORISTAS")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub

    Private Sub Tnombre_KeyUp(sender As Object, e As KeyEventArgs) Handles Tnombre.KeyUp
        conjuntoDatos.Clear()
        If Tnombre.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM MOTORISTAS WHERE NOMBRE like '%" & Tnombre.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "MOTORISTAS")
                data1.DataSource = conjuntoDatos.Tables("MOTORISTAS")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub

    Private Sub Tlicencia_KeyUp(sender As Object, e As KeyEventArgs) Handles Tlicencia.KeyUp
        conjuntoDatos.Clear()
        If Tlicencia.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM MOTORISTAS WHERE NUM_LICENCIA like '%" & Tlicencia.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "MOTORISTAS")
                data1.DataSource = conjuntoDatos.Tables("MOTORISTAS")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub
End Class