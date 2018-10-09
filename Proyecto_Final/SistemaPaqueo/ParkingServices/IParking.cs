using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ParkingServices
{
    public interface IParking
    {
        /// <summary>
        /// Aqui declaramos las listas para los tipos de datos.
        /// </summary>
        List<Admin>    GetAdmins();
        List<Bill>     GetBills();
        List<Client>   GetClients();
        List<Spot>     GetSpots();
        List<Vehicule> GetVehicules();
    }
}
