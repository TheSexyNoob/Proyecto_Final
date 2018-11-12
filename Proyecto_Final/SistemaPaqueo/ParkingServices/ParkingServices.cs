using Database;
using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ParkingServices
{
    public class ParkingServices : IParking
    {

        public MySqlConnection SqlConnection = new MySqlConnection(ConnectionDBTest.DbConnString());

        public List<Admin> GetAdmins()
        {
            List<Admin> admins = new List<Admin>();
            string queryAdmin = "SELECT * FROM admins;";
            using (MySqlCommand cmd = new MySqlCommand(queryAdmin, SqlConnection))
            {
                SqlConnection.Open();
                var result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Admin admin = new Admin (
                        result.GetInt32(0),
                        result.GetString(1),
                        result.GetString(2),
                        result.GetString(3),
                        result.GetInt32(4),
                        result.GetInt32(5),
                        result.GetString(6));
                    Console.WriteLine(admin.ToString());
                    admins.Add(admin);
                }
                SqlConnection.Close();
            }

            
        return admins;
        }

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
    }
}
