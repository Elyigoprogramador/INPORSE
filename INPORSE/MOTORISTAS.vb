Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
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
    'Private Function ValidarDUI(ByVal dui As String) As Boolean

    '    Dim duiR As String = "^\d{8}-\d{1}$"

    '    If Not System.Text.RegularExpressions.Regex.IsMatch(dui, duiR) Then
    '        MessageBox.Show("Formato de DUI no válido.")
    '        Return False
    '    End If

    '    Return True
    'End Function
    Private Sub DUI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DUI.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-" Then
            e.Handled = True ' Evita que se agregue el carácter no permitido
            Return
        End If

        ' Permitir que el guion solo se escriba en la novena posición
        If e.KeyChar = "-" AndAlso DUI.Text.Length <> 8 Then
            e.Handled = True ' Evita que se agregue el guion si no está en la novena posición
        End If
    End Sub
    Private Sub DUI_TextChanged(sender As Object, e As EventArgs) Handles DUI.TextChanged
        If DUI.Text.Length > 10 Then
            DUI.Text = DUI.Text.Substring(0, 10)
            DUI.SelectionStart = DUI.Text.Length ' Coloca el cursor al final
        End If

        ' Asegurarse de que el guion esté en la posición correcta
        If DUI.Text.Length = 9 AndAlso Not DUI.Text.Contains("-") Then
            DUI.Text = DUI.Text.Insert(8, "-") ' Agrega el guion en la novena posición
            DUI.SelectionStart = DUI.Text.Length ' Coloca el cursor al final
        End If
    End Sub
    Private Sub DUI_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DUI.Validating
        Dim duiPattern As String = "^\d{8}-\d{1}$" ' Formato 00000000-0
        Dim isValid As Boolean = Regex.IsMatch(DUI.Text, duiPattern)

        If Not isValid Then
            MessageBox.Show("El DUI no tiene un formato válido. Debe ser 00000000-0.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True ' Cancela el evento si la validación falla
            DUI.Focus() ' Devuelve el foco al TextBox
        End If
    End Sub

    Private Function ValidarDatos() As Boolean

        If Not ValidarCampos() Then
            Return False
        End If

        Return True
    End Function
    Private Sub MOTORISTAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbDispo.Items.Add("SI")
        cmbDispo.Items.Add("NO")
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
        cmbDispo.Visible = False
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
            cmbDispo.Enabled = True
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
            cmbDispo.Visible = True
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
                sentenciaSQL = "INSERT INTO MOTORISTAS VALUES ('" & txtID.Text & "','" & txtNOM.Text & "','" & NL.Text & "','" & cmbDispo.Text & "','" & DUI.Text & "','" & TEL.Text & "','" & DIREC.Text & "','" & SB.Text & "')"
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
            cmbDispo.Enabled = False
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
            cmbDispo.Visible = False
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
            cmbDispo.Enabled = True
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
            cmbDispo.Visible = True
            DUI.Visible = True
            TEL.Visible = True
            DIREC.Visible = True
            SB.Visible = True
            N.Enabled = False
            btnmenu.Enabled = False
            Eliminar.Enabled = False
        Else
            Try

                sentenciaSQL = "UPDATE MOTORISTAS SET NOMBRE='" & txtNOM.Text & "', NUM_LICENCIA='" & NL.Text & "', DISPONIBILIDAD='" & cmbDispo.Text & "', DUI='" & DUI.Text & "', TELEFONO='" & TEL.Text & "', DIRECCION='" & DIREC.Text & "', SUELDO_BASE='" & SB.Text & "' WHERE ID_MOTORISTA='" & txtID.Text & "'"

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
            cmbDispo.Enabled = False
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
            cmbDispo.Visible = False
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
            cmbDispo.Enabled = True
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
            cmbDispo.Enabled = False
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

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If txtID.Text.Length > 5 Then
            txtID.Text = txtID.Text.Substring(0, 5)
            txtID.SelectionStart = txtID.Text.Length
        End If
    End Sub

    Private Sub txtNOM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNOM.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True ' Evita que se agreguen caracteres no permitidos
        End If
    End Sub

    Private Sub SB_TextChanged(sender As Object, e As EventArgs) Handles SB.TextChanged
        If SB.Text.Length > 5 Then
            SB.Text = SB.Text.Substring(0, 5)
            SB.SelectionStart = SB.Text.Length
        End If
    End Sub

    Private Sub TEL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TEL.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-" Then
            e.Handled = True ' Evita que se ingresen caracteres no permitidos
        End If
        If e.KeyChar = "-" AndAlso TEL.Text.Length <> 4 Then
            e.Handled = True ' Solo permite el guion en la 5ª posición
        End If
    End Sub

    Private Sub TEL_TextChanged(sender As Object, e As EventArgs) Handles TEL.TextChanged
        If TEL.Text.Length = 4 AndAlso Not TEL.Text.Contains("-") Then
            TEL.Text &= "-" ' Añade el guion automáticamente
            TEL.SelectionStart = TEL.Text.Length ' Coloca el cursor al final del texto
        End If

        ' Limita el texto a un formato de 0000-0000
        If TEL.Text.Length > 9 Then
            TEL.Text = TEL.Text.Substring(0, 9) ' Limita el tamaño del texto a 9 caracteres
            TEL.SelectionStart = TEL.Text.Length ' Coloca el cursor al final del texto
        End If
    End Sub

    Private Sub SB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SB.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Tnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tnombre.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tID.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class