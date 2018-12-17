using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TypeVehicule
    {
        #region Variables
        public int Code { get; set; }
        public string Description { get; set; }
        public decimal Fare { get; set; }
        #endregion

        #region Builder
        public TypeVehicule(int code, string description, decimal fare)
        {
            Code = code;
            Description = description;
            Fare = fare;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("#{0}.\n Tipo: {1} y Tarifa: {2}", Code, Description, Fare);
        }
        #endregion
    }
}
