using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPaqueo
{
    public class Motocicleta : Vehiculo
    {
        public Motocicleta(string placa, string color, string modelo, string tipo, string descpricion) : base(placa, color, modelo, tipo, descpricion)
        {
        }
    }
}
