using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Spot
    {
        #region Variables
        public int Code     { get; set; }
        public int IdSpot   { get; set; }
        public int Type     { get; set; }
        public int Parking  { get; set; }
        public char IsAvailable { get; set; }
        public char IsReserved  { get; set; }
        #endregion
        
        #region Builder
        public Spot(int code, int idSpot, int type, int parking, char isAvailable, char isReserved)
        {
            Code = code;
            IdSpot = idSpot;
            Type = type;
            Parking = parking;
            IsAvailable = isAvailable;
            IsReserved = isReserved;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format(@"Este campo pertenece al parqueo #{0}.\n
                                   El numero del campo es {1}.\n
                                   Este campo es para {2} (1 = Automovil| 2 = Motos).\n
                                   ¿El campo esta siendo usado? {3}.\n
                                   ¿El campo fue reservado? {4}."
                                   ,Parking ,IdSpot, Type, IsAvailable ,IsReserved);
        }
        #endregion
    }
}
