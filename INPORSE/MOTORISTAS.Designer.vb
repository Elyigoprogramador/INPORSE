﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CON
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlconsulta = New System.Windows.Forms.Panel()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tID = New System.Windows.Forms.TextBox()
        Me.Tlicencia = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Tnombre = New System.Windows.Forms.TextBox()
        Me.Timercontrae = New System.Windows.Forms.Timer(Me.components)
        Me.Timerdespliega = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DIREC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TEL = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DUI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DISPO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNOM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.M = New System.Windows.Forms.Button()
        Me.N = New System.Windows.Forms.Button()
        Me.data1 = New System.Windows.Forms.DataGridView()
        Me.HISTORIAL = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pnlconsulta.SuspendLayout()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlconsulta
        '
        Me.pnlconsulta.Controls.Add(Me.btnmenu)
        Me.pnlconsulta.Controls.Add(Me.Label9)
        Me.pnlconsulta.Controls.Add(Me.tID)
        Me.pnlconsulta.Controls.Add(Me.Tlicencia)
        Me.pnlconsulta.Controls.Add(Me.Label11)
        Me.pnlconsulta.Controls.Add(Me.Label10)
        Me.pnlconsulta.Controls.Add(Me.Tnombre)
        Me.pnlconsulta.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlconsulta.Location = New System.Drawing.Point(1012, 0)
        Me.pnlconsulta.Name = "pnlconsulta"
        Me.pnlconsulta.Size = New System.Drawing.Size(358, 669)
        Me.pnlconsulta.TabIndex = 69
        '
        'btnmenu
        '
        Me.btnmenu.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnmenu.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.ForeColor = System.Drawing.Color.White
        Me.btnmenu.Location = New System.Drawing.Point(3, 3)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(112, 31)
        Me.btnmenu.TabIndex = 41
        Me.btnmenu.Text = "CONSULTAR"
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(10, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 16)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "NUMERO DE LICENCIA:"
        '
        'tID
        '
        Me.tID.BackColor = System.Drawing.Color.DarkSlateGray
        Me.tID.Enabled = False
        Me.tID.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tID.ForeColor = System.Drawing.Color.White
        Me.tID.Location = New System.Drawing.Point(207, 211)
        Me.tID.Name = "tID"
        Me.tID.Size = New System.Drawing.Size(141, 21)
        Me.tID.TabIndex = 42
        '
        'Tlicencia
        '
        Me.Tlicencia.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Tlicencia.Enabled = False
        Me.Tlicencia.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tlicencia.ForeColor = System.Drawing.Color.White
        Me.Tlicencia.Location = New System.Drawing.Point(207, 309)
        Me.Tlicencia.Name = "Tlicencia"
        Me.Tlicencia.Size = New System.Drawing.Size(141, 21)
        Me.Tlicencia.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(116, 211)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 16)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "ID:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(80, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 16)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "NOMBRE:"
        '
        'Tnombre
        '
        Me.Tnombre.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Tnombre.Enabled = False
        Me.Tnombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tnombre.ForeColor = System.Drawing.Color.White
        Me.Tnombre.Location = New System.Drawing.Point(207, 260)
        Me.Tnombre.Name = "Tnombre"
        Me.Tnombre.Size = New System.Drawing.Size(141, 21)
        Me.Tnombre.TabIndex = 44
        '
        'Timercontrae
        '
        Me.Timercontrae.Interval = 5
        '
        'Timerdespliega
        '
        Me.Timerdespliega.Interval = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(356, 349)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "SUELDO BASE:"
        '
        'SB
        '
        Me.SB.BackColor = System.Drawing.Color.DarkSlateGray
        Me.SB.Enabled = False
        Me.SB.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SB.ForeColor = System.Drawing.Color.White
        Me.SB.Location = New System.Drawing.Point(503, 345)
        Me.SB.Name = "SB"
        Me.SB.Size = New System.Drawing.Size(141, 21)
        Me.SB.TabIndex = 67
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(83, 621)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "DIRECCION:"
        '
        'DIREC
        '
        Me.DIREC.BackColor = System.Drawing.Color.DarkSlateGray
        Me.DIREC.Enabled = False
        Me.DIREC.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIREC.ForeColor = System.Drawing.Color.White
        Me.DIREC.Location = New System.Drawing.Point(196, 615)
        Me.DIREC.Name = "DIREC"
        Me.DIREC.Size = New System.Drawing.Size(144, 21)
        Me.DIREC.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(85, 574)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "TELEFONO:"
        '
        'TEL
        '
        Me.TEL.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TEL.Enabled = False
        Me.TEL.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEL.ForeColor = System.Drawing.Color.White
        Me.TEL.Location = New System.Drawing.Point(199, 569)
        Me.TEL.Name = "TEL"
        Me.TEL.Size = New System.Drawing.Size(141, 21)
        Me.TEL.TabIndex = 63
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(108, 527)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 16)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "DUI:"
        '
        'DUI
        '
        Me.DUI.BackColor = System.Drawing.Color.DarkSlateGray
        Me.DUI.Enabled = False
        Me.DUI.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DUI.ForeColor = System.Drawing.Color.White
        Me.DUI.Location = New System.Drawing.Point(199, 523)
        Me.DUI.Name = "DUI"
        Me.DUI.Size = New System.Drawing.Size(141, 21)
        Me.DUI.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(44, 480)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "DISPONIBILIDAD:"
        '
        'DISPO
        '
        Me.DISPO.BackColor = System.Drawing.Color.DarkSlateGray
        Me.DISPO.Enabled = False
        Me.DISPO.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DISPO.ForeColor = System.Drawing.Color.White
        Me.DISPO.Location = New System.Drawing.Point(199, 477)
        Me.DISPO.Name = "DISPO"
        Me.DISPO.Size = New System.Drawing.Size(141, 21)
        Me.DISPO.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(23, 433)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 16)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "NUMERO DE LICENCIA:"
        '
        'NL
        '
        Me.NL.BackColor = System.Drawing.Color.DarkSlateGray
        Me.NL.Enabled = False
        Me.NL.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NL.ForeColor = System.Drawing.Color.White
        Me.NL.Location = New System.Drawing.Point(199, 431)
        Me.NL.Name = "NL"
        Me.NL.Size = New System.Drawing.Size(141, 21)
        Me.NL.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(93, 386)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "NOMBRE:"
        '
        'txtNOM
        '
        Me.txtNOM.BackColor = System.Drawing.Color.DarkSlateGray
        Me.txtNOM.Enabled = False
        Me.txtNOM.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOM.ForeColor = System.Drawing.Color.White
        Me.txtNOM.Location = New System.Drawing.Point(199, 385)
        Me.txtNOM.Name = "txtNOM"
        Me.txtNOM.Size = New System.Drawing.Size(141, 21)
        Me.txtNOM.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(129, 339)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.DarkSlateGray
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.White
        Me.txtID.Location = New System.Drawing.Point(199, 339)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(141, 21)
        Me.txtID.TabIndex = 53
        '
        'Eliminar
        '
        Me.Eliminar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Eliminar.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar.ForeColor = System.Drawing.Color.White
        Me.Eliminar.Location = New System.Drawing.Point(503, 576)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(141, 55)
        Me.Eliminar.TabIndex = 52
        Me.Eliminar.Text = "ELIMINAR"
        Me.Eliminar.UseVisualStyleBackColor = False
        '
        'M
        '
        Me.M.BackColor = System.Drawing.Color.DarkSlateGray
        Me.M.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M.ForeColor = System.Drawing.Color.White
        Me.M.Location = New System.Drawing.Point(503, 486)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(141, 55)
        Me.M.TabIndex = 51
        Me.M.Text = "MODIFICAR"
        Me.M.UseVisualStyleBackColor = False
        '
        'N
        '
        Me.N.BackColor = System.Drawing.Color.DarkSlateGray
        Me.N.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N.ForeColor = System.Drawing.Color.White
        Me.N.Location = New System.Drawing.Point(503, 396)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(141, 55)
        Me.N.TabIndex = 50
        Me.N.Text = "NUEVO"
        Me.N.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.data1.ColumnHeadersHeight = 30
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data1.DefaultCellStyle = DataGridViewCellStyle2
        Me.data1.EnableHeadersVisualStyles = False
        Me.data1.GridColor = System.Drawing.Color.SteelBlue
        Me.data1.Location = New System.Drawing.Point(11, 12)
        Me.data1.Name = "data1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.data1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.data1.Size = New System.Drawing.Size(685, 321)
        Me.data1.TabIndex = 49
        '
        'HISTORIAL
        '
        Me.HISTORIAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HISTORIAL.FormattingEnabled = True
        Me.HISTORIAL.ItemHeight = 7
        Me.HISTORIAL.Location = New System.Drawing.Point(701, 60)
        Me.HISTORIAL.Margin = New System.Windows.Forms.Padding(2)
        Me.HISTORIAL.Name = "HISTORIAL"
        Me.HISTORIAL.Size = New System.Drawing.Size(280, 606)
        Me.HISTORIAL.TabIndex = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(704, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(277, 25)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "HISTORIAL DE REGISTRO"
        '
        'CON
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1370, 669)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.HISTORIAL)
        Me.Controls.Add(Me.pnlconsulta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DIREC)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TEL)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DUI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DISPO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNOM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.M)
        Me.Controls.Add(Me.N)
        Me.Controls.Add(Me.data1)
        Me.Name = "CON"
        Me.Text = "MOTORISTAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlconsulta.ResumeLayout(False)
        Me.pnlconsulta.PerformLayout()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlconsulta As Panel
    Friend WithEvents btnmenu As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents tID As TextBox
    Friend WithEvents Tlicencia As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Tnombre As TextBox
    Friend WithEvents Timercontrae As Timer
    Friend WithEvents Timerdespliega As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents SB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DIREC As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TEL As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DUI As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DISPO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNOM As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Eliminar As Button
    Friend WithEvents M As Button
    Friend WithEvents N As Button
    Friend WithEvents data1 As DataGridView
    Friend WithEvents HISTORIAL As ListBox
    Friend WithEvents Label12 As Label
End Class
