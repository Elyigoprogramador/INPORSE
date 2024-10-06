Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class Formfactura
    Private cliente1 As String
    Private destino1 As String
    Private cobroViaje As Decimal
    Private cabezal As String
    Private motorista As String
    Private pesoProducto As Decimal
    Private total As Decimal
    Public UsuarioActual As String

    Private Sub CargarClientes()
        Try
            Dim comando As New MySqlCommand("SELECT NOMBRE FROM CLIENTE", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbCliente.Items.Clear()

            While reader.Read()
                cmbCliente.Items.Add(reader("NOMBRE").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar Clientes: " & ex.Message)
        End Try
    End Sub
    Private Sub CargarDestinos()
        Try
            Dim comando As New MySqlCommand("SELECT RUTA FROM VIAJES", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbDestino.Items.Clear()

            While reader.Read()
                cmbDestino.Items.Add(reader("RUTA").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar motoristas: " & ex.Message)
        End Try
    End Sub



    Private Sub CargarCabezales()
        Try
            Dim comando As New MySqlCommand("SELECT MARCA FROM CABEZAL", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbCabezal.Items.Clear()

            While reader.Read()
                cmbCabezal.Items.Add(reader("MARCA").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar motoristas: " & ex.Message)
        End Try
    End Sub
    Private Sub CargarMotoristas()
        Try
            Dim comando As New MySqlCommand("SELECT NOMBRE FROM MOTORISTAS", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbMotorista.Items.Clear()

            While reader.Read()
                cmbMotorista.Items.Add(reader("NOMBRE").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar motoristas: " & ex.Message)
        End Try
    End Sub

    Private Sub Formfactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtasesor.Text = Form1.NombreUsuario

        Try

            Module1.funcionConectarBD()
            CargarClientes()
            CargarMotoristas()
            CargarDestinos()
            CargarCabezales()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub
    Private Sub MostrarFactura()
        MessageBox.Show($"Factura generada:" & vbCrLf &
                        $"Cliente1: {txtasesor.Text}" & vbCrLf &
                        $"Destino1: {cmbDestino.Text}" & vbCrLf &
                        $"Cobro del viaje: {txtcobro.Text:C}" & vbCrLf &
                        $"Peso del producto: {txtPP.Text} kg" & vbCrLf &
                        $"Quién realizó la factura: {txtasesor.Text}" & vbCrLf &
                        $"Total: {lblt:C}" & vbCrLf &
                        $"Cabezal: {cmbCabezal}" & vbCrLf &
                        $"Motorista: {cmbMotorista}")
    End Sub
    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click

        cliente1 = cmbCliente.SelectedItem.ToString()
        destino1 = cmbDestino.SelectedItem.ToString()
        cobroViaje = Decimal.Parse(txtcobro.Text)
        cabezal = cmbCabezal.SelectedItem.ToString()
        motorista = cmbMotorista.SelectedItem.ToString()
        pesoProducto = Decimal.Parse(txtPP.Text)
        total = cobroViaje


        MostrarFactura()
    End Sub
End Class