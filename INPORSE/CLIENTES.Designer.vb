﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CLIENTES
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
        Me.data1 = New System.Windows.Forms.DataGridView()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNOM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTEL = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDIR = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCOR = New System.Windows.Forms.TextBox()
        Me.N1 = New System.Windows.Forms.Button()
        Me.M1 = New System.Windows.Forms.Button()
        Me.E1 = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.pnlconsulta = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ttelefono = New System.Windows.Forms.TextBox()
        Me.tID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.Timercontrae = New System.Windows.Forms.Timer(Me.components)
        Me.Timerdespliega = New System.Windows.Forms.Timer(Me.components)
        Me.HISTORIAL = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlconsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'data1
        '
        Me.data1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.data1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.data1.BackgroundColor = System.Drawing.Color.Black
        Me.data1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.data1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.data1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.data1.ColumnHeadersHeight = 30
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.data1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.TELEFONO, Me.Column3, Me.Column4})
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
        Me.data1.Location = New System.Drawing.Point(48, 46)
        Me.data1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.data1.Name = "data1"
        Me.data1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.data1.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.data1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.data1.Size = New System.Drawing.Size(951, 398)
        Me.data1.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.DarkSlateGray
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.White
        Me.txtID.Location = New System.Drawing.Point(165, 487)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(187, 23)
        Me.txtID.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 487)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(44, 539)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "NOMBRE:"
        '
        'txtNOM
        '
        Me.txtNOM.BackColor = System.Drawing.Color.DarkSlateGray
        Me.txtNOM.Enabled = False
        Me.txtNOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOM.ForeColor = System.Drawing.Color.White
        Me.txtNOM.Location = New System.Drawing.Point(165, 538)
        Me.txtNOM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNOM.Name = "txtNOM"
        Me.txtNOM.Size = New System.Drawing.Size(187, 23)
        Me.txtNOM.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(44, 590)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "TELEFONO:"
        '
        'txtTEL
        '
        Me.txtTEL.BackColor = System.Drawing.Color.DarkSlateGray
        Me.txtTEL.Enabled = False
        Me.txtTEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTEL.ForeColor = System.Drawing.Color.White
        Me.txtTEL.Location = New System.Drawing.Point(165, 588)
        Me.txtTEL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTEL.Name = "txtTEL"
        Me.txtTEL.Size = New System.Drawing.Size(187, 23)
        Me.txtTEL.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(371, 487)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "DIRECCION:"
        '
        'txtDIR
        '
        Me.txtDIR.BackColor = System.Drawing.Color.DarkSlateGray
        Me.txtDIR.Enabled = False
        Me.txtDIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDIR.ForeColor = System.Drawing.Color.White
        Me.txtDIR.Location = New System.Drawing.Point(492, 487)
        Me.txtDIR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDIR.Name = "txtDIR"
        Me.txtDIR.Size = New System.Drawing.Size(187, 23)
        Me.txtDIR.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(371, 543)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "CORREO"
        '
        'txtCOR
        '
        Me.txtCOR.BackColor = System.Drawing.Color.DarkSlateGray
        Me.txtCOR.Enabled = False
        Me.txtCOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCOR.ForeColor = System.Drawing.Color.White
        Me.txtCOR.Location = New System.Drawing.Point(492, 543)
        Me.txtCOR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCOR.Name = "txtCOR"
        Me.txtCOR.Size = New System.Drawing.Size(187, 23)
        Me.txtCOR.TabIndex = 13
        '
        'N1
        '
        Me.N1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.N1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N1.ForeColor = System.Drawing.Color.White
        Me.N1.Location = New System.Drawing.Point(720, 458)
        Me.N1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.N1.Name = "N1"
        Me.N1.Size = New System.Drawing.Size(175, 58)
        Me.N1.TabIndex = 15
        Me.N1.Text = "NUEVO"
        Me.N1.UseVisualStyleBackColor = False
        '
        'M1
        '
        Me.M1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.M1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M1.ForeColor = System.Drawing.Color.White
        Me.M1.Location = New System.Drawing.Point(720, 523)
        Me.M1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.M1.Name = "M1"
        Me.M1.Size = New System.Drawing.Size(175, 58)
        Me.M1.TabIndex = 16
        Me.M1.Text = "MODIFICAR"
        Me.M1.UseVisualStyleBackColor = False
        '
        'E1
        '
        Me.E1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.E1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E1.ForeColor = System.Drawing.Color.White
        Me.E1.Location = New System.Drawing.Point(720, 588)
        Me.E1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.E1.Name = "E1"
        Me.E1.Size = New System.Drawing.Size(175, 58)
        Me.E1.TabIndex = 17
        Me.E1.Text = "ELIMINAR"
        Me.E1.UseVisualStyleBackColor = False
        '
        'btnmenu
        '
        Me.btnmenu.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnmenu.ForeColor = System.Drawing.Color.White
        Me.btnmenu.Location = New System.Drawing.Point(4, 4)
        Me.btnmenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(111, 36)
        Me.btnmenu.TabIndex = 18
        Me.btnmenu.Text = "CONSULTAR"
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'pnlconsulta
        '
        Me.pnlconsulta.BackColor = System.Drawing.Color.Black
        Me.pnlconsulta.Controls.Add(Me.Label6)
        Me.pnlconsulta.Controls.Add(Me.btnmenu)
        Me.pnlconsulta.Controls.Add(Me.Ttelefono)
        Me.pnlconsulta.Controls.Add(Me.tID)
        Me.pnlconsulta.Controls.Add(Me.Label7)
        Me.pnlconsulta.Controls.Add(Me.Label8)
        Me.pnlconsulta.Controls.Add(Me.TNombre)
        Me.pnlconsulta.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlconsulta.Location = New System.Drawing.Point(1628, 0)
        Me.pnlconsulta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlconsulta.Name = "pnlconsulta"
        Me.pnlconsulta.Size = New System.Drawing.Size(173, 802)
        Me.pnlconsulta.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 427)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "TELEFONO:"
        '
        'Ttelefono
        '
        Me.Ttelefono.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Ttelefono.Enabled = False
        Me.Ttelefono.ForeColor = System.Drawing.Color.White
        Me.Ttelefono.Location = New System.Drawing.Point(133, 427)
        Me.Ttelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ttelefono.Name = "Ttelefono"
        Me.Ttelefono.Size = New System.Drawing.Size(187, 22)
        Me.Ttelefono.TabIndex = 30
        '
        'tID
        '
        Me.tID.BackColor = System.Drawing.Color.DarkSlateGray
        Me.tID.Enabled = False
        Me.tID.ForeColor = System.Drawing.Color.White
        Me.tID.Location = New System.Drawing.Point(133, 306)
        Me.tID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tID.Name = "tID"
        Me.tID.Size = New System.Drawing.Size(187, 22)
        Me.tID.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 358)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "NOMBRE:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 306)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "ID:"
        '
        'TNombre
        '
        Me.TNombre.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TNombre.Enabled = False
        Me.TNombre.ForeColor = System.Drawing.Color.White
        Me.TNombre.Location = New System.Drawing.Point(133, 367)
        Me.TNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(187, 22)
        Me.TNombre.TabIndex = 28
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
        Me.HISTORIAL.Location = New System.Drawing.Point(1005, 85)
        Me.HISTORIAL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HISTORIAL.Name = "HISTORIAL"
        Me.HISTORIAL.Size = New System.Drawing.Size(372, 706)
        Me.HISTORIAL.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1007, 46)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(342, 29)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "HISTORIAL DE REGISTRO"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID_CLIENTE"
        Me.Column1.HeaderText = "DUI"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 67
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "NOMBRE"
        Me.Column2.HeaderText = "NOMBRE"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 111
        '
        'TELEFONO
        '
        Me.TELEFONO.DataPropertyName = "TELEFONO"
        Me.TELEFONO.HeaderText = "TELÉFONO"
        Me.TELEFONO.MinimumWidth = 6
        Me.TELEFONO.Name = "TELEFONO"
        Me.TELEFONO.Width = 122
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "DIRECCION"
        Me.Column3.HeaderText = "DIRECCIÓN"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 135
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "EMAIL"
        Me.Column4.HeaderText = "EMAIL"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 89
        '
        'CLIENTES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1801, 802)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.HISTORIAL)
        Me.Controls.Add(Me.pnlconsulta)
        Me.Controls.Add(Me.E1)
        Me.Controls.Add(Me.M1)
        Me.Controls.Add(Me.N1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCOR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDIR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTEL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNOM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.data1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CLIENTES"
        Me.Text = "CLIENTES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlconsulta.ResumeLayout(False)
        Me.pnlconsulta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNOM As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTEL As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDIR As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCOR As System.Windows.Forms.TextBox
    Friend WithEvents N1 As System.Windows.Forms.Button
    Friend WithEvents M1 As System.Windows.Forms.Button
    Friend WithEvents E1 As System.Windows.Forms.Button
    Friend WithEvents btnmenu As System.Windows.Forms.Button
    Friend WithEvents pnlconsulta As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Ttelefono As System.Windows.Forms.TextBox
    Friend WithEvents tID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents Timercontrae As System.Windows.Forms.Timer
    Friend WithEvents Timerdespliega As System.Windows.Forms.Timer
    Friend WithEvents HISTORIAL As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
