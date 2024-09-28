Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class CLIENTES
    Dim conjuntoDatos As New DataSet
    Dim adaptadorDatos As New MySqlClient.MySqlDataAdapter
    Dim sentenciaSQL As String
    Dim comandoSQL As New MySqlClient.MySqlCommand

    Private Sub CLIENTES_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub ActualizarGrid()
        Try
            conjuntoDatos.Clear()
            sentenciaSQL = "Select * from CLIENTE"
            adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
            adaptadorDatos.Fill(conjuntoDatos, "CLIENTE")
            data1.DataSource = conjuntoDatos.Tables("CLIENTE")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub CLIENTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlconsulta.Width = 90

        Try
            Module1.funcionConectarBD()
            ActualizarGrid()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        tID.Visible = False
        TNombre.Visible = False
        Ttelefono.Visible = False
        Label8.Visible = False
        Label7.Visible = False
        Label6.Visible = False
    End Sub

    Private Sub data1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data1.CellContentClick
        Dim fila As Integer
        fila = e.RowIndex
        txtID.Text = data1.Rows(fila).Cells(0).Value.ToString
        txtNOM.Text = data1.Rows(fila).Cells(1).Value.ToString
        txtTEL.Text = data1.Rows(fila).Cells(2).Value.ToString
        txtDIR.Text = data1.Rows(fila).Cells(3).Value.ToString
        txtCOR.Text = data1.Rows(fila).Cells(4).Value.ToString
    End Sub

    Private Sub N1_Click(sender As Object, e As EventArgs) Handles N1.Click
        If N1.Text = "NUEVO" Then
            N1.Text = "GUARDAR"
            txtID.Enabled = True
            txtDIR.Enabled = True
            txtCOR.Enabled = True
            txtNOM.Enabled = True
            txtTEL.Enabled = True
            tID.Enabled = False
            TNombre.Enabled = False
            Ttelefono.Enabled = False
            M1.Enabled = False
            E1.Enabled = False
        Else
            Try
                sentenciaSQL = "INSERT INTO CLIENTE VALUES ('" & txtID.Text & "','" & txtNOM.Text & "','" & txtTEL.Text & "','" & txtDIR.Text & "','" & txtCOR.Text & "')"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                MessageBox.Show("El registro ha sido creado.", "Informacion", MessageBoxButtons.OK)
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            N1.Text = "NUEVO"
            txtID.Enabled = False
            txtDIR.Enabled = False
            txtCOR.Enabled = False
            txtNOM.Enabled = False
            txtTEL.Enabled = False
            tID.Enabled = False
            TNombre.Enabled = False
            Ttelefono.Enabled = False
            M1.Enabled = True
            E1.Enabled = True
        End If

    End Sub

    Private Sub M1_Click(sender As Object, e As EventArgs) Handles M1.Click
        If M1.Text = "MODIFICAR" Then
            M1.Text = "GUARDAR"
            txtID.Enabled = True
            txtDIR.Enabled = True
            txtCOR.Enabled = True
            txtNOM.Enabled = True
            txtTEL.Enabled = True
            tID.Enabled = False
            TNombre.Enabled = False
            Ttelefono.Enabled = False
            N1.Enabled = False
            E1.Enabled = False
        Else
            Try

                sentenciaSQL = "UPDATE CLIENTE SET NOMBRE='" & txtNOM.Text & "', TELEFONO='" & txtTEL.Text & "', DIRECCION='" & txtDIR.Text & "', EMAIL='" & txtCOR.Text & "' WHERE ID_CLIENTE='" & txtID.Text & "'"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                MessageBox.Show("El registro a sido modificado.", "Informacion", MessageBoxButtons.OK)
                conjuntoDatos.Clear()
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            M1.Text = "MODIFICAR"
            txtID.Enabled = False
            txtDIR.Enabled = False
            txtCOR.Enabled = False
            txtNOM.Enabled = False
            txtTEL.Enabled = False
            tID.Enabled = False
            TNombre.Enabled = False
            Ttelefono.Enabled = False
            N1.Enabled = True
            E1.Enabled = True
        End If

    End Sub

    Private Sub E1_Click(sender As Object, e As EventArgs) Handles E1.Click
        If MessageBox.Show("¿Desea eliminar un registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MessageBox.Show("Cancelado")
            txtID.Text = True
            txtNOM.Text = True
            txtTEL.Text = True
            txtDIR.Text = True
            txtCOR.Text = True
            tID.Enabled = False
            TNombre.Enabled = False
            Ttelefono.Enabled = False
            N1.Enabled = False
            M1.Enabled = False
        Else
            Dim CodigoEliminar As String
            CodigoEliminar = InputBox("Digite el codigo del registro a eliminar:", "Eliminar")
            Try
                sentenciaSQL = "DELETE FROM CLIENTE WHERE ID_CLIENTE='" & CodigoEliminar & "'"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                conjuntoDatos.Clear()
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try

            txtID.Text = False
            txtNOM.Text = False
            txtTEL.Text = False
            txtDIR.Text = False
            txtCOR.Text = False
            tID.Enabled = False
            TNombre.Enabled = False
            Ttelefono.Enabled = False
            N1.Enabled = True
            M1.Enabled = True
        End If

    End Sub

  
    Private Sub Timercontrae_Tick(sender As Object, e As EventArgs) Handles Timercontrae.Tick
        If pnlconsulta.Width <= 90 Then
            Timercontrae.Enabled = False
            Label8.Visible = False
            Label7.Visible = False
            Label6.Visible = False
            tID.Visible = False
            TNombre.Visible = False
            Ttelefono.Visible = False
        Else
            pnlconsulta.Width = pnlconsulta.Width - 5
        End If
    End Sub

    Private Sub Timerdespliega_Tick(sender As Object, e As EventArgs) Handles Timerdespliega.Tick
        If pnlconsulta.Width >= 300 Then
            Timerdespliega.Enabled = False
            Label8.Visible = True
            Label7.Visible = True
            Label6.Visible = True
            tID.Visible = True
            TNombre.Visible = True
            Ttelefono.Visible = True
        Else
            pnlconsulta.Width = pnlconsulta.Width + 5
        End If
    End Sub
   
    Private Sub CON_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If pnlconsulta.Width = 90 Then
            Timerdespliega.Enabled = True
            btnmenu.Text = "-->"
        ElseIf pnlconsulta.Width = 300 Then
            Timercontrae.Enabled = True
            btnmenu.Text = "CONSULTAR"
        End If

        tID.Enabled = True
        TNombre.Enabled = True
        Ttelefono.Enabled = True
    End Sub

    Private Sub tID_KeyUp(sender As Object, e As KeyEventArgs)
        Ttelefono.Clear()
        conjuntoDatos.Clear()
        If tID.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM CLIENTE WHERE ID_CLIENTE like '%" & tID.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "CLIENTE")
                data1.DataSource = conjuntoDatos.Tables("CLIENTE")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub

    Private Sub TNombre_KeyUp(sender As Object, e As KeyEventArgs)
        tID.Clear()
        conjuntoDatos.Clear()
        If TNombre.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM CLIENTE WHERE NOMBRE like '%" & TNombre.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "CLIENTE")
                data1.DataSource = conjuntoDatos.Tables("CLIENTE")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub

    Private Sub Ttelefono_KeyUp(sender As Object, e As KeyEventArgs)
        TNombre.Clear()
        conjuntoDatos.Clear()
        If Ttelefono.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM CLIENTE WHERE TELEFONO like '%" & Ttelefono.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "CLIENTE")
                data1.DataSource = conjuntoDatos.Tables("CLIENTE")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub

  

    
    
End Class
