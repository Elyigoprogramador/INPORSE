<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.BTNCAP = New System.Windows.Forms.Button()
        Me.BTNEDICION = New System.Windows.Forms.Button()
        Me.PNLCA = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PNLCA.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNCAP
        '
        Me.BTNCAP.BackColor = System.Drawing.Color.Transparent
        Me.BTNCAP.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNCAP.FlatAppearance.BorderColor = System.Drawing.Color.MintCream
        Me.BTNCAP.FlatAppearance.BorderSize = 6
        Me.BTNCAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCAP.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCAP.ForeColor = System.Drawing.Color.LavenderBlush
        Me.BTNCAP.Location = New System.Drawing.Point(0, 0)
        Me.BTNCAP.Name = "BTNCAP"
        Me.BTNCAP.Size = New System.Drawing.Size(900, 91)
        Me.BTNCAP.TabIndex = 0
        Me.BTNCAP.Text = "CAPACITACIÓN"
        Me.BTNCAP.UseVisualStyleBackColor = False
        '
        'BTNEDICION
        '
        Me.BTNEDICION.BackColor = System.Drawing.Color.Transparent
        Me.BTNEDICION.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNEDICION.FlatAppearance.BorderColor = System.Drawing.Color.MintCream
        Me.BTNEDICION.FlatAppearance.BorderSize = 6
        Me.BTNEDICION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEDICION.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEDICION.ForeColor = System.Drawing.Color.LavenderBlush
        Me.BTNEDICION.Location = New System.Drawing.Point(0, 91)
        Me.BTNEDICION.Name = "BTNEDICION"
        Me.BTNEDICION.Size = New System.Drawing.Size(900, 89)
        Me.BTNEDICION.TabIndex = 1
        Me.BTNEDICION.Text = "REDISTRO DE DATOS"
        Me.BTNEDICION.UseVisualStyleBackColor = False
        '
        'PNLCA
        '
        Me.PNLCA.BackgroundImage = CType(resources.GetObject("PNLCA.BackgroundImage"), System.Drawing.Image)
        Me.PNLCA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PNLCA.Controls.Add(Me.BTNEDICION)
        Me.PNLCA.Controls.Add(Me.BTNCAP)
        Me.PNLCA.Location = New System.Drawing.Point(0, 37)
        Me.PNLCA.Name = "PNLCA"
        Me.PNLCA.Size = New System.Drawing.Size(900, 184)
        Me.PNLCA.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel4.Controls.Add(Me.btnMaximizar)
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.btnCerrar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(900, 36)
        Me.Panel4.TabIndex = 12
        '
        'btnMaximizar
        '
        Me.btnMaximizar.BackgroundImage = CType(resources.GetObject("btnMaximizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaximizar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMaximizar.Location = New System.Drawing.Point(1298, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(40, 35)
        Me.btnMaximizar.TabIndex = 15
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button6.Location = New System.Drawing.Point(1252, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 35)
        Me.Button6.TabIndex = 14
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "GRUPO INPORSE "
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Location = New System.Drawing.Point(860, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 36)
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 221)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PNLCA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.PNLCA.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNCAP As Button
    Friend WithEvents BTNEDICION As Button
    Friend WithEvents PNLCA As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCerrar As Button
End Class
