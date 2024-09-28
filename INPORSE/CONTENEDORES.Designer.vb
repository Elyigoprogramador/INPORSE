<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONTENEDORES
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
        Me.TI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.T = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.CONSULTA = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TTIPO = New System.Windows.Forms.TextBox()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data1
        '
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data1.Location = New System.Drawing.Point(23, 12)
        Me.data1.Name = "data1"
        Me.data1.Size = New System.Drawing.Size(559, 301)
        Me.data1.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(732, 285)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(251, 74)
        Me.Eliminar.TabIndex = 7
        Me.Eliminar.Text = "ELIMINAR"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'M
        '
        Me.M.Location = New System.Drawing.Point(732, 153)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(251, 74)
        Me.M.TabIndex = 6
        Me.M.Text = "MODIFICAR"
        Me.M.UseVisualStyleBackColor = True
        '
        'N
        '
        Me.N.Location = New System.Drawing.Point(732, 36)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(251, 74)
        Me.N.TabIndex = 5
        Me.N.Text = "NUEVO"
        Me.N.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(409, 459)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "TIPO:"
        '
        'TI
        '
        Me.TI.Enabled = False
        Me.TI.Location = New System.Drawing.Point(500, 459)
        Me.TI.Name = "TI"
        Me.TI.Size = New System.Drawing.Size(141, 20)
        Me.TI.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(409, 403)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "TAMAÑO:"
        '
        'T
        '
        Me.T.Enabled = False
        Me.T.Location = New System.Drawing.Point(500, 403)
        Me.T.Name = "T"
        Me.T.Size = New System.Drawing.Size(141, 20)
        Me.T.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(409, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(500, 361)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(141, 20)
        Me.txtID.TabIndex = 11
        '
        'CONSULTA
        '
        Me.CONSULTA.Location = New System.Drawing.Point(732, 405)
        Me.CONSULTA.Name = "CONSULTA"
        Me.CONSULTA.Size = New System.Drawing.Size(251, 74)
        Me.CONSULTA.TabIndex = 17
        Me.CONSULTA.Text = "CONSULTAR"
        Me.CONSULTA.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1065, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "ID:"
        '
        'TID
        '
        Me.TID.Enabled = False
        Me.TID.Location = New System.Drawing.Point(1119, 36)
        Me.TID.Name = "TID"
        Me.TID.Size = New System.Drawing.Size(141, 20)
        Me.TID.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1051, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "TIPO:"
        '
        'TTIPO
        '
        Me.TTIPO.Enabled = False
        Me.TTIPO.Location = New System.Drawing.Point(1119, 115)
        Me.TTIPO.Name = "TTIPO"
        Me.TTIPO.Size = New System.Drawing.Size(141, 20)
        Me.TTIPO.TabIndex = 20
        '
        'CONTENEDORES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TTIPO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TID)
        Me.Controls.Add(Me.CONSULTA)
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
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data1 As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents M As System.Windows.Forms.Button
    Friend WithEvents N As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TI As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents T As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents CONSULTA As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TTIPO As System.Windows.Forms.TextBox
End Class
