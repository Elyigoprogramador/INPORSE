Imports System.Net.NetworkInformation
Imports System.Runtime.InteropServices
Imports System.Xml
Imports Microsoft.VisualBasic.ApplicationServices
Imports Org.BouncyCastle.Crypto.Digests
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClientes.Click

        lblE.Text = "REGISTRO DE CLIENTES"
        Dim CLIENTES As New CLIENTES()


        CLIENTES.TopLevel = False

        CLIENTES.FormBorderStyle = FormBorderStyle.None


        Panel3.Controls.Add(CLIENTES)


        CLIENTES.Dock = DockStyle.Fill


        CLIENTES.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnViajes.Click
        lblE.Text = "REGISTRO DE VIAJES"
        Dim VIAJES As New VIAJES()


        VIAJES.TopLevel = False

        VIAJES.FormBorderStyle = FormBorderStyle.None


        Panel3.Controls.Add(VIAJES)


        VIAJES.Dock = DockStyle.Fill


        VIAJES.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnProd.Click
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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblusuario.Text = Form1.NombreUsuario
        btnClientes.FlatAppearance.BorderSize = 0
        btnViajes.FlatAppearance.BorderSize = 0
        btnProd.FlatAppearance.BorderSize = 0
        btnCont.FlatAppearance.BorderSize = 0
        btnCab.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.BorderSize = 0
        btnMaximizar.Visible = False
    End Sub
    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        btnRestaurar.Visible = True
        btnMaximizar.Visible = False
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Form1.Close()
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClientes_MouseMove(sender As Object, e As MouseEventArgs) Handles btnClientes.MouseMove
        btnClientes.BackColor = Color.Silver
    End Sub

    Private Sub btnClientes_MouseLeave(sender As Object, e As EventArgs) Handles btnClientes.MouseLeave
        btnClientes.BackColor = Color.Black
    End Sub

    Private Sub btnViajes_MouseMove(sender As Object, e As MouseEventArgs) Handles btnViajes.MouseMove
        btnViajes.BackColor = Color.Silver
    End Sub

    Private Sub btnViajes_MouseLeave(sender As Object, e As EventArgs) Handles btnViajes.MouseLeave
        btnViajes.BackColor = Color.Black
    End Sub

    Private Sub btnProd_MouseMove(sender As Object, e As MouseEventArgs) Handles btnProd.MouseMove
        btnProd.BackColor = Color.Silver

    End Sub

    Private Sub btnProd_MouseLeave(sender As Object, e As EventArgs) Handles btnProd.MouseLeave
        btnProd.BackColor = Color.Black
    End Sub

    Private Sub btnCont_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCont.MouseMove
        btnCont.BackColor = Color.Silver
    End Sub

    Private Sub btnCont_MouseLeave(sender As Object, e As EventArgs) Handles btnCont.MouseLeave
        btnCont.BackColor = Color.Black
    End Sub

    Private Sub btnCab_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCab.MouseMove
        btnCab.BackColor = Color.Silver
    End Sub

    Private Sub btnCab_MouseLeave(sender As Object, e As EventArgs) Handles btnCab.MouseLeave
        btnCab.BackColor = Color.Black
    End Sub

    Private Sub Button3_MouseMove(sender As Object, e As MouseEventArgs) Handles Button3.MouseMove
        Button3.BackColor = Color.Silver
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.Black
    End Sub

    Private Sub Button5_MouseMove(sender As Object, e As MouseEventArgs) Handles Button5.MouseMove
        Button5.BackColor = Color.Silver
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.BackColor = Color.Black
    End Sub


End Class