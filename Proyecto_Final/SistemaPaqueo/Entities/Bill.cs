using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bill
    {

        #region Variables
        public int Code { get; set; }
        public int ParkingID { get; set; }
        public int Spot { get; set; }
        public string LicensePlate { get; set; }
        public DateTime Time_Bill { get; set; }
        public DateTime Time_Bill_Paid { get; set; }
        public int ClientID { get; set; }
        public int AdminID { get; set; }
        public char IsPaid { get; set; }
        public decimal Amount { get; set; }
        #endregion

        #region Builder
        public Bill(int code, int parkingID, int spot, string licensePlate, DateTime time_Bill, DateTime time_Bill_Paid, int clientID, int adminID, char isPaid, decimal amount)
        {
            Code = code;
            ParkingID = parkingID;
            Spot = spot;
            LicensePlate = licensePlate;
            Time_Bill = time_Bill;
            Time_Bill_Paid = time_Bill_Paid;
            ClientID = clientID;
            AdminID = adminID;
            IsPaid = isPaid;
            Amount = amount;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format(@"LA FACTURA #{0}.\n
                                   Parqueo codigo "
                                ,Code);
        }
        #endregion
    }
}
