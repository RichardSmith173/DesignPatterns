using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class FiredOnion : IDecorator
    {
        public decimal GetPrice()
        {
            return 0.35m;
        }
    }
}
