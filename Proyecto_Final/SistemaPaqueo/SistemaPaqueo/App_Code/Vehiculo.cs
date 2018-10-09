using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPaqueo
{
   public class Vehiculo
    {
        public int    Placa { get; set; }
        public string Color { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public string Descpricion { get; set; } // Este será  usado en caso de que el admin vea algún daño notable del vehiculo.

        public Vehiculo(int placa, string color, string modelo, string tipo, int myProperty, string descpricion)
        {
            Placa = placa;
            Color = color;
            Modelo = modelo;
            Tipo = tipo;
            Descpricion = descpricion;
        }

        public virtual string GetSummary()
        {
            //return string.Format("{0}{1}", Placa, Tipo);
        }
    }
}
