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
        Me.Destino = New System.Windows.Forms.Label()
        Me.txtasesor = New System.Windows.Forms.TextBox()
        Me.lblcabezal = New System.Windows.Forms.Label()
        Me.lblMotorista = New System.Windows.Forms.Label()
        Me.DateTime1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblContenedor = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl69 = New System.Windows.Forms.Label()
        Me.lbl0 = New System.Windows.Forms.Label()
        Me.txtDireccion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox3 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.txtD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.npCant = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.cmbCliente = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbCorreo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbDui = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbTel = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbDistrito = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbDestino = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbCabezal = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbMotorista = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbContenedor = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbProducto = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.DateTime2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnNuevaFac = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFactura = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1263, 36)
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
        Me.btnCerrar.Location = New System.Drawing.Point(1219, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 32)
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Font = New System.Drawing.Font("Microsoft Tai Le", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactura.Location = New System.Drawing.Point(455, 39)
        Me.lblFactura.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(237, 60)
        Me.lblFactura.TabIndex = 12
        Me.lblFactura.Text = "FACTURA"
        '
        'cliente
        '
        Me.cliente.AutoSize = True
        Me.cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cliente.Location = New System.Drawing.Point(22, 151)
        Me.cliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(124, 25)
        Me.cliente.TabIndex = 13
        Me.cliente.Text = "Contratista:"
        '
        'Destino
        '
        Me.Destino.AutoSize = True
        Me.Destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Destino.Location = New System.Drawing.Point(4, 246)
        Me.Destino.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Destino.Name = "Destino"
        Me.Destino.Size = New System.Drawing.Size(154, 25)
        Me.Destino.TabIndex = 15
        Me.Destino.Text = "Departamento:"
        '
        'txtasesor
        '
        Me.txtasesor.Location = New System.Drawing.Point(965, 65)
        Me.txtasesor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtasesor.Name = "txtasesor"
        Me.txtasesor.Size = New System.Drawing.Size(182, 20)
        Me.txtasesor.TabIndex = 18
        Me.txtasesor.Visible = False
        '
        'lblcabezal
        '
        Me.lblcabezal.AutoSize = True
        Me.lblcabezal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcabezal.Location = New System.Drawing.Point(105, 118)
        Me.lblcabezal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcabezal.Name = "lblcabezal"
        Me.lblcabezal.Size = New System.Drawing.Size(99, 25)
        Me.lblcabezal.TabIndex = 19
        Me.lblcabezal.Text = "Cabezal:"
        '
        'lblMotorista
        '
        Me.lblMotorista.AutoSize = True
        Me.lblMotorista.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotorista.Location = New System.Drawing.Point(96, 168)
        Me.lblMotorista.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMotorista.Name = "lblMotorista"
        Me.lblMotorista.Size = New System.Drawing.Size(108, 25)
        Me.lblMotorista.TabIndex = 21
        Me.lblMotorista.Text = "Motorista:"
        '
        'DateTime1
        '
        Me.DateTime1.Location = New System.Drawing.Point(936, 41)
        Me.DateTime1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTime1.Name = "DateTime1"
        Me.DateTime1.Size = New System.Drawing.Size(211, 20)
        Me.DateTime1.TabIndex = 32
        Me.DateTime1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 252)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Dui:"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.Location = New System.Drawing.Point(99, 258)
        Me.lblProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(105, 25)
        Me.lblProducto.TabIndex = 35
        Me.lblProducto.Text = "Producto:"
        '
        'lblContenedor
        '
        Me.lblContenedor.AutoSize = True
        Me.lblContenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContenedor.Location = New System.Drawing.Point(72, 219)
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
        Me.Label15.Location = New System.Drawing.Point(61, 202)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 25)
        Me.Label15.TabIndex = 118
        Me.Label15.Text = "Correo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 146)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 25)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Lugar de llegada:"
        '
        'lbl69
        '
        Me.lbl69.AutoSize = True
        Me.lbl69.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl69.Location = New System.Drawing.Point(42, 299)
        Me.lbl69.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl69.Name = "lbl69"
        Me.lbl69.Size = New System.Drawing.Size(104, 25)
        Me.lbl69.TabIndex = 122
        Me.lbl69.Text = "Telefono:"
        '
        'lbl0
        '
        Me.lbl0.AutoSize = True
        Me.lbl0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl0.Location = New System.Drawing.Point(4, 198)
        Me.lbl0.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl0.Name = "lbl0"
        Me.lbl0.Size = New System.Drawing.Size(86, 25)
        Me.lbl0.TabIndex = 125
        Me.lbl0.Text = "Distrito:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Animated = True
        Me.txtDireccion.AutoRoundedCorners = True
        Me.txtDireccion.BorderRadius = 14
        Me.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDireccion.DefaultText = ""
        Me.txtDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(173, 140)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.PlaceholderText = ""
        Me.txtDireccion.SelectedText = ""
        Me.txtDireccion.Size = New System.Drawing.Size(204, 31)
        Me.txtDireccion.TabIndex = 127
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 286)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 25)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Fecha de Viaje:"
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
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-6, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(289, 44)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Datos del Cliente"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(268, 38)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(88, 83)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 131
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 64)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(257, 44)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "Datos del Viaje"
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.Image = CType(resources.GetObject("Guna2CirclePictureBox2.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(289, 34)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(88, 83)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox2.TabIndex = 133
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(2, 38)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(353, 44)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Datos del Transporte"
        '
        'Guna2CirclePictureBox3
        '
        Me.Guna2CirclePictureBox3.Image = CType(resources.GetObject("Guna2CirclePictureBox3.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox3.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal
        Me.Guna2CirclePictureBox3.ImageRotate = 0!
        Me.Guna2CirclePictureBox3.Location = New System.Drawing.Point(350, 18)
        Me.Guna2CirclePictureBox3.Name = "Guna2CirclePictureBox3"
        Me.Guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox3.Size = New System.Drawing.Size(88, 83)
        Me.Guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Guna2CirclePictureBox3.TabIndex = 135
        Me.Guna2CirclePictureBox3.TabStop = False
        '
        'txtD
        '
        Me.txtD.Animated = True
        Me.txtD.AutoRoundedCorners = True
        Me.txtD.BorderRadius = 9
        Me.txtD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtD.DefaultText = ""
        Me.txtD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtD.Location = New System.Drawing.Point(216, 302)
        Me.txtD.Name = "txtD"
        Me.txtD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtD.PlaceholderText = ""
        Me.txtD.SelectedText = ""
        Me.txtD.Size = New System.Drawing.Size(179, 20)
        Me.txtD.TabIndex = 137
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(72, 297)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 25)
        Me.Label8.TabIndex = 136
        Me.Label8.Text = "Descripción:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(2, 325)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(202, 50)
        Me.Label9.TabIndex = 138
        Me.Label9.Text = "Cantidad de trailers" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "              que viajan:"
        '
        'npCant
        '
        Me.npCant.AutoRoundedCorners = True
        Me.npCant.BackColor = System.Drawing.Color.Transparent
        Me.npCant.BorderRadius = 11
        Me.npCant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.npCant.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.npCant.Location = New System.Drawing.Point(219, 338)
        Me.npCant.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.npCant.Name = "npCant"
        Me.npCant.Size = New System.Drawing.Size(176, 24)
        Me.npCant.TabIndex = 139
        Me.npCant.UpDownButtonFillColor = System.Drawing.Color.Teal
        Me.npCant.UpDownButtonForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoRoundedCorners = True
        Me.cmbCliente.BackColor = System.Drawing.Color.Transparent
        Me.cmbCliente.BorderRadius = 17
        Me.cmbCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCliente.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCliente.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCliente.ItemHeight = 30
        Me.cmbCliente.Location = New System.Drawing.Point(151, 140)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(176, 36)
        Me.cmbCliente.TabIndex = 141
        '
        'cmbCorreo
        '
        Me.cmbCorreo.AutoRoundedCorners = True
        Me.cmbCorreo.BackColor = System.Drawing.Color.Transparent
        Me.cmbCorreo.BorderRadius = 17
        Me.cmbCorreo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCorreo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCorreo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCorreo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCorreo.ItemHeight = 30
        Me.cmbCorreo.Location = New System.Drawing.Point(152, 200)
        Me.cmbCorreo.Name = "cmbCorreo"
        Me.cmbCorreo.Size = New System.Drawing.Size(176, 36)
        Me.cmbCorreo.TabIndex = 142
        '
        'cmbDui
        '
        Me.cmbDui.AutoRoundedCorners = True
        Me.cmbDui.BackColor = System.Drawing.Color.Transparent
        Me.cmbDui.BorderRadius = 17
        Me.cmbDui.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDui.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDui.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDui.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbDui.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbDui.ItemHeight = 30
        Me.cmbDui.Location = New System.Drawing.Point(152, 252)
        Me.cmbDui.Name = "cmbDui"
        Me.cmbDui.Size = New System.Drawing.Size(176, 36)
        Me.cmbDui.TabIndex = 143
        '
        'cmbTel
        '
        Me.cmbTel.AutoRoundedCorners = True
        Me.cmbTel.BackColor = System.Drawing.Color.Transparent
        Me.cmbTel.BorderRadius = 17
        Me.cmbTel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTel.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbTel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbTel.ItemHeight = 30
        Me.cmbTel.Location = New System.Drawing.Point(151, 299)
        Me.cmbTel.Name = "cmbTel"
        Me.cmbTel.Size = New System.Drawing.Size(176, 36)
        Me.cmbTel.TabIndex = 144
        '
        'cmbDistrito
        '
        Me.cmbDistrito.AutoRoundedCorners = True
        Me.cmbDistrito.BackColor = System.Drawing.Color.Transparent
        Me.cmbDistrito.BorderRadius = 17
        Me.cmbDistrito.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDistrito.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDistrito.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDistrito.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbDistrito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbDistrito.ItemHeight = 30
        Me.cmbDistrito.Location = New System.Drawing.Point(91, 191)
        Me.cmbDistrito.Name = "cmbDistrito"
        Me.cmbDistrito.Size = New System.Drawing.Size(179, 36)
        Me.cmbDistrito.TabIndex = 145
        '
        'cmbDestino
        '
        Me.cmbDestino.AutoRoundedCorners = True
        Me.cmbDestino.BackColor = System.Drawing.Color.Transparent
        Me.cmbDestino.BorderRadius = 17
        Me.cmbDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDestino.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDestino.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDestino.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbDestino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbDestino.ItemHeight = 30
        Me.cmbDestino.Location = New System.Drawing.Point(154, 235)
        Me.cmbDestino.Name = "cmbDestino"
        Me.cmbDestino.Size = New System.Drawing.Size(179, 36)
        Me.cmbDestino.TabIndex = 146
        '
        'cmbCabezal
        '
        Me.cmbCabezal.AutoRoundedCorners = True
        Me.cmbCabezal.BackColor = System.Drawing.Color.Transparent
        Me.cmbCabezal.BorderRadius = 17
        Me.cmbCabezal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCabezal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCabezal.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCabezal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCabezal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCabezal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCabezal.ItemHeight = 30
        Me.cmbCabezal.Location = New System.Drawing.Point(219, 107)
        Me.cmbCabezal.Name = "cmbCabezal"
        Me.cmbCabezal.Size = New System.Drawing.Size(176, 36)
        Me.cmbCabezal.TabIndex = 147
        '
        'cmbMotorista
        '
        Me.cmbMotorista.AutoRoundedCorners = True
        Me.cmbMotorista.BackColor = System.Drawing.Color.Transparent
        Me.cmbMotorista.BorderRadius = 17
        Me.cmbMotorista.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMotorista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMotorista.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMotorista.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMotorista.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMotorista.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbMotorista.ItemHeight = 30
        Me.cmbMotorista.Location = New System.Drawing.Point(219, 157)
        Me.cmbMotorista.Name = "cmbMotorista"
        Me.cmbMotorista.Size = New System.Drawing.Size(176, 36)
        Me.cmbMotorista.TabIndex = 148
        '
        'cmbContenedor
        '
        Me.cmbContenedor.AutoRoundedCorners = True
        Me.cmbContenedor.BackColor = System.Drawing.Color.Transparent
        Me.cmbContenedor.BorderRadius = 17
        Me.cmbContenedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbContenedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbContenedor.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbContenedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbContenedor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbContenedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbContenedor.ItemHeight = 30
        Me.cmbContenedor.Location = New System.Drawing.Point(219, 208)
        Me.cmbContenedor.Name = "cmbContenedor"
        Me.cmbContenedor.Size = New System.Drawing.Size(176, 36)
        Me.cmbContenedor.TabIndex = 149
        '
        'cmbProducto
        '
        Me.cmbProducto.AutoRoundedCorners = True
        Me.cmbProducto.BackColor = System.Drawing.Color.Transparent
        Me.cmbProducto.BorderRadius = 17
        Me.cmbProducto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProducto.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbProducto.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbProducto.ItemHeight = 30
        Me.cmbProducto.Location = New System.Drawing.Point(216, 260)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(176, 36)
        Me.cmbProducto.TabIndex = 150
        '
        'DateTime2
        '
        Me.DateTime2.Animated = True
        Me.DateTime2.AutoRoundedCorners = True
        Me.DateTime2.BorderRadius = 10
        Me.DateTime2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.DateTime2.Checked = True
        Me.DateTime2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateTime2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTime2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateTime2.Location = New System.Drawing.Point(173, 293)
        Me.DateTime2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTime2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTime2.Name = "DateTime2"
        Me.DateTime2.Size = New System.Drawing.Size(217, 22)
        Me.DateTime2.TabIndex = 151
        Me.DateTime2.Value = New Date(2024, 10, 22, 0, 2, 38, 163)
        '
        'btnNuevaFac
        '
        Me.btnNuevaFac.Animated = True
        Me.btnNuevaFac.AutoRoundedCorners = True
        Me.btnNuevaFac.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevaFac.BorderRadius = 29
        Me.btnNuevaFac.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNuevaFac.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNuevaFac.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNuevaFac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNuevaFac.FillColor = System.Drawing.Color.Black
        Me.btnNuevaFac.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaFac.ForeColor = System.Drawing.Color.White
        Me.btnNuevaFac.Location = New System.Drawing.Point(251, 464)
        Me.btnNuevaFac.Name = "btnNuevaFac"
        Me.btnNuevaFac.Size = New System.Drawing.Size(175, 61)
        Me.btnNuevaFac.TabIndex = 152
        Me.btnNuevaFac.Text = "Nueva Factura"
        Me.btnNuevaFac.UseTransparentBackground = True
        '
        'btnFactura
        '
        Me.btnFactura.Animated = True
        Me.btnFactura.AutoRoundedCorners = True
        Me.btnFactura.BackColor = System.Drawing.Color.Transparent
        Me.btnFactura.BorderRadius = 29
        Me.btnFactura.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFactura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFactura.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFactura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFactura.FillColor = System.Drawing.Color.Black
        Me.btnFactura.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactura.ForeColor = System.Drawing.Color.White
        Me.btnFactura.Location = New System.Drawing.Point(480, 464)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(175, 61)
        Me.btnFactura.TabIndex = 153
        Me.btnFactura.Text = "Generar Factura PDF"
        Me.btnFactura.UseTransparentBackground = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmbCliente)
        Me.Panel2.Controls.Add(Me.cliente)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.lbl69)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panel2.Controls.Add(Me.cmbCorreo)
        Me.Panel2.Controls.Add(Me.cmbDui)
        Me.Panel2.Controls.Add(Me.cmbTel)
        Me.Panel2.Location = New System.Drawing.Point(0, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(356, 345)
        Me.Panel2.TabIndex = 154
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmbDestino)
        Me.Panel3.Controls.Add(Me.cmbDistrito)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.DateTime2)
        Me.Panel3.Controls.Add(Me.txtDireccion)
        Me.Panel3.Controls.Add(Me.lbl0)
        Me.Panel3.Controls.Add(Me.Destino)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Panel3.Location = New System.Drawing.Point(389, 113)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(391, 343)
        Me.Panel3.TabIndex = 155
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cmbProducto)
        Me.Panel4.Controls.Add(Me.cmbContenedor)
        Me.Panel4.Controls.Add(Me.cmbMotorista)
        Me.Panel4.Controls.Add(Me.cmbCabezal)
        Me.Panel4.Controls.Add(Me.npCant)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.txtD)
        Me.Panel4.Controls.Add(Me.Guna2CirclePictureBox3)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.lblContenedor)
        Me.Panel4.Controls.Add(Me.lblProducto)
        Me.Panel4.Controls.Add(Me.lblMotorista)
        Me.Panel4.Controls.Add(Me.lblcabezal)
        Me.Panel4.Location = New System.Drawing.Point(796, 113)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(441, 379)
        Me.Panel4.TabIndex = 156
        '
        'Formfactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 538)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnFactura)
        Me.Controls.Add(Me.btnNuevaFac)
        Me.Controls.Add(Me.DateTime1)
        Me.Controls.Add(Me.txtasesor)
        Me.Controls.Add(Me.lblFactura)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Formfactura"
        Me.Text = "Formfactura"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblFactura As Label
    Friend WithEvents cliente As Label
    Friend WithEvents Destino As Label
    Friend WithEvents txtasesor As TextBox
    Friend WithEvents lblcabezal As Label
    Friend WithEvents lblMotorista As Label
    Friend WithEvents DateTime1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents lblContenedor As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl69 As Label
    Friend WithEvents lbl0 As Label
    Friend WithEvents txtDireccion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2CirclePictureBox3 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents txtD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents npCant As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents cmbCliente As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbCorreo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbDui As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbTel As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbDistrito As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbDestino As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbCabezal As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbMotorista As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbContenedor As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbProducto As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents DateTime2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnNuevaFac As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFactura As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
