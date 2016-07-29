using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class EntityFactory
    {
        protected Client ClientFactory { get; set; }
        protected Account AccountFactory { get; set; }
    }
}
