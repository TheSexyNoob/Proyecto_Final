using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities

{
   public class Vehicule
    {
        public string LicensePlate { get; set; }
        public string Colour { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Description { get; set; } // Este será  usado en caso de que el admin vea algún daño notable del vehiculo.

        public Vehicule(string licensePlate, string colour, string model, string type, string description)
        {
            LicensePlate = licensePlate;
            Colour = colour;
            Model = model;
            Type = type;
            Description = description;
        }

        public virtual string GetSummary()
        {
            return string.Format("El vehiculo placa: {0} es un {1}, color: {2}, modelo: {3}", LicensePlate, Type, Colour, Model);
        }

        
    }
}
