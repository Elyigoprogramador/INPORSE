<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRODUCTOS
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
        Me.CON = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tnombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tid = New System.Windows.Forms.TextBox()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 469)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "UNIDAD DEL PRODUCTO:"
        '
        'UP
        '
        Me.UP.Enabled = False
        Me.UP.Location = New System.Drawing.Point(164, 462)
        Me.UP.Name = "UP"
        Me.UP.Size = New System.Drawing.Size(141, 20)
        Me.UP.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 413)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "NOMBRE:"
        '
        'NOM
        '
        Me.NOM.Enabled = False
        Me.NOM.Location = New System.Drawing.Point(164, 413)
        Me.NOM.Name = "NOM"
        Me.NOM.Size = New System.Drawing.Size(141, 20)
        Me.NOM.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ID:"
        '
        'ID
        '
        Me.ID.Enabled = False
        Me.ID.Location = New System.Drawing.Point(164, 371)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(141, 20)
        Me.ID.TabIndex = 19
        '
        'ELIMINAR
        '
        Me.ELIMINAR.Location = New System.Drawing.Point(773, 261)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(251, 74)
        Me.ELIMINAR.TabIndex = 18
        Me.ELIMINAR.Text = "ELIMINAR"
        Me.ELIMINAR.UseVisualStyleBackColor = True
        '
        'M
        '
        Me.M.Location = New System.Drawing.Point(773, 129)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(251, 74)
        Me.M.TabIndex = 17
        Me.M.Text = "MODIFICAR"
        Me.M.UseVisualStyleBackColor = True
        '
        'N
        '
        Me.N.Location = New System.Drawing.Point(773, 12)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(251, 74)
        Me.N.TabIndex = 16
        Me.N.Text = "NUEVO"
        Me.N.UseVisualStyleBackColor = True
        '
        'data1
        '
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data1.Location = New System.Drawing.Point(21, 12)
        Me.data1.Name = "data1"
        Me.data1.Size = New System.Drawing.Size(713, 323)
        Me.data1.TabIndex = 15
        '
        'CON
        '
        Me.CON.Location = New System.Drawing.Point(773, 359)
        Me.CON.Name = "CON"
        Me.CON.Size = New System.Drawing.Size(251, 74)
        Me.CON.TabIndex = 25
        Me.CON.Text = "CONSULTAR"
        Me.CON.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1057, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "NOMBRE:"
        '
        'Tnombre
        '
        Me.Tnombre.Enabled = False
        Me.Tnombre.Location = New System.Drawing.Point(1203, 69)
        Me.Tnombre.Name = "Tnombre"
        Me.Tnombre.Size = New System.Drawing.Size(141, 20)
        Me.Tnombre.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1057, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "ID:"
        '
        'Tid
        '
        Me.Tid.Enabled = False
        Me.Tid.Location = New System.Drawing.Point(1203, 27)
        Me.Tid.Name = "Tid"
        Me.Tid.Size = New System.Drawing.Size(141, 20)
        Me.Tid.TabIndex = 26
        '
        'PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Tnombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Tid)
        Me.Controls.Add(Me.CON)
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
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NOM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.TextBox
    Friend WithEvents ELIMINAR As System.Windows.Forms.Button
    Friend WithEvents M As System.Windows.Forms.Button
    Friend WithEvents N As System.Windows.Forms.Button
    Friend WithEvents data1 As System.Windows.Forms.DataGridView
    Friend WithEvents CON As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Tid As System.Windows.Forms.TextBox
End Class
