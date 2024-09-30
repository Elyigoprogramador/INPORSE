Public Class SUPEVISOR

    Private Sub SUPEVISOR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.Show()
        Me.Hide()

    End Sub



    Private Sub btnInicio_Click_1(sender As Object, e As EventArgs) Handles btnInicio.Click
        If txtContra.Text = "ADMIN123" Then
            SUPERVISORENTRAR.Show()
            txtContra.Text = ""
            Me.Hide()
        ElseIf txtContra.Text = "" Then
            MsgBox("INGRESE UNA CLAVE.")
            txtContra.Clear()
        Else
            MsgBox("INGRESE UNA CLAVE VALIDA.")
            txtContra.Clear()
        End If
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

            If contrasenaIngresada = "ADMIN123" Then

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
End Class