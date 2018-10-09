using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Parking
    {
        public int Field { get; set; }
        public int Fare { get; set; }
        public int IdCode { get; set; }

        public Parking(int field, int fare, int idCode)
        {
            Field = field;
            Fare = fare;
            IdCode = idCode;
        }
    }
}
