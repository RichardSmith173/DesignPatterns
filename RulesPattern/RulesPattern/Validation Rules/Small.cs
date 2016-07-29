using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesPattern
{
    public class Small : ICalculate
    {
        public bool Calculate(decimal value)
        {
            return value > 5;
        }
    }
}
