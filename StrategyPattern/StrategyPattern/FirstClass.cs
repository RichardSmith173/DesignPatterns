using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class FirstClass : ICalculateCost
    {
        public decimal Calculate() => 100m;
    }
}
