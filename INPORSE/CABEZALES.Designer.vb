<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CABEZALES
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CABEZALES))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timerdespliega = New System.Windows.Forms.Timer(Me.components)
        Me.pnlconsulta = New System.Windows.Forms.Panel()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timercontrae = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.M = New System.Windows.Forms.Button()
        Me.N = New System.Windows.Forms.Button()
        Me.data1 = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.HISTORIAL = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MEN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CC = New Guna.UI2.WinForms.Guna2TextBox()
        Me.MR = New Guna.UI2.WinForms.Guna2TextBox()
        Me.P = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PLACA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.MOTORISTA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CAPACIDAD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEstado = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pnlconsulta.SuspendLayout()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timerdespliega
        '
        Me.Timerdespliega.Interval = 5
        '
        'pnlconsulta
        '
        Me.pnlconsulta.Controls.Add(Me.CAPACIDAD)
        Me.pnlconsulta.Controls.Add(Me.PLACA)
        Me.pnlconsulta.Controls.Add(Me.MOTORISTA)
        Me.pnlconsulta.Controls.Add(Me.btnmenu)
        Me.pnlconsulta.Controls.Add(Me.Label7)
        Me.pnlconsulta.Controls.Add(Me.Label6)
        Me.pnlconsulta.Controls.Add(Me.Label5)
        Me.pnlconsulta.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlconsulta.Location = New System.Drawing.Point(925, 0)
        Me.pnlconsulta.Name = "pnlconsulta"
        Me.pnlconsulta.Size = New System.Drawing.Size(378, 609)
        Me.pnlconsulta.TabIndex = 45
        '
        'btnmenu
        '
        Me.btnmenu.BackColor = System.Drawing.Color.Transparent
        Me.btnmenu.BackgroundImage = CType(resources.GetObject("btnmenu.BackgroundImage"), System.Drawing.Image)
        Me.btnmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnmenu.FlatAppearance.BorderSize = 0
        Me.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmenu.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.ForeColor = System.Drawing.Color.White
        Me.btnmenu.Location = New System.Drawing.Point(14, 3)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(42, 32)
        Me.btnmenu.TabIndex = 25
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LavenderBlush
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(40, 382)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "CAPACIDAD DE CARGA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(155, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "PLACA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LavenderBlush
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(28, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 17)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "MOTORISTA ENCARGADO:"
        '
        'Timercontrae
        '
        Me.Timercontrae.Interval = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(301, 507)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 23)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "CAPACIDAD DE CARGA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(301, 452)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 23)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "MARCA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(301, 399)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 23)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "MOTORISTA ENCARGADO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(301, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 23)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "PLACA:"
        '
        'Eliminar
        '
        Me.Eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Eliminar.BackgroundImage = CType(resources.GetObject("Eliminar.BackgroundImage"), System.Drawing.Image)
        Me.Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Eliminar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Eliminar.ForeColor = System.Drawing.Color.White
        Me.Eliminar.Location = New System.Drawing.Point(21, 508)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(84, 69)
        Me.Eliminar.TabIndex = 36
        Me.Eliminar.Text = "ELIMINAR"
        Me.Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Eliminar.UseVisualStyleBackColor = False
        '
        'M
        '
        Me.M.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.M.BackgroundImage = CType(resources.GetObject("M.BackgroundImage"), System.Drawing.Image)
        Me.M.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.M.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.M.ForeColor = System.Drawing.Color.White
        Me.M.Location = New System.Drawing.Point(21, 431)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(84, 69)
        Me.M.TabIndex = 35
        Me.M.Text = "EDITAR"
        Me.M.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.M.UseVisualStyleBackColor = False
        '
        'N
        '
        Me.N.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.N.BackgroundImage = CType(resources.GetObject("N.BackgroundImage"), System.Drawing.Image)
        Me.N.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.N.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.N.ForeColor = System.Drawing.Color.White
        Me.N.Location = New System.Drawing.Point(21, 354)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(84, 69)
        Me.N.TabIndex = 34
        Me.N.Text = "NUEVO"
        Me.N.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.N.UseVisualStyleBackColor = False
        '
        'data1
        '
        Me.data1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.data1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.data1.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.data1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.data1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.data1.ColumnHeadersHeight = 30
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data1.DefaultCellStyle = DataGridViewCellStyle2
        Me.data1.EnableHeadersVisualStyles = False
        Me.data1.GridColor = System.Drawing.Color.White
        Me.data1.Location = New System.Drawing.Point(6, 12)
        Me.data1.Name = "data1"
        Me.data1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightPink
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PapayaWhip
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightPink
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.data1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.data1.Size = New System.Drawing.Size(607, 327)
        Me.data1.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(633, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(178, 25)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "HISTORIAL DE REGISTRO"
        '
        'HISTORIAL
        '
        Me.HISTORIAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HISTORIAL.FormattingEnabled = True
        Me.HISTORIAL.ItemHeight = 7
        Me.HISTORIAL.Location = New System.Drawing.Point(643, 43)
        Me.HISTORIAL.Margin = New System.Windows.Forms.Padding(2)
        Me.HISTORIAL.Name = "HISTORIAL"
        Me.HISTORIAL.Size = New System.Drawing.Size(161, 298)
        Me.HISTORIAL.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(301, 550)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 23)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "ESTADO:"
        '
        'MEN
        '
        Me.MEN.Animated = True
        Me.MEN.AutoRoundedCorners = True
        Me.MEN.BorderRadius = 11
        Me.MEN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MEN.DefaultText = ""
        Me.MEN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.MEN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MEN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MEN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MEN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MEN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MEN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MEN.Location = New System.Drawing.Point(570, 399)
        Me.MEN.Name = "MEN"
        Me.MEN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MEN.PlaceholderText = ""
        Me.MEN.SelectedText = ""
        Me.MEN.Size = New System.Drawing.Size(151, 25)
        Me.MEN.TabIndex = 76
        '
        'CC
        '
        Me.CC.Animated = True
        Me.CC.AutoRoundedCorners = True
        Me.CC.BorderRadius = 11
        Me.CC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CC.DefaultText = ""
        Me.CC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CC.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CC.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CC.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CC.Location = New System.Drawing.Point(559, 505)
        Me.CC.Name = "CC"
        Me.CC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CC.PlaceholderText = ""
        Me.CC.SelectedText = ""
        Me.CC.Size = New System.Drawing.Size(151, 25)
        Me.CC.TabIndex = 79
        '
        'MR
        '
        Me.MR.Animated = True
        Me.MR.AutoRoundedCorners = True
        Me.MR.BorderRadius = 11
        Me.MR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MR.DefaultText = ""
        Me.MR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.MR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MR.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MR.Location = New System.Drawing.Point(398, 452)
        Me.MR.Name = "MR"
        Me.MR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MR.PlaceholderText = ""
        Me.MR.SelectedText = ""
        Me.MR.Size = New System.Drawing.Size(151, 25)
        Me.MR.TabIndex = 80
        '
        'P
        '
        Me.P.Animated = True
        Me.P.AutoRoundedCorners = True
        Me.P.BorderRadius = 11
        Me.P.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.P.DefaultText = ""
        Me.P.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.P.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.P.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.P.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.P.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.P.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.P.Location = New System.Drawing.Point(386, 352)
        Me.P.Name = "P"
        Me.P.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.P.PlaceholderText = ""
        Me.P.SelectedText = ""
        Me.P.Size = New System.Drawing.Size(151, 25)
        Me.P.TabIndex = 81
        '
        'PLACA
        '
        Me.PLACA.Animated = True
        Me.PLACA.AutoRoundedCorners = True
        Me.PLACA.BorderRadius = 11
        Me.PLACA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PLACA.DefaultText = ""
        Me.PLACA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PLACA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PLACA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PLACA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PLACA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PLACA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PLACA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PLACA.Location = New System.Drawing.Point(215, 281)
        Me.PLACA.Name = "PLACA"
        Me.PLACA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PLACA.PlaceholderText = ""
        Me.PLACA.SelectedText = ""
        Me.PLACA.Size = New System.Drawing.Size(151, 25)
        Me.PLACA.TabIndex = 83
        '
        'MOTORISTA
        '
        Me.MOTORISTA.Animated = True
        Me.MOTORISTA.AutoRoundedCorners = True
        Me.MOTORISTA.BorderRadius = 11
        Me.MOTORISTA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MOTORISTA.DefaultText = ""
        Me.MOTORISTA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.MOTORISTA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MOTORISTA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MOTORISTA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MOTORISTA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MOTORISTA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MOTORISTA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MOTORISTA.Location = New System.Drawing.Point(215, 326)
        Me.MOTORISTA.Name = "MOTORISTA"
        Me.MOTORISTA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MOTORISTA.PlaceholderText = ""
        Me.MOTORISTA.SelectedText = ""
        Me.MOTORISTA.Size = New System.Drawing.Size(151, 25)
        Me.MOTORISTA.TabIndex = 82
        '
        'CAPACIDAD
        '
        Me.CAPACIDAD.Animated = True
        Me.CAPACIDAD.AutoRoundedCorners = True
        Me.CAPACIDAD.BorderRadius = 11
        Me.CAPACIDAD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CAPACIDAD.DefaultText = ""
        Me.CAPACIDAD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CAPACIDAD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CAPACIDAD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CAPACIDAD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CAPACIDAD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CAPACIDAD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CAPACIDAD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CAPACIDAD.Location = New System.Drawing.Point(215, 374)
        Me.CAPACIDAD.Name = "CAPACIDAD"
        Me.CAPACIDAD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CAPACIDAD.PlaceholderText = ""
        Me.CAPACIDAD.SelectedText = ""
        Me.CAPACIDAD.Size = New System.Drawing.Size(151, 25)
        Me.CAPACIDAD.TabIndex = 84
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.Color.Transparent
        Me.txtEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtEstado.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEstado.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtEstado.ItemHeight = 30
        Me.txtEstado.Location = New System.Drawing.Point(404, 541)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(160, 36)
        Me.txtEstado.TabIndex = 82
        '
        'CABEZALES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(1303, 609)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.P)
        Me.Controls.Add(Me.MR)
        Me.Controls.Add(Me.CC)
        Me.Controls.Add(Me.MEN)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.HISTORIAL)
        Me.Controls.Add(Me.pnlconsulta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.M)
        Me.Controls.Add(Me.N)
        Me.Controls.Add(Me.data1)
        Me.Name = "CABEZALES"
        Me.Text = "CABEZALES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlconsulta.ResumeLayout(False)
        Me.pnlconsulta.PerformLayout()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timerdespliega As Timer
    Friend WithEvents pnlconsulta As Panel
    Friend WithEvents btnmenu As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timercontrae As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Eliminar As Button
    Friend WithEvents M As Button
    Friend WithEvents N As Button
    Friend WithEvents data1 As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents HISTORIAL As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents MEN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CC As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents MR As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents P As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CAPACIDAD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PLACA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents MOTORISTA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEstado As Guna.UI2.WinForms.Guna2ComboBox
End Class
