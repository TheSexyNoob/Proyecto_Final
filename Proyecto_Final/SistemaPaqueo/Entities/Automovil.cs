﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Automovil : Vehicule
    {
        public Automovil(string licensePlate, string colour, string model, string type, DateTime inHour, DateTime outHour, string description) : base(licensePlate, colour, model, type, inHour, outHour, description)
        {
        }
    }
}
