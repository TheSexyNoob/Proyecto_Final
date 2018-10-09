using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bill
    {
        public string LicensePlate { get; set; }
        public string ClientName { get; set; }
        public string AdminName { get; set; }
        public int AdminCode { get; set; }
        public int Amount { get; set; }
        public int Fare { get; set; }

        public Bill(string licensePlate, string clientName, string adminName, int adminCode, int amount, int fare)
        {
            LicensePlate = licensePlate;
            ClientName = clientName;
            AdminName = adminName;
            AdminCode = adminCode;
            Amount = amount;
            Fare = fare;
        }
    }
}
