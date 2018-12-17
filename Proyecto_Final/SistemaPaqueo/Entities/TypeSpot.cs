using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TypeSpot
    {
        #region Variables
        public int Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; }
        #endregion

        #region Builder
        public TypeSpot(int code, string name, char type)
        {
            Code = code;
            Name = name;
            Type = type;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("#{0}.\nEspacio de tipo: {1}. (Descripción: {2})", Code, Name, Type);
        }
        #endregion
    }
}
