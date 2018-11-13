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
        public DateTime date {get;}

        public Bill(string licensePlate, string clientName, string adminName, int adminCode, int amount, int fare)
        {
            date = DateTime.Now;
            LicensePlate = licensePlate;
            ClientName = clientName;
            AdminName = adminName;
            AdminCode = adminCode;
            Amount = amount;
            Fare = fare;
        }

        public void VehiculePayment(int placa) {

            Vehicule car = new Vehicule();//Find vehicule

            if (car.InHour.Day == car.OutHour.Day)
            {
                int parkinHours =  car.OutHour.Hour - car.InHour.Hour;
                double subTotal = 600 * parkinHours;
                double total = subTotal * (1 + 0.13);
                
            }
            else {
                int extraDays = car.OutHour.Day - car.InHour.Day;

            }

            //Showbill
            //SafeBillDB


        }
    }
}
