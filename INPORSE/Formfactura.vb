﻿Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports iTextSharp.text.pdf.draw
Public Class Formfactura
    Private cliente1 As String
    Private destino1 As String
    Private cobroViaje As Decimal
    Private cabezal As String
    Private motorista As String
    Private pesoProducto As Decimal
    Private total As Decimal
    Public UsuarioActual As String
    Private Function GenerarCodigoFactura() As String

        Dim random As New Random()
        Return random.Next(100000, 999999).ToString()
    End Function
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
    Private Sub CargarDui()
        Try
            Dim comando As New MySqlCommand("SELECT ID_CLIENTE FROM CLIENTE", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbDui.Items.Clear()

            While reader.Read()
                cmbDui.Items.Add(reader("ID_CLIENTE").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar dui: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarContenedor()
        Try
            Dim comando As New MySqlCommand("SELECT TIPO FROM CONTENEDOR", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbDui.Items.Clear()

            While reader.Read()
                cmbDui.Items.Add(reader("TIPO").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar contenedores: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarProducto()
        Try
            Dim comando As New MySqlCommand("SELECT NOMBRE FROM PRODUCTO", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbDui.Items.Clear()

            While reader.Read()
                cmbDui.Items.Add(reader("NOMBRE").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
        End Try
    End Sub

    Private Sub Formfactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtasesor.Text = Form1.NombreUsuario

        Try

            Module1.funcionConectarBD()
            CargarClientes()
            CargarMotoristas()
            CargarDestinos()
            CargarDui()
            CargarCabezales()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub
    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        Dim total As Double = lbltotal.Text
        Dim cobro As Double = npCobro.Value
        Dim PesoP As Double = npPP.Value

        Dim logo As iTextSharp.text.Image

        Try
            logo = iTextSharp.text.Image.GetInstance("C:\INPORSE1\logoINPORSE.jpg")
            logo.ScaleToFit(65, 65)
            logo.Alignment = Element.ALIGN_LEFT
        Catch ex As Exception
            MsgBox("Error al cargar la imagen: " & ex.Message)
            Return
        End Try

        Dim encabezadoTable As New PdfPTable(2)
        encabezadoTable.WidthPercentage = 100
        encabezadoTable.SetWidths(New Single() {1, 3})

        Dim logoCell As New PdfPCell(logo)
        logoCell.Border = PdfPCell.NO_BORDER
        logoCell.VerticalAlignment = Element.ALIGN_MIDDLE

        Dim codigoFac = GenerarCodigoFactura()
        Dim fechaFactura As DateTime = DateTime1.Value
        Dim fechahora As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")


        Dim rutaPDF As String = "C:\INPORSE1\FACTURAPDF\factura_" & codigoFac.ToString & "_" & cmbCliente.Text & "_" & fechahora & ".pdf"


        Dim doc As New Document(PageSize.A4, 25, 25, 10, 30)


        If Not Directory.Exists("C:\Facturas") Then
            Directory.CreateDirectory("C:\Facturas")
        End If


        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(rutaPDF, FileMode.Create))

        doc.Open()


        Dim fuenteTitulo As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22, Font.Bold, New BaseColor(0, 123, 255))
        Dim fuenteSubTitulo As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)
        Dim fuenteNormal As Font = FontFactory.GetFont(FontFactory.HELVETICA, 12)
        Dim fuentePequena As Font = FontFactory.GetFont(FontFactory.HELVETICA, 10)
        Dim FuenteDetalle As Font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 15)


        Dim titulo As New Paragraph("Grupo INPORSE", fuenteTitulo)
        titulo.Alignment = Element.ALIGN_LEFT
        titulo.SpacingAfter = 40
        encabezadoTable.AddCell(logoCell)
        encabezadoTable.AddCell(New PdfPCell(titulo) With {.Border = PdfPCell.NO_BORDER, .VerticalAlignment = Element.ALIGN_MIDDLE})


        doc.Add(encabezadoTable)


        Dim numeroFactura As New Paragraph("N° de factura " & codigoFac.ToString, fuenteSubTitulo)
        numeroFactura.Alignment = Element.ALIGN_LEFT
        numeroFactura.SpacingAfter = 10
        doc.Add(numeroFactura)

        doc.Add(New Paragraph("Fecha de emisión: " & fechaFactura.ToString("dd/MM/yyyy"), fuentePequena) With {.Alignment = Element.ALIGN_RIGHT})
        doc.Add(New Paragraph(" "))


        doc.Add(New Paragraph("Dirección:", fuenteSubTitulo))
        doc.Add(New Paragraph("CEPA, Puerto de Acajutla", fuenteNormal))
        doc.Add(New Paragraph("Edificio Administrativo CEPA Puerto Acajutla oficina #10.", fuenteNormal))
        doc.Add(New Paragraph(" ", fuenteNormal))


        Dim cuadro As New PdfPTable(2) With {.WidthPercentage = 100}
        cuadro.SetWidths(New Single() {1, 1})

        cuadro.AddCell(New Phrase("Cliente:" & cmbCliente.Text, fuenteNormal))
        '   cuadro.AddCell(New Phrase(cmbCliente.Text, fuenteNormal))

        cuadro.AddCell(New Phrase("Dui:" & cmbCliente.Text, fuenteNormal))
        ' cuadro.AddCell(New Phrase(cmbCliente.Text, fuenteNormal))

        cuadro.AddCell(New Phrase("Destino:" & cmbDestino.Text, fuenteNormal))
        ' cuadro.AddCell(New Phrase(cmbDestino.Text, fuenteNormal))

        cuadro.AddCell(New Phrase("Motorista:" & cmbMotorista.Text, fuenteNormal))
        ' cuadro.AddCell(New Phrase(cmbMotorista.Text, fuenteNormal))

        cuadro.AddCell(New Phrase("Cabezal utilizado:" & cmbCabezal.Text, fuenteNormal))
        ' cuadro.AddCell(New Phrase(cmbCabezal.Text, fuenteNormal))
        cuadro.AddCell(New Phrase("Contenedor Utilizado:" & cmbContenedor.Text, fuenteNormal))
        cuadro.AddCell(New Phrase("Producto transportado:" & cmbProducto.Text, fuenteNormal))
        cuadro.AddCell(New Phrase("Peso del producto:" & npCobro.Value.ToString("F2"), fuenteNormal))
        cuadro.SpacingBefore = 5
        cuadro.SpacingAfter = 5

        doc.Add(cuadro)


        doc.Add(New Chunk(New LineSeparator(1.0F, 100%, BaseColor.BLACK, Element.ALIGN_CENTER, -1)))
        doc.Add(New Paragraph(" "))
        Dim linea As New LineSeparator(1.0F, 55%, BaseColor.BLACK, Element.ALIGN_CENTER, 17)

        doc.Add(New Paragraph("Detalle de Cobro", FuenteDetalle))
        doc.Add(New Paragraph("Cobro del viaje: $" & npCobro.Value, fuenteNormal))
        doc.Add(New Chunk(linea))

        doc.Add(New Paragraph(" "))
        doc.Add(New Paragraph("Total a pagar: $" & lbltotal.Text, fuenteNormal))
        doc.Add(New Paragraph("Quien realizó la factura: " & txtasesor.Text, fuenteNormal))
        doc.Add(New Paragraph(" ", fuenteNormal))


        doc.Add(New Paragraph("info@grupoinporse.com", fuentePequena) With {.Alignment = Element.ALIGN_RIGHT})


        doc.Add(New Paragraph("¡Gracias por utilizar nuestros servicios portuarios y de transporte!", fuenteNormal) With {.Alignment = Element.ALIGN_CENTER})


        doc.Add(New Paragraph("Expertos en Operar tus servicios portuarios, logísticos y de carga desde el 2002.", fuentePequena) With {.Alignment = Element.ALIGN_CENTER})


        doc.Close()


        writer.Close()


        MsgBox("Factura PDF generada correctamente en: " & rutaPDF)
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub
End Class