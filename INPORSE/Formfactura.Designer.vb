﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formfactura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.lblcobro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblt = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.npPP = New System.Windows.Forms.NumericUpDown()
        Me.DateTime1 = New System.Windows.Forms.DateTimePicker()
        Me.cmbDui = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.cmbContenedor = New System.Windows.Forms.ComboBox()
        Me.lblContenedor = New System.Windows.Forms.Label()
        Me.npCobro = New System.Windows.Forms.NumericUpDown()
        Me.Panel1.SuspendLayout()
        CType(Me.npPP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npCobro, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(852, 43)
        Me.Panel1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 11)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 27)
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
        Me.btnCerrar.Location = New System.Drawing.Point(795, 0)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(53, 39)
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Font = New System.Drawing.Font("Microsoft Tai Le", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactura.Location = New System.Drawing.Point(2, 47)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(214, 55)
        Me.lblFactura.TabIndex = 12
        Me.lblFactura.Text = "FACTURA"
        '
        'cliente
        '
        Me.cliente.AutoSize = True
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.Location = New System.Drawing.Point(7, 129)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(107, 29)
        Me.cliente.TabIndex = 13
        Me.cliente.Text = "Cliente:"
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(120, 134)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(241, 24)
        Me.cmbCliente.TabIndex = 14
        '
        'Destino
        '
        Me.Destino.AutoSize = True
        Me.Destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Destino.Location = New System.Drawing.Point(7, 178)
        Me.Destino.Name = "Destino"
        Me.Destino.Size = New System.Drawing.Size(114, 29)
        Me.Destino.TabIndex = 15
        Me.Destino.Text = "Destino:"
        '
        'cmbDestino
        '
        Me.cmbDestino.FormattingEnabled = True
        Me.cmbDestino.Location = New System.Drawing.Point(127, 186)
        Me.cmbDestino.Name = "cmbDestino"
        Me.cmbDestino.Size = New System.Drawing.Size(241, 24)
        Me.cmbDestino.TabIndex = 16
        '
        'lblasesor
        '
        Me.lblasesor.AutoSize = True
        Me.lblasesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblasesor.Location = New System.Drawing.Point(7, 241)
        Me.lblasesor.Name = "lblasesor"
        Me.lblasesor.Size = New System.Drawing.Size(106, 29)
        Me.lblasesor.TabIndex = 17
        Me.lblasesor.Text = "Asesor:"
        '
        'txtasesor
        '
        Me.txtasesor.Location = New System.Drawing.Point(127, 249)
        Me.txtasesor.Name = "txtasesor"
        Me.txtasesor.Size = New System.Drawing.Size(241, 22)
        Me.txtasesor.TabIndex = 18
        '
        'lblcabezal
        '
        Me.lblcabezal.AutoSize = True
        Me.lblcabezal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcabezal.Location = New System.Drawing.Point(-5, 301)
        Me.lblcabezal.Name = "lblcabezal"
        Me.lblcabezal.Size = New System.Drawing.Size(121, 29)
        Me.lblcabezal.TabIndex = 19
        Me.lblcabezal.Text = "Cabezal:"
        '
        'cmbCabezal
        '
        Me.cmbCabezal.FormattingEnabled = True
        Me.cmbCabezal.Location = New System.Drawing.Point(127, 306)
        Me.cmbCabezal.Name = "cmbCabezal"
        Me.cmbCabezal.Size = New System.Drawing.Size(241, 24)
        Me.cmbCabezal.TabIndex = 20
        '
        'lblMotorista
        '
        Me.lblMotorista.AutoSize = True
        Me.lblMotorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotorista.Location = New System.Drawing.Point(-2, 357)
        Me.lblMotorista.Name = "lblMotorista"
        Me.lblMotorista.Size = New System.Drawing.Size(134, 29)
        Me.lblMotorista.TabIndex = 21
        Me.lblMotorista.Text = "Motorista:"
        '
        'cmbMotorista
        '
        Me.cmbMotorista.FormattingEnabled = True
        Me.cmbMotorista.Location = New System.Drawing.Point(138, 365)
        Me.cmbMotorista.Name = "cmbMotorista"
        Me.cmbMotorista.Size = New System.Drawing.Size(241, 24)
        Me.cmbMotorista.TabIndex = 22
        '
        'btnFactura
        '
        Me.btnFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactura.Location = New System.Drawing.Point(535, 515)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(164, 65)
        Me.btnFactura.TabIndex = 23
        Me.btnFactura.Text = "Generar factura PDF"
        Me.btnFactura.UseVisualStyleBackColor = True
        '
        'lblcobro
        '
        Me.lblcobro.AutoSize = True
        Me.lblcobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcobro.Location = New System.Drawing.Point(7, 466)
        Me.lblcobro.Name = "lblcobro"
        Me.lblcobro.Size = New System.Drawing.Size(205, 29)
        Me.lblcobro.TabIndex = 24
        Me.lblcobro.Text = "Cobro del viaje:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 553)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 29)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Peso del producto:"
        '
        'lblt
        '
        Me.lblt.AutoSize = True
        Me.lblt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblt.Location = New System.Drawing.Point(7, 613)
        Me.lblt.Name = "lblt"
        Me.lblt.Size = New System.Drawing.Size(74, 29)
        Me.lblt.TabIndex = 28
        Me.lblt.Text = "total:"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(132, 613)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(0, 29)
        Me.lbltotal.TabIndex = 29
        '
        'npPP
        '
        Me.npPP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.npPP.Location = New System.Drawing.Point(264, 562)
        Me.npPP.Name = "npPP"
        Me.npPP.Size = New System.Drawing.Size(180, 18)
        Me.npPP.TabIndex = 31
        '
        'DateTime1
        '
        Me.DateTime1.Location = New System.Drawing.Point(419, 63)
        Me.DateTime1.Name = "DateTime1"
        Me.DateTime1.Size = New System.Drawing.Size(280, 22)
        Me.DateTime1.TabIndex = 32
        '
        'cmbDui
        '
        Me.cmbDui.FormattingEnabled = True
        Me.cmbDui.Location = New System.Drawing.Point(476, 137)
        Me.cmbDui.Name = "cmbDui"
        Me.cmbDui.Size = New System.Drawing.Size(241, 24)
        Me.cmbDui.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(363, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 29)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Dui:"
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(535, 210)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(241, 24)
        Me.cmbProducto.TabIndex = 36
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.Location = New System.Drawing.Point(374, 210)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(130, 29)
        Me.lblProducto.TabIndex = 35
        Me.lblProducto.Text = "Producto:"
        '
        'cmbContenedor
        '
        Me.cmbContenedor.FormattingEnabled = True
        Me.cmbContenedor.Location = New System.Drawing.Point(184, 425)
        Me.cmbContenedor.Name = "cmbContenedor"
        Me.cmbContenedor.Size = New System.Drawing.Size(241, 24)
        Me.cmbContenedor.TabIndex = 38
        '
        'lblContenedor
        '
        Me.lblContenedor.AutoSize = True
        Me.lblContenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContenedor.Location = New System.Drawing.Point(18, 417)
        Me.lblContenedor.Name = "lblContenedor"
        Me.lblContenedor.Size = New System.Drawing.Size(162, 29)
        Me.lblContenedor.TabIndex = 37
        Me.lblContenedor.Text = "Contenedor:"
        '
        'npCobro
        '
        Me.npCobro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.npCobro.Location = New System.Drawing.Point(218, 477)
        Me.npCobro.Name = "npCobro"
        Me.npCobro.Size = New System.Drawing.Size(180, 18)
        Me.npCobro.TabIndex = 39
        '
        'Formfactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 696)
        Me.Controls.Add(Me.npCobro)
        Me.Controls.Add(Me.cmbContenedor)
        Me.Controls.Add(Me.lblContenedor)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.cmbDui)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTime1)
        Me.Controls.Add(Me.npPP)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblcobro)
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
        Me.Name = "Formfactura"
        Me.Text = "Formfactura"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.npPP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npCobro, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblcobro As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblt As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents npPP As NumericUpDown
    Friend WithEvents DateTime1 As DateTimePicker
    Friend WithEvents cmbDui As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents lblProducto As Label
    Friend WithEvents cmbContenedor As ComboBox
    Friend WithEvents lblContenedor As Label
    Friend WithEvents npCobro As NumericUpDown
End Class
