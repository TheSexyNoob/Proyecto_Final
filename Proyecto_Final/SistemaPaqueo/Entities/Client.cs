using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Client
    {

        #region Variables
        public int Code { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int Company { get; set; }
        #endregion

        #region Builder
        public Client(int code, int clientId, string name, int company)
        {
            Code = code;
            ClientId = clientId;
            Name = name;
            Company = company;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format(@"El cliente {0}, tiene la cedula {1}. Pertenece a {2}.", Name, ClientId, Company);
        }
        #endregion

    }
}
