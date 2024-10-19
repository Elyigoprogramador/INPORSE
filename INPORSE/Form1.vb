
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Runtime.InteropServices
Public Class Form1


    <DllImport("User32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub


    <DllImport("User32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private isFormBeingDragged As Boolean = False
    Private X As Integer
    Private Y As Integer

    Private intentosFallidos As Integer = 0
    Public Shared NombreUsuario As String

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click


        'EN CASO DE QUE CUALQUIER DE LOS DOS SEA CORRECTO
        If txtContra.Text = "102421" And txtUser.Text = "Mario Escalante" Then
            NombreUsuario = "Mario Escalante"
            intentosFallidos = 0
            NombreUsuario = txtUser.Text
            Dim form2 As New Form2
            form2.Show()
            form2.Button3.Visible = False
            Form2.Button3.Enabled = False
            Form2.Show()
            txtUser.Text = ""
            txtContra.Text = ""
            Me.Hide()
        ElseIf txtContra.Text = "200618" And txtUser.Text = "Rodrigo Hernandez" Then
            NombreUsuario = "Rodrigo Hernandez"
            intentosFallidos = 0
            NombreUsuario = txtUser.Text
            Dim form2 As New Form2
            form2.Panel5.BackgroundImage = My.Resources.YigoJuan
            form2.Panel5.BackgroundImageLayout = ImageLayout.Stretch
            form2.Show()
            form2.Button3.Visible = True
            Form2.Button3.Enabled = True
            Form2.Show()
            txtUser.Text = ""
            txtContra.Text = ""
            Me.Hide()

        ElseIf txtContra.Text = "200618" And txtUser.Text = "Anna Shantall" Then
            NombreUsuario = "Anna Alegria"
            intentosFallidos = 0
            NombreUsuario = txtUser.Text
            Dim form2 As New Form2
            form2.Panel5.BackgroundImage = My.Resources.Anna
            form2.Panel5.BackgroundImageLayout = ImageLayout.Stretch
            form2.Show()
            form2.Button3.Visible = True
            Form2.Button3.Enabled = True
            txtUser.Text = ""
            txtContra.Text = ""
            Me.Hide()
        ElseIf txtContra.Text = "200618" And txtUser.Text = "Cesar Lemus" Then
            NombreUsuario = "Cesar Lemus"
            intentosFallidos = 0
            NombreUsuario = txtUser.Text
            Dim form2 As New Form2
            form2.Show()
            form2.Button3.Visible = True
            Form2.Button3.Enabled = True
            Form2.Show()
            txtUser.Text = ""
            txtContra.Text = ""
            Me.Hide()

            'AMBOS LOGIN
        ElseIf txtContra.Text = "" Or txtUser.Text = "" Then
            MsgBox("INGRESE UNA CLAVE.")
            txtUser.Clear()
            txtContra.Clear()

            'PARA LOGIN DE ADMINISTRADOR
        ElseIf txtContra.Text <> "INPORSE123" And txtUser.Text = "Administrador" Then
            lblpassw.Visible = True
            intentosFallidos += 1
            txtContra.Clear()
        ElseIf txtContra.Text = "INPORSE123" And txtUser.Text <> "Administrador" Then
            lbluser.Visible = True
            txtUser.Clear()
        ElseIf txtContra.Text <> "INPORSE123" And txtUser.Text <> "Administrador" Then
            lbluser.Visible = True
            lblpassw.Visible = True
            txtUser.Clear()
            txtContra.Clear()
            'PARA LOGIN DE EMPLEADO
        ElseIf txtContra.Text <> "102421" And txtUser.Text = "Empleado" Then
            lblpassw.Visible = True
            intentosFallidos += 1
            txtContra.Clear()
        ElseIf txtContra.Text = "102421" And txtUser.Text <> "Empleado" Then
            lbluser.Visible = True
            txtUser.Clear()
        ElseIf txtContra.Text <> "102421" And txtUser.Text <> "Empleado" Then
            lbluser.Visible = True
            lblpassw.Visible = True
            txtUser.Clear()
            txtContra.Clear()
            If intentosFallidos >= 3 Then
                MessageBox.Show("Demasiados intentos, El ingreso se bloqueara.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnInicio.Enabled = False
            End If
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContra.BorderStyle = BorderStyle.None
        txtContra.BackColor = Me.BackColor ' Cambia esto al color del fondo de tu formulario
        txtContra.ForeColor = Color.White
        txtUser.BorderStyle = BorderStyle.None
        txtUser.BackColor = Me.BackColor ' Cambia esto al color del fondo de tu formulario
        txtUser.ForeColor = Color.White




    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Function GenerarCodigoDesbloqueo() As String

        Dim random As New Random()
        Return random.Next(100000, 999999).ToString()
    End Function
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim result As DialogResult = MessageBox.Show("¿Desea solicitar un código de desbloqueo?", "Solicitud de Código", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Dim contrasenaIngresada As String = InputBox("Por favor, ingrese la contraseña:", "Verificación de Contraseña")

            If contrasenaIngresada = "INPORSE123" Then

                Dim codigoDesbloqueo As String = GenerarCodigoDesbloqueo()
                MessageBox.Show("Su código de desbloqueo es: " & codigoDesbloqueo, "Código de Desbloqueo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim codigoIngresado As String = InputBox("Ingrese el código de desbloqueo:", "Verificación de Código")


                If codigoIngresado = codigoDesbloqueo Then

                    Dim siguienteFormulario As New Form2()
                    siguienteFormulario.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Código de desbloqueo incorrecto. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Contraseña incorrecta. No se puede proceder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MoverLabel_Tick(sender As Object, e As EventArgs) Handles MoverLabel.Tick

        lblEmpresa.Left += 7


        If lblEmpresa.Left > Panel4.Width Then
            lblEmpresa.Left = -lblEmpresa.Width
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            isFormBeingDragged = True
            X = e.X
            Y = e.Y
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isFormBeingDragged Then
            Dim newX As Integer = Me.Left + (e.X - X)
            Dim newY As Integer = Me.Top + (e.Y - Y)
            Me.SetDesktopLocation(newX, newY)
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            isFormBeingDragged = False
        End If
    End Sub


    Private Sub btnInicio_MouseEnter(sender As Object, e As EventArgs) Handles btnInicio.MouseEnter
        btnInicio.BackColor = Color.LightGray
    End Sub

    Private Sub btnInicio_MouseLeave(sender As Object, e As EventArgs) Handles btnInicio.MouseLeave
        btnInicio.BackColor = Color.Black
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

        MoverLabel.Interval = 50
        MoverLabel.Start()
    End Sub

    Private Sub btnCerrar_MouseEnter(sender As Object, e As EventArgs) Handles btnCerrar.MouseEnter
        btnCerrar.BackColor = Color.LightGray
    End Sub

    Private Sub btnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles btnCerrar.MouseLeave
        btnCerrar.BackColor = Color.White
    End Sub

   
End Class
