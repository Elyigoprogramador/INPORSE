Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class VIAJES
    Dim conjuntoDatos As New DataSet
    Dim adaptadorDatos As New MySqlClient.MySqlDataAdapter
    Dim sentenciaSQL As String
    Dim comandoSQL As New MySqlClient.MySqlCommand
    Private Sub VIAJES_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.Show()
        Me.Hide()
    End Sub


    Private Sub ActualizarGrid()
        Try
            conjuntoDatos.Clear()
            sentenciaSQL = "Select * from VIAJES"
            adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
            adaptadorDatos.Fill(conjuntoDatos, "VIAJES")
            data1.DataSource = conjuntoDatos.Tables("VIAJES")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub VIAJES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlconsulta.Width = 90
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
            IDV.Enabled = True
            IDC.Enabled = True
            R.Enabled = True
            CAB.Enabled = True
            EST.Enabled = True
            COBRO.Enabled = True
            IDCON.Enabled = True
            IDP.Enabled = True
            CANTIDAD.Enabled = True
            M.Enabled = False
            ELIMINAR.Enabled = False
        Else
            Try
                sentenciaSQL = "INSERT INTO VIAJES VALUES ('" & IDV.Text & "','" & IDC.Text & "','" & R.Text & "','" & CAB.Text & "','" & EST.Text & "','" & COBRO.Text & "','" & IDCON.Text & "','" & IDP.Text & "','" & CANTIDAD.Text & "')"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                MessageBox.Show("El registro ha sido creado.", "Informacion", MessageBoxButtons.OK)
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            N.Text = "NUEVO"
            IDV.Enabled = False
            IDC.Enabled = False
            R.Enabled = False
            CAB.Enabled = False
            EST.Enabled = False
            COBRO.Enabled = False
            IDCON.Enabled = False
            IDP.Enabled = False
            CANTIDAD.Enabled = False
            M.Enabled = True
            ELIMINAR.Enabled = True
        End If
    End Sub

    
    Private Sub M_Click(sender As Object, e As EventArgs) Handles M.Click
        If M.Text = "MODIFICAR" Then
            M.Text = "GUARDAR"
            IDV.Enabled = True
            IDC.Enabled = True
            R.Enabled = True
            CAB.Enabled = True
            EST.Enabled = True
            COBRO.Enabled = True
            IDCON.Enabled = True
            IDP.Enabled = True
            CANTIDAD.Enabled = True
            N.Enabled = False
            ELIMINAR.Enabled = False
        Else
            Try

                sentenciaSQL = "UPDATE VIAJES SET ID_CLIENTE='" & IDC.Text & "', RUTA='" & R.Text & "', CABEZAL='" & CAB.Text & "', ESTADO='" & EST.Text & "', COBRO_VIAJE='" & COBRO.Text & "', ID_CONTENEDOR='" & IDCON.Text & "', ID_PRODUCTOS='" & IDP.Text & "', CANTIDAD='" & CANTIDAD.Text & "' WHERE ID_VIAJE='" & IDV.Text & "'"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                MessageBox.Show("El registro a sido modificado.", "Informacion", MessageBoxButtons.OK)
                conjuntoDatos.Clear()
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            M.Text = "MODIFICAR"
            IDV.Enabled = False
            IDC.Enabled = False
            R.Enabled = False
            CAB.Enabled = False
            EST.Enabled = False
            COBRO.Enabled = False
            IDCON.Enabled = False
            IDP.Enabled = False
            CANTIDAD.Enabled = False
            N.Enabled = True
            ELIMINAR.Enabled = True
        End If

    End Sub

    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        If MessageBox.Show("¿Desea eliminar un registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MessageBox.Show("Cancelado")
            IDV.Enabled = True
            IDC.Enabled = True
            R.Enabled = True
            CAB.Enabled = True
            EST.Enabled = True
            COBRO.Enabled = True
            IDCON.Enabled = True
            IDP.Enabled = True
            CANTIDAD.Enabled = True
            M.Enabled = False
            N.Enabled = False
        Else
            Dim CodigoEliminar As String
            CodigoEliminar = InputBox("Digite el codigo del registro a eliminar:", "Eliminar")
            Try
                sentenciaSQL = "DELETE FROM VIAJES WHERE ID_VIAJE='" & CodigoEliminar & "'"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                conjuntoDatos.Clear()
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try

            IDV.Enabled = False
            IDC.Enabled = False
            R.Enabled = False
            CAB.Enabled = False
            EST.Enabled = False
            COBRO.Enabled = False
            IDCON.Enabled = False
            IDP.Enabled = False
            CANTIDAD.Enabled = False
            M.Enabled = True
            N.Enabled = True
        End If

    End Sub
    Private Sub Timercontraer_Tick(sender As Object, e As EventArgs) Handles Timercontrae.Tick
        If pnlconsulta.Width <= 90 Then
            Timercontrae.Enabled = False
            Label10.Visible = False
            Label11.Visible = False
            Label13.Visible = False
            Label12.Visible = False
            TID.Visible = False
            TNombre.Visible = False
            Ttelefono.Visible = False
        Else
            pnlconsulta.Width = pnlconsulta.Width - 5
        End If
    End Sub

    Private Sub CON_Click(sender As Object, e As EventArgs) Handles CON.Click
        TID.Enabled = True
        RUTA.Enabled = True
        CABEZAL.Enabled = True
        ESTADO.Enabled = True
    End Sub

    Private Sub TID_KeyUp(sender As Object, e As KeyEventArgs) Handles TID.KeyUp
        conjuntoDatos.Clear()
        If TID.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM VIAJES WHERE ID_VIAJE like '%" & TID.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "VIAJES")
                data1.DataSource = conjuntoDatos.Tables("VIAJES")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub

    Private Sub RUTA_KeyUp(sender As Object, e As KeyEventArgs) Handles RUTA.KeyUp
        conjuntoDatos.Clear()
        If RUTA.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM VIAJES WHERE RUTA like '%" & RUTA.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "VIAJES")
                data1.DataSource = conjuntoDatos.Tables("VIAJES")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub

    Private Sub CABEZAL_KeyUp(sender As Object, e As KeyEventArgs) Handles CABEZAL.KeyUp
        conjuntoDatos.Clear()
        If CABEZAL.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM VIAJES WHERE CABEZAL like '%" & CABEZAL.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "VIAJES")
                data1.DataSource = conjuntoDatos.Tables("VIAJES")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub

   
End Class