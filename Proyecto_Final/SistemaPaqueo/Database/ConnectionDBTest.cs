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
        private string Server;
        private string Database;
        private string UID;
        private string Password;
        public static MySqlConnection ConnBD;
        #endregion

        #region Builder
        /// <summary>
        /// Aqui se indicaran los valores que se deben de tener para hacer la conexion a la base de datos.
        /// </summary>
        public ConnectionDBTest()
        {
            /*
             * Estos seran los datos que se usara para conectarse con la base de datos MySQL.
             * Este usuario y contraseña es distinto al que se usará en el programa.
             * Este solo servira para poder obtener e intorducir los datos a la base de datos.
             */

            Server   = "localhost";
            Database = "ParkingDB";
            UID      = "ParkingAdmin";
            Password = "ParkingAdmin";
        }
        #endregion

        #region Methods
        /// <summary>
        /// Metodo que retorna la cadena de conexion.
        /// </summary>
        /// <returns></returns>
        public MySqlConnection ReturnDBConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = Server;
            builder.Database = Database;
            builder.UserID = UID;
            builder.Password = Password;
            string connString = builder.ToString();
            builder = null;
            ConnBD = new MySqlConnection(connString);
            return ConnBD;
        }
        #endregion
    }
}