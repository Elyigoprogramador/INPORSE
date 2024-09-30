Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class PRODUCTOS
    Dim conjuntoDatos As New DataSet
    Dim adaptadorDatos As New MySqlClient.MySqlDataAdapter
    Dim sentenciaSQL As String
    Dim comandoSQL As New MySqlClient.MySqlCommand
    Private Sub PRODUCTOS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub ActualizarGrid()
        Try
            conjuntoDatos.Clear()
            sentenciaSQL = "Select * from PRODUCTO"
            adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
            adaptadorDatos.Fill(conjuntoDatos, "PRODUCTO")
            data1.DataSource = conjuntoDatos.Tables("PRODUCTO")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub PRODUCTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlconsulta.Width = 90
        Try
            Module1.funcionConectarBD()
            ActualizarGrid()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        TidD.Visible = False
        TnombreE.Visible = False
        Label5.Visible = False
        Label4.Visible = False
    End Sub

    Private Sub N_Click_1(sender As Object, e As EventArgs) Handles N.Click
        If N.Text = "NUEVO" Then
            N.Text = "GUARDAR"
            ID.Enabled = True
            NOM.Enabled = True
            UP.Enabled = True
            btnmenu.Enabled = False
            TidD.Enabled = False
            TnombreE.Enabled = False
            M.Enabled = False
            ELIMINAR.Enabled = False
        Else
            Try
                sentenciaSQL = "INSERT INTO PRODUCTO VALUES ('" & ID.Text & "','" & NOM.Text & "','" & UP.Text & "')"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                MessageBox.Show("El registro ha sido creado.", "Informacion", MessageBoxButtons.OK)
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            N.Text = "NUEVO"
            ID.Enabled = False
            NOM.Enabled = False
            TidD.Enabled = False
            TnombreE.Enabled = False
            UP.Enabled = False
            btnmenu.Enabled = False
            M.Enabled = True
            ELIMINAR.Enabled = True
        End If
    End Sub

    Private Sub M_Click_1(sender As Object, e As EventArgs) Handles M.Click
        If M.Text = "MODIFICAR" Then
            M.Text = "GUARDAR"
            ID.Enabled = True
            NOM.Enabled = True
            UP.Enabled = True
            btnmenu.Enabled = False
            TidD.Enabled = False
            TnombreE.Enabled = False
            N.Enabled = False
            ELIMINAR.Enabled = False
        Else
            Try

                sentenciaSQL = "UPDATE PRODUCTO SET NOMBRE='" & NOM.Text & "', UNIDAD_PRODUCTO='" & UP.Text & "' WHERE ID_PRODUCTO='" & ID.Text & "'"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                MessageBox.Show("El registro a sido modificado.", "Informacion", MessageBoxButtons.OK)
                conjuntoDatos.Clear()
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            M.Text = "MODIFICAR"
            ID.Enabled = False
            NOM.Enabled = False
            UP.Enabled = False
            TidD.Enabled = False
            TnombreE.Enabled = False
            btnmenu.Enabled = False
            N.Enabled = True
            ELIMINAR.Enabled = True
        End If
    End Sub
    Private Sub data1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim fila As Integer
        fila = e.RowIndex
        ID.Text = data1.Rows(fila).Cells(0).Value.ToString
        NOM.Text = data1.Rows(fila).Cells(1).Value.ToString
        UP.Text = data1.Rows(fila).Cells(2).Value.ToString
    End Sub
    Private Sub ELIMINAR_Click_1(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        If MessageBox.Show("¿Desea eliminar un registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MessageBox.Show("Cancelado")
            ID.Enabled = True
            NOM.Enabled = True
            UP.Enabled = True
            btnmenu.Enabled = False
            N.Enabled = False
            ELIMINAR.Enabled = False
        Else
            Dim CodigoEliminar As String
            CodigoEliminar = InputBox("Digite el codigo del registro a eliminar:", "Eliminar")
            Try
                sentenciaSQL = "DELETE FROM PRODUCTO WHERE ID_PRODUCTO='" & CodigoEliminar & "'"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                conjuntoDatos.Clear()
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try
            ID.Enabled = False
            NOM.Enabled = False
            UP.Enabled = False
            TidD.Enabled = False
            TnombreE.Enabled = False
            btnmenu.Enabled = False
            N.Enabled = True
            ELIMINAR.Enabled = True
        End If
    End Sub



    Private Sub Timercontrae_Tick(sender As Object, e As EventArgs) Handles Timercontrae.Tick
        If pnlconsulta.Width <= 90 Then
            Timercontrae.Enabled = False
            Label5.Visible = False
            Label4.Visible = False
            TidD.Visible = False
            TnombreE.Visible = False

        Else
            pnlconsulta.Width = pnlconsulta.Width - 5
        End If
    End Sub

    Private Sub Timerdespliega_Tick(sender As Object, e As EventArgs) Handles Timerdespliega.Tick
        If pnlconsulta.Width >= 300 Then
            Timerdespliega.Enabled = False
            Label5.Visible = True
            Label4.Visible = True
            TidD.Visible = True
            TnombreE.Visible = True
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
        TidD.Enabled = True
        TnombreE.Enabled = True
    End Sub
    Private Sub CON_Click(sender As Object, e As EventArgs)
        TidD.Enabled = True
        TnombreE.Enabled = True
    End Sub

    Private Sub Tid_KeyUp(sender As Object, e As KeyEventArgs)
        conjuntoDatos.Clear()
        If TidD.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM PRODUCTO WHERE ID_PRODUCTO like '%" & TidD.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "PRODUCTO")
                data1.DataSource = conjuntoDatos.Tables("PRODUCTO")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub

    Private Sub Tnombre_KeyUp(sender As Object, e As KeyEventArgs)
        conjuntoDatos.Clear()
        If TnombreE.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM PRODUCTO WHERE NOMBRE like '%" & TnombreE.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "PRODUCTO")
                data1.DataSource = conjuntoDatos.Tables("PRODUCTO")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub


End Class