using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities

{
    public class Vehicule
    {
        public Vehicule(string licensePlate, string colour, string model, string type, DateTime inHour, DateTime outHour, string description)
        {
            LicensePlate = licensePlate;
            Colour = colour;
            Model = model;
            Type = type;
            InHour = inHour;
            OutHour = outHour;
            Description = description;
        }

        public string LicensePlate { get; set; }
        public string Colour { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public DateTime InHour{get; set;}
        public DateTime OutHour { get; set; }
        public string Description { get; set; } // Este será usado en caso de que el admin vea algún daño notable del vehiculo.

        public virtual string GetSummary()
        {
            return string.Format("El vehiculo placa: {0} es un {1}, color: {2}, modelo: {3}. Al ingresar se hizo la siguiente anotación: {4}", LicensePlate, Type, Colour, Model, Description);
        }

        
    }
}
