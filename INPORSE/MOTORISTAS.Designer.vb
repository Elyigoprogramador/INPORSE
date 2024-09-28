<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.data1 = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.M = New System.Windows.Forms.Button()
        Me.N = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DISPO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNOM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DIREC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TEL = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DUI = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tlicencia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Tnombre = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tID = New System.Windows.Forms.TextBox()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data1
        '
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data1.Location = New System.Drawing.Point(12, 12)
        Me.data1.Name = "data1"
        Me.data1.Size = New System.Drawing.Size(685, 321)
        Me.data1.TabIndex = 1
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(784, 261)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(251, 74)
        Me.Eliminar.TabIndex = 13
        Me.Eliminar.Text = "ELIMINAR"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'M
        '
        Me.M.Location = New System.Drawing.Point(784, 129)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(251, 74)
        Me.M.TabIndex = 12
        Me.M.Text = "MODIFICAR"
        Me.M.UseVisualStyleBackColor = True
        '
        'N
        '
        Me.N.Location = New System.Drawing.Point(784, 12)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(251, 74)
        Me.N.TabIndex = 11
        Me.N.Text = "NUEVO"
        Me.N.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 491)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "DISPONIBILIDAD:"
        '
        'DISPO
        '
        Me.DISPO.Enabled = False
        Me.DISPO.Location = New System.Drawing.Point(200, 488)
        Me.DISPO.Name = "DISPO"
        Me.DISPO.Size = New System.Drawing.Size(141, 20)
        Me.DISPO.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 437)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "NUMERO DE LICENCIA:"
        '
        'NL
        '
        Me.NL.Enabled = False
        Me.NL.Location = New System.Drawing.Point(200, 437)
        Me.NL.Name = "NL"
        Me.NL.Size = New System.Drawing.Size(141, 20)
        Me.NL.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 381)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "NOMBRE:"
        '
        'txtNOM
        '
        Me.txtNOM.Enabled = False
        Me.txtNOM.Location = New System.Drawing.Point(200, 381)
        Me.txtNOM.Name = "txtNOM"
        Me.txtNOM.Size = New System.Drawing.Size(141, 20)
        Me.txtNOM.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(109, 339)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(200, 339)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(141, 20)
        Me.txtID.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(475, 488)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "SUELDO BASE:"
        '
        'SB
        '
        Me.SB.Enabled = False
        Me.SB.Location = New System.Drawing.Point(622, 488)
        Me.SB.Name = "SB"
        Me.SB.Size = New System.Drawing.Size(141, 20)
        Me.SB.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(506, 437)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "DIRECCION:"
        '
        'DIREC
        '
        Me.DIREC.Enabled = False
        Me.DIREC.Location = New System.Drawing.Point(622, 437)
        Me.DIREC.Name = "DIREC"
        Me.DIREC.Size = New System.Drawing.Size(141, 20)
        Me.DIREC.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(508, 381)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "TELEFONO:"
        '
        'TEL
        '
        Me.TEL.Enabled = False
        Me.TEL.Location = New System.Drawing.Point(622, 381)
        Me.TEL.Name = "TEL"
        Me.TEL.Size = New System.Drawing.Size(141, 20)
        Me.TEL.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(531, 339)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "DUI:"
        '
        'DUI
        '
        Me.DUI.Enabled = False
        Me.DUI.Location = New System.Drawing.Point(622, 339)
        Me.DUI.Name = "DUI"
        Me.DUI.Size = New System.Drawing.Size(141, 20)
        Me.DUI.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(784, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(251, 74)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "CONSULTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1020, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "NUMERO DE LICENCIA:"
        '
        'Tlicencia
        '
        Me.Tlicencia.Enabled = False
        Me.Tlicencia.Location = New System.Drawing.Point(1217, 110)
        Me.Tlicencia.Name = "Tlicencia"
        Me.Tlicencia.Size = New System.Drawing.Size(141, 20)
        Me.Tlicencia.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1090, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "NOMBRE:"
        '
        'Tnombre
        '
        Me.Tnombre.Enabled = False
        Me.Tnombre.Location = New System.Drawing.Point(1217, 54)
        Me.Tnombre.Name = "Tnombre"
        Me.Tnombre.Size = New System.Drawing.Size(141, 20)
        Me.Tnombre.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1126, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "ID:"
        '
        'tID
        '
        Me.tID.Enabled = False
        Me.tID.Location = New System.Drawing.Point(1217, 12)
        Me.tID.Name = "tID"
        Me.tID.Size = New System.Drawing.Size(141, 20)
        Me.tID.TabIndex = 42
        '
        'CON
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 669)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Tlicencia)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Tnombre)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tID)
        Me.Controls.Add(Me.Button1)
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
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data1 As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents M As System.Windows.Forms.Button
    Friend WithEvents N As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DISPO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NL As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNOM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DIREC As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TEL As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DUI As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Tlicencia As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Tnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tID As System.Windows.Forms.TextBox
End Class
