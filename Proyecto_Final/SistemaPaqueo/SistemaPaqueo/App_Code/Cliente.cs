using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPaqueo
{
    class Cliente
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Empresa { get; set; }

        public Cliente(int cedula, string nombre, string empresa)
        {
            Cedula = cedula;
            Nombre = nombre;
            Empresa = empresa;
        }
    }
}
