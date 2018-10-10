using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingServices;

namespace SistemaPaqueo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos");

            ParkingServices.ParkingServices parking = new ParkingServices.ParkingServices();
            parking.GetAdmins();

            Console.ReadKey();
        }
    }
}
