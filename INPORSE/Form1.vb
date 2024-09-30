
Public Class Form1

    Private intentosFallidos As Integer = 0

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click

        If txtContra.Text = "INPORSE123" Then
            intentosFallidos = 0
            Form2.Show()
            txtContra.Text = ""
            Me.Hide()
        ElseIf txtContra.Text = "" Then
            MsgBox("INGRESE UNA CLAVE.")
            txtContra.Clear()
        Else
            MessageBox.Show("Clave incorrecta. Intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            intentosFallidos += 1
            txtContra.Clear()

            If intentosFallidos >= 3 Then
                MessageBox.Show("Demasiados intentos, El ingreso se bloqueara.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnInicio.Enabled = False
            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoverLabel.Interval = 50
        MoverLabel.Start()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblEmpresa.Click

    End Sub

    Private Sub MoverLabel_Tick(sender As Object, e As EventArgs) Handles MoverLabel.Tick

        lblEmpresa.Left += 5


        If lblEmpresa.Left > Me.Width Then
            lblEmpresa.Left = -lblEmpresa.Width
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
