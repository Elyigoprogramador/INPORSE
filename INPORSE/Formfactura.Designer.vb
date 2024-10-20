<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formfactura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formfactura))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.cliente = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.Destino = New System.Windows.Forms.Label()
        Me.cmbDestino = New System.Windows.Forms.ComboBox()
        Me.lblasesor = New System.Windows.Forms.Label()
        Me.txtasesor = New System.Windows.Forms.TextBox()
        Me.lblcabezal = New System.Windows.Forms.Label()
        Me.cmbCabezal = New System.Windows.Forms.ComboBox()
        Me.lblMotorista = New System.Windows.Forms.Label()
        Me.cmbMotorista = New System.Windows.Forms.ComboBox()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.DateTime1 = New System.Windows.Forms.DateTimePicker()
        Me.cmbDui = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.cmbContenedor = New System.Windows.Forms.ComboBox()
        Me.lblContenedor = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbCorreo = New System.Windows.Forms.ComboBox()
        Me.cmbProd = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTel = New System.Windows.Forms.ComboBox()
        Me.lbl69 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.btnimprimirfact = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PanelPDF = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(639, 36)
        Me.Panel1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "GRUPO INPORSE "
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCerrar.Location = New System.Drawing.Point(595, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 32)
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Font = New System.Drawing.Font("Microsoft Tai Le", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactura.Location = New System.Drawing.Point(2, 38)
        Me.lblFactura.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(173, 44)
        Me.lblFactura.TabIndex = 12
        Me.lblFactura.Text = "FACTURA"
        '
        'cliente
        '
        Me.cliente.AutoSize = True
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.Location = New System.Drawing.Point(5, 105)
        Me.cliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(87, 25)
        Me.cliente.TabIndex = 13
        Me.cliente.Text = "Cliente:"
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(90, 109)
        Me.cmbCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(182, 21)
        Me.cmbCliente.TabIndex = 14
        '
        'Destino
        '
        Me.Destino.AutoSize = True
        Me.Destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Destino.Location = New System.Drawing.Point(5, 145)
        Me.Destino.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Destino.Name = "Destino"
        Me.Destino.Size = New System.Drawing.Size(92, 25)
        Me.Destino.TabIndex = 15
        Me.Destino.Text = "Destino:"
        '
        'cmbDestino
        '
        Me.cmbDestino.FormattingEnabled = True
        Me.cmbDestino.Location = New System.Drawing.Point(95, 151)
        Me.cmbDestino.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbDestino.Name = "cmbDestino"
        Me.cmbDestino.Size = New System.Drawing.Size(182, 21)
        Me.cmbDestino.TabIndex = 16
        '
        'lblasesor
        '
        Me.lblasesor.AutoSize = True
        Me.lblasesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblasesor.Location = New System.Drawing.Point(4, 202)
        Me.lblasesor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblasesor.Name = "lblasesor"
        Me.lblasesor.Size = New System.Drawing.Size(87, 25)
        Me.lblasesor.TabIndex = 17
        Me.lblasesor.Text = "Asesor:"
        '
        'txtasesor
        '
        Me.txtasesor.Location = New System.Drawing.Point(95, 208)
        Me.txtasesor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtasesor.Name = "txtasesor"
        Me.txtasesor.Size = New System.Drawing.Size(182, 20)
        Me.txtasesor.TabIndex = 18
        '
        'lblcabezal
        '
        Me.lblcabezal.AutoSize = True
        Me.lblcabezal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcabezal.Location = New System.Drawing.Point(-4, 245)
        Me.lblcabezal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcabezal.Name = "lblcabezal"
        Me.lblcabezal.Size = New System.Drawing.Size(99, 25)
        Me.lblcabezal.TabIndex = 19
        Me.lblcabezal.Text = "Cabezal:"
        '
        'cmbCabezal
        '
        Me.cmbCabezal.FormattingEnabled = True
        Me.cmbCabezal.Location = New System.Drawing.Point(95, 249)
        Me.cmbCabezal.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCabezal.Name = "cmbCabezal"
        Me.cmbCabezal.Size = New System.Drawing.Size(182, 21)
        Me.cmbCabezal.TabIndex = 20
        '
        'lblMotorista
        '
        Me.lblMotorista.AutoSize = True
        Me.lblMotorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotorista.Location = New System.Drawing.Point(-2, 290)
        Me.lblMotorista.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMotorista.Name = "lblMotorista"
        Me.lblMotorista.Size = New System.Drawing.Size(108, 25)
        Me.lblMotorista.TabIndex = 21
        Me.lblMotorista.Text = "Motorista:"
        '
        'cmbMotorista
        '
        Me.cmbMotorista.FormattingEnabled = True
        Me.cmbMotorista.Location = New System.Drawing.Point(104, 297)
        Me.cmbMotorista.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMotorista.Name = "cmbMotorista"
        Me.cmbMotorista.Size = New System.Drawing.Size(182, 21)
        Me.cmbMotorista.TabIndex = 22
        '
        'btnFactura
        '
        Me.btnFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactura.Location = New System.Drawing.Point(340, 462)
        Me.btnFactura.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(123, 53)
        Me.btnFactura.TabIndex = 23
        Me.btnFactura.Text = "Generar factura PDF"
        Me.btnFactura.UseVisualStyleBackColor = True
        '
        'DateTime1
        '
        Me.DateTime1.Location = New System.Drawing.Point(314, 51)
        Me.DateTime1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTime1.Name = "DateTime1"
        Me.DateTime1.Size = New System.Drawing.Size(211, 20)
        Me.DateTime1.TabIndex = 32
        '
        'cmbDui
        '
        Me.cmbDui.FormattingEnabled = True
        Me.cmbDui.Location = New System.Drawing.Point(118, 515)
        Me.cmbDui.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbDui.Name = "cmbDui"
        Me.cmbDui.Size = New System.Drawing.Size(182, 21)
        Me.cmbDui.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 511)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Dui:"
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(118, 479)
        Me.cmbProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(182, 21)
        Me.cmbProducto.TabIndex = 36
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.Location = New System.Drawing.Point(5, 475)
        Me.lblProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(105, 25)
        Me.lblProducto.TabIndex = 35
        Me.lblProducto.Text = "Producto:"
        '
        'cmbContenedor
        '
        Me.cmbContenedor.FormattingEnabled = True
        Me.cmbContenedor.Location = New System.Drawing.Point(138, 345)
        Me.cmbContenedor.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbContenedor.Name = "cmbContenedor"
        Me.cmbContenedor.Size = New System.Drawing.Size(182, 21)
        Me.cmbContenedor.TabIndex = 38
        '
        'lblContenedor
        '
        Me.lblContenedor.AutoSize = True
        Me.lblContenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContenedor.Location = New System.Drawing.Point(2, 339)
        Me.lblContenedor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContenedor.Name = "lblContenedor"
        Me.lblContenedor.Size = New System.Drawing.Size(132, 25)
        Me.lblContenedor.TabIndex = 37
        Me.lblContenedor.Text = "Contenedor:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(5, 174)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 25)
        Me.Label15.TabIndex = 118
        Me.Label15.Text = "Correo:"
        '
        'cmbCorreo
        '
        Me.cmbCorreo.FormattingEnabled = True
        Me.cmbCorreo.Location = New System.Drawing.Point(94, 180)
        Me.cmbCorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCorreo.Name = "cmbCorreo"
        Me.cmbCorreo.Size = New System.Drawing.Size(182, 21)
        Me.cmbCorreo.TabIndex = 119
        '
        'cmbProd
        '
        Me.cmbProd.FormattingEnabled = True
        Me.cmbProd.Location = New System.Drawing.Point(138, 384)
        Me.cmbProd.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbProd.Name = "cmbProd"
        Me.cmbProd.Size = New System.Drawing.Size(182, 21)
        Me.cmbProd.TabIndex = 121
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 378)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 25)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Producto:"
        '
        'cmbTel
        '
        Me.cmbTel.FormattingEnabled = True
        Me.cmbTel.Location = New System.Drawing.Point(118, 427)
        Me.cmbTel.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTel.Name = "cmbTel"
        Me.cmbTel.Size = New System.Drawing.Size(182, 21)
        Me.cmbTel.TabIndex = 123
        '
        'lbl69
        '
        Me.lbl69.AutoSize = True
        Me.lbl69.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl69.Location = New System.Drawing.Point(10, 423)
        Me.lbl69.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl69.Name = "lbl69"
        Me.lbl69.Size = New System.Drawing.Size(104, 25)
        Me.lbl69.TabIndex = 122
        Me.lbl69.Text = "Telefono:"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnimprimirfact
        '
        Me.btnimprimirfact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimprimirfact.Location = New System.Drawing.Point(467, 462)
        Me.btnimprimirfact.Margin = New System.Windows.Forms.Padding(2)
        Me.btnimprimirfact.Name = "btnimprimirfact"
        Me.btnimprimirfact.Size = New System.Drawing.Size(123, 53)
        Me.btnimprimirfact.TabIndex = 124
        Me.btnimprimirfact.Text = "Imprimir Factura"
        Me.btnimprimirfact.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PanelPDF
        '
        Me.PanelPDF.Location = New System.Drawing.Point(351, 105)
        Me.PanelPDF.Name = "PanelPDF"
        Me.PanelPDF.Size = New System.Drawing.Size(276, 300)
        Me.PanelPDF.TabIndex = 125
        '
        'Formfactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 566)
        Me.Controls.Add(Me.PanelPDF)
        Me.Controls.Add(Me.btnimprimirfact)
        Me.Controls.Add(Me.cmbTel)
        Me.Controls.Add(Me.lbl69)
        Me.Controls.Add(Me.cmbProd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCorreo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmbContenedor)
        Me.Controls.Add(Me.lblContenedor)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.cmbDui)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTime1)
        Me.Controls.Add(Me.btnFactura)
        Me.Controls.Add(Me.cmbMotorista)
        Me.Controls.Add(Me.lblMotorista)
        Me.Controls.Add(Me.cmbCabezal)
        Me.Controls.Add(Me.lblcabezal)
        Me.Controls.Add(Me.txtasesor)
        Me.Controls.Add(Me.lblasesor)
        Me.Controls.Add(Me.cmbDestino)
        Me.Controls.Add(Me.Destino)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.lblFactura)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Formfactura"
        Me.Text = "Formfactura"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblFactura As Label
    Friend WithEvents cliente As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents Destino As Label
    Friend WithEvents cmbDestino As ComboBox
    Friend WithEvents lblasesor As Label
    Friend WithEvents txtasesor As TextBox
    Friend WithEvents lblcabezal As Label
    Friend WithEvents cmbCabezal As ComboBox
    Friend WithEvents lblMotorista As Label
    Friend WithEvents cmbMotorista As ComboBox
    Friend WithEvents btnFactura As Button
    Friend WithEvents DateTime1 As DateTimePicker
    Friend WithEvents cmbDui As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents lblProducto As Label
    Friend WithEvents cmbContenedor As ComboBox
    Friend WithEvents lblContenedor As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbCorreo As ComboBox
    Friend WithEvents cmbProd As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTel As ComboBox
    Friend WithEvents lbl69 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents btnimprimirfact As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PanelPDF As Guna.UI2.WinForms.Guna2Panel
End Class
