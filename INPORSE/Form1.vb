
Public Class Form1

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click

        If txtContra.Text = "INPORSE123" Then
            Form2.Show()
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class
