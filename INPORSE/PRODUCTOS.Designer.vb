<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PRODUCTOS
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlconsulta = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TnombreE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TidD = New System.Windows.Forms.TextBox()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NOM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.ELIMINAR = New System.Windows.Forms.Button()
        Me.M = New System.Windows.Forms.Button()
        Me.N = New System.Windows.Forms.Button()
        Me.data1 = New System.Windows.Forms.DataGridView()
        Me.Timercontrae = New System.Windows.Forms.Timer(Me.components)
        Me.Timerdespliega = New System.Windows.Forms.Timer(Me.components)
        Me.HISTORIAL = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlconsulta.SuspendLayout()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlconsulta
        '
        Me.pnlconsulta.Controls.Add(Me.Label4)
        Me.pnlconsulta.Controls.Add(Me.TnombreE)
        Me.pnlconsulta.Controls.Add(Me.Label5)
        Me.pnlconsulta.Controls.Add(Me.TidD)
        Me.pnlconsulta.Controls.Add(Me.btnmenu)
        Me.pnlconsulta.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlconsulta.Location = New System.Drawing.Point(1062, 0)
        Me.pnlconsulta.Name = "pnlconsulta"
        Me.pnlconsulta.Size = New System.Drawing.Size(308, 749)
        Me.pnlconsulta.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "NOMBRE:"
        '
        'TnombreE
        '
        Me.TnombreE.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TnombreE.Enabled = False
        Me.TnombreE.ForeColor = System.Drawing.Color.White
        Me.TnombreE.Location = New System.Drawing.Point(154, 303)
        Me.TnombreE.Name = "TnombreE"
        Me.TnombreE.Size = New System.Drawing.Size(141, 20)
        Me.TnombreE.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "ID:"
        '
        'TidD
        '
        Me.TidD.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TidD.Enabled = False
        Me.TidD.ForeColor = System.Drawing.Color.White
        Me.TidD.Location = New System.Drawing.Point(154, 261)
        Me.TidD.Name = "TidD"
        Me.TidD.Size = New System.Drawing.Size(141, 20)
        Me.TidD.TabIndex = 23
        '
        'btnmenu
        '
        Me.btnmenu.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnmenu.ForeColor = System.Drawing.Color.White
        Me.btnmenu.Location = New System.Drawing.Point(3, 3)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(83, 29)
        Me.btnmenu.TabIndex = 18
        Me.btnmenu.Text = "CONSULTAR"
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 469)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "UNIDAD DEL PRODUCTO:"
        '
        'UP
        '
        Me.UP.BackColor = System.Drawing.Color.DarkSlateGray
        Me.UP.Enabled = False
        Me.UP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UP.ForeColor = System.Drawing.Color.White
        Me.UP.Location = New System.Drawing.Point(155, 461)
        Me.UP.Name = "UP"
        Me.UP.Size = New System.Drawing.Size(141, 21)
        Me.UP.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 413)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "NOMBRE:"
        '
        'NOM
        '
        Me.NOM.BackColor = System.Drawing.Color.DarkSlateGray
        Me.NOM.Enabled = False
        Me.NOM.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NOM.ForeColor = System.Drawing.Color.White
        Me.NOM.Location = New System.Drawing.Point(155, 416)
        Me.NOM.Name = "NOM"
        Me.NOM.Size = New System.Drawing.Size(141, 21)
        Me.NOM.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "ID:"
        '
        'ID
        '
        Me.ID.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ID.Enabled = False
        Me.ID.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.ForeColor = System.Drawing.Color.White
        Me.ID.Location = New System.Drawing.Point(155, 371)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(141, 21)
        Me.ID.TabIndex = 30
        '
        'ELIMINAR
        '
        Me.ELIMINAR.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ELIMINAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ELIMINAR.ForeColor = System.Drawing.Color.White
        Me.ELIMINAR.Location = New System.Drawing.Point(501, 524)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(137, 61)
        Me.ELIMINAR.TabIndex = 29
        Me.ELIMINAR.Text = "ELIMINAR"
        Me.ELIMINAR.UseVisualStyleBackColor = False
        '
        'M
        '
        Me.M.BackColor = System.Drawing.Color.DarkSlateGray
        Me.M.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M.ForeColor = System.Drawing.Color.White
        Me.M.Location = New System.Drawing.Point(501, 436)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(137, 61)
        Me.M.TabIndex = 28
        Me.M.Text = "MODIFICAR"
        Me.M.UseVisualStyleBackColor = False
        '
        'N
        '
        Me.N.BackColor = System.Drawing.Color.DarkSlateGray
        Me.N.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N.ForeColor = System.Drawing.Color.White
        Me.N.Location = New System.Drawing.Point(501, 348)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(137, 61)
        Me.N.TabIndex = 27
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.data1.ColumnHeadersHeight = 30
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data1.DefaultCellStyle = DataGridViewCellStyle10
        Me.data1.EnableHeadersVisualStyles = False
        Me.data1.GridColor = System.Drawing.Color.SteelBlue
        Me.data1.Location = New System.Drawing.Point(12, 12)
        Me.data1.Name = "data1"
        Me.data1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data1.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.data1.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.data1.Size = New System.Drawing.Size(713, 323)
        Me.data1.TabIndex = 26
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
        Me.HISTORIAL.Location = New System.Drawing.Point(730, 64)
        Me.HISTORIAL.Margin = New System.Windows.Forms.Padding(2)
        Me.HISTORIAL.Name = "HISTORIAL"
        Me.HISTORIAL.Size = New System.Drawing.Size(280, 683)
        Me.HISTORIAL.TabIndex = 81
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(733, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(277, 25)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "HISTORIAL DE REGISTRO"
        '
        'PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.HISTORIAL)
        Me.Controls.Add(Me.pnlconsulta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.UP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NOM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.ELIMINAR)
        Me.Controls.Add(Me.M)
        Me.Controls.Add(Me.N)
        Me.Controls.Add(Me.data1)
        Me.Name = "PRODUCTOS"
        Me.Text = "PRODUCTOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlconsulta.ResumeLayout(False)
        Me.pnlconsulta.PerformLayout()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlconsulta As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TnombreE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TidD As TextBox
    Friend WithEvents btnmenu As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents UP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NOM As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents ELIMINAR As Button
    Friend WithEvents M As Button
    Friend WithEvents N As Button
    Friend WithEvents data1 As DataGridView
    Friend WithEvents Timercontrae As Timer
    Friend WithEvents Timerdespliega As Timer
    Friend WithEvents HISTORIAL As ListBox
    Friend WithEvents Label9 As Label
End Class
