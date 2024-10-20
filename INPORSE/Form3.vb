Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Runtime.InteropServices
Public Class Form3
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
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btncapaci_Click(sender As Object, e As EventArgs) Handles btncapaci.Click
        Dim url As String = "https://docs.google.com/forms/d/e/1FAIpQLSdcl1a66ZxxJ7yeFcSMoGXT70nlbpXofi3LDomwp2O5Nk8afg/viewform"
        Process.Start(url)
    End Sub

    Private Sub btnRE_Click(sender As Object, e As EventArgs) Handles btnRE.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class