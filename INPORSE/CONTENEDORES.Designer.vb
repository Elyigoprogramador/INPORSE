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
        Me.pnlconsulta = New System.Windows.Forms.Panel()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TID = New System.Windows.Forms.TextBox()
        Me.TTIPO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timercontrae = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.T = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Timerdespliega = New System.Windows.Forms.Timer(Me.components)
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.M = New System.Windows.Forms.Button()
        Me.N = New System.Windows.Forms.Button()
        Me.data1 = New System.Windows.Forms.DataGridView()
        Me.pnlconsulta.SuspendLayout()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlconsulta
        '
        Me.pnlconsulta.Controls.Add(Me.btnmenu)
        Me.pnlconsulta.Controls.Add(Me.Label5)
        Me.pnlconsulta.Controls.Add(Me.TID)
        Me.pnlconsulta.Controls.Add(Me.TTIPO)
        Me.pnlconsulta.Controls.Add(Me.Label4)
        Me.pnlconsulta.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlconsulta.Location = New System.Drawing.Point(1011, 0)
        Me.pnlconsulta.Name = "pnlconsulta"
        Me.pnlconsulta.Size = New System.Drawing.Size(359, 749)
        Me.pnlconsulta.TabIndex = 33
        '
        'btnmenu
        '
        Me.btnmenu.Location = New System.Drawing.Point(3, 3)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(96, 24)
        Me.btnmenu.TabIndex = 17
        Me.btnmenu.Text = "CONSULTAR"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "TIPO:"
        '
        'TID
        '
        Me.TID.Enabled = False
        Me.TID.Location = New System.Drawing.Point(164, 173)
        Me.TID.Name = "TID"
        Me.TID.Size = New System.Drawing.Size(141, 20)
        Me.TID.TabIndex = 18
        '
        'TTIPO
        '
        Me.TTIPO.Enabled = False
        Me.TTIPO.Location = New System.Drawing.Point(164, 252)
        Me.TTIPO.Name = "TTIPO"
        Me.TTIPO.Size = New System.Drawing.Size(141, 20)
        Me.TTIPO.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
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
        Me.Label3.Location = New System.Drawing.Point(28, 437)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "TIPO:"
        '
        'TI
        '
        Me.TI.Enabled = False
        Me.TI.Location = New System.Drawing.Point(119, 437)
        Me.TI.Name = "TI"
        Me.TI.Size = New System.Drawing.Size(141, 20)
        Me.TI.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 381)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "TAMAÑO:"
        '
        'T
        '
        Me.T.Enabled = False
        Me.T.Location = New System.Drawing.Point(119, 381)
        Me.T.Name = "T"
        Me.T.Size = New System.Drawing.Size(141, 20)
        Me.T.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 339)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(119, 339)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(141, 20)
        Me.txtID.TabIndex = 27
        '
        'Timerdespliega
        '
        Me.Timerdespliega.Interval = 5
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(592, 261)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(251, 74)
        Me.Eliminar.TabIndex = 26
        Me.Eliminar.Text = "ELIMINAR"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'M
        '
        Me.M.Location = New System.Drawing.Point(592, 129)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(251, 74)
        Me.M.TabIndex = 25
        Me.M.Text = "MODIFICAR"
        Me.M.UseVisualStyleBackColor = True
        '
        'N
        '
        Me.N.Location = New System.Drawing.Point(592, 12)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(251, 74)
        Me.N.TabIndex = 24
        Me.N.Text = "NUEVO"
        Me.N.UseVisualStyleBackColor = True
        '
        'data1
        '
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data1.Location = New System.Drawing.Point(12, 12)
        Me.data1.Name = "data1"
        Me.data1.Size = New System.Drawing.Size(559, 301)
        Me.data1.TabIndex = 23
        '
        'CONTENEDORES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.pnlconsulta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.T)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.M)
        Me.Controls.Add(Me.N)
        Me.Controls.Add(Me.data1)
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
    Friend WithEvents TID As TextBox
    Friend WithEvents TTIPO As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Timercontrae As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents TI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents T As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Timerdespliega As Timer
    Friend WithEvents Eliminar As Button
    Friend WithEvents M As Button
    Friend WithEvents N As Button
    Friend WithEvents data1 As DataGridView
End Class
