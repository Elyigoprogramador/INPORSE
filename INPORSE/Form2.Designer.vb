﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCab = New System.Windows.Forms.Button()
        Me.btnCont = New System.Windows.Forms.Button()
        Me.lblE = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.Black
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(3, 193)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(342, 48)
        Me.btnClientes.TabIndex = 3
        Me.btnClientes.Text = "CLIENTES"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnViajes
        '
        Me.btnViajes.BackColor = System.Drawing.Color.SteelBlue
        Me.btnViajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViajes.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViajes.ForeColor = System.Drawing.Color.Black
        Me.btnViajes.Image = CType(resources.GetObject("btnViajes.Image"), System.Drawing.Image)
        Me.btnViajes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViajes.Location = New System.Drawing.Point(3, 258)
        Me.btnViajes.Name = "btnViajes"
        Me.btnViajes.Size = New System.Drawing.Size(342, 48)
        Me.btnViajes.TabIndex = 4
        Me.btnViajes.Text = "VIAJES"
        Me.btnViajes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnViajes.UseVisualStyleBackColor = False
        '
        'btnProd
        '
        Me.btnProd.BackColor = System.Drawing.Color.SteelBlue
        Me.btnProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProd.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProd.ForeColor = System.Drawing.Color.Black
        Me.btnProd.Image = CType(resources.GetObject("btnProd.Image"), System.Drawing.Image)
        Me.btnProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProd.Location = New System.Drawing.Point(1, 323)
        Me.btnProd.Name = "btnProd"
        Me.btnProd.Size = New System.Drawing.Size(345, 48)
        Me.btnProd.TabIndex = 5
        Me.btnProd.Text = "PRODUCTOS"
        Me.btnProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProd.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(0, 721)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(345, 30)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "LOGIN OUT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel4.Controls.Add(Me.btnMaximizar)
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.btnRestaurar)
        Me.Panel4.Controls.Add(Me.btnCerrar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.ForeColor = System.Drawing.Color.White
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
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Location = New System.Drawing.Point(1346, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 35)
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblusuario)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button3)
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
        Me.Panel1.Size = New System.Drawing.Size(347, 753)
        Me.Panel1.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(132, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "INPORSE"
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.Location = New System.Drawing.Point(131, 18)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(0, 20)
        Me.lblusuario.TabIndex = 19
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(117, 114)
        Me.Panel5.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(-1, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(338, 28)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Ventana De Aceso A Tablas"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SteelBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(2, 518)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(340, 48)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "MOTORISTAS"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
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
        Me.btnCab.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCab.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCab.ForeColor = System.Drawing.Color.Black
        Me.btnCab.Image = CType(resources.GetObject("btnCab.Image"), System.Drawing.Image)
        Me.btnCab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCab.Location = New System.Drawing.Point(2, 453)
        Me.btnCab.Name = "btnCab"
        Me.btnCab.Size = New System.Drawing.Size(340, 48)
        Me.btnCab.TabIndex = 11
        Me.btnCab.Text = "CABEZALES"
        Me.btnCab.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCab.UseVisualStyleBackColor = False
        '
        'btnCont
        '
        Me.btnCont.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCont.Font = New System.Drawing.Font("Century Gothic", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCont.ForeColor = System.Drawing.Color.Black
        Me.btnCont.Image = CType(resources.GetObject("btnCont.Image"), System.Drawing.Image)
        Me.btnCont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCont.Location = New System.Drawing.Point(1, 388)
        Me.btnCont.Name = "btnCont"
        Me.btnCont.Size = New System.Drawing.Size(341, 45)
        Me.btnCont.TabIndex = 10
        Me.btnCont.Text = "CONTENEDORES"
        Me.btnCont.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCont.UseVisualStyleBackColor = False
        '
        'lblE
        '
        Me.lblE.AutoSize = True
        Me.lblE.Font = New System.Drawing.Font("Century Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE.ForeColor = System.Drawing.Color.White
        Me.lblE.Location = New System.Drawing.Point(626, 35)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(387, 47)
        Me.lblE.TabIndex = 15
        Me.lblE.Text = "EDICION DE DATOS"
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(352, 85)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1184, 703)
        Me.Panel3.TabIndex = 16
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblE)
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblE As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblusuario As Label
    Friend WithEvents Panel5 As Panel
End Class
