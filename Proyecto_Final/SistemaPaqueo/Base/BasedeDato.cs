using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base
{
    public class BasedeDato
    {
        static List<Espacio> basesita = new List<Espacio>();

        public BasedeDato() {
            
            llenar();
        }


        public void llenar()
        {
            basesita.Add(new Espacio(1));
            basesita.Add(new Espacio(2));
            basesita.Add(new Espacio(3));
            basesita.Add(new Espacio(4));
            basesita.Add(new Espacio(5));
            basesita.Add(new Espacio(6));
        }

        public bool verifica(int id)
        {
            bool a = false;

            foreach (Espacio x in basesita)
            {
                if (id == x.IdEspacio)
                {
                    a =  x.Disponible;
                }

            }
            return a;
        }

        public string Actualiza(int id,bool valor)
        {
           
            foreach (Espacio x in basesita)
            {
                
                if (id == x.IdEspacio)
                {
                    x.Disponible = valor;
             
                }

            }
             return "Estado Actualizado";
        }


        public string Sale(int id)
        {
            foreach (Espacio x in basesita)
            {
                if (x.IdEspacio == id)
                {
                    x.Disponible = true;
                }
            }
            return "Estado Actualizado";


        }

    }
}
