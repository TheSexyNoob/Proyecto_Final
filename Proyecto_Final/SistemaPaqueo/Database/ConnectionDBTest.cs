using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Database
{
    public class ConnectionDBTest
    {
        #region Variables
        /*
         * Estos seran los datos que se usara para conectarse con la base de datos MySQL.
         * Este usuario y contraseña es distinto al que se usará en el programa.
         * Este solo servira para poder obtener e intorducir los datos a la base de datos
         */
        private const string Server = "localhost";
        private const string Database = "parkingdb";
        private const string UID = "ParkingAdmin";
        private const string Password = "ParkingAdmin";
        public static MySqlConnection connection;
        #endregion

        #region Builder
        public ConnectionDBTest()
        {}
        #endregion

        #region Methods
        /// <summary>
        /// Metodo que crea la cadena de conexion.
        /// </summary>
        public static string DbConnString()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = Server,
                UserID = UID,
                Password = Password,
                Database = Database,
                Port = 3306,
                SslMode = MySqlSslMode.None,
                AllowUserVariables = true
            };
            String connString = builder.ToString();
            return connString;
        }
        #endregion
    }
}