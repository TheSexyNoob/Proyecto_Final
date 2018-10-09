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
        public string NombreCliente { get; set; }
        public string NombreAdmin { get; set; }
        public int CodigoAdmin { get; set; }
        public int Monto { get; set; }
        public int Tarifa { get; set; }

        public Factura(string placa, string nombreCliente, string nombreAdmin, int codigoAdmin, int monto, int tarifa)
        {
            Placa = placa;
            NombreCliente = nombreCliente;
            NombreAdmin = nombreAdmin;
            CodigoAdmin = codigoAdmin;
            Monto = monto;
            Tarifa = tarifa;

            //test
        }
    }
}
