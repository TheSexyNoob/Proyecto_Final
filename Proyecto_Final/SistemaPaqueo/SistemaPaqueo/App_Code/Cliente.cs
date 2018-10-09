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

        public Cliente(int cedula, string nombre)
        {
            Cedula = cedula;
            Nombre = nombre;
        }
    }
}
