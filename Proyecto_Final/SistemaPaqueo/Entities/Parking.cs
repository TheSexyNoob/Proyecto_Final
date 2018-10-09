using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Parking
    {
        public int Spot { get; set; }
        public int Fare { get; set; }
        public int IdCode { get; set; }

        public Parking(int spot, int fare, int idCode)
        {
            Spot = spot;
            Fare = fare;
            IdCode = idCode;
        }
    }
}
