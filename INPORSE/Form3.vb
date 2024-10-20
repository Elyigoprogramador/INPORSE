Imports MySql.Data.MySqlClient
Public Class Form3
  
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'crear una conexion a la base de datos MySQL
        Dim conexion As New MySqlConnection("Server=localhost; User ID=root; Password=admin123; Port=3306; Database=INPORSE;")

        ' Comando SQL para seleccionar los datps de la tabla 
        Dim sqlQuery As String = "SELECT * FROM CLIENTE"
        Dim SqlCommand As New MySqlCommand(sqlQuery, conexion)

        Try
            'Abre la conexion
            conexion.Open()

            'crea un datable como fuente de datos del dataGridView
            Dim dataTable As New DataTable()
            Dim adapter As New MySqlDataAdapter(SqlCommand)
            adapter.Fill(dataTable)

            'asigna el dataTable como fuente de datos de datagridview
            data1.DataSource = dataTable

        Catch ex As MySqlException
            ' muestra un mensaje en caso de error
            MessageBox.Show("Error:" & ex.Message)
        Finally
            'Cierra la conexion si esta abierta
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub
End Class