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
        Me.Timerdespliega = New System.Windows.Forms.Timer(Me.components)
        Me.pnlconsulta = New System.Windows.Forms.Panel()
        Me.PLACA = New System.Windows.Forms.TextBox()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CAPACIDAD = New System.Windows.Forms.TextBox()
        Me.MOTORISTA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timercontrae = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MEN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.P = New System.Windows.Forms.TextBox()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.M = New System.Windows.Forms.Button()
        Me.N = New System.Windows.Forms.Button()
        Me.data1 = New System.Windows.Forms.DataGridView()
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
        Me.pnlconsulta.Controls.Add(Me.PLACA)
        Me.pnlconsulta.Controls.Add(Me.btnmenu)
        Me.pnlconsulta.Controls.Add(Me.Label7)
        Me.pnlconsulta.Controls.Add(Me.Label6)
        Me.pnlconsulta.Controls.Add(Me.CAPACIDAD)
        Me.pnlconsulta.Controls.Add(Me.MOTORISTA)
        Me.pnlconsulta.Controls.Add(Me.Label5)
        Me.pnlconsulta.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlconsulta.Location = New System.Drawing.Point(925, 0)
        Me.pnlconsulta.Name = "pnlconsulta"
        Me.pnlconsulta.Size = New System.Drawing.Size(378, 609)
        Me.pnlconsulta.TabIndex = 45
        '
        'PLACA
        '
        Me.PLACA.Enabled = False
        Me.PLACA.Location = New System.Drawing.Point(195, 289)
        Me.PLACA.Name = "PLACA"
        Me.PLACA.Size = New System.Drawing.Size(141, 20)
        Me.PLACA.TabIndex = 26
        '
        'btnmenu
        '
        Me.btnmenu.Location = New System.Drawing.Point(3, 3)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(97, 28)
        Me.btnmenu.TabIndex = 25
        Me.btnmenu.Text = "CONSULTAR"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 382)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "CAPACIDAD DE CARGA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(104, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "PLACA:"
        '
        'CAPACIDAD
        '
        Me.CAPACIDAD.Enabled = False
        Me.CAPACIDAD.Location = New System.Drawing.Point(195, 379)
        Me.CAPACIDAD.Name = "CAPACIDAD"
        Me.CAPACIDAD.Size = New System.Drawing.Size(141, 20)
        Me.CAPACIDAD.TabIndex = 30
        '
        'MOTORISTA
        '
        Me.MOTORISTA.Enabled = False
        Me.MOTORISTA.Location = New System.Drawing.Point(195, 331)
        Me.MOTORISTA.Name = "MOTORISTA"
        Me.MOTORISTA.Size = New System.Drawing.Size(141, 20)
        Me.MOTORISTA.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 13)
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
        Me.Label4.Location = New System.Drawing.Point(318, 512)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "CAPACIDAD DE CARGA:"
        '
        'CC
        '
        Me.CC.Enabled = False
        Me.CC.Location = New System.Drawing.Point(494, 509)
        Me.CC.Name = "CC"
        Me.CC.Size = New System.Drawing.Size(141, 20)
        Me.CC.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(403, 458)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "MARCA:"
        '
        'MR
        '
        Me.MR.Enabled = False
        Me.MR.Location = New System.Drawing.Point(494, 458)
        Me.MR.Name = "MR"
        Me.MR.Size = New System.Drawing.Size(141, 20)
        Me.MR.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "MOTORISTA ENCARGADO:"
        '
        'MEN
        '
        Me.MEN.Enabled = False
        Me.MEN.Location = New System.Drawing.Point(494, 402)
        Me.MEN.Name = "MEN"
        Me.MEN.Size = New System.Drawing.Size(141, 20)
        Me.MEN.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(403, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "PLACA:"
        '
        'P
        '
        Me.P.Enabled = False
        Me.P.Location = New System.Drawing.Point(494, 360)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(141, 20)
        Me.P.TabIndex = 37
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(619, 166)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(161, 32)
        Me.Eliminar.TabIndex = 36
        Me.Eliminar.Text = "ELIMINAR"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'M
        '
        Me.M.Location = New System.Drawing.Point(625, 101)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(163, 40)
        Me.M.TabIndex = 35
        Me.M.Text = "MODIFICAR"
        Me.M.UseVisualStyleBackColor = True
        '
        'N
        '
        Me.N.Location = New System.Drawing.Point(619, 12)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(169, 55)
        Me.N.TabIndex = 34
        Me.N.Text = "NUEVO"
        Me.N.UseVisualStyleBackColor = True
        '
        'data1
        '
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data1.Location = New System.Drawing.Point(6, 12)
        Me.data1.Name = "data1"
        Me.data1.Size = New System.Drawing.Size(607, 327)
        Me.data1.TabIndex = 33
        '
        'CABEZALES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1303, 609)
        Me.Controls.Add(Me.pnlconsulta)
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
        Me.pnlconsulta.ResumeLayout(False)
        Me.pnlconsulta.PerformLayout()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timerdespliega As Timer
    Friend WithEvents pnlconsulta As Panel
    Friend WithEvents PLACA As TextBox
    Friend WithEvents btnmenu As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CAPACIDAD As TextBox
    Friend WithEvents MOTORISTA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Timercontrae As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents CC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MR As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MEN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents P As TextBox
    Friend WithEvents Eliminar As Button
    Friend WithEvents M As Button
    Friend WithEvents N As Button
    Friend WithEvents data1 As DataGridView
End Class
