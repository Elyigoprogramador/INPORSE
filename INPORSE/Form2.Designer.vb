<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnViajes = New System.Windows.Forms.Button()
        Me.btnProd = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCab = New System.Windows.Forms.Button()
        Me.btnCont = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.White
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClientes.Location = New System.Drawing.Point(12, 135)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(223, 43)
        Me.btnClientes.TabIndex = 3
        Me.btnClientes.Text = "CLIENTES"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnViajes
        '
        Me.btnViajes.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViajes.Image = CType(resources.GetObject("btnViajes.Image"), System.Drawing.Image)
        Me.btnViajes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnViajes.Location = New System.Drawing.Point(15, 194)
        Me.btnViajes.Name = "btnViajes"
        Me.btnViajes.Size = New System.Drawing.Size(166, 42)
        Me.btnViajes.TabIndex = 4
        Me.btnViajes.Text = "VIAJES"
        Me.btnViajes.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnViajes.UseVisualStyleBackColor = True
        '
        'btnProd
        '
        Me.btnProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProd.Image = CType(resources.GetObject("btnProd.Image"), System.Drawing.Image)
        Me.btnProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProd.Location = New System.Drawing.Point(12, 254)
        Me.btnProd.Name = "btnProd"
        Me.btnProd.Size = New System.Drawing.Size(272, 52)
        Me.btnProd.TabIndex = 5
        Me.btnProd.Text = "PRODUCTOS"
        Me.btnProd.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnProd.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Location = New System.Drawing.Point(0, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(46, 30)
        Me.Button5.TabIndex = 7
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnMaximizar)
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.btnRestaurar)
        Me.Panel4.Controls.Add(Me.btnCerrar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1386, 35)
        Me.Panel4.TabIndex = 11
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
        'btnRestaurar
        '
        Me.btnRestaurar.BackgroundImage = CType(resources.GetObject("btnRestaurar.BackgroundImage"), System.Drawing.Image)
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRestaurar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRestaurar.Location = New System.Drawing.Point(1306, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(40, 35)
        Me.btnRestaurar.TabIndex = 12
        Me.btnRestaurar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCerrar.Location = New System.Drawing.Point(1346, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 35)
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnCab)
        Me.Panel1.Controls.Add(Me.btnCont)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.btnClientes)
        Me.Panel1.Controls.Add(Me.btnViajes)
        Me.Panel1.Controls.Add(Me.btnProd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 703)
        Me.Panel1.TabIndex = 13
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(12, 474)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(272, 48)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "MOTORISTAS"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sylfaen", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-8, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(394, 44)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Ventana de acceso a tablas"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(392, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1103, 686)
        Me.Panel2.TabIndex = 14
        '
        'btnCab
        '
        Me.btnCab.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCab.Image = CType(resources.GetObject("btnCab.Image"), System.Drawing.Image)
        Me.btnCab.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCab.Location = New System.Drawing.Point(12, 401)
        Me.btnCab.Name = "btnCab"
        Me.btnCab.Size = New System.Drawing.Size(258, 50)
        Me.btnCab.TabIndex = 11
        Me.btnCab.Text = "CABEZALES"
        Me.btnCab.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCab.UseVisualStyleBackColor = True
        '
        'btnCont
        '
        Me.btnCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCont.Image = CType(resources.GetObject("btnCont.Image"), System.Drawing.Image)
        Me.btnCont.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCont.Location = New System.Drawing.Point(12, 324)
        Me.btnCont.Name = "btnCont"
        Me.btnCont.Size = New System.Drawing.Size(339, 46)
        Me.btnCont.TabIndex = 10
        Me.btnCont.Text = "CONTENEDORES"
        Me.btnCont.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCont.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(626, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 52)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "EDICION DE DATOS"
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(395, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1141, 636)
        Me.Panel3.TabIndex = 16
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1386, 738)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents btnViajes As System.Windows.Forms.Button
    Friend WithEvents btnProd As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCont As Button
    Friend WithEvents btnCab As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnRestaurar As Button
End Class
