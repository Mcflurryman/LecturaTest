Imports Microsoft.VisualBasic
Imports Microsoft.Data.SqlClient



Public Class AbrirConexionSQL 'Creamos un clase'
    Private ReadOnly db As New ConexionDataSQL() 'Creamos un objeto de nuestra clase ConexionSQL (Conexiones/ConexionSQL.vb)'
    Public Sub ComprobarConexion() 'Creamos Sub'
        Try 'probamos'

            Using conexion As SqlConnection = db.ObtenerConexion() ' llamamos a la funcion que nos devuelve la conexion preparada'
                conexion.Open() 'Abrimos'
                MessageBox.Show("Conexión a la base de datos establecida correctamente.", "Conexión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Creamos un mensaje de que la conexion se ha realizado correctamente'
            End Using 'Cerramos conexion cuando no la utilizamos'

        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Controlamos errores'
        End Try
    End Sub

End Class

