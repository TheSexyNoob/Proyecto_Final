using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Admin
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public int Id { get; set; }
        public int Phone { get; set; }
        public string  Mail { get; set; }

        public Admin(int code, string name, string lastName, string secondLastName, int id, int phone, string mail)
        {
            Code = code;
            Name = name;
            LastName = lastName;
            SecondLastName = secondLastName;
            Id = id;
            Phone = phone;
            Mail = mail;
        }

        public override string ToString()
        {
            return string.Format("Codigo del admin: {0}, Nombre: {1}, Apellidos: {2} {3}, cedula: {4}, Telefono: {5} y correo {6}.", Code, Name, LastName, SecondLastName, Id, Phone, Mail);

        }
    }
}
