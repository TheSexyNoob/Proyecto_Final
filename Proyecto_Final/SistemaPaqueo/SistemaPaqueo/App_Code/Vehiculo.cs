using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPaqueo
{
   public class Vehiculo
    {
        public string Placa { get; set; }
        public string Color { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public string Descpricion { get; set; } // Este será  usado en caso de que el admin vea algún daño notable del vehiculo.

        public Vehiculo(string placa, string color, string modelo, string tipo, string descpricion)
        {
            Placa = placa;
            Color = color;
            Modelo = modelo;
            Tipo = tipo;
            Descpricion = descpricion;
        }

        public virtual string GetSummary()
        {
            return string.Format("El vehiculo placa: {0} es un {1}, color: {2}, modelo: {3}", Placa, Tipo, Color, Modelo);
        }
    }
}
