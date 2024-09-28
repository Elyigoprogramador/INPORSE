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
        Me.data1 = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.M = New System.Windows.Forms.Button()
        Me.N = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MEN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.P = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CC = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MOTORISTA = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PLACA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CAPACIDAD = New System.Windows.Forms.TextBox()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data1
        '
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data1.Location = New System.Drawing.Point(12, 12)
        Me.data1.Name = "data1"
        Me.data1.Size = New System.Drawing.Size(607, 327)
        Me.data1.TabIndex = 1
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(724, 341)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(251, 74)
        Me.Eliminar.TabIndex = 10
        Me.Eliminar.Text = "ELIMINAR"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'M
        '
        Me.M.Location = New System.Drawing.Point(724, 209)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(251, 74)
        Me.M.TabIndex = 9
        Me.M.Text = "MODIFICAR"
        Me.M.UseVisualStyleBackColor = True
        '
        'N
        '
        Me.N.Location = New System.Drawing.Point(724, 92)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(251, 74)
        Me.N.TabIndex = 8
        Me.N.Text = "NUEVO"
        Me.N.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(409, 458)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "MARCA:"
        '
        'MR
        '
        Me.MR.Enabled = False
        Me.MR.Location = New System.Drawing.Point(500, 458)
        Me.MR.Name = "MR"
        Me.MR.Size = New System.Drawing.Size(141, 20)
        Me.MR.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(308, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "MOTORISTA ENCARGADO:"
        '
        'MEN
        '
        Me.MEN.Enabled = False
        Me.MEN.Location = New System.Drawing.Point(500, 402)
        Me.MEN.Name = "MEN"
        Me.MEN.Size = New System.Drawing.Size(141, 20)
        Me.MEN.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(409, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "PLACA:"
        '
        'P
        '
        Me.P.Enabled = False
        Me.P.Location = New System.Drawing.Point(500, 360)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(141, 20)
        Me.P.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(324, 512)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "CAPACIDAD DE CARGA:"
        '
        'CC
        '
        Me.CC.Enabled = False
        Me.CC.Location = New System.Drawing.Point(500, 509)
        Me.CC.Name = "CC"
        Me.CC.Size = New System.Drawing.Size(141, 20)
        Me.CC.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(724, 472)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(251, 74)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "CONSULTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(958, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "MOTORISTA ENCARGADO:"
        '
        'MOTORISTA
        '
        Me.MOTORISTA.Enabled = False
        Me.MOTORISTA.Location = New System.Drawing.Point(1150, 54)
        Me.MOTORISTA.Name = "MOTORISTA"
        Me.MOTORISTA.Size = New System.Drawing.Size(141, 20)
        Me.MOTORISTA.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1059, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "PLACA:"
        '
        'PLACA
        '
        Me.PLACA.Enabled = False
        Me.PLACA.Location = New System.Drawing.Point(1150, 12)
        Me.PLACA.Name = "PLACA"
        Me.PLACA.Size = New System.Drawing.Size(141, 20)
        Me.PLACA.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(974, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "CAPACIDAD DE CARGA:"
        '
        'CAPACIDAD
        '
        Me.CAPACIDAD.Enabled = False
        Me.CAPACIDAD.Location = New System.Drawing.Point(1150, 102)
        Me.CAPACIDAD.Name = "CAPACIDAD"
        Me.CAPACIDAD.Size = New System.Drawing.Size(141, 20)
        Me.CAPACIDAD.TabIndex = 30
        '
        'CABEZALES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1303, 609)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CAPACIDAD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MOTORISTA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PLACA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MEN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.P)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.M)
        Me.Controls.Add(Me.N)
        Me.Controls.Add(Me.data1)
        Me.Name = "CABEZALES"
        Me.Text = "CABEZALES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data1 As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents M As System.Windows.Forms.Button
    Friend WithEvents N As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MR As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MEN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents P As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CC As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MOTORISTA As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PLACA As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CAPACIDAD As System.Windows.Forms.TextBox
End Class
