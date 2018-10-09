using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base
{
    class Espacio
    {
        public Espacio(int id)
        {
            IdEspacio = id;
            Disponible = true;
        }

        public Boolean Disponible { set; get; }
       public string Placa { set; get; }
        public int IdEspacio { set; get; }
        public int hora { set; get; }

        public void actualiza(bool valor) {

            Disponible = valor;

        }
    }
}
