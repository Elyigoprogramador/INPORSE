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
    Private Function ValidarCampos() As Boolean

        If String.IsNullOrWhiteSpace(P.Text) Then
            MessageBox.Show("El campo de placa es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(MEN.Text) Then
            MessageBox.Show("El campo de motorista es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If


        If String.IsNullOrWhiteSpace(MR.Text) Then
            MessageBox.Show("El campo de marca es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(CC.Text) Then
            MessageBox.Show("El campo de capacidad es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function ValidarDatos() As Boolean

        If Not ValidarCampos() Then
            Return False
        End If

        Return True
    End Function
    Private Sub CABEZALES_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
    Private Sub CABEZALES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlconsulta.Width = 90
        Try
            Module1.funcionConectarBD()
            ActualizarGrid()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Label6.Visible = False
        Label5.Visible = False
        Label7.Visible = False
        PLACA.Visible = False
        MOTORISTA.Visible = False
        CAPACIDAD.Visible = False
        P.Enabled = False
        MEN.Enabled = False
        MR.Enabled = False
        CC.Enabled = False
        P.Visible = False
        MEN.Visible = False
        MR.Visible = False
        CC.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
    End Sub

    Private Sub N_Click_1(sender As Object, e As EventArgs) Handles N.Click
        If N.Text = "NUEVO" Then
            N.Text = "GUARDAR"
            P.Enabled = True
            MEN.Enabled = True
            MR.Enabled = True
            CC.Enabled = True
            P.Visible = True
            MEN.Visible = True
            MR.Visible = True
            CC.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            PLACA.Enabled = True
            MOTORISTA.Enabled = False
            CAPACIDAD.Enabled = False
            M.Enabled = False
            btnmenu.Enabled = False
            Eliminar.Enabled = False
        Else
            If Not ValidarDatos() Then
                Exit Sub
            End If
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
            P.Visible = False
            MEN.Visible = False
            MR.Visible = False
            CC.Visible = False
            P.Visible = False
            MEN.Visible = False
            MR.Visible = False
            CC.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            P.Enabled = False
            MEN.Enabled = False
            MR.Enabled = False
            CC.Enabled = False
            PLACA.Enabled = False
            MOTORISTA.Enabled = False
            CAPACIDAD.Enabled = False
            btnmenu.Enabled = False
            M.Enabled = True
            Eliminar.Enabled = True
        End If
    End Sub

    Private Sub M_Click_1(sender As Object, e As EventArgs) Handles M.Click
        If M.Text = "MODIFICAR" Then
            M.Text = "GUARDAR"
            P.Visible = True
            MEN.Visible = True
            MR.Visible = True
            CC.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            P.Enabled = True
            MEN.Enabled = True
            MR.Enabled = True
            CC.Enabled = True
            PLACA.Enabled = False
            MOTORISTA.Enabled = False
            btnmenu.Enabled = False
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
            P.Visible = False
            MEN.Visible = False
            MR.Visible = False
            CC.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            P.Enabled = False
            MEN.Enabled = False
            MR.Enabled = False
            CC.Enabled = False
            PLACA.Enabled = False
            MOTORISTA.Enabled = False
            CAPACIDAD.Enabled = False
            N.Enabled = True
            btnmenu.Enabled = False
            Eliminar.Enabled = True
        End If
    End Sub

    Private Sub Eliminar_Click_1(sender As Object, e As EventArgs) Handles Eliminar.Click
        If MessageBox.Show("¿Desea eliminar un registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MessageBox.Show("Cancelado")
            P.Visible = True
            MEN.Visible = True
            MR.Visible = True
            CC.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            P.Enabled = True
            MEN.Enabled = True
            MR.Enabled = True
            CC.Enabled = True
            PLACA.Enabled = False
            MOTORISTA.Enabled = False
            CAPACIDAD.Enabled = False
            btnmenu.Enabled = False
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
            P.Visible = False
            MEN.Visible = False
            MR.Visible = False
            CC.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            P.Enabled = False
            MEN.Enabled = False
            MR.Enabled = False
            CC.Enabled = False
            PLACA.Enabled = False
            MOTORISTA.Enabled = False
            CAPACIDAD.Enabled = False
            btnmenu.Enabled = False
            N.Enabled = True
            M.Enabled = True
        End If
    End Sub

    Private Sub Timercontrae_Tick(sender As Object, e As EventArgs) Handles Timercontrae.Tick
        If pnlconsulta.Width <= 90 Then
            Timercontrae.Enabled = False
            Label6.Visible = False
            Label5.Visible = False
            Label7.Visible = False
            PLACA.Visible = False
            MOTORISTA.Visible = False
            CAPACIDAD.Visible = False
        Else
            pnlconsulta.Width = pnlconsulta.Width - 5
        End If
    End Sub

    Private Sub Timerdespliega_Tick(sender As Object, e As EventArgs) Handles Timerdespliega.Tick
        If pnlconsulta.Width >= 300 Then
            Timerdespliega.Enabled = False
            Label6.Visible = True
            Label5.Visible = True
            Label7.Visible = True
            PLACA.Visible = True
            MOTORISTA.Visible = True
            CAPACIDAD.Visible = True
        Else
            pnlconsulta.Width = pnlconsulta.Width + 5
        End If
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If pnlconsulta.Width = 90 Then
            Timerdespliega.Enabled = True

        ElseIf pnlconsulta.Width = 300 Then
            Timercontrae.Enabled = True

        End If

        PLACA.Enabled = True
        MOTORISTA.Enabled = True
        CAPACIDAD.Enabled = True
    End Sub

    Private Sub PLACA_KeyUp(sender As Object, e As KeyEventArgs)


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

    Private Sub MOTORISTA_KeyUp(sender As Object, e As KeyEventArgs)
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

    Private Sub CAPACIDAD_KeyUp(sender As Object, e As KeyEventArgs)
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