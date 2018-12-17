using Database;
using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ParkingServices
{
    public class ParkingServices : IParking
    {
        private MySqlConnection MySQLConn;

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

        #region TypeVehicules
        public List<TypeVehicule> GetTypeVehicule()
        {
            #region Variables
            List<TypeVehicule> Types = new List<TypeVehicule>();
            string query = "CALL GetTypes();";
            int Code;
            string Name;
            Char Type;
            #endregion
            try
            {
                using (MySQLConn = new MySqlConnection(ConnectionDBTest.DbConnString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query.ToString(), MySQLConn))
                    {
                        MySQLConn.Open();
                        var result = cmd.ExecuteReader();
                        while (result.Read())
                        {
                            try
                            {
                                Code = result.GetInt32(0);
                                Name = result.GetString(1);
                                Type = result.GetChar(2);
                                TypeVehicule Tv = new TypeVehicule(Code, Name, Type);
                                Types.Add(Tv);
                            }
                            catch (System.Data.SqlTypes.SqlNullValueException e)
                            {
                                Code = 0;
                                Name = "";
                                Type = ' ';
                                TypeVehicule Tv = new TypeVehicule(Code, Name, Type);
                            }
                        }
                        MySQLConn.Close();
                    }
                    return Types;
                }
            }
            catch (MySqlException e)
            {
                Console.Write("Ha ocurrido un error al conectar con la base de datos.\n");
                return null;
            }
        }
        public bool ExistVehicule(string Plate)
        {
            #region Variables
            bool Exists;
            string query = string.Format("CALL GetVehicule({0});", Plate);
            #endregion
            try
            {
                using (MySQLConn = new MySqlConnection(ConnectionDBTest.DbConnString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query.ToString(), MySQLConn))
                    {
                        MySQLConn.Open();
                        var result = cmd.ExecuteReader();
                        if (result.HasRows)
                        {
                            Exists = true;
                        }
                        else
                        {
                            Exists = false;
                        }
                        MySQLConn.Close();
                    }
                    return Exists;
                }
            }
            catch (MySqlException e)
            {
                Console.Write("Ha ocurrido un error al conectar con la base de datos.\n");
                return true;
            }
        }
        public void InsertVehicule(Vehicule vehicule)
        {
            try
            {
                string query = string.Format("CALL InsertVehicule({0}, N'{1}', N'{2}', {3}, {4});", vehicule.LicensePlate, vehicule.Colour, vehicule.Model, vehicule.Type, vehicule.Description);
                using (MySQLConn = new MySqlConnection(ConnectionDBTest.DbConnString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query.ToString(), MySQLConn))
                    {
                        MySQLConn.Open();
                        cmd.ExecuteNonQuery();
                        Console.Write("DONE!! Vehicule added.");
                    }
                }
                MySQLConn.Close();
            }
            catch (MySqlException e)
            {
                Console.Write("Ha ocurrido un error al conectar con la base de datos.\n");
            }
        }
        #endregion

        #region Client
        public Client GetClient(int id)
        {
            #region Variables
            Client client;
            string query = "CALL GetClient();";
            int Code;
            int ClientId;
            string Name;
            int Company;
            #endregion
            try
            {
                using (MySQLConn = new MySqlConnection(ConnectionDBTest.DbConnString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query.ToString(), MySQLConn))
                    {
                        MySQLConn.Open();
                        var result = cmd.ExecuteReader();
                        if (result.Read())
                        {
                            try
                            {
                                Code = result.GetInt32(0);
                                ClientId = result.GetInt32(1);
                                Name = result.GetString(2);
                                Company = result.GetInt32(3);
                                client = new Client(Code, ClientId, Name, Company);
                            }
                            catch (System.Data.SqlTypes.SqlNullValueException e)
                            {
                                client = null;
                            }
                        }
                        else
                        {
                            client = null;
                        }
                        MySQLConn.Close();
                    }
                    return client;
                }
            }
            catch (MySqlException e)
            {
                Console.Write("Ha ocurrido un error al conectar con la base de datos.\n");
                return null;
            }
        }
        public bool ExistClient(int id)
        {
            #region Variables
            bool Exists;
            string query = string.Format("CALL GetClient({0});", id);
            int Code;
            int ClientId;
            string Name;
            int Company;
            #endregion
            try
            {
                using (MySQLConn = new MySqlConnection(ConnectionDBTest.DbConnString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query.ToString(), MySQLConn))
                    {
                        MySQLConn.Open();
                        var result = cmd.ExecuteReader();
                        if (result.HasRows)
                        {
                            Exists = true;
                        }
                        else
                        {
                            Exists = false;
                        }
                        MySQLConn.Close();
                    }
                    return Exists;
                }
            }
            catch (MySqlException e)
            {
                Console.Write("Ha ocurrido un error al conectar con la base de datos.\n");
                return true;
            }
        }
        public void InsertClient(Client client)
        {
            try
            {
                string query = string.Format("CALL InsertClient({0}, N'{1}', {2});", client.ClientId, client.Name, client.Company);
                using (MySQLConn = new MySqlConnection(ConnectionDBTest.DbConnString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query.ToString(), MySQLConn))
                    {
                        MySQLConn.Open();
                        cmd.ExecuteNonQuery();
                        Console.Write("DONE!! Client added.");
                    }   
                }
            MySQLConn.Close();
            }
            catch (MySqlException e)
            {
                Console.Write("Ha ocurrido un error al conectar con la base de datos.\n");
            }
        }
        #endregion

        #region Company
        public List<Company> GetCompanies()
        {
            #region Variables
            List<Company> companies = new List<Company>();
            string query = "CALL GetCompanies();";
            int Code;
            string Name;
            int Phone;
            #endregion
            try
            {
                using (MySQLConn = new MySqlConnection(ConnectionDBTest.DbConnString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query.ToString(), MySQLConn))
                    {
                        MySQLConn.Open();
                        var result = cmd.ExecuteReader();
                        while (result.Read())
                        {
                            try
                            {
                                Code = result.GetInt32(0);
                                Name = result.GetString(1);
                                Phone = result.GetInt32(2);
                                Company company = new Company(Code, Name, Phone);
                                companies.Add(company);
                                Console.Write(company.ToString());
                            }
                            catch(System.Data.SqlTypes.SqlNullValueException e)
                            {
                                Code = result.GetInt32(0);
                                Name = result.GetString(1);
                                Company company = new Company(Code, Name, 0);
                                companies.Add(company);
                                Console.Write(company.ToString());
                            }
                        }
                        MySQLConn.Close();
                    }
                    return companies;
                }
            }
            catch (MySqlException e)
            {
                Console.Write("Ha ocurrido un error al conectar con la base de datos.\n");
                return null;
            }
        }

        public void InsertCompany(Company company)
        {
            try
            {
                string query = string.Format("CALL InsertCompany(N'{0}', {1})", company.Name, company.Phone);
                using (MySQLConn = new MySqlConnection(ConnectionDBTest.DbConnString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query.ToString(), MySQLConn))
                    {
                        cmd.ExecuteNonQuery();
                        Console.Write("DONE!! Company added.");
                    }                    
                }
                MySQLConn.Close();
            }
            catch (MySqlException e)
            {
                Console.Write("Ha ocurrido un error al conectar con la base de datos.\n");
            }
        }
        #endregion

        #region Admin
        public List<Admin> GetAdmins()
        {
            List<Admin> admins = new List<Admin>();
            string queryAdmin = "CALL GetAdmins();";
            try
            {

                using (MySQLConn = new MySqlConnection(ConnectionDBTest.DbConnString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand(queryAdmin.ToString(), MySQLConn))
                    {

                        MySQLConn.Open();
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
                        MySQLConn.Close();
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
                using (MySQLConn = new MySqlConnection(ConnectionDBTest.DbConnString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand(queryAdmin.ToString(), MySQLConn))
                    {
                        MySQLConn.Open();
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
                        MySQLConn.Close();
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
                using (MySQLConn = new MySqlConnection(ConnectionDBTest.DbConnString()))
                {
                    //Creamos el objeto MySqlCommand que contendrá la sentencia SQL.
                    using (MySqlCommand cmd = new MySqlCommand(queryAdmin.ToString(), MySQLConn))
                    {
                        MySQLConn.Open();//Abrimos la base de datos.
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
                        MySQLConn.Close();//Cerramos la base de datos.
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
                using (MySQLConn = new MySqlConnection(ConnectionDBTest.DbConnString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand(queryAdmin.ToString(), MySQLConn))
                    {
                        MySQLConn.Open();
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
                        MySQLConn.Close();
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

