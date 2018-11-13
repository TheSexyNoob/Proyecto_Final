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

        public void RefreshAdminList()
        {
            
        }

        public List<Admin> GetAdmins()
        {
            List<Admin> admins = new List<Admin>();

            string queryAdmin = @"SELECT code
                                ,name
                                ,flastname
                                ,slastname
                                ,id
                                ,phone
                                ,mail
                                FROM admins;";

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

        public Boolean UserChecker(int id, string password)
        {

             string queryAdmin = "SELECT * FROM admins WHERE id="+id+";";
            using (MySqlCommand cmd = new MySqlCommand(queryAdmin, SqlConnection))
            {
                SqlConnection.Open();
                var result = cmd.ExecuteReader();
                
                if (id == result.GetInt32(4)) return true;
	     
                else return false;
                SqlConnection.Close();
            }


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

        #region Filters
        public Admin GetAdminsById(int id)
        {
            List<Admin> admins = GetAdmins(); 

            foreach (var item in admins)
            {
                if (item.Id == id) return item;
            }
            return null;
        }
        #endregion
    }
}
