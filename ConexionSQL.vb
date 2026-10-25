Imports Microsoft.Data.SqlClient

Public Class ConexionDataSQL 'Creamos una clase para la conexion a la base de datos'

    Private ReadOnly cadenaConexion As String = 'Variable con la cadena de conexion a la base de datos'
        "Server=MCFLU;" &
        "Database=TestCenter;" &
        "Integrated Security=True;" &
        "TrustServerCertificate=True;"

    Public Function ObtenerConexion() As SqlConnection 'Creamos una funcion que nos devuelve la conexion a la base de datos'

        Return New SqlConnection(cadenaConexion) 'Nos devuelve la conexion a la base de datos'

    End Function

End Class