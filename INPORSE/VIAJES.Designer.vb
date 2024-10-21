<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VIAJES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VIAJES))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlconsulta = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TID = New System.Windows.Forms.TextBox()
        Me.ESTADO = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RUTA = New System.Windows.Forms.TextBox()
        Me.CABEZAL = New System.Windows.Forms.TextBox()
        Me.data1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timercontrae = New System.Windows.Forms.Timer(Me.components)
        Me.Timerdespliega = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.COBRO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbR = New System.Windows.Forms.ComboBox()
        Me.cmbcon = New System.Windows.Forms.ComboBox()
        Me.cmbcab = New System.Windows.Forms.ComboBox()
        Me.DateTime1 = New System.Windows.Forms.DateTimePicker()
        Me.ELIMINAR = New System.Windows.Forms.Button()
        Me.N = New System.Windows.Forms.Button()
        Me.M = New System.Windows.Forms.Button()
        Me.npCant = New System.Windows.Forms.NumericUpDown()
        Me.cmbEST = New System.Windows.Forms.ComboBox()
        Me.btnFactura = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.IDV = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.HISTORIAL = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNom = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCorreo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDui = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlconsulta.SuspendLayout()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlconsulta
        '
        Me.pnlconsulta.Controls.Add(Me.Label11)
        Me.pnlconsulta.Controls.Add(Me.btnmenu)
        Me.pnlconsulta.Controls.Add(Me.Label12)
        Me.pnlconsulta.Controls.Add(Me.TID)
        Me.pnlconsulta.Controls.Add(Me.ESTADO)
        Me.pnlconsulta.Controls.Add(Me.Label10)
        Me.pnlconsulta.Controls.Add(Me.Label13)
        Me.pnlconsulta.Controls.Add(Me.RUTA)
        Me.pnlconsulta.Controls.Add(Me.CABEZAL)
        Me.pnlconsulta.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlconsulta.Location = New System.Drawing.Point(1068, 0)
        Me.pnlconsulta.Name = "pnlconsulta"
        Me.pnlconsulta.Size = New System.Drawing.Size(255, 735)
        Me.pnlconsulta.TabIndex = 77
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(29, 294)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 16)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "RUTA:"
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
        Me.btnmenu.Location = New System.Drawing.Point(3, 3)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(42, 32)
        Me.btnmenu.TabIndex = 19
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(19, 398)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 16)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "ESTADO:"
        '
        'TID
        '
        Me.TID.BackColor = System.Drawing.Color.LavenderBlush
        Me.TID.Enabled = False
        Me.TID.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TID.ForeColor = System.Drawing.Color.Black
        Me.TID.Location = New System.Drawing.Point(110, 250)
        Me.TID.Name = "TID"
        Me.TID.Size = New System.Drawing.Size(141, 21)
        Me.TID.TabIndex = 47
        '
        'ESTADO
        '
        Me.ESTADO.BackColor = System.Drawing.Color.LavenderBlush
        Me.ESTADO.Enabled = False
        Me.ESTADO.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ESTADO.ForeColor = System.Drawing.Color.Black
        Me.ESTADO.Location = New System.Drawing.Point(110, 397)
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.Size = New System.Drawing.Size(141, 21)
        Me.ESTADO.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(19, 250)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 16)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "ID DEL VIAJE:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(19, 345)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "CABEZAL:"
        '
        'RUTA
        '
        Me.RUTA.BackColor = System.Drawing.Color.LavenderBlush
        Me.RUTA.Enabled = False
        Me.RUTA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RUTA.ForeColor = System.Drawing.Color.Black
        Me.RUTA.Location = New System.Drawing.Point(110, 299)
        Me.RUTA.Name = "RUTA"
        Me.RUTA.Size = New System.Drawing.Size(141, 21)
        Me.RUTA.TabIndex = 49
        '
        'CABEZAL
        '
        Me.CABEZAL.BackColor = System.Drawing.Color.LavenderBlush
        Me.CABEZAL.Enabled = False
        Me.CABEZAL.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CABEZAL.ForeColor = System.Drawing.Color.Black
        Me.CABEZAL.Location = New System.Drawing.Point(110, 348)
        Me.CABEZAL.Name = "CABEZAL"
        Me.CABEZAL.Size = New System.Drawing.Size(141, 21)
        Me.CABEZAL.TabIndex = 51
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
        Me.data1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column9, Me.Column10, Me.Column11, Me.Column3, Me.Column4, Me.Column8, Me.Column5, Me.Column2})
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
        Me.data1.Location = New System.Drawing.Point(15, 319)
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
        Me.data1.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightPink
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.data1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.data1.Size = New System.Drawing.Size(631, 264)
        Me.data1.TabIndex = 56
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID_VIAJE"
        Me.Column1.HeaderText = "ID DEL VIAJE"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 109
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "NOMBRE"
        Me.Column6.HeaderText = "NOMBRE"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 85
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "EMAIL"
        Me.Column9.HeaderText = "CORREO"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 87
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "TELEFONO"
        Me.Column10.HeaderText = "TELEFONO"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 94
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "ID_CLIENTE"
        Me.Column11.HeaderText = "DUI"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 52
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "RUTA"
        Me.Column3.HeaderText = "DESTINO"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 83
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "CABEZAL"
        Me.Column4.HeaderText = "CABEZAL"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 86
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "ID_CONTENEDOR"
        Me.Column8.HeaderText = "ID DEL CONTENEDOR"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 165
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "ESTADO"
        Me.Column5.HeaderText = "ESTADO"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 79
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "NOMBRE_PRODUCTO"
        Me.Column2.HeaderText = "PRODUCTO"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 103
        '
        'Timercontrae
        '
        Me.Timercontrae.Interval = 5
        '
        'Timerdespliega
        '
        Me.Timerdespliega.Interval = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(348, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "CANTIDAD:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(70, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "PRODUCTO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(17, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 13)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "ID DEL CONTENEDOR:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(30, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "DEPARTAMENTO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(104, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Dui:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(64, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "ID DEL VIAJE:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(360, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "COBRO*:"
        '
        'COBRO
        '
        Me.COBRO.BackColor = System.Drawing.Color.LavenderBlush
        Me.COBRO.Enabled = False
        Me.COBRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COBRO.ForeColor = System.Drawing.Color.Black
        Me.COBRO.Location = New System.Drawing.Point(418, 183)
        Me.COBRO.Name = "COBRO"
        Me.COBRO.Size = New System.Drawing.Size(141, 20)
        Me.COBRO.TabIndex = 97
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(359, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "ESTADO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(354, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "CABEZAL:"
        '
        'cmbR
        '
        Me.cmbR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbR.FormattingEnabled = True
        Me.cmbR.Location = New System.Drawing.Point(151, 174)
        Me.cmbR.Name = "cmbR"
        Me.cmbR.Size = New System.Drawing.Size(155, 21)
        Me.cmbR.TabIndex = 99
        '
        'cmbcon
        '
        Me.cmbcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcon.FormattingEnabled = True
        Me.cmbcon.Location = New System.Drawing.Point(151, 210)
        Me.cmbcon.Name = "cmbcon"
        Me.cmbcon.Size = New System.Drawing.Size(155, 21)
        Me.cmbcon.TabIndex = 102
        '
        'cmbcab
        '
        Me.cmbcab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcab.FormattingEnabled = True
        Me.cmbcab.Location = New System.Drawing.Point(418, 111)
        Me.cmbcab.Name = "cmbcab"
        Me.cmbcab.Size = New System.Drawing.Size(141, 21)
        Me.cmbcab.TabIndex = 104
        '
        'DateTime1
        '
        Me.DateTime1.Location = New System.Drawing.Point(848, 651)
        Me.DateTime1.Name = "DateTime1"
        Me.DateTime1.Size = New System.Drawing.Size(202, 20)
        Me.DateTime1.TabIndex = 107
        '
        'ELIMINAR
        '
        Me.ELIMINAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ELIMINAR.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ELIMINAR.ForeColor = System.Drawing.Color.White
        Me.ELIMINAR.Image = CType(resources.GetObject("ELIMINAR.Image"), System.Drawing.Image)
        Me.ELIMINAR.Location = New System.Drawing.Point(723, 12)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(84, 69)
        Me.ELIMINAR.TabIndex = 78
        Me.ELIMINAR.Text = "ELIMINAR"
        Me.ELIMINAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ELIMINAR.UseVisualStyleBackColor = False
        '
        'N
        '
        Me.N.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.N.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.N.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N.ForeColor = System.Drawing.Color.White
        Me.N.Image = CType(resources.GetObject("N.Image"), System.Drawing.Image)
        Me.N.Location = New System.Drawing.Point(842, 12)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(84, 69)
        Me.N.TabIndex = 76
        Me.N.Text = "NUEVO"
        Me.N.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.N.UseVisualStyleBackColor = False
        '
        'M
        '
        Me.M.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.M.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M.ForeColor = System.Drawing.Color.White
        Me.M.Image = CType(resources.GetObject("M.Image"), System.Drawing.Image)
        Me.M.Location = New System.Drawing.Point(613, 12)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(84, 69)
        Me.M.TabIndex = 57
        Me.M.Text = "EDITAR"
        Me.M.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.M.UseVisualStyleBackColor = False
        '
        'npCant
        '
        Me.npCant.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.npCant.Enabled = False
        Me.npCant.Location = New System.Drawing.Point(419, 72)
        Me.npCant.Name = "npCant"
        Me.npCant.Size = New System.Drawing.Size(139, 16)
        Me.npCant.TabIndex = 108
        '
        'cmbEST
        '
        Me.cmbEST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEST.FormattingEnabled = True
        Me.cmbEST.Location = New System.Drawing.Point(418, 150)
        Me.cmbEST.Name = "cmbEST"
        Me.cmbEST.Size = New System.Drawing.Size(141, 21)
        Me.cmbEST.TabIndex = 109
        '
        'btnFactura
        '
        Me.btnFactura.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.btnFactura.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFactura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFactura.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFactura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFactura.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFactura.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnFactura.ForeColor = System.Drawing.Color.White
        Me.btnFactura.Location = New System.Drawing.Point(792, 556)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnFactura.Size = New System.Drawing.Size(196, 43)
        Me.btnFactura.TabIndex = 110
        Me.btnFactura.Text = "Generar Facturar"
        '
        'IDV
        '
        Me.IDV.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IDV.DefaultText = ""
        Me.IDV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.IDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.IDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IDV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDV.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IDV.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IDV.Location = New System.Drawing.Point(151, 105)
        Me.IDV.Name = "IDV"
        Me.IDV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IDV.PlaceholderText = ""
        Me.IDV.SelectedText = ""
        Me.IDV.Size = New System.Drawing.Size(155, 19)
        Me.IDV.TabIndex = 111
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Uighur", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(688, 145)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(178, 25)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "HISTORIAL DE REGISTRO"
        '
        'HISTORIAL
        '
        Me.HISTORIAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HISTORIAL.FormattingEnabled = True
        Me.HISTORIAL.ItemHeight = 7
        Me.HISTORIAL.Location = New System.Drawing.Point(693, 174)
        Me.HISTORIAL.Margin = New System.Windows.Forms.Padding(2)
        Me.HISTORIAL.Name = "HISTORIAL"
        Me.HISTORIAL.Size = New System.Drawing.Size(233, 263)
        Me.HISTORIAL.TabIndex = 112
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(85, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 114
        Me.Label15.Text = "CORREO:"
        '
        'txtNom
        '
        Me.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNom.DefaultText = ""
        Me.txtNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNom.Location = New System.Drawing.Point(151, 16)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNom.PlaceholderText = ""
        Me.txtNom.SelectedText = ""
        Me.txtNom.Size = New System.Drawing.Size(155, 19)
        Me.txtNom.TabIndex = 115
        '
        'txtCorreo
        '
        Me.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorreo.DefaultText = ""
        Me.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCorreo.Location = New System.Drawing.Point(151, 41)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreo.PlaceholderText = ""
        Me.txtCorreo.SelectedText = ""
        Me.txtCorreo.Size = New System.Drawing.Size(155, 19)
        Me.txtCorreo.TabIndex = 117
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(12, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 13)
        Me.Label16.TabIndex = 116
        Me.Label16.Text = "NOMBRE DEL CLIENTE:"
        '
        'txtTel
        '
        Me.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTel.DefaultText = ""
        Me.txtTel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTel.Location = New System.Drawing.Point(151, 69)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTel.PlaceholderText = ""
        Me.txtTel.SelectedText = ""
        Me.txtTel.Size = New System.Drawing.Size(155, 19)
        Me.txtTel.TabIndex = 119
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(74, 75)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 13)
        Me.Label17.TabIndex = 118
        Me.Label17.Text = "TELEFONO:"
        '
        'txtDui
        '
        Me.txtDui.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDui.DefaultText = ""
        Me.txtDui.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDui.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDui.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDui.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDui.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDui.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDui.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDui.Location = New System.Drawing.Point(151, 135)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDui.PlaceholderText = ""
        Me.txtDui.SelectedText = ""
        Me.txtDui.Size = New System.Drawing.Size(155, 19)
        Me.txtDui.TabIndex = 120
        '
        'txtProd
        '
        Me.txtProd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProd.DefaultText = ""
        Me.txtProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProd.Location = New System.Drawing.Point(151, 247)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProd.PlaceholderText = ""
        Me.txtProd.SelectedText = ""
        Me.txtProd.Size = New System.Drawing.Size(155, 19)
        Me.txtProd.TabIndex = 121
        '
        'VIAJES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(1323, 735)
        Me.Controls.Add(Me.txtProd)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.HISTORIAL)
        Me.Controls.Add(Me.IDV)
        Me.Controls.Add(Me.btnFactura)
        Me.Controls.Add(Me.cmbEST)
        Me.Controls.Add(Me.npCant)
        Me.Controls.Add(Me.DateTime1)
        Me.Controls.Add(Me.cmbcab)
        Me.Controls.Add(Me.data1)
        Me.Controls.Add(Me.cmbcon)
        Me.Controls.Add(Me.cmbR)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.COBRO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ELIMINAR)
        Me.Controls.Add(Me.pnlconsulta)
        Me.Controls.Add(Me.N)
        Me.Controls.Add(Me.M)
        Me.Name = "VIAJES"
        Me.Text = "VIAJES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlconsulta.ResumeLayout(False)
        Me.pnlconsulta.PerformLayout()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlconsulta As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents btnmenu As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TID As TextBox
    Friend WithEvents ESTADO As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents RUTA As TextBox
    Friend WithEvents CABEZAL As TextBox
    Friend WithEvents N As Button
    Friend WithEvents M As Button
    Friend WithEvents data1 As DataGridView
    Friend WithEvents ELIMINAR As Button
    Friend WithEvents Timercontrae As Timer
    Friend WithEvents Timerdespliega As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents COBRO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbR As ComboBox
    Friend WithEvents cmbcon As ComboBox
    Friend WithEvents cmbcab As ComboBox
    Friend WithEvents DateTime1 As DateTimePicker
    Friend WithEvents npCant As NumericUpDown
    Friend WithEvents cmbEST As ComboBox
    Friend WithEvents btnFactura As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents IDV As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents HISTORIAL As ListBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCorreo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtDui As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
