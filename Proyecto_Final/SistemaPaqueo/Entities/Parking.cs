using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Parking
    {
        #region Variables
        public int Code { get; set; }
        public int Name { get; set; }
        public int Phone { get; set; }
        #endregion

        #region Builder
        public Parking(int Code, int Name, int Phone)
        {
            this.Code = Code;
            this.Name = Name;
            this.Phone = Phone;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "El Parqueo de " + Name + " #" + Code + " y telefono: " + Phone;
        }
        #endregion
    }
}
