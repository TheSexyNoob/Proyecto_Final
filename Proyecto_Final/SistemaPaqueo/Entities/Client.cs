using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Client
    {
        public int code { get; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company  { get; set; }
        public Vehicule vehicule { get; set; }

        public Client(int code, int id, string name, string company, Vehicule vehicule)
        {
            this.code = code;
            Id = id;
            Name = name;
            Company = company;
            this.vehicule = vehicule;
        }
    }
}
