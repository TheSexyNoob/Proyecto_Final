﻿using SistemaPaqueo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaParqueo
{
    class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company  { get; set; }
        public Vehiculo vehiculo { get; set; }
        

        public Client(int id, string name, string company)
        {
            Id = id;
            Name = name;
            Company = company;
        }
    }
}
