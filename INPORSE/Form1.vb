
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
End Class
