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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CANTIDAD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IDP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IDCON = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.COBRO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EST = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CAB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.R = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IDC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDV = New System.Windows.Forms.TextBox()
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
        Me.pnlconsulta.Location = New System.Drawing.Point(1487, 0)
        Me.pnlconsulta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlconsulta.Name = "pnlconsulta"
        Me.pnlconsulta.Size = New System.Drawing.Size(340, 922)
        Me.pnlconsulta.TabIndex = 77
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(39, 362)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 19)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "RUTA:"
        '
        'btnmenu
        '
        Me.btnmenu.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnmenu.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.ForeColor = System.Drawing.Color.White
        Me.btnmenu.Location = New System.Drawing.Point(4, 4)
        Me.btnmenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(111, 36)
        Me.btnmenu.TabIndex = 19
        Me.btnmenu.Text = "CONSULTAR"
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(25, 490)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 19)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "ESTADO:"
        '
        'TID
        '
        Me.TID.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TID.Enabled = False
        Me.TID.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TID.ForeColor = System.Drawing.Color.White
        Me.TID.Location = New System.Drawing.Point(147, 308)
        Me.TID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TID.Name = "TID"
        Me.TID.Size = New System.Drawing.Size(187, 24)
        Me.TID.TabIndex = 47
        '
        'ESTADO
        '
        Me.ESTADO.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ESTADO.Enabled = False
        Me.ESTADO.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ESTADO.ForeColor = System.Drawing.Color.White
        Me.ESTADO.Location = New System.Drawing.Point(147, 489)
        Me.ESTADO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.Size = New System.Drawing.Size(187, 24)
        Me.ESTADO.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(25, 308)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 19)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "ID DEL VIAJE:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(25, 425)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 19)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "CABEZAL:"
        '
        'RUTA
        '
        Me.RUTA.BackColor = System.Drawing.Color.DarkSlateGray
        Me.RUTA.Enabled = False
        Me.RUTA.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RUTA.ForeColor = System.Drawing.Color.White
        Me.RUTA.Location = New System.Drawing.Point(147, 368)
        Me.RUTA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RUTA.Name = "RUTA"
        Me.RUTA.Size = New System.Drawing.Size(187, 24)
        Me.RUTA.TabIndex = 49
        '
        'CABEZAL
        '
        Me.CABEZAL.BackColor = System.Drawing.Color.DarkSlateGray
        Me.CABEZAL.Enabled = False
        Me.CABEZAL.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CABEZAL.ForeColor = System.Drawing.Color.White
        Me.CABEZAL.Location = New System.Drawing.Point(147, 428)
        Me.CABEZAL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CABEZAL.Name = "CABEZAL"
        Me.CABEZAL.Size = New System.Drawing.Size(187, 24)
        Me.CABEZAL.TabIndex = 51
        '
        'N
        '
        Me.N.BackColor = System.Drawing.Color.DarkSlateGray
        Me.N.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N.ForeColor = System.Drawing.Color.White
        Me.N.Location = New System.Drawing.Point(781, 417)
        Me.N.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(175, 57)
        Me.N.TabIndex = 76
        Me.N.Text = "NUEVO"
        Me.N.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(36, 705)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "CANTIDAD:"
        '
        'CANTIDAD
        '
        Me.CANTIDAD.BackColor = System.Drawing.Color.DarkSlateGray
        Me.CANTIDAD.Enabled = False
        Me.CANTIDAD.ForeColor = System.Drawing.Color.White
        Me.CANTIDAD.Location = New System.Drawing.Point(177, 697)
        Me.CANTIDAD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.Size = New System.Drawing.Size(187, 22)
        Me.CANTIDAD.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(4, 631)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 17)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "ID DEL PRODUCTO:"
        '
        'IDP
        '
        Me.IDP.BackColor = System.Drawing.Color.DarkSlateGray
        Me.IDP.Enabled = False
        Me.IDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDP.ForeColor = System.Drawing.Color.White
        Me.IDP.Location = New System.Drawing.Point(177, 639)
        Me.IDP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IDP.Name = "IDP"
        Me.IDP.Size = New System.Drawing.Size(187, 23)
        Me.IDP.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(4, 574)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 17)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "ID DEL CONTENEDOR:"
        '
        'IDCON
        '
        Me.IDCON.BackColor = System.Drawing.Color.DarkSlateGray
        Me.IDCON.Enabled = False
        Me.IDCON.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDCON.ForeColor = System.Drawing.Color.White
        Me.IDCON.Location = New System.Drawing.Point(177, 581)
        Me.IDCON.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IDCON.Name = "IDCON"
        Me.IDCON.Size = New System.Drawing.Size(187, 23)
        Me.IDCON.TabIndex = 70
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(429, 528)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 17)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "COBRO*:"
        '
        'COBRO
        '
        Me.COBRO.BackColor = System.Drawing.Color.DarkSlateGray
        Me.COBRO.Enabled = False
        Me.COBRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COBRO.ForeColor = System.Drawing.Color.White
        Me.COBRO.Location = New System.Drawing.Point(551, 523)
        Me.COBRO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.COBRO.Name = "COBRO"
        Me.COBRO.Size = New System.Drawing.Size(187, 23)
        Me.COBRO.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(429, 469)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "ESTADO:"
        '
        'EST
        '
        Me.EST.BackColor = System.Drawing.Color.DarkSlateGray
        Me.EST.Enabled = False
        Me.EST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EST.ForeColor = System.Drawing.Color.White
        Me.EST.Location = New System.Drawing.Point(551, 465)
        Me.EST.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EST.Name = "EST"
        Me.EST.Size = New System.Drawing.Size(187, 23)
        Me.EST.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(429, 407)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "CABEZAL:"
        '
        'CAB
        '
        Me.CAB.BackColor = System.Drawing.Color.DarkSlateGray
        Me.CAB.Enabled = False
        Me.CAB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAB.ForeColor = System.Drawing.Color.White
        Me.CAB.Location = New System.Drawing.Point(551, 407)
        Me.CAB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CAB.Name = "CAB"
        Me.CAB.Size = New System.Drawing.Size(187, 23)
        Me.CAB.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 521)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "RUTA:"
        '
        'R
        '
        Me.R.BackColor = System.Drawing.Color.DarkSlateGray
        Me.R.Enabled = False
        Me.R.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R.ForeColor = System.Drawing.Color.White
        Me.R.Location = New System.Drawing.Point(177, 523)
        Me.R.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.R.Name = "R"
        Me.R.Size = New System.Drawing.Size(187, 23)
        Me.R.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 459)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "ID DEL CLIENTE:"
        '
        'IDC
        '
        Me.IDC.BackColor = System.Drawing.Color.DarkSlateGray
        Me.IDC.Enabled = False
        Me.IDC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDC.ForeColor = System.Drawing.Color.White
        Me.IDC.Location = New System.Drawing.Point(177, 465)
        Me.IDC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IDC.Name = "IDC"
        Me.IDC.Size = New System.Drawing.Size(187, 23)
        Me.IDC.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 407)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "ID DEL VIAJE:"
        '
        'IDV
        '
        Me.IDV.BackColor = System.Drawing.Color.DarkSlateGray
        Me.IDV.Enabled = False
        Me.IDV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDV.ForeColor = System.Drawing.Color.White
        Me.IDV.Location = New System.Drawing.Point(177, 407)
        Me.IDV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IDV.Name = "IDV"
        Me.IDV.Size = New System.Drawing.Size(187, 23)
        Me.IDV.TabIndex = 58
        '
        'M
        '
        Me.M.BackColor = System.Drawing.Color.DarkSlateGray
        Me.M.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M.ForeColor = System.Drawing.Color.White
        Me.M.Location = New System.Drawing.Point(781, 498)
        Me.M.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(175, 57)
        Me.M.TabIndex = 57
        Me.M.Text = "MODIFICAR"
        Me.M.UseVisualStyleBackColor = False
        '
        'data1
        '
        Me.data1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.data1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.data1.BackgroundColor = System.Drawing.Color.Black
        Me.data1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.data1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.data1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.data1.ColumnHeadersHeight = 30
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.data1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column10, Me.Column9, Me.Column8, Me.Column7, Me.Column5, Me.Column4, Me.Column3, Me.Column2})
        Me.data1.EnableHeadersVisualStyles = False
        Me.data1.GridColor = System.Drawing.Color.SteelBlue
        Me.data1.Location = New System.Drawing.Point(1, 2)
        Me.data1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.data1.Name = "data1"
        Me.data1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.data1.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.data1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.data1.Size = New System.Drawing.Size(992, 398)
        Me.data1.TabIndex = 56
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID_VIAJE"
        Me.Column1.HeaderText = "ID DEL VIAJE"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 143
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "CANTIDAD"
        Me.Column10.HeaderText = "CANTIDAD DEL PRODUCTO"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 266
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "ID_PRODUCTOS"
        Me.Column9.HeaderText = "ID DEL PRODUCTO"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 192
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "ID_CONTENEDOR"
        Me.Column8.HeaderText = "ID DEL CONTENEDOR"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 214
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "COBRO_VIAJE"
        Me.Column7.HeaderText = "SUELDO"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 102
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "ESTADO"
        Me.Column5.HeaderText = "ESTADO"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 103
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "CABEZAL"
        Me.Column4.HeaderText = "CABEZAL"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 112
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "RUTA"
        Me.Column3.HeaderText = "RUTA"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 80
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ID_CLIENTE"
        Me.Column2.HeaderText = "ID DEL CLIENTE"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 161
        '
        'ELIMINAR
        '
        Me.ELIMINAR.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ELIMINAR.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ELIMINAR.ForeColor = System.Drawing.Color.White
        Me.ELIMINAR.Location = New System.Drawing.Point(781, 580)
        Me.ELIMINAR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(175, 57)
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
        Me.HISTORIAL.ItemHeight = 9
        Me.HISTORIAL.Location = New System.Drawing.Point(1000, 86)
        Me.HISTORIAL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HISTORIAL.Name = "HISTORIAL"
        Me.HISTORIAL.Size = New System.Drawing.Size(372, 823)
        Me.HISTORIAL.TabIndex = 79
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(1004, 37)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(342, 29)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "HISTORIAL DE REGISTRO"
        '
        'VIAJES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1827, 922)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.HISTORIAL)
        Me.Controls.Add(Me.ELIMINAR)
        Me.Controls.Add(Me.pnlconsulta)
        Me.Controls.Add(Me.N)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CANTIDAD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.IDP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.IDCON)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.COBRO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EST)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CAB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.R)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IDC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IDV)
        Me.Controls.Add(Me.M)
        Me.Controls.Add(Me.data1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents Label6 As Label
    Friend WithEvents CANTIDAD As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents IDP As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents IDCON As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents COBRO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents EST As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CAB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents R As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IDC As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IDV As TextBox
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
End Class
