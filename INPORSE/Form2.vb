Imports System.Net.NetworkInformation
Imports System.Runtime.InteropServices
Imports System.Xml
Imports Microsoft.VisualBasic.ApplicationServices
Imports Org.BouncyCastle.Crypto.Digests
Imports Guna.UI2.WinForms
Imports iTextSharp.text.pdf.codec.wmf
Imports System.Security.Cryptography
Public Class Form2


    <DllImport("User32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub


    <DllImport("User32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Panel4_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel4.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblusuario.Text = Form1.NombreUsuario
        btnViajes.FlatAppearance.BorderSize = 0
        btnCont.FlatAppearance.BorderSize = 0
        btnCab.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.BorderSize = 0
        contrae.Interval = 100
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Opacity = 0
        lblE.Text = "REGISTRO DE CLIENTES"
        Dim CLIENTES As New CLIENTES()


        CLIENTES.TopLevel = False

        CLIENTES.FormBorderStyle = FormBorderStyle.None


        Panel3.Controls.Add(CLIENTES)


        CLIENTES.Dock = DockStyle.Fill


        CLIENTES.Show()

    End Sub
    Private Sub animTimer_Tick(sender As Object, e As EventArgs) Handles contrae.Tick

        Panel3.Width = Panel3.Width + 400

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnViajes.Click

        lblE.Text = "REGISTRO DE VIAJES"
            Dim VIAJES As New VIAJES()

            VIAJES.TopLevel = False
            VIAJES.FormBorderStyle = FormBorderStyle.None

            Panel3.Controls.Clear()
            Panel3.Controls.Add(VIAJES)

            VIAJES.Dock = DockStyle.Fill
            VIAJES.Show()


    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs)
        lblE.Text = "REGISTRO DE PRODUCTOS"
        Dim PRODUCTOS As New PRODUCTOS()


        PRODUCTOS.TopLevel = False

        PRODUCTOS.FormBorderStyle = FormBorderStyle.None


        Panel3.Controls.Add(PRODUCTOS)


        PRODUCTOS.Dock = DockStyle.Fill


        PRODUCTOS.Show()
    End Sub

    Private Sub btnCont_Click(sender As Object, e As EventArgs) Handles btnCont.Click
        lblE.Text = "REGISTRO DE CONTENEDORES"
        Dim CONTENEDORES As New CONTENEDORES()


        CONTENEDORES.TopLevel = False

        CONTENEDORES.FormBorderStyle = FormBorderStyle.None


        Panel3.Controls.Add(CONTENEDORES)


        CONTENEDORES.Dock = DockStyle.Fill


        CONTENEDORES.Show()
    End Sub

    Private Sub btnCab_Click(sender As Object, e As EventArgs) Handles btnCab.Click
        lblE.Text = "REGISTRO DE CABEZALES"
        Dim CABEZALES As New CABEZALES()


        CABEZALES.TopLevel = False

        CABEZALES.FormBorderStyle = FormBorderStyle.None


        Panel3.Controls.Add(CABEZALES)


        CABEZALES.Dock = DockStyle.Fill


        CABEZALES.Show()
    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        lblE.Text = "REGISTRO DE MOTORISTAS"
        Dim MOTORISTAS As New CON()


        MOTORISTAS.TopLevel = False

        MOTORISTAS.FormBorderStyle = FormBorderStyle.None


        Panel3.Controls.Add(MOTORISTAS)


        MOTORISTAS.Dock = DockStyle.Fill


        MOTORISTAS.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Hide()
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
<<<<<<< HEAD
        Dim result As DialogResult = MessageBox.Show("¿Seguro que deseas cerrar el formulario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
            Form1.Close()
        End If
=======
        Me.Close()
        Form1.Close()
        Form3.Close()
>>>>>>> 1180661 (2024/10/19)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
    End Sub

End Class