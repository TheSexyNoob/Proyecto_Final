using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPaqueo
{
    class Admistrador
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int Cedula { get; set; }
        public string  Mail { get; set; }
        public int Codigo { get; set; }

        public Admistrador(string nombre, string apellidoPaterno, string apellidoMaterno, int cedula, string mail, int codigo)
        {
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Cedula = cedula;
            Mail = mail;
            Codigo = codigo;
        }
    }
}
