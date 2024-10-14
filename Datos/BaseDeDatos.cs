using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    // Clase que maneja la conexión a la base de datos
    public class BaseDeDatos
    {
        // Propiedad estática que obtiene la cadena de conexión desde el archivo de configuración
        public static string Connection
        {
            get
            {
                // Retorna la cadena de conexión con el nombre "NWConnectionString"
                return ConfigurationManager.ConnectionStrings["NWConnectionString"].ConnectionString;
            }
        }

        // Método estático que crea y abre una conexión SQL
        public static SqlConnection GetSqlConnection()
        {
            // Crea una nueva instancia de SqlConnection usando la cadena de conexión
            SqlConnection connection = new SqlConnection(Connection);
            // Abre la conexión a la base de datos
            connection.Open();
            // Retorna la conexión abierta
            return connection;
        }
    }
}

