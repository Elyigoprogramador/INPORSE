Public Class SUPEVISOR

    Private Sub SUPEVISOR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
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

    
End Class