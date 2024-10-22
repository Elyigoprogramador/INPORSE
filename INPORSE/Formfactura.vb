﻿Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.parser
Imports iTextSharp.text.pdf.draw
Imports iTextSharp
Imports PdfiumViewer
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.IO



Public Class Formfactura
    Private images As List(Of Image) = New List(Of Image)()
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
        Return random.Next(1000, 9999).ToString()
    End Function
    Private Sub CargarClientes()
        Try
            Dim comando As New MySqlCommand("SELECT NOMBRE FROM VIAJES", Module1.mysqlconexion)
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
            Dim comando As New MySqlCommand("SELECT ID_CLIENTE FROM VIAJES", Module1.mysqlconexion)
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

            cmbContenedor.Items.Clear()

            While reader.Read()
                cmbContenedor.Items.Add(reader("TIPO").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar contenedores: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarProducto()
        Try
            Dim comando As New MySqlCommand("SELECT NOMBRE_PRODUCTO FROM VIAJES", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbProducto.Items.Clear()

            While reader.Read()
                cmbProducto.Items.Add(reader("NOMBRE_PRODUCTO").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
        End Try
    End Sub
    Private Sub CargarTelefono()
        Try
            Dim comando As New MySqlCommand("SELECT TELEFONO FROM VIAJES", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbTel.Items.Clear()

            While reader.Read()
                cmbTel.Items.Add(reader("TELEFONO").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar Telefono: " & ex.Message)
        End Try
    End Sub
    Private Sub CargarCorreo()
        Try
            Dim comando As New MySqlCommand("SELECT EMAIL FROM VIAJES", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbCorreo.Items.Clear()

            While reader.Read()
                cmbCorreo.Items.Add(reader("EMAIL").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar Correos: " & ex.Message)
        End Try
    End Sub
    Private Sub CargarDistrito()
        Try
            Dim comando As New MySqlCommand("SELECT Zona FROM Distritos ", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbDistrito.Items.Clear()

            While reader.Read()
                cmbDistrito.Items.Add(reader("Zona").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar Zonas: " & ex.Message)
        End Try
    End Sub
    Private Sub CargarDepartamento()
        Try
            Dim comando As New MySqlCommand("SELECT Nombre FROM Destinos ", Module1.mysqlconexion)
            Dim reader As MySqlDataReader = comando.ExecuteReader()

            cmbDestino.Items.Clear()

            While reader.Read()
                cmbDestino.Items.Add(reader("Nombre").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar departamentos: " & ex.Message)
        End Try
    End Sub

    Private Sub Formfactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtasesor.Text = Form1.NombreUsuario

        Try

            Module1.funcionConectarBD()
            CargarClientes()
            CargarMotoristas()
            CargarDepartamento()
            CargarDui()
            CargarCabezales()
            CargarDistrito()
            CargarProducto()
            CargarCorreo()
            CargarTelefono()
            CargarContenedor()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub





    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        Dim total As Double
        Dim cobro As Double
        Dim Destino As Double
        Dim Deca As Integer = 18
        Dim IVA As Double = 0.13
        Dim destinos As New Dictionary(Of String, Decimal) From {
        {"San Miguel", 230},
        {"Sonsonate", 30},
        {"La Libertad", 170},
        {"Santa Ana", 120},
        {"La Paz", 200},
        {"Cabañas", 155},
        {"Usulután", 110},
        {"Morazán", 135},
        {"La Unión", 260},
        {"San Vicente", 140},
        {"San Salvador", 100},
        {"Chalatenango", 210},
        {"Cuscatlán", 120},
        {"Ahuachapán", 160}
    }

        If destinos.ContainsKey(cmbDestino.Text) Then
            Destino = destinos(cmbDestino.Text)
            cobro = (Deca + Destino) * IVA
            total = (Deca + Destino) + cobro
        End If

        Dim encabezadoTable As New PdfPTable(2)
        encabezadoTable.WidthPercentage = 100
        encabezadoTable.SetWidths(New Single() {1, 3})

        Dim Fact As New PdfPTable(2)
        Fact.WidthPercentage = 100
        Fact.SetWidths(New Single() {1, 3})

        Dim codigoFac = GenerarCodigoFactura()
        Dim fechaFactura As DateTime = DateTime1.Value
        Dim fechahora As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        Dim Fechaviaje As DateTime = DateTime2.Value

        Dim rutaPDF As String = "C:\Users\josia\Downloads\Yigo prueba\FACTURAINPORSE" & codigoFac.ToString & "_" & "_" & fechahora & ".pdf"
        Dim doc As New Document(PageSize.A4, 25, 25, 10, 30)
        If Not Directory.Exists("C:\Facturas") Then
            Directory.CreateDirectory("C:\Facturas")
        End If
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(rutaPDF, FileMode.Create))
        doc.Open()

        Dim logo As iTextSharp.text.Image
        Try
            logo = iTextSharp.text.Image.GetInstance("C:\Users\josia\Downloads\Yigo prueba\LOGO_INPORSE1.PNG")
            logo.ScaleToFit(75, 75)
            logo.Alignment = Element.ALIGN_RIGHT
            encabezadoTable.AddCell(New PdfPCell(logo) With {.Border = PdfPCell.NO_BORDER})
        Catch ex As Exception
            MsgBox("Error al cargar la imagen: " & ex.Message)
            doc.Close()
            writer.Close()
            Return
        End Try

        ' Fuente
        Dim fuenteTitulo As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 28, Font.Bold, New BaseColor(0, 0, 0))
        Dim fuenteSubTitulo As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 15)
        Dim fuenteNormal As Font = FontFactory.GetFont(FontFactory.HELVETICA, 14)
        Dim fuenteNormal1 As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)
        Dim fuenteinfo As Font = FontFactory.GetFont(FontFactory.HELVETICA, 14)
        Dim CodFac As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, Font.Bold, New BaseColor(0, 0, 0))
        Dim fuentePequena As Font = FontFactory.GetFont(FontFactory.HELVETICA, 10)
        Dim FuenteDetalle As Font = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 15)

        ' Título y detalles de la empresa
        Dim empresaInfo As New PdfPTable(1)
        empresaInfo.AddCell(New PdfPCell(New Paragraph("GRUPOR INPORSE", fuenteTitulo)) With {.Border = PdfPCell.NO_BORDER, .VerticalAlignment = Element.ALIGN_TOP})
        empresaInfo.AddCell(New PdfPCell(New Paragraph("HUGO ERNESTO MORENO" &
                                                       Environment.NewLine & "Giro: Servicios de Transporte de Carga" &
                                                       Environment.NewLine & "CEPA, Puerto de Acajutla Edificio Administrativo, oficina #10." &
                                                       Environment.NewLine & "Tel: +503 7929-2463", fuenteinfo)) With {.Border = PdfPCell.NO_BORDER, .VerticalAlignment = Element.ALIGN_TOP})
        encabezadoTable.AddCell(New PdfPCell(empresaInfo) With {.Border = PdfPCell.NO_BORDER})

        doc.Add(encabezadoTable)
        Dim ESPACIO As New PdfPTable(1)
        ESPACIO.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)) With {.Border = PdfPCell.NO_BORDER})
        doc.Add(ESPACIO)
        ' Factura Exportadora
        Dim facturaTitulo As New Paragraph(1)
        doc.Add(New Paragraph("Factura", fuenteSubTitulo))
        facturaTitulo.Alignment = Element.ALIGN_LEFT
        doc.Add(facturaTitulo)
        ' Número de Factura
        Dim numeroFactura As New Paragraph("N° de factura: " &
                                           codigoFac.ToString, CodFac)
        numeroFactura.Alignment = Element.ALIGN_LEFT
        doc.Add(numeroFactura)

        ' Registro y DUI
        Dim registroDatos As New Paragraph("REGISTRO No. 
                                           25319-5" & Environment.NewLine & "DUI
                                                                          07488415-9" & Environment.NewLine & "Nit
                                                                                                               0301-060702-101-1", fuenteNormal)
        registroDatos.Alignment = Element.ALIGN_RIGHT
        doc.Add(registroDatos)

        ' Cliente y Fecha
        ' Crear una tabla de dos columnas para organizar los detalles del cliente y del viaje
        Dim tablaDetalles As New PdfPTable(2)
        tablaDetalles.WidthPercentage = 100
        tablaDetalles.SetWidths(New Single() {1, 1})

        ' Añadir los títulos "DETALLE DE Cliente" y "DETALLE DE VIAJE" en la primera fila
        tablaDetalles.AddCell(New PdfPCell(New Phrase("Detalle de Cliente", fuenteNormal1)) With {.Border = PdfPCell.NO_BORDER, .HorizontalAlignment = Element.ALIGN_LEFT})
        tablaDetalles.AddCell(New PdfPCell(New Phrase("Detalle de Viaje", fuenteNormal1)) With {.Border = PdfPCell.NO_BORDER, .HorizontalAlignment = Element.ALIGN_MIDDLE})

        ' Tabla de detalles del cliente
        Dim tablaClienteFecha As New PdfPTable(1)
        tablaClienteFecha.WidthPercentage = 100
        tablaClienteFecha.AddCell(New PdfPCell(New Phrase("Cliente:  " & cmbCliente.Text, fuenteNormal)) With {.Border = PdfPCell.NO_BORDER})
        tablaClienteFecha.AddCell(New PdfPCell(New Phrase("Correo:  " & cmbCorreo.Text, fuenteNormal)) With {.Border = PdfPCell.NO_BORDER})
        tablaClienteFecha.AddCell(New PdfPCell(New Phrase("Dui:  " & cmbDui.Text, fuenteNormal)) With {.Border = PdfPCell.NO_BORDER})
        tablaClienteFecha.AddCell(New PdfPCell(New Phrase("Telefono:  " & cmbTel.Text, fuenteNormal)) With {.Border = PdfPCell.NO_BORDER})

        ' Tabla de detalles del viaje
        Dim tablaViaje As New PdfPTable(1)
        tablaViaje.WidthPercentage = 100
        tablaViaje.AddCell(New PdfPCell(New Phrase("Departamento de Destino:  " & cmbDestino.Text & " " & cmbDistrito.Text, fuenteNormal)) With {.Border = PdfPCell.NO_BORDER})
        tablaViaje.AddCell(New PdfPCell(New Phrase("Cabezal:  " & cmbCabezal.Text, fuenteNormal)) With {.Border = PdfPCell.NO_BORDER})
        tablaViaje.AddCell(New PdfPCell(New Phrase("Motorista:  " & cmbMotorista.Text, fuenteNormal)) With {.Border = PdfPCell.NO_BORDER})
        tablaViaje.AddCell(New PdfPCell(New Phrase("Contenedor:  " & cmbContenedor.Text, fuenteNormal)) With {.Border = PdfPCell.NO_BORDER})
        tablaViaje.AddCell(New PdfPCell(New Phrase("Direccion del Contratista:  " & txtDireccion.Text, fuenteNormal)) With {.Border = PdfPCell.NO_BORDER})

        ' Añadir las tablas a las celdas de la tabla principal
        tablaDetalles.AddCell(New PdfPCell(tablaClienteFecha) With {.Border = PdfPCell.NO_BORDER})
        tablaDetalles.AddCell(New PdfPCell(tablaViaje) With {.Border = PdfPCell.NO_BORDER})

        ' Añadir la tabla principal al documento
        doc.Add(tablaDetalles)


        doc.Add(New Paragraph(" ", fuenteNormal))
        ' Detalle de la factura
        Dim tablaDetalle As New PdfPTable(4)
        tablaDetalle.WidthPercentage = 100
        tablaDetalle.SetWidths(New Single() {0.7, 3, 1, 1.2})
        tablaDetalle.AddCell(New PdfPCell(New Phrase("CANT", fuenteSubTitulo)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase("                       DESCRIPCIÓN     ", fuenteSubTitulo)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase("PRECIO UNITARIO", fuenteSubTitulo)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase("VENTAS GRAVADAS", fuenteSubTitulo)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase("10", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase("De mi choza a la casa de la anna" & Environment.NewLine & "Realizado el " & Fechaviaje.ToString("dd/MM/yyyy"), fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase("$" & Destino, fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase("$" & total, fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" " & Environment.NewLine, fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" " & Environment.NewLine, fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" " & Environment.NewLine, fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" " & Environment.NewLine, fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" " & Environment.NewLine, fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" " & Environment.NewLine, fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" " & Environment.NewLine, fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        tablaDetalle.AddCell(New PdfPCell(New Phrase(" ", fuenteNormal)))
        doc.Add(tablaDetalle)

        ' Total
        doc.Add(New Paragraph("Factura realizada por: " & txtasesor.Text, fuenteSubTitulo))
        doc.Add(New Paragraph("Total: $" & total, fuenteSubTitulo))

        ' Mensaje final
        doc.Add(New Paragraph("¡Gracias por utilizar nuestros servicios!", fuenteNormal) With {.Alignment = Element.ALIGN_CENTER})
        doc.Add(New Paragraph("info@grupoinporse.com", fuenteNormal) With {.Alignment = Element.ALIGN_RIGHT})

        doc.Close()
        MsgBox("Factura PDF generada correctamente")
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub btnimprimirfact_Click(sender As Object, e As EventArgs) Handles btnimprimirfact.Click


    End Sub
    'Private Sub LoadDocuments()
    '    ' Abre el cuadro de diálogo para seleccionar la carpeta
    '    Dim folderDialog As New FolderBrowserDialog()

    '    If folderDialog.ShowDialog() = DialogResult.OK Then
    '        ' Obtén todos los archivos de la carpeta seleccionada
    '        Dim files() As String = System.IO.Directory.GetFiles(folderDialog.SelectedPath)

    '        ' Agrega los archivos al ListBox
    '        ListBox1.Items.Clear()
    '        For Each file As String In files
    '            ListBox1.Items.Add(System.IO.Path.GetFileName(file))
    '        Next
    '    End If
    'End Sub

    Private Sub brnPDF_Click(sender As Object, e As EventArgs) Handles brnPDF.Click
        Dim rutaPDFs As String = "C:\Users\josia\Downloads\Yigo prueba\"

        If Not Directory.Exists(rutaPDFs) Then
            MessageBox.Show("La carpeta especificada no existe: " & rutaPDFs)
            Return
        End If

        ' Listar archivos PDF en la carpeta especificada
        Dim pdfFiles As String() = Directory.GetFiles(rutaPDFs, "*.pdf", SearchOption.TopDirectoryOnly)
        ListBox1.Items.Clear() ' ListBox para mostrar archivos PDF
        For Each file As String In pdfFiles
            ListBox1.Items.Add(file)
        Next
    End Sub

    Private Sub btnVistaP_Click(sender As Object, e As EventArgs) Handles btnVistaP.Click
        If ListBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Selecciona un archivo PDF para vista previa.")
            Return
        End If

        ' Establece el archivo PDF seleccionado
        Dim selectedFile As String = ListBox1.SelectedItem.ToString()
        PrintDocument1.DocumentName = selectedFile

        ' Muestra la vista previa
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem IsNot Nothing Then
            Dim selectedFile As String = ListBox1.SelectedItem.ToString()
            ' Cargar el PDF en el control WebBrowser
            WebBrowser1.Navigate(selectedFile)
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If ListBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Selecciona un archivo PDF para imprimir.")
            Return
        End If

        Dim selectedFile As String = ListBox1.SelectedItem.ToString()


        ' Configura el PrintDocument
        PrintDocument1.DocumentName = selectedFile
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub
    Private Sub btnCuadroDialogo_Click(sender As Object, e As EventArgs) Handles btnCuadroDialogo.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim selectedFile As String = PrintDocument1.DocumentName
        'e.Graphics.DrawImage("Imprimiendo: " & selectedFile.ToString, New Font("Arial", 12), Brushes.Black, 100, 100)

    End Sub
End Class