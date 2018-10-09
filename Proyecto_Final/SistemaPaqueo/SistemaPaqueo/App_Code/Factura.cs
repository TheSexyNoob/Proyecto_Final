using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPaqueo
{
    class Factura
    {
        public string Placa { get; set; }

        public int Monto { get; set; }
       

        public Factura(int monto)
        {
            Monto = monto;
        
        }
    }
}
