using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Vehicule
    {
        #region Variables

        public int      Code    { get; set; }
        public string   LicensePlate { get; set; }
        public string   Colour  { get; set; }
        public string   Model   { get; set; }
        public int      Type    { get; set; }
        public string   Description { get; set; } // Este será usado en caso de que el admin vea algún daño notable del vehiculo.
        #endregion

        #region Builder
        public Vehicule (int Code, string LicensePlate, string Colour, string Model, int Type, string Description)
        {
            this.Code = Code;
            this.LicensePlate = LicensePlate;
            this.Colour = Colour;
            this.Model = Model;
            this.Type = Type;
            this.Description = Description;
        }
        #endregion

        #region Methods
        public virtual string GetSummary()
        {
            return string.Format("License Plate: {0} Type: {1}, colour: {2}, Model: {3}. Note: {4}", LicensePlate, Type, Colour, Model, Description);
        }
        #endregion

    }
}
