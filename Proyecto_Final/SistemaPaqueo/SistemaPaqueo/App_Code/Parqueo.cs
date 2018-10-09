using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPaqueo
{
    class Parqueo
    {
        public int Campos { get; set; }
        public int Tarifa { get; set; }
        public int Codigo { get; set; }

        public Parqueo(int campos, int tarifa, int codigo)
        {
            Campos = campos;
            Tarifa = tarifa;
            Codigo = codigo;
        }
    }
}
