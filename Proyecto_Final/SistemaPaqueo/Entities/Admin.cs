using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Admin
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public int Id { get; set; }
        public string  Mail { get; set; }
        public int Code { get; set; }

        public Admin(string name, string lastname, string secondlastname, int id, string mail, int code)
        {
            Name = name;
            LastName = lastname;
            SecondLastName = secondlastname;
            Id = id;
            Mail = mail;
            Code = code;
        }
    }
}
