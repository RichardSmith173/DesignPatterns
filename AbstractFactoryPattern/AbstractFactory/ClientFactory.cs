using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ClientFactory : EntityFactory
    {
        public ClientFactory()
        {
            ClientFactory = new Client();
        }
    }
}
