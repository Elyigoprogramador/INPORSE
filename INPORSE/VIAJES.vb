Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO
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
    Private Function ValidarDatos() As Boolean

        If Not ValidarCampos() Then
            Return False
        End If

        Return True
    End Function
    Private Function ValidarCampos() As Boolean

        If String.IsNullOrWhiteSpace(IDV.Text) Then
            MessageBox.Show("El campo de id del viaje es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(cmbc.Text) Then
            MessageBox.Show("El campo de id del cliente es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(cmbR.Text) Then
            MessageBox.Show("El campo de ruta es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(cmbcon.Text) Then
            MessageBox.Show("El campo de id del contenedor es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(cmbp.Text) Then
            MessageBox.Show("El campo de id del producto es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return False
        End If

        If String.IsNullOrWhiteSpace(CANTIDAD.Text) Then
            MessageBox.Show("El campo de cantidad es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return False
        End If
        If String.IsNullOrWhiteSpace(cmbcab.Text) Then
            MessageBox.Show("El campo de cabezal es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return False
        End If
        If String.IsNullOrWhiteSpace(EST.Text) Then
            MessageBox.Show("El campo de estado es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(COBRO.Text) Then
            MessageBox.Show("El campo de cobro es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function
    Private Sub CargarIdContenedor()
        Try
            Dim comando As New MySqlCommand("SELECT ID_CONTENEDOR FROM CONTENEDOR", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbcon.Items.Clear()

            While reader.Read()
                cmbcon.Items.Add(reader("ID_CONTENEDOR").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
        End Try
    End Sub
    Private Sub CargarIdCabezales()
        Try
            Dim comando As New MySqlCommand("SELECT PLACA FROM CABEZAL", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbcab.Items.Clear()

            While reader.Read()
                cmbcab.Items.Add(reader("PLACA").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
        End Try
    End Sub
    Private Sub CargarIdClientes()
        Try
            Dim comando As New MySqlCommand("SELECT ID_CLIENTE FROM CLEINTE", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbc.Items.Clear()

            While reader.Read()
                cmbc.Items.Add(reader("ID_CLIENTE").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
        End Try
    End Sub
    Private Sub CargarIdProductos()
        Try
            Dim comando As New MySqlCommand("SELECT ID_PRODUCTO FROM PRODUCTO", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbp.Items.Clear()

            While reader.Read()
                cmbp.Items.Add(reader("ID_PRODUCTO").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
        End Try
    End Sub
    Private Sub CargarDestinos()
        Try
            Dim comando As New MySqlCommand("SELECT Nombre FROM Destinos", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbR.Items.Clear()

            While reader.Read()
                cmbR.Items.Add(reader("Nombre").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
        End Try
    End Sub
    Private Function GenerarIdViajes() As String

        Dim random As New Random()
        Return random.Next(10000, 99999).ToString()
    End Function
    Private Sub VIAJES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        N.FlatAppearance.BorderColor = Color.LightGreen
        M.FlatAppearance.BorderColor = Color.LightGreen
        ELIMINAR.FlatAppearance.BorderColor = Color.LightGreen
        pnlconsulta.Width = 90
        Try
            Module1.funcionConectarBD()
            ActualizarGrid()
            CargarDestinos()
            CargarIdClientes()
            CargarIdProductos()
            CargarIdCabezales()
            CargarIdContenedor()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Label10.Visible = False
        Label11.Visible = False
        Label13.Visible = False
        Label12.Visible = False
        TID.Visible = False
        RUTA.Visible = False
        CABEZAL.Visible = False
        ESTADO.Visible = False
    End Sub


    Private Sub N_Click_1(sender As Object, e As EventArgs) Handles N.Click
        If N.Text = "NUEVO" Then
            N.Text = "GUARDAR"
            IDV.Enabled = False
            IDV.Text = GenerarIdViajes()
            cmbc.Enabled = True
            cmbR.Enabled = True
            cmbcab.Enabled = True
            EST.Enabled = True
            COBRO.Enabled = True
            cmbcon.Enabled = True
            cmbp.Enabled = True
            CANTIDAD.Enabled = True
            btnmenu.Enabled = False
            M.Enabled = False
            ELIMINAR.Enabled = False
        Else
            If Not ValidarDatos() Then
                Exit Sub
            End If
            Try
                sentenciaSQL = "INSERT INTO VIAJES VALUES ('" & IDV.Text & "','" & cmbc.Text & "','" & cmbR.Text & "','" & cmbcab.Text & "','" & EST.Text & "','" & COBRO.Text & "','" & cmbcon.Text & "','" & cmbp.Text & "','" & CANTIDAD.Text & "')"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                MessageBox.Show("El registro ha sido creado.", "Informacion", MessageBoxButtons.OK)
                ActualizarGrid()





            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            N.Text = "NUEVO"
            IDV.Enabled = False
            cmbc.Enabled = False
            cmbR.Enabled = False
            cmbcab.Enabled = False
            EST.Enabled = False
            COBRO.Enabled = False
            cmbcon.Enabled = False
            cmbp.Enabled = False
            CANTIDAD.Enabled = False
            btnmenu.Enabled = False
            M.Enabled = True
            ELIMINAR.Enabled = True
        End If
    End Sub

    Private Sub M_Click_1(sender As Object, e As EventArgs) Handles M.Click
        If M.Text = "EDITAR" Then
            M.Text = "GUARDAR"
            IDV.Enabled = True
            cmbc.Enabled = True
            cmbR.Enabled = True
            cmbcab.Enabled = True
            EST.Enabled = True
            COBRO.Enabled = True
            cmbcon.Enabled = True
            cmbp.Enabled = True
            CANTIDAD.Enabled = True
            btnmenu.Enabled = False
            N.Enabled = False
            ELIMINAR.Enabled = False
        Else
            Try

                sentenciaSQL = "UPDATE VIAJES SET ID_CLIENTE='" & cmbc.Text & "', RUTA='" & cmbR.Text & "', CABEZAL='" & cmbcab.Text & "', ESTADO='" & EST.Text & "', COBRO_VIAJE='" & COBRO.Text & "', ID_CONTENEDOR='" & cmbcon.Text & "', ID_PRODUCTOS='" & cmbp.Text & "', CANTIDAD='" & CANTIDAD.Text & "' WHERE ID_VIAJE='" & IDV.Text & "'"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                MessageBox.Show("El registro a sido modificado.", "Informacion", MessageBoxButtons.OK)
                conjuntoDatos.Clear()
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            M.Text = "EDITAR"
            IDV.Enabled = False
            cmbc.Enabled = False
            cmbR.Enabled = False
            cmbcab.Enabled = False
            EST.Enabled = False
            COBRO.Enabled = False
            cmbcon.Enabled = False
            cmbp.Enabled = False
            CANTIDAD.Enabled = False
            N.Enabled = True
            btnmenu.Enabled = False
            ELIMINAR.Enabled = True
        End If
    End Sub

    Private Sub ELIMINAR_Click_1(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        If MessageBox.Show("¿Desea eliminar un registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MessageBox.Show("Cancelado")
            IDV.Enabled = True
            cmbc.Enabled = True
            cmbR.Enabled = True
            cmbcab.Enabled = True
            EST.Enabled = True
            COBRO.Enabled = True
            cmbcon.Enabled = True
            cmbp.Enabled = True
            btnmenu.Enabled = False
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
            cmbc.Enabled = False
            cmbR.Enabled = False
            cmbcab.Enabled = False
            EST.Enabled = False
            COBRO.Enabled = False
            cmbcon.Enabled = False
            cmbp.Enabled = False
            CANTIDAD.Enabled = False
            btnmenu.Enabled = False
            M.Enabled = True
            N.Enabled = True
        End If
    End Sub

    Private Sub Timercontrae_Tick(sender As Object, e As EventArgs) Handles Timercontrae.Tick
        If pnlconsulta.Width <= 90 Then
            Timercontrae.Enabled = False
            Label10.Visible = False
            Label11.Visible = False
            Label13.Visible = False
            Label12.Visible = False
            TID.Visible = False
            RUTA.Visible = False
            CABEZAL.Visible = False
            ESTADO.Visible = False
        Else
            pnlconsulta.Width = pnlconsulta.Width - 5
        End If
    End Sub
    Private Sub Timerdespliega_Tick(sender As Object, e As EventArgs) Handles Timerdespliega.Tick
        If pnlconsulta.Width >= 300 Then
            Timerdespliega.Enabled = False
            Label10.Visible = True
            Label11.Visible = True
            Label13.Visible = True
            Label12.Visible = True
            TID.Visible = True
            RUTA.Visible = True
            CABEZAL.Visible = True
            ESTADO.Visible = True
        Else
            pnlconsulta.Width = pnlconsulta.Width + 5
        End If
    End Sub
    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If pnlconsulta.Width = 90 Then
            Timerdespliega.Enabled = True
            btnmenu.Text = "-->"
        ElseIf pnlconsulta.Width = 300 Then
            Timercontrae.Enabled = True
            btnmenu.Text = "CONSULTAR"
        End If
        TID.Enabled = True
        RUTA.Enabled = True
        CABEZAL.Enabled = True
        ESTADO.Enabled = True
    End Sub


    Private Sub TID_KeyUp(sender As Object, e As KeyEventArgs)
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

    Private Sub RUTA_KeyUp(sender As Object, e As KeyEventArgs)
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

    Private Sub CABEZAL_KeyUp(sender As Object, e As KeyEventArgs)
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