Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Configuration

Class Connection
    'Conexión a la base de datos mysql
    Public Shared Function conexion() As MySqlConnection
        Return New MySqlConnection(ConfigurationManager.ConnectionStrings("MySqlConnectionString").ConnectionString)
    End Function
End Class
