using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Motocicleta : Vehicule
    {
        public Motocicleta(string placa, string color, string modelo, string tipo, string descpricion) : base(placa, color, modelo, tipo, descpricion)
        {
        }
    }
}
