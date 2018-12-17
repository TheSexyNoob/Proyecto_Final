using Database;
using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ParkingServices
{
    public class ParkingServices : IParking
    {
        private MySqlConnection MySQLConnection;

        public List<Bill> GetBills()
        {
            throw new NotImplementedException();
        }

        public List<Client> GetClients()
        {
            throw new NotImplementedException();
        }

        public List<Spot> GetSpots()
        {
            throw new NotImplementedException();
        }

        public List<Vehicule> GetVehicules()
        {
            throw new NotImplementedException();
        }

        #region Admin
        public List<Admin> GetAdmins()
        {
            List<Admin> admins = new List<Admin>();
            string queryAdmin = "CALL GetAdmins();";
            try
            {

                using (MySQLConnection = new MySqlConnection(ConnectionDBTest.DbConnString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand(queryAdmin.ToString(), MySQLConnection))
                    {

                        MySQLConnection.Open();
                        var result = cmd.ExecuteReader();
                        while (result.Read())
                        {
                            Admin admin = new Admin(
                                result.GetInt32(0),
                                result.GetString(1),
                                result.GetString(2),
                                result.GetString(3),
                                result.GetString(4),
                                result.GetInt32(5),
                                result.GetInt32(6),
                                result.GetString(7)
                                );

                            Console.WriteLine(admin.ToString());
                            admins.Add(admin);
                        }
                        MySQLConnection.Close();
                    }

                    return admins;
                }
            }
            catch (MySqlException e)
            {
                Console.Write("Ha ocurrido un error al conectar con la base de datos.\n");
                return null;
            }
        }

        public Admin GetAdmin(int Admin_ID)
        {
            #region Variables 
            Admin admin;
            int Code;
            string Name;
            string LastName;
            string SecondLastName;
            int Id;
            int Phone;
            string Mail;
            string Password;
            #endregion

            string queryAdmin = string.Format("CALL GetAdmin({0});", Admin_ID);
            try
            {
                using (MySQLConnection = new MySqlConnection(ConnectionDBTest.DbConnString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand(queryAdmin.ToString(), MySQLConnection))
                    {
                        MySQLConnection.Open();
                        var result = cmd.ExecuteReader();
                        if (result.Read())
                        {
                            Code = result.GetInt32(0);
                            Name = result.GetString(1);
                            LastName = result.GetString(2);
                            SecondLastName = result.GetString(3);
                            Id = result.GetInt32(4);
                            Phone = result.GetInt32(5);
                            Mail = result.GetString(6);
                            Password = "";

                            admin = new Admin(
                                Code,
                                Password,
                                Name,
                                LastName,
                                SecondLastName,
                                Id,
                                Phone,
                                Mail
                                );
                        }
                        else
                        {
                            admin = null;
                        }
                        MySQLConnection.Close();
                    }
                    return admin;
                }
            }
            catch (MySqlException e)
            {
                Console.Write("Ha ocurrido un error al conectar con la base de datos.\n");
                return null;
            }
        }

        public bool AdminChecker(int id, string password)
        {
            try
            {
                bool exists;        //Creamos bool para retornar.
                //queryAdmin -> Sentencia SQL que se ejecutará para buscar al empleado.
                string queryAdmin = string.Format("CALL AdminLogin({0}, N'{1}');", id, password);
                //Abrimos la conexion con la base de datos.
                using (MySQLConnection = new MySqlConnection(ConnectionDBTest.DbConnString()))
                {
                    //Creamos el objeto MySqlCommand que contendrá la sentencia SQL.
                    using (MySqlCommand cmd = new MySqlCommand(queryAdmin.ToString(), MySQLConnection))
                    {
                        MySQLConnection.Open();//Abrimos la base de datos.
                        //Ejecutamos la sentencia y los datos, los guardamos en una tabla virtual de tipo MySqlDataReader.
                        MySqlDataReader result = cmd.ExecuteReader();
                        //Si la tabla virtual contiene datos.
                        if (result.HasRows)
                        {
                            //Accion de acceso correcto.
                            exists = true;
                        }
                        //Si la consulta no devolvio datos.
                        else
                        {
                            //Acción de acceso fallido.
                            exists = false;
                        }
                        MySQLConnection.Close();//Cerramos la base de datos.
                    }
                }
                return exists;//Retornamos el objeto booleano.
            }
            catch (MySqlException e)
            {
                Console.Write("Ha ocurrido un error al conectar con la base de datos.\n");
                return false;
            }
        }
        #endregion

        #region Bill
        public void ShowBill(int id)
        {
            List<Admin> admins = new List<Admin>();
            string queryAdmin = string.Format("CALL GetBill({0});", id);
            try
            {
                using (MySQLConnection = new MySqlConnection(ConnectionDBTest.DbConnString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand(queryAdmin.ToString(), MySQLConnection))
                    {
                        MySQLConnection.Open();
                        var result = cmd.ExecuteReader();
                        if (result.Read())
                        {
                            try
                            {
                                Console.WriteLine("La Factura #" + result.GetInt32(0) + ", tiene un monto de: " + result.GetDecimal(8));
                            }
                            catch(System.Data.SqlTypes.SqlNullValueException e)
                            {
                                Console.WriteLine("La Factura #" + result.GetInt32(0) + ", tiene un monto de: 0 colones hasta el momento.");
                            }
                        }
                        MySQLConnection.Close();
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.Write("Ha ocurrido un error al conectar con la base de datos.\n");
            }
        }
        #endregion

    }//End Class
}
