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
        Me.Label4.Location = New System.Drawing.Point(8, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "NOMBRE:"
        '
        'TnombreE
        '
        Me.TnombreE.Enabled = False
        Me.TnombreE.Location = New System.Drawing.Point(154, 303)
        Me.TnombreE.Name = "TnombreE"
        Me.TnombreE.Size = New System.Drawing.Size(141, 20)
        Me.TnombreE.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "ID:"
        '
        'TidD
        '
        Me.TidD.Enabled = False
        Me.TidD.Location = New System.Drawing.Point(154, 261)
        Me.TidD.Name = "TidD"
        Me.TidD.Size = New System.Drawing.Size(141, 20)
        Me.TidD.TabIndex = 23
        '
        'btnmenu
        '
        Me.btnmenu.Location = New System.Drawing.Point(3, 3)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(83, 29)
        Me.btnmenu.TabIndex = 18
        Me.btnmenu.Text = "CONSULTAR"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 469)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "UNIDAD DEL PRODUCTO:"
        '
        'UP
        '
        Me.UP.Enabled = False
        Me.UP.Location = New System.Drawing.Point(155, 462)
        Me.UP.Name = "UP"
        Me.UP.Size = New System.Drawing.Size(141, 20)
        Me.UP.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 413)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "NOMBRE:"
        '
        'NOM
        '
        Me.NOM.Enabled = False
        Me.NOM.Location = New System.Drawing.Point(155, 413)
        Me.NOM.Name = "NOM"
        Me.NOM.Size = New System.Drawing.Size(141, 20)
        Me.NOM.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "ID:"
        '
        'ID
        '
        Me.ID.Enabled = False
        Me.ID.Location = New System.Drawing.Point(155, 371)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(141, 20)
        Me.ID.TabIndex = 30
        '
        'ELIMINAR
        '
        Me.ELIMINAR.Location = New System.Drawing.Point(764, 261)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(251, 74)
        Me.ELIMINAR.TabIndex = 29
        Me.ELIMINAR.Text = "ELIMINAR"
        Me.ELIMINAR.UseVisualStyleBackColor = True
        '
        'M
        '
        Me.M.Location = New System.Drawing.Point(764, 129)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(251, 74)
        Me.M.TabIndex = 28
        Me.M.Text = "MODIFICAR"
        Me.M.UseVisualStyleBackColor = True
        '
        'N
        '
        Me.N.Location = New System.Drawing.Point(764, 12)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(251, 74)
        Me.N.TabIndex = 27
        Me.N.Text = "NUEVO"
        Me.N.UseVisualStyleBackColor = True
        '
        'data1
        '
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data1.Location = New System.Drawing.Point(12, 12)
        Me.data1.Name = "data1"
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
        'PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
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
End Class
