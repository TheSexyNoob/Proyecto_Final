﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPaqueo
{
    class Automovil : Vehiculo
    {
        public Automovil(string placa, string color, string modelo, string tipo, string descpricion) : base(placa, color, modelo, tipo, descpricion)
        {
        }

        public override string GetSummary()
        {
            return base.GetSummary();
        }
    }
}
