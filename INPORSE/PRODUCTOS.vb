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
            ID.Enabled = True
            NOM.Enabled = True
            UP.Enabled = True
            Tid.Enabled = False
            Tnombre.Enabled = False
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
            Tid.Enabled = False
            Tnombre.Enabled = False
            UP.Enabled = False

            M.Enabled = True
            ELIMINAR.Enabled = True
        End If
    End Sub

    Private Sub M_Click(sender As Object, e As EventArgs) Handles M.Click
        If M.Text = "MODIFICAR" Then
            M.Text = "GUARDAR"
           ID.Enabled = True
            NOM.Enabled = True
            UP.Enabled = True
            Tid.Enabled = False
            Tnombre.Enabled = False
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
            Tid.Enabled = False
            Tnombre.Enabled = False
            N.Enabled = True
            ELIMINAR.Enabled = True
        End If
    End Sub



    Private Sub data1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data1.CellContentClick
        Dim fila As Integer
        fila = e.RowIndex
        ID.Text = data1.Rows(fila).Cells(0).Value.ToString
        NOM.Text = data1.Rows(fila).Cells(1).Value.ToString
        UP.Text = data1.Rows(fila).Cells(2).Value.ToString
    End Sub



    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        If MessageBox.Show("¿Desea eliminar un registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MessageBox.Show("Cancelado")
          ID.Enabled = True
            NOM.Enabled = True
            UP.Enabled = True

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
            Tid.Enabled = False
            Tnombre.Enabled = False
            N.Enabled = True
            ELIMINAR.Enabled = True
        End If
    End Sub

    Private Sub CON_Click(sender As Object, e As EventArgs) Handles CON.Click
        Tid.Enabled = True
        Tnombre.Enabled = True
    End Sub

    Private Sub Tid_KeyUp(sender As Object, e As KeyEventArgs) Handles Tid.KeyUp
        conjuntoDatos.Clear()
        If Tid.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM PRODUCTO WHERE ID_PRODUCTO like '%" & Tid.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "PRODUCTO")
                data1.DataSource = conjuntoDatos.Tables("PRODUCTO")
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
                sentenciaSQL = "SELECT * FROM PRODUCTO WHERE NOMBRE like '%" & Tnombre.Text & "%'"
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