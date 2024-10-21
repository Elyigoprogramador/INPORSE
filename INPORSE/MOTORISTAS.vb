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
    Private Function ValidarCampos() As Boolean

        If String.IsNullOrWhiteSpace(txtNOM.Text) Then
            MessageBox.Show("El campo de nombre es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtID.Text) Then
            MessageBox.Show("El campo de ID es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If


        If String.IsNullOrWhiteSpace(NL.Text) Then
            MessageBox.Show("El campo de licencia es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtID.Text) Then
            MessageBox.Show("El campo de ID es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(DUI.Text) Then
            MessageBox.Show("El campo de Dui es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return False
        End If
        If String.IsNullOrWhiteSpace(TEL.Text) Then
            MessageBox.Show("El campo de Telefono es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return False
        End If
        If String.IsNullOrWhiteSpace(DIREC.Text) Then
            MessageBox.Show("El campo de Dirección es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(SB.Text) Then
            MessageBox.Show("El campo de sueldo base es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
    Private Sub MOTORISTAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlconsulta.Width = 90
        Try
            Module1.funcionConectarBD()
            ActualizarGrid()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Label11.Visible = False
        Label10.Visible = False
        Label9.Visible = False
        tID.Visible = False
        Tnombre.Visible = False
        Tlicencia.Visible = False
        txtID.Visible = False
        txtNOM.Visible = False
        NL.Visible = False
        DISPO.Visible = False
        DUI.Visible = False
        TEL.Visible = False
        DIREC.Visible = False
        SB.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label8.Visible = False
        Label7.Visible = False
        Label6.Visible = False
    End Sub

    Private Sub MOTORISTAS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub N_Click_1(sender As Object, e As EventArgs) Handles N.Click
        If N.Text = "NUEVO" Then
            N.Text = "GUARDAR"
            N.Image = My.Resources.Save
            N.ImageAlign = ContentAlignment.MiddleCenter
            txtID.Enabled = True
            txtNOM.Enabled = True
            NL.Enabled = True
            DISPO.Enabled = True
            DUI.Enabled = True
            TEL.Enabled = True
            DIREC.Enabled = True
            SB.Enabled = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label8.Visible = True
            Label7.Visible = True
            Label6.Visible = True
            txtID.Visible = True
            txtNOM.Visible = True
            NL.Visible = True
            DISPO.Visible = True
            DUI.Visible = True
            TEL.Visible = True
            DIREC.Visible = True
            SB.Visible = True
            M.Enabled = False
            btnmenu.Enabled = False
            Eliminar.Enabled = False
        Else
            If Not ValidarDatos() Then
                Exit Sub
            End If
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
            N.Image = My.Resources.Add_properties
            N.ImageAlign = ContentAlignment.MiddleCenter
            txtID.Enabled = False
            txtNOM.Enabled = False
            NL.Enabled = False
            DISPO.Enabled = False
            DUI.Enabled = False
            TEL.Enabled = False
            DIREC.Enabled = False
            SB.Enabled = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label8.Visible = False
            Label7.Visible = False
            Label6.Visible = False
            txtID.Visible = False
            txtNOM.Visible = False
            NL.Visible = False
            DISPO.Visible = False
            DUI.Visible = False
            TEL.Visible = False
            DIREC.Visible = False
            SB.Visible = False
            btnmenu.Enabled = False
            M.Enabled = True
            Eliminar.Enabled = True
        End If
    End Sub

    Private Sub M_Click_1(sender As Object, e As EventArgs) Handles M.Click
        If M.Text = "EDITAR" Then
            M.Text = "GUARDAR"
            txtID.Enabled = True
            txtNOM.Enabled = True
            NL.Enabled = True
            DISPO.Enabled = True
            DUI.Enabled = True
            TEL.Enabled = True
            DIREC.Enabled = True
            SB.Enabled = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label8.Visible = True
            Label7.Visible = True
            Label6.Visible = True
            txtID.Visible = True
            txtNOM.Visible = True
            NL.Visible = True
            DISPO.Visible = True
            DUI.Visible = True
            TEL.Visible = True
            DIREC.Visible = True
            SB.Visible = True
            N.Enabled = False
            btnmenu.Enabled = False
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
            M.Text = "EDITAR"
            txtID.Enabled = False
            txtNOM.Enabled = False
            NL.Enabled = False
            DISPO.Enabled = False
            DUI.Enabled = False
            TEL.Enabled = False
            DIREC.Enabled = False
            SB.Enabled = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label8.Visible = False
            Label7.Visible = False
            Label6.Visible = False
            txtID.Visible = False
            txtNOM.Visible = False
            NL.Visible = False
            DISPO.Visible = False
            DUI.Visible = False
            TEL.Visible = False
            DIREC.Visible = False
            SB.Visible = False
            btnmenu.Enabled = False
            N.Enabled = True
            Eliminar.Enabled = True
        End If
    End Sub

    Private Sub Eliminar_Click_1(sender As Object, e As EventArgs) Handles Eliminar.Click
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
            N.Enabled = True
            btnmenu.Enabled = True
            M.Enabled = True
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
            btnmenu.Enabled = False
            N.Enabled = True
            M.Enabled = True
        End If
    End Sub

    Private Sub Timercontrae_Tick(sender As Object, e As EventArgs) Handles Timercontrae.Tick
        If pnlconsulta.Width <= 90 Then
            Timercontrae.Enabled = False
            Label11.Visible = False
            Label10.Visible = False
            Label9.Visible = False
            tID.Visible = False
            Tnombre.Visible = False
            Tlicencia.Visible = False
        Else
            pnlconsulta.Width = pnlconsulta.Width - 5
        End If
    End Sub

    Private Sub Timerdespliega_Tick(sender As Object, e As EventArgs) Handles Timerdespliega.Tick
        If pnlconsulta.Width >= 300 Then
            Timerdespliega.Enabled = False
            Label11.Visible = True
            Label10.Visible = True
            Label9.Visible = True
            tID.Visible = True
            Tnombre.Visible = True
            Tlicencia.Visible = True
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
        tID.Enabled = True
        Tnombre.Enabled = True
        Tlicencia.Enabled = True
    End Sub


    'nuevo
    Private Sub tID_KeyUp_1(sender As Object, e As KeyEventArgs) Handles tID.KeyUp
        conjuntoDatos.Clear()
        Tnombre.Clear()
        Tlicencia.Clear()

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

    Private Sub Tnombre_KeyUp_1(sender As Object, e As KeyEventArgs) Handles Tnombre.KeyUp
        conjuntoDatos.Clear()
        tID.Clear()
        Tlicencia.Clear()

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

    Private Sub Tlicencia_KeyUp_1(sender As Object, e As KeyEventArgs) Handles Tlicencia.KeyUp
        conjuntoDatos.Clear()
        tID.Clear()
        Tnombre.Clear()

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