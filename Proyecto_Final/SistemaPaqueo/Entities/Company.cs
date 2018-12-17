using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Company
    {
        #region Variables
        public int Code { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        #endregion

        #region Builder
        public Company(int code, string name, int phone)
        {
            Code = code;
            Name = name;
            Phone = phone;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("#{0}.\n Nombre de la empresa: {1}.\n Telefono: {2}.", Code, Name, Phone);
        }
        #endregion
    }
}
