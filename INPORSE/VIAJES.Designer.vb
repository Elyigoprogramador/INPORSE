﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VIAJES
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EST = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CAB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.R = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IDC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDV = New System.Windows.Forms.TextBox()
        Me.ELIMINAR = New System.Windows.Forms.Button()
        Me.M = New System.Windows.Forms.Button()
        Me.data1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.COBRO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IDCON = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CANTIDAD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IDP = New System.Windows.Forms.TextBox()
        Me.N = New System.Windows.Forms.Button()
        Me.CON = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TID = New System.Windows.Forms.TextBox()
        Me.RUTA = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ESTADO = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CABEZAL = New System.Windows.Forms.TextBox()
        Me.pnlconsulta = New System.Windows.Forms.Panel()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.Timercontrae = New System.Windows.Forms.Timer(Me.components)
        Me.Timerdesplegar = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlconsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(322, 384)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "ESTADO:"
        '
        'EST
        '
        Me.EST.Enabled = False
        Me.EST.Location = New System.Drawing.Point(413, 384)
        Me.EST.Name = "EST"
        Me.EST.Size = New System.Drawing.Size(141, 20)
        Me.EST.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(322, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "CABEZAL:"
        '
        'CAB
        '
        Me.CAB.Enabled = False
        Me.CAB.Location = New System.Drawing.Point(413, 331)
        Me.CAB.Name = "CAB"
        Me.CAB.Size = New System.Drawing.Size(141, 20)
        Me.CAB.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 429)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "RUTA:"
        '
        'R
        '
        Me.R.Enabled = False
        Me.R.Location = New System.Drawing.Point(102, 429)
        Me.R.Name = "R"
        Me.R.Size = New System.Drawing.Size(141, 20)
        Me.R.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 373)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "ID DEL CLIENTE:"
        '
        'IDC
        '
        Me.IDC.Enabled = False
        Me.IDC.Location = New System.Drawing.Point(102, 373)
        Me.IDC.Name = "IDC"
        Me.IDC.Size = New System.Drawing.Size(141, 20)
        Me.IDC.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ID DEL VIAJE:"
        '
        'IDV
        '
        Me.IDV.Enabled = False
        Me.IDV.Location = New System.Drawing.Point(102, 331)
        Me.IDV.Name = "IDV"
        Me.IDV.Size = New System.Drawing.Size(141, 20)
        Me.IDV.TabIndex = 19
        '
        'ELIMINAR
        '
        Me.ELIMINAR.Location = New System.Drawing.Point(342, 601)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(131, 36)
        Me.ELIMINAR.TabIndex = 18
        Me.ELIMINAR.Text = "ELIMINAR"
        Me.ELIMINAR.UseVisualStyleBackColor = True
        '
        'M
        '
        Me.M.Location = New System.Drawing.Point(342, 536)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(131, 36)
        Me.M.TabIndex = 17
        Me.M.Text = "MODIFICAR"
        Me.M.UseVisualStyleBackColor = True
        '
        'data1
        '
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column10, Me.Column9, Me.Column8, Me.Column7, Me.Column5, Me.Column4, Me.Column3, Me.Column2})
        Me.data1.Location = New System.Drawing.Point(1, 2)
        Me.data1.Name = "data1"
        Me.data1.Size = New System.Drawing.Size(744, 323)
        Me.data1.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID_VIAJE"
        Me.Column1.HeaderText = "ID DEL VIAJE"
        Me.Column1.Name = "Column1"
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "CANTIDAD"
        Me.Column10.HeaderText = "CANTIDAD DEL PRODUCTO"
        Me.Column10.Name = "Column10"
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "ID_PRODUCTOS"
        Me.Column9.HeaderText = "ID DEL PRODUCTO"
        Me.Column9.Name = "Column9"
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "ID_CONTENEDOR"
        Me.Column8.HeaderText = "ID DEL CONTENEDOR"
        Me.Column8.Name = "Column8"
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "COBRO_VIAJE"
        Me.Column7.HeaderText = "SUELDO"
        Me.Column7.Name = "Column7"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "ESTADO"
        Me.Column5.HeaderText = "ESTADO"
        Me.Column5.Name = "Column5"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "CABEZAL"
        Me.Column4.HeaderText = "CABEZAL"
        Me.Column4.Name = "Column4"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "RUTA"
        Me.Column3.HeaderText = "RUTA"
        Me.Column3.Name = "Column3"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ID_CLIENTE"
        Me.Column2.HeaderText = "ID DEL CLIENTE"
        Me.Column2.Name = "Column2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(322, 430)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "COBRO*:"
        '
        'COBRO
        '
        Me.COBRO.Enabled = False
        Me.COBRO.Location = New System.Drawing.Point(413, 430)
        Me.COBRO.Name = "COBRO"
        Me.COBRO.Size = New System.Drawing.Size(141, 20)
        Me.COBRO.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 474)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "ID DEL CONTENEDOR:"
        '
        'IDCON
        '
        Me.IDCON.Enabled = False
        Me.IDCON.Location = New System.Drawing.Point(133, 471)
        Me.IDCON.Name = "IDCON"
        Me.IDCON.Size = New System.Drawing.Size(141, 20)
        Me.IDCON.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 573)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "CANTIDAD:"
        '
        'CANTIDAD
        '
        Me.CANTIDAD.Enabled = False
        Me.CANTIDAD.Location = New System.Drawing.Point(133, 570)
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.Size = New System.Drawing.Size(141, 20)
        Me.CANTIDAD.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 520)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "ID DEL PRODUCTO:"
        '
        'IDP
        '
        Me.IDP.Enabled = False
        Me.IDP.Location = New System.Drawing.Point(133, 517)
        Me.IDP.Name = "IDP"
        Me.IDP.Size = New System.Drawing.Size(141, 20)
        Me.IDP.TabIndex = 41
        '
        'N
        '
        Me.N.Location = New System.Drawing.Point(342, 476)
        Me.N.Name = "N"
        Me.N.Size = New System.Drawing.Size(131, 35)
        Me.N.TabIndex = 45
        Me.N.Text = "NUEVO"
        Me.N.UseVisualStyleBackColor = True
        '
        'CON
        '
        Me.CON.Location = New System.Drawing.Point(1117, 471)
        Me.CON.Name = "CON"
        Me.CON.Size = New System.Drawing.Size(224, 72)
        Me.CON.TabIndex = 46
        Me.CON.Text = "CONSULTAR"
        Me.CON.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 250)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "ID DEL VIAJE:"
        '
        'TID
        '
        Me.TID.Enabled = False
        Me.TID.Location = New System.Drawing.Point(110, 250)
        Me.TID.Name = "TID"
        Me.TID.Size = New System.Drawing.Size(141, 20)
        Me.TID.TabIndex = 47
        '
        'RUTA
        '
        Me.RUTA.Enabled = False
        Me.RUTA.Location = New System.Drawing.Point(110, 291)
        Me.RUTA.Name = "RUTA"
        Me.RUTA.Size = New System.Drawing.Size(141, 20)
        Me.RUTA.TabIndex = 49
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 398)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "ESTADO:"
        '
        'ESTADO
        '
        Me.ESTADO.Enabled = False
        Me.ESTADO.Location = New System.Drawing.Point(110, 398)
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.Size = New System.Drawing.Size(141, 20)
        Me.ESTADO.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 345)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "CABEZAL:"
        '
        'CABEZAL
        '
        Me.CABEZAL.Enabled = False
        Me.CABEZAL.Location = New System.Drawing.Point(110, 345)
        Me.CABEZAL.Name = "CABEZAL"
        Me.CABEZAL.Size = New System.Drawing.Size(141, 20)
        Me.CABEZAL.TabIndex = 51
        '
        'pnlconsulta
        '
        Me.pnlconsulta.Controls.Add(Me.Label11)
        Me.pnlconsulta.Controls.Add(Me.btnmenu)
        Me.pnlconsulta.Controls.Add(Me.Label12)
        Me.pnlconsulta.Controls.Add(Me.TID)
        Me.pnlconsulta.Controls.Add(Me.ESTADO)
        Me.pnlconsulta.Controls.Add(Me.Label10)
        Me.pnlconsulta.Controls.Add(Me.Label13)
        Me.pnlconsulta.Controls.Add(Me.RUTA)
        Me.pnlconsulta.Controls.Add(Me.CABEZAL)
        Me.pnlconsulta.Location = New System.Drawing.Point(805, 2)
        Me.pnlconsulta.Name = "pnlconsulta"
        Me.pnlconsulta.Size = New System.Drawing.Size(271, 747)
        Me.pnlconsulta.TabIndex = 55
        '
        'btnmenu
        '
        Me.btnmenu.Location = New System.Drawing.Point(3, 3)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(83, 29)
        Me.btnmenu.TabIndex = 19
        Me.btnmenu.Text = "CONSULTAR"
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'Timercontrae
        '
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 294)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "RUTA:"
        '
        'VIAJES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.pnlconsulta)
        Me.Controls.Add(Me.CON)
        Me.Controls.Add(Me.N)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CANTIDAD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.IDP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.IDCON)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.COBRO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EST)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CAB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.R)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IDC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IDV)
        Me.Controls.Add(Me.ELIMINAR)
        Me.Controls.Add(Me.M)
        Me.Controls.Add(Me.data1)
        Me.Name = "VIAJES"
        Me.Text = "VIAJES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlconsulta.ResumeLayout(False)
        Me.pnlconsulta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents EST As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CAB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents R As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IDC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IDV As System.Windows.Forms.TextBox
    Friend WithEvents ELIMINAR As System.Windows.Forms.Button
    Friend WithEvents M As System.Windows.Forms.Button
    Friend WithEvents data1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents COBRO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents IDCON As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CANTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IDP As System.Windows.Forms.TextBox
    Friend WithEvents N As System.Windows.Forms.Button
    Friend WithEvents CON As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TID As System.Windows.Forms.TextBox
    Friend WithEvents RUTA As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ESTADO As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CABEZAL As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlconsulta As System.Windows.Forms.Panel
    Friend WithEvents btnmenu As System.Windows.Forms.Button
    Friend WithEvents Timercontrae As System.Windows.Forms.Timer
    Friend WithEvents Timerdesplegar As System.Windows.Forms.Timer
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class