<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CONTENEDORES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CONTENEDORES))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlconsulta = New System.Windows.Forms.Panel()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timercontrae = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timerdespliega = New System.Windows.Forms.Timer(Me.components)
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.M = New System.Windows.Forms.Button()
        Me.N = New System.Windows.Forms.Button()
        Me.data1 = New System.Windows.Forms.DataGridView()
        Me.cmbTI = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TTIPO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlconsulta.SuspendLayout()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlconsulta
        '
        Me.pnlconsulta.Controls.Add(Me.TTIPO)
        Me.pnlconsulta.Controls.Add(Me.TID)
        Me.pnlconsulta.Controls.Add(Me.btnmenu)
        Me.pnlconsulta.Controls.Add(Me.Label5)
        Me.pnlconsulta.Controls.Add(Me.Label4)
        Me.pnlconsulta.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlconsulta.Location = New System.Drawing.Point(707, 0)
        Me.pnlconsulta.Name = "pnlconsulta"
        Me.pnlconsulta.Size = New System.Drawing.Size(245, 749)
        Me.pnlconsulta.TabIndex = 33
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
        Me.btnmenu.TabIndex = 17
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(25, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "TIPO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(47, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 23)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "ID:"
        '
        'Timercontrae
        '
        Me.Timercontrae.Interval = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(333, 394)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 23)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "TIPO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(355, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 23)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "ID:"
        '
        'Timerdespliega
        '
        Me.Timerdespliega.Interval = 5
        '
        'Eliminar
        '
        Me.Eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Eliminar.BackgroundImage = CType(resources.GetObject("Eliminar.BackgroundImage"), System.Drawing.Image)
        Me.Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Eliminar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Eliminar.ForeColor = System.Drawing.Color.White
        Me.Eliminar.Location = New System.Drawing.Point(22, 444)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(84, 69)
        Me.Eliminar.TabIndex = 26
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
        Me.M.Location = New System.Drawing.Point(22, 371)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(84, 69)
        Me.M.TabIndex = 25
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
        Me.N.Location = New System.Drawing.Point(22, 298)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(84, 69)
        Me.N.TabIndex = 24
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
        Me.data1.Location = New System.Drawing.Point(12, 12)
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
        Me.data1.Size = New System.Drawing.Size(578, 264)
        Me.data1.TabIndex = 23
        '
        'cmbTI
        '
        Me.cmbTI.AutoRoundedCorners = True
        Me.cmbTI.BackColor = System.Drawing.Color.Transparent
        Me.cmbTI.BorderRadius = 17
        Me.cmbTI.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTI.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTI.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbTI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbTI.ItemHeight = 30
        Me.cmbTI.Location = New System.Drawing.Point(405, 381)
        Me.cmbTI.Name = "cmbTI"
        Me.cmbTI.Size = New System.Drawing.Size(185, 36)
        Me.cmbTI.TabIndex = 85
        '
        'txtID
        '
        Me.txtID.AutoRoundedCorners = True
        Me.txtID.BorderRadius = 17
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.DefaultText = ""
        Me.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtID.Location = New System.Drawing.Point(405, 321)
        Me.txtID.MaxLength = 5
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.PlaceholderText = ""
        Me.txtID.SelectedText = ""
        Me.txtID.Size = New System.Drawing.Size(185, 36)
        Me.txtID.TabIndex = 86
        '
        'TID
        '
        Me.TID.AutoRoundedCorners = True
        Me.TID.BorderRadius = 13
        Me.TID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TID.DefaultText = ""
        Me.TID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TID.Location = New System.Drawing.Point(102, 124)
        Me.TID.Name = "TID"
        Me.TID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TID.PlaceholderText = ""
        Me.TID.SelectedText = ""
        Me.TID.Size = New System.Drawing.Size(87, 28)
        Me.TID.TabIndex = 22
        '
        'TTIPO
        '
        Me.TTIPO.AutoRoundedCorners = True
        Me.TTIPO.BorderRadius = 13
        Me.TTIPO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TTIPO.DefaultText = ""
        Me.TTIPO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TTIPO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TTIPO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TTIPO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TTIPO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TTIPO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TTIPO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TTIPO.Location = New System.Drawing.Point(102, 167)
        Me.TTIPO.Name = "TTIPO"
        Me.TTIPO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TTIPO.PlaceholderText = ""
        Me.TTIPO.SelectedText = ""
        Me.TTIPO.Size = New System.Drawing.Size(87, 28)
        Me.TTIPO.TabIndex = 23
        '
        'CONTENEDORES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(952, 749)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.cmbTI)
        Me.Controls.Add(Me.pnlconsulta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.M)
        Me.Controls.Add(Me.N)
        Me.Controls.Add(Me.data1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "CONTENEDORES"
        Me.Text = "CONTENEDORES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlconsulta.ResumeLayout(False)
        Me.pnlconsulta.PerformLayout()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlconsulta As Panel
    Friend WithEvents btnmenu As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timercontrae As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timerdespliega As Timer
    Friend WithEvents Eliminar As Button
    Friend WithEvents M As Button
    Friend WithEvents N As Button
    Friend WithEvents data1 As DataGridView
    Friend WithEvents cmbTI As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TTIPO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TID As Guna.UI2.WinForms.Guna2TextBox
End Class
