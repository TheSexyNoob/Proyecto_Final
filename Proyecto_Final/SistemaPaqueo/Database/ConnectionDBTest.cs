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
        public static MySqlConnection dbConn;
        #endregion

        #region Builder
        public ConnectionDBTest()
        {
            Server   = "localhost";
            Database = "ParkingDB";
            UID      = "ParkingAdmin";
            Password = "ParkingAdmin";
        }
        #endregion

        #region Methods
        public string ReturnDBConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = Server;
            builder.Database = Database;
            builder.UserID = UID;
            builder.Password = Password;

            string connString = builder.ToString();
            return connString;
        }
        #endregion
    }
}