Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw
Imports System.Net.Mail
Imports System.Runtime.InteropServices
Imports System.Web.UI.WebControls
Imports System.Web
Imports System.Text.RegularExpressions
Public Class VIAJES
    Private cliente1 As String
    Private destino1 As String
    Private cobroViaje As Decimal
    Private cabezal1 As String
    Private motorista As String
    Private pesoProducto As Decimal
    Private total As Decimal
    Public UsuarioActual As String
    Dim conjuntoDatos As New DataSet
    Dim adaptadorDatos As New MySqlClient.MySqlDataAdapter
    Dim sentenciaSQL As String
    Dim comandoSQL As New MySqlClient.MySqlCommand
    Private Function GenerarCodigoFactura() As String

        Dim random As New Random()
        Return random.Next(100000, 999999).ToString()
    End Function

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

    Private Sub cmbEST_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEST.SelectedIndexChanged

    End Sub
    Private Function ValidarCampos() As Boolean

        If String.IsNullOrWhiteSpace(IDV.Text) Then
            MessageBox.Show("El campo de id del viaje es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtDui.Text) Then
            MessageBox.Show("El campo de Dui es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        If String.IsNullOrWhiteSpace(txtProd.Text) Then
            MessageBox.Show("El campo de producto es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return False
        End If

        'If String.IsNullOrWhiteSpace(npCant.Value) Then
        ' MessageBox.Show("El campo de cantidad es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        '  Return False
        ' End If '
        If String.IsNullOrWhiteSpace(cmbcab.Text) Then
            MessageBox.Show("El campo de cabezal es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return False
        End If
        If String.IsNullOrWhiteSpace(cmbEST.Text) Then
            MessageBox.Show("El campo de estado es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        ' If String.IsNullOrWhiteSpace(COBRO.Text) Then
        'MessageBox.Show("El campo de cobro es obligatorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'Return False
        ' End If
        Return True
    End Function
    Private Function ValidarDUI(ByVal dui As String) As Boolean

        Dim duiR As String = "^\d{8}-\d{1}$"

        If Not System.Text.RegularExpressions.Regex.IsMatch(dui, duiR) Then
            MessageBox.Show("Formato de DUI no válido.")
            Return False
        End If

        Return True
    End Function
    Private Function ValidarCorreo(ByVal email As String) As Boolean
        Dim emailR As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(email, emailR) Then
            MessageBox.Show("Formato de correo electrónico no válido.")
            Return False
        End If
        Return True
    End Function
    Private Function ValidarTelefono(ByVal telefono As String) As Boolean
        Dim telefonoR As String = "^\d{8}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(telefono, telefonoR) Then
            MessageBox.Show("Número de teléfono no válido. Debe contener 8 dígitos.")
            Return False
        End If
        Return True
    End Function
    Private Function ValidarDatos() As Boolean

        If Not ValidarCampos() Then
            Return False
        End If
        If Not ValidarCorreo(txtCorreo.Text) Then
            Return False
        End If

        If Not ValidarTelefono(txtTel.Text) Then
            Return False
        End If

        If Not ValidarDUI(txtDui.Text) Then
            Return False
        End If

        Return True
    End Function
    Private Sub CargarIdContenedor()
        Try
            Dim comando As New MySqlCommand("SELECT TIPO FROM CONTENEDOR", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbcon.Items.Clear()

            While reader.Read()
                cmbcon.Items.Add(reader("TIPO").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar contenedor: " & ex.Message)
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
            MessageBox.Show("Error al cargar cabezales: " & ex.Message)
        End Try
    End Sub
    'Private Sub CargarIdClientes()
    '    Try
    '        Dim comando As New MySqlCommand("SELECT ID_CLIENTE FROM CLIENTE", Module1.mysqlconexion)
    '        Dim reader As MySqlDataReader = comando.ExecuteReader()

    '        cmbc.Items.Clear()

    '        While reader.Read()
    '            cmbc.Items.Add(reader("ID_CLIENTE").ToString())
    '        End While

    '        reader.Close()
    '    Catch ex As Exception
    '        MessageBox.Show("Error al cargar productos: " & ex.Message)
    '    End Try
    'End Sub
    ''Private Sub CargarIdProductos()
    '    Try
    '        Dim comando As New MySqlCommand("SELECT ID_PRODUCTO FROM PRODUCTO", Module1.mysqlconexion)
    '        Dim reader As MySqlDataReader = comando.ExecuteReader()

    '        cmbp.Items.Clear()

    '        While reader.Read()
    '            cmbp.Items.Add(reader("ID_PRODUCTO").ToString())
    '        End While

    '        reader.Close()
    '    Catch ex As Exception
    '        MessageBox.Show("Error al cargar productos: " & ex.Message)
    '    End Try
    'End Sub
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
    Private Sub CargarEstado()
        Try
            Dim comando As New MySqlCommand("SELECT ESTADO FROM CABEZAL", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbEST.Items.Clear()

            While reader.Read()
                cmbEST.Items.Add(reader("ESTADO").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar el estado: " & ex.Message)
        End Try
    End Sub


    Private Function GenerarIdViajes() As String

        Dim random As New Random()
        Return random.Next(10000, 99999).ToString()
    End Function

    Private Sub VIAJES_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Controls.Add(cmbEST)

        'txtasesor.Text = Form1.NombreUsuario
        N.FlatAppearance.BorderColor = Color.LightGreen
        M.FlatAppearance.BorderColor = Color.LightGreen
        ELIMINAR.FlatAppearance.BorderColor = Color.LightGreen
        pnlconsulta.Width = 90
        Try
            Module1.funcionConectarBD()
            ActualizarGrid()
            CargarDestinos()
            'CargarIdClientes()
            'CargarIdProductos()
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
        lblDirec.Visible = False
        txtCorreo.Visible = False
        IDV.Visible = False
        cmbR.Visible = False
        cmbcab.Visible = False
        cmbEST.Visible = False
        TxtDireccion.Visible = False
        cmbcon.Visible = False
        txtProd.Visible = False
        npCant.Visible = False
        txtNom.Visible = False
        txtTel.Visible = False
        txtDui.Visible = False
        Label16.Visible = False
        Label15.Visible = False
        Label1.Visible = False
        Label17.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label8.Visible = False
        Label7.Visible = False
        Label6.Visible = False
        Label4.Visible = False
        Label5.Visible = False

    End Sub


    Private Sub N_Click_1(sender As Object, e As EventArgs) Handles N.Click
        If N.Text = "NUEVO" Then
            N.Text = "GUARDAR"
            IDV.Visible = True
            N.Image = My.Resources.Save
            N.ImageAlign = ContentAlignment.MiddleCenter
            IDV.Enabled = False
            IDV.Text = GenerarIdViajes()
            txtCorreo.Enabled = True
            cmbR.Enabled = True
            cmbcab.Enabled = True
            cmbEST.Enabled = True

            cmbcon.Enabled = True
            txtProd.Enabled = True
            npCant.Enabled = True
            Label16.Visible = True
            Label15.Visible = True
            Label1.Visible = True
            Label17.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label8.Visible = True
            Label7.Visible = True
            Label6.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            txtCorreo.Visible = True
            lblDirec.Visible = True
            txtNom.Visible = True
            txtTel.Visible = True
            txtDui.Visible = True
            cmbR.Visible = True
            cmbcab.Visible = True
            cmbEST.Visible = True
            TxtDireccion.Visible = True
            cmbcon.Visible = True
            txtProd.Visible = True
            npCant.Visible = True
            btnmenu.Enabled = False
            M.Enabled = False
            ELIMINAR.Enabled = False
        Else
            If Not ValidarDatos() Then
                Exit Sub
            End If
            Try
                sentenciaSQL = "INSERT INTO VIAJES (ID_VIAJE, ID_CLIENTE, RUTA, CABEZAL, ID_CONTENEDOR, CANTIDAD, NOMBRE, TELEFONO, EMAIL, NOMBRE_PRODUCTO) " & " VALUES ('" & IDV.Text & "','" & txtDui.Text & "','" & cmbR.Text & "','" & cmbcab.Text & "','" & cmbcon.Text & "','" & npCant.Text & "','" & txtNom.Text & "','" & txtTel.Text & "','" & txtCorreo.Text & "', '" & txtProd.Text & "')"
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
            IDV.Visible = False
            txtNom.Visible = False
            Label16.Visible = False
            Label15.Visible = False
            Label1.Visible = False
            Label17.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label8.Visible = False
            Label7.Visible = False
            Label6.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            TxtDireccion.Visible = False
            txtCorreo.Visible = False
            txtTel.Visible = False
            txtDui.Visible = False
            cmbR.Visible = False
            cmbcab.Visible = False
            cmbEST.Visible = False
            lblDirec.Visible = False
            cmbcon.Visible = False
            txtProd.Visible = False
            npCant.Visible = False
            IDV.Enabled = False
            txtCorreo.Enabled = False
            cmbR.Enabled = False
            cmbcab.Enabled = False
            cmbEST.Enabled = False
            'COBRO.Enabled = False
            cmbcon.Enabled = False
            txtCorreo.Enabled = False
            'npCant.Enabled = False
            btnmenu.Enabled = False
            M.Enabled = True
            ELIMINAR.Enabled = True
        End If
    End Sub

    Private Sub M_Click_1(sender As Object, e As EventArgs) Handles M.Click
        If M.Text = "EDITAR" Then
            M.Text = "GUARDAR"
            IDV.Enabled = True
            IDV.Visible = True
            txtCorreo.Enabled = True
            cmbR.Enabled = True
            cmbcab.Enabled = True
            cmbEST.Enabled = True

            cmbcon.Enabled = True
            txtProd.Enabled = True
            txtNom.Visible = True
            TxtDireccion.Visible = True
            npCant.Enabled = True
            Label16.Visible = True
            Label15.Visible = True
            Label1.Visible = True
            Label17.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label8.Visible = True
            Label7.Visible = True
            Label6.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            lblDirec.Visible = True
            txtTel.Visible = True
            txtDui.Visible = True
            txtCorreo.Visible = True
            cmbR.Visible = True
            cmbcab.Visible = True
            cmbEST.Visible = True

            cmbcon.Visible = True
            txtProd.Visible = True
            npCant.Visible = True
            btnmenu.Enabled = False
            N.Enabled = False
            ELIMINAR.Enabled = False
        Else
            Try

                sentenciaSQL = "UPDATE VIAJES SET ID_CLIENTE='" & txtDui.Text & "', RUTA='" & cmbR.Text & "', CABEZAL='" & cmbcab.Text & "', Tipo_Cont='" & cmbcon.Text & "', CANTIDAD='" & npCant.Text & "', NOMBRE='" & txtNom.Text & "', TELEFONO='" & txtTel.Text & "', DIRECCION='" & txtDireccion.Text & "', EMAIL='" & txtCorreo.Text & "', NOMBRE_PRODUCTO='" & txtProd.Text & "'  WHERE ID_VIAJE='" & IDV.Text & "'"
                comandoSQL = New MySqlClient.MySqlCommand(sentenciaSQL, mysqlconexion)
                comandoSQL.ExecuteNonQuery()
                MessageBox.Show("El registro a sido modificado.", "Informacion", MessageBoxButtons.OK)
                conjuntoDatos.Clear()
                ActualizarGrid()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
            M.Text = "EDITAR"
            IDV.Visible = False
            txtNom.Visible = False
            Label16.Visible = False
            Label15.Visible = False
            Label1.Visible = False
            Label17.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label8.Visible = False
            Label7.Visible = False
            Label6.Visible = False
            Label4.Visible = False
            Label5.Visible = False

            txtCorreo.Visible = False
            txtTel.Visible = False
            txtDui.Visible = False
            cmbR.Visible = False
            cmbcab.Visible = False
            cmbEST.Visible = False
            lblDirec.Visible = False
            cmbcon.Visible = False
            txtProd.Visible = False
            npCant.Visible = False
            IDV.Enabled = False
            txtDui.Enabled = False
            cmbR.Enabled = False
            cmbcab.Enabled = False
            cmbEST.Enabled = False
            TxtDireccion.Visible = False
            cmbcon.Enabled = False
            txtProd.Enabled = False
            npCant.Enabled = False
            N.Enabled = True
            btnmenu.Enabled = False
            ELIMINAR.Enabled = True
        End If
    End Sub

    Private Sub ELIMINAR_Click_1(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        If MessageBox.Show("¿Desea eliminar un registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MessageBox.Show("Cancelado")

            IDV.Enabled = True
            txtDui.Enabled = True
            cmbR.Enabled = True
            cmbcab.Enabled = True
            cmbEST.Enabled = True

            cmbcon.Enabled = True
            txtProd.Enabled = True
            btnmenu.Enabled = True
            npCant.Enabled = True
            M.Enabled = True
            N.Enabled = True
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
            txtDui.Enabled = False
            cmbR.Enabled = False
            cmbcab.Enabled = False
            cmbEST.Enabled = False

            cmbcon.Enabled = False
            txtProd.Enabled = False
            npCant.Enabled = False
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

        ElseIf pnlconsulta.Width = 300 Then
            Timercontrae.Enabled = True

        End If
        TID.Enabled = True
        RUTA.Enabled = True
        CABEZAL.Enabled = True
        ESTADO.Enabled = True
    End Sub

    'nuevo
    Private Sub TID_KeyUp_1(sender As Object, e As KeyEventArgs) Handles TID.KeyUp
        conjuntoDatos.Clear()
        RUTA.Clear()
        CABEZAL.Clear()
        ESTADO.Clear()

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

    Private Sub RUTA_KeyUp_1(sender As Object, e As KeyEventArgs) Handles RUTA.KeyUp
        conjuntoDatos.Clear()
        TID.Clear()
        CABEZAL.Clear()
        ESTADO.Clear()

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

    Private Sub CABEZAL_KeyUp_1(sender As Object, e As KeyEventArgs) Handles CABEZAL.KeyUp
        conjuntoDatos.Clear()
        TID.Clear()
        RUTA.Clear()
        ESTADO.Clear()

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

    Private Sub ESTADO_KeyUp(sender As Object, e As KeyEventArgs) Handles ESTADO.KeyUp
        conjuntoDatos.Clear()
        TID.Clear()
        RUTA.Clear()
        CABEZAL.Clear()

        If ESTADO.Text <> "" Then
            Try
                sentenciaSQL = "SELECT * FROM VIAJES WHERE ESTADO like '%" & ESTADO.Text & "%'"
                adaptadorDatos = New MySqlDataAdapter(sentenciaSQL, mysqlconexion)
                adaptadorDatos.Fill(conjuntoDatos, "VIAJES")
                data1.DataSource = conjuntoDatos.Tables("VIAJES")
            Catch ex As Exception

            End Try
        Else
            ActualizarGrid()
        End If
    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click

        Formfactura.Show()

    End Sub
    Private Sub txtDui_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDui.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-" Then
            e.Handled = True ' Evita que se agregue el carácter no permitido
            Return
        End If

        ' Permitir que el guion solo se escriba en la novena posición
        If e.KeyChar = "-" AndAlso txtDui.Text.Length <> 8 Then
            e.Handled = True ' Evita que se agregue el guion si no está en la novena posición
        End If
    End Sub
    Private Sub txtDui_TextChanged(sender As Object, e As EventArgs) Handles txtDui.TextChanged
        If txtDui.Text.Length > 10 Then
            txtDui.Text = txtDui.Text.Substring(0, 10)
            txtDui.SelectionStart = txtDui.Text.Length ' Coloca el cursor al final
        End If

        ' Asegurarse de que el guion esté en la posición correcta
        If txtDui.Text.Length = 9 AndAlso Not txtDui.Text.Contains("-") Then
            txtDui.Text = txtDui.Text.Insert(8, "-") ' Agrega el guion en la novena posición
            txtDui.SelectionStart = txtDui.Text.Length ' Coloca el cursor al final
        End If
    End Sub

    Private Sub txtDui_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDui.Validating
        Dim duiPattern As String = "^\d{8}-\d{1}$" ' Formato 00000000-0
        Dim isValid As Boolean = Regex.IsMatch(txtDui.Text, duiPattern)

        If Not isValid Then
            MessageBox.Show("El DUI no tiene un formato válido. Debe ser 00000000-0.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True ' Cancela el evento si la validación falla
            txtDui.Focus() ' Devuelve el foco al TextBox
        End If
    End Sub

    Private Sub txtNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-" Then
            e.Handled = True ' Evita que se ingresen caracteres no permitidos
        End If
        If e.KeyChar = "-" AndAlso txtTel.Text.Length <> 4 Then
            e.Handled = True ' Solo permite el guion en la 5ª posición
        End If
    End Sub

    Private Sub txtTel_TextChanged(sender As Object, e As EventArgs) Handles txtTel.TextChanged
        If txtTel.Text.Length = 4 AndAlso Not txtTel.Text.Contains("-") Then
            txtTel.Text &= "-" ' Añade el guion automáticamente
            txtTel.SelectionStart = txtTel.Text.Length ' Coloca el cursor al final del texto
        End If

        ' Limita el texto a un formato de 0000-0000
        If txtTel.Text.Length > 9 Then
            txtTel.Text = txtTel.Text.Substring(0, 9) ' Limita el tamaño del texto a 9 caracteres
            txtTel.SelectionStart = txtTel.Text.Length ' Coloca el cursor al final del texto
        End If
    End Sub

    Private Sub txtProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProd.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub












    'Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
    '    Dim total As Double 
    '    Dim cobro As Double = npCobro.Value
    '    Dim Destino As Double = npPP.Value

    '    Dim logo As iTextSharp.text.Image

    '    Try
    '        logo = iTextSharp.text.Image.GetInstance("C:\INPORSE1\logoINPORSE.jpg")
    '        logo.ScaleToFit(65, 65)
    '        logo.Alignment = Element.ALIGN_LEFT
    '    Catch ex As Exception
    '        MsgBox("Error al cargar la imagen: " & ex.Message)
    '        Return
    '    End Try

    '    Dim encabezadoTable As New PdfPTable(2)
    '    encabezadoTable.WidthPercentage = 100
    '    encabezadoTable.SetWidths(New Single() {1, 3})

    '    Dim logoCell As New PdfPCell(logo)
    '    logoCell.Border = PdfPCell.NO_BORDER
    '    logoCell.VerticalAlignment = Element.ALIGN_MIDDLE

    '    Dim codigoFac = GenerarCodigoFactura()
    '    Dim fechaFactura As DateTime = DateTime1.Value
    '    Dim fechahora As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")


    '    Dim rutaPDF As String = "C:\INPORSE1\FACTURAPDF\factura_" & codigoFac.ToString & "_" & "_" & fechahora & ".pdf"


    '    Dim doc As New Document(PageSize.A4, 25, 25, 10, 30)


    '    If Not Directory.Exists("C:\Facturas") Then
    '        Directory.CreateDirectory("C:\Facturas")
    '    End If


    '    Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(rutaPDF, FileMode.Create))

    '    doc.Open()


    '    Dim fuenteTitulo As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22, Font.Bold, New BaseColor(0, 123, 255))
    '    Dim fuenteSubTitulo As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)
    '    Dim fuenteNormal As Font = FontFactory.GetFont(FontFactory.HELVETICA, 12)
    '    Dim fuentePequena As Font = FontFactory.GetFont(FontFactory.HELVETICA, 10)
    '    Dim FuenteDetalle As Font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 15)


    '    Dim titulo As New Paragraph("Grupo INPORSE", fuenteTitulo)
    '    titulo.Alignment = Element.ALIGN_LEFT
    '    titulo.SpacingAfter = 40
    '    encabezadoTable.AddCell(logoCell)
    '    encabezadoTable.AddCell(New PdfPCell(titulo) With {.Border = PdfPCell.NO_BORDER, .VerticalAlignment = Element.ALIGN_MIDDLE})


    '    doc.Add(encabezadoTable)


    '    Dim numeroFactura As New Paragraph("N° de factura " & codigoFac.ToString, fuenteSubTitulo)
    '    numeroFactura.Alignment = Element.ALIGN_LEFT
    '    numeroFactura.SpacingAfter = 10
    '    doc.Add(numeroFactura)

    '    doc.Add(New Paragraph("Fecha de emisión: " & fechaFactura.ToString("dd/MM/yyyy"), fuentePequena) With {.Alignment = Element.ALIGN_RIGHT})
    '    doc.Add(New Paragraph(" "))


    '    doc.Add(New Paragraph("Dirección:", fuenteSubTitulo))
    '    doc.Add(New Paragraph("CEPA, Puerto de Acajutla", fuenteNormal))
    '    doc.Add(New Paragraph("Edificio Administrativo CEPA Puerto Acajutla oficina #10.", fuenteNormal))
    '    doc.Add(New Paragraph(" ", fuenteNormal))


    '    Dim cuadro As New PdfPTable(2) With {.WidthPercentage = 100}
    '    cuadro.SetWidths(New Single() {1, 1})

    '    cuadro.AddCell(New Phrase("Cliente:" & cmbCliente.Text, fuenteNormal))
    '    '   cuadro.AddCell(New Phrase(cmbCliente.Text, fuenteNormal))

    '    cuadro.AddCell(New Phrase("Dui:" & cmbCliente.Text, fuenteNormal))
    '    ' cuadro.AddCell(New Phrase(cmbCliente.Text, fuenteNormal))

    '    cuadro.AddCell(New Phrase("Destino:" & cmbDestino.Text, fuenteNormal))
    '    ' cuadro.AddCell(New Phrase(cmbDestino.Text, fuenteNormal))

    '    cuadro.AddCell(New Phrase("Motorista:" & cmbMotorista.Text, fuenteNormal))
    '    ' cuadro.AddCell(New Phrase(cmbMotorista.Text, fuenteNormal))

    '    cuadro.AddCell(New Phrase("Cabezal utilizado:" & cmbCabezal.Text, fuenteNormal))
    '    ' cuadro.AddCell(New Phrase(cmbCabezal.Text, fuenteNormal))
    '    cuadro.AddCell(New Phrase("Contenedor Utilizado:" & cmbContenedor.Text, fuenteNormal))
    '    cuadro.AddCell(New Phrase("Producto transportado:" & cmbProducto.Text, fuenteNormal))
    '    cuadro.AddCell(New Phrase("Peso del producto:" & npCobro.Value.ToString("F2"), fuenteNormal))
    '    cuadro.SpacingBefore = 5
    '    cuadro.SpacingAfter = 5

    '    doc.Add(cuadro)


    '    doc.Add(New Chunk(New LineSeparator(1.0F, 100%, BaseColor.BLACK, Element.ALIGN_CENTER, -1)))
    '    doc.Add(New Paragraph(" "))
    '    Dim linea As New LineSeparator(1.0F, 55%, BaseColor.BLACK, Element.ALIGN_CENTER, 17)

    '    doc.Add(New Paragraph("Detalle de Cobro", FuenteDetalle))
    '    doc.Add(New Paragraph("Cobro del viaje: $" & npCobro.Value, fuenteNormal))
    '    doc.Add(New Chunk(linea))

    '    doc.Add(New Paragraph(" "))
    '    doc.Add(New Paragraph("Total a pagar: $" & lbltotal.Text, fuenteNormal))
    '    doc.Add(New Paragraph("Quien realizó la factura: " & txtasesor.Text, fuenteNormal))
    '    doc.Add(New Paragraph(" ", fuenteNormal))


    '    doc.Add(New Paragraph("info@grupoinporse.com", fuentePequena) With {.Alignment = Element.ALIGN_RIGHT})


    '    doc.Add(New Paragraph("¡Gracias por utilizar nuestros servicios portuarios y de transporte!", fuenteNormal) With {.Alignment = Element.ALIGN_CENTER})


    '    doc.Add(New Paragraph("Expertos en Operar tus servicios portuarios, logísticos y de carga desde el 2002.", fuentePequena) With {.Alignment = Element.ALIGN_CENTER})


    '    doc.Close()


    '    writer.Close()


    '    MsgBox("Factura PDF generada correctamente en: " & rutaPDF)
    'End Sub

End Class