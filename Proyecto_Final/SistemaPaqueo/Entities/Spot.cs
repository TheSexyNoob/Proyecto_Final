using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Spot
    {
        public int IdSpot { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsReserved { get; set; }
        public bool IsHandicapped { get; set; }

        public Spot(int idSpot, bool isAvailable, bool isReserved, bool isHandicapped)
        {
            IdSpot = idSpot;
            IsAvailable = isAvailable;
            IsReserved = isReserved;
            IsHandicapped = isHandicapped;
        }
    }
}
