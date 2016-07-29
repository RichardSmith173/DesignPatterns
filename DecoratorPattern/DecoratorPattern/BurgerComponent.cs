using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    abstract class BurgerComponent
    {
        public abstract string GetFilling();
        public abstract decimal GetPrice();

    }
}
