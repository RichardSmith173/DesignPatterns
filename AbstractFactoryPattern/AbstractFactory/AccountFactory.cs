using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AccountFactory : EntityFactory
    {
        public AccountFactory()
        {
            AccountFactory = new Account();
        }
    }
}
