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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.N = New System.Windows.Forms.Button()
        Me.M = New System.Windows.Forms.Button()
        Me.data1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ELIMINAR = New System.Windows.Forms.Button()
        Me.Timercontrae = New System.Windows.Forms.Timer(Me.components)
        Me.Timerdespliega = New System.Windows.Forms.Timer(Me.components)
        Me.HISTORIAL = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CANTIDAD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.COBRO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EST = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbR = New System.Windows.Forms.ComboBox()
        Me.cmbc = New System.Windows.Forms.ComboBox()
        Me.cmbcon = New System.Windows.Forms.ComboBox()
        Me.cmbp = New System.Windows.Forms.ComboBox()
        Me.cmbcab = New System.Windows.Forms.ComboBox()
        Me.IDV = New System.Windows.Forms.TextBox()
        Me.pnlconsulta.SuspendLayout()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnmenu.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnmenu.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.ForeColor = System.Drawing.Color.White
        Me.btnmenu.Location = New System.Drawing.Point(3, 3)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(83, 29)
        Me.btnmenu.TabIndex = 19
        Me.btnmenu.Text = "CONSULTAR"
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
        'N
        '
        Me.N.BackColor = System.Drawing.Color.MidnightBlue
        Me.N.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N.ForeColor = System.Drawing.Color.White
        Me.N.Location = New System.Drawing.Point(201, 592)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(302, 36)
        Me.N.TabIndex = 76
        Me.N.Text = "NUEVO"
        Me.N.UseVisualStyleBackColor = False
        '
        'M
        '
        Me.M.BackColor = System.Drawing.Color.MidnightBlue
        Me.M.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M.ForeColor = System.Drawing.Color.White
        Me.M.Location = New System.Drawing.Point(12, 332)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(92, 31)
        Me.M.TabIndex = 57
        Me.M.Text = "EDITAR"
        Me.M.UseVisualStyleBackColor = False
        '
        'data1
        '
        Me.data1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.data1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.data1.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.data1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.data1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.data1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.data1.ColumnHeadersHeight = 30
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.data1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column10, Me.Column9, Me.Column8, Me.Column7, Me.Column5, Me.Column4, Me.Column3, Me.Column2})
        Me.data1.EnableHeadersVisualStyles = False
        Me.data1.GridColor = System.Drawing.Color.CadetBlue
        Me.data1.Location = New System.Drawing.Point(1, 2)
        Me.data1.Name = "data1"
        Me.data1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data1.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.data1.RowHeadersWidth = 51
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.data1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.data1.Size = New System.Drawing.Size(744, 323)
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
        'Column10
        '
        Me.Column10.DataPropertyName = "CANTIDAD"
        Me.Column10.HeaderText = "CANTIDAD DEL PRODUCTO"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 201
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "ID_PRODUCTOS"
        Me.Column9.HeaderText = "ID DEL PRODUCTO"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 147
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "ID_CONTENEDOR"
        Me.Column8.HeaderText = "ID DEL CONTENEDOR"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 165
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "COBRO_VIAJE"
        Me.Column7.HeaderText = "SUELDO"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 79
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "ESTADO"
        Me.Column5.HeaderText = "ESTADO"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 79
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "CABEZAL"
        Me.Column4.HeaderText = "CABEZAL"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 86
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "RUTA"
        Me.Column3.HeaderText = "RUTA"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 61
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ID_CLIENTE"
        Me.Column2.HeaderText = "ID DEL CLIENTE"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 124
        '
        'ELIMINAR
        '
        Me.ELIMINAR.BackColor = System.Drawing.Color.MidnightBlue
        Me.ELIMINAR.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ELIMINAR.ForeColor = System.Drawing.Color.White
        Me.ELIMINAR.Location = New System.Drawing.Point(122, 332)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(92, 31)
        Me.ELIMINAR.TabIndex = 78
        Me.ELIMINAR.Text = "ELIMINAR"
        Me.ELIMINAR.UseVisualStyleBackColor = False
        '
        'Timercontrae
        '
        Me.Timercontrae.Interval = 5
        '
        'Timerdespliega
        '
        Me.Timerdespliega.Interval = 5
        '
        'HISTORIAL
        '
        Me.HISTORIAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HISTORIAL.FormattingEnabled = True
        Me.HISTORIAL.ItemHeight = 7
        Me.HISTORIAL.Location = New System.Drawing.Point(750, 70)
        Me.HISTORIAL.Margin = New System.Windows.Forms.Padding(2)
        Me.HISTORIAL.Name = "HISTORIAL"
        Me.HISTORIAL.Size = New System.Drawing.Size(280, 347)
        Me.HISTORIAL.TabIndex = 79
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(753, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(277, 25)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "HISTORIAL DE REGISTRO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(353, 398)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "CANTIDAD:"
        '
        'CANTIDAD
        '
        Me.CANTIDAD.BackColor = System.Drawing.Color.LavenderBlush
        Me.CANTIDAD.Enabled = False
        Me.CANTIDAD.ForeColor = System.Drawing.Color.Black
        Me.CANTIDAD.Location = New System.Drawing.Point(459, 398)
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.Size = New System.Drawing.Size(141, 20)
        Me.CANTIDAD.TabIndex = 91
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(41, 542)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "ID DEL PRODUCTO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(41, 506)
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
        Me.Label3.Location = New System.Drawing.Point(61, 470)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "RUTA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(61, 434)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "ID DEL CLIENTE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(61, 398)
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
        Me.Label9.Location = New System.Drawing.Point(368, 506)
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
        Me.COBRO.Location = New System.Drawing.Point(459, 506)
        Me.COBRO.Name = "COBRO"
        Me.COBRO.Size = New System.Drawing.Size(141, 20)
        Me.COBRO.TabIndex = 97
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(368, 470)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "ESTADO:"
        '
        'EST
        '
        Me.EST.BackColor = System.Drawing.Color.LavenderBlush
        Me.EST.Enabled = False
        Me.EST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EST.ForeColor = System.Drawing.Color.Black
        Me.EST.Location = New System.Drawing.Point(459, 470)
        Me.EST.Name = "EST"
        Me.EST.Size = New System.Drawing.Size(141, 20)
        Me.EST.TabIndex = 95
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(368, 434)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "CABEZAL:"
        '
        'cmbR
        '
        Me.cmbR.FormattingEnabled = True
        Me.cmbR.Location = New System.Drawing.Point(171, 467)
        Me.cmbR.Name = "cmbR"
        Me.cmbR.Size = New System.Drawing.Size(141, 21)
        Me.cmbR.TabIndex = 99
        '
        'cmbc
        '
        Me.cmbc.FormattingEnabled = True
        Me.cmbc.Location = New System.Drawing.Point(171, 426)
        Me.cmbc.Name = "cmbc"
        Me.cmbc.Size = New System.Drawing.Size(141, 21)
        Me.cmbc.TabIndex = 101
        '
        'cmbcon
        '
        Me.cmbcon.FormattingEnabled = True
        Me.cmbcon.Location = New System.Drawing.Point(171, 503)
        Me.cmbcon.Name = "cmbcon"
        Me.cmbcon.Size = New System.Drawing.Size(141, 21)
        Me.cmbcon.TabIndex = 102
        '
        'cmbp
        '
        Me.cmbp.FormattingEnabled = True
        Me.cmbp.Location = New System.Drawing.Point(171, 539)
        Me.cmbp.Name = "cmbp"
        Me.cmbp.Size = New System.Drawing.Size(141, 21)
        Me.cmbp.TabIndex = 103
        '
        'cmbcab
        '
        Me.cmbcab.FormattingEnabled = True
        Me.cmbcab.Location = New System.Drawing.Point(459, 431)
        Me.cmbcab.Name = "cmbcab"
        Me.cmbcab.Size = New System.Drawing.Size(141, 21)
        Me.cmbcab.TabIndex = 104
        '
        'IDV
        '
        Me.IDV.BackColor = System.Drawing.Color.LavenderBlush
        Me.IDV.Enabled = False
        Me.IDV.ForeColor = System.Drawing.Color.Black
        Me.IDV.Location = New System.Drawing.Point(171, 391)
        Me.IDV.Name = "IDV"
        Me.IDV.Size = New System.Drawing.Size(141, 20)
        Me.IDV.TabIndex = 105
        '
        'VIAJES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(1323, 735)
        Me.Controls.Add(Me.IDV)
        Me.Controls.Add(Me.cmbcab)
        Me.Controls.Add(Me.cmbp)
        Me.Controls.Add(Me.cmbcon)
        Me.Controls.Add(Me.cmbc)
        Me.Controls.Add(Me.cmbR)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.COBRO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EST)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CANTIDAD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.HISTORIAL)
        Me.Controls.Add(Me.ELIMINAR)
        Me.Controls.Add(Me.pnlconsulta)
        Me.Controls.Add(Me.N)
        Me.Controls.Add(Me.M)
        Me.Controls.Add(Me.data1)
        Me.Name = "VIAJES"
        Me.Text = "VIAJES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlconsulta.ResumeLayout(False)
        Me.pnlconsulta.PerformLayout()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents ELIMINAR As Button
    Friend WithEvents Timercontrae As Timer
    Friend WithEvents Timerdespliega As Timer
    Friend WithEvents HISTORIAL As ListBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CANTIDAD As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents COBRO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents EST As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbR As ComboBox
    Friend WithEvents cmbc As ComboBox
    Friend WithEvents cmbcon As ComboBox
    Friend WithEvents cmbp As ComboBox
    Friend WithEvents cmbcab As ComboBox
    Friend WithEvents IDV As TextBox
End Class
