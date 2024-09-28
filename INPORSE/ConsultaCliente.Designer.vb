<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaCliente
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
        Me.UP = New System.Windows.Forms.TextBox()
        Me.NOM = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.data2 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.data2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UP
        '
        Me.UP.Enabled = False
        Me.UP.Location = New System.Drawing.Point(223, 483)
        Me.UP.Name = "UP"
        Me.UP.Size = New System.Drawing.Size(141, 20)
        Me.UP.TabIndex = 27
        '
        'NOM
        '
        Me.NOM.Enabled = False
        Me.NOM.Location = New System.Drawing.Point(140, 427)
        Me.NOM.Name = "NOM"
        Me.NOM.Size = New System.Drawing.Size(141, 20)
        Me.NOM.TabIndex = 26
        '
        'ID
        '
        Me.ID.Enabled = False
        Me.ID.Location = New System.Drawing.Point(104, 385)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(141, 20)
        Me.ID.TabIndex = 25
        '
        'data2
        '
        Me.data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data2.Location = New System.Drawing.Point(80, 33)
        Me.data2.Name = "data2"
        Me.data2.Size = New System.Drawing.Size(713, 323)
        Me.data2.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 486)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "UNIDAD DEL PRODUCTO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "NOMBRE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 388)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "ID:"
        '
        'ConsultaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 668)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UP)
        Me.Controls.Add(Me.NOM)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.data2)
        Me.Name = "ConsultaCliente"
        Me.Text = "Consultas1"
        CType(Me.data2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UP As TextBox
    Friend WithEvents NOM As TextBox
    Friend WithEvents ID As TextBox
    Friend WithEvents data2 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
